Imports System.Data.SqlClient
Public Class fmShipSelect
    Inherits WineCellar.fmStarter
    Dim ShipTop As Integer = 3
    Dim LastTop As Integer = 3
    Dim ddShip As New ComboBox
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
    Friend WithEvents pToBe As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents pShip As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tCopies As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pToBe = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.pShip = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.tCopies = New System.Windows.Forms.NumericUpDown
        Me.pToBe.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pToBe
        '
        Me.pToBe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pToBe.AutoScroll = True
        Me.pToBe.Controls.Add(Me.Panel2)
        Me.pToBe.Location = New System.Drawing.Point(8, 24)
        Me.pToBe.Name = "pToBe"
        Me.pToBe.Size = New System.Drawing.Size(500, 696)
        Me.pToBe.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel2.Controls.Add(Me.UltraButton1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(8, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 48)
        Me.Panel2.TabIndex = 0
        Me.Panel2.Visible = False
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(304, 0)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(40, 32)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = ">>>"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "asdfasdf asdfasdf asdfasd fasdfas dfasdfa sdfasdf asdf"
        '
        'pShip
        '
        Me.pShip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pShip.AutoScroll = True
        Me.pShip.Location = New System.Drawing.Point(512, 24)
        Me.pShip.Name = "pShip"
        Me.pShip.Size = New System.Drawing.Size(500, 656)
        Me.pShip.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(472, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Orders Available to Ship"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(512, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(472, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Orders Set to Ship"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'UltraButton2
        '
        Me.UltraButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton2.Location = New System.Drawing.Point(512, 688)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(144, 32)
        Me.UltraButton2.TabIndex = 4
        Me.UltraButton2.Text = "Print Order to Ship"
        '
        'tCopies
        '
        Me.tCopies.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCopies.Location = New System.Drawing.Point(664, 688)
        Me.tCopies.Name = "tCopies"
        Me.tCopies.Size = New System.Drawing.Size(56, 26)
        Me.tCopies.TabIndex = 5
        Me.tCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'fmShipSelect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.tCopies)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pShip)
        Me.Controls.Add(Me.pToBe)
        Me.Controls.Add(Me.Label3)
        Me.Name = "fmShipSelect"
        Me.pToBe.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.tCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmShipSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ddShip.Items.Add("Send To Dock")
        ddShip.Items.Add("FEDEX2DY")
        ddShip.Items.Add("FEDEX3")
        ddShip.Items.Add("FEDEXGRND")
        ddShip.Items.Add("FEDEXSO")
    End Sub
    Private Sub LoadGrid()
        Dim cmd As New SqlCommand("SELECT DISTINCT ord_gen_serial,ord_gen.ord_gen_ord_serial, ord_gen.ord_gen_from_rev,ord_gen.ord_gen_rev, ord_gen.ord_gen_toship FROM ord_file LEFT OUTER JOIN ord_gen ON ord_file.ord_serial = ord_gen.ord_gen_ord_serial LEFT OUTER JOIN ord_itm ON ord_gen.ord_gen_ord_serial = ord_itm.ord_itm_ord_serial AND ord_gen.ord_gen_rev = ord_itm.ord_itm_rev AND ord_gen.ord_gen_type = ord_itm.ord_itm_type WHERE (ord_gen.ord_gen_type = 'O') AND (ord_gen.ord_gen_status <> 'SHIPPED') AND (ord_itm.ord_itm_prod_type = 'KIT') AND (ord_gen.ord_gen_status <> 'CANCELED') and ord_gen_balance=0 ORDER BY ord_gen.ord_gen_ord_serial, ord_gen.ord_gen_rev", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim rw As DataRow

        ShipTop = 3
        LastTop = 3
        pShip.Controls.Clear()
        pToBe.Controls.Clear()
        cnn.Open()
        da.Fill(ds)
        cnn.Close()

        For Each rw In ds.Tables(0).Rows
            If nz(rw("ord_gen_toship"), CDate("12/31/2099")) <= Today And nz(rw("ord_gen_toship"), CDate("12/31/2099")) > CDate("1/1/1900") Then
                GetShipPanel(rw("ord_gen_serial"))
            Else
                GetToBePanel(rw("ord_gen_serial"))
            End If
        Next
    End Sub
    Private Sub OrderClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim doit As Boolean = False
        Dim tall As Integer
        Dim ct As Control
        Dim ct2 As Control
        Dim bt As Infragistics.Win.Misc.UltraButton = sender
        Dim cmd As New SqlCommand("", cnn)
        Dim dd As ComboBox
        Dim tb As TextBox

        If bt.Text = ">>>" Then
            dd = GetControl(bt.Parent.Controls, "dd" + Mid(bt.Parent.Name, 2))
            tb = GetControl(bt.Parent.Controls, "tb" + Mid(bt.Parent.Name, 2))
            If dd.Text = "" Then
                MsgBox("You must first pick a shipping method", MsgBoxStyle.Information, "Ship Via?")
                dd.Focus()
                Exit Sub
            End If
            For Each ct In pToBe.Controls
                If doit = False Then
                    If ct.Name = bt.Parent.Name Then
                        cmd.CommandText = "update ord_gen set ord_gen_toship='" + tb.Text + "',ord_gen_toshipvia='" + dd.Text + "' where ord_gen_serial=" + Mid(ct.Name, 2)
                        cnn.Open()
                        cmd.ExecuteNonQuery()
                        cnn.Close()

                        Dim sp As New Panel
                        sp = GetShipPanel(Mid(ct.Name, 2))
                        tall = ct.Height + 3
                        ct2 = ct
                        ct.Visible = False
                        doit = True
                        LastTop -= (ct.Height + 3)
                    End If
                Else
                    If Not ct Is Nothing Then ct.Top = ct.Top - tall
                End If
            Next
            ct2.Controls.Clear()
            ct2.Dispose()
        End If
        If bt.Text = "<<<" Then
            For Each ct In pShip.Controls
                If doit = False Then
                    If ct.Name = bt.Parent.Name Then
                        Dim sp As New Panel
                        sp = GetToBePanel(CLng(Mid(ct.Name, 2)))
                        tall = ct.Height + 3
                        ct2 = ct
                        ct.Visible = False
                        doit = True
                        ShipTop -= (ct.Height + 3)
                        cmd.CommandText = "update ord_gen set ord_gen_toship=null where ord_gen_serial=" + Mid(ct.Name, 2)
                        cnn.Open()
                        cmd.ExecuteNonQuery()
                        cnn.Close()
                    End If
                Else
                    If Not ct Is Nothing Then ct.Top = ct.Top - tall
                End If
            Next

            ct2.Controls.Clear()
            ct2.Dispose()
        End If
    End Sub
    Private Function GetToBePanel(ByVal OrdGenSerial As Long) As Panel
        Dim pCnt As Integer = 0
        Dim iCnt As Integer
        Dim dr As SqlDataReader
        Dim name As String
        Dim cmd As New SqlCommand("", cnn)
        Dim Ord As String
        Dim ShipZip As String = ""

        cnn.Open()
        cmd.CommandText = "select ord_sold_company,ord_ship_state,ord_ship_zip,ord_sold_name,ord_itm_item_code,ord_itm_desc,ord_itm_qty,ord_itm_prod_type,ord_gen_ord_serial,ord_gen_from_rev,ord_gen_rev,ord_ship_zip from ord_file,ord_gen,ord_itm where ord_serial=ord_gen_ord_serial and ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev=ord_itm_rev and ord_gen_type=ord_itm_type and ord_gen_serial=" + CStr(OrdGenSerial)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            iCnt = 1
            dr.Read()
            If ShipZip = "" Then ShipZip = nz(dr("ord_ship_zip"))
            Ord = CStr(dr("ord_gen_ord_serial")) + "-" + CStr(dr("ord_gen_from_rev")) + "-" + CStr(dr("ord_gen_rev"))

            Dim pn As New Panel
            pn.Parent = pToBe
            pn.Height = 36
            pn.Width = 472
            pn.Visible = True
            pn.Location = New Point(0, LastTop + pToBe.AutoScrollPosition.Y)
            pn.BackColor = Color.LightGoldenrodYellow
            pn.Name = "p" + CStr(OrdGenSerial)

            If nz(dr("ord_sold_company")) <> "" Then
                name = dr("ord_sold_company")
            Else
                name = nz(dr("ord_sold_name"))
            End If

            Dim lb As New Label
            lb.Parent = pn
            lb.Height = 20
            lb.Width = 100
            lb.Font = New Font(lb.Font, lb.Font.Style Or FontStyle.Bold)
            lb.Font = New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
            lb.Text = Ord
            lb.Cursor = Cursors.Hand
            AddHandler lb.Click, AddressOf Order_Click

            lb = New Label
            lb.Parent = pn
            lb.Height = 20
            lb.Width = 300
            lb.Left = 105
            'lb.Font = New Font(lb.Font, lb.Font.Style Or FontStyle.Bold)
            lb.Font = New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
            lb.Text = name

            lb = New Label
            lb.Parent = pn
            lb.Height = 14
            lb.Width = 100
            lb.Top = 20
            lb.Left = 105
            lb.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
            lb.Text = " (" + nz(dr("ord_ship_state")) + ", " + nz(dr("ord_ship_zip")) + ")"
            pn.Height += 14

            Do
                lb = New Label
                lb.Parent = pn
                lb.Height = 14
                lb.Width = 370
                lb.Top = (14 * iCnt) + 28
                lb.Text = "(" + CStr(nz(dr("ord_itm_qty"), 0)) + ") " + nz(dr("ord_itm_item_code")) + " " + nz(dr("ord_itm_desc"))
                If nz(dr("ord_itm_prod_type")) <> "KIT" Then lb.Font = New Font(lb.Font, lb.Font.Style Or FontStyle.Bold)
                pn.Height += 14
                iCnt += 1
            Loop Until dr.Read = Nothing
            dr.Close()

            Dim dd As New ComboBox
            Dim itm As Object
            For Each itm In ddShip.Items
                dd.Items.Add(itm)
            Next
            dd.Parent = pn
            dd.Left = 210
            dd.Top = 20
            dd.Height = 14
            dd.Width = 100
            dd.Name = "dd" + CStr(OrdGenSerial)
            cmd.CommandText = "select zip_zone from zip_zone where '" + Mid(ShipZip, 1, 3) + "'>=zip_zone_start and '" + Mid(ShipZip, 1, 3) + "' <= zip_zone_end"
            Select Case nz(cmd.ExecuteScalar)
                Case "1"
                    dd.Text = "FEDEX2DY"
                Case "2"
                    dd.Text = "FEDEX2DY"
                Case "3"
                    dd.Text = "Send To Dock"
            End Select

            Dim tb As New TextBox
            tb.Parent = pn
            tb.Left = 325
            tb.Top = 20
            tb.Height = 14
            tb.Width = 75
            tb.Name = "tb" + CStr(OrdGenSerial)
            tb.Text = CStr(Today)

            Dim bt As New Infragistics.Win.Misc.UltraButton
            bt.Parent = pn
            bt.Text = ">>>"
            bt.Left = 425
            bt.Top = 8
            bt.Height = 40
            bt.Width = 40
            bt.Tag = CStr(OrdGenSerial)
            AddHandler bt.Click, AddressOf OrderClick

            pCnt += 1
            LastTop = pn.Top + pn.Height + 3 + pToBe.AutoScrollPosition.Y
        End If
        cnn.Close()
    End Function
    Private Function GetShipPanel(ByVal OrdGenSerial As Long) As Panel
        Dim pCnt As Integer = 0
        Dim cmd As New SqlCommand("", cnn)
        Dim dr As SqlDataReader
        Dim iCnt As Integer
        Dim Ord As String
        Dim Name As String

        cnn.Open()
        cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_from_rev,ord_gen_rev,ord_sold_company,ord_sold_name,ord_itm_item_code,ord_itm_desc,ord_itm_qty,ord_itm_prod_type,ord_gen_toshipvia,ord_gen_toship from ord_file,ord_gen,ord_itm where ord_serial=ord_gen_ord_serial and ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev=ord_itm_rev and ord_gen_type=ord_itm_type and ord_gen_serial=" + CStr(OrdGenSerial)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            iCnt = 1
            dr.Read()
            Ord = CStr(dr("ord_gen_ord_serial")) + "-" + CStr(dr("ord_gen_from_rev")) + "-" + CStr(dr("ord_gen_rev"))

            Dim pn As New Panel
            pn.Parent = pShip
            pn.Height = 45
            pn.Width = 472
            pn.Visible = True
            pn.Top = ShipTop
            pn.BackColor = Color.PaleGoldenrod
            pn.Name = "s" + CStr(OrdGenSerial)

            If nz(dr("ord_sold_company")) <> "" Then
                Name = dr("ord_sold_company")
            Else
                Name = nz(dr("ord_sold_name"))
            End If

            Dim lb As New Label
            lb.Parent = pn
            lb.Height = 20
            lb.Width = 100
            lb.Font = New Font(lb.Font, lb.Font.Style Or FontStyle.Bold)
            lb.Font = New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
            lb.Text = Ord
            lb.Cursor = Cursors.Hand
            AddHandler lb.Click, AddressOf Order_Click

            lb = New Label
            lb.Parent = pn
            lb.Height = 20
            lb.Width = 300
            lb.Left = 105
            'lb.Font = New Font(lb.Font, lb.Font.Style Or FontStyle.Bold)
            lb.Font = New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
            lb.Text = Name

            lb = New Label
            lb.Parent = pn
            lb.Height = 14
            lb.Width = 300
            lb.Left = 105
            lb.Top = 20
            'lb.Font = New Font(lb.Font, lb.Font.Style Or FontStyle.Bold)
            lb.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
            lb.Text = "Ship Via: " + nz(dr("ord_gen_toshipvia")) + " on " + CStr(nz(dr("ord_gen_toship"), "(Unknown)"))

            Do
                lb = New Label
                lb.Parent = pn
                lb.Height = 14
                lb.Width = 370
                lb.Top = (14 * iCnt) + 28
                lb.Text = "(" + CStr(nz(dr("ord_itm_qty"), 0)) + ") " + nz(dr("ord_itm_item_code")) + " " + nz(dr("ord_itm_desc"))
                If nz(dr("ord_itm_prod_type")) <> "KIT" Then lb.Font = New Font(lb.Font, lb.Font.Style Or FontStyle.Bold)
                pn.Height += 14
                iCnt += 1
            Loop Until dr.Read = Nothing
            dr.Close()

            Dim bt As New Infragistics.Win.Misc.UltraButton
            bt.Parent = pn
            bt.Text = "<<<"
            bt.Left = 425
            bt.Top = 8
            bt.Height = 40
            bt.Width = 40
            AddHandler bt.Click, AddressOf OrderClick

            pCnt += 1
            ShipTop = pn.Top + pn.Height + 3
        End If
        cnn.Close()
    End Function
    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click

    End Sub

    Private Sub Order_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim fm As fmEstOrd2
        Dim lb As Label

        lb = sender
        fm = LoadForm("Quotes/Orders")
        If fm.EditMode <> "" Then
            MsgBox("You must first save or cancel this Quote/Order", MsgBoxStyle.Information, "Save?")
            fm = Nothing
            Exit Sub
        End If
        fm.KeyValue1 = Split(lb.Text, "-")(0)
        fm.tOrd.Text = fm.KeyValue1
        fm.LoadPage()
        fm.Tab1.Tabs("O" + Split(lb.Text, "-")(2)).Selected = True
        fm.TabItems.Tabs("General").Selected = True

    End Sub
    Private Sub Ship_Change(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub fmShipSelect_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        LoadGrid()

    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        UltraButton2.Enabled = False
        DisplayReport("orders to ship", , False, CInt(tCopies.Value))
        UltraButton2.Enabled = True
    End Sub
End Class
