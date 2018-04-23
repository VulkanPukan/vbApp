Imports System.Data.SqlClient
Public Class fmWizardSub
    Inherits System.Windows.Forms.Form
    Dim dvInstItems As DataView
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
    Friend WithEvents tState As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents pFly As System.Windows.Forms.Panel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tAirfair As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tCircle As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tPcs As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tHeightOver8 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tTGCeiling As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tTGWalls As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents bSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tInstaller As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lInstaller As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tTotal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tItemized As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tItemTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tItemRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Web1 As AxSHDocVw.AxWebBrowser
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tMile As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRackTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRackRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRack As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tTravelTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tTravelRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tTravel As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tTruckTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tTruckRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tTruck As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tFoodTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tFoodRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tFood As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tLodgingTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tLodgingRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tLodging As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tZipFrom As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tZipTo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lJobBox As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tJobBox As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lMiles As System.Windows.Forms.Label
    Friend WithEvents tDriveFly As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tBottles As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tStained As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents tLacquered As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRaisedPanels As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tRacksCut As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tLightBoxes As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lQuote As System.Windows.Forms.Label
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lTotDays As System.Windows.Forms.Label
    Friend WithEvents tUser As System.Windows.Forms.Label
    Friend WithEvents tTime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lGoogleTime As System.Windows.Forms.Label
    Friend WithEvents tTotHrs As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lTax As System.Windows.Forms.Label
    Friend WithEvents lTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tEnkeboll As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tDays As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cbSaveQuote As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbSavePrint As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbSavePDF As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbSaveCheckoff As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ddWood As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel34 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents t8footTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel35 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents t8footRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents t8foot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel36 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tStainTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel37 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tStainRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tStain As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel38 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tLacqTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tLacqRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tLacq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel40 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tWoodTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tWoodRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tWood As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel42 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tEnkTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel43 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tEnkRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tEnk As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmWizardSub))
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_qty")
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
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
        Me.tInstaller = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.lInstaller = New Infragistics.Win.Misc.UltraLabel
        Me.tState = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.pFly = New System.Windows.Forms.Panel
        Me.lJobBox = New Infragistics.Win.Misc.UltraLabel
        Me.tJobBox = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.tAirfair = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.tCircle = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.tPcs = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tHeightOver8 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.tTGCeiling = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.tTGWalls = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.bSave = New Infragistics.Win.Misc.UltraButton
        Me.bCancel = New Infragistics.Win.Misc.UltraButton
        Me.tTotal = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.tItemized = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.tItemRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.tItemTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.Web1 = New AxSHDocVw.AxWebBrowser
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.tMile = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.tRackTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.tRackRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.tRack = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel
        Me.tTravelTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel
        Me.tTravelRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel
        Me.tTravel = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel
        Me.tTruckTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel
        Me.tTruckRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel
        Me.tTruck = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel
        Me.tFoodTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel
        Me.tFoodRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel
        Me.tFood = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel
        Me.tLodgingTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel
        Me.tLodgingRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel
        Me.tLodging = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel
        Me.tZipFrom = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel
        Me.tZipTo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.lMiles = New System.Windows.Forms.Label
        Me.tDriveFly = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel
        Me.tBottles = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tStained = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.tLacquered = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel
        Me.tRaisedPanels = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel
        Me.tRacksCut = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel
        Me.tLightBoxes = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lQuote = New System.Windows.Forms.Label
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.lTotDays = New System.Windows.Forms.Label
        Me.tUser = New System.Windows.Forms.Label
        Me.tTime = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.lGoogleTime = New System.Windows.Forms.Label
        Me.tTotHrs = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lTax = New System.Windows.Forms.Label
        Me.lTotal = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel
        Me.tEnkeboll = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.tDays = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.cbSaveQuote = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbSavePrint = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbSavePDF = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbSaveCheckoff = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ddWood = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel34 = New Infragistics.Win.Misc.UltraLabel
        Me.t8footTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel35 = New Infragistics.Win.Misc.UltraLabel
        Me.t8footRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.t8foot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel36 = New Infragistics.Win.Misc.UltraLabel
        Me.tStainTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel37 = New Infragistics.Win.Misc.UltraLabel
        Me.tStainRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tStain = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel38 = New Infragistics.Win.Misc.UltraLabel
        Me.tLacqTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel
        Me.tLacqRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tLacq = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel40 = New Infragistics.Win.Misc.UltraLabel
        Me.tWoodTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel
        Me.tWoodRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tWood = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel42 = New Infragistics.Win.Misc.UltraLabel
        Me.tEnkTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel43 = New Infragistics.Win.Misc.UltraLabel
        Me.tEnkRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tEnk = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label5 = New System.Windows.Forms.Label
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        CType(Me.tInstaller, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tState, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pFly.SuspendLayout()
        CType(Me.tJobBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAirfair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCircle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPcs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tHeightOver8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTGCeiling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTGWalls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tItemized, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tItemRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tItemTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Web1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tMile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRackTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRackRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTravelTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTravelRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTravel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTruckTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTruckRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTruck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tFoodTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tFoodRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLodgingTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLodgingRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLodging, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tZipFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tZipTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDriveFly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBottles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tStained, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLacquered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRaisedPanels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRacksCut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLightBoxes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTotHrs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tEnkeboll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSaveQuote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSavePrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSavePDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSaveCheckoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddWood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t8footTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t8footRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t8foot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tStainTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tStainRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tStain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLacqTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLacqRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLacq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tWoodTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tWoodRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tWood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tEnkTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tEnkRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tEnk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tInstaller
        '
        Me.tInstaller.CheckedListSettings.CheckStateMember = ""
        Me.tInstaller.Location = New System.Drawing.Point(56, 32)
        Me.tInstaller.Name = "tInstaller"
        Me.tInstaller.Size = New System.Drawing.Size(184, 22)
        Me.tInstaller.TabIndex = 0
        Me.tInstaller.Tag = "edit;install_installer_serial;dd"
        '
        'lInstaller
        '
        Me.lInstaller.Location = New System.Drawing.Point(8, 32)
        Me.lInstaller.Name = "lInstaller"
        Me.lInstaller.Size = New System.Drawing.Size(40, 16)
        Me.lInstaller.TabIndex = 1
        Me.lInstaller.Text = "Installer"
        '
        'tState
        '
        Me.tState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tState.Location = New System.Drawing.Point(56, 56)
        Me.tState.Name = "tState"
        Me.tState.Size = New System.Drawing.Size(32, 21)
        Me.tState.TabIndex = 1
        Me.tState.Tag = "edit;install_state"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 56)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(40, 16)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "State"
        '
        'pFly
        '
        Me.pFly.Controls.Add(Me.lJobBox)
        Me.pFly.Controls.Add(Me.tJobBox)
        Me.pFly.Controls.Add(Me.UltraLabel2)
        Me.pFly.Controls.Add(Me.tAirfair)
        Me.pFly.Location = New System.Drawing.Point(64, 88)
        Me.pFly.Name = "pFly"
        Me.pFly.Size = New System.Drawing.Size(128, 48)
        Me.pFly.TabIndex = 7
        '
        'lJobBox
        '
        Me.lJobBox.Location = New System.Drawing.Point(8, 24)
        Me.lJobBox.Name = "lJobBox"
        Me.lJobBox.Size = New System.Drawing.Size(48, 16)
        Me.lJobBox.TabIndex = 7
        Me.lJobBox.Text = "Job box"
        '
        'tJobBox
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.tJobBox.Appearance = Appearance1
        Me.tJobBox.Location = New System.Drawing.Point(56, 24)
        Me.tJobBox.Name = "tJobBox"
        Me.tJobBox.Size = New System.Drawing.Size(72, 21)
        Me.tJobBox.TabIndex = 8
        Me.tJobBox.Tag = "edit;install_jobbox;cu"
        Me.tJobBox.Text = "$0.00"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(8, 0)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "Airfair"
        '
        'tAirfair
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.tAirfair.Appearance = Appearance2
        Me.tAirfair.Location = New System.Drawing.Point(56, 0)
        Me.tAirfair.Name = "tAirfair"
        Me.tAirfair.Size = New System.Drawing.Size(72, 21)
        Me.tAirfair.TabIndex = 7
        Me.tAirfair.Tag = "edit;install_airfair;cu"
        Me.tAirfair.Text = "$0.00"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(8, 176)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(136, 24)
        Me.UltraLabel3.TabIndex = 9
        Me.UltraLabel3.Text = "# Circles on Molding Plan"
        '
        'tCircle
        '
        Appearance3.BackColor = System.Drawing.Color.Yellow
        Appearance3.TextHAlignAsString = "Right"
        Me.tCircle.Appearance = Appearance3
        Me.tCircle.BackColor = System.Drawing.Color.Yellow
        Me.tCircle.Location = New System.Drawing.Point(144, 176)
        Me.tCircle.Name = "tCircle"
        Me.tCircle.Size = New System.Drawing.Size(48, 21)
        Me.tCircle.TabIndex = 10
        Me.tCircle.Tag = "edit;install_circles;nm"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 200)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(120, 24)
        Me.UltraLabel4.TabIndex = 11
        Me.UltraLabel4.Text = "Pieces of Molding"
        '
        'tPcs
        '
        Appearance4.BackColor = System.Drawing.Color.Yellow
        Appearance4.TextHAlignAsString = "Right"
        Me.tPcs.Appearance = Appearance4
        Me.tPcs.BackColor = System.Drawing.Color.Yellow
        Me.tPcs.Location = New System.Drawing.Point(144, 200)
        Me.tPcs.Name = "tPcs"
        Me.tPcs.Size = New System.Drawing.Size(48, 21)
        Me.tPcs.TabIndex = 11
        Me.tPcs.Tag = "edit;install_molding;nm"
        '
        'tHeightOver8
        '
        Me.tHeightOver8.Location = New System.Drawing.Point(16, 352)
        Me.tHeightOver8.Name = "tHeightOver8"
        Me.tHeightOver8.Size = New System.Drawing.Size(64, 16)
        Me.tHeightOver8.TabIndex = 14
        Me.tHeightOver8.Tag = "edit;install_over8;cb"
        Me.tHeightOver8.Text = "Over 8'"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(224, 224)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(120, 24)
        Me.UltraLabel5.TabIndex = 14
        Me.UltraLabel5.Text = "Boxes T&&G for Ceiling"
        '
        'tTGCeiling
        '
        Appearance5.BackColor = System.Drawing.Color.Yellow
        Appearance5.TextHAlignAsString = "Right"
        Me.tTGCeiling.Appearance = Appearance5
        Me.tTGCeiling.BackColor = System.Drawing.Color.Yellow
        Me.tTGCeiling.Location = New System.Drawing.Point(368, 224)
        Me.tTGCeiling.Name = "tTGCeiling"
        Me.tTGCeiling.Size = New System.Drawing.Size(48, 21)
        Me.tTGCeiling.TabIndex = 12
        Me.tTGCeiling.Tag = "edit;install_tg_ceiling_boxes;nm"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(224, 248)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel6.TabIndex = 16
        Me.UltraLabel6.Text = "Boxes T&&G for Walls"
        '
        'tTGWalls
        '
        Appearance6.BackColor = System.Drawing.Color.Yellow
        Appearance6.TextHAlignAsString = "Right"
        Me.tTGWalls.Appearance = Appearance6
        Me.tTGWalls.BackColor = System.Drawing.Color.Yellow
        Me.tTGWalls.Location = New System.Drawing.Point(368, 248)
        Me.tTGWalls.Name = "tTGWalls"
        Me.tTGWalls.Size = New System.Drawing.Size(48, 21)
        Me.tTGWalls.TabIndex = 13
        Me.tTGWalls.Tag = "edit;install_tg_wall_boxes;nm"
        '
        'bSave
        '
        Me.bSave.Enabled = False
        Me.bSave.Location = New System.Drawing.Point(8, 600)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(80, 24)
        Me.bSave.TabIndex = 33
        Me.bSave.Text = "Save"
        '
        'bCancel
        '
        Me.bCancel.Location = New System.Drawing.Point(8, 632)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(80, 24)
        Me.bCancel.TabIndex = 34
        Me.bCancel.Text = "Cancel"
        '
        'tTotal
        '
        Appearance7.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance7.FontData.SizeInPoints = 12.0!
        Appearance7.TextHAlignAsString = "Right"
        Me.tTotal.Appearance = Appearance7
        Me.tTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tTotal.Location = New System.Drawing.Point(288, 592)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.ReadOnly = True
        Me.tTotal.Size = New System.Drawing.Size(112, 28)
        Me.tTotal.TabIndex = 19
        Me.tTotal.Tag = "edit;install_total;cu"
        Me.tTotal.Text = "$0.00"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Location = New System.Drawing.Point(8, 280)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel7.TabIndex = 21
        Me.UltraLabel7.Text = "Itemized Installation"
        '
        'tItemized
        '
        Appearance8.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance8.TextHAlignAsString = "Right"
        Me.tItemized.Appearance = Appearance8
        Me.tItemized.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tItemized.Location = New System.Drawing.Point(120, 280)
        Me.tItemized.Name = "tItemized"
        Me.tItemized.ReadOnly = True
        Me.tItemized.Size = New System.Drawing.Size(56, 21)
        Me.tItemized.TabIndex = 21
        Me.tItemized.Tag = "edit;install_item_hrs;nm"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Location = New System.Drawing.Point(184, 288)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel8.TabIndex = 23
        Me.UltraLabel8.Text = "hours X"
        '
        'tItemRate
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.tItemRate.Appearance = Appearance9
        Me.tItemRate.Location = New System.Drawing.Point(232, 280)
        Me.tItemRate.Name = "tItemRate"
        Me.tItemRate.Size = New System.Drawing.Size(56, 21)
        Me.tItemRate.TabIndex = 22
        Me.tItemRate.Tag = "edit;install_item_rate;cu"
        Me.tItemRate.Text = "$75.00"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.Location = New System.Drawing.Point(296, 288)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(32, 24)
        Me.UltraLabel9.TabIndex = 25
        Me.UltraLabel9.Text = "total"
        '
        'tItemTot
        '
        Appearance10.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance10.TextHAlignAsString = "Right"
        Me.tItemTot.Appearance = Appearance10
        Me.tItemTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tItemTot.Location = New System.Drawing.Point(328, 280)
        Me.tItemTot.Name = "tItemTot"
        Me.tItemTot.ReadOnly = True
        Me.tItemTot.Size = New System.Drawing.Size(72, 21)
        Me.tItemTot.TabIndex = 24
        Me.tItemTot.Tag = ""
        Me.tItemTot.Text = "$0.00"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(328, 48)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(88, 32)
        Me.UltraButton1.TabIndex = 5
        Me.UltraButton1.Text = "Get Miles and Travel Time"
        '
        'Web1
        '
        Me.Web1.Enabled = True
        Me.Web1.Location = New System.Drawing.Point(512, 112)
        Me.Web1.OcxState = CType(resources.GetObject("Web1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Web1.Size = New System.Drawing.Size(235, 424)
        Me.Web1.TabIndex = 27
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(248, 56)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(32, 16)
        Me.UltraLabel10.TabIndex = 29
        Me.UltraLabel10.Text = "Miles"
        '
        'tMile
        '
        Appearance11.BackColor = System.Drawing.Color.Yellow
        Appearance11.TextHAlignAsString = "Right"
        Me.tMile.Appearance = Appearance11
        Me.tMile.BackColor = System.Drawing.Color.Yellow
        Me.tMile.Location = New System.Drawing.Point(280, 56)
        Me.tMile.Name = "tMile"
        Me.tMile.Size = New System.Drawing.Size(48, 21)
        Me.tMile.TabIndex = 4
        Me.tMile.Tag = "edit;install_miles;nm"
        Me.tMile.Text = "0"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.Location = New System.Drawing.Point(296, 312)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(32, 24)
        Me.UltraLabel11.TabIndex = 35
        Me.UltraLabel11.Text = "total"
        '
        'tRackTot
        '
        Appearance12.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance12.TextHAlignAsString = "Right"
        Me.tRackTot.Appearance = Appearance12
        Me.tRackTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tRackTot.Location = New System.Drawing.Point(328, 304)
        Me.tRackTot.Name = "tRackTot"
        Me.tRackTot.ReadOnly = True
        Me.tRackTot.Size = New System.Drawing.Size(72, 21)
        Me.tRackTot.TabIndex = 34
        Me.tRackTot.Tag = ""
        Me.tRackTot.Text = "$0.00"
        '
        'UltraLabel12
        '
        Me.UltraLabel12.Location = New System.Drawing.Point(184, 312)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel12.TabIndex = 33
        Me.UltraLabel12.Text = "hours X"
        '
        'tRackRate
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.tRackRate.Appearance = Appearance13
        Me.tRackRate.Location = New System.Drawing.Point(232, 304)
        Me.tRackRate.Name = "tRackRate"
        Me.tRackRate.Size = New System.Drawing.Size(56, 21)
        Me.tRackRate.TabIndex = 24
        Me.tRackRate.Tag = "edit;install_rack_rate;cu"
        Me.tRackRate.Text = "$75.00"
        '
        'UltraLabel13
        '
        Me.UltraLabel13.Location = New System.Drawing.Point(8, 304)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel13.TabIndex = 31
        Me.UltraLabel13.Text = "Racking Install"
        '
        'tRack
        '
        Appearance14.BackColor = System.Drawing.Color.Yellow
        Appearance14.TextHAlignAsString = "Right"
        Me.tRack.Appearance = Appearance14
        Me.tRack.BackColor = System.Drawing.Color.Yellow
        Me.tRack.Location = New System.Drawing.Point(120, 304)
        Me.tRack.Name = "tRack"
        Me.tRack.Size = New System.Drawing.Size(56, 21)
        Me.tRack.TabIndex = 23
        Me.tRack.Tag = "edit;install_rack_hrs;nm"
        '
        'UltraLabel14
        '
        Me.UltraLabel14.Location = New System.Drawing.Point(296, 336)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(32, 24)
        Me.UltraLabel14.TabIndex = 41
        Me.UltraLabel14.Text = "total"
        '
        'tTravelTot
        '
        Appearance15.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance15.TextHAlignAsString = "Right"
        Me.tTravelTot.Appearance = Appearance15
        Me.tTravelTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tTravelTot.Location = New System.Drawing.Point(328, 328)
        Me.tTravelTot.Name = "tTravelTot"
        Me.tTravelTot.ReadOnly = True
        Me.tTravelTot.Size = New System.Drawing.Size(72, 21)
        Me.tTravelTot.TabIndex = 40
        Me.tTravelTot.Tag = ""
        Me.tTravelTot.Text = "$0.00"
        '
        'UltraLabel15
        '
        Me.UltraLabel15.Location = New System.Drawing.Point(184, 336)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel15.TabIndex = 39
        Me.UltraLabel15.Text = "hours X"
        '
        'tTravelRate
        '
        Appearance16.TextHAlignAsString = "Right"
        Me.tTravelRate.Appearance = Appearance16
        Me.tTravelRate.Location = New System.Drawing.Point(232, 328)
        Me.tTravelRate.Name = "tTravelRate"
        Me.tTravelRate.Size = New System.Drawing.Size(56, 21)
        Me.tTravelRate.TabIndex = 26
        Me.tTravelRate.Tag = "edit;install_travel_rate;cu"
        Me.tTravelRate.Text = "$75.00"
        '
        'UltraLabel16
        '
        Me.UltraLabel16.Location = New System.Drawing.Point(8, 328)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel16.TabIndex = 37
        Me.UltraLabel16.Text = "Cost for Travel Time"
        '
        'tTravel
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.tTravel.Appearance = Appearance17
        Me.tTravel.Location = New System.Drawing.Point(120, 328)
        Me.tTravel.Name = "tTravel"
        Me.tTravel.Size = New System.Drawing.Size(56, 21)
        Me.tTravel.TabIndex = 25
        Me.tTravel.Tag = "edit;install_travel_hrs;nm"
        '
        'UltraLabel17
        '
        Me.UltraLabel17.Location = New System.Drawing.Point(296, 568)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(32, 24)
        Me.UltraLabel17.TabIndex = 59
        Me.UltraLabel17.Text = "total"
        '
        'tTruckTot
        '
        Appearance18.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance18.TextHAlignAsString = "Right"
        Me.tTruckTot.Appearance = Appearance18
        Me.tTruckTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tTruckTot.Location = New System.Drawing.Point(328, 560)
        Me.tTruckTot.Name = "tTruckTot"
        Me.tTruckTot.ReadOnly = True
        Me.tTruckTot.Size = New System.Drawing.Size(72, 21)
        Me.tTruckTot.TabIndex = 58
        Me.tTruckTot.Tag = ""
        Me.tTruckTot.Text = "$0.00"
        '
        'UltraLabel18
        '
        Me.UltraLabel18.Location = New System.Drawing.Point(184, 568)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel18.TabIndex = 57
        Me.UltraLabel18.Text = "days X"
        '
        'tTruckRate
        '
        Appearance19.TextHAlignAsString = "Right"
        Me.tTruckRate.Appearance = Appearance19
        Me.tTruckRate.Location = New System.Drawing.Point(232, 560)
        Me.tTruckRate.Name = "tTruckRate"
        Me.tTruckRate.Size = New System.Drawing.Size(56, 21)
        Me.tTruckRate.TabIndex = 32
        Me.tTruckRate.Tag = "edit;install_truck_rate;cu"
        Me.tTruckRate.Text = "$100.00"
        '
        'UltraLabel19
        '
        Me.UltraLabel19.Location = New System.Drawing.Point(8, 560)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel19.TabIndex = 55
        Me.UltraLabel19.Text = "Rental Truck"
        '
        'tTruck
        '
        Appearance20.TextHAlignAsString = "Right"
        Me.tTruck.Appearance = Appearance20
        Me.tTruck.Location = New System.Drawing.Point(120, 560)
        Me.tTruck.Name = "tTruck"
        Me.tTruck.Size = New System.Drawing.Size(56, 21)
        Me.tTruck.TabIndex = 31
        Me.tTruck.Tag = "edit;install_truck_days;nm"
        '
        'UltraLabel20
        '
        Me.UltraLabel20.Location = New System.Drawing.Point(296, 544)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(32, 24)
        Me.UltraLabel20.TabIndex = 53
        Me.UltraLabel20.Text = "total"
        '
        'tFoodTot
        '
        Appearance21.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance21.TextHAlignAsString = "Right"
        Me.tFoodTot.Appearance = Appearance21
        Me.tFoodTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tFoodTot.Location = New System.Drawing.Point(328, 536)
        Me.tFoodTot.Name = "tFoodTot"
        Me.tFoodTot.ReadOnly = True
        Me.tFoodTot.Size = New System.Drawing.Size(72, 21)
        Me.tFoodTot.TabIndex = 52
        Me.tFoodTot.Tag = ""
        Me.tFoodTot.Text = "$0.00"
        '
        'UltraLabel21
        '
        Me.UltraLabel21.Location = New System.Drawing.Point(184, 544)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel21.TabIndex = 51
        Me.UltraLabel21.Text = "days X"
        '
        'tFoodRate
        '
        Appearance22.TextHAlignAsString = "Right"
        Me.tFoodRate.Appearance = Appearance22
        Me.tFoodRate.Location = New System.Drawing.Point(232, 536)
        Me.tFoodRate.Name = "tFoodRate"
        Me.tFoodRate.Size = New System.Drawing.Size(56, 21)
        Me.tFoodRate.TabIndex = 30
        Me.tFoodRate.Tag = "edit;install_food_rate;cu"
        Me.tFoodRate.Text = "$30.00"
        '
        'UltraLabel22
        '
        Me.UltraLabel22.Location = New System.Drawing.Point(8, 536)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel22.TabIndex = 49
        Me.UltraLabel22.Text = "Food"
        '
        'tFood
        '
        Appearance23.TextHAlignAsString = "Right"
        Me.tFood.Appearance = Appearance23
        Me.tFood.Location = New System.Drawing.Point(120, 536)
        Me.tFood.Name = "tFood"
        Me.tFood.Size = New System.Drawing.Size(56, 21)
        Me.tFood.TabIndex = 29
        Me.tFood.Tag = "edit;install_food_days;nm"
        '
        'UltraLabel23
        '
        Me.UltraLabel23.Location = New System.Drawing.Point(296, 520)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(32, 24)
        Me.UltraLabel23.TabIndex = 47
        Me.UltraLabel23.Text = "total"
        '
        'tLodgingTot
        '
        Appearance24.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance24.TextHAlignAsString = "Right"
        Me.tLodgingTot.Appearance = Appearance24
        Me.tLodgingTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tLodgingTot.Location = New System.Drawing.Point(328, 512)
        Me.tLodgingTot.Name = "tLodgingTot"
        Me.tLodgingTot.ReadOnly = True
        Me.tLodgingTot.Size = New System.Drawing.Size(72, 21)
        Me.tLodgingTot.TabIndex = 46
        Me.tLodgingTot.Tag = ""
        Me.tLodgingTot.Text = "$0.00"
        '
        'UltraLabel24
        '
        Me.UltraLabel24.Location = New System.Drawing.Point(184, 520)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel24.TabIndex = 45
        Me.UltraLabel24.Text = "days X"
        '
        'tLodgingRate
        '
        Appearance25.TextHAlignAsString = "Right"
        Me.tLodgingRate.Appearance = Appearance25
        Me.tLodgingRate.Location = New System.Drawing.Point(232, 512)
        Me.tLodgingRate.Name = "tLodgingRate"
        Me.tLodgingRate.Size = New System.Drawing.Size(56, 21)
        Me.tLodgingRate.TabIndex = 28
        Me.tLodgingRate.Tag = "edit;install_lodging_rate;cu"
        Me.tLodgingRate.Text = "$0.00"
        '
        'UltraLabel25
        '
        Me.UltraLabel25.Location = New System.Drawing.Point(8, 512)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel25.TabIndex = 43
        Me.UltraLabel25.Text = "Lodging"
        '
        'tLodging
        '
        Appearance26.TextHAlignAsString = "Right"
        Me.tLodging.Appearance = Appearance26
        Me.tLodging.Location = New System.Drawing.Point(120, 512)
        Me.tLodging.Name = "tLodging"
        Me.tLodging.Size = New System.Drawing.Size(56, 21)
        Me.tLodging.TabIndex = 27
        Me.tLodging.Tag = "edit;install_lodging_days;nm"
        '
        'UltraLabel26
        '
        Me.UltraLabel26.Location = New System.Drawing.Point(96, 56)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(24, 16)
        Me.UltraLabel26.TabIndex = 61
        Me.UltraLabel26.Text = "Zip"
        '
        'tZipFrom
        '
        Me.tZipFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tZipFrom.Location = New System.Drawing.Point(120, 56)
        Me.tZipFrom.Name = "tZipFrom"
        Me.tZipFrom.Size = New System.Drawing.Size(48, 21)
        Me.tZipFrom.TabIndex = 2
        Me.tZipFrom.Tag = "edit;install_zipfrom"
        '
        'UltraLabel27
        '
        Me.UltraLabel27.Location = New System.Drawing.Point(176, 56)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(24, 16)
        Me.UltraLabel27.TabIndex = 63
        Me.UltraLabel27.Text = "to"
        '
        'tZipTo
        '
        Me.tZipTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tZipTo.Location = New System.Drawing.Point(192, 56)
        Me.tZipTo.Name = "tZipTo"
        Me.tZipTo.Size = New System.Drawing.Size(48, 21)
        Me.tZipTo.TabIndex = 3
        Me.tZipTo.Tag = "edit;install_zipto"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 359
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid1.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid1.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid1.Location = New System.Drawing.Point(424, 8)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(361, 630)
        Me.Grid1.TabIndex = 64
        '
        'lMiles
        '
        Me.lMiles.ForeColor = System.Drawing.Color.Red
        Me.lMiles.Location = New System.Drawing.Point(336, 80)
        Me.lMiles.Name = "lMiles"
        Me.lMiles.Size = New System.Drawing.Size(80, 16)
        Me.lMiles.TabIndex = 65
        Me.lMiles.Text = "Getting Miles"
        Me.lMiles.Visible = False
        '
        'tDriveFly
        '
        Me.tDriveFly.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.tDriveFly.CheckedIndex = 0
        ValueListItem1.DataValue = "D"
        ValueListItem1.DisplayText = "Drive"
        ValueListItem2.DataValue = "F"
        ValueListItem2.DisplayText = "Fly"
        Me.tDriveFly.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.tDriveFly.Location = New System.Drawing.Point(8, 88)
        Me.tDriveFly.Name = "tDriveFly"
        Me.tDriveFly.Size = New System.Drawing.Size(56, 32)
        Me.tDriveFly.TabIndex = 6
        Me.tDriveFly.Tag = "edit;install_drivefly;op"
        Me.tDriveFly.Text = "Drive"
        '
        'UltraLabel28
        '
        Me.UltraLabel28.Location = New System.Drawing.Point(8, 152)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(136, 24)
        Me.UltraLabel28.TabIndex = 68
        Me.UltraLabel28.Text = "Bottle Count"
        '
        'tBottles
        '
        Appearance28.BackColor = System.Drawing.Color.Yellow
        Appearance28.TextHAlignAsString = "Right"
        Me.tBottles.Appearance = Appearance28
        Me.tBottles.BackColor = System.Drawing.Color.Yellow
        Me.tBottles.Location = New System.Drawing.Point(144, 152)
        Me.tBottles.Name = "tBottles"
        Me.tBottles.Size = New System.Drawing.Size(48, 21)
        Me.tBottles.TabIndex = 9
        Me.tBottles.Tag = "edit;install_bottles;nm"
        Me.tBottles.Text = "0"
        '
        'tStained
        '
        Me.tStained.Location = New System.Drawing.Point(16, 376)
        Me.tStained.Name = "tStained"
        Me.tStained.Size = New System.Drawing.Size(80, 16)
        Me.tStained.TabIndex = 15
        Me.tStained.Tag = "edit;install_stained;cb"
        Me.tStained.Text = "Stained"
        '
        'tLacquered
        '
        Me.tLacquered.Location = New System.Drawing.Point(16, 400)
        Me.tLacquered.Name = "tLacquered"
        Me.tLacquered.Size = New System.Drawing.Size(88, 16)
        Me.tLacquered.TabIndex = 16
        Me.tLacquered.Tag = "edit;install_lacquered;cb"
        Me.tLacquered.Text = "Lacquered"
        '
        'UltraLabel29
        '
        Me.UltraLabel29.Location = New System.Drawing.Point(224, 144)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(136, 24)
        Me.UltraLabel29.TabIndex = 74
        Me.UltraLabel29.Text = "Raised Panels for Ceiling"
        '
        'tRaisedPanels
        '
        Appearance29.BackColor = System.Drawing.Color.Yellow
        Appearance29.TextHAlignAsString = "Right"
        Me.tRaisedPanels.Appearance = Appearance29
        Me.tRaisedPanels.BackColor = System.Drawing.Color.Yellow
        Me.tRaisedPanels.Location = New System.Drawing.Point(368, 144)
        Me.tRaisedPanels.Name = "tRaisedPanels"
        Me.tRaisedPanels.Size = New System.Drawing.Size(48, 21)
        Me.tRaisedPanels.TabIndex = 18
        Me.tRaisedPanels.Tag = "edit;install_raised_panels;nm"
        '
        'UltraLabel30
        '
        Me.UltraLabel30.Location = New System.Drawing.Point(224, 168)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(144, 24)
        Me.UltraLabel30.TabIndex = 76
        Me.UltraLabel30.Text = "Sections of Rack Cut to Fit"
        '
        'tRacksCut
        '
        Appearance30.BackColor = System.Drawing.Color.Yellow
        Appearance30.TextHAlignAsString = "Right"
        Me.tRacksCut.Appearance = Appearance30
        Me.tRacksCut.BackColor = System.Drawing.Color.Yellow
        Me.tRacksCut.Location = New System.Drawing.Point(368, 168)
        Me.tRacksCut.Name = "tRacksCut"
        Me.tRacksCut.Size = New System.Drawing.Size(48, 21)
        Me.tRacksCut.TabIndex = 19
        Me.tRacksCut.Tag = "edit;install_racks_cut;nm"
        '
        'UltraLabel31
        '
        Me.UltraLabel31.Location = New System.Drawing.Point(224, 192)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(104, 24)
        Me.UltraLabel31.TabIndex = 78
        Me.UltraLabel31.Text = "Light Boxes"
        '
        'tLightBoxes
        '
        Appearance31.BackColor = System.Drawing.Color.Yellow
        Appearance31.TextHAlignAsString = "Right"
        Me.tLightBoxes.Appearance = Appearance31
        Me.tLightBoxes.BackColor = System.Drawing.Color.Yellow
        Me.tLightBoxes.Location = New System.Drawing.Point(368, 192)
        Me.tLightBoxes.Name = "tLightBoxes"
        Me.tLightBoxes.Size = New System.Drawing.Size(48, 21)
        Me.tLightBoxes.TabIndex = 20
        Me.tLightBoxes.Tag = "edit;install_light_boxes;nm"
        '
        'lQuote
        '
        Me.lQuote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lQuote.Location = New System.Drawing.Point(0, 0)
        Me.lQuote.Name = "lQuote"
        Me.lQuote.Size = New System.Drawing.Size(288, 23)
        Me.lQuote.TabIndex = 80
        Me.lQuote.Text = "Quote 0-0"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(296, 8)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(112, 24)
        Me.UltraButton2.TabIndex = 82
        Me.UltraButton2.Text = "Reload Values"
        '
        'lTotDays
        '
        Me.lTotDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotDays.Location = New System.Drawing.Point(176, 480)
        Me.lTotDays.Name = "lTotDays"
        Me.lTotDays.Size = New System.Drawing.Size(112, 16)
        Me.lTotDays.TabIndex = 84
        Me.lTotDays.Text = "hrs / 9 ="
        '
        'tUser
        '
        Me.tUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tUser.Location = New System.Drawing.Point(496, 641)
        Me.tUser.Name = "tUser"
        Me.tUser.Size = New System.Drawing.Size(128, 16)
        Me.tUser.TabIndex = 85
        Me.tUser.Text = "User"
        '
        'tTime
        '
        Me.tTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tTime.Location = New System.Drawing.Point(648, 641)
        Me.tTime.Name = "tTime"
        Me.tTime.Size = New System.Drawing.Size(128, 16)
        Me.tTime.TabIndex = 86
        Me.tTime.Text = "0:00"
        Me.tTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(424, 641)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Last Saved:"
        '
        'UltraButton3
        '
        Me.UltraButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton3.Location = New System.Drawing.Point(56, 512)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(56, 20)
        Me.UltraButton3.TabIndex = 89
        Me.UltraButton3.Text = "Hotels"
        '
        'lGoogleTime
        '
        Me.lGoogleTime.Location = New System.Drawing.Point(208, 88)
        Me.lGoogleTime.Name = "lGoogleTime"
        Me.lGoogleTime.Size = New System.Drawing.Size(208, 48)
        Me.lGoogleTime.TabIndex = 90
        Me.lGoogleTime.Tag = "edit;install_mapquest_time"
        '
        'tTotHrs
        '
        Appearance32.TextHAlignAsString = "Right"
        Me.tTotHrs.Appearance = Appearance32
        Me.tTotHrs.Location = New System.Drawing.Point(120, 480)
        Me.tTotHrs.Name = "tTotHrs"
        Me.tTotHrs.Size = New System.Drawing.Size(56, 21)
        Me.tTotHrs.TabIndex = 91
        Me.tTotHrs.Tag = ""
        '
        'lTax
        '
        Me.lTax.Location = New System.Drawing.Point(288, 624)
        Me.lTax.Name = "lTax"
        Me.lTax.Size = New System.Drawing.Size(112, 16)
        Me.lTax.TabIndex = 92
        Me.lTax.Text = "$0.00"
        Me.lTax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lTotal
        '
        Me.lTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotal.Location = New System.Drawing.Point(288, 640)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(112, 16)
        Me.lTotal.TabIndex = 93
        Me.lTotal.Text = "$0.00"
        Me.lTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(288, 624)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Tax"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(288, 640)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Total"
        '
        'UltraLabel32
        '
        Me.UltraLabel32.Location = New System.Drawing.Point(8, 448)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(56, 24)
        Me.UltraLabel32.TabIndex = 97
        Me.UltraLabel32.Text = "Enkeboll Value"
        '
        'tEnkeboll
        '
        Appearance33.BackColor = System.Drawing.Color.Yellow
        Appearance33.TextHAlignAsString = "Right"
        Me.tEnkeboll.Appearance = Appearance33
        Me.tEnkeboll.BackColor = System.Drawing.Color.Yellow
        Me.tEnkeboll.Location = New System.Drawing.Point(56, 448)
        Me.tEnkeboll.Name = "tEnkeboll"
        Me.tEnkeboll.Size = New System.Drawing.Size(64, 21)
        Me.tEnkeboll.TabIndex = 96
        Me.tEnkeboll.Tag = "edit;install_enkeboll;cu"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(296, 480)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "days"
        '
        'tDays
        '
        Appearance34.TextHAlignAsString = "Right"
        Me.tDays.Appearance = Appearance34
        Me.tDays.Location = New System.Drawing.Point(240, 480)
        Me.tDays.Name = "tDays"
        Me.tDays.Size = New System.Drawing.Size(48, 21)
        Me.tDays.TabIndex = 100
        Me.tDays.Tag = ""
        Me.tDays.Text = "0"
        '
        'cbSaveQuote
        '
        Me.cbSaveQuote.Location = New System.Drawing.Point(96, 592)
        Me.cbSaveQuote.Name = "cbSaveQuote"
        Me.cbSaveQuote.Size = New System.Drawing.Size(168, 16)
        Me.cbSaveQuote.TabIndex = 101
        Me.cbSaveQuote.Text = "Save Quote/Order"
        '
        'cbSavePrint
        '
        Me.cbSavePrint.Location = New System.Drawing.Point(96, 608)
        Me.cbSavePrint.Name = "cbSavePrint"
        Me.cbSavePrint.Size = New System.Drawing.Size(168, 16)
        Me.cbSavePrint.TabIndex = 102
        Me.cbSavePrint.Text = "Print Install"
        '
        'cbSavePDF
        '
        Me.cbSavePDF.Location = New System.Drawing.Point(96, 624)
        Me.cbSavePDF.Name = "cbSavePDF"
        Me.cbSavePDF.Size = New System.Drawing.Size(168, 16)
        Me.cbSavePDF.TabIndex = 103
        Me.cbSavePDF.Text = "Create PDF"
        Me.cbSavePDF.Visible = False
        '
        'cbSaveCheckoff
        '
        Me.cbSaveCheckoff.Location = New System.Drawing.Point(96, 640)
        Me.cbSaveCheckoff.Name = "cbSaveCheckoff"
        Me.cbSaveCheckoff.Size = New System.Drawing.Size(168, 16)
        Me.cbSaveCheckoff.TabIndex = 104
        Me.cbSaveCheckoff.Text = "Checkoff Install"
        '
        'ddWood
        '
        Me.ddWood.CheckedListSettings.CheckStateMember = ""
        Me.ddWood.Location = New System.Drawing.Point(8, 424)
        Me.ddWood.Name = "ddWood"
        Me.ddWood.Size = New System.Drawing.Size(112, 22)
        Me.ddWood.TabIndex = 107
        Me.ddWood.Tag = "edit;install_mat_code;dd"
        '
        'UltraLabel34
        '
        Me.UltraLabel34.Location = New System.Drawing.Point(296, 360)
        Me.UltraLabel34.Name = "UltraLabel34"
        Me.UltraLabel34.Size = New System.Drawing.Size(32, 24)
        Me.UltraLabel34.TabIndex = 112
        Me.UltraLabel34.Text = "total"
        '
        't8footTot
        '
        Appearance35.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance35.TextHAlignAsString = "Right"
        Me.t8footTot.Appearance = Appearance35
        Me.t8footTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.t8footTot.Location = New System.Drawing.Point(328, 352)
        Me.t8footTot.Name = "t8footTot"
        Me.t8footTot.ReadOnly = True
        Me.t8footTot.Size = New System.Drawing.Size(72, 21)
        Me.t8footTot.TabIndex = 111
        Me.t8footTot.Tag = ""
        Me.t8footTot.Text = "$0.00"
        '
        'UltraLabel35
        '
        Me.UltraLabel35.Location = New System.Drawing.Point(184, 360)
        Me.UltraLabel35.Name = "UltraLabel35"
        Me.UltraLabel35.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel35.TabIndex = 110
        Me.UltraLabel35.Text = "hours X"
        '
        't8footRate
        '
        Appearance36.TextHAlignAsString = "Right"
        Me.t8footRate.Appearance = Appearance36
        Me.t8footRate.Location = New System.Drawing.Point(232, 352)
        Me.t8footRate.Name = "t8footRate"
        Me.t8footRate.Size = New System.Drawing.Size(56, 21)
        Me.t8footRate.TabIndex = 109
        Me.t8footRate.Tag = "edit;install_8foot_rate;cu"
        Me.t8footRate.Text = "$75.00"
        '
        't8foot
        '
        Appearance37.TextHAlignAsString = "Right"
        Me.t8foot.Appearance = Appearance37
        Me.t8foot.Location = New System.Drawing.Point(120, 352)
        Me.t8foot.Name = "t8foot"
        Me.t8foot.Size = New System.Drawing.Size(56, 21)
        Me.t8foot.TabIndex = 108
        Me.t8foot.Tag = "edit;install_8foot_hrs;nm"
        '
        'UltraLabel36
        '
        Me.UltraLabel36.Location = New System.Drawing.Point(296, 384)
        Me.UltraLabel36.Name = "UltraLabel36"
        Me.UltraLabel36.Size = New System.Drawing.Size(32, 24)
        Me.UltraLabel36.TabIndex = 117
        Me.UltraLabel36.Text = "total"
        '
        'tStainTot
        '
        Appearance38.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance38.TextHAlignAsString = "Right"
        Me.tStainTot.Appearance = Appearance38
        Me.tStainTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tStainTot.Location = New System.Drawing.Point(328, 376)
        Me.tStainTot.Name = "tStainTot"
        Me.tStainTot.ReadOnly = True
        Me.tStainTot.Size = New System.Drawing.Size(72, 21)
        Me.tStainTot.TabIndex = 116
        Me.tStainTot.Tag = ""
        Me.tStainTot.Text = "$0.00"
        '
        'UltraLabel37
        '
        Me.UltraLabel37.Location = New System.Drawing.Point(184, 384)
        Me.UltraLabel37.Name = "UltraLabel37"
        Me.UltraLabel37.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel37.TabIndex = 115
        Me.UltraLabel37.Text = "hours X"
        '
        'tStainRate
        '
        Appearance39.TextHAlignAsString = "Right"
        Me.tStainRate.Appearance = Appearance39
        Me.tStainRate.Location = New System.Drawing.Point(232, 376)
        Me.tStainRate.Name = "tStainRate"
        Me.tStainRate.Size = New System.Drawing.Size(56, 21)
        Me.tStainRate.TabIndex = 114
        Me.tStainRate.Tag = "edit;install_stain_rate;cu"
        Me.tStainRate.Text = "$75.00"
        '
        'tStain
        '
        Appearance40.TextHAlignAsString = "Right"
        Me.tStain.Appearance = Appearance40
        Me.tStain.Location = New System.Drawing.Point(120, 376)
        Me.tStain.Name = "tStain"
        Me.tStain.Size = New System.Drawing.Size(56, 21)
        Me.tStain.TabIndex = 113
        Me.tStain.Tag = "edit;install_stain_hrs;nm"
        '
        'UltraLabel38
        '
        Me.UltraLabel38.Location = New System.Drawing.Point(296, 408)
        Me.UltraLabel38.Name = "UltraLabel38"
        Me.UltraLabel38.Size = New System.Drawing.Size(32, 24)
        Me.UltraLabel38.TabIndex = 122
        Me.UltraLabel38.Text = "total"
        '
        'tLacqTot
        '
        Appearance41.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance41.TextHAlignAsString = "Right"
        Me.tLacqTot.Appearance = Appearance41
        Me.tLacqTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tLacqTot.Location = New System.Drawing.Point(328, 400)
        Me.tLacqTot.Name = "tLacqTot"
        Me.tLacqTot.ReadOnly = True
        Me.tLacqTot.Size = New System.Drawing.Size(72, 21)
        Me.tLacqTot.TabIndex = 121
        Me.tLacqTot.Tag = ""
        Me.tLacqTot.Text = "$0.00"
        '
        'UltraLabel39
        '
        Me.UltraLabel39.Location = New System.Drawing.Point(184, 408)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel39.TabIndex = 120
        Me.UltraLabel39.Text = "hours X"
        '
        'tLacqRate
        '
        Appearance42.TextHAlignAsString = "Right"
        Me.tLacqRate.Appearance = Appearance42
        Me.tLacqRate.Location = New System.Drawing.Point(232, 400)
        Me.tLacqRate.Name = "tLacqRate"
        Me.tLacqRate.Size = New System.Drawing.Size(56, 21)
        Me.tLacqRate.TabIndex = 119
        Me.tLacqRate.Tag = "edit;install_lacq_rate;cu"
        Me.tLacqRate.Text = "$75.00"
        '
        'tLacq
        '
        Appearance43.TextHAlignAsString = "Right"
        Me.tLacq.Appearance = Appearance43
        Me.tLacq.Location = New System.Drawing.Point(120, 400)
        Me.tLacq.Name = "tLacq"
        Me.tLacq.Size = New System.Drawing.Size(56, 21)
        Me.tLacq.TabIndex = 118
        Me.tLacq.Tag = "edit;install_lacq_hrs;nm"
        '
        'UltraLabel40
        '
        Me.UltraLabel40.Location = New System.Drawing.Point(296, 432)
        Me.UltraLabel40.Name = "UltraLabel40"
        Me.UltraLabel40.Size = New System.Drawing.Size(32, 24)
        Me.UltraLabel40.TabIndex = 127
        Me.UltraLabel40.Text = "total"
        '
        'tWoodTot
        '
        Appearance44.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance44.TextHAlignAsString = "Right"
        Me.tWoodTot.Appearance = Appearance44
        Me.tWoodTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tWoodTot.Location = New System.Drawing.Point(328, 424)
        Me.tWoodTot.Name = "tWoodTot"
        Me.tWoodTot.ReadOnly = True
        Me.tWoodTot.Size = New System.Drawing.Size(72, 21)
        Me.tWoodTot.TabIndex = 126
        Me.tWoodTot.Tag = ""
        Me.tWoodTot.Text = "$0.00"
        '
        'UltraLabel41
        '
        Me.UltraLabel41.Location = New System.Drawing.Point(184, 432)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel41.TabIndex = 125
        Me.UltraLabel41.Text = "hours X"
        '
        'tWoodRate
        '
        Appearance45.TextHAlignAsString = "Right"
        Me.tWoodRate.Appearance = Appearance45
        Me.tWoodRate.Location = New System.Drawing.Point(232, 424)
        Me.tWoodRate.Name = "tWoodRate"
        Me.tWoodRate.Size = New System.Drawing.Size(56, 21)
        Me.tWoodRate.TabIndex = 124
        Me.tWoodRate.Tag = "edit;install_wood_rate;cu"
        Me.tWoodRate.Text = "$75.00"
        '
        'tWood
        '
        Appearance46.TextHAlignAsString = "Right"
        Me.tWood.Appearance = Appearance46
        Me.tWood.Location = New System.Drawing.Point(120, 424)
        Me.tWood.Name = "tWood"
        Me.tWood.Size = New System.Drawing.Size(56, 21)
        Me.tWood.TabIndex = 123
        Me.tWood.Tag = "edit;install_wood_hrs;nm"
        '
        'UltraLabel42
        '
        Me.UltraLabel42.Location = New System.Drawing.Point(296, 456)
        Me.UltraLabel42.Name = "UltraLabel42"
        Me.UltraLabel42.Size = New System.Drawing.Size(32, 24)
        Me.UltraLabel42.TabIndex = 132
        Me.UltraLabel42.Text = "total"
        '
        'tEnkTot
        '
        Appearance47.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance47.TextHAlignAsString = "Right"
        Me.tEnkTot.Appearance = Appearance47
        Me.tEnkTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tEnkTot.Location = New System.Drawing.Point(328, 448)
        Me.tEnkTot.Name = "tEnkTot"
        Me.tEnkTot.ReadOnly = True
        Me.tEnkTot.Size = New System.Drawing.Size(72, 21)
        Me.tEnkTot.TabIndex = 131
        Me.tEnkTot.Tag = ""
        Me.tEnkTot.Text = "$0.00"
        '
        'UltraLabel43
        '
        Me.UltraLabel43.Location = New System.Drawing.Point(184, 456)
        Me.UltraLabel43.Name = "UltraLabel43"
        Me.UltraLabel43.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel43.TabIndex = 130
        Me.UltraLabel43.Text = "hours X"
        '
        'tEnkRate
        '
        Appearance48.TextHAlignAsString = "Right"
        Me.tEnkRate.Appearance = Appearance48
        Me.tEnkRate.Location = New System.Drawing.Point(232, 448)
        Me.tEnkRate.Name = "tEnkRate"
        Me.tEnkRate.Size = New System.Drawing.Size(56, 21)
        Me.tEnkRate.TabIndex = 129
        Me.tEnkRate.Tag = "edit;install_enk_rate;cu"
        Me.tEnkRate.Text = "$75.00"
        '
        'tEnk
        '
        Appearance49.TextHAlignAsString = "Right"
        Me.tEnk.Appearance = Appearance49
        Me.tEnk.Location = New System.Drawing.Point(120, 448)
        Me.tEnk.Name = "tEnk"
        Me.tEnk.Size = New System.Drawing.Size(56, 21)
        Me.tEnk.TabIndex = 128
        Me.tEnk.Tag = "edit;install_enk_hrs;nm"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(8, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(408, 3)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Label5"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(428, 441)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(334, 179)
        Me.WebBrowser1.TabIndex = 134
        '
        'fmWizardSub
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(790, 670)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tEnkeboll)
        Me.Controls.Add(Me.UltraLabel42)
        Me.Controls.Add(Me.tEnkTot)
        Me.Controls.Add(Me.UltraLabel43)
        Me.Controls.Add(Me.tEnkRate)
        Me.Controls.Add(Me.tEnk)
        Me.Controls.Add(Me.UltraLabel40)
        Me.Controls.Add(Me.tWoodTot)
        Me.Controls.Add(Me.UltraLabel41)
        Me.Controls.Add(Me.tWoodRate)
        Me.Controls.Add(Me.tWood)
        Me.Controls.Add(Me.UltraLabel38)
        Me.Controls.Add(Me.tLacqTot)
        Me.Controls.Add(Me.UltraLabel39)
        Me.Controls.Add(Me.tLacqRate)
        Me.Controls.Add(Me.tLacq)
        Me.Controls.Add(Me.UltraLabel36)
        Me.Controls.Add(Me.tStainTot)
        Me.Controls.Add(Me.UltraLabel37)
        Me.Controls.Add(Me.tStainRate)
        Me.Controls.Add(Me.tStain)
        Me.Controls.Add(Me.UltraLabel34)
        Me.Controls.Add(Me.t8footTot)
        Me.Controls.Add(Me.UltraLabel35)
        Me.Controls.Add(Me.t8footRate)
        Me.Controls.Add(Me.t8foot)
        Me.Controls.Add(Me.ddWood)
        Me.Controls.Add(Me.cbSaveCheckoff)
        Me.Controls.Add(Me.cbSavePDF)
        Me.Controls.Add(Me.cbSavePrint)
        Me.Controls.Add(Me.cbSaveQuote)
        Me.Controls.Add(Me.tDays)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UltraLabel32)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lTotal)
        Me.Controls.Add(Me.lTax)
        Me.Controls.Add(Me.tTotHrs)
        Me.Controls.Add(Me.UltraButton3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tTime)
        Me.Controls.Add(Me.tUser)
        Me.Controls.Add(Me.lTotDays)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.lQuote)
        Me.Controls.Add(Me.UltraLabel31)
        Me.Controls.Add(Me.tLightBoxes)
        Me.Controls.Add(Me.UltraLabel30)
        Me.Controls.Add(Me.tRacksCut)
        Me.Controls.Add(Me.UltraLabel29)
        Me.Controls.Add(Me.tRaisedPanels)
        Me.Controls.Add(Me.tLacquered)
        Me.Controls.Add(Me.tStained)
        Me.Controls.Add(Me.UltraLabel28)
        Me.Controls.Add(Me.tBottles)
        Me.Controls.Add(Me.tDriveFly)
        Me.Controls.Add(Me.lMiles)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Web1)
        Me.Controls.Add(Me.tZipTo)
        Me.Controls.Add(Me.UltraLabel26)
        Me.Controls.Add(Me.tZipFrom)
        Me.Controls.Add(Me.UltraLabel17)
        Me.Controls.Add(Me.tTruckTot)
        Me.Controls.Add(Me.UltraLabel18)
        Me.Controls.Add(Me.tTruckRate)
        Me.Controls.Add(Me.UltraLabel19)
        Me.Controls.Add(Me.tTruck)
        Me.Controls.Add(Me.UltraLabel20)
        Me.Controls.Add(Me.tFoodTot)
        Me.Controls.Add(Me.UltraLabel21)
        Me.Controls.Add(Me.tFoodRate)
        Me.Controls.Add(Me.UltraLabel22)
        Me.Controls.Add(Me.tFood)
        Me.Controls.Add(Me.UltraLabel23)
        Me.Controls.Add(Me.tLodgingTot)
        Me.Controls.Add(Me.UltraLabel24)
        Me.Controls.Add(Me.tLodgingRate)
        Me.Controls.Add(Me.UltraLabel25)
        Me.Controls.Add(Me.tLodging)
        Me.Controls.Add(Me.UltraLabel14)
        Me.Controls.Add(Me.tTravelTot)
        Me.Controls.Add(Me.UltraLabel15)
        Me.Controls.Add(Me.tTravelRate)
        Me.Controls.Add(Me.UltraLabel16)
        Me.Controls.Add(Me.tTravel)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.tRackTot)
        Me.Controls.Add(Me.UltraLabel12)
        Me.Controls.Add(Me.tRackRate)
        Me.Controls.Add(Me.UltraLabel13)
        Me.Controls.Add(Me.tRack)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.tMile)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.tItemTot)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.tItemRate)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.tItemized)
        Me.Controls.Add(Me.tTotal)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.tTGWalls)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.tTGCeiling)
        Me.Controls.Add(Me.tHeightOver8)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.tPcs)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.tCircle)
        Me.Controls.Add(Me.pFly)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.tState)
        Me.Controls.Add(Me.lInstaller)
        Me.Controls.Add(Me.tInstaller)
        Me.Controls.Add(Me.UltraLabel27)
        Me.Controls.Add(Me.lGoogleTime)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fmWizardSub"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.tInstaller, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tState, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pFly.ResumeLayout(False)
        Me.pFly.PerformLayout()
        CType(Me.tJobBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAirfair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCircle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPcs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tHeightOver8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTGCeiling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTGWalls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tItemized, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tItemRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tItemTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Web1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tMile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRackTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRackRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTravelTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTravelRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTravel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTruckTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTruckRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTruck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tFoodTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tFoodRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLodgingTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLodgingRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLodging, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tZipFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tZipTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDriveFly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBottles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tStained, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLacquered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRaisedPanels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRacksCut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLightBoxes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTotHrs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tEnkeboll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSaveQuote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSavePrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSavePDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSaveCheckoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddWood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t8footTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t8footRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t8foot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tStainTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tStainRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tStain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLacqTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLacqRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLacq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tWoodTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tWoodRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tWood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tEnkTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tEnkRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tEnk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public Install_Serial As Long
    Public onForm As fmEstOrd2
    Dim dtInst As New DataTable
    Dim cmdInst As New SqlClient.SqlCommand("", cnn)
    Dim daInst As New SqlClient.SqlDataAdapter(cmdInst)
    Dim onInstaller As Boolean = False
    Dim AllowTotal As Boolean = False
    Dim RowAdded As Boolean = False
    Dim onWood As String

    Private Sub fmWizardSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDD2(tInstaller, "installer_file", "installer_serial", "installer_name")
        LoadDD2(ddWood, "mat_file", "mat_code", "mat_code", "mat_code", "mat_iswood=1")
        ddWood.DisplayLayout.Bands(0).Columns("mat_code").Width = 400
        cmdInst.CommandText = "select * from install_file where install_serial=" + CStr(Install_Serial)
        cnn.Open()
        daInst.Fill(dtInst)
        cnn.Close()
        If dtInst.Rows.Count = 0 Then
            Dim dr As DataRow
            dr = dtInst.NewRow
            dr("install_drivefly") = "D"
            dr("install_lodging_rate") = 0
            dr("install_food_rate") = 30
            dr("install_truck_rate") = 100
            dr("install_over8") = False
            dtInst.Rows.Add(dr)
            RowAdded = True
            tUser.Text = ""
            tTime.Text = ""
        Else
            tUser.Text = dtInst.Rows(0).Item("editby")
            tTime.Text = CStr(dtInst.Rows(0).Item("edited"))
        End If

        jBindFields(Me.Controls, dtInst.Rows(0), False)

        LoadItems()
        If RowAdded Then
            LoadInstaller()
            onInstaller = True
            tInstaller_ValueChanged(sender, e)
            onInstaller = False
            tTGCeiling.Text = nz(onForm.DVGen(0).Item("ord_gen_tgceiling"), 0)
            tTGWalls.Text = nz(onForm.DVGen(0).Item("ord_gen_tgwall"), 0)
            tBottles.Text = nz(onForm.DVGen(0).Item("ord_gen_bottles"), 0)
            tCircle.Text = nz(onForm.DVGen(0).Item("ord_gen_circles"), 0)
            tPcs.Text = nz(onForm.DVGen(0).Item("ord_gen_moldings"), 0)

            If nz(onForm.DVGen(0).Item("ord_gen_material"), "") = "" Then
                ddWood.Text = "ALL-HEART REDWOOD"
            Else
                ddWood.Text = onForm.DVGen(0).Item("ord_gen_material")
            End If
            AllowTotal = True
            DoTotal()
            AllowTotal = False
        Else
            DoSubTotals()
        End If


        lQuote.Text = "Quote " + onForm.tOrd.Text + "-" + Mid(onForm.Tab1.ActiveTab.Key, 2)
        If UserGroup = "Admins" Or User = "janeller" Or User = "keithl" Or User = "jackd" Or tUser.Text = "" Or tUser.Text = User Then
            bSave.Enabled = True
            cbSaveCheckoff.Checked = (GetSetting("Jcom", "Settings", "InstallSaveCheckoff", "False") = "True")
        Else
            cbSaveCheckoff.Checked = False
            cbSaveCheckoff.Enabled = False
        End If
        DoTax()

        cbSaveQuote.Checked = (GetSetting("Jcom", "Settings", "InstallSaveQuote", "False") = "True")
        cbSavePrint.Checked = (GetSetting("Jcom", "Settings", "InstallSavePrint", "False") = "True")
        cbSavePDF.Checked = (GetSetting("Jcom", "Settings", "InstallSavePDF", "False") = "True")
    End Sub
    Private Sub LoadItems()
        dvInstItems = New DataView(onForm.dsItems.Tables(0))
        dvInstItems.RowFilter = onForm.DVItems.RowFilter + " and ord_itm_prod_type not in ('IN','STAIN','DES')"
        Grid1.DataSource = dvInstItems
        Dim cl As Infragistics.Win.UltraWinGrid.UltraGridColumn
        For Each cl In Grid1.DisplayLayout.Bands(0).Columns
            cl.Hidden = True
        Next
        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_item_code").Hidden = False
        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_qty").Hidden = False
        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_install_min").Hidden = False
        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_install_use").Hidden = False

        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_item_code").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_qty").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_item_code").Header.Caption = "Item"
        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_qty").Header.Caption = "Qty"
        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_install_min").Header.Caption = "Minutes"
        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_install_use").Header.Caption = "Exclude"

        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_item_code").Width = 50

        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_qty").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
        Grid1.DisplayLayout.Bands(0).Columns("ord_itm_install_min").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

        'Grid1.DisplayLayout.Bands(0).Columns("ord_itm_qty")

        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
        Dim min As Double
        Dim WoodPerc As Integer
        Dim cmd As New SqlCommand("", cnn)
        Dim HasLadder As Boolean = False
        Dim HasSoffit As Boolean = False
        Dim HasStain As Boolean = False
        Dim HasLacq As Boolean = False
        Dim EnkTot As Double = 0

        cnn.Open()
        For Each rw In Grid1.Rows
            cmd.CommandText = "select itm_price_price from itm_price where itm_price_type='Install' and itm_price_itm_code='" + rw.Cells("ord_itm_item_code").Value + "' and itm_price_start<='" + CStr(Today) + "' and itm_price_end>='" + CStr(Today) + "' and itm_price_qty_from<=" + CStr(rw.Cells("ord_itm_qty").Value) + " and itm_price_qty_to>=" + CStr(rw.Cells("ord_itm_qty").Value)
            min = CInt(nz(cmd.ExecuteScalar, -999999))
            'Wood percent markup turned off on items for now.  Material markup on wizard is used instead.
            'cmd.CommandText = "select mat_install_perc_up from mat_file where mat_code='" + rw.Cells("ord_itm_mat_code").Value + "'"
            'WoodPerc = nz(cmd.ExecuteScalar, 50)
            If min >= 0 Then
                rw.Cells("ord_itm_install_min").Value = min   'Math.Round(min + (min * WoodPerc / 100), 2)
                rw.Cells("ord_itm_install_min").Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                rw.Cells("ord_itm_install_min").Appearance.BackColor = Color.WhiteSmoke
            Else
                If min = -1 Then
                    rw.Cells("ord_itm_install_min").Value = 0
                    rw.Cells("ord_itm_install_min").Appearance.BackColor = Color.Red
                    rw.Cells("ord_itm_install_min").Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    rw.Cells("ord_itm_install_use").Value = True
                Else
                    If nz(rw.Cells("ord_itm_install_min").Value, 0) = 0 Then
                        rw.Cells("ord_itm_install_min").Appearance.BackColor = Color.Yellow
                    Else
                        rw.Cells("ord_itm_install_min").Appearance.BackColor = Color.White
                    End If
                    rw.Cells("ord_itm_install_min").Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
                End If
            End If
            If rw.Cells("ord_itm_install_use").Value Is DBNull.Value Then rw.Cells("ord_itm_install_use").Value = False

            If HasLadder = False Then
                cmd.CommandText = "select itm_class from itm_file where itm_code='" + rw.Cells("ord_itm_item_code").Value + "'"
                If nz(cmd.ExecuteScalar) = "LADDER" Then HasLadder = True
            End If
            If HasSoffit = False And RowAdded Then
                If InStr(rw.Cells("ord_itm_desc").Value, "Soffit") > 0 Then HasSoffit = True
            End If
            If HasStain = False And RowAdded Then
                If nz(rw.Cells("ord_itm_stain_serial").Value) > 0 Then HasStain = True
            End If
            If HasLacq = False And RowAdded Then
                If nz(rw.Cells("ord_itm_lacq3").Value, " ") <> " " Then HasLacq = True
            End If
            If Mid(rw.Cells("ord_itm_item_code").Value, 1, 3) = "ES-" Or Mid(rw.Cells("ord_itm_item_code").Value, 1, 2) = "E-" Or Mid(rw.Cells("ord_itm_item_code").Value, 1, 3) = "ENK" Then
                EnkTot += (rw.Cells("ord_itm_qty").Value * rw.Cells("ord_itm_unt_sell").Value) + rw.Cells("ord_itm_disc").Value
            End If
        Next
        cnn.Close()

        If RowAdded Then
            If HasStain Then tStained.Checked = True
            If HasLacq Then tLacquered.Checked = True
            tEnkeboll.Text = FormatCurrency(EnkTot)
        End If
    End Sub
    Private Sub LoadInstaller()
        If tZipTo.Text = "" Then tZipTo.Text = nz(onForm.DVGen(0)("ord_gen_ship_zip"))
        If tState.Text = "" Then tState.Text = nz(onForm.DVGen(0)("ord_gen_ship_state"))

        Dim cmd As New SqlCommand("", cnn)
        Dim dr As DataRow
        Dim daInstall As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim zips, zipx As String
        Dim row As DataRow
        Dim Zip As Integer
        Dim doOutside As Boolean

        cnn.Open()
        cmd.CommandText = "select * from installer_file where installer_terr_state like '%" + tState.Text + "%'"
        daInstall.Fill(ds, "rep")
        If ds.Tables("rep").Rows.Count > 0 Then
            For Each dr In ds.Tables("rep").Rows
                If nz(dr("installer_terr_zip")) <> "" Then
                    If tZipTo.Text = "" Then Exit For
                    For Each zips In Split(dr("installer_terr_zip"), ",")
                        For Zip = CInt(Split(zips, "-")(0)) To CInt(Split(zips, "-")(Split(zips, "-").Length - 1))
                            zipx = Format(Zip, "000")
                            If Mid(tZipTo.Text, 1, Len(Trim(zipx))) = Mid(Trim(zipx), 1, Len(Trim(zipx))) Then
                                tInstaller.Value = dr("installer_serial")
                                tZipFrom.Text = dr("installer_zip")
                                cnn.Close()
                                Exit Sub
                            End If
                        Next
                    Next
                Else
                    tInstaller.Value = dr("installer_serial")
                    tZipFrom.Text = dr("installer_zip")
                    cnn.Close()
                    Exit Sub
                End If
            Next
        End If
        cnn.Close()
        tInstaller.Value = 3
        tZipFrom.Text = "45226"
    End Sub
    Private Sub bCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Cancel?") = MsgBoxResult.Yes Then Me.Close()
    End Sub

    Private Sub bSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click
        Dim SaveQuote As Boolean = cbSaveQuote.Checked
        Dim SavePrint As Boolean = cbSavePrint.Checked
        Dim savePDF As Boolean = cbSavePDF.Checked
        Dim SaveCheckoff As Boolean = cbSaveCheckoff.Checked

        SaveSetting("Jcom", "Settings", "InstallSaveQuote", CStr(SaveQuote))
        SaveSetting("Jcom", "Settings", "InstallSavePrint", CStr(SavePrint))
        SaveSetting("Jcom", "Settings", "InstallSavePdf", CStr(savePDF))
        SaveSetting("Jcom", "Settings", "InstallSaveCheckoff", CStr(SaveCheckoff))

        bSave.Enabled = False
        Save()
        Me.Close()

        If SaveCheckoff Then
            onForm.DVGen(0).Item("ord_gen_co_factoryinstall") = True
            onForm.DVGen(0).Item("ord_gen_co_factoryinstall_user") = User
            onForm.DVGen(0).Item("ord_gen_co_factoryinstall_date") = Now
        End If
        If SaveQuote Then onForm.Save()
        If SavePrint Then DisplayReport("install", "{install_file.install_serial} = " + CStr(Install_Serial), True)

        '' Copy the form's image into a bitmap.
        'm_PrintBitmap = GetFormImage()

        '' Make a PrintDocument and print.
        'm_PrintDocument = New System.Drawing.Printing.PrintDocument
        'm_PrintDocument.Print()

    End Sub
    Private Sub Save()
        Try
            Dim cb As New SqlCommandBuilder(daInst)

            jSaveFields(Me.Controls, dtInst.Rows(0))

            cnn.Open()
            dtInst.Rows(0)("editby") = User
            dtInst.Rows(0).Item("edited") = CStr(Now)
            daInst.Update(dtInst)

            If RowAdded Then
                Dim cmd As New SqlCommand("select @@identity", cnn)
                Install_Serial = cmd.ExecuteScalar
                onForm.Grid1.ActiveRow.Cells("ord_itm_wizard_serial").Value = Install_Serial
                cnn.Close()
            Else
                cnn.Close()
            End If
            onForm.Grid1.ActiveRow.Cells("ord_itm_unt_sell").Value = CDbl(Replace(tTotal.Text, "$", ""))
            onForm.UltraCalcManager1.DirtyAllFormulas()
            onForm.DoTotal()
        Catch
            DoError(Err, Me)
        End Try
    End Sub
    Private Sub DoTotal()
        If AllowTotal = False Then Exit Sub
        AllowTotal = False
        Try
            Dim tot As Double = 0
            Dim Mins As Double = 0
            Dim tmp As Double = 0
            Dim dr As Infragistics.Win.UltraWinGrid.UltraGridRow

            tot = Math.Round((num(tCircle.Text) * num(tPcs.Text) * 0.166666666) + 0.499, 0)
            tot += num(tTGCeiling.Text) * 2
            tot += num(tTGWalls.Text)
            If num(tRaisedPanels.Text) > 0 Then tot += num(tRaisedPanels.Text) + 4
            'If tSoffit.Checked Then tot += num(tRaisedPanels.Text)
            tot += num(tRacksCut.Text) * 2
            'If tHeightOver8.Checked Then tot += Math.Round((num(tBottles.Text) / 1000) + 0.499, 0)
            'If tStained.Checked Then tot += Math.Round((num(tBottles.Text) * 1.5 / 1000) + 0.499, 0)
            'If tLacquered.Checked Then tot += Math.Round((num(tBottles.Text) * 1.5 / 1000) + 0.499, 0)
            For Each dr In Grid1.Rows
                If dr.Cells("ord_itm_install_use").Value = False Then
                    Mins += nz(dr.Cells("ord_itm_qty").Value, 0) * nz(dr.Cells("ord_itm_install_min").Value, 0)
                End If
            Next
            tItemized.Text = Math.Round(tot + (Mins / 60) + 0.4999, 0)

            If num(tLodging.Text) = 0 Then
                tLodging.Text = Math.Round((num(tTotHrs.Text) / 9) + 0.49999, 0)
                tFood.Text = tLodging.Text
                If tDriveFly.Value = "F" Then tTruck.Text = tLodging.Text
            End If

            If num(t8footTot.Text) = 0 And tHeightOver8.Checked Then
                t8foot.Text = Math.Round(((num(tItemized.Text) + num(tRack.Text)) * 0.1) + 0.499, 0)
            End If

            If tStained.Checked And num(tStain.Text) = 0 Then
                tStain.Text = Math.Round((num(tBottles.Text) / 1000 * 1.5) + 0.499, 0)
            End If

            If tLacquered.Checked And num(tLacq.Text) = 0 Then
                tLacq.Text = Math.Round((num(tBottles.Text) / 1000 * 1.5) + 0.499, 0)
            End If

            DoWoodTot()
            DoSubTotals()

            tot = num(tItemTot.Text) + num(tRackTot.Text) + num(tTravelTot.Text) + num(tLodgingTot.Text) + num(tFoodTot.Text) + num(tTruckTot.Text)
            tot += num(t8footTot.Text) + num(tStainTot.Text) + num(tLacqTot.Text) + num(tWoodTot.Text) + num(tEnkTot.Text)
            tot += num(tAirfair.Text) + num(tJobBox.Text)

            'If tHeightOver8.Checked Then tot = Math.Round(tot * 1.1, 2)
            'tot = tot + num(tEnkeboll.Text) * 0.2


            tTotal.Text = FormatCurrency(tot)

            DoTax()
        Catch
            DoError(Err, Me)
        Finally
            AllowTotal = True
        End Try
    End Sub
    Private Sub DoTax()
        Dim tot As Double = num(tTotal.Text)

        If onForm.gsTaxInstalls.Checked Then
            lTax.Text = FormatCurrency(Math.Round(tot * onForm.DVGen(0)("ord_gen_cust_taxrate"), 2))
            lTotal.Text = FormatCurrency(Math.Round(tot + (tot * onForm.DVGen(0)("ord_gen_cust_taxrate")), 2))
        Else
            lTax.Text = "$0.00"
            lTotal.Text = Math.Round(tot, 2)
        End If
    End Sub
    Private Sub DoSubTotals()
        tItemTot.Text = Math.Round(num(tItemized.Text) * num(tItemRate.Text), 2)
        tRackTot.Text = Math.Round(num(tRack.Text) * num(tRackRate.Text), 2)
        tTravelTot.Text = Math.Round(num(tTravel.Text) * num(tTravelRate.Text), 2)
        tLodgingTot.Text = Math.Round(num(tLodging.Text) * num(tLodgingRate.Text), 2)
        tFoodTot.Text = Math.Round(num(tFood.Text) * num(tFoodRate.Text), 2)
        tTruckTot.Text = Math.Round(num(tTruck.Text) * num(tTruckRate.Text), 2)
        t8footTot.Text = Math.Round(num(t8foot.Text) * num(t8footRate.Text), 2)
        tStainTot.Text = Math.Round(num(tStain.Text) * num(tStainRate.Text), 2)
        tLacqTot.Text = Math.Round(num(tLacq.Text) * num(tLacqRate.Text), 2)
        tWoodTot.Text = Math.Round(num(tWood.Text) * num(tWoodRate.Text), 2)
        tEnkTot.Text = Math.Round(num(tEnk.Text) * num(tEnkRate.Text), 2)
    End Sub

    


    Private Sub GetDistance(ByVal dFrom As String, ByVal dTo As String)
        Try
            lMiles.Visible = True
            Application.DoEvents()
            'Web1.Top = 0
            'Web1.Left = 0
            'Web1.Height = Me.Height
            'Web1.Width = Me.Width
            'Web1.Visible = True
            'Dim strUrl As String = "http://www.mapquest.com/maps?1z=" + dFrom + "&2z=" + dTo
            Dim strUrl As String = "http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + dFrom + "&destinations=" + dTo + "&sensor=false&units=imperial"
            Dim strFullPageHtml As String = ""
            Dim doc As mshtml.HTMLDocument
            Dim elems As Xml.XmlNodeList
            Dim elem As Xml.XmlNode
            Dim x As Integer
            Dim hrs As Double = 0
            Dim xml As New Xml.XmlDocument
            Dim doc2 As HtmlDocument

            WebBrowser1.Navigate(strUrl)
            While WebBrowser1.ReadyState <> WebBrowserReadyState.Complete
                Application.DoEvents()
            End While
            'Web1.Navigate(strUrl)
            ''Do While WebBrowser1. 'Web1.Busy
            ''    Application.DoEvents()
            ''Loop
            Dim dd = WebBrowser1.DocumentType
            doc2 = WebBrowser1.Document
            'doc = Web1.Document
            'xml.LoadXml(Trim(Replace(doc.documentElement.innerText, "-", "")))
            xml.LoadXml(Trim(Replace(doc2.Body.InnerText, "-", "")))

            'lGoogleTime.Text = Replace(doc.getElementById("dirTimeSumm").innerText, "Total Estimated ", "")

            'elem = doc.getElementById("dirTimeSummary")
            elems = xml.GetElementsByTagName("duration")
            If Not elems Is Nothing Then
                If Split(elems(0).LastChild.InnerText, " ").Length = 2 Then
                    If InStr(Split(elems(0).LastChild.InnerText, " ")(1), "min") > 0 Then hrs = num(Split(elems(0).LastChild.InnerText, " ")(0)) / 60
                End If
                If Split(elems(0).LastChild.InnerText, " ").Length = 4 Then
                    If InStr(Split(elems(0).LastChild.InnerText, " ")(1), "hour") > 0 Then hrs = num(Split(elems(0).LastChild.InnerText, " ")(0))
                    If InStr(Split(elems(0).LastChild.InnerText, " ")(3), "min") > 0 Then hrs += num(Split(elems(0).LastChild.InnerText, " ")(2)) / 60
                End If
                tTravel.Text = Math.Round((hrs * 2) + 0.49999, 0)
            End If

            'elem = doc.getElementById("dirDistanceSummary")
            elems = xml.GetElementsByTagName("distance")
            If Not elems Is Nothing Then
                tMile.Text = num(Split(elems(0).LastChild.InnerText, " ")(0))
            End If

            'elems = doc.getElementsByTagName("td")
            'For Each elem In elems
            '    If elem.className = "timedist ul" Then Exit For
            'Next
            'MsgBox(elem.className + " | " + elem.innerText)
            'If IsNumeric(Split(elem.innerText, " ")(0)) Then
            '    tMile.Text = CDbl(Split(elem.innerText, " ")(0))
            'Else
            '    tMile.Text = 0
            'End If
            'For x = 0 To Split(elem.innerText, " ").Length - 1
            '    If InStr(Split(elem.innerText, " ")(x), "hour") > 0 Then Exit For
            'Next
            'If IsNumeric(Split(elem.innerText, " ")(x - 1)) Then
            '    tTravel.Text = (num(Split(elem.innerText, " ")(x - 1)) + 1) * 2
            'Else
            '    tTravel.Text = "1"
            'End If
            'If Split(elem.innerText, " – ").Length > 1 Then
            '    lGoogleTime.Text = Split(elem.innerText, " – ")(1)
            'Else
            '    lGoogleTime.Text = elem.innerText
            'End If
        Catch
            MsgBox(Err.Description)
        Finally
            'Web1.Visible = False
            lMiles.Visible = False
        End Try
    End Sub
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim x
    End Sub
    Private Sub wb_DocumentCompleted(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        Dim wb As WebBrowser = TryCast(sender, WebBrowser)
        ' wb.Document is not null at this point
    End Sub

    Private Sub tCircle_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCircle.ValueChanged
        DoTotal()
        If tCircle.Text = "" Then
            tCircle.BackColor = Color.Yellow
        Else
            tCircle.BackColor = Color.White
        End If
    End Sub

    Private Sub tPcs_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPcs.ValueChanged
        DoTotal()
        If tPcs.Text = "" Then
            tPcs.BackColor = Color.Yellow
        Else
            tPcs.BackColor = Color.White
        End If
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        UltraButton1.Enabled = False
        GetDistance(tZipFrom.Text, tZipTo.Text)
        UltraButton1.Enabled = True
    End Sub

    Private Sub tItemized_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tItemized.ValueChanged
        DoTotal()
        DoSubTotal()
    End Sub
    Private Sub DoSubTotal()
        tTotHrs.Text = num(tItemized.Text) + num(tRack.Text) + num(tTravel.Text) + num(t8foot.Text) + num(tStain.Text) + num(tLacq.Text) + num(tWood.Text) + num(tEnk.Text)
        tDays.Text = Math.Round(num(tTotHrs.Text) / 9, 2)
    End Sub

    Private Sub tRack_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tRack.ValueChanged
        DoTotal()
        If num(tRack.Text) = 0 Then
            tRack.BackColor = Color.Yellow
        Else
            tRack.BackColor = Color.White
        End If
        DoSubTotal()
    End Sub

    Private Sub tTravel_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTravel.ValueChanged
        DoTotal()
        DoSubTotal()
    End Sub

    Private Sub tLodging_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tLodging.ValueChanged
        DoTotal()
        If num(tLodging.Text) > 0 And num(tLodgingRate.Text) = 0 Then
            tLodgingRate.BackColor = Color.Yellow
        Else
            tLodgingRate.BackColor = Color.White
        End If
    End Sub

    Private Sub tFood_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFood.ValueChanged
        DoTotal()
    End Sub

    Private Sub tTruck_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTruck.ValueChanged
        DoTotal()
    End Sub

    Private Sub tInstaller_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tInstaller.ValueChanged
        If onInstaller = False Then Exit Sub
        Dim cmd As New SqlCommand("select * from installer_file where installer_serial=" + CStr(nz(tInstaller.Value, -1)), cnn)
        Dim rw As DataRow
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)

        cnn.Open()
        da.Fill(dt)
        cnn.Close()
        For Each rw In dt.Rows
            tZipFrom.Text = nz(rw("installer_zip"))
            tItemRate.Text = FormatCurrency(nz(rw("installer_hr_rate"), 0))
            tRackRate.Text = FormatCurrency(nz(rw("installer_hr_rate"), 0))
            tTravelRate.Text = FormatCurrency(nz(rw("installer_hr_rate"), 0))
            t8footRate.Text = FormatCurrency(nz(rw("installer_hr_rate"), 0))
            tStainRate.Text = FormatCurrency(nz(rw("installer_hr_rate"), 0))
            tLacqRate.Text = FormatCurrency(nz(rw("installer_hr_rate"), 0))
            tWoodRate.Text = FormatCurrency(nz(rw("installer_hr_rate"), 0))
            tEnkRate.Text = FormatCurrency(nz(rw("installer_hr_rate"), 0))
        Next
        DoTotal()
    End Sub

    Private Sub tInstaller_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tInstaller.Enter
        onInstaller = True
    End Sub

    Private Sub tInstaller_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tInstaller.Leave
        onInstaller = False
    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub Grid1_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid1.AfterCellUpdate
        If e.Cell.Column.Header.Caption = "Minutes" Then
            If e.Cell.Value = 0 And nz(e.Cell.Row.Cells("ord_itm_install_use").Value, False) = True Then
                e.Cell.Appearance.BackColor = Color.Yellow
            Else
                e.Cell.Appearance.BackColor = Color.White
            End If
        End If
        DoTotal()
    End Sub

    Private Sub tDriveFly_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tDriveFly.ValueChanged
        If tDriveFly.Value = "F" Then
            tJobBox.Text = "$1000.00"
            tAirfair.Text = "$800.00"
            tTruck.Text = Math.Round((num(tTravel.Text) / 9) + 0.49999, 0)
            tTruckRate.Text = "$100.00"
        Else
            tJobBox.Text = "$0.00"
            tAirfair.Text = "$0.00"
            tTruck.Text = "0"
            tTruckRate.Text = "$0.00"
        End If
        DoTotal()
    End Sub

    Private Sub fmWizardSub_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        AllowTotal = True
    End Sub

    Private Sub tTGCeiling_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTGCeiling.ValueChanged
        DoTotal()
        If tTGCeiling.Text = "" Then
            tTGCeiling.BackColor = Color.Yellow
        Else
            tTGCeiling.BackColor = Color.White
        End If
    End Sub

    Private Sub tTGWalls_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTGWalls.ValueChanged
        DoTotal()
        If tTGWalls.Text = "" Then
            tTGWalls.BackColor = Color.Yellow
        Else
            tTGWalls.BackColor = Color.White
        End If
    End Sub

    Private Sub tBottles_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tBottles.ValueChanged
        DoTotal()
        If num(tBottles.Text) = 0 Then
            tBottles.BackColor = Color.Yellow
        Else
            tBottles.BackColor = Color.White
        End If
    End Sub

    Private Sub tHeightOver8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tHeightOver8.CheckedChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Me.ActiveControl.Name = "tHeightOver8" Then
            If tHeightOver8.Checked Then
                t8foot.Text = Math.Round(((num(tItemized.Text) + num(tRack.Text)) * 0.1) + 0.499, 0)
            Else
                t8foot.Text = "0"
            End If
        End If
        DoTotal()
    End Sub

    Private Sub tStained_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tStained.CheckedChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Me.ActiveControl.Name = "tStained" Then
            If tStained.Checked Then
                tStain.Text = Math.Round((num(tBottles.Text) / 1000 * 1.5) + 0.499, 0)
            Else
                tStain.Text = "0"
            End If
        End If
        DoTotal()
    End Sub

    Private Sub tLacquered_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tLacquered.CheckedChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Me.ActiveControl.Name = "tLacquered" Then
            If tLacquered.Checked Then
                tLacq.Text = Math.Round((num(tBottles.Text) / 1000 * 1.5) + 0.499, 0)
            Else
                tLacq.Text = "0"
            End If
        End If
        DoTotal()
    End Sub

    Private Sub tMile_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tMile.ValueChanged
        DoTotal()
        If num(tMile.Text) = 0 Then
            tMile.BackColor = Color.Yellow
        Else
            tMile.BackColor = Color.White
        End If

    End Sub

    Private Sub tLodgingRate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tLodgingRate.ValueChanged
        DoTotal()
        If num(tLodging.Text) > 0 And num(tLodgingRate.Text) = 0 Then
            tLodgingRate.BackColor = Color.Yellow
        Else
            tLodgingRate.BackColor = Color.White
        End If
    End Sub

    Private Declare Auto Function BitBlt Lib "gdi32.dll" (ByVal _
    hdcDest As IntPtr, ByVal nXDest As Integer, ByVal _
    nYDest As Integer, ByVal nWidth As Integer, ByVal _
    nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc _
    As Integer, ByVal nYSrc As Integer, ByVal dwRop As _
    System.Int32) As Boolean
    Private Const SRCCOPY As Integer = &HCC0020

    ' Variables used to print.
    Private m_PrintBitmap As Bitmap
    Private WithEvents m_PrintDocument As System.Drawing.Printing.PrintDocument

    Private Function GetFormImage() As Bitmap
        ' Get this form's Graphics object.
        Dim me_gr As Graphics = Me.CreateGraphics

        ' Make a Bitmap to hold the image.
        Dim bm As New Bitmap(Me.ClientSize.Width, _
            Me.ClientSize.Height, me_gr)
        Dim bm_gr As Graphics = me_gr.FromImage(bm)
        Dim bm_hdc As IntPtr = bm_gr.GetHdc

        ' Get the form's hDC. We must do this after 
        ' creating the new Bitmap, which uses me_gr.
        Dim me_hdc As IntPtr = me_gr.GetHdc

        ' BitBlt the form's image onto the Bitmap.
        BitBlt(bm_hdc, 0, 0, Me.ClientSize.Width, _
            Me.ClientSize.Height, _
            me_hdc, 0, 0, SRCCOPY)
        me_gr.ReleaseHdc(me_hdc)
        bm_gr.ReleaseHdc(bm_hdc)

        ' Return the result.
        Return bm
    End Function

    ' Print the form image.
    Private Sub m_PrintDocument_PrintPage(ByVal sender As _
        Object, ByVal e As _
        System.Drawing.Printing.PrintPageEventArgs) Handles _
        m_PrintDocument.PrintPage
        ' Draw the image centered.
        Dim x As Integer = e.MarginBounds.X + _
            (e.MarginBounds.Width - m_PrintBitmap.Width) \ 2
        Dim y As Integer = e.MarginBounds.Y + _
            (e.MarginBounds.Height - m_PrintBitmap.Height) \ 2
        e.Graphics.DrawImage(m_PrintBitmap, x, y)

        ' There's only one page.
        e.HasMorePages = False
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        If Install_Serial <> 0 Then
            Dim cmd As New SqlCommand("delete from install_file where install_serial=" + CStr(Install_Serial), cnn)
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
        End If
        RowAdded = False
        Install_Serial = 0
        dtInst.Clear()
        fmWizardSub_Load(sender, e)
    End Sub

    Private Sub tSoffit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DoTotal()
    End Sub

    Private Sub tRaisedPanels_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tRaisedPanels.ValueChanged
        DoTotal()
        If tRaisedPanels.Text = "" Then
            tRaisedPanels.BackColor = Color.Yellow
        Else
            tRaisedPanels.BackColor = Color.White
        End If

    End Sub

    Private Sub tRacksCut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tRacksCut.ValueChanged
        DoTotal()
        If tRacksCut.Text = "" Then
            tRacksCut.BackColor = Color.Yellow
        Else
            tRacksCut.BackColor = Color.White
        End If

    End Sub

    Private Sub tLightBoxes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tLightBoxes.ValueChanged
        DoTotal()
        If tLightBoxes.Text = "" Then
            tLightBoxes.BackColor = Color.Yellow
        Else
            tLightBoxes.BackColor = Color.White
        End If
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        Process.Start("IExplore.exe", "http://www.hotels.com/processIndexAddressSearch.do?_dyncharset=UTF-8&allPropertyTypesSelected=true&searchType=address&destination=usertyped&usertypedcity=&street1=&street2=" + tZipTo.Text + "&acDestinationId=&acDestinationType=&lat=0.0&lon=0.0&pointName=&checkIn=&checkOut=&numrooms=1&adults%5B0%5D=2&child%5B0%5D=0&CIMonth=-1&CIDay=-1&CIYear=" + CStr(Year(Today)) + "&COMonth=-1&CODay=-1&COYear=" + CStr(Year(Today)) + "&refined=true")
    End Sub

    Private Sub tTotHrs_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTotHrs.ValueChanged
        Dim x As Double = -num(tItemized.Text) - num(tTravel.Text) - num(t8foot.Text) - num(tStain.Text) - num(tLacq.Text) - num(tEnk.Text)
        Dim WoodPerc As Double
        Dim cmd As New SqlCommand("", cnn)
        cmd.CommandText = "select mat_install_perc_up from mat_file where mat_code='" + ddWood.Text + "'"
        cnn.Open()
        WoodPerc = nz(cmd.ExecuteScalar, 0)
        cnn.Close()

        tRack.Text = ((100 * num(tTotHrs.Text)) + (100 * x) - (WoodPerc * num(tItemized.Text))) / (100 + WoodPerc)
    End Sub

    Private Sub tEnkeboll_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tEnkeboll.ValueChanged
        UpdateEnk()
    End Sub
    Private Sub UpdateEnk()
        If num(tEnkRate.Text) = 0 Then
            tEnk.Text = "0"
        Else
            tEnk.Text = Math.Round(((num(tEnkeboll.Text) / num(tEnkRate.Text)) * 0.2) + 0.499, 0)
        End If
        DoTotal()
        If tEnkeboll.Text = "" Then
            tEnkeboll.BackColor = Color.Yellow
        Else
            tEnkeboll.BackColor = Color.White
        End If
    End Sub
    Private Sub tDays_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tDays.ValueChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Me.ActiveControl.Parent Is tDays Then
            AllowTotal = False
            tLodging.Text = "0"
            AllowTotal = True
            tTotHrs.Text = num(tDays.Text) * 9
        End If
    End Sub

    Private Sub cbSavePrint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSavePrint.CheckedChanged
        If cbSavePrint.Checked Then cbSaveQuote.Checked = True
    End Sub

    Private Sub cbSavePDF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSavePDF.CheckedChanged
        If cbSavePDF.Checked Then cbSaveQuote.Checked = True
    End Sub

    Private Sub cbSaveQuote_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSaveQuote.CheckedChanged
        If cbSaveQuote.Checked = False Then
            cbSavePDF.Checked = False
            cbSavePrint.Checked = False
        End If
    End Sub

    Private Sub tWood_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddWood.Leave
        If onWood <> ddWood.Text Then
            DoTotal()
        End If
    End Sub
    Private Sub DoWoodTot()
        Dim WoodPerc As Double
        Dim cmd As New SqlCommand("", cnn)
        cmd.CommandText = "select mat_install_perc_up from mat_file where mat_code='" + ddWood.Text + "'"
        cnn.Open()
        WoodPerc = nz(cmd.ExecuteScalar, 0)
        cnn.Close()
        'tWood.Text = Math.Round(((num(tItemized.Text) + num(tRack.Text)) * WoodPerc / 100) + 0.499, 0)
        tWood.Text = ((num(tItemized.Text) + num(tRack.Text)) * WoodPerc / 100)
    End Sub
    Private Sub tWood_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ddWood.InitializeLayout

    End Sub

    Private Sub tWood_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddWood.Enter
        onWood = tWood.Text
    End Sub

    Private Sub t8foot_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t8foot.ValueChanged
        DoTotal()
        DoSubTotal()
    End Sub

    Private Sub tStain_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tStain.ValueChanged
        DoTotal()
        DoSubTotal()
    End Sub

    Private Sub tLacq_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tLacq.ValueChanged
        DoTotal()
        DoSubTotal()
    End Sub

    Private Sub tWood_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tWood.ValueChanged
        DoTotal()
        DoSubTotal()
    End Sub

    Private Sub tEnk_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tEnk.ValueChanged
        DoTotal()
        DoSubTotal()
    End Sub

    Private Sub tEnkRate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tEnkRate.ValueChanged
        UpdateEnk()
    End Sub

    Private Sub tAirfair_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tAirfair.ValueChanged

    End Sub

    
End Class
