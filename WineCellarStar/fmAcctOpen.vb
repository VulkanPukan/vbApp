Public Class fmAcctOpen
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
    Friend WithEvents tNum As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tNum = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'tNum
        '
        Me.tNum.Location = New System.Drawing.Point(8, 8)
        Me.tNum.Name = "tNum"
        Me.tNum.Size = New System.Drawing.Size(120, 20)
        Me.tNum.TabIndex = 0
        Me.tNum.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open for Today"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Parent Number"
        '
        'fmAcctOpen
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(280, 62)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tNum)
        Me.Name = "fmAcctOpen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acct Open Order/Quote"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New SqlClient.SqlCommand("update ord_file set ord_acct_open='" + CStr(Today) + "' where ord_serial=" + tNum.Text, cnn)
        cnn.Open()
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update ord_file set ord_acct_open=null where ord_acct_open<>'" + CStr(Today) + "'"
        cmd.ExecuteNonQuery()
        cnn.Close()
        tNum.SelectAll()
        tNum.Focus()
    End Sub
End Class
