<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmPartRename
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.tOld = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tNew = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old Part Number"
        '
        'tOld
        '
        Me.tOld.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tOld.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tOld.FormattingEnabled = True
        Me.tOld.Location = New System.Drawing.Point(136, 17)
        Me.tOld.Name = "tOld"
        Me.tOld.Size = New System.Drawing.Size(232, 24)
        Me.tOld.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Part Number"
        '
        'tNew
        '
        Me.tNew.Location = New System.Drawing.Point(136, 61)
        Me.tNew.Name = "tNew"
        Me.tNew.Size = New System.Drawing.Size(231, 22)
        Me.tNew.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 50)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fmPartRename
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 255)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tNew)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tOld)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fmPartRename"
        Me.Text = "fmPartRename"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tOld As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tNew As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
