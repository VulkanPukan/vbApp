Public Class fmSalesCat
    Inherits WineCellar.fmStarter
    Dim dsCat As New DataSet
    Dim daCat As New SqlClient.SqlDataAdapter
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
    Friend WithEvents tCat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sales_cat_prod_mar_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sales_cat_prod_mar_cat")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sales_cat_prod_mar_type")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sales_cat_prod_mar_from")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sales_cat_prod_mar_to")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sales_cat_prod_mar_mar")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sales_cat_prod_mar_start")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sales_cat_prod_mar_end")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.tCat = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.tCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tCat
        '
        Me.tCat.Location = New System.Drawing.Point(8, 8)
        Me.tCat.Name = "tCat"
        Me.tCat.Size = New System.Drawing.Size(104, 21)
        Me.tCat.TabIndex = 0
        Me.tCat.Tag = "edit;sales_cat_cat"
        '
        'UltraTextEditor2
        '
        Me.UltraTextEditor2.Location = New System.Drawing.Point(120, 8)
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.Size = New System.Drawing.Size(592, 21)
        Me.UltraTextEditor2.TabIndex = 1
        Me.UltraTextEditor2.Tag = "edit;sales_cat_desc"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Appearance1.BackColor2 = System.Drawing.Color.Silver
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.Grid1.DisplayLayout.Appearance = Appearance1
        Me.Grid1.DisplayLayout.AutoFitColumns = True
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 71
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 135
        UltraGridColumn3.Header.Caption = "Type"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 110
        UltraGridColumn4.Header.Caption = "From Qty"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 116
        UltraGridColumn5.Header.Caption = "To Qty"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 98
        UltraGridColumn6.Header.Caption = "Margin"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 145
        UltraGridColumn7.Header.Caption = "Start Date"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 112
        UltraGridColumn8.Header.Caption = "End Date"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 111
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        UltraGridBand1.Override.RowSpacingAfter = 0
        UltraGridBand1.Override.RowSpacingBefore = 0
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.InterBandSpacing = 10
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        Me.Grid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Me.Grid1.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Appearance3.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Me.Grid1.DisplayLayout.Override.CellAppearance = Appearance3
        Me.Grid1.DisplayLayout.Override.CellSpacing = 3
        Appearance4.BackColor = System.Drawing.Color.Silver
        Appearance4.FontData.Name = "Verdana"
        Appearance4.ForeColor = System.Drawing.Color.Black
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid1.DisplayLayout.Override.HeaderAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.RowAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.Silver
        Me.Grid1.DisplayLayout.Override.RowSelectorAppearance = Appearance6
        Me.Grid1.DisplayLayout.Override.RowSelectorWidth = 10
        Me.Grid1.DisplayLayout.Override.RowSpacingAfter = 3
        Me.Grid1.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance7.BackColor = System.Drawing.Color.Silver
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Me.Grid1.DisplayLayout.Override.SelectedRowAppearance = Appearance7
        Me.Grid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(8, 32)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(704, 440)
        Me.Grid1.TabIndex = 63
        '
        'fmSalesCat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(720, 478)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.UltraTextEditor2)
        Me.Controls.Add(Me.tCat)
        Me.Name = "fmSalesCat"
        Me.Text = "Sales Categories"
        CType(Me.tCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmSalesCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Table = "sales_cat"
        Me.Key1 = "sales_cat_serial"
        Me.FocusField = "tcat"
    End Sub

    Private Sub Grid1_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterCellActivate
        If Grid1.ActiveCell.Text <> "" Then Exit Sub
        Select Case Grid1.ActiveCell.Column.Header.Caption
            Case "From Qty"
                Grid1.ActiveCell.Value = "1"
            Case "To Qty"
                Grid1.ActiveCell.Value = "999999"
            Case "Start Date"
                Grid1.ActiveCell.Value = "1/1/1980"
            Case "End Date"
                Grid1.ActiveCell.Value = "12/31/2099"
        End Select
    End Sub

    Public Overrides Sub Find()
        Try
            Dim fm As New fmFind
            Dim flds As jFld
            fm.frm = Me
            fm.Sort = "sales_cat_cat"
            fm.ShowInactive = False

            fm.flds = New Collection

            flds = New jFld
            flds.Field = "sales_cat_serial"
            flds.FieldName = "Category"
            flds.FieldType = "Numeric"
            flds.Searchable = False
            fm.flds.Add(flds)

            flds = New jFld
            flds.Field = "sales_cat_cat"
            flds.FieldName = "Category"
            flds.FieldType = "String"
            flds.Searchable = True
            fm.flds.Add(flds)

            flds = New jFld
            flds.Field = "sales_cat_desc"
            flds.FieldName = "Description"
            flds.FieldType = "String"
            flds.Searchable = True
            fm.flds.Add(flds)

            fm.ShowDialog()
            LoadFields(Me)
            EditButtons("Idle")
            LoadGrid(Grid1, daCat, dsCat, "select * from sales_cat_prod_mar where sales_cat_prod_mar_cat='" + tCat.Text + "'", "cat")
        Catch
            DoError(Err, MainForm)
        End Try

    End Sub

    Public Overrides Sub Save_After()
        Dim x As Integer

        Grid1.UpdateData()
        BindingContext(dsCat, "cat").EndCurrentEdit()
        For x = 0 To dsCat.Tables("cat").Rows.Count - 1
            If dsCat.Tables("cat").Rows(x).RowState <> DataRowState.Deleted Then
                dsCat.Tables("cat").Rows(x).Item("sales_cat_prod_mar_cat") = tCat.Text
            End If
        Next
        cnn.Open()
        daCat.Update(dsCat, "cat")
        cnn.Close()
    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub
End Class
