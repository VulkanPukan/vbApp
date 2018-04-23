Public Class fmItemPricing
    Inherits System.Windows.Forms.Form
    Dim dsCust As New DataSet

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
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents ddCust As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Bar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents bRun As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbInclude As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.ddCust = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Bar1 = New System.Windows.Forms.ProgressBar
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.tDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.bRun = New Infragistics.Win.Misc.UltraButton
        Me.cbInclude = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        CType(Me.ddCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(8, 8)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "General Pricing"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(8, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Customer Pricing"
        '
        'ddCust
        '
        Me.ddCust.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ddCust.DisplayMember = ""
        Me.ddCust.Enabled = False
        Me.ddCust.Location = New System.Drawing.Point(136, 40)
        Me.ddCust.Name = "ddCust"
        Me.ddCust.Size = New System.Drawing.Size(288, 21)
        Me.ddCust.TabIndex = 2
        Me.ddCust.ValueMember = ""
        '
        'Bar1
        '
        Me.Bar1.Location = New System.Drawing.Point(8, 240)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(520, 16)
        Me.Bar1.TabIndex = 3
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(72, 80)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "As of"
        '
        'tDate
        '
        Me.tDate.Location = New System.Drawing.Point(136, 72)
        Me.tDate.Name = "tDate"
        Me.tDate.Size = New System.Drawing.Size(112, 21)
        Me.tDate.TabIndex = 5
        '
        'bRun
        '
        Me.bRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRun.Location = New System.Drawing.Point(136, 112)
        Me.bRun.Name = "bRun"
        Me.bRun.Size = New System.Drawing.Size(176, 32)
        Me.bRun.TabIndex = 6
        Me.bRun.Text = "Run Report"
        '
        'cbInclude
        '
        Me.cbInclude.Location = New System.Drawing.Point(136, 152)
        Me.cbInclude.Name = "cbInclude"
        Me.cbInclude.Size = New System.Drawing.Size(264, 16)
        Me.cbInclude.TabIndex = 7
        Me.cbInclude.Text = "Include lacquer bottles and install minutes"
        '
        'fmItemPricing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 266)
        Me.Controls.Add(Me.cbInclude)
        Me.Controls.Add(Me.bRun)
        Me.Controls.Add(Me.tDate)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.ddCust)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Name = "fmItemPricing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Pricing"
        CType(Me.ddCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmItemPricing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDD(ddCust, dsCust, "cust_file", "cust_serial", "cust_id", "cust_serial,cust_id,cust_name", , True, "cust_id")
        tDate.Value = Today
    End Sub

    Public Sub GetGeneral()
        Try
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim cmd As New SqlClient.SqlCommand
            Dim dr As DataRow
            Dim ds As New DataSet
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim base, md, con, retail, ship, install As Double
            Dim cnt As Long = 0

            cmd.Connection = cnn

            cnn.Open()
            cmd.CommandText = "delete from item_price where item_user='" + User + "'"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "select * from itm_file"
            da.Fill(ds, "itm")
            For Each dr In ds.Tables(0).Rows
                cnt = cnt + 1
                If nz(dr("inactive"), 0) <> True Then
                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='BASE' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                    base = nz(cmd.ExecuteScalar, 0)

                    If nz(dr("itm_flat_rate"), False) = True Then
                        md = base
                    Else
                        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='MD' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                        md = nz(cmd.ExecuteScalar, 0)
                        If md = 0 Then
                            cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + nz(dr("itm_prod_type")) + "' and sales_cat_prod_mar_cat='MD' and sales_cat_prod_mar_start<='" + CStr(tDate.Value) + "' and sales_cat_prod_mar_end>='" + CStr(tDate.Value) + "'"
                            md = nz(cmd.ExecuteScalar, 0)
                            md = md * base
                        End If
                    End If

                    If nz(dr("itm_flat_rate"), False) = True Then
                        con = base
                    Else
                        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='CON' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                        con = nz(cmd.ExecuteScalar, 0)
                        If con = 0 Then
                            cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + nz(dr("itm_prod_type")) + "' and sales_cat_prod_mar_cat='CON' and sales_cat_prod_mar_start<='" + CStr(tDate.Value) + "' and sales_cat_prod_mar_end>='" + CStr(tDate.Value) + "'"
                            con = nz(cmd.ExecuteScalar, 0)
                            con = con * base
                        End If
                    End If

                    If nz(dr("itm_flat_rate"), False) = True Then
                        retail = base
                    Else
                        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='RET' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                        retail = nz(cmd.ExecuteScalar, 0)
                        If retail = 0 Then
                            cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + nz(dr("itm_prod_type")) + "' and sales_cat_prod_mar_cat='RET' and sales_cat_prod_mar_start<='" + CStr(tDate.Value) + "' and sales_cat_prod_mar_end>='" + CStr(tDate.Value) + "'"
                            retail = nz(cmd.ExecuteScalar, 0)
                            retail = retail * base
                        End If
                    End If

                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='SHIP' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                    ship = nz(cmd.ExecuteScalar, 0)

                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='Install' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                    install = nz(cmd.ExecuteScalar, 0)

                    cmd.CommandText = "insert into item_price (item_user,item_cust,item_code,item_desc,base,md,con,ret,ship,install) values ('" + User + "','GEN','" + nz(dr("itm_code")) + "','" + Replace(nz(dr("itm_desc")), "'", "''") + "'," + CStr(base) + "," + CStr(md) + "," + CStr(con) + "," + CStr(retail) + "," + CStr(ship) + "," + CStr(install) + ")"
                    cmd.ExecuteNonQuery()
                End If
                Bar1.Value = cnt / ds.Tables("itm").Rows.Count * 100
            Next
            cnn.Close()
        Catch
            MsgBox(Err.Description)
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
            cnn.Close()
        End Try
        If Me.cbInclude.Checked Then
            DisplayReport("Item Pricing by margin with install", , True, 1, User, tDate.Value, True)
        Else
            DisplayReport("Item Pricing by margin", , True, 1, User, tDate.Value, True)
        End If
        Me.Close()
    End Sub
    Private Sub GetCustomer()
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim cmd As New SqlClient.SqlCommand
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim base, md, con, retail, margin, itmbase, ship, install As Double
        Dim cnt As Long = 0
        Dim MultiQty_MD, MultiQty_CON, MultiQty_RET, MutliQty_SHIP, MultiQty_BASE As Boolean
        Dim CustSalesCat As String
        Try

            cmd.Connection = cnn

            cnn.Open()
            cmd.CommandText = "delete from item_price where item_user='" + User + "'"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "select cust_sales_cat from cust_file where cust_serial=" + CStr(ddCust.Value)
            CustSalesCat = nz(cmd.ExecuteScalar)

            'If CustSalesCat <> "MD" Or CustSalesCat <> "MR" Then CustSalesCat = "RET"


            cmd.CommandText = "select * from itm_file"
            da.Fill(ds, "itm")
            For Each dr In ds.Tables(0).Rows
                cnt = cnt + 1
                If nz(dr("inactive"), 0) = 0 Then
                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='BASE' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "' and itm_price_qty_from <= 1 and itm_price_qty_to >= 1"
                    itmbase = nz(cmd.ExecuteScalar, 0)
                    cmd.CommandText = "select count(itm_price_serial) from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='BASE' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                    MultiQty_BASE = nz(cmd.ExecuteScalar, 0) > 1

                    md = 0
                    con = 0

                    cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_itm_code='" + nz(dr("itm_code")) + "' and cust_itm_price_cust_serial=" + CStr(ddCust.Value) + " and cust_itm_price_start<='" + CStr(tDate.Value) + "' and cust_itm_price_end>='" + CStr(tDate.Value) + "' and cust_itm_price_from <= 1 and cust_itm_price_to >= 1"
                    base = nz(cmd.ExecuteScalar, 0)
                    If base = 0 Then
                        cmd.CommandText = "select cust_prod_mar_margin from cust_prod_mar where cust_prod_mar_cust_serial=" + CStr(ddCust.Value) + " and cust_prod_mar_type='" + nz(dr("itm_prod_type")) + "' and cust_prod_mar_start<='" + CStr(tDate.Value) + "' and cust_prod_mar_end>='" + CStr(tDate.Value) + "'"
                        margin = nz(cmd.ExecuteScalar, 0)
                        If margin <> 0 Then
                            base = itmbase * margin
                        Else
                            cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_cat='" + CustSalesCat + "' and sales_cat_prod_mar_type='" + nz(dr("itm_prod_type")) + "' and sales_cat_prod_mar_start<='" + CStr(tDate.Value) + "' and sales_cat_prod_mar_end>='" + CStr(tDate.Value) + "'"
                            margin = nz(cmd.ExecuteScalar, 0)
                            If margin <> 0 Then
                                base = itmbase * margin
                            Else
                                base = itmbase
                            End If
                        End If
                    Else
                        cmd.CommandText = "select count(cust_itm_price_serial) from cust_itm_price where cust_itm_price_itm_code='" + nz(dr("itm_code")) + "' and cust_itm_price_cust_serial=" + CStr(ddCust.Value) + " and cust_itm_price_start<='" + CStr(tDate.Value) + "' and cust_itm_price_end>='" + CStr(tDate.Value) + "'"
                        MultiQty_BASE = nz(cmd.ExecuteScalar, 0) > 1
                    End If

                    'If nz(dr("itm_prod_type")) = "FIX" Or Mid(dr("itm_code"), 1, 6) = "FPRTAG" Then
                    '    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='MD' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "' and itm_price_qty_from <= 1 and itm_price_qty_to >= 1"
                    'Else
                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='RET' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "' and itm_price_qty_from <= 1 and itm_price_qty_to >= 1"
                    'End If
                    retail = nz(cmd.ExecuteScalar, 0)
                    If retail = 0 Then
                        cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + nz(dr("itm_prod_type")) + "' and sales_cat_prod_mar_cat='RET' and sales_cat_prod_mar_start<='" + CStr(tDate.Value) + "' and sales_cat_prod_mar_end>='" + CStr(tDate.Value) + "'"
                        retail = nz(cmd.ExecuteScalar, 0)
                        retail = retail * itmbase
                        MultiQty_RET = MultiQty_BASE
                    Else
                        'If nz(dr("itm_prod_type")) = "FIX" Or Mid(dr("itm_code"), 1, 6) = "FPRTAG" Then
                        '    cmd.CommandText = "select count(itm_price_serial) from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='MD' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                        'Else
                        cmd.CommandText = "select count(itm_price_serial) from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='RET' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                        'End If
                        MultiQty_RET = nz(cmd.ExecuteScalar, 0) > 1
                    End If

                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='SHIP' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                    ship = nz(cmd.ExecuteScalar, 0)

                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='Install' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                    install = nz(cmd.ExecuteScalar, 0)

                    cmd.CommandText = "insert into item_price (item_user,item_cust,item_code,item_desc,base,md,con,ret,ship,multiqty_ret,multiqty_base,install) values ('" + User + "','" + ddCust.Text + "','" + nz(dr("itm_code")) + "','" + Replace(nz(dr("itm_desc")), "'", "''") + "'," + CStr(base) + "," + CStr(md) + "," + CStr(con) + "," + CStr(retail) + "," + CStr(ship) + "," + IIf(MultiQty_RET, "1", "0") + "," + IIf(MultiQty_BASE, "1", "0") + "," + CStr(install) + ")"
                    cmd.ExecuteNonQuery()
                End If
                Bar1.Value = cnt / ds.Tables("itm").Rows.Count * 100
            Next
            cnn.Close()
        Catch
            MsgBox(Err.Description + vbCrLf + vbCrLf + cmd.CommandText)
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
            cnn.Close()
        End Try
        If Me.cbInclude.Checked Then
            DisplayReport("Item Pricing by customer with install", , True, 1, User, tDate.Value, True)
        Else
            DisplayReport("Item Pricing by customer", , True, 1, User, tDate.Value, True)
        End If
        Me.Close()
    End Sub
    Private Sub GetCustomerSaved022007()
        Try
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim cmd As New SqlClient.SqlCommand
            Dim dr As DataRow
            Dim ds As New DataSet
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim base, md, con, retail, margin, itmbase, ship As Double
            Dim cnt As Long = 0

            cmd.Connection = cnn

            cnn.Open()
            cmd.CommandText = "delete from item_price where item_user='" + User + "'"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "select * from itm_file"
            da.Fill(ds, "itm")
            For Each dr In ds.Tables(0).Rows
                cnt = cnt + 1
                If nz(dr("inactive"), 0) = 0 Then
                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='BASE' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                    itmbase = nz(cmd.ExecuteScalar, 0)

                    cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_itm_code='" + nz(dr("itm_code")) + "' and cust_itm_price_cust_serial=" + CStr(ddCust.Value) + " and cust_itm_price_start<='" + CStr(tDate.Value) + "' and cust_itm_price_end>='" + CStr(tDate.Value) + "'"
                    base = nz(cmd.ExecuteScalar, 0)
                    If base = 0 Then
                        cmd.CommandText = "select cust_prod_mar_margin from cust_prod_mar where cust_prod_mar_cust_serial=" + CStr(ddCust.Value) + " and cust_prod_mar_type='" + nz(dr("itm_prod_type")) + "' and cust_prod_mar_start<='" + CStr(tDate.Value) + "' and cust_prod_mar_end>='" + CStr(tDate.Value) + "'"
                        margin = nz(cmd.ExecuteScalar, 0)
                        If margin <> 0 Then
                            base = itmbase * margin
                        Else
                            base = itmbase
                        End If
                    End If

                    md = 0
                    con = 0

                    If nz(dr("itm_prod_type")) = "FIX" Or Mid(dr("itm_code"), 1, 6) = "FPRTAG" Then
                        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='MD' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                    Else
                        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='RET' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                    End If
                    retail = nz(cmd.ExecuteScalar, 0)
                    If retail = 0 Then
                        cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + nz(dr("itm_prod_type")) + "' and sales_cat_prod_mar_cat='RET' and sales_cat_prod_mar_start<='" + CStr(tDate.Value) + "' and sales_cat_prod_mar_end>='" + CStr(tDate.Value) + "'"
                        retail = nz(cmd.ExecuteScalar, 0)
                        retail = retail * itmbase
                    End If

                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("itm_code")) + "' and itm_price_type='SHIP' and itm_price_start<='" + CStr(tDate.Value) + "' and itm_price_end>='" + CStr(tDate.Value) + "'"
                    ship = nz(cmd.ExecuteScalar, 0)

                    cmd.CommandText = "insert into item_price (item_user,item_cust,item_code,item_desc,base,md,con,ret,ship) values ('" + User + "','" + ddCust.Text + "','" + nz(dr("itm_code")) + "','" + Replace(nz(dr("itm_desc")), "'", "''") + "'," + CStr(base) + "," + CStr(md) + "," + CStr(con) + "," + CStr(retail) + "," + CStr(ship) + ")"
                    cmd.ExecuteNonQuery()
                End If
                Bar1.Value = cnt / ds.Tables("itm").Rows.Count * 100
            Next
            cnn.Close()
        Catch
            MsgBox(Err.Description)
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
            cnn.Close()
        End Try
        DisplayReport("Item Pricing by customer", , True, 1, User, tDate.Value, True)
        Me.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ddCust.Enabled = True
        Else
            ddCust.Enabled = False
        End If
    End Sub

    Private Sub bRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRun.Click
        If RadioButton1.Checked Then

            GetGeneral()
        Else
            GetCustomer()
        End If
    End Sub
End Class
