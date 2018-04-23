Imports System.Data.SqlClient
Public Class fmCloseMonth
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
    Friend WithEvents tEnd As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Bar1 As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Me.tEnd = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.Bar1 = New System.Windows.Forms.ProgressBar
        CType(Me.tEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tEnd
        '
        Me.tEnd.BackColor = System.Drawing.SystemColors.Window
        Me.tEnd.DateButtons.Add(DateButton1)
        Me.tEnd.Location = New System.Drawing.Point(88, 40)
        Me.tEnd.Name = "tEnd"
        Me.tEnd.NonAutoSizeHeight = 160
        Me.tEnd.Size = New System.Drawing.Size(176, 21)
        Me.tEnd.TabIndex = 1
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(8, 40)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 24)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "Month End"
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(88, 120)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(176, 40)
        Me.UltraButton1.TabIndex = 4
        Me.UltraButton1.Text = "Close Month"
        '
        'Bar1
        '
        Me.Bar1.Location = New System.Drawing.Point(0, 168)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(472, 16)
        Me.Bar1.TabIndex = 5
        '
        'fmCloseMonth
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 182)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.tEnd)
        Me.Name = "fmCloseMonth"
        Me.Text = "fmCloseMonth"
        CType(Me.tEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmCloseMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tEnd.Value = DateAdd(DateInterval.Month, -1, (DateAdd(DateInterval.Day, (-1 * Microsoft.VisualBasic.Day(Today)) + 1, Today)))
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim cmd As New SqlCommand("", cnn)
        Dim cmd2 As New SqlCommand("", cnn2)
        Dim dr As SqlDataReader
        Dim tot As Long = 0
        Dim cnt As Long = 0
        cmd.CommandTimeout = 500000
        Try

            UltraButton1.Enabled = False
            cnn.Open()
            cmd.CommandText = "update ord_gen set ord_gen_acct_total=ord_gen_total, ord_gen_acct_lock=1 where (case ord_gen_staged when 1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(tEnd.Value) + "' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and ord_gen_type='O' and ord_gen_acct_lock=0"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "select count(ord_gen_serial) from ord_gen,ord_itm where ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev=ord_itm_rev and ord_gen_type=ord_itm_type and (case ord_gen_staged when 1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(tEnd.Value) + "' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and ord_gen_type='O' and ord_itm_acct_lock=0"
            tot = cmd.ExecuteScalar

            cmd.CommandText = "alter table ord_itm nocheck constraint CK_ord_itm_check_lock"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "select distinct ord_gen_ord_serial,ord_gen_rev,ord_gen_type from ord_gen,ord_itm where ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev=ord_itm_rev and ord_gen_type=ord_itm_type and (case ord_gen_staged when 1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(tEnd.Value) + "' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and ord_gen_type='O' and ord_itm_acct_lock=0"
            dr = cmd.ExecuteReader
            cnn2.Open()
            Do While dr.Read
                cmd2.CommandText = "update ord_itm set ord_itm_acct_lock=1,ord_itm_acct_total=(ord_itm_qty * (ord_itm_unt_sell+ord_itm_unt_ship))+ord_itm_disc_amt where ord_itm_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(dr("ord_gen_rev")) + " and ord_itm_type='O'"
                cmd2.ExecuteNonQuery()
                Bar1.Value = (cnt / tot * 100)
                cnt += 1
                Application.DoEvents()
            Loop
            dr.Close()
            cmd.CommandText = "update mas_file set mas_acct_locked='" + CStr(tEnd.Value) + "'"
            cmd.ExecuteNonQuery()
            If cnn.State = ConnectionState.Closed Then cnn.Open()
            cmd.CommandText = "alter table ord_itm check constraint CK_ord_itm_check_lock"
            cmd.ExecuteNonQuery()
            MsgBox("Month Close Succesful.", MsgBoxStyle.OkOnly, "Complete")
        Catch
            DoError(Err, MainForm)
        Finally
            cnn2.Close()
            cnn.Close()
            UltraButton1.Enabled = True
        End Try
    End Sub
End Class
