Public Class fmErrors
    Inherits System.Windows.Forms.Form
    Dim dsErr As New DataSet
    Dim dsUsers As New DataTable
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
    Friend WithEvents tErr As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tUser As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("err_stack")
        Me.tErr = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.tUser = New Infragistics.Win.UltraWinGrid.UltraCombo
        CType(Me.tErr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tErr
        '
        Me.tErr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tErr.Location = New System.Drawing.Point(8, 552)
        Me.tErr.Multiline = True
        Me.tErr.Name = "tErr"
        Me.tErr.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.tErr.Size = New System.Drawing.Size(1048, 96)
        Me.tErr.TabIndex = 1
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.DisplayLayout.AutoFitColumns = True
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1064, 528)
        Me.Grid1.TabIndex = 4
        '
        'tUser
        '
        Me.tUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tUser.DisplayMember = ""
        Me.tUser.Location = New System.Drawing.Point(8, 528)
        Me.tUser.Name = "tUser"
        Me.tUser.Size = New System.Drawing.Size(152, 21)
        Me.tUser.TabIndex = 5
        Me.tUser.ValueMember = ""
        '
        'fmErrors
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1064, 654)
        Me.Controls.Add(Me.tUser)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.tErr)
        Me.Name = "fmErrors"
        Me.Text = "fmErrors"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tErr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmErrors_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGrid()

        Dim cmd As New SqlClient.SqlCommand("select distinct err_user from err_file order by err_user", cnn)
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        cnn.Open()
        da.Fill(dsUsers)
        cnn.Close()

        tUser.DataSource = dsUsers
        tUser.DataBind()
    End Sub
    Private Sub Grid1_AfterRowActivate1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterRowActivate
        tErr.Text = Grid1.ActiveRow.Cells("err_stack").Text
    End Sub
    Private Sub LoadGrid()
        Dim cmd As New SqlClient.SqlCommand("select top 200 * from err_file order by err_serial desc", cnn)
        Dim da As New SqlClient.SqlDataAdapter(cmd)

        If tUser.Text <> "" Then cmd.CommandText = "select top 200 * from err_file where err_user='" + tUser.Text + "' order by err_serial desc"
        cnn.Open()
        dsErr.Clear()
        da.Fill(dsErr)
        cnn.Close()

        Grid1.DataSource = dsErr.Tables(0)
        Grid1.DataBind()
        Grid1.DisplayLayout.Bands(0).Columns(5).Format = "MM/dd/yyyy hh:mm"

    End Sub
    Private Sub tUser_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tUser.InitializeLayout
    End Sub

    Private Sub tUser_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tUser.Leave
        LoadGrid()

    End Sub
End Class
