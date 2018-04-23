Public Class fmUpdateRep
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
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tFrom As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tTo As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.tFrom = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.tTo = New Infragistics.Win.UltraWinGrid.UltraCombo
        CType(Me.tFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 16)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "From"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(8, 48)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "To"
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(56, 104)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(160, 40)
        Me.UltraButton1.TabIndex = 6
        Me.UltraButton1.Text = "Update"
        '
        'tFrom
        '
        Me.tFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tFrom.DisplayMember = ""
        Me.tFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFrom.Location = New System.Drawing.Point(88, 16)
        Me.tFrom.Name = "tFrom"
        Me.tFrom.Size = New System.Drawing.Size(100, 24)
        Me.tFrom.TabIndex = 7
        Me.tFrom.ValueMember = ""
        '
        'tTo
        '
        Me.tTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tTo.DisplayMember = ""
        Me.tTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTo.Location = New System.Drawing.Point(88, 48)
        Me.tTo.Name = "tTo"
        Me.tTo.Size = New System.Drawing.Size(100, 24)
        Me.tTo.TabIndex = 8
        Me.tTo.ValueMember = ""
        '
        'fmUpdateRep
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 174)
        Me.Controls.Add(Me.tTo)
        Me.Controls.Add(Me.tFrom)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Name = "fmUpdateRep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Rep"
        CType(Me.tFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmUpdateRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDD2(tFrom, "rep_file", "rep_code", "rep_code", , "rep_type='I'")
        LoadDD2(tTo, "rep_file", "rep_code", "rep_code", , "rep_type='I'")
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        If MsgBox("This will update all Orders with a non-zero balance and all Quotes for " + tFrom.Text + ".  Do you want to proceed?", MsgBoxStyle.YesNo, "Update?") = MsgBoxResult.No Then Exit Sub
        UltraButton1.Enabled = False
        Dim cmd As New SqlClient.SqlCommand("update ord_gen set ord_gen_inside='" + tTo.Text + "' where ord_gen_inside='" + tFrom.Text + "' and ord_gen_type='O' and ord_gen_balance<>0", cnn)
        Dim Recs As Integer = 0

        cnn.Open()
        Recs = cmd.ExecuteNonQuery()
        cmd.CommandText = "update ord_gen set ord_gen_inside='" + tTo.Text + "' where ord_gen_inside='" + tFrom.Text + "' and ord_gen_type='Q'"
        Recs += cmd.ExecuteNonQuery()
        cnn.Close()
        MsgBox("Update Complete. " + CStr(Recs) + " records updated.")
        UltraButton1.Enabled = True
    End Sub
End Class
