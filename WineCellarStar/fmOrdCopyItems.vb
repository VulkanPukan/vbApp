Public Class fmOrdCopyItems
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
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents tOrd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.tOrd = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Parent Number"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(8, 32)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel2.TabIndex = 1
        Me.UltraLabel2.Text = "Copy to"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(72, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(176, 212)
        Me.ListBox1.TabIndex = 2
        '
        'tOrd
        '
        Me.tOrd.Enabled = False
        Me.tOrd.Location = New System.Drawing.Point(96, 8)
        Me.tOrd.Name = "tOrd"
        Me.tOrd.Size = New System.Drawing.Size(152, 21)
        Me.tOrd.TabIndex = 3
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(16, 256)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(120, 24)
        Me.UltraButton1.TabIndex = 4
        Me.UltraButton1.Text = "Copy Items"
        '
        'UltraButton2
        '
        Me.UltraButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton2.Location = New System.Drawing.Point(144, 256)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(120, 24)
        Me.UltraButton2.TabIndex = 5
        Me.UltraButton2.Text = "Cancel"
        '
        'fmOrdCopyItems
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(274, 294)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.tOrd)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmOrdCopyItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copy Items"
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        tOrd.Text = ""
        Me.Hide()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        If ListBox1.SelectedItems.Count = 0 Then
            MsgBox("You must select a revision", MsgBoxStyle.Critical, "Revision?")
            Exit Sub
        End If
        Me.Hide()
    End Sub
End Class
