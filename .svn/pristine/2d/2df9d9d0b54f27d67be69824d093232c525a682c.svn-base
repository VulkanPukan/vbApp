Imports Microsoft.Office.Interop
Imports Infragistics.Win
Imports Infragistics.Win.Misc
Imports Infragistics.Win.UltraWinGrid

Public Class fmImportItems
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bLoadGrid As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents pAdmins As System.Windows.Forms.Panel
    Friend WithEvents ddDealer As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tFilter As System.Windows.Forms.TextBox
    Dim dtItems As New DataTable
    Dim msmtch As Boolean = False
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tDate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lExcel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Button1 = New System.Windows.Forms.Button
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Button2 = New System.Windows.Forms.Button
        Me.tDate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lExcel = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tFilter = New System.Windows.Forms.TextBox
        Me.ddDealer = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.pAdmins = New System.Windows.Forms.Panel
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.bLoadGrid = New System.Windows.Forms.Button
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ddDealer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pAdmins.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Load File"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid1.Location = New System.Drawing.Point(129, 3)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(920, 693)
        Me.Grid1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(2, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Import Items"
        '
        'tDate
        '
        Me.tDate.Location = New System.Drawing.Point(2, 51)
        Me.tDate.Name = "tDate"
        Me.tDate.Size = New System.Drawing.Size(100, 20)
        Me.tDate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Active Date"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Beige
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lExcel)
        Me.Panel1.Location = New System.Drawing.Point(151, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 47)
        Me.Panel1.TabIndex = 6
        Me.Panel1.Visible = False
        '
        'lExcel
        '
        Me.lExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lExcel.Location = New System.Drawing.Point(16, 16)
        Me.lExcel.Name = "lExcel"
        Me.lExcel.Size = New System.Drawing.Size(288, 24)
        Me.lExcel.TabIndex = 0
        Me.lExcel.Text = "Reading Excel Line: 0"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.tFilter)
        Me.Panel2.Controls.Add(Me.ddDealer)
        Me.Panel2.Controls.Add(Me.pAdmins)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.bLoadGrid)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Grid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1052, 700)
        Me.Panel2.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 508)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Exact: PART"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Ends With: %PART"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 482)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "In Middle: %PART%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 469)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Starts With: PART%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 454)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Filter"
        '
        'tFilter
        '
        Me.tFilter.Location = New System.Drawing.Point(5, 432)
        Me.tFilter.Name = "tFilter"
        Me.tFilter.Size = New System.Drawing.Size(100, 20)
        Me.tFilter.TabIndex = 13
        '
        'ddDealer
        '
        Me.ddDealer.CheckedListSettings.CheckStateMember = ""
        Appearance4.BackColor = System.Drawing.SystemColors.Window
        Appearance4.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ddDealer.DisplayLayout.Appearance = Appearance4
        Me.ddDealer.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ddDealer.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance1.BorderColor = System.Drawing.SystemColors.Window
        Me.ddDealer.DisplayLayout.GroupByBox.Appearance = Appearance1
        Appearance2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ddDealer.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance2
        Me.ddDealer.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance3.BackColor2 = System.Drawing.SystemColors.Control
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ddDealer.DisplayLayout.GroupByBox.PromptAppearance = Appearance3
        Me.ddDealer.DisplayLayout.MaxColScrollRegions = 1
        Me.ddDealer.DisplayLayout.MaxRowScrollRegions = 1
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddDealer.DisplayLayout.Override.ActiveCellAppearance = Appearance12
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ddDealer.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.ddDealer.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ddDealer.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Me.ddDealer.DisplayLayout.Override.CardAreaAppearance = Appearance6
        Appearance5.BorderColor = System.Drawing.Color.Silver
        Appearance5.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ddDealer.DisplayLayout.Override.CellAppearance = Appearance5
        Me.ddDealer.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ddDealer.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ddDealer.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance11.TextHAlignAsString = "Left"
        Me.ddDealer.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.ddDealer.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ddDealer.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.BorderColor = System.Drawing.Color.Silver
        Me.ddDealer.DisplayLayout.Override.RowAppearance = Appearance10
        Me.ddDealer.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ddDealer.DisplayLayout.Override.TemplateAddRowAppearance = Appearance8
        Me.ddDealer.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ddDealer.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ddDealer.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ddDealer.Location = New System.Drawing.Point(5, 379)
        Me.ddDealer.Name = "ddDealer"
        Me.ddDealer.NullText = "Retail"
        Me.ddDealer.Size = New System.Drawing.Size(108, 22)
        Me.ddDealer.TabIndex = 12
        '
        'pAdmins
        '
        Me.pAdmins.Controls.Add(Me.Button1)
        Me.pAdmins.Controls.Add(Me.tDate)
        Me.pAdmins.Controls.Add(Me.Button2)
        Me.pAdmins.Controls.Add(Me.Label1)
        Me.pAdmins.Location = New System.Drawing.Point(0, 10)
        Me.pAdmins.Name = "pAdmins"
        Me.pAdmins.Size = New System.Drawing.Size(128, 194)
        Me.pAdmins.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(5, 545)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 24)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Export to Excel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Dealer"
        '
        'bLoadGrid
        '
        Me.bLoadGrid.Location = New System.Drawing.Point(2, 333)
        Me.bLoadGrid.Name = "bLoadGrid"
        Me.bLoadGrid.Size = New System.Drawing.Size(112, 41)
        Me.bLoadGrid.TabIndex = 7
        Me.bLoadGrid.Text = "Load Grid From Database"
        '
        'fmImportItems
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1052, 700)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "fmImportItems"
        Me.Text = "fmImportItems"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ddDealer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pAdmins.ResumeLayout(False)
        Me.pAdmins.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fb As New OpenFileDialog
        fb.Filter = "Text Files (*.xls)|*.xls"
        If fb.ShowDialog = DialogResult.OK Then
            Dim ex As New Excel.Application
            Dim fl As Excel.Workbook
            Dim sh As Excel.Worksheet
            Dim rg As Excel.Range
            Dim rw As Integer
            Dim data As Object(,)

            Dim x As Integer = 0

            Panel1.Visible = True
            fl = ex.Workbooks.Open(fb.FileName)
            sh = fl.Sheets(1)
            data = sh.Range("A1", sh.Cells(sh.UsedRange.Rows.Count, sh.UsedRange.Columns.Count + 1)).Value
            For rw = 1 To sh.UsedRange.Rows.Count
                lExcel.Text = "Reading Excel Line: " + CStr(rw) + " of " + CStr(sh.UsedRange.Rows.Count)
                Application.DoEvents()
                If data(rw, 1) = "Dealer" Or data(rw, 1) = "Dealer Code" Then

                Else
                    ReadRowNew(rw, data)
                End If

            Next

            Grid1.DataSource = ds.Tables(0)
            Panel1.Visible = False
            ex.Workbooks.Close()
            ex = Nothing
            If msmtch = True Then
                MsgBox("There are items in Red that have the same Item and Unstained codes." + vbCrLf + "Fix before importing.")
            End If
        End If
    End Sub
    Private Sub ReadRow(ByRef rw As Integer, ByRef sh As Excel.Worksheet)
        Dim rg As Excel.Range
        Dim x As Integer = 0
        Dim ln As String

        Dim dr As DataRow = ds.Tables(0).NewRow
        rg = sh.Cells(rw, x)
        dr("dealer") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("item") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("desc") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("parent") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("unstained") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("height") = Trim(Replace(rg.Value, """", ""))
        x += 1
        rg = sh.Cells(rw, x)
        dr("depth") = Trim(Replace(rg.Value, """", ""))
        x += 1
        rg = sh.Cells(rw, x)
        dr("width") = Trim(Replace(rg.Value, """", ""))
        x += 1
        rg = sh.Cells(rw, x)
        If nz(dr("height")) = "" Then dr("height") = "null"
        If nz(dr("depth")) = "" Then dr("depth") = "null"
        If nz(dr("width")) = "" Then dr("width") = "null"

        If Split(ln, vbTab).Length > x Then
            dr("weight") = Trim(Replace(rg.Value, """", ""))
            If dr("weight") = "" Then dr("weight") = "null"
        End If

        x += 1
        rg = sh.Cells(rw, x)
        dr("btl_capacity") = Replace(Replace(Replace(rg.Value, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("act") = Replace(Replace(Replace(rg.Value, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("base") = Replace(Replace(Replace(rg.Value, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("retail") = Replace(Replace(Replace(rg.Value, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("con") = Replace(Replace(Replace(rg.Value, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("md") = Replace(Replace(Replace(rg.Value, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("ship") = Replace(Replace(Replace(rg.Value, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("flatrate") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("shipflatrate") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("product type") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("wood type") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("class") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("taxable") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("qty from") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("qty to") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("start") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("end") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("ship from") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("ship to") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("ship start") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("ship end") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("inactive") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("change price") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("change base") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("allow 0") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("change material") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("stain bottles") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("lacquer bottles") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("wood factor") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("price track") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("stain") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("groupno") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("install_min") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("install_from") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("install_to") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("install_start") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("install_end") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("add_art") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("notes") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("is disc") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("disc perc") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("disc prod") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("disc matl") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("is up") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("up perc") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("up prod") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)
        dr("up matl") = Replace(rg.Value, """", "")
        x += 1
        rg = sh.Cells(rw, x)


        If nz(dr("item")) <> "" Then ds.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub ReadRowNew(ByRef rw As Integer, ByRef sh As Array)
        Dim rg As String
        Dim x As Integer = 1
        Dim ln As String

        Dim dr As DataRow = ds.Tables(0).NewRow
        rg = sh(rw, x)
        dr("dealer") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("item") = Trim(Replace(rg, """", ""))
        x += 1
        rg = sh(rw, x)
        dr("desc") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("parent") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("unstained") = Trim(Replace(rg, """", ""))
        x += 1
        rg = sh(rw, x)
        dr("height") = Trim(Replace(rg, """", ""))
        x += 1
        rg = sh(rw, x)
        dr("depth") = Trim(Replace(rg, """", ""))
        x += 1
        rg = sh(rw, x)
        dr("width") = Trim(Replace(rg, """", ""))
        x += 1
        rg = sh(rw, x)
        dr("weight") = Trim(Replace(rg, """", ""))
        If nz(dr("height")) = "" Then dr("height") = "null"
        If nz(dr("depth")) = "" Then dr("depth") = "null"
        If nz(dr("width")) = "" Then dr("width") = "null"
        If dr("weight") = "" Then dr("weight") = "null"

        If Split(ln, vbTab).Length > x Then
            dr("weight") = Trim(Replace(rg, """", ""))
            If dr("weight") = "" Then dr("weight") = "null"
        End If

        x += 1
        rg = sh(rw, x)
        dr("btl_capacity") = Replace(Replace(Replace(rg, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh(rw, x)
        dr("act") = Replace(Replace(Replace(rg, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh(rw, x)
        dr("base") = Replace(Replace(Replace(rg, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh(rw, x)
        dr("retail") = Replace(Replace(Replace(rg, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh(rw, x)
        dr("con") = Replace(Replace(Replace(rg, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh(rw, x)
        dr("md") = Replace(Replace(Replace(rg, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh(rw, x)
        dr("ship") = Replace(Replace(Replace(rg, """", ""), "$", ""), ",", "")
        x += 1
        rg = sh(rw, x)
        If rg = "False" Then rg = "0"
        If rg = "True" Then rg = "1"
        dr("flatrate") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        If rg = "False" Then rg = "0"
        If rg = "True" Then rg = "1"
        dr("shipflatrate") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("product type") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("wood type") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("class") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        If rg = "False" Then rg = "0"
        If rg = "True" Then rg = "1"
        dr("taxable") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("qty from") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("qty to") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("start") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("end") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("ship from") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("ship to") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("ship start") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("ship end") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        If rg = "False" Then rg = "0"
        If rg = "True" Then rg = "1"
        dr("inactive") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        If rg = "False" Then rg = "0"
        If rg = "True" Then rg = "1"
        dr("change price") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        If rg = "False" Then rg = "0"
        If rg = "True" Then rg = "1"
        dr("change base") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        If rg = "False" Then rg = "0"
        If rg = "True" Then rg = "1"
        dr("allow 0") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        If rg = "False" Then rg = "0"
        If rg = "True" Then rg = "1"
        dr("change material") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("stain bottles") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("lacquer bottles") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("wood factor") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("price track") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("stain") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("groupno") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("install_min") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("install_from") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("install_to") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("install_start") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("install_end") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("notes") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        If rg = "False" Then rg = "0"
        If rg = "True" Then rg = "1"
        dr("is disc") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("disc perc") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("disc prod") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("disc matl") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        If rg = "False" Then rg = "0"
        If rg = "True" Then rg = "1"
        dr("is up") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("up perc") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("up prod") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        dr("up matl") = Replace(rg, """", "")
        x += 1
        rg = sh(rw, x)
        If rg = "False" Then rg = "0"
        If rg = "True" Then rg = "1"
        dr("add_art") = Replace(rg, """", "")


        If nz(dr("item")) <> "" Then ds.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub Button1Saved()
        Dim fb As New OpenFileDialog
        fb.Filter = "Text Files (*.txt)|*.txt"
        If fb.ShowDialog = DialogResult.OK Then
            Dim fl As New IO.StreamReader(fb.FileName)
            Dim ln As String
            Dim x As Integer = 0

            Do
                ln = fl.ReadLine
                x = 0
                If ln Is Nothing Then Exit Do
                If Split(ln, vbTab).Length < 5 Then
                    ln = ln + vbCrLf + fl.ReadLine
                End If
                If Split(ln, vbTab).Length < 5 Then
                    ln = ln + vbCrLf + fl.ReadLine
                End If
                If Split(ln, vbTab).Length < 5 Then
                    ln = ln + vbCrLf + fl.ReadLine
                End If
                If Split(ln, vbTab).Length < 5 Then
                    ln = ln + vbCrLf + fl.ReadLine
                End If

                Dim dr As DataRow = ds.Tables(0).NewRow
                If Split(ln, vbTab).Length > x Then dr("dealer") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("item") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("desc") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("parent") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("unstained") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("height") = Trim(Replace(Split(ln, vbTab)(x), """", ""))
                x += 1
                If Split(ln, vbTab).Length > x Then dr("depth") = Trim(Replace(Split(ln, vbTab)(x), """", ""))
                x += 1
                If Split(ln, vbTab).Length > x Then dr("width") = Trim(Replace(Split(ln, vbTab)(x), """", ""))
                x += 1
                If nz(dr("height")) = "" Then dr("height") = "null"
                If nz(dr("depth")) = "" Then dr("depth") = "null"
                If nz(dr("width")) = "" Then dr("width") = "null"
                If Split(ln, vbTab).Length > x Then
                    dr("weight") = Trim(Replace(Split(ln, vbTab)(x), """", ""))
                    If dr("weight") = "" Then dr("weight") = "null"
                End If
                x += 1
                If Split(ln, vbTab).Length > x Then dr("btl_capacity") = Replace(Replace(Replace(Split(ln, vbTab)(x), """", ""), "$", ""), ",", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("act") = Replace(Replace(Replace(Split(ln, vbTab)(x), """", ""), "$", ""), ",", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("base") = Replace(Replace(Replace(Split(ln, vbTab)(x), """", ""), "$", ""), ",", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("retail") = Replace(Replace(Replace(Split(ln, vbTab)(x), """", ""), "$", ""), ",", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("con") = Replace(Replace(Replace(Split(ln, vbTab)(x), """", ""), "$", ""), ",", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("md") = Replace(Replace(Replace(Split(ln, vbTab)(x), """", ""), "$", ""), ",", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("ship") = Replace(Replace(Replace(Split(ln, vbTab)(x), """", ""), "$", ""), ",", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("flatrate") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("shipflatrate") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("product type") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("wood type") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("class") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("taxable") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("qty from") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("qty to") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("start") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("end") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("ship from") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("ship to") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("ship start") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("ship end") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("inactive") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("change price") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("change base") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("allow 0") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("change material") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("stain bottles") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("lacquer bottles") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("wood factor") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("price track") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("stain") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("groupno") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("install_min") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("install_from") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("install_to") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("install_start") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("install_end") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("add_art") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("notes") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("is disc") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("disc perc") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("disc prod") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("disc matl") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("is up") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("up perc") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("up prod") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1
                If Split(ln, vbTab).Length > x Then dr("up matl") = Replace(Split(ln, vbTab)(x), """", "")
                x += 1


                If nz(dr("item")) <> "" Then ds.Tables(0).Rows.Add(dr)
            Loop Until ln Is Nothing

            Grid1.DataSource = ds.Tables(0)
        End If
    End Sub
    Private Sub fmImportItems_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = ds.Tables.Add("items")
        dt.Columns.Add("dealer")
        dt.Columns.Add("item")
        dt.Columns.Add("desc")
        dt.Columns.Add("parent")
        dt.Columns.Add("unstained")
        dt.Columns.Add("height")
        dt.Columns.Add("width")
        dt.Columns.Add("depth")
        dt.Columns.Add("weight")
        dt.Columns.Add("btl_capacity")
        dt.Columns.Add("act")
        dt.Columns.Add("base")
        dt.Columns.Add("retail")
        dt.Columns.Add("con")
        dt.Columns.Add("md")
        dt.Columns.Add("ship")
        dt.Columns.Add("flatrate")
        dt.Columns.Add("shipflatrate")
        dt.Columns.Add("product type")
        dt.Columns.Add("wood type")
        dt.Columns.Add("class")
        dt.Columns.Add("taxable")
        dt.Columns.Add("qty from")
        dt.Columns.Add("qty to")
        dt.Columns.Add("start")
        dt.Columns.Add("end")
        dt.Columns.Add("ship from")
        dt.Columns.Add("ship to")
        dt.Columns.Add("ship start")
        dt.Columns.Add("ship end")
        dt.Columns.Add("inactive")
        dt.Columns.Add("change price")
        dt.Columns.Add("change base")
        dt.Columns.Add("allow 0")
        dt.Columns.Add("change material")
        dt.Columns.Add("stain bottles")
        dt.Columns.Add("lacquer bottles")
        dt.Columns.Add("wood factor")
        dt.Columns.Add("price track")
        dt.Columns.Add("stain")
        dt.Columns.Add("groupno")
        dt.Columns.Add("install_min")
        dt.Columns.Add("install_from")
        dt.Columns.Add("install_to")
        dt.Columns.Add("install_start")
        dt.Columns.Add("install_end")
        dt.Columns.Add("notes")
        dt.Columns.Add("is disc")
        dt.Columns.Add("disc perc")
        dt.Columns.Add("disc prod")
        dt.Columns.Add("disc matl")
        dt.Columns.Add("is up")
        dt.Columns.Add("up perc")
        dt.Columns.Add("up prod")
        dt.Columns.Add("up matl")
        dt.Columns.Add("add_art")

        'dtItems.Columns.Add("cust_itm_price_cust_id")
        'dtItems.Columns.Add("itm_code")
        'dtItems.Columns.Add("itm_desc")
        'dtItems.Columns.Add("itm_parent_code")
        'dtItems.Columns.Add("itm_unstained_itm_code")
        'dtItems.Columns.Add("itm_height")
        'dtItems.Columns.Add("itm_width")
        'dtItems.Columns.Add("itm_depth")
        'dtItems.Columns.Add("itm_weight")
        'dtItems.Columns.Add("itm_bottle_capacity")
        'dtItems.Columns.Add("act")
        'dtItems.Columns.Add("base")
        'dtItems.Columns.Add("retail")
        'dtItems.Columns.Add("con")
        'dtItems.Columns.Add("md")
        'dtItems.Columns.Add("ship")
        'dtItems.Columns.Add("flatrate")
        'dtItems.Columns.Add("shipflatrate")
        'dtItems.Columns.Add("product type")
        'dtItems.Columns.Add("wood type")
        'dtItems.Columns.Add("class")
        'dtItems.Columns.Add("taxable")
        'dtItems.Columns.Add("qty from")
        'dtItems.Columns.Add("qty to")
        'dtItems.Columns.Add("start")
        'dtItems.Columns.Add("end")
        'dtItems.Columns.Add("ship from")
        'dtItems.Columns.Add("ship to")
        'dtItems.Columns.Add("ship start")
        'dtItems.Columns.Add("ship end")
        'dtItems.Columns.Add("inactive")
        'dtItems.Columns.Add("change price")
        'dtItems.Columns.Add("change base")
        'dtItems.Columns.Add("allow 0")
        'dtItems.Columns.Add("change material")
        'dtItems.Columns.Add("stain bottles")
        'dtItems.Columns.Add("lacquer bottles")
        'dtItems.Columns.Add("wood factor")
        'dtItems.Columns.Add("price track")
        'dtItems.Columns.Add("stain")
        'dtItems.Columns.Add("groupno")
        'dtItems.Columns.Add("install_min")
        'dtItems.Columns.Add("install_from")
        'dtItems.Columns.Add("install_to")
        'dtItems.Columns.Add("install_start")
        'dtItems.Columns.Add("install_end")
        'dtItems.Columns.Add("notes")
        'dtItems.Columns.Add("is disc")
        'dtItems.Columns.Add("disc perc")
        'dtItems.Columns.Add("disc prod")
        'dtItems.Columns.Add("disc matl")
        'dtItems.Columns.Add("is up")
        'dtItems.Columns.Add("up perc")
        'dtItems.Columns.Add("up prod")
        'dtItems.Columns.Add("up matl")
        'dtItems.Columns.Add("add_art")

        tDate.Text = DateAdd(DateInterval.Day, 1, Today)

        If UserGroup <> "Admins" Then pAdmins.Visible = False

        LoadDD2(ddDealer, "cust_file", "cust_id", "cust_id", "cust_id", "inactive <> 1")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dr As DataRow
        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim sqlx As String = ""
        Dim onNote As String = ""
        Dim LastPart As String = ""
        Dim onCust, onStain As Long
        Dim itms As String

        Try
            Button2.Enabled = False

            For Each dr In ds.Tables(0).Rows
                If dr.RowState <> DataRowState.Deleted Then
                    If nz(dr("item")) = nz(dr("parent")) Then
                        MsgBox("You can not have the Parent Code the same as the Item Code for item " + dr("item"))
                        Button2.Enabled = True
                        Exit Sub
                    End If
                End If
            Next

            cnn.Open()
            For Each dr In ds.Tables(0).Rows
                If dr.RowState <> DataRowState.Deleted Then
                    If nz(dr("stain")) <> "" Then
                        cmd.CommandText = "select stain_serial from stain_file where stain_name='" + dr("stain") + "'"
                        onStain = nz(cmd.ExecuteScalar, 0)
                    Else
                        onStain = 0
                    End If
                    If Trim(dr("item")) <> "" Then
                        If InStr(itms, dr("item") + ",") = 0 Then itms += "'" + dr("item") + "',"
                        If Trim(nz(dr("dealer"), "")) = "" Then
                            sqlx = ""
                            cmd.CommandText = "select count(itm_code) as cnt from itm_file where itm_code='" + Trim(dr("item")) + "'"
                            If cmd.ExecuteScalar = 0 Then
                                If nz(dr("is disc")) = "" Then dr("is disc") = "0"
                                If nz(dr("is up")) = "" Then dr("is up") = "0"
                                If nz(dr("disc perc")) = "" Then dr("disc perc") = "0"
                                If nz(dr("up perc")) = "" Then dr("up perc") = "0"
                                If nz(dr("wood factor")) = "" Then dr("wood factor") = "1"
                                If nz(dr("taxable")) = "" Then dr("taxable") = "1"
                                If nz(dr("add_art")) = "" Then dr("add_art") = "0"
                                If nz(dr("shipflatrate")) = "" Then dr("shipflatrate") = "0"
                                If nz(dr("btl_capacity")) = "" Then dr("btl_capacity") = "0"

                                cmd.CommandText = "insert into itm_file (itm_code,itm_desc,itm_height,itm_depth,itm_width,itm_weight,itm_prod_type,itm_material,inactive,itm_allow_0_base_price,itm_material_sel,itm_stain_bottles,itm_lacquer_bottles,itm_wood_factor,itm_price_track_inches,itm_stain_serial,itm_group,itm_note,last_update,update_by,itm_disc,itm_disc_def_perc,itm_disc_def_matl,itm_disc_def_prod,itm_up,itm_up_def_perc,itm_up_def_matl,itm_up_def_prod,itm_change_price,itm_change_base_price,itm_flat_rate,itm_taxable,itm_additional_art,itm_parent_code,itm_class,itm_bottle_capacity) values ('" + Trim(nz(dr("item"))) + "','" + Replace(nz(dr("desc")), "'", "''") + "'," + nz(dr("height")) + "," + nz(dr("depth")) + "," + nz(dr("width")) + "," + nz(dr("weight"), "0") + ",'" + nz(dr("product type")) + "','" + nz(dr("wood type")) + "'," + nz(dr("inactive"), "0") + "," + nz(dr("allow 0"), "0") + "," + nz(dr("change material"), "0") + "," + nz(dr("stain bottles"), "0") + "," + nz(dr("lacquer bottles"), "0") + "," + nz(dr("wood factor"), "1") + "," + nz(dr("price track"), "0") + "," + CStr(onStain) + ",'" + nz(dr("groupno")) + "','" + Replace(nz(dr("notes")), "'", "''") + "','" + CStr(Now) + "','IMP-" + User + "'," + nz(dr("is disc"), "0") + "," + nz(dr("disc perc"), "0") + ",'" + nz(dr("disc matl"), "") + "','" + nz(dr("disc prod"), "") + "'," + nz(dr("is up"), "0") + "," + nz(dr("up perc"), "0") + ",'" + nz(dr("up matl"), "") + "','" + nz(dr("up prod"), "") + "'," + nz(dr("change price"), 0) + "," + nz(dr("change base"), 0) + "," + nz(dr("flatrate"), 0) + "," + dr("taxable") + "," + dr("add_art") + ",'" + dr("parent") + "','" + dr("class") + "'," + dr("btl_capacity") + ")"
                                cmd.ExecuteNonQuery()

                                cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','ACT'," + nz(dr("qty from"), "1") + "," + nz(dr("qty to"), "999999") + "," + nz(dr("act"), "0") + ",'" + dr("start") + "','" + dr("end") + "',0,'" + CStr(Now) + "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','BASE'," + nz(dr("qty from"), "1") + "," + nz(dr("qty to"), "999999") + "," + nz(dr("base"), "0") + ",'" + dr("start") + "','" + dr("end") + "',0,'" + CStr(Now) + "')"
                                cmd.ExecuteNonQuery()
                                If IsDate(dr("start")) And nz(dr("RETAIL")) <> "" Then
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','RET'," + nz(dr("qty from"), "1") + "," + nz(dr("qty to"), "999999") + "," + nz(dr("retail"), "0") + ",'" + dr("start") + "','" + dr("end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If
                                If IsDate(dr("start")) And nz(dr("CON")) <> "" Then
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','CON'," + nz(dr("qty from"), "1") + "," + nz(dr("qty to"), "999999") + "," + nz(dr("con"), "0") + ",'" + dr("start") + "','" + dr("end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If
                                If IsDate(dr("start")) And nz(dr("MD")) <> "" Then
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','MD'," + nz(dr("qty from"), "1") + "," + nz(dr("qty to"), "999999") + "," + nz(dr("md"), "0") + ",'" + dr("start") + "','" + dr("end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If
                                If IsDate(dr("start")) And nz(dr("SHIP")) <> "" Then
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','SHIP'," + nz(dr("ship from"), "1") + "," + nz(dr("ship to"), "999999") + "," + nz(dr("ship"), "0") + ",'" + dr("ship start") + "','" + dr("ship end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If
                                If IsDate(dr("install_start")) And nz(dr("install_min")) <> "" Then
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','Install'," + nz(dr("install_from"), "1") + "," + nz(dr("install_to"), "999999") + "," + nz(dr("install_min"), "0") + ",'" + dr("install_start") + "','" + dr("install_end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If
                            Else
                                If nz(dr("desc")) <> "" Then sqlx += "itm_desc='" + Replace(dr("desc"), "'", "''") + "',"
                                If nz(dr("height")) <> "" Then sqlx += "itm_height=" + dr("height") + ","
                                If nz(dr("depth")) <> "" Then sqlx += "itm_depth=" + dr("depth") + ","
                                If nz(dr("width")) <> "" Then sqlx += "itm_width=" + dr("width") + ","
                                If nz(dr("weight")) <> "" Then sqlx += "itm_weight=" + dr("weight") + ","
                                If nz(dr("btl_capacity")) <> "" Then sqlx += "itm_bottle_capacity=" + dr("btl_capacity") + ","
                                If nz(dr("product type")) <> "" Then sqlx += "itm_prod_type='" + dr("product type") + "',"
                                If nz(dr("wood type")) <> "" Then sqlx += "itm_material='" + dr("wood type") + "',"
                                If nz(dr("taxable")) <> "" Then sqlx += "itm_taxable='" + dr("taxable") + "',"
                                If nz(dr("inactive")) <> "" Then sqlx += "inactive=" + dr("inactive") + ","
                                If nz(dr("change price")) <> "" Then sqlx += "itm_change_price=" + dr("change price") + ","
                                If nz(dr("change base")) <> "" Then sqlx += "itm_change_base_price=" + dr("change base") + ","
                                If nz(dr("allow 0")) <> "" Then sqlx += "itm_allow_0_base_price=" + dr("allow 0") + ","
                                If nz(dr("change material")) <> "" Then sqlx += "itm_material_sel=" + dr("change material") + ","
                                If nz(dr("stain bottles")) <> "" Then sqlx += "itm_stain_bottles=" + dr("stain bottles") + ","
                                If nz(dr("lacquer bottles")) <> "" Then sqlx += "itm_lacquer_bottles=" + dr("lacquer bottles") + ","
                                If nz(dr("wood factor")) <> "" Then sqlx += "itm_wood_factor=" + dr("wood factor") + ","
                                If nz(dr("price track")) <> "" Then sqlx += "itm_price_track_inches=" + dr("price track") + ","
                                If onStain <> 0 Then sqlx += "itm_stain_serial=" + CStr(onStain) + ","
                                sqlx += "itm_group='" + dr("groupno") + "',"
                                If nz(dr("notes")) <> "" Then
                                    cmd.CommandText = "select itm_note from itm_file where itm_code='" + Trim(dr("item")) + "'"
                                    onNote = nz(cmd.ExecuteScalar)
                                    If onNote = "" Then
                                        sqlx += "itm_note = '" + Replace(dr("notes"), "'", "''") + "',"
                                    Else
                                        sqlx += "itm_note = '" + Replace(onNote + vbCrLf + dr("notes"), "'", "''") + "',"
                                    End If
                                End If
                                If nz(dr("is disc")) <> "" Then sqlx += "itm_disc=" + dr("is disc") + ","
                                If nz(dr("disc perc")) <> "" Then sqlx += "itm_disc_def_perc=" + dr("disc perc") + ","
                                If nz(dr("disc prod")) <> "" Then sqlx += "itm_disc_def_prod='" + Replace(dr("disc prod"), "'", "''") + "',"
                                If nz(dr("disc matl")) <> "" Then sqlx += "itm_disc_def_matl='" + Replace(dr("disc matl"), "'", "''") + "',"
                                If nz(dr("is up")) <> "" Then sqlx += "itm_up=" + dr("is up") + ","
                                If nz(dr("up perc")) <> "" Then sqlx += "itm_up_def_perc=" + dr("up perc") + ","
                                If nz(dr("up prod")) <> "" Then sqlx += "itm_up_def_prod='" + Replace(dr("up prod"), "'", "''") + "',"
                                If nz(dr("up matl")) <> "" Then sqlx += "itm_up_def_matl='" + Replace(dr("up matl"), "'", "''") + "',"
                                If nz(dr("add_art")) <> "" Then sqlx += "itm_additional_art=" + dr("add_art") + ","
                                If nz(dr("flatrate")) <> "" Then sqlx += "itm_flat_rate=" + dr("flatrate") + ","
                                If nz(dr("parent")) <> "" Then sqlx += "itm_parent_code='" + dr("parent") + "',"
                                If nz(dr("class")) <> "" Then sqlx += "itm_class='" + dr("class") + "',"
                                If Len(sqlx) > 1 Then
                                    sqlx = Mid(sqlx, 1, Len(sqlx) - 1)
                                    cmd.CommandText = "update itm_file set " + sqlx + " where itm_code='" + Trim(dr("item")) + "'"
                                    cmd.ExecuteNonQuery()
                                End If

                                If IsDate(dr("start")) And nz(dr("ACT")) <> "" Then
                                    cmd.CommandText = "update itm_price set itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "',itm_price_updated='" + CStr(Now) + "' where itm_price_itm_code='" + dr("item") + "' and itm_price_type='ACT' and itm_price_end>='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "'"
                                    If dr("item") <> LastPart Then cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','ACT'," + nz(dr("qty from"), "1") + "," + nz(dr("qty to"), "999999") + "," + nz(dr("act"), "0") + ",'" + dr("start") + "','" + dr("end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If

                                If IsDate(dr("start")) And nz(dr("BASE")) <> "" Then
                                    cmd.CommandText = "update itm_price set itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "',itm_price_updated='" + CStr(Now) + "' where itm_price_itm_code='" + dr("item") + "' and itm_price_type='BASE' and itm_price_end>='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "'"
                                    If dr("item") <> LastPart Then cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','BASE'," + nz(dr("qty from"), "1") + "," + nz(dr("qty to"), "999999") + "," + nz(dr("base"), "0") + ",'" + dr("start") + "','" + dr("end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If

                                If IsDate(dr("start")) And nz(dr("RETAIL")) <> "" Then
                                    cmd.CommandText = "update itm_price set itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "',itm_price_updated='" + CStr(Now) + "' where itm_price_itm_code='" + dr("item") + "' and itm_price_type='RET' and itm_price_end>='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "'"
                                    If dr("item") <> LastPart Then cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','RET'," + nz(dr("qty from"), "1") + "," + nz(dr("qty to"), "999999") + "," + nz(dr("retail"), "0") + ",'" + dr("start") + "','" + dr("end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If

                                If IsDate(dr("start")) And nz(dr("CON")) <> "" Then
                                    cmd.CommandText = "update itm_price set itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "',itm_price_updated='" + CStr(Now) + "' where itm_price_itm_code='" + dr("item") + "' and itm_price_type='CON' and itm_price_end>='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "'"
                                    If dr("item") <> LastPart Then cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','CON'," + nz(dr("qty from"), "1") + "," + nz(dr("qty to"), "999999") + "," + nz(dr("con"), "0") + ",'" + dr("start") + "','" + dr("end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If

                                If IsDate(dr("start")) And nz(dr("MD")) <> "" Then
                                    cmd.CommandText = "update itm_price set itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "',itm_price_updated='" + CStr(Now) + "' where itm_price_itm_code='" + dr("item") + "' and itm_price_type='MD' and itm_price_end>='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "'"
                                    If dr("item") <> LastPart Then cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','MD'," + nz(dr("qty from"), "1") + "," + nz(dr("qty to"), "999999") + "," + nz(dr("md"), "0") + ",'" + dr("start") + "','" + dr("end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If

                                If IsDate(dr("ship start")) And nz(dr("SHIP")) <> "" Then
                                    cmd.CommandText = "update itm_price set itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("ship start")))) + "',itm_price_updated='" + CStr(Now) + "' where itm_price_itm_code='" + dr("item") + "' and itm_price_type='SHIP' and itm_price_end>='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("ship start")))) + "'"
                                    If dr("item") <> LastPart Then cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','SHIP'," + nz(dr("ship from"), "1") + "," + nz(dr("ship to"), "999999") + "," + nz(dr("ship"), "0") + ",'" + dr("ship start") + "','" + dr("ship end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If

                                If IsDate(dr("ship start")) And nz(dr("shipflatrate")) <> "" Then
                                    cmd.CommandText = "update itm_price set itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("ship start")))) + "',itm_price_updated='" + CStr(Now) + "' where itm_price_itm_code='" + dr("item") + "' and itm_price_type='SHIP' and itm_price_end>='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("ship start")))) + "'"
                                    If dr("item") <> LastPart Then cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_flat_rate,itm_price_created) values ('" + Trim(dr("item")) + "','SHIP'," + nz(dr("ship from"), "1") + "," + nz(dr("ship to"), "999999") + "," + nz(dr("ship"), "0") + ",'" + dr("ship start") + "','" + dr("ship end") + "',0," + dr("shipflatrate") + ",'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If

                                If IsDate(dr("install_start")) And nz(dr("install_min")) <> "" Then
                                    cmd.CommandText = "update itm_price set itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("install_start")))) + "',itm_price_updated='" + CStr(Now) + "' where itm_price_itm_code='" + dr("item") + "' and itm_price_type='Install' and itm_price_end>='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("install_start")))) + "'"
                                    If dr("item") <> LastPart Then cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_created) values ('" + Trim(dr("item")) + "','Install'," + nz(dr("install_from"), "1") + "," + nz(dr("install_to"), "999999") + "," + nz(dr("install_min"), "0") + ",'" + dr("install_start") + "','" + dr("install_end") + "',0,'" + CStr(Now) + "')"
                                    cmd.ExecuteNonQuery()
                                End If

                            End If
                            If nz(dr("parent")) <> "" Then
                                cnn.Close()
                                UpdateChild(dr("parent"), Trim(dr("item")))
                                cnn.Open()
                            End If
                            LastPart = dr("item")
                        Else
                            If IsDate(dr("start")) And nz(dr("BASE")) <> "" Then
                                cmd.CommandText = "select cust_serial from cust_file where cust_id='" + dr("dealer") + "'"
                                onCust = nz(cmd.ExecuteScalar, -1)
                                If onCust <> -1 Then
                                    cmd.CommandText = "update cust_itm_price set cust_itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "' where cust_itm_price_cust_serial=" + CStr(onCust) + " and cust_itm_price_itm_code='" + dr("item") + "' and cust_itm_price_end>='" + CStr(DateAdd(DateInterval.Day, -1, CDate(dr("start")))) + "' and cust_itm_price_start<>'" + dr("start") + "'"
                                    cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_cust_id,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_price,cust_itm_price_start,cust_itm_price_end) values (" + CStr(onCust) + ",'" + dr("dealer") + "','" + Trim(dr("item")) + "'," + nz(dr("qty from"), "1") + "," + nz(dr("qty to"), "999999") + "," + nz(dr("base"), "0") + ",'" + dr("start") + "','" + dr("end") + "')"
                                    cmd.ExecuteNonQuery()
                                Else
                                    MsgBox(dr("dealer") + " customer code not found.", MsgBoxStyle.Critical, "Customer Code?")
                                End If
                            End If
                        End If
                    End If
                    If nz(dr("unstained")) <> "" Then
                        If (UCase(dr("unstained")) <> UCase(dr("item"))) And InStr(UCase(dr("item")), "-UN-") = 0 Then
                            cmd.CommandText = "select count(*) from itm_stain where itm_unstained_itm_code='" + UCase(dr("unstained")) + "' and itm_stained_itm_code='" + UCase(dr("item")) + "'"
                            If nz(cmd.ExecuteScalar, 0) = 0 Then
                                cmd.CommandText = "delete from itm_stain where itm_stained_itm_code='" + UCase(dr("item")) + "'"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into itm_stain (itm_stained_type,itm_unstained_itm_code,itm_stained_itm_code,itm_stained_start,itm_stained_end) values ("
                                cmd.CommandText += "'" + nz(dr("product type")) + "',"
                                cmd.CommandText += "'" + UCase(dr("unstained")) + "',"
                                cmd.CommandText += "'" + UCase(dr("item")) + "',"
                                cmd.CommandText += "'1/1/1900',"
                                cmd.CommandText += "'12/31/2099')"
                                cmd.ExecuteNonQuery()
                            End If
                        Else

                        End If
                    End If
                End If
            Next
            If Len(itms) > 0 Then
                Dim msg As String = ""
                Dim drd As SqlClient.SqlDataReader

                itms = Mid(itms, 1, Len(itms) - 1)
                cmd.CommandText = "select * from itm_price where itm_price_itm_code in (" + itms + ") and itm_price_price=0 and itm_price_end > '" + CStr(Today) + "'"
                drd = cmd.ExecuteReader
                Do While drd.Read
                    msg += drd("itm_price_itm_code") + " is set to $0.00 for " + drd("itm_price_type") + vbCrLf
                Loop
                drd.Close()
                If msg <> "" Then
                    msg += vbCrLf + "Hit YES to send to the printer, otherwise hit NO."
                    MsgBox(msg, MsgBoxStyle.YesNo, "Items Set to $0.00")
                End If
            End If
            MsgBox("Import Complete")
        Catch
            MsgBox(Err.Description + vbCrLf + cmd.CommandText)
        Finally
            cnn.Close()
            Button2.Enabled = True
        End Try
    End Sub

    Private Sub bLoadGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLoadGrid.Click
        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dr As DataRow

        bLoadGrid.Enabled = False
        ds.Tables("items").Clear()

        'dt.Columns.Add("install_from")
        'dt.Columns.Add("install_to")
        'dt.Columns.Add("install_start")
        'dt.Columns.Add("install_end")

        If ddDealer.Text = "" Then
            'cmd.CommandText = "select distinct '' as dealer,itm_code as item,itm_desc as [desc],itm_parent_code as parent,itm_height as height,itm_width as width,itm_depth as depth"
            'cmd.CommandText += ",itm_weight as weight, itm_bottle_capacity as btl_capacity,itm_prod_type as [product type],itm_material as [wood type],itm_taxable as taxable,inactive,itm_change_price as [change price]"
            'cmd.CommandText += ",itm_change_base_price as [change base],itm_allow_0_base_price as [allow 0],itm_material_sel as [change material],itm_stain_bottles as [stain bottles],itm_lacquer_bottles as [lacquer bottles]"
            'cmd.CommandText += ",itm_wood_factor as [wood factor],itm_price_track_inches as [price track],itm_disc as [is disc],itm_disc_def_perc as [disc perc],itm_disc_def_prod as [disc prod],itm_disc_def_matl as [disc matl]"
            'cmd.CommandText += ",itm_up as [is up],itm_up_def_perc as [up perc],itm_up_def_prod as [up prod],itm_up_def_matl as [up matl],itm_additional_art as [add_art],itm_flat_rate as flatrate,itm_class as class"
            'cmd.CommandText += ",itm_price_qty_from as [qty from],itm_price_qty_to as [qty to], itm_price_start as [start], itm_price_end as [end]"
            'cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='BASE' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as base"
            'cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='RET' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as retail"
            'cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='CON' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as con"
            'cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='MD' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as md"
            'cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='SHIP' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as ship"
            'cmd.CommandText += ",(select top 1 itm_price_flat_rate from itm_price where itm_price_itm_code=itm_code and itm_price_type='SHIP' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as shipflatrate"
            'cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='ACT' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as act"
            'cmd.CommandText += ",(select top 1 itm_unstained_itm_code from itm_stain where itm_stained_itm_code=itm_code and itm_stained_start<=getdate() and itm_stained_end>=getdate()) as unstained"
            'cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='Install' and itm_price_start<=getdate() and itm_price_end>=getdate() order by itm_price_end) as install_min"
            'cmd.CommandText += " from itm_file left outer join itm_price as itm_price1 on itm_code=itm_price_itm_code where inactive<>1 and itm_price_start<=getdate() and itm_price_end>=getdate() and itm_price_type<>'Install' order by itm_code"


            cmd.CommandText = "select distinct '' as dealer,stain_name as stain,itm_code as item,itm_desc as [desc],itm_parent_code as parent,itm_height as height,itm_width as width,itm_depth as depth"
            cmd.CommandText += ",itm_weight as weight, itm_bottle_capacity as btl_capacity,itm_prod_type as [product type],itm_material as [wood type],itm_taxable as taxable,inactive,itm_change_price as [change price]"
            cmd.CommandText += ",itm_change_base_price as [change base],itm_allow_0_base_price as [allow 0],itm_material_sel as [change material],itm_stain_bottles as [stain bottles],itm_lacquer_bottles as [lacquer bottles]"
            cmd.CommandText += ",itm_wood_factor as [wood factor],itm_price_track_inches as [price track],itm_disc as [is disc],itm_disc_def_perc as [disc perc],itm_disc_def_prod as [disc prod],itm_disc_def_matl as [disc matl]"
            cmd.CommandText += ",itm_up as [is up],itm_up_def_perc as [up perc],itm_up_def_prod as [up prod],itm_up_def_matl as [up matl],itm_additional_art as [add_art],itm_flat_rate as flatrate,itm_class as class"
            cmd.CommandText += ",itm_price_qty_from as [qty from],itm_price_qty_to as [qty to], '" + CStr(Today) + "' as [start], '12/31/2099' as [end]"
            cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='BASE' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as base"
            cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='RET' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as retail"
            cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='CON' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as con"
            cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='MD' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as md"

            cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='SHIP' and itm_price_qty_from<=itm_price1.itm_price_qty_from and itm_price_qty_to>=itm_price1.itm_price_qty_from and itm_price_start<=getdate() and itm_price_end>=getdate()) as ship"
            cmd.CommandText += ",(select top 1 itm_price_qty_from from itm_price where itm_price_itm_code=itm_code and itm_price_type='SHIP' and itm_price_qty_from<=itm_price1.itm_price_qty_from and itm_price_qty_to>=itm_price1.itm_price_qty_from and itm_price_start<=getdate() and itm_price_end>=getdate()) as [ship from]"
            cmd.CommandText += ",(select top 1 itm_price_qty_to from itm_price where itm_price_itm_code=itm_code and itm_price_type='SHIP' and itm_price_qty_from<=itm_price1.itm_price_qty_from and itm_price_qty_to>=itm_price1.itm_price_qty_from and itm_price_start<=getdate() and itm_price_end>=getdate()) as [ship to]"
            cmd.CommandText += ",'" + CStr(Today) + "' as [ship start]"
            cmd.CommandText += ",'12/31/2099' as [ship end]"

            cmd.CommandText += ",(select top 1 itm_price_flat_rate from itm_price where itm_price_itm_code=itm_code and itm_price_type='SHIP' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as shipflatrate"
            cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='ACT' and itm_price_qty_from=itm_price1.itm_price_qty_from and itm_price_qty_to=itm_price1.itm_price_qty_to and itm_price_start<=getdate() and itm_price_end>=getdate()) as act"
            cmd.CommandText += ",(select top 1 itm_unstained_itm_code from itm_stain where itm_stained_itm_code=itm_code and itm_stained_start<=getdate() and itm_stained_end>=getdate()) as unstained"

            cmd.CommandText += ",(select top 1 itm_price_price from itm_price where itm_price_itm_code=itm_code and itm_price_type='Install' and itm_price_start<=getdate() and itm_price_end>=getdate() order by itm_price_end) as install_min"
            cmd.CommandText += ",(select top 1 itm_price_qty_from from itm_price where itm_price_itm_code=itm_code and itm_price_type='Install' and itm_price_start<=getdate() and itm_price_end>=getdate() order by itm_price_end) as install_from"
            cmd.CommandText += ",(select top 1 itm_price_qty_to from itm_price where itm_price_itm_code=itm_code and itm_price_type='Install' and itm_price_start<=getdate() and itm_price_end>=getdate() order by itm_price_end) as install_to"
            cmd.CommandText += ",(select top 1 itm_price_start from itm_price where itm_price_itm_code=itm_code and itm_price_type='Install' and itm_price_start<=getdate() and itm_price_end>=getdate() order by itm_price_end) as install_start"
            cmd.CommandText += ",(select top 1 itm_price_end from itm_price where itm_price_itm_code=itm_code and itm_price_type='Install' and itm_price_start<=getdate() and itm_price_end>=getdate() order by itm_price_end) as install_end"

            cmd.CommandText += " from itm_file left outer join itm_price as itm_price1 on itm_code=itm_price_itm_code left outer join stain_file on itm_file.itm_stain_serial = stain_file.stain_serial where inactive<>1 and itm_price_start<=getdate() and itm_price_end>=getdate() and itm_price_type<>'Install' " + IIf(tFilter.Text = "", "", "and itm_code like '" + tFilter.Text + "'") + " order by itm_code"
            cnn.Open()
            cmd.CommandTimeout = 50000
            da.Fill(ds.Tables("items"))

            cnn.Close()

            Grid1.DataSource = ds.Tables("items")
            Grid1.DataBind()
        Else
            cmd.CommandText = "select distinct '" + ddDealer.Text + "' as dealer,itm_code as item,itm_desc as [desc],itm_parent_code as parent,itm_height as height,itm_width as width,itm_depth as depth"
            cmd.CommandText += ",itm_weight as weight, itm_bottle_capacity as btl_capacity,itm_prod_type as [product type],itm_material as [wood type],itm_taxable as taxable,inactive,itm_change_price as [change price]"
            cmd.CommandText += ",itm_change_base_price as [change base],itm_allow_0_base_price as [allow 0],itm_material_sel as [change material],itm_stain_bottles as [stain bottles],itm_lacquer_bottles as [lacquer bottles]"
            cmd.CommandText += ",itm_wood_factor as [wood factor],itm_price_track_inches as [price track],itm_disc as [is disc],itm_disc_def_perc as [disc perc],itm_disc_def_prod as [disc prod],itm_disc_def_matl as [disc matl]"
            cmd.CommandText += ",itm_up as [is up],itm_up_def_perc as [up perc],itm_up_def_prod as [up prod],itm_up_def_matl as [up matl],itm_additional_art as [add_art],itm_flat_rate as flatrate,itm_class as class"
            cmd.CommandText += ",cust_itm_price_from as [qty from],cust_itm_price_to as [qty to], cust_itm_price_start as [start], cust_itm_price_end as [end]"
            cmd.CommandText += ",(select top 1 cust_itm_price_price from cust_itm_price where cust_itm_price_cust_id='" + ddDealer.Text + "' and cust_itm_price_itm_code=itm_code and cust_itm_price_from=itm_price1.cust_itm_price_from and cust_itm_price_to=itm_price1.cust_itm_price_to and cust_itm_price_start<=getdate() and cust_itm_price_end>=getdate()) as base"
            cmd.CommandText += ",(select top 1 itm_unstained_itm_code from itm_stain where itm_stained_itm_code=itm_code and itm_stained_start<=getdate() and itm_stained_end>=getdate()) as unstained"
            cmd.CommandText += " from itm_file left outer join cust_itm_price as itm_price1 on itm_code=cust_itm_price_itm_code where inactive<>1 and cust_itm_price_start<=getdate() and cust_itm_price_end>=getdate() and itm_price1.cust_itm_price_cust_id='" + ddDealer.Text + "' order by itm_code"
            cnn.Open()
            cmd.CommandTimeout = 50000
            da.Fill(ds.Tables("items"))

            cnn.Close()

            Grid1.DataSource = ds.Tables("items")
            Grid1.DataBind()
        End If
        bLoadGrid.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        If IO.Directory.Exists("c:\temp\") = False Then IO.Directory.CreateDirectory("c:\temp\")
        UltraGridExcelExporter1.Export(Grid1, "c:\temp\temp.xls")
        System.Diagnostics.Process.Start("c:\temp\temp.xls")
        Button3.Enabled = True
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub Grid1_InitializeRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles Grid1.InitializeRow
        If e.Row.Cells("item").Value <> "" Then
            Try
                If nz(e.Row.Cells("item").Value) = nz(e.Row.Cells("unstained").Value) Then
                    e.Row.Cells("item").Appearance.BackColor = Color.LightCoral
                    e.Row.Cells("unstained").Appearance.BackColor = Color.LightCoral
                    e.Row.Appearance.BackColor = Color.Yellow
                    msmtch = True
                End If
            Catch
            End Try
        End If
    End Sub
End Class
