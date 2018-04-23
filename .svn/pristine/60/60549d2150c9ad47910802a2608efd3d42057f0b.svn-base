Public Class fmOrdItmHist
    Inherits System.Windows.Forms.Form
    Public onSerial As Long
    Dim ds As New DataSet
    Public gr As Infragistics.Win.UltraWinGrid.UltraGrid
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
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_finish_serial")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_price_method")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_ship")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_shipped")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_prod_type")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_from_ord_itm_serial")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_forecast_overide")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_order_id")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_note")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_mat_color")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_up_color")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_disc_type")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_disc_val")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_disc_amt")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_is_disc")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_is_up")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_disc_prod")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_disc_matl")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_user")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_itm_updated")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total", 0)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.Caption = "Line"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MaxWidth = 20
        UltraGridColumn5.MinWidth = 20
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(28, 0)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Width = 20
        UltraGridColumn6.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.None
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn6.CellAppearance = Appearance2
        UltraGridColumn6.Header.Caption = "Qty"
        UltraGridColumn6.Header.VisiblePosition = 9
        UltraGridColumn6.MaxWidth = 40
        UltraGridColumn6.MinWidth = 40
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Width = 40
        UltraGridColumn7.Header.Caption = "Item Code"
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.MaxWidth = 200
        UltraGridColumn7.MinWidth = 100
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Width = 100
        UltraGridColumn8.Header.Caption = "Description"
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.MinWidth = 50
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Width = 202
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn9.CellAppearance = Appearance3
        UltraGridColumn9.Format = "$###,###.00"
        UltraGridColumn9.Header.Caption = "Unit Sell $"
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.MaxWidth = 60
        UltraGridColumn9.MinWidth = 60
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Width = 60
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
        UltraGridColumn31.Header.VisiblePosition = 31
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 32
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 33
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 34
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn35.CellAppearance = Appearance4
        UltraGridColumn35.Format = "$###,###.00"
        UltraGridColumn35.Header.Caption = "Disc / Up"
        UltraGridColumn35.Header.VisiblePosition = 35
        UltraGridColumn35.MaxWidth = 60
        UltraGridColumn35.MinWidth = 60
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.Width = 60
        UltraGridColumn36.Header.VisiblePosition = 36
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(53, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Header.VisiblePosition = 37
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 38
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(78, 0)
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Header.VisiblePosition = 39
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn40.Format = ""
        UltraGridColumn40.Header.Caption = "User"
        UltraGridColumn40.Header.VisiblePosition = 40
        UltraGridColumn40.MaxWidth = 50
        UltraGridColumn40.MinWidth = 50
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn41.Format = "MM/dd/yyyy hh:mm"
        UltraGridColumn41.Header.Caption = "Updated"
        UltraGridColumn41.Header.VisiblePosition = 41
        UltraGridColumn41.MaxWidth = 75
        UltraGridColumn41.MinWidth = 75
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn42.CellAppearance = Appearance5
        UltraGridColumn42.Format = "$###,###.00"
        UltraGridColumn42.Formula = "([ord_itm_qty] *  [ord_itm_unt_sell]) + [ord_itm_disc]"
        UltraGridColumn42.Header.VisiblePosition = 21
        UltraGridColumn42.MaxWidth = 90
        UltraGridColumn42.MinWidth = 75
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42})
        UltraGridBand1.SummaryFooterCaption = ""
        UltraGridBand1.UseRowLayout = True
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.CardAreaAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(112, Byte), CType(111, Byte), CType(145, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.FontData.Name = "Arial"
        Appearance7.FontData.SizeInPoints = 10.0!
        Appearance7.ForeColor = System.Drawing.Color.White
        Appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid1.DisplayLayout.Override.HeaderAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(112, Byte), CType(111, Byte), CType(145, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Grid1.DisplayLayout.Override.RowSelectorAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(251, Byte), CType(230, Byte), CType(148, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(238, Byte), CType(149, Byte), CType(21, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Grid1.DisplayLayout.Override.SelectedRowAppearance = Appearance9
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(928, 160)
        Me.Grid1.SupportThemes = False
        Me.Grid1.TabIndex = 1
        Me.Grid1.Tag = ""
        Me.Grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus
        '
        'fmOrdItmHist
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.Grid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "fmOrdItmHist"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Line Item History (Esc or F9 to exit)"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmOrdItmHist_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlClient.SqlCommand("select * from ord_itm_hist where ord_itm_serial=" + CStr(onSerial) + " order by ord_itm_hist_serial", cnn)
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim cl As Infragistics.Win.UltraWinGrid.UltraGridColumn

            cnn.Open()
            da.Fill(ds)
            cnn.Close()

            Grid1.DataSource = ds.Tables(0)
            Grid1.DataBind()

            For Each cl In gr.DisplayLayout.Bands(0).Columns
                Grid1.DisplayLayout.Bands(0).Columns(cl.Key).Hidden = cl.Hidden
                Grid1.DisplayLayout.Bands(0).Columns(cl.Key).Header.Caption = cl.Header.Caption
                Grid1.DisplayLayout.Bands(0).Columns(cl.Key).Width = cl.Width
            Next
        Catch
            DoError(Err, Me)
        End Try
    End Sub
    Private Sub fmOrdItmHist_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.F9 Then Me.Close()
    End Sub
End Class
