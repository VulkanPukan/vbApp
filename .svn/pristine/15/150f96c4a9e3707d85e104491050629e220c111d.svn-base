Public Class fmForecastStatus
    Inherits System.Windows.Forms.Form
    Public fm As fmEstOrd2
    Dim ds As New DataSet
    Dim cmd As New SqlClient.SqlCommand
    Dim da As New SqlClient.SqlDataAdapter(cmd)
    Dim cb As New SqlClient.SqlCommandBuilder(da)
    Dim Qgen As DataView
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
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_rev", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_total")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_forecast")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_gen_forecast_date")
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Rev"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MinWidth = 15
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Total"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.Caption = "Status"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.Caption = "Date"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MinWidth = 25
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(8, 8)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(444, 268)
        Me.Grid1.TabIndex = 0
        Me.Grid1.Text = "Quote: "
        '
        'UltraButton1
        '
        Me.UltraButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(8, 280)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(128, 32)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "OK"
        '
        'fmForecastStatus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 326)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "fmForecastStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forecast Status"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmForecastStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateValueList(Grid1, "forecast_file", "select forecast_desc from forecast_file order by forecast_order", "forecast_desc", "forecast_desc", "ord_gen_forecast")

        Grid1.Text = "Quotes for " + fm.tOrd.Text
        Qgen = New DataView(fm.dsGen.Tables("ord_gen"))
        Qgen.RowFilter = "ord_gen_type='Q'"

        Grid1.DataSource = Qgen

        Dim col As Infragistics.Win.UltraWinGrid.UltraGridColumn
        For Each col In Grid1.DisplayLayout.Bands(0).Columns
            If Mid(col.Header.Caption, 1, 7) = "ord_gen" Then col.Hidden = True
        Next
        Grid1.DataBind()
    End Sub

    Private Sub fmForecastStatus_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Grid1.UpdateData()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub
End Class
