Imports System.Data.SqlClient
Public Class fmPayment
    Inherits WineCellar.fmStarter
    Public dsOrds As New DataSet
    Public daOrds As New SqlDataAdapter
    Public dsMeth As New DataSet
    Public toApply As Double
    Dim onMeth As String = ""
    Dim FillGridType As String = ""
    Friend WithEvents tCompany As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lcc As Infragistics.Win.Misc.UltraLabel
    Dim FillGridData As String = ""

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
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lCust As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tMeth As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tExp As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tAuth As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents tAmt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tOrd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tCust As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tApply As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tApplied As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents bRefresh As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_ord_serial")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_rev")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_for")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_ship_name")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_sold_company")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_total")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_balance")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Amount")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 0")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 1")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.lCust = New Infragistics.Win.Misc.UltraLabel
        Me.tDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.tMeth = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tExp = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tAuth = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.tAmt = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.tApply = New Infragistics.Win.Misc.UltraLabel
        Me.tOrd = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tCust = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tID = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.tApplied = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.bRefresh = New Infragistics.Win.Misc.UltraButton
        Me.tCompany = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel
        Me.lcc = New Infragistics.Win.Misc.UltraLabel
        CType(Me.tDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tMeth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAuth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tApplied, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraLabel31
        '
        Me.UltraLabel31.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel31.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel31.TabIndex = 26
        Me.UltraLabel31.Text = "Order Number"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 40)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel1.TabIndex = 28
        Me.UltraLabel1.Text = "Customer ID"
        '
        'UltraLabel2
        '
        Appearance1.ForeColor = System.Drawing.Color.Gray
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(40, 24)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(32, 16)
        Me.UltraLabel2.TabIndex = 30
        Me.UltraLabel2.Text = "or"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel3.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(866, 8)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(72, 24)
        Me.UltraLabel3.TabIndex = 31
        Me.UltraLabel3.Text = "Billing ID"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.BorderColor = System.Drawing.Color.Gray
        Me.UltraLabel4.Appearance = Appearance2
        Me.UltraLabel4.BackColorInternal = System.Drawing.Color.Gray
        Me.UltraLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabel4.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 64)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(1026, 4)
        Me.UltraLabel4.TabIndex = 33
        '
        'lCust
        '
        Me.lCust.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.lCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCust.Location = New System.Drawing.Point(240, 40)
        Me.lCust.Name = "lCust"
        Me.lCust.Size = New System.Drawing.Size(632, 24)
        Me.lCust.TabIndex = 34
        '
        'tDate
        '
        Me.tDate.Enabled = False
        Me.tDate.Location = New System.Drawing.Point(64, 96)
        Me.tDate.Name = "tDate"
        Me.tDate.Size = New System.Drawing.Size(88, 21)
        Me.tDate.TabIndex = 4
        Me.tDate.Tag = "Edit;pay_date;dt"
        '
        'tMeth
        '
        Me.tMeth.CheckedListSettings.CheckStateMember = ""
        Me.tMeth.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tMeth.Enabled = False
        Me.tMeth.Location = New System.Drawing.Point(160, 96)
        Me.tMeth.Name = "tMeth"
        Me.tMeth.Size = New System.Drawing.Size(152, 22)
        Me.tMeth.TabIndex = 5
        Me.tMeth.Tag = "Edit;pay_method"
        '
        'tNum
        '
        Me.tNum.Enabled = False
        Me.tNum.Location = New System.Drawing.Point(320, 96)
        Me.tNum.MaxLength = 40
        Me.tNum.Name = "tNum"
        Me.tNum.Size = New System.Drawing.Size(144, 21)
        Me.tNum.TabIndex = 6
        Me.tNum.Tag = "Edit;pay_num"
        '
        'tExp
        '
        Me.tExp.Enabled = False
        Me.tExp.Location = New System.Drawing.Point(472, 96)
        Me.tExp.Name = "tExp"
        Me.tExp.Size = New System.Drawing.Size(88, 21)
        Me.tExp.TabIndex = 7
        Me.tExp.Tag = "Edit;pay_exp_date"
        '
        'tAuth
        '
        Me.tAuth.Enabled = False
        Me.tAuth.Location = New System.Drawing.Point(632, 96)
        Me.tAuth.Name = "tAuth"
        Me.tAuth.Size = New System.Drawing.Size(120, 21)
        Me.tAuth.TabIndex = 9
        Me.tAuth.Tag = "Edit;pay_auth_code"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(0, 104)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel5.TabIndex = 40
        Me.UltraLabel5.Text = "Deposited"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(160, 120)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel6.TabIndex = 41
        Me.UltraLabel6.Text = "Method"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(320, 120)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(146, 24)
        Me.UltraLabel7.TabIndex = 42
        Me.UltraLabel7.Text = "Number"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(472, 120)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel8.TabIndex = 43
        Me.UltraLabel8.Text = "Expiration"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(632, 120)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(120, 24)
        Me.UltraLabel9.TabIndex = 44
        Me.UltraLabel9.Text = "Authorization Code"
        '
        'UltraLabel10
        '
        Me.UltraLabel10.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(760, 120)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(88, 24)
        Me.UltraLabel10.TabIndex = 46
        Me.UltraLabel10.Text = "Total Amount"
        '
        'tAmt
        '
        Me.tAmt.Enabled = False
        Me.tAmt.Location = New System.Drawing.Point(760, 96)
        Me.tAmt.Name = "tAmt"
        Me.tAmt.Size = New System.Drawing.Size(88, 21)
        Me.tAmt.TabIndex = 10
        Me.tAmt.Tag = "Edit;pay_amt;cu"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance13.BackColor = System.Drawing.Color.Green
        Appearance13.BackColor2 = System.Drawing.Color.MediumSpringGreen
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.Grid1.DisplayLayout.Appearance = Appearance13
        Me.Grid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 102
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Order"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MinWidth = 75
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn2.Width = 81
        UltraGridColumn3.Header.Caption = "Rev"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MinWidth = 35
        UltraGridColumn3.Width = 35
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "For"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 119
        UltraGridColumn5.Header.Caption = "Shipping Name"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 178
        UltraGridColumn6.Header.Caption = "Company"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 167
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Format = "$###,###,##0.00"
        UltraGridColumn7.Header.Caption = "Total"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 72
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.FontData.BoldAsString = "True"
        UltraGridColumn8.CellAppearance = Appearance14
        UltraGridColumn8.Format = "$###,###,##0.00"
        UltraGridColumn8.Header.Caption = "Balance"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 81
        Appearance15.BackColor = System.Drawing.Color.White
        UltraGridColumn9.CellAppearance = Appearance15
        UltraGridColumn9.Format = "$###,###,##0.00"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn9.Width = 81
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 87
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Width = 125
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.InterBandSpacing = 10
        Me.Grid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.Grid1.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.CardAreaAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.Color.MediumSpringGreen
        Appearance17.BackColor2 = System.Drawing.Color.Green
        Appearance17.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.None
        Me.Grid1.DisplayLayout.Override.CellAppearance = Appearance17
        Me.Grid1.DisplayLayout.Override.CellSpacing = 2
        Appearance18.BackColor = System.Drawing.Color.PaleGreen
        Appearance18.FontData.BoldAsString = "True"
        Appearance18.FontData.Name = "Verdana"
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextHAlignAsString = "Left"
        Appearance18.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid1.DisplayLayout.Override.HeaderAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.RowAppearance = Appearance19
        Appearance20.BackColor = System.Drawing.Color.Green
        Me.Grid1.DisplayLayout.Override.RowSelectorAppearance = Appearance20
        Me.Grid1.DisplayLayout.Override.RowSelectorWidth = 10
        Me.Grid1.DisplayLayout.Override.RowSpacingAfter = 0
        Me.Grid1.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance21.BackColor = System.Drawing.Color.Green
        Appearance21.BackColor2 = System.Drawing.Color.MediumSpringGreen
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.Grid1.DisplayLayout.Override.SelectedRowAppearance = Appearance21
        Me.Grid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid1.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 144)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1038, 416)
        Me.Grid1.TabIndex = 11
        '
        'UltraLabel11
        '
        Me.UltraLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel11.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(742, 568)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(133, 24)
        Me.UltraLabel11.TabIndex = 48
        Me.UltraLabel11.Text = "Amount to Apply"
        '
        'tApply
        '
        Me.tApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance12.TextHAlignAsString = "Right"
        Me.tApply.Appearance = Appearance12
        Me.tApply.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.tApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tApply.Location = New System.Drawing.Point(902, 568)
        Me.tApply.Name = "tApply"
        Me.tApply.Size = New System.Drawing.Size(112, 24)
        Me.tApply.TabIndex = 49
        Me.tApply.Text = "$0.00"
        '
        'tOrd
        '
        Me.tOrd.Enabled = False
        Me.tOrd.Location = New System.Drawing.Point(120, 8)
        Me.tOrd.Name = "tOrd"
        Me.tOrd.Size = New System.Drawing.Size(112, 21)
        Me.tOrd.TabIndex = 0
        Me.tOrd.TabStop = False
        Me.tOrd.Tag = "Edit"
        '
        'tCust
        '
        Me.tCust.Enabled = False
        Me.tCust.Location = New System.Drawing.Point(120, 40)
        Me.tCust.Name = "tCust"
        Me.tCust.Size = New System.Drawing.Size(112, 21)
        Me.tCust.TabIndex = 1
        Me.tCust.TabStop = False
        Me.tCust.Tag = "Edit;pay_cust_id"
        '
        'tID
        '
        Me.tID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tID.Enabled = False
        Me.tID.Location = New System.Drawing.Point(938, 8)
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(96, 21)
        Me.tID.TabIndex = 50
        Me.tID.Tag = "key;pay_serial;nm"
        '
        'UltraLabel12
        '
        Me.UltraLabel12.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(0, 80)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel12.TabIndex = 52
        Me.UltraLabel12.Text = "Applied"
        '
        'tApplied
        '
        Me.tApplied.Enabled = False
        Me.tApplied.Location = New System.Drawing.Point(64, 72)
        Me.tApplied.Name = "tApplied"
        Me.tApplied.Size = New System.Drawing.Size(88, 21)
        Me.tApplied.TabIndex = 3
        Me.tApplied.Tag = "Edit;pay_applied;dt"
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.Enabled = False
        Me.UltraTextEditor1.Location = New System.Drawing.Point(568, 96)
        Me.UltraTextEditor1.MaxLength = 4
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(56, 21)
        Me.UltraTextEditor1.TabIndex = 8
        Me.UltraTextEditor1.Tag = "Edit;pay_sec_code"
        '
        'UltraLabel13
        '
        Me.UltraLabel13.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(568, 120)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(62, 24)
        Me.UltraLabel13.TabIndex = 54
        Me.UltraLabel13.Text = "Sec Code"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Transfer"
        '
        'bRefresh
        '
        Me.bRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bRefresh.Location = New System.Drawing.Point(8, 568)
        Me.bRefresh.Name = "bRefresh"
        Me.bRefresh.Size = New System.Drawing.Size(96, 24)
        Me.bRefresh.TabIndex = 55
        Me.bRefresh.Text = "Refresh"
        '
        'tCompany
        '
        Me.tCompany.Enabled = False
        Me.tCompany.Location = New System.Drawing.Point(352, 7)
        Me.tCompany.Name = "tCompany"
        Me.tCompany.Size = New System.Drawing.Size(149, 21)
        Me.tCompany.TabIndex = 56
        Me.tCompany.TabStop = False
        Me.tCompany.Tag = "Edit"
        '
        'UltraLabel14
        '
        Me.UltraLabel14.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(265, 7)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(87, 24)
        Me.UltraLabel14.TabIndex = 57
        Me.UltraLabel14.Text = "Company"
        '
        'lcc
        '
        Me.lcc.BackColorInternal = System.Drawing.Color.YellowGreen
        Me.lcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcc.Location = New System.Drawing.Point(320, 80)
        Me.lcc.Name = "lcc"
        Me.lcc.Size = New System.Drawing.Size(146, 18)
        Me.lcc.TabIndex = 58
        Me.lcc.Text = "Last 4 digits only"
        Me.lcc.Visible = False
        '
        'fmPayment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1042, 614)
        Me.Controls.Add(Me.lcc)
        Me.Controls.Add(Me.tCompany)
        Me.Controls.Add(Me.UltraLabel14)
        Me.Controls.Add(Me.bRefresh)
        Me.Controls.Add(Me.UltraLabel13)
        Me.Controls.Add(Me.tApplied)
        Me.Controls.Add(Me.tDate)
        Me.Controls.Add(Me.UltraTextEditor1)
        Me.Controls.Add(Me.UltraLabel12)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.tCust)
        Me.Controls.Add(Me.tOrd)
        Me.Controls.Add(Me.tApply)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.tAmt)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.tAuth)
        Me.Controls.Add(Me.tExp)
        Me.Controls.Add(Me.tNum)
        Me.Controls.Add(Me.tMeth)
        Me.Controls.Add(Me.lCust)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraLabel31)
        Me.Menu = Me.MainMenu1
        Me.Name = "fmPayment"
        Me.Text = "Payments"
        CType(Me.tDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tMeth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAuth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tApplied, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCompany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub tOrd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FillGrid(ByVal Typex As String, ByVal Datax As String)
        Try
            Dim cmd As New SqlCommand
            Dim da As New SqlDataAdapter

            FillGridType = Typex
            FillGridData = Datax
            dsOrds.Clear()
            Select Case Typex
                Case "O"
                    cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_rev,ord_for,ord_gen_ship_name,ord_sold_company,ord_gen_total,ord_gen_balance,0.00 as Amount from ord_gen,ord_file where ord_gen_ord_serial=ord_serial and ord_gen_ord_serial=" + Datax + " and ord_gen_type='O' and ord_gen_status<>'CANCELED' order by ord_gen_ord_serial"
                Case "C"
                    cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_rev,ord_for,ord_gen_ship_name,ord_sold_company,ord_gen_total,ord_gen_balance,0.00 as Amount from ord_gen,ord_file,cust_file where ord_gen_ord_serial=ord_serial and ord_sold_cust_serial=cust_serial and cust_id='" + Datax + "' and ord_gen_type='O' and ord_gen_balance<>0 and ord_gen_status<>'CANCELED' order by ord_gen_ord_serial"
                Case "Comp"
                    cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_rev,ord_for,ord_gen_ship_name,ord_sold_company,ord_gen_total,ord_gen_balance,0.00 as Amount from ord_gen,ord_file,cust_file where ord_gen_ord_serial=ord_serial and ord_sold_cust_serial=cust_serial and cust_company like '%" + Datax + "%' and ord_gen_type='O' and ord_gen_balance<>0 and ord_gen_status<>'CANCELED' order by ord_gen_ord_serial"
            End Select
            cmd.Connection = cnn
            da.SelectCommand = cmd
            cnn.Open()
            da.Fill(dsOrds, "ord_file")
            cnn.Close()
            Grid1.DataSource = dsOrds
            Grid1.DataBind()
            tOrd.Enabled = False
            tCust.Enabled = False
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Private Sub RefreshGrid()
        bRefresh.Enabled = False
        Try
            Dim cmd As New SqlCommand
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable
            Dim rw1, rw2 As DataRow
            Dim found As Boolean

            If FillGridType = "O" Then
                cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_rev,ord_for,ord_gen_ship_name,ord_gen_total,ord_gen_balance,0.00 as Amount from ord_gen,ord_file where ord_gen_ord_serial=ord_serial and ord_gen_ord_serial=" + FillGridData + " and ord_gen_type='O' and ord_gen_status<>'CANCELED' order by ord_gen_ord_serial"
            Else
                cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_rev,ord_for,ord_gen_ship_name,ord_gen_total,ord_gen_balance,0.00 as Amount from ord_gen,ord_file,cust_file where ord_gen_ord_serial=ord_serial and ord_sold_cust_serial=cust_serial and cust_id='" + FillGridData + "' and ord_gen_type='O' and ord_gen_balance<>0 and ord_gen_status<>'CANCELED' order by ord_gen_ord_serial"
            End If
            cmd.Connection = cnn
            da.SelectCommand = cmd
            cnn.Open()
            da.Fill(dt)
            cnn.Close()

            For Each rw1 In dt.Rows
                found = False
                For Each rw2 In dsOrds.Tables("ord_file").Rows
                    If rw1("ord_gen_serial") = rw2("ord_gen_serial") Then
                        found = True
                        rw2("ord_gen_balance") = rw1("ord_gen_balance")
                        rw2("ord_gen_total") = rw1("ord_gen_total")
                    End If
                Next
                If found = False Then
                    rw2 = dsOrds.Tables("ord_file").NewRow
                    rw2.ItemArray = rw1.ItemArray
                    dsOrds.Tables("ord_file").Rows.Add(rw2)
                End If
            Next
            Grid1.DataBind()
        Catch
            DoError(Err, MainForm)
        End Try
        bRefresh.Enabled = True
    End Sub

    Private Sub fmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Table = "pay_file"
            Me.Key1 = "pay_serial"
            Me.FocusField = "tOrd"
            tOrd.Focus()

            LoadDD(tMeth, dsMeth, "meth_file", "meth_type", "meth_type")
            tMeth.DropDownWidth = 200
        Catch
            DoError(Err, MainForm)
        End Try

    End Sub

    Public Overrides Sub Add_After()
        Try
            Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            tDate.Value = Today
            tApplied.Value = Today
            tOrd.Enabled = True
            tCust.Enabled = True
        Catch
            DoError(Err, MainForm)
        End Try

    End Sub
    Public Overrides Sub Find()
        Try
            ClearFields(Me.Controls, False)
            dsOrds.Clear()
            EditButtons("Blank")

            Dim fm As New fmFind
            Dim flds As jFld
            fm.frm = Me
            fm.Sort = "pay_date desc"

            fm.flds = New Collection

            flds = New jFld
            flds.Field = "pay_serial"
            flds.FieldName = "Payment Number"
            flds.FieldType = "Numeric"
            flds.Searchable = True
            fm.flds.Add(flds)

            flds = New jFld
            flds.Field = "pay_cust_id"
            flds.FieldName = "Customer ID"
            flds.FieldType = "String"
            flds.Searchable = True
            fm.flds.Add(flds)

            flds = New jFld
            flds.Field = "pay_num"
            flds.FieldName = "Reference Number"
            flds.FieldType = "String"
            flds.Searchable = True
            fm.flds.Add(flds)

            fm.ShowDialog()
            If KeyValue1 = "" Then Exit Sub
            LoadPage()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Sub LoadPage()
        LoadFields(Me)
        EditButtons("Idle")
        'LoadGrid(Grid1, daOrds, dsOrds, "select ord_gen_serial,ord_gen_ord_serial,ord_gen_total,ord_gen_balance,pay_itm_amt from pay_itm,ord_gen where pay_itm_ord_gen_serial=ord_gen_serial and pay_itm_serial=" + KeyValue1, "ord_file")
        LoadGrid(Grid1, daOrds, dsOrds, "select ord_gen_serial,ord_gen_ord_serial,ord_gen_rev,ord_for,ord_ship_name,ord_gen_total,ord_gen_balance,pay_itm_amt as Amount from pay_itm,ord_file,ord_gen where pay_itm_ord_gen_serial=ord_gen_serial and ord_gen_ord_serial=ord_serial and pay_itm_pay_serial=" + KeyValue1, "ord_file")
        'LoadGrid(Grid2, daItemProdMar, dsItemProdMar, "select * from cust_prod_mar where cust_prod_mar_cust_serial='" + KeyValue1 + "'", "parts")

    End Sub

    Private Sub DoTotal()
        Try
            Dim x As Integer
            Dim t As Double
            t = 0
            For x = 0 To Grid1.Rows.Count - 1
                If Not Grid1.Rows(x).Cells("Amount").Value Is DBNull.Value Then
                    If IsNumeric(Grid1.Rows(x).Cells("Amount").Value) Then
                        t = t + Grid1.Rows(x).Cells("Amount").Value
                    End If
                End If
            Next
            If Not IsNumeric(tAmt.Text) Then tAmt.Text = "$0.00"
            toApply = tAmt.Value - t
            tApply.Text = FormatCurrency(toApply)
        Catch
            DoError(Err, Me)
        End Try

    End Sub
    Private Sub tAmt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAmt.LostFocus
        DoTotal()
    End Sub

    Public Overrides Sub Save_After()
        'If tID.Text <> "" Then Exit Sub
        Dim x As Integer
        Dim cmd As New SqlCommand
        Dim Trans As SqlTransaction
        Dim Pay As Double
        Dim row As DataRow
        Dim dr As SqlDataReader

        Try
            cmd.Connection = cnn
            cnn.Open()
            'Trans = cnn.BeginTransaction
            'cmd.Transaction = Trans
            tID.Text = KeyValue1
            'BalanceCheck("Payment Save_After " + EditMode + " " + KeyValue1)
            cmd.CommandText = "delete from pay_itm where pay_itm_pay_serial=" + KeyValue1
            cmd.ExecuteNonQuery()
            'If onMeth = "Balance Transfer" Then
            '    If onMeth <> tMeth.Text Then
            '        cmd.CommandText = "delete from ref_ledger where ref_ledger_ref='TRANSFER' and ref_ledger_refnum=" + CStr(KeyValue1)
            '        cmd.ExecuteNonQuery()
            '    End If
            'End If
            onMeth = ""
            Do While cmd.Connection.State = ConnectionState.Executing
            Loop
            'For x = 0 To Grid1.Rows.Count - 1
            For Each row In dsOrds.Tables("ord_file").Rows
                If IsNumeric(nz(row("ord_gen_ord_serial"), "")) Then
                    cmd.CommandText = "insert into pay_itm (pay_itm_pay_serial,pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,pay_itm_amt) values ("
                    cmd.CommandText = cmd.CommandText + tID.Text + ","
                    cmd.CommandText = cmd.CommandText + CStr(nz(row("ord_gen_serial"), 0)) + ","
                    cmd.CommandText = cmd.CommandText + CStr(nz(row("ord_gen_ord_serial"), 0)) + ","
                    cmd.CommandText = cmd.CommandText + CStr(nz(row("ord_gen_rev"), 0)) + ","
                    cmd.CommandText = cmd.CommandText + CStr(nz(row("Amount"), 0)) + ")"
                    cmd.ExecuteNonQuery()
                    Do While cmd.Connection.State = ConnectionState.Executing
                    Loop

                    If row("amount") <> 0 Then
                        cmd.CommandText = "select sum(pay_itm_amt) as pay from pay_itm where pay_itm_ord_gen_serial=" + CStr(row("ord_gen_serial"))
                        Pay = cmd.ExecuteScalar
                        Do While cnn.State = ConnectionState.Executing
                        Loop
                        cmd.CommandText = "update ord_gen set ord_gen_balance=ord_gen_total - (" + CStr(Pay) + ") where ord_gen_serial=" + CStr(row("ord_gen_serial"))
                        cmd.ExecuteNonQuery()
                        Do While cnn.State = ConnectionState.Executing
                        Loop
                        cmd.CommandText = "select ord_gen_ord_serial,ord_gen_rev,ord_gen_type from ord_gen where ord_gen_serial=" + CStr(row("ord_gen_serial"))
                        dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            dr.Read()
                            'If tMeth.Text = "Balance Transfer" Then
                            '    CheckRefTransfer(dr("ord_gen_ord_serial"), dr("ord_gen_rev"), dr("ord_gen_type"), KeyValue1, row("amount"))
                            'Else
                            CheckReferral(dr("ord_gen_ord_serial"), dr("ord_gen_rev"), dr("ord_gen_type"), tMeth.Text, KeyValue1)
                            'End If
                        End If
                        dr.Close()
                        'BalanceCheck("Payment Save_after " + cmd.CommandText)
                    End If
                End If
            Next
            cnn.Close()
            SetCommission(KeyValue1)
            'Trans.Commit()
            'BalanceCheck("Payment Save_After " + EditMode)
        Catch
            'Trans.Rollback()
            DoError(Err, MainForm)
        Finally
            If cnn.State <> ConnectionState.Closed Then cnn.Close()
        End Try
    End Sub
    'Private Sub CheckRefTransfer(ByVal Ord As Long, ByVal Rev As Integer, ByVal Type As String, ByVal PaySerial As Long, ByVal Amt As Double)
    '    Dim cnnx As New SqlConnection(cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'")
    '    Dim cmd As New SqlCommand("select ref_ledger_serial from ref_ledger where ref_ledger_ref='TRANSFER' and ref_ledger_refnum=" + CStr(PaySerial) + " and ref_ledger_ord_serial=" + CStr(Ord) + " and ref_ledger_ord_rev=" + CStr(Rev) + " and ref_ledger_ord_type='" + Type + "'", cnnx)
    '    Dim onRef As Long
    '    Dim onPerc As Double

    '    cnnx.Open()
    '    onRef = nz(cmd.ExecuteScalar, 0)
    '    cmd.CommandText = "select ord_ref_perc from ord_file where ord_serial=" + CStr(Ord)
    '    onPerc = CDbl(nz(cmd.ExecuteScalar, "0"))
    '    If onPerc <> 0 Then
    '        If onRef = 0 Then
    '            cmd.CommandText = "insert into ref_ledger (ref_ledger_ord_serial,ref_ledger_ord_rev,ref_ledger_ord_type,ref_ledger_ref,ref_ledger_refnum,ref_ledger_amt,ref_ledger_user,ref_ledger_date) values (" + CStr(Ord) + "," + CStr(Rev) + ",'" + Type + "','TRANSFER'," + CStr(PaySerial) + "," + CStr(Math.Round(Amt * onPerc / 100, 2)) + ",'" + User + "','" + CStr(Now) + "')"
    '        Else
    '            cmd.CommandText = "update ref_ledger set ref_ledger_amt=" + CStr(Math.Round(Amt * onPerc / 100, 2)) + ",ref_ledger_user='" + User + "',ref_ledger_date='" + CStr(Now) + "' where ref_ledger_serial=" + CStr(onRef)
    '        End If
    '        cmd.ExecuteNonQuery()
    '    End If
    '    cnnx.Close()
    'End Sub
    Public Overrides Sub Save_Before()
        Try
            If Math.Round(toApply, 2) <> 0 Then
                MsgBox("You must first apply all of the money. (" + FormatCurrency(toApply) + ")", MsgBoxStyle.Exclamation, "Money Applied?")
                Me.SaveCanceled = True
                DoTotal()
                Exit Sub
            End If
            If tMeth.Text = "Balance Transfer" And tAmt.Value = 0 Then
                MsgBox("You may no longer put balance transfers on one payment. You must enter each transfer indvidually.")
                Me.SaveCanceled = True
                Exit Sub
            End If
            Grid1.Update()
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Public Overrides Sub Delete()
        If Me.SecLevel < jDelete Then
            MsgBox("You do not have DELETE access to this screen.", MsgBoxStyle.Exclamation, "Access?")
            Exit Sub
        End If
        Dim x As Integer
        Dim cmd As New SqlCommand
        Dim Trans As SqlTransaction

        Try
            If UserGroup = "Admins" Then
                If tApplied.Value < AcctLocked Then
                    MsgBox("This payment was applied prior to the Accounting closed month.  You may not delete this payment.", MsgBoxStyle.Information, "Applied?")
                    Exit Sub
                End If
            Else
                If tApplied.Value < Date.Today Then
                    MsgBox("This payment was applied prior to today.  You may not delete this payment.", MsgBoxStyle.Information, "Applied?")
                    Exit Sub
                End If
            End If
            If MsgBox("This will delete this payment and put the balances back onto the orders.  Do you wanto to procede?", MsgBoxStyle.YesNo, "Delete?") = MsgBoxResult.No Then Exit Sub
            cmd.Connection = cnn
            cnn.Open()
            Trans = cnn.BeginTransaction
            cmd.Transaction = Trans
            tID.Text = KeyValue1
            For x = 0 To Grid1.Rows.Count - 1
                If IsNumeric(Grid1.Rows(x).Cells("ord_gen_ord_serial").Value) Then
                    cmd.CommandText = "update ord_gen set ord_gen_balance=" + CStr(Grid1.Rows(x).Cells("ord_gen_balance").Value + Grid1.Rows(x).Cells("Amount").Value) + " where ord_gen_serial=" + Grid1.Rows(x).Cells("ord_gen_serial").Text
                    cmd.ExecuteNonQuery()
                End If
            Next
            cmd.CommandText = "delete from pay_itm where pay_itm_pay_serial=" + KeyValue1
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from pay_file where pay_serial=" + KeyValue1
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from comm_file where comm_pay_serial=" + KeyValue1
            cmd.ExecuteNonQuery()
            Trans.Commit()
            DelRecord("pay_file", KeyValue1)
            ClearFields(Me.Controls, False)
            dsOrds.Clear()
            EditButtons("Blank")
            'BalanceCheck("Delete Payment")
        Catch
            Trans.Rollback()
            DoError(Err, MainForm)
        Finally
            cnn.Close()
        End Try

    End Sub

    Public Overrides Sub Edit_After()
        onMeth = tMeth.Text
        Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
    End Sub

    Private Sub Grid1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Enter
        If Grid1.Rows.Count > 0 Then
            Grid1.Rows(0).Cells("Amount").Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
            Grid1.Rows(0).Cells("Amount").Activate()
        End If
    End Sub

    Public Sub tOrd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tOrd.Leave
        Try
            If tOrd.Text = "" Then
                'MsgBox("Must be a NUMBER.", MsgBoxStyle.Exclamation, "Number?")
                Exit Sub
            End If
            Dim cmd As New SqlCommand("select cust_id,ord_sold_name from ord_file,cust_file where ord_sold_cust_id=cust_id and ord_serial=" + tOrd.Text, cnn)
            Dim dr As SqlDataReader
            cnn.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                tCust.Text = dr("cust_id")
                lCust.Text = dr("ord_sold_name")
            End If
            dr.Close()
            cnn.Close()
            FillGrid("O", tOrd.Text)
            tDate.Focus()
        Catch
            DoError(Err, MainForm)
        End Try

    End Sub

    Private Sub tCust_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCust.Leave
        Try
            If tCust.Text = "" Then
                'MsgBox("Must be a NUMBER.", MsgBoxStyle.Exclamation, "Number?")
                tCust.Focus()
                Exit Sub
            End If
            Dim cmd As New SqlCommand("select cust_company from cust_file where cust_id='" + tCust.Text + "'", cnn)
            Dim dr As SqlDataReader
            cnn.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                lCust.Text = nz(dr("cust_company"), "")
            End If
            dr.Close()
            cnn.Close()
            FillGrid("C", tCust.Text)
            tDate.Focus()
        Catch
            DoError(Err, MainForm)
        End Try

    End Sub


    Public Overrides Sub Add_Before()
        dsOrds.Clear()
    End Sub

    Private Sub Grid1_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid1.ClickCellButton
        Try
            If Grid1.ActiveRow Is Nothing Then Exit Sub
            Select Case e.Cell.Column.Header.Caption
                Case "Amount"
                    If Grid1.ActiveRow.Cells("Amount").Value Is DBNull.Value Then Exit Sub
                    Grid1.ActiveRow.Cells("Amount").Value = nz(Grid1.ActiveRow.Cells("ord_gen_balance").Value, 0)
                Case "Order"
                    Dim fm As fmEstOrd2
                    fm = LoadForm("Quotes/Orders")
                    If fm.EditMode <> "" Then
                        MsgBox("You must first save or cancel this Quote/Order", MsgBoxStyle.Information, "Save?")
                        fm = Nothing
                        Exit Sub
                    End If
                    fm.KeyValue1 = Grid1.ActiveRow.Cells(1).Text
                    fm.tOrd.Text = fm.KeyValue1
                    fm.LoadPage()
                    fm.Tab1.Tabs("O" + Grid1.ActiveRow.Cells(2).Text).Selected = True
                    fm.TabItems.Tabs("Payments").Selected = True
            End Select
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Private Sub Grid1_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid1.AfterCellUpdate
        DoTotal()

    End Sub

    Private Sub tCust_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCust.ValueChanged

    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub tOrd_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tOrd.ValueChanged

    End Sub

    Public Overrides Sub Cancel_After()
        dsOrds.Clear()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim fm As New fmPaymentTransfer
        fm.ShowDialog()
    End Sub

    Public Overrides Sub Edit_Before()
        If tApplied.Value <= AcctLocked Then
            MsgBox("This payment was applied prior to the accounting locked date of " + CStr(AcctLocked) + ".  You may not edit this payment.", MsgBoxStyle.Information, "Applied?")
            EditCanceled = True
            Exit Sub
        End If
    End Sub

    Private Sub Grid1_BeforeCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles Grid1.BeforeCellUpdate
        Try
            If Grid1.ActiveCell.Column.Header.Caption = "Amount" Then
                If InStr(Grid1.ActiveCell.Text, "$") > 0 Then
                    MsgBox("Do not enter the $ for amounts", MsgBoxStyle.Information, "$$$")
                    e.Cancel = True
                End If
            End If
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Private Sub bRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRefresh.Click
        Me.RefreshGrid()
    End Sub

    Private Sub tCompany_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCompany.Leave
        Try
            If tCompany.Text = "" Then
                'MsgBox("Must be a NUMBER.", MsgBoxStyle.Exclamation, "Number?")
                tCompany.Focus()
                Exit Sub
            End If
            Dim cmd As New SqlCommand("select cust_company from cust_file where cust_company like '%" + tCompany.Text + "%'", cnn)
            Dim dr As SqlDataReader
            cnn.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                lCust.Text = nz(dr("cust_company"), "")
            End If
            dr.Close()
            cnn.Close()
            FillGrid("Comp", tCompany.Text)
            tDate.Focus()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Private Sub tCompany_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCompany.ValueChanged

    End Sub

    
    Private Sub tMeth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tMeth.ValueChanged
        If ActiveControl Is tMeth Then
            Select Case tMeth.Value
                Case "Visa", "American Express", "Master Card"
                    tNum.MaxLength = 4
                    lcc.Visible = True
                    'UltraTextEditor1.Enabled = False
                    'tAuth.Enabled = False
                    'tExp.Enabled = False
                Case Else
                    tNum.MaxLength = 40
                    lcc.Visible = False
                    'UltraTextEditor1.Enabled = True
                    'tAuth.Enabled = True
                    'tExp.Enabled = True
            End Select
        End If
    End Sub
End Class
