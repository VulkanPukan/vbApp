Public Class fmOrdApproveDiscount
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
    Friend WithEvents tOrd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tOrd = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tOrd
        '
        Me.tOrd.Location = New System.Drawing.Point(8, 8)
        Me.tOrd.Name = "tOrd"
        Me.tOrd.Size = New System.Drawing.Size(136, 21)
        Me.tOrd.TabIndex = 0
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(8, 32)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(136, 24)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "Approve for Discounts"
        '
        'fmOrdApproveDiscount
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(200, 70)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.tOrd)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmOrdApproveDiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approve for Discounts"
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmOrdApproveDiscount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Select Case Split(tOrd.Text, "-").Length
            Case 2
                cmd.CommandText = "insert into ord_disc_override (ord_disc_override_ord_serial,ord_disc_override_ord_rev,ord_disc_override_ord_type,ord_disc_override_user,ord_disc_override_date) values (" + Split(tOrd.Text, "-")(0) + "," + Split(tOrd.Text, "-")(1) + ",'Q','" + User + "','" + CStr(Now) + "')"
            Case 3
                cmd.CommandText = "insert into ord_disc_override (ord_disc_override_ord_serial,ord_disc_override_ord_rev,ord_disc_override_ord_type,ord_disc_override_user,ord_disc_override_date) values (" + Split(tOrd.Text, "-")(0) + "," + Split(tOrd.Text, "-")(2) + ",'O','" + User + "','" + CStr(Now) + "')"
            Case Else
                MsgBox("Must be an Order or a Quote (ie 123456-0-0 or 123456-0)", MsgBoxStyle.Information, "Number?")
                Exit Sub
        End Select
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        MsgBox("Approval Complete", MsgBoxStyle.Information, "Complete")
        Me.Close()
    End Sub
End Class
