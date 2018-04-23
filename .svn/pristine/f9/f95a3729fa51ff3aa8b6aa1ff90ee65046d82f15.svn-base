
Public Class fmFind
    Inherits System.Windows.Forms.Form
    Public frm As fmStarter
    Public flds As Collection
    Public Sort As String
    Dim ctFocus As Control
    Public ShowInactive As Boolean = False
    Public ShowHasOrders As Boolean = False
    Public Joinx As String = ""
    Public Wherex As String = ""
    Public Repeat As Boolean = False


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
    Friend WithEvents Button1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chInactive As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chOrders As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Button1 = New Infragistics.Win.Misc.UltraButton
        Me.chInactive = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chOrders = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chInactive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.White
        Me.Grid1.DisplayLayout.Appearance = Appearance1
        Me.Grid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Grid1.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(150, Byte), Integer))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.FontData.Name = "Arial"
        Appearance3.FontData.SizeInPoints = 10.0!
        Appearance3.ForeColor = System.Drawing.Color.White
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Grid1.DisplayLayout.Override.HeaderAppearance = Appearance3
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(150, Byte), Integer))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Grid1.DisplayLayout.Override.RowSelectorAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Grid1.DisplayLayout.Override.SelectedRowAppearance = Appearance5
        Me.Grid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.Grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid1.Location = New System.Drawing.Point(0, 224)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(792, 264)
        Me.Grid1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(592, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 56)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Search"
        '
        'chInactive
        '
        Me.chInactive.Location = New System.Drawing.Point(608, 88)
        Me.chInactive.Name = "chInactive"
        Me.chInactive.Size = New System.Drawing.Size(160, 16)
        Me.chInactive.TabIndex = 6
        Me.chInactive.Text = "Show Inactives"
        '
        'chOrders
        '
        Me.chOrders.Location = New System.Drawing.Point(608, 112)
        Me.chOrders.Name = "chOrders"
        Me.chOrders.Size = New System.Drawing.Size(152, 16)
        Me.chOrders.TabIndex = 7
        Me.chOrders.Text = "Has Orders"
        '
        'fmFind
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 486)
        Me.Controls.Add(Me.chOrders)
        Me.Controls.Add(Me.chInactive)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "fmFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fmFind"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chInactive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub fmFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Repeat = False Then
                Dim s As String
                Dim cnt As Integer = 0
                Dim lb As Label
                Dim tb As TextBox
                Dim fld As jFld

                chInactive.Visible = ShowInactive
                chOrders.Visible = ShowHasOrders

                For Each fld In flds
                    If fld.Searchable = True Then
                        lb = New Label
                        lb.Parent = Me
                        lb.Text = fld.FieldName
                        lb.Top = 25 * cnt
                        lb.Left = 10
                        lb.Width = 150
                        lb.Visible = True

                        tb = New TextBox
                        tb.Parent = Me
                        tb.Top = 25 * cnt
                        tb.Left = 160
                        tb.Visible = True
                        tb.Tag = fld.Field
                        fld.TextBox = tb
                        If cnt = 0 Then ctFocus = tb

                        cnt = cnt + 1
                    End If
                Next
                Me.AcceptButton = Button1
            End If
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Private Sub fmFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ctFocus.Focus()
    End Sub
    Private Sub Grid1_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterCellActivate
        frm.KeyValue1 = Grid1.ActiveRow.Cells(0).Value
        Grid1.ActiveRow.Selected = True
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Button1.Text = "Search" Then
                Dim cmd As New SqlClient.SqlCommand
                Dim da As New SqlClient.SqlDataAdapter
                Dim ds As New DataSet
                Dim ct As Control
                Dim sqlx, fldx, sqlAll As String
                Dim tb As TextBox
                Dim cnt As Integer
                Dim fld As jFld

                sqlx = ""
                fldx = ""
                For Each fld In flds
                    fldx = fldx + "" + fld.Field + " as '" + fld.FieldName + "',"
                    If fld.Searchable = True Then
                        If fld.TextBox.Text <> "" Then
                            Select Case fld.FieldType
                                Case "Numeric"
                                    sqlx = sqlx + fld.Field + "=" + fld.TextBox.Text + " and "
                                Case "String"
                                    If fld.SearchAll = True Then
                                        sqlx = sqlx + fld.Field + " like '%" + fld.TextBox.Text + "%' and "
                                    Else
                                        sqlx = sqlx + fld.Field + " like '" + fld.TextBox.Text + "%' and "
                                    End If
                                Case "Date"
                                    sqlx = sqlx + fld.Field + " = '" + fld.TextBox.Text + "' and "
                            End Select
                        End If
                    End If
                Next
                If Len(sqlx) > 4 Then sqlx = Mid(sqlx, 1, Len(sqlx) - 4)
                If Len(fldx) > 1 Then fldx = Mid(fldx, 1, Len(fldx) - 1)

                sqlAll = ""
                If Joinx <> "" Then
                    sqlAll = "select distinct " + fldx + " from " + frm.Table + " " + Joinx + " where "
                Else
                    sqlAll = "select " + fldx + " from " + frm.Table + " where "
                End If

                If chOrders.Checked = True Then
                    sqlAll = sqlAll + " ord_gen_type='O' and " + sqlx
                Else
                    sqlAll = sqlAll + sqlx
                End If

                If chInactive.Visible Then
                    If Not chInactive.Checked Then
                        sqlAll = sqlAll + " and inactive=0"
                    End If
                End If

                sqlAll = sqlAll + " order by " + Sort

                cmd.Connection = cnn
                cmd.CommandText = sqlAll
                da.SelectCommand = cmd
                cnn.Open()
                da.Fill(ds, frm.Table)
                cnn.Close()

                If ds.Tables(frm.Table).Rows.Count = 1 Then
                    frm.KeyValue1 = ds.Tables(frm.Table).Rows(0).Item(0)
                    Me.Close()
                End If

                Grid1.SetDataBinding(ds, frm.Table)
                If Grid1.Rows.Count > 0 Then
                    Grid1.Focus()
                    Grid1.Rows(0).Selected = True
                End If
            Else
                Grid1_AfterCellActivate(sender, e)
            End If
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub Grid1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.GotFocus
        Button1.Text = "Select"
    End Sub

    Private Sub Grid1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.LostFocus
        Button1.Text = "Search"
    End Sub
End Class
