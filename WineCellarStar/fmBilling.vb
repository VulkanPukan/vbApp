Imports System.Data.SqlClient
Public Class fmBilling
    Inherits WineCellar.fmStarter
    Dim dsList As New DataSet
    Dim dsBillDay As New DataSet
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
    Friend WithEvents chSummary As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents bPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tBillDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents tBillDay As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents tNote As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_company")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_ord_serial")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_rev")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cust_terms")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_balance")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_sold_cust_serial")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Print", 0)
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.bPrint = New Infragistics.Win.Misc.UltraButton
        Me.chSummary = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.tBillDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.tBillDay = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.tNote = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBillDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBillDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn2.Header.Caption = "Company"
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Width = 196
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn3.Header.Caption = "Order"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn3.Width = 154
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn4.Header.Caption = "Revision"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Width = 153
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn5.Header.Caption = "Terms"
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 148
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance1
        UltraGridColumn6.Format = "$###,###,##0.00"
        UltraGridColumn6.Header.Caption = "Balance"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 148
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 105
        UltraGridColumn8.DataType = GetType(Boolean)
        UltraGridColumn8.DefaultCellValue = True
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Disallow
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn8.Width = 31
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(8, 48)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(832, 432)
        Me.Grid1.TabIndex = 0
        '
        'bPrint
        '
        Me.bPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPrint.Location = New System.Drawing.Point(16, 488)
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Size = New System.Drawing.Size(192, 32)
        Me.bPrint.TabIndex = 1
        Me.bPrint.Text = "Print Invoices"
        '
        'chSummary
        '
        Me.chSummary.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chSummary.Checked = True
        Me.chSummary.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chSummary.Location = New System.Drawing.Point(224, 496)
        Me.chSummary.Name = "chSummary"
        Me.chSummary.Size = New System.Drawing.Size(144, 16)
        Me.chSummary.TabIndex = 2
        Me.chSummary.Text = "Print Summary Pages"
        '
        'UltraButton1
        '
        Me.UltraButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton1.Location = New System.Drawing.Point(544, 488)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(112, 32)
        Me.UltraButton1.TabIndex = 3
        Me.UltraButton1.Text = "Clear All"
        '
        'UltraButton2
        '
        Me.UltraButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton2.Location = New System.Drawing.Point(664, 488)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(112, 32)
        Me.UltraButton2.TabIndex = 4
        Me.UltraButton2.Text = "Select All"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel1.TabIndex = 5
        Me.UltraLabel1.Text = "Bill Date"
        '
        'tBillDate
        '
        Me.tBillDate.Location = New System.Drawing.Point(80, 8)
        Me.tBillDate.Name = "tBillDate"
        Me.tBillDate.Size = New System.Drawing.Size(120, 21)
        Me.tBillDate.TabIndex = 6
        '
        'tBillDay
        '
        Me.tBillDay.CheckedListSettings.CheckStateMember = ""
        Me.tBillDay.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tBillDay.Location = New System.Drawing.Point(328, 8)
        Me.tBillDay.Name = "tBillDay"
        Me.tBillDay.Size = New System.Drawing.Size(136, 22)
        Me.tBillDay.TabIndex = 7
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(224, 8)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel2.TabIndex = 8
        Me.UltraLabel2.Text = "Customer Bill Day"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3})
        Me.MenuItem1.Text = "Print"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Reprint Invoices"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Reprint Summaries"
        '
        'tNote
        '
        Me.tNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNote.Location = New System.Drawing.Point(528, 8)
        Me.tNote.MaxLength = 250
        Me.tNote.Multiline = True
        Me.tNote.Name = "tNote"
        Me.tNote.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.tNote.Size = New System.Drawing.Size(312, 40)
        Me.tNote.TabIndex = 9
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(480, 8)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel3.TabIndex = 10
        Me.UltraLabel3.Text = "Notes"
        '
        'fmBilling
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(848, 526)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.tNote)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.tBillDay)
        Me.Controls.Add(Me.tBillDate)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.chSummary)
        Me.Controls.Add(Me.bPrint)
        Me.Controls.Add(Me.Grid1)
        Me.Menu = Me.MainMenu1
        Me.Name = "fmBilling"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBillDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBillDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub fmBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tBillDate.Value = Today
        LoadDD(tBillDay, dsBillDay, "day_file", "dayno", "day", , , True)
        Dim dr As DataRow
        dr = dsBillDay.Tables(0).NewRow
        dr("dayno") = 8
        dr("day") = "All"
        dsBillDay.Tables(0).Rows.Add(dr)
        dr = Nothing

        tBillDay.Value = Weekday(Today)
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        cmd.Connection = cnn

        

        If tBillDate.Value < Date.Today Then
            'bPrint.Enabled = False
            bPrint.Enabled = True
            cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_rev,ord_gen_balance,ord_sold_cust_serial,cust_company,cust_terms from ord_gen,ord_file,cust_file where ord_gen_ord_serial=ord_serial and ord_sold_cust_serial=cust_serial and ord_gen_type='O' and ord_gen_billdate='" + tBillDate.Text + "' order by cust_company,ord_serial"
        Else
            bPrint.Enabled = True
            If tBillDay.Text = "All" Then
                cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_rev,ord_gen_balance,ord_sold_cust_serial,cust_company,cust_terms from ord_gen,ord_file,cust_file where ord_gen_ord_serial=ord_serial and ord_sold_cust_serial=cust_serial and ord_gen_billed=0 and ord_gen_type='O' and cust_billable=1 and ord_gen_balance<>0 and ord_gen_status='SHIPPED' and ord_gen_ship_date<>'" + CStr(Today) + "' order by cust_company,ord_serial"
            Else
                'cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_rev,ord_gen_balance,ord_sold_cust_serial,cust_company,cust_terms FROM  ord_gen INNER JOIN ord_file ON ord_gen.ord_gen_ord_serial = ord_file.ord_serial INNER JOIN cust_file ON ord_file.ord_sold_cust_id = cust_file.cust_id LEFT OUTER JOIN  ord_prod ON ord_gen.ord_gen_ord_serial = ord_prod.ord_prod_ord_serial AND ord_gen.ord_gen_rev = ord_prod.ord_prod_rev AND ord_gen.ord_gen_type = ord_prod.ord_prod_type where ord_gen_billed=0 and ord_gen_type='O' and cust_billable=1 and cust_bill_day=" + CStr(tBillDay.Value) + " and ord_gen_balance<>0 and ((ord_gen_status='SHIPPED' and ord_gen_ship_date<>'" + CStr(Today) + "') or (ord_gen_ok_to_bill_early=1 and ord_prod_est_comp<>'1/1/1900' and ord_prod_est_comp <= '" + CStr(DateAdd(DateInterval.Day, 14, Today)) + "')) order by cust_company,ord_serial"
                cmd.CommandText = "SELECT dbo.ord_gen.ord_gen_serial, dbo.ord_gen.ord_gen_ord_serial, dbo.ord_gen.ord_gen_rev, dbo.ord_gen.ord_gen_type, " + _
                                            "dbo.ord_gen.ord_gen_balance, dbo.ord_file.ord_sold_cust_serial, dbo.cust_file.cust_company, dbo.cust_file.cust_terms, dbo.cust_file.cust_email_bills_to " + _
                   "FROM            dbo.ord_gen INNER JOIN " + _
                                            "dbo.ord_file ON dbo.ord_gen.ord_gen_ord_serial = dbo.ord_file.ord_serial INNER JOIN " + _
                                            "dbo.cust_file ON dbo.ord_file.ord_sold_cust_id = dbo.cust_file.cust_id LEFT OUTER JOIN " + _
                                            "dbo.ord_prod ON dbo.ord_gen.ord_gen_ord_serial = dbo.ord_prod.ord_prod_ord_serial AND dbo.ord_gen.ord_gen_rev = dbo.ord_prod.ord_prod_rev AND " + _
                                            "dbo.ord_gen.ord_gen_type = dbo.ord_prod.ord_prod_type " + _
                   "WHERE        (dbo.ord_gen.ord_gen_billed = 0) AND (dbo.ord_gen.ord_gen_type = 'O') AND (dbo.cust_file.cust_billable = 1) AND (dbo.cust_file.cust_bill_day = " + CStr(Weekday(Today)) + ") AND " + _
                                            "(dbo.ord_gen.ord_gen_balance <> 0) AND (dbo.ord_gen.ord_gen_status = 'SHIPPED') AND (dbo.ord_gen.ord_gen_ship_date <> '" + CStr(Today) + "') OR " + _
                                            "(dbo.ord_gen.ord_gen_billed = 0) AND (dbo.ord_gen.ord_gen_type = 'O') AND (dbo.cust_file.cust_billable = 1) AND (dbo.cust_file.cust_bill_day = " + CStr(Weekday(Today)) + ") AND " + _
                                            "(dbo.ord_gen.ord_gen_balance <> 0) AND (dbo.ord_gen.ord_gen_ok_to_bill_early = 1) AND (dbo.ord_prod.ord_prod_est_comp <> '1/1/1900') AND " + _
                                            "(dbo.ord_prod.ord_prod_est_comp <= '" + CStr(DateAdd(DateInterval.Day, 14, Today)) + "') OR " + _
                                            "(dbo.ord_gen.ord_gen_billed = 0) AND (dbo.ord_gen.ord_gen_type = 'O') AND (dbo.cust_file.cust_billable = 1) AND (dbo.ord_gen.ord_gen_balance <> 0) AND " + _
                                            "(dbo.ord_gen.ord_gen_status = 'SHIPPED') AND (dbo.ord_gen.ord_gen_ship_date <> '" + CStr(Today) + "') AND " + _
                                            "(dbo.ord_file.ord_sold_cust_serial = 380) AND (DATEPART(dw, GETDATE()) IN (2, 3, 4, 5)) OR " + _
                                            "(dbo.ord_gen.ord_gen_billed = 0) AND (dbo.ord_gen.ord_gen_type = 'O') AND (dbo.cust_file.cust_billable = 1) AND (dbo.ord_gen.ord_gen_balance <> 0) AND " + _
                                            "(dbo.ord_gen.ord_gen_ok_to_bill_early = 1) AND (dbo.ord_prod.ord_prod_est_comp <> CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) AND " + _
                                            "(dbo.ord_prod.ord_prod_est_comp <= '" + CStr(DateAdd(DateInterval.Day, 14, Today)) + "') AND (dbo.ord_file.ord_sold_cust_serial = 380) AND (DATEPART(dw,GETDATE()) IN (2, 3, 4, 5)) " + _
                   "ORDER BY dbo.cust_file.cust_company, dbo.ord_file.ord_serial"
            End If
        End If

        da.SelectCommand = cmd
        'cnn.Open()
        dsList.Clear()
        da.Fill(dsList, "list")
        'cnn.Close()
        Grid1.DataSource = dsList
        Grid1.DataBind()
        If tBillDate.Value < Date.Today Then
            Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
            For Each rw In Grid1.Rows
                rw.Appearance.BackColor = Color.LightGreen
            Next
        End If
    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub Grid1_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid1.ClickCellButton
        Try
            Dim fm As fmEstOrd2
            fm = LoadForm("Quotes/Orders")
            If fm.EditMode <> "" Then
                MsgBox("You must first save or cancel this Quote/Order", MsgBoxStyle.Information, "Save?")
                fm = Nothing
                Exit Sub
            End If
            fm.KeyValue1 = e.Cell.Text
            fm.tOrd.Text = e.Cell.Text
            fm.LoadPage()
            fm.Tab1.Tabs("O" + Grid1.ActiveRow.Cells(2).Text).Selected = True
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
        For Each rw In Grid1.Rows
            rw.Cells("Print").Value = 0
        Next
        rw = Nothing
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
        For Each rw In Grid1.Rows
            rw.Cells("Print").Value = 1
        Next
        rw = Nothing

    End Sub

    Private Sub Grid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Click
    End Sub

    Private Sub Grid1_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterCellActivate
        If Grid1.ActiveCell.Column.Key = "cust_company" Then
            Dim Checked As Boolean
            Dim onComp As String
            Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
            Checked = Grid1.ActiveRow.Cells("Print").Value
            onComp = Grid1.ActiveCell.Text
            For Each rw In Grid1.Rows
                If rw.Cells("cust_company").Text = onComp Then
                    rw.Cells("Print").Value = Not Checked
                End If
            Next
            rw = Nothing

        End If

    End Sub

    Private Sub bPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrint.Click
        'If tBillDate.Value < Today Then
        '    If MsgBox("The billing date is prior to todays date.  Do you want to continue?", MsgBoxStyle.YesNo, "Billing Date?") = MsgBoxResult.No Then Exit Sub
        '    If MsgBox("This could combine billings with previous dates.  Are you really sure?", MsgBoxStyle.YesNo, "Billing Date?") = MsgBoxResult.No Then Exit Sub
        'End If
        Dim onComp As String = ""
        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
        Dim cmd As New SqlCommand
        Dim trans As SqlTransaction
        Dim Comp As Long
        Dim Comps As New Collection

        bPrint.Enabled = False
        Try
            cmd.Connection = cnn
            cnn.Open()
            trans = cnn.BeginTransaction
            cmd.Transaction = trans

            For Each rw In Grid1.Rows
                If rw.Cells("print").Value = True Then
                    If rw.Cells("cust_company").Text <> onComp Then
                        onComp = rw.Cells("cust_company").Text
                        Comps.Add(rw.Cells("ord_sold_cust_serial").Value)
                    End If
                    'cmd.CommandText = "update ord_gen set ord_gen_billed=1, ord_gen_billdate='" + tBillDate.Text + "' where ord_gen_serial=" + rw.Cells("ord_gen_serial").Text
                    'cmd.ExecuteNonQuery()
                End If
            Next
            rw = Nothing
            trans.Commit()
            cnn.Close()

            For Each Comp In Comps
                If chSummary.CheckState = CheckState.Checked Then
                    DisplayReport("billing summary", , False, 1, tBillDate.Value, Comp)
                End If
                DisplayReport("order", "{ord_file.ord_sold_cust_serial} = " + CStr(Comp) + " and {ord_gen.ord_gen_type}='O' and {ord_gen.ord_gen_billdate}=#" + CStr(tBillDate.Value) + "#", False, 1, True)
            Next

        Catch
            trans.Rollback()
            DoError(Err, Me)
        End Try
        LoadGrid()
        bPrint.Enabled = True
    End Sub

    Private Sub tBillDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tBillDate.ValueChanged
        If IsDate(tBillDate.Text) And Me.ActiveControl Is tBillDate Then
            Dim cmd As New SqlCommand("select bill_note from bill_notes where bill_date='" + tBillDate.Text + "'", cnn)
            cnn.Open()
            tNote.Text = cmd.ExecuteScalar
            cnn.Close()
            tBillDay.Value = Weekday(CDate(tBillDate.Text))
            LoadGrid()
        End If
    End Sub


    Private Sub tBillDay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tBillDay.TextChanged
        If ActiveControl Is tBillDay Then
            LoadGrid()
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        DisplayReport("order", "{ord_gen.ord_gen_type}='O' and {ord_gen.ord_gen_billdate}=#" + CStr(tBillDate.Value) + "#", True, 1, , , True, False)

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        DisplayReport("billing summary", , True, 1, tBillDate.Value, -1, True)

    End Sub

    Private Sub tNote_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tNote.ValueChanged

    End Sub

    Private Sub tNote_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNote.Leave
        UpdateNote()
    End Sub
    Private Sub UpdateNote()
        Dim cmd As New SqlCommand("delete from bill_notes where bill_date='" + tBillDate.Text + "'", cnn)
        cnn.Open()
        cmd.ExecuteNonQuery()
        cmd.CommandText = "insert into bill_notes (bill_date,bill_note) values ('" + tBillDate.Text + "','" + Replace(tNote.Text, "'", "''") + "')"
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub

    Private Sub fmBilling_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        UpdateNote()
    End Sub

    Private Sub tBillDay_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tBillDay.InitializeLayout

    End Sub
End Class
