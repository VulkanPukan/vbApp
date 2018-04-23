Public Class fmEstOrdUpdateForecast
    Inherits System.Windows.Forms.Form
    Public onOrd As Long
    Public onRev As Integer
    Public onStatus As String
    Public onReason As String
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
    Friend WithEvents UltraMonthViewMulti1 As Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
    Friend WithEvents UltraLabel68 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tForecastNote As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tForecastDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel67 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lLostReason As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tLostReason As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel50 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tForecast As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tLostDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tPerc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraMonthViewMulti1 = New Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
        Me.UltraLabel68 = New Infragistics.Win.Misc.UltraLabel
        Me.tForecastNote = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tForecastDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel67 = New Infragistics.Win.Misc.UltraLabel
        Me.lLostReason = New Infragistics.Win.Misc.UltraLabel
        Me.tLostReason = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel50 = New Infragistics.Win.Misc.UltraLabel
        Me.tForecast = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.tLostDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.tPerc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        CType(Me.UltraMonthViewMulti1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tForecastNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tForecastDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLostReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tForecast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLostDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPerc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraMonthViewMulti1
        '
        Me.UltraMonthViewMulti1.BackColor = System.Drawing.SystemColors.Window
        Me.UltraMonthViewMulti1.Location = New System.Drawing.Point(592, 8)
        Me.UltraMonthViewMulti1.MonthDimensions = New System.Drawing.Size(3, 3)
        Me.UltraMonthViewMulti1.Name = "UltraMonthViewMulti1"
        Me.UltraMonthViewMulti1.Size = New System.Drawing.Size(430, 382)
        Me.UltraMonthViewMulti1.TabIndex = 104
        Me.UltraMonthViewMulti1.Tag = "edit"
        '
        'UltraLabel68
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel68.Appearance = Appearance1
        Me.UltraLabel68.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.UltraLabel68.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel68.Location = New System.Drawing.Point(0, 104)
        Me.UltraLabel68.Name = "UltraLabel68"
        Me.UltraLabel68.Size = New System.Drawing.Size(96, 24)
        Me.UltraLabel68.TabIndex = 103
        Me.UltraLabel68.Text = "Notes"
        '
        'tForecastNote
        '
        Me.tForecastNote.AcceptsReturn = True
        Me.tForecastNote.Location = New System.Drawing.Point(104, 104)
        Me.tForecastNote.Multiline = True
        Me.tForecastNote.Name = "tForecastNote"
        Me.tForecastNote.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.tForecastNote.Size = New System.Drawing.Size(472, 320)
        Me.tForecastNote.TabIndex = 6
        Me.tForecastNote.Tag = "edit"
        '
        'tForecastDate
        '
        Me.tForecastDate.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.tForecastDate.Location = New System.Drawing.Point(456, 8)
        Me.tForecastDate.Name = "tForecastDate"
        Me.tForecastDate.Size = New System.Drawing.Size(120, 21)
        Me.tForecastDate.TabIndex = 4
        Me.tForecastDate.Tag = "Edit"
        '
        'UltraLabel67
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel67.Appearance = Appearance2
        Me.UltraLabel67.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.UltraLabel67.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel67.Location = New System.Drawing.Point(328, 8)
        Me.UltraLabel67.Name = "UltraLabel67"
        Me.UltraLabel67.Size = New System.Drawing.Size(120, 24)
        Me.UltraLabel67.TabIndex = 100
        Me.UltraLabel67.Text = "Forecasted Date"
        '
        'lLostReason
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.lLostReason.Appearance = Appearance3
        Me.lLostReason.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lLostReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLostReason.Location = New System.Drawing.Point(8, 40)
        Me.lLostReason.Name = "lLostReason"
        Me.lLostReason.Size = New System.Drawing.Size(96, 24)
        Me.lLostReason.TabIndex = 99
        Me.lLostReason.Text = "Lost Reason"
        '
        'tLostReason
        '
        Me.tLostReason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tLostReason.DisplayMember = ""
        Me.tLostReason.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tLostReason.Location = New System.Drawing.Point(104, 40)
        Me.tLostReason.Name = "tLostReason"
        Me.tLostReason.Size = New System.Drawing.Size(184, 21)
        Me.tLostReason.TabIndex = 2
        Me.tLostReason.Tag = "Edit"
        Me.tLostReason.ValueMember = ""
        '
        'UltraLabel50
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel50.Appearance = Appearance4
        Me.UltraLabel50.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.UltraLabel50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel50.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel50.Name = "UltraLabel50"
        Me.UltraLabel50.Size = New System.Drawing.Size(96, 24)
        Me.UltraLabel50.TabIndex = 97
        Me.UltraLabel50.Text = "Forecast"
        '
        'tForecast
        '
        Me.tForecast.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tForecast.DisplayMember = ""
        Me.tForecast.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.tForecast.Location = New System.Drawing.Point(104, 8)
        Me.tForecast.Name = "tForecast"
        Me.tForecast.Size = New System.Drawing.Size(184, 21)
        Me.tForecast.TabIndex = 1
        Me.tForecast.Tag = "Edit"
        Me.tForecast.ValueMember = ""
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(104, 432)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(104, 32)
        Me.UltraButton1.TabIndex = 7
        Me.UltraButton1.Text = "Save"
        '
        'tLostDate
        '
        Me.tLostDate.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.tLostDate.Location = New System.Drawing.Point(104, 72)
        Me.tLostDate.Name = "tLostDate"
        Me.tLostDate.Size = New System.Drawing.Size(120, 21)
        Me.tLostDate.TabIndex = 3
        Me.tLostDate.Tag = "Edit"
        '
        'UltraLabel1
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel1.Appearance = Appearance5
        Me.UltraLabel1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 72)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 24)
        Me.UltraLabel1.TabIndex = 107
        Me.UltraLabel1.Text = "Lost Date"
        '
        'UltraLabel2
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel2.Appearance = Appearance6
        Me.UltraLabel2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(328, 40)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(136, 24)
        Me.UltraLabel2.TabIndex = 108
        Me.UltraLabel2.Text = "Forecasted Percent"
        '
        'tPerc
        '
        Me.tPerc.Location = New System.Drawing.Point(480, 40)
        Me.tPerc.Name = "tPerc"
        Me.tPerc.Size = New System.Drawing.Size(72, 21)
        Me.tPerc.TabIndex = 5
        '
        'fmEstOrdUpdateForecast
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(1040, 478)
        Me.Controls.Add(Me.tPerc)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.tLostDate)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraMonthViewMulti1)
        Me.Controls.Add(Me.UltraLabel68)
        Me.Controls.Add(Me.tForecastNote)
        Me.Controls.Add(Me.tForecastDate)
        Me.Controls.Add(Me.UltraLabel67)
        Me.Controls.Add(Me.lLostReason)
        Me.Controls.Add(Me.tLostReason)
        Me.Controls.Add(Me.UltraLabel50)
        Me.Controls.Add(Me.tForecast)
        Me.Name = "fmEstOrdUpdateForecast"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Forecast"
        CType(Me.UltraMonthViewMulti1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tForecastNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tForecastDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLostReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tForecast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLostDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPerc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmEstOrdUpdateForecast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDD2(tForecast, "forecast_file", "forecast_desc", "forecast_desc", "forecast_desc")
        LoadDD2(tLostReason, "forecast_reason", "forecast_reason_desc", "forecast_reason_desc", "forecast_reason_desc")
        tForecast.Value = onStatus
        tLostReason.Value = onReason
    End Sub

    Private Sub UltraMonthViewMulti1_BeforeMonthScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinSchedule.BeforeMonthScrollEventArgs) Handles UltraMonthViewMulti1.BeforeMonthScroll

    End Sub

    Private Sub UltraMonthViewMulti1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraMonthViewMulti1.Click
        tForecastDate.Focus()
        tForecast.Value = "Forecasted"
        tForecastDate.Value = UltraMonthViewMulti1.CalendarInfo.ActiveDay.Date

    End Sub

    Private Sub tForecastDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tForecastDate.ValueChanged
        If Not Me.ActiveControl Is tForecastDate Then Exit Sub
        tForecast.Value = "Forecasted"
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Try
            Dim cmd As New SqlClient.SqlCommand("", cnn)
            Dim LostDate As String

            If IsDate(tLostDate.Value) Then
                LostDate = "'" + CStr(tLostDate.Value) + "'"
            Else
                LostDate = "null"
            End If

            If tPerc.Text = "" Or Not IsNumeric(tPerc.Text) Then
                MsgBox("Percent must be nemeric", MsgBoxStyle.Information, "Percent?")
                tPerc.Focus()
                Exit Sub
            End If

            cmd.CommandText = "update ord_gen set ord_gen_forecast='" + tForecast.Text + "',ord_gen_forecast_note='" + Replace(tForecastNote.Text, "'", "''") + "',ord_gen_lost_reason='" + tLostReason.Text + "',ord_gen_lost_date=" + LostDate + ",ord_gen_forecast_date='" + tForecastDate.Text + "', ord_gen_forecast_perc=" + tPerc.Text + " where ord_gen_ord_serial=" + CStr(onOrd) + " and ord_gen_rev=" + CStr(onRev) + " and ord_gen_type='Q'"
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()

            Me.Close()
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Private Sub tForecast_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tForecast.InitializeLayout

    End Sub

    Private Sub tForecast_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tForecast.ValueChanged
        If tForecast.Value = "Lost" Then
            If IsDate(tLostDate.Value) Then
                If tLostDate.Value <= CDate("1/1/1900") Then tLostDate.Value = Date.Today
            Else
                tLostDate.Value = Date.Today
            End If
        Else
            tLostDate.Value = DBNull.Value
        End If

    End Sub

    Private Sub tLostDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tLostDate.ValueChanged
    End Sub
End Class
