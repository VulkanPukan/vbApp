Public Class fmOrdPrintDuke
    Inherits System.Windows.Forms.Form
    Public fm As fmEstOrd2
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
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents l4 As System.Windows.Forms.Label
    Friend WithEvents l5 As System.Windows.Forms.Label
    Friend WithEvents l6 As System.Windows.Forms.Label
    Friend WithEvents Step1 As System.Windows.Forms.Label
    Friend WithEvents Step2 As System.Windows.Forms.Label
    Friend WithEvents Step3 As System.Windows.Forms.Label
    Friend WithEvents Step4 As System.Windows.Forms.Label
    Friend WithEvents Step5 As System.Windows.Forms.Label
    Friend WithEvents Step6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Step1 = New System.Windows.Forms.Label
        Me.Step2 = New System.Windows.Forms.Label
        Me.Step3 = New System.Windows.Forms.Label
        Me.Step4 = New System.Windows.Forms.Label
        Me.Step5 = New System.Windows.Forms.Label
        Me.Step6 = New System.Windows.Forms.Label
        Me.l1 = New System.Windows.Forms.Label
        Me.l2 = New System.Windows.Forms.Label
        Me.l3 = New System.Windows.Forms.Label
        Me.l4 = New System.Windows.Forms.Label
        Me.l5 = New System.Windows.Forms.Label
        Me.l6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Step1
        '
        Me.Step1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step1.Location = New System.Drawing.Point(40, 8)
        Me.Step1.Name = "Step1"
        Me.Step1.Size = New System.Drawing.Size(176, 16)
        Me.Step1.TabIndex = 0
        Me.Step1.Text = "Print DUKE PDF"
        '
        'Step2
        '
        Me.Step2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step2.Location = New System.Drawing.Point(40, 32)
        Me.Step2.Name = "Step2"
        Me.Step2.Size = New System.Drawing.Size(176, 16)
        Me.Step2.TabIndex = 1
        Me.Step2.Text = "Calculate DUKE1 Pricing"
        '
        'Step3
        '
        Me.Step3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step3.Location = New System.Drawing.Point(40, 56)
        Me.Step3.Name = "Step3"
        Me.Step3.Size = New System.Drawing.Size(176, 16)
        Me.Step3.TabIndex = 2
        Me.Step3.Text = "Print DUKE1 PDF"
        '
        'Step4
        '
        Me.Step4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step4.Location = New System.Drawing.Point(40, 80)
        Me.Step4.Name = "Step4"
        Me.Step4.Size = New System.Drawing.Size(176, 16)
        Me.Step4.TabIndex = 3
        Me.Step4.Text = "Calculate RETAIL Pricing"
        '
        'Step5
        '
        Me.Step5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step5.Location = New System.Drawing.Point(40, 104)
        Me.Step5.Name = "Step5"
        Me.Step5.Size = New System.Drawing.Size(176, 16)
        Me.Step5.TabIndex = 4
        Me.Step5.Text = "Print RETAIL PDF"
        '
        'Step6
        '
        Me.Step6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step6.Location = New System.Drawing.Point(40, 128)
        Me.Step6.Name = "Step6"
        Me.Step6.Size = New System.Drawing.Size(176, 16)
        Me.Step6.TabIndex = 5
        Me.Step6.Text = "Reset DUKE Pricing"
        '
        'l1
        '
        Me.l1.Font = New System.Drawing.Font("Wingdings", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.l1.Location = New System.Drawing.Point(8, 0)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(24, 24)
        Me.l1.TabIndex = 6
        Me.l1.Text = "C"
        Me.l1.Visible = False
        '
        'l2
        '
        Me.l2.Font = New System.Drawing.Font("Wingdings", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.l2.Location = New System.Drawing.Point(8, 24)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(24, 24)
        Me.l2.TabIndex = 7
        Me.l2.Text = "C"
        Me.l2.Visible = False
        '
        'l3
        '
        Me.l3.Font = New System.Drawing.Font("Wingdings", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.l3.Location = New System.Drawing.Point(8, 48)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(24, 24)
        Me.l3.TabIndex = 8
        Me.l3.Text = "C"
        Me.l3.Visible = False
        '
        'l4
        '
        Me.l4.Font = New System.Drawing.Font("Wingdings", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.l4.Location = New System.Drawing.Point(8, 72)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(24, 24)
        Me.l4.TabIndex = 9
        Me.l4.Text = "C"
        Me.l4.Visible = False
        '
        'l5
        '
        Me.l5.Font = New System.Drawing.Font("Wingdings", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.l5.Location = New System.Drawing.Point(8, 96)
        Me.l5.Name = "l5"
        Me.l5.Size = New System.Drawing.Size(24, 24)
        Me.l5.TabIndex = 10
        Me.l5.Text = "C"
        Me.l5.Visible = False
        '
        'l6
        '
        Me.l6.Font = New System.Drawing.Font("Wingdings", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.l6.Location = New System.Drawing.Point(8, 120)
        Me.l6.Name = "l6"
        Me.l6.Size = New System.Drawing.Size(24, 24)
        Me.l6.TabIndex = 11
        Me.l6.Text = "C"
        Me.l6.Visible = False
        '
        'fmOrdPrintDuke
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(208, 166)
        Me.Controls.Add(Me.l6)
        Me.Controls.Add(Me.l5)
        Me.Controls.Add(Me.l4)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.Step6)
        Me.Controls.Add(Me.Step5)
        Me.Controls.Add(Me.Step4)
        Me.Controls.Add(Me.Step3)
        Me.Controls.Add(Me.Step2)
        Me.Controls.Add(Me.Step1)
        Me.Name = "fmOrdPrintDuke"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Duke Quote"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmOrdPrintDuke_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub DoIt()
        Try
            Dim x As Integer
            Dim Output, OnSalesCat As String

            OnSalesCat = fm.tSalesCat.Text
            QuietMode = True
            fm.Focus()

            Step1.BackColor = Color.Yellow
            Output = PDFPath + fm.tOrd.Text + " (" + fm.tord_for.Text + ")\" + fm.tOrd.Text + "-" + Mid(fm.Tab1.ActiveTab.Key, 2) + " (" + fm.tord_for.Text + ") QUOTE - " + fm.tSalesCat.Text + ".pdf"
            DisplayReport("quote landscape", "{ord_file.ord_serial} = " + fm.tOrd.Text + " and {ord_gen.ord_gen_rev} = " + Mid(fm.Tab1.ActiveTab.Key, 2) + " and {ord_gen.ord_gen_type}='Q'", True, 1, True, , False, False, , , Output)
            l1.Visible = True
            Step1.Font = New Font(Step1.Font, FontStyle.Bold)
            Step1.BackColor = Nothing

            Step2.BackColor = Color.Yellow
            fm.Edit()
            fm.tCustId.Text = "DUKE1"
            For x = 0 To fm.Grid1.Rows.Count - 1
                fm.Grid1.Focus()
                If x < fm.Grid1.Rows.Count Then
                    fm.Grid1.Rows(x).Activate()
                    fm.Grid1.ActiveRow.Cells("ord_itm_item_code").Activate()
                    Application.DoEvents()
                    fm.LoadPrice()
                    fm.PriceCalc()
                End If
            Next
            fm.Save()
            l2.Visible = True
            Step2.Font = New Font(Step1.Font, FontStyle.Bold)
            Step2.BackColor = Nothing

            Step3.BackColor = Color.Yellow
            Output = PDFPath + fm.tOrd.Text + " (" + fm.tord_for.Text + ")\" + fm.tOrd.Text + "-" + Mid(fm.Tab1.ActiveTab.Key, 2) + " (" + fm.tord_for.Text + ") QUOTE - " + fm.tSalesCat.Text + " DUKE1.pdf"
            DisplayReport("quote landscape", "{ord_file.ord_serial} = " + fm.tOrd.Text + " and {ord_gen.ord_gen_rev} = " + Mid(fm.Tab1.ActiveTab.Key, 2) + " and {ord_gen.ord_gen_type}='Q'", True, 1, True, , False, False, , , Output)
            l3.Visible = True
            Step3.Font = New Font(Step1.Font, FontStyle.Bold)
            Step3.BackColor = Nothing

            Step4.BackColor = Color.Yellow
            fm.Edit()
            fm.tCustId.Text = ""
            fm.tSalesCat.Text = "RET"
            For x = 0 To fm.Grid1.Rows.Count - 1
                fm.Grid1.Focus()
                If x < fm.Grid1.Rows.Count Then
                    fm.Grid1.Rows(x).Activate()
                    fm.Grid1.ActiveRow.Cells("ord_itm_item_code").Activate()
                    Application.DoEvents()
                    fm.LoadPrice()
                    fm.PriceCalc()
                End If
            Next
            QuietMode = True
            fm.Save()
            QuietMode = False
            l4.Visible = True
            Step4.Font = New Font(Step1.Font, FontStyle.Bold)
            Step4.BackColor = Nothing

            Step5.BackColor = Color.Yellow
            Output = PDFPath + fm.tOrd.Text + " (" + fm.tord_for.Text + ")\" + fm.tOrd.Text + "-" + Mid(fm.Tab1.ActiveTab.Key, 2) + " (" + fm.tord_for.Text + ") QUOTE - " + fm.tSalesCat.Text + " RETAIL.pdf"
            DisplayReport("quote landscape", "{ord_file.ord_serial} = " + fm.tOrd.Text + " and {ord_gen.ord_gen_rev} = " + Mid(fm.Tab1.ActiveTab.Key, 2) + " and {ord_gen.ord_gen_type}='Q'", True, 1, True, , False, False, , , Output)
            fm.tSalesCat.Text = OnSalesCat
            l5.Visible = True
            Step5.Font = New Font(Step1.Font, FontStyle.Bold)
            Step5.BackColor = Nothing

            Step6.BackColor = Color.Yellow
            fm.Edit()
            fm.tCustId.Text = "DUKE"
            For x = 0 To fm.Grid1.Rows.Count - 1
                fm.Grid1.Focus()
                If x < fm.Grid1.Rows.Count Then
                    fm.Grid1.Rows(x).Activate()
                    fm.Grid1.ActiveRow.Cells("ord_itm_item_code").Activate()
                    Application.DoEvents()
                    fm.LoadPrice()
                    fm.PriceCalc()
                End If
            Next
            fm.Save()
            l6.Visible = True
            Step6.Font = New Font(Step1.Font, FontStyle.Bold)
            Step6.BackColor = Nothing

            Me.Close()
        Catch
            DoError(Err, Me)
        Finally
            QuietMode = False
        End Try
    End Sub
End Class
