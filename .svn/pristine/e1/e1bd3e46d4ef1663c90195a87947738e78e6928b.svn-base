Imports System.Data.SqlClient
Public Class fmReferralPayment
    Inherits System.Windows.Forms.Form
    Dim dsOrd As New DataSet
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
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents NamesList As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lAmount As System.Windows.Forms.Label
    Friend WithEvents tCheckNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.NamesList = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.lAmount = New System.Windows.Forms.Label
        Me.tCheckNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCheckNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.Location = New System.Drawing.Point(168, 0)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(616, 432)
        Me.Grid1.TabIndex = 0
        '
        'NamesList
        '
        Me.NamesList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NamesList.Location = New System.Drawing.Point(0, 0)
        Me.NamesList.Name = "NamesList"
        Me.NamesList.Size = New System.Drawing.Size(160, 420)
        Me.NamesList.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(176, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Pay This Amount"
        '
        'lAmount
        '
        Me.lAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAmount.Location = New System.Drawing.Point(512, 440)
        Me.lAmount.Name = "lAmount"
        Me.lAmount.Size = New System.Drawing.Size(152, 24)
        Me.lAmount.TabIndex = 3
        Me.lAmount.Text = "$0.00"
        '
        'tCheckNum
        '
        Me.tCheckNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tCheckNum.Location = New System.Drawing.Point(352, 440)
        Me.tCheckNum.Name = "tCheckNum"
        Me.tCheckNum.Size = New System.Drawing.Size(120, 21)
        Me.tCheckNum.TabIndex = 4
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel1.Location = New System.Drawing.Point(352, 464)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel1.TabIndex = 5
        Me.UltraLabel1.Text = "Check Number"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(16, 440)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 32)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Print Report"
        '
        'fmReferralPayment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 486)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.tCheckNum)
        Me.Controls.Add(Me.lAmount)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NamesList)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "fmReferralPayment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Referral Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCheckNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmReferralPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNames()
    End Sub
    Private Sub LoadNames()
        Try
            Dim cmd As New SqlCommand("SELECT ref_file.ref_name FROM ref_ledger INNER JOIN ord_file ON ref_ledger.ref_ledger_ord_serial = ord_file.ord_serial INNER JOIN ref_file ON ord_file.ord_ref_serial = ref_file.ref_serial GROUP BY ref_file.ref_name HAVING (SUM(ref_ledger.ref_ledger_amt) <> 0) ORDER BY ref_file.ref_name", cnn)
            Dim dr As SqlDataReader
            cnn.Open()
            dr = cmd.ExecuteReader
            NamesList.Items.Clear()
            If dr.HasRows Then
                Do While dr.Read
                    NamesList.Items.Add(dr("ref_name"))
                Loop
            End If
            cnn.Close()
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Private Sub NamesList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NamesList.SelectedIndexChanged
        Try
            Dim cmd As New SqlCommand("SELECT ref_ledger.ref_ledger_ord_serial, ref_ledger.ref_ledger_ord_rev, ref_ledger.ref_ledger_ord_type, SUM(ref_ledger.ref_ledger_amt) AS amt,ord_ref_note as Note FROM ref_ledger INNER JOIN ord_file ON ref_ledger.ref_ledger_ord_serial = ord_file.ord_serial INNER JOIN ref_file ON ord_file.ord_ref_serial = ref_file.ref_serial GROUP BY ref_name, ref_ledger.ref_ledger_ord_serial, ref_ledger.ref_ledger_ord_rev, ref_ledger.ref_ledger_ord_type,ord_ref_note HAVING(SUM(ref_ledger.ref_ledger_amt) <> 0 and ref_name='" + Me.NamesList.SelectedItem + "')", cnn)
            Dim da As New SqlDataAdapter(cmd)
            Dim rw As DataRow
            Dim tot As Double = 0
            Dim gr As Infragistics.Win.UltraWinGrid.UltraGridRow

            cnn.Open()
            dsOrd.Clear()
            da.Fill(dsOrd)
            cnn.Close()

            Grid1.DataSource = dsOrd.Tables(0)
            For Each rw In dsOrd.Tables(0).Rows
                tot += rw("amt")
            Next
            lAmount.Text = FormatCurrency(tot)

            For Each gr In Grid1.Rows
                If gr.Cells("Note").Text <> "" Then gr.Appearance.BackColor = Color.Yellow
            Next
        Catch
            DoError(Err, Me)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If tCheckNum.Text = "" Then
                MsgBox("Must have a check number", MsgBoxStyle.Critical, "Check Number?")
                tCheckNum.Focus()
                Exit Sub
            End If
            Button1.Enabled = False
            Dim rw As DataRow
            Dim cmd As New SqlCommand("", cnn)

            cnn.Open()
            For Each rw In dsOrd.Tables(0).Rows
                cmd.CommandText = "insert into ref_ledger (ref_ledger_ord_serial,ref_ledger_ord_rev,ref_ledger_ord_type,ref_ledger_ref,ref_ledger_refnum,ref_ledger_amt,ref_ledger_user,ref_ledger_date) values (" + CStr(rw("ref_ledger_ord_serial")) + "," + CStr(rw("ref_ledger_ord_rev")) + ",'" + rw("ref_ledger_ord_type") + "','PAID'," + tCheckNum.Text + "," + CStr(rw("amt") * -1) + ",'" + User + "','" + CStr(Now) + "')"
                cmd.ExecuteNonQuery()
            Next
            cnn.Close()
            dsOrd.Clear()
            tCheckNum.Text = ""
            lAmount.Text = "$0.00"
            LoadNames()
        Catch
            DoError(Err, Me)
        Finally
            If cnn.State <> ConnectionState.Closed Then cnn.Close()
            Button1.Enabled = True
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DisplayReport("referral payment record", "{ref_file.ref_name} = '" + NamesList.SelectedItem + "'", True)
    End Sub
End Class
