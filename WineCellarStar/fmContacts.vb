Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net.Mime
Imports Microsoft.Office.Interop

Public Class fmContacts
    Inherits WineCellar.fmStarter
    Public onZip As String = ""
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tContPhoneExt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tContPhone2Ext As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbCatMatEmail As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents bAddQuote As Infragistics.Win.Misc.UltraButton
    Friend WithEvents gSource As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents bAddSrc As System.Windows.Forms.Button
    Dim ShowAllSourceCodes As Boolean = False
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lCatMatLast As System.Windows.Forms.Label
    Friend WithEvents lCatComLast As System.Windows.Forms.Label
    Friend WithEvents lCatResLast As System.Windows.Forms.Label
    Friend WithEvents cbCatMatInQue As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbCatComInQue As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbCatResInQue As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbCatMatRemove As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbCatComRemove As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbCatResRemove As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbCatMatMail As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbCatComMail As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbCatResMail As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Dim dtSrcCodes As New DataTable
    Dim dtOldContact As DataTable
    Friend WithEvents cbNotes As System.Windows.Forms.CheckBox
    Dim dtOldSrcCodes As DataTable
    Friend WithEvents bReEmail As System.Windows.Forms.LinkLabel
    Friend WithEvents tContCountry As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tContCounty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lContCounty As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tContProvince As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lContProvince As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Grid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Public AddedFromContact As Boolean = False
    Friend WithEvents tContPhone As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tContPhone2 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tContCell As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents tContFax As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents bDocPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bOpenPdf As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ListPDF As System.Windows.Forms.ListBox
    Dim nonNumberEntered As Boolean
    Dim NameChanged As Boolean = False
    Friend WithEvents cOSRnote As System.Windows.Forms.CheckBox
    Dim onName As String

    Dim dtc As New DataTable
    Dim cmdc As New SqlCommand("", cnn)
    Dim dac As New SqlDataAdapter(cmdc)
    Friend WithEvents tLastCallBy As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tLastCall As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tFieldConsult As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbRemoveReport As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbAddToReport As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Dim cbc As New SqlCommandBuilder(dac)

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
    Friend WithEvents tContAddr1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel85 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tContName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tContAddr3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lContAddr3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tContCity As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tContState As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lContState As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lContCity As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel57 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tContAddr2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tContZip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel54 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lContAddr1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lContAddr2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lContZip As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tSerial As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lSerial As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tContType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tStatus As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tContEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbInactive As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents tContWebsite As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tContComp As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbCatComEmail As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbCatResEmail As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tInactiveReason As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tNextCall As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tNextCallBy As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTextEditor6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Tab1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gNotes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tAddNote As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_note_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_note_user")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_note_date")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_note_type")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_note")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_note_cont_serial")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cont_src_serial")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_src")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_src_desc")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Delete", 0)
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(273)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(30)
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
        Dim DateButton2 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.cbNotes = New System.Windows.Forms.CheckBox
        Me.gNotes = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Grid2 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.bDocPrint = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.bOpenPdf = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.ListPDF = New System.Windows.Forms.ListBox
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label10 = New System.Windows.Forms.Label
        Me.tContAddr1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel85 = New Infragistics.Win.Misc.UltraLabel
        Me.tContName = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tContAddr3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lContAddr3 = New Infragistics.Win.Misc.UltraLabel
        Me.tContCity = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel
        Me.tContState = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lContState = New Infragistics.Win.Misc.UltraLabel
        Me.lContCity = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel57 = New Infragistics.Win.Misc.UltraLabel
        Me.tContAddr2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tContZip = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel54 = New Infragistics.Win.Misc.UltraLabel
        Me.lContAddr1 = New Infragistics.Win.Misc.UltraLabel
        Me.lContAddr2 = New Infragistics.Win.Misc.UltraLabel
        Me.lContZip = New Infragistics.Win.Misc.UltraLabel
        Me.tSerial = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lSerial = New Infragistics.Win.Misc.UltraLabel
        Me.tContType = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tStatus = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.tContEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.cbInactive = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.tContWebsite = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.tContComp = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lCatMatLast = New System.Windows.Forms.Label
        Me.lCatComLast = New System.Windows.Forms.Label
        Me.lCatResLast = New System.Windows.Forms.Label
        Me.cbCatMatInQue = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbCatComInQue = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbCatResInQue = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbCatMatRemove = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbCatComRemove = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbCatResRemove = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbCatMatMail = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbCatComMail = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbCatResMail = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbCatMatEmail = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbCatComEmail = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbCatResEmail = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.tInactiveReason = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.tNextCall = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.tNextCallBy = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraTextEditor6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.Tab1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.tAddNote = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.tContPhoneExt = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tContPhone2Ext = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel
        Me.bAddQuote = New Infragistics.Win.Misc.UltraButton
        Me.gSource = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.bAddSrc = New System.Windows.Forms.Button
        Me.bReEmail = New System.Windows.Forms.LinkLabel
        Me.tContCountry = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.tContCounty = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lContCounty = New Infragistics.Win.Misc.UltraLabel
        Me.tContProvince = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lContProvince = New Infragistics.Win.Misc.UltraLabel
        Me.tContPhone = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.tContPhone2 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.tContCell = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.tContFax = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.cOSRnote = New System.Windows.Forms.CheckBox
        Me.tLastCallBy = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel
        Me.tLastCall = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel
        Me.tFieldConsult = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel
        Me.cbRemoveReport = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel
        Me.cbAddToReport = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.gNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContAddr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContAddr3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContAddr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContZip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tSerial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbInactive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContWebsite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContComp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.cbCatMatInQue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatComInQue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatResInQue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatMatRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatComRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatResRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatMatMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatComMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatResMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatMatEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatComEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatResEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tInactiveReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNextCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNextCallBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab1.SuspendLayout()
        CType(Me.tAddNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContPhoneExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContPhone2Ext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContCounty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tContProvince, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLastCallBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLastCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tFieldConsult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRemoveReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAddToReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.cbNotes)
        Me.UltraTabPageControl1.Controls.Add(Me.gNotes)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1444, 469)
        '
        'cbNotes
        '
        Me.cbNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbNotes.AutoSize = True
        Me.cbNotes.Checked = True
        Me.cbNotes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNotes.Location = New System.Drawing.Point(1308, 1)
        Me.cbNotes.Name = "cbNotes"
        Me.cbNotes.Size = New System.Drawing.Size(135, 21)
        Me.cbNotes.TabIndex = 239
        Me.cbNotes.Text = "Show Notes Only"
        Me.cbNotes.UseVisualStyleBackColor = True
        '
        'gNotes
        '
        Me.gNotes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 248
        UltraGridColumn2.Header.Caption = "User"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MaxWidth = 100
        UltraGridColumn2.Width = 80
        UltraGridColumn3.Format = "MM/dd/yyyy hh:mm tt"
        UltraGridColumn3.Header.Caption = "Date"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaxWidth = 150
        UltraGridColumn3.Width = 150
        UltraGridColumn4.Header.Caption = "Type"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.MaxWidth = 100
        UltraGridColumn4.Width = 100
        UltraGridColumn5.CellMultiLine = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn5.Header.Caption = "Note"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 1093
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 132
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.gNotes.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gNotes.DisplayLayout.MaxRowScrollRegions = 1
        Me.gNotes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.gNotes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.gNotes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gNotes.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFixed
        Me.gNotes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gNotes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gNotes.Location = New System.Drawing.Point(0, 0)
        Me.gNotes.Margin = New System.Windows.Forms.Padding(0)
        Me.gNotes.Name = "gNotes"
        Me.gNotes.Size = New System.Drawing.Size(1444, 469)
        Me.gNotes.TabIndex = 2
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Grid2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1444, 469)
        '
        'Grid2
        '
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.Grid2.DisplayLayout.Appearance = Appearance25
        Me.Grid2.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        Me.Grid2.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.Grid2.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        Me.Grid2.DisplayLayout.GroupByBox.Appearance = Appearance26
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grid2.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance27
        Me.Grid2.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.Grid2.DisplayLayout.GroupByBox.Hidden = True
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance28.BackColor2 = System.Drawing.SystemColors.Control
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grid2.DisplayLayout.GroupByBox.PromptAppearance = Appearance28
        Me.Grid2.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid2.DisplayLayout.MaxRowScrollRegions = 1
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid2.DisplayLayout.Override.ActiveCellAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.SystemColors.Highlight
        Appearance30.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Grid2.DisplayLayout.Override.ActiveRowAppearance = Appearance30
        Me.Grid2.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.Grid2.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid2.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.Grid2.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Me.Grid2.DisplayLayout.Override.CardAreaAppearance = Appearance31
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.Grid2.DisplayLayout.Override.CellAppearance = Appearance32
        Me.Grid2.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.Grid2.DisplayLayout.Override.CellPadding = 0
        Appearance33.BackColor = System.Drawing.SystemColors.Control
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.Grid2.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Left"
        Me.Grid2.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.Grid2.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid2.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Me.Grid2.DisplayLayout.Override.RowAppearance = Appearance35
        Me.Grid2.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid2.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Grid2.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
        Me.Grid2.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid2.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid2.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.Grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid2.Location = New System.Drawing.Point(0, 0)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(1444, 469)
        Me.Grid2.TabIndex = 0
        Me.Grid2.Text = "UltraGrid1"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.bDocPrint)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraButton5)
        Me.UltraTabPageControl3.Controls.Add(Me.bOpenPdf)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraButton2)
        Me.UltraTabPageControl3.Controls.Add(Me.ListPDF)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1444, 469)
        '
        'bDocPrint
        '
        Me.bDocPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bDocPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDocPrint.Location = New System.Drawing.Point(566, 308)
        Me.bDocPrint.Name = "bDocPrint"
        Me.bDocPrint.Size = New System.Drawing.Size(180, 38)
        Me.bDocPrint.TabIndex = 12
        Me.bDocPrint.Text = "Print"
        '
        'UltraButton5
        '
        Me.UltraButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton5.Location = New System.Drawing.Point(368, 308)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(180, 38)
        Me.UltraButton5.TabIndex = 11
        Me.UltraButton5.Text = "Show Directory"
        '
        'bOpenPdf
        '
        Me.bOpenPdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bOpenPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bOpenPdf.Location = New System.Drawing.Point(186, 308)
        Me.bOpenPdf.Name = "bOpenPdf"
        Me.bOpenPdf.Size = New System.Drawing.Size(180, 38)
        Me.bOpenPdf.TabIndex = 10
        Me.bOpenPdf.Text = "Open"
        '
        'UltraButton2
        '
        Me.UltraButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton2.Location = New System.Drawing.Point(4, 308)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(180, 38)
        Me.UltraButton2.TabIndex = 9
        Me.UltraButton2.Text = "eMail"
        '
        'ListPDF
        '
        Me.ListPDF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListPDF.ItemHeight = 20
        Me.ListPDF.Location = New System.Drawing.Point(0, 0)
        Me.ListPDF.Name = "ListPDF"
        Me.ListPDF.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListPDF.Size = New System.Drawing.Size(747, 184)
        Me.ListPDF.TabIndex = 8
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1444, 469)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.UltraGrid1)
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1444, 469)
        Me.Panel2.TabIndex = 260
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(548, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 26)
        Me.Button1.TabIndex = 255
        Me.Button1.Text = "Load Duplicates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance13
        Me.UltraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.GroupByBox.Hidden = True
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.UltraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance20
        Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance23
        Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGrid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraGrid1.Location = New System.Drawing.Point(370, 2)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(1072, 397)
        Me.UltraGrid1.TabIndex = 259
        Me.UltraGrid1.Text = "UltraGrid1"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.LemonChiffon
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(364, 469)
        Me.ListView1.TabIndex = 258
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(372, 441)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 17)
        Me.Label10.TabIndex = 256
        Me.Label10.Text = "Label10"
        '
        'tContAddr1
        '
        Me.tContAddr1.AutoSize = False
        Me.tContAddr1.Enabled = False
        Me.tContAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContAddr1.Location = New System.Drawing.Point(67, 100)
        Me.tContAddr1.Name = "tContAddr1"
        Me.tContAddr1.Size = New System.Drawing.Size(192, 22)
        Me.tContAddr1.TabIndex = 3
        Me.tContAddr1.Tag = "edit;cont_addr1"
        '
        'UltraLabel85
        '
        Me.UltraLabel85.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel85.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel85.Location = New System.Drawing.Point(278, 150)
        Me.UltraLabel85.Name = "UltraLabel85"
        Me.UltraLabel85.Size = New System.Drawing.Size(116, 20)
        Me.UltraLabel85.TabIndex = 186
        Me.UltraLabel85.Text = "Type"
        '
        'tContName
        '
        Me.tContName.AutoSize = False
        Me.tContName.Enabled = False
        Me.tContName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContName.Location = New System.Drawing.Point(67, 31)
        Me.tContName.Name = "tContName"
        Me.tContName.Size = New System.Drawing.Size(192, 21)
        Me.tContName.TabIndex = 1
        Me.tContName.Tag = "edit;cont_name"
        '
        'tContAddr3
        '
        Me.tContAddr3.AutoSize = False
        Me.tContAddr3.Enabled = False
        Me.tContAddr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContAddr3.Location = New System.Drawing.Point(67, 145)
        Me.tContAddr3.Name = "tContAddr3"
        Me.tContAddr3.Size = New System.Drawing.Size(192, 21)
        Me.tContAddr3.TabIndex = 5
        Me.tContAddr3.Tag = "edit;cont_addr3"
        '
        'lContAddr3
        '
        Me.lContAddr3.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.lContAddr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContAddr3.Location = New System.Drawing.Point(2, 146)
        Me.lContAddr3.Name = "lContAddr3"
        Me.lContAddr3.Size = New System.Drawing.Size(116, 20)
        Me.lContAddr3.TabIndex = 183
        Me.lContAddr3.Text = "Addr3"
        '
        'tContCity
        '
        Me.tContCity.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.tContCity.AutoSize = False
        Me.tContCity.CheckedListSettings.CheckStateMember = ""
        Me.tContCity.Enabled = False
        Me.tContCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContCity.Location = New System.Drawing.Point(67, 190)
        Me.tContCity.Name = "tContCity"
        Me.tContCity.Size = New System.Drawing.Size(192, 22)
        Me.tContCity.TabIndex = 7
        Me.tContCity.Tag = "edit;cont_city"
        '
        'UltraLabel17
        '
        Me.UltraLabel17.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(278, 9)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(116, 19)
        Me.UltraLabel17.TabIndex = 184
        Me.UltraLabel17.Text = "Phone 1"
        '
        'tContState
        '
        Me.tContState.AutoSize = False
        Me.tContState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tContState.Enabled = False
        Me.tContState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContState.Location = New System.Drawing.Point(67, 213)
        Me.tContState.MaxLength = 2
        Me.tContState.Name = "tContState"
        Me.tContState.Size = New System.Drawing.Size(54, 22)
        Me.tContState.TabIndex = 8
        Me.tContState.Tag = "edit;cont_state"
        '
        'lContState
        '
        Me.lContState.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.lContState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContState.Location = New System.Drawing.Point(2, 213)
        Me.lContState.Name = "lContState"
        Me.lContState.Size = New System.Drawing.Size(116, 21)
        Me.lContState.TabIndex = 181
        Me.lContState.Text = "State"
        '
        'lContCity
        '
        Me.lContCity.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.lContCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContCity.Location = New System.Drawing.Point(2, 191)
        Me.lContCity.Name = "lContCity"
        Me.lContCity.Size = New System.Drawing.Size(116, 19)
        Me.lContCity.TabIndex = 180
        Me.lContCity.Text = "City"
        '
        'UltraLabel57
        '
        Me.UltraLabel57.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel57.Location = New System.Drawing.Point(2, 32)
        Me.UltraLabel57.Name = "UltraLabel57"
        Me.UltraLabel57.Size = New System.Drawing.Size(116, 20)
        Me.UltraLabel57.TabIndex = 176
        Me.UltraLabel57.Text = "Name"
        '
        'tContAddr2
        '
        Me.tContAddr2.AutoSize = False
        Me.tContAddr2.Enabled = False
        Me.tContAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContAddr2.Location = New System.Drawing.Point(67, 123)
        Me.tContAddr2.Name = "tContAddr2"
        Me.tContAddr2.Size = New System.Drawing.Size(192, 21)
        Me.tContAddr2.TabIndex = 4
        Me.tContAddr2.Tag = "edit;cont_addr2"
        '
        'tContZip
        '
        Me.tContZip.AutoSize = False
        Me.tContZip.Enabled = False
        Me.tContZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContZip.Location = New System.Drawing.Point(67, 167)
        Me.tContZip.MaxLength = 10
        Me.tContZip.Name = "tContZip"
        Me.tContZip.Size = New System.Drawing.Size(96, 21)
        Me.tContZip.TabIndex = 6
        Me.tContZip.Tag = "edit;cont_zip"
        '
        'UltraLabel54
        '
        Me.UltraLabel54.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel54.Location = New System.Drawing.Point(2, 54)
        Me.UltraLabel54.Name = "UltraLabel54"
        Me.UltraLabel54.Size = New System.Drawing.Size(116, 21)
        Me.UltraLabel54.TabIndex = 177
        Me.UltraLabel54.Text = "Company"
        '
        'lContAddr1
        '
        Me.lContAddr1.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.lContAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContAddr1.Location = New System.Drawing.Point(2, 101)
        Me.lContAddr1.Name = "lContAddr1"
        Me.lContAddr1.Size = New System.Drawing.Size(116, 20)
        Me.lContAddr1.TabIndex = 178
        Me.lContAddr1.Text = "Addr1"
        '
        'lContAddr2
        '
        Me.lContAddr2.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.lContAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContAddr2.Location = New System.Drawing.Point(2, 124)
        Me.lContAddr2.Name = "lContAddr2"
        Me.lContAddr2.Size = New System.Drawing.Size(116, 19)
        Me.lContAddr2.TabIndex = 179
        Me.lContAddr2.Text = "Addr2"
        '
        'lContZip
        '
        Me.lContZip.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.lContZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContZip.Location = New System.Drawing.Point(2, 169)
        Me.lContZip.Name = "lContZip"
        Me.lContZip.Size = New System.Drawing.Size(116, 19)
        Me.lContZip.TabIndex = 182
        Me.lContZip.Text = "Zip"
        '
        'tSerial
        '
        Me.tSerial.AutoSize = False
        Me.tSerial.Enabled = False
        Me.tSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSerial.Location = New System.Drawing.Point(67, 9)
        Me.tSerial.Name = "tSerial"
        Me.tSerial.Size = New System.Drawing.Size(96, 21)
        Me.tSerial.TabIndex = 0
        Me.tSerial.Tag = "key;cont_serial;nm"
        '
        'lSerial
        '
        Me.lSerial.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.lSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSerial.Location = New System.Drawing.Point(2, 10)
        Me.lSerial.Name = "lSerial"
        Me.lSerial.Size = New System.Drawing.Size(116, 20)
        Me.lSerial.TabIndex = 199
        Me.lSerial.Text = "ID"
        '
        'tContType
        '
        Me.tContType.AutoSize = False
        Me.tContType.CheckedListSettings.CheckStateMember = ""
        Me.tContType.Enabled = False
        Me.tContType.Location = New System.Drawing.Point(341, 150)
        Me.tContType.Name = "tContType"
        Me.tContType.Size = New System.Drawing.Size(192, 21)
        Me.tContType.TabIndex = 15
        Me.tContType.Tag = "edit;cont_type"
        '
        'tStatus
        '
        Me.tStatus.AutoSize = False
        Me.tStatus.CheckedListSettings.CheckStateMember = ""
        Me.tStatus.Enabled = False
        Me.tStatus.Location = New System.Drawing.Point(341, 172)
        Me.tStatus.Name = "tStatus"
        Me.tStatus.Size = New System.Drawing.Size(192, 21)
        Me.tStatus.TabIndex = 16
        Me.tStatus.Tag = "edit;cont_status"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(278, 172)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(106, 20)
        Me.UltraLabel1.TabIndex = 203
        Me.UltraLabel1.Text = "Status"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(278, 31)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(116, 18)
        Me.UltraLabel3.TabIndex = 206
        Me.UltraLabel3.Text = "Phone 2"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(278, 54)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(116, 20)
        Me.UltraLabel4.TabIndex = 208
        Me.UltraLabel4.Text = "Cell"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(278, 79)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(116, 21)
        Me.UltraLabel5.TabIndex = 210
        Me.UltraLabel5.Text = "Fax"
        '
        'tContEmail
        '
        Me.tContEmail.AutoSize = False
        Me.tContEmail.Enabled = False
        Me.tContEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContEmail.Location = New System.Drawing.Point(341, 102)
        Me.tContEmail.Name = "tContEmail"
        Me.tContEmail.Size = New System.Drawing.Size(192, 22)
        Me.tContEmail.TabIndex = 13
        Me.tContEmail.Tag = "edit;cont_email"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(278, 103)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(116, 20)
        Me.UltraLabel6.TabIndex = 212
        Me.UltraLabel6.Text = "Email"
        '
        'cbInactive
        '
        Me.cbInactive.Enabled = False
        Me.cbInactive.Location = New System.Drawing.Point(341, 197)
        Me.cbInactive.Name = "cbInactive"
        Me.cbInactive.Size = New System.Drawing.Size(182, 20)
        Me.cbInactive.TabIndex = 213
        Me.cbInactive.Tag = "edit;inactive;cb"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Import Contacts"
        '
        'tContWebsite
        '
        Me.tContWebsite.AutoSize = False
        Me.tContWebsite.Enabled = False
        Me.tContWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContWebsite.Location = New System.Drawing.Point(341, 126)
        Me.tContWebsite.Name = "tContWebsite"
        Me.tContWebsite.Size = New System.Drawing.Size(192, 20)
        Me.tContWebsite.TabIndex = 14
        Me.tContWebsite.Tag = "edit;cont_website"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(278, 128)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(116, 18)
        Me.UltraLabel7.TabIndex = 215
        Me.UltraLabel7.Text = "Website"
        '
        'tContComp
        '
        Me.tContComp.AutoSize = False
        Me.tContComp.CheckedListSettings.CheckStateMember = ""
        Me.tContComp.Enabled = False
        Me.tContComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContComp.Location = New System.Drawing.Point(67, 53)
        Me.tContComp.Name = "tContComp"
        Me.tContComp.Size = New System.Drawing.Size(192, 22)
        Me.tContComp.TabIndex = 2
        Me.tContComp.Tag = "edit;cont_company"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lCatMatLast)
        Me.Panel1.Controls.Add(Me.lCatComLast)
        Me.Panel1.Controls.Add(Me.lCatResLast)
        Me.Panel1.Controls.Add(Me.cbCatMatInQue)
        Me.Panel1.Controls.Add(Me.cbCatComInQue)
        Me.Panel1.Controls.Add(Me.cbCatResInQue)
        Me.Panel1.Controls.Add(Me.cbCatMatRemove)
        Me.Panel1.Controls.Add(Me.cbCatComRemove)
        Me.Panel1.Controls.Add(Me.cbCatResRemove)
        Me.Panel1.Controls.Add(Me.cbCatMatMail)
        Me.Panel1.Controls.Add(Me.cbCatComMail)
        Me.Panel1.Controls.Add(Me.cbCatResMail)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbCatMatEmail)
        Me.Panel1.Controls.Add(Me.cbCatComEmail)
        Me.Panel1.Controls.Add(Me.cbCatResEmail)
        Me.Panel1.Location = New System.Drawing.Point(540, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 114)
        Me.Panel1.TabIndex = 217
        '
        'lCatMatLast
        '
        Me.lCatMatLast.AutoSize = True
        Me.lCatMatLast.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCatMatLast.Location = New System.Drawing.Point(282, 86)
        Me.lCatMatLast.Name = "lCatMatLast"
        Me.lCatMatLast.Size = New System.Drawing.Size(51, 16)
        Me.lCatMatLast.TabIndex = 25
        Me.lCatMatLast.Text = "Never"
        '
        'lCatComLast
        '
        Me.lCatComLast.AutoSize = True
        Me.lCatComLast.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCatComLast.Location = New System.Drawing.Point(282, 63)
        Me.lCatComLast.Name = "lCatComLast"
        Me.lCatComLast.Size = New System.Drawing.Size(51, 16)
        Me.lCatComLast.TabIndex = 24
        Me.lCatComLast.Text = "Never"
        '
        'lCatResLast
        '
        Me.lCatResLast.AutoSize = True
        Me.lCatResLast.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCatResLast.Location = New System.Drawing.Point(282, 39)
        Me.lCatResLast.Name = "lCatResLast"
        Me.lCatResLast.Size = New System.Drawing.Size(51, 16)
        Me.lCatResLast.TabIndex = 23
        Me.lCatResLast.Text = "Never"
        '
        'cbCatMatInQue
        '
        Me.cbCatMatInQue.Location = New System.Drawing.Point(248, 86)
        Me.cbCatMatInQue.Name = "cbCatMatInQue"
        Me.cbCatMatInQue.Size = New System.Drawing.Size(35, 16)
        Me.cbCatMatInQue.TabIndex = 22
        Me.cbCatMatInQue.Tag = "edit;cont_cat_mat_inmailque;cb"
        '
        'cbCatComInQue
        '
        Me.cbCatComInQue.Location = New System.Drawing.Point(248, 63)
        Me.cbCatComInQue.Name = "cbCatComInQue"
        Me.cbCatComInQue.Size = New System.Drawing.Size(35, 16)
        Me.cbCatComInQue.TabIndex = 21
        Me.cbCatComInQue.Tag = "edit;cont_cat_com_inmailque;cb"
        '
        'cbCatResInQue
        '
        Me.cbCatResInQue.Location = New System.Drawing.Point(248, 39)
        Me.cbCatResInQue.Name = "cbCatResInQue"
        Me.cbCatResInQue.Size = New System.Drawing.Size(35, 16)
        Me.cbCatResInQue.TabIndex = 20
        Me.cbCatResInQue.Tag = "edit;cont_cat_res_inmailque;cb"
        '
        'cbCatMatRemove
        '
        Me.cbCatMatRemove.Location = New System.Drawing.Point(174, 87)
        Me.cbCatMatRemove.Name = "cbCatMatRemove"
        Me.cbCatMatRemove.Size = New System.Drawing.Size(35, 16)
        Me.cbCatMatRemove.TabIndex = 19
        Me.cbCatMatRemove.Tag = "edit;cont_cat_mat_remove;cb"
        '
        'cbCatComRemove
        '
        Me.cbCatComRemove.Location = New System.Drawing.Point(174, 64)
        Me.cbCatComRemove.Name = "cbCatComRemove"
        Me.cbCatComRemove.Size = New System.Drawing.Size(35, 16)
        Me.cbCatComRemove.TabIndex = 18
        Me.cbCatComRemove.Tag = "edit;cont_cat_com_remove;cb"
        '
        'cbCatResRemove
        '
        Me.cbCatResRemove.Location = New System.Drawing.Point(174, 41)
        Me.cbCatResRemove.Name = "cbCatResRemove"
        Me.cbCatResRemove.Size = New System.Drawing.Size(35, 16)
        Me.cbCatResRemove.TabIndex = 17
        Me.cbCatResRemove.Tag = "edit;cont_cat_res_remove;cb"
        '
        'cbCatMatMail
        '
        Me.cbCatMatMail.Location = New System.Drawing.Point(132, 87)
        Me.cbCatMatMail.Name = "cbCatMatMail"
        Me.cbCatMatMail.Size = New System.Drawing.Size(35, 16)
        Me.cbCatMatMail.TabIndex = 16
        Me.cbCatMatMail.Tag = "edit;cont_cat_mat_mail;cb"
        '
        'cbCatComMail
        '
        Me.cbCatComMail.Location = New System.Drawing.Point(132, 64)
        Me.cbCatComMail.Name = "cbCatComMail"
        Me.cbCatComMail.Size = New System.Drawing.Size(35, 16)
        Me.cbCatComMail.TabIndex = 15
        Me.cbCatComMail.Tag = "edit;cont_cat_com_mail;cb"
        '
        'cbCatResMail
        '
        Me.cbCatResMail.Location = New System.Drawing.Point(132, 41)
        Me.cbCatResMail.Name = "cbCatResMail"
        Me.cbCatResMail.Size = New System.Drawing.Size(35, 16)
        Me.cbCatResMail.TabIndex = 14
        Me.cbCatResMail.Tag = "edit;cont_cat_res_mail;cb"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Material"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Commercial"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(295, -2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 33)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Last Sent"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(229, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 33)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Mail Today"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Remove"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Email"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Catalog Requests"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Residential"
        '
        'cbCatMatEmail
        '
        Me.cbCatMatEmail.Location = New System.Drawing.Point(90, 87)
        Me.cbCatMatEmail.Name = "cbCatMatEmail"
        Me.cbCatMatEmail.Size = New System.Drawing.Size(35, 16)
        Me.cbCatMatEmail.TabIndex = 5
        Me.cbCatMatEmail.Tag = "edit;cont_cat_mat_email;cb"
        '
        'cbCatComEmail
        '
        Me.cbCatComEmail.Location = New System.Drawing.Point(90, 64)
        Me.cbCatComEmail.Name = "cbCatComEmail"
        Me.cbCatComEmail.Size = New System.Drawing.Size(35, 16)
        Me.cbCatComEmail.TabIndex = 2
        Me.cbCatComEmail.Tag = "edit;cont_cat_com_email;cb"
        '
        'cbCatResEmail
        '
        Me.cbCatResEmail.Location = New System.Drawing.Point(90, 41)
        Me.cbCatResEmail.Name = "cbCatResEmail"
        Me.cbCatResEmail.Size = New System.Drawing.Size(35, 16)
        Me.cbCatResEmail.TabIndex = 1
        Me.cbCatResEmail.Tag = "edit;cont_cat_res_email;cb"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(278, 193)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(71, 20)
        Me.UltraLabel8.TabIndex = 218
        Me.UltraLabel8.Text = "Inactive"
        '
        'tInactiveReason
        '
        Me.tInactiveReason.AutoSize = False
        Me.tInactiveReason.CheckedListSettings.CheckStateMember = ""
        Me.tInactiveReason.Enabled = False
        Me.tInactiveReason.Location = New System.Drawing.Point(362, 194)
        Me.tInactiveReason.Name = "tInactiveReason"
        Me.tInactiveReason.Size = New System.Drawing.Size(171, 23)
        Me.tInactiveReason.TabIndex = 18
        Me.tInactiveReason.Tag = "edit;cont_inactive_reason"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(278, 256)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(71, 18)
        Me.UltraLabel9.TabIndex = 220
        Me.UltraLabel9.Text = "Next Call"
        '
        'tNextCall
        '
        Me.tNextCall.AutoSize = False
        Me.tNextCall.DateButtons.Add(DateButton1)
        Me.tNextCall.Enabled = False
        Me.tNextCall.Location = New System.Drawing.Point(341, 252)
        Me.tNextCall.Name = "tNextCall"
        Me.tNextCall.NonAutoSizeHeight = 0
        Me.tNextCall.Size = New System.Drawing.Size(114, 22)
        Me.tNextCall.TabIndex = 19
        Me.tNextCall.Tag = "edit;cont_next_call;dt"
        '
        'UltraLabel10
        '
        Me.UltraLabel10.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(461, 255)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(33, 19)
        Me.UltraLabel10.TabIndex = 222
        Me.UltraLabel10.Text = "By"
        '
        'tNextCallBy
        '
        Me.tNextCallBy.AutoSize = False
        Me.tNextCallBy.CheckedListSettings.CheckStateMember = ""
        Me.tNextCallBy.Enabled = False
        Me.tNextCallBy.Location = New System.Drawing.Point(486, 252)
        Me.tNextCallBy.Name = "tNextCallBy"
        Me.tNextCallBy.Size = New System.Drawing.Size(121, 22)
        Me.tNextCallBy.TabIndex = 20
        Me.tNextCallBy.Tag = "edit;cont_next_call_by"
        '
        'UltraTextEditor6
        '
        Me.UltraTextEditor6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraTextEditor6.AutoSize = False
        Me.UltraTextEditor6.Enabled = False
        Me.UltraTextEditor6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTextEditor6.Location = New System.Drawing.Point(342, 278)
        Me.UltraTextEditor6.Multiline = True
        Me.UltraTextEditor6.Name = "UltraTextEditor6"
        Me.UltraTextEditor6.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.UltraTextEditor6.Size = New System.Drawing.Size(1108, 22)
        Me.UltraTextEditor6.TabIndex = 21
        Me.UltraTextEditor6.Tag = "edit;cont_next_call_reason"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(278, 282)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(71, 18)
        Me.UltraLabel11.TabIndex = 225
        Me.UltraLabel11.Text = "Reason"
        '
        'Tab1
        '
        Me.Tab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl1)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl2)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl3)
        Me.Tab1.Controls.Add(Me.UltraTabPageControl4)
        Me.Tab1.Location = New System.Drawing.Point(2, 343)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.Tab1.Size = New System.Drawing.Size(1448, 496)
        Me.Tab1.TabIndex = 23
        UltraTab1.Key = "Notes"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Notes"
        UltraTab2.Key = "Quote"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Quotes and Orders"
        UltraTab3.Key = "Documents"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Documents"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Duplicates"
        UltraTab4.Visible = False
        Me.Tab1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1444, 469)
        '
        'UltraLabel12
        '
        Me.UltraLabel12.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(278, 304)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(71, 18)
        Me.UltraLabel12.TabIndex = 228
        Me.UltraLabel12.Text = "Add Note"
        '
        'tAddNote
        '
        Me.tAddNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tAddNote.AutoSize = False
        Me.tAddNote.Enabled = False
        Me.tAddNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAddNote.Location = New System.Drawing.Point(341, 304)
        Me.tAddNote.Multiline = True
        Me.tAddNote.Name = "tAddNote"
        Me.tAddNote.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.tAddNote.Size = New System.Drawing.Size(1109, 48)
        Me.tAddNote.TabIndex = 22
        Me.tAddNote.Tag = "edit"
        '
        'UltraLabel13
        '
        Me.UltraLabel13.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(463, 9)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(13, 19)
        Me.UltraLabel13.TabIndex = 232
        Me.UltraLabel13.Text = "x"
        '
        'tContPhoneExt
        '
        Me.tContPhoneExt.AutoSize = False
        Me.tContPhoneExt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tContPhoneExt.Enabled = False
        Me.tContPhoneExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContPhoneExt.Location = New System.Drawing.Point(473, 9)
        Me.tContPhoneExt.MaxLength = 10
        Me.tContPhoneExt.Name = "tContPhoneExt"
        Me.tContPhoneExt.Size = New System.Drawing.Size(60, 21)
        Me.tContPhoneExt.TabIndex = 233
        Me.tContPhoneExt.Tag = "edit;cont_phone1_ext"
        '
        'tContPhone2Ext
        '
        Me.tContPhone2Ext.AutoSize = False
        Me.tContPhone2Ext.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tContPhone2Ext.Enabled = False
        Me.tContPhone2Ext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContPhone2Ext.Location = New System.Drawing.Point(473, 31)
        Me.tContPhone2Ext.MaxLength = 10
        Me.tContPhone2Ext.Name = "tContPhone2Ext"
        Me.tContPhone2Ext.Size = New System.Drawing.Size(60, 21)
        Me.tContPhone2Ext.TabIndex = 235
        Me.tContPhone2Ext.Tag = "edit;cont_phone2_ext"
        '
        'UltraLabel14
        '
        Me.UltraLabel14.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(463, 31)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(13, 19)
        Me.UltraLabel14.TabIndex = 234
        Me.UltraLabel14.Text = "x"
        '
        'bAddQuote
        '
        Appearance143.BackColor = System.Drawing.Color.PaleGoldenrod
        Appearance143.BackColor2 = System.Drawing.Color.Gold
        Appearance143.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance143.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.bAddQuote.Appearance = Appearance143
        Me.bAddQuote.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAddQuote.Location = New System.Drawing.Point(794, 209)
        Me.bAddQuote.Name = "bAddQuote"
        Me.bAddQuote.Size = New System.Drawing.Size(87, 29)
        Me.bAddQuote.TabIndex = 236
        Me.bAddQuote.Tag = ""
        Me.bAddQuote.Text = "Add Quote"
        Me.bAddQuote.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'gSource
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gSource.DisplayLayout.Appearance = Appearance1
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 85
        UltraGridColumn8.Header.Caption = "Src Code"
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.MaxWidth = 100
        UltraGridColumn8.MinWidth = 100
        UltraGridColumn8.Width = 100
        UltraGridColumn9.Header.Caption = "Description"
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridColumn9.MaxWidth = 135
        UltraGridColumn9.MinWidth = 135
        UltraGridColumn9.Width = 135
        UltraGridColumn10.Header.Caption = "X"
        UltraGridColumn10.Header.VisiblePosition = 3
        UltraGridColumn10.MaxWidth = 20
        UltraGridColumn10.MinWidth = 20
        UltraGridColumn10.NullText = "X"
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn10.Width = 20
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.gSource.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gSource.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gSource.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gSource.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.gSource.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.gSource.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gSource.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.gSource.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gSource.DisplayLayout.GroupByBox.Hidden = True
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gSource.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.gSource.DisplayLayout.MaxColScrollRegions = 1
        Me.gSource.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gSource.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.gSource.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.gSource.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.gSource.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.gSource.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gSource.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gSource.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.gSource.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.gSource.DisplayLayout.Override.CellAppearance = Appearance8
        Me.gSource.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gSource.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.gSource.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.FontData.SizeInPoints = 7.0!
        Appearance10.TextHAlignAsString = "Left"
        Me.gSource.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.gSource.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gSource.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.gSource.DisplayLayout.Override.RowAppearance = Appearance11
        Me.gSource.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gSource.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.gSource.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gSource.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gSource.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.gSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gSource.Location = New System.Drawing.Point(907, 11)
        Me.gSource.Name = "gSource"
        Me.gSource.Size = New System.Drawing.Size(312, 239)
        Me.gSource.TabIndex = 237
        Me.gSource.Tag = "NOEDIT"
        Me.gSource.Text = "UltraGrid1"
        '
        'bAddSrc
        '
        Me.bAddSrc.Enabled = False
        Me.bAddSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddSrc.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAddSrc.Location = New System.Drawing.Point(1123, 11)
        Me.bAddSrc.Name = "bAddSrc"
        Me.bAddSrc.Size = New System.Drawing.Size(90, 25)
        Me.bAddSrc.TabIndex = 238
        Me.bAddSrc.Tag = "Edit"
        Me.bAddSrc.Text = "Add"
        Me.bAddSrc.UseVisualStyleBackColor = True
        '
        'bReEmail
        '
        Me.bReEmail.AutoSize = True
        Me.bReEmail.Location = New System.Drawing.Point(545, 128)
        Me.bReEmail.Name = "bReEmail"
        Me.bReEmail.Size = New System.Drawing.Size(124, 17)
        Me.bReEmail.TabIndex = 239
        Me.bReEmail.TabStop = True
        Me.bReEmail.Text = "Re-Email Catalogs"
        '
        'tContCountry
        '
        Me.tContCountry.AutoSize = False
        Me.tContCountry.CheckedListSettings.CheckStateMember = ""
        Me.tContCountry.Enabled = False
        Me.tContCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContCountry.Location = New System.Drawing.Point(67, 76)
        Me.tContCountry.Name = "tContCountry"
        Me.tContCountry.Size = New System.Drawing.Size(192, 22)
        Me.tContCountry.TabIndex = 240
        Me.tContCountry.Tag = "edit;cont_country"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(2, 76)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(116, 21)
        Me.UltraLabel2.TabIndex = 241
        Me.UltraLabel2.Text = "Country"
        '
        'tContCounty
        '
        Me.tContCounty.AutoSize = False
        Me.tContCounty.Enabled = False
        Me.tContCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContCounty.Location = New System.Drawing.Point(67, 236)
        Me.tContCounty.Name = "tContCounty"
        Me.tContCounty.Size = New System.Drawing.Size(192, 21)
        Me.tContCounty.TabIndex = 242
        Me.tContCounty.Tag = "edit;cont_county"
        '
        'lContCounty
        '
        Me.lContCounty.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.lContCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContCounty.Location = New System.Drawing.Point(2, 238)
        Me.lContCounty.Name = "lContCounty"
        Me.lContCounty.Size = New System.Drawing.Size(116, 19)
        Me.lContCounty.TabIndex = 243
        Me.lContCounty.Text = "County"
        '
        'tContProvince
        '
        Me.tContProvince.AutoSize = False
        Me.tContProvince.Enabled = False
        Me.tContProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContProvince.Location = New System.Drawing.Point(67, 258)
        Me.tContProvince.Name = "tContProvince"
        Me.tContProvince.Size = New System.Drawing.Size(192, 21)
        Me.tContProvince.TabIndex = 244
        Me.tContProvince.Tag = "edit;cont_province"
        '
        'lContProvince
        '
        Me.lContProvince.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.lContProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContProvince.Location = New System.Drawing.Point(2, 260)
        Me.lContProvince.Name = "lContProvince"
        Me.lContProvince.Size = New System.Drawing.Size(116, 19)
        Me.lContProvince.TabIndex = 245
        Me.lContProvince.Text = "Province"
        '
        'tContPhone
        '
        Me.tContPhone.Enabled = False
        Me.tContPhone.Location = New System.Drawing.Point(341, 4)
        Me.tContPhone.Name = "tContPhone"
        Me.tContPhone.Size = New System.Drawing.Size(120, 23)
        Me.tContPhone.TabIndex = 246
        Me.tContPhone.Tag = "edit;cont_phone1"
        '
        'tContPhone2
        '
        Me.tContPhone2.Enabled = False
        Me.tContPhone2.Location = New System.Drawing.Point(341, 28)
        Me.tContPhone2.Name = "tContPhone2"
        Me.tContPhone2.Size = New System.Drawing.Size(120, 23)
        Me.tContPhone2.TabIndex = 247
        Me.tContPhone2.Tag = "edit;cont_phone2"
        '
        'tContCell
        '
        Me.tContCell.Enabled = False
        Me.tContCell.Location = New System.Drawing.Point(341, 53)
        Me.tContCell.Name = "tContCell"
        Me.tContCell.Size = New System.Drawing.Size(192, 23)
        Me.tContCell.TabIndex = 248
        Me.tContCell.Tag = "edit;cont_cell"
        '
        'tContFax
        '
        Me.tContFax.Enabled = False
        Me.tContFax.Location = New System.Drawing.Point(341, 78)
        Me.tContFax.Name = "tContFax"
        Me.tContFax.Size = New System.Drawing.Size(192, 23)
        Me.tContFax.TabIndex = 249
        Me.tContFax.Tag = "edit;cont_fax"
        '
        'cOSRnote
        '
        Me.cOSRnote.AutoSize = True
        Me.cOSRnote.Enabled = False
        Me.cOSRnote.Location = New System.Drawing.Point(283, 319)
        Me.cOSRnote.Name = "cOSRnote"
        Me.cOSRnote.Size = New System.Drawing.Size(57, 21)
        Me.cOSRnote.TabIndex = 250
        Me.cOSRnote.Tag = "edit"
        Me.cOSRnote.Text = "OSR"
        Me.cOSRnote.UseVisualStyleBackColor = True
        '
        'tLastCallBy
        '
        Me.tLastCallBy.AutoSize = False
        Me.tLastCallBy.CheckedListSettings.CheckStateMember = ""
        Me.tLastCallBy.Enabled = False
        Me.tLastCallBy.Location = New System.Drawing.Point(586, 226)
        Me.tLastCallBy.Name = "tLastCallBy"
        Me.tLastCallBy.Size = New System.Drawing.Size(121, 23)
        Me.tLastCallBy.TabIndex = 252
        Me.tLastCallBy.Tag = "edit;cont_call_center_rep_code"
        '
        'UltraLabel15
        '
        Me.UltraLabel15.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(560, 229)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(34, 20)
        Me.UltraLabel15.TabIndex = 254
        Me.UltraLabel15.Text = "By"
        '
        'tLastCall
        '
        Me.tLastCall.AutoSize = False
        Me.tLastCall.DateButtons.Add(DateButton2)
        Me.tLastCall.Enabled = False
        Me.tLastCall.Location = New System.Drawing.Point(440, 226)
        Me.tLastCall.Name = "tLastCall"
        Me.tLastCall.NonAutoSizeHeight = 0
        Me.tLastCall.Size = New System.Drawing.Size(114, 23)
        Me.tLastCall.TabIndex = 251
        Me.tLastCall.Tag = "edit;cont_last_contact;dt"
        '
        'UltraLabel16
        '
        Me.UltraLabel16.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(278, 230)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(178, 19)
        Me.UltraLabel16.TabIndex = 253
        Me.UltraLabel16.Text = "Call Center Last Contacted"
        '
        'UltraLabel18
        '
        Me.UltraLabel18.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(2, 288)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(70, 34)
        Me.UltraLabel18.TabIndex = 256
        Me.UltraLabel18.Text = "Field Consultant"
        '
        'tFieldConsult
        '
        Me.tFieldConsult.AutoSize = False
        Me.tFieldConsult.CheckedListSettings.CheckStateMember = ""
        Me.tFieldConsult.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tFieldConsult.Enabled = False
        Me.tFieldConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFieldConsult.Location = New System.Drawing.Point(67, 288)
        Me.tFieldConsult.Name = "tFieldConsult"
        Me.tFieldConsult.Size = New System.Drawing.Size(192, 22)
        Me.tFieldConsult.TabIndex = 257
        Me.tFieldConsult.Tag = "edit;cont_field_consult;dc"
        '
        'UltraLabel19
        '
        Me.UltraLabel19.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(626, 255)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(170, 24)
        Me.UltraLabel19.TabIndex = 258
        Me.UltraLabel19.Text = "Remove from report"
        '
        'cbRemoveReport
        '
        Me.cbRemoveReport.Enabled = False
        Me.cbRemoveReport.Location = New System.Drawing.Point(788, 250)
        Me.cbRemoveReport.Name = "cbRemoveReport"
        Me.cbRemoveReport.Size = New System.Drawing.Size(36, 24)
        Me.cbRemoveReport.TabIndex = 259
        Me.cbRemoveReport.Tag = "edit;RemoveReport;cb"
        '
        'UltraLabel20
        '
        Me.UltraLabel20.BackColorInternal = System.Drawing.Color.Gainsboro
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(814, 250)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(86, 24)
        Me.UltraLabel20.TabIndex = 260
        Me.UltraLabel20.Text = "Add to report"
        '
        'cbAddToReport
        '
        Me.cbAddToReport.Location = New System.Drawing.Point(906, 252)
        Me.cbAddToReport.Name = "cbAddToReport"
        Me.cbAddToReport.Size = New System.Drawing.Size(36, 24)
        Me.cbAddToReport.TabIndex = 261
        Me.cbAddToReport.Tag = ""
        '
        'fmContacts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1456, 842)
        Me.Controls.Add(Me.cbAddToReport)
        Me.Controls.Add(Me.UltraLabel20)
        Me.Controls.Add(Me.cbRemoveReport)
        Me.Controls.Add(Me.UltraLabel19)
        Me.Controls.Add(Me.tFieldConsult)
        Me.Controls.Add(Me.UltraLabel18)
        Me.Controls.Add(Me.tLastCallBy)
        Me.Controls.Add(Me.UltraLabel15)
        Me.Controls.Add(Me.tLastCall)
        Me.Controls.Add(Me.UltraLabel16)
        Me.Controls.Add(Me.cOSRnote)
        Me.Controls.Add(Me.tContFax)
        Me.Controls.Add(Me.tContCell)
        Me.Controls.Add(Me.tContPhone2)
        Me.Controls.Add(Me.tContPhone)
        Me.Controls.Add(Me.tContProvince)
        Me.Controls.Add(Me.lContProvince)
        Me.Controls.Add(Me.tContCounty)
        Me.Controls.Add(Me.lContCounty)
        Me.Controls.Add(Me.tContCountry)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.bReEmail)
        Me.Controls.Add(Me.UltraTextEditor6)
        Me.Controls.Add(Me.bAddSrc)
        Me.Controls.Add(Me.gSource)
        Me.Controls.Add(Me.bAddQuote)
        Me.Controls.Add(Me.tContPhone2Ext)
        Me.Controls.Add(Me.UltraLabel14)
        Me.Controls.Add(Me.tContPhoneExt)
        Me.Controls.Add(Me.UltraLabel13)
        Me.Controls.Add(Me.tAddNote)
        Me.Controls.Add(Me.Tab1)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.tNextCallBy)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.tNextCall)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.tInactiveReason)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tContComp)
        Me.Controls.Add(Me.tContWebsite)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.cbInactive)
        Me.Controls.Add(Me.tContEmail)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.tStatus)
        Me.Controls.Add(Me.tContType)
        Me.Controls.Add(Me.tSerial)
        Me.Controls.Add(Me.lSerial)
        Me.Controls.Add(Me.tContAddr1)
        Me.Controls.Add(Me.UltraLabel85)
        Me.Controls.Add(Me.tContName)
        Me.Controls.Add(Me.tContAddr3)
        Me.Controls.Add(Me.lContAddr3)
        Me.Controls.Add(Me.tContCity)
        Me.Controls.Add(Me.UltraLabel17)
        Me.Controls.Add(Me.tContState)
        Me.Controls.Add(Me.lContState)
        Me.Controls.Add(Me.lContCity)
        Me.Controls.Add(Me.UltraLabel57)
        Me.Controls.Add(Me.tContAddr2)
        Me.Controls.Add(Me.tContZip)
        Me.Controls.Add(Me.UltraLabel54)
        Me.Controls.Add(Me.lContAddr1)
        Me.Controls.Add(Me.lContAddr2)
        Me.Controls.Add(Me.lContZip)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.UltraLabel12)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu = Me.MainMenu1
        Me.Name = "fmContacts"
        Me.Text = "Contacts"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.gNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContAddr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContAddr3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContAddr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContZip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tSerial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbInactive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContWebsite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContComp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbCatMatInQue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatComInQue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatResInQue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatMatRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatComRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatResRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatMatMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatComMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatResMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatMatEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatComEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatResEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tInactiveReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNextCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNextCallBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab1.ResumeLayout(False)
        CType(Me.tAddNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContPhoneExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContPhone2Ext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContCounty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tContProvince, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLastCallBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLastCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tFieldConsult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRemoveReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAddToReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub fmContacts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Table = "cont_file"
        Me.Key1 = "cont_serial"
        Me.FocusField = "tconttype"

        LoadDD2(tContType, "cont_type", "cont_type", "cont_type")
        LoadDD2(tStatus, "cont_status", "cont_status", "cont_status")
        'LoadDD2(tOrderSrc, "ord_src", "ord_src", "ord_src", , "ord_src_inactive <> 1")
        LoadDD2(tContComp, "cont_file", "cont_company", "cont_company", "distinct cont_company")
        tContComp.DisplayLayout.Bands(0).Columns(0).Width = 300
        LoadDD2(tContCountry, "country_file", "country_code", "country_code", "country_code,country")
        LoadDD2(tFieldConsult, "field_consultant", "fc_serial", "fc_full_name_last", , , )
        Try
            Dim dt As New DataTable
            Dim dr As DataRow
            dt.Columns.Add("Reason")
            dr = dt.NewRow
            dr("Reason") = "Returned Mail"
            dt.Rows.Add(dr)
            dr = dt.NewRow
            dr("Reason") = "Customer Requested"
            dt.Rows.Add(dr)
            tInactiveReason.DataSource = dt
            tInactiveReason.DisplayMember = "Reason"
            tInactiveReason.ValueMember = "Reason"
            tInactiveReason.DataBind()

            'dt = New DataTable
            'dt.Columns.Add("By")
            'dr = dt.NewRow
            'dr("By") = "Call Center"
            'dt.Rows.Add(dr)

            'tNextCallBy.DataSource = dt
            'tNextCallBy.DisplayMember = "By"
            'tNextCallBy.ValueMember = "By"
            'tNextCallBy.DataBind()

            LoadDD2(tNextCallBy, "usr_file", "usr_name", "usr_name", , "isnull(inactive,0)=0", False, "Call Center,")
            LoadDD2(tLastCallBy, "usr_file", "usr_name", "usr_name", , "isnull(inactive,0)=0", False, "Call Center,")

            If UserGroup = "Admins" Then
                Tab1.Tabs(3).Visible = True
            Else
                Tab1.Tabs(3).Visible = False
            End If

        Catch
            MsgBox(Err.Description)
        End Try

    End Sub
    Public Overrides Sub Add_After()
        MyBase.Add_After()
        LoadNotes()
        LoadSourceCodes()
        NameChanged = False
    End Sub
    Public Overrides Sub Add_Before()
        MyBase.Add_Before()
        If AddedFromContact = False Then
            MsgBox("You must first try to find the contact and then add from that screen.", MsgBoxStyle.Information, "Add?")
            EditCanceled = True
        End If
    End Sub
    Public Overrides Sub Edit_After()
        MyBase.Edit_After()
        NameChanged = False
        If UserGroup = "Admins" Then
            gNotes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True
        Else
            gNotes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        End If
        gNotes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.DefaultableBoolean.False
    End Sub
    Public Overrides Sub Save_Before()
        If gSource.Rows.Count = 0 Then
            MsgBox("You must have at least one Source Code", MsgBoxStyle.Critical, "Source Code")
            SaveCanceled = True
            Exit Sub
        End If
        If cbCatResEmail.Checked And (tContEmail.Text = "" Or (InStr(tContEmail.Text, "@") = 0 Or InStr(tContEmail.Text, ".") = 0)) Then
            MsgBox("You must have a proper email address if catalogs are to be emailed", MsgBoxStyle.Critical, "Email?")
            SaveCanceled = True
            Exit Sub
        End If
        If KeyValue1 <> "" Then
            Dim cmd As New SqlCommand("", cnn)
            Dim da As New SqlDataAdapter(cmd)
            cmd.CommandText = "select * from cont_file where cont_serial=" + KeyValue1
            dtOldContact = New DataTable
            da.Fill(dtOldContact)
            cmd.CommandText = "select * from cont_src where cont_src_cont_serial=" + KeyValue1
            dtOldSrcCodes = New DataTable
            da.Fill(dtOldSrcCodes)


        Else
            If Not dtOldContact Is Nothing Then dtOldContact.Clear()
            If Not dtOldSrcCodes Is Nothing Then dtOldSrcCodes.Clear()
        End If
    End Sub
    Public Overrides Sub Save_After()
        Dim cmd As New SqlCommand("", cnn)
        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
        Dim Note As String
        Dim NoteType As String
        Dim col As DataColumn
        Dim da As New SqlDataAdapter(cmd)
        Dim SrcCodeChanges As String = ""
        Dim SendResCat As Boolean = False
        Dim SendComCat As Boolean = False
        Dim SendMatCat As Boolean = False
        Dim UpdateNextCall As Boolean = False

        If tSerial.Text = "" Then
            NoteType = "Added"
        Else
            NoteType = "Saved"
        End If

        tSerial.Text = KeyValue1

        cnn.Open()
        If NoteType = "Added" Then
            cmd.CommandText = "update cont_file set cont_import_by='Star Contact Pg',cont_import_time=getdate() where cont_serial=" + tSerial.Text
            cmd.ExecuteNonQuery()
        End If
        If Me.cbAddToReport.Checked Then
            cmd.CommandText = "insert to_do (to_do_type,to_do_ord_serial) select 'call', " + tSerial.Text
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update cont_file set cont_next_call=GETDATE() where cont_serial =" + tSerial.Text
            cmd.ExecuteNonQuery()
        End If
        For Each rw In gSource.Rows
            If rw.Cells("cont_src_serial").Value = 0 And rw.Appearance.FontData.Strikeout <> Infragistics.Win.DefaultableBoolean.True Then
                cmd.CommandText = "insert into cont_src (cont_src_cont_serial,cont_src_ord_src) values (" + CStr(KeyValue1) + ",'" + rw.Cells("ord_src").Value + "')"
                cmd.ExecuteNonQuery()
                SrcCodeChanges += "Added " + rw.Cells("ord_src").Value + ", "
            End If
            If rw.Cells("cont_src_serial").Value <> 0 And rw.Appearance.FontData.Strikeout = Infragistics.Win.DefaultableBoolean.True Then
                cmd.CommandText = "delete from cont_src where cont_src_serial=" + CStr(rw.Cells("cont_src_serial").Value)
                cmd.ExecuteNonQuery()
                SrcCodeChanges += "Deleted " + rw.Cells("ord_src").Value + ", "
            End If
        Next
        If SrcCodeChanges.Length > 2 Then SrcCodeChanges = Mid(SrcCodeChanges, 1, SrcCodeChanges.Length - 2)

        Note = ""

        Dim dt As New DataTable
        cmd.CommandText = "select * from cont_file where cont_serial=" + KeyValue1
        da.Fill(dt)

        If Not dtOldContact Is Nothing Then
            For Each col In dtOldContact.Columns
                If (col.DataType.Name) = "DateTime" Then
                    If nz(dtOldContact.Rows(0)(col.ColumnName), CDate("1/1/1900")) <> nz(dt.Rows(0)(col.ColumnName)) Then
                        If col.ColumnName <> "last_update" Then
                            If col.DataType Is GetType(Boolean) Then
                                If Mid(col.ColumnName, 1, 8) = "cont_cat" Then
                                    Note += UCase(Mid(col.ColumnName, 10)) + ": "
                                Else
                                    Note += UCase(col.ColumnName) + ": "
                                End If
                                If col.ColumnName = "cont_cat_res_email" Then
                                    If dtOldContact.Rows(0)(col.ColumnName) = False And dt.Rows(0)(col.ColumnName) = True Then
                                        SendResCat = True
                                    End If
                                End If
                                If col.ColumnName = "cont_cat_com_email" Then
                                    If dtOldContact.Rows(0)(col.ColumnName) = False And dt.Rows(0)(col.ColumnName) = True Then
                                        SendComCat = True
                                    End If
                                End If
                                If col.ColumnName = "cont_cat_mat_email" Then
                                    If dtOldContact.Rows(0)(col.ColumnName) = False And dt.Rows(0)(col.ColumnName) = True Then
                                        SendMatCat = True
                                    End If
                                End If
                            End If
                            Note += CStr(nz(dtOldContact.Rows(0)(col.ColumnName))) + " -> " + CStr(nz(dt.Rows(0)(col.ColumnName))) + ", "
                        End If
                    End If
                Else
                    If nz(dtOldContact.Rows(0)(col.ColumnName)) <> nz(dt.Rows(0)(col.ColumnName)) Then
                        If col.ColumnName <> "last_update" Then
                            If col.DataType Is GetType(Boolean) Then
                                If Mid(col.ColumnName, 1, 8) = "cont_cat" Then
                                    Note += UCase(Mid(col.ColumnName, 10)) + ": "
                                Else
                                    Note += UCase(col.ColumnName) + ": "
                                End If
                                If col.ColumnName = "cont_cat_res_email" Then
                                    If dtOldContact.Rows(0)(col.ColumnName) = False And dt.Rows(0)(col.ColumnName) = True Then
                                        SendResCat = True
                                    End If
                                End If
                                If col.ColumnName = "cont_cat_com_email" Then
                                    If dtOldContact.Rows(0)(col.ColumnName) = False And dt.Rows(0)(col.ColumnName) = True Then
                                        SendComCat = True
                                    End If
                                End If
                                If col.ColumnName = "cont_cat_mat_email" Then
                                    If dtOldContact.Rows(0)(col.ColumnName) = False And dt.Rows(0)(col.ColumnName) = True Then
                                        SendMatCat = True
                                    End If
                                End If
                            End If
                            Note += CStr(nz(dtOldContact.Rows(0)(col.ColumnName))) + " -> " + CStr(nz(dt.Rows(0)(col.ColumnName))) + ", "
                        End If
                    End If
                End If

                'If nz(dtOldContact.Rows(0)(col.ColumnName)) <> nz(dt.Rows(0)(col.ColumnName)) Then
                '    If col.ColumnName <> "last_update" Then
                '        If col.DataType Is GetType(Boolean) Then
                '            If Mid(col.ColumnName, 1, 8) = "cont_cat" Then
                '                Note += UCase(Mid(col.ColumnName, 10)) + ": "
                '            Else
                '                Note += UCase(col.ColumnName) + ": "
                '            End If
                '            If col.ColumnName = "cont_cat_res_email" Then
                '                If dtOldContact.Rows(0)(col.ColumnName) = False And dt.Rows(0)(col.ColumnName) = True Then
                '                    SendResCat = True
                '                End If
                '            End If
                '            If col.ColumnName = "cont_cat_com_email" Then
                '                If dtOldContact.Rows(0)(col.ColumnName) = False And dt.Rows(0)(col.ColumnName) = True Then
                '                    SendComCat = True
                '                End If
                '            End If
                '            If col.ColumnName = "cont_cat_mat_email" Then
                '                If dtOldContact.Rows(0)(col.ColumnName) = False And dt.Rows(0)(col.ColumnName) = True Then
                '                    SendMatCat = True
                '                End If
                '            End If
                '        End If
                '        Note += CStr(nz(dtOldContact.Rows(0)(col.ColumnName))) + " -> " + CStr(nz(dt.Rows(0)(col.ColumnName))) + ", "
                '    End If
                'End If
            Next
            If SrcCodeChanges <> "" Then Note += "SOURCE CODES: " + SrcCodeChanges + ", "
            If Note.Length > 2 Then Note = Mid(Note, 1, Note.Length - 2)

            If dtOldContact.Rows(0)("cont_next_call") <> dt.Rows(0)("cont_next_call") Or dtOldContact.Rows(0)("cont_next_call_by") <> dt.Rows(0)("cont_next_call_by") Then UpdateNextCall = True
        Else
            If cbCatResEmail.Checked Then SendResCat = True
            If cbCatComEmail.Checked Then SendComCat = True
            If cbCatMatEmail.Checked Then SendMatCat = True
            UpdateNextCall = True
        End If

        If Note <> "" Then
            cmd.CommandText = "insert into cont_note (cont_note_cont_serial,cont_note_user,cont_note_date,cont_note_type,cont_note) values (" + CStr(KeyValue1) + ",'" + User + "',getdate(),'" + NoteType + "','" + Replace(Note, "'", "''") + "')"
            cmd.ExecuteNonQuery()
        End If
        If tAddNote.Text <> "" Then
            cmd.CommandText = "insert into cont_note (cont_note_cont_serial,cont_note_user,cont_note_date,cont_note_type,cont_note,cont_note_osr) values (" + CStr(KeyValue1) + ",'" + User + "',getdate(),'Note','" + Replace(tAddNote.Text, "'", "''") + "'," + IIf(cOSRnote.CheckState = CheckState.Checked, "1", "0") + ")"
            cmd.ExecuteNonQuery()
        End If
        If UpdateNextCall Then
            If IsDate(tNextCall.Text) = True And tNextCallBy.Text <> "" Then
                Dim dtRep As New DataTable
                cmd.CommandText = "select rep_email from rep_file where rep_code='" + Replace(tNextCallBy.Text, "'", "''") + "' and rep_type='O'"
                da.Fill(dtRep)
                If dtRep.Rows.Count > 1 Then
                    SendMail(dt.Rows(0)("rep_email"), "toddw@winecellarinnovations.com", "New Lead", "You have a new lead: " + tContName.Text + " should be called on " + tNextCall.Text)
                Else
                    AddToDo("Call", tNextCallBy.Text, "New Lead: " + tContName.Text + " should be called on " + tNextCall.Text, CLng(tSerial.Text), , , , tContName.Text, "Contact")
                End If
            End If
        End If
        cnn.Close()

        If NameChanged Then
            Dim dr As String
            For Each dr In IO.Directory.GetDirectories(PDFPathContact, tSerial.Text + "*")
                'FileIO.FileSystem.RenameDirectory(dr, PDFPathContact + tSerial.Text + " (" + tContName.Text + ")")
                IO.Directory.Move(dr, PDFPathContact + tSerial.Text + " (" + tContName.Text + ")")
            Next
        End If

        '*-contact note delete added 4/5/12 by DRW
        If dtc.Rows.Count > 0 Then
            dac.Update(dtc)
            dtc.Clear()
        End If

        tAddNote.Text = ""
        LoadNotes()
        LoadSourceCodes()

        If SendResCat Or SendComCat Or SendMatCat Then
            EmailCatalogs()
        End If
        EditMode = ""
    End Sub
    Public Overrides Sub Cancel()
        MyBase.Cancel()
        dtc.Clear()
        If KeyValue1 <> "" Then
            LoadFields(Me)
            LoadNotes()
            LoadSourceCodes()
        Else
            ClearFields(Me.Controls, False)
            LoadNotes()
            LoadSourceCodes()
        End If
        EditMode = ""
    End Sub
    Public Overrides Sub Find()
        Try
            Dim fm As New fmContactFind
            fm.Width = Me.Width * 0.8
            fm.Height = Me.Height * 0.8
            fm.SearchSpeedCodes = False
            fm.tName.Focus()
            fm.ShowDialog()
            If fm.AddContact Then
                AddedFromContact = True
                Me.Add()
                AddedFromContact = False
                tContName.Text = fm.tName.Text
                tContComp.Text = fm.tCompany.Text
                tContAddr1.Text = fm.tAddr.Text
                tContZip.Text = fm.tZip.Text
                tContCity.Text = fm.tCity.Text
                tContState.Text = fm.tState.Text
                tContPhone.Text = fm.tPhone.Text
                tContPhoneExt.Text = fm.tPhoneExt.Text
                tContCell.Text = fm.tCell.Text
                tContFax.Text = fm.tFax.Text
                tContEmail.Text = fm.tEmail.Text
                tContWebsite.Text = fm.tWebsite.Text
                tContType.Value = fm.tType.Value
                tStatus.Value = fm.tStatus.Value
                tContCountry.Value = "USA"
                fm.Close()
            Else
                If fm.ContactSerial <> 0 Then
                    KeyValue1 = fm.ContactSerial
                    LoadFields(Me)
                    LoadNotes()
                    LoadSourceCodes()
                End If
                fm.Close()
                EditButtons("Idle")
            End If
            If Tab1.SelectedTab.Key = "Quote" Then LoadQuotesOrders()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Sub LoadNotes()
        dtc.Clear()
        cmdc.CommandText = "select * from cont_note where cont_note_cont_serial=" + CStr(IIf(KeyValue1 = "", -1, KeyValue1)) + IIf(cbNotes.Checked, " and cont_note_type in ('Note','System','OSR')", "") + " order by cont_note_date desc"
        dac.Fill(dtc)
        gNotes.DataSource = dtc
        gNotes.DataBind()
    End Sub
    'Private Sub LoadSourceCodes(Optional ByVal Reset As Boolean = False)
    '    Dim cmd As New SqlCommand("", cnn)
    '    Dim dt As New DataTable
    '    Dim da As New SqlDataAdapter(cmd)
    '    Dim dr As DataRow

    '    If Reset Then
    '        ShowAllSourceCodes = False
    '        LinkLabel1.Text = "Show All Source Codes"
    '    End If
    '    If ShowAllSourceCodes Then
    '        cmd.CommandText = "select ord_src,ord_src_desc,cont_src_serial from ord_src left outer join cont_src on ord_src=cont_src_ord_src where ord_src_inactive<>1 order by ord_src_desc"
    '    Else
    '        cmd.CommandText = "select cont_src_serial,ord_src,ord_src_desc from cont_src left outer join ord_src on cont_src_ord_src=ord_src where cont_src_cont_serial=" + CStr(KeyValue1) + " order by ord_src_desc"
    '    End If

    '    da.Fill(dt)
    '    tSourceCode.Items.Clear()
    '    For Each dr In dt.Rows
    '        If ShowAllSourceCodes Then
    '            tSourceCode.Items.Add(dr("ord_src") + " - " + dr("ord_src_desc"), nz(dr("cont_src_serial"), 0) > 0)
    '        Else
    '            tSourceCode.Items.Add(dr("ord_src") + " - " + dr("ord_src_desc"), True)
    '        End If
    '    Next
    'End Sub
    Public Sub LoadSourceCodes(Optional ByVal Reset As Boolean = False)
        Dim cmd As New SqlCommand("", cnn)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow

        cmd.CommandText = "select cont_src_serial,ord_src,ord_src_desc from cont_src left outer join ord_src on cont_src_ord_src=ord_src where cont_src_cont_serial=" + CStr(IIf(KeyValue1 = "", -1, KeyValue1)) + " order by cont_src_serial"

        dtSrcCodes = New DataTable
        da.Fill(dtSrcCodes)
        gSource.DataSource = dtSrcCodes
        gSource.DataBind()

        cmd.CommandText = "select cont_cat_res_last_sent,cont_cat_com_last_sent,cont_cat_mat_last_sent from cont_file where cont_serial=" + CStr(IIf(KeyValue1 = "", -1, KeyValue1))
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            lCatResLast.Text = IIf(CStr(nz(dr("cont_cat_res_last_sent"), "Never")) = "Never", "Never", Format(nz(dr("cont_cat_res_last_sent")), "MM/dd/yyyy"))
            lCatComLast.Text = IIf(CStr(nz(dr("cont_cat_com_last_sent"), "Never")) = "Never", "Never", Format(nz(dr("cont_cat_com_last_sent")), "MM/dd/yyyy"))
            lCatMatLast.Text = IIf(CStr(nz(dr("cont_cat_mat_last_sent"), "Never")) = "Never", "Never", Format(nz(dr("cont_cat_mat_last_sent")), "MM/dd/yyyy"))
        End If
        dt = Nothing
    End Sub

    Private Sub tContFax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        nonNumberEntered = False
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            ' Determine whether the keystroke is a number from the keypad.
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                ' Determine whether the keystroke is a backspace.
                If e.KeyCode <> Keys.Back Then
                    ' A non-numerical keystroke was pressed. 
                    ' Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = True
                End If
            End If
        End If
    End Sub

    Private Sub tContFax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If nonNumberEntered And e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub


    Private Sub tContZip_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tContZip.Enter
        onZip = tContZip.Text
    End Sub

    Private Sub tContZip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tContZip.Leave
        If tContZip.Text <> onZip Then
            tContCity.Text = ""
            tContState.Text = ""
        End If
        If tContZip.Text = "" Then Exit Sub
        LoadDD2(tContCity, "zip_file", "zip_city", "zip_city", "zip_city,zip_state,zip_county_name", "zip_code='" + tContZip.Text + "' and zip_start<='" + CStr(Today) + "' and zip_end>='" + CStr(Today) + " '")
    End Sub

    Private Sub tContCity_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tContCity.InitializeLayout

    End Sub

    Private Sub tContCity_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tContCity.Enter
        If tContCity.Rows.Count = 1 Then
            tContCity.Text = tContCity.Rows(0).Cells(0).Text
        Else
            If tContCity.IsDroppedDown = False Then tContCity.ToggleDropdown()
        End If
    End Sub

    Private Sub tContCity_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tContCity.Leave
        Try
            If tContCity.ActiveRow Is Nothing Then Exit Sub
            If tContCity.IsItemInList(tContCity.Value) = True Then
                tContState.Text = tContCity.ActiveRow.Cells(1).Text
                tContCounty.Text = tContCity.ActiveRow.Cells(2).Text
            End If
        Catch
            DoError(Err, Me)
        End Try

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim fm As New fmContactsImport
        fm.ShowDialog()
    End Sub

    Private Sub tContComp_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tContComp.Enter
        If tContComp.IsDroppedDown = False Then tContComp.ToggleDropdown()

    End Sub

    Private Sub tContComp_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tContComp.InitializeLayout

    End Sub

    Private Sub tContComp_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tContComp.KeyUp
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cmd As New SqlCommand("", cnn)

        cmd.CommandText = "insert into cont_note (cont_note_cont_serial,cont_note_user,cont_note_date,cont_note_type,cont_note) values (" + CStr(KeyValue1) + ",'" + User + "',getdate(),'Note','" + Replace(tAddNote.Text, "'", "''") + "')"
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        LoadNotes()
    End Sub

    Private Sub tContPhone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        nonNumberEntered = False
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            ' Determine whether the keystroke is a number from the keypad.
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                ' Determine whether the keystroke is a backspace.
                If e.KeyCode <> Keys.Back Then
                    ' A non-numerical keystroke was pressed. 
                    ' Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = True
                End If
            End If
        End If

    End Sub


    Private Sub tContPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If nonNumberEntered And e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub


    Private Sub tContPhone2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        nonNumberEntered = False
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            ' Determine whether the keystroke is a number from the keypad.
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                ' Determine whether the keystroke is a backspace.
                If e.KeyCode <> Keys.Back Then
                    ' A non-numerical keystroke was pressed. 
                    ' Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = True
                End If
            End If
        End If
    End Sub

    Private Sub tContPhone2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If nonNumberEntered And e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub


    Private Sub tContCell_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        nonNumberEntered = False
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            ' Determine whether the keystroke is a number from the keypad.
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                ' Determine whether the keystroke is a backspace.
                If e.KeyCode <> Keys.Back Then
                    ' A non-numerical keystroke was pressed. 
                    ' Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = True
                End If
            End If
        End If
    End Sub

    Private Sub UltraTextEditor2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If nonNumberEntered And e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub


    Private Sub UltraTextEditor2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bAddQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAddQuote.Click
        If tSerial.Text = "" Then
            MsgBox("You must be on a valid contact before you add a quote", MsgBoxStyle.Information, "Contact?")
            Exit Sub
        End If
        If CLng(tSerial.Text) = 0 Then
            MsgBox("You must be on a valid contact before you add a quote", MsgBoxStyle.Information, "Contact?")
            Exit Sub
        End If

        Dim fm As Form
        Dim fmOrd As fmEstOrd2
        For Each fm In MainForm.MdiChildren
            If fm.Tag = "Quotes/Orders" Then
                fmOrd = fm
                fmOrd.BringToFront()
                Exit For
            End If
        Next
        If fmOrd Is Nothing Then
            fmOrd = LoadForm("Quotes/Orders")
        End If
        If fmOrd.EditMode = "Edit" Or fmOrd.EditMode = "Add" Then
            MsgBox("You must not be in EDIT mode on the quote screen.", MsgBoxStyle.Information, "Edit?")
            Exit Sub
        End If


        fmOrd.ShowContactsOnAdd = False
        fmOrd.Add()

        fmOrd.tSold_Name.Text = tContName.Text
        fmOrd.tsold_company.Text = tContComp.Text
        fmOrd.tCountry.Text = tContCountry.Text
        fmOrd.UpdateCountry()
        fmOrd.tsold_addr1.Text = tContAddr1.Text
        fmOrd.tsold_addr2.Text = tContAddr2.Text
        fmOrd.tsold_addr3.Text = tContAddr3.Text
        fmOrd.tSold_City.Text = tContCity.Text
        fmOrd.tsold_state.Text = tContState.Text
        fmOrd.tsold_zip.Text = tContZip.Text
        fmOrd.tSoldCounty.Text = tContCounty.Text
        fmOrd.tSoldCounty.Text = ""
        If fmOrd.tSoldCounty.Text = "" Then
            fmOrd.LoadSoldCities()
            If fmOrd.tSold_City.Rows.Count > 0 Then
                fmOrd.tSoldCounty.Text = fmOrd.tSold_City.Rows(0).Cells(2).Text
            End If
        End If
        fmOrd.tsold_phone1.Value = CleanPhoneNumber(tContPhone.Text)
        fmOrd.tsold_email.Text = tContEmail.Text
        fmOrd.tsold_cell.Text = CleanPhoneNumber(tContCell.Text)
        fmOrd.tsold_fax.Text = CleanPhoneNumber(tContFax.Text)
        fmOrd.tord_for.Text = ""
        fmOrd.tOrdContSerial.Text = tSerial.Text

        fmOrd.UpdateSalesRep()


        fmOrd.Tab1.Tabs("Q0").Selected = True
        fmOrd.TabItems.Tabs("Shipping").Selected = True
        fmOrd.CopyShipAddress()
        fmOrd.GetGenTaxRate()

        If tContComp.Text = "" Then
            fmOrd.DVGen(0)("ord_gen_shiptotype") = "R"
        Else
            fmOrd.DVGen(0)("ord_gen_shiptotype") = "C"
        End If



        If gSource.Rows.Count > 0 Then fmOrd.DVGen(0)("ord_gen_src") = gSource.Rows(0).Cells("ord_src").Value
        fmOrd.TabItems.Tabs("Items").Selected = True
        fmOrd.DoTotal()
        fmOrd.tFieldConsultant.Value = nz2(tFieldConsult.Value, 14)

        'QuietMode = True
        'fmOrd.SplitOMatic(True)
        'QuietMode = False
    End Sub

    Private Sub bAddSrc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAddSrc.Click
        Dim fm As New fmAddSourceCode

        fm.Height = Me.Height * 0.9
        fm.ShowDialog()
        If fm.SrcCode <> "" Then
            Dim dr As DataRow
            dr = dtSrcCodes.NewRow
            dr("cont_src_serial") = 0
            dr("ord_src") = fm.SrcCode
            dr("ord_src_desc") = fm.SrcCodeDesc
            dtSrcCodes.Rows.Add(dr)
        End If
    End Sub

    Private Sub gSource_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gSource.ClickCellButton
        If Me.EditMode = "Add" Or Me.EditMode = "Edit" Then
            If e.Cell.Row.Appearance.FontData.Strikeout = Infragistics.Win.DefaultableBoolean.True Then
                e.Cell.Row.Appearance.FontData.Strikeout = Infragistics.Win.DefaultableBoolean.False
            Else
                e.Cell.Row.Appearance.FontData.Strikeout = Infragistics.Win.DefaultableBoolean.True
            End If
        End If
    End Sub

    Private Sub cbCatResRemove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCatResRemove.CheckedChanged
        If cbCatResRemove.Checked = True Then
            cbCatResEmail.Checked = False
            cbCatResMail.Checked = False
            cbCatResInQue.Checked = False
        End If
    End Sub

    Private Sub cbCatComRemove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCatComRemove.CheckedChanged
        If cbCatComRemove.Checked = True Then
            cbCatComEmail.Checked = False
            cbCatComMail.Checked = False
            cbCatComInQue.Checked = False
        End If
    End Sub

    Private Sub cbCatMatRemove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCatMatRemove.CheckedChanged
        If cbCatMatRemove.Checked = True Then
            cbCatMatEmail.Checked = False
            cbCatMatMail.Checked = False
            cbCatMatInQue.Checked = False
        End If
    End Sub

    Private Sub cbNotes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNotes.CheckedChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Me.ActiveControl.Name = "cbNotes" Then
            LoadNotes()
        End If
    End Sub

    Private Sub cbCatResEmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCatResEmail.CheckedChanged
        If cbCatResEmail.Checked Then
            cbCatResRemove.Checked = False
        End If
    End Sub

    Private Sub cbCatComEmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCatComEmail.CheckedChanged
        If cbCatComEmail.Checked Then
            cbCatComRemove.Checked = False
        End If
    End Sub

    Private Sub cbCatMatEmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCatMatEmail.CheckedChanged
        If cbCatMatEmail.Checked Then
            cbCatMatRemove.Checked = False
        End If
    End Sub

    Private Sub cbCatResMail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCatResMail.CheckedChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Not Me.ActiveControl Is cbCatResMail Then Exit Sub
        If cbCatResMail.Checked Then
            cbCatResRemove.Checked = False
            cbCatResInQue.Checked = True
        End If
    End Sub

    Private Sub cbCatComMail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCatComMail.CheckedChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Not Me.ActiveControl Is cbCatComMail Then Exit Sub
        If cbCatComMail.Checked Then
            cbCatComRemove.Checked = False
            cbCatComInQue.Checked = True
        End If
    End Sub

    Private Sub cbCatMatMail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCatMatMail.CheckedChanged
        If Me.ActiveControl Is Nothing Then Exit Sub
        If Not Me.ActiveControl Is cbCatMatMail Then Exit Sub
        If cbCatMatMail.Checked Then
            cbCatMatRemove.Checked = False
            cbCatMatInQue.Checked = True
        End If
    End Sub
    Private Sub EmailCatalogs()
        Dim oMailMsg As MailMessage
        Dim sHTMLBody As String = ""
        Dim avHTMLBody As AlternateView
        Dim oSMtPClient As SmtpClient
        Dim cmd As New SqlCommand("", cnn)
        Dim ol As New Outlook.Application
        Dim mess As Outlook.MailItem

        mess = ol.CreateItem(Outlook.OlItemType.olMailItem)
        mess.To = tContEmail.Text
        mess.Subject = "Wine Cellar Innovations Catalogs"




        'oMailMsg = New MailMessage
        'oMailMsg.From = New MailAddress("info@winecellarinnovations.com", "")
        'oMailMsg.To.Add(tContEmail.Text)
        'oMailMsg.Subject = "Wine Cellar Innovations Catalogs"

        sHTMLBody += "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>"
        sHTMLBody += "<html xmlns='http://www.w3.org/1999/xhtml'>"
        sHTMLBody += "<head>"
        sHTMLBody += "<meta http-equiv='Content-Type' content='text/html; charset=utf-8' />"
        sHTMLBody += "<title>Untitled Document</title>"
        sHTMLBody += "<style type='text/css'>"
        sHTMLBody += ".style2 .style2 {"
        sHTMLBody += "	font-family: Tahoma, Geneva, sans-serif;"
        sHTMLBody += "}"
        sHTMLBody += ".linksize {"
        sHTMLBody += "	font-size: 12px;"
        sHTMLBody += "	text-align: center;"
        sHTMLBody += "}"
        sHTMLBody += ".smtext {"
        sHTMLBody += "	font-family: Tahoma, Geneva, sans-serif;"
        sHTMLBody += "}"
        sHTMLBody += ".smtext {"
        sHTMLBody += "	font-size: 12px;"
        sHTMLBody += "}"
        sHTMLBody += ".text {"
        sHTMLBody += "	font-family: Tahoma, Geneva, sans-serif;"
        sHTMLBody += "}"
        sHTMLBody += ".texttl {"
        sHTMLBody += "	font-size: 14px;"
        sHTMLBody += "}"
        sHTMLBody += "</style>"
        sHTMLBody += "</head>"
        sHTMLBody += ""
        sHTMLBody += "<body>"
        sHTMLBody += "<style type='text/css'>"
        sHTMLBody += "    <!--"
        sHTMLBody += ".h1 {"
        sHTMLBody += "	font-family: Georgia, 'Times New Roman', Times, serif;"
        sHTMLBody += "	font-size: large;"
        sHTMLBody += "	font-style: normal;"
        sHTMLBody += "	font-weight: bold;"
        sHTMLBody += "	color: #755A2F;"
        sHTMLBody += "}"
        sHTMLBody += "#text {"
        sHTMLBody += "	position:absolute;"
        sHTMLBody += "	width:235px;"
        sHTMLBody += "	height:290px;"
        sHTMLBody += "	z-index:15;"
        sHTMLBody += "	left: 404px;"
        sHTMLBody += "	top: 225px;"
        sHTMLBody += "	background-color: #E6D8BF;"
        sHTMLBody += "	visibility: hidden;"
        sHTMLBody += "}"
        sHTMLBody += "a:link {"
        sHTMLBody += "	color: #962033;"
        sHTMLBody += "	text-decoration: none;"
        sHTMLBody += "}"
        sHTMLBody += "a:hover {"
        sHTMLBody += "	color: #962033;"
        sHTMLBody += "	text-decoration: underline;"
        sHTMLBody += "}"
        sHTMLBody += "a:visited {"
        sHTMLBody += "	color: #962033;"
        sHTMLBody += "	text-decoration: none;"
        sHTMLBody += "}"
        sHTMLBody += "a:active {"
        sHTMLBody += "	text-decoration: none;"
        sHTMLBody += "	color: #962033;"
        sHTMLBody += "}"
        sHTMLBody += "hr {color: #7B5B20; height: 1 pixels;}	"
        sHTMLBody += "a:link {"
        sHTMLBody += "	text-decoration: none;"
        sHTMLBody += "}"
        sHTMLBody += "a:hover {"
        sHTMLBody += "	text-decoration: underline;"
        sHTMLBody += "}"
        sHTMLBody += "a:visited {"
        sHTMLBody += "	text-decoration: none;"
        sHTMLBody += "}"
        sHTMLBody += "a:active {"
        sHTMLBody += "	text-decoration: none;"
        sHTMLBody += "}"
        sHTMLBody += ""
        sHTMLBody += "    .style3"
        sHTMLBody += "    {"
        sHTMLBody += "        text-decoration: underline;"
        sHTMLBody += "    }"
        sHTMLBody += ""
        sHTMLBody += "-->"
        sHTMLBody += "</style>"
        sHTMLBody += "<table width='800' align='center'>"
        sHTMLBody += "                <tbody>"
        sHTMLBody += "                    <tr>"
        sHTMLBody += "                        <td>"
        sHTMLBody += "                        <table width='100%'><tr><td>"
        sHTMLBody += "                            <a href='http://www.winecellarinnovations.com?ex=v0442e-yhhdw0-nbpvd0-ym8518'><img style='margin: 5px; float: left; border-width: 0px;' src='http://www.winecellarinnovations.com/wci-logo-opt.png' alt='wci-logo-opt.png' /></a><br />"
        sHTMLBody += "                            </td>"
        sHTMLBody += "                            <td>Wine Cellar Innovations<br />"
        sHTMLBody += "                                4575 Eastern Avenue<br />"
        sHTMLBody += "                                Cincinnati, OH 45226<br />"
        sHTMLBody += "                                Tel: 800-229-9813<br />"
        sHTMLBody += "                                Web: www.winecellarinnovations.com</td>"
        sHTMLBody += "                            <td>"
        sHTMLBody += "                                <img alt='' "
        sHTMLBody += "                                    src='http://www.winecellarinnovations.com/free-shipping-wood-wine-racks-CTA-3.png' /></td>"
        sHTMLBody += "                            </tr></table>"
        sHTMLBody += "                        </td>"
        sHTMLBody += "                    </tr>"
        sHTMLBody += "                    <tr>"
        sHTMLBody += "                        <td align='center'>"
        sHTMLBody += "                        <div style='text-align: left;'>"
        sHTMLBody += "                            Thank you for your interest in our product line! You may click on the catalog "
        sHTMLBody += "                            you would like to review. We have also provided some additional information that "
        sHTMLBody += "                            may be of use to you. Please do not hesitate to contact us if you need "
        sHTMLBody += "                            additional support!</div>"
        sHTMLBody += "                        <hr />"
        sHTMLBody += "                        <div>"
        sHTMLBody += "                        <table width='100%' cellpadding='10'>"
        sHTMLBody += "                          <tr>"
        sHTMLBody += "                            <td align='left'><span class='style3'>Residential catalog:<br />"
        sHTMLBody += "                                </span>Features custom and kit product lines for the home.<br />"
        sHTMLBody += "                              </td>"
        sHTMLBody += "                            <td align='left'><span class='style3'>Commercial catalog:<br />"
        sHTMLBody += "                                </span>Features custom and kit product lines for use in commercial wine "
        sHTMLBody += "                                displays.<br />"
        sHTMLBody += "                              </td>"
        sHTMLBody += "                            <td align='left'><span class='style3'>Materials catalog:<br />"
        sHTMLBody += "                                </span>Features the various material and stain options commonly requested.<br />"
        sHTMLBody += "                              </td>"
        sHTMLBody += "                          </tr>"
        sHTMLBody += "                          <tr>"
        sHTMLBody += "                            <td align='left'>"
        sHTMLBody += "                                <a href='http://www.winecellarinnovations.com/WCI-Retail-Catalog.pdf'><img alt='' src='http://www.winecellarinnovations.com/WCI-Retail-Catalog.jpg' /></a></td>"
        sHTMLBody += "                            <td align='left'>"
        sHTMLBody += "                                <a href='http://www.winecellarinnovations.com/WCI-Commercial-Catalog.pdf'><img alt='' src='http://www.winecellarinnovations.com/WCI-Commercial-Catalog.jpg' /></a></td>"
        sHTMLBody += "                            <td align='left'>"
        sHTMLBody += "                                <a href='http://www.winecellarinnovations.com/WCI-Materials-Catalog.pdf'><img alt='' src='http://www.winecellarinnovations.com/WCI-Materials-Catalog.jpg' /></a></td>"
        sHTMLBody += "                          </tr>"
        sHTMLBody += "                        </table>"
        sHTMLBody += "                        "
        sHTMLBody += "                        </div></td></tr>"
        sHTMLBody += "                        <tr><td><div><hr /></div></td></tr>"
        sHTMLBody += "                        <tr><td>"
        sHTMLBody += "                            <table>"
        sHTMLBody += "                              <tr>"
        sHTMLBody += "                                <td>"
        sHTMLBody += "                                    <img alt='' src='http://www.winecellarinnovations.com/jj-globe.jpg' /></td>"
        sHTMLBody += "                                <td><span class='style3'>Need someone to review the project at your location? We do "
        sHTMLBody += "                                    that for free! </span>"
        sHTMLBody += "                                    <br />"
        sHTMLBody += "                                    <br />"
        sHTMLBody += "                                    If you have a large space you are looking to convert for wine storage and would "
        sHTMLBody += "                                    like someone to come on site and assist you we have Design Consultants who "
        sHTMLBody += "                                    travel throughout the world that could assist. This is a free service as long as "
        sHTMLBody += "                                    they can schedule the trip while they are in your area.                                     <br />"
        sHTMLBody += "                                    <a href='http://www.winecellarinnovations.com/Consultant-Locator.htm'>"
        sHTMLBody += "                                    http://www.winecellarinnovations.com/Consultant-Locator.htm</a><br />"
        sHTMLBody += "                                  </td>"
        sHTMLBody += "                              </tr>"
        sHTMLBody += "                              <tr>"
        sHTMLBody += "                                <td>"
        sHTMLBody += "                                    <img alt='' src='http://www.winecellarinnovations.com/jj-hardhat.jpg' /></td>"
        sHTMLBody += "                                <td><span class='style3'>Need information on how to design or construct your wine cellar?"
        sHTMLBody += "                                    </span>"
        sHTMLBody += "                                    <br />"
        sHTMLBody += "                                    <br />"
        sHTMLBody += "                                    You can review our construction guile lines here:"
        sHTMLBody += "                                    <br />"
        sHTMLBody += "                                    <a href='http://www.winecellarinnovations.com/learn/how-to-build-a-wine-cellar.htm'>"
        sHTMLBody += "                                    http://www.winecellarinnovations.com/learn/how-to-build-a-wine-cellar.htm</a>"
        sHTMLBody += "                                    <br />"
        sHTMLBody += "                                    <br />"
        sHTMLBody += "                                    We offer a free design service for residential or commercial projects. Learn "
        sHTMLBody += "                                    more about it here:<br />"
        sHTMLBody += "                                    <br />"
        sHTMLBody += "                                    Commercial:&nbsp;&nbsp;"
        sHTMLBody += "                                    <a href='http://www.winecellarinnovations.com/commercialdesigns.htm'>"
        sHTMLBody += "                                    http://www.winecellarinnovations.com/commercialdesigns.htm</a>"
        sHTMLBody += "                                    <br />"
        sHTMLBody += "                                    Residential:&nbsp;&nbsp;&nbsp;&nbsp;"
        sHTMLBody += "                                    <a href='http://www.winecellarinnovations.com/design.htm'>"
        sHTMLBody += "                                    http://www.winecellarinnovations.com/design.htm</a></td>"
        sHTMLBody += "                              </tr>"
        sHTMLBody += "                            </table>"
        sHTMLBody += "                        </td></tr>"
        sHTMLBody += "                        <tr><td><div><hr /></div></td></tr>"
        sHTMLBody += "                        <tr><td>"
        sHTMLBody += "                            <a href='http://www.winecellarinnovations.com/Photo-and-Video-Galleries/'>"
        sHTMLBody += "                            <img alt='' "
        sHTMLBody += "                                src='http://www.winecellarinnovations.com/photo-video-home-slide-4.jpg' "
        sHTMLBody += "                                style='height: 335px; width: 789px; border-width: 0px' /></a></td></tr>"
        sHTMLBody += "                        <tr><td>"
        sHTMLBody += "                        <hr />"
        sHTMLBody += "                        "
        sHTMLBody += "                        "
        sHTMLBody += "                        <div style='text-align: center;'><a href='http://www.winecellarinnovations.com/sales-discounts/?ex=v0442e-yhhdw0-nbpvd0-15dc7mp'>"
        sHTMLBody += "                            <img src='http://www.winecellarinnovations.com/currentSpecialsBar.gif' "
        sHTMLBody += "                                alt='currentSpecialsBar.gif' "
        sHTMLBody += "                                style='margin: 5px; vertical-align: top; height: 98px; width: 766px;' "
        sHTMLBody += "                                border='0' /></a><br />"
        sHTMLBody += "                            </div>"
        sHTMLBody += "                        </td></tr>"
        sHTMLBody += "                        <tr><td>"
        sHTMLBody += "                        <hr />"
        sHTMLBody += "                        "
        sHTMLBody += "                            </td></tr>"
        sHTMLBody += "                        <tr><td align='left'>"
        sHTMLBody += "                        "
        sHTMLBody += "                            Visit us online: <a href='http://www.winecellarinnovations.com'>http://www.winecellarinnovations.com</a><br />"
        sHTMLBody += "                            <br />"
        sHTMLBody += "                            <strong>Stay Connected to Wine Cellar Innovations</strong><br />"
        sHTMLBody += "                            Join us on<br />"
        sHTMLBody += "                            <br />"
        sHTMLBody += "                            <a title='http://www.winecellarinnovations.com/blog/' href='http://www.winecellarinnovations.com/blog/' target='_blank'><span title='http://www.winecellarinnovations.com/blog/'><img src='http://www.winecellarinnovations.com/media/blog-social-img.gif' alt='View our Blog' id='_x0000_i1025' title='blog' /></span></a>"
        sHTMLBody += "                            <a title='http://twitter.com/WCICellars' href='http://twitter.com/WCICellars' target='_blank'><span title='http://twitter.com/WCICellars'><img style='vertical-align: middle; margin: 3px 5px; border-width: 0px; border-style: solid;' src='http://www.winecellarinnovations.com/media/twitter-social-img.gif' alt='twitter' name='_x0000_i1026' id='_x0000_i1026' title='http://twitter.com/WCICellars' /></span></a>"
        sHTMLBody += "                            <a title='http://www.facebook.com/WineCellarInnovations' href='http://www.facebook.com/WineCellarInnovations' target='_blank'><span title='http://www.facebook.com/pages/Wine-Cellar-Innovations/128485470477?ref=ts'><img style='vertical-align: middle; margin: 2px 5px; border-width: 0px; border-style: solid;' src='http://www.winecellarinnovations.com/media/facebook-social-img.gif' alt='Find us on Facebook' id='_x0000_i1025' title='http://www.facebook.com/pages/Wine-Cellar-Innovations/128485470477?ref=ts' /></span></a>"
        sHTMLBody += "                            <a target='_blank' href='http://www.youtube.com/winecellarinnovation'><img alt='' style='margin: 2px 5px; border-width: 0px; border-style: solid; vertical-align: middle;' src='http://www.winecellarinnovations.com//you-tube-social-img.png' /></a>"
        sHTMLBody += "                          </td>"
        sHTMLBody += "                        </tr>"
        sHTMLBody += "                        <tr><td><div><hr /></div></td></tr>"
        sHTMLBody += "                                <tr>"
        sHTMLBody += "                                    <td>"
        sHTMLBody += "                                    <a href='javascript:PopWindow(&quot;https://secure.campaigner.com/Campaigner/Public/Form10.aspx?fid=463152&quot;)'><img alt='' style='margin: 2px 10px; border-width: 0px; border-style: solid; float: left;' src='http://www.winecellarinnovations.com/media/email-social-img.gif' /></a><span class='smtext'>Would "
        sHTMLBody += "                                        you like to hear from us?<span style='font-size: 13px;'><br />"
        sHTMLBody += "                                    </span></span>"
        sHTMLBody += "<div id='emailOptInButton'><span class='smtext' style='font-size: 13px;'><a onclick='window.open('https://builder.campaigner.com/app/campaigner/services/optinlist/processoptinrequest.jsp?oilb=91320843&amp;builderType=paidl', 'OptInwin', 'height=420, width=420')' href='#'><strong>"
        sHTMLBody += "    Subscribe</strong></a> to receive quarterly emails from us, as well as important "
        sHTMLBody += "    announcements and sales info.</span><span class='smtext' style='font-size: 13px;'></span> "
        sHTMLBody += "                                    </div>"
        sHTMLBody += "                                    </td>"
        sHTMLBody += "                                </tr>"
        sHTMLBody += "                            </tbody>"
        sHTMLBody += "                        </table>"
        sHTMLBody += "                        "
        sHTMLBody += "                       <hr />"
        sHTMLBody += "                        <p style='font-family: Tahoma, Geneva, sans-serif; font-size: 10px; text-align: center;'>"
        sHTMLBody += "                            You have received this message because you requested more information from one "
        sHTMLBody += "                            of our representatives. If you would like to no longer receive emails from us, "
        sHTMLBody += "                            please send us an opt out request to <a href='mailto:optout@winecellarinnovations.com'>"
        sHTMLBody += "                            optout@winecellarinnovations.com</a>.</p>"
        sHTMLBody += "                        <p style='font-family: Tahoma, Geneva, sans-serif; font-size: 10px; text-align: center;'>"
        sHTMLBody += "                            Wine Cellar Innovations<br />"
        sHTMLBody += "                            4575 Eastern Avenue Cincinnati, OH 45226<br />"
        sHTMLBody += "                            Ph | 800.229.9813 </p>"
        sHTMLBody += "</body>"
        sHTMLBody += "</html>"


        'sHTMLBody = "<body style='font-family: Arial, Helvetica, sans-serif; font-size: 10pt' topmargin=0 leftmargin=0>"
        'sHTMLBody += "<img src='http://remote.winecellarinnovations.com/portal/images/header3.bmp'><br><br>"
        'sHTMLBody += "<table>"

        'If cbCatResEmail.Checked Then sHTMLBody += "<tr><td colspan=6><strong><a href='http://www.winecellarinnovations.com/March2011RetailCatalogWeb.pdf'>Residential Catalog</a></strong></td></tr>"
        'If cbCatComEmail.Checked Then sHTMLBody += "<tr><td colspan=6><strong><a href='http://www.winecellarinnovations.com/WCI_2007%20Commercial%20Catalog.pdf'>Commercial Catalog</a></strong></td></tr>"
        'If cbCatMatEmail.Checked Then sHTMLBody += "<tr><td colspan=6><strong><a href='http://www.winecellarinnovations.com/WCI_2008%20Materials%20Catalog.pdf'>Materials Catalog</a></strong></td></tr>"
        'sHTMLBody += "</table>"

        'sHTMLBody += "<P>Wine Cellar Innovations<BR>4575 Eastern Avenue<BR>Cincinnati, OH 45226<BR>800.229.9813<BR>513.321.3733</P><DIV>Visit us online : <A href='http://www.winecellarinnovations.com'>http://www.winecellarinnovations.com</A><br>"
        'sHTMLBody = AddLinksAtBottom(sHTMLBody)
        'sHTMLBody += "</body>"

        avHTMLBody = AlternateView.CreateAlternateViewFromString(sHTMLBody, Nothing, MediaTypeNames.Text.Html)

        mess.BodyFormat = Outlook.OlBodyFormat.olFormatHTML
        mess.HTMLBody = sHTMLBody
        'oMailMsg.AlternateViews.Add(avHTMLBody)
        mess.Display()
        'oSMtPClient = New SmtpClient(MailServer)
        'oSMtPClient.Send(oMailMsg)

        cmd.CommandText = "update cont_file set "
        If cbCatResEmail.Checked Then cmd.CommandText += "cont_cat_res_last_sent=getdate(),"
        If cbCatComEmail.Checked Then cmd.CommandText += "cont_cat_com_last_sent=getdate(),"
        If cbCatMatEmail.Checked Then cmd.CommandText += "cont_cat_mat_last_sent=getdate(),"
        cmd.CommandText = Mid(cmd.CommandText, 1, Len(cmd.CommandText) - 1)
        cmd.CommandText += " where cont_serial=" + KeyValue1
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        LoadSourceCodes()
        'MsgBox("Catalogs have been emailed", MsgBoxStyle.Information, "Emailed")
    End Sub

    Private Sub bReEmail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles bReEmail.LinkClicked
        If Me.EditMode = "Edit" Or Me.EditMode = "Add" Then
            MsgBox("You can not be in edit mode for this function", MsgBoxStyle.Critical, "Edit?")
            Exit Sub
        End If
        If MsgBox("This will send out the selected catalogs to the customer via email.  Do you want to proceed?", MsgBoxStyle.YesNo, "Email?") = MsgBoxResult.No Then Exit Sub
        If cbCatResEmail.Checked = False And cbCatComEmail.Checked = False And cbCatMatEmail.Checked = False Then
            MsgBox("You must pick at least on catalog to email", MsgBoxStyle.Critical, "Catalog?")
            Exit Sub
        End If
        EmailCatalogs()
    End Sub


    Private Sub tContCountry_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tContCountry.InitializeLayout

    End Sub

    Private Sub tContCountry_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tContCountry.ValueChanged
        UpdateCountry()
    End Sub

    Private Sub Tab1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles Tab1.SelectedTabChanged
        Select Case Tab1.SelectedTab.Key
            Case "Quote"
                LoadQuotesOrders()
            Case "Documents"
                LoadDocuments()
        End Select
    End Sub
    Private Sub LoadQuotesOrders()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim cmd As New SqlCommand("", cnn)
        Dim da As New SqlDataAdapter(cmd)

        If tSerial.Text <> "" Then
            cmd.CommandText = "select ord_serial as [Order], ord_for as [Reference] from ord_file where ord_cont_serial=" + tSerial.Text
            da.Fill(dt)
        End If
        Grid2.DataSource = dt
        Grid2.DataBind()
    End Sub

    Private Sub Grid2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid2.DoubleClick
        Dim fm As fmEstOrd2
        fm = LoadForm("Quotes/Orders")
        If fm.EditMode <> "" Then
            MsgBox("You must first save or cancel this Quote/Order", MsgBoxStyle.Information, "Save?")
            fm = Nothing
            Exit Sub
        End If
        fm.KeyValue1 = Grid2.ActiveRow.Cells("Order").Text
        fm.tOrd.Text = fm.KeyValue1
        fm.LoadPage()

    End Sub

    Private Sub Grid2_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid2.InitializeLayout
        '        http://www.winecellarinnovations.com/WCI-Retail-Catalog.pdf

        'http://www.winecellarinnovations.com/WCI-Commercial-Catalog.pdf

        'http://www.winecellarinnovations.com/WCI-Materials-Catalog.pdf

        '<a href='http://www.winecellarinnovations.com/March2011RetailCatalogWeb.pdf'><img alt='' src='http://www.winecellarinnovations.com/retail-catalog-2011.jpg' /></a></td>"
        'sHTMLBody += "                            <td align='left'>"
        'sHTMLBody += "                                <a href='http://www.winecellarinnovations.com/WCI_2007 Commercial Catalog.pdf'><img alt='' src='http://www.winecellarinnovations.com/commercial-2007.jpg' /></a></td>"
        'sHTMLBody += "                            <td align='left'>"
        'sHTMLBody += "                                <a href='http://www.winecellarinnovations.com/WCI_2008%20Materials%20Catalog.pdf'><img alt='' src='http://www.winecellarinnovations.com/materials-2008.jpg' /></a></td>"
        'sHTMLBody += "                         "


    End Sub

    Private Sub tContFax_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub UpdateCountry()
        Try
            If tContCountry.Text = "" Then Exit Sub
            Dim cnnx As New SqlConnection(cnn.ConnectionString + ";password='39201'")
            Dim cmd As New SqlCommand("select * from country_file where country_code='" + tContCountry.Text + "'", cnnx)
            Dim dr As SqlDataReader
            cnnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If dr("country_addr1") = 1 Then
                    tContAddr1.Visible = True
                    lContAddr1.Visible = True
                Else
                    tContAddr1.Text = ""
                    lContAddr1.Text = ""
                    tContAddr1.Visible = False
                End If
                If dr("country_addr2") = 1 Then
                    tContAddr2.Visible = True
                    lContAddr2.Visible = True
                Else
                    tContAddr2.Visible = False
                    lContAddr2.Visible = False
                    tContAddr2.Text = ""
                End If
                If dr("country_addr3") = 1 Then
                    tContAddr3.Visible = True
                    lContAddr3.Visible = True
                Else
                    tContAddr3.Visible = False
                    lContAddr3.Visible = False
                    tContAddr3.Text = ""
                End If
                If dr("country_city") = 1 Then
                    tContCity.Visible = True
                    lContCity.Visible = True
                Else
                    tContCity.Visible = False
                    lContCity.Visible = False
                    tContCity.Text = ""
                End If
                If dr("country_state") = 1 Then
                    tContState.Visible = True
                    lContState.Visible = True
                Else
                    tContState.Visible = False
                    lContState.Visible = False
                    tContState.Text = ""
                End If
                If dr("country_zip") = 1 Then
                    tContZip.Visible = True
                    lContZip.Visible = True
                Else
                    tContZip.Visible = False
                    lContZip.Visible = False
                    tContZip.Text = ""
                End If
                If dr("country_county") = 1 Then
                    tContCounty.Visible = True
                    lContCounty.Visible = True
                Else
                    tContCounty.Visible = False
                    lContCounty.Visible = False
                End If
                If dr("country_province") = 1 Then
                    tContProvince.Visible = True
                    lContProvince.Visible = True
                Else
                    tContProvince.Visible = False
                    lContProvince.Visible = False
                    tContProvince.Text = ""
                End If
                If Not dr("country_phone_mask") Is DBNull.Value Then
                    Dim onPhone As String

                    onPhone = tContPhone.Text
                    tContPhone.InputMask = dr("country_phone_mask")
                    tContPhone.Value = onPhone
                    tContPhone.Text = onPhone

                    onPhone = tContPhone2.Text
                    tContPhone2.InputMask = dr("country_phone_mask")
                    tContPhone2.Value = onPhone
                    tContPhone2.Text = onPhone

                    onPhone = tContFax.Text
                    tContFax.InputMask = dr("country_phone_mask")
                    tContFax.Value = onPhone
                    tContFax.Text = onPhone

                    'taltphone.InputMask = dr("country_phone_mask")

                    onPhone = tContCell.Text
                    tContCell.InputMask = dr("country_phone_mask")
                    tContCell.Value = onPhone
                    tContCell.Text = onPhone
                End If
            End If
            dr.Close()

            'cmd.CommandText = "select * from country_file where country_code='" + gsCountry.Text + "'"
            'dr = cmd.ExecuteReader
            'If dr.HasRows Then
            '    dr.Read()
            '    If Not dr("country_phone_mask") Is DBNull.Value Then
            '        gsPhone1.InputMask = dr("country_phone_mask")
            '        gsPhone2.InputMask = dr("country_phone_mask")
            '        gsCell.InputMask = dr("country_phone_mask")
            '        gsFax.InputMask = dr("country_phone_mask")
            '    End If
            'End If
            'dr.Close()

            cnnx.Close()

        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Private Sub tContZip_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tContZip.ValueChanged

    End Sub

    Private Sub tContState_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tContState.ValueChanged

    End Sub
    Private Sub LoadDocuments()
        ListPDF.Items.Clear()
        If tSerial.Text = "" Then Exit Sub
        Dim dr As String

        For Each dr In IO.Directory.GetDirectories(PDFPathContact, tSerial.Text + "*")
            LookPDFFiles(dr, True)
        Next

    End Sub
    Private Sub LookPDFDir(ByVal dirs As String, ByVal lev As Integer, Optional ByVal ShowAll As Boolean = False)
        If IO.Directory.Exists(dirs) = False Then Exit Sub
        Dim dr As String
        Dim sp As String = "*"

        If lev = 1 Then sp = tSerial.Text + "*"
        If lev = 0 And Microsoft.VisualBasic.Right(dirs, 8) = "Contacts" Then sp = tSerial.Text + "*"
        For Each dr In IO.Directory.GetDirectories(dirs, sp)
            If sp <> "*" Then 'lev = 1 Then
                LookPDFFiles(dr, ShowAll)
            Else
                If Microsoft.VisualBasic.Right(dr, 8) <> "\Catalog" Then
                    If lev < 1 Then LookPDFDir(dr, lev + 1, ShowAll)
                Else
                    If lev < 1 Then LookPDFDir(dr, lev, ShowAll)
                End If
            End If
        Next

    End Sub
    Private Sub LookPDFFiles(ByVal dr As String, Optional ByVal ShowAll As Boolean = False)
        Dim fl As String
        Dim id As Integer = 1

        For Each fl In IO.Directory.GetFiles(dr, "*")
            ListPDF.Items.Add(Mid(fl, Len(dr) + 2))
        Next
    End Sub
    Private Sub CheckPrimaryDirectory()
        Try
            If tSerial.Text = "" Then Exit Sub

            Dim dr As String
            Dim dirs As Array
            Dim sp As String = "*"

            dirs = IO.Directory.GetDirectories(PDFPathContact, tSerial.Text + " (" + tContName.Text + ")")
            If dirs.Length > 0 Then Exit Sub

            dirs = IO.Directory.GetDirectories(PDFPathContact, tSerial.Text + "*")
            If dirs.Length = 0 Then
                IO.Directory.CreateDirectory(PDFPathContact + tSerial.Text + " (" + tContName.Text + ")")
            Else
                For Each dr In dirs
                    If IO.Path.GetFileName(dr) <> tSerial.Text + " (" + tContName.Text + ")" Then
                        Rename(dr, IO.Path.GetDirectoryName(dr) + "\" + tSerial.Text + " (" + tContName.Text + ")")
                    Else
                    End If
                Next
            End If
        Catch
            If QuietMode = False Then MsgBox("Directory will not be renamed with the proper Contact Name due to files being opened", MsgBoxStyle.Information, "Contact Name Rename?")
        End Try

    End Sub

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        If ListPDF.Items.Count > 0 Then
            Dim cl As String = "C:\Program Files\Internet Explorer\IEXPLORE.EXE " + IO.Path.GetDirectoryName(PDFPathContact + ListPDF.Items.Item(0))
            Shell(cl, AppWinStyle.NormalFocus)
        Else
            CheckPrimaryDirectory()
            Dim cl As String = "C:\Program Files\Internet Explorer\IEXPLORE.EXE " + PDFPathContact + tSerial.Text + " (" + tContName.Text + ")"
            Shell(cl, AppWinStyle.NormalFocus)
        End If
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Dim app As New Outlook.Application
        Dim mailx As Outlook.MailItem
        Dim itm As String

        Try
            mailx = app.CreateItem(Outlook.OlItemType.olMailItem)
            For Each itm In ListPDF.SelectedItems
                mailx.Attachments.Add(PDFPathContact + tSerial.Text + " (" + tContName.Text + ")\" + itm)
            Next
            mailx.Display()
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Private Sub bOpenPdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOpenPdf.Click
        Try
            Dim hwnd As Long
            Dim myProc As Process
            Dim itm As Object

            For Each itm In ListPDF.SelectedItems
                myProc = New Process

                myProc.StartInfo.FileName = PDFPathContact + tSerial.Text + " (" + tContName.Text + ")\" + itm
                myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                myProc.Start()
            Next
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Private Sub bDocPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDocPrint.Click
        Try
            Dim hwnd As Long
            Dim myProc As Process
            Dim itm As Object

            For Each itm In ListPDF.SelectedItems
                myProc = New Process

                myProc.StartInfo.UseShellExecute = True
                myProc.StartInfo.CreateNoWindow = False
                myProc.StartInfo.FileName = PDFPathContact + tSerial.Text + " (" + tContName.Text + ")\" + itm
                myProc.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                myProc.StartInfo.Verb = "Print"
                myProc.Start()
                'myProc.WaitForExit(15000)
                Try
                    myProc.CloseMainWindow()
                    myProc.Close()
                Catch
                    'MsgBox(Err.Description)
                End Try
                myProc = Nothing
            Next
        Catch
            DoError(Err, Me)
        End Try

    End Sub

    Private Sub tContName_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tContName.Enter
        onName = tContName.Text
    End Sub

    Private Sub tContName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tContName.Leave
        If onName <> tContName.Text Then NameChanged = True
    End Sub

    Private Sub tContName_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tContName.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Tab1.Tabs(3).Selected = True
        LoadContacts()
    End Sub

    Private Sub LoadContacts()
        Dim dt As New DataTable
        Dim rw As DataRow
        Dim TempStr(1) As String
        Dim TempNode As ListViewItem
        Dim cmd As New SqlCommand("", cnn)
        Dim da As New SqlDataAdapter(cmd)

        cnn.Open()
        cmd.CommandText = "select cont_name,cont_city,cont_state from duplicatecontacts order by cont_name"
        da.Fill(dt)
        Label10.Text = dt.Rows.Count
        cnn.Close()

        ListView1.Columns.Clear()
        ListView1.View = View.Details

        ListView1.Columns.Add("Name", 120)
        ListView1.Columns.Add("City", 160)
        ListView1.Columns.Add("State", 60)

        Try
            Dim ls As ListViewItem
            For Each rw In dt.Rows
                ls = ListView1.Items.Add(rw("cont_name"))
                ls.SubItems.Add(nz(rw("cont_city")))
                ls.SubItems.Add(nz(rw("cont_state")))
            Next
        Catch
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Dim dt As New DataTable
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim dr As DataRow
        Dim cmd As New SqlCommand("", cnn)
        Dim da As New SqlDataAdapter(cmd)
        Try


            dt.Clear()
            cnn.Open()
            cmd.CommandText = "select cont_serial,cont_name,cont_company,cont_addr1,cont_city,cont_state,cont_zip,cont_type from cont_file where cont_name='" + ListView1.SelectedItems(0).Text.ToString + "' and cont_city='" + ListView1.SelectedItems(0).SubItems(1).Text.ToString + "' and cont_state='" + ListView1.SelectedItems(0).SubItems(2).Text.ToString + "'"
            da.Fill(dt)
            dt.Columns.Add("notes")
            dt.Columns.Add("orders")
            For Each dr In dt.Rows
                cmd.CommandText = "select cont_note_cont_serial from cont_note where cont_note_cont_serial=" + dr("cont_serial").ToString
                da.Fill(dt1)
                dr("notes") = nz(dt1.Rows.Count).ToString

                cmd.CommandText = "select ord_cont_serial from ord_file where ord_cont_serial=" + dr("cont_serial").ToString
                da.Fill(dt2)
                dr("orders") = nz(dt2.Rows.Count).ToString
            Next
            cnn.Close()
            UltraGrid1.DataSource = dt
            UltraGrid1.DataBind()
            Dim col As Infragistics.Win.UltraWinGrid.UltraGridColumn
            col = UltraGrid1.DisplayLayout.Bands(0).Columns.Add("Merge")
            col.DataType = GetType(System.Boolean)
            col.DefaultCellValue = False
            col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
            col.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
            Me.UltraGrid1.DisplayLayout.Bands("Merge").Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True

            UltraGrid1.Selected.Rows.Clear()
        Catch
            'MsgBox(Err.Description)
            cnn.Close()
        End Try
    End Sub

    Private Sub UltraGrid1_AfterCellActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterCellActivate
        KeyValue1 = UltraGrid1.ActiveRow.Cells("cont_serial").Value
        LoadFields(Me)
        LoadNotes()
        LoadSourceCodes()
        LoadQuotesOrders()
        LoadDocuments()
        EditButtons("Idle")
    End Sub

    Private Sub tFieldConsult_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tFieldConsult.InitializeLayout
        e.Layout.Bands(0).Columns(0).Hidden = True
        e.Layout.Bands(0).Columns(1).Header.Caption = "Consultant"
        e.Layout.Bands(0).Columns(1).Width = 150
    End Sub
End Class
