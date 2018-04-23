Imports System.Data.SqlClient
Public Class fmShipBillReprint
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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(8, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(272, 420)
        Me.ListBox1.TabIndex = 0
        '
        'UltraButton1
        '
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(48, 464)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(184, 32)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "Reprint Reports"
        '
        'fmShipBillReprint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 502)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "fmShipBillReprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fmShipBillReprint"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmShipBillReprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("select distinct ship_bill_invoice from ship_bill order by ship_bill_invoice desc", cnn)
        Dim dr As SqlDataReader

        cnn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            ListBox1.Items.Add(dr("ship_bill_invoice"))
        Loop
        dr.Close()
        cnn.Close()


    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        DisplayReport("shipping late", , True, 1, ListBox1.SelectedItem)
        DisplayReport("Shipping - Items not matched from bill.rpt", , True, 1, ListBox1.SelectedItem)
        Me.Close()
    End Sub
End Class
