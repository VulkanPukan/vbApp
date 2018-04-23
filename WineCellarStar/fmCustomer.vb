Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class fmCustomer
    Inherits WineCellar.fmStarter
    Dim daItemPrices As New SqlDataAdapter
    Dim dsItemPrices As New DataSet
    Dim daDiscounts As New SqlDataAdapter
    Dim dsDiscounts As New DataSet
    Dim daItemProdMar As New SqlDataAdapter
    Dim daThirdParty As New SqlDataAdapter
    Dim dsItemProdMar As New DataSet
    Dim dsZip As New DataSet
    Dim dsTerms As New DataSet
    Dim dsContacts As New DataSet
    Dim dsThirdParty As New DataSet
    Dim daContacts As New SqlDataAdapter
    Dim dsRep As New DataSet
    Dim dsCat As New DataSet
    Dim dsCountry As New DataSet
    Dim dsBillDay As New DataSet
    Dim onZip, onState, onCounty As String
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tSpecialNotes As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tDealerReq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tBillableEmails As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents bResendEmail As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tEmailBody As System.Windows.Forms.WebBrowser
    Friend WithEvents gEmails As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tAttach1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tAttach2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor10 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Dim onEmailReceipts As Boolean
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
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents cust_serial As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tCust_ID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor15 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraCheckEditor1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbBillable As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraCheckEditor4 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTextEditor4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Grid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tState As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraCheckEditor5 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tCopyFrom As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tCopyFromPrice As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor9 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tTerms As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Grid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tCat As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tRep As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tCounty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tAddr1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tAddr2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tAddr3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lAddr1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lAddr2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lAddr3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lZip As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lCounty As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lProvince As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tProvince As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tZip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tCity As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents taltphone As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tfax As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tphone2 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tphone1 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tcell As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tCountry As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tBillDay As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tTaxExempt As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chVendorNet As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chCurrentPrice As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents tFilter As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraCheckEditor2 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbThirdParty As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraCheckEditor6 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tCommSplit As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tTerr As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tNotes As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTextEditor5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents bDocPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Docs As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cbEmailReceipts As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTextEditor6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cbEmailShipments As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grThirdParty As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grDiscounts As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tEmailProd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cbEmailProd As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraCheckEditor7 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_prod_mar_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_prod_mar_cust_serial")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_prod_mar_cust_id")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_prod_mar_type")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_prod_mar_from")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_prod_mar_to")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_prod_mar_margin")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_prod_mar_start")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_prod_mar_end")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_itm_price_serial")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_itm_price_cust_serial")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_itm_price_cust_id")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_itm_price_itm_code")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_itm_price_from")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_itm_price_to")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_itm_price_price")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_itm_price_start")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_itm_price_end")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_cont_serial")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_cont_cust_serial")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_cont_name")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_cont_type")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_cont_email")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_cont_email_shipment")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_cont_signoff_not_rec")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_cont_phone")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Override1 As Infragistics.Win.UltraWinTree.Override = New Infragistics.Win.UltraWinTree.Override()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_ship_serial")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_ship_cust_serial")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_ship_name")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_ship_via")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_ship_acct")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_ship_default")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_disc_serial")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_disc_cust_serial")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_disc_cust_id")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_disc_itm_code")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_disc_prod_type")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_disc_perc")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_disc_start")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_disc_end")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_disc_note")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmCustomer))
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("es_serial")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("es_date")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("es_to")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("es_from")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("es_type")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("es_email")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("es_ord_serial")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("es_ord_rev")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("es_ord_type")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("es_cust_serial")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tNotes = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.tCopyFrom = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.Grid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.tFilter = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chCurrentPrice = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.tCopyFromPrice = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Docs = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.bDocPrint = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grThirdParty = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grDiscounts = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tSpecialNotes = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tDealerReq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tAttach2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tAttach1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton()
        Me.bResendEmail = New Infragistics.Win.Misc.UltraButton()
        Me.tEmailBody = New System.Windows.Forms.WebBrowser()
        Me.gEmails = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.cust_serial = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.tCust_ID = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTextEditor3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.tAddr1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tAddr2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tAddr3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tState = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lAddr1 = New Infragistics.Win.Misc.UltraLabel()
        Me.lAddr2 = New Infragistics.Win.Misc.UltraLabel()
        Me.lAddr3 = New Infragistics.Win.Misc.UltraLabel()
        Me.lZip = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.taltphone = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.tfax = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.tphone2 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.tphone1 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraTextEditor15 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraCheckEditor1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.tTaxExempt = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cbBillable = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraCheckEditor4 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTextEditor4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTextEditor8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraCheckEditor5 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTextEditor9 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.tcell = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.tTerms = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.tRep = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.tCat = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.tCountry = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lCounty = New Infragistics.Win.Misc.UltraLabel()
        Me.tCounty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lProvince = New Infragistics.Win.Misc.UltraLabel()
        Me.tProvince = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tZip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tCity = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.tBillDay = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.chVendorNet = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraCheckEditor2 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cbThirdParty = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraCheckEditor6 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.tCommSplit = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tTerr = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbEmailReceipts = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTextEditor5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTextEditor6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cbEmailShipments = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.tEmailProd = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cbEmailProd = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraCheckEditor7 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.tBillableEmails = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTextEditor10 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.tNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.tCopyFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.tFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chCurrentPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCopyFromPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.Docs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.grThirdParty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.grDiscounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.tSpecialNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.tDealerReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.gEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cust_serial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCust_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAddr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAddr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAddr3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTaxExempt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBillable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.UltraTextEditor8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCounty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tProvince, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tZip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBillDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chVendorNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbThirdParty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCommSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTerr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmailReceipts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmailShipments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tEmailProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmailProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBillableEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.tNotes)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 29)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1266, 354)
        '
        'tNotes
        '
        Me.tNotes.AcceptsReturn = True
        Me.tNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tNotes.Enabled = False
        Me.tNotes.Location = New System.Drawing.Point(10, 9)
        Me.tNotes.Multiline = True
        Me.tNotes.Name = "tNotes"
        Me.tNotes.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.tNotes.Size = New System.Drawing.Size(1248, 338)
        Me.tNotes.TabIndex = 26
        Me.tNotes.Tag = "edit;cust_notes"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton1)
        Me.UltraTabPageControl2.Controls.Add(Me.tCopyFrom)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel19)
        Me.UltraTabPageControl2.Controls.Add(Me.Grid2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-12000, -11538)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1266, 354)
        '
        'UltraButton1
        '
        Me.UltraButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton1.Enabled = False
        Me.UltraButton1.Location = New System.Drawing.Point(365, 321)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(96, 28)
        Me.UltraButton1.TabIndex = 65
        Me.UltraButton1.Tag = "Edit"
        Me.UltraButton1.Text = "Copy"
        '
        'tCopyFrom
        '
        Me.tCopyFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tCopyFrom.Enabled = False
        Me.tCopyFrom.Location = New System.Drawing.Point(221, 321)
        Me.tCopyFrom.Name = "tCopyFrom"
        Me.tCopyFrom.Size = New System.Drawing.Size(125, 28)
        Me.tCopyFrom.TabIndex = 64
        Me.tCopyFrom.Tag = "Edit"
        '
        'UltraLabel19
        '
        Me.UltraLabel19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel19.BackColorInternal = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UltraLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(10, 321)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(201, 28)
        Me.UltraLabel19.TabIndex = 63
        Me.UltraLabel19.Text = "Copy from Customer ID"
        '
        'Grid2
        '
        Me.Grid2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid2.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.Grid2.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Product Type"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.Caption = "From Qty"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.Caption = "To Qty"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Format = "####%"
        UltraGridColumn7.Header.Caption = "Margin"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.MaskInput = ""
        UltraGridColumn8.Header.Caption = "Start Date"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.Caption = "End Date"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        UltraGridBand1.Override.RowSpacingAfter = 0
        UltraGridBand1.Override.RowSpacingBefore = 0
        Me.Grid2.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid2.DisplayLayout.InterBandSpacing = 10
        Me.Grid2.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.Grid2.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid2.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.Grid2.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Grid2.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance3.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Me.Grid2.DisplayLayout.Override.CellAppearance = Appearance3
        Me.Grid2.DisplayLayout.Override.CellSpacing = 3
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance4.FontData.Name = "Verdana"
        Appearance4.ForeColor = System.Drawing.Color.Black
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid2.DisplayLayout.Override.HeaderAppearance = Appearance4
        Me.Grid2.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Grid2.DisplayLayout.Override.RowAppearance = Appearance5
        Appearance58.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Grid2.DisplayLayout.Override.RowSelectorAppearance = Appearance58
        Me.Grid2.DisplayLayout.Override.RowSelectorWidth = 10
        Me.Grid2.DisplayLayout.Override.RowSpacingAfter = 3
        Me.Grid2.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance81.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance81.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.Grid2.DisplayLayout.Override.SelectedRowAppearance = Appearance81
        Me.Grid2.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.Grid2.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid2.Location = New System.Drawing.Point(0, 0)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(1269, 317)
        Me.Grid2.TabIndex = 62
        Me.Grid2.Tag = ""
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl3.Controls.Add(Me.tFilter)
        Me.UltraTabPageControl3.Controls.Add(Me.chCurrentPrice)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraButton2)
        Me.UltraTabPageControl3.Controls.Add(Me.tCopyFromPrice)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraLabel20)
        Me.UltraTabPageControl3.Controls.Add(Me.Grid1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-12000, -11538)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1266, 354)
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel5.BackColorInternal = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(778, 321)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(57, 28)
        Me.UltraLabel5.TabIndex = 71
        Me.UltraLabel5.Text = "Filter"
        '
        'tFilter
        '
        Me.tFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tFilter.Location = New System.Drawing.Point(845, 321)
        Me.tFilter.Name = "tFilter"
        Me.tFilter.Size = New System.Drawing.Size(125, 28)
        Me.tFilter.TabIndex = 70
        Me.tFilter.Tag = ""
        '
        'chCurrentPrice
        '
        Me.chCurrentPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chCurrentPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.chCurrentPrice.BackColorInternal = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.chCurrentPrice.Checked = True
        Me.chCurrentPrice.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chCurrentPrice.Location = New System.Drawing.Point(538, 321)
        Me.chCurrentPrice.Name = "chCurrentPrice"
        Me.chCurrentPrice.Size = New System.Drawing.Size(182, 19)
        Me.chCurrentPrice.TabIndex = 69
        Me.chCurrentPrice.Text = "Current Pricing Only"
        '
        'UltraButton2
        '
        Me.UltraButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton2.Enabled = False
        Me.UltraButton2.Location = New System.Drawing.Point(365, 321)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(96, 28)
        Me.UltraButton2.TabIndex = 68
        Me.UltraButton2.Tag = "Edit"
        Me.UltraButton2.Text = "Copy"
        '
        'tCopyFromPrice
        '
        Me.tCopyFromPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tCopyFromPrice.Enabled = False
        Me.tCopyFromPrice.Location = New System.Drawing.Point(221, 321)
        Me.tCopyFromPrice.Name = "tCopyFromPrice"
        Me.tCopyFromPrice.Size = New System.Drawing.Size(125, 28)
        Me.tCopyFromPrice.TabIndex = 67
        Me.tCopyFromPrice.Tag = "Edit"
        '
        'UltraLabel20
        '
        Me.UltraLabel20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel20.BackColorInternal = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(10, 321)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(201, 28)
        Me.UltraLabel20.TabIndex = 66
        Me.UltraLabel20.Text = "Copy from Customer ID"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance82.BackColor = System.Drawing.Color.Gainsboro
        Appearance82.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.Grid1.DisplayLayout.Appearance = Appearance82
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Item Code"
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn14.Header.Caption = "From Qty"
        UltraGridColumn14.Header.VisiblePosition = 4
        UltraGridColumn15.Header.Caption = "To Qty"
        UltraGridColumn15.Header.VisiblePosition = 5
        UltraGridColumn16.Format = "$###,###,##0.00"
        UltraGridColumn16.Header.Caption = "Price"
        UltraGridColumn16.Header.VisiblePosition = 6
        UltraGridColumn16.MaskInput = ""
        UltraGridColumn17.Header.Caption = "Start Date"
        UltraGridColumn17.Header.VisiblePosition = 7
        UltraGridColumn18.Header.Caption = "End Date"
        UltraGridColumn18.Header.VisiblePosition = 8
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        UltraGridBand2.Override.RowSpacingAfter = 0
        UltraGridBand2.Override.RowSpacingBefore = 0
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.Grid1.DisplayLayout.InterBandSpacing = 10
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.Grid1.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.CardAreaAppearance = Appearance83
        Appearance84.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance84.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Me.Grid1.DisplayLayout.Override.CellAppearance = Appearance84
        Me.Grid1.DisplayLayout.Override.CellSpacing = 3
        Appearance85.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance85.FontData.Name = "Verdana"
        Appearance85.ForeColor = System.Drawing.Color.Black
        Appearance85.TextHAlignAsString = "Left"
        Appearance85.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid1.DisplayLayout.Override.HeaderAppearance = Appearance85
        Me.Grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.RowAppearance = Appearance86
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Grid1.DisplayLayout.Override.RowSelectorAppearance = Appearance13
        Me.Grid1.DisplayLayout.Override.RowSelectorWidth = 10
        Me.Grid1.DisplayLayout.Override.RowSpacingAfter = 3
        Me.Grid1.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.Grid1.DisplayLayout.Override.SelectedRowAppearance = Appearance14
        Me.Grid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1261, 317)
        Me.Grid1.TabIndex = 61
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Grid3)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-12000, -11538)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1266, 354)
        '
        'Grid3
        '
        Me.Grid3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance10.BackColor = System.Drawing.Color.Gainsboro
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.Grid3.DisplayLayout.Appearance = Appearance10
        Me.Grid3.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.Caption = "Name"
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Width = 132
        UltraGridColumn22.Header.Caption = "Type"
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridColumn22.Width = 432
        UltraGridColumn23.Header.Caption = "Email"
        UltraGridColumn23.Header.VisiblePosition = 4
        UltraGridColumn23.Width = 266
        UltraGridColumn24.Header.Caption = "Email Ship Notifications"
        UltraGridColumn24.Header.VisiblePosition = 5
        UltraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn24.Width = 179
        UltraGridColumn25.Header.Caption = "Email Signoff Not Rec"
        UltraGridColumn25.Header.VisiblePosition = 6
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn25.Width = 192
        UltraGridColumn26.Header.Caption = "Phone"
        UltraGridColumn26.Header.VisiblePosition = 7
        UltraGridColumn26.Width = 284
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        UltraGridBand3.Override.RowSpacingAfter = 0
        UltraGridBand3.Override.RowSpacingBefore = 0
        Me.Grid3.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.Grid3.DisplayLayout.InterBandSpacing = 10
        Me.Grid3.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.Grid3.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid3.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid3.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.Grid3.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.Grid3.DisplayLayout.Override.CardAreaAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance12.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Me.Grid3.DisplayLayout.Override.CellAppearance = Appearance12
        Me.Grid3.DisplayLayout.Override.CellSpacing = 3
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance35.FontData.Name = "Verdana"
        Appearance35.ForeColor = System.Drawing.Color.Black
        Appearance35.TextHAlignAsString = "Left"
        Appearance35.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid3.DisplayLayout.Override.HeaderAppearance = Appearance35
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Me.Grid3.DisplayLayout.Override.RowAppearance = Appearance38
        Appearance41.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Grid3.DisplayLayout.Override.RowSelectorAppearance = Appearance41
        Me.Grid3.DisplayLayout.Override.RowSelectorWidth = 10
        Me.Grid3.DisplayLayout.Override.RowSpacingAfter = 3
        Me.Grid3.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance44.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance44.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.Grid3.DisplayLayout.Override.SelectedRowAppearance = Appearance44
        Me.Grid3.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.Grid3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid3.Location = New System.Drawing.Point(2, 0)
        Me.Grid3.Name = "Grid3"
        Me.Grid3.Size = New System.Drawing.Size(1261, 358)
        Me.Grid3.TabIndex = 62
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Docs)
        Me.UltraTabPageControl5.Controls.Add(Me.bDocPrint)
        Me.UltraTabPageControl5.Controls.Add(Me.UltraButton3)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-12000, -11538)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1266, 354)
        '
        'Docs
        '
        Me.Docs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Docs.HideSelection = False
        Me.Docs.Location = New System.Drawing.Point(0, 0)
        Me.Docs.Name = "Docs"
        Override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Extended
        Me.Docs.Override = Override1
        Me.Docs.Size = New System.Drawing.Size(1269, 294)
        Me.Docs.TabIndex = 92
        '
        'bDocPrint
        '
        Me.bDocPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bDocPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDocPrint.Location = New System.Drawing.Point(240, 303)
        Me.bDocPrint.Name = "bDocPrint"
        Me.bDocPrint.Size = New System.Drawing.Size(211, 37)
        Me.bDocPrint.TabIndex = 11
        Me.bDocPrint.Text = "Print"
        '
        'UltraButton3
        '
        Me.UltraButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton3.Location = New System.Drawing.Point(19, 303)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(211, 37)
        Me.UltraButton3.TabIndex = 8
        Me.UltraButton3.Text = "eMail"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.grThirdParty)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-12000, -11538)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1266, 354)
        '
        'grThirdParty
        '
        Me.grThirdParty.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance22.BackColor = System.Drawing.Color.Gainsboro
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.grThirdParty.DisplayLayout.Appearance = Appearance22
        Me.grThirdParty.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.Width = 160
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.Width = 228
        UltraGridColumn29.Header.Caption = "Name"
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn29.Width = 468
        UltraGridColumn30.Header.Caption = "Ship Via"
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn30.Width = 470
        UltraGridColumn31.Header.Caption = "Account Number"
        UltraGridColumn31.Header.VisiblePosition = 4
        UltraGridColumn31.Width = 447
        UltraGridColumn32.Header.Caption = "Default"
        UltraGridColumn32.Header.VisiblePosition = 5
        UltraGridColumn32.MaxWidth = 100
        UltraGridColumn32.MinWidth = 75
        UltraGridColumn32.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn32.Width = 100
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32})
        UltraGridBand4.Override.RowSpacingAfter = 0
        UltraGridBand4.Override.RowSpacingBefore = 0
        Me.grThirdParty.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.grThirdParty.DisplayLayout.InterBandSpacing = 10
        Me.grThirdParty.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grThirdParty.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.grThirdParty.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grThirdParty.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.grThirdParty.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Me.grThirdParty.DisplayLayout.Override.CardAreaAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance24.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Me.grThirdParty.DisplayLayout.Override.CellAppearance = Appearance24
        Me.grThirdParty.DisplayLayout.Override.CellSpacing = 3
        Appearance25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance25.FontData.Name = "Verdana"
        Appearance25.ForeColor = System.Drawing.Color.Black
        Appearance25.TextHAlignAsString = "Left"
        Appearance25.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.grThirdParty.DisplayLayout.Override.HeaderAppearance = Appearance25
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Me.grThirdParty.DisplayLayout.Override.RowAppearance = Appearance26
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grThirdParty.DisplayLayout.Override.RowSelectorAppearance = Appearance27
        Me.grThirdParty.DisplayLayout.Override.RowSelectorWidth = 10
        Me.grThirdParty.DisplayLayout.Override.RowSpacingAfter = 3
        Me.grThirdParty.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance28.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.grThirdParty.DisplayLayout.Override.SelectedRowAppearance = Appearance28
        Me.grThirdParty.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.grThirdParty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grThirdParty.Location = New System.Drawing.Point(2, -2)
        Me.grThirdParty.Name = "grThirdParty"
        Me.grThirdParty.Size = New System.Drawing.Size(1261, 358)
        Me.grThirdParty.TabIndex = 63
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.grDiscounts)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-12000, -11538)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1266, 354)
        '
        'grDiscounts
        '
        Me.grDiscounts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grDiscounts.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance29.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance29.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.grDiscounts.DisplayLayout.Appearance = Appearance29
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 1
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 2
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn36.Header.Caption = "Item Code"
        UltraGridColumn36.Header.VisiblePosition = 3
        UltraGridColumn37.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn37.Header.Caption = "Prod Type"
        UltraGridColumn37.Header.VisiblePosition = 4
        UltraGridColumn38.Header.Caption = "Perc (%)"
        UltraGridColumn38.Header.VisiblePosition = 5
        UltraGridColumn39.Header.Caption = "Start"
        UltraGridColumn39.Header.VisiblePosition = 6
        UltraGridColumn40.Header.Caption = "End"
        UltraGridColumn40.Header.VisiblePosition = 7
        UltraGridColumn41.Header.Caption = "Note"
        UltraGridColumn41.Header.VisiblePosition = 8
        UltraGridColumn41.Width = 442
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41})
        UltraGridBand5.Override.RowSpacingAfter = 0
        UltraGridBand5.Override.RowSpacingBefore = 0
        Me.grDiscounts.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.grDiscounts.DisplayLayout.InterBandSpacing = 10
        Me.grDiscounts.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grDiscounts.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.grDiscounts.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grDiscounts.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.grDiscounts.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Me.grDiscounts.DisplayLayout.Override.CardAreaAppearance = Appearance30
        Appearance31.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance31.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Me.grDiscounts.DisplayLayout.Override.CellAppearance = Appearance31
        Me.grDiscounts.DisplayLayout.Override.CellSpacing = 3
        Appearance32.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance32.FontData.Name = "Verdana"
        Appearance32.ForeColor = System.Drawing.Color.Black
        Appearance32.TextHAlignAsString = "Left"
        Appearance32.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.grDiscounts.DisplayLayout.Override.HeaderAppearance = Appearance32
        Me.grDiscounts.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Me.grDiscounts.DisplayLayout.Override.RowAppearance = Appearance33
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grDiscounts.DisplayLayout.Override.RowSelectorAppearance = Appearance34
        Me.grDiscounts.DisplayLayout.Override.RowSelectorWidth = 10
        Me.grDiscounts.DisplayLayout.Override.RowSpacingAfter = 3
        Me.grDiscounts.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance87.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance87.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.grDiscounts.DisplayLayout.Override.SelectedRowAppearance = Appearance87
        Me.grDiscounts.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.grDiscounts.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grDiscounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grDiscounts.Location = New System.Drawing.Point(0, 0)
        Me.grDiscounts.Name = "grDiscounts"
        Me.grDiscounts.Size = New System.Drawing.Size(1269, 349)
        Me.grDiscounts.TabIndex = 63
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.Label1)
        Me.UltraTabPageControl8.Controls.Add(Me.tSpecialNotes)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-12000, -11538)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1266, 354)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(743, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "These notes will be added to new quotes and orders in the Special Notes area on t" & _
    "he General Tab:"
        '
        'tSpecialNotes
        '
        Me.tSpecialNotes.AcceptsReturn = True
        Me.tSpecialNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tSpecialNotes.Enabled = False
        Me.tSpecialNotes.Location = New System.Drawing.Point(8, 33)
        Me.tSpecialNotes.Multiline = True
        Me.tSpecialNotes.Name = "tSpecialNotes"
        Me.tSpecialNotes.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.tSpecialNotes.Size = New System.Drawing.Size(1249, 311)
        Me.tSpecialNotes.TabIndex = 27
        Me.tSpecialNotes.Tag = "edit;cust_special_notes"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.tDealerReq)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-12000, -11538)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1266, 354)
        '
        'tDealerReq
        '
        Me.tDealerReq.AcceptsReturn = True
        Me.tDealerReq.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tDealerReq.Enabled = False
        Me.tDealerReq.Location = New System.Drawing.Point(8, 8)
        Me.tDealerReq.Multiline = True
        Me.tDealerReq.Name = "tDealerReq"
        Me.tDealerReq.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.tDealerReq.Size = New System.Drawing.Size(1249, 336)
        Me.tDealerReq.TabIndex = 27
        Me.tDealerReq.Tag = "edit;cust_dealer_req"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.tAttach2)
        Me.UltraTabPageControl10.Controls.Add(Me.tAttach1)
        Me.UltraTabPageControl10.Controls.Add(Me.UltraButton4)
        Me.UltraTabPageControl10.Controls.Add(Me.bResendEmail)
        Me.UltraTabPageControl10.Controls.Add(Me.tEmailBody)
        Me.UltraTabPageControl10.Controls.Add(Me.gEmails)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-12000, -11538)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1266, 354)
        '
        'tAttach2
        '
        Appearance6.FontData.SizeInPoints = 8.0!
        Appearance6.FontData.UnderlineAsString = "True"
        Appearance6.ForeColor = System.Drawing.Color.Blue
        Appearance6.Image = "pdficon.png"
        Me.tAttach2.Appearance = Appearance6
        Me.tAttach2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tAttach2.ImageList = Me.ImageList1
        Me.tAttach2.Location = New System.Drawing.Point(646, 3)
        Me.tAttach2.Name = "tAttach2"
        Me.tAttach2.Size = New System.Drawing.Size(312, 18)
        Me.tAttach2.TabIndex = 8
        Me.tAttach2.Text = "Attachment.pdf"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "pdficon.png")
        '
        'tAttach1
        '
        Appearance7.FontData.SizeInPoints = 8.0!
        Appearance7.FontData.UnderlineAsString = "True"
        Appearance7.ForeColor = System.Drawing.Color.Blue
        Appearance7.Image = "pdficon.png"
        Me.tAttach1.Appearance = Appearance7
        Me.tAttach1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tAttach1.ImageList = Me.ImageList1
        Me.tAttach1.Location = New System.Drawing.Point(426, 3)
        Me.tAttach1.Name = "tAttach1"
        Me.tAttach1.Size = New System.Drawing.Size(215, 18)
        Me.tAttach1.TabIndex = 7
        Me.tAttach1.Text = "Attachment.pdf"
        '
        'UltraButton4
        '
        Me.UltraButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton4.Location = New System.Drawing.Point(348, 320)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(68, 31)
        Me.UltraButton4.TabIndex = 6
        Me.UltraButton4.Text = "Back"
        '
        'bResendEmail
        '
        Me.bResendEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bResendEmail.Location = New System.Drawing.Point(2, 322)
        Me.bResendEmail.Name = "bResendEmail"
        Me.bResendEmail.Size = New System.Drawing.Size(162, 32)
        Me.bResendEmail.TabIndex = 5
        Me.bResendEmail.Text = "Resend Email"
        '
        'tEmailBody
        '
        Me.tEmailBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tEmailBody.Location = New System.Drawing.Point(422, 21)
        Me.tEmailBody.MinimumSize = New System.Drawing.Size(20, 20)
        Me.tEmailBody.Name = "tEmailBody"
        Me.tEmailBody.Size = New System.Drawing.Size(841, 330)
        Me.tEmailBody.TabIndex = 4
        '
        'gEmails
        '
        Me.gEmails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance92.BackColor = System.Drawing.SystemColors.Window
        Appearance92.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gEmails.DisplayLayout.Appearance = Appearance92
        UltraGridColumn42.Header.VisiblePosition = 0
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.Caption = "Date"
        UltraGridColumn43.Header.VisiblePosition = 1
        UltraGridColumn44.Header.Caption = "To"
        UltraGridColumn44.Header.VisiblePosition = 2
        UltraGridColumn45.Header.Caption = "From"
        UltraGridColumn45.Header.VisiblePosition = 3
        UltraGridColumn46.Header.VisiblePosition = 4
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 5
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 6
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 7
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 8
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 9
        UltraGridColumn51.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51})
        Me.gEmails.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.gEmails.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gEmails.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance93.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance93.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance93.BorderColor = System.Drawing.SystemColors.Window
        Me.gEmails.DisplayLayout.GroupByBox.Appearance = Appearance93
        Appearance94.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gEmails.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance94
        Me.gEmails.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance95.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance95.BackColor2 = System.Drawing.SystemColors.Control
        Appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance95.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gEmails.DisplayLayout.GroupByBox.PromptAppearance = Appearance95
        Me.gEmails.DisplayLayout.MaxColScrollRegions = 1
        Me.gEmails.DisplayLayout.MaxRowScrollRegions = 1
        Appearance96.BackColor = System.Drawing.SystemColors.Window
        Appearance96.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gEmails.DisplayLayout.Override.ActiveCellAppearance = Appearance96
        Appearance97.BackColor = System.Drawing.SystemColors.Highlight
        Appearance97.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.gEmails.DisplayLayout.Override.ActiveRowAppearance = Appearance97
        Me.gEmails.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gEmails.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance98.BackColor = System.Drawing.SystemColors.Window
        Me.gEmails.DisplayLayout.Override.CardAreaAppearance = Appearance98
        Appearance99.BorderColor = System.Drawing.Color.Silver
        Appearance99.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.gEmails.DisplayLayout.Override.CellAppearance = Appearance99
        Me.gEmails.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gEmails.DisplayLayout.Override.CellPadding = 0
        Appearance100.BackColor = System.Drawing.SystemColors.Control
        Appearance100.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance100.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance100.BorderColor = System.Drawing.SystemColors.Window
        Me.gEmails.DisplayLayout.Override.GroupByRowAppearance = Appearance100
        Appearance101.TextHAlignAsString = "Left"
        Me.gEmails.DisplayLayout.Override.HeaderAppearance = Appearance101
        Me.gEmails.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gEmails.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance102.BackColor = System.Drawing.SystemColors.Window
        Appearance102.BorderColor = System.Drawing.Color.Silver
        Me.gEmails.DisplayLayout.Override.RowAppearance = Appearance102
        Me.gEmails.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance103.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gEmails.DisplayLayout.Override.TemplateAddRowAppearance = Appearance103
        Me.gEmails.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gEmails.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gEmails.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.gEmails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gEmails.Location = New System.Drawing.Point(-4, 3)
        Me.gEmails.Name = "gEmails"
        Me.gEmails.Size = New System.Drawing.Size(420, 314)
        Me.gEmails.TabIndex = 3
        '
        'cust_serial
        '
        Me.cust_serial.Enabled = False
        Me.cust_serial.Location = New System.Drawing.Point(125, 9)
        Me.cust_serial.Name = "cust_serial"
        Me.cust_serial.Size = New System.Drawing.Size(144, 24)
        Me.cust_serial.TabIndex = 0
        Me.cust_serial.Tag = "key;cust_serial;nm"
        '
        'UltraLabel1
        '
        Appearance36.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel1.Appearance = Appearance36
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(10, 9)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(67, 19)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Serial"
        '
        'tCust_ID
        '
        Me.tCust_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tCust_ID.Enabled = False
        Me.tCust_ID.Location = New System.Drawing.Point(125, 37)
        Me.tCust_ID.Name = "tCust_ID"
        Me.tCust_ID.Size = New System.Drawing.Size(144, 24)
        Me.tCust_ID.TabIndex = 1
        Me.tCust_ID.Tag = "edit;cust_id"
        '
        'UltraTextEditor3
        '
        Me.UltraTextEditor3.Enabled = False
        Me.UltraTextEditor3.Location = New System.Drawing.Point(125, 102)
        Me.UltraTextEditor3.Name = "UltraTextEditor3"
        Me.UltraTextEditor3.Size = New System.Drawing.Size(278, 24)
        Me.UltraTextEditor3.TabIndex = 3
        Me.UltraTextEditor3.Tag = "edit;cust_name"
        '
        'UltraLabel2
        '
        Appearance37.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel2.Appearance = Appearance37
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(10, 37)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(67, 18)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "ID"
        '
        'UltraLabel3
        '
        Appearance88.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel3.Appearance = Appearance88
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(10, 102)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(67, 18)
        Me.UltraLabel3.TabIndex = 5
        Me.UltraLabel3.Text = "Name"
        '
        'UltraLabel4
        '
        Appearance39.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel4.Appearance = Appearance39
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(10, 74)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(67, 18)
        Me.UltraLabel4.TabIndex = 7
        Me.UltraLabel4.Text = "Company"
        '
        'tAddr1
        '
        Me.tAddr1.Enabled = False
        Me.tAddr1.Location = New System.Drawing.Point(125, 166)
        Me.tAddr1.Name = "tAddr1"
        Me.tAddr1.Size = New System.Drawing.Size(278, 24)
        Me.tAddr1.TabIndex = 5
        Me.tAddr1.Tag = "edit;cust_addr1"
        '
        'tAddr2
        '
        Me.tAddr2.Enabled = False
        Me.tAddr2.Location = New System.Drawing.Point(125, 194)
        Me.tAddr2.Name = "tAddr2"
        Me.tAddr2.Size = New System.Drawing.Size(278, 24)
        Me.tAddr2.TabIndex = 6
        Me.tAddr2.Tag = "edit;cust_addr2"
        '
        'tAddr3
        '
        Me.tAddr3.Enabled = False
        Me.tAddr3.Location = New System.Drawing.Point(125, 222)
        Me.tAddr3.Name = "tAddr3"
        Me.tAddr3.Size = New System.Drawing.Size(278, 24)
        Me.tAddr3.TabIndex = 7
        Me.tAddr3.Tag = "edit;cust_addr3"
        '
        'tState
        '
        Me.tState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tState.Enabled = False
        Me.tState.Location = New System.Drawing.Point(374, 249)
        Me.tState.Name = "tState"
        Me.tState.Size = New System.Drawing.Size(29, 24)
        Me.tState.TabIndex = 10
        Me.tState.Tag = "edit;cust_state"
        '
        'lAddr1
        '
        Appearance40.ForeColor = System.Drawing.Color.Black
        Me.lAddr1.Appearance = Appearance40
        Me.lAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAddr1.Location = New System.Drawing.Point(10, 166)
        Me.lAddr1.Name = "lAddr1"
        Me.lAddr1.Size = New System.Drawing.Size(96, 19)
        Me.lAddr1.TabIndex = 14
        Me.lAddr1.Text = "Address 1"
        '
        'lAddr2
        '
        Appearance89.ForeColor = System.Drawing.Color.Black
        Me.lAddr2.Appearance = Appearance89
        Me.lAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAddr2.Location = New System.Drawing.Point(10, 194)
        Me.lAddr2.Name = "lAddr2"
        Me.lAddr2.Size = New System.Drawing.Size(96, 18)
        Me.lAddr2.TabIndex = 15
        Me.lAddr2.Text = "Address 2"
        '
        'lAddr3
        '
        Appearance42.ForeColor = System.Drawing.Color.Black
        Me.lAddr3.Appearance = Appearance42
        Me.lAddr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAddr3.Location = New System.Drawing.Point(10, 222)
        Me.lAddr3.Name = "lAddr3"
        Me.lAddr3.Size = New System.Drawing.Size(96, 18)
        Me.lAddr3.TabIndex = 16
        Me.lAddr3.Text = "Address 3"
        '
        'lZip
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.lZip.Appearance = Appearance43
        Me.lZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lZip.Location = New System.Drawing.Point(10, 249)
        Me.lZip.Name = "lZip"
        Me.lZip.Size = New System.Drawing.Size(105, 19)
        Me.lZip.TabIndex = 17
        Me.lZip.Text = "Zip, City, State"
        '
        'UltraLabel13
        '
        Appearance90.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel13.Appearance = Appearance90
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(10, 138)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(96, 19)
        Me.UltraLabel13.TabIndex = 27
        Me.UltraLabel13.Text = "Country"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=JON;packet size=4096;integrated security=SSPI;data source=JON;pers" & _
    "ist security info=True;initial catalog=WineCellar"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cust_id", System.Data.SqlDbType.VarChar, 25, "cust_id"), New System.Data.SqlClient.SqlParameter("@cust_name", System.Data.SqlDbType.VarChar, 50, "cust_name"), New System.Data.SqlClient.SqlParameter("@cust_company", System.Data.SqlDbType.VarChar, 50, "cust_company"), New System.Data.SqlClient.SqlParameter("@cust_country", System.Data.SqlDbType.VarChar, 10, "cust_country"), New System.Data.SqlClient.SqlParameter("@cust_addr1", System.Data.SqlDbType.VarChar, 100, "cust_addr1"), New System.Data.SqlClient.SqlParameter("@cust_addr2", System.Data.SqlDbType.VarChar, 100, "cust_addr2"), New System.Data.SqlClient.SqlParameter("@cust_addr3", System.Data.SqlDbType.VarChar, 100, "cust_addr3"), New System.Data.SqlClient.SqlParameter("@cust_city", System.Data.SqlDbType.VarChar, 20, "cust_city"), New System.Data.SqlClient.SqlParameter("@cust_state", System.Data.SqlDbType.VarChar, 2, "cust_state"), New System.Data.SqlClient.SqlParameter("@cust_zip", System.Data.SqlDbType.VarChar, 10, "cust_zip"), New System.Data.SqlClient.SqlParameter("@cust_email", System.Data.SqlDbType.VarChar, 50, "cust_email"), New System.Data.SqlClient.SqlParameter("@cust_phone1", System.Data.SqlDbType.VarChar, 25, "cust_phone1"), New System.Data.SqlClient.SqlParameter("@cust_phone2", System.Data.SqlDbType.VarChar, 25, "cust_phone2"), New System.Data.SqlClient.SqlParameter("@cust_fax", System.Data.SqlDbType.VarChar, 25, "cust_fax"), New System.Data.SqlClient.SqlParameter("@cust_altphone", System.Data.SqlDbType.VarChar, 25, "cust_altphone"), New System.Data.SqlClient.SqlParameter("@cust_notes", System.Data.SqlDbType.VarChar, 2147483647, "cust_notes"), New System.Data.SqlClient.SqlParameter("@cust_terr_code", System.Data.SqlDbType.VarChar, 10, "cust_terr_code"), New System.Data.SqlClient.SqlParameter("@cust_rep", System.Data.SqlDbType.VarChar, 10, "cust_rep"), New System.Data.SqlClient.SqlParameter("@cust_sales_cat", System.Data.SqlDbType.VarChar, 10, "cust_sales_cat"), New System.Data.SqlClient.SqlParameter("@cust_terms", System.Data.SqlDbType.VarChar, 25, "cust_terms"), New System.Data.SqlClient.SqlParameter("@cust_po_req", System.Data.SqlDbType.Bit, 1, "cust_po_req"), New System.Data.SqlClient.SqlParameter("@cust_tax_exempt", System.Data.SqlDbType.Bit, 1, "cust_tax_exempt"), New System.Data.SqlClient.SqlParameter("@cust_tax_ex_no", System.Data.SqlDbType.VarChar, 25, "cust_tax_ex_no"), New System.Data.SqlClient.SqlParameter("@cust_billable", System.Data.SqlDbType.Bit, 1, "cust_billable"), New System.Data.SqlClient.SqlParameter("@cust_appl_5_perc", System.Data.SqlDbType.Bit, 1, "cust_appl_5_perc")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cust_id", System.Data.SqlDbType.VarChar, 25, "cust_id"), New System.Data.SqlClient.SqlParameter("@cust_name", System.Data.SqlDbType.VarChar, 50, "cust_name"), New System.Data.SqlClient.SqlParameter("@cust_company", System.Data.SqlDbType.VarChar, 50, "cust_company"), New System.Data.SqlClient.SqlParameter("@cust_country", System.Data.SqlDbType.VarChar, 10, "cust_country"), New System.Data.SqlClient.SqlParameter("@cust_addr1", System.Data.SqlDbType.VarChar, 100, "cust_addr1"), New System.Data.SqlClient.SqlParameter("@cust_addr2", System.Data.SqlDbType.VarChar, 100, "cust_addr2"), New System.Data.SqlClient.SqlParameter("@cust_addr3", System.Data.SqlDbType.VarChar, 100, "cust_addr3"), New System.Data.SqlClient.SqlParameter("@cust_city", System.Data.SqlDbType.VarChar, 20, "cust_city"), New System.Data.SqlClient.SqlParameter("@cust_state", System.Data.SqlDbType.VarChar, 2, "cust_state"), New System.Data.SqlClient.SqlParameter("@cust_zip", System.Data.SqlDbType.VarChar, 10, "cust_zip"), New System.Data.SqlClient.SqlParameter("@cust_email", System.Data.SqlDbType.VarChar, 50, "cust_email"), New System.Data.SqlClient.SqlParameter("@cust_phone1", System.Data.SqlDbType.VarChar, 25, "cust_phone1"), New System.Data.SqlClient.SqlParameter("@cust_phone2", System.Data.SqlDbType.VarChar, 25, "cust_phone2"), New System.Data.SqlClient.SqlParameter("@cust_fax", System.Data.SqlDbType.VarChar, 25, "cust_fax"), New System.Data.SqlClient.SqlParameter("@cust_altphone", System.Data.SqlDbType.VarChar, 25, "cust_altphone"), New System.Data.SqlClient.SqlParameter("@cust_notes", System.Data.SqlDbType.VarChar, 2147483647, "cust_notes"), New System.Data.SqlClient.SqlParameter("@cust_terr_code", System.Data.SqlDbType.VarChar, 10, "cust_terr_code"), New System.Data.SqlClient.SqlParameter("@cust_rep", System.Data.SqlDbType.VarChar, 10, "cust_rep"), New System.Data.SqlClient.SqlParameter("@cust_sales_cat", System.Data.SqlDbType.VarChar, 10, "cust_sales_cat"), New System.Data.SqlClient.SqlParameter("@cust_terms", System.Data.SqlDbType.VarChar, 25, "cust_terms"), New System.Data.SqlClient.SqlParameter("@cust_po_req", System.Data.SqlDbType.Bit, 1, "cust_po_req"), New System.Data.SqlClient.SqlParameter("@cust_tax_exempt", System.Data.SqlDbType.Bit, 1, "cust_tax_exempt"), New System.Data.SqlClient.SqlParameter("@cust_tax_ex_no", System.Data.SqlDbType.VarChar, 25, "cust_tax_ex_no"), New System.Data.SqlClient.SqlParameter("@cust_billable", System.Data.SqlDbType.Bit, 1, "cust_billable"), New System.Data.SqlClient.SqlParameter("@cust_appl_5_perc", System.Data.SqlDbType.Bit, 1, "cust_appl_5_perc"), New System.Data.SqlClient.SqlParameter("@Original_cust_serial", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_serial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_addr1", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_addr1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_addr2", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_addr2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_addr3", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_addr3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_altphone", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_altphone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_appl_5_perc", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_appl_5_perc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_billable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_billable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_city", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_city", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_company", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_company", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_country", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_email", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_fax", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_id", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_name", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_phone1", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_phone1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_phone2", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_phone2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_po_req", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_po_req", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_rep", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_rep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_sales_cat", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_sales_cat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_state", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_state", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_tax_ex_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_tax_ex_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_tax_exempt", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_tax_exempt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_terms", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_terms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_terr_code", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_terr_code", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_zip", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_zip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@cust_serial", System.Data.SqlDbType.BigInt, 8, "cust_serial")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_cust_serial", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_serial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_addr1", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_addr1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_addr2", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_addr2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_addr3", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_addr3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_altphone", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_altphone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_appl_5_perc", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_appl_5_perc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_billable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_billable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_city", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_city", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_company", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_company", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_country", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_email", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_fax", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_id", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_name", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_phone1", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_phone1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_phone2", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_phone2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_po_req", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_po_req", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_rep", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_rep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_sales_cat", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_sales_cat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_state", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_state", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_tax_ex_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_tax_ex_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_tax_exempt", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_tax_exempt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_terms", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_terms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_terr_code", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_terr_code", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cust_zip", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_zip", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_file", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cust_serial", "cust_serial"), New System.Data.Common.DataColumnMapping("cust_id", "cust_id"), New System.Data.Common.DataColumnMapping("cust_name", "cust_name"), New System.Data.Common.DataColumnMapping("cust_company", "cust_company"), New System.Data.Common.DataColumnMapping("cust_country", "cust_country"), New System.Data.Common.DataColumnMapping("cust_addr1", "cust_addr1"), New System.Data.Common.DataColumnMapping("cust_addr2", "cust_addr2"), New System.Data.Common.DataColumnMapping("cust_addr3", "cust_addr3"), New System.Data.Common.DataColumnMapping("cust_city", "cust_city"), New System.Data.Common.DataColumnMapping("cust_state", "cust_state"), New System.Data.Common.DataColumnMapping("cust_zip", "cust_zip"), New System.Data.Common.DataColumnMapping("cust_email", "cust_email"), New System.Data.Common.DataColumnMapping("cust_phone1", "cust_phone1"), New System.Data.Common.DataColumnMapping("cust_phone2", "cust_phone2"), New System.Data.Common.DataColumnMapping("cust_fax", "cust_fax"), New System.Data.Common.DataColumnMapping("cust_altphone", "cust_altphone"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("cust_terr_code", "cust_terr_code"), New System.Data.Common.DataColumnMapping("cust_rep", "cust_rep"), New System.Data.Common.DataColumnMapping("cust_sales_cat", "cust_sales_cat"), New System.Data.Common.DataColumnMapping("cust_terms", "cust_terms"), New System.Data.Common.DataColumnMapping("cust_po_req", "cust_po_req"), New System.Data.Common.DataColumnMapping("cust_tax_exempt", "cust_tax_exempt"), New System.Data.Common.DataColumnMapping("cust_tax_ex_no", "cust_tax_ex_no"), New System.Data.Common.DataColumnMapping("cust_billable", "cust_billable"), New System.Data.Common.DataColumnMapping("cust_appl_5_perc", "cust_appl_5_perc")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'UltraLabel18
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel18.Appearance = Appearance8
        Me.UltraLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(701, 158)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(57, 19)
        Me.UltraLabel18.TabIndex = 58
        Me.UltraLabel18.Text = "Terms"
        '
        'UltraLabel17
        '
        Appearance46.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel17.Appearance = Appearance46
        Me.UltraLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(422, 212)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(81, 19)
        Me.UltraLabel17.TabIndex = 57
        Me.UltraLabel17.Text = "Sales Cat"
        '
        'UltraLabel16
        '
        Appearance47.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel16.Appearance = Appearance47
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(420, 185)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(96, 18)
        Me.UltraLabel16.TabIndex = 56
        Me.UltraLabel16.Text = "Account Rep"
        '
        'UltraLabel12
        '
        Appearance48.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel12.Appearance = Appearance48
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(422, 92)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(68, 19)
        Me.UltraLabel12.TabIndex = 50
        Me.UltraLabel12.Text = "Alt Phone"
        '
        'UltraLabel11
        '
        Appearance49.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel11.Appearance = Appearance49
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(422, 65)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(68, 18)
        Me.UltraLabel11.TabIndex = 49
        Me.UltraLabel11.Text = "Fax"
        '
        'UltraLabel10
        '
        Appearance91.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel10.Appearance = Appearance91
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(422, 37)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(68, 18)
        Me.UltraLabel10.TabIndex = 48
        Me.UltraLabel10.Text = "Phone 2"
        '
        'UltraLabel9
        '
        Appearance51.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel9.Appearance = Appearance51
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(422, 9)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(68, 19)
        Me.UltraLabel9.TabIndex = 47
        Me.UltraLabel9.Text = "Phone 1"
        '
        'taltphone
        '
        Me.taltphone.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.taltphone.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.taltphone.Enabled = False
        Me.taltphone.InputMask = "(###) ###-####"
        Me.taltphone.Location = New System.Drawing.Point(509, 92)
        Me.taltphone.Name = "taltphone"
        Me.taltphone.Size = New System.Drawing.Size(144, 22)
        Me.taltphone.TabIndex = 16
        Me.taltphone.Tag = "edit;cust_alt_phone"
        Me.taltphone.Text = "() -"
        '
        'tfax
        '
        Me.tfax.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.tfax.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.tfax.Enabled = False
        Me.tfax.InputMask = "(###) ###-####"
        Me.tfax.Location = New System.Drawing.Point(509, 65)
        Me.tfax.Name = "tfax"
        Me.tfax.Size = New System.Drawing.Size(144, 22)
        Me.tfax.TabIndex = 15
        Me.tfax.Tag = "edit;cust_fax"
        Me.tfax.Text = "() -"
        '
        'tphone2
        '
        Me.tphone2.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.tphone2.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.tphone2.Enabled = False
        Me.tphone2.InputMask = "(###) ###-#### Ext. 99999"
        Me.tphone2.Location = New System.Drawing.Point(509, 37)
        Me.tphone2.Name = "tphone2"
        Me.tphone2.Size = New System.Drawing.Size(144, 22)
        Me.tphone2.TabIndex = 14
        Me.tphone2.Tag = "edit;cust_phone2"
        Me.tphone2.Text = "() - Ext. "
        '
        'tphone1
        '
        Me.tphone1.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.tphone1.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.tphone1.Enabled = False
        Me.tphone1.InputMask = "(###) ###-#### Ext. 99999"
        Me.tphone1.Location = New System.Drawing.Point(509, 9)
        Me.tphone1.Name = "tphone1"
        Me.tphone1.Size = New System.Drawing.Size(144, 22)
        Me.tphone1.TabIndex = 13
        Me.tphone1.Tag = "edit;cust_phone1"
        Me.tphone1.Text = "() - Ext. "
        '
        'UltraTextEditor15
        '
        Me.UltraTextEditor15.Enabled = False
        Me.UltraTextEditor15.Location = New System.Drawing.Point(701, 48)
        Me.UltraTextEditor15.Name = "UltraTextEditor15"
        Me.UltraTextEditor15.Size = New System.Drawing.Size(144, 24)
        Me.UltraTextEditor15.TabIndex = 24
        Me.UltraTextEditor15.Tag = "edit;cust_tax_ex_no"
        '
        'UltraCheckEditor1
        '
        Appearance52.FontData.BoldAsString = "True"
        Appearance52.ForeColor = System.Drawing.Color.Black
        Me.UltraCheckEditor1.Appearance = Appearance52
        Me.UltraCheckEditor1.Enabled = False
        Me.UltraCheckEditor1.Location = New System.Drawing.Point(672, 9)
        Me.UltraCheckEditor1.Name = "UltraCheckEditor1"
        Me.UltraCheckEditor1.Size = New System.Drawing.Size(144, 18)
        Me.UltraCheckEditor1.TabIndex = 22
        Me.UltraCheckEditor1.Tag = "edit;cust_po_req;cb"
        Me.UltraCheckEditor1.Text = "PO Required"
        '
        'tTaxExempt
        '
        Appearance53.FontData.BoldAsString = "True"
        Appearance53.ForeColor = System.Drawing.Color.Black
        Me.tTaxExempt.Appearance = Appearance53
        Me.tTaxExempt.Enabled = False
        Me.tTaxExempt.Location = New System.Drawing.Point(672, 27)
        Me.tTaxExempt.Name = "tTaxExempt"
        Me.tTaxExempt.Size = New System.Drawing.Size(144, 18)
        Me.tTaxExempt.TabIndex = 23
        Me.tTaxExempt.Tag = "edit;cust_tax_exempt;cb"
        Me.tTaxExempt.Text = "Tax Exempt"
        '
        'cbBillable
        '
        Appearance54.FontData.BoldAsString = "True"
        Appearance54.ForeColor = System.Drawing.Color.Black
        Me.cbBillable.Appearance = Appearance54
        Me.cbBillable.Enabled = False
        Me.cbBillable.Location = New System.Drawing.Point(979, 195)
        Me.cbBillable.Name = "cbBillable"
        Me.cbBillable.Size = New System.Drawing.Size(144, 18)
        Me.cbBillable.TabIndex = 25
        Me.cbBillable.Tag = "edit;cust_billable;cb"
        Me.cbBillable.Text = "Billable"
        '
        'UltraCheckEditor4
        '
        Appearance55.FontData.BoldAsString = "True"
        Appearance55.ForeColor = System.Drawing.Color.Black
        Me.UltraCheckEditor4.Appearance = Appearance55
        Me.UltraCheckEditor4.Enabled = False
        Me.UltraCheckEditor4.Location = New System.Drawing.Point(701, 130)
        Me.UltraCheckEditor4.Name = "UltraCheckEditor4"
        Me.UltraCheckEditor4.Size = New System.Drawing.Size(192, 18)
        Me.UltraCheckEditor4.TabIndex = 26
        Me.UltraCheckEditor4.Tag = "edit;cust_appl_5_perc;cb"
        Me.UltraCheckEditor4.Text = "Apply 5% Discount"
        '
        'UltraTextEditor4
        '
        Me.UltraTextEditor4.Enabled = False
        Me.UltraTextEditor4.Location = New System.Drawing.Point(125, 74)
        Me.UltraTextEditor4.Name = "UltraTextEditor4"
        Me.UltraTextEditor4.Size = New System.Drawing.Size(278, 24)
        Me.UltraTextEditor4.TabIndex = 2
        Me.UltraTextEditor4.Tag = "edit;cust_company"
        '
        'UltraTabControl1
        '
        Appearance56.BackColor = System.Drawing.Color.White
        Appearance56.FontData.BoldAsString = "True"
        Me.UltraTabControl1.ActiveTabAppearance = Appearance56
        Me.UltraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance57.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UltraTabControl1.Appearance = Appearance57
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl10)
        Me.UltraTabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabControl1.Location = New System.Drawing.Point(10, 342)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(1270, 385)
        Me.UltraTabControl1.TabIndex = 29
        Appearance59.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraTab1.ClientAreaAppearance = Appearance59
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Notes"
        Appearance60.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        UltraTab2.ClientAreaAppearance = Appearance60
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Product Type Margin"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Item Price"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Contacts"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Documents"
        UltraTab6.Key = "ThirdParty"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Third Party Shipping"
        Appearance61.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraTab7.ClientAreaAppearance = Appearance61
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Discounts"
        UltraTab8.Key = "Special"
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "Special Notes"
        UltraTab9.Key = "DealerReq"
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Dealer Req"
        UltraTab10.Key = "Emails"
        UltraTab10.TabPage = Me.UltraTabPageControl10
        UltraTab10.Text = "Emails"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab7, UltraTab8, UltraTab9, UltraTab10})
        Me.UltraTabControl1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1266, 354)
        '
        'UltraLabel14
        '
        Appearance62.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel14.Appearance = Appearance62
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(422, 277)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(68, 18)
        Me.UltraLabel14.TabIndex = 63
        Me.UltraLabel14.Text = "eMail"
        '
        'UltraTextEditor8
        '
        Me.UltraTextEditor8.Enabled = False
        Me.UltraTextEditor8.Location = New System.Drawing.Point(509, 277)
        Me.UltraTextEditor8.Name = "UltraTextEditor8"
        Me.UltraTextEditor8.Size = New System.Drawing.Size(144, 24)
        Me.UltraTextEditor8.TabIndex = 20
        Me.UltraTextEditor8.Tag = "edit;cust_email"
        '
        'UltraCheckEditor5
        '
        Appearance63.FontData.BoldAsString = "True"
        Appearance63.ForeColor = System.Drawing.Color.Black
        Me.UltraCheckEditor5.Appearance = Appearance63
        Me.UltraCheckEditor5.Enabled = False
        Me.UltraCheckEditor5.Location = New System.Drawing.Point(326, 9)
        Me.UltraCheckEditor5.Name = "UltraCheckEditor5"
        Me.UltraCheckEditor5.Size = New System.Drawing.Size(87, 28)
        Me.UltraCheckEditor5.TabIndex = 28
        Me.UltraCheckEditor5.Tag = "edit;Inactive;cb"
        Me.UltraCheckEditor5.Text = "Inactive"
        '
        'UltraLabel21
        '
        Appearance64.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel21.Appearance = Appearance64
        Me.UltraLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(422, 305)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(68, 18)
        Me.UltraLabel21.TabIndex = 66
        Me.UltraLabel21.Text = "Web Site"
        '
        'UltraTextEditor9
        '
        Me.UltraTextEditor9.Enabled = False
        Me.UltraTextEditor9.Location = New System.Drawing.Point(509, 305)
        Me.UltraTextEditor9.Name = "UltraTextEditor9"
        Me.UltraTextEditor9.Size = New System.Drawing.Size(144, 24)
        Me.UltraTextEditor9.TabIndex = 21
        Me.UltraTextEditor9.Tag = "edit;cust_web"
        '
        'UltraLabel22
        '
        Appearance65.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel22.Appearance = Appearance65
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(422, 120)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(77, 18)
        Me.UltraLabel22.TabIndex = 68
        Me.UltraLabel22.Text = "Cell Phone"
        '
        'tcell
        '
        Me.tcell.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.tcell.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.tcell.Enabled = False
        Me.tcell.InputMask = "(###) ###-####"
        Me.tcell.Location = New System.Drawing.Point(509, 120)
        Me.tcell.Name = "tcell"
        Me.tcell.Size = New System.Drawing.Size(144, 22)
        Me.tcell.TabIndex = 17
        Me.tcell.Tag = "edit;cust_cell"
        Me.tcell.Text = "() -"
        '
        'tTerms
        '
        Me.tTerms.CheckedListSettings.CheckStateMember = ""
        Me.tTerms.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tTerms.Enabled = False
        Me.tTerms.Location = New System.Drawing.Point(768, 158)
        Me.tTerms.Name = "tTerms"
        Me.tTerms.Size = New System.Drawing.Size(96, 25)
        Me.tTerms.TabIndex = 27
        Me.tTerms.Tag = "edit;cust_terms"
        '
        'tRep
        '
        Me.tRep.CheckedListSettings.CheckStateMember = ""
        Me.tRep.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tRep.Enabled = False
        Me.tRep.Location = New System.Drawing.Point(509, 185)
        Me.tRep.Name = "tRep"
        Me.tRep.Size = New System.Drawing.Size(144, 25)
        Me.tRep.TabIndex = 18
        Me.tRep.Tag = "edit;cust_rep"
        '
        'tCat
        '
        Me.tCat.CheckedListSettings.CheckStateMember = ""
        Me.tCat.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tCat.Enabled = False
        Me.tCat.Location = New System.Drawing.Point(509, 212)
        Me.tCat.Name = "tCat"
        Me.tCat.Size = New System.Drawing.Size(144, 25)
        Me.tCat.TabIndex = 19
        Me.tCat.Tag = "edit;cust_sales_cat"
        '
        'tCountry
        '
        Me.tCountry.CheckedListSettings.CheckStateMember = ""
        Me.tCountry.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tCountry.Enabled = False
        Me.tCountry.Location = New System.Drawing.Point(125, 138)
        Me.tCountry.Name = "tCountry"
        Me.tCountry.Size = New System.Drawing.Size(163, 25)
        Me.tCountry.TabIndex = 4
        Me.tCountry.Tag = "edit;cust_country"
        '
        'lCounty
        '
        Appearance66.ForeColor = System.Drawing.Color.Black
        Me.lCounty.Appearance = Appearance66
        Me.lCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCounty.Location = New System.Drawing.Point(10, 277)
        Me.lCounty.Name = "lCounty"
        Me.lCounty.Size = New System.Drawing.Size(96, 18)
        Me.lCounty.TabIndex = 71
        Me.lCounty.Tag = ""
        Me.lCounty.Text = "County"
        '
        'tCounty
        '
        Me.tCounty.Enabled = False
        Me.tCounty.Location = New System.Drawing.Point(125, 277)
        Me.tCounty.Name = "tCounty"
        Me.tCounty.Size = New System.Drawing.Size(278, 24)
        Me.tCounty.TabIndex = 11
        Me.tCounty.Tag = "edit;cust_county"
        '
        'lProvince
        '
        Appearance67.ForeColor = System.Drawing.Color.Black
        Me.lProvince.Appearance = Appearance67
        Me.lProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lProvince.Location = New System.Drawing.Point(10, 305)
        Me.lProvince.Name = "lProvince"
        Me.lProvince.Size = New System.Drawing.Size(96, 18)
        Me.lProvince.TabIndex = 73
        Me.lProvince.Tag = ""
        Me.lProvince.Text = "Province"
        '
        'tProvince
        '
        Me.tProvince.Enabled = False
        Me.tProvince.Location = New System.Drawing.Point(125, 305)
        Me.tProvince.Name = "tProvince"
        Me.tProvince.Size = New System.Drawing.Size(278, 24)
        Me.tProvince.TabIndex = 12
        Me.tProvince.Tag = "edit;cust_province"
        '
        'tZip
        '
        Me.tZip.Enabled = False
        Me.tZip.Location = New System.Drawing.Point(125, 249)
        Me.tZip.Name = "tZip"
        Me.tZip.Size = New System.Drawing.Size(96, 24)
        Me.tZip.TabIndex = 8
        Me.tZip.Tag = "edit;cust_zip"
        '
        'tCity
        '
        Me.tCity.CheckedListSettings.CheckStateMember = ""
        Me.tCity.Enabled = False
        Me.tCity.Location = New System.Drawing.Point(221, 249)
        Me.tCity.Name = "tCity"
        Me.tCity.Size = New System.Drawing.Size(153, 25)
        Me.tCity.TabIndex = 9
        Me.tCity.Tag = "edit;cust_city"
        '
        'tBillDay
        '
        Me.tBillDay.CheckedListSettings.CheckStateMember = ""
        Me.tBillDay.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tBillDay.Enabled = False
        Me.tBillDay.Location = New System.Drawing.Point(768, 185)
        Me.tBillDay.Name = "tBillDay"
        Me.tBillDay.Size = New System.Drawing.Size(96, 25)
        Me.tBillDay.TabIndex = 76
        Me.tBillDay.Tag = "edit;cust_bill_day;nm"
        '
        'UltraLabel6
        '
        Appearance68.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel6.Appearance = Appearance68
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(701, 185)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(57, 19)
        Me.UltraLabel6.TabIndex = 77
        Me.UltraLabel6.Text = "Bill Day"
        '
        'chVendorNet
        '
        Appearance69.FontData.BoldAsString = "True"
        Appearance69.ForeColor = System.Drawing.Color.Black
        Me.chVendorNet.Appearance = Appearance69
        Me.chVendorNet.Enabled = False
        Me.chVendorNet.Location = New System.Drawing.Point(797, 9)
        Me.chVendorNet.Name = "chVendorNet"
        Me.chVendorNet.Size = New System.Drawing.Size(144, 18)
        Me.chVendorNet.TabIndex = 78
        Me.chVendorNet.Tag = "edit;cust_vendornet;cb"
        Me.chVendorNet.Text = "Vendor Net"
        '
        'UltraCheckEditor2
        '
        Appearance70.FontData.BoldAsString = "True"
        Appearance70.ForeColor = System.Drawing.Color.Black
        Me.UltraCheckEditor2.Appearance = Appearance70
        Me.UltraCheckEditor2.Enabled = False
        Me.UltraCheckEditor2.Location = New System.Drawing.Point(797, 27)
        Me.UltraCheckEditor2.Name = "UltraCheckEditor2"
        Me.UltraCheckEditor2.Size = New System.Drawing.Size(173, 18)
        Me.UltraCheckEditor2.TabIndex = 79
        Me.UltraCheckEditor2.Tag = "edit;cust_force_forecasting;cb"
        Me.UltraCheckEditor2.Text = "Force Forecasting"
        '
        'cbThirdParty
        '
        Appearance71.FontData.BoldAsString = "True"
        Appearance71.ForeColor = System.Drawing.Color.Black
        Me.cbThirdParty.Appearance = Appearance71
        Me.cbThirdParty.Enabled = False
        Me.cbThirdParty.Location = New System.Drawing.Point(672, 213)
        Me.cbThirdParty.Name = "cbThirdParty"
        Me.cbThirdParty.Size = New System.Drawing.Size(230, 18)
        Me.cbThirdParty.TabIndex = 80
        Me.cbThirdParty.Tag = "edit;cust_thirdparty;cb"
        Me.cbThirdParty.Text = "Third Party Shipment Billing"
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.Enabled = False
        Me.UltraTextEditor1.Location = New System.Drawing.Point(701, 234)
        Me.UltraTextEditor1.MaxLength = 35
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(144, 24)
        Me.UltraTextEditor1.TabIndex = 81
        Me.UltraTextEditor1.Tag = "edit;cust_thirdpartyname"
        '
        'UltraCheckEditor6
        '
        Appearance72.FontData.BoldAsString = "True"
        Appearance72.ForeColor = System.Drawing.Color.Black
        Me.UltraCheckEditor6.Appearance = Appearance72
        Me.UltraCheckEditor6.Enabled = False
        Me.UltraCheckEditor6.Location = New System.Drawing.Point(672, 268)
        Me.UltraCheckEditor6.Name = "UltraCheckEditor6"
        Me.UltraCheckEditor6.Size = New System.Drawing.Size(192, 18)
        Me.UltraCheckEditor6.TabIndex = 82
        Me.UltraCheckEditor6.Tag = "edit;cust_process_override;cb"
        Me.UltraCheckEditor6.Text = "Process fee above base"
        '
        'UltraTextEditor2
        '
        Me.UltraTextEditor2.Enabled = False
        Me.UltraTextEditor2.Location = New System.Drawing.Point(864, 268)
        Me.UltraTextEditor2.MaxLength = 35
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.Size = New System.Drawing.Size(58, 24)
        Me.UltraTextEditor2.TabIndex = 83
        Me.UltraTextEditor2.Tag = "edit;cust_process;nm"
        '
        'UltraLabel7
        '
        Appearance73.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel7.Appearance = Appearance73
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(922, 268)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(28, 19)
        Me.UltraLabel7.TabIndex = 84
        Me.UltraLabel7.Text = "%"
        '
        'UltraLabel8
        '
        Appearance74.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel8.Appearance = Appearance74
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(672, 305)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(125, 19)
        Me.UltraLabel8.TabIndex = 86
        Me.UltraLabel8.Text = "Commission Split"
        '
        'tCommSplit
        '
        Me.tCommSplit.Enabled = False
        Me.tCommSplit.Location = New System.Drawing.Point(797, 305)
        Me.tCommSplit.Name = "tCommSplit"
        Me.tCommSplit.Size = New System.Drawing.Size(144, 24)
        Me.tCommSplit.TabIndex = 85
        Me.tCommSplit.Tag = "edit;cust_commission_split"
        '
        'tTerr
        '
        Me.tTerr.CheckedListSettings.CheckStateMember = ""
        Me.tTerr.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tTerr.Enabled = False
        Me.tTerr.Location = New System.Drawing.Point(509, 240)
        Me.tTerr.Name = "tTerr"
        Me.tTerr.Size = New System.Drawing.Size(144, 25)
        Me.tTerr.TabIndex = 87
        Me.tTerr.Tag = "edit;cust_terr"
        '
        'UltraLabel15
        '
        Appearance75.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel15.Appearance = Appearance75
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(422, 240)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(68, 18)
        Me.UltraLabel15.TabIndex = 88
        Me.UltraLabel15.Text = "Territory"
        '
        'cbEmailReceipts
        '
        Appearance76.FontData.BoldAsString = "True"
        Appearance76.ForeColor = System.Drawing.Color.Black
        Me.cbEmailReceipts.Appearance = Appearance76
        Me.cbEmailReceipts.Enabled = False
        Me.cbEmailReceipts.Location = New System.Drawing.Point(979, 9)
        Me.cbEmailReceipts.Name = "cbEmailReceipts"
        Me.cbEmailReceipts.Size = New System.Drawing.Size(144, 28)
        Me.cbEmailReceipts.TabIndex = 89
        Me.cbEmailReceipts.Tag = "edit;cust_email_receipt;cb"
        Me.cbEmailReceipts.Text = "Email Receipts to:"
        '
        'UltraTextEditor5
        '
        Me.UltraTextEditor5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraTextEditor5.Enabled = False
        Me.UltraTextEditor5.Location = New System.Drawing.Point(979, 37)
        Me.UltraTextEditor5.MaxLength = 200
        Me.UltraTextEditor5.Name = "UltraTextEditor5"
        Me.UltraTextEditor5.Size = New System.Drawing.Size(301, 24)
        Me.UltraTextEditor5.TabIndex = 90
        Me.UltraTextEditor5.Tag = "edit;cust_email_receipts_to"
        '
        'UltraTextEditor6
        '
        Me.UltraTextEditor6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraTextEditor6.Enabled = False
        Me.UltraTextEditor6.Location = New System.Drawing.Point(979, 92)
        Me.UltraTextEditor6.MaxLength = 200
        Me.UltraTextEditor6.Name = "UltraTextEditor6"
        Me.UltraTextEditor6.Size = New System.Drawing.Size(301, 24)
        Me.UltraTextEditor6.TabIndex = 92
        Me.UltraTextEditor6.Tag = "edit;cust_email_shipments_to"
        '
        'cbEmailShipments
        '
        Appearance77.FontData.BoldAsString = "True"
        Appearance77.ForeColor = System.Drawing.Color.Black
        Me.cbEmailShipments.Appearance = Appearance77
        Me.cbEmailShipments.Enabled = False
        Me.cbEmailShipments.Location = New System.Drawing.Point(979, 65)
        Me.cbEmailShipments.Name = "cbEmailShipments"
        Me.cbEmailShipments.Size = New System.Drawing.Size(211, 27)
        Me.cbEmailShipments.TabIndex = 91
        Me.cbEmailShipments.Tag = "edit;cust_email_shipment;cb"
        Me.cbEmailShipments.Text = "Email Ship Notifications to:"
        '
        'UltraLabel24
        '
        Appearance78.ForeColor = System.Drawing.Color.Silver
        Me.UltraLabel24.Appearance = Appearance78
        Me.UltraLabel24.Location = New System.Drawing.Point(979, 175)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(250, 18)
        Me.UltraLabel24.TabIndex = 96
        Me.UltraLabel24.Text = "name@place.com; name2 @place.com"
        '
        'tEmailProd
        '
        Me.tEmailProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tEmailProd.Enabled = False
        Me.tEmailProd.Location = New System.Drawing.Point(979, 148)
        Me.tEmailProd.MaxLength = 200
        Me.tEmailProd.Name = "tEmailProd"
        Me.tEmailProd.Size = New System.Drawing.Size(301, 24)
        Me.tEmailProd.TabIndex = 95
        Me.tEmailProd.Tag = "edit;cust_email_prod_to"
        '
        'cbEmailProd
        '
        Appearance79.FontData.BoldAsString = "True"
        Appearance79.ForeColor = System.Drawing.Color.Black
        Me.cbEmailProd.Appearance = Appearance79
        Me.cbEmailProd.Enabled = False
        Me.cbEmailProd.Location = New System.Drawing.Point(979, 120)
        Me.cbEmailProd.Name = "cbEmailProd"
        Me.cbEmailProd.Size = New System.Drawing.Size(211, 28)
        Me.cbEmailProd.TabIndex = 94
        Me.cbEmailProd.Tag = "edit;cust_email_prod;cb"
        Me.cbEmailProd.Text = "Email Production Reports to:"
        '
        'UltraCheckEditor7
        '
        Appearance80.FontData.BoldAsString = "True"
        Appearance80.ForeColor = System.Drawing.Color.Black
        Me.UltraCheckEditor7.Appearance = Appearance80
        Me.UltraCheckEditor7.Enabled = False
        Me.UltraCheckEditor7.Location = New System.Drawing.Point(672, 80)
        Me.UltraCheckEditor7.Name = "UltraCheckEditor7"
        Me.UltraCheckEditor7.Size = New System.Drawing.Size(211, 28)
        Me.UltraCheckEditor7.TabIndex = 97
        Me.UltraCheckEditor7.Tag = "edit;cust_auto_pdf_ret;cb"
        Me.UltraCheckEditor7.Text = "Auto PDF Retail Quote"
        '
        'tBillableEmails
        '
        Me.tBillableEmails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tBillableEmails.Enabled = False
        Me.tBillableEmails.Location = New System.Drawing.Point(979, 216)
        Me.tBillableEmails.MaxLength = 200
        Me.tBillableEmails.Name = "tBillableEmails"
        Me.tBillableEmails.Size = New System.Drawing.Size(301, 24)
        Me.tBillableEmails.TabIndex = 98
        Me.tBillableEmails.Tag = "edit;cust_email_bills_to"
        '
        'UltraTextEditor10
        '
        Me.UltraTextEditor10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraTextEditor10.Enabled = False
        Me.UltraTextEditor10.Location = New System.Drawing.Point(977, 264)
        Me.UltraTextEditor10.MaxLength = 200
        Me.UltraTextEditor10.Name = "UltraTextEditor10"
        Me.UltraTextEditor10.Size = New System.Drawing.Size(301, 24)
        Me.UltraTextEditor10.TabIndex = 99
        Me.UltraTextEditor10.Tag = "edit;cust_email_ddp_to"
        '
        'UltraLabel23
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel23.Appearance = Appearance9
        Me.UltraLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(977, 247)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(501, 18)
        Me.UltraLabel23.TabIndex = 100
        Me.UltraLabel23.Text = "DDP Email (added to sold to email when sending designs)"
        '
        'fmCustomer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1287, 734)
        Me.Controls.Add(Me.UltraTextEditor10)
        Me.Controls.Add(Me.UltraLabel23)
        Me.Controls.Add(Me.tBillableEmails)
        Me.Controls.Add(Me.chVendorNet)
        Me.Controls.Add(Me.UltraCheckEditor1)
        Me.Controls.Add(Me.UltraCheckEditor7)
        Me.Controls.Add(Me.UltraLabel24)
        Me.Controls.Add(Me.tEmailProd)
        Me.Controls.Add(Me.cbEmailProd)
        Me.Controls.Add(Me.UltraTextEditor6)
        Me.Controls.Add(Me.cbEmailShipments)
        Me.Controls.Add(Me.UltraTextEditor5)
        Me.Controls.Add(Me.cbEmailReceipts)
        Me.Controls.Add(Me.tTerr)
        Me.Controls.Add(Me.UltraLabel15)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.tCommSplit)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraCheckEditor6)
        Me.Controls.Add(Me.UltraTextEditor2)
        Me.Controls.Add(Me.cbThirdParty)
        Me.Controls.Add(Me.UltraTextEditor1)
        Me.Controls.Add(Me.UltraCheckEditor2)
        Me.Controls.Add(Me.tBillDay)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.tCity)
        Me.Controls.Add(Me.tZip)
        Me.Controls.Add(Me.lProvince)
        Me.Controls.Add(Me.tProvince)
        Me.Controls.Add(Me.lCounty)
        Me.Controls.Add(Me.tCounty)
        Me.Controls.Add(Me.tCountry)
        Me.Controls.Add(Me.tCat)
        Me.Controls.Add(Me.tRep)
        Me.Controls.Add(Me.tTerms)
        Me.Controls.Add(Me.UltraLabel22)
        Me.Controls.Add(Me.tcell)
        Me.Controls.Add(Me.UltraLabel21)
        Me.Controls.Add(Me.UltraTextEditor9)
        Me.Controls.Add(Me.UltraCheckEditor5)
        Me.Controls.Add(Me.UltraLabel14)
        Me.Controls.Add(Me.UltraTextEditor8)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.UltraTextEditor4)
        Me.Controls.Add(Me.UltraCheckEditor4)
        Me.Controls.Add(Me.cbBillable)
        Me.Controls.Add(Me.tTaxExempt)
        Me.Controls.Add(Me.UltraTextEditor15)
        Me.Controls.Add(Me.UltraLabel18)
        Me.Controls.Add(Me.UltraLabel17)
        Me.Controls.Add(Me.UltraLabel16)
        Me.Controls.Add(Me.UltraLabel12)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.taltphone)
        Me.Controls.Add(Me.tfax)
        Me.Controls.Add(Me.tphone2)
        Me.Controls.Add(Me.tphone1)
        Me.Controls.Add(Me.UltraLabel13)
        Me.Controls.Add(Me.lZip)
        Me.Controls.Add(Me.lAddr3)
        Me.Controls.Add(Me.lAddr2)
        Me.Controls.Add(Me.lAddr1)
        Me.Controls.Add(Me.tState)
        Me.Controls.Add(Me.tAddr3)
        Me.Controls.Add(Me.tAddr2)
        Me.Controls.Add(Me.tAddr1)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraTextEditor3)
        Me.Controls.Add(Me.tCust_ID)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.cust_serial)
        Me.Name = "fmCustomer"
        Me.Text = "Customers"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.tNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.tCopyFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl3.PerformLayout()
        CType(Me.tFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chCurrentPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCopyFromPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.Docs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.grThirdParty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.grDiscounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        Me.UltraTabPageControl8.PerformLayout()
        CType(Me.tSpecialNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        Me.UltraTabPageControl9.PerformLayout()
        CType(Me.tDealerReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.gEmails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cust_serial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCust_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAddr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAddr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAddr3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTaxExempt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBillable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.UltraTextEditor8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTerms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCounty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tProvince, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tZip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBillDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chVendorNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbThirdParty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCommSplit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTerr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmailReceipts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmailShipments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tEmailProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmailProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBillableEmails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub fmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Table = "cust_file"
        Me.Key1 = "cust_serial"
        Me.FocusField = "tcust_id"
        PopulateValueList_Parts()
        PopulateValueList_Prod()
        LoadGrid(Grid1, daItemPrices, dsItemPrices, "select * from cust_itm_price where cust_itm_price_cust_serial='" + KeyValue1 + "'", "parts")
        LoadGrid(grDiscounts, daDiscounts, dsDiscounts, "select * from cust_disc where cust_disc_cust_serial='" + KeyValue1 + "'", "discounts")
        LoadGrid(Grid2, daItemProdMar, dsItemProdMar, "select * from cust_prod_mar where cust_prod_mar_cust_serial='" + KeyValue1 + "' order by cust_prod_mar_type", "parts")
        LoadGrid(Grid3, daContacts, dsContacts, "select * from cust_cont where cust_cont_cust_serial='" + KeyValue1 + "'", "cont")
        LoadGrid(grThirdParty, daThirdParty, dsThirdParty, "select * from cust_ship where cust_ship_cust_serial='" + KeyValue1 + "'", "ship")
        PopulateValueList(grThirdParty, "ship_via", "select ship_via_code from ship_via where ship_via_inactive<>1 order by ship_via_code", "ship_via_code", "ship_via_code", "cust_ship_via")
        'LoadDD(tZip, dsZip, "zip_file", "zip_code", "zip_code", "zip_code,zip_city,zip_state,zip_county_name")
        LoadDD(tTerms, dsTerms, "terms_file", "terms_code", "terms_code", "terms_code,terms_desc")
        LoadDD(tRep, dsRep, "rep_file", "rep_code", "rep_code", "rep_code,rep_type,rep_name")
        LoadDD(tCat, dsCat, "sales_cat", "sales_cat_cat", "sales_cat_cat", "sales_cat_cat,sales_cat_desc")
        LoadDD(tCountry, dsCountry, "country_file", "country_code", "country_code", "country_code,country")
        LoadDD(tBillDay, dsBillDay, "day_file", "dayno", "day", , , True)
        LoadDD2(tTerr, "territory", "territory", "territory")
    End Sub
    Private Sub PopulateValueList_Parts()
        If Grid1.DisplayLayout.ValueLists.Exists("parts") Then Exit Sub
        Dim objValueList As Infragistics.Win.ValueList
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        cmd.Connection = cnn
        cmd.CommandText = "select itm_serial,itm_code,itm_desc from itm_file order by itm_code"
        da.SelectCommand = cmd
        cnn.Open()
        da.Fill(ds, "parts")
        cnn.Close()

        objValueList = Grid1.DisplayLayout.ValueLists.Add("parts")
        Dim i As Integer
        For i = 0 To ds.Tables("parts").Rows.Count - 1
            If Not ds.Tables("parts").Rows(i).Item("itm_code") Is DBNull.Value Then
                objValueList.ValueListItems.Add(Trim(ds.Tables("parts").Rows(i).Item("itm_code")), Trim(ds.Tables("parts").Rows(i).Item("itm_code")))
            End If
        Next
        Grid1.DisplayLayout.Bands(0).Columns("cust_itm_price_itm_code").ValueList = Grid1.DisplayLayout.ValueLists("parts")
    End Sub
    Private Sub PopulateValueList_Prod()
        If Grid2.DisplayLayout.ValueLists.Exists("parts") Then Exit Sub
        Dim objValueList As Infragistics.Win.ValueList
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        cmd.Connection = cnn
        'cmd.CommandText = "select itm_prod_type_serial,itm_prod_type_type,itm_prod_type_desc from itm_prod_type order by itm_prod_type_type"
        cmd.CommandText = "select itm_prod_type_type from itm_prod_type order by itm_prod_type_type"
        da.SelectCommand = cmd
        cnn.Open()
        da.Fill(ds, "parts")
        cnn.Close()

        objValueList = Grid2.DisplayLayout.ValueLists.Add("parts")
        Dim i As Integer
        For i = 0 To ds.Tables("parts").Rows.Count - 1
            If Not ds.Tables("parts").Rows(i).Item("itm_prod_type_type") Is DBNull.Value Then
                objValueList.ValueListItems.Add(Trim(ds.Tables("parts").Rows(i).Item("itm_prod_type_type")), Trim(ds.Tables("parts").Rows(i).Item("itm_prod_type_type")))
            End If
        Next
        Grid2.DisplayLayout.Bands(0).Columns("cust_prod_mar_type").ValueList = Grid2.DisplayLayout.ValueLists("parts")
    End Sub
    Public Overrides Sub Save_After()
        cust_serial.Text = KeyValue1
        Dim x As Integer

        cnn.Open()
        Grid1.UpdateData()
        BindingContext(dsItemPrices, "parts").EndCurrentEdit()
        For x = 0 To dsItemPrices.Tables("parts").Rows.Count - 1
            If dsItemPrices.Tables("parts").Rows(x).RowState <> DataRowState.Deleted Then
                dsItemPrices.Tables("parts").Rows(x).Item("cust_itm_price_cust_serial") = CLng(KeyValue1)
            End If
        Next
        daItemPrices.Update(dsItemPrices, "parts")

        grDiscounts.UpdateData()
        BindingContext(dsDiscounts, "discounts").EndCurrentEdit()
        For x = 0 To dsDiscounts.Tables("discounts").Rows.Count - 1
            If dsDiscounts.Tables("discounts").Rows(x).RowState <> DataRowState.Deleted Then
                dsDiscounts.Tables("discounts").Rows(x).Item("cust_disc_cust_serial") = CLng(KeyValue1)
                dsDiscounts.Tables("discounts").Rows(x).Item("cust_disc_cust_id") = Me.tCust_ID.Text
            End If
        Next
        daDiscounts.Update(dsDiscounts, "discounts")

        Grid2.UpdateData()
        BindingContext(dsItemProdMar, "parts").EndCurrentEdit()
        For x = 0 To dsItemProdMar.Tables("parts").Rows.Count - 1
            If dsItemProdMar.Tables("parts").Rows(x).RowState <> DataRowState.Deleted Then
                dsItemProdMar.Tables("parts").Rows(x).Item("cust_prod_mar_serial") = DBNull.Value
                dsItemProdMar.Tables("parts").Rows(x).Item("cust_prod_mar_cust_serial") = CLng(KeyValue1)
            End If
        Next
        daItemProdMar.Update(dsItemProdMar, "parts")

        Grid3.UpdateData()
        BindingContext(dsContacts, "cont").EndCurrentEdit()
        For x = 0 To dsContacts.Tables("cont").Rows.Count - 1
            If dsContacts.Tables("cont").Rows(x).RowState <> DataRowState.Deleted Then
                dsContacts.Tables("cont").Rows(x).Item("cust_cont_cust_serial") = CLng(KeyValue1)
            End If
        Next
        daContacts.Update(dsContacts, "cont")

        grThirdParty.UpdateData()
        BindingContext(dsThirdParty, "ship").EndCurrentEdit()
        For x = 0 To dsThirdParty.Tables("ship").Rows.Count - 1
            If dsThirdParty.Tables("ship").Rows(x).RowState <> DataRowState.Deleted Then
                dsThirdParty.Tables("ship").Rows(x).Item("cust_ship_cust_serial") = CLng(KeyValue1)
            End If
        Next
        daThirdParty.Update(dsThirdParty, "ship")

        If (Me.onEmailReceipts = False) And (Me.cbEmailReceipts.Checked) Then
            Dim cmd As New SqlCommand("update pay_itm set pay_itm_sent_cust=1 where pay_itm_pay_serial in (select pay_serial from pay_file where pay_cust_id='" + Me.tCust_ID.Text + "')", cnn)
            cmd.ExecuteNonQuery()
        End If

        cnn.Close()
    End Sub
    Public Overrides Sub find()
        Try
            Dim fm As New fmFind
            Dim flds As jFld
            fm.frm = Me
            fm.Sort = "cust_id"
            fm.ShowInactive = True

            fm.flds = New Collection

            flds = New jFld
            flds.Field = "cust_serial"
            flds.FieldName = "Cust No"
            flds.FieldType = "Numeric"
            flds.Searchable = False
            fm.flds.Add(flds)

            flds = New jFld
            flds.Field = "cust_id"
            flds.FieldName = "Customer ID"
            flds.FieldType = "String"
            flds.SearchAll = False
            flds.Searchable = True
            fm.flds.Add(flds)

            flds = New jFld
            flds.Field = "cust_name"
            flds.FieldName = "Customer Name"
            flds.FieldType = "String"
            flds.SearchAll = True
            flds.Searchable = True
            fm.flds.Add(flds)

            flds = New jFld
            flds.Field = "cust_company"
            flds.FieldName = "Company"
            flds.FieldType = "String"
            flds.SearchAll = True
            flds.Searchable = True
            fm.flds.Add(flds)

            fm.ShowDialog()
            LoadFields(Me)
            EditButtons("Idle")
            LoadItemPrices()
            LoadGrid(grDiscounts, daDiscounts, dsDiscounts, "select * from cust_disc where cust_disc_cust_serial='" + KeyValue1 + "'", "discounts")
            LoadGrid(Grid2, daItemProdMar, dsItemProdMar, "select * from cust_prod_mar where cust_prod_mar_cust_serial='" + KeyValue1 + "' order by cust_prod_mar_type,cust_prod_mar_start", "parts")
            LoadGrid(Grid3, daContacts, dsContacts, "select * from cust_cont where cust_cont_cust_serial=" + KeyValue1 + "", "cont")
            LoadGrid(grThirdParty, daThirdParty, dsThirdParty, "select * from cust_ship where cust_ship_cust_serial=" + KeyValue1 + "", "ship")
            LoadEmailsSent()
            tCopyFrom.Text = ""
            tCopyFromPrice.Text = ""
            UpdateCountry()
            If tNotes.Enabled = False Then
                tNotes.ReadOnly = True
                tNotes.Enabled = True
            Else
                tNotes.ReadOnly = False
            End If
        Catch
            DoError(Err, MainForm)
        End Try
        'MsgBox(" " + Grid2.DisplayLayout.Override.AllowUpdate.ToString)
    End Sub
    Private Sub LoadItemPrices()
        Dim Wherex As String = ""
        If tFilter.Text <> "" Then Wherex = " and cust_itm_price.cust_itm_price_itm_code like '" + tFilter.Text + "%' "
        If chCurrentPrice.Checked Then
            LoadGrid(Grid1, daItemPrices, dsItemPrices, "select * from cust_itm_price where cust_itm_price_cust_serial='" + KeyValue1 + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "' " + Wherex + " order by cust_itm_price_itm_code,cust_itm_price_start", "parts")
        Else
            LoadGrid(Grid1, daItemPrices, dsItemPrices, "select * from cust_itm_price where cust_itm_price.cust_itm_price_cust_serial='" + KeyValue1 + "' " + Wherex + " order by cust_itm_price.cust_itm_price_itm_code,cust_itm_price.cust_itm_price_start", "parts")
        End If
    End Sub
    Private Sub Grid1_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterCellActivate
        If Grid1.ActiveRow.Cells(0).Value Is DBNull.Value Then
            Grid1.ActiveCell.Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
        Else
            If Grid1.ActiveCell.Column.Header.Caption = "End Date" Then
                Grid1.ActiveCell.Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
            Else
                Grid1.ActiveCell.Activation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
            End If
        End If
        If Grid1.ActiveCell.Text <> "" Then Exit Sub
        Select Case Grid1.ActiveCell.Column.Header.Caption
            Case "From Qty"
                Grid1.ActiveCell.Value = "1"
            Case "To Qty"
                Grid1.ActiveCell.Value = "999999"
            Case "Start Date"
                Grid1.ActiveCell.Value = Today
            Case "End Date"
                Grid1.ActiveCell.Value = "12/31/2099"
        End Select
    End Sub

    Private Sub Grid2_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid2.AfterCellActivate
        'If Grid2.ActiveRow.Cells(0).Value Is DBNull.Value Then
        Grid2.ActiveCell.Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
        'Else
        '    If Grid2.ActiveCell.Column.Header.Caption = "End Date" Then
        '        Grid2.ActiveCell.Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
        '    Else
        '        Grid2.ActiveCell.Activation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        '    End If
        'End If
        If Grid2.ActiveCell.Text <> "" Then Exit Sub
        Select Case Grid2.ActiveCell.Column.Header.Caption
            Case "From Qty"
                Grid2.ActiveCell.Value = "1"
            Case "To Qty"
                Grid2.ActiveCell.Value = "999999"
            Case "Start Date"
                Grid2.ActiveCell.Value = Today
            Case "End Date"
                Grid2.ActiveCell.Value = "12/31/2099"
        End Select
    End Sub


    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim rw As DataRow

        Dim cmd As New SqlCommand("select cust_prod_mar_cust_serial from cust_prod_mar where cust_prod_mar_cust_id='" + tCopyFrom.Text + "'", cnn)
        cnn.Open()
        Dim x = nz(cmd.ExecuteScalar, 0)
        cnn.Close()

        Dim cmd2 As New SqlCommand("select * from cust_prod_mar where cust_prod_mar_cust_serial=" + x.ToString, cnn)
        Dim dr As SqlDataReader

        cnn.Open()
        dr = cmd2.ExecuteReader
        Do While dr.Read
            rw = dsItemProdMar.Tables(0).NewRow
            rw("cust_prod_mar_type") = dr("cust_prod_mar_type")
            rw("cust_prod_mar_to") = dr("cust_prod_mar_to")
            rw("cust_prod_mar_from") = dr("cust_prod_mar_from")
            rw("cust_prod_mar_margin") = dr("cust_prod_mar_margin")
            rw("cust_prod_mar_start") = dr("cust_prod_mar_start")
            rw("cust_prod_mar_end") = dr("cust_prod_mar_end")
            dsItemProdMar.Tables(0).Rows.Add(rw)
        Loop
        dr.Close()
        cnn.Close()

    End Sub

    Public Overrides Sub Add_Before()
        tNotes.ReadOnly = False
        chCurrentPrice.Enabled = False
        tFilter.Enabled = False
        dsItemPrices.Clear()
        dsItemProdMar.Clear()
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Dim rw As DataRow
        Dim cmd As New SqlCommand("select * from cust_itm_price where cust_itm_price_cust_id='" + tCopyFromPrice.Text + "'", cnn)
        Dim dr As SqlDataReader

        cnn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            rw = dsItemPrices.Tables(0).NewRow
            rw("cust_itm_price_itm_code") = dr("cust_itm_price_itm_code")
            rw("cust_itm_price_to") = dr("cust_itm_price_to")
            rw("cust_itm_price_from") = dr("cust_itm_price_from")
            rw("cust_itm_price_price") = dr("cust_itm_price_price")
            rw("cust_itm_price_start") = dr("cust_itm_price_start")
            rw("cust_itm_price_end") = dr("cust_itm_price_end")
            dsItemPrices.Tables(0).Rows.Add(rw)
        Loop
        dr.Close()
        cnn.Close()
    End Sub

    Private Sub tCountry_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tCountry.InitializeLayout
    End Sub
    Private Sub tCountry_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCountry.Leave
        UpdateCountry()
    End Sub
    Private Sub UpdateCountry()
        Try
            If tCountry.Text = "" Then Exit Sub
            Dim cmd As New SqlCommand("select * from country_file where country_code='" + tCountry.Text + "'", cnn)
            Dim dr As SqlDataReader
            cnn.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If dr("country_addr1") = 1 Then
                    tAddr1.Visible = True
                    lAddr1.Visible = True
                Else
                    tAddr1.Visible = False
                    lAddr1.Visible = False
                End If
                If dr("country_addr2") = 1 Then
                    tAddr2.Visible = True
                    lAddr2.Visible = True
                Else
                    tAddr2.Visible = False
                    lAddr2.Visible = False
                End If
                If dr("country_addr3") = 1 Then
                    tAddr3.Visible = True
                    lAddr3.Visible = True
                Else
                    tAddr3.Visible = False
                    lAddr3.Visible = False
                End If
                lZip.Text = ""
                If dr("country_city") = 1 Then
                    tCity.Visible = True
                    lZip.Text = tZip.Text + "City,"
                Else
                    tCity.Visible = False
                End If
                If dr("country_state") = 1 Then
                    tState.Visible = True
                    lZip.Text = tZip.Text + "State,"
                Else
                    tState.Visible = False
                End If
                If dr("country_zip") = 1 Then
                    tZip.Visible = True
                    lZip.Text = tZip.Text + "Zip,"
                Else
                    tZip.Visible = False
                End If
                If Len(lZip.Text) > 1 Then lZip.Text = Mid(lZip.Text, 1, Len(lZip.Text) - 1)
                If dr("country_county") = 1 Then
                    tCounty.Visible = True
                    lCounty.Visible = True
                Else
                    tCounty.Visible = False
                    lCounty.Visible = False
                End If
                If dr("country_province") = 1 Then
                    tProvince.Visible = True
                    lProvince.Visible = True
                Else
                    tProvince.Visible = False
                    lProvince.Visible = False
                End If
                If Not dr("country_phone_mask") Is DBNull.Value Then
                    tphone1.InputMask = dr("country_phone_mask")
                    tphone2.InputMask = dr("country_phone_mask")
                    tfax.InputMask = dr("country_phone_mask")
                    taltphone.InputMask = dr("country_phone_mask")
                    tcell.InputMask = dr("country_phone_mask")
                End If
            End If
            cnn.Close()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Private Sub tZip_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tZip.ValueChanged

    End Sub

    Private Sub tZip_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tZip.LostFocus
    End Sub

    Private Sub tCity_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tCity.InitializeLayout

    End Sub

    Private Sub tCity_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCity.LostFocus
        Try
            If tCity.IsItemInList(tCity.Value) = True Then
                tState.Text = tCity.ActiveRow.Cells(1).Text
                tCounty.Text = tCity.ActiveRow.Cells(2).Text
                'If tState.Text <> "" And tTaxExempt.Checked = False Then tTaxRate.Text = CheckTaxRate(tState.Text, tCounty.Text)
            End If
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Private Sub tZip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tZip.Leave
        If tZip.Text <> onZip Then
            tCity.Text = ""
            tState.Text = ""
            tCounty.Text = ""
        End If
        If tZip.Text = "" Then Exit Sub
        If dsZip.Tables.Count > 0 Then dsZip.Tables.RemoveAt(0)
        LoadDD(tCity, dsZip, "zip_file", "zip_city", "zip_city", "zip_city,zip_state,zip_county_name", "zip_code='" + tZip.Text + "'")
        'tCity.DataSource = dsZip.Tables(0)
        'tCity.DataBind()

    End Sub

    Private Sub tZip_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tZip.GotFocus
    End Sub

    Private Sub tZip_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tZip.Enter
        onZip = tZip.Text
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tCity.ToggleDropdown()
    End Sub

    Private Sub tCity_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCity.Enter
        If tCity.Rows.Count = 1 Then
            tCity.Text = tCity.Rows(0).Cells(0).Text
        Else
            If tCity.IsDroppedDown = False Then tCity.ToggleDropdown()
        End If

    End Sub

    Private Sub UltraLabel13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraLabel13.Click

    End Sub

    Private Sub tState_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tState.ValueChanged

    End Sub

    Private Sub tState_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tState.Leave
        'If onState <> tState.Text And tState.Text <> "" And tTaxExempt.Checked = False Then tTaxRate.Text = CheckTaxRate(tState.Text, tCounty.Text)
    End Sub
    Private Sub tState_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tState.Enter
        onState = tState.Text
    End Sub

    Private Sub tCounty_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCounty.ValueChanged

    End Sub

    Private Sub tCounty_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCounty.Enter
        onCounty = tCounty.Text
    End Sub

    Private Sub tCounty_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCounty.Leave
        'If onCounty <> tCounty.Text And tState.Text <> "" And tTaxExempt.Checked = False Then tTaxRate.Text = CheckTaxRate(tState.Text, tCounty.Text)

    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        Select Case e.Tab.Text
            Case "Documents"
                Docs.Nodes.Clear()
                Dim nd As New Infragistics.Win.UltraWinTree.UltraTreeNode
                nd.Key = "Root"
                nd.Text = tCust_ID.Text
                nd.Expanded = True
                Docs.Nodes.Add(nd)
                LookDir("\\10.0.0.245\sales$\Catalog\" + tCust_ID.Text, Docs.Nodes(0))
        End Select
    End Sub
    Private Sub LookDir(ByVal dirs As String, ByVal onND As Infragistics.Win.UltraWinTree.UltraTreeNode)
        If IO.Directory.Exists(dirs) = False Then Exit Sub
        Dim dr As String
        Dim nd As Infragistics.Win.UltraWinTree.UltraTreeNode

        For Each dr In IO.Directory.GetDirectories(dirs)
            nd = New Infragistics.Win.UltraWinTree.UltraTreeNode
            nd.Key = dr
            nd.Text = IO.Path.GetFileName(dr)
            nd.Override.NodeAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
            nd.LeftImages.Add(ImageList1.Images(0))
            If nd.Text = CStr(Year(Today)) Then nd.Expanded = True
            onND.Nodes.Add(nd)
            LookDir(dr, nd)
        Next
        For Each dr In IO.Directory.GetFiles(dirs)
            nd = New Infragistics.Win.UltraWinTree.UltraTreeNode
            nd.Key = dr
            nd.Text = IO.Path.GetFileName(dr)
            onND.Nodes.Add(nd)
        Next

    End Sub
    Public Overrides Sub Delete()

    End Sub

    Public Overrides Sub Add_After()
        tCountry.Value = "USA"

    End Sub

    Private Sub tTaxExempt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTaxExempt.CheckedChanged

    End Sub

    Private Sub tTaxRate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Overrides Sub Save_Before()
        'If tTaxExempt.Checked = False Then
        'If tTaxRate.Value = 0 Then
        'MsgBox("Must have a Tax Rate.", MsgBoxStyle.Exclamation, "Tax Rate?")
        'SaveCanceled = True
        'Exit Sub
        'End If
        'End If
        If tCust_ID.Text = "" Then
            MsgBox("You must enter a Customer ID.", MsgBoxStyle.Critical, "ID?")
            SaveCanceled = True
            Exit Sub
        End If
        If cbBillable.Checked And tBillableEmails.Text = "" Then
            MsgBox("You must enter an email for billable customers.  This is where the bill will be sent to.", MsgBoxStyle.Critical, "Billable?")
            SaveCanceled = True
            Exit Sub
        End If
        chCurrentPrice.Enabled = True
        tFilter.Enabled = True
    End Sub

    Private Sub Grid2_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid2.InitializeLayout

    End Sub

    Private Sub chCurrentPrice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chCurrentPrice.CheckedChanged
        LoadItemPrices()
    End Sub

    Public Overrides Sub Edit_Before()
        tNotes.ReadOnly = False
        chCurrentPrice.Enabled = False
        tFilter.Enabled = False
        Me.onEmailReceipts = Me.cbEmailReceipts.Checked
        'Grid2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
    End Sub

    Public Overrides Sub Cancel_After()
        chCurrentPrice.Enabled = True
        tFilter.Enabled = True
        dsItemProdMar.Clear()
    End Sub

    Private Sub tFilter_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFilter.ValueChanged
        LoadItemPrices()
    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub Docs_AfterSelect(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTree.SelectEventArgs) Handles Docs.AfterSelect

    End Sub

    Private Sub Docs_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Docs.DoubleClick
        Try
            Dim hwnd As Long
            Dim myProc As New Process
            myProc.StartInfo.FileName = Docs.ActiveNode.Key
            myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProc.Start()
        Catch
            DoError(Err, Me)
        End Try

    End Sub

    Private Sub UltraButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        Dim app As New Outlook.Application
        Dim mailx As Outlook.MailItem
        Dim nd As Infragistics.Win.UltraWinTree.UltraTreeNode

        Try
            mailx = app.CreateItem(Outlook.OlItemType.olMailItem)
            For Each nd In Docs.SelectedNodes
                If nd.Override.NodeAppearance.FontData.Bold <> Infragistics.Win.DefaultableBoolean.True Then mailx.Attachments.Add(nd.Key)
            Next
            mailx.Display()
        Catch
            DoError(Err, Me)
        End Try

    End Sub

    Private Sub bDocPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDocPrint.Click
        Try
            Dim hwnd As Long
            Dim myProc As Process
            Dim nd As Infragistics.Win.UltraWinTree.UltraTreeNode

            For Each nd In Docs.SelectedNodes
                If nd.Override.NodeAppearance.FontData.Bold <> Infragistics.Win.DefaultableBoolean.True Then
                    myProc = New Process

                    myProc.StartInfo.FileName = nd.Key
                    myProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    myProc.StartInfo.Verb = "Print"
                    myProc.Start()
                    Try
                        myProc.CloseMainWindow()
                    Catch
                    End Try
                End If
            Next
        Catch
            DoError(Err, Me)
        End Try

    End Sub
    Private Sub LoadEmailsSent()
        Dim cmd As New SqlCommand("", cnn)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)

        cmd.CommandText = "select * from emails_sent where es_cust_serial=" + cust_serial.Text + " order by es_date desc"
        da.Fill(dt)

        gEmails.DataSource = dt
        gEmails.DataBind()

        If dt.Rows.Count = 0 Then
            bResendEmail.Visible = False
            tEmailBody.DocumentText = ""
        End If

    End Sub

    Private Sub bResendEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bResendEmail.Click
        Dim ol As New Outlook.Application
        Dim mess As Outlook.MailItem
        mess = ol.CreateItem(Outlook.OlItemType.olMailItem)

        mess.To = gEmails.ActiveRow.Cells("es_to").Value
        mess.Subject = gEmails.ActiveRow.Cells("es_subj").Value
        mess.HTMLBody = gEmails.ActiveRow.Cells("es_email").Value

        Dim att As String
        For Each att In Split(gEmails.ActiveRow.Cells("es_attachments").Value, ";")
            mess.Attachments.Add(att)
        Next

        mess.Display()

        ol = Nothing
    End Sub

    Private Sub gEmails_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles gEmails.AfterRowActivate
        Dim htmlx As String

        htmlx = gEmails.ActiveRow.Cells("es_email").Value
        tEmailBody.DocumentText = htmlx
        bResendEmail.Visible = True

        If Split(gEmails.ActiveRow.Cells("es_attachments").Value, ";").Length > 0 Then
            tAttach1.Text = IO.Path.GetFileName(Split(gEmails.ActiveRow.Cells("es_attachments").Value, ";")(0))
            tAttach1.Tag = Split(gEmails.ActiveRow.Cells("es_attachments").Value, ";")(0)
        Else
            tAttach1.Visible = False
        End If
        If Split(gEmails.ActiveRow.Cells("es_attachments").Value, ";").Length > 1 Then
            tAttach2.Text = IO.Path.GetFileName(Split(gEmails.ActiveRow.Cells("es_attachments").Value, ";")(1))
            tAttach2.Tag = Split(gEmails.ActiveRow.Cells("es_attachments").Value, ";")(1)
        Else
            tAttach2.Visible = False
        End If
    End Sub

    Private Sub gEmails_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gEmails.InitializeLayout

    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        tEmailBody.GoBack()
    End Sub

    Private Sub tAttach1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tAttach1.Click
        Try
            Dim hwnd As Long
            Dim myProc As New Process
            myProc.StartInfo.FileName = tAttach1.Tag
            myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProc.Start()
        Catch
            DoError(Err, Me)
        End Try

    End Sub

    Private Sub tAttach2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tAttach2.Click
        Try
            Dim hwnd As Long
            Dim myProc As New Process
            myProc.StartInfo.FileName = tAttach2.Tag
            myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProc.Start()
        Catch
            DoError(Err, Me)
        End Try
    End Sub
End Class
