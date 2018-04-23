<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmKitCDRDownstairs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmKitCDRDownstairs))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.bPrint = New Infragistics.Win.Misc.UltraButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bSave = New Infragistics.Win.Misc.UltraButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Selectx = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ord_gen_ord_serial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ord_gen_rev = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ord_sold_cust_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ord_for = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ord_prod_kitdown_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ord_prod_factcomp_date = New Infragistics.Win.UltraDataGridView.UltraDateTimeEditorColumn(Me.components)
        Me.ord_prod_est_comp = New Infragistics.Win.UltraDataGridView.UltraDateTimeEditorColumn(Me.components)
        Me.ord_prod_committed = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ord_gen_print_downstairs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ord_gen_print_downstairs_by = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ord_prod_kitdown_note = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ord_prod_estship_emailsent = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.printDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton6 = New Infragistics.Win.Misc.UltraButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.UltraButton8 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton7 = New Infragistics.Win.Misc.UltraButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbTray = New System.Windows.Forms.ComboBox
        Me.UltraButton9 = New Infragistics.Win.Misc.UltraButton
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bPrint
        '
        Me.bPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance10.ForeColor = System.Drawing.Color.Blue
        Appearance10.Image = "listview.gif"
        Me.bPrint.Appearance = Appearance10
        Me.bPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPrint.ImageList = Me.ImageList1
        Me.bPrint.Location = New System.Drawing.Point(244, 37)
        Me.bPrint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Size = New System.Drawing.Size(171, 24)
        Me.bPrint.TabIndex = 11
        Me.bPrint.Text = "Print Selected Orders"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "arrow_refresh.png")
        Me.ImageList1.Images.SetKeyName(1, "checkbox.gif")
        Me.ImageList1.Images.SetKeyName(2, "icon-cancel.bmp")
        Me.ImageList1.Images.SetKeyName(3, "print-icon2.png")
        Me.ImageList1.Images.SetKeyName(4, "report.png")
        Me.ImageList1.Images.SetKeyName(5, "save16.png")
        Me.ImageList1.Images.SetKeyName(6, "unchecked.gif")
        Me.ImageList1.Images.SetKeyName(7, "listview.gif")
        Me.ImageList1.Images.SetKeyName(8, "products.gif")
        Me.ImageList1.Images.SetKeyName(9, "refresh.gif")
        Me.ImageList1.Images.SetKeyName(10, "vbaman.bmp")
        '
        'bSave
        '
        Me.bSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance4.Image = "refresh.gif"
        Me.bSave.Appearance = Appearance4
        Me.bSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSave.ImageList = Me.ImageList1
        Me.bSave.ImageTransparentColor = System.Drawing.Color.White
        Me.bSave.Location = New System.Drawing.Point(122, 37)
        Me.bSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(110, 24)
        Me.bSave.TabIndex = 10
        Me.bSave.Text = "Refresh Grid"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 600000
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selectx, Me.ord_gen_ord_serial, Me.ord_gen_rev, Me.ord_sold_cust_id, Me.ord_for, Me.ord_prod_kitdown_date, Me.ord_prod_factcomp_date, Me.ord_prod_est_comp, Me.ord_prod_committed, Me.ord_gen_print_downstairs, Me.ord_gen_print_downstairs_by, Me.ord_prod_kitdown_note, Me.ord_prod_estship_emailsent})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 5)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1190, 683)
        Me.DataGridView1.TabIndex = 12
        '
        'Selectx
        '
        Me.Selectx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Selectx.Frozen = True
        Me.Selectx.HeaderText = "Select"
        Me.Selectx.Name = "Selectx"
        Me.Selectx.Width = 50
        '
        'ord_gen_ord_serial
        '
        Me.ord_gen_ord_serial.DataPropertyName = "ord_gen_ord_serial"
        Me.ord_gen_ord_serial.Frozen = True
        Me.ord_gen_ord_serial.HeaderText = "Order"
        Me.ord_gen_ord_serial.Name = "ord_gen_ord_serial"
        Me.ord_gen_ord_serial.ReadOnly = True
        Me.ord_gen_ord_serial.Width = 90
        '
        'ord_gen_rev
        '
        Me.ord_gen_rev.DataPropertyName = "ord_gen_rev"
        Me.ord_gen_rev.Frozen = True
        Me.ord_gen_rev.HeaderText = "Rev"
        Me.ord_gen_rev.Name = "ord_gen_rev"
        Me.ord_gen_rev.ReadOnly = True
        Me.ord_gen_rev.Width = 45
        '
        'ord_sold_cust_id
        '
        Me.ord_sold_cust_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ord_sold_cust_id.DataPropertyName = "ord_sold_cust_id"
        Me.ord_sold_cust_id.Frozen = True
        Me.ord_sold_cust_id.HeaderText = "CustID"
        Me.ord_sold_cust_id.Name = "ord_sold_cust_id"
        Me.ord_sold_cust_id.ReadOnly = True
        '
        'ord_for
        '
        Me.ord_for.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ord_for.DataPropertyName = "ord_for"
        Me.ord_for.Frozen = True
        Me.ord_for.HeaderText = "Ord For"
        Me.ord_for.Name = "ord_for"
        Me.ord_for.ReadOnly = True
        Me.ord_for.Width = 250
        '
        'ord_prod_kitdown_date
        '
        Me.ord_prod_kitdown_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ord_prod_kitdown_date.DataPropertyName = "ord_prod_kitdown_date"
        Me.ord_prod_kitdown_date.HeaderText = "KitDown"
        Me.ord_prod_kitdown_date.Name = "ord_prod_kitdown_date"
        Me.ord_prod_kitdown_date.ReadOnly = True
        Me.ord_prod_kitdown_date.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ord_prod_kitdown_date.Width = 135
        '
        'ord_prod_factcomp_date
        '
        Me.ord_prod_factcomp_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ord_prod_factcomp_date.DataPropertyName = "ord_prod_factcomp_date"
        Me.ord_prod_factcomp_date.DefaultNewRowValue = CType(resources.GetObject("ord_prod_factcomp_date.DefaultNewRowValue"), Object)
        Me.ord_prod_factcomp_date.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.[Default]
        Me.ord_prod_factcomp_date.DropDownCalendarAlignment = Infragistics.Win.DropDownListAlignment.Right
        Me.ord_prod_factcomp_date.HeaderText = "Est Fact. Comp."
        Me.ord_prod_factcomp_date.MaskInput = Nothing
        Me.ord_prod_factcomp_date.Name = "ord_prod_factcomp_date"
        Me.ord_prod_factcomp_date.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ord_prod_factcomp_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ord_prod_factcomp_date.SpinButtonAlignment = Infragistics.Win.SpinButtonDisplayStyle.None
        Me.ord_prod_factcomp_date.Width = 135
        '
        'ord_prod_est_comp
        '
        Me.ord_prod_est_comp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ord_prod_est_comp.DataPropertyName = "ord_prod_est_comp"
        Me.ord_prod_est_comp.DefaultNewRowValue = CType(resources.GetObject("ord_prod_est_comp.DefaultNewRowValue"), Object)
        Me.ord_prod_est_comp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.[Default]
        Me.ord_prod_est_comp.DropDownCalendarAlignment = Infragistics.Win.DropDownListAlignment.Right
        Me.ord_prod_est_comp.HeaderText = "Est Ship Date"
        Me.ord_prod_est_comp.MaskInput = Nothing
        Me.ord_prod_est_comp.Name = "ord_prod_est_comp"
        Me.ord_prod_est_comp.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ord_prod_est_comp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ord_prod_est_comp.SpinButtonAlignment = Infragistics.Win.SpinButtonDisplayStyle.None
        Me.ord_prod_est_comp.Width = 135
        '
        'ord_prod_committed
        '
        Me.ord_prod_committed.DataPropertyName = "ord_prod_committed"
        Me.ord_prod_committed.HeaderText = "Committed"
        Me.ord_prod_committed.Name = "ord_prod_committed"
        Me.ord_prod_committed.ReadOnly = True
        Me.ord_prod_committed.Width = 115
        '
        'ord_gen_print_downstairs
        '
        Me.ord_gen_print_downstairs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ord_gen_print_downstairs.DataPropertyName = "ord_gen_print_downstairs"
        Me.ord_gen_print_downstairs.HeaderText = "First Printed"
        Me.ord_gen_print_downstairs.Name = "ord_gen_print_downstairs"
        Me.ord_gen_print_downstairs.ReadOnly = True
        Me.ord_gen_print_downstairs.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ord_gen_print_downstairs.Width = 115
        '
        'ord_gen_print_downstairs_by
        '
        Me.ord_gen_print_downstairs_by.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ord_gen_print_downstairs_by.DataPropertyName = "ord_gen_print_downstairs_by"
        Me.ord_gen_print_downstairs_by.HeaderText = "PrintedBy"
        Me.ord_gen_print_downstairs_by.Name = "ord_gen_print_downstairs_by"
        Me.ord_gen_print_downstairs_by.ReadOnly = True
        '
        'ord_prod_kitdown_note
        '
        Me.ord_prod_kitdown_note.DataPropertyName = "ord_prod_kitdown_note"
        Me.ord_prod_kitdown_note.HeaderText = "Kit\CDR Notes"
        Me.ord_prod_kitdown_note.Name = "ord_prod_kitdown_note"
        Me.ord_prod_kitdown_note.ReadOnly = True
        Me.ord_prod_kitdown_note.Width = 500
        '
        'ord_prod_estship_emailsent
        '
        Me.ord_prod_estship_emailsent.DataPropertyName = "ord_prod_estship_emailsent"
        Me.ord_prod_estship_emailsent.HeaderText = "EmailSent"
        Me.ord_prod_estship_emailsent.Name = "ord_prod_estship_emailsent"
        Me.ord_prod_estship_emailsent.ReadOnly = True
        Me.ord_prod_estship_emailsent.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ord_prod_estship_emailsent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ord_prod_estship_emailsent.Visible = False
        Me.ord_prod_estship_emailsent.Width = 125
        '
        'UltraButton1
        '
        Me.UltraButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance2.Image = "checkbox.gif"
        Me.UltraButton1.Appearance = Appearance2
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.ImageList = Me.ImageList1
        Me.UltraButton1.Location = New System.Drawing.Point(2, 11)
        Me.UltraButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(112, 24)
        Me.UltraButton1.TabIndex = 13
        Me.UltraButton1.Text = "Select All"
        '
        'UltraButton2
        '
        Me.UltraButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance3.Image = "unchecked.gif"
        Me.UltraButton2.Appearance = Appearance3
        Me.UltraButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton2.ImageList = Me.ImageList1
        Me.UltraButton2.Location = New System.Drawing.Point(2, 37)
        Me.UltraButton2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(112, 24)
        Me.UltraButton2.TabIndex = 14
        Me.UltraButton2.Text = "Un-Select All"
        '
        'UltraButton3
        '
        Me.UltraButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance5.Image = "save16.png"
        Me.UltraButton3.Appearance = Appearance5
        Me.UltraButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton3.ImageList = Me.ImageList1
        Me.UltraButton3.Location = New System.Drawing.Point(419, 11)
        Me.UltraButton3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(152, 24)
        Me.UltraButton3.TabIndex = 15
        Me.UltraButton3.Text = "Save Grid Changes"
        Me.UltraButton3.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(730, 36)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Bypass Auto Refresh"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'UltraButton4
        '
        Me.UltraButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance9.Image = "vbaman.bmp"
        Me.UltraButton4.Appearance = Appearance9
        Me.UltraButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton4.ImageList = Me.ImageList1
        Me.UltraButton4.Location = New System.Drawing.Point(1092, 37)
        Me.UltraButton4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(93, 24)
        Me.UltraButton4.TabIndex = 17
        Me.UltraButton4.Text = "Print Grid"
        '
        'printDocument1
        '
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(1148, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "---"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Timer2
        '
        Me.Timer2.Interval = 900
        '
        'UltraButton5
        '
        Me.UltraButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance6.Image = "icon-cancel.bmp"
        Me.UltraButton5.Appearance = Appearance6
        Me.UltraButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton5.ImageList = Me.ImageList1
        Me.UltraButton5.Location = New System.Drawing.Point(419, 37)
        Me.UltraButton5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(152, 24)
        Me.UltraButton5.TabIndex = 19
        Me.UltraButton5.Text = "Cancel Changes"
        Me.UltraButton5.Visible = False
        '
        'UltraButton6
        '
        Me.UltraButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance7.Image = "print-icon2.png"
        Me.UltraButton6.Appearance = Appearance7
        Me.UltraButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton6.ImageList = Me.ImageList1
        Me.UltraButton6.Location = New System.Drawing.Point(583, 11)
        Me.UltraButton6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UltraButton6.Name = "UltraButton6"
        Me.UltraButton6.Size = New System.Drawing.Size(121, 24)
        Me.UltraButton6.TabIndex = 21
        Me.UltraButton6.Text = "Select Printer"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(708, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "---"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.UltraButton9)
        Me.Panel1.Controls.Add(Me.UltraButton8)
        Me.Panel1.Controls.Add(Me.UltraButton7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbTray)
        Me.Panel1.Controls.Add(Me.UltraButton1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.bSave)
        Me.Panel1.Controls.Add(Me.UltraButton6)
        Me.Panel1.Controls.Add(Me.bPrint)
        Me.Panel1.Controls.Add(Me.UltraButton5)
        Me.Panel1.Controls.Add(Me.UltraButton2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.UltraButton3)
        Me.Panel1.Controls.Add(Me.UltraButton4)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Location = New System.Drawing.Point(4, 692)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1190, 66)
        Me.Panel1.TabIndex = 23
        '
        'UltraButton8
        '
        Me.UltraButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.ForeColor = System.Drawing.Color.Blue
        Appearance1.Image = "listview.gif"
        Me.UltraButton8.Appearance = Appearance1
        Me.UltraButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton8.ImageList = Me.ImageList1
        Me.UltraButton8.Location = New System.Drawing.Point(741, 15)
        Me.UltraButton8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UltraButton8.Name = "UltraButton8"
        Me.UltraButton8.Size = New System.Drawing.Size(15, 16)
        Me.UltraButton8.TabIndex = 26
        Me.UltraButton8.Text = "Print Selected Orders"
        Me.UltraButton8.Visible = False
        '
        'UltraButton7
        '
        Me.UltraButton7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance11.Image = "products.gif"
        Me.UltraButton7.Appearance = Appearance11
        Me.UltraButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton7.ImageList = Me.ImageList1
        Me.UltraButton7.Location = New System.Drawing.Point(859, 11)
        Me.UltraButton7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UltraButton7.Name = "UltraButton7"
        Me.UltraButton7.Size = New System.Drawing.Size(229, 24)
        Me.UltraButton7.TabIndex = 25
        Me.UltraButton7.Text = "Print Factory Kits Budget"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(585, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Printer Tray"
        '
        'cbTray
        '
        Me.cbTray.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbTray.FormattingEnabled = True
        Me.cbTray.Items.AddRange(New Object() {"Drawer 1", "Drawer 2", "Drawer 3", "Drawer 4"})
        Me.cbTray.Location = New System.Drawing.Point(650, 38)
        Me.cbTray.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbTray.Name = "cbTray"
        Me.cbTray.Size = New System.Drawing.Size(65, 21)
        Me.cbTray.TabIndex = 23
        Me.cbTray.Text = "Drawer 3"
        '
        'UltraButton9
        '
        Me.UltraButton9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance8.Image = "products.gif"
        Me.UltraButton9.Appearance = Appearance8
        Me.UltraButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton9.ImageList = Me.ImageList1
        Me.UltraButton9.Location = New System.Drawing.Point(859, 37)
        Me.UltraButton9.Margin = New System.Windows.Forms.Padding(2)
        Me.UltraButton9.Name = "UltraButton9"
        Me.UltraButton9.Size = New System.Drawing.Size(229, 24)
        Me.UltraButton9.TabIndex = 27
        Me.UltraButton9.Text = "Print Factory Kits Daily Report"
        '
        'fmKitCDRDownstairs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 759)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "fmKitCDRDownstairs"
        Me.Text = "Open Order Kit\CDR Downstairs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Private WithEvents printDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Selectx As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ord_gen_ord_serial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ord_gen_rev As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ord_sold_cust_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ord_for As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ord_prod_kitdown_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ord_prod_factcomp_date As Infragistics.Win.UltraDataGridView.UltraDateTimeEditorColumn
    Friend WithEvents ord_prod_est_comp As Infragistics.Win.UltraDataGridView.UltraDateTimeEditorColumn
    Friend WithEvents ord_prod_committed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ord_gen_print_downstairs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ord_gen_print_downstairs_by As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ord_prod_kitdown_note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ord_prod_estship_emailsent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbTray As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton8 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton9 As Infragistics.Win.Misc.UltraButton
End Class
