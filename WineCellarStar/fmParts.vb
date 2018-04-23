Public Class fmParts
    Inherits WineCellar.fmStarter
    Public daPrices As New SqlClient.SqlDataAdapter
    Public dsPrices As New DataSet
    Public dvPrices As New DataView
    Private dsProdTypes As New DataSet
    Private dsMat As New DataSet
    Private dsFin As New DataSet
    Private dsColor As New DataSet
    Private dsDefProd As New DataSet
    Private dsDefMatl As New DataSet
    Private dsBoxes As New DataSet
    Private daBoxes As New SqlClient.SqlDataAdapter
    Private dsUpsell As New DataSet
    Private daUpsell As New SqlClient.SqlDataAdapter
    Private dsBottles As New DataSet
    Private dsImages As New DataSet
    Private daImages As New SqlClient.SqlDataAdapter
    Private onFindForm As fmFind
    Friend WithEvents tPriceTrackInches As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel35 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraCheckEditor14 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chItmPricing As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Private onParent As String

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
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tPart As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraCheckEditor1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraCheckEditor2 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Open1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tProdType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraCheckEditor4 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chMaterial As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents tMatDef As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tFinish As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor9 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraCheckEditor3 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chChangePrice As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbUpColor As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ddColor As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tColorPerc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents TabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTextEditor10 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Tab1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cbDiscount As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraCheckEditor6 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents tDiscDefPerc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tDiscDefProd As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tDiscDefMatl As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tUpDefMatl As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tUpDefProd As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tUpDefPerc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraCheckEditor7 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor11 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor12 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor13 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraCheckEditor8 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tComProdType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraCheckEditor9 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grBoxes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tStainBottles As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tLacqBottles As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ddSearchStain As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tWoodFactor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chAllow0Base As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents tStain As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tCommProdType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gUpSell As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tWidth As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tHeight As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tDepth As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraCheckEditor10 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraCheckEditor11 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraCheckEditor12 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tGroup As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTextEditor6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTextEditor7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cbTaxable As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraCheckEditor5 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gImages As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tPicture As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTextEditor8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ddClass As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel33 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel34 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tParent As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tBottleCapacity As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lBottleCapacity As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraCheckEditor13 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_itm_serial")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_itm_code")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_type")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_qty_from")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_qty_to")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_price")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_start")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_end")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_sale")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_flat_rate")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_price_created")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_pirce_updated")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_box_serial")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_box_itm_code")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_box_name")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_box_len")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_box_width")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_box_height")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_box_weight")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_box_dept")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("upsell_serial")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("upsell_parent_itm_code")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("upsell_type")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("upsell_group")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("upsell_child_itm_code")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("upsell_formula")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("upsell_shipping")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("upsell_line_note")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_img_serial")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_img_itm_code")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_img_path")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_img_order")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.TabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTextEditor10 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTextEditor13 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTextEditor12 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTextEditor11 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraCheckEditor7 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.grBoxes = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.gUpSell = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.tPicture = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.gImages = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTextEditor4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTextEditor5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDiscount = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.tProdType = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tMatDef = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.tFinish = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTextEditor9 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraCheckEditor3 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbTaxable = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chChangePrice = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbUpColor = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ddColor = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tColorPerc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraCheckEditor6 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.tDiscDefPerc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tDiscDefProd = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tDiscDefMatl = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tUpDefMatl = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tUpDefProd = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tUpDefPerc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraCheckEditor8 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.tComProdType = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraCheckEditor9 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel
        Me.tStainBottles = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tLacqBottles = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.ddSearchStain = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tWoodFactor = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel
        Me.chAllow0Base = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.tStain = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel
        Me.tCommProdType = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.tPart = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraCheckEditor2 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraCheckEditor1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraCheckEditor4 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chMaterial = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.Open1 = New System.Windows.Forms.OpenFileDialog
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.Tab1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel
        Me.tWidth = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tHeight = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tDepth = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraCheckEditor10 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraCheckEditor11 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraCheckEditor12 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel
        Me.tGroup = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTextEditor3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraTextEditor6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraTextEditor7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraCheckEditor5 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraTextEditor8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel
        Me.ddClass = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel33 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel34 = New Infragistics.Win.Misc.UltraLabel
        Me.tParent = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tBottleCapacity = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lBottleCapacity = New Infragistics.Win.Misc.UltraLabel
        Me.UltraCheckEditor13 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.tPriceTrackInches = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel35 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraCheckEditor14 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chItmPricing = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.TabPageControl1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraTextEditor10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraTextEditor13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.grBoxes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.gUpSell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.gImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tProdType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tMatDef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tFinish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTaxable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chChangePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbUpColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tColorPerc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDiscDefPerc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDiscDefProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDiscDefMatl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tUpDefMatl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tUpDefProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tUpDefPerc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tComProdType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tStainBottles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLacqBottles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddSearchStain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tWoodFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chAllow0Base, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tStain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCommProdType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab1.SuspendLayout()
        CType(Me.tWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDepth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tParent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBottleCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPriceTrackInches, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chItmPricing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPageControl1
        '
        Me.TabPageControl1.Controls.Add(Me.Grid1)
        Me.TabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.TabPageControl1.Name = "TabPageControl1"
        Me.TabPageControl1.Size = New System.Drawing.Size(1217, 483)
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.Grid1.DisplayLayout.Appearance = Appearance1
        Me.Grid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 102
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 99
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Width = 118
        UltraGridColumn4.Header.Caption = "Type"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 124
        UltraGridColumn5.Header.Caption = "Qty From"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MinWidth = 100
        UltraGridColumn5.Width = 101
        UltraGridColumn6.Header.Caption = "Qty To"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.MinWidth = 100
        UltraGridColumn6.Width = 140
        UltraGridColumn7.Format = "$#,###,##0.00"
        UltraGridColumn7.Header.Caption = "Price"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 132
        UltraGridColumn8.Header.Caption = "Start Date"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownCalendar
        UltraGridColumn8.Width = 367
        UltraGridColumn9.Header.Caption = "End Date"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownCalendar
        UltraGridColumn9.Width = 179
        UltraGridColumn10.Header.Caption = "Sale"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn10.Width = 86
        UltraGridColumn11.Header.Caption = "Flat Rate"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn11.Width = 98
        UltraGridColumn12.Format = "MM/dd/yyy hh:mm"
        UltraGridColumn12.Header.Caption = "Created"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Width = 99
        UltraGridColumn13.Format = "MM/dd/yyy hh:mm"
        UltraGridColumn13.Header.Caption = "Updated"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Width = 104
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.InterBandSpacing = 10
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.Grid1.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.AliceBlue
        Appearance3.BackColor2 = System.Drawing.Color.LightSteelBlue
        Appearance3.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.Grid1.DisplayLayout.Override.CellAppearance = Appearance3
        Me.Grid1.DisplayLayout.Override.CellSpacing = 2
        Appearance4.BackColor = System.Drawing.Color.LightSteelBlue
        Appearance4.FontData.Name = "Verdana"
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid1.DisplayLayout.Override.HeaderAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.RowAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid1.DisplayLayout.Override.RowSelectorAppearance = Appearance6
        Me.Grid1.DisplayLayout.Override.RowSelectorWidth = 10
        Me.Grid1.DisplayLayout.Override.RowSpacingAfter = 0
        Me.Grid1.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance7.BackColor = System.Drawing.Color.Blue
        Appearance7.BackColor2 = System.Drawing.Color.LightSteelBlue
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.Grid1.DisplayLayout.Override.SelectedRowAppearance = Appearance7
        Me.Grid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1220, 486)
        Me.Grid1.TabIndex = 14
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1217, 483)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1217, 483)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1217, 483)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1217, 483)
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1217, 483)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTextEditor10)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1217, 483)
        '
        'UltraTextEditor10
        '
        Me.UltraTextEditor10.AcceptsReturn = True
        Me.UltraTextEditor10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraTextEditor10.Appearance = Appearance8
        Me.UltraTextEditor10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraTextEditor10.Enabled = False
        Me.UltraTextEditor10.Location = New System.Drawing.Point(6, 7)
        Me.UltraTextEditor10.Multiline = True
        Me.UltraTextEditor10.Name = "UltraTextEditor10"
        Me.UltraTextEditor10.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.UltraTextEditor10.Size = New System.Drawing.Size(1205, 469)
        Me.UltraTextEditor10.TabIndex = 20
        Me.UltraTextEditor10.Tag = "edit;itm_note"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraLabel20)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraTextEditor13)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraLabel19)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraTextEditor12)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraLabel18)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraTextEditor11)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraCheckEditor7)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1217, 483)
        '
        'UltraLabel20
        '
        Me.UltraLabel20.BackColorInternal = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(16, 104)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(120, 16)
        Me.UltraLabel20.TabIndex = 68
        Me.UltraLabel20.Text = "NOT to Item Codes"
        '
        'UltraTextEditor13
        '
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor13.Appearance = Appearance9
        Me.UltraTextEditor13.Enabled = False
        Me.UltraTextEditor13.Location = New System.Drawing.Point(152, 104)
        Me.UltraTextEditor13.Name = "UltraTextEditor13"
        Me.UltraTextEditor13.Size = New System.Drawing.Size(672, 21)
        Me.UltraTextEditor13.TabIndex = 67
        Me.UltraTextEditor13.Tag = "edit;itm_perc_itemcodes"
        '
        'UltraLabel19
        '
        Me.UltraLabel19.BackColorInternal = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(16, 72)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(120, 16)
        Me.UltraLabel19.TabIndex = 66
        Me.UltraLabel19.Text = "Applies to Prod Types"
        '
        'UltraTextEditor12
        '
        Appearance10.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor12.Appearance = Appearance10
        Me.UltraTextEditor12.Enabled = False
        Me.UltraTextEditor12.Location = New System.Drawing.Point(152, 72)
        Me.UltraTextEditor12.Name = "UltraTextEditor12"
        Me.UltraTextEditor12.Size = New System.Drawing.Size(672, 21)
        Me.UltraTextEditor12.TabIndex = 65
        Me.UltraTextEditor12.Tag = "edit;itm_perc_prodtypes"
        '
        'UltraLabel18
        '
        Me.UltraLabel18.BackColorInternal = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(16, 40)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel18.TabIndex = 64
        Me.UltraLabel18.Text = "Percentage"
        '
        'UltraTextEditor11
        '
        Appearance11.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor11.Appearance = Appearance11
        Me.UltraTextEditor11.Enabled = False
        Me.UltraTextEditor11.Location = New System.Drawing.Point(88, 40)
        Me.UltraTextEditor11.Name = "UltraTextEditor11"
        Me.UltraTextEditor11.Size = New System.Drawing.Size(48, 21)
        Me.UltraTextEditor11.TabIndex = 63
        Me.UltraTextEditor11.Tag = "edit;itm_perc_price;nm"
        '
        'UltraCheckEditor7
        '
        Appearance12.FontData.BoldAsString = "True"
        Me.UltraCheckEditor7.Appearance = Appearance12
        Me.UltraCheckEditor7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraCheckEditor7.BackColorInternal = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraCheckEditor7.Enabled = False
        Me.UltraCheckEditor7.Location = New System.Drawing.Point(16, 16)
        Me.UltraCheckEditor7.Name = "UltraCheckEditor7"
        Me.UltraCheckEditor7.Size = New System.Drawing.Size(248, 16)
        Me.UltraCheckEditor7.TabIndex = 54
        Me.UltraCheckEditor7.Tag = "edit;itm_is_perc_price;cb"
        Me.UltraCheckEditor7.Text = "Item is Percentage Pricing"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.grBoxes)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1217, 483)
        '
        'grBoxes
        '
        Me.grBoxes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grBoxes.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.grBoxes.DisplayLayout.Appearance = Appearance13
        Me.grBoxes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.Width = 149
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.Width = 188
        UltraGridColumn16.Header.Caption = "Box Name"
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.Width = 78
        UltraGridColumn17.Header.Caption = "Length (inches)"
        UltraGridColumn17.Header.VisiblePosition = 3
        UltraGridColumn17.Width = 320
        UltraGridColumn18.Header.Caption = "Width (inches)"
        UltraGridColumn18.Header.VisiblePosition = 4
        UltraGridColumn18.Width = 228
        UltraGridColumn19.Header.Caption = "Height (inches)"
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn19.Width = 226
        UltraGridColumn20.Header.Caption = "Weight (lbs)"
        UltraGridColumn20.Header.VisiblePosition = 6
        UltraGridColumn20.Width = 228
        UltraGridColumn21.Header.Caption = "Department"
        UltraGridColumn21.Header.VisiblePosition = 7
        UltraGridColumn21.Width = 112
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21})
        Me.grBoxes.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grBoxes.DisplayLayout.InterBandSpacing = 10
        Me.grBoxes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grBoxes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.grBoxes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grBoxes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.grBoxes.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.grBoxes.DisplayLayout.Override.CardAreaAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.Color.AliceBlue
        Appearance15.BackColor2 = System.Drawing.Color.LightSteelBlue
        Appearance15.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.grBoxes.DisplayLayout.Override.CellAppearance = Appearance15
        Me.grBoxes.DisplayLayout.Override.CellSpacing = 2
        Appearance16.BackColor = System.Drawing.Color.LightSteelBlue
        Appearance16.FontData.Name = "Verdana"
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Appearance16.TextHAlignAsString = "Left"
        Appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.grBoxes.DisplayLayout.Override.HeaderAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.grBoxes.DisplayLayout.Override.RowAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grBoxes.DisplayLayout.Override.RowSelectorAppearance = Appearance18
        Me.grBoxes.DisplayLayout.Override.RowSelectorWidth = 10
        Me.grBoxes.DisplayLayout.Override.RowSpacingAfter = 0
        Me.grBoxes.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance19.BackColor = System.Drawing.Color.Blue
        Appearance19.BackColor2 = System.Drawing.Color.LightSteelBlue
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.grBoxes.DisplayLayout.Override.SelectedRowAppearance = Appearance19
        Me.grBoxes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.grBoxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grBoxes.Location = New System.Drawing.Point(0, 0)
        Me.grBoxes.Name = "grBoxes"
        Me.grBoxes.Size = New System.Drawing.Size(1221, 484)
        Me.grBoxes.TabIndex = 15
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.gUpSell)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1217, 483)
        '
        'gUpSell
        '
        Me.gUpSell.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gUpSell.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.gUpSell.DisplayLayout.Appearance = Appearance20
        Me.gUpSell.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn22.Header.VisiblePosition = 0
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.Width = 89
        UltraGridColumn23.Header.VisiblePosition = 1
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.Width = 179
        UltraGridColumn24.Header.Caption = "Type"
        UltraGridColumn24.Header.VisiblePosition = 2
        UltraGridColumn24.Width = 156
        UltraGridColumn25.Header.Caption = "Group"
        UltraGridColumn25.Header.VisiblePosition = 3
        UltraGridColumn25.Width = 234
        UltraGridColumn26.Header.Caption = "Item Code"
        UltraGridColumn26.Header.VisiblePosition = 4
        UltraGridColumn26.Width = 230
        UltraGridColumn27.Header.Caption = "Formula"
        UltraGridColumn27.Header.VisiblePosition = 5
        UltraGridColumn27.Width = 191
        UltraGridColumn28.Header.Caption = "Shipping"
        UltraGridColumn28.Header.VisiblePosition = 6
        UltraGridColumn28.Width = 191
        UltraGridColumn29.Header.Caption = "Line Note"
        UltraGridColumn29.Header.VisiblePosition = 7
        UltraGridColumn29.Width = 191
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29})
        Me.gUpSell.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.gUpSell.DisplayLayout.InterBandSpacing = 10
        Me.gUpSell.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.gUpSell.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.gUpSell.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gUpSell.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.gUpSell.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Me.gUpSell.DisplayLayout.Override.CardAreaAppearance = Appearance21
        Appearance22.BackColor = System.Drawing.Color.AliceBlue
        Appearance22.BackColor2 = System.Drawing.Color.LightSteelBlue
        Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.gUpSell.DisplayLayout.Override.CellAppearance = Appearance22
        Me.gUpSell.DisplayLayout.Override.CellSpacing = 2
        Appearance23.BackColor = System.Drawing.Color.LightSteelBlue
        Appearance23.FontData.Name = "Verdana"
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Appearance23.TextHAlignAsString = "Left"
        Appearance23.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.gUpSell.DisplayLayout.Override.HeaderAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Me.gUpSell.DisplayLayout.Override.RowAppearance = Appearance24
        Appearance25.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gUpSell.DisplayLayout.Override.RowSelectorAppearance = Appearance25
        Me.gUpSell.DisplayLayout.Override.RowSelectorWidth = 10
        Me.gUpSell.DisplayLayout.Override.RowSpacingAfter = 0
        Me.gUpSell.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance26.BackColor = System.Drawing.Color.Blue
        Appearance26.BackColor2 = System.Drawing.Color.LightSteelBlue
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.gUpSell.DisplayLayout.Override.SelectedRowAppearance = Appearance26
        Me.gUpSell.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.gUpSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gUpSell.Location = New System.Drawing.Point(-2, -1)
        Me.gUpSell.Name = "gUpSell"
        Me.gUpSell.Size = New System.Drawing.Size(1222, 485)
        Me.gUpSell.TabIndex = 16
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.UltraButton1)
        Me.UltraTabPageControl10.Controls.Add(Me.tPicture)
        Me.UltraTabPageControl10.Controls.Add(Me.gImages)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1217, 483)
        '
        'UltraButton1
        '
        Me.UltraButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton1.Enabled = False
        Me.UltraButton1.Location = New System.Drawing.Point(8, 453)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(96, 24)
        Me.UltraButton1.TabIndex = 31
        Me.UltraButton1.TabStop = False
        Me.UltraButton1.Tag = "edit"
        Me.UltraButton1.Text = "Get Picture"
        '
        'tPicture
        '
        Me.tPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance27.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance27.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.tPicture.Appearance = Appearance27
        Me.tPicture.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tPicture.BorderShadowColor = System.Drawing.Color.Empty
        Me.tPicture.DrawBorderShadow = True
        Me.tPicture.Location = New System.Drawing.Point(632, 0)
        Me.tPicture.Name = "tPicture"
        Me.tPicture.ScaleImage = Infragistics.Win.ScaleImage.Always
        Me.tPicture.Size = New System.Drawing.Size(598, 484)
        Me.tPicture.TabIndex = 29
        '
        'gImages
        '
        Me.gImages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gImages.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.Caption = "Path"
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn32.Width = 571
        UltraGridColumn33.Header.Caption = "Order"
        UltraGridColumn33.Header.VisiblePosition = 3
        UltraGridColumn33.MaxWidth = 50
        UltraGridColumn33.MinWidth = 40
        UltraGridColumn33.Width = 40
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33})
        Me.gImages.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.gImages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gImages.Location = New System.Drawing.Point(0, 0)
        Me.gImages.Name = "gImages"
        Me.gImages.Size = New System.Drawing.Size(632, 445)
        Me.gImages.TabIndex = 0
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(1217, 483)
        '
        'UltraTextEditor1
        '
        Appearance28.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor1.Appearance = Appearance28
        Me.UltraTextEditor1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UltraTextEditor1.Enabled = False
        Me.UltraTextEditor1.Location = New System.Drawing.Point(80, 32)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(168, 21)
        Me.UltraTextEditor1.TabIndex = 1
        Me.UltraTextEditor1.Tag = "edit;itm_iwa_code"
        '
        'UltraLabel5
        '
        Appearance29.FontData.BoldAsString = "False"
        Me.UltraLabel5.Appearance = Appearance29
        Me.UltraLabel5.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(0, 152)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel5.TabIndex = 9
        Me.UltraLabel5.Text = "Product Type"
        '
        'UltraLabel6
        '
        Appearance30.FontData.BoldAsString = "False"
        Me.UltraLabel6.Appearance = Appearance30
        Me.UltraLabel6.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(0, 224)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel6.TabIndex = 11
        Me.UltraLabel6.Text = "Item Shipping $"
        Me.UltraLabel6.Visible = False
        '
        'UltraTextEditor4
        '
        Appearance31.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor4.Appearance = Appearance31
        Me.UltraTextEditor4.Enabled = False
        Me.UltraTextEditor4.Location = New System.Drawing.Point(96, 224)
        Me.UltraTextEditor4.Name = "UltraTextEditor4"
        Me.UltraTextEditor4.Size = New System.Drawing.Size(168, 21)
        Me.UltraTextEditor4.TabIndex = 5
        Me.UltraTextEditor4.Tag = "edit;itm_ship_cost;cu"
        Me.UltraTextEditor4.Visible = False
        '
        'UltraLabel7
        '
        Appearance32.FontData.BoldAsString = "False"
        Me.UltraLabel7.Appearance = Appearance32
        Me.UltraLabel7.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(0, 248)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel7.TabIndex = 13
        Me.UltraLabel7.Text = "Weight"
        '
        'UltraTextEditor5
        '
        Appearance33.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor5.Appearance = Appearance33
        Me.UltraTextEditor5.Enabled = False
        Me.UltraTextEditor5.Location = New System.Drawing.Point(96, 248)
        Me.UltraTextEditor5.Name = "UltraTextEditor5"
        Me.UltraTextEditor5.Size = New System.Drawing.Size(168, 21)
        Me.UltraTextEditor5.TabIndex = 6
        Me.UltraTextEditor5.Tag = "edit;itm_weight;nm"
        '
        'UltraLabel8
        '
        Appearance34.FontData.BoldAsString = "False"
        Me.UltraLabel8.Appearance = Appearance34
        Me.UltraLabel8.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(816, 256)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel8.TabIndex = 19
        Me.UltraLabel8.Text = "Width"
        '
        'cbDiscount
        '
        Appearance35.FontData.BoldAsString = "False"
        Me.cbDiscount.Appearance = Appearance35
        Me.cbDiscount.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cbDiscount.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.cbDiscount.Enabled = False
        Me.cbDiscount.Location = New System.Drawing.Point(256, 96)
        Me.cbDiscount.Name = "cbDiscount"
        Me.cbDiscount.Size = New System.Drawing.Size(144, 16)
        Me.cbDiscount.TabIndex = 53
        Me.cbDiscount.Tag = "edit;itm_disc;cb"
        Me.cbDiscount.Text = "Item is a Discount"
        '
        'tProdType
        '
        Me.tProdType.CheckedListSettings.CheckStateMember = ""
        Me.tProdType.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tProdType.Enabled = False
        Me.tProdType.Location = New System.Drawing.Point(96, 152)
        Me.tProdType.Name = "tProdType"
        Me.tProdType.Size = New System.Drawing.Size(168, 22)
        Me.tProdType.TabIndex = 4
        Me.tProdType.Tag = "edit;itm_prod_type"
        '
        'tMatDef
        '
        Me.tMatDef.CheckedListSettings.CheckStateMember = ""
        Me.tMatDef.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tMatDef.Enabled = False
        Me.tMatDef.Location = New System.Drawing.Point(336, 256)
        Me.tMatDef.Name = "tMatDef"
        Me.tMatDef.Size = New System.Drawing.Size(88, 22)
        Me.tMatDef.TabIndex = 15
        Me.tMatDef.Tag = "edit;itm_material"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.BackColorInternal = System.Drawing.Color.CornflowerBlue
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(280, 256)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel9.TabIndex = 32
        Me.UltraLabel9.Text = "Wood"
        '
        'tFinish
        '
        Me.tFinish.CheckedListSettings.CheckStateMember = ""
        Me.tFinish.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tFinish.Enabled = False
        Me.tFinish.Location = New System.Drawing.Point(336, 280)
        Me.tFinish.Name = "tFinish"
        Me.tFinish.Size = New System.Drawing.Size(88, 22)
        Me.tFinish.TabIndex = 16
        Me.tFinish.Tag = "edit;itm_finish_serial;nm"
        '
        'UltraLabel10
        '
        Me.UltraLabel10.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(280, 280)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel10.TabIndex = 34
        Me.UltraLabel10.Text = "Finish"
        '
        'UltraLabel11
        '
        Appearance36.FontData.BoldAsString = "False"
        Me.UltraLabel11.Appearance = Appearance36
        Me.UltraLabel11.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(0, 56)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel11.TabIndex = 38
        Me.UltraLabel11.Text = "WE Code"
        '
        'UltraTextEditor9
        '
        Appearance37.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor9.Appearance = Appearance37
        Me.UltraTextEditor9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UltraTextEditor9.Enabled = False
        Me.UltraTextEditor9.Location = New System.Drawing.Point(80, 56)
        Me.UltraTextEditor9.Name = "UltraTextEditor9"
        Me.UltraTextEditor9.Size = New System.Drawing.Size(168, 21)
        Me.UltraTextEditor9.TabIndex = 2
        Me.UltraTextEditor9.Tag = "edit;itm_we_code"
        '
        'UltraCheckEditor3
        '
        Appearance38.FontData.BoldAsString = "False"
        Me.UltraCheckEditor3.Appearance = Appearance38
        Me.UltraCheckEditor3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor3.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor3.Enabled = False
        Me.UltraCheckEditor3.Location = New System.Drawing.Point(400, 152)
        Me.UltraCheckEditor3.Name = "UltraCheckEditor3"
        Me.UltraCheckEditor3.Size = New System.Drawing.Size(120, 16)
        Me.UltraCheckEditor3.TabIndex = 17
        Me.UltraCheckEditor3.Tag = "edit;inactive;cb"
        Me.UltraCheckEditor3.Text = "Inactive"
        '
        'cbTaxable
        '
        Appearance39.FontData.BoldAsString = "False"
        Me.cbTaxable.Appearance = Appearance39
        Me.cbTaxable.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cbTaxable.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.cbTaxable.Enabled = False
        Me.cbTaxable.Location = New System.Drawing.Point(624, 8)
        Me.cbTaxable.Name = "cbTaxable"
        Me.cbTaxable.Size = New System.Drawing.Size(168, 16)
        Me.cbTaxable.TabIndex = 43
        Me.cbTaxable.Tag = "edit;itm_taxable;cb"
        Me.cbTaxable.Text = "Taxable"
        '
        'chChangePrice
        '
        Appearance40.FontData.BoldAsString = "False"
        Me.chChangePrice.Appearance = Appearance40
        Me.chChangePrice.BackColor = System.Drawing.Color.LightSteelBlue
        Me.chChangePrice.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.chChangePrice.Enabled = False
        Me.chChangePrice.Location = New System.Drawing.Point(400, 168)
        Me.chChangePrice.Name = "chChangePrice"
        Me.chChangePrice.Size = New System.Drawing.Size(120, 16)
        Me.chChangePrice.TabIndex = 46
        Me.chChangePrice.Tag = "edit;itm_change_price;cb"
        Me.chChangePrice.Text = "Can Change Price"
        '
        'cbUpColor
        '
        Appearance41.FontData.BoldAsString = "True"
        Me.cbUpColor.Appearance = Appearance41
        Me.cbUpColor.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cbUpColor.BackColorInternal = System.Drawing.Color.CornflowerBlue
        Me.cbUpColor.Enabled = False
        Me.cbUpColor.Location = New System.Drawing.Point(448, 256)
        Me.cbUpColor.Name = "cbUpColor"
        Me.cbUpColor.Size = New System.Drawing.Size(88, 16)
        Me.cbUpColor.TabIndex = 47
        Me.cbUpColor.Tag = "edit;itm_up_color;cb"
        Me.cbUpColor.Text = "Upcharge"
        '
        'ddColor
        '
        Me.ddColor.CheckedListSettings.CheckStateMember = ""
        Me.ddColor.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.ddColor.Enabled = False
        Me.ddColor.Location = New System.Drawing.Point(536, 256)
        Me.ddColor.Name = "ddColor"
        Me.ddColor.Size = New System.Drawing.Size(88, 22)
        Me.ddColor.TabIndex = 48
        Me.ddColor.Tag = "edit;itm_up_color_color"
        '
        'tColorPerc
        '
        Appearance42.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tColorPerc.Appearance = Appearance42
        Me.tColorPerc.Enabled = False
        Me.tColorPerc.Location = New System.Drawing.Point(632, 256)
        Me.tColorPerc.Name = "tColorPerc"
        Me.tColorPerc.Size = New System.Drawing.Size(48, 21)
        Me.tColorPerc.TabIndex = 49
        Me.tColorPerc.Tag = "edit;itm_up_color_perc;nm"
        '
        'UltraLabel12
        '
        Me.UltraLabel12.BackColorInternal = System.Drawing.Color.CornflowerBlue
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(680, 256)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel12.TabIndex = 50
        Me.UltraLabel12.Text = "% (9% = 9)"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(272, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 32)
        Me.Label1.TabIndex = 51
        '
        'UltraLabel13
        '
        Me.UltraLabel13.BackColorInternal = System.Drawing.Color.CornflowerBlue
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(544, 256)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(32, 16)
        Me.UltraLabel13.TabIndex = 52
        Me.UltraLabel13.Text = "Color"
        '
        'UltraCheckEditor6
        '
        Appearance43.FontData.BoldAsString = "False"
        Me.UltraCheckEditor6.Appearance = Appearance43
        Me.UltraCheckEditor6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor6.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor6.Enabled = False
        Me.UltraCheckEditor6.Location = New System.Drawing.Point(256, 120)
        Me.UltraCheckEditor6.Name = "UltraCheckEditor6"
        Me.UltraCheckEditor6.Size = New System.Drawing.Size(144, 16)
        Me.UltraCheckEditor6.TabIndex = 54
        Me.UltraCheckEditor6.Tag = "edit;itm_up;cb"
        Me.UltraCheckEditor6.Text = "Item is an Upcharge"
        '
        'tDiscDefPerc
        '
        Appearance44.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tDiscDefPerc.Appearance = Appearance44
        Me.tDiscDefPerc.Enabled = False
        Me.tDiscDefPerc.Location = New System.Drawing.Point(400, 96)
        Me.tDiscDefPerc.Name = "tDiscDefPerc"
        Me.tDiscDefPerc.Size = New System.Drawing.Size(48, 21)
        Me.tDiscDefPerc.TabIndex = 55
        Me.tDiscDefPerc.Tag = "edit;itm_disc_def_perc;nm"
        '
        'tDiscDefProd
        '
        Me.tDiscDefProd.CheckedListSettings.CheckStateMember = ""
        Me.tDiscDefProd.Enabled = False
        Me.tDiscDefProd.Location = New System.Drawing.Point(456, 96)
        Me.tDiscDefProd.Name = "tDiscDefProd"
        Me.tDiscDefProd.Size = New System.Drawing.Size(168, 22)
        Me.tDiscDefProd.TabIndex = 56
        Me.tDiscDefProd.Tag = "edit;itm_disc_def_prod"
        '
        'tDiscDefMatl
        '
        Me.tDiscDefMatl.CheckedListSettings.CheckStateMember = ""
        Me.tDiscDefMatl.Enabled = False
        Me.tDiscDefMatl.Location = New System.Drawing.Point(632, 96)
        Me.tDiscDefMatl.Name = "tDiscDefMatl"
        Me.tDiscDefMatl.Size = New System.Drawing.Size(88, 22)
        Me.tDiscDefMatl.TabIndex = 57
        Me.tDiscDefMatl.Tag = "edit;itm_disc_def_matl"
        '
        'tUpDefMatl
        '
        Me.tUpDefMatl.CheckedListSettings.CheckStateMember = ""
        Me.tUpDefMatl.Enabled = False
        Me.tUpDefMatl.Location = New System.Drawing.Point(632, 120)
        Me.tUpDefMatl.Name = "tUpDefMatl"
        Me.tUpDefMatl.Size = New System.Drawing.Size(88, 22)
        Me.tUpDefMatl.TabIndex = 60
        Me.tUpDefMatl.Tag = "edit;itm_up_def_matl"
        '
        'tUpDefProd
        '
        Me.tUpDefProd.CheckedListSettings.CheckStateMember = ""
        Me.tUpDefProd.Enabled = False
        Me.tUpDefProd.Location = New System.Drawing.Point(456, 120)
        Me.tUpDefProd.Name = "tUpDefProd"
        Me.tUpDefProd.Size = New System.Drawing.Size(168, 22)
        Me.tUpDefProd.TabIndex = 59
        Me.tUpDefProd.Tag = "edit;itm_up_def_prod"
        '
        'tUpDefPerc
        '
        Appearance45.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tUpDefPerc.Appearance = Appearance45
        Me.tUpDefPerc.Enabled = False
        Me.tUpDefPerc.Location = New System.Drawing.Point(400, 120)
        Me.tUpDefPerc.Name = "tUpDefPerc"
        Me.tUpDefPerc.Size = New System.Drawing.Size(48, 21)
        Me.tUpDefPerc.TabIndex = 58
        Me.tUpDefPerc.Tag = "edit;itm_up_def_perc;nm"
        '
        'UltraLabel14
        '
        Me.UltraLabel14.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(328, 80)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel14.TabIndex = 61
        Me.UltraLabel14.Text = "Defaults:"
        '
        'UltraLabel15
        '
        Me.UltraLabel15.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(400, 80)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(40, 16)
        Me.UltraLabel15.TabIndex = 62
        Me.UltraLabel15.Text = "Perc"
        '
        'UltraLabel16
        '
        Me.UltraLabel16.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(456, 80)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel16.TabIndex = 63
        Me.UltraLabel16.Text = "Prod Type"
        '
        'UltraLabel17
        '
        Me.UltraLabel17.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(632, 80)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel17.TabIndex = 64
        Me.UltraLabel17.Text = "Matl Code"
        '
        'UltraCheckEditor8
        '
        Appearance46.FontData.BoldAsString = "False"
        Me.UltraCheckEditor8.Appearance = Appearance46
        Me.UltraCheckEditor8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor8.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor8.Enabled = False
        Me.UltraCheckEditor8.Location = New System.Drawing.Point(56, 288)
        Me.UltraCheckEditor8.Name = "UltraCheckEditor8"
        Me.UltraCheckEditor8.Size = New System.Drawing.Size(200, 16)
        Me.UltraCheckEditor8.TabIndex = 65
        Me.UltraCheckEditor8.Tag = "edit;itm_flat_rate;cb"
        Me.UltraCheckEditor8.Text = "Flat Rate (use Base price only)"
        '
        'tComProdType
        '
        Me.tComProdType.CheckedListSettings.CheckStateMember = ""
        Me.tComProdType.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tComProdType.Enabled = False
        Me.tComProdType.Location = New System.Drawing.Point(96, 176)
        Me.tComProdType.Name = "tComProdType"
        Me.tComProdType.Size = New System.Drawing.Size(168, 22)
        Me.tComProdType.TabIndex = 66
        Me.tComProdType.Tag = "edit;itm_com_prod_type"
        '
        'UltraLabel21
        '
        Appearance47.FontData.BoldAsString = "False"
        Me.UltraLabel21.Appearance = Appearance47
        Me.UltraLabel21.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(0, 176)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(80, 24)
        Me.UltraLabel21.TabIndex = 67
        Me.UltraLabel21.Text = "Batch Report"
        '
        'UltraCheckEditor9
        '
        Appearance48.FontData.BoldAsString = "False"
        Me.UltraCheckEditor9.Appearance = Appearance48
        Me.UltraCheckEditor9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor9.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor9.Enabled = False
        Me.UltraCheckEditor9.Location = New System.Drawing.Point(400, 184)
        Me.UltraCheckEditor9.Name = "UltraCheckEditor9"
        Me.UltraCheckEditor9.Size = New System.Drawing.Size(152, 16)
        Me.UltraCheckEditor9.TabIndex = 68
        Me.UltraCheckEditor9.Tag = "edit;itm_change_base_price;cb"
        Me.UltraCheckEditor9.Text = "Can Change Base Price"
        '
        'UltraLabel22
        '
        Appearance49.FontData.BoldAsString = "False"
        Me.UltraLabel22.Appearance = Appearance49
        Me.UltraLabel22.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(560, 152)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel22.TabIndex = 69
        Me.UltraLabel22.Text = "Stain Btls"
        '
        'UltraLabel23
        '
        Appearance50.FontData.BoldAsString = "False"
        Me.UltraLabel23.Appearance = Appearance50
        Me.UltraLabel23.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(560, 176)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel23.TabIndex = 70
        Me.UltraLabel23.Text = "Lacquer Btls"
        '
        'UltraLabel24
        '
        Appearance51.FontData.BoldAsString = "False"
        Me.UltraLabel24.Appearance = Appearance51
        Me.UltraLabel24.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(560, 200)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel24.TabIndex = 71
        Me.UltraLabel24.Text = "Search For"
        '
        'tStainBottles
        '
        Appearance52.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tStainBottles.Appearance = Appearance52
        Me.tStainBottles.Enabled = False
        Me.tStainBottles.Location = New System.Drawing.Point(640, 152)
        Me.tStainBottles.Name = "tStainBottles"
        Me.tStainBottles.Size = New System.Drawing.Size(48, 21)
        Me.tStainBottles.TabIndex = 72
        Me.tStainBottles.Tag = "edit;itm_stain_bottles;nm"
        '
        'tLacqBottles
        '
        Appearance53.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tLacqBottles.Appearance = Appearance53
        Me.tLacqBottles.Enabled = False
        Me.tLacqBottles.Location = New System.Drawing.Point(640, 176)
        Me.tLacqBottles.Name = "tLacqBottles"
        Me.tLacqBottles.Size = New System.Drawing.Size(48, 21)
        Me.tLacqBottles.TabIndex = 73
        Me.tLacqBottles.Tag = "edit;itm_lacquer_bottles;nm"
        '
        'ddSearchStain
        '
        Me.ddSearchStain.CheckedListSettings.CheckStateMember = ""
        Me.ddSearchStain.Enabled = False
        Me.ddSearchStain.Location = New System.Drawing.Point(640, 200)
        Me.ddSearchStain.Name = "ddSearchStain"
        Me.ddSearchStain.Size = New System.Drawing.Size(80, 22)
        Me.ddSearchStain.TabIndex = 74
        Me.ddSearchStain.Tag = "edit;itm_search_bottles;dc"
        '
        'tWoodFactor
        '
        Appearance54.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tWoodFactor.Appearance = Appearance54
        Me.tWoodFactor.Enabled = False
        Me.tWoodFactor.Location = New System.Drawing.Point(856, 208)
        Me.tWoodFactor.Name = "tWoodFactor"
        Me.tWoodFactor.Size = New System.Drawing.Size(48, 21)
        Me.tWoodFactor.TabIndex = 76
        Me.tWoodFactor.Tag = "edit;itm_wood_factor;nm"
        '
        'UltraLabel25
        '
        Appearance55.FontData.BoldAsString = "False"
        Me.UltraLabel25.Appearance = Appearance55
        Me.UltraLabel25.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(776, 208)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel25.TabIndex = 75
        Me.UltraLabel25.Text = "Wood Factor"
        '
        'chAllow0Base
        '
        Appearance90.FontData.BoldAsString = "False"
        Me.chAllow0Base.Appearance = Appearance90
        Me.chAllow0Base.BackColor = System.Drawing.Color.LightSteelBlue
        Me.chAllow0Base.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.chAllow0Base.Enabled = False
        Me.chAllow0Base.Location = New System.Drawing.Point(400, 200)
        Me.chAllow0Base.Name = "chAllow0Base"
        Me.chAllow0Base.Size = New System.Drawing.Size(136, 16)
        Me.chAllow0Base.TabIndex = 77
        Me.chAllow0Base.Tag = "edit;itm_allow_0_base_price;cb"
        Me.chAllow0Base.Text = "Allow $0 Base Price"
        '
        'tStain
        '
        Me.tStain.CheckedListSettings.CheckStateMember = ""
        Me.tStain.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tStain.Enabled = False
        Me.tStain.Location = New System.Drawing.Point(488, 280)
        Me.tStain.Name = "tStain"
        Me.tStain.Size = New System.Drawing.Size(88, 22)
        Me.tStain.TabIndex = 78
        Me.tStain.Tag = "edit;itm_stain_serial;nm"
        '
        'UltraLabel26
        '
        Me.UltraLabel26.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel26.Location = New System.Drawing.Point(440, 280)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(40, 16)
        Me.UltraLabel26.TabIndex = 79
        Me.UltraLabel26.Text = "Stain"
        '
        'tCommProdType
        '
        Me.tCommProdType.CheckedListSettings.CheckStateMember = ""
        Me.tCommProdType.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tCommProdType.Enabled = False
        Me.tCommProdType.Location = New System.Drawing.Point(96, 200)
        Me.tCommProdType.Name = "tCommProdType"
        Me.tCommProdType.Size = New System.Drawing.Size(168, 22)
        Me.tCommProdType.TabIndex = 80
        Me.tCommProdType.Tag = "edit;itm_commission_prod_type"
        '
        'UltraLabel3
        '
        Appearance57.FontData.BoldAsString = "False"
        Me.UltraLabel3.Appearance = Appearance57
        Me.UltraLabel3.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(0, 200)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(96, 24)
        Me.UltraLabel3.TabIndex = 81
        Me.UltraLabel3.Text = "Comm Prod Type"
        '
        'tPart
        '
        Appearance58.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tPart.Appearance = Appearance58
        Me.tPart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tPart.Enabled = False
        Me.tPart.Location = New System.Drawing.Point(80, 8)
        Me.tPart.Name = "tPart"
        Me.tPart.Size = New System.Drawing.Size(168, 21)
        Me.tPart.TabIndex = 0
        Me.tPart.Tag = "edit;itm_code"
        '
        'UltraTextEditor2
        '
        Me.UltraTextEditor2.AcceptsReturn = True
        Appearance59.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor2.Appearance = Appearance59
        Me.UltraTextEditor2.Enabled = False
        Me.UltraTextEditor2.Location = New System.Drawing.Point(256, 16)
        Me.UltraTextEditor2.Multiline = True
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.UltraTextEditor2.Size = New System.Drawing.Size(360, 56)
        Me.UltraTextEditor2.TabIndex = 3
        Me.UltraTextEditor2.Tag = "edit;itm_desc"
        '
        'UltraLabel1
        '
        Appearance60.FontData.BoldAsString = "False"
        Me.UltraLabel1.Appearance = Appearance60
        Me.UltraLabel1.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(0, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Item Code"
        '
        'UltraLabel2
        '
        Appearance61.FontData.BoldAsString = "False"
        Me.UltraLabel2.Appearance = Appearance61
        Me.UltraLabel2.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(256, 0)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Description"
        '
        'UltraLabel4
        '
        Appearance62.FontData.BoldAsString = "False"
        Me.UltraLabel4.Appearance = Appearance62
        Me.UltraLabel4.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(0, 32)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel4.TabIndex = 7
        Me.UltraLabel4.Text = "IWA Code"
        '
        'UltraCheckEditor2
        '
        Appearance63.FontData.BoldAsString = "False"
        Me.UltraCheckEditor2.Appearance = Appearance63
        Me.UltraCheckEditor2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor2.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor2.Enabled = False
        Me.UltraCheckEditor2.Location = New System.Drawing.Point(272, 168)
        Me.UltraCheckEditor2.Name = "UltraCheckEditor2"
        Me.UltraCheckEditor2.Size = New System.Drawing.Size(168, 16)
        Me.UltraCheckEditor2.TabIndex = 12
        Me.UltraCheckEditor2.Tag = "edit;itm_fixture;cb"
        Me.UltraCheckEditor2.Text = "Can be a fixture"
        Me.UltraCheckEditor2.ThreeState = True
        '
        'UltraCheckEditor1
        '
        Appearance64.FontData.BoldAsString = "False"
        Me.UltraCheckEditor1.Appearance = Appearance64
        Me.UltraCheckEditor1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor1.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor1.Enabled = False
        Me.UltraCheckEditor1.Location = New System.Drawing.Point(272, 152)
        Me.UltraCheckEditor1.Name = "UltraCheckEditor1"
        Me.UltraCheckEditor1.Size = New System.Drawing.Size(168, 16)
        Me.UltraCheckEditor1.TabIndex = 11
        Me.UltraCheckEditor1.Tag = "edit;itm_surcharge;cb"
        Me.UltraCheckEditor1.Text = "Surcharge"
        '
        'UltraCheckEditor4
        '
        Appearance65.FontData.BoldAsString = "False"
        Me.UltraCheckEditor4.Appearance = Appearance65
        Me.UltraCheckEditor4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor4.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor4.Enabled = False
        Me.UltraCheckEditor4.Location = New System.Drawing.Point(272, 184)
        Me.UltraCheckEditor4.Name = "UltraCheckEditor4"
        Me.UltraCheckEditor4.Size = New System.Drawing.Size(168, 16)
        Me.UltraCheckEditor4.TabIndex = 13
        Me.UltraCheckEditor4.Tag = "edit;itm_wrs_exclusive;cb"
        Me.UltraCheckEditor4.Text = "WRS Exclusive"
        '
        'chMaterial
        '
        Appearance89.FontData.BoldAsString = "False"
        Me.chMaterial.Appearance = Appearance89
        Me.chMaterial.BackColor = System.Drawing.Color.LightSteelBlue
        Me.chMaterial.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.chMaterial.Enabled = False
        Me.chMaterial.Location = New System.Drawing.Point(272, 200)
        Me.chMaterial.Name = "chMaterial"
        Me.chMaterial.Size = New System.Drawing.Size(168, 16)
        Me.chMaterial.TabIndex = 14
        Me.chMaterial.Tag = "edit;itm_material_sel;cb"
        Me.chMaterial.Text = "Material Selectable"
        '
        'Open1
        '
        Me.Open1.Multiselect = True
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1217, 483)
        '
        'Tab1
        '
        Me.Tab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab1.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.Tab1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.Tab1.Controls.Add(Me.TabPageControl1)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl2)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl4)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl5)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl1)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl3)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl6)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl7)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl8)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl9)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl10)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl11)
        Me.Tab1.Location = New System.Drawing.Point(0, 312)
        Me.Tab1.Name = "Tab1"
        Appearance67.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tab1.SelectedTabAppearance = Appearance67
        Me.Tab1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.Tab1.Size = New System.Drawing.Size(1221, 509)
        Appearance68.FontData.BoldAsString = "True"
        Appearance68.FontData.SizeInPoints = 10.0!
        Me.Tab1.TabHeaderAreaAppearance = Appearance68
        Me.Tab1.TabIndex = 18
        Me.Tab1.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.SingleRowSizeToFit
        UltraTab1.Key = "Base"
        UltraTab1.TabPage = Me.TabPageControl1
        UltraTab1.Text = "Base"
        UltraTab2.Key = "RET"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Retail"
        UltraTab3.Key = "MD"
        UltraTab3.TabPage = Me.UltraTabPageControl4
        UltraTab3.Text = "Misc Dealer"
        UltraTab4.Key = "CON"
        UltraTab4.TabPage = Me.UltraTabPageControl5
        UltraTab4.Text = "Contractor"
        UltraTab5.Key = "ACT"
        UltraTab5.TabPage = Me.UltraTabPageControl3
        UltraTab5.Text = "Actual"
        UltraTab6.Key = "SHIP"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Shipping"
        UltraTab7.Key = "NOTE"
        UltraTab7.TabPage = Me.UltraTabPageControl1
        UltraTab7.Text = "Notes"
        UltraTab8.Key = "Perc"
        UltraTab8.TabPage = Me.UltraTabPageControl7
        UltraTab8.Text = "% Pricing"
        UltraTab9.Key = "Boxes"
        UltraTab9.TabPage = Me.UltraTabPageControl8
        UltraTab9.Text = "Boxes"
        UltraTab10.Key = "UP"
        UltraTab10.TabPage = Me.UltraTabPageControl9
        UltraTab10.Text = "Up Sell"
        UltraTab11.Key = "Images"
        UltraTab11.TabPage = Me.UltraTabPageControl10
        UltraTab11.Text = "Images"
        UltraTab12.Key = "Install"
        UltraTab12.TabPage = Me.UltraTabPageControl11
        UltraTab12.Text = "Install"
        Me.Tab1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab7, UltraTab8, UltraTab9, UltraTab10, UltraTab11, UltraTab12})
        Me.Tab1.TabsPerRow = 6
        Me.Tab1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabel27
        '
        Appearance69.FontData.BoldAsString = "False"
        Me.UltraLabel27.Appearance = Appearance69
        Me.UltraLabel27.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel27.Location = New System.Drawing.Point(880, 256)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel27.TabIndex = 128
        Me.UltraLabel27.Text = "Height"
        '
        'UltraLabel28
        '
        Appearance70.FontData.BoldAsString = "False"
        Me.UltraLabel28.Appearance = Appearance70
        Me.UltraLabel28.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel28.Location = New System.Drawing.Point(944, 256)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel28.TabIndex = 129
        Me.UltraLabel28.Text = "Depth"
        '
        'tWidth
        '
        Appearance71.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tWidth.Appearance = Appearance71
        Me.tWidth.Enabled = False
        Me.tWidth.Location = New System.Drawing.Point(816, 232)
        Me.tWidth.Name = "tWidth"
        Me.tWidth.Size = New System.Drawing.Size(56, 21)
        Me.tWidth.TabIndex = 130
        Me.tWidth.Tag = "edit;itm_width;nm"
        '
        'tHeight
        '
        Appearance72.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tHeight.Appearance = Appearance72
        Me.tHeight.Enabled = False
        Me.tHeight.Location = New System.Drawing.Point(880, 232)
        Me.tHeight.Name = "tHeight"
        Me.tHeight.Size = New System.Drawing.Size(56, 21)
        Me.tHeight.TabIndex = 131
        Me.tHeight.Tag = "edit;itm_height;nm"
        '
        'tDepth
        '
        Appearance73.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tDepth.Appearance = Appearance73
        Me.tDepth.Enabled = False
        Me.tDepth.Location = New System.Drawing.Point(944, 232)
        Me.tDepth.Name = "tDepth"
        Me.tDepth.Size = New System.Drawing.Size(56, 21)
        Me.tDepth.TabIndex = 132
        Me.tDepth.Tag = "edit;itm_depth;nm"
        '
        'UltraLabel29
        '
        Me.UltraLabel29.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel29.Location = New System.Drawing.Point(776, 232)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(40, 40)
        Me.UltraLabel29.TabIndex = 133
        Me.UltraLabel29.Text = "Part Dims"
        '
        'UltraCheckEditor10
        '
        Me.UltraCheckEditor10.Enabled = False
        Me.UltraCheckEditor10.Location = New System.Drawing.Point(856, 256)
        Me.UltraCheckEditor10.Name = "UltraCheckEditor10"
        Me.UltraCheckEditor10.Size = New System.Drawing.Size(16, 16)
        Me.UltraCheckEditor10.TabIndex = 134
        Me.UltraCheckEditor10.Tag = "edit;itm_width_req;cb"
        Me.UltraCheckEditor10.Text = "UltraCheckEditor10"
        '
        'UltraCheckEditor11
        '
        Me.UltraCheckEditor11.Enabled = False
        Me.UltraCheckEditor11.Location = New System.Drawing.Point(920, 256)
        Me.UltraCheckEditor11.Name = "UltraCheckEditor11"
        Me.UltraCheckEditor11.Size = New System.Drawing.Size(16, 16)
        Me.UltraCheckEditor11.TabIndex = 135
        Me.UltraCheckEditor11.Tag = "edit;itm_height_req;cb"
        Me.UltraCheckEditor11.Text = "UltraCheckEditor11"
        '
        'UltraCheckEditor12
        '
        Me.UltraCheckEditor12.Enabled = False
        Me.UltraCheckEditor12.Location = New System.Drawing.Point(984, 256)
        Me.UltraCheckEditor12.Name = "UltraCheckEditor12"
        Me.UltraCheckEditor12.Size = New System.Drawing.Size(16, 16)
        Me.UltraCheckEditor12.TabIndex = 136
        Me.UltraCheckEditor12.Tag = "edit;itm_depth_req;cb"
        Me.UltraCheckEditor12.Text = "UltraCheckEditor12"
        '
        'UltraLabel30
        '
        Appearance74.FontData.BoldAsString = "False"
        Me.UltraLabel30.Appearance = Appearance74
        Me.UltraLabel30.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel30.Location = New System.Drawing.Point(560, 224)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel30.TabIndex = 137
        Me.UltraLabel30.Text = "Group"
        '
        'tGroup
        '
        Me.tGroup.CheckedListSettings.CheckStateMember = ""
        Me.tGroup.Enabled = False
        Me.tGroup.Location = New System.Drawing.Point(640, 224)
        Me.tGroup.Name = "tGroup"
        Me.tGroup.Size = New System.Drawing.Size(80, 22)
        Me.tGroup.TabIndex = 139
        Me.tGroup.Tag = "edit;itm_group"
        '
        'UltraLabel31
        '
        Me.UltraLabel31.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel31.Location = New System.Drawing.Point(776, 272)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(40, 32)
        Me.UltraLabel31.TabIndex = 143
        Me.UltraLabel31.Text = "Max Dims"
        '
        'UltraTextEditor3
        '
        Appearance75.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor3.Appearance = Appearance75
        Me.UltraTextEditor3.Enabled = False
        Me.UltraTextEditor3.Location = New System.Drawing.Point(944, 280)
        Me.UltraTextEditor3.Name = "UltraTextEditor3"
        Me.UltraTextEditor3.Size = New System.Drawing.Size(56, 21)
        Me.UltraTextEditor3.TabIndex = 142
        Me.UltraTextEditor3.Tag = "edit;itm_depth_max;nm"
        '
        'UltraTextEditor6
        '
        Appearance76.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor6.Appearance = Appearance76
        Me.UltraTextEditor6.Enabled = False
        Me.UltraTextEditor6.Location = New System.Drawing.Point(880, 280)
        Me.UltraTextEditor6.Name = "UltraTextEditor6"
        Me.UltraTextEditor6.Size = New System.Drawing.Size(56, 21)
        Me.UltraTextEditor6.TabIndex = 141
        Me.UltraTextEditor6.Tag = "edit;itm_height_max;nm"
        '
        'UltraTextEditor7
        '
        Appearance77.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor7.Appearance = Appearance77
        Me.UltraTextEditor7.Enabled = False
        Me.UltraTextEditor7.Location = New System.Drawing.Point(816, 280)
        Me.UltraTextEditor7.Name = "UltraTextEditor7"
        Me.UltraTextEditor7.Size = New System.Drawing.Size(56, 21)
        Me.UltraTextEditor7.TabIndex = 140
        Me.UltraTextEditor7.Tag = "edit;itm_width_max;nm"
        '
        'UltraCheckEditor5
        '
        Appearance78.FontData.BoldAsString = "False"
        Me.UltraCheckEditor5.Appearance = Appearance78
        Me.UltraCheckEditor5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor5.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor5.Enabled = False
        Me.UltraCheckEditor5.Location = New System.Drawing.Point(624, 24)
        Me.UltraCheckEditor5.Name = "UltraCheckEditor5"
        Me.UltraCheckEditor5.Size = New System.Drawing.Size(168, 16)
        Me.UltraCheckEditor5.TabIndex = 144
        Me.UltraCheckEditor5.Tag = "edit;itm_additional_art;cb"
        Me.UltraCheckEditor5.Text = "Additional Art Note"
        '
        'UltraTextEditor8
        '
        Appearance79.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.UltraTextEditor8.Appearance = Appearance79
        Me.UltraTextEditor8.Enabled = False
        Me.UltraTextEditor8.Location = New System.Drawing.Point(872, 144)
        Me.UltraTextEditor8.Name = "UltraTextEditor8"
        Me.UltraTextEditor8.Size = New System.Drawing.Size(48, 21)
        Me.UltraTextEditor8.TabIndex = 146
        Me.UltraTextEditor8.Tag = "edit;itm_install_min;nm"
        '
        'UltraLabel32
        '
        Appearance80.FontData.BoldAsString = "False"
        Me.UltraLabel32.Appearance = Appearance80
        Me.UltraLabel32.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(776, 144)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel32.TabIndex = 145
        Me.UltraLabel32.Text = "Install Minutes"
        '
        'ddClass
        '
        Me.ddClass.CheckedListSettings.CheckStateMember = ""
        Me.ddClass.Enabled = False
        Me.ddClass.Location = New System.Drawing.Point(872, 168)
        Me.ddClass.Name = "ddClass"
        Me.ddClass.Size = New System.Drawing.Size(128, 22)
        Me.ddClass.TabIndex = 148
        Me.ddClass.Tag = "edit;itm_class;dc"
        '
        'UltraLabel33
        '
        Appearance81.FontData.BoldAsString = "False"
        Me.UltraLabel33.Appearance = Appearance81
        Me.UltraLabel33.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel33.Location = New System.Drawing.Point(776, 168)
        Me.UltraLabel33.Name = "UltraLabel33"
        Me.UltraLabel33.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel33.TabIndex = 147
        Me.UltraLabel33.Text = "Class"
        '
        'UltraLabel34
        '
        Appearance82.FontData.BoldAsString = "False"
        Me.UltraLabel34.Appearance = Appearance82
        Me.UltraLabel34.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel34.Location = New System.Drawing.Point(0, 80)
        Me.UltraLabel34.Name = "UltraLabel34"
        Me.UltraLabel34.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel34.TabIndex = 150
        Me.UltraLabel34.Text = "Parent"
        '
        'tParent
        '
        Appearance83.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tParent.Appearance = Appearance83
        Me.tParent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tParent.Enabled = False
        Me.tParent.Location = New System.Drawing.Point(80, 80)
        Me.tParent.Name = "tParent"
        Me.tParent.Size = New System.Drawing.Size(168, 21)
        Me.tParent.TabIndex = 149
        Me.tParent.Tag = "edit;itm_parent_code"
        '
        'tBottleCapacity
        '
        Appearance87.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tBottleCapacity.Appearance = Appearance87
        Me.tBottleCapacity.Enabled = False
        Me.tBottleCapacity.Location = New System.Drawing.Point(872, 120)
        Me.tBottleCapacity.Name = "tBottleCapacity"
        Me.tBottleCapacity.Size = New System.Drawing.Size(48, 21)
        Me.tBottleCapacity.TabIndex = 152
        Me.tBottleCapacity.Tag = "edit;itm_bottle_capacity;nm"
        '
        'lBottleCapacity
        '
        Appearance88.FontData.BoldAsString = "False"
        Me.lBottleCapacity.Appearance = Appearance88
        Me.lBottleCapacity.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.lBottleCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBottleCapacity.Location = New System.Drawing.Point(776, 120)
        Me.lBottleCapacity.Name = "lBottleCapacity"
        Me.lBottleCapacity.Size = New System.Drawing.Size(88, 16)
        Me.lBottleCapacity.TabIndex = 151
        Me.lBottleCapacity.Text = "Bottle Capacity"
        '
        'UltraCheckEditor13
        '
        Appearance86.FontData.BoldAsString = "False"
        Me.UltraCheckEditor13.Appearance = Appearance86
        Me.UltraCheckEditor13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor13.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor13.Enabled = False
        Me.UltraCheckEditor13.Location = New System.Drawing.Point(624, 40)
        Me.UltraCheckEditor13.Name = "UltraCheckEditor13"
        Me.UltraCheckEditor13.Size = New System.Drawing.Size(192, 16)
        Me.UltraCheckEditor13.TabIndex = 153
        Me.UltraCheckEditor13.Tag = "edit;itm_art_allclear;cb"
        Me.UltraCheckEditor13.Text = "Notify Cellar Art when All Clear"
        '
        'tPriceTrackInches
        '
        Appearance84.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.tPriceTrackInches.Appearance = Appearance84
        Me.tPriceTrackInches.Enabled = False
        Me.tPriceTrackInches.Location = New System.Drawing.Point(872, 96)
        Me.tPriceTrackInches.Name = "tPriceTrackInches"
        Me.tPriceTrackInches.Size = New System.Drawing.Size(48, 21)
        Me.tPriceTrackInches.TabIndex = 155
        Me.tPriceTrackInches.Tag = "edit;itm_price_track_inches;nm"
        '
        'UltraLabel35
        '
        Appearance85.FontData.BoldAsString = "False"
        Me.UltraLabel35.Appearance = Appearance85
        Me.UltraLabel35.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel35.Location = New System.Drawing.Point(776, 96)
        Me.UltraLabel35.Name = "UltraLabel35"
        Me.UltraLabel35.Size = New System.Drawing.Size(88, 17)
        Me.UltraLabel35.TabIndex = 154
        Me.UltraLabel35.Text = "Price Track Ft"
        '
        'UltraCheckEditor14
        '
        Appearance66.FontData.BoldAsString = "False"
        Me.UltraCheckEditor14.Appearance = Appearance66
        Me.UltraCheckEditor14.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor14.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.UltraCheckEditor14.Enabled = False
        Me.UltraCheckEditor14.Location = New System.Drawing.Point(272, 217)
        Me.UltraCheckEditor14.Name = "UltraCheckEditor14"
        Me.UltraCheckEditor14.Size = New System.Drawing.Size(168, 15)
        Me.UltraCheckEditor14.TabIndex = 156
        Me.UltraCheckEditor14.Tag = "edit;itm_send_diag;cb"
        Me.UltraCheckEditor14.Text = "Send Diagnostic Email"
        '
        'chItmPricing
        '
        Appearance56.FontData.BoldAsString = "False"
        Me.chItmPricing.Appearance = Appearance56
        Me.chItmPricing.BackColor = System.Drawing.Color.LightSteelBlue
        Me.chItmPricing.BackColorInternal = System.Drawing.Color.LightSteelBlue
        Me.chItmPricing.Enabled = False
        Me.chItmPricing.Location = New System.Drawing.Point(400, 217)
        Me.chItmPricing.Name = "chItmPricing"
        Me.chItmPricing.Size = New System.Drawing.Size(176, 15)
        Me.chItmPricing.TabIndex = 157
        Me.chItmPricing.Tag = "edit;itm_pricing_hide;cb"
        Me.chItmPricing.Text = "Do not show on Item Pricing"
        '
        'fmParts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1221, 821)
        Me.Controls.Add(Me.chItmPricing)
        Me.Controls.Add(Me.UltraCheckEditor14)
        Me.Controls.Add(Me.tPriceTrackInches)
        Me.Controls.Add(Me.UltraLabel35)
        Me.Controls.Add(Me.UltraCheckEditor13)
        Me.Controls.Add(Me.tBottleCapacity)
        Me.Controls.Add(Me.lBottleCapacity)
        Me.Controls.Add(Me.UltraLabel34)
        Me.Controls.Add(Me.tParent)
        Me.Controls.Add(Me.ddClass)
        Me.Controls.Add(Me.UltraLabel33)
        Me.Controls.Add(Me.UltraTextEditor8)
        Me.Controls.Add(Me.UltraLabel32)
        Me.Controls.Add(Me.UltraCheckEditor5)
        Me.Controls.Add(Me.UltraLabel31)
        Me.Controls.Add(Me.UltraTextEditor3)
        Me.Controls.Add(Me.UltraTextEditor6)
        Me.Controls.Add(Me.UltraTextEditor7)
        Me.Controls.Add(Me.tGroup)
        Me.Controls.Add(Me.UltraLabel30)
        Me.Controls.Add(Me.UltraCheckEditor12)
        Me.Controls.Add(Me.UltraCheckEditor11)
        Me.Controls.Add(Me.UltraCheckEditor10)
        Me.Controls.Add(Me.UltraLabel29)
        Me.Controls.Add(Me.tDepth)
        Me.Controls.Add(Me.tHeight)
        Me.Controls.Add(Me.tWidth)
        Me.Controls.Add(Me.UltraLabel28)
        Me.Controls.Add(Me.UltraLabel27)
        Me.Controls.Add(Me.Tab1)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraTextEditor5)
        Me.Controls.Add(Me.tStainBottles)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.tWoodFactor)
        Me.Controls.Add(Me.cbDiscount)
        Me.Controls.Add(Me.chAllow0Base)
        Me.Controls.Add(Me.tProdType)
        Me.Controls.Add(Me.tMatDef)
        Me.Controls.Add(Me.UltraLabel26)
        Me.Controls.Add(Me.tCommProdType)
        Me.Controls.Add(Me.UltraLabel25)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.tFinish)
        Me.Controls.Add(Me.chMaterial)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.UltraTextEditor9)
        Me.Controls.Add(Me.UltraCheckEditor3)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.cbTaxable)
        Me.Controls.Add(Me.chChangePrice)
        Me.Controls.Add(Me.cbUpColor)
        Me.Controls.Add(Me.UltraCheckEditor1)
        Me.Controls.Add(Me.UltraCheckEditor9)
        Me.Controls.Add(Me.ddColor)
        Me.Controls.Add(Me.tColorPerc)
        Me.Controls.Add(Me.UltraCheckEditor4)
        Me.Controls.Add(Me.tPart)
        Me.Controls.Add(Me.UltraLabel12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UltraLabel13)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraCheckEditor6)
        Me.Controls.Add(Me.tLacqBottles)
        Me.Controls.Add(Me.ddSearchStain)
        Me.Controls.Add(Me.tDiscDefPerc)
        Me.Controls.Add(Me.tDiscDefProd)
        Me.Controls.Add(Me.tComProdType)
        Me.Controls.Add(Me.tDiscDefMatl)
        Me.Controls.Add(Me.tUpDefMatl)
        Me.Controls.Add(Me.tUpDefProd)
        Me.Controls.Add(Me.tStain)
        Me.Controls.Add(Me.UltraLabel22)
        Me.Controls.Add(Me.tUpDefPerc)
        Me.Controls.Add(Me.UltraLabel23)
        Me.Controls.Add(Me.UltraLabel14)
        Me.Controls.Add(Me.UltraLabel15)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel16)
        Me.Controls.Add(Me.UltraLabel17)
        Me.Controls.Add(Me.UltraCheckEditor8)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.UltraTextEditor2)
        Me.Controls.Add(Me.UltraLabel21)
        Me.Controls.Add(Me.UltraTextEditor1)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.UltraTextEditor4)
        Me.Controls.Add(Me.UltraLabel24)
        Me.Controls.Add(Me.UltraCheckEditor2)
        Me.Name = "fmParts"
        Me.Text = "Parts"
        Me.TabPageControl1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.UltraTextEditor10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        Me.UltraTabPageControl7.PerformLayout()
        CType(Me.UltraTextEditor13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.grBoxes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.gUpSell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.gImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tProdType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tMatDef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tFinish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTaxable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chChangePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbUpColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tColorPerc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDiscDefPerc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDiscDefProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDiscDefMatl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tUpDefMatl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tUpDefProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tUpDefPerc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tComProdType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tStainBottles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLacqBottles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddSearchStain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tWoodFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chAllow0Base, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tStain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCommProdType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab1.ResumeLayout(False)
        CType(Me.tWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDepth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tParent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBottleCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPriceTrackInches, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chItmPricing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub LoadPage()
        LoadGrid(Grid1, daPrices, dsPrices, "select * from itm_price where itm_price_itm_code='" + tPart.Text + "'", "itm_price", , dvPrices)
        UpdatePrices(Tab1.ActiveTab.Key)
        LoadGrid(grBoxes, daBoxes, dsBoxes, "select itm_box_serial,itm_box_itm_code,itm_box_len,itm_box_width,itm_box_height,itm_box_weight,itm_box_name,itm_box_dept,itm_box_who,itm_box_when from itm_box where itm_box_itm_code='" + tPart.Text + "'", "itm_box")
        LoadGrid(gUpSell, daUpsell, dsUpsell, "select * from upsell_file where upsell_parent_itm_code='" + tPart.Text + "'", "upsell")
        LoadGrid(gImages, daImages, dsImages, "select * from itm_img where itm_img_itm_code='" + tPart.Text + "'", "img")
    End Sub
    Private Sub ShowCurrentPrices(ByVal gr As Infragistics.Win.UltraWinGrid.UltraGrid)
        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow

        For Each rw In gr.Rows
            If nz(rw.Cells("itm_price_start").Value, CDate("1/1/1900")) <= Today And nz(rw.Cells("itm_price_end").Value, CDate("12/31/2099")) >= Today Then rw.Appearance.BackColor = Color.Yellow
        Next
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Table = "itm_file"
        Me.Key1 = "itm_serial"
        Me.FocusField = "tpart"
        PopulateValueList(Grid1, "itm_prod_type", "select * from itm_prod_type order by itm_prod_type_type", "itm_prod_type_desc", "itm_prod_type_type", "itm_price_type")
        'LoadGrid(Grid1, daPrices, dsPrices, "select * from itm_price where itm_price_itm_code='" + KeyValue1 + "'", "itm_price")
        'LoadPage()
        LoadProdTypes(dsProdTypes)
        tProdType.DataSource = dsProdTypes
        tProdType.DisplayMember = "itm_prod_type_type"
        tProdType.ValueMember = "itm_prod_type_type"

        LoadDD(tMatDef, dsMat, "mat_file", "mat_code", "mat_code", "mat_code,mat_desc")
        LoadDD2(ddClass, "class_file", "class_code", "class_code")
        LoadGrid(Grid1, daPrices, dsPrices, "select * from itm_price where itm_price_serial=-1", "itm_price", , dvPrices)
        LoadDD(tDiscDefMatl, dsDefMatl, "mat_file", "mat_code", "mat_code", "mat_code,mat_desc")
        LoadDD(tUpDefMatl, dsDefMatl, "mat_file", "mat_code", "mat_code", "mat_code,mat_desc")
        LoadDD(tDiscDefProd, dsDefProd, "itm_prod_type", "itm_prod_type_type", "itm_prod_type_type", "itm_prod_type_type,itm_prod_type_desc")
        LoadDD(tUpDefProd, dsDefProd, "itm_prod_type", "itm_prod_type_type", "itm_prod_type_type", "itm_prod_type_type,itm_prod_type_desc")
        LoadDD2(tComProdType, "itm_prod_type", "itm_prod_type_type", "itm_prod_type_type")
        LoadDD2(tCommProdType, "itm_prod_type", "itm_prod_type_type", "itm_prod_type_type")
        LoadDD(ddSearchStain, dsBottles, "itm_bottle", "itm_bottle_code", "itm_bottle_desc")
        LoadDD2(tStain, "stain_file", "stain_serial", "stain_name", "stain_serial, stain_name, stain_desc")
        tStain.DisplayLayout.Bands(0).Columns(0).Hidden = True
        tStain.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Stain"
        tStain.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Description"
        LoadDD2(tFinish, "finish_file", "finish_serial", "finish_name", "finish_serial,finish_name,finish_desc")
        LoadDD2(tGroup, "ord_group_desc", "ord_group_no", "ord_group_no", "ord_group_no,ord_group_no_desc")
        tGroup.DisplayLayout.Bands(0).Columns(0).SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending
        tGroup.DisplayLayout.Bands(0).Columns(1).Width = 200
        UpdatePrices(Tab1.ActiveTab.Key)
    End Sub
    Public Overrides Sub Find()
        Try
            'If Findx.frm Is Me Then
            'Findx.ShowDialog()
            'Exit Sub
            'End If
            Dim fm As fmFind
            If onFindForm Is Nothing Then
                onFindForm = New fmFind
                fm = onFindForm
                'fm = Findx
                Dim flds As jFld
                fm.frm = Me
                fm.Sort = "itm_code"
                fm.ShowInactive = True

                fm.flds = New Collection

                flds = New jFld
                flds.Field = "itm_serial"
                flds.FieldName = "Part Serial"
                flds.FieldType = "Numeric"
                flds.Searchable = False
                fm.flds.Add(flds)

                flds = New jFld
                flds.Field = "itm_code"
                flds.FieldName = "Part Number"
                flds.FieldType = "String"
                flds.SearchAll = False
                flds.Searchable = True
                fm.flds.Add(flds)

                flds = New jFld
                flds.Field = "itm_desc"
                flds.FieldName = "Description"
                flds.FieldType = "String"
                flds.Searchable = True
                fm.flds.Add(flds)

                flds = New jFld
                flds.Field = "itm_prod_type"
                flds.FieldName = "Prod Type"
                flds.FieldType = "String"
                flds.Searchable = True
                fm.flds.Add(flds)

                fm.Repeat = False
                fm.frm = Me
                fm.Height = Me.Height * 0.9
            Else
                fm = onFindForm
                fm.Repeat = True
            End If

            fm.ShowDialog()
            LoadFields(Me)
            'LoadGrid(Grid1, daPrices, dsPrices, "select * from itm_price where itm_price_itm_serial='" + KeyValue1 + "'", "itm_price")
            LoadPage()
            EditButtons("Idle")
            UpdatePic()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Private Sub UpdatePic()
        Try
            If tPart.Text = "" Then Exit Sub
            If gImages.ActiveRow Is Nothing Then Exit Sub
            If IO.File.Exists(nz(gImages.ActiveRow.Cells("itm_img_path").Value)) Then
                tPicture.Image = Image.FromFile(gImages.ActiveRow.Cells("itm_img_path").Value)
                tPicture.Show()
            Else
                tPicture.Hide()
            End If
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Overrides Sub Save_After()
        Dim x As Integer
        Dim rw As DataRow
        Dim cmd As New SqlClient.SqlCommand("", cnn)
        'tPart.Text = KeyValue1.ToString

        For x = 0 To dsPrices.Tables("itm_price").Rows.Count - 1
            If dsPrices.Tables("itm_price").Rows(x).RowState <> DataRowState.Deleted Then
                If dsPrices.Tables("itm_price").Rows(x).RowState = DataRowState.Modified Then
                    dsPrices.Tables("itm_price").Rows(x).Item("itm_price_updated") = Now
                End If
                If dsPrices.Tables("itm_price").Rows(x).RowState = DataRowState.Added Then
                    dsPrices.Tables("itm_price").Rows(x).Item("itm_price_created") = Now
                    dsPrices.Tables("itm_price").Rows(x).Item("itm_price_updated") = Now
                End If

                dsPrices.Tables("itm_price").Rows(x).Item("itm_price_itm_code") = tPart.Text
            End If
        Next

        If dsBoxes.Tables.Count > 0 Then
            For Each rw In dsBoxes.Tables(0).Rows
                If rw.RowState <> DataRowState.Deleted Then
                    rw("itm_box_itm_code") = tPart.Text
                    If nz(rw("itm_box_who")) = "" Then
                        rw("itm_box_who") = User
                        rw("itm_box_when") = Now
                    End If
                End If
            Next
        End If
        If dsUpsell.Tables.Count > 0 Then
            For Each rw In dsUpsell.Tables(0).Rows
                If rw.RowState <> DataRowState.Deleted Then
                    rw("upsell_parent_itm_code") = tPart.Text
                End If
            Next
        End If
        If dsImages.Tables.Count > 0 Then
            For Each rw In dsImages.Tables(0).Rows
                If rw.RowState <> DataRowState.Deleted Then
                    rw("itm_img_itm_code") = tPart.Text
                End If
            Next
        End If

        cnn.Open()
        daPrices.Update(dsPrices, "itm_price")
        daBoxes.Update(dsBoxes, "itm_box")
        daUpsell.Update(dsUpsell, "upsell")
        daImages.Update(dsImages, "img")

        cmd.CommandText = "update itm_file set itm_img='" + tPicture.Tag + "' where itm_code='" + tPart.Text + "'"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        cmd.CommandText = "select itm_code from itm_file where itm_parent_code='" + tPart.Text + "'"
        da.Fill(dt)
        cnn.Close()

        For Each rw In dt.Rows
            UpdateChild(tPart.Text, rw("itm_code"))
        Next

        If tParent.Text <> "" Then
            UpdateChild(tParent.Text, tPart.Text)
            LoadFields(Me)
            LoadPage()
        End If

    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

    End Sub

    Private Sub Grid1_InitializeRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs)
        If Me.EditMode = "Edit" Or Me.EditMode = "Add" Then
            e.Row.Cells("itm_price_sale").Value = 0
        End If
    End Sub

    Public Overrides Sub Cancel_After()
        LoadFields(Me)
        'LoadGrid(Grid1, daPrices, dsPrices, "select * from itm_price where itm_price_itm_serial='" + KeyValue1 + "'", "itm_price")
        LoadPage()
        EditButtons("Idle")
        UpdatePic()
    End Sub

    Public Overrides Sub Add_After()
        dsPrices.Clear()
        tPicture.Hide()
        cbTaxable.Checked = True
        tWoodFactor.Text = "1"

        LoadBoxes()
        LoadUpSell()
    End Sub


    Public Overrides Sub Save_Before()
        If tPart.Text = "" Then
            MsgBox("You must enter a part number", MsgBoxStyle.Information, "Part Number?")
            Me.SaveCanceled = True
            Exit Sub
        End If
        If tParent.Text = tPart.Text Then
            MsgBox("Parent Item Code can not be the same as the Part Number", MsgBoxStyle.Critical, "Parent")
            SaveCanceled = True
            tParent.Focus()
            Exit Sub
        End If
        If tParent.Text = "" Then
            If tStainBottles.Text = "" Or Not IsNumeric(tStainBottles.Text) Then
                MsgBox("Must have a Stain Bottles amount", MsgBoxStyle.Critical, "Stain Bottles")
                SaveCanceled = True
                tStainBottles.Focus()
                Exit Sub
            End If
            If tLacqBottles.Text = "" Or Not IsNumeric(tLacqBottles.Text) Then
                MsgBox("Must have a Lacquer Bottles amount", MsgBoxStyle.Critical, "Lacquer Bottles")
                SaveCanceled = True
                tLacqBottles.Focus()
                Exit Sub
            End If
            If CInt(tStainBottles.Text) < 0 Then
                MsgBox("Must have a Stain Bottles amount greater than or equal to 0", MsgBoxStyle.Critical, "Stain Bottles")
                SaveCanceled = True
                tStainBottles.Focus()
                Exit Sub
            End If
            If CInt(tLacqBottles.Text) < 0 Then
                MsgBox("Must have a Lacquer Bottles amount greater than or equal to 0", MsgBoxStyle.Critical, "Lacquer Bottles")
                SaveCanceled = True
                tLacqBottles.Focus()
                Exit Sub
            End If
            If Not IsNumeric(tWoodFactor.Text) Then
                MsgBox("Wood factor must be a number", MsgBoxStyle.Critical, "Wood Factor?")
                SaveCanceled = True
                tWoodFactor.Focus()
                Exit Sub
            End If
            If Not IsNumeric(tGroup.Text) And tGroup.Text <> "" Then
                MsgBox("Group must be a number or blank", MsgBoxStyle.Critical, "Group?")
                SaveCanceled = True
                tGroup.Focus()
                Exit Sub
            End If
            If Not (CDbl(tWoodFactor.Text) > 0 And CDbl(tWoodFactor.Text) <= 1) Then
                MsgBox("Wood factor must be greater than 0 and less than or equal to 1", MsgBoxStyle.Critical, "Wood Factor?")
                SaveCanceled = True
                tWoodFactor.Focus()
                Exit Sub
            End If
        End If
        If EditMode = "Add" Then
            Dim cmd As New SqlClient.SqlCommand("select itm_code from itm_file where itm_code='" + tPart.Text + "'", cnn)
            Dim Itm As String
            cnn.Open()
            Itm = cmd.ExecuteScalar
            cnn.Close()
            If Itm <> "" Then
                MsgBox("Item Code already exists.", MsgBoxStyle.Exclamation, "Item Code")
                tPart.Focus()
                SaveCanceled = True
                Exit Sub
            End If
        End If
        Grid1.UpdateData()
        grBoxes.UpdateData()
        gUpSell.UpdateData()
        BindingContext(dsPrices, "itm_price").EndCurrentEdit()

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Try
            If Open1.ShowDialog() = DialogResult.OK Then
                Dim rw As DataRow
                Dim fl As String

                For Each fl In Open1.FileNames
                    rw = dsImages.Tables(0).NewRow
                    rw("itm_img_itm_code") = tPart.Text
                    rw("itm_img_path") = fl
                    rw("itm_img_order") = 0
                    dsImages.Tables(0).Rows.Add(rw)
                Next

                UpdatePic()
            End If
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Private Sub Grid1_AfterCellActivate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Grid1.ActiveCell.Text <> "" Then Exit Sub
        Select Case Grid1.ActiveCell.Column.Header.Caption
            Case "Qty From"
                Grid1.ActiveCell.Value = "1"
            Case "Qty To"
                Grid1.ActiveCell.Value = "999999"
            Case "Start Date"
                Grid1.ActiveCell.Value = "1/1/1980"
            Case "End Date"
                Grid1.ActiveCell.Value = "12/31/2099"
        End Select
    End Sub

    Private Sub chMaterial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chMaterial.CheckedChanged
        If chMaterial.Checked And (EditMode = "Add" Or EditMode = "Edit") Then
            tMatDef.Enabled = True
        Else
            tMatDef.Enabled = False
        End If
    End Sub

    Public Overrides Sub Edit_After()
        tPart.Enabled = False
        'Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        'Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
    End Sub

    Private Sub Tab1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles Tab1.SelectedTabChanged
        If dvPrices.Table Is Nothing Then Exit Sub
        UpdatePrices(e.Tab.Key)
    End Sub
    Private Sub UpdatePrices(ByVal key As String)
        Select Case key
            Case "Base"
                dvPrices.RowFilter = "itm_price_type='Base'"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_flat_rate").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Header.Caption = "Price"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Format = "$#,###,##0.00"
            Case "RET"
                dvPrices.RowFilter = "itm_price_type='RET'"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_flat_rate").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Header.Caption = "Price"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Format = "$#,###,##0.00"
            Case "MR"
                dvPrices.RowFilter = "itm_price_type='MR'"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_flat_rate").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Header.Caption = "Price"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Format = "$#,###,##0.00"
            Case "MD"
                dvPrices.RowFilter = "itm_price_type='MD'"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_flat_rate").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Header.Caption = "Price"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Format = "$#,###,##0.00"
            Case "CON"
                dvPrices.RowFilter = "itm_price_type='CON'"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_flat_rate").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Header.Caption = "Price"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Format = "$#,###,##0.00"
            Case "ACT"
                dvPrices.RowFilter = "itm_price_type='ACT'"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_flat_rate").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Header.Caption = "Price"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Format = "$#,###,##0.00"
            Case "SHIP"
                dvPrices.RowFilter = "itm_price_type='SHIP'"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_flat_rate").Hidden = False
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Header.Caption = "Price"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Format = "$#,###,##0.00"
            Case "Install"
                dvPrices.RowFilter = "itm_price_type='Install'"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_flat_rate").Hidden = True
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Header.Caption = "Minutes"
                Grid1.DisplayLayout.Bands(0).Columns("itm_price_price").Format = "###,##0"
            Case "Boxes"
            Case "UP"
        End Select
        If key <> "NOTE" And key <> "Perc" And key <> "Boxes" And key <> "UP" And key <> "Images" Then
            dsPrices.Tables("itm_price").Columns("itm_price_type").DefaultValue = key
            Grid1.Parent = Tab1.ActiveTab.TabPage
            Grid1.DataSource = dvPrices
            Grid1.DataBind()
        End If
        ShowCurrentPrices(Grid1)
    End Sub
    Private Sub LoadBoxes()
        Dim cmd As New SqlClient.SqlCommand("select itm_box_serial,itm_box_itm_code,itm_box_len,itm_box_width,itm_box_height,itm_box_weight,itm_box_name,itm_box_dept from itm_box where itm_box_itm_code='" + tPart.Text + "'", cnn)

        daBoxes.SelectCommand = cmd
        Dim cb As New SqlClient.SqlCommandBuilder(daBoxes)
        dsBoxes.Clear()
        cnn.Open()
        daBoxes.Fill(dsBoxes, "itm_box")
        cnn.Close()

        grBoxes.DataSource = dsBoxes.Tables(0)
        grBoxes.DataBind()
    End Sub
    Private Sub LoadUpSell()
        Dim cmd As New SqlClient.SqlCommand("select * from upsell_file where upsell_parent_itm_code='" + tPart.Text + "'", cnn)

        daUpsell.SelectCommand = cmd
        Dim cb As New SqlClient.SqlCommandBuilder(daUpsell)
        dsUpsell.Clear()
        cnn.Open()
        daUpsell.Fill(dsUpsell, "upsell")
        cnn.Close()

        gUpSell.DataSource = dsUpsell.Tables(0)
        gUpSell.DataBind()
    End Sub
    Private Sub Grid1_AfterCellActivate1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.AfterCellActivate
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
            Case "Qty From"
                Grid1.ActiveCell.Value = "1"
            Case "Qty To"
                Grid1.ActiveCell.Value = "999999"
            Case "Start Date"
                Grid1.ActiveCell.Value = "1/1/1980"
            Case "End Date"
                Grid1.ActiveCell.Value = "12/31/2099"
        End Select
    End Sub

    Private Sub Grid1_InitializeLayout_1(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub tMatDef_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tMatDef.InitializeLayout

    End Sub

    Private Sub tMatDef_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tMatDef.ValueChanged
        LoadDD(ddColor, dsColor, "mat_color", "mat_color", "mat_color", "mat_color", "mat_color_mat_code='" + tMatDef.Text + "'", , "mat_color")
    End Sub

    Private Sub UltraLabel21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraLabel21.Click

    End Sub

    Private Sub UltraLabel22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraLabel22.Click

    End Sub

    Private Sub fmParts_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not onFindForm Is Nothing Then onFindForm = Nothing
    End Sub

    Private Sub tPart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPart.ValueChanged
        Me.Text = tPart.Text
    End Sub

    Private Sub UltraLabel8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraLabel8.Click

    End Sub

    Private Sub tWidth_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tWidth.Enter
        tWidth.SelectAll()
    End Sub

    Private Sub tHeight_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tHeight.Enter
        tHeight.SelectAll()
    End Sub

    Private Sub tDepth_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tDepth.Enter
        tDepth.SelectAll()
    End Sub

    Private Sub gImages_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gImages.InitializeLayout

    End Sub

    Private Sub gImages_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles gImages.AfterRowActivate
        UpdatePic()
    End Sub
 

    Private Sub tParent_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tParent.ValueChanged

    End Sub

    Private Sub tParent_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tParent.Enter
        onParent = tParent.Text
    End Sub

    Private Sub tParent_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tParent.Leave
        If onParent <> tParent.Text And tParent.Text <> "" Then
            Dim cmd As New SqlClient.SqlCommand("select itm_serial from itm_file where itm_code='" + tParent.Text + "'", cnn)
            cnn.Open()
            If nz(cmd.ExecuteScalar, 0) = 0 Then
                MsgBox("Parent item code does not exist", MsgBoxStyle.Information, "Parent?")
                tParent.Text = ""
                tParent.Focus()
                cnn.Close()
                Exit Sub
            End If
            cnn.Close()
            If MsgBox("WARNING: Most data on this item code will be overwritten with the data from the parent item code.  Item Code, Parent Code, Description and Inactive will not be overwritten.  Are you sure you want to do this?", MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.No Then
                tParent.Text = ""
                tParent.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub UltraLabel35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraLabel35.Click

    End Sub
End Class
