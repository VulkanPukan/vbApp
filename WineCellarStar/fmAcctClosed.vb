Public Class fmAcctClosed
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
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Date1 As System.Windows.Forms.MonthCalendar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.Date1 = New System.Windows.Forms.MonthCalendar
        Me.SuspendLayout()
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(8, 176)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(240, 40)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "Save Accounting Closed Date"
        '
        'Date1
        '
        Me.Date1.Location = New System.Drawing.Point(40, 8)
        Me.Date1.Name = "Date1"
        Me.Date1.ShowToday = False
        Me.Date1.TabIndex = 2
        '
        'fmAcctClosed
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(256, 222)
        Me.Controls.Add(Me.Date1)
        Me.Controls.Add(Me.UltraButton1)
        Me.Name = "fmAcctClosed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounting Closed Date"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmAcctClosed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlClient.SqlCommand("select mas_acct_closed from mas_file where mas_serial=1", cnn)
        cnn.Open()
        Date1.TodayDate = cmd.ExecuteScalar
        Date1.SetDate(Date1.TodayDate)
        cnn.Close()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim cmd As New SqlClient.SqlCommand("update mas_file set mas_acct_closed='" + CStr(Date1.SelectionStart) + "' where mas_serial=1", cnn)
        cnn.Open()
        cmd.ExecuteNonQuery()
        LoadAcctClosed()
        cnn.Close()
        Me.Close()
    End Sub
End Class
