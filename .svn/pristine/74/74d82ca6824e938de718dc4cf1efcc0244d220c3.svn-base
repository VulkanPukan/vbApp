Imports System.data.SqlClient
Public Class fmPriceIncrease
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
    Friend WithEvents tCust As System.Windows.Forms.ListBox
    Friend WithEvents tCustNo As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tPercent As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tCust = New System.Windows.Forms.ListBox
        Me.tCustNo = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tDate = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.tPercent = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'tCust
        '
        Me.tCust.Location = New System.Drawing.Point(176, 32)
        Me.tCust.Name = "tCust"
        Me.tCust.Size = New System.Drawing.Size(256, 667)
        Me.tCust.TabIndex = 0
        '
        'tCustNo
        '
        Me.tCustNo.Location = New System.Drawing.Point(440, 32)
        Me.tCustNo.Name = "tCustNo"
        Me.tCustNo.Size = New System.Drawing.Size(256, 667)
        Me.tCustNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Give Price Increase To:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(440, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DO NOT Give Price Increase To:"
        '
        'tDate
        '
        Me.tDate.Location = New System.Drawing.Point(16, 32)
        Me.tDate.Name = "tDate"
        Me.tDate.Size = New System.Drawing.Size(136, 20)
        Me.tDate.TabIndex = 4
        Me.tDate.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Start Date"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Update Prices"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Percent (eg 5 = 5%)"
        '
        'tPercent
        '
        Me.tPercent.Location = New System.Drawing.Point(16, 80)
        Me.tPercent.Name = "tPercent"
        Me.tPercent.Size = New System.Drawing.Size(136, 20)
        Me.tPercent.TabIndex = 7
        Me.tPercent.Text = ""
        '
        'fmPriceIncrease
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1136, 726)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tPercent)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tCustNo)
        Me.Controls.Add(Me.tCust)
        Me.Name = "fmPriceIncrease"
        Me.Text = "fmPriceIncrease"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmPriceIncrease_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("select * from cust_file order by cust_id", cnn)
        Dim dr As SqlDataReader

        cnn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            tCust.Items.Add(dr("cust_id") + " - " + dr("cust_name"))
        Loop
        cnn.Close()
    End Sub

    Private Sub tCust_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCust.SelectedIndexChanged

    End Sub

    Private Sub tCust_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCust.Click

    End Sub

    Private Sub tCust_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCust.DoubleClick
        tCustNo.Items.Add(tCust.SelectedItem)
        tCust.Items.RemoveAt(tCust.SelectedIndex)
    End Sub

    Private Sub tCustNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCustNo.SelectedIndexChanged

    End Sub

    Private Sub tCustNo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCustNo.DoubleClick
        tCust.Items.Add(tCustNo.SelectedItem)
        tCustNo.Items.RemoveAt(tCustNo.SelectedIndex)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you ready to update pricing by " + tPercent.Text + "% ?", MsgBoxStyle.YesNo, "Update") = MsgBoxResult.Yes Then
            Dim cmd As New SqlCommand("", cnn)
            Dim Customers As String = ""
            Dim Cust As String

            For Each Cust In tCustNo.Items
                Customers += "'" + Split(Cust, " - ")(0) + "',"
            Next
            If Customers = "" Then Customers = "'''"
            If Len(Customers) > 1 Then Customers = Mid(Customers, 1, Len(Customers) - 1)

            cnn.Open()
            cmd.CommandText = "update itm_price set itm_price_end='" + tDate.Text + "' where itm_price_end > '" + tDate.Text + "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale,itm_price_flat_rate) select itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,ROUND(itm_price_price + itm_price_price * " + tPercent.Text + " / 100, 2),'" + tDate.Text + "','12/31/2099',itm_price_sale,itm_price_flat_rate FROM itm_price left outer join itm_file on itm_price_itm_code=itm_code WHERE (itm_price_end = '1/1/2008') and itm_prod_type<>'SHIP'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update itm_price set itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, CDate(tDate.Text))) + "' where itm_price_end = '" + tDate.Text + "'"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "update cust_itm_price set cust_itm_price_end='" + tDate.Text + "' where cust_itm_price_end > '" + tDate.Text + "' and cust_itm_price_cust_id not in (" + Customers + ") and tmp='x'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_cust_id,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_price,cust_itm_price_start,cust_itm_price_end) select cust_itm_price_cust_serial,cust_itm_price_cust_id,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,ROUND(cust_itm_price_price + cust_itm_price_price * " + tPercent.Text + " / 100, 2),'" + tDate.Text + "','12/31/2099' FROM cust_itm_price left outer join itm_file on cust_itm_price_itm_code=itm_code WHERE (cust_itm_price_end = '1/1/2008') and cust_itm_price_cust_id not in (" + Customers + ") and tmp='x' and itm_prod_type<>'SHIP'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update cust_itm_price set cust_itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, CDate(tDate.Text))) + "' where cust_itm_price_end = '" + tDate.Text + "' and cust_itm_price_cust_id not in (" + Customers + ") and tmp='x'"
            cmd.ExecuteNonQuery()
            cnn.Close()
        End If
    End Sub
End Class
