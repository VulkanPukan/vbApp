Public Class fmReferralNew
    Inherits System.Windows.Forms.Form
    Public SaveCanceled As Boolean = True
    Public onValue As Long
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
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel83 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel79 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRefPerc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tRefAddr3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel73 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRefCity As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tRefZip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel74 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRefState As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel75 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel76 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRefAddr2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel77 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRefAddr1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel78 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRefCompany As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel80 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel81 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents bSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tRefName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel83 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel79 = New Infragistics.Win.Misc.UltraLabel
        Me.tRefPerc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tRefAddr3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel73 = New Infragistics.Win.Misc.UltraLabel
        Me.tRefCity = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tRefZip = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel74 = New Infragistics.Win.Misc.UltraLabel
        Me.tRefState = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel75 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel76 = New Infragistics.Win.Misc.UltraLabel
        Me.tRefAddr2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel77 = New Infragistics.Win.Misc.UltraLabel
        Me.tRefAddr1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel78 = New Infragistics.Win.Misc.UltraLabel
        Me.tRefCompany = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel80 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel81 = New Infragistics.Win.Misc.UltraLabel
        Me.bSave = New Infragistics.Win.Misc.UltraButton
        Me.tRefName = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRefPerc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRefAddr3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRefCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRefZip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRefState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRefAddr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRefAddr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRefCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRefName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTextEditor2
        '
        Me.UltraTextEditor2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UltraTextEditor2.Location = New System.Drawing.Point(72, 200)
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.Size = New System.Drawing.Size(160, 21)
        Me.UltraTextEditor2.TabIndex = 143
        Me.UltraTextEditor2.Tag = ""
        '
        'UltraLabel83
        '
        Me.UltraLabel83.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel83.Location = New System.Drawing.Point(8, 200)
        Me.UltraLabel83.Name = "UltraLabel83"
        Me.UltraLabel83.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel83.TabIndex = 152
        Me.UltraLabel83.Text = "Phone"
        '
        'UltraLabel79
        '
        Me.UltraLabel79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel79.Location = New System.Drawing.Point(8, 224)
        Me.UltraLabel79.Name = "UltraLabel79"
        Me.UltraLabel79.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel79.TabIndex = 151
        Me.UltraLabel79.Text = "Percent"
        '
        'tRefPerc
        '
        Me.tRefPerc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tRefPerc.DisplayMember = ""
        Me.tRefPerc.LimitToList = True
        Me.tRefPerc.Location = New System.Drawing.Point(72, 224)
        Me.tRefPerc.Name = "tRefPerc"
        Me.tRefPerc.Size = New System.Drawing.Size(88, 21)
        Me.tRefPerc.TabIndex = 144
        Me.tRefPerc.Tag = ""
        Me.tRefPerc.ValueMember = ""
        '
        'tRefAddr3
        '
        Me.tRefAddr3.Location = New System.Drawing.Point(72, 104)
        Me.tRefAddr3.Name = "tRefAddr3"
        Me.tRefAddr3.Size = New System.Drawing.Size(160, 21)
        Me.tRefAddr3.TabIndex = 138
        Me.tRefAddr3.Tag = ""
        '
        'UltraLabel73
        '
        Me.UltraLabel73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel73.Location = New System.Drawing.Point(8, 104)
        Me.UltraLabel73.Name = "UltraLabel73"
        Me.UltraLabel73.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel73.TabIndex = 150
        Me.UltraLabel73.Text = "Addr3"
        '
        'tRefCity
        '
        Me.tRefCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tRefCity.DisplayMember = ""
        Me.tRefCity.Location = New System.Drawing.Point(72, 152)
        Me.tRefCity.Name = "tRefCity"
        Me.tRefCity.Size = New System.Drawing.Size(160, 21)
        Me.tRefCity.TabIndex = 141
        Me.tRefCity.Tag = ""
        Me.tRefCity.ValueMember = ""
        '
        'tRefZip
        '
        Me.tRefZip.Location = New System.Drawing.Point(72, 128)
        Me.tRefZip.Name = "tRefZip"
        Me.tRefZip.Size = New System.Drawing.Size(160, 21)
        Me.tRefZip.TabIndex = 139
        Me.tRefZip.Tag = ""
        '
        'UltraLabel74
        '
        Me.UltraLabel74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel74.Location = New System.Drawing.Point(8, 128)
        Me.UltraLabel74.Name = "UltraLabel74"
        Me.UltraLabel74.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel74.TabIndex = 149
        Me.UltraLabel74.Text = "Zip"
        '
        'tRefState
        '
        Me.tRefState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tRefState.Location = New System.Drawing.Point(72, 176)
        Me.tRefState.Name = "tRefState"
        Me.tRefState.Size = New System.Drawing.Size(160, 21)
        Me.tRefState.TabIndex = 142
        Me.tRefState.Tag = ""
        '
        'UltraLabel75
        '
        Me.UltraLabel75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel75.Location = New System.Drawing.Point(8, 176)
        Me.UltraLabel75.Name = "UltraLabel75"
        Me.UltraLabel75.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel75.TabIndex = 148
        Me.UltraLabel75.Text = "State"
        '
        'UltraLabel76
        '
        Me.UltraLabel76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel76.Location = New System.Drawing.Point(8, 152)
        Me.UltraLabel76.Name = "UltraLabel76"
        Me.UltraLabel76.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel76.TabIndex = 147
        Me.UltraLabel76.Text = "City"
        '
        'tRefAddr2
        '
        Me.tRefAddr2.Location = New System.Drawing.Point(72, 80)
        Me.tRefAddr2.Name = "tRefAddr2"
        Me.tRefAddr2.Size = New System.Drawing.Size(160, 21)
        Me.tRefAddr2.TabIndex = 136
        Me.tRefAddr2.Tag = ""
        '
        'UltraLabel77
        '
        Me.UltraLabel77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel77.Location = New System.Drawing.Point(8, 80)
        Me.UltraLabel77.Name = "UltraLabel77"
        Me.UltraLabel77.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel77.TabIndex = 146
        Me.UltraLabel77.Text = "Addr2"
        '
        'tRefAddr1
        '
        Me.tRefAddr1.Location = New System.Drawing.Point(72, 56)
        Me.tRefAddr1.Name = "tRefAddr1"
        Me.tRefAddr1.Size = New System.Drawing.Size(160, 21)
        Me.tRefAddr1.TabIndex = 135
        Me.tRefAddr1.Tag = ""
        '
        'UltraLabel78
        '
        Me.UltraLabel78.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel78.Location = New System.Drawing.Point(8, 56)
        Me.UltraLabel78.Name = "UltraLabel78"
        Me.UltraLabel78.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel78.TabIndex = 145
        Me.UltraLabel78.Text = "Addr1"
        '
        'tRefCompany
        '
        Me.tRefCompany.Location = New System.Drawing.Point(72, 32)
        Me.tRefCompany.Name = "tRefCompany"
        Me.tRefCompany.Size = New System.Drawing.Size(160, 21)
        Me.tRefCompany.TabIndex = 134
        Me.tRefCompany.Tag = ""
        '
        'UltraLabel80
        '
        Me.UltraLabel80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel80.Location = New System.Drawing.Point(8, 32)
        Me.UltraLabel80.Name = "UltraLabel80"
        Me.UltraLabel80.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel80.TabIndex = 140
        Me.UltraLabel80.Text = "Company"
        '
        'UltraLabel81
        '
        Me.UltraLabel81.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel81.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel81.Name = "UltraLabel81"
        Me.UltraLabel81.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel81.TabIndex = 137
        Me.UltraLabel81.Text = "Name"
        '
        'bSave
        '
        Me.bSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSave.Location = New System.Drawing.Point(72, 256)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(152, 32)
        Me.bSave.TabIndex = 153
        Me.bSave.Text = "Save"
        '
        'tRefName
        '
        Me.tRefName.Location = New System.Drawing.Point(72, 8)
        Me.tRefName.Name = "tRefName"
        Me.tRefName.Size = New System.Drawing.Size(160, 21)
        Me.tRefName.TabIndex = 154
        Me.tRefName.Tag = ""
        '
        'fmReferralNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.Controls.Add(Me.tRefName)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.UltraTextEditor2)
        Me.Controls.Add(Me.UltraLabel83)
        Me.Controls.Add(Me.UltraLabel79)
        Me.Controls.Add(Me.tRefPerc)
        Me.Controls.Add(Me.tRefAddr3)
        Me.Controls.Add(Me.UltraLabel73)
        Me.Controls.Add(Me.tRefCity)
        Me.Controls.Add(Me.tRefZip)
        Me.Controls.Add(Me.UltraLabel74)
        Me.Controls.Add(Me.tRefState)
        Me.Controls.Add(Me.UltraLabel75)
        Me.Controls.Add(Me.UltraLabel76)
        Me.Controls.Add(Me.tRefAddr2)
        Me.Controls.Add(Me.UltraLabel77)
        Me.Controls.Add(Me.tRefAddr1)
        Me.Controls.Add(Me.UltraLabel78)
        Me.Controls.Add(Me.tRefCompany)
        Me.Controls.Add(Me.UltraLabel80)
        Me.Controls.Add(Me.UltraLabel81)
        Me.Name = "fmReferralNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Referral"
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRefPerc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRefAddr3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRefCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRefZip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRefState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRefAddr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRefAddr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRefCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRefName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmReferralNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDD2(tRefPerc, "ref_perc", "ref_perc", "ref_perc")
    End Sub
    Private Function CheckField(ByVal ctl As Control, ByVal nm As String, ByVal tb As String) As Boolean
        If ctl.Text = "" Then
            MsgBox("Must have a " + nm + ".", MsgBoxStyle.Information, nm + "?")
            ctl.Focus()
            SaveCanceled = True
            CheckField = False
        Else
            CheckField = True
        End If

    End Function

    Private Sub bSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click
        If CheckField(tRefAddr1, "Referral Address", "C") = False Then Exit Sub
        If CheckField(tRefCity, "Referral City", "C") = False Then Exit Sub
        If CheckField(tRefState, "Referral State", "C") = False Then Exit Sub
        If CheckField(tRefZip, "Referral Zip", "C") = False Then Exit Sub
        If CheckField(tRefPerc, "Referral Percentage", "C") = False Then Exit Sub
        Try
            Dim cnnx As New SqlClient.SqlConnection(cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'")
            Dim cmd As New SqlClient.SqlCommand("", cnnx)
            cmd.CommandText = "insert into ref_file (ref_name,ref_company,ref_addr1,ref_addr2,ref_addr3,ref_city,ref_state,ref_zip,ref_perc,ref_pay_on_recpt) values ("
            cmd.CommandText += "'" + tRefName.Text + "',"
            cmd.CommandText += "'" + tRefCompany.Text + "',"
            cmd.CommandText += "'" + tRefAddr1.Text + "',"
            cmd.CommandText += "'" + tRefAddr2.Text + "',"
            cmd.CommandText += "'" + tRefAddr3.Text + "',"
            cmd.CommandText += "'" + tRefCity.Text + "',"
            cmd.CommandText += "'" + tRefState.Text + "',"
            cmd.CommandText += "'" + tRefZip.Text + "',"
            cmd.CommandText += "" + tRefPerc.Text + ","
            cmd.CommandText += "0)"
            cnnx.Open()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "select @@identity"
            onValue = cmd.ExecuteScalar
            cnnx.Close()
            SaveCanceled = False
        Catch ex As Exception
            DoError(Err, Me)
            SaveCanceled = True
        End Try
        Me.Hide()
    End Sub

    Private Sub fmReferralNew_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        tRefCompany.Focus()
    End Sub
End Class
