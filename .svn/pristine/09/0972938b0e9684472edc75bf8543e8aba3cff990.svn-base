Public Class fmAdjustBalance
    Inherits System.Windows.Forms.Form
    Dim dsItems As New DataSet
    Dim daItems As New SqlClient.SqlDataAdapter
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
    Friend WithEvents tOrd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tBalance As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tSoldTo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tRev As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tNote As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ord_itm", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_ord_serial")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_type")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_rev")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_line")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_qty")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_item_code")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_desc")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_unt_sell")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_unt_ship")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_unt_base")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_mpf")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_markup")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_disc")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_disc_perc")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_base_price")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_taxable")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_fixture")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_sel_material")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_img")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_mat_code")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_fin_code")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_price_method")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_ship")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_shipped")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_prod_type")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_from_ord_itm_serial")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_forecast_overide")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_order_id")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_note")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total", 0)
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.tOrd = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tBalance = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.tSoldTo = New Infragistics.Win.Misc.UltraLabel
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.tRev = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.tNote = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tOrd
        '
        Me.tOrd.Location = New System.Drawing.Point(16, 16)
        Me.tOrd.Name = "tOrd"
        Me.tOrd.Size = New System.Drawing.Size(128, 21)
        Me.tOrd.TabIndex = 0
        '
        'tBalance
        '
        Me.tBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBalance.Location = New System.Drawing.Point(104, 64)
        Me.tBalance.Name = "tBalance"
        Me.tBalance.Size = New System.Drawing.Size(144, 24)
        Me.tBalance.TabIndex = 1
        Me.tBalance.Text = "$0.00"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 64)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(88, 24)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Balance:"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid1.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.TextTrimming = Infragistics.Win.TextTrimming.Character
        Me.Grid1.DisplayLayout.Appearance = Appearance1
        Me.Grid1.DisplayLayout.AutoFitColumns = True
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 35
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Tag = "Show"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.Caption = "Line"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MaxWidth = 50
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(28, 0)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Tag = "Show"
        UltraGridColumn5.Width = 10
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn6.CellAppearance = Appearance2
        UltraGridColumn6.Header.Caption = "Qty"
        UltraGridColumn6.Header.VisiblePosition = 9
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Tag = "Show"
        UltraGridColumn6.Width = 86
        UltraGridColumn7.Header.Caption = "Item Code"
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Tag = "Show"
        UltraGridColumn7.Width = 93
        UltraGridColumn8.Header.Caption = "Description"
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.MinWidth = 50
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Tag = "Show"
        UltraGridColumn8.Width = 202
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn9.CellAppearance = Appearance3
        UltraGridColumn9.Format = "$###,###.00"
        UltraGridColumn9.Header.Caption = "Unit Sell $"
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Tag = "Show"
        UltraGridColumn9.Width = 90
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 60
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 67
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.Width = 53
        UltraGridColumn13.Header.VisiblePosition = 14
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Width = 77
        UltraGridColumn14.Header.VisiblePosition = 16
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.Width = 83
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 17
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.Width = 107
        UltraGridColumn17.Header.Caption = "Taxable"
        UltraGridColumn17.Header.VisiblePosition = 18
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 93
        UltraGridColumn18.Header.Caption = "Fixture"
        UltraGridColumn18.Header.VisiblePosition = 7
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.Width = 59
        UltraGridColumn19.Header.Caption = "Select Mat'l"
        UltraGridColumn19.Header.VisiblePosition = 8
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Width = 47
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 22
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 23
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 24
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.DefaultCellValue = "0"
        UltraGridColumn25.Header.VisiblePosition = 25
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 26
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 27
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 28
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 29
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 30
        UltraGridColumn30.Hidden = True
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn31.CellAppearance = Appearance4
        UltraGridColumn31.Format = "$###,###.00"
        UltraGridColumn31.Formula = "([ord_itm_qty] *  [ord_itm_unt_sell]) + [ord_itm_disc]"
        UltraGridColumn31.Header.VisiblePosition = 21
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.Tag = "Show"
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31})
        UltraGridBand1.SummaryFooterCaption = ""
        UltraGridBand1.UseRowLayout = True
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.CardAreaAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(112, Byte), CType(111, Byte), CType(145, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.FontData.Name = "Arial"
        Appearance6.FontData.SizeInPoints = 10.0!
        Appearance6.ForeColor = System.Drawing.Color.White
        Appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid1.DisplayLayout.Override.HeaderAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(112, Byte), CType(111, Byte), CType(145, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Grid1.DisplayLayout.Override.RowSelectorAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(251, Byte), CType(230, Byte), CType(148, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(238, Byte), CType(149, Byte), CType(21, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Grid1.DisplayLayout.Override.SelectedRowAppearance = Appearance8
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(8, 128)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(616, 552)
        Me.Grid1.SupportThemes = False
        Me.Grid1.TabIndex = 3
        Me.Grid1.Tag = ""
        Me.Grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus
        '
        'tSoldTo
        '
        Me.tSoldTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSoldTo.Location = New System.Drawing.Point(8, 96)
        Me.tSoldTo.Name = "tSoldTo"
        Me.tSoldTo.Size = New System.Drawing.Size(608, 24)
        Me.tSoldTo.TabIndex = 4
        Me.tSoldTo.Text = "Sold To: "
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(576, 16)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(200, 40)
        Me.UltraButton1.TabIndex = 3
        Me.UltraButton1.Text = "Set Balance to $0.00"
        '
        'tRev
        '
        Me.tRev.Location = New System.Drawing.Point(160, 16)
        Me.tRev.Name = "tRev"
        Me.tRev.Size = New System.Drawing.Size(40, 21)
        Me.tRev.TabIndex = 1
        Me.tRev.Text = "0"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(16, 40)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel2.TabIndex = 7
        Me.UltraLabel2.Text = "Order"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(160, 40)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel3.TabIndex = 8
        Me.UltraLabel3.Text = "Rev"
        '
        'tNote
        '
        Me.tNote.Location = New System.Drawing.Point(216, 16)
        Me.tNote.Name = "tNote"
        Me.tNote.Size = New System.Drawing.Size(312, 21)
        Me.tNote.TabIndex = 2
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(216, 40)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel4.TabIndex = 10
        Me.UltraLabel4.Text = "Note"
        '
        'fmAdjustBalance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(824, 686)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.tNote)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.tRev)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.tSoldTo)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.tBalance)
        Me.Controls.Add(Me.tOrd)
        Me.Name = "fmAdjustBalance"
        Me.Text = "fmAdjustBalance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub tOrd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tOrd.ValueChanged

    End Sub

    Private Sub tOrd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tOrd.KeyUp
        If e.KeyCode = Keys.Enter Then
            getOrder()
        End If
    End Sub
    Private Sub getOrder()
        If tOrd.Text = "" Then Exit Sub
        Dim cmd As New SqlClient.SqlCommand
        Dim dr As SqlClient.SqlDataReader
        cmd.Connection = cnn
        cnn.Open()

        cmd.CommandText = "select ord_gen_balance from ord_gen where ord_gen_ord_serial=" + tOrd.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='O'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            tBalance.Text = FormatCurrency(dr("ord_gen_balance"))
            dr.Close()
        Else
            MsgBox("Order not found.", MsgBoxStyle.Information)
            dr.Close()
            cnn.Close()
            tOrd.Focus()
            tOrd.SelectAll()
            Exit Sub
        End If

        cmd.CommandText = "select ord_sold_company,ord_sold_name from ord_file where ord_serial=" + tOrd.Text
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            tSoldTo.Text = nz(dr("ord_sold_company")) + " / " + nz(dr("ord_sold_name"))
        Else
            MsgBox("Order not found.", MsgBoxStyle.Information)
            dr.Close()
            cnn.Close()
            tOrd.Focus()
            tOrd.SelectAll()
            Exit Sub
        End If
        dr.Close()

        dsItems.Clear()
        cmd.CommandText = "select * from ord_itm where ord_itm_ord_serial=" + tOrd.Text + " and ord_itm_rev=" + tRev.Text + " and ord_itm_type='O' order by ord_itm_line"
        daItems.SelectCommand = cmd
        daItems.Fill(dsItems, "ord_itm")
        Grid1.DataSource = dsItems

        Dim cl As Infragistics.Win.UltraWinGrid.UltraGridColumn
        For Each cl In Grid1.DisplayLayout.Bands(0).Columns
            If cl.Tag = "Show" Then
                cl.Hidden = False
            Else
                cl.Hidden = True
            End If
        Next
        cnn.Close()

    End Sub

    Private Sub tOrd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tOrd.KeyPress

    End Sub

    Private Sub tRev_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tRev.ValueChanged

    End Sub

    Private Sub tRev_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tRev.KeyUp
        If e.KeyCode = Keys.Enter Then
            getOrder()
        End If
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        UltraButton1.Enabled = False
        UpdateBalance()
        Dim cmd As New SqlClient.SqlCommand
        Dim Bal As Double
        cmd.Connection = cnn

        cnn.Open()
        cmd.CommandText = "select ord_gen_balance from ord_gen where ord_gen_ord_serial=" + tOrd.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='O'"
        Bal = cmd.ExecuteScalar

        Try
            cmd.CommandText = "insert into ord_itm (ord_itm_ord_serial,ord_itm_rev,ord_itm_type,ord_itm_qty,ord_itm_desc,ord_itm_unt_sell,ord_itm_taxable,ord_itm_unt_ship,ord_itm_base_price,ord_itm_unt_base,ord_itm_mpf,ord_itm_markup,ord_itm_disc_perc,ord_itm_disc,ord_itm_price_method,ord_itm_prod_type,ord_itm_note,ord_itm_mat_code,ord_itm_finish_serial,ord_itm_sel_material) values (" + tOrd.Text + "," + tRev.Text + ",'O',1,'Manual adjustment to balance made on " + CStr(Today) + " by " + User + " - " + tNote.Text + "'," + CStr(Bal * -1) + ",0,0,0,0,1,0,0,0,'','','','',0,0)"
            cmd.ExecuteNonQuery()
        Catch
            MsgBox(Err.Description)
        End Try
        cnn.Close()

        UpdateBalance()
        getOrder()
        tOrd.Focus()
        tOrd.SelectAll()
        UltraButton1.Enabled = True
    End Sub
    Private Sub UpdateBalance()
        Dim cmd As New SqlClient.SqlCommand
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim tot, pay, taxrate, tax, ship, totTaxable As Double
        Dim x, y As Long

        Try
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select * from ord_gen where ord_gen_ord_serial=" + tOrd.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='O'"
            da.Fill(ds, "ord")

            For Each dr In ds.Tables("ord").Rows
                cmd.CommandText = "select sum((ord_itm_qty*ord_itm_unt_ship)) as tot from ord_itm where ord_itm_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(dr("ord_gen_rev")) + " and ord_itm_type='" + dr("ord_gen_type") + "'"
                ship = nz(cmd.ExecuteScalar, 0) + nz(dr("ord_gen_ship_extra"), 0) - nz(dr("ord_gen_ship_disc"), 0)

                cmd.CommandText = "select sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc) as tot from ord_itm where ord_itm_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(dr("ord_gen_rev")) + " and ord_itm_type='" + dr("ord_gen_type") + "'"
                tot = nz(cmd.ExecuteScalar, 0)

                cmd.CommandText = "select sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc) as tot from ord_itm where ord_itm_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(dr("ord_gen_rev")) + " and ord_itm_type='" + dr("ord_gen_type") + "' and ord_itm_taxable=1"
                totTaxable = nz(cmd.ExecuteScalar, 0)

                cmd.CommandText = "select sum(pay_itm_amt) as paysum from pay_itm where pay_itm_ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                pay = nz(cmd.ExecuteScalar, 0)

                cmd.CommandText = "select ord_cust_taxrate from ord_file where ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_tax_exempt=0"
                taxrate = nz(cmd.ExecuteScalar, 0)
                tax = Math.Round((taxrate * totTaxable) + 0.00001, 2)

                cmd.CommandText = "update ord_gen set ord_gen_line_total=" + CStr(tot) + ",ord_gen_ship=" + CStr(ship) + ",ord_gen_tax=" + CStr(tax) + ", ord_gen_total=" + CStr(tot + ship + tax) + ", ord_gen_acct_total=" + CStr(tot + ship + tax) + ",ord_gen_balance=" + CStr(tot + ship + tax - pay) + " where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                cmd.ExecuteNonQuery()

            Next
            BalanceCheck("Adjustment Balance")
        Catch
            MsgBox(Err.Description)
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub UltraLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraLabel4.Click

    End Sub

    Private Sub fmAdjustBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
