Imports System.Data
Imports System.Data.SqlClient

Public Class fmOrdUpdateInstaller
    Inherits System.Windows.Forms.Form
    Public OrdGenSerial As Long

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
    Friend WithEvents tInstaller As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tInstallerDate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel107 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel105 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents bsave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tNotes As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tInstaller = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tInstallerDate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel107 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel105 = New Infragistics.Win.Misc.UltraLabel
        Me.bsave = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.tNotes = New System.Windows.Forms.TextBox
        CType(Me.tInstaller, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tInstallerDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tInstaller
        '
        Me.tInstaller.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tInstaller.DisplayMember = ""
        Me.tInstaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tInstaller.Location = New System.Drawing.Point(72, 32)
        Me.tInstaller.Name = "tInstaller"
        Me.tInstaller.Size = New System.Drawing.Size(128, 21)
        Me.tInstaller.TabIndex = 109
        Me.tInstaller.Tag = "edit"
        Me.tInstaller.ValueMember = ""
        '
        'tInstallerDate
        '
        Me.tInstallerDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tInstallerDate.Location = New System.Drawing.Point(96, 8)
        Me.tInstallerDate.Name = "tInstallerDate"
        Me.tInstallerDate.Size = New System.Drawing.Size(104, 21)
        Me.tInstallerDate.TabIndex = 108
        Me.tInstallerDate.Tag = "edit"
        '
        'UltraLabel107
        '
        Me.UltraLabel107.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel107.Location = New System.Drawing.Point(8, 32)
        Me.UltraLabel107.Name = "UltraLabel107"
        Me.UltraLabel107.Size = New System.Drawing.Size(101, 17)
        Me.UltraLabel107.TabIndex = 107
        Me.UltraLabel107.Text = "Installer"
        '
        'UltraLabel105
        '
        Me.UltraLabel105.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel105.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel105.Name = "UltraLabel105"
        Me.UltraLabel105.Size = New System.Drawing.Size(103, 17)
        Me.UltraLabel105.TabIndex = 106
        Me.UltraLabel105.Text = "Install Date"
        '
        'bsave
        '
        Me.bsave.Location = New System.Drawing.Point(72, 168)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(128, 24)
        Me.bsave.TabIndex = 110
        Me.bsave.Text = "Save"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 56)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(101, 17)
        Me.UltraLabel1.TabIndex = 111
        Me.UltraLabel1.Text = "Notes"
        '
        'tNotes
        '
        Me.tNotes.Location = New System.Drawing.Point(72, 56)
        Me.tNotes.Multiline = True
        Me.tNotes.Name = "tNotes"
        Me.tNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tNotes.Size = New System.Drawing.Size(192, 88)
        Me.tNotes.TabIndex = 112
        Me.tNotes.Text = ""
        '
        'fmOrdUpdateInstaller
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(272, 198)
        Me.Controls.Add(Me.tNotes)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.bsave)
        Me.Controls.Add(Me.tInstaller)
        Me.Controls.Add(Me.tInstallerDate)
        Me.Controls.Add(Me.UltraLabel107)
        Me.Controls.Add(Me.UltraLabel105)
        Me.Name = "fmOrdUpdateInstaller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Installer"
        CType(Me.tInstaller, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tInstallerDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmOrdUpdateInstaller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDD2(tInstaller, "installer_file", "installer_serial", "installer_name")

    End Sub

    Private Sub bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsave.Click
        'If Not IsDate(tInstallerDate.Text) Then
        '    MsgBox("Must be a date.", MsgBoxStyle.Information, "Date?")
        '    tInstallerDate.Focus()
        '    Exit Sub
        'End If
        Dim cmd As New SqlCommand("", cnn)

        cmd.CommandText = "update ord_gen set ord_gen_install_dt='" + Me.tInstallerDate.Text + "',ord_gen_installer=" + CStr(Me.tInstaller.Value) + ",ord_gen_install_note='" + Replace(tNotes.Text, "'", "''") + "' where ord_gen_serial=" + CStr(Me.OrdGenSerial)
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        Me.Close()
    End Sub
End Class
