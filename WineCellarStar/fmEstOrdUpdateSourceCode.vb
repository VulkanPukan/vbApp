Public Class fmEstOrdUpdateSourceCode
    Inherits System.Windows.Forms.Form
    Public onOrd As Long
    Public onRev As Integer
    Public onType As String
    Friend WithEvents tSourceCode As Infragistics.Win.UltraWinGrid.UltraCombo
    Public onSrcCode As String
    Dim dsSources As New DataSet
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
    Friend WithEvents UltraLabel68 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tForecastNote As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel50 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraLabel68 = New Infragistics.Win.Misc.UltraLabel
        Me.tForecastNote = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel50 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.tSourceCode = New Infragistics.Win.UltraWinGrid.UltraCombo
        CType(Me.tForecastNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tSourceCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraLabel68
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel68.Appearance = Appearance1
        Me.UltraLabel68.BackColorInternal = System.Drawing.Color.LightGoldenrodYellow
        Me.UltraLabel68.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel68.Location = New System.Drawing.Point(8, 36)
        Me.UltraLabel68.Name = "UltraLabel68"
        Me.UltraLabel68.Size = New System.Drawing.Size(96, 39)
        Me.UltraLabel68.TabIndex = 103
        Me.UltraLabel68.Text = "Reason for Change"
        '
        'tForecastNote
        '
        Me.tForecastNote.AcceptsReturn = True
        Me.tForecastNote.Location = New System.Drawing.Point(104, 36)
        Me.tForecastNote.Name = "tForecastNote"
        Me.tForecastNote.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.tForecastNote.Size = New System.Drawing.Size(472, 21)
        Me.tForecastNote.TabIndex = 6
        Me.tForecastNote.Tag = "edit"
        '
        'UltraLabel50
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel50.Appearance = Appearance4
        Me.UltraLabel50.BackColorInternal = System.Drawing.Color.LightGoldenrodYellow
        Me.UltraLabel50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel50.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel50.Name = "UltraLabel50"
        Me.UltraLabel50.Size = New System.Drawing.Size(96, 24)
        Me.UltraLabel50.TabIndex = 97
        Me.UltraLabel50.Text = "Source Code"
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(104, 81)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(104, 32)
        Me.UltraButton1.TabIndex = 7
        Me.UltraButton1.Text = "Save"
        '
        'tSourceCode
        '
        Me.tSourceCode.CheckedListSettings.CheckStateMember = ""
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.tSourceCode.DisplayLayout.Appearance = Appearance6
        Me.tSourceCode.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.tSourceCode.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.tSourceCode.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tSourceCode.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.tSourceCode.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tSourceCode.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.tSourceCode.DisplayLayout.MaxColScrollRegions = 1
        Me.tSourceCode.DisplayLayout.MaxRowScrollRegions = 1
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tSourceCode.DisplayLayout.Override.ActiveCellAppearance = Appearance14
        Appearance9.BackColor = System.Drawing.SystemColors.Highlight
        Appearance9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.tSourceCode.DisplayLayout.Override.ActiveRowAppearance = Appearance9
        Me.tSourceCode.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.tSourceCode.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.tSourceCode.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance7.BorderColor = System.Drawing.Color.Silver
        Appearance7.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.tSourceCode.DisplayLayout.Override.CellAppearance = Appearance7
        Me.tSourceCode.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.tSourceCode.DisplayLayout.Override.CellPadding = 0
        Appearance11.BackColor = System.Drawing.SystemColors.Control
        Appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance11.BorderColor = System.Drawing.SystemColors.Window
        Me.tSourceCode.DisplayLayout.Override.GroupByRowAppearance = Appearance11
        Appearance13.TextHAlignAsString = "Left"
        Me.tSourceCode.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.tSourceCode.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.tSourceCode.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.tSourceCode.DisplayLayout.Override.RowAppearance = Appearance12
        Me.tSourceCode.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tSourceCode.DisplayLayout.Override.TemplateAddRowAppearance = Appearance10
        Me.tSourceCode.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.tSourceCode.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.tSourceCode.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.tSourceCode.Location = New System.Drawing.Point(105, 11)
        Me.tSourceCode.Name = "tSourceCode"
        Me.tSourceCode.Size = New System.Drawing.Size(245, 22)
        Me.tSourceCode.TabIndex = 104
        '
        'fmEstOrdUpdateSourceCode
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(609, 130)
        Me.Controls.Add(Me.tSourceCode)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraLabel68)
        Me.Controls.Add(Me.tForecastNote)
        Me.Controls.Add(Me.UltraLabel50)
        Me.Name = "fmEstOrdUpdateSourceCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Source Code"
        CType(Me.tForecastNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tSourceCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub fmEstOrdUpdateForecast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LoadDD2(tSourceCode, "ord_src", "ord_src", "ord_src,ord_src_desc", "ord_src_desc", "ord_src_inactive=0")
        LoadDD(tSourceCode, dsSources, "ord_src", "ord_src", "ord_src_desc", , "ord_src_inactive=0", , "ord_src")
        tSourceCode.DisplayLayout.Bands(0).Columns(1).Width = 400
        If onSrcCode <> "" Then tSourceCode.Value = onSrcCode
    End Sub


    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Try
            Dim cmd As New SqlClient.SqlCommand("", cnn)

            cmd.CommandText = "update ord_gen set ord_gen_src='" + tSourceCode.Value + "' where ord_gen_ord_serial=" + CStr(onOrd) + " and ord_gen_rev=" + CStr(onRev) + " and ord_gen_type='" + onType + "'"
            cnn.Open()
            cmd.ExecuteNonQuery()
            If onSrcCode <> tSourceCode.Value Then
                cmd.CommandText = "insert into ord_gen_src_update (ord_gen_src_update_ord_serial,ord_gen_src_update_ord_rev,ord_gen_src_update_ord_type,ord_gen_src_update_by,ord_gen_src_update_date,ord_gen_src_update_was) values (" + CStr(onOrd) + "," + CStr(onRev) + ",'" + onType + "','" + User + "',getdate(),'" + Replace(onSrcCode, "'", "''") + "')"
                cmd.ExecuteNonQuery()
            End If
            cnn.Close()

            Me.Close()
        Catch
            DoError(Err, Me)
        End Try
    End Sub


    Private Sub tSourceCode_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tSourceCode.InitializeLayout

    End Sub
End Class
