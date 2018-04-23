Public Class fmTaxCodes
    Inherits System.Windows.Forms.Form
    Dim dsCodes As New DataSet
    Dim daCodes As New SqlClient.SqlDataAdapter
    Dim dsProdCat As New DataSet
    Dim daProdCat As New SqlClient.SqlDataAdapter
    Dim dsTaxCat As New DataSet
    Dim daTaxCat As New SqlClient.SqlDataAdapter
    Dim dvTaxCat As New DataView
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
    Friend WithEvents Grid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Grid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tax_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tax_state")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tax_county")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tax_rate")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_prod_type_serial")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_prod_type_type")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("itm_prod_type_desc")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tax_serial")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tax_state")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tax_county")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tax_cat")
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Grid2 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Grid3 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.DisplayLayout.AutoFitColumns = True
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "State"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 92
        UltraGridColumn3.Header.Caption = "County"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 97
        UltraGridColumn4.Header.Caption = "Rate"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 94
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(8, 8)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(304, 608)
        Me.Grid1.TabIndex = 0
        Me.Grid1.Text = "Tax Codes"
        '
        'Grid2
        '
        Me.Grid2.DisplayLayout.AutoFitColumns = True
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.Width = 91
        UltraGridColumn6.Header.Caption = "Type"
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 70
        UltraGridColumn7.Header.Caption = "Description"
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Width = 197
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.Grid2.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.Grid2.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.Grid2.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.Grid2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Me.Grid2.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid2.Location = New System.Drawing.Point(344, 88)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(288, 528)
        Me.Grid2.TabIndex = 1
        Me.Grid2.Text = "Product Categories"
        '
        'Grid3
        '
        Me.Grid3.DisplayLayout.AutoFitColumns = True
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.Caption = "State"
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 20
        UltraGridColumn10.Header.Caption = "County"
        UltraGridColumn10.Header.VisiblePosition = 2
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 30
        UltraGridColumn11.Header.Caption = "Type"
        UltraGridColumn11.Header.VisiblePosition = 3
        UltraGridColumn11.Width = 107
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.Grid3.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.Grid3.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes
        Me.Grid3.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True
        Me.Grid3.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Me.Grid3.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid3.Location = New System.Drawing.Point(640, 88)
        Me.Grid3.Name = "Grid3"
        Me.Grid3.Size = New System.Drawing.Size(128, 528)
        Me.Grid3.TabIndex = 2
        Me.Grid3.Text = "Tax Codes"
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(344, 24)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(168, 32)
        Me.UltraButton1.TabIndex = 3
        Me.UltraButton1.Text = "Save Changes"
        '
        'fmTaxCodes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(912, 630)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.Grid3)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "fmTaxCodes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fmTaxCodes"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmTaxCodes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGrid(Grid1, daCodes, dsCodes, "select * from tax_file order by tax_state,tax_county", "tax_file")
        LoadGrid(Grid2, daProdCat, dsProdCat, "select * from itm_prod_type order by itm_prod_type_type", "itm_type")
        LoadGrid(grid3, daTaxCat, dsTaxCat, "select * from tax_cat order by tax_state,tax_county", "tax_cat")
        dvTaxCat = New DataView(dsTaxCat.Tables("tax_cat"))

        Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True
        Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        'Grid3.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        Grid3.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True
        'Grid3.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        UltraButton1.Enabled = False
        daCodes.Update(dsCodes, "tax_file")
        daTaxCat.Update(dsTaxCat, "tax_cat")
        Me.Close()
    End Sub
    Private Sub Grid1_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterCellActivate
        If Not Grid1.ActiveRow Is Nothing Then
            dvTaxCat.RowFilter = "tax_state='" + Grid1.ActiveRow.Cells("tax_state").Text + "' and tax_county='" + Grid1.ActiveRow.Cells("tax_county").Text + "'"
            Grid3.DataSource = dvTaxCat
            Grid3.DataBind()
        End If
    End Sub

    Private Sub Grid2_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid2.InitializeLayout

    End Sub

    Private Sub Grid2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid2.DoubleClick
        Dim tr As DataRow
        tr = dsTaxCat.Tables(0).NewRow
        tr("tax_state") = Grid1.ActiveRow.Cells("tax_state").Text
        tr("tax_county") = Grid1.ActiveRow.Cells("tax_county").Text
        tr("tax_cat") = Grid2.ActiveRow.Cells("itm_prod_type_type").Text
        dsTaxCat.Tables(0).Rows.Add(tr)
    End Sub
End Class
