Public Class fmOrdTaxOverride
    Inherits System.Windows.Forms.Form
    Public Accepted As Boolean = False
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
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tPerc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tAmt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tPerc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tAmt = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(24, 64)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(104, 24)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "Accept"
        '
        'UltraLabel1
        '
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.Location = New System.Drawing.Point(136, 64)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(232, 24)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Set both to 0 to allow tax to be calculated."
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tax Fixed Amount"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "OR"
        '
        'tPerc
        '
        Me.tPerc.Location = New System.Drawing.Point(232, 8)
        Me.tPerc.Name = "tPerc"
        Me.tPerc.Size = New System.Drawing.Size(104, 20)
        Me.tPerc.TabIndex = 5
        Me.tPerc.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(232, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tax Rate (eg 0.05 = 5%)"
        '
        'tAmt
        '
        Me.tAmt.Location = New System.Drawing.Point(8, 8)
        Me.tAmt.Name = "tAmt"
        Me.tAmt.Size = New System.Drawing.Size(144, 20)
        Me.tAmt.TabIndex = 7
        Me.tAmt.Text = ""
        Me.tAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fmOrdTaxOverride
        '
        Me.AcceptButton = Me.UltraButton1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 94)
        Me.Controls.Add(Me.tAmt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tPerc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraButton1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmOrdTaxOverride"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tax Override"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        If (Not IsNumeric(tAmt.Text)) And (Not IsNumeric(tPerc.Text)) Then
            MsgBox("Must be numeric.", MsgBoxStyle.OKOnly, "Numeric?")
            tAmt.Focus()
            Exit Sub
        End If
        Accepted = True
        Me.Hide()
    End Sub

    Private Sub fmOrdTaxOverride_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tAmt.SelectAll()
    End Sub

    Private Sub UltraLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraLabel1.Click

    End Sub

    Private Sub tPerc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPerc.TextChanged
        If Me.ActiveControl Is tPerc Then tAmt.Text = ""
    End Sub

    Private Sub tAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tAmt.TextChanged
        If Me.ActiveControl Is tAmt Then tPerc.Text = ""
    End Sub
End Class
