Public Class fmStaged
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
    Friend WithEvents tOrder As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tRev As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents List1 As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tOrder = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.tDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.tRev = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.List1 = New System.Windows.Forms.ListBox
        CType(Me.tOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tOrder
        '
        Me.tOrder.Location = New System.Drawing.Point(16, 16)
        Me.tOrder.Name = "tOrder"
        Me.tOrder.Size = New System.Drawing.Size(128, 21)
        Me.tOrder.TabIndex = 0
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(16, 40)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Order to Stage"
        '
        'tDate
        '
        Me.tDate.Location = New System.Drawing.Point(16, 120)
        Me.tDate.Name = "tDate"
        Me.tDate.Size = New System.Drawing.Size(128, 21)
        Me.tDate.TabIndex = 3
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(16, 144)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Date to Stage"
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(16, 176)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(128, 40)
        Me.UltraButton1.TabIndex = 5
        Me.UltraButton1.Text = "Stage Orders"
        '
        'tRev
        '
        Me.tRev.Location = New System.Drawing.Point(152, 16)
        Me.tRev.Name = "tRev"
        Me.tRev.Size = New System.Drawing.Size(40, 21)
        Me.tRev.TabIndex = 6
        Me.tRev.Text = "0"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(152, 40)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(40, 16)
        Me.UltraLabel3.TabIndex = 7
        Me.UltraLabel3.Text = "Rev"
        '
        'List1
        '
        Me.List1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.List1.Location = New System.Drawing.Point(240, 16)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(536, 524)
        Me.List1.TabIndex = 8
        '
        'fmStaged
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(824, 566)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.tRev)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.tDate)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.tOrder)
        Me.Name = "fmStaged"
        Me.Text = "Stage Orders"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmStaged_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tOrder_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tOrder.ValueChanged

    End Sub

    Private Sub tOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tOrder.KeyPress
    End Sub

    Private Sub tOrder_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tOrder.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                Dim cmd As New SqlClient.SqlCommand("select * from ord_gen where ord_gen_ord_serial=" + tOrder.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='O'", cnn)
                Dim dr As SqlClient.SqlDataReader
                Dim cmd2 As New SqlClient.SqlCommand
                cmd2.Connection = cnn2

                cnn.Open()
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Do While dr.Read
                        Select Case nz(dr("ord_gen_status"), "")
                            Case "PROCESS"
                                cmd2.CommandText = "update ord_gen set ord_gen_staged=1,ord_gen_staged_date='" + CStr(tDate.Value) + "',ord_gen_status='STAGED' where ord_gen_ord_serial=" + tOrder.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='O'"
                                cnn2.Open()
                                cmd2.ExecuteNonQuery()
                                cmd2.CommandText = "insert into status_trans (status_date,status_user,status) values ('" + CStr(Now) + "','" + User + "','STAGED')"
                                cmd2.ExecuteNonQuery()
                                cnn2.Close()
                                List1.Items.Add("STAGED - " + CStr(dr("ord_gen_ord_serial")) + " REV " + CStr(dr("ord_gen_rev")))
                            Case "STAGED"
                                If MsgBox("This order has ALREADY BEEN STAGED.  Do you want to put this order back into PROCESS?", MsgBoxStyle.YesNo, "Already Staged?") = MsgBoxResult.Yes Then
                                    If MsgBox("Are you sure you want to put this order back into PROCESS?", MsgBoxStyle.YesNo, "PROCESS?") = MsgBoxResult.Yes Then
                                        cmd2.CommandText = "update ord_gen set ord_gen_staged=0,ord_gen_staged_date=null,ord_gen_status='PROCESS' where ord_gen_ord_serial=" + tOrder.Text + " and ord_gen_rev=" + tRev.Text + " and ord_gen_type='O'"
                                        cnn2.Open()
                                        cmd2.ExecuteNonQuery()
                                        cmd2.CommandText = "insert into status_trans (status_date,status_user,status) values ('" + CStr(Now) + "','" + User + "','STAGED')"
                                        cmd2.ExecuteNonQuery()
                                        cnn2.Close()
                                        List1.Items.Add("Back into PROCESS - " + CStr(dr("ord_gen_ord_serial")) + " REV " + CStr(dr("ord_gen_rev")))
                                    End If
                                End If
                            Case Else
                                MsgBox("Order is not status 'PROCESS'.  Only orders in PROCESS and be staged.", MsgBoxStyle.Information, "Not is PROCESS")
                        End Select
                    Loop
                Else
                    MsgBox("Order not found.", MsgBoxStyle.Information, "Order?")
                End If
                cnn.Close()
            End If
        Catch
            DoError(Err, Me)
        End Try

    End Sub
End Class
