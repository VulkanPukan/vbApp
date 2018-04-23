Imports System.Data.SqlClient
Imports System.IO
Public Class fmVendorNet
    Inherits fmStarter
    Dim dsShip As New DataSet
    Dim cmd As New SqlCommand

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents bShipping As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bImport As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.bShipping = New Infragistics.Win.Misc.UltraButton
        Me.bImport = New Infragistics.Win.Misc.UltraButton
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.Location = New System.Drawing.Point(504, 8)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(440, 536)
        Me.Grid1.TabIndex = 0
        '
        'bShipping
        '
        Me.bShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bShipping.Location = New System.Drawing.Point(16, 16)
        Me.bShipping.Name = "bShipping"
        Me.bShipping.Size = New System.Drawing.Size(216, 40)
        Me.bShipping.TabIndex = 1
        Me.bShipping.Text = "Send Shipping Notifications"
        '
        'bImport
        '
        Me.bImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bImport.Location = New System.Drawing.Point(16, 64)
        Me.bImport.Name = "bImport"
        Me.bImport.Size = New System.Drawing.Size(216, 40)
        Me.bImport.TabIndex = 2
        Me.bImport.Text = "Import Orders"
        '
        'fmVendorNet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(952, 550)
        Me.Controls.Add(Me.bImport)
        Me.Controls.Add(Me.bShipping)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "fmVendorNet"
        Me.Text = "Vendor Net"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmVendorNet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        Try
            cmd.Connection = cnn
            Dim da As New SqlDataAdapter

            'cmd.CommandText = "select ship_serial,ship_date,ship_via,ship_ord_serial,ship_ord_rev,ord_sold_cust_id,ship_track,ord_gen_cust_po,ord_gen_total,ord_gen_ship,ord_gen_from_rev,ord_gen_ship_date from ship_file,ord_file,cust_file,ord_gen where ship_ord_serial=ord_serial and ord_sold_cust_id=cust_id and ship_ord_serial=ord_gen_ord_serial and ship_ord_rev=ord_gen_rev and cust_vendornet=1 and isnull(ship_vendornet,0)=0 and ship_date>'2/1/06' and ord_gen_type='O' and ship_via<>'STAGED' order by ship_ord_serial,ship_ord_rev"
            cmd.CommandText = "select cust_id,ord_gen_ord_serial,ord_gen_from_rev,ord_gen_rev,ord_gen_cust_po,ord_gen_ship_date,ord_gen_total,ord_gen_ship,ord_gen_serial from ord_gen,ord_file,cust_file where ord_gen_ord_serial=ord_serial and ord_sold_cust_serial=cust_serial and ord_gen_type='O' and ord_gen_status='SHIPPED' and ord_gen_ship_date>='4/7/2006' and isnull(ord_gen_vend_net_date,'1/1/1900')='1/1/1900' and isnull(cust_vendornet,0)=1"
            da.SelectCommand = cmd
            cnn.Open()
            dsShip.Clear()
            da.Fill(dsShip, "ship")
            cnn.Close()
            Grid1.DataSource = dsShip
            Grid1.DataBind()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Private Sub bShipping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bShipping.Click
        bShipping.Enabled = False
        Dim fl As StreamWriter
        Dim row, itm As DataRow
        Dim ln, lnTemp As String
        Dim dr As SqlDataReader
        Dim CustPo, Part, onOrdRev As String
        Dim dsItems As New DataSet
        Dim da As New SqlDataAdapter(cmd)

        Try
            If File.Exists(Jcom.Path + "VendorNet\Shipments " + Format(Date.Today, "yyyy-MM-dd") + ".txt") Then
                Dim cnt As Integer = 1
                Do While File.Exists(Jcom.Path + "VendorNet\Shipments " + Format(Date.Today, "yyyy-MM-dd") + "(" + CStr(cnt) + ").txt")
                    cnt = cnt + 1
                Loop
                fl = New StreamWriter(Jcom.Path + "VendorNet\Shipments " + Format(Date.Today, "yyyy-MM-dd") + "(" + CStr(cnt) + ").txt")
            Else
                fl = New StreamWriter(Jcom.Path + "VendorNet\Shipments " + Format(Date.Today, "yyyy-MM-dd") + ".txt")
            End If

            cnn.Open()
            onOrdRev = ""
            For Each row In dsShip.Tables("ship").Rows
                If onOrdRev <> CStr(row("ord_gen_ord_serial")) + "-" + CStr(row("ord_gen_rev")) Then
                    If onOrdRev <> "" Then
                        ln = "TR" + CustPo
                        fl.WriteLine(ln)
                    End If
                    ln = "HD"
                    'cmd.CommandText = "select ord_gen_cust_po,ord_gen_total,ord_gen_ship from ord_gen where ord_gen_ord_serial=" + CStr(row("ship_ord_serial")) + " and ord_gen_rev=" + CStr(row("ship_ord_rev")) + " and ord_gen_type='O'"
                    'dr = cmd.ExecuteReader
                    'dr.Read()
                    CustPo = AddSpace(nz(row("ord_gen_cust_po"), ""), 15)
                    ln = ln + CustPo
                    ln = ln + Format(row("ord_gen_ship_date"), "yyyyMMdd")
                    'ln = ln + Space(20)
                    'ln = ln + Format(row("ord_gen_ship_date"), "yyyyMMdd")
                    ln = ln + AddSpace(CStr(row("ord_gen_ord_serial")) + "-" + CStr(row("ord_gen_from_rev")) + "-" + CStr(row("ord_gen_rev")), 20)
                    ln = ln + Format(nz(row("ord_gen_total"), 0), "000000000.00")
                    ln = ln + Format(nz(row("ord_gen_ship"), 0), "000000000.00")
                    'ln = ln + "        0.00"
                    fl.WriteLine(ln)
                    'dr.Close()
                    onOrdRev = CStr(row("ord_gen_ord_serial")) + "-" + CStr(row("ord_gen_rev"))
                End If
                'ln = "PL"
                'ln = ln + AddSpace(CustPo, 15)
                'ln = ln + AddSpace(nz(row("ship_track"), ""), 30)
                'ln = ln + AddSpace(nz(row("ship_via"), ""), 20)
                'ln = ln + "        0.00"
                'fl.WriteLine(ln)

                cmd.CommandText = "select *,itm_convert_cust_part from ord_itm left outer join itm_convert on ord_itm_item_code=itm_convert_part where ord_itm_ord_serial=" + CStr(row("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(row("ord_gen_rev")) + " and ord_itm_type='O'"
                'dr = cmd.ExecuteReader
                dsItems.Clear()
                da.Fill(dsItems, "itm")
                For Each itm In dsItems.Tables("itm").Rows
                    If nz(itm("itm_convert_cust_part"), itm("ord_itm_item_code")) <> "" Then
                        ln = "PD"
                        ln = ln + CustPo
                        ln = ln + AddSpace(nz(itm("itm_convert_cust_part"), itm("ord_itm_item_code")), 20)
                        ln = ln + AddSpace(CStr(itm("ord_itm_qty")), 6)
                        ln = ln + Format(itm("ord_itm_unt_sell"), "000000000.00")
                        fl.WriteLine(ln)

                        cmd.CommandText = "select ship_track,ship_via from ship_itm,ship_file where ship_itm_ship_serial=ship_serial and ship_ord_serial=" + CStr(row("ord_gen_ord_serial")) + " and ship_ord_rev=" + CStr(row("ord_gen_rev")) + " and ship_itm_code='" + itm("ord_itm_item_code") + "' and ship_via<>'STAGED'"
                        dr = cmd.ExecuteReader
                        If dr.HasRows = True Then
                            Do While dr.Read
                                ln = "PL"
                                ln = ln + CustPo
                                ln = ln + AddSpace(dr("ship_track"), 30)
                                ln = ln + AddSpace(dr("ship_via"), 20)
                                fl.WriteLine(ln)
                            Loop
                        End If
                        dr.Close()
                    End If
                Next
                'cmd.CommandText = "update ship_file set ship_vendornet=1,ship_vendornet_date='" + CStr(Today) + "' where ship_serial=" + CStr(row("ship_serial"))
                'cmd.ExecuteNonQuery()
                cmd.CommandText = "update ord_gen set ord_gen_vend_net_date='" + CStr(Now) + "' where ord_gen_serial=" + CStr(row("ord_gen_serial"))
                cmd.ExecuteNonQuery()
            Next
            ln = "TR" + CustPo
            fl.WriteLine(ln)
        Catch
            DoError(Err, MainForm)
        Finally
            fl.Close()
            cnn.Close()
            LoadGrid()
            bShipping.Enabled = True
        End Try
    End Sub
    Private Function AddSpace(ByVal x As String, ByVal lenx As Integer)
        x = Mid(x, 1, lenx)
        AddSpace = x + Space(lenx - Len(x))
    End Function

    Private Sub bImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImport.Click
        Dim fld As New OpenFileDialog

        If fld.ShowDialog() = DialogResult.OK Then
            Dim fl As New IO.StreamReader(fld.FileName)
            Dim ln As String
            Dim onPO, sqlx As String
            Dim onOrd As Long
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            cmd.Connection = cnn

            cnn.Open()
            ln = fl.ReadLine
            Do While ln <> Nothing
                Select Case Mid(ln, 1, 2)
                    Case "HD"
                        cmd.CommandText = "select * from cust_file where cust_id='WE'"
                        dr = cmd.ExecuteReader
                        dr.Read()
                        sqlx = "(ord_rev,ord_for,ord_sold_cust_id,ord_sold_cust_serial,ord_sold_company,ord_sold_country,ord_sold_addr1,ord_sold_addr2,ord_sold_addr3,ord_sold_city,ord_sold_state,ord_sold_zip,ord_sold_county) "
                        sqlx = "values (0,'End Cusomter PO: " + Trim(Mid(ln, 94, 20)) + "','WE'," + CStr(dr("cust_serial")) + ",'" + dr("cust_company") + "','" + dr("cust_country") + "','" + nz(dr("cust_addr1")) + "','" + nz(dr("cust_addr2")) + "','" + nz(dr("cust_addr3")) + "','" + nz(dr("cust_city")) + "','" + nz(dr("cust_state")) + "','" + nz(dr("cust_zip")) + "','" + nz(dr("cust_county")) + "')"
                        dr.Close()
                        cmd.CommandText = "insert into ord_file " + sqlx
                        cmd.CommandText = "select @@identity"
                        onOrd = cmd.ExecuteScalar

                        sqlx = "(ord_gen_ord_serial,ord_gen_type,ord_gen_rev,ord_gen_show_date,ord_gen_create_date) values"
                        sqlx = sqlx + "(" + CStr(onOrd) + ",'O',0,'" + CStr(Today) + "','" + CStr(Today) + "')"
                        cmd.CommandText = "insert into ord_gen " + sqlx
                        cmd.ExecuteNonQuery()
                    Case "BT"

                    Case "ST"
                        sqlx = "ord_ship_company='" + Trim(Mid(ln, 19, 35)) + "',"
                        sqlx = sqlx + "ord_ship_name='" + Trim(Mid(ln, 66, 35)) + "',"
                        sqlx = sqlx + "ord_ship_addr1='" + Trim(Mid(ln, 174, 35)) + "',"
                        sqlx = sqlx + "ord_ship_addr2='" + Trim(Mid(ln, 102, 35)) + "',"
                        sqlx = sqlx + "ord_ship_addr3='" + Trim(Mid(ln, 138, 35)) + "',"
                        sqlx = sqlx + "ord_ship_city='" + Trim(Mid(ln, 210, 20)) + "',"
                        sqlx = sqlx + "ord_ship_state='" + Trim(Mid(ln, 231, 2)) + "',"
                        sqlx = sqlx + "ord_ship_zip='" + Trim(Mid(ln, 234, 9)) + "',"
                        sqlx = sqlx + "ord_ship_country='" + Trim(Mid(ln, 261, 20)) + "',"
                        sqlx = sqlx + "ord_ship_phone1='" + Trim(Mid(ln, 244, 16)) + "'"
                        cmd.CommandText = "update ord_file set " + sqlx + " where ord_serial=" + CStr(onOrd)
                        cmd.ExecuteNonQuery()
                    Case "PD"
                        sqlx = "(ord_itm_ord_serial,ord_item_type,ord_itm_rev,ord_itm_item_code,ord_itm_desc,ord_itm_qty,ord_itm_unt_sell) values "
                        sqlx = sqlx + "(" + CStr(onOrd) + ",'O',0,'" + Trim(Mid(ln, 54, 20)) + "','" + Trim(Mid(ln, 96, 100)) + "'," + Trim(Mid(ln, 26, 9)) + "," + Trim(Mid(ln, 39, 14)) + ")"
                        cmd.CommandText = "insert into ord_itm " + sqlx
                        cmd.ExecuteNonQuery()
                End Select
                ln = fl.ReadLine
            Loop
            cnn.Close()
        End If
    End Sub
End Class
