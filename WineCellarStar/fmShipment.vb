Imports WineCellar.ShipServiceWebReference
Imports System.Web.Services.Protocols
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data.SqlClient
Public Class fmShipment
    Inherits WineCellar.fmStarter
    Dim dsOrds As New DataSet
    Dim daOrds As New SqlDataAdapter
    Dim dsShip As New DataSet
    Dim daShip As New SqlDataAdapter
    Dim dsVia As New DataSet
    Dim dsRev As New DataSet
    Dim daRev As New SqlDataAdapter
    Dim dsType As New DataSet
    Dim daType As New SqlDataAdapter
    Dim toApply As Double
    Dim onOrd, onShip, onOrdField, onTrack, onStat As String
    Dim onDate As Date
    Dim dsBoxes As New DataSet
    Dim ShipType As String
    Dim FromRev As Integer
    Dim ShipPrinterFedEx As String
    Dim onShipDate As String
    Public CloseOnSave As Boolean = False
    Dim FedExService As String
    Friend WithEvents cbNoEmail As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Dim NeedSignature As Boolean = False

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
    Friend WithEvents tID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tOrd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tAuth As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Grid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tVia As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRev As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lCust As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tCreated As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lStatus As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents pFedEx As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tFedExService As System.Windows.Forms.ComboBox
    Friend WithEvents tFedExPackaging As System.Windows.Forms.ComboBox
    Friend WithEvents tFedExCity As System.Windows.Forms.TextBox
    Friend WithEvents tFedExZip As System.Windows.Forms.TextBox
    Friend WithEvents tFedExPhone As System.Windows.Forms.TextBox
    Friend WithEvents tFedExCountry As System.Windows.Forms.TextBox
    Friend WithEvents tFedExState As System.Windows.Forms.TextBox
    Friend WithEvents tFedExAddr2 As System.Windows.Forms.TextBox
    Friend WithEvents tFedExAddr1 As System.Windows.Forms.TextBox
    Friend WithEvents tFedExContact As System.Windows.Forms.TextBox
    Friend WithEvents tFedExComp As System.Windows.Forms.TextBox
    Friend WithEvents oNoStatus As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents tOut As System.Windows.Forms.TextBox
    Friend WithEvents tWeight As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents gBoxes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tFedExRef As System.Windows.Forms.TextBox
    Friend WithEvents chFedExResidential As System.Windows.Forms.CheckBox
    Friend WithEvents chFedExSat As System.Windows.Forms.CheckBox
    Friend WithEvents chFedExSign As System.Windows.Forms.CheckBox
    Friend WithEvents chFedExHold As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tFedExPO As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tFedEx3rdParty As System.Windows.Forms.TextBox
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bFedExDelete As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bShipFedEx As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bFedExRepeat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tFedExRepeat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents bFedExReprint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tFedExInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tCost As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents tShipLiveVia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tValue As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tFedexReturnText As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents bRemoveAll As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ship_itm_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ship_itm_ship_serial")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ship_itm_ord_serial")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ship_itm_ord_rev")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ship_itm_ord_itm_serial")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ship_itm_code")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ship_itm_desc")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ship_itm_qty")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_unt_sell")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_serial")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_ord_serial")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_type")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_rev")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_item_code")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_desc")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_toship")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_serial")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_unt_sell")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Weight")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Length")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Width")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Height")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracking")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Declared")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cost")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Reference")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itmcode")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmShipment))
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.tID = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tOrd = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Grid2 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.tAuth = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tWeight = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tVia = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.tCost = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.tRev = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.lCust = New Infragistics.Win.Misc.UltraLabel
        Me.tCreated = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lStatus = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.tType = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.pFedEx = New System.Windows.Forms.Panel
        Me.tFedExInvoice = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.bFedExReprint = New Infragistics.Win.Misc.UltraButton
        Me.tFedExRepeat = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.bFedExRepeat = New Infragistics.Win.Misc.UltraButton
        Me.bFedExDelete = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.tOut = New System.Windows.Forms.TextBox
        Me.tFedEx3rdParty = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tFedExPO = New System.Windows.Forms.TextBox
        Me.chFedExHold = New System.Windows.Forms.CheckBox
        Me.chFedExSign = New System.Windows.Forms.CheckBox
        Me.chFedExSat = New System.Windows.Forms.CheckBox
        Me.chFedExResidential = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tFedExRef = New System.Windows.Forms.TextBox
        Me.gBoxes = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Label12 = New System.Windows.Forms.Label
        Me.tFedExService = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tFedExPackaging = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tFedExCity = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tFedExZip = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tFedExPhone = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tFedExCountry = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tFedExState = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tFedExAddr2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tFedExAddr1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tFedExContact = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tFedExComp = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.oNoStatus = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.bShipFedEx = New Infragistics.Win.Misc.UltraButton
        Me.tShipLiveVia = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tValue = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.tFedexReturnText = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.bRemoveAll = New Infragistics.Win.Misc.UltraButton
        Me.cbNoEmail = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        CType(Me.tID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAuth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tVia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCreated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pFedEx.SuspendLayout()
        CType(Me.tFedExRepeat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gBoxes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oNoStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tShipLiveVia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tFedexReturnText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNoEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tID
        '
        Me.tID.Enabled = False
        Me.tID.Location = New System.Drawing.Point(8, 104)
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(96, 21)
        Me.tID.TabIndex = 0
        Me.tID.Tag = "key;ship_serial;nm"
        Me.tID.Visible = False
        '
        'tOrd
        '
        Me.tOrd.Enabled = False
        Me.tOrd.Location = New System.Drawing.Point(8, 8)
        Me.tOrd.Name = "tOrd"
        Me.tOrd.Size = New System.Drawing.Size(72, 21)
        Me.tOrd.TabIndex = 0
        Me.tOrd.Tag = "Edit;ship_ord_serial"
        '
        'Grid2
        '
        Me.Grid2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.DarkGoldenrod
        Appearance1.BackColor2 = System.Drawing.Color.Khaki
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.Grid2.DisplayLayout.Appearance = Appearance1
        Me.Grid2.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 103
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 119
        UltraGridColumn3.Header.Caption = "Order"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Width = 97
        UltraGridColumn4.Header.Caption = "Rev"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.MaxWidth = 30
        UltraGridColumn4.MinWidth = 30
        UltraGridColumn4.Width = 30
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.Width = 147
        UltraGridColumn6.Header.Caption = "Item Code"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 132
        UltraGridColumn7.Header.Caption = "Description"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 264
        UltraGridColumn8.Header.Caption = "Qty"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 50
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 96
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        Me.Grid2.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid2.DisplayLayout.InterBandSpacing = 10
        Me.Grid2.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.Grid2.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Grid2.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.Goldenrod
        Appearance3.BackColor2 = System.Drawing.Color.DarkGoldenrod
        Appearance3.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.None
        Me.Grid2.DisplayLayout.Override.CellAppearance = Appearance3
        Me.Grid2.DisplayLayout.Override.CellSpacing = 2
        Appearance4.BackColor = System.Drawing.Color.Goldenrod
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.FontData.Name = "Verdana"
        Appearance4.ForeColor = System.Drawing.Color.Black
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid2.DisplayLayout.Override.HeaderAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Grid2.DisplayLayout.Override.RowAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.Khaki
        Me.Grid2.DisplayLayout.Override.RowSelectorAppearance = Appearance6
        Me.Grid2.DisplayLayout.Override.RowSelectorWidth = 10
        Me.Grid2.DisplayLayout.Override.RowSpacingAfter = 0
        Me.Grid2.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance7.BackColor = System.Drawing.Color.DarkGoldenrod
        Appearance7.BackColor2 = System.Drawing.Color.Khaki
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.Grid2.DisplayLayout.Override.SelectedRowAppearance = Appearance7
        Me.Grid2.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.Grid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid2.Location = New System.Drawing.Point(480, 160)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(488, 726)
        Me.Grid2.TabIndex = 12
        Me.Grid2.Tag = ""
        Me.Grid2.Text = "Now Shipping"
        Me.Grid2.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus
        '
        'UltraLabel10
        '
        Me.UltraLabel10.BackColorInternal = System.Drawing.Color.DarkGoldenrod
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(864, 32)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel10.TabIndex = 70
        Me.UltraLabel10.Text = "Cost"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.BackColorInternal = System.Drawing.Color.DarkGoldenrod
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(680, 32)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel9.TabIndex = 68
        Me.UltraLabel9.Text = "Boxes"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.BackColorInternal = System.Drawing.Color.DarkGoldenrod
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(608, 32)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel8.TabIndex = 67
        Me.UltraLabel8.Text = "Weight"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.BackColorInternal = System.Drawing.Color.DarkGoldenrod
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(456, 32)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel7.TabIndex = 66
        Me.UltraLabel7.Text = "Tracking Number"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.BackColorInternal = System.Drawing.Color.DarkGoldenrod
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(312, 32)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel6.TabIndex = 65
        Me.UltraLabel6.Text = "Ship Via"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.BackColorInternal = System.Drawing.Color.DarkGoldenrod
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(216, 32)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel5.TabIndex = 64
        Me.UltraLabel5.Text = "Date"
        '
        'tAuth
        '
        Me.tAuth.Enabled = False
        Me.tAuth.Location = New System.Drawing.Point(680, 8)
        Me.tAuth.Name = "tAuth"
        Me.tAuth.Size = New System.Drawing.Size(72, 21)
        Me.tAuth.TabIndex = 7
        Me.tAuth.Tag = "Edit;ship_boxes;nm"
        '
        'tWeight
        '
        Me.tWeight.Enabled = False
        Me.tWeight.Location = New System.Drawing.Point(608, 8)
        Me.tWeight.Name = "tWeight"
        Me.tWeight.Size = New System.Drawing.Size(64, 21)
        Me.tWeight.TabIndex = 6
        Me.tWeight.Tag = "Edit;ship_weight;nm"
        '
        'tNum
        '
        Me.tNum.Enabled = False
        Me.tNum.Location = New System.Drawing.Point(456, 8)
        Me.tNum.Name = "tNum"
        Me.tNum.Size = New System.Drawing.Size(144, 21)
        Me.tNum.TabIndex = 5
        Me.tNum.Tag = "Edit;ship_track"
        '
        'tVia
        '
        Me.tVia.CheckedListSettings.CheckStateMember = ""
        Me.tVia.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tVia.Enabled = False
        Me.tVia.Location = New System.Drawing.Point(312, 8)
        Me.tVia.Name = "tVia"
        Me.tVia.Size = New System.Drawing.Size(136, 22)
        Me.tVia.TabIndex = 4
        Me.tVia.Tag = "Edit;ship_via"
        '
        'tDate
        '
        Me.tDate.Enabled = False
        Me.tDate.Location = New System.Drawing.Point(216, 8)
        Me.tDate.Name = "tDate"
        Me.tDate.Size = New System.Drawing.Size(88, 21)
        Me.tDate.TabIndex = 3
        Me.tDate.Tag = "Edit;ship_date;dt"
        '
        'UltraLabel31
        '
        Me.UltraLabel31.BackColorInternal = System.Drawing.Color.DarkGoldenrod
        Me.UltraLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel31.Location = New System.Drawing.Point(8, 32)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel31.TabIndex = 53
        Me.UltraLabel31.Text = "Order"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance8.BackColor = System.Drawing.Color.DarkGoldenrod
        Appearance8.BackColor2 = System.Drawing.Color.Khaki
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.Grid1.DisplayLayout.Appearance = Appearance8
        Me.Grid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.MaxWidth = 8
        UltraGridColumn10.Width = 8
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.Caption = "Order"
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 188
        UltraGridColumn12.Header.Caption = "Type"
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn12.MinWidth = 30
        UltraGridColumn12.Width = 38
        UltraGridColumn13.Header.Caption = "Rev"
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn13.MinWidth = 30
        UltraGridColumn13.Width = 38
        UltraGridColumn14.Header.Caption = "Item Code"
        UltraGridColumn14.Header.VisiblePosition = 4
        UltraGridColumn14.Width = 205
        UltraGridColumn15.Header.Caption = "Description"
        UltraGridColumn15.Header.VisiblePosition = 5
        UltraGridColumn15.Width = 159
        UltraGridColumn16.Header.Caption = "To Ship"
        UltraGridColumn16.Header.VisiblePosition = 6
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.Width = 114
        UltraGridColumn17.Header.VisiblePosition = 7
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 100
        UltraGridColumn18.Header.VisiblePosition = 8
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.Width = 93
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.Grid1.DisplayLayout.InterBandSpacing = 10
        Me.Grid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.Grid1.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.Color.Goldenrod
        Appearance10.BackColor2 = System.Drawing.Color.DarkGoldenrod
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.None
        Me.Grid1.DisplayLayout.Override.CellAppearance = Appearance10
        Me.Grid1.DisplayLayout.Override.CellSpacing = 2
        Appearance11.BackColor = System.Drawing.Color.Goldenrod
        Appearance11.FontData.BoldAsString = "True"
        Appearance11.FontData.Name = "Verdana"
        Appearance11.ForeColor = System.Drawing.Color.Black
        Appearance11.TextHAlignAsString = "Left"
        Appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid1.DisplayLayout.Override.HeaderAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.RowAppearance = Appearance12
        Appearance13.BackColor = System.Drawing.Color.Khaki
        Me.Grid1.DisplayLayout.Override.RowSelectorAppearance = Appearance13
        Me.Grid1.DisplayLayout.Override.RowSelectorWidth = 30
        Me.Grid1.DisplayLayout.Override.RowSpacingAfter = 0
        Me.Grid1.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance14.BackColor = System.Drawing.Color.DarkGoldenrod
        Appearance14.BackColor2 = System.Drawing.Color.Khaki
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.Grid1.DisplayLayout.Override.SelectedRowAppearance = Appearance14
        Me.Grid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 160)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(472, 726)
        Me.Grid1.TabIndex = 11
        Me.Grid1.Tag = ""
        Me.Grid1.Text = "Available to Ship"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(352, 128)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(120, 24)
        Me.UltraButton1.TabIndex = 9
        Me.UltraButton1.Text = "Ship All"
        '
        'tCost
        '
        Me.tCost.Enabled = False
        Me.tCost.Location = New System.Drawing.Point(864, 8)
        Me.tCost.MaskInput = "{LOC}$ nn,nnn.nn"
        Me.tCost.MaxValue = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.tCost.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.tCost.Name = "tCost"
        Me.tCost.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.tCost.Size = New System.Drawing.Size(88, 21)
        Me.tCost.TabIndex = 8
        Me.tCost.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.tCost.Tag = "Edit;ship_cost;cu"
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.AcceptsReturn = True
        Me.UltraTextEditor1.Enabled = False
        Me.UltraTextEditor1.Location = New System.Drawing.Point(480, 56)
        Me.UltraTextEditor1.Multiline = True
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.UltraTextEditor1.Size = New System.Drawing.Size(488, 64)
        Me.UltraTextEditor1.TabIndex = 10
        Me.UltraTextEditor1.Tag = "edit;ship_note"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.BackColorInternal = System.Drawing.Color.DarkGoldenrod
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(432, 56)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(40, 24)
        Me.UltraLabel1.TabIndex = 72
        Me.UltraLabel1.Text = "Note"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.BackColorInternal = System.Drawing.Color.DarkGoldenrod
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(88, 32)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 24)
        Me.UltraLabel2.TabIndex = 74
        Me.UltraLabel2.Text = "Rev"
        '
        'tRev
        '
        Me.tRev.CheckedListSettings.CheckStateMember = ""
        Me.tRev.Enabled = False
        Me.tRev.Location = New System.Drawing.Point(88, 8)
        Me.tRev.Name = "tRev"
        Me.tRev.Size = New System.Drawing.Size(48, 22)
        Me.tRev.TabIndex = 1
        Me.tRev.Tag = "Edit;ship_ord_rev"
        Me.tRev.Text = "0"
        '
        'lCust
        '
        Appearance15.ForeColor = System.Drawing.Color.White
        Me.lCust.Appearance = Appearance15
        Me.lCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCust.Location = New System.Drawing.Point(8, 56)
        Me.lCust.Name = "lCust"
        Me.lCust.Size = New System.Drawing.Size(416, 24)
        Me.lCust.TabIndex = 76
        '
        'tCreated
        '
        Me.tCreated.Enabled = False
        Me.tCreated.Location = New System.Drawing.Point(128, 104)
        Me.tCreated.Name = "tCreated"
        Me.tCreated.Size = New System.Drawing.Size(96, 21)
        Me.tCreated.TabIndex = 77
        Me.tCreated.Tag = "show;ship_created;dt"
        Me.tCreated.Visible = False
        '
        'lStatus
        '
        Appearance16.ForeColor = System.Drawing.Color.White
        Me.lStatus.Appearance = Appearance16
        Me.lStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStatus.Location = New System.Drawing.Point(8, 80)
        Me.lStatus.Name = "lStatus"
        Me.lStatus.Size = New System.Drawing.Size(336, 24)
        Me.lStatus.TabIndex = 78
        '
        'UltraLabel3
        '
        Me.UltraLabel3.BackColorInternal = System.Drawing.Color.DarkGoldenrod
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(136, 32)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(72, 24)
        Me.UltraLabel3.TabIndex = 80
        Me.UltraLabel3.Text = "Ord Type"
        '
        'tType
        '
        Me.tType.CheckedListSettings.CheckStateMember = ""
        Me.tType.Enabled = False
        Me.tType.Location = New System.Drawing.Point(144, 8)
        Me.tType.Name = "tType"
        Me.tType.Size = New System.Drawing.Size(48, 22)
        Me.tType.TabIndex = 2
        Me.tType.Tag = "Edit;ship_ord_type"
        Me.tType.Text = "O"
        '
        'pFedEx
        '
        Me.pFedEx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pFedEx.BackColor = System.Drawing.Color.Goldenrod
        Me.pFedEx.Controls.Add(Me.tFedExInvoice)
        Me.pFedEx.Controls.Add(Me.Label15)
        Me.pFedEx.Controls.Add(Me.bFedExReprint)
        Me.pFedEx.Controls.Add(Me.tFedExRepeat)
        Me.pFedEx.Controls.Add(Me.bFedExRepeat)
        Me.pFedEx.Controls.Add(Me.bFedExDelete)
        Me.pFedEx.Controls.Add(Me.UltraButton2)
        Me.pFedEx.Controls.Add(Me.tOut)
        Me.pFedEx.Controls.Add(Me.tFedEx3rdParty)
        Me.pFedEx.Controls.Add(Me.Label13)
        Me.pFedEx.Controls.Add(Me.tFedExPO)
        Me.pFedEx.Controls.Add(Me.chFedExHold)
        Me.pFedEx.Controls.Add(Me.chFedExSign)
        Me.pFedEx.Controls.Add(Me.chFedExSat)
        Me.pFedEx.Controls.Add(Me.chFedExResidential)
        Me.pFedEx.Controls.Add(Me.Label6)
        Me.pFedEx.Controls.Add(Me.tFedExRef)
        Me.pFedEx.Controls.Add(Me.gBoxes)
        Me.pFedEx.Controls.Add(Me.Label12)
        Me.pFedEx.Controls.Add(Me.tFedExService)
        Me.pFedEx.Controls.Add(Me.Label11)
        Me.pFedEx.Controls.Add(Me.tFedExPackaging)
        Me.pFedEx.Controls.Add(Me.Label10)
        Me.pFedEx.Controls.Add(Me.tFedExCity)
        Me.pFedEx.Controls.Add(Me.Label9)
        Me.pFedEx.Controls.Add(Me.tFedExZip)
        Me.pFedEx.Controls.Add(Me.Label8)
        Me.pFedEx.Controls.Add(Me.tFedExPhone)
        Me.pFedEx.Controls.Add(Me.Label7)
        Me.pFedEx.Controls.Add(Me.tFedExCountry)
        Me.pFedEx.Controls.Add(Me.Label5)
        Me.pFedEx.Controls.Add(Me.tFedExState)
        Me.pFedEx.Controls.Add(Me.Label4)
        Me.pFedEx.Controls.Add(Me.tFedExAddr2)
        Me.pFedEx.Controls.Add(Me.Label3)
        Me.pFedEx.Controls.Add(Me.tFedExAddr1)
        Me.pFedEx.Controls.Add(Me.Label2)
        Me.pFedEx.Controls.Add(Me.tFedExContact)
        Me.pFedEx.Controls.Add(Me.Label1)
        Me.pFedEx.Controls.Add(Me.tFedExComp)
        Me.pFedEx.Controls.Add(Me.PictureBox1)
        Me.pFedEx.Controls.Add(Me.Label14)
        Me.pFedEx.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pFedEx.Location = New System.Drawing.Point(0, 272)
        Me.pFedEx.Name = "pFedEx"
        Me.pFedEx.Size = New System.Drawing.Size(1315, 767)
        Me.pFedEx.TabIndex = 81
        Me.pFedEx.Visible = False
        '
        'tFedExInvoice
        '
        Me.tFedExInvoice.Location = New System.Drawing.Point(96, 400)
        Me.tFedExInvoice.Name = "tFedExInvoice"
        Me.tFedExInvoice.Size = New System.Drawing.Size(208, 20)
        Me.tFedExInvoice.TabIndex = 112
        Me.tFedExInvoice.Tag = ""
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 400)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 113
        Me.Label15.Text = "Invoice #"
        '
        'bFedExReprint
        '
        Me.bFedExReprint.Location = New System.Drawing.Point(856, 128)
        Me.bFedExReprint.Name = "bFedExReprint"
        Me.bFedExReprint.Size = New System.Drawing.Size(112, 24)
        Me.bFedExReprint.TabIndex = 111
        Me.bFedExReprint.Text = "Reprint Label"
        '
        'tFedExRepeat
        '
        Me.tFedExRepeat.Location = New System.Drawing.Point(824, 272)
        Me.tFedExRepeat.Name = "tFedExRepeat"
        Me.tFedExRepeat.Size = New System.Drawing.Size(72, 21)
        Me.tFedExRepeat.TabIndex = 110
        Me.tFedExRepeat.Text = "1"
        '
        'bFedExRepeat
        '
        Me.bFedExRepeat.Location = New System.Drawing.Point(824, 296)
        Me.bFedExRepeat.Name = "bFedExRepeat"
        Me.bFedExRepeat.Size = New System.Drawing.Size(72, 24)
        Me.bFedExRepeat.TabIndex = 109
        Me.bFedExRepeat.Text = "Repeat"
        '
        'bFedExDelete
        '
        Me.bFedExDelete.Location = New System.Drawing.Point(856, 96)
        Me.bFedExDelete.Name = "bFedExDelete"
        Me.bFedExDelete.Size = New System.Drawing.Size(112, 24)
        Me.bFedExDelete.TabIndex = 108
        Me.bFedExDelete.Text = "Delete Shipment"
        '
        'UltraButton2
        '
        Me.UltraButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraButton2.Location = New System.Drawing.Point(1291, 0)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(24, 24)
        Me.UltraButton2.TabIndex = 107
        Me.UltraButton2.Text = "X"
        '
        'tOut
        '
        Me.tOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tOut.Location = New System.Drawing.Point(496, 328)
        Me.tOut.Multiline = True
        Me.tOut.Name = "tOut"
        Me.tOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tOut.Size = New System.Drawing.Size(810, 431)
        Me.tOut.TabIndex = 54
        Me.tOut.Visible = False
        '
        'tFedEx3rdParty
        '
        Me.tFedEx3rdParty.Location = New System.Drawing.Point(96, 376)
        Me.tFedEx3rdParty.Name = "tFedEx3rdParty"
        Me.tFedEx3rdParty.Size = New System.Drawing.Size(208, 20)
        Me.tFedEx3rdParty.TabIndex = 41
        Me.tFedEx3rdParty.Tag = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 352)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Cust PO"
        '
        'tFedExPO
        '
        Me.tFedExPO.Location = New System.Drawing.Point(96, 352)
        Me.tFedExPO.Name = "tFedExPO"
        Me.tFedExPO.Size = New System.Drawing.Size(208, 20)
        Me.tFedExPO.TabIndex = 40
        Me.tFedExPO.Tag = ""
        '
        'chFedExHold
        '
        Me.chFedExHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFedExHold.Location = New System.Drawing.Point(344, 408)
        Me.chFedExHold.Name = "chFedExHold"
        Me.chFedExHold.Size = New System.Drawing.Size(160, 16)
        Me.chFedExHold.TabIndex = 46
        Me.chFedExHold.Text = "Hold At Terminal"
        '
        'chFedExSign
        '
        Me.chFedExSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFedExSign.Location = New System.Drawing.Point(344, 384)
        Me.chFedExSign.Name = "chFedExSign"
        Me.chFedExSign.Size = New System.Drawing.Size(160, 19)
        Me.chFedExSign.TabIndex = 45
        Me.chFedExSign.Text = "Signature Required"
        '
        'chFedExSat
        '
        Me.chFedExSat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFedExSat.Location = New System.Drawing.Point(344, 360)
        Me.chFedExSat.Name = "chFedExSat"
        Me.chFedExSat.Size = New System.Drawing.Size(160, 19)
        Me.chFedExSat.TabIndex = 44
        Me.chFedExSat.Text = "Saturday Delivery"
        '
        'chFedExResidential
        '
        Me.chFedExResidential.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFedExResidential.Location = New System.Drawing.Point(344, 336)
        Me.chFedExResidential.Name = "chFedExResidential"
        Me.chFedExResidential.Size = New System.Drawing.Size(160, 16)
        Me.chFedExResidential.TabIndex = 43
        Me.chFedExResidential.Text = "Residential"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Reference"
        '
        'tFedExRef
        '
        Me.tFedExRef.Location = New System.Drawing.Point(96, 328)
        Me.tFedExRef.Name = "tFedExRef"
        Me.tFedExRef.Size = New System.Drawing.Size(208, 20)
        Me.tFedExRef.TabIndex = 39
        Me.tFedExRef.Tag = ""
        '
        'gBoxes
        '
        Appearance17.BackColor = System.Drawing.Color.Khaki
        Me.gBoxes.DisplayLayout.Appearance = Appearance17
        Me.gBoxes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.MaxWidth = 50
        UltraGridColumn19.MinWidth = 50
        UltraGridColumn19.Width = 50
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn20.MaxWidth = 50
        UltraGridColumn20.MinWidth = 50
        UltraGridColumn20.Width = 50
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.MaxWidth = 50
        UltraGridColumn21.MinWidth = 50
        UltraGridColumn21.Width = 50
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridColumn22.MaxWidth = 50
        UltraGridColumn22.MinWidth = 50
        UltraGridColumn22.Width = 50
        UltraGridColumn23.Header.VisiblePosition = 4
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.Width = 84
        UltraGridColumn24.Header.Caption = "Declared $$$"
        UltraGridColumn24.Header.VisiblePosition = 5
        UltraGridColumn24.Width = 125
        UltraGridColumn25.Header.VisiblePosition = 6
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.Width = 83
        UltraGridColumn26.Header.VisiblePosition = 7
        UltraGridColumn26.Width = 158
        UltraGridColumn27.Header.VisiblePosition = 8
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.Width = 74
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27})
        Me.gBoxes.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.gBoxes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.gBoxes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.gBoxes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gBoxes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gBoxes.Enabled = False
        Me.gBoxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gBoxes.Location = New System.Drawing.Point(312, 32)
        Me.gBoxes.Name = "gBoxes"
        Me.gBoxes.Size = New System.Drawing.Size(504, 288)
        Me.gBoxes.TabIndex = 94
        Me.gBoxes.Tag = "edit"
        Me.gBoxes.Text = "Boxes"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Service"
        '
        'tFedExService
        '
        Me.tFedExService.Items.AddRange(New Object() {"FedEx Priority Overnight", "FedEx 2Day", "FedEx Standard Overnight", "FedEx 3Day Freight", "Ground", "FedEx Home Delivery", "International Priority"})
        Me.tFedExService.Location = New System.Drawing.Point(96, 296)
        Me.tFedExService.Name = "tFedExService"
        Me.tFedExService.Size = New System.Drawing.Size(208, 22)
        Me.tFedExService.TabIndex = 38
        Me.tFedExService.Text = "FedEx 2Day"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Packaging"
        '
        'tFedExPackaging
        '
        Me.tFedExPackaging.Items.AddRange(New Object() {"Customer Packaging", "FedEx Pak", "FedEx Box", "FedEx Tube", "FedEx Envelope"})
        Me.tFedExPackaging.Location = New System.Drawing.Point(96, 272)
        Me.tFedExPackaging.Name = "tFedExPackaging"
        Me.tFedExPackaging.Size = New System.Drawing.Size(208, 22)
        Me.tFedExPackaging.TabIndex = 37
        Me.tFedExPackaging.Text = "Customer Packaging"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "City"
        '
        'tFedExCity
        '
        Me.tFedExCity.Location = New System.Drawing.Point(96, 128)
        Me.tFedExCity.Name = "tFedExCity"
        Me.tFedExCity.Size = New System.Drawing.Size(208, 20)
        Me.tFedExCity.TabIndex = 32
        Me.tFedExCity.Tag = "15"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(144, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Zip"
        '
        'tFedExZip
        '
        Me.tFedExZip.Location = New System.Drawing.Point(184, 152)
        Me.tFedExZip.Name = "tFedExZip"
        Me.tFedExZip.Size = New System.Drawing.Size(120, 20)
        Me.tFedExZip.TabIndex = 34
        Me.tFedExZip.Tag = "17"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Phone"
        '
        'tFedExPhone
        '
        Me.tFedExPhone.Location = New System.Drawing.Point(96, 208)
        Me.tFedExPhone.Name = "tFedExPhone"
        Me.tFedExPhone.Size = New System.Drawing.Size(208, 20)
        Me.tFedExPhone.TabIndex = 36
        Me.tFedExPhone.Tag = "18"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Country"
        '
        'tFedExCountry
        '
        Me.tFedExCountry.Location = New System.Drawing.Point(96, 176)
        Me.tFedExCountry.Name = "tFedExCountry"
        Me.tFedExCountry.Size = New System.Drawing.Size(208, 20)
        Me.tFedExCountry.TabIndex = 35
        Me.tFedExCountry.Tag = "50"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "State"
        '
        'tFedExState
        '
        Me.tFedExState.Location = New System.Drawing.Point(96, 152)
        Me.tFedExState.Name = "tFedExState"
        Me.tFedExState.Size = New System.Drawing.Size(40, 20)
        Me.tFedExState.TabIndex = 33
        Me.tFedExState.Tag = "16"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Addr2"
        '
        'tFedExAddr2
        '
        Me.tFedExAddr2.Location = New System.Drawing.Point(96, 104)
        Me.tFedExAddr2.Name = "tFedExAddr2"
        Me.tFedExAddr2.Size = New System.Drawing.Size(208, 20)
        Me.tFedExAddr2.TabIndex = 31
        Me.tFedExAddr2.Tag = "14"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Addr1"
        '
        'tFedExAddr1
        '
        Me.tFedExAddr1.Location = New System.Drawing.Point(96, 80)
        Me.tFedExAddr1.Name = "tFedExAddr1"
        Me.tFedExAddr1.Size = New System.Drawing.Size(208, 20)
        Me.tFedExAddr1.TabIndex = 30
        Me.tFedExAddr1.Tag = "13"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Contact"
        '
        'tFedExContact
        '
        Me.tFedExContact.Location = New System.Drawing.Point(96, 56)
        Me.tFedExContact.Name = "tFedExContact"
        Me.tFedExContact.Size = New System.Drawing.Size(208, 20)
        Me.tFedExContact.TabIndex = 29
        Me.tFedExContact.Tag = "12"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Company"
        '
        'tFedExComp
        '
        Me.tFedExComp.Location = New System.Drawing.Point(96, 32)
        Me.tFedExComp.Name = "tFedExComp"
        Me.tFedExComp.Size = New System.Drawing.Size(208, 20)
        Me.tFedExComp.TabIndex = 28
        Me.tFedExComp.Tag = "11"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1163, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 56)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 376)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 16)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "3rd Party Act#"
        '
        'oNoStatus
        '
        Appearance19.FontData.BoldAsString = "True"
        Me.oNoStatus.Appearance = Appearance19
        Me.oNoStatus.Enabled = False
        Me.oNoStatus.Location = New System.Drawing.Point(8, 112)
        Me.oNoStatus.Name = "oNoStatus"
        Me.oNoStatus.Size = New System.Drawing.Size(336, 16)
        Me.oNoStatus.TabIndex = 82
        Me.oNoStatus.Tag = "edit;ship_no_status_change;cb"
        Me.oNoStatus.Text = "Do Not Change Order Status to SHIPPED"
        '
        'bShipFedEx
        '
        Me.bShipFedEx.Location = New System.Drawing.Point(480, 128)
        Me.bShipFedEx.Name = "bShipFedEx"
        Me.bShipFedEx.Size = New System.Drawing.Size(112, 24)
        Me.bShipFedEx.TabIndex = 83
        Me.bShipFedEx.Text = "Ship FedEx"
        '
        'tShipLiveVia
        '
        Me.tShipLiveVia.Location = New System.Drawing.Point(544, 64)
        Me.tShipLiveVia.Name = "tShipLiveVia"
        Me.tShipLiveVia.Size = New System.Drawing.Size(144, 21)
        Me.tShipLiveVia.TabIndex = 84
        Me.tShipLiveVia.Tag = "edit;ship_live_via"
        Me.tShipLiveVia.Visible = False
        '
        'tValue
        '
        Me.tValue.Enabled = False
        Me.tValue.Location = New System.Drawing.Point(760, 8)
        Me.tValue.MaskInput = "{LOC}$ nn,nnn.nn"
        Me.tValue.MaxValue = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.tValue.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.tValue.Name = "tValue"
        Me.tValue.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.tValue.Size = New System.Drawing.Size(88, 21)
        Me.tValue.TabIndex = 85
        Me.tValue.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.tValue.Tag = "Edit;ship_declared;cu"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.BackColorInternal = System.Drawing.Color.DarkGoldenrod
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(760, 32)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(96, 24)
        Me.UltraLabel4.TabIndex = 86
        Me.UltraLabel4.Text = "Declared Value"
        '
        'tFedexReturnText
        '
        Me.tFedexReturnText.Location = New System.Drawing.Point(712, 64)
        Me.tFedexReturnText.Name = "tFedexReturnText"
        Me.tFedexReturnText.Size = New System.Drawing.Size(144, 21)
        Me.tFedexReturnText.TabIndex = 87
        Me.tFedexReturnText.Tag = "edit;ship_fedex_return_text"
        Me.tFedexReturnText.Visible = False
        '
        'bRemoveAll
        '
        Me.bRemoveAll.Location = New System.Drawing.Point(848, 128)
        Me.bRemoveAll.Name = "bRemoveAll"
        Me.bRemoveAll.Size = New System.Drawing.Size(120, 24)
        Me.bRemoveAll.TabIndex = 88
        Me.bRemoveAll.Text = "Remove All"
        '
        'cbNoEmail
        '
        Appearance18.FontData.BoldAsString = "True"
        Me.cbNoEmail.Appearance = Appearance18
        Me.cbNoEmail.Enabled = False
        Me.cbNoEmail.Location = New System.Drawing.Point(8, 130)
        Me.cbNoEmail.Name = "cbNoEmail"
        Me.cbNoEmail.Size = New System.Drawing.Size(336, 16)
        Me.cbNoEmail.TabIndex = 89
        Me.cbNoEmail.Tag = "edit;ship_no_email;cb"
        Me.cbNoEmail.Text = "Do Not send Email Notification to Customer"
        Me.cbNoEmail.Visible = False
        '
        'fmShipment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.ClientSize = New System.Drawing.Size(1315, 892)
        Me.Controls.Add(Me.cbNoEmail)
        Me.Controls.Add(Me.bRemoveAll)
        Me.Controls.Add(Me.tCreated)
        Me.Controls.Add(Me.tFedexReturnText)
        Me.Controls.Add(Me.tValue)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.tShipLiveVia)
        Me.Controls.Add(Me.pFedEx)
        Me.Controls.Add(Me.bShipFedEx)
        Me.Controls.Add(Me.oNoStatus)
        Me.Controls.Add(Me.tType)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.lStatus)
        Me.Controls.Add(Me.lCust)
        Me.Controls.Add(Me.tRev)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraTextEditor1)
        Me.Controls.Add(Me.tCost)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.tOrd)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.tAuth)
        Me.Controls.Add(Me.tWeight)
        Me.Controls.Add(Me.tNum)
        Me.Controls.Add(Me.tVia)
        Me.Controls.Add(Me.tDate)
        Me.Controls.Add(Me.UltraLabel31)
        Me.KeyPreview = True
        Me.Name = "fmShipment"
        Me.Text = "fmShipment"
        CType(Me.tID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAuth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tVia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCreated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pFedEx.ResumeLayout(False)
        Me.pFedEx.PerformLayout()
        CType(Me.tFedExRepeat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gBoxes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oNoStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tShipLiveVia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tFedexReturnText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNoEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub FillGrid(ByVal Datax As String)
        Try
            Dim cmd As New SqlCommand

            dsOrds.Clear()
            cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_type,ord_gen_rev,ord_itm_item_code,ord_itm_desc,ord_itm_qty as ord_itm_toship,ord_itm_serial,ord_itm_unt_sell from ord_gen,ord_itm where ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev=ord_itm_rev and ord_gen_type=ord_itm_type and ord_gen_ord_serial=" + Datax + " and ord_gen_type='" + tType.Text + "' and ord_gen_rev = " + tRev.Text + " order by ord_itm_line"
            cmd.Connection = cnn
            daOrds.SelectCommand = cmd
            cnn.Open()
            daOrds.Fill(dsOrds, "ord_file")
            Grid1.DataSource = dsOrds
            Grid1.DataBind()

            dsShip.Clear()
            cmd.CommandText = "select ship_itm_serial,ship_itm_ship_serial,ship_itm_ord_serial,ship_itm_ord_rev,ship_itm_ord_itm_serial,ship_itm_code,ship_itm_desc,ship_itm_qty,0 as ord_itm_unt_sell from ship_itm where ship_itm_ship_serial=" + KeyValue1.ToString
            cmd.Connection = cnn
            daShip.SelectCommand = cmd
            Dim cb As SqlCommandBuilder = New SqlCommandBuilder(daShip)
            daShip.Fill(dsShip, "ship_itm")
            cnn.Close()
            Grid2.DataSource = dsShip
            Grid2.DataBind()

            If Grid1.Rows.Count = 0 Then
                MsgBox("Order not found", MsgBoxStyle.Exclamation, "Order?")
                tOrd.Focus()
                tOrd.SelectAll()
            End If
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Private Sub fmShipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Table = "ship_file"
        Me.Key1 = "ship_serial"
        Me.FocusField = "tOrd"

        LoadDD(tVia, dsVia, "ship_via", "ship_via_code", "ship_via_code", "ship_via_code,ship_via_desc", "ship_via_inactive<>1")
        Try
            tVia.Value = GetSetting("Jcom", "Settings", "ShipVia", "")
        Catch
        End Try

        dsBoxes.Tables.Add("boxes")
        dsBoxes.Tables(0).Columns.Add("Weight", GetType(Double))
        dsBoxes.Tables(0).Columns.Add("Length", GetType(Integer))
        dsBoxes.Tables(0).Columns.Add("Width", GetType(Integer))
        dsBoxes.Tables(0).Columns.Add("Height", GetType(Integer))
        dsBoxes.Tables(0).Columns.Add("Tracking", GetType(String))
        dsBoxes.Tables(0).Columns.Add("Declared", GetType(Double))
        dsBoxes.Tables(0).Columns.Add("Reference", GetType(String))
        dsBoxes.Tables(0).Columns.Add("Cost", GetType(Double))
        dsBoxes.Tables(0).Columns.Add("ItmCode", GetType(String))
        gBoxes.DataSource = dsBoxes.Tables(0)
        gBoxes.DataBind()
        tDate.Value = DateAdd(DateInterval.Day, -1, Today)
        If Weekday(tDate.Value) = 1 Then tDate.Value = DateAdd(DateInterval.Day, -2, tDate.Value)
        If Weekday(tDate.Value) = 7 Then tDate.Value = DateAdd(DateInterval.Day, -1, tDate.Value)
        ShipPrinterFedEx = GetSetting("Jcom", "Shipping", "PrinterFedEx", "\\fedex\eltron")

        If UserGroup = "Admins" Then
            cbNoEmail.Visible = True
        End If
    End Sub
    Public Overrides Sub Add_After()
        Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        tDate.Value = DateAdd(DateInterval.Day, -1, Today)
        If Weekday(tDate.Value) = 1 Then tDate.Value = DateAdd(DateInterval.Day, -2, tDate.Value)
        If Weekday(tDate.Value) = 7 Then tDate.Value = DateAdd(DateInterval.Day, -1, tDate.Value)
        KeyValue1 = -1
        tOrd.Text = onOrd
        tVia.Text = onShip
        tRev.Text = "0"
        tNum.Text = onTrack
        tCreated.Text = CStr(Now)
        If IsDate(onDate) Then tDate.Value = onDate
        oNoStatus.Checked = False
    End Sub

    Private Sub tOrd_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tOrd.ValueChanged

    End Sub

    Private Sub tOrd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tOrd.LostFocus
    End Sub

    Public Overrides Sub Find()
        Try
            ClearFields(Me.Controls, False)
            dsOrds.Clear()
            dsShip.Clear()
            EditButtons("Blank")

            Dim fm As New fmFind
            Dim flds As jFld
            fm.frm = Me
            fm.Joinx = "left outer join ship_itm on ship_itm_ship_serial = ship_serial"

            fm.Sort = "ship_serial desc"

            fm.flds = New Collection

            flds = New jFld
            flds.Field = "ship_serial"
            flds.FieldName = "Shipment Number"
            flds.FieldType = "Numeric"
            flds.Searchable = False
            fm.flds.Add(flds)

            flds = New jFld
            flds.Field = "ship_ord_serial"
            flds.FieldName = "Order"
            flds.FieldType = "Numeric"
            flds.Searchable = True
            fm.flds.Add(flds)

            flds = New jFld
            flds.Field = "ship_date"
            flds.FieldName = "Ship Date"
            flds.FieldType = "Date"
            flds.Searchable = True
            fm.flds.Add(flds)

            flds = New jFld
            flds.Field = "ship_track"
            flds.FieldName = "Tracking #"
            flds.FieldType = "String"
            flds.Searchable = True
            fm.flds.Add(flds)

            fm.ShowDialog()
            LoadPage()
            'LoadGrid(Grid1, daOrds, dsOrds, "select ord_gen_serial,ord_gen_ord_serial,ord_gen_total,ord_gen_balance,pay_itm_amt from pay_itm,ord_gen where pay_itm_ord_gen_serial=ord_gen_serial and pay_itm_serial=" + KeyValue1, "ord_file")
            'LoadGrid(Grid1, daOrds, dsOrds, "select ord_gen_serial,ord_gen_ord_serial,ord_for,ord_ship_name,ord_gen_total,ord_gen_balance,pay_itm_amt as Amount from pay_itm,ord_file,ord_gen where pay_itm_ord_gen_serial=ord_gen_serial and ord_gen_ord_serial=ord_serial and pay_itm_pay_serial=" + KeyValue1, "ord_file")
            'LoadGrid(Grid2, daItemProdMar, dsItemProdMar, "select * from cust_prod_mar where cust_prod_mar_cust_serial='" + KeyValue1 + "'", "parts")
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Sub LoadPage()
        If KeyValue1 = "" Then Exit Sub

        tID.Text = KeyValue1
        Dim cmd As New SqlCommand("select top 1 ship_ord_serial from ship_file where ship_serial=" + KeyValue1, cnn)
        cnn.Open()
        tOrd.Text = CStr(cmd.ExecuteScalar)
        cnn.Close()

        LoadRevs()
        LoadFields(Me)
        FillGrid(tOrd.Text)
        EditButtons("Idle")

    End Sub

    Public Overrides Sub Save_After()
        Dim x As Long
        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow

        Try
            If cnn.State = ConnectionState.Closed Then cnn.Open()
            tID.Text = KeyValue1
            If gBoxes.Rows.Count > 0 Then
            Else
                For x = 0 To dsShip.Tables("ship_itm").Rows.Count - 1
                    If dsShip.Tables("ship_itm").Rows(x).RowState <> DataRowState.Deleted Then
                        dsShip.Tables("ship_itm").Rows(x).Item("ship_itm_ship_serial") = CLng(KeyValue1)
                    End If
                Next

                BindingContext(dsShip).EndCurrentEdit()
                daShip.Update(dsShip, "ship_itm")

                Do While cnn.State = ConnectionState.Executing

                Loop
            End If

            cmd.Connection = cnn
            cmd.CommandText = "insert into ship_stat (ship_ship_serial,ship_ord_stat,ship_date,ship_user,ship_ord) values (" + KeyValue1 + ",'" + onStat + "','" + CStr(Now) + "','" + User + "','" + tOrd.Text + "-" + tRev.Text + "-" + tType.Text + "')"
            cmd.ExecuteNonQuery()
            SetShipDate(tOrd.Text, tRev.Text, tType.Text, "Ship Save")
            SetDiagnostic("Save")


            'FedEx Shipping Routine
            'cmd.CommandText = "insert into ship_fedex_track (ship_fedex_track_ship_serial,ship_fedex_track,ship_fedex_track_user,ship_fedex_track_date) values (" + CStr(KeyValue1) + ",'" + tOut.Text + "','" + User + "','" + CStr(Now) + "')"
            'cmd.ExecuteNonQuery()

            If gBoxes.Rows.Count > 0 Then
                Dim row As Infragistics.Win.UltraWinGrid.UltraGridRow
                Dim cnt As Integer = 1
                Dim onMinSerial As Long = 0
                Dim Ref As String
                For Each row In gBoxes.Rows
                    If nz(row.Cells("reference").Value) = "" Then
                        Ref = Me.tFedExRef.Text
                    Else
                        Ref = row.Cells("reference").Value
                    End If
                    If cnt <> 1 Then
                        cmd.CommandText = "insert into ship_file (ship_via,ship_date,ship_track,ship_weight,ship_boxes,ship_cost,ship_notes,ship_ord_serial,ship_ord_rev,ship_ord_type,update_by,last_update,ship_note,ship_created,ship_vendornet,ship_vendornet_date,ship_no_status_change,ship_live_via) select ship_via,ship_date,ship_track,ship_weight,ship_boxes,ship_cost,ship_notes,ship_ord_serial,ship_ord_rev,ship_ord_type,update_by,last_update,ship_note,ship_created,ship_vendornet,ship_vendornet_date,ship_no_status_change,ship_live_via from ship_file where ship_serial=" + tID.Text
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "select @@IDENTITY"
                        x = cmd.ExecuteScalar
                        cmd.CommandText = "update ship_file set ship_track='" + row.Cells("tracking").Value + "',ship_weight=" + CStr(row.Cells("weight").Value) + ", ship_declared=" + CStr(nz(row.Cells("declared").Value, 0)) + ", ship_cost=" + CStr(nz(row.Cells("cost").Value, 0)) + " where ship_serial=" + CStr(x)
                        cmd.ExecuteNonQuery()
                        'cmd.CommandText = "insert into ship_itm (ship_itm_ship_serial,ship_itm_ord_serial,ship_itm_ord_rev,ship_itm_ord_itm_serial,ship_itm_qty,ship_itm_code,ship_itm_desc) select " + CStr(x) + " as ship_itm_ship_serial,ship_itm_ord_serial,ship_itm_ord_rev,ship_itm_ord_itm_serial,1 as ship_itm_qty,ship_itm_code,ship_itm_desc from ship_itm where ship_itm_ship_serial=" + tID.Text + " and ship_itm_code='" + row.Cells("itmcode").Value + "'"
                        cmd.CommandText = "insert into ship_itm (ship_itm_ship_serial,ship_itm_ord_serial,ship_itm_ord_rev,ship_itm_ord_itm_serial,ship_itm_qty,ship_itm_code,ship_itm_desc)values (" + CStr(x) + "," + Me.tOrd.Text + "," + Me.tRev.Text + ",0,1,'','" + Ref + "')"
                        cmd.ExecuteNonQuery()
                    Else
                        'cmd.CommandText = "select min(ship_itm_serial) from ship_itm where ship_itm_ship_serial=" + tID.Text
                        'onMinSerial = cmd.ExecuteScalar
                        cmd.CommandText = "insert into ship_itm (ship_itm_ship_serial,ship_itm_ord_serial,ship_itm_ord_rev,ship_itm_ord_itm_serial,ship_itm_qty,ship_itm_code,ship_itm_desc)values (" + CStr(KeyValue1) + "," + Me.tOrd.Text + "," + Me.tRev.Text + ",0,1,'','" + Ref + "')"
                        cmd.ExecuteNonQuery()
                    End If
                    cnt += 1
                Next
                'cmd.CommandText = "delete from ship_itm where ship_itm_ship_serial=" + tID.Text + " and ship_itm_serial<>" + CStr(onMinSerial)
                'cmd.ExecuteNonQuery()
                'cmd.CommandText = "update ship_itm set ship_itm_qty=1 where ship_itm_serial=" + CStr(onMinSerial)
                'cmd.ExecuteScalar()
            End If

            CheckReferral(CLng(tOrd.Text), CInt(tRev.Text), tType.Text)

            cmd.CommandText = "select * from ship_itm where ship_itm_ship_serial=" + KeyValue1
            da.Fill(ds)
            For Each dr In ds.Tables(0).Rows
                cmd.CommandText = "update ord_itm set ord_itm_shipped=(select sum(ship_itm_qty) from ship_itm where ship_itm_ord_itm_serial=" + CStr(dr("ship_itm_ord_itm_serial")) + ") where ord_itm_serial=" + CStr(dr("ship_itm_ord_itm_serial"))
                cmd.ExecuteNonQuery()
            Next

            SaveSetting("Jcom", "Settings", "ShipVia", nz(tVia.Value))
            If Me.CloseOnSave = True Then
                If cnn.State <> ConnectionState.Closed Then cnn.Close()
                Me.Close()
            End If
        Catch
            DoError(Err, Me)
        Finally
            If cnn.State <> ConnectionState.Closed Then cnn.Close()
            pFedEx.Top = 128
            pFedEx.Visible = False
            dsBoxes.Clear()
        End Try
    End Sub
    Private Sub SetDiagnostic(ByVal Action As String)
        Dim cmd As New SqlCommand("", cnn)
        Dim onSerial As Long

        'cnn.Open()
        Select Case Action
            Case "Save"
                cmd.CommandText = "select diag_serial from diag_file where diag_ord_serial=" + tOrd.Text + " and diag_rev=" + tRev.Text + " and diag_type='" + tType.Text + "' and diag_status='NOTSENT'"
                onSerial = nz(cmd.ExecuteScalar, 0)
                If onSerial > 0 Then
                    cmd.CommandText = "update diag_file set diag_status='TOSEND' where diag_serial=" + CStr(onSerial)
                    cmd.ExecuteNonQuery()
                End If
            Case "Delete"
                cmd.CommandText = "update diag_file set diag_status='NOTSENT' where diag_ord_serial=" + tOrd.Text + " and diag_rev=" + tRev.Text + " and diag_type='" + tType.Text + "' and diag_status='TOSEND'"
                cmd.ExecuteNonQuery()
        End Select
        'cnn.Close()
    End Sub

    Private Sub SetShipDate(ByVal Ord As String, ByVal Rev As String, ByVal Typex As String, ByVal Source As String)
        Try
            Dim cmd As New SqlCommand("", cnn)
            Dim ShipDate, StageDate, AcctDate, onAcctDate As Date
            Dim Status As String = "NEW"
            Dim StageFlag As String
            Dim ISR As String
            Dim dr As DataRow
            Dim onStatus, onMgr As String
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            Dim dr2 As DataRow

            cmd.CommandText = "select ord_gen_status,ord_gen_staged,ord_gen_staged_date,ord_gen_ship_date from ord_gen where ord_gen_ord_serial=" + Ord + " and ord_gen_rev=" + Rev + " and ord_gen_type='" + Typex + "'"
            da.Fill(dt)
            For Each dr In dt.Rows
                onStatus = nz(dr("ord_gen_status"), "")
                If nz(dr("ord_gen_staged"), False) = True Then
                    onAcctDate = nz(dr("ord_gen_staged_date"), CDate("1/1/1900"))
                Else
                    onAcctDate = nz(dr("ord_gen_ship_date"), CDate("1/1/1900"))
                End If
            Next

            cmd.CommandText = "select min(ship_date) as ship_date from ship_file where ship_ord_serial=" + Ord + " and ship_ord_rev=" + Rev + " and ship_ord_type='" + Typex + "' and ship_via<>'STAGED' and ship_no_status_change<>1"
            ShipDate = nz(cmd.ExecuteScalar, CDate("1/1/1900"))
            If ShipDate <> CDate("1/1/1900") Then Status = "SHIPPED"

            cmd.CommandText = "select min(ship_date) as ship_date from ship_file where ship_ord_serial=" + Ord + " and ship_ord_rev=" + Rev + " and ship_ord_type='" + Typex + "' and ship_via='STAGED' and ship_no_status_change<>1"
            StageDate = nz(cmd.ExecuteScalar, CDate("1/1/1900"))
            If StageDate = CDate("1/1/1900") Then
                StageFlag = "0"
            Else
                If Status <> "SHIPPED" Then Status = "STAGED"
                StageFlag = "1"
            End If
            If StageFlag = "1" Then
                AcctDate = StageDate
            Else
                AcctDate = ShipDate
            End If

            If AcctDate <= AcctClosed And DateDiff(DateInterval.Month, AcctDate, onAcctDate) <> 0 And AcctDate <> CDate("1/1/1900") Then
                SendMail("jonj@jcom.cc", "tlarkin@winecellarinnovations.com", "Ship/Stage Date Error", "Order " + CStr(Ord) + " Rev " + CStr(Rev) + " cannot change ship/stage date to " + CStr(AcctDate) + ".  " + User + " on " + CStr(Now))
                MsgBox("Ship/Stage date and status could not be set prior to the accounting closed date.  Please report this to Todd.", MsgBoxStyle.Critical, "Ship/Stage Error")
                Exit Sub
            End If

            cmd.CommandText = "update ord_gen set ord_gen_ship_date='" + CStr(ShipDate) + "',ord_gen_staged_date='" + CStr(StageDate) + "',ord_gen_staged=" + StageFlag + " where ord_gen_type='" + Typex + "' and ord_gen_ord_serial=" + Ord + " and ord_gen_rev=" + Rev
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update ord_gen set ord_gen_status='" + Status + "' where ord_gen_type='" + Typex + "' and ord_gen_ord_serial=" + Ord + " and ord_gen_rev=" + Rev + " and ord_gen_status<>'CANCELED'"
            cmd.ExecuteNonQuery()

            'Check for Email List
            Dim onCust, onName As String
            Dim onCustSerial As Long
            Dim HasEmails As Boolean = False
            Dim eMail As String
            Dim eMails As New ArrayList
            cmd.CommandText = "select ord_serial,ord_gen_from_rev,ord_gen_rev,ord_gen_inside,ord_gen_cust_po, ord_for, ord_sold_cust_id, ord_email_shipment, ord_sold_email, ord_sold_name, cust_serial, cust_email_shipment, cust_email_shipments_to from ord_file left outer join cust_file on ord_sold_cust_id=cust_id,ord_gen where ord_serial=ord_gen_ord_serial and ord_gen_ord_serial=" + CStr(Ord) + " and ord_gen_rev=" + CStr(Rev) + " and ord_gen_type='O'"
            dt = New DataTable
            da.Fill(dt)
            For Each dr In dt.Rows
                onCust = nz(dr("ord_sold_cust_id"))
                onCustSerial = nz(dr("cust_serial"), 0)
                onName = nz(dr("ord_sold_name"))
                If onCust = "" Then
                    If dr("ord_email_shipment") = True Then
                        For Each eMail In Split(nz(dr("ord_sold_email")), ";")
                            If eMails.Contains(eMail) = False And eMail <> "" Then eMails.Add(eMail)
                        Next
                    End If
                    cmd.CommandText = "select ord_gen_ship_email from ord_gen where ord_gen_ord_serial=" + CStr(Ord) + " and ord_gen_rev=" + CStr(Rev) + " and ord_gen_type='O' and ord_gen_ship_notify=1"
                    da.Fill(dt2)
                    For Each dr2 In dt2.Rows
                        For Each eMail In Split(nz(dr2("ord_gen_ship_email")), ";")
                            If eMails.Contains(eMail) = False And eMail <> "" Then eMails.Add(eMail)
                        Next
                    Next
                Else
                    If nz(dr("cust_email_shipment"), False) = True Then
                        For Each eMail In Split(nz(dr("cust_email_shipments_to")), ";")
                            If eMails.Contains(eMail) = False And eMail <> "" Then eMails.Add(eMail)
                        Next
                    End If
                    cmd.CommandText = "select cust_cont_email from cust_cont where cust_cont_cust_serial=" + CStr(onCustSerial) + " and cust_cont_name='" + onName + "' and cust_cont_email_shipment=1"
                    dt2 = New DataTable
                    da.Fill(dt2)
                    For Each dr2 In dt2.Rows
                        For Each eMail In Split(nz(dr2("cust_cont_email")), ";")
                            If eMails.Contains(eMail) = False And eMail <> "" Then eMails.Add(eMail)
                        Next
                    Next
                End If

                If eMails.Count > 0 Then HasEmails = True
                eMails = Nothing
            Next
            'End Check for Emails


            cmd.CommandText = "select ord_gen_inside,ord_gen_total,ord_gen_from_rev,rep_manager from ord_gen left outer join rep_file on ord_gen_inside=rep_code where ord_gen_ord_serial=" + CStr(Ord) + " and ord_gen_rev=" + CStr(Rev) + " and ord_gen_type='O' and ord_gen_status='SHIPPED'"
            dt2 = New DataTable
            da.Fill(dt2)
            Dim ShipNote As String
            For Each dr2 In dt2.Rows
                If Source = "Ship Delete" Then
                    ShipNote = "Order " + CStr(Ord) + "-" + CStr(dr2("ord_gen_from_rev")) + "-" + CStr(Rev) + " for " + UCase(lCust.Text) + " has been deleted on " + CStr(Now) + " by " + User
                Else
                    ShipNote = "Order " + CStr(Ord) + "-" + CStr(dr2("ord_gen_from_rev")) + "-" + CStr(Rev) + " for " + UCase(lCust.Text) + " has shipped on " + CStr(Now) + " for " + FormatCurrency(dr2("ord_gen_total"))
                End If
                If nz(dr2("ord_gen_inside")) <> "MELISSAB" Then
                    If HasEmails Then AddToDo("SHIP", nz(dr2("ord_gen_inside")), ShipNote, Ord, Rev, "O", "", CStr(Ord) + "-" + CStr(dr2("ord_gen_from_rev")) + "-" + CStr(Rev), "Order", Source)
                    If nz(dr2("rep_manager")) <> "" Then AddToDo("SHIP", dr2("rep_manager"), ShipNote, Ord, Rev, "O", "", CStr(Ord) + "-" + CStr(dr2("ord_gen_from_rev")) + "-" + CStr(Rev), "Order", Source)
                End If
    Next
            If onStatus = "SHIPPED" And Status <> "SHIPPED" Then
                cmd.CommandText = "select ord_gen_inside,ord_gen_total,ord_gen_from_rev,rep_manager from ord_gen left outer join rep_file on ord_gen_inside=rep_code where ord_gen_ord_serial=" + CStr(Ord) + " and ord_gen_rev=" + CStr(Rev) + " and ord_gen_type='O'"
                dt2 = New DataTable
                da.Fill(dt2)
                ShipNote = "SHIPPED Status Changed to " + Status + " by " + User + " on " + CStr(Now) + " on order " + Ord + " rev " + Rev
                If dt2.Rows.Count > 0 Then
                    dr2 = dt2.Rows(0)
                    If nz(dr2("ord_gen_inside")) <> "MELISSAB" Then
                        AddToDo("SHIP", nz(dr2("ord_gen_inside")), ShipNote, Ord, Rev, "O", "", CStr(Ord) + "-" + CStr(dr2("ord_gen_from_rev")) + "-" + CStr(Rev), "Order", Source)
                    End If
                End If

                SendMail("trishas@winecellarinnovations.com;bambi@winecellarinnovations.com", "jcom@winecellarinnovations.com", "SHIPPED Status Changed", ShipNote)
            End If

            'Testing shipment status after all is saved.
            cmd.CommandText = "select ord_gen_status from ord_gen where ord_gen_ord_serial=" + tOrd.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='" + tType.Text + "'"
            onStat = nz(cmd.ExecuteScalar, "Not Found")
            cmd.CommandText = "insert into ship_stat (ship_ship_serial,ship_ord_stat,ship_date,ship_user,ship_ord) values (" + KeyValue1 + ",'" + onStat + "','" + CStr(Now) + "','" + User + "','" + tOrd.Text + "-" + tRev.Text + "-" + tType.Text + "')"
            cmd.ExecuteNonQuery()
            StatusCheck(tOrd.Text, tType.Text, tRev.Text, Status, Source)
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Public Overrides Sub Save_Before()
        Dim cmd As New SqlCommand("", cnn)

        If InStr(lStatus.Text, "SHIPPED") > 0 And tVia.Text = "STAGED" Then
            MsgBox("You may not STAGE a SHIPPED order", MsgBoxStyle.Critical, "Can Not Stage")
            tVia.Text = ""
            tVia.Focus()
            SaveCanceled = True
            Exit Sub
        End If
        If tDate.Value < AcctClosed And ((EditMode = "Edit" And onShipDate <> tDate.Text) Or (EditMode = "Add")) Then
            MsgBox("You may not save a shipping with a date prior to the Accounting Closed date", MsgBoxStyle.Critical, "Accounting Closed")
            SaveCanceled = True
            Exit Sub
        End If
        If oNoStatus.Checked Then
            If MsgBox("Are you sure you DO NOT want to change the Order Status with this shipment?", MsgBoxStyle.YesNo, "No Status Change?") = MsgBoxResult.No Then Exit Sub
            If MsgBox("Are you really, really sure? This should only be used for third party shipments not sent from WCI.", MsgBoxStyle.YesNo, "No Status Change?") = MsgBoxResult.No Then Exit Sub
        End If
        If tOrd.Text = "" Or tRev.Text = "" Or tVia.Text = "" Or tType.Text = "" Then
            MsgBox("Must have an Order, Rev, Type and Ship Via", MsgBoxStyle.Information, "???")
            SaveCanceled = True
            Exit Sub
        End If
        If tRev.IsItemInList(tRev.Text) = False Then
            MsgBox("Rev does not exist on this order", MsgBoxStyle.Exclamation, "Rev?")
            SaveCanceled = True
            Exit Sub
        End If
        If Grid2.Rows.Count <= 0 And tVia.Text <> "STAGED" Then
            MsgBox("You must select at least one item to ship", MsgBoxStyle.Critical, "Items?")
            SaveCanceled = True
            Exit Sub
        End If
        cnn.Open()
        If tVia.Text <> "STAGED" Then
            cmd.CommandText = "select cust_id,ord_sold_name,ord_gen_status,ord_gen_from_rev,ord_gen_shiptotype,ord_gen_ship_hold from (ord_file left outer join cust_file on ord_sold_cust_serial=cust_serial) left outer join ord_gen on ord_serial=ord_gen_ord_serial where ord_serial=" + tOrd.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='" + tType.Text + "'"
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If nz(dr("ord_gen_ship_hold"), False) = True Then
                    dr.Close()
                    MsgBox("This order is on SHIPPING HOLD and can not ship.", MsgBoxStyle.Critical, "Shipping Hold?")
                    cnn.Close()
                    'QuietMode = True
                    'Me.Cancel()
                    'QuietMode = False
                    SaveCanceled = True
                    Exit Sub
                Else
                    dr.Close()
                End If
            End If
        End If

        cmd.CommandText = "select ord_gen_status from ord_gen where ord_gen_ord_serial=" + tOrd.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='" + tType.Text + "'"
        onStat = nz(cmd.ExecuteScalar, "Not Found")
        If UCase(onStat) = "CANCELED" Then
            MsgBox("Can not add shipments to a CANCELED Order", MsgBoxStyle.Exclamation, "Canceled?")
            SaveCanceled = True
            cnn.Close()
            Exit Sub
        End If
        cnn.Close()

        'tCreated.Text = CStr(Now)
        'Do not check per Todd 2/7/2006
        'If tVia.Text <> "STAGED" And dsShip.Tables(0).Rows.Count = 0 Then
        'MsgBox("Must select at least one item to ship", MsgBoxStyle.Information, "Items?")
        'SaveCanceled = True
        'Exit Sub
        'End If
        Grid2.UpdateData()
        Grid2.Update()

        If tNum.Text = "" And gBoxes.Rows.Count > 0 Then
            'If ShipPrinterFedEx = "" Then
            '    MsgBox("You must first setup a FedEx printer.", MsgBoxStyle.Exclamation, "Printer?")
            '    SaveCanceled = True
            '    Exit Sub
            'End If

            If GetSetting("Jcom", "Printing", "ShippingLabel", "") = "" Then
                MsgBox("Please choose a Shipping Label Printer first under Shipping / Setup Label Printer / Shipping Label Printer from the menu", MsgBoxStyle.Critical, "Printer?")
                SaveCanceled = True
                Exit Sub
            End If
            gBoxes.UpdateData()
            gBoxes.Update()
            Dim row As Infragistics.Win.UltraWinGrid.UltraGridRow
            For Each row In gBoxes.Rows
                If nz(row.Cells("Declared").Value, 0) >= 500 Then
                    chFedExSign.Checked = True
                End If
            Next
            If SubmitFedEx2() = False Then
                SaveCanceled = True
                Exit Sub
            End If
            tShipLiveVia.Text = "FEDEX"
        End If
    End Sub

    Public Overrides Sub Delete()
        If Me.SecLevel < jDelete Then
            MsgBox("You do not have DELETE access to this screen.", MsgBoxStyle.Exclamation, "Access?")
            Exit Sub
        End If
        Dim onDate As Date
        onDate = DateAdd(DateInterval.Day, -1, Today)
        If Weekday(onDate) = 1 Then onDate = DateAdd(DateInterval.Day, -2, onDate)
        If UserGroup = "Admins" Then
            If CDate(tCreated.Text) < CDate(AcctClosed) Then
                MsgBox("You can not delete an shipment that was created before " + CStr(CDate(AcctClosed)) + " (Accounting Closed Date).", MsgBoxStyle.Exclamation, "Delete?")
                Exit Sub
            End If
        Else
            If CDate(tCreated.Text) < CDate(onDate) Then
                MsgBox("You can not delete an shipment that was created before " + CStr(CDate(onDate)) + ".", MsgBoxStyle.Exclamation, "Delete?")
                Exit Sub
            End If
        End If

        If MsgBox("This will recalculate the shipping/staged date for this order (which could change report values).  Do you want to proceed?", MsgBoxStyle.YesNo, "Proceed?") = MsgBoxResult.Yes Then
            Dim x As Integer
            Dim cmd As New SqlCommand
            Dim Trans As SqlTransaction
            Dim dr As SqlDataReader
            Dim onShipDate As Date = CDate("1/1/1900")
            Dim onStageDate As Date = CDate("1/1/1900")
            Dim onVia As String
            Dim onOrd, onRev, onType As String

            Try
                If tShipLiveVia.Text = "FEDEX" Then
                    If FedExDelete() = False Then
                        If MsgBox("Could not delete FedEx shipment. Do you want to delete this shipper anyway?", MsgBoxStyle.YesNo, "Delete?") = MsgBoxResult.No Then Exit Sub
                    End If
                End If

                cmd.Connection = cnn

                cnn.Open()

                onOrd = tOrd.Text
                onRev = tRev.Text
                onType = tType.Text

                cmd.CommandText = "delete from ship_itm where ship_itm_ship_serial=" + tID.Text
                cmd.ExecuteNonQuery()
                cmd.CommandText = "delete from ship_file where ship_serial=" + tID.Text
                cmd.ExecuteNonQuery()
                'Trans.Commit()
                SetShipDate(onOrd, onRev, onType, "Ship Delete")
                SetDiagnostic("Delete")
                dsOrds.Clear()
                dsShip.Clear()
            Catch
                Trans.Rollback()
                DoError(Err, MainForm)
            Finally
                If cnn.State <> ConnectionState.Closed Then cnn.Close()
            End Try
        End If
    End Sub

    Public Overrides Sub Edit_After()
        Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        onShipDate = tDate.Text
    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Public Sub tOrd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tOrd.Leave
        Try
            If tOrd.Text = "" Then Exit Sub
            If tOrd.Text + "-" + tRev.Text + "-" + tType.Text = onOrdField Then Exit Sub

            '**** Tax Certificates
            'Dim cmd As New SqlCommand("select ord_tax_exempt from ord_file where ord_serial=" + tOrd.Text, cnn)

            'cnn.Open()
            'If nz(cmd.ExecuteScalar, False) = True Then
            '    cmd.CommandText = "select count(tax_cert_serial) from ord_file,tax_cert where ord_sold_cust_id=tax_cert_cust_id and ord_tax_exempt_no=tax_cert_no and ord_serial=" + tOrd.Text + " AND ((ord_file.ord_sold_cust_id = '' AND ord_file.ord_ship_state = tax_cert.tax_cert_state) OR (ord_file.ord_sold_cust_id <> ''))"
            '    If cmd.ExecuteScalar <= 0 Then
            '        cnn.Close()
            '        MsgBox("Order " + tOrd.Text + " must have a valid tax exempt number before you can ship or stage.", MsgBoxStyle.Critical, "Tax Exempt?")
            '        tOrd.Text = ""
            '        tOrd.Focus()
            '        Exit Sub
            '    End If
            'End If
            'cnn.Close()
            LoadRevs()
            GetItems()
        Catch
            DoError(Err, Me)
            tOrd.Text = ""
            tOrd.Focus()
        End Try

    End Sub
    Public Sub LoadRevs()
        Dim cmd As New SqlCommand

        dsRev.Clear()
        If IsNumeric(tOrd.Text) = False Then Exit Sub
        cmd.CommandText = "select distinct ord_gen_rev as Rev from ord_gen where ord_gen_ord_serial=" + tOrd.Text + " and ord_gen_type<>'Q' order by ord_gen_rev"
        cmd.Connection = cnn
        daRev.SelectCommand = cmd
        cnn.Open()
        daRev.Fill(dsRev, "rev")
        tRev.DataSource = dsRev
        tRev.ValueMember = "Rev"
        tRev.DisplayMember = "Rev"
        tRev.DataBind()
        If dsRev.Tables(0).Rows.Count > 0 Then
            tRev.Text = CStr(dsRev.Tables(0).Rows(0).Item(0))
        Else
            tRev.Text = "0"
        End If
        cnn.Close()
        LoadTypes()
    End Sub
    Public Sub LoadTypes()
        Dim cmd As New SqlCommand

        dsType.Clear()
        If IsNumeric(tOrd.Text) = False Then Exit Sub
        cmd.CommandText = "select distinct ord_gen_type as ord_gen_type from ord_gen where ord_gen_ord_serial=" + tOrd.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type<>'Q' order by ord_gen_type"
        cmd.Connection = cnn
        daType.SelectCommand = cmd
        cnn.Open()
        daType.Fill(dsType, "type")
        tType.DataSource = dsType
        tType.ValueMember = "ord_gen_type"
        tType.DisplayMember = "ord_gen_type"
        tType.DataBind()
        If dsType.Tables(0).Rows.Count > 0 Then
            tType.Text = CStr(dsType.Tables(0).Rows(0).Item(0))
        Else
            tType.Text = "O"
        End If
        cnn.Close()
    End Sub
    Public Sub GetItems()
        Try
            If tOrd.Text = "" Then Exit Sub
            If IsNumeric(tOrd.Text) = False Then
                MsgBox("Must be a NUMBER.", MsgBoxStyle.Exclamation, "Number?")
                Exit Sub
            End If
            Dim cmd As New SqlCommand("select cust_id,ord_sold_name,ord_gen_status,ord_gen_from_rev,ord_gen_shiptotype,ord_gen_ship_hold from (ord_file left outer join cust_file on ord_sold_cust_serial=cust_serial) left outer join ord_gen on ord_serial=ord_gen_ord_serial where ord_serial=" + tOrd.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='" + tType.Text + "'", cnn)
            Dim dr As SqlDataReader
            cnn.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If nz(dr("ord_gen_ship_hold"), False) = True Then
                    If MsgBox("This order is on SHIPPING HOLD and can not ship.  The only thing you can do is STAGE this order.  Do you want to continue?", MsgBoxStyle.YesNo, "Shipping Hold?") = MsgBoxResult.No Then
                        dr.Close()
                        cnn.Close()
                        QuietMode = True
                        Me.Cancel()
                        QuietMode = False
                        Exit Sub
                    End If
                End If
                lCust.Text = nz(dr("ord_sold_name"))
                lStatus.Text = "Order Status: " + nz(dr("ord_gen_status"))
                If nz(dr("ord_gen_shiptotype")) = "R" Then
                    chFedExResidential.Checked = True
                End If
                tVia.Value = "STAGED"
            Else
                MsgBox("Order Not Found.", MsgBoxStyle.Exclamation, "Not Found")
                dr.Close()
                cnn.Close()
                tOrd.Focus()
                Exit Sub
            End If
            dr.Close()
            cnn.Close()
            FillGrid(tOrd.Text)
        Catch
            DoError(Err, MainForm)
        Finally
            If cnn.State <> ConnectionState.Closed Then cnn.Close()
        End Try

    End Sub
    Private Sub Grid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Click
    End Sub
    Private Sub PickRow(ByVal CurRow As Infragistics.Win.UltraWinGrid.UltraGridRow)
        If CurRow Is Nothing Then Exit Sub
        Dim tr As DataRow
        tr = dsShip.Tables("ship_itm").NewRow
        tr("ship_itm_ship_serial") = KeyValue1
        tr("ship_itm_ord_serial") = CurRow.Cells("ord_gen_ord_serial").Value
        tr("ship_itm_ord_rev") = CurRow.Cells("ord_gen_rev").Value
        tr("ship_itm_ord_itm_serial") = CurRow.Cells("ord_itm_serial").Value
        tr("ship_itm_code") = CurRow.Cells("ord_itm_item_code").Value
        tr("ship_itm_desc") = CurRow.Cells("ord_itm_desc").Value
        tr("ship_itm_qty") = CurRow.Cells("ord_itm_toship").Value
        tr("ord_itm_unt_sell") = CurRow.Cells("ord_itm_unt_sell").Value
        dsShip.Tables(0).Rows.Add(tr)
        'CurRow.Delete(False)
    End Sub
    Private Sub Grid1_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterRowActivate

    End Sub

    Public Overrides Sub Add_Before()
        dsShip.Clear()
        dsOrds.Clear()
        dsBoxes.Clear()
        onOrd = tOrd.Text
        onShip = tVia.Text
        tFedExComp.Text = ""
        tFedExContact.Text = ""
        tFedExAddr1.Text = ""
        tFedExAddr2.Text = ""
        tFedExCity.Text = ""
        tFedExState.Text = ""
        tFedExZip.Text = ""
        tFedExPhone.Text = ""
        tFedExCountry.Text = ""
        If tVia.Text = "FEDX" Then
            onTrack = ""
        Else
            onTrack = tNum.Text
        End If
        If IsDate(tDate.Text) Then onDate = tDate.Value
    End Sub

    Public Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        If Grid1.Rows Is Nothing Then Exit Sub
        Dim x As Integer
        For x = 0 To Grid1.Rows.Count - 1
            If Mid(Grid1.Rows(x).Cells("ord_itm_item_code").Value, 1, 5) <> "COMP-" Then
                PickRow(Grid1.Rows(x))
            End If
        Next
    End Sub

    Private Sub tOrd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tOrd.KeyUp
    End Sub

    Private Sub tOrd_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tOrd.Enter
        onOrdField = tOrd.Text + "-" + tRev.Text + "-" + tType.Text
    End Sub

    Private Sub tOrd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tOrd.GotFocus
        Try
            tOrd.SelectionStart = 0
            tOrd.SelectionLength = 99
        Catch
        End Try

    End Sub

    Private Sub tOrd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tOrd.KeyPress
        If e.KeyChar = Chr(13) Then tOrd_Leave(sender, e)

    End Sub

    Public Overrides Sub Cancel_After()
        dsOrds.Clear()
        dsShip.Clear()
        If Me.CloseOnSave = True Then Me.Close()
    End Sub

    Private Sub Grid1_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles Grid1.AfterSelectChange
        PickRow(Grid1.ActiveRow)
    End Sub

    Private Sub tOrd_RightToLeftChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tOrd.RightToLeftChanged

    End Sub

    Private Sub tRev_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tRev_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        onOrdField = tOrd.Text + "-" + tRev.Text + "-" + tType.Text

    End Sub

    Private Sub tRev_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If tOrd.Text + "-" + tRev.Text + "-" + tType.Text = onOrdField Then Exit Sub
        GetItems()

    End Sub

    Private Sub tRev_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tRev.InitializeLayout

    End Sub

    Private Sub tRev_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tRev.Leave
        If tOrd.Text + "-" + tRev.Text + "-" + tType.Text = onOrdField Then Exit Sub
        LoadTypes()
        GetItems()

    End Sub

    Private Sub tNum_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNum.Enter
        tNum.SelectAll()
        pFedEx.Visible = False
    End Sub

    Private Sub tType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tType.Leave
        If tOrd.Text + "-" + tRev.Text + "-" + tType.Text = onOrdField Then Exit Sub
        GetItems()
    End Sub

    Private Sub tType_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tType.Enter
        onOrdField = tOrd.Text + "-" + tRev.Text + "-" + tType.Text
    End Sub

    Private Sub CheckShipVia()
        Select Case tVia.Text
            Case "FEDX"
                ShipViaFedEx()
                tNum.Enabled = False
                tWeight.Enabled = False
                tAuth.Enabled = False
                ShipType = "FedEx"
            Case Else
                pFedEx.Visible = False
                tNum.Enabled = True
                tWeight.Enabled = True
                tAuth.Enabled = True
                ShipType = "General"
        End Select
    End Sub
    Private Sub ShipViaFedEx()
        pFedEx.Top = 128
        pFedEx.Left = 0
        pFedEx.Visible = True
        tFedExComp.Text = ""
        tFedExContact.Text = ""
        tFedExAddr1.Text = ""
        tFedExAddr2.Text = ""
        tFedExCity.Text = ""
        tFedExState.Text = ""
        tFedExZip.Text = ""
        tFedExPhone.Text = ""
        tFedExCountry.Text = ""

        Dim cmd As New SqlCommand("select ord_gen_alt_ship from ord_gen where ord_gen_ord_serial=" + tOrd.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='" + tType.Text + "' and ord_gen_alt_ship=1", cnn)
        Dim dr As SqlDataReader
        cnn.Open()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Close()
            cmd.CommandText = "select * from ord_alt_ship where ord_alt_ship_ord_serial=" + tOrd.Text + " and ord_alt_ship_rev=" + tRev.Text + " and ord_alt_ship_type='" + tType.Text + "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                tFedExComp.Text = dr("ord_alt_ship_company")
                tFedExContact.Text = dr("ord_alt_ship_name")
                tFedExAddr1.Text = dr("ord_alt_ship_addr1")
                tFedExAddr2.Text = dr("ord_alt_ship_addr2")
                tFedExCity.Text = dr("ord_alt_ship_city")
                tFedExState.Text = dr("ord_alt_ship_state")
                tFedExZip.Text = dr("ord_alt_ship_zip")
                tFedExPhone.Text = MakeNumeric(dr("ord_alt_ship_phone1"))
                tFedExCountry.Text = IIf(dr("ord_alt_ship_country") = "USA", "US", dr("ord_alt_ship_country"))
            End If
        Else
            dr.Close()
            'cmd.CommandText = "select * from ord_file where ord_serial=" + tOrd.Text
            cmd.CommandText = "select * from ord_gen where ord_gen_ord_serial=" + tOrd.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='" + tType.Text + "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                tFedExComp.Text = dr("ord_gen_ship_company")
                tFedExContact.Text = dr("ord_gen_ship_name")
                tFedExAddr1.Text = dr("ord_gen_ship_addr1")
                tFedExAddr2.Text = dr("ord_gen_ship_addr2")
                tFedExCity.Text = dr("ord_gen_ship_city")
                tFedExState.Text = dr("ord_gen_ship_state")
                tFedExZip.Text = dr("ord_gen_ship_zip")
                tFedExPhone.Text = MakeNumeric(dr("ord_gen_ship_phone1"))
                tFedExCountry.Text = IIf(dr("ord_gen_ship_country") = "USA", "US", dr("ord_gen_ship_country"))
            End If
        End If
        dr.Close()
        cnn.Close()
    End Sub
    Private Sub tVia_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVia.ValueChanged
        'If Me.ActiveControl Is tVia Then CheckShipVia()
    End Sub

    Private Sub UltraLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraLabel1.Click

    End Sub

    Private Sub tVia_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tVia.InitializeLayout
        'e.Layout.Bands(0).Columns(0).Hidden = True
        'e.Layout.Bands(0).Columns(1).Header.Caption = ""
        e.Layout.Bands(0).Columns(1).Width = 250
    End Sub

    Private Sub tVia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVia.Enter
        'CheckShipVia()
    End Sub
    Private Sub tAuth_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAuth.Enter
        pFedEx.Visible = False

    End Sub
    Private Sub UltraTextEditor1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraTextEditor1.Enter
        pFedEx.Visible = False

    End Sub
    Private Function SubmitFedEx() As Boolean
        Exit Function
        Dim data As String = "0," + QT + "20" + QT
        Dim ct As Control
        Dim rt As String
        Dim cmd As New SqlCommand("", cnn)
        Dim FedExService As String

        SubmitFedEx = False

        Try
            cnn.Open()
            cmd.CommandText = "select ship_code_desc from ship_via where ship_via_code='" + tVia.Text + "' and ship_company='FedEx'"
            FedExService = nz(cmd.ExecuteScalar, "")
            cnn.Close()
            If FedExService = "" Then
                MsgBox(tVia.Text + " is not setup to ship by FedEx automation.  See the database manager.", MsgBoxStyle.Critical, tVia.Text + "?")
                Exit Function
            End If

            For Each ct In pFedEx.Controls
                If ct.Tag <> "" And ct.Name <> "gBoxes" Then
                    data += ct.Tag + "," + QT + Replace(ct.Text, "'", "''") + QT
                End If
            Next
            data += "498," + QT + "261146" + QT

            Select Case tFedExPackaging.Text
                Case "Customer Packaging"
                    data += "1273," + QT + "01" + QT
                Case "FedEx Pak"
                    data += "1273," + QT + "02" + QT
                Case "FedEx Box"
                    data += "1273," + QT + "03" + QT
                Case "FedEx Tube"
                    data += "1273," + QT + "04" + QT
                Case "FedEx Envelope"
                    data += "1273," + QT + "06" + QT
                Case Else
                    MsgBox("Undefined Packaging Type", MsgBoxStyle.Critical, "Packaging?")
                    Exit Function
            End Select

            Select Case FedExService
                Case "FedEx Priority Overnight"
                    data += "1274," + QT + "01" + QT
                Case "FedEx 2Day"
                    data += "1274," + QT + "03" + QT
                Case "FedEx Standard Overnight"
                    data += "1274," + QT + "05" + QT
                Case "FedEx 3Day Freight"
                    data += "1274," + QT + "83" + QT
                Case "FedEx Home Delivery"
                    data += "1274," + QT + "90" + QT
                Case "Home Delivery"
                    data += "1274," + QT + "90" + QT
                Case "Ground"
                    data += "1274," + QT + "92" + QT
                Case "International Priority"
                    data += "1274," + QT + "01" + QT
                Case Else
                    MsgBox("Undefined Service Type", MsgBoxStyle.Critical, "Service?")
                    Exit Function
            End Select

            Dim dr As DataRow
            Dim cnt As Integer = 1
            For Each dr In dsBoxes.Tables(0).Rows
                data += "1670-" + CStr(cnt) + "," + QT + CStr(Math.Round(dr("weight") * 100, 0)) + QT
                data += "57-" + CStr(cnt) + "," + QT + CStr(dr("height")) + QT
                data += "58-" + CStr(cnt) + "," + QT + CStr(dr("width")) + QT
                data += "59-" + CStr(cnt) + "," + QT + CStr(dr("length")) + QT
                data += "69-" + CStr(cnt) + "," + QT + CStr(Math.Round(nz(dr("declared"), 0) * 100, 0)) + QT
                If nz(dr("reference")) = "" Then
                    data += "25-" + CStr(cnt) + "," + QT + tFedExInvoice.Text + " " + dr("reference") + QT
                Else
                    data += "25-" + CStr(cnt) + "," + QT + tFedExInvoice.Text + " " + dr("reference") + QT
                End If
                If chFedExSign.Checked Then data += "2399-" + CStr(cnt) + "," + QT + "2" + QT
                cnt += 1
            Next

            data += "75," + QT + "LBS" + QT

            If tFedExPO.Text <> "" Then data += "3001," + QT + tFedExPO.Text + QT
            If tFedExPO.Text <> "" Then data += "3002," + QT + tFedExInvoice.Text + QT
            If tFedEx3rdParty.Text <> "" Then
                data += "23," + QT + "3" + QT
                data += "20," + QT + tFedEx3rdParty.Text + QT
            Else
                data += "23," + QT + "1" + QT
            End If
            If chFedExResidential.Checked Then data += "440," + QT + "Y" + QT
            If chFedExSat.Checked Then data += "1266," + QT + "Y" + QT
            If chFedExHold.Checked Then data += "1200," + QT + "Y" + QT

            data += "537," + QT + ShipPrinterFedEx + QT
            data += "187," + QT + "199" + QT
            data += "99," + QT + QT

            tOut.Text = data + vbCrLf + vbCrLf
            rt = ShipFedEx(data)
            If rt Is Nothing Then
                MsgBox("Could not communicate the the WCI FedEx server on 10.0.0.245", MsgBoxStyle.Critical, "Network Error")
                Exit Function
            End If
            tOut.Text += rt
            Me.tFedexReturnText.Text = rt

            Dim fe As New FedExData(rt)

            If fe.GetData("3") <> "" Then
                MsgBox("FedEx Error: " + fe.GetData("3"))
                Exit Function
            Else
                tNum.Text = fe.GetData("29")
            End If

            Dim row As Infragistics.Win.UltraWinGrid.UltraGridRow
            cnt = 1
            For Each row In gBoxes.Rows
                If cnt = 1 Then
                    row.Cells("Tracking").Value = fe.GetData("29")
                    If IsNumeric(fe.GetData("37")) Then row.Cells("cost").Value = Math.Round(CDbl(fe.GetData("37")) / gBoxes.Rows.Count, 2)
                    tNum.Text = row.Cells("Tracking").Value
                    tWeight.Text = row.Cells("Weight").Value
                    tCost.Value = IIf(IsNumeric(row.Cells("cost").Value), CDbl(row.Cells("cost").Value) / 100, 0)
                    tValue.Value = nz(row.Cells("declared").Value, 0)
                Else
                    row.Cells("Tracking").Value = fe.GetData("29-" + CStr(cnt))
                End If
                cnt += 1
            Next
            tAuth.Text = "1"

            SubmitFedEx = True
        Catch
            DoError(Err, MainForm)
        End Try

    End Function
    Private Function SubmitFedEx2() As Boolean
        Dim data As String = "0," + QT + "20" + QT
        Dim ct As Control
        Dim rt As String
        Dim cmd As New SqlCommand("", cnn)

        SubmitFedEx2 = False

        Try
            cnn.Open()
            cmd.CommandText = "select ship_code_desc from ship_via where ship_via_code='" + tVia.Text + "' and ship_company='FedEx'"
            FedExService = nz(cmd.ExecuteScalar, "")
            cnn.Close()
            If FedExService = "" Then
                MsgBox(tVia.Text + " is not setup to ship by FedEx automation.  See the database manager.", MsgBoxStyle.Critical, tVia.Text + "?")
                Exit Function
            End If

            Dim isCodShipment As Boolean = False
            Dim masterRequest As ProcessShipmentRequest
            Dim service As ShipService = New ShipService() ' Initialize the service
            Dim masterReply As ProcessShipmentReply
            Dim childRequest As ProcessShipmentRequest
            Dim childReply As ProcessShipmentReply

            Dim dr As DataRow
            Dim cnt As Integer = 1
            For Each dr In dsBoxes.Tables(0).Rows
                If nz(dr("reference")) = "" Then dr("reference") = tFedExRef.Text
                If cnt = 1 Then
                    masterRequest = CreateMasterShipmentRequest(isCodShipment, nz(dr("reference")))
                    SetIndividualPackageLineItems(masterRequest, Math.Round(dr("weight"), 0), CStr(cnt), CStr(dr("length")), CStr(dr("width")), CStr(dr("height")), isCodShipment, tFedExInvoice.Text + " " + dr("reference"), CType(nz(dr("declared"), 0), Decimal))

                    masterReply = service.processShipment(masterRequest)
                    If ((Not masterReply.HighestSeverity = NotificationSeverityType.ERROR) And (Not masterReply.HighestSeverity = NotificationSeverityType.FAILURE)) Then ' check if the call was successful
                        ShowShipmentLabel(masterReply, isCodShipment)
                    Else
                        For Each notification As Notification In masterReply.Notifications
                            MsgBox(notification.Message)
                        Next
                        SubmitFedEx2 = False
                        Exit Function
                    End If
                    dr("tracking") = masterReply.CompletedShipmentDetail.CompletedPackageDetails(0).TrackingIds(0).TrackingNumber
                    tNum.Text = masterReply.CompletedShipmentDetail.CompletedPackageDetails(0).TrackingIds(0).TrackingNumber
                    tWeight.Text = nz(dr("weight"), 0)
                    If Not masterReply.CompletedShipmentDetail.CompletedPackageDetails(0).PackageRating Is Nothing Then
                        tCost.Value = masterReply.CompletedShipmentDetail.CompletedPackageDetails(0).PackageRating.PackageRateDetails(0).NetCharge.Amount
                    End If
                    tValue.Value = nz(dr("declared"), 0)
                Else
                    If (Not masterReply.CompletedShipmentDetail.CompletedPackageDetails(0) Is Nothing) Then
                        childRequest = CreateChildShipmentRequest(masterRequest, masterReply, isCodShipment, nz(dr("reference")))
                        SetIndividualPackageLineItems(childRequest, Math.Round(dr("weight"), 0), CStr(cnt), CStr(dr("length")), CStr(dr("width")), CStr(dr("height")), isCodShipment, tFedExInvoice.Text + " " + dr("reference"), nz(dr("declared"), 0))
                        childReply = service.processShipment(childRequest)
                        If ((Not childReply.HighestSeverity = NotificationSeverityType.ERROR) And (Not childReply.HighestSeverity = NotificationSeverityType.FAILURE)) Then ' check if the call was successful
                            ShowShipmentLabel(childReply, isCodShipment)
                        Else
                            For Each notification As Notification In childReply.Notifications
                                MsgBox(notification.Message)
                            Next
                            SubmitFedEx2 = False
                            Exit Function
                        End If
                        dr("tracking") = childReply.CompletedShipmentDetail.CompletedPackageDetails(0).TrackingIds(0).TrackingNumber
                        If Not childReply.CompletedShipmentDetail.CompletedPackageDetails(0).PackageRating Is Nothing Then
                            dr("cost") = childReply.CompletedShipmentDetail.CompletedPackageDetails(0).PackageRating.PackageRateDetails(0).NetCharge.Amount
                        End If
                    End If
                End If
                cnt += 1
            Next

            SubmitFedEx2 = True
        Catch
            DoError(Err, MainForm)
        End Try

    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SubmitFedEx()
    End Sub


    Private Sub tWeight_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tWeight.Enter
        pFedEx.Visible = False
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        pFedEx.Visible = False
    End Sub

    Private Sub fmShipment_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then pFedEx.Visible = False
    End Sub

    Private Sub chFedExHold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFedExHold.CheckedChanged
        If chFedExHold.Checked And tFedExContact.Text = "" Then
            MsgBox("Must have a contact name before you click Hold At Terminal", MsgBoxStyle.Information, "Contact?")
            chFedExHold.Checked = False
            tFedExContact.Focus()
        End If
    End Sub

    Private Sub tFedExPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFedExPhone.TextChanged

    End Sub

    Private Sub tFedExPhone_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFedExPhone.Leave
        tFedExPhone.Text = MakeNumeric(tFedExPhone.Text)
    End Sub

    Private Sub tFedExCountry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFedExCountry.TextChanged

    End Sub

    Private Sub tFedExCountry_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFedExCountry.Leave
        If tFedExCountry.Text = "USA" Then tFedExCountry.Text = "US"
    End Sub

    Private Sub bFedExDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFedExDelete.Click
        If tNum.Text = "" Then
            MsgBox("You cannot delete unless a tracking number has been submitted.", MsgBoxStyle.Information, "Can't Delete.")
            Exit Sub
        Else
            bFedExDelete.Enabled = False
            If MsgBox("Are you sure you want to delete this shipment from FedEx?", MsgBoxStyle.YesNo, "Delete?") = MsgBoxResult.Yes Then
                If FedExDelete() = True Then MsgBox("Shipment has been deleted.", MsgBoxStyle.Information, "Deleted")
            End If
            bFedExDelete.Enabled = True
        End If
    End Sub
    Private Function FedExDelete() As Boolean
        Dim request As DeleteShipmentRequest = CreateDeleteShipmentRequest()
        Dim service As ShipService = New ShipService() ' Initialize the service
        '
        Try
            ' This is the call to the ship web service passing in a DeleteShipmentRequest and returning a ShipmentReply
            Dim reply As ShipmentReply = service.deleteShipment(request)
            If ((Not reply.HighestSeverity = NotificationSeverityType.ERROR) And (Not reply.HighestSeverity = NotificationSeverityType.FAILURE)) Then ' check if the call was successful
                'Console.WriteLine("This Shipment is Deleted Successfully")
                FedExDelete = True
            Else
                For Each notification As Notification In reply.Notifications
                    MsgBox(notification.Message)
                Next
                FedExDelete = False
            End If
        Catch e As SoapException
            MsgBox(e.Detail.InnerText)
            FedExDelete = False
        Catch e As Exception
            MsgBox(e.Message)
            FedExDelete = False
        End Try


        'Dim data As String = "0," + QT + "023" + QT + "29," + QT + tNum.Text + QT + "498," + QT + "261146" + QT + "99," + QT + QT
        'Dim rt As String = ShipFedEx(data)
        'Dim fe As New FedExData(rt)
        'If fe.GetData("3") <> "" Then
        '    MsgBox("FedEx Error: " + fe.GetData("3"), MsgBoxStyle.Critical, "Delete Error")
        '    FedExDelete = False
        '    Exit Function
        'Else
        '    tNum.Text = ""
        '    FedExDelete = True
        'End If
    End Function
    Function CreateDeleteShipmentRequest()
        ' Build a DeleteShipmentRequest
        Dim request As DeleteShipmentRequest = New DeleteShipmentRequest()
        Dim FedExService As String
        Dim cmd As New SqlCommand("", cnn)

        cnn.Open()
        cmd.CommandText = "select ship_code_desc from ship_via where ship_via_code='" + tVia.Text + "' and ship_company='FedEx'"
        FedExService = nz(cmd.ExecuteScalar, "")
        cnn.Close()
        '
        request.WebAuthenticationDetail = New WebAuthenticationDetail()
        request.WebAuthenticationDetail.UserCredential = New WebAuthenticationCredential()
        'request.WebAuthenticationDetail.UserCredential.Key = "adCSpkKRKvCSBnJy" ' Test
        'request.WebAuthenticationDetail.UserCredential.Password = "Y7wNA8Gz3U9pAbCxAepFywCYJ" ' Test
        request.WebAuthenticationDetail.UserCredential.Key = "3vpzP1rr97rzZjaA" ' Live
        request.WebAuthenticationDetail.UserCredential.Password = "4pnubEiEfKCoVErhNr2p5y3o8" ' Live
        '
        request.ClientDetail = New ClientDetail()
        'request.ClientDetail.AccountNumber = "510087089" ' Test Account Number
        'request.ClientDetail.MeterNumber = "118509704" ' Test
        request.ClientDetail.AccountNumber = "128395695" ' Live
        request.ClientDetail.MeterNumber = "101818115" ' Live
        'request.TransactionDetail.CustomerTransactionId = "***Delete Shipment v8 Request- Master using VB.NET***" ' The client will get the same value back in the response
        '
        '
        request.Version = New VersionId() ' WSDL version information, value is automatically set from wsdl
        '
        request.ShipTimestamp = Date.Now()
        request.ShipTimestampSpecified = True
        request.TrackingId = New TrackingId()
        Select Case FedExService
            Case "FedEx Priority Overnight"
                request.TrackingId.TrackingIdType = TrackingIdType.EXPRESS ' Service types are STANDARD_OVERNIGHT, PRIORITY_OVERNIGHT, FEDEX_GROUND ...
            Case "FedEx 2Day"
                request.TrackingId.TrackingIdType = TrackingIdType.EXPRESS
            Case "FedEx Standard Overnight"
                request.TrackingId.TrackingIdType = TrackingIdType.EXPRESS
            Case "FedEx 3Day Freight"
                request.TrackingId.TrackingIdType = TrackingIdType.GROUND
            Case "FedEx Home Delivery"
                request.TrackingId.TrackingIdType = TrackingIdType.GROUND
            Case "Home Delivery"
                request.TrackingId.TrackingIdType = TrackingIdType.GROUND
            Case "Ground"
                request.TrackingId.TrackingIdType = TrackingIdType.GROUND
            Case "International Priority"
                request.TrackingId.TrackingIdType = TrackingIdType.EXPRESS
            Case Else
                MsgBox("Undefined Service Type", MsgBoxStyle.Critical, "Service?")
                Exit Function
        End Select
        request.TrackingId.TrackingIdTypeSpecified = True
        request.TrackingId.TrackingNumber = tNum.Text ' Replace "XXX" with the tracking number to delete
        request.DeletionControl = New DeletionControlType()
        request.DeletionControl = DeletionControlType.DELETE_ALL_PACKAGES
        Return request
    End Function

    Private Sub bShipFedEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bShipFedEx.Click
        If tOrd.Text = "" Then Exit Sub
        If tVia.Text = "" Then tVia.Text = "FEDEX2DY"
        tDate.Value = Today

        Dim rw As DataRow
        Dim ref As String = ""
        Dim cmd As New SqlCommand("select ord_gen_from_rev from ord_gen where ord_gen_ord_serial=" + tOrd.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='O'", cnn)
        Dim dr As DataRow
        Dim dr2 As DataRow
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        Dim NoBoxes As String = ""
        Dim box As DataRow
        Dim x As Integer
        Dim fmNeedBox As fmShipmentNeedBox
        Dim onProdType As String

        cnn.Open()
        tFedExInvoice.Text = tOrd.Text + "-" + CStr(nz(cmd.ExecuteScalar, 0)) + "-" + tRev.Text
        cmd.CommandText = "select ship_code_desc from ship_via where ship_via_code='" + tVia.Text + "'"
        tFedExService.Text = nz(cmd.ExecuteScalar, "")
        'If tFedExPO.Text = "" Then
        '    cmd.CommandText = "select ord_gen_cust_po from ord_gen where ord_gen_ord_serial=" + Me.tOrd.Text + " and ord_gen_rev=" + Me.tRev.Text + " and ord_gen_type='" + Me.tType.Text + "'"
        '    tFedExPO.Text = nz(cmd.ExecuteScalar)
        'End If

        For Each rw In dsShip.Tables(0).Rows
            ref += rw("ship_itm_code") + ","

            cmd.CommandText = "select *,box_cnt from itm_box left outer join itm_box_cnt on itm_box_itm_code=itm_box_cnt_itm_code where itm_box_itm_code='" + rw("ship_itm_code") + "'"
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For x = 1 To rw("ship_itm_qty")
                    For Each dr In dt.Rows
                        box = dsBoxes.Tables(0).NewRow
                        box("weight") = dr("itm_box_weight")
                        box("width") = dr("itm_box_width")
                        box("height") = dr("itm_box_height")
                        box("length") = dr("itm_box_len")
                        box("reference") = dr("itm_box_name")
                        box("itmcode") = dr("itm_box_itm_code")
                        'If rw("ord_itm_unt_sell") / nz(dr("box_cnt"), 0) >= 200 Then box("declared") = rw("ord_itm_unt_sell") / nz(dr("box_cnt"), 0)
                        dsBoxes.Tables(0).Rows.Add(box)
                    Next
                Next
            Else
                cmd.CommandText = "select itm_prod_type from itm_file where itm_code='" + rw("ship_itm_code") + "'"
                onProdType = nz(cmd.ExecuteScalar)
                If onProdType = "KIT" Or onProdType = "DESKIT" Then
                    fmNeedBox = New fmShipmentNeedBox
                    fmNeedBox.ItmCode = rw("ship_itm_code")
                    fmNeedBox.ShowDialog()

                    If fmNeedBox.Canceled = True Then
                        cnn.Close()
                        fmNeedBox = Nothing
                        QuietMode = True
                        Me.Cancel()
                        QuietMode = False
                        Exit Sub
                    Else
                        cmd.CommandText = "select *,box_cnt from itm_box left outer join itm_box_cnt on itm_box_itm_code=itm_box_cnt_itm_code where itm_box_itm_code='" + rw("ship_itm_code") + "'"
                        dt2.Clear()
                        da.Fill(dt2)
                        If dt2.Rows.Count > 0 Then
                            For x = 1 To rw("ship_itm_qty")
                                For Each dr2 In dt2.Rows
                                    box = dsBoxes.Tables(0).NewRow
                                    box("weight") = dr2("itm_box_weight")
                                    box("width") = dr2("itm_box_width")
                                    box("height") = dr2("itm_box_height")
                                    box("length") = dr2("itm_box_len")
                                    box("reference") = dr2("itm_box_name")
                                    'If rw("ord_itm_unt_sell") / nz(dr2("box_cnt"), 0) >= 200 Then box("declared") = rw("ord_itm_unt_sell") / nz(dr2("box_cnt"), 0)
                                    dsBoxes.Tables(0).Rows.Add(box)
                                Next
                            Next
                        End If
                        fmNeedBox = Nothing
                    End If
                Else
                    If rw("ship_itm_code") <> "CAT-PROMO" Then NoBoxes += rw("ship_itm_code") + ", "
                End If
            End If
        Next
        cnn.Close()
        If NoBoxes <> "" Then
            MsgBox("Dimensions for " + Mid(NoBoxes, 1, Len(NoBoxes) - 2) + " need to be entered manually.", MsgBoxStyle.Information, "Dimensions?")
        End If

        If Len(ref) > 0 Then ref = Mid(ref, 1, Len(ref) - 1)
        tFedExRef.Text = ref

        ShipViaFedEx()
        tNum.Enabled = False
        tWeight.Enabled = False
        tAuth.Enabled = False
        ShipType = "FedEx"


    End Sub

    Private Sub bFedExRepeat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFedExRepeat.Click
        Dim rw, onRw As DataRow
        Dim x As Integer

        onRw = dsBoxes.Tables(0).Rows(gBoxes.ActiveRow.Index)
        For x = 1 To CInt(tFedExRepeat.Text)
            rw = dsBoxes.Tables(0).NewRow
            rw.ItemArray = onRw.ItemArray
            dsBoxes.Tables(0).Rows.Add(rw)
        Next
    End Sub

    Private Sub bFedExReprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFedExReprint.Click
        If tNum.Text = "" Then
            MsgBox("You cannot reprint unless a tracking number has been submitted.", MsgBoxStyle.Information, "Can't Delete.")
            Exit Sub
        Else
            bFedExReprint.Enabled = False
            DisplayLabel("\\10.0.0.245\jcom$\FedEx\Labels\" + tNum.Text + ".epl")
            bFedExReprint.Enabled = True


            'bFedExReprint.Enabled = False
            'Dim data As String = "0," + QT + "095" + QT + "29," + QT + tNum.Text + QT + "187," + QT + "199" + QT + "537," + QT + "\\fedex\eltron" + QT + "99," + QT + QT
            'Dim rt As String = ShipFedEx(data)
            'Dim fe As New FedExData(rt)
            'If fe.GetData("3") <> "" Then
            '    MsgBox("FedEx Error: " + fe.GetData("3"))
            '    Exit Sub
            'End If
            'bFedExReprint.Enabled = True
        End If

    End Sub

    Private Sub tCost_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCost.ValueChanged

    End Sub

    Private Sub tCost_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCost.Leave
    End Sub

    Private Sub tCost_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCost.Enter
        tCost.SelectionStart = 0
        tCost.SelectionLength = 99
    End Sub

    Private Sub pFedEx_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pFedEx.Paint

    End Sub

    Private Sub tVia_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVia.Leave
        If InStr(lStatus.Text, "SHIPPED") > 0 And tVia.Text = "STAGED" Then
            MsgBox("You may not STAGE a SHIPPED order", MsgBoxStyle.Critical, "Can Not Stage")
            tVia.Text = ""
            tVia.Focus()
        End If
    End Sub

    Private Sub bRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRemoveAll.Click

        dsShip.Tables(0).Rows.Clear()

    End Sub

    'FedEx Routines

    Function CreateMasterShipmentRequest(ByVal isCodShipment As Boolean, ByVal Ref As String) As ProcessShipmentRequest
        ' Build the Master ShipmentRequest
        Dim masterRequest As ProcessShipmentRequest = New ProcessShipmentRequest()
        '
        masterRequest.WebAuthenticationDetail = New WebAuthenticationDetail()
        masterRequest.WebAuthenticationDetail.UserCredential = New WebAuthenticationCredential()
        'masterRequest.WebAuthenticationDetail.UserCredential.Key = "adCSpkKRKvCSBnJy" ' Test
        'masterRequest.WebAuthenticationDetail.UserCredential.Password = "Y7wNA8Gz3U9pAbCxAepFywCYJ" ' Test
        masterRequest.WebAuthenticationDetail.UserCredential.Key = "3vpzP1rr97rzZjaA" ' Live
        masterRequest.WebAuthenticationDetail.UserCredential.Password = "4pnubEiEfKCoVErhNr2p5y3o8" ' Live
        '
        masterRequest.ClientDetail = New ClientDetail()
        'masterRequest.ClientDetail.AccountNumber = "510087089" ' Test
        'masterRequest.ClientDetail.MeterNumber = "118509704" ' Test
        masterRequest.ClientDetail.AccountNumber = "128395695" ' Live
        masterRequest.ClientDetail.MeterNumber = "101818115" ' Live
        '
        masterRequest.TransactionDetail = New TransactionDetail()
        masterRequest.TransactionDetail.CustomerTransactionId = "***Express Domestic MPS Ship v8 Request - Master using VB.NET***" ' The client will get the same value back in the response
        '
        masterRequest.Version = New VersionId() ' WSDL version information, value is automatically set from wsdl
        '
        SetShipmentDetails(masterRequest, Ref)
        '
        Return masterRequest
    End Function

    Function CreateChildShipmentRequest(ByRef masterRequest As ProcessShipmentRequest, ByRef masterReply As ProcessShipmentReply, ByVal isCodShipment As Boolean, ByVal Ref As String) As ProcessShipmentRequest
        ' Build the Child ShipmentRequest
        Dim childRequest As ProcessShipmentRequest = New ProcessShipmentRequest()
        '
        childRequest.WebAuthenticationDetail = masterRequest.WebAuthenticationDetail
        '
        childRequest.ClientDetail = masterRequest.ClientDetail
        '
        childRequest.TransactionDetail = New TransactionDetail()
        childRequest.TransactionDetail.CustomerTransactionId = "*** Express Domestic MPS Shipment v8 Request- Child using VB.NET***"
        '
        childRequest.Version = masterRequest.Version
        '
        SetShipmentDetails(childRequest, Ref)
        ' Master Tracking Number details
        childRequest.RequestedShipment.MasterTrackingId = New TrackingId()
        childRequest.RequestedShipment.MasterTrackingId.TrackingNumber = masterReply.CompletedShipmentDetail.CompletedPackageDetails(0).TrackingIds(0).TrackingNumber
        '
        Return childRequest
    End Function

    Sub SetShipmentDetails(ByRef request As ProcessShipmentRequest, ByVal Ref As String)
        request.RequestedShipment = New RequestedShipment()
        request.RequestedShipment.ShipTimestamp = DateTime.Now  ' Ship date and time
        request.RequestedShipment.DropoffType = DropoffType.REGULAR_PICKUP

        Select Case tFedExPackaging.Text
            Case "Customer Packaging"
                request.RequestedShipment.PackagingType = PackagingType.YOUR_PACKAGING ' Packaging type FEDEX_BOK, FEDEX_PAK, FEDEX_TUBE, YOUR_PACKAGING, ...
            Case "FedEx Pak"
                request.RequestedShipment.PackagingType = PackagingType.FEDEX_PAK
            Case "FedEx Box"
                request.RequestedShipment.PackagingType = PackagingType.FEDEX_BOX
            Case "FedEx Tube"
                request.RequestedShipment.PackagingType = PackagingType.FEDEX_TUBE
            Case "FedEx Envelope"
                request.RequestedShipment.PackagingType = PackagingType.FEDEX_ENVELOPE
            Case Else
                MsgBox("Undefined Packaging Type", MsgBoxStyle.Critical, "Packaging?")
                Exit Sub
        End Select

        Select Case FedExService
            Case "FedEx Priority Overnight"
                request.RequestedShipment.ServiceType = ServiceType.PRIORITY_OVERNIGHT ' Service types are STANDARD_OVERNIGHT, PRIORITY_OVERNIGHT, FEDEX_GROUND ...
            Case "FedEx 2Day"
                request.RequestedShipment.ServiceType = ServiceType.FEDEX_2_DAY
            Case "FedEx Standard Overnight"
                request.RequestedShipment.ServiceType = ServiceType.STANDARD_OVERNIGHT
            Case "FedEx 3Day Freight"
                request.RequestedShipment.ServiceType = ServiceType.FEDEX_3_DAY_FREIGHT
            Case "FedEx Home Delivery"
                request.RequestedShipment.ServiceType = ServiceType.GROUND_HOME_DELIVERY
            Case "Home Delivery"
                request.RequestedShipment.ServiceType = ServiceType.GROUND_HOME_DELIVERY
            Case "Ground"
                request.RequestedShipment.ServiceType = ServiceType.FEDEX_GROUND
            Case "International Priority"
                request.RequestedShipment.ServiceType = ServiceType.INTERNATIONAL_PRIORITY
            Case Else
                MsgBox("Undefined Service Type", MsgBoxStyle.Critical, "Service?")
                Exit Sub
        End Select

        request.RequestedShipment.RateRequestTypes = New RateRequestType(0) {RateRequestType.ACCOUNT} ' Rate types requested LIST, MULTIWEIGHT, ...
        request.RequestedShipment.PackageCount = CStr(dsBoxes.Tables(0).Rows.Count)
        request.RequestedShipment.PackageDetail = RequestedPackageDetailType.INDIVIDUAL_PACKAGES
        request.RequestedShipment.PackageDetailSpecified = True

        If chFedExSat.Checked Then request.RequestedShipment.SpecialServicesRequested.SpecialServiceTypes = New ShipmentSpecialServiceType(0) {ShipmentSpecialServiceType.SATURDAY_DELIVERY}
        If chFedExHold.Checked Then request.RequestedShipment.SpecialServicesRequested.SpecialServiceTypes = New ShipmentSpecialServiceType(0) {ShipmentSpecialServiceType.HOLD_AT_LOCATION}
        '
        SetSender(request)
        '
        SetRecipient(request)
        '
        SetPayment(request)
        '
        SetLabelDetails(request, Ref)
    End Sub

    Sub SetSender(ByRef request As ProcessShipmentRequest)
        request.RequestedShipment.Shipper = New Party() ' Sender information
        request.RequestedShipment.Shipper.Contact = New Contact()
        request.RequestedShipment.Shipper.Contact.PersonName = ""
        request.RequestedShipment.Shipper.Contact.CompanyName = "Wine Cellar Innovations"
        request.RequestedShipment.Shipper.Contact.PhoneNumber = "5133213733"
        request.RequestedShipment.Shipper.Address = New Address()
        request.RequestedShipment.Shipper.Address.StreetLines = New String(0) {"4575 Eastern Avenue"}
        request.RequestedShipment.Shipper.Address.City = "Cincinnati"
        request.RequestedShipment.Shipper.Address.StateOrProvinceCode = "OH"
        request.RequestedShipment.Shipper.Address.PostalCode = "45226"
        request.RequestedShipment.Shipper.Address.CountryCode = "US"
    End Sub

    Sub SetRecipient(ByRef request As ProcessShipmentRequest)
        request.RequestedShipment.Recipient = New Party() ' Recipient information
        request.RequestedShipment.Recipient.Contact = New Contact()
        request.RequestedShipment.Recipient.Contact.PersonName = tFedExContact.Text
        request.RequestedShipment.Recipient.Contact.CompanyName = tFedExComp.Text
        request.RequestedShipment.Recipient.Contact.PhoneNumber = tFedExPhone.Text
        request.RequestedShipment.Recipient.Address = New Address()
        If tFedExAddr2.Text = "" Then
            request.RequestedShipment.Recipient.Address.StreetLines = New String(1) {tFedExAddr1.Text, tFedExAddr2.Text}
        Else
            request.RequestedShipment.Recipient.Address.StreetLines = New String(1) {tFedExAddr1.Text, tFedExAddr2.Text}
        End If
        request.RequestedShipment.Recipient.Address.City = tFedExCity.Text
        request.RequestedShipment.Recipient.Address.StateOrProvinceCode = tFedExState.Text
        request.RequestedShipment.Recipient.Address.PostalCode = tFedExZip.Text
        request.RequestedShipment.Recipient.Address.CountryCode = tFedExCountry.Text
        If chFedExResidential.Checked Then
            request.RequestedShipment.Recipient.Address.Residential = True
            request.RequestedShipment.Recipient.Address.ResidentialSpecified = True
        End If
    End Sub

    Sub SetPayment(ByRef request As ProcessShipmentRequest)
        ' Shipping charges details
        If tFedEx3rdParty.Text <> "" Then
            request.RequestedShipment.ShippingChargesPayment = New Payment
            request.RequestedShipment.ShippingChargesPayment.PaymentType = PaymentType.THIRD_PARTY
            request.RequestedShipment.ShippingChargesPayment.Payor = New Payor
            request.RequestedShipment.ShippingChargesPayment.Payor.AccountNumber = tFedEx3rdParty.Text
            request.RequestedShipment.ShippingChargesPayment.Payor.CountryCode = "US"
        Else
            request.RequestedShipment.ShippingChargesPayment = New Payment()
            request.RequestedShipment.ShippingChargesPayment.PaymentType = PaymentType.SENDER
            request.RequestedShipment.ShippingChargesPayment.Payor = New Payor()
            request.RequestedShipment.ShippingChargesPayment.Payor.AccountNumber = "128395695" ' Replace "XXX" with payor's account number
            request.RequestedShipment.ShippingChargesPayment.Payor.CountryCode = "US"
        End If


    End Sub

    Sub SetLabelDetails(ByRef request As ProcessShipmentRequest, ByVal Ref As String)
        request.RequestedShipment.LabelSpecification = New LabelSpecification()
        request.RequestedShipment.LabelSpecification.LabelStockType = LabelStockType.STOCK_4X675_LEADING_DOC_TAB
        request.RequestedShipment.LabelSpecification.LabelPrintingOrientation = LabelPrintingOrientationType.TOP_EDGE_OF_TEXT_FIRST
        request.RequestedShipment.LabelSpecification.LabelPrintingOrientationSpecified = True
        request.RequestedShipment.LabelSpecification.LabelStockTypeSpecified = True
        request.RequestedShipment.LabelSpecification.ImageType = ShippingDocumentImageType.EPL2 ' Image types PDF, PNG, DPL, ...
        request.RequestedShipment.LabelSpecification.ImageTypeSpecified = True
        request.RequestedShipment.LabelSpecification.LabelFormatType = LabelFormatType.COMMON2D ' COMMON2D, LABEL_DATA_ONLY
        request.RequestedShipment.LabelSpecification.CustomerSpecifiedDetail = New CustomerSpecifiedLabelDetail
        request.RequestedShipment.LabelSpecification.CustomerSpecifiedDetail.DocTabContent = New DocTabContent
        request.RequestedShipment.LabelSpecification.CustomerSpecifiedDetail.DocTabContent.DocTabContentType = DocTabContentType.ZONE001

        Dim zn(3) As DocTabZoneSpecification
        zn(0) = New DocTabZoneSpecification
        zn(0).ZoneNumber = 3
        zn(0).Header = "Date"
        zn(0).LiteralValue = Format(Now, "MM/dd/yyyy")

        zn(1) = New DocTabZoneSpecification
        zn(1).ZoneNumber = 4
        zn(1).Header = "Time"
        zn(1).LiteralValue = Format(Now, "hh:mm")

        zn(2) = New DocTabZoneSpecification
        zn(2).ZoneNumber = 7
        zn(2).Header = "Inv"
        zn(2).LiteralValue = tFedExInvoice.Text

        zn(3) = New DocTabZoneSpecification
        zn(3).ZoneNumber = 8
        zn(3).Header = "Ref"
        zn(3).LiteralValue = Ref

        'zn(0).DataField = "REQUEST/SHIPMENT/Shipper/Address/StreetLines[1]"
        request.RequestedShipment.LabelSpecification.CustomerSpecifiedDetail.DocTabContent.Zone001 = zn
    End Sub

    Sub SetIndividualPackageLineItems(ByRef request As ProcessShipmentRequest, ByRef weightValue As Decimal, ByRef sequenceNumber As String, ByRef length As String, ByRef width As String, ByRef height As String, ByVal isCodShipment As Boolean, ByVal Ref As String, ByVal DeclaredValue As Decimal)
        request.RequestedShipment.RequestedPackageLineItems = New RequestedPackageLineItem(0) {New RequestedPackageLineItem()}
        request.RequestedShipment.RequestedPackageLineItems(0).SequenceNumber = sequenceNumber ' package sequence number
        request.RequestedShipment.RequestedPackageLineItems(0).Weight = New Weight() ' Package weight information
        request.RequestedShipment.RequestedPackageLineItems(0).Weight.Value = weightValue
        request.RequestedShipment.RequestedPackageLineItems(0).Weight.Units = WeightUnits.LB
        ' package dimensions
        request.RequestedShipment.RequestedPackageLineItems(0).Dimensions = New Dimensions()
        request.RequestedShipment.RequestedPackageLineItems(0).Dimensions.Length = length
        request.RequestedShipment.RequestedPackageLineItems(0).Dimensions.Width = width
        request.RequestedShipment.RequestedPackageLineItems(0).Dimensions.Height = height
        request.RequestedShipment.RequestedPackageLineItems(0).Dimensions.Units = LinearUnits.IN
        request.RequestedShipment.RequestedPackageLineItems(0).CustomerReferences = New CustomerReference(2) {New CustomerReference(), New CustomerReference(), New CustomerReference()}
        request.RequestedShipment.RequestedPackageLineItems(0).CustomerReferences(0).CustomerReferenceType = CustomerReferenceType.CUSTOMER_REFERENCE

        'Removing the below code as it cuts the reference number to be printed on the labels. Adding full ref# in in line #3021
        'If Len(Ref) > 30 Then
        '    request.RequestedShipment.RequestedPackageLineItems(0).CustomerReferences(0).Value = Mid(Ref, 1, 14) + "~" + Mid(Ref, Len(Ref) - 14, 15)
        'Else
        '    request.RequestedShipment.RequestedPackageLineItems(0).CustomerReferences(0).Value = Ref
        'End If
        'request.RequestedShipment.RequestedPackageLineItems(0).CustomerReferences(0).Value = Ref
        request.RequestedShipment.RequestedPackageLineItems(0).CustomerReferences(0).Value = Ref.Substring(Ref.IndexOf(" ") + 1)

        request.RequestedShipment.RequestedPackageLineItems(0).CustomerReferences(1).CustomerReferenceType = CustomerReferenceType.INVOICE_NUMBER
        request.RequestedShipment.RequestedPackageLineItems(0).CustomerReferences(1).Value = Split(Ref, " ")(0)
        request.RequestedShipment.RequestedPackageLineItems(0).CustomerReferences(2).CustomerReferenceType = CustomerReferenceType.P_O_NUMBER
        request.RequestedShipment.RequestedPackageLineItems(0).CustomerReferences(2).Value = tFedExPO.Text
        Dim Mony As New Money
        Mony.Amount = DeclaredValue
        Mony.Currency = "USD"
        request.RequestedShipment.RequestedPackageLineItems(0).InsuredValue = Mony
        If chFedExSign.Checked Or DeclaredValue >= 500 Then
            request.RequestedShipment.RequestedPackageLineItems(0).SpecialServicesRequested = New PackageSpecialServicesRequested
            request.RequestedShipment.RequestedPackageLineItems(0).SpecialServicesRequested.SignatureOptionDetail = New SignatureOptionDetail
            request.RequestedShipment.RequestedPackageLineItems(0).SpecialServicesRequested.SignatureOptionDetail.OptionType = SignatureOptionType.DIRECT
            request.RequestedShipment.RequestedPackageLineItems(0).SpecialServicesRequested.SpecialServiceTypes = New PackageSpecialServiceType(0) {PackageSpecialServiceType.SIGNATURE_OPTION}
        End If
        '
        If (isCodShipment) Then
            SetCOD(request)
        End If
    End Sub

    Sub SetCOD(ByRef request As ProcessShipmentRequest)
        request.RequestedShipment.SpecialServicesRequested = New ShipmentSpecialServicesRequested()
        request.RequestedShipment.SpecialServicesRequested.SpecialServiceTypes = New ShipmentSpecialServiceType(0) {ShipmentSpecialServiceType.COD} ' Special Services types COD, ALCOHOL, HOLD_AT_LOCATION, RESIDENTIAL DELIVERY, ...
        request.RequestedShipment.SpecialServicesRequested.CodDetail = New CodDetail()
        request.RequestedShipment.SpecialServicesRequested.CodDetail.CollectionType = CodCollectionType.ANY ' ANY, CASH, GUARANTEED_FUNDS
        request.RequestedShipment.SpecialServicesRequested.CodCollectionAmount = New Money()
        request.RequestedShipment.SpecialServicesRequested.CodCollectionAmount.Amount = 150
        request.RequestedShipment.SpecialServicesRequested.CodCollectionAmount.Currency = "USD"
    End Sub

    Sub ShowReply(ByRef reply As ProcessShipmentReply, ByVal isCodShipment As Boolean)
        ' Details for each package
        For Each packageDetail As CompletedPackageDetail In reply.CompletedShipmentDetail.CompletedPackageDetails
            ShowTrackingDetails(packageDetail.TrackingIds)
            ShowPackageRateDetails(packageDetail.PackageRating.PackageRateDetails)
            ShowBarcodeDetails(packageDetail.Barcodes)
        Next
        ShowPackageRouteDetails(reply.CompletedShipmentDetail.RoutingDetail)
    End Sub

    Sub ShowMPSChildShipmentLabels(ByRef masterReply As ProcessShipmentReply, ByRef childReply As ProcessShipmentReply, ByVal isCodShipment As Boolean)
        'Save Master label buffer to file
        Dim FileName As String = "\\10.0.0.245\jcom$\FedEx\Labels\" + masterReply.CompletedShipmentDetail.CompletedPackageDetails(0).TrackingIds(0).TrackingNumber + ".epl" '"c:\" +
        SaveLabel(FileName, masterReply.CompletedShipmentDetail.CompletedPackageDetails(0).Label.Parts(0).Image)
        ' Save Child label buffer to file
        FileName = "\\10.0.0.245\jcom$\FedEx\Labels\" + childReply.CompletedShipmentDetail.CompletedPackageDetails(0).TrackingIds(0).TrackingNumber + ".epl"  '"c:\" +
        SaveLabel(FileName, childReply.CompletedShipmentDetail.CompletedPackageDetails(0).Label.Parts(0).Image)
        ' Save COD Return label
        If (isCodShipment) Then
            FileName = "\\10.0.0.245\jcom$\FedEx\Labels\" + childReply.CompletedShipmentDetail.CodReturnDetail.CodRoutingDetail.AstraDetails(0).TrackingId.TrackingNumber + "CR.epl"  ' "c:\" + 
            SaveLabel(FileName, childReply.CompletedShipmentDetail.CodReturnDetail.Label.Parts(0).Image)
        End If
    End Sub

    Sub ShowShipmentLabel(ByRef ShipmentReply As ProcessShipmentReply, ByVal isCodShipment As Boolean)
        'Save Master label buffer to file
        Dim FileName As String = "\\10.0.0.245\jcom$\FedEx\Labels\" + ShipmentReply.CompletedShipmentDetail.CompletedPackageDetails(0).TrackingIds(0).TrackingNumber + ".epl" '"c:\" +
        SaveLabel(FileName, ShipmentReply.CompletedShipmentDetail.CompletedPackageDetails(0).Label.Parts(0).Image)
        ' Save COD Return label
        If (isCodShipment) Then
            FileName = "\\10.0.0.245\jcom$\FedEx\Labels\" + ShipmentReply.CompletedShipmentDetail.CodReturnDetail.CodRoutingDetail.AstraDetails(0).TrackingId.TrackingNumber + "CR.epl"  ' "c:\" + 
            SaveLabel(FileName, ShipmentReply.CompletedShipmentDetail.CodReturnDetail.Label.Parts(0).Image)
        End If
    End Sub


    Sub ShowTrackingDetails(ByRef TrackingIds() As TrackingId)
        ' Tracking information for each package
        Console.WriteLine("Tracking details")
        If (TrackingIds IsNot Nothing) Then
            For Each trackingId As TrackingId In TrackingIds
                Console.WriteLine("Tracking # {0} Form ID {1}", trackingId.TrackingNumber, trackingId.FormId)
            Next
        End If
    End Sub

    Sub ShowPackageRateDetails(ByRef PackageRateDetails() As PackageRateDetail)
        For Each ratedPackage As PackageRateDetail In PackageRateDetails
            Console.WriteLine()
            Console.WriteLine("Rate details")
            If (ratedPackage.BillingWeight IsNot Nothing) Then
                Console.WriteLine("Billing weight {0} {1}", ratedPackage.BillingWeight.Value, ratedPackage.BillingWeight.Units)
            End If

            If (ratedPackage.BaseCharge IsNot Nothing) Then
                Console.WriteLine("Base charge {0} {1}", ratedPackage.BaseCharge.Amount, ratedPackage.BaseCharge.Currency)
            End If

            If (ratedPackage.NetCharge IsNot Nothing) Then
                Console.WriteLine("Net charge {0} {1}", ratedPackage.NetCharge.Amount, ratedPackage.NetCharge.Currency)
            End If

            If (ratedPackage.Surcharges IsNot Nothing) Then
                ' Individual surcharge for each package
                For Each surcharge As Surcharge In ratedPackage.Surcharges
                    Console.WriteLine("{0} surcharge {1} {2}", surcharge.SurchargeType, surcharge.Amount.Amount, surcharge.Amount.Currency)
                Next
            End If

            If (ratedPackage.TotalSurcharges IsNot Nothing) Then
                Console.WriteLine("Total surcharge {0} {1}", ratedPackage.TotalSurcharges.Amount, ratedPackage.TotalSurcharges.Currency)
            End If
        Next
    End Sub

    Sub ShowBarcodeDetails(ByRef Barcodes As PackageBarcodes)
        ' Barcode information for each package
        Console.WriteLine()
        Console.WriteLine("Barcode details")
        If (Barcodes IsNot Nothing) Then
            If (Barcodes.StringBarcodes IsNot Nothing) Then
                For i As Integer = 0 To Barcodes.StringBarcodes.Length - 1
                    Console.WriteLine("String barcode {0} Type {1}", Barcodes.StringBarcodes(i).Value, Barcodes.StringBarcodes(i).Type)
                Next
            End If

            If (Barcodes.BinaryBarcodes IsNot Nothing) Then
                For i As Integer = 0 To Barcodes.BinaryBarcodes.Length - 1
                    Console.WriteLine("Binary barcode Type {0}", Barcodes.BinaryBarcodes(i).Type)
                Next
            End If
        End If
    End Sub

    Sub ShowPackageRouteDetails(ByRef RoutingDetail As ShipmentRoutingDetail)
        Console.WriteLine()
        Console.WriteLine("Routing details")
        Console.WriteLine("URSA prefix {0} suffix {1}", RoutingDetail.UrsaPrefixCode, RoutingDetail.UrsaSuffixCode)
        Console.WriteLine("Service commitment {0} Airport ID {1}", RoutingDetail.DestinationLocationId, RoutingDetail.AirportId)

        If (RoutingDetail.DeliveryDaySpecified) Then
            Console.WriteLine("Delivery day " + RoutingDetail.DeliveryDay.ToString())
        End If
        If (RoutingDetail.DeliveryDateSpecified) Then
            Console.WriteLine("Delivery date " + RoutingDetail.DeliveryDate.ToShortDateString())
        End If
        Console.WriteLine("Transit time " + RoutingDetail.TransitTime.ToString())
    End Sub

    Sub SaveLabel(ByRef LabelFileName As String, ByRef LabelBuffer() As Byte)
        ' Save label buffer to file
        Dim LabelFile As FileStream = New FileStream(LabelFileName, FileMode.Create)
        LabelFile.Write(LabelBuffer, 0, LabelBuffer.Length)
        LabelFile.Close()
        ' Display label in Acrobat
        DisplayLabel(LabelFileName)
    End Sub

    Sub DisplayLabel(ByRef LabelFileName As String)
        Dim PrinterName As String

        PrinterName = GetSetting("Jcom", "Printing", "ShippingLabel", "")

        If PrinterName = "" Then
            MsgBox("Please choose a Shipping Label Printer first under Shipping / Setup Label Printer / Shipping Label Printer from the menu", MsgBoxStyle.Critical, "Printer?")
            Exit Sub
        End If

        RawPrinterHelper.SendFileToPrinter(PrinterName, LabelFileName)

        Exit Sub
        Dim info As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo(LabelFileName)
        info.UseShellExecute = True
        info.Verb = "open"
        System.Diagnostics.Process.Start(info)
    End Sub
    'End FedEx Routines
End Class
