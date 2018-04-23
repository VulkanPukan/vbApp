Public Class fmCodes
    Inherits System.Windows.Forms.Form
    Dim daCodes As New SqlClient.SqlDataAdapter
    Dim dsCodes As New DataSet
    Public SQLx As String
    Public AllowChanges As Boolean = True
    Public FilterName As String = ""
    Public FilterField As String = ""
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents UltraGridExcelExporter2 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents UltraGridExcelExporter3 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Public onCNN As SqlClient.SqlConnection = cnn
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
    Friend WithEvents bSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tFilter As System.Windows.Forms.TextBox
    Friend WithEvents lFilter As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("code_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("code_code")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("code_name")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.bSave = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.tFilter = New System.Windows.Forms.TextBox
        Me.lFilter = New System.Windows.Forms.Label
        Me.UltraGridExcelExporter3 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.Blue
        Appearance1.BackColor2 = System.Drawing.Color.LightSteelBlue
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal
        Me.Grid1.DisplayLayout.Appearance = Appearance1
        Me.Grid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Code"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 142
        UltraGridColumn3.Header.Caption = "Name"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 606
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.InterBandSpacing = 10
        Me.Grid1.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid1.DisplayLayout.MaxRowScrollRegions = 1
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
        Me.Grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
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
        Me.Grid1.Size = New System.Drawing.Size(760, 578)
        Me.Grid1.TabIndex = 1
        Me.Grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus
        '
        'bSave
        '
        Me.bSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bSave.Location = New System.Drawing.Point(8, 586)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(144, 24)
        Me.bSave.TabIndex = 2
        Me.bSave.Text = "Save Changes"
        '
        'UltraButton1
        '
        Me.UltraButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton1.Location = New System.Drawing.Point(160, 586)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(144, 24)
        Me.UltraButton1.TabIndex = 3
        Me.UltraButton1.Text = "Print"
        '
        'UltraButton2
        '
        Me.UltraButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton2.Location = New System.Drawing.Point(312, 586)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(144, 24)
        Me.UltraButton2.TabIndex = 4
        Me.UltraButton2.Text = "Export"
        '
        'tFilter
        '
        Me.tFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tFilter.Location = New System.Drawing.Point(544, 586)
        Me.tFilter.Name = "tFilter"
        Me.tFilter.Size = New System.Drawing.Size(208, 20)
        Me.tFilter.TabIndex = 5
        Me.tFilter.Visible = False
        '
        'lFilter
        '
        Me.lFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lFilter.Location = New System.Drawing.Point(464, 586)
        Me.lFilter.Name = "lFilter"
        Me.lFilter.Size = New System.Drawing.Size(72, 14)
        Me.lFilter.TabIndex = 6
        Me.lFilter.Text = "Filter"
        Me.lFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lFilter.Visible = False
        '
        'fmCodes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 614)
        Me.Controls.Add(Me.lFilter)
        Me.Controls.Add(Me.tFilter)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "fmCodes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fmCodes"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub fmCodes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGrid()
        If AllowChanges = False Then
            bSave.Enabled = False
            Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        End If
        If FilterName <> "" Then
            lFilter.Text = FilterName
            lFilter.Visible = True
            tFilter.Visible = True
        End If
    End Sub
    Private Sub LoadGrid()
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim custCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(daCodes)
            Dim SQL As String = SQLx

            dsCodes.Clear()
            cmd.Connection = onCNN
            If tFilter.Text <> "" Then
                If InStr(SQLx, "order by") > 0 Then
                    SQL = Mid(SQLx, 1, InStr(SQLx, "order by") - 1) + " where " + FilterField + " like '" + tFilter.Text + "%' " + Mid(SQLx, InStr(SQLx, "order by"))
                Else
                    SQL += " where " + FilterField + " like '" + tFilter.Text + "%'"
                End If
            End If
            cmd.CommandText = SQL
            daCodes.SelectCommand = cmd
            onCNN.Open()
            daCodes.Fill(dsCodes, "codes")
            onCNN.Close()

            Grid1.SetDataBinding(dsCodes, "codes")
            Grid1.DataBind()
            If Grid1.Rows.Band.Columns.Count > 1 Then
                If Grid1.Rows.Band.Columns(1).Key = "tax_exempt_cust_id" Then
                    Grid1.Rows.Band.Columns("tax_exempt_cust_id").NullText = ""
                End If
            End If
            If SQLx = "select fc_last_name,fc_first_name,fc_weekly_total,fc_serial from field_consultant order by fc_last_name,fc_first_name" Then
                Grid1.DisplayLayout.Bands(0).Columns(3).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            End If
            If SQLx = "select * from rep_ter order by rep_ter_state,rep_ter_zip" Then
                Dim gr As Infragistics.Win.UltraWinGrid.UltraGridRow

                For Each gr In Grid1.Rows
                    If nz(gr.Cells("rep_ter_zip").Value) = "" Then
                        gr.Cells("rep_ter_zip").Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    End If
                Next
            End If
        Catch
            DoError(Err, Me)
        End Try

    End Sub

    Private Sub fmCodes_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If dsCodes.Tables("codes").DataSet.HasChanges = True Then
            If MsgBox("The Codes have changed.  Do you want to save the changes now?", MsgBoxStyle.YesNo, "Save Changes?") = MsgBoxResult.Yes Then
                bSave_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub bSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click
        Try
            onCNN.Open()
            daCodes.Update(dsCodes, "codes")
            onCNN.Close()
            Me.Close()
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim layout As New Infragistics.Win.UltraWinGrid.UltraGridLayout
        Dim w As Integer
        layout.AutoFitColumns = True
        layout.Appearance.FontData.SizeInPoints = 8
        w = Grid1.Width
        Grid1.Width = 600

        Grid1.Print(layout)
        Grid1.Width = w
    End Sub

    Private Sub bExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim fl As New OpenFileDialog
        'fl.CheckFileExists = False

        'Try
        '    If fl.ShowDialog = DialogResult.OK Then
        '        UltraGridExcelExporter1.Export(Grid1, fl.FileName)
        '    End If
        'Catch
        '    DoError(Err, MainForm)
        'End Try
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Try
            UltraButton2.Enabled = False
            Dim hndl As Long

            UltraGridExcelExporter3.Export(Grid1, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\temp.xls")
            System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\temp.xls")
        Catch ex As Exception
            DoError(Err, Me)
        Finally
            UltraButton2.Enabled = True
        End Try
    End Sub

    Private Sub tFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFilter.TextChanged
        LoadGrid()
    End Sub
End Class
