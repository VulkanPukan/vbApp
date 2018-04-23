Public Class fmShipPrinterFedex
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
    Friend WithEvents tPrinter As System.Windows.Forms.TextBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tPrinter = New System.Windows.Forms.TextBox
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.SuspendLayout()
        '
        'tPrinter
        '
        Me.tPrinter.Location = New System.Drawing.Point(8, 8)
        Me.tPrinter.Name = "tPrinter"
        Me.tPrinter.Size = New System.Drawing.Size(248, 20)
        Me.tPrinter.TabIndex = 0
        Me.tPrinter.Text = ""
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(16, 40)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "Save"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(112, 40)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton2.TabIndex = 2
        Me.UltraButton2.Text = "Test"
        '
        'fmShipPrinterFedex
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(264, 78)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.tPrinter)
        Me.Name = "fmShipPrinterFedex"
        Me.Text = "Enter FedEx Label Printer"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmShipPrinterFedex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tPrinter.Text = GetSetting("Jcom", "Shipping", "PrinterFedEx", "")

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        SaveSetting("Jcom", "Shipping", "PrinterFedEx", tPrinter.Text)

    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        IO.File.Copy("\\10.0.0.245\jcom$\printtest.txt", tPrinter.Text)
    End Sub
End Class
