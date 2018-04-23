Imports System.Data.SqlClient
Public Class fmOrdSearch
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Public frm As fmStarter
    Dim dsItm As New DataSet
    Friend WithEvents cbDesReq As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Dim daItm As New SqlDataAdapter

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
    Friend WithEvents tFrom As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents tTo As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Grid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tab1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tship_id As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tship_country As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tship_city As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tship_phone1 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tship_cell As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tship_fax As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tship_phone2 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tship_addr3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lship_addr3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tship_province As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lship_province As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tship_email As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tship_zip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lship_zip As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tship_state As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lship_state As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lship_city As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tship_addr2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lship_addr2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tship_addr1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lship_addr1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tship_company As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tship_name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tsold_city As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tsold_country As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tSold_name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tSold_ID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tSold_phone1 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tsold_cell As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tsold_fax As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tsold_phone2 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tsold_addr3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lsold_addr3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lProvince As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tsold_email As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lsold_fax As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lsold_phone2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tsold_zip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lsold_zip As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tsold_state As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lsold_state As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lsold_city As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tsold_addr2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lsold_addr2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tsold_addr1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lSold_addr1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tsold_company As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tNumber As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tPrimary As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tTracking As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tPayRef As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tSecondary As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents bSearch As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tDesc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tsold_Province As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chOrders As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents lSearching As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tPO As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chRepl As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chQuotes As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tPart As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tList As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lNotes As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tNotes As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tProdType As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tCustOrd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents lMax As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tMax As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tMin As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tDesType As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_recent_no")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_recent_when")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmOrdSearch))
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_type")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_rev")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_line")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_item_code")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_desc")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_qty")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_unt_sell")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_tot")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ship_tot")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.tsold_city = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tsold_country = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tSold_name = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tSold_ID = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tSold_phone1 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.tsold_cell = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.tsold_fax = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.tsold_phone2 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.tsold_addr3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lsold_addr3 = New Infragistics.Win.Misc.UltraLabel
        Me.tsold_Province = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lProvince = New Infragistics.Win.Misc.UltraLabel
        Me.tsold_email = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel
        Me.lsold_fax = New Infragistics.Win.Misc.UltraLabel
        Me.lsold_phone2 = New Infragistics.Win.Misc.UltraLabel
        Me.tsold_zip = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lsold_zip = New Infragistics.Win.Misc.UltraLabel
        Me.tsold_state = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lsold_state = New Infragistics.Win.Misc.UltraLabel
        Me.lsold_city = New Infragistics.Win.Misc.UltraLabel
        Me.tsold_addr2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lsold_addr2 = New Infragistics.Win.Misc.UltraLabel
        Me.tsold_addr1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lSold_addr1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.tsold_company = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.tship_id = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tship_country = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tship_city = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tship_phone1 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel
        Me.tship_cell = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.tship_fax = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.tship_phone2 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.tship_addr3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lship_addr3 = New Infragistics.Win.Misc.UltraLabel
        Me.tship_province = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lship_province = New Infragistics.Win.Misc.UltraLabel
        Me.tship_email = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel
        Me.tship_zip = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lship_zip = New Infragistics.Win.Misc.UltraLabel
        Me.tship_state = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lship_state = New Infragistics.Win.Misc.UltraLabel
        Me.lship_city = New Infragistics.Win.Misc.UltraLabel
        Me.tship_addr2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lship_addr2 = New Infragistics.Win.Misc.UltraLabel
        Me.tship_addr1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lship_addr1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel
        Me.tship_company = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel
        Me.tship_name = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.lMax = New Infragistics.Win.Misc.UltraLabel
        Me.tMax = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel
        Me.tMin = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tFrom = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.tTo = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Grid2 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Tab1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.tNumber = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.tPrimary = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.tTracking = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel
        Me.tPayRef = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel
        Me.tSecondary = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.chOrders = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.bSearch = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel
        Me.tDesc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lSearching = New Infragistics.Win.Misc.UltraLabel
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.tPO = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.chRepl = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chQuotes = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel
        Me.tPart = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lNotes = New Infragistics.Win.Misc.UltraLabel
        Me.tNotes = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tList = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel
        Me.tProdType = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel
        Me.tCustOrd = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel
        Me.tDesType = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.cbDesReq = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.tsold_city, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsold_country, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tSold_name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tSold_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsold_addr3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsold_Province, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsold_email, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsold_zip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsold_state, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsold_addr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsold_addr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsold_company, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.tship_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tship_country, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tship_city, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tship_addr3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tship_province, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tship_email, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tship_zip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tship_state, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tship_addr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tship_addr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tship_company, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tship_name, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.tMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab1.SuspendLayout()
        CType(Me.tNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPrimary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPayRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tSecondary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chRepl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chQuotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tProdType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCustOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDesType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDesReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_city)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_country)
        Me.UltraTabPageControl1.Controls.Add(Me.tSold_name)
        Me.UltraTabPageControl1.Controls.Add(Me.tSold_ID)
        Me.UltraTabPageControl1.Controls.Add(Me.tSold_phone1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_cell)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_fax)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_phone2)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_addr3)
        Me.UltraTabPageControl1.Controls.Add(Me.lsold_addr3)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_Province)
        Me.UltraTabPageControl1.Controls.Add(Me.lProvince)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_email)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel18)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel19)
        Me.UltraTabPageControl1.Controls.Add(Me.lsold_fax)
        Me.UltraTabPageControl1.Controls.Add(Me.lsold_phone2)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_zip)
        Me.UltraTabPageControl1.Controls.Add(Me.lsold_zip)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_state)
        Me.UltraTabPageControl1.Controls.Add(Me.lsold_state)
        Me.UltraTabPageControl1.Controls.Add(Me.lsold_city)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_addr2)
        Me.UltraTabPageControl1.Controls.Add(Me.lsold_addr2)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_addr1)
        Me.UltraTabPageControl1.Controls.Add(Me.lSold_addr1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel8)
        Me.UltraTabPageControl1.Controls.Add(Me.tsold_company)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel9)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel6)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(180, 398)
        '
        'tsold_city
        '
        Me.tsold_city.Location = New System.Drawing.Point(72, 200)
        Me.tsold_city.Name = "tsold_city"
        Me.tsold_city.Size = New System.Drawing.Size(104, 21)
        Me.tsold_city.TabIndex = 8
        Me.tsold_city.Tag = "edit;ord_sold_city"
        '
        'tsold_country
        '
        Me.tsold_country.Location = New System.Drawing.Point(72, 80)
        Me.tsold_country.Name = "tsold_country"
        Me.tsold_country.Size = New System.Drawing.Size(104, 21)
        Me.tsold_country.TabIndex = 3
        Me.tsold_country.Tag = "edit;ord_sold_country"
        '
        'tSold_name
        '
        Me.tSold_name.Location = New System.Drawing.Point(72, 32)
        Me.tSold_name.Name = "tSold_name"
        Me.tSold_name.Size = New System.Drawing.Size(104, 21)
        Me.tSold_name.TabIndex = 1
        Me.tSold_name.Tag = "edit;ord_sold_name"
        '
        'tSold_ID
        '
        Me.tSold_ID.Location = New System.Drawing.Point(72, 8)
        Me.tSold_ID.Name = "tSold_ID"
        Me.tSold_ID.Size = New System.Drawing.Size(104, 21)
        Me.tSold_ID.TabIndex = 0
        Me.tSold_ID.Tag = "edit;ord_sold_cust_id"
        '
        'tSold_phone1
        '
        Me.tSold_phone1.Location = New System.Drawing.Point(72, 280)
        Me.tSold_phone1.Name = "tSold_phone1"
        Me.tSold_phone1.Size = New System.Drawing.Size(104, 20)
        Me.tSold_phone1.TabIndex = 11
        Me.tSold_phone1.Tag = "edit;ord_sold_phone1"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(0, 280)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel1.TabIndex = 178
        Me.UltraLabel1.Text = "Phone1"
        '
        'tsold_cell
        '
        Me.tsold_cell.Location = New System.Drawing.Point(72, 352)
        Me.tsold_cell.Name = "tsold_cell"
        Me.tsold_cell.Size = New System.Drawing.Size(104, 20)
        Me.tsold_cell.TabIndex = 14
        Me.tsold_cell.Tag = "edit;ord_sold_cell"
        '
        'tsold_fax
        '
        Me.tsold_fax.Location = New System.Drawing.Point(72, 328)
        Me.tsold_fax.Name = "tsold_fax"
        Me.tsold_fax.Size = New System.Drawing.Size(104, 20)
        Me.tsold_fax.TabIndex = 13
        Me.tsold_fax.Tag = "edit;ord_sold_fax"
        '
        'tsold_phone2
        '
        Me.tsold_phone2.Location = New System.Drawing.Point(72, 304)
        Me.tsold_phone2.Name = "tsold_phone2"
        Me.tsold_phone2.Size = New System.Drawing.Size(104, 20)
        Me.tsold_phone2.TabIndex = 12
        Me.tsold_phone2.Tag = "edit;ord_sold_phone2"
        '
        'tsold_addr3
        '
        Me.tsold_addr3.Location = New System.Drawing.Point(72, 152)
        Me.tsold_addr3.Name = "tsold_addr3"
        Me.tsold_addr3.Size = New System.Drawing.Size(104, 21)
        Me.tsold_addr3.TabIndex = 6
        Me.tsold_addr3.Tag = "edit;ord_sold_addr3"
        '
        'lsold_addr3
        '
        Me.lsold_addr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsold_addr3.Location = New System.Drawing.Point(0, 152)
        Me.lsold_addr3.Name = "lsold_addr3"
        Me.lsold_addr3.Size = New System.Drawing.Size(104, 16)
        Me.lsold_addr3.TabIndex = 176
        Me.lsold_addr3.Text = "Addr3"
        '
        'tsold_Province
        '
        Me.tsold_Province.Location = New System.Drawing.Point(72, 248)
        Me.tsold_Province.Name = "tsold_Province"
        Me.tsold_Province.Size = New System.Drawing.Size(104, 21)
        Me.tsold_Province.TabIndex = 10
        Me.tsold_Province.Tag = "edit;ord_sold_province"
        '
        'lProvince
        '
        Me.lProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lProvince.Location = New System.Drawing.Point(0, 248)
        Me.lProvince.Name = "lProvince"
        Me.lProvince.Size = New System.Drawing.Size(104, 16)
        Me.lProvince.TabIndex = 175
        Me.lProvince.Text = "Province"
        '
        'tsold_email
        '
        Me.tsold_email.Location = New System.Drawing.Point(72, 376)
        Me.tsold_email.Name = "tsold_email"
        Me.tsold_email.Size = New System.Drawing.Size(104, 21)
        Me.tsold_email.TabIndex = 15
        Me.tsold_email.Tag = "edit;ord_sold_email"
        '
        'UltraLabel18
        '
        Me.UltraLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(0, 376)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel18.TabIndex = 174
        Me.UltraLabel18.Text = "Email"
        '
        'UltraLabel19
        '
        Me.UltraLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(0, 352)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel19.TabIndex = 173
        Me.UltraLabel19.Text = "Cell Phone"
        '
        'lsold_fax
        '
        Me.lsold_fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsold_fax.Location = New System.Drawing.Point(0, 328)
        Me.lsold_fax.Name = "lsold_fax"
        Me.lsold_fax.Size = New System.Drawing.Size(104, 16)
        Me.lsold_fax.TabIndex = 172
        Me.lsold_fax.Text = "Fax"
        '
        'lsold_phone2
        '
        Me.lsold_phone2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsold_phone2.Location = New System.Drawing.Point(0, 304)
        Me.lsold_phone2.Name = "lsold_phone2"
        Me.lsold_phone2.Size = New System.Drawing.Size(104, 16)
        Me.lsold_phone2.TabIndex = 171
        Me.lsold_phone2.Text = "Phone2"
        '
        'tsold_zip
        '
        Me.tsold_zip.Location = New System.Drawing.Point(72, 176)
        Me.tsold_zip.Name = "tsold_zip"
        Me.tsold_zip.Size = New System.Drawing.Size(104, 21)
        Me.tsold_zip.TabIndex = 7
        Me.tsold_zip.Tag = "edit;ord_sold_zip"
        '
        'lsold_zip
        '
        Me.lsold_zip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsold_zip.Location = New System.Drawing.Point(0, 176)
        Me.lsold_zip.Name = "lsold_zip"
        Me.lsold_zip.Size = New System.Drawing.Size(104, 16)
        Me.lsold_zip.TabIndex = 170
        Me.lsold_zip.Text = "Zip"
        '
        'tsold_state
        '
        Me.tsold_state.Location = New System.Drawing.Point(72, 224)
        Me.tsold_state.Name = "tsold_state"
        Me.tsold_state.Size = New System.Drawing.Size(104, 21)
        Me.tsold_state.TabIndex = 9
        Me.tsold_state.Tag = "edit;ord_sold_state"
        '
        'lsold_state
        '
        Me.lsold_state.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsold_state.Location = New System.Drawing.Point(0, 224)
        Me.lsold_state.Name = "lsold_state"
        Me.lsold_state.Size = New System.Drawing.Size(104, 16)
        Me.lsold_state.TabIndex = 169
        Me.lsold_state.Text = "State"
        '
        'lsold_city
        '
        Me.lsold_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsold_city.Location = New System.Drawing.Point(0, 200)
        Me.lsold_city.Name = "lsold_city"
        Me.lsold_city.Size = New System.Drawing.Size(104, 16)
        Me.lsold_city.TabIndex = 166
        Me.lsold_city.Text = "City"
        '
        'tsold_addr2
        '
        Me.tsold_addr2.Location = New System.Drawing.Point(72, 128)
        Me.tsold_addr2.Name = "tsold_addr2"
        Me.tsold_addr2.Size = New System.Drawing.Size(104, 21)
        Me.tsold_addr2.TabIndex = 5
        Me.tsold_addr2.Tag = "edit;ord_sold_addr2"
        '
        'lsold_addr2
        '
        Me.lsold_addr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsold_addr2.Location = New System.Drawing.Point(0, 128)
        Me.lsold_addr2.Name = "lsold_addr2"
        Me.lsold_addr2.Size = New System.Drawing.Size(104, 16)
        Me.lsold_addr2.TabIndex = 163
        Me.lsold_addr2.Text = "Addr2"
        '
        'tsold_addr1
        '
        Me.tsold_addr1.Location = New System.Drawing.Point(72, 104)
        Me.tsold_addr1.Name = "tsold_addr1"
        Me.tsold_addr1.Size = New System.Drawing.Size(104, 21)
        Me.tsold_addr1.TabIndex = 4
        Me.tsold_addr1.Tag = "edit;ord_sold_addr1"
        '
        'lSold_addr1
        '
        Me.lSold_addr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSold_addr1.Location = New System.Drawing.Point(0, 104)
        Me.lSold_addr1.Name = "lSold_addr1"
        Me.lSold_addr1.Size = New System.Drawing.Size(104, 16)
        Me.lSold_addr1.TabIndex = 161
        Me.lSold_addr1.Text = "Addr1"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(0, 80)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel8.TabIndex = 159
        Me.UltraLabel8.Text = "Country"
        '
        'tsold_company
        '
        Me.tsold_company.Location = New System.Drawing.Point(72, 56)
        Me.tsold_company.Name = "tsold_company"
        Me.tsold_company.Size = New System.Drawing.Size(104, 21)
        Me.tsold_company.TabIndex = 2
        Me.tsold_company.Tag = "edit;ord_sold_company"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(0, 56)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel9.TabIndex = 156
        Me.UltraLabel9.Text = "Company"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(0, 32)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel6.TabIndex = 153
        Me.UltraLabel6.Text = "Name"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(0, 8)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel5.TabIndex = 151
        Me.UltraLabel5.Text = "Cust ID"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.tship_id)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_country)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_city)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_phone1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel21)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_cell)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_fax)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_phone2)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_addr3)
        Me.UltraTabPageControl2.Controls.Add(Me.lship_addr3)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_province)
        Me.UltraTabPageControl2.Controls.Add(Me.lship_province)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_email)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel3)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel17)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel20)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_zip)
        Me.UltraTabPageControl2.Controls.Add(Me.lship_zip)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_state)
        Me.UltraTabPageControl2.Controls.Add(Me.lship_state)
        Me.UltraTabPageControl2.Controls.Add(Me.lship_city)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_addr2)
        Me.UltraTabPageControl2.Controls.Add(Me.lship_addr2)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_addr1)
        Me.UltraTabPageControl2.Controls.Add(Me.lship_addr1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel27)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_company)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel28)
        Me.UltraTabPageControl2.Controls.Add(Me.tship_name)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel29)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel30)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-8333, -8667)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(180, 398)
        '
        'tship_id
        '
        Me.tship_id.Location = New System.Drawing.Point(72, 8)
        Me.tship_id.Name = "tship_id"
        Me.tship_id.Size = New System.Drawing.Size(104, 21)
        Me.tship_id.TabIndex = 185
        Me.tship_id.Tag = "edit;ord_ship_cust_id"
        '
        'tship_country
        '
        Me.tship_country.Location = New System.Drawing.Point(72, 80)
        Me.tship_country.Name = "tship_country"
        Me.tship_country.Size = New System.Drawing.Size(104, 21)
        Me.tship_country.TabIndex = 184
        Me.tship_country.Tag = "edit;ord_ship_country"
        '
        'tship_city
        '
        Me.tship_city.Location = New System.Drawing.Point(72, 200)
        Me.tship_city.Name = "tship_city"
        Me.tship_city.Size = New System.Drawing.Size(104, 21)
        Me.tship_city.TabIndex = 183
        Me.tship_city.Tag = "edit;ord_ship_city"
        '
        'tship_phone1
        '
        Me.tship_phone1.Location = New System.Drawing.Point(72, 280)
        Me.tship_phone1.Name = "tship_phone1"
        Me.tship_phone1.Size = New System.Drawing.Size(104, 20)
        Me.tship_phone1.TabIndex = 181
        Me.tship_phone1.Tag = "edit;ord_ship_phone1"
        '
        'UltraLabel21
        '
        Me.UltraLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(0, 280)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel21.TabIndex = 182
        Me.UltraLabel21.Text = "Phone1"
        '
        'tship_cell
        '
        Me.tship_cell.Location = New System.Drawing.Point(72, 352)
        Me.tship_cell.Name = "tship_cell"
        Me.tship_cell.Size = New System.Drawing.Size(104, 20)
        Me.tship_cell.TabIndex = 165
        Me.tship_cell.Tag = "edit;ord_ship_cell"
        '
        'tship_fax
        '
        Me.tship_fax.Location = New System.Drawing.Point(72, 328)
        Me.tship_fax.Name = "tship_fax"
        Me.tship_fax.Size = New System.Drawing.Size(104, 20)
        Me.tship_fax.TabIndex = 163
        Me.tship_fax.Tag = "edit;ord_ship_fax"
        '
        'tship_phone2
        '
        Me.tship_phone2.Location = New System.Drawing.Point(72, 304)
        Me.tship_phone2.Name = "tship_phone2"
        Me.tship_phone2.Size = New System.Drawing.Size(104, 20)
        Me.tship_phone2.TabIndex = 162
        Me.tship_phone2.Tag = "edit;ord_ship_phone2"
        '
        'tship_addr3
        '
        Me.tship_addr3.Location = New System.Drawing.Point(72, 152)
        Me.tship_addr3.Name = "tship_addr3"
        Me.tship_addr3.Size = New System.Drawing.Size(104, 21)
        Me.tship_addr3.TabIndex = 158
        Me.tship_addr3.Tag = "edit;ord_ship_addr3"
        '
        'lship_addr3
        '
        Me.lship_addr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lship_addr3.Location = New System.Drawing.Point(0, 152)
        Me.lship_addr3.Name = "lship_addr3"
        Me.lship_addr3.Size = New System.Drawing.Size(104, 16)
        Me.lship_addr3.TabIndex = 180
        Me.lship_addr3.Text = "Addr3"
        '
        'tship_province
        '
        Me.tship_province.Location = New System.Drawing.Point(72, 248)
        Me.tship_province.Name = "tship_province"
        Me.tship_province.Size = New System.Drawing.Size(104, 21)
        Me.tship_province.TabIndex = 161
        Me.tship_province.Tag = "edit;ord_ship_province"
        '
        'lship_province
        '
        Me.lship_province.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lship_province.Location = New System.Drawing.Point(0, 248)
        Me.lship_province.Name = "lship_province"
        Me.lship_province.Size = New System.Drawing.Size(104, 16)
        Me.lship_province.TabIndex = 179
        Me.lship_province.Text = "Province"
        '
        'tship_email
        '
        Me.tship_email.Location = New System.Drawing.Point(72, 376)
        Me.tship_email.Name = "tship_email"
        Me.tship_email.Size = New System.Drawing.Size(104, 21)
        Me.tship_email.TabIndex = 166
        Me.tship_email.Tag = "edit;ord_ship_email"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(0, 376)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel2.TabIndex = 178
        Me.UltraLabel2.Text = "Email"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(0, 352)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel3.TabIndex = 177
        Me.UltraLabel3.Text = "Cell Phone"
        '
        'UltraLabel17
        '
        Me.UltraLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(0, 328)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel17.TabIndex = 176
        Me.UltraLabel17.Text = "Fax"
        '
        'UltraLabel20
        '
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(0, 304)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel20.TabIndex = 175
        Me.UltraLabel20.Text = "Phone2"
        '
        'tship_zip
        '
        Me.tship_zip.Location = New System.Drawing.Point(72, 176)
        Me.tship_zip.Name = "tship_zip"
        Me.tship_zip.Size = New System.Drawing.Size(104, 21)
        Me.tship_zip.TabIndex = 159
        Me.tship_zip.Tag = "edit;ord_ship_zip"
        '
        'lship_zip
        '
        Me.lship_zip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lship_zip.Location = New System.Drawing.Point(0, 176)
        Me.lship_zip.Name = "lship_zip"
        Me.lship_zip.Size = New System.Drawing.Size(104, 16)
        Me.lship_zip.TabIndex = 174
        Me.lship_zip.Text = "Zip"
        '
        'tship_state
        '
        Me.tship_state.Location = New System.Drawing.Point(72, 224)
        Me.tship_state.Name = "tship_state"
        Me.tship_state.Size = New System.Drawing.Size(104, 21)
        Me.tship_state.TabIndex = 160
        Me.tship_state.Tag = "edit;ord_ship_state"
        '
        'lship_state
        '
        Me.lship_state.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lship_state.Location = New System.Drawing.Point(0, 224)
        Me.lship_state.Name = "lship_state"
        Me.lship_state.Size = New System.Drawing.Size(104, 16)
        Me.lship_state.TabIndex = 173
        Me.lship_state.Text = "State"
        '
        'lship_city
        '
        Me.lship_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lship_city.Location = New System.Drawing.Point(0, 200)
        Me.lship_city.Name = "lship_city"
        Me.lship_city.Size = New System.Drawing.Size(104, 16)
        Me.lship_city.TabIndex = 172
        Me.lship_city.Text = "City"
        '
        'tship_addr2
        '
        Me.tship_addr2.Location = New System.Drawing.Point(72, 128)
        Me.tship_addr2.Name = "tship_addr2"
        Me.tship_addr2.Size = New System.Drawing.Size(104, 21)
        Me.tship_addr2.TabIndex = 157
        Me.tship_addr2.Tag = "edit;ord_ship_addr2"
        '
        'lship_addr2
        '
        Me.lship_addr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lship_addr2.Location = New System.Drawing.Point(0, 128)
        Me.lship_addr2.Name = "lship_addr2"
        Me.lship_addr2.Size = New System.Drawing.Size(104, 16)
        Me.lship_addr2.TabIndex = 171
        Me.lship_addr2.Text = "Addr2"
        '
        'tship_addr1
        '
        Me.tship_addr1.Location = New System.Drawing.Point(72, 104)
        Me.tship_addr1.Name = "tship_addr1"
        Me.tship_addr1.Size = New System.Drawing.Size(104, 21)
        Me.tship_addr1.TabIndex = 156
        Me.tship_addr1.Tag = "edit;ord_ship_addr1"
        '
        'lship_addr1
        '
        Me.lship_addr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lship_addr1.Location = New System.Drawing.Point(0, 104)
        Me.lship_addr1.Name = "lship_addr1"
        Me.lship_addr1.Size = New System.Drawing.Size(104, 16)
        Me.lship_addr1.TabIndex = 170
        Me.lship_addr1.Text = "Addr1"
        '
        'UltraLabel27
        '
        Me.UltraLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel27.Location = New System.Drawing.Point(0, 80)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel27.TabIndex = 169
        Me.UltraLabel27.Text = "Country"
        '
        'tship_company
        '
        Me.tship_company.Location = New System.Drawing.Point(72, 56)
        Me.tship_company.Name = "tship_company"
        Me.tship_company.Size = New System.Drawing.Size(104, 21)
        Me.tship_company.TabIndex = 155
        Me.tship_company.Tag = "edit;ord_ship_company"
        '
        'UltraLabel28
        '
        Me.UltraLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel28.Location = New System.Drawing.Point(0, 56)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel28.TabIndex = 168
        Me.UltraLabel28.Text = "Company"
        '
        'tship_name
        '
        Me.tship_name.Location = New System.Drawing.Point(72, 32)
        Me.tship_name.Name = "tship_name"
        Me.tship_name.Size = New System.Drawing.Size(104, 21)
        Me.tship_name.TabIndex = 154
        Me.tship_name.Tag = "edit;ord_ship_name"
        '
        'UltraLabel29
        '
        Me.UltraLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel29.Location = New System.Drawing.Point(0, 32)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel29.TabIndex = 167
        Me.UltraLabel29.Text = "Name"
        '
        'UltraLabel30
        '
        Me.UltraLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel30.Location = New System.Drawing.Point(0, 8)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel30.TabIndex = 164
        Me.UltraLabel30.Text = "Cust ID"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.lMax)
        Me.UltraTabPageControl3.Controls.Add(Me.tMax)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraLabel22)
        Me.UltraTabPageControl3.Controls.Add(Me.tMin)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-8333, -8667)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(180, 398)
        '
        'lMax
        '
        Me.lMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMax.Location = New System.Drawing.Point(0, 32)
        Me.lMax.Name = "lMax"
        Me.lMax.Size = New System.Drawing.Size(96, 16)
        Me.lMax.TabIndex = 184
        Me.lMax.Text = "Maximum Total"
        '
        'tMax
        '
        Me.tMax.Location = New System.Drawing.Point(96, 32)
        Me.tMax.Name = "tMax"
        Me.tMax.Size = New System.Drawing.Size(80, 21)
        Me.tMax.TabIndex = 182
        '
        'UltraLabel22
        '
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(0, 8)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel22.TabIndex = 183
        Me.UltraLabel22.Text = "Mininum Total"
        '
        'tMin
        '
        Me.tMin.Location = New System.Drawing.Point(96, 8)
        Me.tMin.Name = "tMin"
        Me.tMin.Size = New System.Drawing.Size(80, 21)
        Me.tMin.TabIndex = 181
        '
        'tFrom
        '
        Me.tFrom.DateTime = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.tFrom.Location = New System.Drawing.Point(384, 8)
        Me.tFrom.Name = "tFrom"
        Me.tFrom.Size = New System.Drawing.Size(96, 21)
        Me.tFrom.TabIndex = 10
        Me.tFrom.Value = New Date(1980, 1, 1, 0, 0, 0, 0)
        '
        'tTo
        '
        Me.tTo.DateTime = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.tTo.Location = New System.Drawing.Point(496, 8)
        Me.tTo.Name = "tTo"
        Me.tTo.Size = New System.Drawing.Size(96, 21)
        Me.tTo.TabIndex = 11
        Me.tTo.Value = New Date(2099, 12, 31, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(360, 8)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(24, 16)
        Me.UltraLabel4.TabIndex = 156
        Me.UltraLabel4.Text = "Fm"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(480, 8)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(16, 16)
        Me.UltraLabel7.TabIndex = 157
        Me.UltraLabel7.Text = "to"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.Grid1.DisplayLayout.Appearance = Appearance1
        Me.Grid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 602
        UltraGridColumn2.Format = "MM/dd/yyyy hh:mm"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MaxWidth = 100
        UltraGridColumn2.Width = 100
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.InterBandSpacing = 10
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid1.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.Grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Grid1.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Grid1.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.Grid1.DisplayLayout.Override.RowSelectorWidth = 12
        Me.Grid1.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.Grid1.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.Grid1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Grid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid1.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.ImageList = Me.ImageList1
        Me.Grid1.Location = New System.Drawing.Point(392, 32)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1004, 416)
        Me.Grid1.TabIndex = 15
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        '
        'Grid2
        '
        Me.Grid2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.Grid2.DisplayLayout.Appearance = Appearance7
        Me.Grid2.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn3.Header.Caption = "Type"
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Width = 63
        Appearance19.ImageAlpha = Infragistics.Win.Alpha.Transparent
        UltraGridColumn4.CellAppearance = Appearance19
        UltraGridColumn4.Header.Caption = "Rev"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 44
        UltraGridColumn5.Header.Caption = "Line"
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.Width = 179
        UltraGridColumn6.Header.Caption = "Item Code"
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn6.Width = 173
        UltraGridColumn7.Header.Caption = "Description"
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Width = 434
        UltraGridColumn8.Header.Caption = "Qty"
        UltraGridColumn8.Header.VisiblePosition = 5
        UltraGridColumn8.Width = 103
        UltraGridColumn9.Format = "$###,###,##0.00"
        UltraGridColumn9.Header.Caption = "Unit Price"
        UltraGridColumn9.Header.VisiblePosition = 6
        UltraGridColumn9.Width = 153
        Appearance8.FontData.BoldAsString = "True"
        UltraGridColumn10.CellAppearance = Appearance8
        UltraGridColumn10.Format = "$###,###,##0.00"
        UltraGridColumn10.Header.Caption = "Ext Price"
        UltraGridColumn10.Header.VisiblePosition = 7
        UltraGridColumn10.Width = 105
        UltraGridColumn11.Format = "$###,###,##0.00"
        UltraGridColumn11.Header.Caption = "Ext Ship"
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn11.Width = 120
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.Grid2.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.Grid2.DisplayLayout.InterBandSpacing = 10
        Me.Grid2.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.Grid2.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Me.Grid2.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.ForeColor = System.Drawing.Color.Black
        Appearance10.TextHAlignAsString = "Left"
        Appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid2.DisplayLayout.Override.HeaderAppearance = Appearance10
        Appearance11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Grid2.DisplayLayout.Override.RowAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Grid2.DisplayLayout.Override.RowSelectorAppearance = Appearance12
        Me.Grid2.DisplayLayout.Override.RowSelectorWidth = 12
        Me.Grid2.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.Grid2.DisplayLayout.Override.SelectedRowAppearance = Appearance13
        Me.Grid2.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Grid2.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.Grid2.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid2.ImageList = Me.ImageList1
        Me.Grid2.Location = New System.Drawing.Point(8, 464)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(1388, 323)
        Me.Grid2.TabIndex = 16
        '
        'Tab1
        '
        Appearance14.FontData.BoldAsString = "True"
        Me.Tab1.ActiveTabAppearance = Appearance14
        Me.Tab1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl1)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl2)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl3)
        Me.Tab1.Location = New System.Drawing.Point(200, 8)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.Tab1.Size = New System.Drawing.Size(184, 424)
        Me.Tab1.TabIndex = 9
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Sold To"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ship To"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Other"
        Me.Tab1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.Tab1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(180, 398)
        '
        'tNumber
        '
        Me.tNumber.Location = New System.Drawing.Point(112, 8)
        Me.tNumber.Name = "tNumber"
        Me.tNumber.Size = New System.Drawing.Size(80, 21)
        Me.tNumber.TabIndex = 0
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel10.TabIndex = 162
        Me.UltraLabel10.Text = "Number"
        '
        'UltraLabel12
        '
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(8, 32)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel12.TabIndex = 166
        Me.UltraLabel12.Text = "Primary Ref"
        '
        'tPrimary
        '
        Me.tPrimary.Location = New System.Drawing.Point(112, 32)
        Me.tPrimary.Name = "tPrimary"
        Me.tPrimary.Size = New System.Drawing.Size(80, 21)
        Me.tPrimary.TabIndex = 1
        '
        'UltraLabel13
        '
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(8, 104)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel13.TabIndex = 172
        Me.UltraLabel13.Text = "Tracking #"
        '
        'tTracking
        '
        Me.tTracking.Location = New System.Drawing.Point(112, 104)
        Me.tTracking.Name = "tTracking"
        Me.tTracking.Size = New System.Drawing.Size(80, 21)
        Me.tTracking.TabIndex = 4
        '
        'UltraLabel14
        '
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(8, 80)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel14.TabIndex = 170
        Me.UltraLabel14.Text = "Pay Ref #"
        '
        'tPayRef
        '
        Me.tPayRef.Location = New System.Drawing.Point(112, 80)
        Me.tPayRef.Name = "tPayRef"
        Me.tPayRef.Size = New System.Drawing.Size(80, 21)
        Me.tPayRef.TabIndex = 3
        '
        'UltraLabel15
        '
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(8, 56)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel15.TabIndex = 168
        Me.UltraLabel15.Text = "Secondary Details"
        '
        'tSecondary
        '
        Me.tSecondary.Location = New System.Drawing.Point(112, 56)
        Me.tSecondary.Name = "tSecondary"
        Me.tSecondary.Size = New System.Drawing.Size(80, 21)
        Me.tSecondary.TabIndex = 2
        '
        'chOrders
        '
        Appearance15.FontData.BoldAsString = "True"
        Me.chOrders.Appearance = Appearance15
        Me.chOrders.Checked = True
        Me.chOrders.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chOrders.Location = New System.Drawing.Point(672, 8)
        Me.chOrders.Name = "chOrders"
        Me.chOrders.Size = New System.Drawing.Size(88, 16)
        Me.chOrders.TabIndex = 173
        Me.chOrders.Text = "Orders"
        '
        'bSearch
        '
        Me.bSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSearch.Location = New System.Drawing.Point(8, 416)
        Me.bSearch.Name = "bSearch"
        Me.bSearch.Size = New System.Drawing.Size(184, 40)
        Me.bSearch.TabIndex = 14
        Me.bSearch.Text = "Search"
        '
        'UltraLabel16
        '
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(8, 128)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel16.TabIndex = 176
        Me.UltraLabel16.Text = "Description"
        '
        'tDesc
        '
        Me.tDesc.Location = New System.Drawing.Point(112, 128)
        Me.tDesc.Name = "tDesc"
        Me.tDesc.Size = New System.Drawing.Size(80, 21)
        Me.tDesc.TabIndex = 5
        '
        'lSearching
        '
        Me.lSearching.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSearching.Location = New System.Drawing.Point(408, 56)
        Me.lSearching.Name = "lSearching"
        Me.lSearching.Size = New System.Drawing.Size(400, 64)
        Me.lSearching.TabIndex = 181
        Me.lSearching.Text = "Searching..."
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(8, 344)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(184, 32)
        Me.UltraButton2.TabIndex = 13
        Me.UltraButton2.Text = "List Latest (F3)"
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(8, 320)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(184, 24)
        Me.UltraButton3.TabIndex = 12
        Me.UltraButton3.Text = "Clear Fields (ESC)"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(8, 152)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel11.TabIndex = 186
        Me.UltraLabel11.Text = "Customer PO"
        '
        'tPO
        '
        Me.tPO.Location = New System.Drawing.Point(112, 152)
        Me.tPO.Name = "tPO"
        Me.tPO.Size = New System.Drawing.Size(80, 21)
        Me.tPO.TabIndex = 6
        '
        'chRepl
        '
        Appearance16.FontData.BoldAsString = "True"
        Me.chRepl.Appearance = Appearance16
        Me.chRepl.Location = New System.Drawing.Point(744, 8)
        Me.chRepl.Name = "chRepl"
        Me.chRepl.Size = New System.Drawing.Size(88, 16)
        Me.chRepl.TabIndex = 187
        Me.chRepl.Text = "Replacemnt"
        '
        'chQuotes
        '
        Appearance17.FontData.BoldAsString = "True"
        Me.chQuotes.Appearance = Appearance17
        Me.chQuotes.Checked = True
        Me.chQuotes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chQuotes.Location = New System.Drawing.Point(600, 8)
        Me.chQuotes.Name = "chQuotes"
        Me.chQuotes.Size = New System.Drawing.Size(64, 16)
        Me.chQuotes.TabIndex = 188
        Me.chQuotes.Text = "Quotes"
        '
        'UltraLabel23
        '
        Me.UltraLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(8, 200)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel23.TabIndex = 190
        Me.UltraLabel23.Text = "Part Number"
        '
        'tPart
        '
        Me.tPart.Location = New System.Drawing.Point(112, 200)
        Me.tPart.Name = "tPart"
        Me.tPart.Size = New System.Drawing.Size(80, 21)
        Me.tPart.TabIndex = 8
        '
        'lNotes
        '
        Me.lNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNotes.Location = New System.Drawing.Point(8, 224)
        Me.lNotes.Name = "lNotes"
        Me.lNotes.Size = New System.Drawing.Size(96, 16)
        Me.lNotes.TabIndex = 192
        Me.lNotes.Text = "Notes"
        '
        'tNotes
        '
        Me.tNotes.Location = New System.Drawing.Point(112, 224)
        Me.tNotes.Name = "tNotes"
        Me.tNotes.Size = New System.Drawing.Size(80, 21)
        Me.tNotes.TabIndex = 9
        '
        'tList
        '
        Me.tList.Location = New System.Drawing.Point(880, 4)
        Me.tList.Name = "tList"
        Me.tList.Size = New System.Drawing.Size(56, 21)
        Me.tList.TabIndex = 193
        Me.tList.Text = "200"
        '
        'UltraLabel24
        '
        Me.UltraLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(848, 8)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(32, 16)
        Me.UltraLabel24.TabIndex = 194
        Me.UltraLabel24.Text = "List"
        '
        'UltraLabel25
        '
        Me.UltraLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(8, 248)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel25.TabIndex = 196
        Me.UltraLabel25.Text = "Product Type"
        '
        'tProdType
        '
        Me.tProdType.Location = New System.Drawing.Point(112, 248)
        Me.tProdType.Name = "tProdType"
        Me.tProdType.Size = New System.Drawing.Size(80, 21)
        Me.tProdType.TabIndex = 10
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(8, 376)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(184, 32)
        Me.UltraButton1.TabIndex = 197
        Me.UltraButton1.Text = "List Recent (F4)"
        '
        'UltraLabel26
        '
        Me.UltraLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel26.Location = New System.Drawing.Point(8, 176)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel26.TabIndex = 199
        Me.UltraLabel26.Text = "Customer Order#"
        '
        'tCustOrd
        '
        Me.tCustOrd.Location = New System.Drawing.Point(112, 176)
        Me.tCustOrd.Name = "tCustOrd"
        Me.tCustOrd.Size = New System.Drawing.Size(80, 21)
        Me.tCustOrd.TabIndex = 7
        '
        'UltraLabel31
        '
        Me.UltraLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel31.Location = New System.Drawing.Point(8, 272)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel31.TabIndex = 201
        Me.UltraLabel31.Text = "Design Type"
        '
        'tDesType
        '
        Me.tDesType.Location = New System.Drawing.Point(112, 272)
        Me.tDesType.Name = "tDesType"
        Me.tDesType.Size = New System.Drawing.Size(80, 21)
        Me.tDesType.TabIndex = 11
        '
        'cbDesReq
        '
        Me.cbDesReq.Location = New System.Drawing.Point(112, 297)
        Me.cbDesReq.Name = "cbDesReq"
        Me.cbDesReq.Size = New System.Drawing.Size(25, 16)
        Me.cbDesReq.TabIndex = 202
        '
        'UltraLabel32
        '
        Me.UltraLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(10, 296)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(96, 15)
        Me.UltraLabel32.TabIndex = 203
        Me.UltraLabel32.Text = "Design Req'd"
        '
        'fmOrdSearch
        '
        Me.AcceptButton = Me.bSearch
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1404, 793)
        Me.Controls.Add(Me.UltraLabel32)
        Me.Controls.Add(Me.cbDesReq)
        Me.Controls.Add(Me.UltraLabel31)
        Me.Controls.Add(Me.tDesType)
        Me.Controls.Add(Me.UltraLabel26)
        Me.Controls.Add(Me.tCustOrd)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraLabel25)
        Me.Controls.Add(Me.tProdType)
        Me.Controls.Add(Me.tList)
        Me.Controls.Add(Me.UltraLabel24)
        Me.Controls.Add(Me.lNotes)
        Me.Controls.Add(Me.tNotes)
        Me.Controls.Add(Me.UltraLabel23)
        Me.Controls.Add(Me.tPart)
        Me.Controls.Add(Me.chQuotes)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.chRepl)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.tPO)
        Me.Controls.Add(Me.UltraButton3)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraLabel16)
        Me.Controls.Add(Me.tDesc)
        Me.Controls.Add(Me.bSearch)
        Me.Controls.Add(Me.chOrders)
        Me.Controls.Add(Me.UltraLabel13)
        Me.Controls.Add(Me.tTracking)
        Me.Controls.Add(Me.UltraLabel14)
        Me.Controls.Add(Me.tPayRef)
        Me.Controls.Add(Me.UltraLabel15)
        Me.Controls.Add(Me.tSecondary)
        Me.Controls.Add(Me.UltraLabel12)
        Me.Controls.Add(Me.tPrimary)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.tNumber)
        Me.Controls.Add(Me.Tab1)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.tTo)
        Me.Controls.Add(Me.tFrom)
        Me.Controls.Add(Me.lSearching)
        Me.KeyPreview = True
        Me.Name = "fmOrdSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search for Estimate/Order"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.tsold_city, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsold_country, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tSold_name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tSold_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsold_addr3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsold_Province, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsold_email, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsold_zip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsold_state, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsold_addr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsold_addr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsold_company, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.tship_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tship_country, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tship_city, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tship_addr3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tship_province, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tship_email, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tship_zip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tship_state, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tship_addr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tship_addr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tship_company, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tship_name, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl3.PerformLayout()
        CType(Me.tMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab1.ResumeLayout(False)
        CType(Me.tNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPrimary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTracking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPayRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tSecondary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chRepl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chQuotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tProdType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCustOrd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDesType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDesReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub fmOrdSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UltraLabel12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraLabel12.Click

    End Sub

    Private Sub bSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSearch.Click
        Try
            If bSearch.Text = "Search" Then
                bSearch.Enabled = False
                Grid1.Visible = False
                dsItm.Clear()
                Application.DoEvents()
                Dim cmd As New SqlCommand
                Dim Fields, Tables, Wherex, DisFields, WhereType As String
                Dim ct As Integer = 3

                If tNumber.Text <> "" Then
                    If IsNumeric(tNumber.Text) = False Then
                        MsgBox("Enter numbers only.", MsgBoxStyle.Information, "Numbers?")
                        bSearch.Enabled = True
                        Exit Sub
                    End If
                    Wherex = " and ord_gen_ord_serial=" + tNumber.Text
                Else
                    DisFields = ""
                    If tPrimary.Text <> "" Then
                        Wherex = Wherex + " and ord_for like '%" + Replace(tPrimary.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_for"
                        ct += 1
                    End If
                    If tSecondary.Text <> "" Then
                        Wherex = Wherex + " and ord_for2 like '%" + Replace(tSecondary.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_for2"
                        ct += 1
                    End If
                    If tDesc.Text <> "" Then
                        Wherex = Wherex + " and ord_itm_desc like '%" + Replace(tDesc.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_itm_desc"
                        ct += 1
                    End If
                    If tPart.Text <> "" Then
                        Wherex = Wherex + " and ord_itm_item_code like '" + Replace(tPart.Text, "'", "''") + "'"
                        DisFields = DisFields + ",ord_itm_item_code, ord_gen.ord_gen_type"
                        ct += 2
                    End If
                    If tProdType.Text <> "" Then
                        Wherex = Wherex + " and ord_itm_prod_type = '" + Replace(tProdType.Text, "'", "''") + "'"
                        DisFields = DisFields + ",ord_itm_prod_type, ord_gen.ord_gen_type"
                        ct += 2
                    End If
                    If tNotes.Text <> "" Then
                        Wherex = Wherex + " and ord_note like '%" + Replace(tNotes.Text, "'", "''") + "%'"
                        'DisFields = DisFields + ",ord_itm_item_code"
                    End If
                    If tSold_ID.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_cust_id like '" + Replace(tSold_ID.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_cust_id"
                        ct += 1
                    End If
                    If tSold_name.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_name like '%" + Replace(tSold_name.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_name"
                        ct += 1
                    End If
                    If tsold_company.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_company like '" + Replace(tsold_company.Text, "'", "''") + "%'"
                    End If
                    If tsold_country.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_country like '" + Replace(tsold_country.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_country"
                        ct += 1
                    End If
                    If tsold_addr1.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_addr1 like '" + Replace(tsold_addr1.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_addr1"
                        ct += 1
                    End If
                    If tsold_addr2.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_addr2 like '" + Replace(tsold_addr2.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_addr2"
                        ct += 1
                    End If
                    If tsold_addr3.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_addr3 like '" + Replace(tsold_addr3.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_addr3"
                        ct += 1
                    End If
                    If tsold_city.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_city like '" + Replace(tsold_city.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_city"
                        ct += 1
                    End If
                    If tsold_state.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_state like '" + Replace(tsold_state.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_state"
                        ct += 1
                    End If
                    If tsold_zip.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_zip like '" + Replace(tsold_zip.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_zip"
                        ct += 1
                    End If
                    If tsold_Province.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_province like '" + Replace(tsold_Province.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_province"
                        ct += 1
                    End If
                    If tSold_phone1.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_phone1 like '%" + Replace(tSold_phone1.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_phone1"
                        ct += 1
                    End If
                    If tsold_phone2.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_phone2 like '%" + Replace(tsold_phone2.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_phone2"
                        ct += 1
                    End If
                    If tsold_fax.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_fax like '%" + Replace(tsold_fax.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_fax"
                        ct += 1
                    End If
                    If tsold_cell.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_cell like '%" + Replace(tsold_cell.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_cell"
                        ct += 1
                    End If
                    If tsold_email.Text <> "" Then
                        Wherex = Wherex + " and ord_sold_email like '" + Replace(tsold_email.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_sold_email"
                        ct += 1
                    End If

                    If tship_id.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_cust_id like '" + Replace(tship_id.Text, "'", "''") + "%' or ord_alt_ship_cust_id like '" + Replace(tship_id.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_cust_id"
                        ct += 1
                    End If
                    If tship_name.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_name like '%" + Replace(tship_name.Text, "'", "''") + "%' or ord_alt_ship_name like '%" + Replace(tship_name.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_name"
                        ct += 1
                    End If
                    If tship_company.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_company like '" + Replace(tship_company.Text, "'", "''") + "%' or ord_alt_ship_company like '" + Replace(tship_company.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_company"
                        ct += 1
                    End If
                    If tship_country.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_country like '" + Replace(tship_country.Text, "'", "''") + "%' or ord_alt_ship_country like '" + Replace(tship_country.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_country"
                        ct += 1
                    End If
                    If tship_addr1.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_addr1 like '" + Replace(tship_addr1.Text, "'", "''") + "%' or ord_alt_ship_addr1 like '" + Replace(tship_addr1.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_addr1"
                        ct += 1
                    End If
                    If tship_addr2.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_addr2 like '" + Replace(tship_addr2.Text, "'", "''") + "%' or ord_alt_ship_addr2 like '" + Replace(tship_addr2.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_addr2"
                        ct += 1
                    End If
                    If tship_addr3.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_addr3 like '" + Replace(tship_addr3.Text, "'", "''") + "%' or ord_alt_ship_addr3 like '" + Replace(tship_addr3.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_addr3"
                        ct += 1
                    End If
                    If tship_city.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_city like '" + Replace(tship_city.Text, "'", "''") + "%' or ord_alt_ship_city like '" + Replace(tship_city.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_city"
                        ct += 1
                    End If
                    If tship_state.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_state like '" + Replace(tship_state.Text, "'", "''") + "%' or ord_alt_ship_state like '" + Replace(tship_state.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_state"
                        ct += 1
                    End If
                    If tship_zip.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_zip like '" + Replace(tship_zip.Text, "'", "''") + "%' or ord_alt_ship_zip like '" + Replace(tship_zip.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_zip"
                        ct += 1
                    End If
                    If tship_province.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_province like '" + Replace(tship_province.Text, "'", "''") + "%' or ord_alt_ship_province like '" + Replace(tship_province.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_province"
                        ct += 1
                    End If
                    If tship_phone1.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_phone1 like '%" + Replace(tship_phone1.Text, "'", "''") + "%' or ord_alt_ship_phone1 like '" + Replace(tship_phone1.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_phone1"
                        ct += 1
                    End If
                    If tship_phone2.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_phone2 like '%" + Replace(tship_phone2.Text, "'", "''") + "%' or ord_alt_ship_phone2 like '" + Replace(tship_phone2.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_phone2"
                        ct += 1
                    End If
                    If tship_fax.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_fax like '%" + Replace(tship_fax.Text, "'", "''") + "%' or ord_alt_ship_fax like '" + Replace(tship_fax.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_fax"
                        ct += 1
                    End If
                    If tship_cell.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_cell like '%" + Replace(tship_cell.Text, "'", "''") + "%' or ord_alt_ship_cell like '" + Replace(tship_cell.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_cell"
                        ct += 1
                    End If
                    If tship_email.Text <> "" Then
                        Wherex = Wherex + " and (ord_gen_ship_email like '" + Replace(tship_email.Text, "'", "''") + "%' or ord_alt_ship_email like '" + Replace(tship_email.Text, "'", "''") + "%')"
                        DisFields = DisFields + ",ord_gen_ship_email"
                        ct += 1
                    End If
                    If tPO.Text <> "" Then
                        Wherex = Wherex + " and ord_gen_cust_po like '%" + Replace(tPO.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_gen_cust_po"
                        ct += 1
                    End If
                    If tCustOrd.Text <> "" Then
                        Wherex = Wherex + " and ord_gen_cust_order like '%" + Replace(tCustOrd.Text, "'", "''") + "%'"
                        DisFields = DisFields + ",ord_gen_cust_order"
                        ct += 1
                    End If
                    If tTracking.Text <> "" Then
                        Wherex = Wherex + " and ship_track like '" + tTracking.Text + "'"
                        DisFields = DisFields + ",ship_track"
                        ct += 1
                    End If
                    If tDesType.Text <> "" Then
                        Wherex = Wherex + " and ord_gen_des_type = '" + tDesType.Text + "'"
                        DisFields = DisFields + ",ord_gen_des_type"
                        ct += 1
                    End If

                    If tFrom.Value <> CDate("1/1/1980") Then
                        Wherex = Wherex + " and ord_gen_show_date >= '" + tFrom.Text + "'"
                    End If
                    If tTo.Value <> CDate("12/31/2099") Then
                        Wherex = Wherex + " and ord_gen_show_date <= '" + tTo.Text + "'"
                    End If

                    If IsNumeric(tMin.Text) Then
                        Wherex = Wherex + " and ord_gen_total >= " + tMin.Text
                    End If
                    If IsNumeric(tMax.Text) Then
                        Wherex = Wherex + " and ord_gen_total <= " + tMax.Text
                    End If
                    If cbDesReq.Checked Then
                        Wherex += " and ord_gen_co_desreq=1"
                    End If

                    WhereType = " and ("
                    If chOrders.Checked = True Then
                        WhereType += "ord_gen_type='O' or "
                    End If
                    If chQuotes.Checked = True Then
                        WhereType += "ord_gen_type='Q' or "
                    End If
                    If chRepl.Checked = True Then
                        WhereType += "ord_gen_type='R' or "
                    End If
                    If WhereType.Length > 6 Then
                        WhereType = Mid(WhereType, 1, WhereType.Length - 4) + ")"
                    End If
                    Wherex += WhereType

                    If UserOSR <> "" And LCase(UserOSR) <> "brettn" And LCase(UserOSR) <> "erik" Then Wherex += " and ord_gen_outside='" + UserOSR + "'"
                End If

                'cmd.CommandText = "select distinct top " + tList.Text + " ord_gen_ord_serial,ord_sold_company,ord_sold_name" + DisFields + " from ord_gen " + IIf(tNotes.Text = "", "", "left outer join ord_note on ord_gen_serial=ord_note_ord_gen_serial") + ",ord_file left outer join ord_itm on ord_serial=ord_itm_ord_serial where ord_gen_ord_serial=ord_serial " + Wherex + " order by ord_gen_ord_serial desc"
                'cmd.CommandText = "select distinct top " + tList.Text + " ord_gen_ord_serial,ord_sold_company,ord_sold_name" + DisFields + " from ord_file, ord_gen " + IIf(tNotes.Text = "", "", "left outer join ord_note on ord_gen_serial=ord_note_ord_gen_serial") + " left outer join ship_file on ord_gen_ord_serial=ship_ord_serial and ord_gen_rev=ship_ord_rev and ord_gen_type=ship_ord_type,ord_itm  where ord_serial=ord_gen_ord_serial and ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_type=ord_itm_type and ord_gen_rev=ord_itm_rev " + Wherex + " order by ord_gen_ord_serial desc"
                cmd.CommandText = "select distinct top " + tList.Text + " ord_gen_ord_serial,ord_sold_company,ord_sold_name" + DisFields + " from ord_file, ord_gen " + IIf(tNotes.Text = "", "", "left outer join ord_note on ord_gen_serial=ord_note_ord_gen_serial") + " left outer join ord_alt_ship on ord_gen_ord_serial=ord_alt_ship_ord_serial and ord_gen_rev=ord_alt_ship_rev and ord_gen_type=ord_alt_ship_type left outer join ship_file on ord_gen_ord_serial=ship_ord_serial and ord_gen_rev=ship_ord_rev and ord_gen_type=ship_ord_type left outer join ord_itm on ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_type=ord_itm_type and ord_gen_rev=ord_itm_rev where ord_serial=ord_gen_ord_serial " + Wherex + " order by ord_gen_ord_serial desc"
                cmd.Connection = cnn
                da.SelectCommand = cmd
                ds = New DataSet
                cnn.Open()
                cmd.CommandTimeout = 50000
                da.Fill(ds, "ord")
                cnn.Close()
                Grid1.DataSource = ds.Tables("ord")
                Grid1.DataBind()
                ct = ct - 1
                Dim wd = Grid1.Width - 100
                Dim cwd = wd / ct
                Dim i As Integer
                Grid1.DisplayLayout.Bands(0).Columns(0).Width = 100
                For i = 1 To ct
                    Grid1.DisplayLayout.Bands(0).Columns(i).Width = cwd
                Next
                bSearch.Text = "Select"
                bSearch.Enabled = True
                Grid1.Visible = True
                If Grid1.Rows.Count > 0 Then Grid1.Rows(0).Selected = True
                Grid1.Focus()
            Else
                frm.KeyValue1 = Grid1.ActiveRow.Cells(0).Text
                Me.Hide()
            End If
        Catch
            DoError(Err, Me)
        End Try



    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub Grid1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Enter
        bSearch.Text = "Select"
    End Sub

    Private Sub Grid1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Leave
        If Me.ActiveControl.Name() <> "bSearch" Then bSearch.Text = "Search"
    End Sub

    Private Sub Grid1_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles Grid1.AfterSelectChange
    End Sub

    Private Sub Grid1_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterRowActivate
        Dim cmd As New SqlCommand
        Dim wheretype As String

        daItm.SelectCommand = cmd
        cmd.Connection = cnn

        wheretype = " and ("
        If chOrders.Checked = True Then
            wheretype += "ord_itm_type='O' or "
        End If
        If chQuotes.Checked = True Then
            wheretype += "ord_itm_type='Q' or "
        End If
        If chRepl.Checked = True Then
            wheretype += "ord_itm_type='R' or "
        End If
        If wheretype.Length > 6 Then
            wheretype = Mid(wheretype, 1, wheretype.Length - 4) + ")"
        End If

        'If chOrders.Checked = True Then
        'cmd.CommandText = "select ord_itm_type,ord_itm_rev,ord_itm_line,ord_itm_item_code,ord_itm_desc from ord_itm where ord_itm_ord_serial=" + Grid1.ActiveRow.Cells(0).Text + " and ord_itm_type='O' order by ord_itm_type,ord_itm_rev desc,ord_itm_line"
        'Else
        cmd.CommandText = "select ord_itm_type,ord_itm_rev,ord_itm_line,ord_itm_item_code,ord_itm_desc,ord_itm_qty,ord_itm_unt_sell,ord_itm_qty*ord_itm_unt_sell as itm_tot,ord_itm_qty*ord_itm_unt_ship as ship_tot from ord_itm where ord_itm_ord_serial=" + Grid1.ActiveRow.Cells(0).Text + wheretype + " order by ord_itm_type,ord_itm_rev desc,ord_itm_line"
        'End If
        dsItm.Clear()
        cnn.Open()
        cmd.CommandTimeout = 50000
        daItm.Fill(dsItm, "itm")
        Grid2.DataSource = dsItm
        Grid2.DataBind()

        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
        For Each rw In Grid2.Rows
            Select Case rw.Cells(0).Text
                Case "O"
                    rw.Appearance.BackColor = Color.AliceBlue
                    rw.Cells(0).Appearance.Image = GetIcon(rw)
                    'rw.Cells(0).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Image
                Case "Q"
                    rw.Appearance.BackColor = Color.LemonChiffon
                Case "R"
                    rw.Appearance.BackColor = Color.LightCoral
            End Select
        Next
        'cmd.CommandText = "select cont_call_center_rep_code from cont_file where cont_serial=" + tOrdContSerial.Text + " and cont_last_contact>='" + CStr(DateAdd(DateInterval.Day, -90, Today)) + "'"


        cnn.Close()
    End Sub
    Private Function GetIcon(ByRef rw As Infragistics.Win.UltraWinGrid.UltraGridRow) As Object
        Dim cmd As New SqlCommand("select * from ord_gen where ord_gen_ord_serial=" + Grid1.ActiveRow.Cells(0).Text + " and ord_gen_rev=" + rw.Cells("ord_itm_rev").Text + " and ord_gen_type='" + rw.Cells("ord_itm_type").Text + "'", cnn)
        Dim dr As SqlDataReader

        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If dr("ord_gen_type") = "O" Or dr("ord_gen_type") = "R" Then
                'If dr("ord_gen_balance") Is DBNull.Value Then dr("ord_gen_balance") = 0
                'If nz(dr("ord_gen_addon"), False) = True Then
                '    Tab1.ActiveTab.Appearance.BorderColor3DBase = Color.Yellow
                'Else
                '    Tab1.ActiveTab.Appearance.BorderColor3DBase = Nothing
                'End If
                Select Case dr("ord_gen_status")
                    Case "CANCELED"
                        'Tab1.ActiveTab.Appearance.BorderColor3DBase = Color.Red
                        'Tab1.ActiveTab.Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                        'Tab1.ActiveTab.Appearance.ForeColor = Color.Red
                        GetIcon = 9
                    Case "SHIPPED"
                        If nz(dr.Item("ord_gen_alt_ship"), False) = True Then
                            GetIcon = 7
                        Else
                            GetIcon = 3
                        End If
                    Case "STAGED"
                        If nz(dr("ord_gen_total"), 0) <> 0 And nz(dr("ord_gen_balance"), 0) = 0 Then
                            If nz(dr.Item("ord_gen_alt_ship"), False) = True Then
                                GetIcon = 5
                            Else
                                GetIcon = 1
                            End If
                        Else
                            If nz(dr.Item("ord_gen_alt_ship"), False) = True Then
                                GetIcon = 5
                            Else
                                GetIcon = 1
                            End If
                        End If
                    Case Else
                        If nz(dr("ord_gen_total"), 0) <> 0 And nz(dr("ord_gen_balance"), 0) <> nz(dr("ord_gen_total"), 0) And nz(dr("ord_gen_balance"), 0) <> 0 Then
                            If nz(dr.Item("ord_gen_alt_ship"), False) = True Then
                                GetIcon = 4
                            Else
                                GetIcon = 0
                            End If
                        End If
                        If nz(dr("ord_gen_balance"), 0) = nz(dr("ord_gen_total"), 0) Then
                            If nz(dr.Item("ord_gen_alt_ship"), False) = True Then
                                GetIcon = 8
                            Else
                                GetIcon = Nothing
                            End If
                        End If

                        If nz(dr("ord_gen_total"), 0) <> 0 Then
                            If nz(dr("ord_gen_balance"), 0) = dr("ord_gen_total") Then
                                If nz(dr.Item("ord_gen_alt_ship"), False) = True Then
                                    GetIcon = 8
                                Else
                                    GetIcon = Nothing
                                End If
                            Else
                                If nz(dr("ord_gen_balance"), 0) = 0 Then
                                    If nz(dr.Item("ord_gen_alt_ship"), False) = True Then
                                        GetIcon = 6
                                    Else
                                        GetIcon = 2
                                    End If
                                Else
                                    If nz(dr.Item("ord_gen_alt_ship"), False) = True Then
                                        GetIcon = 4
                                    Else
                                        GetIcon = 0
                                    End If
                                End If
                            End If
                        Else
                            If nz(dr("ord_gen_balance"), 0) = 0 Then
                                If nz(dr.Item("ord_gen_alt_ship"), False) = True Then
                                    GetIcon = 8
                                Else
                                    GetIcon = Nothing
                                End If
                            Else
                                If nz(dr.Item("ord_gen_alt_ship"), False) = True Then
                                    GetIcon = 4
                                Else
                                    GetIcon = 0
                                End If
                            End If
                        End If

                End Select
            Else
                GetIcon = Nothing
            End If
        Else
            GetIcon = Nothing
        End If
            dr.Close()
    End Function

    Private Sub bSearch_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles bSearch.Leave
        bSearch.Text = "Search"
    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        bSearch_Click(sender, e)
    End Sub


    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        bSearch.Enabled = False
        Grid1.Visible = False
        Application.DoEvents()
        Dim cmd As New SqlCommand
        Dim Fields, Tables, Wherex As String

        cmd.CommandText = "select distinct top " + tList.Text + " ord_gen_ord_serial,ord_sold_company,ord_sold_name from ord_gen,ord_file left outer join ord_itm on ord_serial=ord_itm_ord_serial where ord_gen_ord_serial=ord_serial order by ord_gen_ord_serial desc"
        cmd.Connection = cnn
        da.SelectCommand = cmd
        ds.Clear()
        cnn.Open()
        cmd.CommandTimeout = 50000
        da.Fill(ds, "ord")
        cnn.Close()
        Grid1.DataSource = ds.Tables("ord")
        Grid1.DataBind()

        bSearch.Text = "Select"
        bSearch.Enabled = True
        Grid1.Visible = True
        If Grid1.Rows.Count > 0 Then Grid1.Rows(0).Selected = True
        Grid1.Focus()
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        Dim ct As Control
        For Each ct In Me.Controls
            If ct.GetType Is GetType(Infragistics.Win.UltraWinEditors.UltraTextEditor) Then
                If ct.Name <> "tList" Then ct.Text = ""
            End If
        Next

        For Each ct In Tab1.Tabs(0).TabPage.Controls
            If ct.GetType Is GetType(Infragistics.Win.UltraWinEditors.UltraTextEditor) Or ct.GetType Is GetType(Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit) Then
                ct.Text = ""
            End If
        Next
        For Each ct In Tab1.Tabs(1).TabPage.Controls
            If ct.GetType Is GetType(Infragistics.Win.UltraWinEditors.UltraTextEditor) Or ct.GetType Is GetType(Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit) Then
                ct.Text = ""
            End If
        Next
        tFrom.Value = CDate("1/1/1980")
        tTo.Value = CDate("12/31/2099")
        ds.Clear()
        dsItm.Clear()
    End Sub

    Private Sub fmOrdSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            UltraButton3_Click(sender, e)
        End If
    End Sub

    Private Sub tNumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tNumber.ValueChanged

    End Sub

    Private Sub tNumber_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tNumber.KeyUp

    End Sub

    Private Sub tNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tNumber.KeyPress

    End Sub

    Private Sub tNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tNumber.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                UltraButton2_Click(sender, e)
            Case Keys.F4
                UltraButton1_Click(sender, e)
        End Select

    End Sub

    Private Sub tDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lNotes.Click

    End Sub

    Private Sub tList_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tList.ValueChanged

    End Sub

    Private Sub tList_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tList.Leave
        If Not IsNumeric(tList.Text) Then tList.Text = "200"
    End Sub

    Private Sub tPart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPart.ValueChanged

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        bSearch.Enabled = False
        Grid1.Visible = False
        Application.DoEvents()
        Dim cmd As New SqlCommand
        Dim Fields, Tables, Wherex As String

        cmd.CommandText = "select distinct ord_gen_ord_serial,ord_sold_company,ord_sold_name,ord_recent_when,ord_recent_no from ord_gen,ord_file left outer join ord_itm on ord_serial=ord_itm_ord_serial,ord_recent where ord_gen_ord_serial=ord_serial and ord_gen_ord_serial=ord_recent_ord_serial and ord_recent_user='" + User + "' order by ord_recent_no"
        cmd.Connection = cnn
        da.SelectCommand = cmd
        ds.Clear()
        cnn.Open()
        da.Fill(ds, "ord")
        cnn.Close()
        Grid1.DataSource = ds.Tables("ord")
        Grid1.DataBind()
        bSearch.Text = "Select"
        bSearch.Enabled = True
        Grid1.Visible = True
        If Grid1.Rows.Count > 0 Then Grid1.Rows(0).Selected = True
        Grid1.Focus()

    End Sub
End Class
