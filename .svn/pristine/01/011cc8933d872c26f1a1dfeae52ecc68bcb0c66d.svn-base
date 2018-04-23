Public Class fmOrdCopyInstall
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bCopy As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bCancel As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.bCopy = New Infragistics.Win.Misc.UltraButton
        Me.bCancel = New Infragistics.Win.Misc.UltraButton
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 224)
        Me.Panel1.TabIndex = 0
        '
        'bCopy
        '
        Me.bCopy.Location = New System.Drawing.Point(8, 232)
        Me.bCopy.Name = "bCopy"
        Me.bCopy.Size = New System.Drawing.Size(104, 24)
        Me.bCopy.TabIndex = 1
        Me.bCopy.Text = "Copy"
        '
        'bCancel
        '
        Me.bCancel.Location = New System.Drawing.Point(176, 232)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(104, 24)
        Me.bCancel.TabIndex = 2
        Me.bCancel.Text = "Cancel"
        '
        'fmOrdCopyInstall
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bCopy)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmOrdCopyInstall"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose the Revs to Copy to"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
        Dim cb As CheckBox

        For Each cb In Panel1.Controls
            cb.Checked = False
        Next
        Me.Hide()
    End Sub

    Private Sub bCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCopy.Click
        Me.Hide()
    End Sub
End Class
