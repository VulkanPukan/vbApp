Imports System.Data.SqlClient
Public Class fmContactFind
    Inherits System.Windows.Forms.Form
    Public Zip As String
    Friend WithEvents tPhoneExt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tCompany As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tWebsite As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tFax As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tCell As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tAddr As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tCity As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tPhone As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tState As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel57 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tZip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel54 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Public ContactSerial As Long = 0
    Friend WithEvents tDealer As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lDealer As Infragistics.Win.Misc.UltraLabel
    Public SearchSpeedCodes As Boolean
    Public SpeedCodeSelected As Boolean
    Friend WithEvents bAdd As System.Windows.Forms.Button
    Friend WithEvents bAddContact As System.Windows.Forms.Button
    Public AddContact As Boolean = False
    Friend WithEvents tCounty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents tContCountry As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Dim onZip As String

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
    Friend WithEvents bSearch As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tStatus As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents bClear As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbHasOrders As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbShowInactives As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_name")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_id")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_company")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_type")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_state")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_zip")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmContactFind))
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.bSearch = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.tType = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tStatus = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.bClear = New Infragistics.Win.Misc.UltraButton
        Me.cbHasOrders = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbShowInactives = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.tPhoneExt = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.tCompany = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tWebsite = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.tEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.tFax = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.tCell = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.tAddr = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tName = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tCity = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tPhone = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel
        Me.tState = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel57 = New Infragistics.Win.Misc.UltraLabel
        Me.tZip = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel54 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel
        Me.tDealer = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lDealer = New Infragistics.Win.Misc.UltraLabel
        Me.bAdd = New System.Windows.Forms.Button
        Me.bAddContact = New System.Windows.Forms.Button
        Me.tCounty = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.tContCountry = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbHasOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbShowInactives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPhoneExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tWebsite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tFax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAddr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tZip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDealer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCounty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.Caption = "Contact ID"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.MaxWidth = 100
        UltraGridColumn1.Width = 74
        UltraGridColumn2.Header.Caption = "Name"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 156
        UltraGridColumn3.Header.Caption = "Cust ID"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaxWidth = 100
        UltraGridColumn3.Width = 94
        UltraGridColumn4.Header.Caption = "Company"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 154
        UltraGridColumn5.Header.Caption = "Type"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 153
        UltraGridColumn6.Header.Caption = "State"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.MaxWidth = 40
        UltraGridColumn6.Width = 38
        UltraGridColumn7.Header.Caption = "Zip"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.MaxWidth = 100
        UltraGridColumn7.Width = 94
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.Grid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.Grid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.Location = New System.Drawing.Point(298, 30)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(784, 843)
        Me.Grid1.TabIndex = 17
        '
        'bSearch
        '
        Me.bSearch.Location = New System.Drawing.Point(35, 391)
        Me.bSearch.Name = "bSearch"
        Me.bSearch.Size = New System.Drawing.Size(177, 28)
        Me.bSearch.TabIndex = 15
        Me.bSearch.Text = "Select"
        '
        'UltraLabel5
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel5.Appearance = Appearance13
        Me.UltraLabel5.Location = New System.Drawing.Point(1, 318)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(105, 20)
        Me.UltraLabel5.TabIndex = 12
        Me.UltraLabel5.Text = "Type"
        '
        'UltraLabel6
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel6.Appearance = Appearance12
        Me.UltraLabel6.Location = New System.Drawing.Point(1, 347)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(105, 18)
        Me.UltraLabel6.TabIndex = 14
        Me.UltraLabel6.Text = "Status"
        '
        'tType
        '
        Me.tType.CheckedListSettings.CheckStateMember = ""
        Me.tType.Location = New System.Drawing.Point(91, 318)
        Me.tType.Name = "tType"
        Me.tType.Size = New System.Drawing.Size(178, 25)
        Me.tType.TabIndex = 13
        Me.tType.Tag = ""
        '
        'tStatus
        '
        Me.tStatus.CheckedListSettings.CheckStateMember = ""
        Me.tStatus.Location = New System.Drawing.Point(91, 347)
        Me.tStatus.Name = "tStatus"
        Me.tStatus.Size = New System.Drawing.Size(178, 25)
        Me.tStatus.TabIndex = 14
        Me.tStatus.Tag = ""
        '
        'bClear
        '
        Me.bClear.Location = New System.Drawing.Point(35, 428)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(177, 28)
        Me.bClear.TabIndex = 16
        Me.bClear.Text = "Clear Fields"
        '
        'cbHasOrders
        '
        Me.cbHasOrders.Location = New System.Drawing.Point(298, 6)
        Me.cbHasOrders.Name = "cbHasOrders"
        Me.cbHasOrders.Size = New System.Drawing.Size(124, 18)
        Me.cbHasOrders.TabIndex = 16
        Me.cbHasOrders.Text = "Has Orders"
        '
        'cbShowInactives
        '
        Me.cbShowInactives.Location = New System.Drawing.Point(392, 5)
        Me.cbShowInactives.Name = "cbShowInactives"
        Me.cbShowInactives.Size = New System.Drawing.Size(125, 19)
        Me.cbShowInactives.TabIndex = 17
        Me.cbShowInactives.Text = "Show Inactives"
        '
        'tPhoneExt
        '
        Me.tPhoneExt.AutoSize = False
        Me.tPhoneExt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tPhoneExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPhoneExt.Location = New System.Drawing.Point(210, 30)
        Me.tPhoneExt.MaxLength = 10
        Me.tPhoneExt.Name = "tPhoneExt"
        Me.tPhoneExt.Size = New System.Drawing.Size(59, 20)
        Me.tPhoneExt.TabIndex = 2
        Me.tPhoneExt.Tag = "edit;cont_phone1_ext"
        '
        'UltraLabel13
        '
        Me.UltraLabel13.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(200, 30)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(12, 18)
        Me.UltraLabel13.TabIndex = 264
        Me.UltraLabel13.Text = "x"
        '
        'tCompany
        '
        Me.tCompany.AutoSize = False
        Me.tCompany.CheckedListSettings.CheckStateMember = ""
        Me.tCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCompany.Location = New System.Drawing.Point(91, 72)
        Me.tCompany.Name = "tCompany"
        Me.tCompany.Size = New System.Drawing.Size(178, 19)
        Me.tCompany.TabIndex = 4
        Me.tCompany.Tag = "edit;cont_company"
        '
        'tWebsite
        '
        Me.tWebsite.AutoSize = False
        Me.tWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tWebsite.Location = New System.Drawing.Point(91, 293)
        Me.tWebsite.Name = "tWebsite"
        Me.tWebsite.Size = New System.Drawing.Size(178, 20)
        Me.tWebsite.TabIndex = 12
        Me.tWebsite.Tag = "edit;cont_website"
        '
        'UltraLabel7
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel7.Appearance = Appearance1
        Me.UltraLabel7.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(1, 293)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(115, 17)
        Me.UltraLabel7.TabIndex = 263
        Me.UltraLabel7.Text = "Website"
        '
        'tEmail
        '
        Me.tEmail.AutoSize = False
        Me.tEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tEmail.Location = New System.Drawing.Point(91, 272)
        Me.tEmail.Name = "tEmail"
        Me.tEmail.Size = New System.Drawing.Size(178, 20)
        Me.tEmail.TabIndex = 11
        Me.tEmail.Tag = "edit;cont_email"
        '
        'UltraLabel8
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel8.Appearance = Appearance2
        Me.UltraLabel8.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(1, 272)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(115, 18)
        Me.UltraLabel8.TabIndex = 262
        Me.UltraLabel8.Text = "Email"
        '
        'tFax
        '
        Me.tFax.AutoSize = False
        Me.tFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFax.Location = New System.Drawing.Point(91, 250)
        Me.tFax.Name = "tFax"
        Me.tFax.Size = New System.Drawing.Size(178, 21)
        Me.tFax.TabIndex = 10
        Me.tFax.Tag = "edit;cont_fax"
        '
        'UltraLabel9
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel9.Appearance = Appearance3
        Me.UltraLabel9.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(1, 250)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(115, 20)
        Me.UltraLabel9.TabIndex = 261
        Me.UltraLabel9.Text = "Fax"
        '
        'tCell
        '
        Me.tCell.AutoSize = False
        Me.tCell.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCell.Location = New System.Drawing.Point(91, 228)
        Me.tCell.Name = "tCell"
        Me.tCell.Size = New System.Drawing.Size(178, 21)
        Me.tCell.TabIndex = 9
        Me.tCell.Tag = "edit;cont_cell"
        '
        'UltraLabel10
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel10.Appearance = Appearance15
        Me.UltraLabel10.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(1, 228)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(115, 19)
        Me.UltraLabel10.TabIndex = 260
        Me.UltraLabel10.Text = "Cell"
        '
        'tAddr
        '
        Me.tAddr.AutoSize = False
        Me.tAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAddr.Location = New System.Drawing.Point(91, 114)
        Me.tAddr.Name = "tAddr"
        Me.tAddr.Size = New System.Drawing.Size(178, 21)
        Me.tAddr.TabIndex = 5
        Me.tAddr.Tag = "edit;cont_addr1"
        '
        'tName
        '
        Me.tName.AutoSize = False
        Me.tName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tName.Location = New System.Drawing.Point(91, 9)
        Me.tName.Name = "tName"
        Me.tName.Size = New System.Drawing.Size(178, 20)
        Me.tName.TabIndex = 0
        Me.tName.Tag = "edit;cont_name"
        '
        'tCity
        '
        Me.tCity.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.tCity.AutoSize = False
        Me.tCity.CheckedListSettings.CheckStateMember = ""
        Me.tCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCity.Location = New System.Drawing.Point(91, 158)
        Me.tCity.Name = "tCity"
        Me.tCity.Size = New System.Drawing.Size(178, 20)
        Me.tCity.TabIndex = 7
        Me.tCity.Tag = "edit;cont_city"
        '
        'tPhone
        '
        Me.tPhone.AutoSize = False
        Me.tPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPhone.Location = New System.Drawing.Point(91, 30)
        Me.tPhone.Name = "tPhone"
        Me.tPhone.Size = New System.Drawing.Size(106, 20)
        Me.tPhone.TabIndex = 1
        Me.tPhone.Tag = "edit;cont_phone1"
        '
        'UltraLabel17
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel17.Appearance = Appearance5
        Me.UltraLabel17.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(1, 30)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(115, 18)
        Me.UltraLabel17.TabIndex = 258
        Me.UltraLabel17.Text = "Phone"
        '
        'tState
        '
        Me.tState.AutoSize = False
        Me.tState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tState.Location = New System.Drawing.Point(91, 179)
        Me.tState.MaxLength = 2
        Me.tState.Name = "tState"
        Me.tState.Size = New System.Drawing.Size(41, 19)
        Me.tState.TabIndex = 8
        Me.tState.Tag = "edit;cont_state"
        '
        'UltraLabel27
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel27.Appearance = Appearance6
        Me.UltraLabel27.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel27.Location = New System.Drawing.Point(1, 179)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(115, 18)
        Me.UltraLabel27.TabIndex = 255
        Me.UltraLabel27.Text = "State"
        '
        'UltraLabel28
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel28.Appearance = Appearance7
        Me.UltraLabel28.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel28.Location = New System.Drawing.Point(1, 158)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(115, 17)
        Me.UltraLabel28.TabIndex = 254
        Me.UltraLabel28.Text = "City"
        '
        'UltraLabel57
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel57.Appearance = Appearance14
        Me.UltraLabel57.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel57.Location = New System.Drawing.Point(1, 9)
        Me.UltraLabel57.Name = "UltraLabel57"
        Me.UltraLabel57.Size = New System.Drawing.Size(115, 18)
        Me.UltraLabel57.TabIndex = 250
        Me.UltraLabel57.Text = "Name"
        '
        'tZip
        '
        Me.tZip.AutoSize = False
        Me.tZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tZip.Location = New System.Drawing.Point(91, 136)
        Me.tZip.MaxLength = 10
        Me.tZip.Name = "tZip"
        Me.tZip.Size = New System.Drawing.Size(82, 21)
        Me.tZip.TabIndex = 6
        Me.tZip.Tag = "edit;cont_zip"
        '
        'UltraLabel54
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel54.Appearance = Appearance9
        Me.UltraLabel54.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel54.Location = New System.Drawing.Point(1, 72)
        Me.UltraLabel54.Name = "UltraLabel54"
        Me.UltraLabel54.Size = New System.Drawing.Size(115, 18)
        Me.UltraLabel54.TabIndex = 251
        Me.UltraLabel54.Text = "Company"
        '
        'UltraLabel30
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel30.Appearance = Appearance16
        Me.UltraLabel30.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel30.Location = New System.Drawing.Point(1, 114)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(115, 19)
        Me.UltraLabel30.TabIndex = 252
        Me.UltraLabel30.Text = "Address"
        '
        'UltraLabel21
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel21.Appearance = Appearance11
        Me.UltraLabel21.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(1, 136)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(115, 20)
        Me.UltraLabel21.TabIndex = 256
        Me.UltraLabel21.Text = "Zip"
        '
        'tDealer
        '
        Me.tDealer.AutoSize = False
        Me.tDealer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDealer.Location = New System.Drawing.Point(91, 51)
        Me.tDealer.Name = "tDealer"
        Me.tDealer.Size = New System.Drawing.Size(178, 19)
        Me.tDealer.TabIndex = 3
        Me.tDealer.Tag = "edit;cont_name"
        '
        'lDealer
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.lDealer.Appearance = Appearance8
        Me.lDealer.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.lDealer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDealer.Location = New System.Drawing.Point(1, 51)
        Me.lDealer.Name = "lDealer"
        Me.lDealer.Size = New System.Drawing.Size(115, 17)
        Me.lDealer.TabIndex = 266
        Me.lDealer.Text = "Dealer Code"
        '
        'bAdd
        '
        Me.bAdd.BackColor = System.Drawing.Color.Crimson
        Me.bAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAdd.ForeColor = System.Drawing.Color.White
        Me.bAdd.Location = New System.Drawing.Point(35, 479)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(177, 31)
        Me.bAdd.TabIndex = 268
        Me.bAdd.Text = "Add Contact"
        Me.bAdd.UseVisualStyleBackColor = False
        Me.bAdd.Visible = False
        '
        'bAddContact
        '
        Me.bAddContact.BackColor = System.Drawing.Color.Crimson
        Me.bAddContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAddContact.ForeColor = System.Drawing.Color.White
        Me.bAddContact.Location = New System.Drawing.Point(35, 517)
        Me.bAddContact.Name = "bAddContact"
        Me.bAddContact.Size = New System.Drawing.Size(177, 50)
        Me.bAddContact.TabIndex = 269
        Me.bAddContact.Text = "Cancel This Order and Add New Contact"
        Me.bAddContact.UseVisualStyleBackColor = False
        Me.bAddContact.Visible = False
        '
        'tCounty
        '
        Me.tCounty.AutoSize = False
        Me.tCounty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCounty.Location = New System.Drawing.Point(91, 200)
        Me.tCounty.Name = "tCounty"
        Me.tCounty.Size = New System.Drawing.Size(178, 20)
        Me.tCounty.TabIndex = 270
        Me.tCounty.Tag = "edit;cont_county"
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(1, 200)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(115, 18)
        Me.UltraLabel1.TabIndex = 271
        Me.UltraLabel1.Text = "County"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(238, 816)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 272
        Me.PictureBox1.TabStop = False
        '
        'tContCountry
        '
        Me.tContCountry.AutoSize = False
        Me.tContCountry.CheckedListSettings.CheckStateMember = ""
        Me.tContCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContCountry.Location = New System.Drawing.Point(91, 92)
        Me.tContCountry.Name = "tContCountry"
        Me.tContCountry.Size = New System.Drawing.Size(178, 21)
        Me.tContCountry.TabIndex = 273
        Me.tContCountry.Tag = "edit;cont_country"
        '
        'UltraLabel2
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel2.Appearance = Appearance10
        Me.UltraLabel2.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(1, 92)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(83, 21)
        Me.UltraLabel2.TabIndex = 274
        Me.UltraLabel2.Text = "Country"
        '
        'fmContactFind
        '
        Me.AcceptButton = Me.bSearch
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1082, 872)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.tContCountry)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tCounty)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.bAddContact)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.tDealer)
        Me.Controls.Add(Me.lDealer)
        Me.Controls.Add(Me.tPhoneExt)
        Me.Controls.Add(Me.UltraLabel13)
        Me.Controls.Add(Me.tCompany)
        Me.Controls.Add(Me.tWebsite)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.tEmail)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.tFax)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.tCell)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.tAddr)
        Me.Controls.Add(Me.tName)
        Me.Controls.Add(Me.tCity)
        Me.Controls.Add(Me.tPhone)
        Me.Controls.Add(Me.UltraLabel17)
        Me.Controls.Add(Me.tState)
        Me.Controls.Add(Me.UltraLabel27)
        Me.Controls.Add(Me.UltraLabel28)
        Me.Controls.Add(Me.UltraLabel57)
        Me.Controls.Add(Me.tZip)
        Me.Controls.Add(Me.UltraLabel54)
        Me.Controls.Add(Me.UltraLabel30)
        Me.Controls.Add(Me.UltraLabel21)
        Me.Controls.Add(Me.cbShowInactives)
        Me.Controls.Add(Me.cbHasOrders)
        Me.Controls.Add(Me.bClear)
        Me.Controls.Add(Me.tStatus)
        Me.Controls.Add(Me.tType)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.bSearch)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "fmContactFind"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Contact"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbHasOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbShowInactives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPhoneExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tWebsite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tFax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAddr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tZip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDealer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCounty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContCountry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub bSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSearch.Click
        'If bSearch.Text = "Search" Then
        '    DoSearch()
        'Else
        If Not Grid1.ActiveRow Is Nothing Then
            ContactSerial = Grid1.ActiveRow.Cells("cont_serial").Value
            If Grid1.ActiveRow.Cells("cont_type").Value = "Speed" Then
                SpeedCodeSelected = True
            Else
                SpeedCodeSelected = False
            End If
        Else
            ContactSerial = 0
            SpeedCodeSelected = False
        End If
        Me.Hide()
        'End If

    End Sub
    Private Sub DoSearch()
        Dim dt As New DataTable
        Dim cmd As New SqlCommand("", cnn)
        Dim da As New SqlDataAdapter(cmd)
        Dim sql As String
        Dim gr As Infragistics.Win.UltraWinGrid.UltraGridRow

        If SearchSpeedCodes Then
            sql = ""
            If tName.Text <> "" Then sql += "(cust_name like '%" + Replace(tName.Text, "'", "''") + "%') and "
            If tDealer.Text <> "" Then sql += "(cust_id like '" + Replace(tDealer.Text, "'", "''") + "%') and "
            If tCompany.Text <> "" Then sql += "cust_company like '%" + Replace(tCompany.Text, "'", "''") + "%' and "
            If tContCountry.Text <> "" Then sql += "cust_country like '%" + Replace(tContCountry.Text, "'", "''") + "%' and "
            If tAddr.Text <> "" Then sql += "(cust_addr1 like '%" + Replace(tAddr.Text, "'", "''") + "%' or cust_addr2 like '%" + Replace(tAddr.Text, "'", "''") + "%' or cust_addr3 like '%" + Replace(tAddr.Text, "'", "''") + "%') and "
            If tZip.Text <> "" Then sql += "cust_zip like '" + tZip.Text + "%' and "
            If tCity.Text <> "" Then sql += "cust_city like '" + Replace(tCity.Text, "'", "''") + "%' and "
            If tState.Text <> "" Then sql += "cust_state = '" + tState.Text + "' and "
            If tPhone.Text <> "" Then sql += "(cust_phone1 like '%" + Replace(tPhone.Text, "'", "''") + "%' or cust_phone2 like '%" + Replace(tPhone.Text, "'", "''") + "%' or cust_cell like '%" + Replace(tPhone.Text, "'", "''") + "%') and "
            If tFax.Text <> "" Then sql += "cust_fax like '%" + Replace(tFax.Text, "'", "''") + "%' and "
            If tEmail.Text <> "" Then sql += "cust_email like '%" + Replace(tEmail.Text, "'", "''") + "%' and "
            If tWebsite.Text <> "" Then sql += "cust_web like '%" + Replace(tWebsite.Text, "'", "''") + "%' and "

            If sql <> "" Then
                If cbShowInactives.Checked = False Then sql += "inactive<>1 and "
                If Microsoft.VisualBasic.Right(sql, 4) = "and " Then sql = Mid(sql, 1, Len(sql) - 4)
                sql = "select top 100 cust_serial as cont_serial,cust_name as cont_name,cust_id,cust_company as cont_company,'Speed' as cont_type,cust_state as cont_state,cust_zip as cont_zip from cust_file where " + sql

                sql += " order by cust_name"

                cmd.CommandText = sql
                da.Fill(dt)
            End If
        End If

        sql = ""
        If tName.Text <> "" Then sql += "cont_name like '%" + Replace(tName.Text, "'", "''") + "%' and "
        If tCompany.Text <> "" Then sql += "cont_company like '%" + Replace(tCompany.Text, "'", "''") + "%' and "
        If tContCountry.Text <> "" Then sql += "cont_country like '%" + Replace(tContCountry.Text, "'", "''") + "%' and "
        If tAddr.Text <> "" Then sql += "(cont_addr1 like '%" + Replace(tAddr.Text, "'", "''") + "%' or cont_addr2 like '%" + Replace(tAddr.Text, "'", "''") + "%' or cont_addr3 like '%" + Replace(tAddr.Text, "'", "''") + "%') and "
        If tZip.Text <> "" Then sql += "cont_zip like '" + tZip.Text + "%' and "
        If tCity.Text <> "" Then sql += "cont_city like '" + Replace(tCity.Text, "'", "''") + "%' and "
        If tState.Text <> "" Then sql += "cont_state = '" + tState.Text + "' and "
        If tPhone.Text <> "" Then sql += "(cont_phone1 like '%" + Replace(tPhone.Text, "'", "''") + "%' or cont_phone2 like '%" + Replace(tPhone.Text, "'", "''") + "%' or cont_cell like '%" + Replace(tPhone.Text, "'", "''") + "%') and "
        If tPhoneExt.Text <> "" Then sql += "(cont_phone1_ext like '%" + Replace(tPhoneExt.Text, "'", "''") + "%' or cont_phone2_ext like '%" + Replace(tPhoneExt.Text, "'", "''") + "%') and "
        If tFax.Text <> "" Then sql += "cont_fax = '" + Replace(tFax.Text, "'", "''") + "' and "
        If tEmail.Text <> "" Then sql += "cont_email like '%" + Replace(tEmail.Text, "'", "''") + "%' and "
        If tWebsite.Text <> "" Then sql += "cont_website like '%" + Replace(tWebsite.Text, "'", "''") + "%' and "
        If tType.Text <> "" Then sql += "cont_type like '" + tType.Text + "%' and "
        If tStatus.Text <> "" Then sql += "cont_status = '" + tStatus.Text + "' and "

        If sql <> "" Then
            If cbShowInactives.Checked = False Then sql += "inactive<>1 and "
            If cbHasOrders.Checked = True Then sql += "(select count(*) from ord_cont where ord_cont_cont_serial=cont_serial)>0 and "
            If Microsoft.VisualBasic.Right(sql, 4) = "and " Then sql = Mid(sql, 1, Len(sql) - 4)
            sql = "select top 100 cont_serial,cont_name,'' as cust_id,cont_company,cont_type,cont_state,cont_zip from cont_file where " + sql

            sql += " order by cont_name"

            cmd.CommandText = sql
            da.Fill(dt)

            Grid1.DataSource = dt
            Grid1.DataBind()
            If Grid1.Rows.Count > 0 Then
                Grid1.Rows(0).Selected = True
                If SearchSpeedCodes Then
                    bAddContact.Visible = False
                Else
                    bAdd.Visible = False
                End If
            Else
                If SearchSpeedCodes Then
                    bAddContact.Visible = True
                Else
                    bAdd.Visible = True
                End If
            End If

            For Each gr In Grid1.Rows
                If gr.Cells("cont_type").Text = "Speed" Then gr.Appearance.BackColor = Color.FromArgb(255, 255, 192)
            Next
        Else
            Grid1.DataSource = dt
            Grid1.DataBind()
            If SearchSpeedCodes Then
                bAddContact.Visible = False
            Else
                bAdd.Visible = False
            End If
            For Each gr In Grid1.Rows
                If gr.Cells("cont_type").Text = "Speed" Then gr.Appearance.BackColor = Color.FromArgb(255, 255, 192)
            Next
        End If

    End Sub
    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        ContactSerial = Grid1.ActiveRow.Cells("cont_serial").Value
        If Grid1.ActiveRow.Cells("cont_type").Value = "Speed" Then
            SpeedCodeSelected = True
        Else
            SpeedCodeSelected = False
        End If
        Me.Hide()
    End Sub

    Private Sub fmContactFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("select cont_serial,cont_name,'' as cust_id,cont_company,cont_type,cont_state,cont_zip from cont_file where cont_serial=-1", cnn)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)

        da.Fill(dt)
        Grid1.DataSource = dt
        Grid1.DataBind()

        LoadDD2(tType, "cont_type", "cont_type", "cont_type")
        LoadDD2(tStatus, "cont_status", "cont_status", "cont_status")
        LoadDD2(tContCountry, "country_file", "country_code", "country_code", "country_code,country")

        If tType.Text <> "" Then bSearch_Click(sender, e)
        If SearchSpeedCodes = False Then
            tDealer.Visible = False
            lDealer.Visible = False
            bAddContact.Visible = False
        End If
        tName.Focus()
    End Sub

    Private Sub Grid1_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterRowActivate
        'LoadOrders(Grid1.ActiveRow.Cells("cont_serial").Value)
    End Sub
    'Private Sub LoadOrders(ByVal Contact As Long)
    '    Dim dt As New DataTable
    '    Dim cmd As New SqlCommand("select ord_cont_ord_serial,ord_for from ord_cont left outer join ord_file on ord_cont_ord_serial=ord_serial where ord_cont_cont_serial=" + CStr(Contact) + " order by ord_cont_ord_serial desc", cnn)
    '    Dim da As New SqlDataAdapter(cmd)

    '    cnn.Open()
    '    da.Fill(dt)
    '    cnn.Close()
    '    Grid2.DataSource = dt
    '    Grid2.DataBind()
    'End Sub

    Private Sub tName_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'bSearch.Text = "Search"
    End Sub

    Private Sub tCompany_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'bSearch.Text = "Search"
    End Sub

    Private Sub tState_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'bSearch.Text = "Search"
    End Sub

    Private Sub tZip_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'bSearch.Text = "Search"
    End Sub


    Private Sub tType_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tType.TextChanged
        DoSearch()
    End Sub

    Private Sub tStatus_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tStatus.TextChanged
        DoSearch()
    End Sub

    Private Sub bClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClear.Click
        tName.Text = ""
        tCompany.Text = ""
        tState.Text = ""
        tZip.Text = ""
        tType.Text = ""
        tStatus.Text = ""
        'bSearch.Text = "Search"
        Grid1.DataSource = Nothing
        Grid1.DataBind()
        'Grid2.DataSource = Nothing
        'Grid2.DataBind()
    End Sub

    Private Sub cbHasOrders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHasOrders.CheckedChanged
        'bSearch.Text = "Search"
    End Sub

    Private Sub cbShowInactives_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShowInactives.CheckedChanged
        'bSearch.Text = "Search"
    End Sub

    Private Sub tName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tName.KeyUp
        DoSearch()
    End Sub

    

    Private Sub tZip_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tZip.Enter
        onZip = tZip.Text
    End Sub

    Private Sub tZip_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tZip.KeyUp
        DoSearch()
    End Sub

    Private Sub tZip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tZip.Leave
        If tZip.Text <> onZip Then
            tCity.Text = ""
            tState.Text = ""
        End If
        If tZip.Text = "" Then Exit Sub
        LoadDD2(tCity, "zip_file", "zip_city", "zip_city", "zip_city,zip_state,zip_county_name", "zip_code='" + tZip.Text + "' and zip_start<='" + CStr(Today) + "' and zip_end>='" + CStr(Today) + " '")
    End Sub

    Private Sub tZip_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tZip.ValueChanged

    End Sub

    Private Sub tCompany_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tCompany.InitializeLayout

    End Sub

    Private Sub tCompany_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tCompany.KeyUp
        DoSearch()
    End Sub

    Private Sub tAddr_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tAddr.KeyUp
        DoSearch()
    End Sub

    Private Sub tAddr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tAddr.ValueChanged

    End Sub

    Private Sub tCity_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCity.Enter
        If tCity.Rows.Count = 1 Then
            tCity.Text = tCity.Rows(0).Cells(0).Text
        Else
            If tCity.IsDroppedDown = False Then tCity.ToggleDropdown()
        End If
    End Sub

    Private Sub tCity_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tCity.InitializeLayout

    End Sub

    Private Sub tCity_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tCity.KeyUp
        DoSearch()
    End Sub

    Private Sub tState_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tState.KeyUp
        DoSearch()
    End Sub

    Private Sub tState_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tState.ValueChanged

    End Sub

    Private Sub tPhone_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tPhone.KeyUp
        DoSearch()
    End Sub

    Private Sub tPhone_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPhone.ValueChanged

    End Sub

    Private Sub tCell_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tCell.KeyUp
        DoSearch()
    End Sub

    Private Sub tCell_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCell.ValueChanged

    End Sub

    Private Sub tFax_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tFax.KeyUp
        DoSearch()
    End Sub

    Private Sub tFax_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFax.ValueChanged

    End Sub

    Private Sub tEmail_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tEmail.KeyUp
        DoSearch()
    End Sub

    Private Sub tEmail_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tEmail.ValueChanged

    End Sub

    Private Sub tWebsite_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tWebsite.KeyUp
        DoSearch()
    End Sub

    Private Sub tWebsite_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tWebsite.ValueChanged

    End Sub

    Private Sub tType_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tType.InitializeLayout

    End Sub

    Private Sub tDealer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tDealer.KeyUp
        DoSearch()
    End Sub

    Private Sub bAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAdd.Click
        AddContact = True
        Me.Hide()
    End Sub

    Private Sub bAddContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAddContact.Click
        AddContact = True
        Me.Hide()
    End Sub

    Private Sub tCity_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCity.Leave
        Try
            If tCity.ActiveRow Is Nothing Then Exit Sub
            If tCity.IsItemInList(tCity.Value) = True Then
                tState.Text = tCity.ActiveRow.Cells(1).Text
                tCounty.Text = tCity.ActiveRow.Cells(2).Text
            End If
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Private Sub UltraTextEditor1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tCounty.KeyUp
        DoSearch()
    End Sub

    Private Sub UltraTextEditor1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCounty.ValueChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        UltraGridExcelExporter1.Export(Grid1, "temp.xls")
        System.Diagnostics.Process.Start("temp.xls")
    End Sub

    
    Private Sub tContCountry_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tContCountry.ValueChanged
        DoSearch()
    End Sub
End Class
