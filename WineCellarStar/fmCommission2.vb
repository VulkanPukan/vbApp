Imports System.Data.SqlClient
Public Class fmCommission2
    Inherits System.Windows.Forms.Form
    Dim dsComm As New DataSet
    Dim dsBonus As New DataSet
    Dim daBonus As New SqlDataAdapter
    Dim dsCat As New DataSet
    Dim dsRep As New DataSet
    Dim UserLevel As String
    Dim Ret, Con, MR, MD As Double
    Dim onSalesCat As String
    Dim UserName As String = User
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
    Friend WithEvents lName As System.Windows.Forms.ListBox
    Friend WithEvents tStart As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tEnd As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Bar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents bSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tComm As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tShip As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tTotal As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lPayTOT As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lPayRET As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lPayCON As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lPayMD As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lPayMR As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Grid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents rComm As System.Windows.Forms.RadioButton
    Friend WithEvents rBonus As System.Windows.Forms.RadioButton
    Friend WithEvents tBonus As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chShowAll As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents bRules As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Order")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_for")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_applied")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_payment_full")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_method")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_payment")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_rep")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_sales_cat")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_rate")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_ret_rate")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_amt")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_ship_comm")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_sold_state")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_note")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_edited")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_edited_by")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comp_codes")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_pay_serial")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_ord_serial")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_ord_rev")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_ship_amt")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_total")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Reset", 0)
        Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
        Dim DateButton2 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_bonus_serial")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_bonus_date")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_bonus_rep")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_bonus_amt")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_bonus_note")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_bonus_edited")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_bonus_edited_by")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_bonus_created")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comm_bonus_created_by")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.lName = New System.Windows.Forms.ListBox()
        Me.tStart = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.tEnd = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.Bar1 = New System.Windows.Forms.ProgressBar()
        Me.bSave = New Infragistics.Win.Misc.UltraButton()
        Me.bPrint = New Infragistics.Win.Misc.UltraButton()
        Me.tComm = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.tShip = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.tTotal = New Infragistics.Win.Misc.UltraLabel()
        Me.lPayTOT = New Infragistics.Win.Misc.UltraLabel()
        Me.lPayRET = New Infragistics.Win.Misc.UltraLabel()
        Me.lPayCON = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.lPayMD = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lPayMR = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.Grid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.rComm = New System.Windows.Forms.RadioButton()
        Me.rBonus = New System.Windows.Forms.RadioButton()
        Me.tBonus = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.chShowAll = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.bRules = New Infragistics.Win.Misc.UltraButton()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chShowAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MaxWidth = 100
        UltraGridColumn2.MinWidth = 75
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn2.Width = 81
        UltraGridColumn3.Header.Caption = "Reference"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MinWidth = 150
        UltraGridColumn4.Header.Caption = "Applied"
        UltraGridColumn4.Header.VisiblePosition = 16
        UltraGridColumn4.MaxWidth = 75
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance16
        UltraGridColumn5.Format = "$###,###,##0.00"
        UltraGridColumn5.Header.Caption = "Payment"
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn6.Header.Caption = "Pay Type"
        UltraGridColumn6.Header.VisiblePosition = 4
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance17
        UltraGridColumn7.Format = "$###,###,##0.00"
        UltraGridColumn7.Header.Caption = "Comm Payment"
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.MaxWidth = 75
        UltraGridColumn8.Header.Caption = "Rep"
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.MaxWidth = 75
        UltraGridColumn9.Header.Caption = "Sales Cat"
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.MaxWidth = 75
        UltraGridColumn10.Header.Caption = "Rate"
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn11.Header.Caption = "Ret Rate"
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn11.NullText = "N/A"
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance18
        UltraGridColumn12.Format = "$###,###,##0.00"
        UltraGridColumn12.Header.Caption = "Commission"
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn12.MaxWidth = 75
        UltraGridColumn13.Format = "$###,###,##0.00"
        UltraGridColumn13.Header.Caption = "Ship Comm"
        UltraGridColumn13.Header.VisiblePosition = 11
        UltraGridColumn13.MaxWidth = 75
        UltraGridColumn14.Header.Caption = "Sold ST"
        UltraGridColumn14.Header.VisiblePosition = 17
        UltraGridColumn14.MaxWidth = 15
        UltraGridColumn15.Header.Caption = "Note"
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.MinWidth = 300
        UltraGridColumn16.Header.Caption = "Edited"
        UltraGridColumn16.Header.VisiblePosition = 18
        UltraGridColumn16.MaxWidth = 75
        UltraGridColumn17.Header.Caption = "Edited By"
        UltraGridColumn17.Header.VisiblePosition = 19
        UltraGridColumn17.MaxWidth = 75
        UltraGridColumn18.Header.Caption = "Comp Codes"
        UltraGridColumn18.Header.VisiblePosition = 12
        UltraGridColumn19.Header.VisiblePosition = 20
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 21
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 23
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Format = "$###,###,##0.00"
        UltraGridColumn22.Header.Caption = "ShipTot"
        UltraGridColumn22.Header.VisiblePosition = 13
        UltraGridColumn23.Format = "$###,###,##0.00"
        UltraGridColumn23.Header.Caption = "Total"
        UltraGridColumn23.Header.VisiblePosition = 14
        UltraGridColumn24.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        UltraGridColumn24.Header.VisiblePosition = 22
        UltraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(192, 0)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1250, 753)
        Me.Grid1.TabIndex = 0
        Me.Grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange
        Me.Grid1.Visible = False
        '
        'lName
        '
        Me.lName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lName.ItemHeight = 18
        Me.lName.Location = New System.Drawing.Point(10, 83)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(172, 274)
        Me.lName.TabIndex = 1
        '
        'tStart
        '
        Me.tStart.DateButtons.Add(DateButton1)
        Me.tStart.Location = New System.Drawing.Point(58, 18)
        Me.tStart.Name = "tStart"
        Me.tStart.NonAutoSizeHeight = 16
        Me.tStart.Size = New System.Drawing.Size(124, 25)
        Me.tStart.TabIndex = 2
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(10, 18)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(76, 19)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Start"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(10, 46)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(76, 19)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "End"
        '
        'tEnd
        '
        Me.tEnd.DateButtons.Add(DateButton2)
        Me.tEnd.Location = New System.Drawing.Point(58, 46)
        Me.tEnd.Name = "tEnd"
        Me.tEnd.NonAutoSizeHeight = 16
        Me.tEnd.Size = New System.Drawing.Size(124, 25)
        Me.tEnd.TabIndex = 4
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Update Payments"
        '
        'Bar1
        '
        Me.Bar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bar1.Location = New System.Drawing.Point(0, 802)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(1442, 18)
        Me.Bar1.TabIndex = 7
        '
        'bSave
        '
        Me.bSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSave.Location = New System.Drawing.Point(192, 753)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(134, 38)
        Me.bSave.TabIndex = 8
        Me.bSave.Text = "Save"
        Me.bSave.Visible = False
        '
        'bPrint
        '
        Me.bPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPrint.Location = New System.Drawing.Point(346, 753)
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Size = New System.Drawing.Size(134, 38)
        Me.bPrint.TabIndex = 9
        Me.bPrint.Text = "Print"
        Me.bPrint.Visible = False
        '
        'tComm
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.tComm.Appearance = Appearance4
        Me.tComm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tComm.Location = New System.Drawing.Point(67, 452)
        Me.tComm.Name = "tComm"
        Me.tComm.Size = New System.Drawing.Size(115, 28)
        Me.tComm.TabIndex = 10
        Me.tComm.Text = "$0.00"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(10, 452)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(86, 19)
        Me.UltraLabel4.TabIndex = 11
        Me.UltraLabel4.Text = "Comm"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(10, 480)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(86, 18)
        Me.UltraLabel5.TabIndex = 13
        Me.UltraLabel5.Text = "Shipping"
        '
        'tShip
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.tShip.Appearance = Appearance5
        Me.tShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tShip.Location = New System.Drawing.Point(67, 480)
        Me.tShip.Name = "tShip"
        Me.tShip.Size = New System.Drawing.Size(115, 28)
        Me.tShip.TabIndex = 12
        Me.tShip.Text = "$0.00"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Location = New System.Drawing.Point(10, 535)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(86, 19)
        Me.UltraLabel7.TabIndex = 15
        Me.UltraLabel7.Text = "Total"
        '
        'tTotal
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.tTotal.Appearance = Appearance6
        Me.tTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTotal.Location = New System.Drawing.Point(67, 535)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.Size = New System.Drawing.Size(115, 28)
        Me.tTotal.TabIndex = 14
        Me.tTotal.Text = "$0.00"
        '
        'lPayTOT
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.lPayTOT.Appearance = Appearance7
        Me.lPayTOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPayTOT.Location = New System.Drawing.Point(48, 720)
        Me.lPayTOT.Name = "lPayTOT"
        Me.lPayTOT.Size = New System.Drawing.Size(134, 28)
        Me.lPayTOT.TabIndex = 20
        Me.lPayTOT.Text = "$0.00"
        '
        'lPayRET
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.lPayRET.Appearance = Appearance8
        Me.lPayRET.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPayRET.Location = New System.Drawing.Point(67, 609)
        Me.lPayRET.Name = "lPayRET"
        Me.lPayRET.Size = New System.Drawing.Size(115, 28)
        Me.lPayRET.TabIndex = 18
        Me.lPayRET.Text = "$0.00"
        '
        'lPayCON
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.lPayCON.Appearance = Appearance9
        Me.lPayCON.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPayCON.Location = New System.Drawing.Point(67, 637)
        Me.lPayCON.Name = "lPayCON"
        Me.lPayCON.Size = New System.Drawing.Size(115, 28)
        Me.lPayCON.TabIndex = 16
        Me.lPayCON.Text = "$0.00"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.Location = New System.Drawing.Point(10, 720)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(86, 18)
        Me.UltraLabel9.TabIndex = 21
        Me.UltraLabel9.Text = "Total"
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(10, 609)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(86, 19)
        Me.UltraLabel10.TabIndex = 19
        Me.UltraLabel10.Text = "RET"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.Location = New System.Drawing.Point(10, 637)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(86, 18)
        Me.UltraLabel11.TabIndex = 17
        Me.UltraLabel11.Text = "CON"
        '
        'lPayMD
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.lPayMD.Appearance = Appearance10
        Me.lPayMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPayMD.Location = New System.Drawing.Point(67, 665)
        Me.lPayMD.Name = "lPayMD"
        Me.lPayMD.Size = New System.Drawing.Size(115, 27)
        Me.lPayMD.TabIndex = 22
        Me.lPayMD.Text = "$0.00"
        '
        'UltraLabel13
        '
        Me.UltraLabel13.Location = New System.Drawing.Point(10, 665)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(86, 18)
        Me.UltraLabel13.TabIndex = 23
        Me.UltraLabel13.Text = "MD"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 582)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 18)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Payments"
        '
        'lPayMR
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.lPayMR.Appearance = Appearance11
        Me.lPayMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPayMR.Location = New System.Drawing.Point(67, 692)
        Me.lPayMR.Name = "lPayMR"
        Me.lPayMR.Size = New System.Drawing.Size(115, 28)
        Me.lPayMR.TabIndex = 25
        Me.lPayMR.Text = "$0.00"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(10, 692)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(86, 19)
        Me.UltraLabel6.TabIndex = 26
        Me.UltraLabel6.Text = "MR"
        '
        'Grid2
        '
        Me.Grid2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid2.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn25.Header.VisiblePosition = 0
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.Caption = "Date"
        UltraGridColumn26.Header.VisiblePosition = 1
        UltraGridColumn26.Width = 183
        UltraGridColumn27.Header.VisiblePosition = 2
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.Caption = "Amount"
        UltraGridColumn28.Header.VisiblePosition = 3
        UltraGridColumn28.Width = 166
        UltraGridColumn29.Header.Caption = "Note"
        UltraGridColumn29.Header.VisiblePosition = 4
        UltraGridColumn29.Width = 182
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn30.Header.Caption = "Edited"
        UltraGridColumn30.Header.VisiblePosition = 5
        UltraGridColumn30.Width = 177
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn31.Header.Caption = "Edited By"
        UltraGridColumn31.Header.VisiblePosition = 6
        UltraGridColumn31.Width = 172
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn32.Header.Caption = "Created"
        UltraGridColumn32.Header.VisiblePosition = 7
        UltraGridColumn32.Width = 173
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn33.Header.Caption = "Created By"
        UltraGridColumn33.Header.VisiblePosition = 8
        UltraGridColumn33.Width = 176
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33})
        Me.Grid2.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.Grid2.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.Grid2.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid2.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid2.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid2.Location = New System.Drawing.Point(192, 0)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(1250, 753)
        Me.Grid2.TabIndex = 28
        Me.Grid2.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange
        Me.Grid2.Visible = False
        '
        'rComm
        '
        Me.rComm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rComm.Checked = True
        Me.rComm.Location = New System.Drawing.Point(528, 761)
        Me.rComm.Name = "rComm"
        Me.rComm.Size = New System.Drawing.Size(163, 28)
        Me.rComm.TabIndex = 29
        Me.rComm.TabStop = True
        Me.rComm.Text = "Show Commissions"
        '
        'rBonus
        '
        Me.rBonus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rBonus.Location = New System.Drawing.Point(710, 761)
        Me.rBonus.Name = "rBonus"
        Me.rBonus.Size = New System.Drawing.Size(173, 28)
        Me.rBonus.TabIndex = 30
        Me.rBonus.Text = "Show Bonuses"
        '
        'tBonus
        '
        Appearance12.TextHAlignAsString = "Right"
        Me.tBonus.Appearance = Appearance12
        Me.tBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBonus.Location = New System.Drawing.Point(67, 508)
        Me.tBonus.Name = "tBonus"
        Me.tBonus.Size = New System.Drawing.Size(115, 27)
        Me.tBonus.TabIndex = 31
        Me.tBonus.Text = "$0.00"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Location = New System.Drawing.Point(10, 508)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(86, 18)
        Me.UltraLabel8.TabIndex = 32
        Me.UltraLabel8.Text = "Bonus"
        '
        'chShowAll
        '
        Me.chShowAll.Location = New System.Drawing.Point(19, 425)
        Me.chShowAll.Name = "chShowAll"
        Me.chShowAll.Size = New System.Drawing.Size(144, 18)
        Me.chShowAll.TabIndex = 33
        Me.chShowAll.Text = "Show All"
        Me.chShowAll.Visible = False
        '
        'bRules
        '
        Me.bRules.Location = New System.Drawing.Point(38, 757)
        Me.bRules.Name = "bRules"
        Me.bRules.Size = New System.Drawing.Size(90, 26)
        Me.bRules.TabIndex = 34
        Me.bRules.Text = "Rules"
        '
        'fmCommission2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1442, 818)
        Me.Controls.Add(Me.bRules)
        Me.Controls.Add(Me.chShowAll)
        Me.Controls.Add(Me.tBonus)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.rBonus)
        Me.Controls.Add(Me.rComm)
        Me.Controls.Add(Me.lPayMR)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lPayMD)
        Me.Controls.Add(Me.UltraLabel13)
        Me.Controls.Add(Me.lPayTOT)
        Me.Controls.Add(Me.lPayRET)
        Me.Controls.Add(Me.lPayCON)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.tTotal)
        Me.Controls.Add(Me.tShip)
        Me.Controls.Add(Me.tComm)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.bPrint)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.tEnd)
        Me.Controls.Add(Me.tStart)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Grid2)
        Me.Menu = Me.MainMenu1
        Me.Name = "fmCommission2"
        Me.Text = "Commission"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chShowAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub fmCommission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UCase(Jcom.User) = "JON" Then UserName = "KeithL"
        LoadNames()
        tStart.Value = CDate(GetSetting("Jcom", "Settings", "CommStart", CStr(Today)))
        tEnd.Value = CDate(GetSetting("Jcom", "Settings", "CommEnd", CStr(Today)))
    End Sub
    Private Sub LoadNames()
        Dim ds As DataSet
        Dim cmd As New SqlCommand("select rep_comm_level from rep_file where rep_code='" + UserName + "'", cnn)
        Dim dr As SqlDataReader

        cnn.Open()
        UserLevel = nz(cmd.ExecuteScalar)
        cmd.CommandText = "select rep_code from rep_file where rep_code='" + UserName + "'"
        Select Case UCase(UserLevel)
            Case "MANAGER"
                If chShowAll.Checked Then
                    cmd.CommandText = "select rep_code from rep_file where (rep_manager<>'' or rep_type='F') and rep_active=1 order by rep_code"
                Else
                    cmd.CommandText = "select rep_code from rep_file where rep_manager='" + UserName + "' and rep_active=1 order by rep_code"
                End If
                chShowAll.Visible = True
            Case "ISR"
                If UCase(Jcom.User) = "DAIANAS" Then
                    If chShowAll.Checked Then
                        cmd.CommandText = "select rep_code from rep_file where (rep_manager<>'' or rep_type='F') and rep_active=1 order by rep_code"
                    Else
                        cmd.CommandText = "select rep_code from rep_file where rep_manager='" + UserName + "' and rep_active=1 order by rep_code"
                    End If
                    chShowAll.Visible = True
                End If
        End Select
        dr = cmd.ExecuteReader
        lName.Items.Clear()
        Do While dr.Read
            lName.Items.Add(dr("rep_code"))
        Loop
        dr.Close()
        cnn.Close()
        dsComm.Clear()
        ClearTotals()
    End Sub
    Private Sub LoadGrid()
        Try
            Me.Cursor = Cursors.WaitCursor
            dsComm.Clear()
            Grid1.Visible = False
            bSave.Visible = False
            bPrint.Visible = False
            Dim cmd As New SqlCommand("", cnn)
            Dim da As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            Dim Terr As String
            Dim CompCodes As String
            Dim dRow As DataRow
            Dim totRET, totCON, totMD, totMR, tot As Double

            cnn.Open()
            cmd.CommandText = "select rep_split_terr from rep_file where rep_code='" + lName.SelectedItem + "'"
            Terr = nz(cmd.ExecuteScalar, "")
            cmd.CommandText = "select * from rep_comm where rep_comm_rep_code='" + lName.SelectedItem + "' and rep_comm_start<='" + CStr(Date.Today) + "' and rep_comm_end>='" + CStr(Date.Today) + "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Ret = nz(dr("rep_comm_ret"), 0)
                Con = nz(dr("rep_comm_con"), 0)
                MD = nz(dr("rep_comm_md"), 0)
                MR = nz(dr("rep_comm_mr"), 0)
            Else
                Ret = 0
                Con = 0
                MD = 0
                MR = 0
            End If
            dr.Close()
            cmd.CommandText = "select comm_serial,comm_pay_serial,cast(comm_ord_serial as varchar(10))+'-'+cast(comm_from_rev as varchar(2))+'-'+cast(comm_ord_rev as varchar(2)) as [Order],comm_ord_serial,comm_ord_rev, ord_for, pay_applied,comm_rate as comm_rate,comm_ret_rate,comm_payment,comm_rep,comm_sales_cat,comm_amt,comm_ship_amt,comm_ship_comm,comm_payment+comm_ship_amt as comm_total,comm_note,comm_edited,comm_edited_by,pay_method,comm_payment_full,ord_sold_state,'' as Comp_Codes from comm_file left outer join pay_file on comm_pay_serial=pay_serial left outer join ord_file on comm_ord_serial=ord_serial where (comm_rep='" + lName.SelectedItem + "' or comm_rep='" + Terr + "') and pay_applied>='" + CStr(tStart.Value) + "' and pay_applied<='" + tEnd.Value + "' order by comm_ord_serial,comm_ord_rev"
            da.Fill(dsComm)

            For Each dRow In dsComm.Tables(0).Rows
                cmd.CommandText = "select ord_itm_item_code from ord_itm where ord_itm_ord_serial=" + Split(dRow("Order"), "-")(0) + " and ord_itm_rev=" + Split(dRow("Order"), "-")(2) + " and ord_itm_type='O' and ord_itm_item_code like 'COMP-%'"
                dr = cmd.ExecuteReader
                CompCodes = ""
                If dr.HasRows Then
                    Do While dr.Read
                        CompCodes += dr("ord_itm_item_code") + ","
                    Loop
                    CompCodes = Mid(CompCodes, 1, Len(CompCodes) - 1)
                    dRow("comp_codes") = CompCodes
                    dRow.AcceptChanges()
                End If

                Select Case dRow("comm_sales_cat")
                    Case "RET"
                        totRET += dRow("comm_payment_full")
                    Case "CON"
                        totCON += dRow("comm_payment_full")
                    Case "MD"
                        totMD += dRow("comm_payment_full")
                    Case "MR"
                        totMR += dRow("comm_payment_full")
                End Select
                tot += dRow("comm_payment_full")
                dr.Close()
            Next
            lPayRET.Text = FormatCurrency(totRET)
            lPayCON.Text = FormatCurrency(totCON)
            lPayMD.Text = FormatCurrency(totMD)
            lPayMR.Text = FormatCurrency(totMR)
            lPayTOT.Text = FormatCurrency(tot)

            Grid1.DataSource = dsComm.Tables(0)
            Grid1.DataBind()
            Grid1.Visible = True
            If dsComm.Tables(0).Rows.Count > 0 Then
                bSave.Visible = True
                bPrint.Visible = True
            End If

            Dim dd As New Infragistics.Win.UltraWinGrid.UltraDropDown
            If dsCat.Tables.Count = 0 Then
                cmd.CommandText = "select sales_cat_cat from sales_cat order by sales_cat_cat"
                da.SelectCommand = cmd
                da.Fill(dsCat)
                dd.Width = 100
                dd.DataSource = dsCat
                dd.ValueMember = "Sales_Cat_Cat"
                dd.DisplayMember = "Sales_Cat_Cat"
                dd.DataBind()
                Grid1.DisplayLayout.Bands(0).Columns("comm_sales_cat").ValueList = dd
            End If

            dd = New Infragistics.Win.UltraWinGrid.UltraDropDown
            Dim uLevel As String
            cmd.CommandText = "select rep_comm_level from rep_file where rep_code='" + lName.SelectedItem + "'"
            uLevel = nz(cmd.ExecuteScalar)
            cmd.CommandText = "select rep_code from rep_file where rep_comm_level='" + uLevel + "' and rep_active=1 order by rep_code"
            da.SelectCommand = cmd
            dsRep.Tables.Clear()
            da.Fill(dsRep)
            dd.Width = 100
            dd.DataSource = dsRep
            dd.ValueMember = "rep_code"
            dd.DisplayMember = "rep_code"
            dd.DataBind()
            Grid1.DisplayLayout.Bands(0).Columns("comm_rep").ValueList = dd

            'LoadBonuses
            Dim cb As New SqlCommandBuilder(daBonus)
            cmd.CommandText = "select * from comm_bonus where comm_bonus_rep='" + lName.SelectedItem + "' and comm_bonus_date>='" + tStart.Text + "' and comm_bonus_date<='" + tEnd.Text + "'"
            daBonus.SelectCommand = cmd
            dsBonus.Clear()
            daBonus.Fill(dsBonus)
            Grid2.DataSource = dsBonus.Tables(0)
            Grid2.DataBind()

            Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
            Dim Comm, Ship, Bonus As Double
            Comm = 0
            Ship = 0
            Bonus = 0
            For Each rw In Grid1.Rows
                If Not rw.Cells("comm_edited_by").Value Is DBNull.Value Then
                    rw.Appearance.BackColor = Color.LightYellow
                Else
                    If nz(rw.Cells("comp_codes").Value) <> "" Then rw.Appearance.BackColor = Color.LightPink
                End If
                Comm += rw.Cells("comm_amt").Value
                Ship += rw.Cells("comm_ship_comm").Value
                rw.Cells("Reset").Value = "Reset " + rw.Cells("Order").Value
                'If nz(rw.Cells("comm_ret_rate").Value, 0) = 0 Then
                '    rw.Cells("comm_ret_rate").Value = DBNull.Value
                'End If
                rw.Cells("Reset").Refresh()
            Next

            For Each rw In Grid2.Rows
                Bonus += rw.Cells("comm_bonus_amt").Value
            Next

            tComm.Text = FormatCurrency(Comm, 2)
            tShip.Text = FormatCurrency(Ship, 2)
            tBonus.Text = FormatCurrency(Bonus, 2)
            tTotal.Text = FormatCurrency(Comm + Ship + Bonus, 2)

            cnn.Close()
            Grid1.UpdateData()
        Catch
            DoError(Err, Me)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub ClearTotals()
        lPayRET.Text = "$0.00"
        lPayCON.Text = "$0.00"
        lPayMD.Text = "$0.00"
        lPayMR.Text = "$0.00"
        lPayTOT.Text = "$0.00"
        tComm.Text = "$0.00"
        tShip.Text = "$0.00"
        tBonus.Text = "$0.00"
        tTotal.Text = "$0.00"

    End Sub
    Private Sub lName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lName.SelectedIndexChanged
        CheckDirty()
        LoadGrid()
    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub Grid1_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid1.ClickCellButton
        Select Case e.Cell.Column.Header.Caption
            Case "Order"
                Dim fm As fmEstOrd2
                fm = LoadForm("Quotes/Orders")
                If fm.EditMode <> "" Then
                    MsgBox("You must first save or cancel this Quote/Order", MsgBoxStyle.Information, "Save?")
                    fm = Nothing
                    Exit Sub
                End If
                fm.KeyValue1 = Split(e.Cell.Value, "-")(0)
                fm.tOrd.Text = fm.KeyValue1
                fm.LoadPage()
                fm.Tab1.Tabs("O" + Split(e.Cell.Value, "-")(2)).Selected = True
                fm.TabItems.Tabs("Items").Selected = True
            Case "Reset"
                If IsDirty() Then
                    MsgBox("You must save first and then you can reset this row", MsgBoxStyle.Information, "Save first")
                    Exit Sub
                End If
                SetCommission(e.Cell.Row.Cells("comm_pay_serial").Value)
                LoadGrid()
        End Select
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        'Exit Sub

        Dim cmd As New SqlCommand("select distinct pay_file.pay_serial from pay_file left outer join comm_file on pay_serial=comm_pay_serial left outer join meth_file on pay_method=meth_type where pay_applied >= '2/1/2010' and meth_pay_commission=1", cnn) ' and isnull(comm_serial,-1)=-1", cnn)
        Dim ds As New DataSet
        Dim dsItem As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim row, rowItem As DataRow
        Dim SalesCat As String
        Dim Rate, Comm, ShipComm As Double
        Dim dr As SqlDataReader
        Dim cmRet, cmMD, cmCon, cmShip, cmFix, cmMr As Double
        Dim cnt As Integer = 0
        Dim Manager, Supervisor, Rep As String

        cnn.Open()
        da.Fill(ds)
        For Each row In ds.Tables(0).Rows
            SetCommission(row("pay_serial"))
            Bar1.Value = cnt / ds.Tables(0).Rows.Count * 100
            cnt += 1
            Application.DoEvents()
        Next
        cnn.Close()
        MsgBox("Update Complete")

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click
        SaveData()
        LoadGrid()
    End Sub
    Private Sub SaveData()
        Dim rw, rwx As DataRow
        Dim cmd As New SqlCommand("", cnn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim onSalesCatx As String
        Dim onRate As Double
        Dim onAmt As Double

        BindingContext(dsComm).EndCurrentEdit()
        BindingContext(dsBonus).EndCurrentEdit()

        cnn.Open()
        For Each rw In dsComm.Tables(0).Rows
            If rw.RowState = DataRowState.Modified Then
                If UCase(UserLevel) = "MANAGER" And UCase(rw("comm_rep")) = UCase(UserName) Then
                    cmd.CommandText = "select comm_sales_cat from comm_file where  comm_serial=" + CStr(rw("comm_serial"))
                    onSalesCatx = nz(cmd.ExecuteScalar)
                    If onSalesCatx <> rw("comm_sales_cat") Then
                        cmd.CommandText = "select * from comm_file where comm_pay_serial=" + CStr(rw("comm_pay_serial")) + " and comm_ord_serial=" + CStr(rw("comm_ord_serial")) + " and comm_ord_rev=" + CStr(rw("comm_ord_rev")) + " and comm_serial<>" + CStr(rw("comm_serial"))
                        da.Fill(dt)
                        For Each rwx In dt.Rows
                            Select Case rw("comm_sales_cat")
                                Case "RET"
                                    cmd.CommandText = "select rep_comm_ret from rep_comm where rep_comm_rep_code='" + rwx("comm_rep") + "' and rep_comm_start<='" + CStr(Date.Today) + "' and rep_comm_end>='" + CStr(Date.Today) + "'"
                                Case "CON"
                                    cmd.CommandText = "select rep_comm_con from rep_comm where rep_comm_rep_code='" + rwx("comm_rep") + "' and rep_comm_start<='" + CStr(Date.Today) + "' and rep_comm_end>='" + CStr(Date.Today) + "'"
                                Case "MD"
                                    cmd.CommandText = "select rep_comm_md from rep_comm where rep_comm_rep_code='" + rwx("comm_rep") + "' and rep_comm_start<='" + CStr(Date.Today) + "' and rep_comm_end>='" + CStr(Date.Today) + "'"
                                Case "MR"
                                    cmd.CommandText = "select rep_comm_mr from rep_comm where rep_comm_rep_code='" + rwx("comm_rep") + "' and rep_comm_start<='" + CStr(Date.Today) + "' and rep_comm_end>='" + CStr(Date.Today) + "'"
                            End Select
                            onRate = nz(cmd.ExecuteScalar, 0)
                            onAmt = Math.Round(rwx("comm_payment") * onRate, 2)
                            cmd.CommandText = "update comm_file set comm_rep='" + rw("comm_rep") + "',comm_sales_cat='" + rw("comm_sales_cat") + "',comm_rate=" + CStr(onRate) + ",comm_amt=" + CStr(onAmt) + ",comm_note='" + Replace(nz(rw("comm_note")), "'", "''") + "',comm_edited='" + CStr(Now) + "',comm_edited_by='" + User + "' where comm_serial=" + CStr(rwx("comm_serial"))
                            cmd.ExecuteNonQuery()
                        Next
                    End If
                End If
                cmd.CommandText = "update comm_file set comm_rep='" + rw("comm_rep") + "',comm_sales_cat='" + rw("comm_sales_cat") + "',comm_rate=" + CStr(rw("comm_rate")) + ",comm_amt=" + CStr(rw("comm_amt")) + ",comm_note='" + Replace(nz(rw("comm_note")), "'", "''") + "',comm_edited='" + CStr(Now) + "',comm_edited_by='" + User + "',comm_ship_comm=" + CStr(rw("comm_ship_comm")) + " where comm_serial=" + CStr(rw("comm_serial"))
                cmd.ExecuteNonQuery()
            End If
        Next

        Grid2.UpdateData()
        For Each rw In dsBonus.Tables(0).Rows
            If rw.RowState = DataRowState.Added Then
                rw("comm_bonus_created") = Now
                rw("comm_bonus_created_by") = User
                rw("comm_bonus_edited") = Now
                rw("comm_bonus_edited_by") = User
                rw("comm_bonus_rep") = lName.SelectedItem
            End If
            If rw.RowState = DataRowState.Modified Then
                rw("comm_bonus_edited") = Now
                rw("comm_bonus_edited_by") = User
            End If
        Next
        daBonus.Update(dsBonus)

        cnn.Close()
    End Sub
    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrint.Click
        Dim cmd As New SqlCommand("select rep_split_terr from rep_file where rep_code='" + lName.SelectedItem + "'", cnn)
        Dim onSplit As String

        cnn.Open()
        onSplit = nz(cmd.ExecuteScalar, "<None>")
        cnn.Close()
        DisplayReport("commission detail", "{?StartDt}<={pay_file.pay_applied} and {?EndDt}>={pay_file.pay_applied} and (({comm_file.comm_rep}='" + lName.SelectedItem + "') or ({comm_file.comm_rep}='" + onSplit + "'))", True, , tStart.Value, tEnd.Value, False)
    End Sub

    Private Sub Grid1_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid1.AfterCellUpdate
        If Grid1.ActiveRow Is Nothing Then Exit Sub
        If e.Cell.Column.Header.Caption = "Comp_Codes" Or e.Cell.Column.Header.Caption = "Reset" Then Exit Sub
        Dim ShipComm As Double

        Grid1.ActiveRow.Appearance.BackColor = Color.Yellow
        If e.Cell.Column.Header.Caption = "Sales Cat" Then
            If onSalesCat <> e.Cell.Value Then
                Select Case e.Cell.Value
                    Case "RET"
                        Grid1.ActiveRow.Cells("comm_rate").Value = Ret
                        onSalesCat = "Ret"
                    Case "CON"
                        Grid1.ActiveRow.Cells("comm_rate").Value = Con
                        onSalesCat = "Con"
                    Case "MD"
                        Grid1.ActiveRow.Cells("comm_rate").Value = MD
                        onSalesCat = "MD"
                    Case "MR"
                        Grid1.ActiveRow.Cells("comm_rate").Value = MR
                        onSalesCat = "MR"
                    Case "BASE"
                        Grid1.ActiveRow.Cells("comm_rate").Value = MR
                        onSalesCat = "MR"
                    Case Else
                End Select
                Grid1.ActiveRow.Cells("comm_amt").Value = Math.Round(Grid1.ActiveRow.Cells("comm_payment").Value * Grid1.ActiveRow.Cells("comm_rate").Value, 2)
                'Select Case Grid1.ActiveRow.Cells("ord_gen_sales_cat").Value
                '    Case "RET"
                '        ShipComm = Math.Round(cmRet * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '    Case "CON"
                '        ShipComm = Math.Round(cmCon * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '    Case "MD"
                '        ShipComm = Math.Round(cmMD * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '    Case "MR"
                '        ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '    Case Else
                '        ShipComm = 0
                'End Select
            End If
        End If
    End Sub

    Private Sub Grid1_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterCellActivate
        Select Case Grid1.ActiveCell.Column.Header.Caption
            Case "Sales Cat"
                onSalesCat = Grid1.ActiveCell.Value
            Case "Note"
            Case "Commission"
            Case "Ship Comm"
            Case "Rep"
            Case Else
                Grid1.ActiveCell.Activation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        End Select
    End Sub

    Private Sub tStart_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tStart.Leave
        SaveSetting("Jcom", "Settings", "CommStart", CStr(tStart.Value))
    End Sub

    Private Sub tEnd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tEnd.Leave
        SaveSetting("Jcom", "Settings", "CommEnd", CStr(tEnd.Value))
    End Sub
    Private Function CheckDirty() As MsgBoxResult
        If IsDirty() Then
            Select Case MsgBox("Some rows have changed.  Do you want to save now?", MsgBoxStyle.YesNo, "Save?")
                Case MsgBoxResult.Yes
                    CheckDirty = MsgBoxResult.Yes
                    SaveData()
                Case MsgBoxResult.No
                    CheckDirty = MsgBoxResult.No
                    Exit Function
                Case MsgBoxResult.Cancel
                    CheckDirty = MsgBoxResult.Cancel
                    Exit Function
            End Select
        End If
        CheckDirty = Nothing
    End Function
    Private Function IsDirty() As Boolean
        IsDirty = False
        If dsComm.Tables.Count = 0 Then Exit Function
        BindingContext(dsComm).EndCurrentEdit()
        BindingContext(dsBonus).EndCurrentEdit()
        Dim rw As DataRow
        For Each rw In dsComm.Tables(0).Rows
            If rw.RowState = DataRowState.Modified Then
                IsDirty = True
                Exit Function
            End If
        Next
        For Each rw In dsBonus.Tables(0).Rows
            If rw.RowState = DataRowState.Modified Or rw.RowState = DataRowState.Deleted Then
                IsDirty = True
                Exit Function
            End If
        Next
    End Function
    Private Sub fmCommission_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If CheckDirty() = MsgBoxResult.Cancel Then e.Cancel = True
    End Sub

    Private Sub rComm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rComm.CheckedChanged
        If rComm.Checked Then
            Grid1.Visible = True
            Grid2.Visible = False
        Else
            Grid1.Visible = False
            Grid2.Visible = True
        End If
    End Sub

    Private Sub Grid2_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid2.InitializeLayout

    End Sub

    Private Sub chShowAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chShowAll.CheckedChanged
        LoadNames()
    End Sub

    Private Sub bRules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRules.Click
        Dim myProc As New Process
        myProc.StartInfo.FileName = "\\10.0.0.245\jcom$\docs\rules for commission.pdf"
        myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        myProc.Start()

    End Sub
End Class
