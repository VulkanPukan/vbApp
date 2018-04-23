Public Class fmLogin
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
    Friend WithEvents UltraPictureBox1 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents tUser As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tPassword As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(fmLogin))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraPictureBox1 = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.tUser = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tPassword = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.tUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraPictureBox1
        '
        Me.UltraPictureBox1.BackColor = System.Drawing.Color.White
        Me.UltraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty
        Me.UltraPictureBox1.Image = CType(resources.GetObject("UltraPictureBox1.Image"), Object)
        Me.UltraPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPictureBox1.Name = "UltraPictureBox1"
        Me.UltraPictureBox1.Size = New System.Drawing.Size(232, 184)
        Me.UltraPictureBox1.TabIndex = 0
        '
        'tUser
        '
        Me.tUser.Location = New System.Drawing.Point(248, 8)
        Me.tUser.Name = "tUser"
        Appearance1.ForeColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tUser.NullTextAppearance = Appearance1
        Me.tUser.Size = New System.Drawing.Size(176, 21)
        Me.tUser.TabIndex = 1
        '
        'tPassword
        '
        Me.tPassword.Location = New System.Drawing.Point(248, 56)
        Me.tPassword.Name = "tPassword"
        Appearance2.ForeColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tPassword.NullTextAppearance = Appearance2
        Me.tPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.tPassword.Size = New System.Drawing.Size(176, 21)
        Me.tPassword.TabIndex = 2
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(272, 104)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(136, 32)
        Me.UltraButton1.TabIndex = 3
        Me.UltraButton1.Text = "Login"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(248, 32)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(160, 16)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "User Name"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(248, 80)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(160, 16)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 16)
        Me.Label1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fmLogin
        '
        Me.AcceptButton = Me.UltraButton1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 190)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.tPassword)
        Me.Controls.Add(Me.tUser)
        Me.Controls.Add(Me.UltraPictureBox1)
        Me.KeyPreview = True
        Me.Name = "fmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.tUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tUser.Text = GetSetting("Jcom", "Settings", "User", "")
        onDatabase = GetSetting("Jcom", "Settings", "Database", "winecellar")
        '*********testing
        'onDatabase = "winecellar test"
        If onDatabase <> "winecellar" Then Me.BackColor = Color.Yellow
        Dim ver As New System.Version
        Label1.Text = "Last build: " + System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly.Location)

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim dr As SqlClient.SqlDataReader
            Dim onGroup As Long
            cnnConnect()
            cmd.CommandText = "select * from usr_file left outer join rep_file on (lower(usr_osr)=lower(rep_code) or lower(usr_name)=lower(rep_code)) where usr_name='" + tUser.Text + "' and inactive<>1"
            cmd.Connection = cnn
            cnn.Open()
            Try
                dr = cmd.ExecuteReader
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
            If dr.HasRows = False Then
                MsgBox("User NOT FOUND", MsgBoxStyle.Critical, "Not Found")
                tUser.Focus()
                dr.Close()
                cnn.Close()
                Exit Sub
            Else
                dr.Read()
                If dr.Item("usr_password") = tPassword.Text Then
                    SaveSetting("Jcom", "Settings", "User", tUser.Text)
                    DoKeyLog = dr("usr_do_key_log")
                    User = dr("usr_name")
                    UserSerial = dr("usr_serial")
                    onGroup = nz(dr("usr_group"), 0)
                    UserGroupSerial = onGroup
                    UserISRAdmin = nz(dr("usr_isr_admin"), False)
                    DefForm = nz(dr("usr_def_form"))
                    UserType = nz(dr("rep_type"))
                    If UserType = "O" Then
                        UserOSR = dr("rep_code")
                    End If
                    dr.Close()
                    cmd.CommandText = "update usr_file set usr_login_time='" + CStr(Date.Now) + "',usr_program_version='" + CStr(System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly.Location)) + "' where usr_serial=" + CStr(UserSerial)
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "select usr_name from usr_file where usr_serial=" + CStr(onGroup)
                    UserGroup = cmd.ExecuteScalar
                    'cmd.CommandText = "select rep_type from rep_file where rep_code='" + User + "'"
                    'UserType = nz(cmd.ExecuteScalar, "")
                Else
                    MsgBox("Password does not match.", MsgBoxStyle.Critical, "Password?")
                    tPassword.Focus()
                    dr.Close()
                    cnn.Close()
                    Exit Sub
                End If
            End If
            cnn.Close()
            Me.Close()
        Catch
            MsgBox("Could not login", MsgBoxStyle.Exclamation, "Server?")
            Dim fm As New fmSetting
            fm.ID = "Server"
            fm.ShowDialog()
            Jcom.Server = GetSetting("Jcom", "Settings", "Server", "")
            cnnConnect()
            UltraButton1_Click(sender, e)
        End Try
    End Sub

    Private Sub fmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If tUser.Text = "" Then
            tUser.Focus()
        Else
            tPassword.Focus()
        End If

    End Sub

    Private Sub fmLogin_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.S And e.Modifiers = Keys.Alt Then
            Dim fm As New fmSetting
            fm.ID = "Server"
            fm.ShowDialog()
            Jcom.Server = GetSetting("Jcom", "Settings", "Server", "")
            If onDatabase <> "winecellar" Then
                Me.BackColor = Color.Yellow
            Else
                Me.BackColor = Color.White
            End If
        End If
    End Sub
End Class
