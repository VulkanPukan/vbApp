Public Class fmTaskList
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
    Friend WithEvents Text1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Text1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        CType(Me.Text1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(40, 32)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(80, 21)
        Me.Text1.TabIndex = 0
        Me.Text1.Text = "UltraTextEditor1"
        '
        'fmTaskList
        '
        Me.AllowDrop = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(864, 718)
        Me.Controls.Add(Me.Text1)
        Me.Name = "fmTaskList"
        Me.Text = "Tasks"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Text1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Text1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text1.ValueChanged

    End Sub

    Private Sub Text1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Text1.MouseDown
        Text1.BackColor = Color.AliceBlue
    End Sub

    Private Sub Text1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Text1.MouseUp
        Text1.BackColor = Color.White
    End Sub

    Private Sub Text1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Text1.DragEnter
        MsgBox("HI")
    End Sub
End Class
