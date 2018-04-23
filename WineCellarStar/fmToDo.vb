Public Class fmToDo
    Inherits WineCellar.fmStarter
    Dim ds As New DataSet
    Dim cmd As New SqlClient.SqlCommand("", cnn2)
    Dim da As New SqlClient.SqlDataAdapter(cmd)
    Dim UserList As String
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rRackDesign As System.Windows.Forms.RadioButton
    Dim isOperations As Boolean
    Friend WithEvents pKey As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Dim onSilentUpdate As Boolean = False

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
    Friend WithEvents pUsers As System.Windows.Forms.Panel
    Friend WithEvents bClear As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bCheckAll As Infragistics.Win.Misc.UltraButton
    Friend WithEvents rOperations As System.Windows.Forms.RadioButton
    Friend WithEvents rISR As System.Windows.Forms.RadioButton
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chShowTimes As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents rDesigns As System.Windows.Forms.RadioButton
    Friend WithEvents tDesFilter As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents bDesFilter As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lDesigns As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("quote")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_prod_designstart_date")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_inside")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_sold_cust_id")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_sold_company")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_sold_name")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_for")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_total")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_co_desreq")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_co_designer")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_co_desdate")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_co_toart")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_co_ca")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_co_cadate")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_co_factoryinstall_req")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_co_factoryinstall")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_co_factoryinstall_date")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_co_priority")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_prority_note")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_prod_designstart")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_prod_designcomplete")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_prod_designstart_note")
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1186)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(872)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim RowScrollRegion1 As Infragistics.Win.UltraWinGrid.RowScrollRegion = New Infragistics.Win.UltraWinGrid.RowScrollRegion(0)
        Dim RowScrollRegion2 As Infragistics.Win.UltraWinGrid.RowScrollRegion = New Infragistics.Win.UltraWinGrid.RowScrollRegion(0)
        Dim RowScrollRegion3 As Infragistics.Win.UltraWinGrid.RowScrollRegion = New Infragistics.Win.UltraWinGrid.RowScrollRegion(692)
        Dim RowScrollRegion4 As Infragistics.Win.UltraWinGrid.RowScrollRegion = New Infragistics.Win.UltraWinGrid.RowScrollRegion(-35)
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.pUsers = New System.Windows.Forms.Panel
        Me.bClear = New Infragistics.Win.Misc.UltraButton
        Me.bCheckAll = New Infragistics.Win.Misc.UltraButton
        Me.rOperations = New System.Windows.Forms.RadioButton
        Me.rISR = New System.Windows.Forms.RadioButton
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.chShowTimes = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.rDesigns = New System.Windows.Forms.RadioButton
        Me.tDesFilter = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.bDesFilter = New Infragistics.Win.Misc.UltraButton
        Me.lDesigns = New Infragistics.Win.Misc.UltraLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pKey = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.rRackDesign = New System.Windows.Forms.RadioButton
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chShowTimes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDesFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pKey.SuspendLayout()
        Me.SuspendLayout()
        '
        'pUsers
        '
        Me.pUsers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pUsers.AutoScroll = True
        Me.pUsers.Location = New System.Drawing.Point(1203, 10)
        Me.pUsers.Name = "pUsers"
        Me.pUsers.Size = New System.Drawing.Size(143, 614)
        Me.pUsers.TabIndex = 1
        '
        'bClear
        '
        Me.bClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bClear.Location = New System.Drawing.Point(1203, 735)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(63, 24)
        Me.bClear.TabIndex = 2
        Me.bClear.Text = "Clear"
        '
        'bCheckAll
        '
        Me.bCheckAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCheckAll.Location = New System.Drawing.Point(1275, 735)
        Me.bCheckAll.Name = "bCheckAll"
        Me.bCheckAll.Size = New System.Drawing.Size(71, 24)
        Me.bCheckAll.TabIndex = 3
        Me.bCheckAll.Text = "Check All"
        '
        'rOperations
        '
        Me.rOperations.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rOperations.Location = New System.Drawing.Point(1223, 677)
        Me.rOperations.Name = "rOperations"
        Me.rOperations.Size = New System.Drawing.Size(88, 18)
        Me.rOperations.TabIndex = 7
        Me.rOperations.Text = "Operations"
        '
        'rISR
        '
        Me.rISR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rISR.Checked = True
        Me.rISR.Location = New System.Drawing.Point(1223, 651)
        Me.rISR.Name = "rISR"
        Me.rISR.Size = New System.Drawing.Size(105, 18)
        Me.rISR.TabIndex = 6
        Me.rISR.TabStop = True
        Me.rISR.Text = "ISRs"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.Caption = "Quote Number"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.MaxWidth = 100
        UltraGridColumn1.MinWidth = 100
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn1.Width = 100
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 143
        UltraGridColumn3.Header.Caption = "ISR"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaxWidth = 100
        UltraGridColumn3.Width = 24
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 82
        UltraGridColumn5.Header.Caption = "Company"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 37
        UltraGridColumn6.Header.Caption = "Name"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 20
        UltraGridColumn7.Header.Caption = "Primary Reference"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 39
        UltraGridColumn8.Format = "$###,###,###.00"
        UltraGridColumn8.Header.Caption = "Total"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 31
        UltraGridColumn9.Header.Caption = "Des Req"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn9.Width = 45
        UltraGridColumn10.Header.Caption = "Design"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn10.Width = 49
        UltraGridColumn11.Format = "MM/dd/yyy hh:mm"
        UltraGridColumn11.Header.Caption = "Des Date"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.MaxWidth = 100
        UltraGridColumn11.Width = 45
        UltraGridColumn12.Header.Caption = "Art Req"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn12.Width = 21
        UltraGridColumn13.Header.Caption = "Art"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn13.Width = 22
        UltraGridColumn14.Format = "MM/dd/yyy hh:mm"
        UltraGridColumn14.Header.Caption = "Art Date"
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn14.MaxWidth = 100
        UltraGridColumn14.Width = 36
        UltraGridColumn15.Header.Caption = "Factory Install Req"
        UltraGridColumn15.Header.VisiblePosition = 16
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn15.Width = 32
        UltraGridColumn16.Header.Caption = "Factory Install"
        UltraGridColumn16.Header.VisiblePosition = 17
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn16.Width = 57
        UltraGridColumn17.Format = "MM/dd/yyy hh:mm"
        UltraGridColumn17.Header.Caption = "Inst Date"
        UltraGridColumn17.Header.VisiblePosition = 18
        UltraGridColumn17.MaxWidth = 100
        UltraGridColumn17.Width = 49
        UltraGridColumn18.Header.Caption = "Priority"
        UltraGridColumn18.Header.VisiblePosition = 13
        UltraGridColumn18.MaxWidth = 20
        UltraGridColumn18.MinWidth = 20
        UltraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn18.Width = 20
        UltraGridColumn19.Header.Caption = "Prority Note"
        UltraGridColumn19.Header.VisiblePosition = 14
        UltraGridColumn19.Width = 84
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.CellMultiLine = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn22.Header.Caption = "Design Start Note"
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        UltraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.Grid1.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid1.DisplayLayout.Override.EditCellAppearance = Appearance3
        Me.Grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.Grid1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid1.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree
        Me.Grid1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.Grid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        RowScrollRegion1.ScrollPosition = 0
        RowScrollRegion2.ScrollPosition = 0
        RowScrollRegion3.ScrollPosition = 0
        RowScrollRegion4.ScrollPosition = 0
        Me.Grid1.DisplayLayout.RowScrollRegions.Add(RowScrollRegion1)
        Me.Grid1.DisplayLayout.RowScrollRegions.Add(RowScrollRegion2)
        Me.Grid1.DisplayLayout.RowScrollRegions.Add(RowScrollRegion3)
        Me.Grid1.DisplayLayout.RowScrollRegions.Add(RowScrollRegion4)
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(8, 10)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1188, 712)
        Me.Grid1.TabIndex = 8
        '
        'chShowTimes
        '
        Me.chShowTimes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chShowTimes.Location = New System.Drawing.Point(7, 735)
        Me.chShowTimes.Name = "chShowTimes"
        Me.chShowTimes.Size = New System.Drawing.Size(120, 14)
        Me.chShowTimes.TabIndex = 9
        Me.chShowTimes.Text = "Show Times"
        '
        'rDesigns
        '
        Me.rDesigns.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rDesigns.Location = New System.Drawing.Point(1223, 629)
        Me.rDesigns.Name = "rDesigns"
        Me.rDesigns.Size = New System.Drawing.Size(105, 18)
        Me.rDesigns.TabIndex = 10
        Me.rDesigns.Text = "Designs"
        '
        'tDesFilter
        '
        Me.tDesFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tDesFilter.Location = New System.Drawing.Point(134, 735)
        Me.tDesFilter.Name = "tDesFilter"
        Me.tDesFilter.Size = New System.Drawing.Size(153, 21)
        Me.tDesFilter.TabIndex = 11
        Me.tDesFilter.Visible = False
        '
        'bDesFilter
        '
        Me.bDesFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bDesFilter.Location = New System.Drawing.Point(287, 733)
        Me.bDesFilter.Name = "bDesFilter"
        Me.bDesFilter.Size = New System.Drawing.Size(55, 22)
        Me.bDesFilter.TabIndex = 12
        Me.bDesFilter.Text = "Filter"
        Me.bDesFilter.Visible = False
        '
        'lDesigns
        '
        Me.lDesigns.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.TextHAlignAsString = "Right"
        Me.lDesigns.Appearance = Appearance1
        Me.lDesigns.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDesigns.Location = New System.Drawing.Point(986, 727)
        Me.lDesigns.Name = "lDesigns"
        Me.lDesigns.Size = New System.Drawing.Size(193, 22)
        Me.lDesigns.TabIndex = 13
        Me.lDesigns.Text = "0 Designs"
        Me.lDesigns.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pKey)
        Me.Panel1.Controls.Add(Me.rRackDesign)
        Me.Panel1.Controls.Add(Me.Grid1)
        Me.Panel1.Controls.Add(Me.lDesigns)
        Me.Panel1.Controls.Add(Me.pUsers)
        Me.Panel1.Controls.Add(Me.bDesFilter)
        Me.Panel1.Controls.Add(Me.bClear)
        Me.Panel1.Controls.Add(Me.tDesFilter)
        Me.Panel1.Controls.Add(Me.bCheckAll)
        Me.Panel1.Controls.Add(Me.rDesigns)
        Me.Panel1.Controls.Add(Me.rISR)
        Me.Panel1.Controls.Add(Me.chShowTimes)
        Me.Panel1.Controls.Add(Me.rOperations)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1358, 764)
        Me.Panel1.TabIndex = 14
        '
        'pKey
        '
        Me.pKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pKey.Controls.Add(Me.Label3)
        Me.pKey.Controls.Add(Me.Label2)
        Me.pKey.Controls.Add(Me.Label1)
        Me.pKey.Location = New System.Drawing.Point(357, 729)
        Me.pKey.Name = "pKey"
        Me.pKey.Size = New System.Drawing.Size(279, 26)
        Me.pKey.TabIndex = 15
        Me.pKey.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(121, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Add On"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(54, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Committed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kit/Cust"
        '
        'rRackDesign
        '
        Me.rRackDesign.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rRackDesign.Location = New System.Drawing.Point(1223, 697)
        Me.rRackDesign.Name = "rRackDesign"
        Me.rRackDesign.Size = New System.Drawing.Size(105, 19)
        Me.rRackDesign.TabIndex = 14
        Me.rRackDesign.Text = "Rack Design"
        '
        'fmToDo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1358, 764)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "fmToDo"
        Me.Text = "Check Off"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chShowTimes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDesFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pKey.ResumeLayout(False)
        Me.pKey.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmToDo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chShowTimes.Checked = (GetSetting("Jcom", "Settings", "CheckOffShowTimes", "False") = "True")
        SetColumns()
        LoadReps()
        If CheckSecurity("Designer Lock Down") > 0 Then
            rDesigns.Checked = True
            rISR.Checked = False
            rOperations.Checked = False
            rRackDesign.Checked = False
            rDesigns.Visible = False
            rISR.Visible = False
            rOperations.Visible = False
            rRackDesign.Visible = False
        Else
            Select Case GetSetting("Jcom", "Checkoff", "Section", "")
                Case "Design"
                    rDesigns.Checked = True
                    rISR.Checked = False
                    rOperations.Checked = False
                    rRackDesign.Checked = False
                Case "ISR"
                    rDesigns.Checked = False
                    rISR.Checked = True
                    rOperations.Checked = False
                    rRackDesign.Checked = False
                Case "Operations"
                    rDesigns.Checked = False
                    rISR.Checked = False
                    rOperations.Checked = True
                    rRackDesign.Checked = False
                Case "RackDesign"
                    rDesigns.Checked = False
                    rISR.Checked = False
                    rOperations.Checked = False
                    rRackDesign.Checked = True
            End Select
        End If
        If rISR.Checked Then
            bClear.Visible = True
            bCheckAll.Visible = True
            pUsers.Visible = True
            tDesFilter.Visible = False
            bDesFilter.Visible = False
            lDesigns.Visible = False
        ElseIf Me.rDesigns.Checked Then
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = True
            bDesFilter.Visible = True
            lDesigns.Visible = True
        ElseIf Me.rRackDesign.Checked Then
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = True
            bDesFilter.Visible = True
            lDesigns.Visible = True
        Else
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = False
            bDesFilter.Visible = False
            lDesigns.Visible = False
        End If

    End Sub
    Private Sub LoadReps()
        'If UserISRAdmin Then
        If UserType <> "C" Or Jcom.User = "christyl" Then
            cmd.CommandText = "select usr_isr_list from usr_file where usr_name='" + User + "'"
            cnn2.Open()
            UserList = nz(cmd.ExecuteScalar, "")

            If rISR.Checked Then
                cmd.CommandText = "select * from rep_file where (rep_type='I') and rep_active=1 order by rep_code"
            Else
                cmd.CommandText = "select * from rep_file where (rep_type='P') and rep_active=1 order by rep_code"
            End If
            Dim dr As SqlClient.SqlDataReader
            Dim cnt As Integer = 0
            dr = cmd.ExecuteReader
            Do While dr.Read
                Dim cb As New CheckBox
                cb.Text = dr("rep_code")
                If InStr(UserList, "*" + cb.Text + "*") > 0 Then
                    cb.Checked = True
                Else
                    cb.Checked = False
                End If
                cb.Top = cnt * 20
                cnt += 1
                AddHandler cb.Click, AddressOf UserClick

                pUsers.Controls.Add(cb)
            Loop
            cnn2.Close()

            If Jcom.User = "christyl" Then
                rISR.Visible = False
                rOperations.Visible = False
            End If
        Else
            bClear.Visible = False
            bCheckAll.Visible = False
            If User <> "terrif" Then
                rISR.Visible = False
                rOperations.Visible = False
            End If
        End If
    End Sub
    Private Sub UserClick(ByVal sender As Object, ByVal e As EventArgs)
        LoadGrid()
        SetUsers()
    End Sub
    Private Sub SetUsers()
        Dim cb As CheckBox
        Dim users As String = ""
        For Each cb In pUsers.Controls
            If cb.Checked Then users += "*" + cb.Text + "*,"
        Next
        Dim cmd As New SqlClient.SqlCommand("update usr_file set usr_isr_list='" + users + "' where usr_name='" + User + "'", cnn2)
        cnn2.Open()
        cmd.ExecuteNonQuery()
        cnn2.Close()
    End Sub
    Public Sub LoadGrid()
        Try
            onSilentUpdate = True
            cmd.CommandText = "select CONVERT(varchar, ord_gen_ord_serial) + '-' + CONVERT(varchar, ord_gen_rev) as quote, ord_gen_create_date,ord_gen_inside,ord_sold_cust_id, ord_sold_company,ord_sold_name,ord_for,ord_gen_total,ord_gen_co_desreq,ord_gen_co_designer,ord_gen_co_desdate,ord_gen_co_toart,isnull(ord_gen_co_priority,0) as ord_gen_co_priority, ord_gen_priority_note, ord_gen_co_ca, ord_gen_co_cadate,ord_gen_co_factoryinstall_req,ord_gen_co_factoryinstall,ord_gen_co_factoryinstall_date, ord_gen_designer, ord_gen_des_status, '' as ord_prod_designstart_note,ord_gen_start_design,ord_gen_design_required "  ''' as material
            'If UserISRAdmin Or User = "terrif" Then
            cmd.CommandTimeout = 2000
            Grid1.DisplayLayout.Bands(0).Columns(2).Header.Caption = "ISR"

            If UserType <> "C" Or Jcom.User = "christyl" Then
                Dim cb As CheckBox
                Dim Users As String = ""
                For Each cb In pUsers.Controls
                    If cb.Checked Then Users += "'" + cb.Text + "',"
                Next
                If Len(Users) > 0 Then
                    Users = Mid(Users, 1, Len(Users) - 1)
                Else
                    Users = "''"
                End If
                If rISR.Checked Then
                    cmd.CommandText += "from ord_gen left outer join ord_file on ord_gen_ord_serial=ord_serial where (ord_gen_type='Q' and ord_gen_inside in (" + Users + ")) and (case ord_gen_co_desreq when 1 then ord_gen_co_designer else 1 end)=1 and ord_gen_co_isr=0  and ord_gen_type='Q' order by ord_gen_co_desdate desc"
                ElseIf rDesigns.Checked Then
                    Grid1.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Resp."
                    cmd.CommandText = Replace(cmd.CommandText, "ord_gen_inside", "(CASE WHEN ord_gen_resp_rep = 'I' THEN ord_gen_inside WHEN ord_gen_resp_rep = 'O' THEN ord_gen_outside ELSE ord_gen_floating END) AS ord_gen_inside ")
                    'cmd.CommandText = Replace(cmd.CommandText, "ord_gen_inside", "CASE WHEN ord_gen_resp_rep = 'I' THEN ord_gen_inside ELSE CASE WHEN ord_gen_resp_rep = 'O' THEN ord_gen_outside ELSE ord_gen_floating END END AS ord_gen_inside")

                    cmd.CommandText += "from ord_gen left outer join ord_file on ord_gen_ord_serial=ord_serial where ord_gen_type='Q' and (ord_gen_co_desreq=1 and ord_gen_co_designer=0)"
                    If tDesFilter.Text <> "" Then
                        If IsNumeric(tDesFilter.Text) Then
                            cmd.CommandText += " and (ord_for like '%" + tDesFilter.Text + "%' or ord_gen_ord_serial=" + tDesFilter.Text + ")"
                        Else
                            cmd.CommandText += " and ord_for like '%" + tDesFilter.Text + "%'"
                        End If
                    End If
                    If Jcom.User = "christyl" Then
                        cmd.CommandText = cmd.CommandText.Replace("(ord_gen_co_desreq=1 and ord_gen_co_designer=0)", " ord_gen_co_desreq=1 AND ord_gen_co_ca = 0")
                        cmd.CommandText += " and ord_gen_co_toart=1"
                    End If
                    cmd.CommandText += " order by ord_gen_co_priority desc,ord_gen_design_required,ord_gen_create_date"
                ElseIf rRackDesign.Checked Then
                    cmd.CommandText = "select CONVERT(varchar, ord_gen_ord_serial) + '-' + CONVERT(varchar, ord_gen_from_rev)+ '-' + CONVERT(varchar, ord_gen_rev) as quote, ord_gen_create_date,ord_prod_designstart,ord_prod_designcomplete,ord_prod_allclear_date,ord_prod_committed,ord_gen_inside,ord_sold_cust_id, ord_sold_company,ord_sold_name,ord_for,ord_gen_line_total as ord_gen_total,ord_gen_co_desreq,ord_gen_co_designer,ord_gen_co_desdate,ord_gen_co_toart,isnull(ord_gen_co_priority,0) as ord_gen_co_priority, ord_gen_priority_note, ord_gen_co_ca, ord_gen_co_cadate,ord_gen_co_factoryinstall_req,ord_gen_co_factoryinstall,ord_gen_co_factoryinstall_date, ord_gen_designer, ord_gen_des_status,0 as [Kit/Cust], ord_prod_designstart_note, ord_gen_addon, case when isnull(ord_prod_est_comp,'1/1/1900')='1/1/1900' then 999 else datediff(day,getdate(),ord_prod_est_comp) end as DaysToComp,ord_gen_start_design,ord_gen_design_required  "
                    cmd.CommandText += "from ord_gen left outer join ord_file on ord_gen_ord_serial=ord_serial left outer join ord_prod on ord_gen_ord_serial=ord_prod_ord_serial and ord_gen_rev=ord_prod_rev and ord_gen_type=ord_prod_type where ord_gen_type='O' and (ord_prod_allclear=1 and ord_prod_tofactory=0) and ord_gen_status not in ('SHIPPED','CANCELED') "
                    If tDesFilter.Text <> "" Then
                        If IsNumeric(tDesFilter.Text) Then
                            cmd.CommandText += " and (ord_for like '%" + tDesFilter.Text + "%' or ord_gen_ord_serial=" + tDesFilter.Text + ")"
                        Else
                            cmd.CommandText += " and ord_for like '%" + tDesFilter.Text + "%'"
                        End If
                    End If
                    'cmd.CommandText += " order by case when isnull(ord_prod_est_comp,'1/1/1900')='1/1/1900' then 999 else datediff(day,getdate(),ord_prod_est_comp) end"
                    cmd.CommandText += " order by ord_prod_allclear_date,ord_gen_ord_serial"
                Else
                    cmd.CommandText += "from ord_gen left outer join ord_file on ord_gen_ord_serial=ord_serial where ord_gen_co_toart=1 and ord_gen_co_ca=0 and ord_gen_type='Q' and ((ord_gen_co_desreq=1 and ord_gen_co_designer=1) or (ord_gen_co_desreq=0)) order by ord_gen_co_desdate desc"
                End If
            Else
                'Select Case UserType
                '    Case "C"
                cmd.CommandText += "from ord_gen left outer join ord_file on ord_gen_ord_serial=ord_serial where ord_gen_co_toart=1 and ord_gen_co_ca=0 and ord_gen_type='Q' and ((ord_gen_co_desreq=1 and ord_gen_co_designer=1) or (ord_gen_co_desreq=0)) order by ord_gen_co_desdate desc"
                '    Case "P"
                '        cmd.CommandText += "FROM ord_gen LEFT OUTER JOIN ord_file ON ord_gen_ord_serial = ord_serial WHERE ord_gen_type='Q' and ord_gen_co_isr=0 and (ord_gen_co_desreq<>1 or (ord_gen_co_desreq=1 and ord_gen_co_designer=1)) and (ord_gen_co_toart<>1 or (ord_gen_co_toart=1 and ord_gen_co_ca=1)) and ((ord_gen_co_factoryinstall_req=1 and ord_gen_co_factoryinstall<>1)) ORDER BY ord_gen_co_desdate DESC"
                '    Case Else
                '        'cmd.CommandText += "from ord_gen left outer join ord_file on ord_gen_ord_serial=ord_serial left outer join rep_file on ord_gen_floating=rep_code where (ord_gen_type='Q' and (case ord_gen_resp_rep when 'F' then rep_fsr_isr else ord_gen_inside end)='" + User + "') and (case ord_gen_co_desreq when 1 then ord_gen_co_designer else 1 end)=1 and ord_gen_co_isr=0  and ord_gen_type='Q' order by ord_gen_co_desdate desc"
                '        'Took out the reference to 'F'  2/2/2009 jpj
                '        cmd.CommandText += "from ord_gen left outer join ord_file on ord_gen_ord_serial=ord_serial left outer join rep_file on ord_gen_floating=rep_code where (ord_gen_type='Q' and ord_gen_inside ='" + User + "') and (case ord_gen_co_desreq when 1 then ord_gen_co_designer else 1 end)=1 and ord_gen_co_isr=0  and ord_gen_type='Q' order by ord_gen_co_desdate desc"
                'End Select
            End If
            'ds.Clear()
            ds = New DataSet
            cnn2.Open()
            da.Fill(ds)
            Grid1.DataSource = ds.Tables(0)
            Grid1.DataBind()

            If rDesigns.Checked Then
                Grid1.DisplayLayout.Bands(0).Columns("Quote").Header.Caption = "Quote"
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_desreq").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_designer").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_desdate").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_toart").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_ca").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_cadate").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_factoryinstall_req").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_factoryinstall").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_factoryinstall_date").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_designer").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_priority").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_priority_note").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_des_status").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_create_date").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_prod_designstart_note").Hidden = True

                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_des_status").Header.Caption = "Status"
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_designer").Header.Caption = "Designer"
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_priority_note").Header.Caption = "Priority Note"
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_create_date").Header.Caption = "Created"

                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_des_status").Width = 100
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_create_date").Width = 50
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_designer").Width = 60
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_inside").Width = 60
                Grid1.DisplayLayout.Bands(0).Columns("ord_for").Width = 250

                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_start_design").Header.Caption = "Design Start"
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_start_design").Format = "MM-dd-yyyy hh:mm tt"
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_start_design").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_design_required").Header.Caption = "Design Req'd Start"
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_design_required").Format = "MM-dd-yyyy hh:mm tt"
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_design_required").Hidden = False

                lDesigns.Text = CStr(Grid1.Rows.Count) + " Designs"
            ElseIf Me.rISR.Checked Then
                Grid1.DisplayLayout.Bands(0).Columns("Quote").Header.Caption = "Quote"
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_desreq").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_designer").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_desdate").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_toart").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_ca").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_cadate").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_factoryinstall_req").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_factoryinstall").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_factoryinstall_date").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_designer").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_priority_note").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_des_status").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_create_date").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_prod_designstart_note").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_start_design").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_design_required").Hidden = True
            ElseIf rRackDesign.Checked Then
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_desreq").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_designer").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_desdate").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_toart").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_ca").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_cadate").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_factoryinstall_req").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_factoryinstall").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_factoryinstall_date").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_designer").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_priority").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_priority_note").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_des_status").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_create_date").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_prod_designstart_note").Hidden = False

                Try
                    Grid1.DisplayLayout.Bands(0).Columns("ord_prod_designstart").Hidden = True
                    Grid1.DisplayLayout.Bands(0).Columns("ord_prod_designcomplete").Hidden = True
                    Grid1.DisplayLayout.Bands(0).Columns("ord_gen_addon").Hidden = True
                    Grid1.DisplayLayout.Bands(0).Columns("ord_prod_committed").Hidden = True
                    Grid1.DisplayLayout.Bands(0).Columns("Kit/Cust").Hidden = True
                    Grid1.DisplayLayout.Bands(0).Columns("ord_prod_allclear_date").Header.Caption = "To Rack Design"
                    Grid1.DisplayLayout.Bands(0).Columns("ord_prod_committed").Header.Caption = "Committed"
                    Grid1.DisplayLayout.Bands(0).Columns("ord_prod_allclear_date").Header.VisiblePosition = 2
                    Grid1.DisplayLayout.Bands(0).Columns("ord_prod_committed").Header.VisiblePosition = 3
                    Grid1.DisplayLayout.Bands(0).Columns("Kit/Cust").Header.VisiblePosition = 4
                    Grid1.DisplayLayout.Bands(0).Columns("ord_prod_allclear_date").Width = 50
                    Grid1.DisplayLayout.Bands(0).Columns("ord_prod_committed").Width = 50
                Catch

                End Try
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_des_status").Header.Caption = "Status"
                'Grid1.DisplayLayout.Bands(0).Columns("ord_gen_create_date").Header.Caption = "Created"
                Grid1.DisplayLayout.Bands(0).Columns("ord_prod_designstart_note").Header.Caption = "Design Start Note"
                Grid1.DisplayLayout.Bands(0).Columns("Quote").Header.Caption = "Order"
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_des_status").Width = 100
                'Grid1.DisplayLayout.Bands(0).Columns("ord_gen_create_date").Width = 50
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_designer").Width = 60
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_inside").Width = 60
                Grid1.DisplayLayout.Bands(0).Columns("ord_for").Width = 250
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_total").Width = 50
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_start_design").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("ord_gen_design_required").Hidden = True
                lDesigns.Text = CStr(Grid1.Rows.Count) + " Designs"
                pKey.Visible = True
            End If

            Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
            Dim KitCust As Boolean
            For Each rw In Grid1.Rows
                If nz(rw.Cells("ord_gen_co_desdate").Value, CDate("1/1/1900")) = CDate("1/1/1900") Then rw.Cells("ord_gen_co_desdate").Appearance.ForeColor = Color.White
                If nz(rw.Cells("ord_gen_co_cadate").Value, CDate("1/1/1900")) = CDate("1/1/1900") Then rw.Cells("ord_gen_co_cadate").Appearance.ForeColor = Color.White
                If nz(rw.Cells("ord_gen_co_factoryinstall_date").Value, CDate("1/1/1900")) = CDate("1/1/1900") Then rw.Cells("ord_gen_co_factoryinstall_date").Appearance.ForeColor = Color.White

                If rDesigns.Checked Then
                    If rw.Cells("ord_gen_designer").Value = "" Or rw.Cells("ord_gen_designer").Value = "<None>" Then
                        rw.Cells("ord_gen_designer").Value = "Start Design"
                        rw.Cells("ord_gen_designer").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
                        rw.Cells("ord_gen_designer").Column.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
                        rw.Cells("ord_gen_designer").ButtonAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                        rw.Cells("ord_gen_designer").ButtonAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                    End If
                    If nz(rw.Cells("ord_gen_des_status").Value) = "START CHECKING" Then
                        rw.Cells("ord_gen_des_status").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
                        rw.Cells("ord_gen_des_status").Column.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
                        rw.Cells("ord_gen_des_status").ButtonAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                        rw.Cells("ord_gen_des_status").ButtonAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                    End If
                  

                    If rw.Cells("ord_sold_cust_id").Value = "WE" And DateDiff(DateInterval.Day, rw.Cells("ord_gen_create_date").Value, Today) >= 4 Then rw.Appearance.BackColor = Color.LightPink
                    If rw.Cells("ord_sold_cust_id").Value = "IWA" And DateDiff(DateInterval.Day, rw.Cells("ord_gen_create_date").Value, Today) >= 2 Then rw.Appearance.BackColor = Color.LightPink
                    If rw.Cells("ord_sold_cust_id").Value = "SANDY" And DateDiff(DateInterval.Day, rw.Cells("ord_gen_create_date").Value, Today) >= 2 And Split(rw.Cells("quote").Value, "-")(Split(rw.Cells("quote").Value, "-").Length - 1) <> "0" Then rw.Appearance.BackColor = Color.LightPink

                    If Not rw.Cells("ord_gen_design_required").Value Is DBNull.Value Then
                        If rw.Cells("ord_gen_design_required").Value.ToString = "12/31/2120 12:00:00 AM" Or rw.Cells("ord_gen_design_required").Value.ToString = "1/1/1900 12:00:00 AM" Then
                            rw.Cells("ord_gen_design_required").Appearance.ForeColor = Color.White
                            rw.Cells("ord_gen_design_required").Appearance.BackColor = Color.White
                        Else
                            rw.Cells("ord_gen_design_required").Appearance.BackColor = Color.White
                        End If
                    End If
                    If Not rw.Cells("ord_gen_start_design").Value Is DBNull.Value Then

                        If nz(rw.Cells("ord_gen_start_design").Value).ToString = "1/1/1900 12:00:00 AM" Then
                            rw.Cells("ord_gen_start_design").Appearance.ForeColor = Color.White
                            rw.Cells("ord_gen_start_design").Appearance.BackColor = Color.White
                        Else

                            Dim daysdiff = DateDiff(DateInterval.Hour, CDate(rw.Cells("ord_gen_start_design").Value), Now)
                            Dim daysdiffz = DateDiffW(CDate(rw.Cells("ord_gen_start_design").Value), Now)
                            Dim dd = daysdiff + daysdiffz
                            If dd < 0 Then dd = 0
                            'If dd <> 0 Then dd = dd * 24
                            If dd < 24 Then
                                rw.Cells("ord_gen_start_design").Appearance.BackColor = Color.White
                            ElseIf dd > 23 And dd < 48 Then
                                rw.Cells("ord_gen_start_design").Appearance.BackColor = Color.Yellow
                            Else
                                rw.Cells("ord_gen_start_design").Appearance.ForeColor = Color.White
                                rw.Cells("ord_gen_start_design").Appearance.BackColor = Color.Red
                            End If
                        End If
                    End If
                    If rw.Cells("ord_gen_des_status").Value = "" Then
                        rw.Cells("ord_gen_start_design").Appearance.ForeColor = Color.White
                        rw.Cells("ord_gen_start_design").Appearance.BackColor = Color.White
                    End If
                End If
                If rRackDesign.Checked Then
                    If rw.Cells("ord_prod_designstart").Value = False Then
                        rw.Cells("ord_gen_des_status").Value = "Start"
                    ElseIf rw.Cells("ord_prod_designcomplete").Value = False Then
                        rw.Cells("ord_gen_des_status").Value = "Complete"
                    Else
                        rw.Cells("ord_gen_des_status").Value = "To Factory"
                    End If
                    rw.Cells("ord_gen_des_status").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
                    rw.Cells("ord_gen_des_status").Column.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
                    rw.Cells("ord_gen_des_status").ButtonAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                    rw.Cells("ord_gen_des_status").ButtonAppearance.TextHAlign = Infragistics.Win.HAlign.Center

                    rw.Cells("Kit/Cust").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
                    cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(rw.Cells("quote").Text, "-")(0) + " and ord_itm_rev=" + Split(rw.Cells("quote").Text, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='KIT' or ord_itm_prod_type='DESKIT')"
                    KitCust = nz(cmd.ExecuteScalar, 0) > 0
                    cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(rw.Cells("quote").Text, "-")(0) + " and ord_itm_rev=" + Split(rw.Cells("quote").Text, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='TOP' or ord_itm_prod_type='BUD' or ord_itm_prod_type='GOLD')"
                    KitCust = KitCust And (nz(cmd.ExecuteScalar, 0) > 0)
                    rw.Cells("Kit/Cust").Value = KitCust

                    If KitCust Then
                        rw.Appearance.BackColor = Color.Yellow
                    ElseIf nz(rw.Cells("ord_prod_committed").Value, CDate("1/1/1900")) > CDate("1/1/1900") Then
                        rw.Appearance.BackColor = Color.Red
                    ElseIf rw.Cells("ord_gen_addon").Value = True Then
                        rw.Appearance.BackColor = Color.Green
                    End If

                    rw.Cells("ord_prod_designstart_note").Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
                End If
            Next

            cmd.CommandText = "update rep_file set rep_isr_time='" + CStr(Now) + "' where rep_code='" + User + "'"
            cmd.ExecuteNonQuery()
            cnn2.Close()

            Dim col As Infragistics.Win.UltraWinGrid.UltraGridColumn
            For Each col In Grid1.DisplayLayout.Bands(0).Columns
                If col.Hidden = False Then
                    If col.Key = "ord_prod_designstart_note" Then
                        col.CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
                        col.Width = 200
                    Else
                        If col.Key = "ord_gen_des_status" Then
                            col.Width = 150
                        Else
                            col.PerformAutoResize(Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand, True)
                        End If
                        col.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    End If
                End If
            Next

            Grid1.UpdateData()
            onSilentUpdate = False

            MainForm.Toolbar1.Tools("Check Off").SharedProps.AppearancesSmall.Appearance.BackColor = Drawing.Color.Empty
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    DateDiffW(CDate("10/23/2012 11:00"), CDate("10/24/2012 10:00"))
    '    DateDiffW(CDate("10/22/2012 09:00"), CDate("10/24/2012 10:00"))
    '    DateDiffW(CDate("10/21/2012 11:00"), CDate("10/24/2012 10:00"))
    '    DateDiffW(CDate("10/20/2012 08:00"), CDate("10/24/2012 10:00"))
    '    DateDiffW(CDate("10/18/2012 09:00"), CDate("10/24/2012 10:00"))
    'End Sub

    Function DateDiffW(ByVal BegDate, ByVal EndDate)
        Const SUNDAY = 1
        Const SATURDAY = 7
        Dim NumWeeks As Integer
        Dim hr As Integer = 0
        Dim i As Integer

        If BegDate > EndDate Then
            DateDiffW = 0
        Else
            Dim x = DateDiff(DateInterval.Hour, BegDate, EndDate)
            Dim y = x / 24
            Dim z = Math.Truncate(y)
            Dim b = y - z

            If Weekday(BegDate) = 1 Then
                hr = hr - (b * 24)
            End If
            If Weekday(BegDate) = 7 Then
                hr = hr - (b * 24)
            End If

            If z <> 0 Then
                For i = 1 To z
                    If Weekday(DateAdd(DateInterval.Day, (i * -1), EndDate)) = 1 Or Weekday(DateAdd(DateInterval.Day, (i * -1), EndDate)) = 7 Then
                        hr = hr - 24
                    End If
                Next
            End If
            DateDiffW = hr

            'Select Case Weekday(BegDate)
            '    Case SUNDAY : BegDate = DateAdd(DateInterval.Hour, 24, BegDate)
            '    Case SATURDAY : BegDate = DateAdd(DateInterval.Hour, 48, BegDate)
            'End Select
            'Select Case Weekday(EndDate)
            '    Case SUNDAY : EndDate = DateAdd(DateInterval.Hour, -48, EndDate)
            '    Case SATURDAY : EndDate = DateAdd(DateInterval.Hour, -24, EndDate)
            'End Select
            'NumWeeks = DateDiff("ww", BegDate, EndDate)
            'DateDiffW = NumWeeks * 5 + Weekday(EndDate) - Weekday(BegDate)
        End If
    End Function

    Private Sub pUsers_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pUsers.Paint

    End Sub

    Private Sub bClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClear.Click
        Dim cb As CheckBox
        For Each cb In pUsers.Controls
            cb.Checked = False
        Next
        SetUsers()
        LoadGrid()
    End Sub

    Private Sub bCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCheckAll.Click
        Dim cb As CheckBox
        For Each cb In pUsers.Controls
            cb.Checked = True
        Next
        SetUsers()
        LoadGrid()
    End Sub

    Private Sub rISR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rISR.CheckedChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Me.ActiveControl.Name <> "rISR" Then Exit Sub
        SaveSetting("Jcom", "Checkoff", "Section", "ISR")
        If rISR.Checked Then
            bClear.Visible = True
            bCheckAll.Visible = True
            pUsers.Visible = True
            tDesFilter.Visible = False
            bDesFilter.Visible = False
            lDesigns.Visible = False
            pKey.Visible = False
        ElseIf Me.rDesigns.Checked Then
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = True
            bDesFilter.Visible = True
            lDesigns.Visible = True
            pKey.Visible = False
        ElseIf Me.rRackDesign.Checked Then
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = True
            bDesFilter.Visible = True
            lDesigns.Visible = True
            pKey.Visible = True
        Else
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = False
            bDesFilter.Visible = False
            lDesigns.Visible = False
            pKey.Visible = False
        End If
        LoadGrid()
    End Sub

    Private Sub rOperations_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rOperations.CheckedChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Me.ActiveControl.Name <> "rOperations" Then Exit Sub
        SaveSetting("Jcom", "Checkoff", "Section", "Operations")
        If rISR.Checked Then
            bClear.Visible = True
            bCheckAll.Visible = True
            pUsers.Visible = True
            tDesFilter.Visible = False
            bDesFilter.Visible = False
            lDesigns.Visible = False
            pKey.Visible = False
        ElseIf Me.rDesigns.Checked Then
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = True
            bDesFilter.Visible = True
            lDesigns.Visible = True
            pKey.Visible = False
        ElseIf Me.rRackDesign.Checked Then
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = True
            bDesFilter.Visible = True
            lDesigns.Visible = True
            pKey.Visible = True
        Else
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = False
            bDesFilter.Visible = False
            lDesigns.Visible = False
            pKey.Visible = False
        End If
        LoadGrid()
    End Sub

    Private Sub Grid1_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid1.AfterCellUpdate
        If onSilentUpdate Then Exit Sub
        Try
            Select Case e.Cell.Column.Key
                Case "ord_prod_designstart_note"
                    cnn2.Open()
                    cmd.CommandText = "update ord_prod set ord_prod_designstart_note='" + Replace(nz(e.Cell.Value), "'", "''") + "' where ord_prod_ord_serial=" + Split(Grid1.ActiveRow.Cells("quote").Value, "-")(0) + " and ord_prod_rev=" + Split(Grid1.ActiveRow.Cells("quote").Value, "-")(2) + " and ord_prod_type='O'"
                    cmd.ExecuteNonQuery()
                    cnn2.Close()
                    e.Cell.Appearance.BackColor = Color.PaleGreen
            End Select
        Catch ex As Exception
            DoError(Err, Me)
        End Try
    End Sub

    Private Sub Grid1_InitializeLayout_1(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub Grid1_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid1.ClickCellButton
        Select Case e.Cell.Column.Key
            Case "quote"
                Dim fm As fmEstOrd2
                fm = LoadForm("Quotes/Orders")
                fm.KeyValue1 = Split(Grid1.ActiveCell.Text, "-")(0)
                fm.tOrd.Text = fm.KeyValue1
                fm.LoadPage()

                If Me.rDesigns.Checked Then
                    fm.Tab1.Tabs("Q" + Split(Grid1.ActiveCell.Text, "-")(1)).Selected = True
                    fm.TabItems.Tabs("Drawings").Selected = True
                ElseIf rRackDesign.Checked Then
                    fm.Tab1.Tabs("O" + Split(Grid1.ActiveCell.Text, "-")(2)).Selected = True
                    fm.TabItems.Tabs("Drawings").Selected = True
                Else
                    fm.Tab1.Tabs("Q" + Split(Grid1.ActiveCell.Text, "-")(1)).Selected = True
                    fm.TabItems.Tabs("General").Selected = True
                End If
            Case "ord_gen_designer"
                Dim cmd As New SqlClient.SqlCommand("select ord_gen_designer from ord_gen where ord_gen_ord_serial=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(0) + " and ord_gen_rev=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(1) + " and ord_gen_type='Q'", cnn)
                Dim des As String
                cnn.Open()
                des = nz(cmd.ExecuteScalar)
                If des <> "" And des <> "<None>" Then
                    MsgBox(des + " has already started this quote.", MsgBoxStyle.Critical, "Started?")
                    cnn.Close()
                    Exit Sub
                End If
                cmd.CommandText = "update ord_gen set ord_gen_start_design='" + Now.ToString + "',ord_gen_designer='" + User + "',ord_gen_des_status='DESIGN STARTED' where ord_gen_ord_serial=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(0) + " and ord_gen_rev=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(1) + " and ord_gen_type='Q'"
                cmd.ExecuteNonQuery()
                e.Cell.Value = User
                e.Cell.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Default
                e.Cell.Row.Cells("ord_gen_des_status").Value = "DESIGN STARTED"
                cnn.Close()
            Case "ord_gen_des_status"
                Dim cmd As New SqlClient.SqlCommand("", cnn)
                cnn.Open()
                If e.Cell.Value = "START CHECKING" Then
                    cmd.CommandText = "select ord_gen_start_checking from ord_gen where ord_gen_ord_serial=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(0) + " and ord_gen_rev=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(1) + " and ord_gen_type='Q'"
                    Dim des As String
                    'cnn.Open()
                    des = nz2(cmd.ExecuteScalar, CDate("1/1/1900"))
                    If CDate(des) = CDate("1/1/1900") Then
                        cmd.CommandText = "update ord_gen set ord_gen_des_status='CHECKING STARTED', ord_gen_start_checking='" + Now.ToString + "' where ord_gen_ord_serial=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(0) + " and ord_gen_rev=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(1) + " and ord_gen_type='Q'"
                        cmd.ExecuteNonQuery()
                    Else
                        cmd.CommandText = "update ord_gen set ord_gen_des_status='CHECKING STARTED' where ord_gen_ord_serial=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(0) + " and ord_gen_rev=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(1) + " and ord_gen_type='Q'"
                        cmd.ExecuteNonQuery()
                    End If
                    'cnn.Close()
                    Dim fm As fmEstOrd2
                    fm = LoadForm("Quotes/Orders")
                    fm.KeyValue1 = Split(Grid1.ActiveRow.Cells(0).Text, "-")(0)
                    fm.tOrd.Text = fm.KeyValue1
                    fm.LoadPage()

                    fm.Tab1.Tabs("Q" + Split(Grid1.ActiveRow.Cells(0).Text, "-")(1)).Selected = True
                    fm.TabItems.Tabs("Drawings").Selected = True
                Else
                    cmd.CommandText = "INSERT INTO ord_prod_hist SELECT ord_prod_ord_serial, ord_prod_rev, ord_prod_type, ord_prod_date, ord_prod_who, ord_prod_status, ord_prod_must_ship, ord_prod_must_ship_by, ord_prod_must_ship_note, ord_prod_committed, ord_prod_committed_by, ord_prod_committed_note, ord_prod_est_comp, ord_prod_est_comp_by, ord_prod_est_comp_note, ord_prod_art, ord_prod_art_by, ord_prod_art_note, ord_prod_sign_stain, ord_prod_sign_stain_by, ord_prod_sign_stain_dt, ord_prod_signoff, ord_prod_signoff_date, ord_prod_signoff_by, ord_prod_signoff_note, ord_prod_roomnotready, ord_prod_roomnotready_date, ord_prod_roomnotready_by, ord_prod_roomnotready_note, ord_prod_roomrevision, ord_prod_roomrevision_date, ord_prod_roomrevision_by, ord_prod_roomrevision_note, ord_prod_waitingsignoff, ord_prod_waitingsignoff_date, ord_prod_waitingsignoff_by, ord_prod_waitingsignoff_note, ord_prod_signoffrec, ord_prod_signoffrec_date, ord_prod_signoffrec_by, ord_prod_signoffrec_note, ord_prod_allclear, ord_prod_allclear_date, ord_prod_allclear_by, ord_prod_allclear_note, ord_prod_designstart, ord_prod_designstart_date, ord_prod_designstart_by, ord_prod_designstart_note, ord_prod_designcomplete, ord_prod_designcomplete_date, ord_prod_designcomplete_by, ord_prod_designcomplete_note, ord_prod_tofactory, ord_prod_tofactory_date, ord_prod_tofactory_by, ord_prod_tofactory_note, ord_prod_added_to_closed_week, ord_prod_notes_flag, ord_prod_production_note, ord_prod_kitdown, ord_prod_kitdown_date, ord_prod_kitdown_by, ord_prod_kitdown_note, ord_prod_cdrdown, ord_prod_cdrdown_date, ord_prod_cdrdown_by, ord_prod_cdrdown_note FROM  ord_prod WHERE (ord_prod_ord_serial = " + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(0) + ") and (ord_prod_rev=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(2) + ") AND (ord_prod_type = 'O')"
                    cmd.ExecuteNonQuery()
                    Select Case e.Cell.Value
                        Case "Start"
                            cmd.CommandText = "update ord_prod set ord_prod_designstart=1, ord_prod_designstart_by='" + User + "',ord_prod_designstart_date=getdate() where ord_prod_ord_serial=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(0) + " and ord_prod_rev=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(2) + " and ord_prod_type='O'"
                        Case "Complete"
                            cmd.CommandText = "update ord_prod set ord_prod_designcomplete=1, ord_prod_designcomplete_by='" + User + "',ord_prod_designcomplete_date=getdate() where ord_prod_ord_serial=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(0) + " and ord_prod_rev=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(2) + " and ord_prod_type='O'"
                        Case "To Factory"
                            If CheckSecurity("Check Off - Allow To Factory") = 0 Then
                                MsgBox("You do not have permission for this function", MsgBoxStyle.Critical, "Permission?")
                                cnn.Close()
                                Exit Sub
                            End If
                            cmd.CommandText = "update ord_prod set ord_prod_tofactory=1, ord_prod_tofactory_by='" + User + "',ord_prod_tofactory_date=getdate() where ord_prod_ord_serial=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(0) + " and ord_prod_rev=" + Split(Grid1.ActiveRow.Cells("quote").Text, "-")(2) + " and ord_prod_type='O'"
                    End Select
                    cmd.ExecuteNonQuery()
                End If
                If cnn.State <> ConnectionState.Closed Then cnn.Close()
                LoadGrid()
        End Select
    End Sub

    Private Sub chShowTimes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chShowTimes.CheckedChanged
        SaveSetting("Jcom", "Settings", "CheckOffShowTimes", CStr(chShowTimes.Checked))
        SetColumns()
    End Sub
    Private Sub SetColumns()
        Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_desdate").Hidden = Not chShowTimes.Checked
        Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_cadate").Hidden = Not chShowTimes.Checked
        Grid1.DisplayLayout.Bands(0).Columns("ord_gen_co_factoryinstall_date").Hidden = Not chShowTimes.Checked
    End Sub

    Private Sub rDesigns_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rDesigns.CheckedChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Me.ActiveControl.Name <> "rDesigns" Then Exit Sub
        SaveSetting("Jcom", "Checkoff", "Section", "Design")
        If rISR.Checked Then
            bClear.Visible = True
            bCheckAll.Visible = True
            pUsers.Visible = True
            tDesFilter.Visible = False
            bDesFilter.Visible = False
            lDesigns.Visible = False
            pKey.Visible = False
        ElseIf Me.rDesigns.Checked Then
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = True
            bDesFilter.Visible = True
            lDesigns.Visible = True
            pKey.Visible = False
        ElseIf Me.rRackDesign.Checked Then
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = True
            bDesFilter.Visible = True
            lDesigns.Visible = True
            pKey.Visible = True
        Else
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = False
            bDesFilter.Visible = False
            lDesigns.Visible = False
            pKey.Visible = False
        End If
        LoadGrid()
        tDesFilter.Focus()
    End Sub

    Private Sub tDesFilter_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tDesFilter.KeyUp
        If e.KeyCode = Keys.Enter Then LoadGrid()
    End Sub

    Private Sub bDesFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDesFilter.Click
        LoadGrid()
        tDesFilter.SelectAll()
    End Sub

    Private Sub lDesigns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lDesigns.Click

    End Sub

    Private Sub rRackDesign_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rRackDesign.CheckedChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Me.ActiveControl.Name <> "rRackDesign" Then Exit Sub
        SaveSetting("Jcom", "Checkoff", "Section", "RackDesign")
        If rISR.Checked Then
            bClear.Visible = True
            bCheckAll.Visible = True
            pUsers.Visible = True
            tDesFilter.Visible = False
            bDesFilter.Visible = False
            lDesigns.Visible = False
            pKey.Visible = False
        ElseIf Me.rDesigns.Checked Then
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = True
            bDesFilter.Visible = True
            lDesigns.Visible = True
            pKey.Visible = False
        ElseIf Me.rRackDesign.Checked Then
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = True
            bDesFilter.Visible = True
            lDesigns.Visible = True
            pKey.Visible = True
        Else
            bClear.Visible = False
            bCheckAll.Visible = False
            pUsers.Visible = False
            tDesFilter.Visible = False
            bDesFilter.Visible = False
            lDesigns.Visible = False
            pKey.Visible = False
        End If
        LoadGrid()
        tDesFilter.Focus()
    End Sub


    
End Class
