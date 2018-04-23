Public Class fmDateSelect
    Inherits System.Windows.Forms.Form
    Public StartDate As Date
    Public EndDate As Date
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
    Friend WithEvents tStart As Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
    Friend WithEvents tEnd As Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
    Friend WithEvents tStartDate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tEndDate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents bYesterday As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bToday As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bAll As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.tStart = New Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
        Me.tEnd = New Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
        Me.tStartDate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tEndDate = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton6 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton7 = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.bYesterday = New Infragistics.Win.Misc.UltraButton
        Me.bToday = New Infragistics.Win.Misc.UltraButton
        Me.bAll = New Infragistics.Win.Misc.UltraButton
        CType(Me.tStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tStart
        '
        Appearance1.FontData.BoldAsString = "False"
        Appearance1.FontData.SizeInPoints = 10.0!
        Me.tStart.Appearance = Appearance1
        Me.tStart.BackColor = System.Drawing.SystemColors.Window
        Me.tStart.Location = New System.Drawing.Point(8, 24)
        Me.tStart.MonthDimensions = New System.Drawing.Size(3, 1)
        Me.tStart.Name = "tStart"
        Me.tStart.Size = New System.Drawing.Size(526, 156)
        Me.tStart.TabIndex = 0
        '
        'tEnd
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.SizeInPoints = 10.0!
        Me.tEnd.Appearance = Appearance2
        Me.tEnd.BackColor = System.Drawing.SystemColors.Window
        Me.tEnd.Location = New System.Drawing.Point(8, 208)
        Me.tEnd.MonthDimensions = New System.Drawing.Size(3, 1)
        Me.tEnd.Name = "tEnd"
        Me.tEnd.Size = New System.Drawing.Size(526, 156)
        Me.tEnd.TabIndex = 1
        '
        'tStartDate
        '
        Me.tStartDate.Location = New System.Drawing.Point(560, 8)
        Me.tStartDate.Name = "tStartDate"
        Me.tStartDate.Size = New System.Drawing.Size(144, 21)
        Me.tStartDate.TabIndex = 2
        '
        'tEndDate
        '
        Me.tEndDate.Location = New System.Drawing.Point(560, 56)
        Me.tEndDate.Name = "tEndDate"
        Me.tEndDate.Size = New System.Drawing.Size(144, 21)
        Me.tEndDate.TabIndex = 3
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(560, 32)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "Start Date"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(560, 80)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "End Date"
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(552, 216)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(160, 32)
        Me.UltraButton1.TabIndex = 6
        Me.UltraButton1.Text = "Last Week"
        '
        'UltraButton2
        '
        Me.UltraButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton2.Location = New System.Drawing.Point(552, 256)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(160, 32)
        Me.UltraButton2.TabIndex = 7
        Me.UltraButton2.Text = "Last Month"
        '
        'UltraButton3
        '
        Me.UltraButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton3.Location = New System.Drawing.Point(552, 296)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(160, 32)
        Me.UltraButton3.TabIndex = 8
        Me.UltraButton3.Text = "Last Year"
        '
        'UltraButton4
        '
        Me.UltraButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton4.Location = New System.Drawing.Point(736, 296)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(160, 32)
        Me.UltraButton4.TabIndex = 11
        Me.UltraButton4.Text = "Year to Date"
        '
        'UltraButton5
        '
        Me.UltraButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton5.Location = New System.Drawing.Point(736, 256)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(160, 32)
        Me.UltraButton5.TabIndex = 10
        Me.UltraButton5.Text = "Month to Date"
        '
        'UltraButton6
        '
        Me.UltraButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton6.Location = New System.Drawing.Point(736, 216)
        Me.UltraButton6.Name = "UltraButton6"
        Me.UltraButton6.Size = New System.Drawing.Size(160, 32)
        Me.UltraButton6.TabIndex = 9
        Me.UltraButton6.Text = "Week to Date"
        '
        'UltraButton7
        '
        Me.UltraButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton7.Location = New System.Drawing.Point(560, 104)
        Me.UltraButton7.Name = "UltraButton7"
        Me.UltraButton7.Size = New System.Drawing.Size(160, 32)
        Me.UltraButton7.TabIndex = 12
        Me.UltraButton7.Text = "Run Report"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel3.TabIndex = 13
        Me.UltraLabel3.Text = "Pick Start Date:"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 192)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel4.TabIndex = 14
        Me.UltraLabel4.Text = "Pick End Date:"
        '
        'bYesterday
        '
        Me.bYesterday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bYesterday.Location = New System.Drawing.Point(552, 176)
        Me.bYesterday.Name = "bYesterday"
        Me.bYesterday.Size = New System.Drawing.Size(160, 32)
        Me.bYesterday.TabIndex = 15
        Me.bYesterday.Text = "Yesterday"
        '
        'bToday
        '
        Me.bToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bToday.Location = New System.Drawing.Point(736, 176)
        Me.bToday.Name = "bToday"
        Me.bToday.Size = New System.Drawing.Size(160, 32)
        Me.bToday.TabIndex = 16
        Me.bToday.Text = "Today"
        '
        'bAll
        '
        Me.bAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAll.Location = New System.Drawing.Point(736, 336)
        Me.bAll.Name = "bAll"
        Me.bAll.Size = New System.Drawing.Size(160, 32)
        Me.bAll.TabIndex = 17
        Me.bAll.Text = "All Dates"
        '
        'fmDateSelect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(904, 374)
        Me.Controls.Add(Me.bAll)
        Me.Controls.Add(Me.bToday)
        Me.Controls.Add(Me.bYesterday)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraButton7)
        Me.Controls.Add(Me.UltraButton4)
        Me.Controls.Add(Me.UltraButton5)
        Me.Controls.Add(Me.UltraButton6)
        Me.Controls.Add(Me.UltraButton3)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.tEndDate)
        Me.Controls.Add(Me.tStartDate)
        Me.Controls.Add(Me.tEnd)
        Me.Controls.Add(Me.tStart)
        Me.Name = "fmDateSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fmDateSelect"
        CType(Me.tStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub tStart_BeforeMonthScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinSchedule.BeforeMonthScrollEventArgs) Handles tStart.BeforeMonthScroll

    End Sub

    Private Sub tStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tStart.Click
        tStartDate.Text = tStart.CalendarInfo.ActiveDay.Date
    End Sub

    Private Sub fmDateSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tStart.Scroll(-2)
        'tEnd.Scroll(-2)
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        tStartDate.Text = DateAdd(DateInterval.Day, (Weekday(Today) * -1) - 6, Today)
        tEndDate.Text = DateAdd(DateInterval.Day, (Weekday(Today) * -1), Today)
        Me.Hide()
    End Sub

    Private Sub tStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tStartDate.ValueChanged
        If IsDate(tStartDate.Text) Then StartDate = CDate(tStartDate.Text)
    End Sub

    Private Sub tEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tEndDate.ValueChanged
        If IsDate(tEndDate.Text) Then EndDate = CDate(tEndDate.Text)
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        tStartDate.Text = DateAdd(DateInterval.Month, -1, DateAdd(DateInterval.Day, (Microsoft.VisualBasic.Day(Today) * -1) + 1, Today))
        tEndDate.Text = DateAdd(DateInterval.Day, (Microsoft.VisualBasic.Day(Today) * -1), Today)
        Me.Hide()
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        Me.Hide()
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        tStartDate.Text = CDate("1/1/" + CStr(Year(Today) - 1))
        tEndDate.Text = CDate("12/31/" + CStr(Year(Today) - 1))
        Me.Hide()
    End Sub

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        tStartDate.Text = DateAdd(DateInterval.Day, (Weekday(Today) * -1) + 1, Today)
        tEndDate.Text = Today
        Me.Hide()
    End Sub

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        tStartDate.Text = DateAdd(DateInterval.Day, (Microsoft.VisualBasic.Day(Today) * -1) + 1, Today)
        tEndDate.Text = Today
        Me.Hide()
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        tStartDate.Text = CDate("1/1/" + CStr(Year(Today)))
        tEndDate.Text = Today
        Me.Hide()
    End Sub

    Private Sub tEnd_BeforeMonthScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinSchedule.BeforeMonthScrollEventArgs) Handles tEnd.BeforeMonthScroll

    End Sub

    Private Sub tEnd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tEnd.Click
        tEndDate.Text = tEnd.CalendarInfo.ActiveDay.Date

    End Sub

    Private Sub bToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bToday.Click
        tStartDate.Text = Today
        tEndDate.Text = Today
        Me.Hide()

    End Sub

    Private Sub bYesterday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bYesterday.Click
        tStartDate.Text = DateAdd(DateInterval.Day, -1, Today)
        tEndDate.Text = DateAdd(DateInterval.Day, -1, Today)
        Me.Hide()

    End Sub

    Private Sub bAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAll.Click
        tStartDate.Text = "1/1/1900"
        tEndDate.Text = "12/31/2099"
        Me.Hide()
    End Sub

    Private Sub tStart_AfterMonthScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles tStart.AfterMonthScroll
        tEnd.FirstMonth = tStart.FirstMonth
    End Sub
End Class
