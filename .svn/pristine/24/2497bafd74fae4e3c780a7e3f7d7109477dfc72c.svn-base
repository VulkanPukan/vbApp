Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class fmReport
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents CRV1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.CRV1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRV1
        '
        Me.CRV1.ActiveViewIndex = -1
        Me.CRV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CRV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV1.Location = New System.Drawing.Point(0, 0)
        Me.CRV1.Name = "CRV1"
        Me.CRV1.ShowRefreshButton = False
        Me.CRV1.Size = New System.Drawing.Size(1031, 656)
        Me.CRV1.TabIndex = 0
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Email Report"
        Me.MenuItem1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CRV1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 656)
        Me.Panel1.TabIndex = 1
        '
        'fmReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1031, 656)
        Me.Controls.Add(Me.Panel1)
        Me.Menu = Me.MainMenu1
        Me.Name = "fmReport"
        Me.Text = "fmReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmReport_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        EditButtons("None")
    End Sub


    Private Sub fmReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MainForm.Timer2.Enabled = True
    End Sub

    Private Sub fmReport_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'MainForm.Timer2.Enabled = False

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

    End Sub

    Private Sub fmReport_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        CRV1.Width = Me.Width - 10
        CRV1.Height = Me.Height - 25
    End Sub
End Class
