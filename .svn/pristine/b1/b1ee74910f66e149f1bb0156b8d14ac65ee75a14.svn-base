Imports System.Data.SqlClient
Public Class fmUpdateISR
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
    Friend WithEvents Bar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Bar1 = New System.Windows.Forms.ProgressBar
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.Location = New System.Drawing.Point(16, 16)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(344, 16)
        Me.Bar1.TabIndex = 0
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(120, 48)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(136, 40)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "Start"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 16)
        Me.Label1.TabIndex = 2
        '
        'fmUpdateISR
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(376, 110)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.Bar1)
        Me.Name = "fmUpdateISR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update ISR from Speed Codes"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim cmd As New SqlCommand("", cnn)
        Dim ds As New DataSet
        Dim dsRep As New DataSet
        Dim dsOrd As New DataSet
        Dim dr As SqlDataReader
        Dim drOrd As DataRow
        Dim cnt As Integer = 0
        Dim cmd2 As New SqlCommand("", cnn2)
        Dim da As New SqlDataAdapter(cmd2)
        Dim ISR, OSR As String
        Dim zips As String
        Dim row As DataRow
        Dim Zip As Integer
        Dim doOutside As Boolean
        Dim rowCnt As Integer

        UltraButton1.Enabled = False
        cnn.Open()
        cnn2.Open()

        '********* Start here to figure out total count and then test.
        cmd.CommandText = "select count(ord_gen_serial) from ord_gen,ord_file where ord_gen_ord_serial=ord_serial and ord_gen_type='Q' or (ord_gen_type='O' and ord_gen_balance<>0)"
        rowCnt = cmd.ExecuteScalar
        cmd.CommandText = "select ord_gen_serial,ord_sold_cust_id,ord_sold_state,ord_sold_zip,ord_gen_create_date from ord_gen,ord_file where ord_gen_ord_serial=ord_serial and ord_gen_type='Q' or (ord_gen_type='O' and ord_gen_balance<>0)"
        dr = cmd.ExecuteReader

        Do While dr.Read
            OSR = "NONE"
            ISR = "NONE"
            If nz(dr("ord_sold_state")) <> "" Then
                cmd2.CommandText = "select * from rep_ter where rep_ter_state='" + dr("ord_sold_state") + "' and rep_ter_start<='" + CStr(dr("ord_gen_create_date")) + "' and rep_ter_end>='" + CStr(dr("ord_gen_create_date")) + "'"
                da.Fill(dsRep, "rep")
                If dsRep.Tables("rep").Rows.Count > 0 Then
                    For Each row In dsRep.Tables("rep").Rows
                        If nz(row("rep_ter_zip")) <> "" Then
                            If nz(dr("ord_sold_zip")) <> "" Then
                                For Each zips In Split(row("rep_ter_zip"), ",")
                                    For Zip = CInt(Split(zips, "-")(0)) To CInt(Split(zips, "-")(Split(zips, "-").Length - 1))
                                        If Mid(dr("ord_sold_zip"), 1, 3) = Mid(Trim(Zip), 1, 3) Then
                                            OSR = row("rep_ter_out_rep_code")
                                            ISR = row("rep_ter_in_rep_code")
                                            Exit For
                                        End If
                                    Next
                                Next
                            End If
                        Else
                            OSR = row("rep_ter_out_rep_code")
                            ISR = row("rep_ter_in_rep_code")
                            Exit For
                        End If
                    Next
                End If
            End If
            'cnn2.Open()
            If nz(dr("ord_sold_cust_id")) <> "" Then
                cmd2.CommandText = "select cust_rep from cust_file where cust_id='" + dr("ord_sold_cust_id") + "'"
                ISR = cmd2.ExecuteScalar
            End If


            Label1.Text = dr("ord_sold_cust_id")
            Application.DoEvents()
            cmd2.CommandText = "update ord_gen set ord_gen_inside='" + ISR + "',ord_gen_outside='" + OSR + "' where ord_gen_serial=" + CStr(dr("ord_gen_serial")) + ")"
            cmd2.ExecuteNonQuery()
            cnt += 1
            Bar1.Value = cnt / rowCnt * 100
            Application.DoEvents()
        Loop
        cnn.Close()
        Label1.Text = "Done."
        UltraButton1.Enabled = True
    End Sub
End Class
