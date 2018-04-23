Public Class fmSetting
    Inherits System.Windows.Forms.Form
    Public ID As String

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tDatabase As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.tDatabase = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter User Name of this machine:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = ""
        '
        'tDatabase
        '
        Me.tDatabase.Items.AddRange(New Object() {"winecellar", "winecellartest"})
        Me.tDatabase.Location = New System.Drawing.Point(8, 64)
        Me.tDatabase.Name = "tDatabase"
        Me.tDatabase.Size = New System.Drawing.Size(192, 21)
        Me.tDatabase.TabIndex = 0
        Me.tDatabase.Text = "winecellar"
        '
        'fmSetting
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(208, 150)
        Me.Controls.Add(Me.tDatabase)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "fmSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fmSetting"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Must have a " + ID, MsgBoxStyle.Critical, ID + "?")
            TextBox1.Focus()
            Exit Sub
        End If
        SaveSetting("Jcom", "Settings", ID, TextBox1.Text)
        SaveSetting("Jcom", "Settings", "Database", tDatabase.Text)
        onDatabase = tDatabase.Text
        Me.Close()
    End Sub

    Private Sub fmUserName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = GetSetting("Jcom", "Settings", ID, "")
        tDatabase.Text = GetSetting("Jcom", "Settings", "Database", "winecellar")
        Label1.Text = "Enter " + ID + ":"
        Me.Text = ID
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = Replace(TextBox1.Text, "'", "")
    End Sub

End Class
