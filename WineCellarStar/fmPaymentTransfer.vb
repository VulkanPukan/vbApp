Public Class fmPaymentTransfer
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
    Friend WithEvents tFrom As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tTo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lName As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bGo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lNameTo As System.Windows.Forms.Label
    Friend WithEvents lPayments As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.tFrom = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tTo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lName = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lNameTo = New System.Windows.Forms.Label
        Me.bGo = New Infragistics.Win.Misc.UltraButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lPayments = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.tFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tFrom
        '
        Me.tFrom.Location = New System.Drawing.Point(16, 16)
        Me.tFrom.Name = "tFrom"
        Me.tFrom.NullText = "123456-0-0"
        Appearance1.ForeColor = System.Drawing.Color.Silver
        Me.tFrom.NullTextAppearance = Appearance1
        Me.tFrom.Size = New System.Drawing.Size(144, 21)
        Me.tFrom.TabIndex = 0
        '
        'tTo
        '
        Me.tTo.Location = New System.Drawing.Point(16, 160)
        Me.tTo.Name = "tTo"
        Me.tTo.NullText = "123456-0-0"
        Appearance2.ForeColor = System.Drawing.Color.Silver
        Me.tTo.NullTextAppearance = Appearance2
        Me.tTo.Size = New System.Drawing.Size(144, 21)
        Me.tTo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From Order"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To Order"
        '
        'lName
        '
        Me.lName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lName.Location = New System.Drawing.Point(184, 16)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(384, 16)
        Me.lName.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(184, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 72)
        Me.Panel1.TabIndex = 5
        '
        'lNameTo
        '
        Me.lNameTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNameTo.Location = New System.Drawing.Point(176, 160)
        Me.lNameTo.Name = "lNameTo"
        Me.lNameTo.Size = New System.Drawing.Size(384, 16)
        Me.lNameTo.TabIndex = 6
        '
        'bGo
        '
        Me.bGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGo.Location = New System.Drawing.Point(64, 304)
        Me.bGo.Name = "bGo"
        Me.bGo.Size = New System.Drawing.Size(136, 32)
        Me.bGo.TabIndex = 7
        Me.bGo.Text = "Transfer"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Amount"
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.Location = New System.Drawing.Point(16, 224)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Appearance3.ForeColor = System.Drawing.Color.Silver
        Me.UltraTextEditor1.NullTextAppearance = Appearance3
        Me.UltraTextEditor1.Size = New System.Drawing.Size(144, 21)
        Me.UltraTextEditor1.TabIndex = 8
        '
        'lPayments
        '
        Me.lPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPayments.Location = New System.Drawing.Point(480, 128)
        Me.lPayments.Name = "lPayments"
        Me.lPayments.Size = New System.Drawing.Size(88, 24)
        Me.lPayments.TabIndex = 10
        Me.lPayments.Text = "$0.00"
        Me.lPayments.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(384, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total Payments"
        '
        'fmPaymentTransfer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(128, Byte))
        Me.ClientSize = New System.Drawing.Size(840, 590)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lPayments)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UltraTextEditor1)
        Me.Controls.Add(Me.bGo)
        Me.Controls.Add(Me.lNameTo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tTo)
        Me.Controls.Add(Me.tFrom)
        Me.Name = "fmPaymentTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Transfer"
        CType(Me.tFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub tFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFrom.ValueChanged

    End Sub

    Private Sub tFrom_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrom.Leave
        Dim cmd As New SqlClient.SqlCommand("select case when isnull(ord_sold_company,'')='' then ord_sold_name else ord_sold_company end from ord_file where ord_serial=" + Split(tFrom.Text, "-")(0), cnn)
        Dim dr As SqlClient.SqlDataReader
        Dim lb As Label
        Dim pos As Integer = 0
        Dim tot As Double

        cnn.Open()
        lName.Text = nz(cmd.ExecuteScalar)
        cmd.CommandText = "select pay_method,pay_date,pay_itm_amt from pay_file, pay_itm where pay_serial=pay_itm_pay_serial and pay_itm_ord_serial=" + Split(tFrom.Text, "-")(0) + " and pay_itm_ord_rev=" + Split(tFrom.Text, "-")(2) + " order by pay_date"
        dr = (cmd.ExecuteReader)
        Panel1.Controls.Clear()

        Do While dr.Read
            lb = New Label
            lb.Text = "Paid on " + CStr(dr("pay_date")) + " by " + dr("pay_method") + " for " + FormatCurrency(dr("pay_itm_amt"))
            lb.Top = pos
            lb.Width = 500
            lb.Height = 15

            Panel1.Controls.Add(lb)
            tot += dr("pay_itm_amt")
            pos += 18
        Loop

        lPayments.Text = FormatCurrency(tot)
        cnn.Close()
    End Sub

    Private Sub tTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTo.ValueChanged

    End Sub

    Private Sub tTo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tTo.Leave
        Dim cmd As New SqlClient.SqlCommand("select case when isnull(ord_sold_company,'')='' then ord_sold_name else ord_sold_company end from ord_file where ord_serial=" + Split(tTo.Text, "-")(0), cnn)

        cnn.Open()
        lNameTo.Text = nz(cmd.ExecuteScalar)
        cmd.CommandText = "select pay_method,pay_date,pay_itm_amt from pay_file, pay_itm where pay_serial=pay_itm_pay_serial and pay_itm_ord_serial=" + Split(tTo.Text, "-")(0) + " and pay_itm_ord_rev=" + Split(tTo.Text, "-")(2) + " order by pay_date"
        cnn.Close()

    End Sub
End Class
