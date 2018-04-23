Imports System.Data.SqlClient
Public Class fmImport
    Inherits System.Windows.Forms.Form
    Dim cnn0 As New SqlConnection
    Friend WithEvents Button59 As System.Windows.Forms.Button
    Friend WithEvents Button60 As System.Windows.Forms.Button
    Friend WithEvents Button61 As System.Windows.Forms.Button
    Friend WithEvents Button62 As System.Windows.Forms.Button
    Dim fo As IO.StreamWriter

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Bar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lMin As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tErr As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents tOrd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents bAddRef As System.Windows.Forms.Button
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents Button41 As System.Windows.Forms.Button
    Friend WithEvents Button42 As System.Windows.Forms.Button
    Friend WithEvents Button43 As System.Windows.Forms.Button
    Friend WithEvents Button44 As System.Windows.Forms.Button
    Friend WithEvents Button45 As System.Windows.Forms.Button
    Friend WithEvents Button46 As System.Windows.Forms.Button
    Friend WithEvents Button47 As System.Windows.Forms.Button
    Friend WithEvents Button48 As System.Windows.Forms.Button
    Friend WithEvents Button49 As System.Windows.Forms.Button
    Friend WithEvents Button50 As System.Windows.Forms.Button
    Friend WithEvents Button51 As System.Windows.Forms.Button
    Friend WithEvents Button52 As System.Windows.Forms.Button
    Friend WithEvents Button53 As System.Windows.Forms.Button
    Friend WithEvents Button54 As System.Windows.Forms.Button
    Friend WithEvents Button55 As System.Windows.Forms.Button
    Friend WithEvents Button56 As System.Windows.Forms.Button
    Friend WithEvents Button57 As System.Windows.Forms.Button
    Friend WithEvents Button58 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Button1 = New System.Windows.Forms.Button
        Me.Bar1 = New System.Windows.Forms.ProgressBar
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.lMin = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.tErr = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.tOrd = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button22 = New System.Windows.Forms.Button
        Me.Button23 = New System.Windows.Forms.Button
        Me.Button24 = New System.Windows.Forms.Button
        Me.Button25 = New System.Windows.Forms.Button
        Me.Button26 = New System.Windows.Forms.Button
        Me.Button27 = New System.Windows.Forms.Button
        Me.Button28 = New System.Windows.Forms.Button
        Me.Button29 = New System.Windows.Forms.Button
        Me.Button30 = New System.Windows.Forms.Button
        Me.Button31 = New System.Windows.Forms.Button
        Me.Button32 = New System.Windows.Forms.Button
        Me.Button33 = New System.Windows.Forms.Button
        Me.Button34 = New System.Windows.Forms.Button
        Me.Button35 = New System.Windows.Forms.Button
        Me.Button36 = New System.Windows.Forms.Button
        Me.Button37 = New System.Windows.Forms.Button
        Me.Button38 = New System.Windows.Forms.Button
        Me.bAddRef = New System.Windows.Forms.Button
        Me.Button39 = New System.Windows.Forms.Button
        Me.Button40 = New System.Windows.Forms.Button
        Me.Button41 = New System.Windows.Forms.Button
        Me.Button42 = New System.Windows.Forms.Button
        Me.Button43 = New System.Windows.Forms.Button
        Me.Button44 = New System.Windows.Forms.Button
        Me.Button45 = New System.Windows.Forms.Button
        Me.Button46 = New System.Windows.Forms.Button
        Me.Button47 = New System.Windows.Forms.Button
        Me.Button48 = New System.Windows.Forms.Button
        Me.Button49 = New System.Windows.Forms.Button
        Me.Button50 = New System.Windows.Forms.Button
        Me.Button51 = New System.Windows.Forms.Button
        Me.Button52 = New System.Windows.Forms.Button
        Me.Button53 = New System.Windows.Forms.Button
        Me.Button54 = New System.Windows.Forms.Button
        Me.Button55 = New System.Windows.Forms.Button
        Me.Button56 = New System.Windows.Forms.Button
        Me.Button57 = New System.Windows.Forms.Button
        Me.Button58 = New System.Windows.Forms.Button
        Me.Button59 = New System.Windows.Forms.Button
        Me.Button60 = New System.Windows.Forms.Button
        Me.Button61 = New System.Windows.Forms.Button
        Me.Button62 = New System.Windows.Forms.Button
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(125, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        '
        'Bar1
        '
        Me.Bar1.Location = New System.Drawing.Point(365, 9)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(489, 9)
        Me.Bar1.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(19, 65)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(240, 564)
        Me.ListBox1.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(298, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(211, 24)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "ComboBox1"
        '
        'ComboBox2
        '
        Me.ComboBox2.Location = New System.Drawing.Point(528, 65)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(182, 24)
        Me.ComboBox2.TabIndex = 5
        Me.ComboBox2.Text = "ComboBox2"
        '
        'Grid1
        '
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(730, 65)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(585, 258)
        Me.Grid1.TabIndex = 6
        '
        'ListBox2
        '
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(298, 92)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(211, 548)
        Me.ListBox2.TabIndex = 7
        '
        'ListBox3
        '
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(528, 92)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(182, 548)
        Me.ListBox3.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(528, 665)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(182, 22)
        Me.TextBox1.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(58, 748)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 27)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Upadate Cust Serial"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(58, 674)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 28)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Add Quotes/Orders"
        '
        'lMin
        '
        Me.lMin.Location = New System.Drawing.Point(730, 28)
        Me.lMin.Name = "lMin"
        Me.lMin.Size = New System.Drawing.Size(134, 18)
        Me.lMin.TabIndex = 12
        Me.lMin.Text = "0.0"
        '
        'UltraLabel1
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.Location = New System.Drawing.Point(557, 28)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(163, 18)
        Me.UltraLabel1.TabIndex = 13
        Me.UltraLabel1.Text = "Minutes Remaining:"
        '
        'tErr
        '
        Me.tErr.Location = New System.Drawing.Point(730, 83)
        Me.tErr.Multiline = True
        Me.tErr.Name = "tErr"
        Me.tErr.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tErr.Size = New System.Drawing.Size(585, 240)
        Me.tErr.TabIndex = 14
        Me.tErr.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(58, 711)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(163, 27)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Do List"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(58, 785)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(163, 27)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Upadate Payments"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(58, 822)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(163, 27)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Upadate Shipments"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(58, 858)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(163, 28)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "Upadate Bill Date"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(250, 674)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(163, 28)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "Do All Buttons"
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.Location = New System.Drawing.Point(58, 895)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(163, 28)
        Me.Button9.TabIndex = 20
        Me.Button9.Text = "Upadate Shipping"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(250, 868)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(163, 27)
        Me.Button10.TabIndex = 21
        Me.Button10.Text = "Discontinues"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(432, 729)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(163, 28)
        Me.Button11.TabIndex = 22
        Me.Button11.Text = "Import Price.txt"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(432, 766)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(163, 28)
        Me.Button12.TabIndex = 23
        Me.Button12.Text = "Import Line Item Notes"
        '
        'tOrd
        '
        Me.tOrd.Location = New System.Drawing.Point(614, 729)
        Me.tOrd.Name = "tOrd"
        Me.tOrd.Size = New System.Drawing.Size(135, 24)
        Me.tOrd.TabIndex = 24
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(614, 766)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(135, 28)
        Me.UltraButton1.TabIndex = 25
        Me.UltraButton1.Text = "Combine Order"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(432, 803)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(163, 28)
        Me.Button13.TabIndex = 26
        Me.Button13.Text = "Update Shipping Status"
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(432, 849)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(163, 28)
        Me.Button14.TabIndex = 27
        Me.Button14.Text = "Update Ship/Stage"
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(614, 822)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(125, 27)
        Me.Button15.TabIndex = 28
        Me.Button15.Text = "Item Price Report"
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(835, 978)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(125, 28)
        Me.Button16.TabIndex = 29
        Me.Button16.Text = "Update Totals"
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(432, 886)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(163, 28)
        Me.Button17.TabIndex = 30
        Me.Button17.Text = "Update Special Inst"
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(432, 923)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(163, 28)
        Me.Button18.TabIndex = 31
        Me.Button18.Text = "Update Ship Disc"
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(614, 877)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(154, 28)
        Me.Button19.TabIndex = 32
        Me.Button19.Text = "Import New Items"
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(250, 785)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(163, 27)
        Me.Button20.TabIndex = 33
        Me.Button20.Text = "Upadate Payments 2"
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(778, 785)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(124, 27)
        Me.Button21.TabIndex = 34
        Me.Button21.Text = "Button21"
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(778, 831)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(172, 27)
        Me.Button22.TabIndex = 35
        Me.Button22.Text = "Update Ship for ARCH"
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(778, 868)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(172, 27)
        Me.Button23.TabIndex = 36
        Me.Button23.Text = "Update Price DKS SRS"
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(778, 905)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(172, 27)
        Me.Button24.TabIndex = 37
        Me.Button24.Text = "Upd Sales Cat from Cust"
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(998, 988)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(183, 27)
        Me.Button25.TabIndex = 38
        Me.Button25.Text = "Ord_gen in Pay_itm"
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(1008, 951)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(115, 27)
        Me.Button26.TabIndex = 39
        Me.Button26.Text = "Test"
        '
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(1133, 951)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(182, 27)
        Me.Button27.TabIndex = 40
        Me.Button27.Text = "Add Sales Reps"
        '
        'Button28
        '
        Me.Button28.Location = New System.Drawing.Point(1142, 794)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(183, 28)
        Me.Button28.TabIndex = 41
        Me.Button28.Text = "Import Forecast"
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(1142, 831)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(183, 27)
        Me.Button29.TabIndex = 42
        Me.Button29.Text = "Lost Quotes"
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(1142, 868)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(183, 27)
        Me.Button30.TabIndex = 43
        Me.Button30.Text = "Forecast Ordered"
        '
        'Button31
        '
        Me.Button31.Location = New System.Drawing.Point(1142, 757)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(183, 28)
        Me.Button31.TabIndex = 44
        Me.Button31.Text = "Mark Lost or Not FC"
        '
        'Button32
        '
        Me.Button32.Location = New System.Drawing.Point(941, 785)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(144, 27)
        Me.Button32.TabIndex = 45
        Me.Button32.Text = "WE Pricing"
        '
        'Button33
        '
        Me.Button33.Location = New System.Drawing.Point(1142, 905)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(183, 27)
        Me.Button33.TabIndex = 46
        Me.Button33.Text = "Mark Revised"
        '
        'Button34
        '
        Me.Button34.Location = New System.Drawing.Point(970, 831)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(124, 27)
        Me.Button34.TabIndex = 47
        Me.Button34.Text = "IWA Pricing"
        '
        'Button35
        '
        Me.Button35.Location = New System.Drawing.Point(970, 868)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(124, 27)
        Me.Button35.TabIndex = 48
        Me.Button35.Text = "Update County"
        '
        'Button36
        '
        Me.Button36.Location = New System.Drawing.Point(614, 914)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(154, 28)
        Me.Button36.TabIndex = 49
        Me.Button36.Text = "Import Adjustments"
        '
        'Button37
        '
        Me.Button37.Location = New System.Drawing.Point(970, 905)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(153, 27)
        Me.Button37.TabIndex = 50
        Me.Button37.Text = "Update Pricing"
        '
        'Button38
        '
        Me.Button38.Location = New System.Drawing.Point(1229, 988)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(115, 27)
        Me.Button38.TabIndex = 51
        Me.Button38.Text = "Insert Shipping"
        '
        'bAddRef
        '
        Me.bAddRef.Location = New System.Drawing.Point(806, 942)
        Me.bAddRef.Name = "bAddRef"
        Me.bAddRef.Size = New System.Drawing.Size(125, 27)
        Me.bAddRef.TabIndex = 52
        Me.bAddRef.Text = "Add Referral"
        '
        'Button39
        '
        Me.Button39.Location = New System.Drawing.Point(730, 332)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(182, 28)
        Me.Button39.TabIndex = 53
        Me.Button39.Text = "Change OIL to STAIN 4/11/2007"
        '
        'Button40
        '
        Me.Button40.Location = New System.Drawing.Point(730, 369)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(182, 28)
        Me.Button40.TabIndex = 54
        Me.Button40.Text = "Update ord_gen_inside with 'INSIDE'"
        '
        'Button41
        '
        Me.Button41.Location = New System.Drawing.Point(730, 406)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(182, 28)
        Me.Button41.TabIndex = 55
        Me.Button41.Text = "Copy 2005 PDFs"
        '
        'Button42
        '
        Me.Button42.Location = New System.Drawing.Point(730, 443)
        Me.Button42.Name = "Button42"
        Me.Button42.Size = New System.Drawing.Size(182, 28)
        Me.Button42.TabIndex = 56
        Me.Button42.Text = "Update Forecast for WE"
        '
        'Button43
        '
        Me.Button43.Location = New System.Drawing.Point(730, 480)
        Me.Button43.Name = "Button43"
        Me.Button43.Size = New System.Drawing.Size(182, 28)
        Me.Button43.TabIndex = 57
        Me.Button43.Text = "Update Allow $0 Base"
        '
        'Button44
        '
        Me.Button44.Location = New System.Drawing.Point(730, 517)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(182, 28)
        Me.Button44.TabIndex = 58
        Me.Button44.Text = "Update BOM flags"
        '
        'Button45
        '
        Me.Button45.Location = New System.Drawing.Point(730, 554)
        Me.Button45.Name = "Button45"
        Me.Button45.Size = New System.Drawing.Size(182, 28)
        Me.Button45.TabIndex = 59
        Me.Button45.Text = "Import Box Dims"
        '
        'Button46
        '
        Me.Button46.Location = New System.Drawing.Point(730, 591)
        Me.Button46.Name = "Button46"
        Me.Button46.Size = New System.Drawing.Size(182, 27)
        Me.Button46.TabIndex = 60
        Me.Button46.Text = "Update Ord Terr with Cust Terr"
        '
        'Button47
        '
        Me.Button47.Location = New System.Drawing.Point(730, 628)
        Me.Button47.Name = "Button47"
        Me.Button47.Size = New System.Drawing.Size(182, 27)
        Me.Button47.TabIndex = 61
        Me.Button47.Text = "Update Tax Exempt"
        '
        'Button48
        '
        Me.Button48.Location = New System.Drawing.Point(922, 332)
        Me.Button48.Name = "Button48"
        Me.Button48.Size = New System.Drawing.Size(163, 28)
        Me.Button48.TabIndex = 62
        Me.Button48.Text = "Update Group No on Items"
        '
        'Button49
        '
        Me.Button49.Location = New System.Drawing.Point(922, 369)
        Me.Button49.Name = "Button49"
        Me.Button49.Size = New System.Drawing.Size(163, 28)
        Me.Button49.TabIndex = 63
        Me.Button49.Text = "Update Inside Rep from Customer"
        '
        'Button50
        '
        Me.Button50.Location = New System.Drawing.Point(922, 406)
        Me.Button50.Name = "Button50"
        Me.Button50.Size = New System.Drawing.Size(163, 28)
        Me.Button50.TabIndex = 64
        Me.Button50.Text = "Update Item Department"
        '
        'Button51
        '
        Me.Button51.Location = New System.Drawing.Point(922, 443)
        Me.Button51.Name = "Button51"
        Me.Button51.Size = New System.Drawing.Size(163, 28)
        Me.Button51.TabIndex = 65
        Me.Button51.Text = "Update OSR from Rep_terr"
        '
        'Button52
        '
        Me.Button52.Location = New System.Drawing.Point(922, 480)
        Me.Button52.Name = "Button52"
        Me.Button52.Size = New System.Drawing.Size(163, 28)
        Me.Button52.TabIndex = 66
        Me.Button52.Text = "Set Open Terr to OSR=None"
        '
        'Button53
        '
        Me.Button53.Location = New System.Drawing.Point(922, 517)
        Me.Button53.Name = "Button53"
        Me.Button53.Size = New System.Drawing.Size(163, 28)
        Me.Button53.TabIndex = 67
        Me.Button53.Text = "Fix CENTRAL Territory"
        '
        'Button54
        '
        Me.Button54.Location = New System.Drawing.Point(922, 554)
        Me.Button54.Name = "Button54"
        Me.Button54.Size = New System.Drawing.Size(163, 28)
        Me.Button54.TabIndex = 68
        Me.Button54.Text = "Test Acct Totals"
        '
        'Button55
        '
        Me.Button55.Location = New System.Drawing.Point(922, 591)
        Me.Button55.Name = "Button55"
        Me.Button55.Size = New System.Drawing.Size(163, 27)
        Me.Button55.TabIndex = 69
        Me.Button55.Text = "Copy Shipping Info"
        '
        'Button56
        '
        Me.Button56.Location = New System.Drawing.Point(922, 628)
        Me.Button56.Name = "Button56"
        Me.Button56.Size = New System.Drawing.Size(163, 27)
        Me.Button56.TabIndex = 70
        Me.Button56.Text = "Update Classic and Fresco"
        '
        'Button57
        '
        Me.Button57.Location = New System.Drawing.Point(950, 18)
        Me.Button57.Name = "Button57"
        Me.Button57.Size = New System.Drawing.Size(144, 28)
        Me.Button57.TabIndex = 71
        Me.Button57.Text = "Get Price Test"
        '
        'Button58
        '
        Me.Button58.Location = New System.Drawing.Point(1152, 332)
        Me.Button58.Name = "Button58"
        Me.Button58.Size = New System.Drawing.Size(163, 28)
        Me.Button58.TabIndex = 72
        Me.Button58.Text = "Upd Lat Long"
        '
        'Button59
        '
        Me.Button59.Location = New System.Drawing.Point(1152, 372)
        Me.Button59.Name = "Button59"
        Me.Button59.Size = New System.Drawing.Size(163, 23)
        Me.Button59.TabIndex = 73
        Me.Button59.Text = "To floor data 2009"
        Me.Button59.UseVisualStyleBackColor = True
        '
        'Button60
        '
        Me.Button60.Location = New System.Drawing.Point(1152, 401)
        Me.Button60.Name = "Button60"
        Me.Button60.Size = New System.Drawing.Size(163, 23)
        Me.Button60.TabIndex = 74
        Me.Button60.Text = "Move Prod Checkoffs"
        Me.Button60.UseVisualStyleBackColor = True
        '
        'Button61
        '
        Me.Button61.Location = New System.Drawing.Point(1152, 430)
        Me.Button61.Name = "Button61"
        Me.Button61.Size = New System.Drawing.Size(163, 23)
        Me.Button61.TabIndex = 75
        Me.Button61.Text = "Add Diags Sent"
        Me.Button61.UseVisualStyleBackColor = True
        '
        'Button62
        '
        Me.Button62.Location = New System.Drawing.Point(1091, 627)
        Me.Button62.Name = "Button62"
        Me.Button62.Size = New System.Drawing.Size(234, 28)
        Me.Button62.TabIndex = 76
        Me.Button62.Text = "Import Box Dims from Dbase"
        '
        'fmImport
        '
        Me.AcceptButton = Me.bAddRef
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1427, 1015)
        Me.Controls.Add(Me.Button62)
        Me.Controls.Add(Me.Button61)
        Me.Controls.Add(Me.Button60)
        Me.Controls.Add(Me.Button59)
        Me.Controls.Add(Me.Button58)
        Me.Controls.Add(Me.Button57)
        Me.Controls.Add(Me.Button56)
        Me.Controls.Add(Me.Button55)
        Me.Controls.Add(Me.Button54)
        Me.Controls.Add(Me.Button53)
        Me.Controls.Add(Me.Button52)
        Me.Controls.Add(Me.Button51)
        Me.Controls.Add(Me.Button50)
        Me.Controls.Add(Me.Button49)
        Me.Controls.Add(Me.Button48)
        Me.Controls.Add(Me.Button47)
        Me.Controls.Add(Me.Button46)
        Me.Controls.Add(Me.Button45)
        Me.Controls.Add(Me.Button44)
        Me.Controls.Add(Me.Button43)
        Me.Controls.Add(Me.Button42)
        Me.Controls.Add(Me.Button41)
        Me.Controls.Add(Me.Button40)
        Me.Controls.Add(Me.Button39)
        Me.Controls.Add(Me.bAddRef)
        Me.Controls.Add(Me.Button38)
        Me.Controls.Add(Me.Button37)
        Me.Controls.Add(Me.Button36)
        Me.Controls.Add(Me.Button35)
        Me.Controls.Add(Me.Button34)
        Me.Controls.Add(Me.Button33)
        Me.Controls.Add(Me.Button32)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.tOrd)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.tErr)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.lMin)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "fmImport"
        Me.Text = "fmImport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connStr As String
        Dim dr As SqlDataReader
        Dim dr0 As SqlDataReader
        Dim cmd As New SqlCommand
        Dim cmd0 As New SqlCommand
        Dim Ins As New SqlCommand
        Dim x, y As Long
        Dim sqlx As String = ""
        Dim flds As String = ""
        Dim cnnIns As New SqlConnection
        Dim tm As Date = Now
        Dim Wherex As String = ""

        Try
            Button1.Enabled = False
            connStr = String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201")
            cnn0 = New SqlClient.SqlConnection(connStr)
            connStr = String.Format("server={0};user id={1}; password={2}; database=winecellar; pooling=false", Server, "sa", "39201")
            cnnIns.ConnectionString = connStr
            cnn0.Open()
            cnn.Open()
            cnnIns.Open()
            Ins.Connection = cnnIns

            cmd0.CommandTimeout = 9999999
            cmd.Connection = cnn
            cmd.CommandText = "truncate table " + ComboBox1.Text
            cmd.ExecuteNonQuery()
            cmd0.Connection = cnn0
            cmd0.CommandText = "select count(*) as cnt from " + ComboBox2.Text
            x = cmd0.ExecuteScalar
            cmd.CommandText = "select *,data_type from imp_file,information_schema.columns where imp_dest=table_name and imp_to=column_name and imp_dest='" + ComboBox1.Text + "'"
            dr = cmd.ExecuteReader
            Do While dr.Read
                If dr("imp_to") = "<Where>" Then
                    Wherex = Mid(dr("imp_from"), 2, Len(dr("imp_from")) - 2)
                End If
            Loop
            dr.Close()
            cmd0.CommandText = "select * from " + ComboBox2.Text + " " + Wherex
            dr0 = cmd0.ExecuteReader
            y = 0
        Catch
            tErr.Text = Err.Description + vbCr + tErr.Text
            tErr.Visible = True
        End Try
        tm = Now
        Do While dr0.Read
            sqlx = ""
            flds = ""
            dr = cmd.ExecuteReader
            Do While dr.Read
                If dr("imp_to") = "<Where>" Then
                Else
                    flds = flds + Trim(dr("imp_to")) + ","
                    If Mid(Trim(dr("imp_from")), 1, 1) = "<" Then
                        Select Case Trim(dr("imp_from"))
                            Case "<Q=>"
                                If dr0("order_id") Is DBNull.Value Then
                                    sqlx = sqlx + "null,"
                                Else
                                    sqlx = sqlx + Split(dr0("order_id"), "-")(0) + ","
                                End If
                            Case "<R=>"
                                If dr0("order_id") Is DBNull.Value Then
                                    sqlx = sqlx + "null,"
                                Else
                                    sqlx = sqlx + Split(dr0("order_id"), "-")(Split(dr0("order_id"), "-").Length - 1) + ","
                                End If
                            Case "<OT=>"
                                If Split(dr0("order_id"), "-").Length > 2 Then
                                    sqlx = sqlx + "'O',"
                                Else
                                    sqlx = sqlx + "'Q',"
                                End If
                            Case Else
                                sqlx = sqlx + Mid(Trim(dr("imp_from")), 2, Len(Trim(dr("imp_from"))) - 2) + ","
                        End Select
                    Else
                        If dr0(Trim(dr("imp_from"))) Is DBNull.Value Then
                            sqlx = sqlx + "null,"
                        Else
                            Select Case dr("data_type")
                                Case "char"
                                    sqlx = sqlx + "'" + Replace(Trim(CStr(dr0(Trim(dr("imp_from"))))), "'", "''") + "',"
                                Case "varchar"
                                    sqlx = sqlx + "'" + Replace(Trim(CStr(dr0(Trim(dr("imp_from"))))), "'", "''") + "',"
                                Case "numeric"
                                    sqlx = sqlx + CStr(dr0(Trim(dr("imp_from")))) + ","
                                Case "decimal"
                                    sqlx = sqlx + CStr(dr0(Trim(dr("imp_from")))) + ","
                                Case "int"
                                    sqlx = sqlx + CStr(dr0(Trim(dr("imp_from")))) + ","
                                Case "bigint"
                                    sqlx = sqlx + CStr(dr0(Trim(dr("imp_from")))) + ","
                                Case "money"
                                    sqlx = sqlx + CStr(dr0(Trim(dr("imp_from")))) + ","
                                Case "bit"
                                    sqlx = sqlx + CStr(dr0(Trim(dr("imp_from")))) + ","
                                Case "datetime"
                                    sqlx = sqlx + "'" + CStr(dr0(Trim(dr("imp_from")))) + "',"
                                Case Else
                                    MsgBox(dr("data_type"))
                            End Select
                        End If
                    End If
                End If
            Loop
            dr.Close()
            sqlx = Mid(sqlx, 1, Len(sqlx) - 1)
            flds = Mid(flds, 1, Len(flds) - 1)
            Try
                Ins.CommandText = "insert into " + ComboBox1.Text + " (" + flds + ") values (" & sqlx & ")"
                Ins.ExecuteNonQuery()
            Catch
                tErr.Text = Err.Description + vbCr + tErr.Text
                tErr.Visible = True
            End Try
            y = y + 1
            Bar1.Value = y / x * 100
            lMin.Text = Format(DateDiff(DateInterval.Minute, tm, Now) / y * (x - y), "######.00")
            Application.DoEvents()
        Loop
        cnn.Close()
        cnn0.Close()
        cnnIns.Close()
        Button1.Enabled = True
        'Catch
        '    Button1.Enabled = True
        '    DoError(Err, MainForm)
        'End Try
    End Sub

    Private Sub fmImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim cmd As New SqlCommand
        'Dim dr As SqlDataReader
        'Dim connstr As String

        'ComboBox1.Items.Clear()
        'cmd.Connection = cnn
        'cmd.CommandText = "select * from information_schema.tables where table_type='Base Table' order by table_type"
        'cnn.Open()
        'dr = cmd.ExecuteReader
        'Do While dr.Read
        '    ComboBox1.Items.Add(dr("table_name"))
        'Loop
        'cnn.Close()

        'connstr = String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201")
        'cnn0.ConnectionString = connstr
        'ComboBox2.Items.Clear()
        'cmd.Connection = cnn0
        'cmd.CommandText = "select * from information_schema.tables where table_type='Base Table' order by table_type"
        'cnn0.Open()
        'dr = cmd.ExecuteReader
        'Do While dr.Read
        '    ComboBox2.Items.Add(dr("table_name"))
        'Loop
        'dr.Close()

        'cmd.Connection = cnn
        'cmd.CommandText = "select distinct imp_source,imp_dest from imp_file"
        'cnn.Open()
        'ListBox1.Items.Clear()
        'dr = cmd.ExecuteReader
        'Do While dr.Read
        '    ListBox1.Items.Add(Trim(dr("imp_dest")) + "," + Trim(dr("imp_source")))
        'Loop
        'dr.Close()
        'cnn.Close()
        'cnn0.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        ListBox2.Items.Clear()
        cmd.Connection = cnn
        cmd.CommandText = "select * from information_schema.columns where table_name='" + ComboBox1.Text + "'"
        cnn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            ListBox2.Items.Add(dr("column_name"))
        Loop
        cnn.Close()
        ListBox2.Items.Add("<Where>")
        UpdateList()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        ListBox3.Items.Clear()
        cmd.Connection = cnn0
        cmd.CommandText = "select * from information_schema.columns where table_name='" + ComboBox2.Text + "'"
        cnn0.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            ListBox3.Items.Add(dr("column_name"))
        Loop
        ListBox3.Items.Add("<Blank>")
        ListBox3.Items.Add("<Today>")
        ListBox3.Items.Add("<>")
        ListBox3.Items.Add("<Q=>")
        ListBox3.Items.Add("<R=>")
        ListBox3.Items.Add("<OT=>")
        cnn0.Close()
        UpdateList()
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged
    End Sub
    Private Sub UpdateList()
        Dim cmd As New SqlCommand
        cmd.Connection = cnn
        Dim dr As SqlDataReader
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter

        cmd.CommandText = "select * from imp_file where imp_source='" + ComboBox2.Text + "' and imp_dest='" + ComboBox1.Text + "'"
        da.SelectCommand = cmd
        cnn.Open()
        da.Fill(ds, "imp")
        cnn.Close()
        Grid1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        Dim cmd As New SqlCommand
        cmd.Connection = cnn
        cmd.CommandText = "delete from imp_file where imp_serial=" + CStr(Grid1.Item(Grid1.CurrentRowIndex, 0))
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        UpdateList()
    End Sub

    Private Sub ListBox3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox3.DoubleClick
        Dim cmd As New SqlCommand
        Dim itm As String

        If ListBox3.SelectedItem = "<>" Then
            itm = "<" + Replace(TextBox1.Text, "'", "''") + ">"
        Else
            itm = ListBox3.SelectedItem
        End If
        cmd.Connection = cnn
        cnn.Open()
        cmd.CommandText = "insert into imp_file (imp_source,imp_dest,imp_to,imp_from) values ('" + ComboBox2.Text + "','" + ComboBox1.Text + "','" + ListBox2.SelectedItem + "','" + itm + "')"
        cmd.ExecuteNonQuery()
        cnn.Close()
        UpdateList()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim dr As SqlDataReader
        Dim cnn0 As New SqlConnection
        Dim connstr As String
        Dim cmd0 As New SqlCommand

        connstr = String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201")
        cnn0.ConnectionString = connstr
        cmd0.Connection = cnn0

        Button2.Enabled = False
        cmd.Connection = cnn
        cmd1.Connection = cnn2

        cnn.Open()
        cnn2.Open()
        cnn0.Open()

        cmd0.CommandText = "select * from order_tbl where is_active_flg=0"
        dr = cmd0.ExecuteReader
        Do While dr.Read
            cmd1.CommandText = "delete from ord_itm where ord_itm_order_id='" + dr("order_id") + "'"
            cmd1.ExecuteNonQuery()
        Loop
        cmd1.CommandText = "delete from ord_gen where ord_gen_status='CANCELED'"
        cmd1.ExecuteNonQuery()
        dr.Close()

        cmd.CommandText = "select cust_itm_price_cust_id,cust_serial from cust_itm_price,cust_file where cust_itm_price_cust_id=cust_id"
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmd1.CommandText = "update cust_itm_price set cust_itm_price_cust_serial=" + CStr(dr("cust_serial")) + " where cust_itm_price_cust_id='" + dr("cust_itm_price_cust_id") + "'"
            cmd1.ExecuteNonQuery()
        Loop
        dr.Close()

        cmd.CommandText = "select cust_prod_mar_cust_id,cust_serial from cust_prod_mar,cust_file where cust_prod_mar_cust_id=cust_id"
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmd1.CommandText = "update cust_prod_mar set cust_prod_mar_cust_serial=" + CStr(dr("cust_serial")) + " where cust_prod_mar_cust_id='" + Replace(dr("cust_prod_mar_cust_id"), "'", "''") + "'"
            cmd1.ExecuteNonQuery()
        Loop
        dr.Close()

        cmd.CommandText = "select distinct ord_sold_cust_id,cust_serial from ord_file,cust_file where ord_sold_cust_id=cust_id"
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmd1.CommandText = "update ord_file set ord_sold_cust_serial=" + CStr(dr("cust_serial")) + " where ord_sold_cust_id='" + Replace(dr("ord_sold_cust_id"), "'", "''") + "'"
            cmd1.ExecuteNonQuery()
        Loop
        dr.Close()

        cmd.CommandText = "delete from itm_price where itm_price_type='Base'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "select * from itm_file"
        dr = cmd.ExecuteReader
        Dim Price As Double
        Do While dr.Read
            If Not dr("itm_code") Is DBNull.Value Then
                If dr("itm_price") Is DBNull.Value Then
                    Price = 0
                Else
                    Price = dr("itm_price")
                End If
                cmd1.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale) values ('" + dr("itm_code") + "','Base',1,999999," + CStr(Price) + ",'1/1/1980','12/31/2099',0)"
                cmd1.ExecuteNonQuery()
            End If
        Loop
        dr.Close()

        cnn.Close()
        cnn2.Close()
        Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Dim cmd As New SqlCommand
        Dim cmd0 As New SqlCommand
        Dim cnn0 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim connstr As String
        Dim x, y As Long
        Dim cnn3 As New SqlConnection
        Dim cmd3 As New SqlCommand
        Dim dr3 As SqlDataReader
        Dim tm As Date = Date.Now
        Dim dr As SqlDataReader

        Try
            MsgBox("Turn off the identity field ord_serial")
            connstr = String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201")
            cnn0.ConnectionString = connstr


            cmd.Connection = cnn
            cmd0.Connection = cnn0
            cmd2.Connection = cnn2
            cnn.Open()
            cnn0.Open()
            cnn2.Open()
            cnn3.ConnectionString = connstr
            cnn3.Open()
            cmd3.Connection = cnn3
            cmd0.CommandTimeout = 9999999
            cmd.CommandTimeout = 9999999
            cmd3.CommandTimeout = 9999999

            cmd.CommandText = "truncate table ord_file"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "truncate table ord_gen"
            cmd.ExecuteNonQuery()
            'cmd.CommandText = "truncate table ord_itm"
            'cmd.ExecuteNonQuery()

            cmd0.CommandText = "select count(*) as cnt from order_tbl" ' where order_display_dt >='01-01-2005'"
            x = cmd0.ExecuteScalar
            y = 0
            cmd0.CommandText = "select * from order_tbl order by order_id desc" ',revision desc" where order_display_dt >='01-01-2005' 
            dr = cmd0.ExecuteReader
        Catch
            tErr.Text = Err.Description + vbCrLf + cmd0.CommandText + vbCrLf + vbCrLf + tErr.Text
            tErr.Visible = True
        End Try
        tm = Now
        Do While dr.Read
            'If dr("is_active_flg") = 1 Then
            cmd2.CommandText = "select count(*) from ord_file where ord_serial=" + CStr(dr("order_nbr"))
            If cmd2.ExecuteScalar = 0 Then
                cmd3.CommandText = "select * from order_addr_tbl where order_id='" + CStr(dr("order_id")) + "'"
                dr3 = cmd3.ExecuteReader
                If dr3.HasRows Then
                    dr3.Read()
                    cmd2.CommandText = "insert into ord_file (ord_serial,ord_rev,ord_for,ord_sold_cust_id,ord_sold_name,ord_sold_company,ord_sold_country,ord_sold_addr1,ord_sold_addr2,ord_sold_addr3,ord_sold_city,ord_sold_state,ord_sold_province,ord_sold_zip,ord_sold_phone1,ord_sold_phone2,ord_sold_fax,ord_sold_alt_phone,ord_sold_email,ord_ship_cust_id,ord_ship_name,ord_ship_company,ord_ship_country,ord_ship_addr1,ord_ship_addr2,ord_ship_addr3,ord_ship_city,ord_ship_state,ord_ship_province,ord_ship_zip,ord_ship_phone1,ord_ship_phone2,ord_ship_fax,ord_ship_alt_phone,ord_cust_taxrate,ord_tax_exempt,ord_tax_exempt_no,ord_ship_email) values (" ',ord_ship_cust_id,ord_ship_name,ord_ship_company,ord_ship_country,ord_ship_addr1,ord_ship_addr2,ord_ship_addr3,ord_ship_city,ord_ship_state,ord_ship_zip,ord_ship_phone1,ord_ship_phone2,ord_ship_fax,ord_ship_alt_phone,ord_ship_cell,ord_ship_email,ord_sales_cat,ord_cust_taxrate) values ("
                    cmd2.CommandText = cmd2.CommandText + CStr(dr("order_nbr")) + ","
                    cmd2.CommandText = cmd2.CommandText + CStr(dr("revision")) + ","
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr("order_for") & "~!~,"

                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_customer_id") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_name") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_company") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_to_country") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_addr1") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_addr2") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_addr3") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_us_city") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_us_state") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_province") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_us_zipcode") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_phone1") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_phone2") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_fax") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_alternate_phone") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("sold_email") & "~!~,"

                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_customer_id") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_name") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_company") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_to_country") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_addr1") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_addr2") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_addr3") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_us_city") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_us_state") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_province") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_us_zipcode") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_phone1") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_phone2") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_fax") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_alternate_phone") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "" & CStr(nz(dr("tax_rate_pct"), 0)) & ","
                    cmd2.CommandText = cmd2.CommandText & "" & CStr(nz(dr("tax_exempt_flg"), 0)) & ","
                    cmd2.CommandText = cmd2.CommandText & "~!~" & CStr(nz(dr("tax_exempt_nbr"), 0)) & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr3("ship_email") & "~!~"

                    cmd2.CommandText = cmd2.CommandText + ")"
                    cmd2.CommandText = Replace(cmd2.CommandText, "`", "")
                    cmd2.CommandText = Replace(cmd2.CommandText, "'", "''")
                    cmd2.CommandText = Replace(cmd2.CommandText, "~!~", "'")
                    'On Error Resume Next
                    Try
                        cmd2.ExecuteNonQuery()
                        'On Error GoTo 0
                    Catch
                        'MsgBox(Err.Description)
                        tErr.Text = Err.Description + vbCrLf + cmd2.CommandText + vbCrLf + vbCrLf + tErr.Text
                        tErr.Visible = True
                    End Try
                End If

                dr3.Close()
            End If

            Try
                cmd2.CommandText = "insert into ord_gen (ord_gen_ord_serial,ord_gen_rev,ord_gen_type,ord_gen_show_date,ord_gen_create_date,ord_gen_total,ord_gen_tax,ord_gen_ship,ord_gen_balance,ord_gen_cust_po,ord_gen_status,ord_gen_from_rev,ord_gen_inside,ord_gen_outside,ord_gen_designer,ord_gen_line_total,ord_gen_ship_extra,ord_gen_src,ord_gen_ship_prepaid,ord_gen_sales_cat) values ("
                cmd2.CommandText = cmd2.CommandText + CStr(dr("order_nbr")) + ","
                If dr("is_order_flg") = 1 Then
                    cmd2.CommandText = cmd2.CommandText + CStr(dr("order_revision")) + ","
                    cmd2.CommandText = cmd2.CommandText & "~!~O~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr("order_display_dt") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr("order_create_dt") & "~!~,"
                Else
                    cmd2.CommandText = cmd2.CommandText + CStr(dr("revision")) + ","
                    cmd2.CommandText = cmd2.CommandText & "~!~Q~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr("qt_display_dt") & "~!~,"
                    cmd2.CommandText = cmd2.CommandText & "~!~" & dr("qt_create_dt") & "~!~,"
                End If
                cmd2.CommandText = cmd2.CommandText & "" & CStr(dr("total_amt")) & ","
                cmd2.CommandText = cmd2.CommandText & "" & CStr(dr("total_tax")) & ","
                cmd2.CommandText = cmd2.CommandText & "" & CStr(nz(dr("total_frt"), 0) + nz(dr("total_ship_extra"), 0)) & ","
                If dr("balance_due") Is DBNull.Value Then
                    cmd2.CommandText = cmd2.CommandText + "0,"
                Else
                    cmd2.CommandText = cmd2.CommandText & "" & CStr(dr("balance_due")) & ","
                End If
                cmd2.CommandText = cmd2.CommandText & "~!~" & dr("customer_order") & "~!~,"
                If dr("is_active_flg") = 0 Then
                    cmd2.CommandText = cmd2.CommandText & "~!~CANCELED~!~,"
                Else
                    cmd2.CommandText = cmd2.CommandText & "~!~PROCESS~!~,"
                End If
                If dr("is_order_flg") = 1 Then
                    cmd2.CommandText = cmd2.CommandText & Split(dr("order_id"), "-")(2) + ","
                Else
                    cmd2.CommandText = cmd2.CommandText & "null,"
                End If

                If Not dr("qt_by") Is DBNull.Value Then
                    cmd.CommandText = "select rep_type from rep_file where rep_code='" + dr("qt_by") + "'"
                    Select Case cmd.ExecuteScalar
                        Case "I"
                            cmd2.CommandText = cmd2.CommandText + "~!~" + dr("qt_by") + "~!~,null,null,"
                        Case "O"
                            cmd2.CommandText = cmd2.CommandText + "null,~!~" + dr("qt_by") + "~!~,null,"
                        Case "D"
                            cmd2.CommandText = cmd2.CommandText + "null,null,~!~" + dr("qt_by") + "~!~,"
                        Case "I"
                            cmd2.CommandText = cmd2.CommandText + "null,null,null,"
                        Case Else
                            cmd2.CommandText = cmd2.CommandText + "null,null,null,"
                    End Select
                Else
                    cmd2.CommandText = cmd2.CommandText + "null,null,null,"
                End If
                cmd2.CommandText = cmd2.CommandText & "" & CStr(nz(dr("total_item_amt"), 0)) & ","
                cmd2.CommandText = cmd2.CommandText & "" & CStr(nz(dr("total_frt"), 0)) & ","
                cmd2.CommandText = cmd2.CommandText & "~!~" & CStr(nz(dr("order_source_code"), "")) & "~!~,"
                cmd2.CommandText = cmd2.CommandText & "" & CStr(nz(dr("is_ship_prepaid"), 0)) & ","
                cmd2.CommandText = cmd2.CommandText & "~!~" & CStr(nz(dr("sales_category_code"), "")) & "~!~"


                cmd2.CommandText = cmd2.CommandText + ")"
                cmd2.CommandText = Replace(cmd2.CommandText, "`", "")
                cmd2.CommandText = Replace(cmd2.CommandText, "'", "''")
                cmd2.CommandText = Replace(cmd2.CommandText, "~!~", "'")
                'On Error Resume Next
                cmd2.ExecuteNonQuery()
            Catch
                tErr.Text = Err.Description + vbCrLf + cmd2.CommandText + vbCrLf + vbCrLf + tErr.Text
                tErr.Visible = True
                MsgBox(Err.Description)
            End Try
            'On Error GoTo 0

            '  End If
            y = y + 1
            Bar1.Value = y / x * 100
            lMin.Text = Format(DateDiff(DateInterval.Minute, tm, Now) / y * (x - y), "#####0.00")
            Application.DoEvents()
        Loop
        cnn.Close()
        cnn0.Close()
        cnn2.Close()
        'MsgBox("Turn ON the indentity field ord_serial")
        Button3.Enabled = True
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim fls() As String
        fls = Split(ListBox1.SelectedItem, ",")
        ComboBox1.Text = fls(0)
        ComboBox2.Text = fls(1)
    End Sub

    Private Sub lMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lMin.Click

    End Sub

    Private Sub tErr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tErr.TextChanged

    End Sub

    Private Sub tErr_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tErr.DoubleClick
        tErr.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim x As Integer
        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.SelectedIndex = x
            Button1_Click(sender, e)
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Enabled = False
        Dim cmd As New SqlCommand("select pay_itm_serial,pay_serial,pay_itm_ord_serial,pay_itm_ord_rev from pay_itm,pay_file where pay_itm.billing_id=pay_file.billing_id and pay_itm.pay_id=pay_file.pay_id", cnn)
        Dim dr As SqlDataReader
        Dim x, y As Long
        Dim cnn0 As New SqlConnection
        Dim cmd0 As New SqlCommand

        cnn0.ConnectionString = String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201")
        cmd0.Connection = cnn0

        cnn.Open()
        cnn2.Open()
        cnn0.Open()
        Dim cmd2 As New SqlCommand
        cmd2.Connection = cnn2
        cmd2.CommandText = "select count(*) as cnt from pay_itm,pay_file where pay_itm.billing_id=pay_file.billing_id and pay_itm.pay_id=pay_file.pay_id" ' where order_display_dt >='01-01-2005'"
        x = cmd2.ExecuteScalar
        cmd0.CommandText = "select count(*) as cnt from order_payment_tbl"
        x = x + cmd0.ExecuteScalar
        y = 0
        dr = cmd.ExecuteReader
        Do While dr.Read
            Try
                cmd2.CommandText = "update pay_itm set pay_itm_pay_serial=" + CStr(dr("pay_serial")) + " where pay_itm_serial=" + CStr(dr("pay_itm_serial"))
                cmd2.ExecuteNonQuery()
                If Not dr("pay_itm_ord_serial") Is DBNull.Value Then
                    cmd2.CommandText = "update pay_itm set pay_itm_ord_gen_serial=(select top 1 ord_gen_serial from ord_gen where ord_gen_ord_serial=" + CStr(dr("pay_itm_ord_serial")) + " and ord_gen_rev=" + CStr(dr("pay_itm_ord_rev")) + " and ord_gen_type='O') where pay_itm_serial=" + CStr(dr("pay_itm_serial"))
                    cmd2.ExecuteNonQuery()
                End If
            Catch
                tErr.Text = Err.Description + vbCr + tErr.Text
                tErr.Visible = True
            Finally
                y = y + 1
                Bar1.Value = y / x * 100
                Application.DoEvents()

            End Try
        Loop
        dr.Close()

        cmd0.CommandText = "select order_payment_tbl.*,order_addr_tbl.sold_customer_id from order_payment_tbl left outer join order_addr_tbl on order_payment_tbl.order_id=order_addr_tbl.order_id"
        dr = cmd0.ExecuteReader

        Dim LastPay, OrdGen As Long

        Do While dr.Read
            Try
                cmd2.CommandText = "insert into pay_file (pay_cust_id,pay_date,pay_amt,pay_method,pay_num,pay_exp_date,pay_auth_code) values ('" & nz(dr("sold_customer_id")) & "','" & CStr(nz(dr("pay_dt"))) & "'," & CStr(nz(dr("pay_amt"), "0")) & ",'" & nz(dr("pay_method_code")) & "','" & nz(dr("pay_nbr")) & "',null,'" & nz(dr("pay_auth_code")) & "')"
                cmd2.ExecuteNonQuery()
                cmd2.CommandText = "select @@IDENTITY as jid"
                LastPay = cmd2.ExecuteScalar
                cmd2.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + Split(dr("order_id"), "-")(0) + " and ord_gen_rev=" + Split(dr("order_id"), "-")(2) + " and ord_gen_type='O'"
                OrdGen = cmd2.ExecuteScalar
                cmd2.CommandText = "insert into pay_itm (pay_itm_pay_serial,pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,pay_itm_amt) values (" & CStr(LastPay) & "," & CStr(OrdGen) & "," & Split(dr("order_id"), "-")(0) & "," & Split(dr("order_id"), "-")(2) & "," & CStr(nz(dr("pay_amt"), "0")) + ")"
                cmd2.ExecuteNonQuery()
            Catch
                tErr.Text = Err.Description + vbCr + tErr.Text
                tErr.Visible = True
            Finally
                y = y + 1
                Bar1.Value = y / x * 100
                Application.DoEvents()
            End Try
        Loop
        cnn.Close()
        cnn2.Close()
        cnn0.Close()
        Button5.Enabled = True
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Enabled = False
        Dim cnn0 As New SqlConnection(String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201"))
        Dim cmd0 As New SqlCommand("select count(*) as cnt from order_shipment_tbl where ship_dt>='1/6/2006'", cnn0)
        Dim dr0 As SqlDataReader
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader
        Dim cnn2 As New SqlConnection
        Dim LastAuto, x, y As Long
        'Try
        cnn2.ConnectionString = cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'"
        cmd2.Connection = cnn2
        cmd.Connection = cnn

        cnn.Open()
        'cmd.CommandText = "truncate table ship_file"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "truncate table ship_itm"
        'cmd.ExecuteNonQuery()

        cnn0.Open()
        cnn2.Open()
        x = cmd0.ExecuteScalar
        y = 0

        cmd0.CommandText = "select * from order_shipment_tbl where ship_dt>='1/6/2006'"
        dr0 = cmd0.ExecuteReader
        Do While dr0.Read
            If Not dr0("order_id") Is DBNull.Value Then
                If Split(dr0("order_id"), "-").Length > 2 Then
                    Try
                        cmd.CommandText = "insert into ship_file (ship_via,ship_date,ship_track,ship_weight,ship_boxes,ship_cost,ship_notes,ship_ord_serial,ship_ord_rev) values (~!~" + dr0("ship_via_code") + "~!~,~!~" + CStr(dr0("ship_dt")) + "~!~,~!~" + dr0("track_nbr") + "~!~," + jstr(dr0("ship_wt")) + "," + jstr(dr0("nbr_boxes")) + "," + jstr(dr0("ship_cost")) + ",~!~" + jstr(dr0("ship_note")) + "~!~," + Split(dr0("order_id"), "-")(0) + "," + Split(dr0("order_id"), "-")(2) + ")"
                        cmd.CommandText = Replace(cmd.CommandText, "'", "''")
                        cmd.CommandText = Replace(cmd.CommandText, "~!~", "'")
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "select @@IDENTITY as jid"
                        LastAuto = cmd.ExecuteScalar
                    Catch
                        tErr.Text = Err.Description + vbCr + tErr.Text
                        tErr.Visible = True
                    End Try
                    cmd2.CommandText = "select * from ord_itm where ord_itm_ord_serial=" + Split(dr0("order_id"), "-")(0) + " and ord_itm_rev=" + Split(dr0("order_id"), "-")(2) + " and ord_itm_type='O' and ord_itm_shipped < ord_itm_qty"
                    dr = cmd2.ExecuteReader
                    Do While dr.Read
                        Try
                            cmd.CommandText = "insert into ship_itm (ship_itm_ship_serial,ship_itm_ord_serial,ship_itm_ord_rev,ship_itm_ord_itm_serial,ship_itm_qty,ship_itm_code,ship_itm_desc) values (" + CStr(LastAuto) + "," + Split(dr0("order_id"), "-")(0) + "," + Split(dr0("order_id"), "-")(2) + "," + CStr(dr("ord_itm_serial")) + "," + CStr(dr("ord_itm_qty")) + ",`" + dr("ord_itm_item_code") + "`,`" + jstr(dr("ord_itm_desc")) + "`)"
                            cmd.CommandText = Replace(cmd.CommandText, "'", "''")
                            cmd.CommandText = Replace(cmd.CommandText, "`", "'")
                            cmd.ExecuteNonQuery()
                        Catch
                            tErr.Text = Err.Description + vbCr + tErr.Text
                            tErr.Visible = True
                        End Try
                    Loop
                    dr.Close()
                    cmd.CommandText = "update ord_itm set ord_itm_shipped=ord_itm_qty where ord_itm_ord_serial=" + Split(dr0("order_id"), "-")(0) + " and ord_itm_rev=" + Split(dr0("order_id"), "-")(2) + " and ord_itm_type='O'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "update ord_gen set ord_gen_ship_date='" + CStr(dr0("ship_dt")) + "',ord_gen_status='SHIPPED' where ord_gen_ord_serial=" + Split(dr0("order_id"), "-")(0) + " and ord_gen_rev=" + Split(dr0("order_id"), "-")(2) + " and ord_gen_type='O'"
                    cmd.ExecuteNonQuery()
                End If
            End If
            y = y + 1
            Bar1.Value = y / x * 100
            'Application.DoEvents()
        Loop
        cnn0.Close()
        cnn2.Close()
        cnn.Close()
        Button6.Enabled = True
        'Catch
        '    MsgBox(Err.Description)
        'End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Enabled = False
        Dim cnn0 As New SqlConnection(String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201"))
        Dim cmd0 As New SqlCommand("select count(*) as cnt from billing_detail_tbl", cnn0)
        Dim dr0 As SqlDataReader
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader
        Dim cnn2 As New SqlConnection
        Dim LastAuto, x, y As Long
        'Try
        cnn2.ConnectionString = cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'"
        cmd2.Connection = cnn2
        cmd.Connection = cnn

        cnn.Open()
        cnn0.Open()
        cnn2.Open()
        x = cmd0.ExecuteScalar
        y = 0

        cmd0.CommandText = "select order_id,billing_dt from billing_tbl,billing_detail_tbl where billing_tbl.billing_id=billing_detail_tbl.billing_id"
        Try
            dr0 = cmd0.ExecuteReader
        Catch
            MsgBox(Err.Description)
        End Try
        Do While dr0.Read
            If Not dr0("order_id") Is DBNull.Value Then
                Try
                    cmd.CommandText = "update ord_gen set ord_gen_billed=1,ord_gen_billdate='" + CStr(dr0("billing_dt")) + "' where ord_gen_ord_serial=" + Split(dr0("order_id"), "-")(0) + " and ord_gen_rev=" + Split(dr0("order_id"), "-")(2) + " and ord_gen_type='O'"
                    cmd.ExecuteNonQuery()
                Catch
                    tErr.Text = Err.Description + vbCr + tErr.Text
                    tErr.Visible = True
                End Try
            End If
            y = y + 1
            Bar1.Value = y / x * 100
            'Application.DoEvents()
        Loop
        cnn0.Close()
        cnn2.Close()
        cnn.Close()
        Button7.Enabled = True
        'Catch
        '    MsgBox(Err.Description)
        'End Try

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button3_Click(sender, e)
        Button4_Click(sender, e)
        Button2_Click(sender, e)
        Button5_Click(sender, e)
        Button6_Click(sender, e)
        Button7_Click(sender, e)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Dim cmd As New SqlCommand("select ord_gen_ord_serial,ord_gen_type,ord_gen_rev,ord_gen_ship_extra as extra,(select sum(ord_itm_unt_ship * ord_itm_qty) from ord_itm where ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_type=ord_itm_type and ord_gen_rev=ord_itm_rev) as lineship from ord_gen", cnn)
            Dim dr As SqlDataReader

            cnn.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                MsgBox(CStr(nz(dr("ord_gen_ord_serial"), 0)) + "-" + CStr(nz(dr("ord_gen_type"), 0)) + "-" + CStr(nz(dr("ord_gen_rev"), 0)) + CStr(nz(dr("extra"), 0)) + "***" + CStr(nz(dr("lineship"), 0)))
            Loop
            cnn.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            Button10.Enabled = False
            Dim cmd As New SqlCommand("select * from itm_file", cnn)
            Dim dr As SqlDataReader
            Dim cmd2 As New SqlCommand
            cmd2.Connection = cnn2

            cnn.Open()
            cnn2.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                If InStr(UCase(dr("itm_desc")), "DISCONTINUE") > 0 Then
                    cmd2.CommandText = "update itm_file set inactive=1 where itm_code='" + dr("itm_code") + "'"
                    cmd2.ExecuteNonQuery()
                End If
            Loop
            cnn2.Close()
            cnn.Close()
            Button10.Enabled = True
        Catch
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Button11.Enabled = False
            Dim fl As New IO.StreamReader("c:\temp\price3.txt")
            Dim ln As String
            Dim cmd As New SqlCommand
            Dim dt As Date = CDate("1/13/06")
            Dim tot As Double

            cmd.Connection = cnn
            cnn.Open()

            Do
                ln = fl.ReadLine
                If Not ln Is Nothing Then
                    If Trim(Split(ln, ",")(1)) <> "nil" Then
                        cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_cust_id='IWA' and cust_itm_price_itm_code='" + Split(ln, ",")(0) + "' and cust_itm_price_start<='" + CStr(dt) + "' and cust_itm_price_end>='" + CStr(dt) + "'"
                        tot = cmd.ExecuteScalar
                        If tot <> CDbl(Split(ln, ",")(1)) Then
                            cmd.CommandText = "update cust_itm_price set cust_itm_price_end='1/12/2006' where cust_itm_price_cust_id='IWA' and cust_itm_price_itm_code='" + Split(ln, ",")(0) + "' and cust_itm_price_start<='" + CStr(dt) + "' and cust_itm_price_end>='" + CStr(dt) + "'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_id,cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_price,cust_itm_price_start,cust_itm_price_end) values ('IWA',120,'" + Split(ln, ",")(0) + "',1,999999," + Replace(Replace(Split(ln, ",")(1), "$", ""), ",", "") + ",'1/13/2006','12/31/2099')"
                            cmd.ExecuteNonQuery()
                        End If
                    End If

                    If Trim(Split(ln, ",")(2)) <> "nil" Then
                        cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_cust_id='WE' and cust_itm_price_itm_code='" + Split(ln, ",")(0) + "' and cust_itm_price_start<='" + CStr(dt) + "' and cust_itm_price_end>='" + CStr(dt) + "'"
                        tot = cmd.ExecuteScalar
                        If tot <> CDbl(Split(ln, ",")(2)) Then
                            cmd.CommandText = "update cust_itm_price set cust_itm_price_end='1/12/2006' where cust_itm_price_cust_id='WE' and cust_itm_price_itm_code='" + Split(ln, ",")(0) + "' and cust_itm_price_start<='" + CStr(dt) + "' and cust_itm_price_end>='" + CStr(dt) + "'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_id,cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_price,cust_itm_price_start,cust_itm_price_end) values ('WE',380,'" + Split(ln, ",")(0) + "',1,999999," + Replace(Replace(Split(ln, ",")(2), "$", ""), ",", "") + ",'1/13/2006','12/31/2099')"
                            cmd.ExecuteNonQuery()
                        End If
                    End If

                    If Trim(Split(ln, ",")(3)) <> "nil" Then
                        cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_cust_id='SAMS' and cust_itm_price_itm_code='" + Split(ln, ",")(0) + "' and cust_itm_price_start<='" + CStr(dt) + "' and cust_itm_price_end>='" + CStr(dt) + "'"
                        tot = cmd.ExecuteScalar
                        If tot <> CDbl(Split(ln, ",")(3)) Then
                            cmd.CommandText = "update cust_itm_price set cust_itm_price_end='1/12/2006' where cust_itm_price_cust_id='SAMS' and cust_itm_price_itm_code='" + Split(ln, ",")(0) + "' and cust_itm_price_start<='" + CStr(dt) + "' and cust_itm_price_end>='" + CStr(dt) + "'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_id,cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_price,cust_itm_price_start,cust_itm_price_end) values ('SAMS',330,'" + Split(ln, ",")(0) + "',1,999999," + Replace(Replace(Split(ln, ",")(3), "$", ""), ",", "") + ",'1/13/2006','12/31/2099')"
                            cmd.ExecuteNonQuery()
                        End If
                    End If

                    If Trim(Split(ln, ",")(4)) <> "nil" Then
                        cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_cust_id='PRIME' and cust_itm_price_itm_code='" + Split(ln, ",")(0) + "' and cust_itm_price_start<='" + CStr(dt) + "' and cust_itm_price_end>='" + CStr(dt) + "'"
                        tot = cmd.ExecuteScalar
                        If tot <> CDbl(Split(ln, ",")(4)) Then
                            cmd.CommandText = "update cust_itm_price set cust_itm_price_end='1/12/2006' where cust_itm_price_cust_id='PRIME' and cust_itm_price_itm_code='" + Split(ln, ",")(0) + "' and cust_itm_price_start<='" + CStr(dt) + "' and cust_itm_price_end>='" + CStr(dt) + "'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_id,cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_price,cust_itm_price_start,cust_itm_price_end) values ('PRIME',323,'" + Split(ln, ",")(0) + "',1,999999," + Replace(Replace(Split(ln, ",")(4), "$", ""), ",", "") + ",'1/13/2006','12/31/2099')"
                            cmd.ExecuteNonQuery()
                        End If
                    End If

                End If
            Loop Until ln Is Nothing

            cnn.Close()
        Catch
            MsgBox(Err.Description)
        Finally
            Button11.Enabled = True
        End Try

    End Sub
    Private Sub ImportPrice20060112()
        Try
            Button11.Enabled = False
            Dim fl As New IO.StreamReader("c:\temp\price2.txt")
            Dim ln As String
            Dim cmd As New SqlCommand
            Dim dt As Date = CDate("1/10/06")
            Dim tot As Double

            cmd.Connection = cnn
            cnn.Open()

            Do
                ln = fl.ReadLine
                If Not ln Is Nothing Then
                    If Split(ln, ",")(2) <> "nil" Then
                        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Split(ln, ",")(0) + "' and itm_price_start<='" + CStr(dt) + "' and itm_price_end>='" + CStr(dt) + "' and itm_price_type='BASE'"
                        tot = cmd.ExecuteScalar
                        If tot <> CDbl(Split(ln, ",")(2)) Then
                            cmd.CommandText = "update itm_price set itm_price_end='1/9/2006' where itm_price_itm_code='" + Split(ln, ",")(0) + "' and itm_price_start<='" + CStr(dt) + "' and itm_price_end>='" + CStr(dt) + "' and itm_price_type='BASE'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale) values ('" + Split(ln, ",")(0) + "','BASE',1,999999," + Replace(Replace(Split(ln, ",")(2), "$", ""), ",", "") + ",'1/10/2006','12/31/2099',0)"
                            cmd.ExecuteNonQuery()
                        End If
                    End If

                    If Split(ln, ",")(2) <> "nil" Then
                        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Split(ln, ",")(0) + "' and itm_price_start<='" + CStr(dt) + "' and itm_price_end>='" + CStr(dt) + "' and itm_price_type='MD'"
                        tot = cmd.ExecuteScalar
                        If tot <> CDbl(Split(ln, ",")(2)) Then
                            cmd.CommandText = "update itm_price set itm_price_end='1/9/2006' where itm_price_itm_code='" + Split(ln, ",")(0) + "' and itm_price_start<='" + CStr(dt) + "' and itm_price_end>='" + CStr(dt) + "' and itm_price_type='MD'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale) values ('" + Split(ln, ",")(0) + "','MD',1,999999," + Replace(Replace(Split(ln, ",")(2), "$", ""), ",", "") + ",'1/10/2006','12/31/2099',0)"
                            cmd.ExecuteNonQuery()
                        End If
                    End If

                    If Split(ln, ",")(3) <> "nil" Then
                        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Split(ln, ",")(0) + "' and itm_price_start<='" + CStr(dt) + "' and itm_price_end>='" + CStr(dt) + "' and itm_price_type='CON'"
                        tot = cmd.ExecuteScalar
                        If tot <> CDbl(Split(ln, ",")(3)) Then
                            cmd.CommandText = "update itm_price set itm_price_end='1/9/2006' where itm_price_itm_code='" + Split(ln, ",")(0) + "' and itm_price_start<='" + CStr(dt) + "' and itm_price_end>='" + CStr(dt) + "' and itm_price_type='CON'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale) values ('" + Split(ln, ",")(0) + "','CON',1,999999," + Replace(Replace(Split(ln, ",")(3), "$", ""), ",", "") + ",'1/10/2006','12/31/2099',0)"
                            cmd.ExecuteNonQuery()
                        End If
                    End If

                    If Split(ln, ",")(4) <> "nil" Then
                        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Split(ln, ",")(0) + "' and itm_price_start<='" + CStr(dt) + "' and itm_price_end>='" + CStr(dt) + "' and itm_price_type='RET'"
                        tot = cmd.ExecuteScalar
                        If tot <> CDbl(Split(ln, ",")(4)) Then
                            cmd.CommandText = "update itm_price set itm_price_end='1/9/2006' where itm_price_itm_code='" + Split(ln, ",")(0) + "' and itm_price_start<='" + CStr(dt) + "' and itm_price_end>='" + CStr(dt) + "' and itm_price_type='RET'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale) values ('" + Split(ln, ",")(0) + "','RET',1,999999," + Replace(Replace(Split(ln, ",")(4), "$", ""), ",", "") + ",'1/10/2006','12/31/2099',0)"
                            cmd.ExecuteNonQuery()
                        End If
                    End If

                    If Split(ln, ",")(5) <> "nil" Then
                        cmd.CommandText = "update itm_file set itm_ship_cost=" + Replace(Replace(Split(ln, ",")(5), "$", ""), ",", "") + " where itm_code='" + Split(ln, ",")(0) + "'"
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Loop Until ln Is Nothing

            cnn.Close()
        Catch
            MsgBox(Err.Description)
        Finally
            Button11.Enabled = True
        End Try

    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Button12.Enabled = False
        Dim cnn0 As New SqlConnection(String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201"))
        Dim cmd0 As New SqlCommand("select count(*) as cnt from order_detail_tbl", cnn0)
        Dim dr0 As SqlDataReader
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader
        Dim cnn2 As New SqlConnection
        Dim LastAuto, x, y As Long
        'Try
        cnn2.ConnectionString = cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'"
        cmd2.Connection = cnn2
        cmd.Connection = cnn

        cnn.Open()
        'cmd.CommandText = "truncate table ship_file"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "truncate table ship_itm"
        'cmd.ExecuteNonQuery()

        cnn0.Open()
        cnn2.Open()
        x = cmd0.ExecuteScalar
        y = 0

        cmd0.CommandText = "select * from order_detail_tbl"
        dr0 = cmd0.ExecuteReader
        Do While dr0.Read
            If Not dr0("order_id") Is DBNull.Value And nz(dr0("full_description"), "") <> "" Then
                If Split(dr0("order_id"), "-").Length = 3 Then
                    Try
                        cmd.CommandText = "update ord_itm set ord_itm_note=~!~" + dr0("full_description") + "~!~ where ord_itm_ord_serial=" + Split(dr0("order_id"), "-")(0) + " and ord_itm_rev=" + Split(dr0("order_id"), "-")(2) + " and ord_itm_type=~!~O~!~ and ord_itm_line=" + CStr(nz(dr0("line_nbr"), 0))
                        cmd.CommandText = Replace(cmd.CommandText, "'", "''")
                        cmd.CommandText = Replace(cmd.CommandText, "~!~", "'")
                        cmd.ExecuteNonQuery()
                    Catch
                        tErr.Text = Err.Description + vbCr + tErr.Text
                        tErr.Visible = True
                    End Try
                End If

                If Split(dr0("order_id"), "-").Length = 2 Then
                    Try
                        cmd.CommandText = "update ord_itm set ord_itm_note=~!~" + dr0("full_description") + "~!~ where ord_itm_ord_serial=" + Split(dr0("order_id"), "-")(0) + " and ord_itm_rev=" + Split(dr0("order_id"), "-")(2) + " and ord_itm_type=~!~Q~!~ and ord_itm_line=" + CStr(nz(dr0("line_nbr"), 0))
                        cmd.CommandText = Replace(cmd.CommandText, "'", "''")
                        cmd.CommandText = Replace(cmd.CommandText, "~!~", "'")
                        cmd.ExecuteNonQuery()
                    Catch
                        tErr.Text = Err.Description + vbCr + tErr.Text
                        tErr.Visible = True
                    End Try
                End If
            End If
            y = y + 1
            Bar1.Value = y / x * 100
            'Application.DoEvents()
        Loop
        cnn0.Close()
        cnn2.Close()
        cnn.Close()
        Button12.Enabled = True
        'Catch
        '    MsgBox(Err.Description)
        'End Try
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim LowRev As Integer
        Dim onSerial As Double

        cmd.Connection = cnn
        cmd.CommandText = "select * from ord_gen where ord_gen_ord_serial=" + tOrd.Text + " and ord_gen_type='O'"

        cnn.Open()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count <> 2 Then
            MsgBox("order does not have 2 records")
        Else
            LowRev = 99
            onSerial = -1
            For Each dr In ds.Tables(0).Rows
                If dr("ord_gen_from_rev") < LowRev Then
                    LowRev = dr("ord_gen_from_rev")
                    onSerial = dr("ord_gen_serial")
                End If
            Next
            cmd.CommandText = "delete from ord_gen where ord_gen_serial=" + CStr(onSerial)
            cmd.ExecuteNonQuery()
        End If
        cnn.Close()
        tOrd.Focus()
        tOrd.SelectAll()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader
        Dim dr2 As SqlDataReader
        Dim onOrd, onRev As Long

        cmd.Connection = cnn
        cnn.Open()
        cmd2.Connection = cnn2
        cnn2.Open()

        cmd.CommandText = "select * from ship_file where ship_serial>=266228"
        dr = cmd.ExecuteReader
        Do While dr.Read
            If dr("ship_via") = "STAGED" Then
                cmd2.CommandText = "update ord_gen set ord_gen_staged=1,ord_gen_staged_date='" + CStr(dr("ship_date")) + "' where ord_gen_ord_serial=" + CStr(nz(dr("ship_ord_serial"), 0)) + " and ord_gen_rev=" + CStr(nz(dr("ship_ord_rev"), 0)) + " and ord_gen_type='O'"
                cmd2.ExecuteNonQuery()
                cmd2.CommandText = "update ord_gen set ord_gen_status='STAGED' where ord_gen_ord_serial=" + CStr(nz(dr("ship_ord_serial"), 0)) + " and ord_gen_rev=" + CStr(nz(dr("ship_ord_rev"), 0)) + " and ord_gen_type='O' and ord_gen_status<>'SHIPPED'"
                cmd2.ExecuteNonQuery()
            Else
                cmd2.CommandText = "update ord_gen set ord_gen_status='SHIPPED',ord_gen_ship_date='" + CStr(dr("ship_date")) + "' where ord_gen_ord_serial=" + CStr(nz(dr("ship_ord_serial"), 0)) + " and ord_gen_rev=" + CStr(nz(dr("ship_ord_rev"), 0)) + " and ord_gen_type='O'"
                cmd2.ExecuteNonQuery()
            End If
        Loop

        cnn.Close()
        cnn2.Close()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Try
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader
            Dim onOrd, onRev As Long
            Dim doit As Boolean

            Button14.Enabled = False
            cmd.Connection = cnn
            cnn.Open()
            cmd2.Connection = cnn2
            cnn2.Open()


            'cmd.CommandText = "select ship_ord_serial,ship_ord_rev,min(ship_date) as dt from ship_file where ship_via='STAGED' and ship_date > '1/15/06' group by ship_ord_serial,ship_ord_rev"
            'dr = cmd.ExecuteReader
            'Do While dr.Read
            'cmd2.CommandText = "update ord_gen set ord_gen_status='STAGED',ord_gen_staged_date='" + CStr(dr("dt")) + "',ord_gen_staged=1 where ord_gen_ord_serial=" + CStr(nz(dr("ship_ord_serial"), 0)) + " and ord_gen_rev=" + CStr(nz(dr("ship_ord_rev"), 0)) + " and ord_gen_type='O'"
            'cmd2.ExecuteNonQuery()
            'Loop
            'dr.Close()

            'cmd.CommandText = "select ship_ord_serial,ship_ord_rev,min(ship_date) as dt from ship_file where ship_via<>'STAGED' and ship_date > '1/15/06' group by ship_ord_serial,ship_ord_rev"
            'cmd.CommandText = "SELECT ord_gen.ord_gen_type, ship_file.ship_serial, ship_file.ship_date, ship_file.ship_ord_serial, ship_file.ship_ord_rev, ord_gen.ord_gen_status, ord_gen.ord_gen_ship_date, ship_file.ship_via FROM   ship_file ship_file INNER JOIN ord_gen ord_gen ON (ship_file.ship_ord_serial=ord_gen.ord_gen_ord_serial) AND (ship_file.ship_ord_rev=ord_gen.ord_gen_rev) and (ord_gen.ord_gen_type=ship_file.ship_ord_type)" 'AND  NOT (ord_gen.ord_gen_status='SHIPPED' OR ord_gen.ord_gen_status='STAGED' OR ord_gen.ord_gen_status='CANCELED') AND ship_file.ship_via<>'STAGED'"
            'cmd.CommandText = "SELECT ord_gen.ord_gen_type, ship_file.ship_serial, ship_file.ship_date, ship_file.ship_ord_serial, ship_file.ship_ord_rev, ord_gen.ord_gen_status, ord_gen.ord_gen_ship_date, ship_file.ship_via FROM   ship_file ship_file INNER JOIN ord_gen ord_gen ON (ship_file.ship_ord_serial=ord_gen.ord_gen_ord_serial) AND (ship_file.ship_ord_rev=ord_gen.ord_gen_rev) WHERE  ord_gen.ord_gen_type='O' AND ord_gen.ord_gen_status='SHIPPED' AND ship_file.ship_via<>'STAGED' and ord_gen_ship_date is null"

            cmd.CommandText = "SELECT ord_gen_ord_serial,ord_gen_rev,ord_gen_type,ord_gen_ship_date,min(ship_file.ship_date) as ship_date FROM   ord_gen INNER JOIN ship_file ON (ship_file.ship_ord_serial=ord_gen.ord_gen_ord_serial) AND (ship_file.ship_ord_rev=ord_gen.ord_gen_rev) and (ord_gen.ord_gen_type=ship_file.ship_ord_type) where ship_via<>'STAGED' group by ord_gen_ord_serial,ord_gen_rev,ord_gen_type,ord_gen_ship_date"


            dr = cmd.ExecuteReader
            Do While dr.Read
                doit = False
                If dr("ord_gen_ship_date") Is DBNull.Value Then
                    doit = True
                Else
                    If dr("ord_gen_ship_date") = CDate("1/1/1900") Then
                        doit = True
                    Else
                        If dr("ship_date") < nz(dr("ord_gen_ship_date"), CDate("1/1/2900")) Then
                            doit = True
                        End If
                    End If
                End If

                If doit Then
                    cmd2.CommandText = "update ord_gen set ord_gen_ship_date='" + CStr(dr("ship_date")) + "' where ord_gen_ord_serial=" + CStr(nz(dr("ord_gen_ord_serial"), 0)) + " and ord_gen_rev=" + CStr(nz(dr("ord_gen_rev"), 0)) + " and ord_gen_type='O'"
                    cmd2.ExecuteNonQuery()
                End If
            Loop
            dr.Close()

        Catch
            MsgBox(Err.Description)
        Finally
            cnn.Close()
            cnn2.Close()
            Button14.Enabled = True
        End Try
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim da As New SqlDataAdapter(cmd)
        Dim tot, pay, taxrate, tax, ship, totTaxable, Bal As Double
        Dim x, y As Long

        Try
            Button16.Enabled = False
            cmd.Connection = cnn
            cmd.CommandText = "select * from ord_gen where ord_gen_type='O' and ord_gen_update_date>'1/1/2006'"
            cnn.Open()
            da.Fill(ds, "ord")

            x = ds.Tables(0).Rows.Count + 1

            For Each dr In ds.Tables(0).Rows
                'If nz(dr("ord_gen_update_date"), CDate("1/1/1900")) >= CDate("1/8/2006") Then
                cmd.CommandText = "select sum((ord_itm_qty*ord_itm_unt_ship)) as tot from ord_itm where ord_itm_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(dr("ord_gen_rev")) + " and ord_itm_type='" + dr("ord_gen_type") + "'"
                ship = nz(cmd.ExecuteScalar, 0) + nz(dr("ord_gen_ship_extra"), 0) - nz(dr("ord_gen_ship_disc"), 0)

                cmd.CommandText = "select sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc) as tot from ord_itm where ord_itm_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(dr("ord_gen_rev")) + " and ord_itm_type='" + dr("ord_gen_type") + "'"
                tot = nz(cmd.ExecuteScalar, 0)

                cmd.CommandText = "select sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc) as tot from ord_itm where ord_itm_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(dr("ord_gen_rev")) + " and ord_itm_type='" + dr("ord_gen_type") + "' and ord_itm_taxable=1"
                totTaxable = nz(cmd.ExecuteScalar, 0)

                cmd.CommandText = "select sum(pay_itm_amt) as paysum from pay_itm where pay_itm_ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                pay = nz(cmd.ExecuteScalar, 0)

                cmd.CommandText = "select ord_cust_taxrate from ord_file where ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_tax_exempt=0"
                taxrate = nz(cmd.ExecuteScalar, 0)
                If nz(dr("ord_gen_update_date"), CDate("1/1/1900")) >= CDate("1/8/2006") Then
                    tax = Math.Round((taxrate * tot) + 0.00001, 2)
                Else
                    tax = Math.Round((taxrate * totTaxable) + 0.00001, 2)
                End If
                Bal = tot + ship + tax - pay
                If Bal >= -0.05 And Bal <= 0.05 Then Bal = 0

                cmd.CommandText = "update ord_gen set ord_gen_line_total=" + CStr(tot) + ",ord_gen_ship=" + CStr(ship) + ",ord_gen_tax=" + CStr(tax) + ", ord_gen_total=" + CStr(tot + ship + tax) + ",ord_gen_balance=" + CStr(Bal) + " where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                cmd.ExecuteNonQuery()
                'End If
                y = y + 1
                Bar1.Value = y / x * 100

            Next
        Catch
            MsgBox(Err.Description)
        Finally
            cnn.Close()
            Button16.Enabled = True
        End Try
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim cnn0 As SqlConnection
        Dim cmd As New SqlCommand("select * from order_tbl where not special_instr is null", cnn0)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim dr As DataRow
        Dim connstr As String

        Button17.Enabled = False
        connstr = String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201")
        cnn0 = New SqlClient.SqlConnection(connstr)

        cnn0.Open()
        cnn.Open()
        cmd.Connection = cnn0
        da.SelectCommand = cmd
        da.Fill(ds)
        cmd.Connection = cnn

        For Each dr In ds.Tables(0).Rows
            Try
                If dr("is_order_flg") = 1 Then
                    If Split(dr("order_id"), "-").Length > 1 Then
                        cmd.CommandText = "update ord_gen set ord_gen_special_notes='" + Replace(dr("special_instr"), "'", "''") + "' where ord_gen_ord_serial=" + Split(dr("order_id"), "-")(0) + " and ord_gen_from_rev=" + Split(dr("order_id"), "-")(1) + " and ord_gen_rev=" + Split(dr("order_id"), "-")(2) + " and ord_gen_type='O'"
                        cmd.ExecuteNonQuery()
                    End If
                Else
                    If Split(dr("order_id"), "-").Length > 0 Then
                        cmd.CommandText = "update ord_gen set ord_gen_special_notes='" + Replace(dr("special_instr"), "'", "''") + "' where ord_gen_ord_serial=" + Split(dr("order_id"), "-")(0) + " and ord_gen_rev=" + Split(dr("order_id"), "-")(1) + " and ord_gen_type='Q'"
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Catch
            End Try
        Next
        cnn0.Close()
        cnn.Close()
        Button17.Enabled = True
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim cnn0 As SqlConnection
        Dim cmd As New SqlCommand("select * from order_tbl where ship_disc_amt<>0", cnn0)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim dr As DataRow
        Dim connstr As String

        Button17.Enabled = False
        connstr = String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201")
        cnn0 = New SqlClient.SqlConnection(connstr)

        cnn0.Open()
        cnn.Open()
        cmd.Connection = cnn0
        da.SelectCommand = cmd
        da.Fill(ds)
        cmd.Connection = cnn

        For Each dr In ds.Tables(0).Rows
            Try
                If dr("is_order_flg") = 1 Then
                    If Split(dr("order_id"), "-").Length > 1 Then
                        cmd.CommandText = "update ord_gen set ord_gen_ship_disc=" + CStr(nz(dr("ship_disc_amt"), "0")) + " where ord_gen_ord_serial=" + Split(dr("order_id"), "-")(0) + " and ord_gen_from_rev=" + Split(dr("order_id"), "-")(1) + " and ord_gen_rev=" + Split(dr("order_id"), "-")(2) + " and ord_gen_type='O'"
                        cmd.ExecuteNonQuery()
                    End If
                Else
                    If Split(dr("order_id"), "-").Length > 0 Then
                        cmd.CommandText = "update ord_gen set ord_gen_ship_disc=" + CStr(nz(dr("ship_disc_amt"), "0")) + " where ord_gen_ord_serial=" + Split(dr("order_id"), "-")(0) + " and ord_gen_rev=" + Split(dr("order_id"), "-")(1) + " and ord_gen_type='Q'"
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Catch
            End Try
        Next
        cnn0.Close()
        cnn.Close()
        Button17.Enabled = True
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Try
            Button19.Enabled = False
            Dim fl As New IO.StreamReader("c:\temp\items.txt")
            Dim ln As String
            Dim cmd As New SqlCommand
            Dim dt As Date = CDate("1/26/06")
            Dim tot As Double
            Dim ProdType As String

            cmd.Connection = cnn
            cnn.Open()

            Do
                ln = fl.ReadLine
                If ln = Nothing Then Exit Do
                If Split(ln, vbTab).Length < 5 Then
                    ln = ln + vbCrLf + fl.ReadLine
                End If
                If Split(ln, vbTab).Length < 5 Then
                    ln = ln + vbCrLf + fl.ReadLine
                End If
                If Split(ln, vbTab).Length < 5 Then
                    ln = ln + vbCrLf + fl.ReadLine
                End If
                If Not ln Is Nothing Then
                    cmd.CommandText = "select count(itm_code) as cnt from itm_file where itm_code='" + Trim(Split(ln, vbTab)(1)) + "'"
                    If cmd.ExecuteScalar = 0 Then
                        ProdType = Trim(Split(ln, vbTab)(6))
                        Select Case ProdType
                            Case "Fixture"
                                ProdType = "FIX"
                            Case "Kits"
                                ProdType = "KIT"
                            Case Else
                                MsgBox(ProdType)
                        End Select

                        cmd.CommandText = "insert into itm_file (itm_code,itm_desc,itm_prod_type,last_update,update_by,inactive,itm_material,itm_ship_cost) values ('" + Trim(Split(ln, vbTab)(1)) + "','" + Replace(Split(ln, vbTab)(2), """", "") + "','" + ProdType + "','" + CStr(Now) + "','Import',0,'" + Split(ln, vbTab)(5) + "'," + Replace(Replace(Split(ln, vbTab)(7), ",", ""), """", "") + ")"
                        cmd.ExecuteNonQuery()

                        cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end) values ('" + Trim(Split(ln, vbTab)(1)) + "','BASE',1,999999," + Replace(Replace(Split(ln, vbTab)(3), ",", ""), """", "") + ",'1/1/1980','12/31/2099')"
                        cmd.ExecuteNonQuery()

                        cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end) values ('" + Trim(Split(ln, vbTab)(1)) + "','MD',1,999999," + Replace(Replace(Split(ln, vbTab)(4), ",", ""), """", "") + ",'1/1/1980','12/31/2099')"
                        cmd.ExecuteNonQuery()

                        'cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end) values ('" + Split(ln, vbtab)(0) + "','CON',1,999999," + Split(ln, vbtab)(4) + ",'1/1/1980','12/31/2099')"
                        'cmd.ExecuteNonQuery()

                        'cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end) values ('" + Split(ln, vbtab)(0) + "','RET',1,999999," + Split(ln, vbtab)(5) + ",'1/1/1980','12/31/2099')"
                        'cmd.ExecuteNonQuery()
                    Else
                        cmd.CommandText = "update itm_file set itm_desc='" + Replace(Split(ln, vbTab)(2), """", "") + "',inactive=0 where itm_code='" + Trim(Split(ln, vbTab)(1)) + "'"
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Loop Until ln Is Nothing

            cnn.Close()
        Catch
            MsgBox(Err.Description)
        Finally
            Button19.Enabled = True
        End Try

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Button20.Enabled = False
        Dim cmd As New SqlCommand("select pay_itm_serial,pay_serial,pay_itm_ord_serial,pay_itm_ord_rev from pay_itm,pay_file where pay_itm.billing_id=pay_file.billing_id and pay_itm.pay_id=pay_file.pay_id", cnn)
        Dim dr As SqlDataReader
        Dim x, y As Long
        Dim cnn0 As New SqlConnection
        Dim cmd0 As New SqlCommand

        cnn0.ConnectionString = String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201")
        cmd0.Connection = cnn0

        cnn.Open()
        cnn2.Open()
        cnn0.Open()
        Dim cmd2 As New SqlCommand
        cmd2.Connection = cnn2
        'cmd2.CommandText = "select count(*) as cnt from pay_itm,pay_file where pay_itm.billing_id=pay_file.billing_id and pay_itm.pay_id=pay_file.pay_id" ' where order_display_dt >='01-01-2005'"
        'x = cmd2.ExecuteScalar
        cmd0.CommandText = "select count(*) as cnt from order_payment_tbl"
        x = cmd0.ExecuteScalar
        y = 0

        cmd0.CommandText = "select order_payment_tbl.* from order_payment_tbl"
        dr = cmd0.ExecuteReader

        Dim LastPay, OrdGen As Long

        Do While dr.Read
            Try
                cmd2.CommandText = "insert into pay_file (pay_date,pay_amt,pay_method,pay_num,pay_exp_date,pay_auth_code) values ('" & CStr(nz(dr("pay_dt"))) & "'," & CStr(nz(dr("pay_amt"), "0")) & ",'" & nz(dr("pay_method_code")) & "','" & Replace(nz(dr("pay_nbr")), "'", "''") & "',null,'" & Replace(nz(dr("pay_auth_code")), "'", "''") & "')"
                cmd2.ExecuteNonQuery()
                cmd2.CommandText = "select @@IDENTITY as jid"
                LastPay = cmd2.ExecuteScalar
                cmd2.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + Split(dr("order_id"), "-")(0) + " and ord_gen_rev=" + Split(dr("order_id"), "-")(2) + " and ord_gen_type='O'"
                OrdGen = cmd2.ExecuteScalar
                cmd2.CommandText = "insert into pay_itm (pay_itm_pay_serial,pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,pay_itm_amt) values (" & CStr(LastPay) & "," & CStr(OrdGen) & "," & Split(dr("order_id"), "-")(0) & "," & Split(dr("order_id"), "-")(2) & "," & CStr(nz(dr("pay_amt"), "0")) + ")"
                cmd2.ExecuteNonQuery()
            Catch
                tErr.Text = nz(dr("order_id"), "") + " - " + Err.Description + vbCrLf + tErr.Text
                tErr.Visible = True
            Finally
                y = y + 1
                If (y / x * 100) <= Bar1.Maximum Then Bar1.Value = y / x * 100
                Application.DoEvents()
            End Try
        Loop
        cnn0.Close()
        cnn.Close()
        cnn2.Close()
        Button20.Enabled = True
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Dim cmd As New SqlCommand
        cmd.Connection = cnn
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow

        cmd.CommandText = "select ord_gen_serial, from ord_file where ord_serial<10000"
        da.Fill(ds)

        Dim fm As New fmEstOrd2
        fm.Show()
        For Each dr In ds.Tables(0).Rows
            fm.KeyValue1 = dr("ord_serial")
            fm.LoadPage()
            fm.Edit()
            fm.Save()
            fm.LoadPage()
        Next

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Dim cnn0 As New SqlConnection
        Dim cmd0 As New SqlCommand
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cnn0.ConnectionString = String.Format("server={0};user id={1}; password={2}; database=wci; pooling=false", Server, "sa", "39201")
        cmd0.Connection = cnn0
        cmd.Connection = cnn
        cnn0.Open()
        cnn.Open()

        cmd0.CommandText = "SELECT * FROM item_tbl WHERE (product_type_code = 'ARCH')"
        dr = cmd0.ExecuteReader
        Do While dr.Read
            cmd.CommandText = "update itm_file set itm_ship_cost=" + CStr(nz(dr("ship_extra"), 0)) + " where itm_code='" + dr("item_code") + "'"
            cmd.ExecuteNonQuery()
        Loop
        cnn0.Close()
        cnn.Close()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        Dim dr As SqlDataReader
        Dim dr2 As SqlDataReader
        Dim ds As New DataSet
        Dim dsr As DataRow
        Dim da As New SqlDataAdapter

        Dim Price As Double

        cmd.Connection = cnn
        cmd2.Connection = cnn2

        cnn.Open()
        cnn2.Open()

        cmd.CommandText = "select * from itm_file where itm_prod_type='KIT' and itm_code like 'SRS-%' and inactive=0"
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmd2.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + dr("itm_code") + "' and itm_price_type='RET' and itm_price_start<'2/9/06' and itm_price_end>'2/9/06'"
            Price = cmd2.ExecuteScalar

            ds.Clear()
            cmd2.CommandText = "select * from itm_price where itm_price_itm_code='" + dr("itm_code") + "' and itm_price_type='CON' and itm_price_start<'2/9/06' and itm_price_end>'2/9/06'"
            da.SelectCommand = cmd2
            da.Fill(ds)
            For Each dsr In ds.Tables(0).Rows
                cmd2.CommandText = "update itm_price set itm_price_end='2/8/06' where itm_price_serial=" + CStr(dsr("itm_price_serial"))
                cmd2.ExecuteNonQuery()
            Next
            cmd2.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale) values ('" + dr("itm_code") + "','CON',1,999999," + CStr(Math.Round(Price * 0.9, 2)) + ",'2/9/2006','12/31/2099',0)"
            cmd2.ExecuteNonQuery()

            ds.Clear()
            cmd2.CommandText = "select * from itm_price where itm_price_itm_code='" + dr("itm_code") + "' and itm_price_type='MD' and itm_price_start<'2/9/06' and itm_price_end>'2/9/06'"
            da.SelectCommand = cmd2
            da.Fill(ds)
            For Each dsr In ds.Tables(0).Rows
                cmd2.CommandText = "update itm_price set itm_price_end='2/8/06' where itm_price_serial=" + CStr(dsr("itm_price_serial"))
                cmd2.ExecuteNonQuery()
            Next
            cmd2.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end,itm_price_sale) values ('" + dr("itm_code") + "','MD',1,999999," + CStr(Math.Round(Price * 0.8, 2)) + ",'2/9/2006','12/31/2099',0)"
            cmd2.ExecuteNonQuery()

        Loop

    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Dim cmd As New SqlCommand("SELECT ord_gen.ord_gen_serial, ord_gen.ord_gen_sales_cat, cust_file.cust_sales_cat FROM ord_gen INNER JOIN ord_file ON ord_gen.ord_gen_ord_serial = ord_file.ord_serial INNER JOIN cust_file ON ord_file.ord_sold_cust_id = cust_file.cust_id WHERE (ord_gen.ord_gen_sales_cat = '') AND (cust_file.cust_sales_cat <> '')", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow

        cnn.Open()
        da.Fill(ds)
        For Each dr In ds.Tables(0).Rows
            cmd.CommandText = "update ord_gen set ord_gen_sales_cat='" + dr("cust_sales_cat") + "' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
            cmd.ExecuteNonQuery()
        Next

        cnn.Close()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader
        Dim onSerial As Long

        cmd.Connection = cnn
        cmd2.Connection = cnn2

        cmd.CommandText = "select * from pay_itm where pay_itm_ord_gen_serial=0"
        cnn.Open()
        cnn2.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmd2.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + CStr(dr("pay_itm_ord_serial")) + " and ord_gen_rev=" + CStr(dr("pay_itm_ord_rev")) + " and ord_gen_type='O'"
            onSerial = cmd2.ExecuteScalar
            cmd2.CommandText = "update pay_itm set pay_itm_ord_gen_serial=" + CStr(onSerial) + " where pay_itm_serial=" + CStr(dr("pay_itm_serial"))
            cmd2.ExecuteNonQuery()
        Loop
        cnn.Close()
        cnn2.Close()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        'Dim cmd As New SqlCommand("SELECT * from ord_file where ord_sold_cust_id<>'' and ord_sold_state=''", cnn)
        Dim cmd As New SqlCommand("SELECT * from nothingx where ord_sold_cust_id<>'' and ord_sold_state=''", cnn)
        Dim cmd2 As New SqlCommand("", cnn2)
        Dim dr As SqlDataReader
        Dim onState As String
        Dim test As Double

        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            DoError(Err, Me)
        End Try

        cnn.Open()
        cnn2.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmd2.CommandText = "select cust_state from cust_file where cust_id='" + dr("ord_sold_cust_id") + "'"
            onState = nz(cmd2.ExecuteScalar, "")
            If onState <> "" Then
                cmd2.CommandText = "update ord_file set ord_sold_state='" + onState + "' where ord_serial=" + CStr(dr("ord_serial"))
                cmd2.ExecuteNonQuery()
            End If
        Loop
        dr.Close()
        cnn.Close()
        cnn2.Close()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Dim cmd As New SqlCommand("select ord_gen_serial,ord_sold_cust_id,ord_sold_state,ord_sold_zip,ord_serial,ord_gen_inside from ord_gen,ord_file where ord_gen_ord_serial=ord_serial and ord_gen_create_date>='1/1/2004'", cnn)   'and isnull(ord_gen_outside,'')='' or isnull(ord_gen_inside,'')=''
        Dim cmd2 As New SqlCommand("", cnn2)
        Dim dr2 As DataRow
        Dim zip, zips As String
        Dim row As DataRow
        'Dim cmd3 As New SqlCommand
        'Dim cnn3 As New SqlConnection
        Dim dsOrd As New DataSet
        Dim drOrd As DataRow
        Dim daOrd As New SqlDataAdapter(cmd)
        Dim dsZip As New DataSet
        Dim daZip As New SqlDataAdapter(cmd2)
        Dim onOSR, onISR As String
        Dim cnt As Integer = 0
        Button27.Enabled = False

        Try
            cnn.Open()
            cnn2.Open()
            'cnn3.ConnectionString = cnn2.ConnectionString + ";password='JGMn4wbhnHL9s3be'"
            'cnn3.Open()
            'cmd3.Connection = cnn3

            daOrd.Fill(dsOrd, "ord")

            'drOrd = cmd.ExecuteReader
            For Each drOrd In dsOrd.Tables("ord").Rows
                'Do While drOrd.Read
                cmd2.CommandText = "select * from rep_ter where rep_ter_state='" + nz(drOrd("ord_sold_state")) + "'"
                dsZip.Clear()
                daZip.Fill(dsZip)
                onOSR = ""
                onISR = ""
                If dsZip.Tables(0).Rows.Count > 0 Then
                    For Each dr2 In dsZip.Tables(0).Rows
                        If nz(dr2("rep_ter_zip")) <> "" Then
                            For Each zips In Split(dr2("rep_ter_zip"), ",")
                                If Split(zips, "-").Length > 1 Then
                                    If (Mid(nz(drOrd("ord_sold_zip")), 1, 3) >= Mid(Trim(Split(zips, "-")(0)), 1, 3)) And (Mid(nz(drOrd("ord_sold_zip")), 1, 3) <= Mid(Trim(Split(zips, "-")(1)), 1, 3)) Then
                                        onOSR = dr2("rep_ter_out_rep_code")
                                        onISR = dr2("rep_ter_in_rep_code")
                                    End If
                                Else
                                    If Mid(nz(drOrd("ord_sold_zip")), 1, 3) = Mid(Trim(zips), 1, 3) Then
                                        onOSR = dr2("rep_ter_out_rep_code")
                                        onISR = dr2("rep_ter_in_rep_code")
                                    End If
                                End If
                            Next
                        Else
                            onOSR = dr2("rep_ter_out_rep_code")
                            onISR = dr2("rep_ter_in_rep_code")
                        End If
                    Next
                End If

                If nz(drOrd("ord_sold_cust_id")) <> "" Then
                    cmd2.CommandText = "select cust_rep from cust_file where cust_id='" + drOrd("ord_sold_cust_id") + "'"
                    onISR = nz(cmd2.ExecuteScalar)
                End If

                If onOSR = "" Then onOSR = "NONE"
                If onISR = "" Then
                    onISR = nz(drOrd("ord_gen_inside"))
                    Select Case nz(drOrd("ord_sold_state"))
                        Case "WA"
                            If nz(drOrd("ord_gen_inside")) <> "RANDALLM" Then onISR = "ERINC"
                        Case "OR"
                            If nz(drOrd("ord_gen_inside")) <> "RANDALLM" Then onISR = "ERINC"
                        Case "ID"
                            If nz(drOrd("ord_gen_inside")) <> "RANDALLM" Then onISR = "ERINC"
                        Case "UT"
                            If nz(drOrd("ord_gen_inside")) <> "RANDALLM" Then onISR = "ERINC"
                        Case "AZ"
                            If nz(drOrd("ord_gen_inside")) <> "RANDALLM" Then onISR = "ERINC"
                        Case "MT"
                            If nz(drOrd("ord_gen_inside")) <> "RANDALLM" Then onISR = "ERINC"
                        Case "WY"
                            If nz(drOrd("ord_gen_inside")) <> "RANDALLM" Then onISR = "ERINC"
                        Case "AK"
                            If nz(drOrd("ord_gen_inside")) <> "RANDALLM" Then onISR = "ERINC"
                        Case "HI"
                            If nz(drOrd("ord_gen_inside")) <> "RANDALLM" Then onISR = "ERINC"
                        Case "TX"
                            If nz(drOrd("ord_gen_inside")) <> "MELISSAB" Then onISR = "DAVEE"
                        Case "AR"
                            If nz(drOrd("ord_gen_inside")) <> "MELISSAB" Then onISR = "DAVEE"
                        Case "LA"
                            If nz(drOrd("ord_gen_inside")) <> "MELISSAB" Then onISR = "DAVEE"
                        Case "MS"
                            If nz(drOrd("ord_gen_inside")) <> "ERICD" Then onISR = "BRETTN"
                        Case "VA"
                            If nz(drOrd("ord_gen_inside")) <> "ERICD" Then onISR = "BRETTN"
                        Case "NY"
                            If nz(drOrd("ord_gen_inside")) <> "JASONC" Then onISR = "DAVEG"
                        Case Else
                            nz(drOrd("ord_serial"))
                    End Select
                End If

                cmd2.CommandText = "update ord_gen set ord_gen_outside='" + onOSR + "',ord_gen_inside='" + onISR + "' where ord_gen_serial=" + CStr(drOrd("ord_gen_serial"))
                cmd2.ExecuteNonQuery()
                'Loop
                Bar1.Value = cnt / dsOrd.Tables("ord").Rows.Count * 100
                cnt = cnt + 1
            Next
        Catch
            MsgBox(Err.Description)
        Finally
            cnn2.Close()
            cnn.Close()
            'cnn3.Close()
            Button27.Enabled = True
        End Try
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Try

            Button28.Enabled = False
            Dim br As New OpenFileDialog
            Dim ln As String
            Dim cmd As New SqlCommand("", cnn)
            Dim onDate As Date

            cnn.Open()
            If br.ShowDialog = DialogResult.OK Then
                Dim fl As New IO.StreamReader(br.FileName)
                Dim flOut As New IO.StreamWriter(Path + "except.txt", False)
                ln = fl.ReadLine
                Do While Not ln Is Nothing
                    If InStr(Split(ln, vbTab)(0), "-") > 0 Then
                        If IsDate(Split(ln, vbTab)(1)) = True Then
                            onDate = CDate(Split(ln, vbTab)(1))
                            cmd.CommandText = "update ord_gen set ord_gen_forecast='Forecasted',ord_gen_forecast_date='" + CStr(onDate) + "' where ord_gen_ord_serial=" + Split(Split(ln, vbTab)(0), "-")(0) + " and ord_gen_rev=" + Split(Split(ln, vbTab)(0), "-")(1) + " and ord_gen_type='Q'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "update ord_gen set ord_gen_resp_rep='I' where ord_gen_ord_serial=" + Split(Split(ln, vbTab)(0), "-")(0) + " and ord_gen_rev=" + Split(Split(ln, vbTab)(0), "-")(1) + " and ord_gen_type='Q' and ord_gen_inside='" + Split(ln, vbTab)(2) + "'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "update ord_gen set ord_gen_resp_rep='O' where ord_gen_ord_serial=" + Split(Split(ln, vbTab)(0), "-")(0) + " and ord_gen_rev=" + Split(Split(ln, vbTab)(0), "-")(1) + " and ord_gen_type='Q' and ord_gen_outside='" + Split(ln, vbTab)(2) + "'"
                            cmd.ExecuteNonQuery()
                        Else
                            If UCase(Split(ln, vbTab)(1)) = "N/A" Then
                                cmd.CommandText = "update ord_gen set ord_gen_forecast='Non-Active' where ord_gen_ord_serial=" + Split(Split(ln, vbTab)(0), "-")(0) + " and ord_gen_rev=" + Split(Split(ln, vbTab)(0), "-")(1) + " and ord_gen_type='Q'"
                                cmd.ExecuteNonQuery()
                            Else
                                flOut.WriteLine(ln)
                            End If
                        End If

                    Else
                        flOut.WriteLine(ln)
                    End If
                    ln = fl.ReadLine
                Loop

                fl.Close()
                flOut.Close()
            End If

        Catch
            MsgBox(Err.Description)
        Finally

            cnn.Close()
            Button28.Enabled = True
        End Try
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Try
            Button29.Enabled = False
            Dim br As New OpenFileDialog
            Dim ln As String
            Dim cmd As New SqlCommand("", cnn)
            Dim onDate As Date
            Dim onReason As String

            cnn.Open()
            If br.ShowDialog = DialogResult.OK Then
                Dim fl As New IO.StreamReader(br.FileName)
                ln = fl.ReadLine
                Do While Not ln Is Nothing
                    If InStr(Split(ln, vbTab)(0), "-") > 0 Then
                        'If Split(ln, vbTab)(9) = "X" Then
                        '    onReason = "Build Issue"
                        'ElseIf Split(ln, vbTab)(10) = "X" Then
                        '    onReason = "Lost Communication"
                        'ElseIf Split(ln, vbTab)(11) = "X" Then
                        '    onReason = "Design"
                        'ElseIf Split(ln, vbTab)(12) = "X" Then
                        '    onReason = "External Competition"
                        'ElseIf Split(ln, vbTab)(13) = "X" Then
                        '    onReason = "Internal Competition"
                        'ElseIf Split(ln, vbTab)(14) = "X" Then
                        '    onReason = "Too Expensive"
                        'ElseIf Split(ln, vbTab)(15) = "X" Then
                        '    onReason = "WCI Internal"
                        'ElseIf Split(ln, vbTab)(16) = "X" Then
                        '    onReason = "Lost Interest"
                        'Else
                        '    onReason = "Other"
                        'End If
                        cmd.CommandText = "update ord_gen set ord_gen_forecast='Lost',ord_gen_lost_reason='" + Replace(Mid(Split(ln, vbTab)(7), 1, 30), "'", "''") + "',ord_gen_forecast_note='" + Replace(Split(ln, vbTab)(8), "'", "''") + "' where ord_gen_ord_serial=" + Split(Split(ln, vbTab)(0), "-")(0) + " and ord_gen_rev=" + Split(Split(ln, vbTab)(0), "-")(1) + " and ord_gen_type='Q'"
                        cmd.ExecuteNonQuery()
                    End If
                    ln = fl.ReadLine
                Loop


            End If

        Catch
            MsgBox(Err.Description)
        Finally
            Button29.Enabled = True
            cnn.Close()
        End Try
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Try
            Button31.Enabled = False
            Dim cmd As New SqlCommand("update ord_gen set ord_gen_forecast='Lost',ord_gen_lost_reason='Lost Communication',ord_gen_forecast_note='Imported Forecast on " + CStr(Today) + "' where ord_gen_create_date<'1/1/2004'", cnn)
            cnn.Open()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update ord_gen set ord_gen_forecast='Need Forecast' where ord_gen_create_date>='1/1/2004'"
            cmd.ExecuteNonQuery()
            cnn.Close()
            Button31.Enabled = True
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Try
            Button30.Enabled = False
            Dim cmd As New SqlCommand("select ord_gen.ord_gen_serial,ord_gen.ord_gen_ord_serial from ord_gen inner join ord_gen as ord_gen_1 on ord_gen.ord_gen_rev=ord_gen_1.ord_gen_from_rev and ord_gen.ord_gen_ord_serial=ord_gen_1.ord_gen_ord_serial where ord_gen.ord_gen_type='Q' and ord_gen_1.ord_gen_type='O'", cnn)
            Dim dr As SqlDataReader
            Dim cmd2 As New SqlCommand("", cnn2)
            cnn.Open()
            cnn2.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                cmd2.CommandText = "update ord_gen set ord_gen_forecast='Revised' where ord_gen_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_gen_type='Q'"
                cmd2.ExecuteNonQuery()
                cmd2.CommandText = "update ord_gen set ord_gen_forecast='Ordered' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                cmd2.ExecuteNonQuery()
            Loop
            cnn.Close()
            cnn2.Close()
            Button30.Enabled = True
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        Try

            Button32.Enabled = False
            Dim br As New OpenFileDialog
            Dim ln As String
            Dim cmd As New SqlCommand("", cnn)
            Dim onDate As Date
            Dim onSerial As Long
            Dim onPrice As Double

            cnn.Open()
            If br.ShowDialog = DialogResult.OK Then
                Dim fl As New IO.StreamReader(br.FileName)
                ln = fl.ReadLine
                Do While Not ln Is Nothing
                    ln = Replace(ln, """", "")
                    If IsNumeric(Split(ln, vbTab)(3)) Then
                        onSerial = -1
                        cmd.CommandText = "delete from cust_itm_price where cust_itm_price_cust_serial=380 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "'"
                        onPrice = cmd.ExecuteScalar
                        cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_cust_serial=380 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "'"
                        onPrice = cmd.ExecuteScalar
                        cmd.CommandText = "select cust_itm_price_serial from cust_itm_price where cust_itm_price_cust_serial=380 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "' and cust_itm_price_price<>" + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "")
                        onSerial = cmd.ExecuteScalar

                        cmd.CommandText = "update itm_file set itm_ship_cost=" + Replace(Replace(Split(ln, vbTab)(3), "$", ""), ",", "") + " where itm_code='" + Split(ln, vbTab)(0) + "'"
                        cmd.ExecuteNonQuery()
                        If nz(onSerial, -1) > 0 Then
                            If onPrice <> CDbl(Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "")) Then
                                cmd.CommandText = "update cust_itm_price set cust_itm_price_end='" + CStr(Today) + "' where cust_itm_price_serial=" + CStr(onSerial)
                                cmd.ExecuteNonQuery()

                                If Split(ln, vbTab)(4) <> "" Then
                                    cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                        "(380,'" + Split(ln, vbTab)(0) + "',1,9999999,'" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "','6/1/2006'," + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "") + ")"
                                    cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                        "(380,'" + Split(ln, vbTab)(0) + "',1,9999999,'6/2/2006','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "") + ")"
                                    cmd.ExecuteNonQuery()
                                Else
                                    cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                        "(380,'" + Split(ln, vbTab)(0) + "',1,9999999,'" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "") + ")"
                                    cmd.ExecuteNonQuery()
                                End If
                            Else
                                If Split(ln, vbTab)(4) <> "" Then
                                    cmd.CommandText = "update cust_itm_price set cust_itm_price_end='6/1/2006' where cust_itm_price_serial=" + CStr(onSerial)
                                    cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                        "(380,'" + Split(ln, vbTab)(0) + "',1,9999999,'6/2/2006','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "") + ")"
                                    cmd.ExecuteNonQuery()
                                End If
                            End If
                        Else
                            If Split(ln, vbTab)(4) <> "" Then
                                cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                    "(380,'" + Split(ln, vbTab)(0) + "',1,9999999,'" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "','6/1/2006'," + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "") + ")"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                    "(380,'" + Split(ln, vbTab)(0) + "',1,9999999,'6/2/2006','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "") + ")"
                                cmd.ExecuteNonQuery()
                            Else
                                cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                    "(380,'" + Split(ln, vbTab)(0) + "',1,9999999,'" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "") + ")"
                                cmd.ExecuteNonQuery()
                            End If
                        End If
                    End If
                    ln = fl.ReadLine
                Loop
            End If

        Catch
            MsgBox(Err.Description)
        Finally
            cnn.Close()
            Button32.Enabled = True
        End Try
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        Try
            Button30.Enabled = False
            Dim cmd As New SqlCommand("select ord_gen.ord_gen_serial,ord_gen.ord_gen_ord_serial,ord_sold_cust_id from ord_gen,ord_file where ord_gen_ord_serial=ord_serial and ord_gen.ord_gen_type='Q' and (ord_gen_forecast='Need Forecast') and ord_gen_forecast_date='1/1/1900' and ord_gen_create_date>='1/1/2006' and isnull(ord_sold_cust_id,'')=''", cnn)
            Dim dr As SqlDataReader
            Dim cmd2 As New SqlCommand("", cnn2)
            cnn.Open()
            cnn2.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                cmd2.CommandText = "update ord_gen set ord_gen_forecast_date='10/26/2006' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                cmd2.ExecuteNonQuery()
            Loop
            cnn.Close()
            cnn2.Close()
            Button30.Enabled = True
        Catch
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        Try

            Button32.Enabled = False
            Dim br As New OpenFileDialog
            Dim ln As String
            Dim cmd As New SqlCommand("", cnn)
            Dim onDate As Date
            Dim onSerial As Long
            Dim onPrice As Double

            cnn.Open()
            If br.ShowDialog = DialogResult.OK Then
                Dim fl As New IO.StreamReader(br.FileName)
                ln = fl.ReadLine
                Do While Not ln Is Nothing
                    ln = Replace(ln, """", "")
                    If IsNumeric(Split(ln, vbTab)(3)) Then
                        onSerial = -1
                        'cmd.CommandText = "delete from cust_itm_price where cust_itm_price_cust_serial=120 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "'"
                        'onPrice = cmd.ExecuteScalar
                        cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_cust_serial=120 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "'"
                        onPrice = cmd.ExecuteScalar
                        cmd.CommandText = "select cust_itm_price_serial from cust_itm_price where cust_itm_price_cust_serial=120 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "' and cust_itm_price_price<>" + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "")
                        onSerial = cmd.ExecuteScalar

                        cmd.CommandText = "update itm_file set itm_ship_cost=" + Replace(Replace(Split(ln, vbTab)(3), "$", ""), ",", "") + " where itm_code='" + Split(ln, vbTab)(0) + "'"
                        cmd.ExecuteNonQuery()
                        If nz(onSerial, -1) > 0 Then
                            If onPrice <> CDbl(Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "")) Then
                                'cmd.CommandText = "update cust_itm_price set cust_itm_price_end='" + CStr(Today) + "' where cust_itm_price_serial=" + CStr(onSerial)
                                cmd.CommandText = "update cust_itm_price set cust_itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "' where cust_itm_price_cust_serial=120 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "' and cust_itm_price_price<>" + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "")
                                cmd.ExecuteNonQuery()

                                If Split(ln, vbTab)(4) <> "" Then
                                    cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                        "(120,'" + Split(ln, vbTab)(0) + "',1,9999999,'" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "','6/1/2006'," + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "") + ")"
                                    cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                        "(120,'" + Split(ln, vbTab)(0) + "',1,9999999,'6/2/2006','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "") + ")"
                                    cmd.ExecuteNonQuery()
                                Else
                                    cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                        "(120,'" + Split(ln, vbTab)(0) + "',1,9999999,'" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "") + ")"
                                    cmd.ExecuteNonQuery()
                                End If
                            Else
                                cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_cust_serial=120 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "'"
                                onPrice = cmd.ExecuteScalar
                                cmd.CommandText = "select cust_itm_price_serial from cust_itm_price where cust_itm_price_cust_serial=120 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "' and cust_itm_price_price<>" + Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "")
                                onSerial = cmd.ExecuteScalar

                                If Split(ln, vbTab)(4) <> "" Then
                                    'cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                    '    "(120,'" + Split(ln, vbTab)(0) + "',1,9999999,'" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "','6/1/2006'," + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "") + ")"
                                    'cmd.ExecuteNonQuery()
                                    If CDbl(Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "")) <> onPrice Then
                                        cmd.CommandText = "update cust_itm_price set cust_itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "' where cust_itm_price_cust_serial=120 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "' and cust_itm_price_price<>" + Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "")
                                        cmd.ExecuteNonQuery()
                                        cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                            "(120,'" + Split(ln, vbTab)(0) + "',1,9999999,'6/2/2006','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "") + ")"
                                        cmd.ExecuteNonQuery()
                                    End If
                                Else
                                    'cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                    '    "(120,'" + Split(ln, vbTab)(0) + "',1,9999999,'" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "") + ")"
                                    'cmd.ExecuteNonQuery()
                                End If
                            End If
                        Else
                            cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_cust_serial=120 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "'"
                            onPrice = cmd.ExecuteScalar
                            cmd.CommandText = "select cust_itm_price_serial from cust_itm_price where cust_itm_price_cust_serial=120 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "' and cust_itm_price_price<>" + Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "")
                            onSerial = cmd.ExecuteScalar

                            If Split(ln, vbTab)(4) <> "" Then
                                'cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                '    "(120,'" + Split(ln, vbTab)(0) + "',1,9999999,'" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "','6/1/2006'," + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "") + ")"
                                'cmd.ExecuteNonQuery()
                                If CDbl(Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "")) <> onPrice Then
                                    cmd.CommandText = "update cust_itm_price set cust_itm_price_end='" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "' where cust_itm_price_cust_serial=120 and cust_itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and cust_itm_price_start<='" + CStr(Today) + "' and cust_itm_price_end>='" + CStr(Today) + "' and cust_itm_price_price<>" + Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "")
                                    cmd.ExecuteNonQuery()
                                    cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                        "(120,'" + Split(ln, vbTab)(0) + "',1,9999999,'6/2/2006','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(4), "$", ""), ",", "") + ")"
                                    cmd.ExecuteNonQuery()
                                End If
                            Else
                                'cmd.CommandText = "insert into cust_itm_price (cust_itm_price_cust_serial,cust_itm_price_itm_code,cust_itm_price_from,cust_itm_price_to,cust_itm_price_start,cust_itm_price_end,cust_itm_price_price) values " + _
                                '    "(120,'" + Split(ln, vbTab)(0) + "',1,9999999,'" + CStr(DateAdd(DateInterval.Day, -1, Today)) + "','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(2), "$", ""), ",", "") + ")"
                                'cmd.ExecuteNonQuery()
                            End If
                        End If
                    End If
                    ln = fl.ReadLine
                Loop
            End If

        Catch
            MsgBox(Err.Description)
        Finally
            cnn.Close()
            Button32.Enabled = True
        End Try
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        Dim cmd As New SqlCommand("", cnn)
        Dim dr As SqlDataReader
        Dim cmd2 As New SqlCommand("", cnn2)

        cmd.CommandText = "SELECT     ord_file.ord_sold_county, zip_file.zip_county_name, ord_file.ord_serial FROM ord_file INNER JOIN zip_file ON ord_file.ord_sold_zip = zip_file.zip_code AND ord_file.ord_sold_city = zip_file.zip_city WHERE     (ord_file.ord_sold_county = '') OR (ord_file.ord_sold_county IS NULL)"
        cnn.Open()
        cnn2.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmd2.CommandText = "update ord_file set ord_sold_county='" + dr("zip_county_name") + "' where ord_serial=" + CStr(dr("ord_serial"))
            cmd2.ExecuteNonQuery()
        Loop
        dr.Close()
        cnn.Close()
        cnn2.Close()

    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        Dim cmd As New SqlCommand
        Dim fl As IO.StreamReader
        Dim fd As New OpenFileDialog
        Dim ln As String
        Dim onOrd, onRev, tmp, Adj, Note As String
        Dim Adjust As Double

        cmd.Connection = cnn
        If fd.ShowDialog = DialogResult.OK Then
            cnn.Open()
            fl = New IO.StreamReader(fd.FileName, IO.FileMode.Open)
            ln = fl.ReadLine
            Do While ln <> Nothing
                tmp = Split(ln, vbTab)(0)
                If Split(tmp, "-").Length = 3 And Split(ln, vbTab).Length >= 10 Then
                    If Split(ln, vbTab)(8) = "X" Then
                        onOrd = Split(tmp, "-")(0)
                        onRev = Split(tmp, "-")(2)
                        Adj = Split(ln, vbTab)(2)
                        If IsNumeric(Adj) Then
                            Adjust = CDbl(Adj) * -1
                            Note = Replace(Split(ln, vbTab)(9), "'", "''")
                            cmd.CommandText = "insert into ord_itm (ord_itm_ord_serial,ord_itm_rev,ord_itm_type,ord_itm_qty,ord_itm_desc,ord_itm_unt_sell,ord_itm_taxable,ord_itm_unt_ship,ord_itm_base_price,ord_itm_unt_base,ord_itm_mpf,ord_itm_markup,ord_itm_disc_perc,ord_itm_disc,ord_itm_price_method,ord_itm_prod_type,ord_itm_note,ord_itm_mat_code,ord_itm_fin_code,ord_itm_sel_material,ord_itm_line) values (" + onOrd + "," + onRev + ",'O',1,'Manual adjustment to balance made on " + CStr(Today) + " by Import - " + Note + "'," + CStr(Adjust) + ",0,0,0,0,1,0,0,0,'','','','','',0,999)"
                            cmd.ExecuteNonQuery()
                            UpdateBalance(onOrd, onRev)
                        End If
                    End If
                End If
                ln = fl.ReadLine
            Loop
            cnn.Close()
        End If
    End Sub
    Private Sub UpdateBalance(ByVal Ord As String, ByVal Rev As String)
        Dim cmd As New SqlClient.SqlCommand
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim tot, pay, taxrate, tax, ship, totTaxable As Double
        Dim x, y As Long

        Try
            'cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select * from ord_gen where ord_gen_ord_serial=" + Ord + " and ord_gen_rev=" + Rev + " and ord_gen_type='O'"
            da.Fill(ds, "ord")

            For Each dr In ds.Tables("ord").Rows
                cmd.CommandText = "select sum((ord_itm_qty*ord_itm_unt_ship)) as tot from ord_itm where ord_itm_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(dr("ord_gen_rev")) + " and ord_itm_type='" + dr("ord_gen_type") + "'"
                ship = Math.Round(nz2(cmd.ExecuteScalar, 0) + nz(dr("ord_gen_ship_extra"), 0) - nz2(dr("ord_gen_ship_disc"), 0), 2)

                cmd.CommandText = "select sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc) as tot from ord_itm where ord_itm_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(dr("ord_gen_rev")) + " and ord_itm_type='" + dr("ord_gen_type") + "'"
                tot = Math.Round(nz2(cmd.ExecuteScalar, 0), 2)

                'cmd.CommandText = "select sum((ord_itm_qty*ord_itm_unt_sell)-ord_itm_disc) as tot from ord_itm where ord_itm_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(dr("ord_gen_rev")) + " and ord_itm_type='" + dr("ord_gen_type") + "' and ord_itm_taxable=1"
                'totTaxable = Math.Round(nz(cmd.ExecuteScalar, 0), 2)

                cmd.CommandText = "select ord_gen_tax from ord_gen where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                tax = nz2(cmd.ExecuteScalar, 0)

                cmd.CommandText = "select sum(pay_itm_amt) as paysum from pay_itm where pay_itm_ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                pay = Math.Round(nz2(cmd.ExecuteScalar, 0), 2)

                'cmd.CommandText = "select ord_cust_taxrate from ord_file where ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_tax_exempt=0"
                'taxrate = nz(cmd.ExecuteScalar, 0)
                'tax = Math.Round((taxrate * totTaxable) + 0.00001, 2)

                cmd.CommandText = "update ord_gen set ord_gen_line_total=" + CStr(tot) + ",ord_gen_ship=" + CStr(ship) + ",ord_gen_tax=" + CStr(tax) + ", ord_gen_total=" + CStr(Math.Round(tot + ship + tax, 2)) + ",ord_gen_balance=" + CStr(Math.Round(tot + ship + tax - pay, 2)) + " where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                If Math.Round(tot + ship + tax - pay, 2) <> 0 Then
                    MsgBox("Balance " + Ord + "- -" + Rev)
                End If
                cmd.ExecuteNonQuery()

            Next
            'BalanceCheck("Adjustment Balance")
        Catch
            MsgBox(Err.Description)
        Finally
            'cnn.Close()
        End Try

    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        Try
            Dim fd As New OpenFileDialog
            If fd.ShowDialog <> DialogResult.OK Then Exit Sub
            Button37.Enabled = False
            Dim fl As New IO.StreamReader(fd.FileName)
            Dim ln As String
            Dim cmd As New SqlCommand
            Dim dt As Date = CDate("7/22/06")
            Dim tot As Double
            Dim ProdType As String

            cmd.Connection = cnn
            cnn.Open()

            Do
                ln = fl.ReadLine
                If ln = Nothing Then Exit Do
                'If Split(ln, vbTab).Length < 5 Then
                '    ln = ln + vbCrLf + fl.ReadLine
                'End If
                'If Split(ln, vbTab).Length < 5 Then
                '    ln = ln + vbCrLf + fl.ReadLine
                'End If
                'If Split(ln, vbTab).Length < 5 Then
                '    ln = ln + vbCrLf + fl.ReadLine
                'End If
                If Not ln Is Nothing Then
                    cmd.CommandText = "update itm_price set itm_price_end='7/21/2006' where itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and itm_price_start<'7/22/2006' and itm_price_end>'7/22/2006' and itm_price_type='BASE'"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_start,itm_price_end,itm_price_price,itm_price_sale) values ('" + Split(ln, vbTab)(0) + "','BASE',1,9999999,'7/22/06','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(1), ",", ""), "$", "") + ",0)"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "update itm_price set itm_price_end='7/21/2006' where itm_price_itm_code='" + Split(ln, vbTab)(0) + "' and itm_price_start<'7/22/2006' and itm_price_end>'7/22/2006' and itm_price_type='MD'"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_start,itm_price_end,itm_price_price,itm_price_sale) values ('" + Split(ln, vbTab)(0) + "','MD',1,9999999,'7/22/06','12/31/2099'," + Replace(Replace(Split(ln, vbTab)(2), ",", ""), "$", "") + ",0)"
                    cmd.ExecuteNonQuery()


                    '    cmd.CommandText = "select count(itm_code) as cnt from itm_file where itm_code='" + Trim(Split(ln, vbTab)(1)) + "'"
                    '    If cmd.ExecuteScalar = 0 Then
                    '        ProdType = Trim(Split(ln, vbTab)(6))
                    '        Select Case ProdType
                    '            Case "Fixture"
                    '                ProdType = "FIX"
                    '            Case "Kits"
                    '                ProdType = "KIT"
                    '            Case Else
                    '                MsgBox(ProdType)
                    '        End Select

                    '        cmd.CommandText = "insert into itm_file (itm_code,itm_desc,itm_prod_type,last_update,update_by,inactive,itm_material,itm_ship_cost) values ('" + Trim(Split(ln, vbTab)(1)) + "','" + Replace(Split(ln, vbTab)(2), """", "") + "','" + ProdType + "','" + CStr(Now) + "','Import',0,'" + Split(ln, vbTab)(5) + "'," + Replace(Replace(Split(ln, vbTab)(7), ",", ""), """", "") + ")"
                    '        cmd.ExecuteNonQuery()

                    '        cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end) values ('" + Trim(Split(ln, vbTab)(1)) + "','BASE',1,999999," + Replace(Replace(Split(ln, vbTab)(3), ",", ""), """", "") + ",'1/1/1980','12/31/2099')"
                    '        cmd.ExecuteNonQuery()

                    '        cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end) values ('" + Trim(Split(ln, vbTab)(1)) + "','MD',1,999999," + Replace(Replace(Split(ln, vbTab)(4), ",", ""), """", "") + ",'1/1/1980','12/31/2099')"
                    '        cmd.ExecuteNonQuery()

                    '        'cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end) values ('" + Split(ln, vbtab)(0) + "','CON',1,999999," + Split(ln, vbtab)(4) + ",'1/1/1980','12/31/2099')"
                    '        'cmd.ExecuteNonQuery()

                    '        'cmd.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_from,itm_price_qty_to,itm_price_price,itm_price_start,itm_price_end) values ('" + Split(ln, vbtab)(0) + "','RET',1,999999," + Split(ln, vbtab)(5) + ",'1/1/1980','12/31/2099')"
                    '        'cmd.ExecuteNonQuery()
                    '    Else
                    '        cmd.CommandText = "update itm_file set itm_desc='" + Replace(Split(ln, vbTab)(2), """", "") + "',inactive=0 where itm_code='" + Trim(Split(ln, vbTab)(1)) + "'"
                    '        cmd.ExecuteNonQuery()
                    '    End If
                End If
            Loop Until ln Is Nothing

            cnn.Close()
        Catch
            MsgBox(Err.Description)
        Finally
            Button37.Enabled = True
        End Try

    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Dim cmd As New SqlCommand("select * from itm_file where itm_ship_cost<>0", cnn)
        Dim dr As SqlDataReader
        Dim cmd2 As New SqlCommand
        cmd2.Connection = cnn2

        cnn.Open()
        cnn2.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmd2.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_to,itm_price_qty_from,itm_price_price,itm_price_start,itm_price_end,itm_price_sale) values ('" + dr("itm_code") + "','SHIP',999999,1," + CStr(dr("itm_ship_cost")) + ",'1/1/1900','12/31/2006',0)"
            cmd2.ExecuteNonQuery()
            'cmd2.CommandText = "insert into itm_price (itm_price_itm_code,itm_price_type,itm_price_qty_to,itm_price_qty_from,itm_price_price,itm_price_start,itm_price_end,itm_price_sale) values ('" + dr("itm_code") + "','SHIP',999999,1," + CStr(Math.Round(dr("itm_ship_cost") * 1.05, 2)) + ",'1/1/2007','12/31/2099',0)"
            'cmd2.ExecuteNonQuery()

        Loop
        cnn.Close()
        cnn2.Close()
    End Sub

    Private Sub bAddRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAddRef.Click
        If InStr(TextBox1.Text, "-") = 0 Then TextBox1.Text += "-0"
        CheckReferral(CLng(Split(TextBox1.Text, "-")(0)), CInt(Split(TextBox1.Text, "-")(1)), "O")
        TextBox1.Focus()
        TextBox1.SelectAll()
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        Button39.Enabled = False
        Dim cmd As New SqlCommand("select ord_itm_serial,ord_itm_ord_serial,ord_itm_rev from ord_gen,ord_itm,itm_file where ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev=ord_itm_rev and ord_gen_type=ord_itm_type and ord_itm_item_code=itm_code and ord_itm_item_code='DSSTAIN'", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow

        cnn.Open()
        da.Fill(ds)
        For Each dr In ds.Tables(0).Rows
            cmd.CommandText = "update ord_itm set ord_itm_mat_code='STAIN',ord_itm_prod_type='STAIN' where ord_itm_serial=" + CStr(dr("ord_itm_serial"))
            cmd.ExecuteNonQuery()
        Next
        cnn.Close()
        Button39.Enabled = True
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        Button40.Enabled = False
        Dim cmd As New SqlCommand("SELECT     ord_gen.ord_gen_serial, ord_itm_serial, ord_gen.ord_gen_ship_inside, ord_itm.ord_itm_unt_ship FROM         ord_gen INNER JOIN ord_itm ON ord_gen.ord_gen_ord_serial = ord_itm.ord_itm_ord_serial AND ord_gen.ord_gen_rev = ord_itm.ord_itm_rev AND ord_gen.ord_gen_type = ord_itm.ord_itm_type WHERE     (ord_itm.ord_itm_item_code = 'ISMALL') AND (ord_gen.ord_gen_ship_smalltruck = 1) and ord_itm_unt_ship=210 ORDER BY ord_gen.ord_gen_serial", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow

        cnn.Open()
        da.Fill(ds)
        For Each dr In ds.Tables(0).Rows
            'cmd.CommandText = "update ord_gen set ord_gen_ship_inside=0 where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
            'cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from ord_itm where ord_itm_serial=" + CStr(dr("ord_itm_serial"))
            cmd.ExecuteNonQuery()
        Next
        cnn.Close()
        Button40.Enabled = True
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        fo = New IO.StreamWriter("c:\FilesRenamed.txt", True)

        MoveFiles("\\10.0.0.185\pdf\2005")
        fo.Close()

    End Sub
    Private Sub MoveFiles(ByVal dir As String)
        Dim dr, fl As String
        Dim rootDir As String = Replace(dir, IO.Path.GetDirectoryName(dir), "")
        Dim NewDir, NewFile As String
        Dim cnt As Integer


        If Len(rootDir) > 1 Then rootDir = Mid(rootDir, 2)

        If Split(Split(rootDir, " ")(0), "-").Length = 2 Then
            NewDir = "\\10.0.0.245\pdf\projects$\" + Split(Split(rootDir, " ")(0), "-")(0)
            NewDir += Mid(rootDir, Len(Split(rootDir, " ")(0)) + 1)

            For Each fl In IO.Directory.GetFiles(dir)
                If Split(IO.Path.GetFileName(fl), " ")(0) <> Split(rootDir, " ")(0) Then
                    NewFile = IO.Path.GetDirectoryName(fl) + "\" + rootDir + " " + IO.Path.GetFileName(fl)
                    IO.File.Move(fl, NewFile)
                    fo.WriteLine(fl + vbTab + NewFile)
                End If
            Next

            If IO.Directory.Exists(NewDir) Then
                For Each fl In IO.Directory.GetFiles(dir)
                    If IO.File.Exists(NewDir + "\" + IO.Path.GetFileName(fl)) = True Then
                        cnt = 1
                        NewFile = NewDir + "\" + IO.Path.GetFileName(fl) + " (" + CStr(cnt) + ")"
                        Do While IO.File.Exists(NewFile) = True
                            cnt += 1
                            NewFile = NewDir + "\" + IO.Path.GetFileName(fl) + " (" + CStr(cnt) + ")"
                        Loop
                        IO.File.Move(fl, NewFile)
                        fo.WriteLine(fl + vbTab + NewFile)
                    Else
                        IO.File.Move(fl, NewDir + "\" + IO.Path.GetFileName(fl))
                    End If
                Next
                If IO.Directory.GetFiles(dir).Length = 0 And IO.Directory.GetDirectories(dir).Length = 0 Then IO.Directory.Delete(dir)
            Else
                IO.Directory.Move(dir, NewDir)
            End If
        Else
            For Each dr In IO.Directory.GetDirectories(dir)
                MoveFiles(dr)
            Next
        End If
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        'Try
        '    Button42.Enabled = False
        '    Dim cmd As New SqlCommand("SELECT     ord_gen.ord_gen_ord_serial, MAX(ord_gen.ord_gen_rev) AS ord_gen_rev, ord_gen.ord_gen_type AS ord_gen_type, ord_file.ord_sold_cust_id FROM          ord_gen INNER JOIN ord_file ON ord_gen.ord_gen_ord_serial = ord_file.ord_serial GROUP BY ord_gen.ord_gen_ord_serial, ord_gen.ord_gen_type, ord_file.ord_sold_cust_id HAVING      (ord_gen.ord_gen_type = 'Q') AND (ord_file.ord_sold_cust_id = 'WE')", cnn)
        '    Dim ds As New DataSet
        '    Dim da As New SqlDataAdapter(cmd)
        '    Dim rw As DataRow
        '    Dim dr As SqlDataReader

        '    cnn.Open()
        '    da.Fill(ds)
        '    For Each rw In ds.Tables(0).Rows
        '        cmd.CommandText = "update ord_gen set ord_gen_forecast=null,ord_gen_forecast_date='1/1/1900' where ord_gen_ord_serial=" + CStr(rw("ord_gen_ord_serial")) + " and ord_gen_rev=" + CStr(rw("ord_gen_rev")) + " and ord_gen_type='Q'"
        '        cmd.ExecuteNonQuery()
        '        cmd.CommandText = "select * from ord_gen where ord_gen_ord_serial=" + CStr(rw("ord_gen_ord_serial")) + " and ord_gen_type='O'"
        '        dr = cmd.ExecuteReader
        '        If dr.HasRows = False Then
        '            dr.Close()
        '            cmd.CommandText = "update ord_gen set ord_gen_forecast='Forecasted',ord_gen_forecast_date='7/25/2007',ord_gen_co_isr=1, ord_gen_co_isruser='System',ord_gen_co_isrdate='" + CStr(Now) + "' where ord_gen_ord_serial=" + CStr(rw("ord_gen_ord_serial")) + " and ord_gen_rev=" + CStr(rw("ord_gen_rev")) + " and ord_gen_type='Q' and ord_gen_create_date>='1/1/2007'"
        '            cmd.ExecuteNonQuery()
        '        Else
        '            dr.Close()
        '        End If
        '    Next
        'Catch
        '    MsgBox(Err.Description)
        'Finally
        '    Button42.Enabled = True
        'End Try
        Try
            Button42.Enabled = False
            Dim cmd As New SqlCommand("SELECT     ord_gen.ord_gen_ord_serial, ord_gen.ord_gen_rev, ord_gen.ord_gen_type, ord_file.ord_sold_cust_id FROM          ord_gen INNER JOIN ord_file ON ord_gen.ord_gen_ord_serial = ord_file.ord_serial where      (ord_gen.ord_gen_type = 'Q') AND (ord_file.ord_sold_cust_id = 'WE') and (ord_", cnn)
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cmd)
            Dim rw As DataRow
            Dim dr As SqlDataReader

            cnn.Open()
            da.Fill(ds)
            For Each rw In ds.Tables(0).Rows
                cmd.CommandText = "update ord_gen set ord_gen_forecast=null,ord_gen_forecast_date='1/1/1900' where ord_gen_ord_serial=" + CStr(rw("ord_gen_ord_serial")) + " and ord_gen_rev=" + CStr(rw("ord_gen_rev")) + " and ord_gen_type='Q'"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "select * from ord_gen where ord_gen_ord_serial=" + CStr(rw("ord_gen_ord_serial")) + " and ord_gen_type='O'"
                dr = cmd.ExecuteReader
                If dr.HasRows = False Then
                    dr.Close()
                    cmd.CommandText = "update ord_gen set ord_gen_forecast='Forecasted',ord_gen_forecast_date='7/25/2007',ord_gen_co_isr=1, ord_gen_co_isruser='System',ord_gen_co_isrdate='" + CStr(Now) + "' where ord_gen_ord_serial=" + CStr(rw("ord_gen_ord_serial")) + " and ord_gen_rev=" + CStr(rw("ord_gen_rev")) + " and ord_gen_type='Q' and ord_gen_create_date>='1/1/2007'"
                    cmd.ExecuteNonQuery()
                Else
                    dr.Close()
                End If
            Next
        Catch
            MsgBox(Err.Description)
        Finally
            Button42.Enabled = True
        End Try
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        Button43.Enabled = False
        Dim fl As New IO.StreamReader("\\10.0.0.245\jcom$\Temp\allow0base.txt")
        Dim ln As String
        Dim cmd As New SqlCommand("", cnn)

        ln = fl.ReadLine
        cnn.Open()
        Do
            cmd.CommandText = "update itm_file set itm_allow_0_base_price=1 where itm_code='" + Split(ln, vbTab)(0) + "'"
            cmd.ExecuteNonQuery()
            ln = fl.ReadLine
        Loop Until ln Is Nothing
        cnn.Close()
        Button43.Enabled = True
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        Dim cmd As New SqlCommand("select * from ord_itm where ord_itm_item_code='BOMIMPORT' order by ord_itm_serial", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow
        Dim onOrd As String
        Dim cnt As Long = 0
        Dim onSerial As Long

        Button44.Enabled = False
        cnn.Open()
        da.Fill(ds)
        For Each dr In ds.Tables(0).Rows
            If dr("ord_itm_desc") = "********* BOM Import *********" Then
                onOrd = dr("ord_itm_type") + "-" + CStr(dr("ord_itm_ord_serial")) + "-" + CStr(dr("ord_itm_rev"))
                onSerial = dr("ord_itm_serial")
                If IsDate(Replace(Replace(dr("ord_itm_note"), "BOM created on ", ""), "@", "")) Then
                    cmd.CommandText = "update ord_gen set ord_gen_bom_import='" + CStr(CDate(Replace(Replace(dr("ord_itm_note"), "BOM created on ", ""), "@", ""))) + "' where ord_gen_ord_serial=" + CStr(dr("ord_itm_ord_serial")) + " and ord_gen_rev=" + CStr(dr("ord_itm_rev")) + " and ord_gen_type='" + dr("ord_itm_type") + "'"
                    cmd.ExecuteNonQuery()
                End If
            Else
                If onOrd = dr("ord_itm_type") + "-" + CStr(dr("ord_itm_ord_serial")) + "-" + CStr(dr("ord_itm_rev")) Then
                    cmd.CommandText = "update ord_itm set ord_itm_bom_import=1 where ord_itm_serial>=" + CStr(onSerial) + " and ord_itm_serial<=" + CStr(dr("ord_itm_serial"))
                    cmd.ExecuteNonQuery()
                End If

            End If
            cnt += 1
            Bar1.Value = (cnt / ds.Tables(0).Rows.Count) * 100
            Application.DoEvents()
        Next

        cnn.Close()
        Button44.Enabled = True
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        Dim cmd As New SqlCommand("", cnn)
        'Dim fl As New IO.StreamReader("c:\data\customers\winecellar\temp\kits.txt")
        Dim fl As New IO.StreamReader("c:\temp\Import VIN-3 KITS.txt")
        Dim ln, itm, name As String
        Button45.Enabled = False
        Try
            cnn.Open()
            ln = fl.ReadLine
            Do While ln <> ""
                If IsNumeric(Split(ln, vbTab)(3)) = True Then
                    itm = Split(ln, vbTab)(0)
                    name = Split(ln, vbTab)(1)
                    'If InStr(itm, "#") > 0 Then
                    '    itm = Mid(itm, 1, InStr(itm, "#") - 1)
                    'End If
                    cmd.CommandText = "insert into itm_box (itm_box_itm_code,itm_box_len,itm_box_width,itm_box_height,itm_box_weight,itm_box_name) values ('" + itm + "'," + Split(ln, vbTab)(3) + "," + Split(ln, vbTab)(4) + "," + Split(ln, vbTab)(5) + "," + Split(ln, vbTab)(6) + ",'" + name + "')"
                    cmd.ExecuteNonQuery()
                End If
                ln = fl.ReadLine
            Loop
        Catch
            MsgBox(Err.Description)
        Finally
            cnn.Close()
            fl.Close()
            Button45.Enabled = True
        End Try
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        Dim cmd As New SqlCommand("select * from cust_file", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow

        cnn.Open()
        da.Fill(ds)
        For Each dr In ds.Tables(0).Rows
            If nz(dr("cust_rep")) <> "" Then
                cmd.CommandText = "update ord_gen set ord_gen_inside='" + dr("cust_rep") + "' where ord_gen_temp='" + Replace(dr("cust_id"), "'", "''") + "' and (ord_gen_type='O' and ord_gen_balance<>0)"
                cmd.ExecuteNonQuery()
            End If
        Next
        cnn.Close()
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        'Dim fl As New IO.StreamReader("c:\temp\Tax Exempt UPDATED 2-22.txt")
        'Dim ln As String
        'Dim cmd As New SqlCommand("", cnn)
        'Dim dr As SqlDataReader
        'Dim onSerial As Long
        'Dim xExp, xRec As String

        'Try
        '    cnn.Open()
        '    ln = fl.ReadLine
        '    Do While ln <> ""
        '        cmd.CommandText = "select * from tax_cert where tax_cert_no='" + Trim(Split(ln, vbTab)(5)) + "'"
        '        dr = cmd.ExecuteReader()
        '        If dr.HasRows Then
        '            dr.Read()
        '            onSerial = dr("tax_cert_serial")
        '            dr.Close()
        '            cmd.CommandText = "update tax_cert set tax_cust_name='" + Replace(Trim(Split(ln, vbTab)(0)), "'", "''") + "' where tax_cert_serial=" + CStr(onSerial)
        '            cmd.ExecuteNonQuery()
        '        Else
        '            dr.Close()
        '            If IsDate(Split(ln, vbTab)(7)) Then
        '                xExp = "'" + Split(ln, vbTab)(7) + "'"
        '            Else
        '                xExp = "null"
        '            End If
        '            If IsDate(Split(ln, vbTab)(6)) Then
        '                xRec = "'" + Split(ln, vbTab)(6) + "'"
        '            Else
        '                xRec = "null"
        '            End If
        '            cmd.CommandText = "insert into tax_cert (tax_cert_cust_id,tax_cust_name,tax_cert_expires,tax_cert_no,tax_cert_received,tax_cert_sold_state,tax_cert_state,tax_cert_type,tax_cert_note) values ('" + Replace(Trim(Split(ln, vbTab)(1)), "'", "''") + "','" + Replace(Replace(Trim(Split(ln, vbTab)(0)), "'", "''"), """", "") + "'," + xExp + ",'" + Trim(Split(ln, vbTab)(5)) + "'," + xRec + ",'" + Trim(Split(ln, vbTab)(3)) + "','" + Replace(Trim(Split(ln, vbTab)(3)), "'", "''") + "','" + Replace(Trim(Split(ln, vbTab)(4)), "'", "''") + "','" + Replace(Trim(Split(ln, vbTab)(2)), "'", "''") + "')"
        '            cmd.ExecuteNonQuery()
        '        End If
        '        ln = fl.ReadLine
        '    Loop
        'Catch
        '    MsgBox(Err.Description + vbCrLf + vbCrLf + cmd.CommandText)
        'Finally
        '    cnn.Close()
        'End Try

        Dim fl As New IO.StreamReader("c:\temp\Tax Exempt UPDATED1.txt")
        Dim ln As String
        Dim cmd As New SqlCommand("", cnn)
        Dim dr As SqlDataReader
        Dim onSerial As Long
        Dim xExp, xRec As String

        Try
            cnn.Open()
            ln = fl.ReadLine
            Do While ln <> ""
                cmd.CommandText = "select * from tax_cert where tax_cert_no='" + Trim(Split(ln, vbTab)(9)) + "'"
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    dr.Read()
                    onSerial = dr("tax_cert_serial")
                    If nz(dr("tax_cert_addr")) = "" And Trim(Split(ln, vbTab)(2)) <> "" Then
                        dr.Close()
                        cmd.CommandText = "update tax_cert set tax_cert_addr='" + Replace(Trim(Split(ln, vbTab)(2)), "'", "''") + "',tax_cert_city='" + Replace(Trim(Split(ln, vbTab)(3)), "'", "''") + "',tax_cert_state='" + Replace(Trim(Split(ln, vbTab)(4)), "'", "''") + "',tax_cert_zip='" + Replace(Trim(Split(ln, vbTab)(5)), "'", "''") + "' where tax_cert_serial=" + CStr(onSerial)
                        cmd.ExecuteNonQuery()
                    Else
                        dr.Close()
                    End If
                Else
                    dr.Close()
                End If
                ln = fl.ReadLine
            Loop
        Catch
            MsgBox(Err.Description + vbCrLf + vbCrLf + cmd.CommandText)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        Dim cmd As New SqlCommand("", cnn)
        Dim cmd2 As New SqlCommand("", cnn2)
        Dim dr As SqlDataReader
        Dim onGroup As Integer
        Dim Recs, Cnt As Long

        cnn.Open()
        cmd.CommandText = "select count(ord_itm_serial) from ord_itm"
        Recs = cmd.ExecuteScalar
        Cnt = 0

        cmd.CommandText = "select ord_itm_serial,ord_itm_item_code from ord_itm order by ord_itm_serial desc"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            cnn2.Open()
            Do While dr.Read
                cmd2.CommandText = "select ord_group_no from itm_file,ord_group where itm_code=ord_group_itm_code and itm_code='" + dr("ord_itm_item_code") + "'"
                onGroup = nz(cmd2.ExecuteScalar, -1)
                If onGroup = -1 Then
                    cmd2.CommandText = "select ord_group_no from itm_file,ord_group where itm_com_prod_type=ord_group_prod_type and itm_code='" + dr("ord_itm_item_code") + "'"
                    onGroup = nz(cmd2.ExecuteScalar, -1)
                End If
                If onGroup = -1 Then
                    cmd2.CommandText = "select ord_group_no from itm_file,ord_group where itm_prod_type=ord_group_prod_type and itm_code='" + dr("ord_itm_item_code") + "'"
                    onGroup = nz(cmd2.ExecuteScalar, -1)
                End If
                If onGroup = -1 Then onGroup = 0
                cmd2.CommandText = "update ord_itm set ord_itm_group = " + CStr(onGroup) + " where ord_itm_serial=" + CStr(dr("ord_itm_serial"))
                cmd2.ExecuteNonQuery()

                Bar1.Value = Cnt / Recs * 100
                Bar1.Refresh()
                Cnt += 1
            Loop
            cnn2.Close()
        End If
        cnn.Close()
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Button49.Enabled = False
        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim cmd2 As New SqlCommand("", cnn2)
        Dim dr As SqlDataReader

        cmd.CommandText = "select ord_gen_serial,cust_rep,ord_gen_inside from ord_gen,ord_file,cust_file where ord_gen_ord_serial=ord_serial and ord_sold_cust_id=cust_id and ord_gen_type='Q'"
        cnn.Open()
        cnn2.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            If dr("ord_gen_inside") <> dr("cust_rep") Then
                cmd2.CommandText = "update ord_gen set ord_gen_inside='" + dr("cust_rep") + "' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                cmd2.ExecuteNonQuery()
            End If
        Loop
        dr.Close()

        cmd.CommandText = "select ord_gen_serial,cust_rep,ord_gen_inside from ord_gen,ord_file,cust_file where ord_gen_ord_serial=ord_serial and ord_sold_cust_id=cust_id and ord_gen_type='O' and ord_gen_status<>'SHIPPED' and ord_gen_status<>'STAGED'"
        dr = cmd.ExecuteReader
        Do While dr.Read
            If dr("ord_gen_inside") <> dr("cust_rep") Then
                cmd2.CommandText = "update ord_gen set ord_gen_inside='" + dr("cust_rep") + "' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                cmd2.ExecuteNonQuery()
            End If
        Loop
        dr.Close()

        cnn.Close()
        cnn2.Close()
        Button49.Enabled = True
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        'did not use.  created 1/23/2008
        Dim fl As New IO.StreamReader("c:\data\customers\winecellar\temp\departments.txt")
        Dim ln As String
        Dim cmd As New SqlCommand("", cnn)

        cnn.Open()
        ln = fl.ReadLine
        Do While ln <> ""
            cmd.CommandText = "update itm_file set itm_dept='" + Split(ln, vbTab)(0) + "' where itm_code='" + Split(ln, vbTab)(1) + "'"
            cmd.ExecuteNonQuery()
            ln = fl.ReadLine
        Loop
        cnn.Close()
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click
        Button51.Enabled = False
        Dim cmd As New SqlCommand("", cnn)
        Dim dr, drOrd As DataRow
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dsOrd As New DataSet
        Dim zips, zipx As String
        Dim row As DataRow
        Dim Zip As Integer
        Dim doOutside As Boolean
        Dim cnt As Integer = 0

        cnn.Open()

        cmd.CommandText = "select ord_gen_serial,ord_sold_cust_id,ord_sold_state,ord_sold_zip from ord_file, ord_gen where ord_serial=ord_gen_ord_serial and ord_sold_cust_id='' and ((ord_gen_type='Q') or (ord_gen_type='O' and ord_gen_status<>'SHIPPED' and ord_gen_status<>'STAGED')) and ord_serial=170453"
        da.Fill(dsOrd)

        For Each drOrd In dsOrd.Tables(0).Rows
            If nz(drOrd("ord_sold_state")) <> "" Then
                cmd.CommandText = "select * from rep_ter where rep_ter_state='" + drOrd("ord_sold_state") + "'"
                ds.Clear()
                da.Fill(ds, "rep")
                If ds.Tables("rep").Rows.Count > 0 Then
                    For Each dr In ds.Tables("rep").Rows
                        If nz(dr("rep_ter_zip")) <> "" Then
                            If nz(drOrd("ord_sold_zip")) = "" Then
                                Exit For
                            End If
                            For Each zips In Split(dr("rep_ter_zip"), ",")
                                For Zip = CInt(Split(zips, "-")(0)) To CInt(Split(zips, "-")(Split(zips, "-").Length - 1))
                                    zipx = Format(Zip, "000")
                                    If Mid(drOrd("ord_sold_zip"), 1, Len(Trim(zipx))) = Mid(Trim(zipx), 1, Len(Trim(zipx))) Then
                                        cmd.CommandText = "update ord_gen set ord_gen_outside='" + dr("rep_ter_out_rep_code") + "' where ord_gen_serial=" + CStr(drOrd("ord_gen_serial"))
                                        cmd.ExecuteNonQuery()
                                        cmd.CommandText = "update ord_gen set ord_gen_inside='" + dr("rep_ter_in_rep_code") + "' where ord_gen_serial=" + CStr(drOrd("ord_gen_serial"))
                                        cmd.ExecuteNonQuery()
                                        Exit For
                                    End If
                                Next
                            Next
                        Else
                            cmd.CommandText = "update ord_gen set ord_gen_outside='" + dr("rep_ter_out_rep_code") + "' where ord_gen_serial=" + CStr(drOrd("ord_gen_serial"))
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "update ord_gen set ord_gen_inside='" + dr("rep_ter_in_rep_code") + "' where ord_gen_serial=" + CStr(drOrd("ord_gen_serial"))
                            cmd.ExecuteNonQuery()
                            Exit For
                        End If
                    Next
                End If
            End If
            Bar1.Value = (cnt / dsOrd.Tables(0).Rows.Count * 100)
            cnt += 1
            lMin.Text = CStr(cnt)
            Application.DoEvents()
        Next
        cnn.Close()
        Button51.Enabled = True
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        Try
            Button52.Enabled = False
            Dim cmd As New SqlCommand("", cnn)
            Dim dr, drOrd As DataRow
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            Dim dsOrd As New DataSet
            Dim zips, zipx As String
            Dim row As DataRow
            Dim Zip As Integer
            Dim doOutside As Boolean
            Dim cnt As Integer = 0
            Dim GotIt As Boolean

            cnn.Open()

            cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_rev,ord_gen_type,ord_sold_cust_id,ord_sold_state,ord_sold_zip from ord_file, ord_gen where ord_serial=ord_gen_ord_serial and ord_sold_cust_id='' and ((ord_gen_type='Q') or (ord_gen_type='O' and ord_gen_status<>'SHIPPED' and ord_gen_status<>'STAGED'))"
            da.Fill(dsOrd)

            For Each drOrd In dsOrd.Tables(0).Rows
                GotIt = False
                If nz(drOrd("ord_sold_state")) <> "" Then
                    cmd.CommandText = "select * from rep_ter where rep_ter_state='" + drOrd("ord_sold_state") + "'"
                    ds.Clear()
                    da.Fill(ds, "rep")
                    If ds.Tables("rep").Rows.Count > 0 Then
                        For Each dr In ds.Tables("rep").Rows
                            If nz(dr("rep_ter_zip")) <> "" Then
                                If nz(drOrd("ord_sold_zip")) = "" Then
                                    Exit For
                                End If
                                For Each zips In Split(dr("rep_ter_zip"), ",")
                                    For Zip = CInt(Split(zips, "-")(0)) To CInt(Split(zips, "-")(Split(zips, "-").Length - 1))
                                        zipx = Format(Zip, "000")
                                        If Mid(drOrd("ord_sold_zip"), 1, Len(Trim(zipx))) = Mid(Trim(zipx), 1, Len(Trim(zipx))) Then
                                            GotIt = True
                                            'cmd.CommandText = "update ord_gen set ord_gen_outside='" + dr("rep_ter_out_rep_code") + "' where ord_gen_serial=" + CStr(drOrd("ord_gen_serial"))
                                            'cmd.ExecuteNonQuery()
                                            'cmd.CommandText = "update ord_gen set ord_gen_inside='" + dr("rep_ter_in_rep_code") + "' where ord_gen_serial=" + CStr(drOrd("ord_gen_serial"))
                                            'cmd.ExecuteNonQuery()
                                            Exit For
                                        End If
                                    Next
                                Next
                            Else
                                GotIt = True
                                'cmd.CommandText = "update ord_gen set ord_gen_outside='" + dr("rep_ter_out_rep_code") + "' where ord_gen_serial=" + CStr(drOrd("ord_gen_serial"))
                                'cmd.ExecuteNonQuery()
                                'cmd.CommandText = "update ord_gen set ord_gen_inside='" + dr("rep_ter_in_rep_code") + "' where ord_gen_serial=" + CStr(drOrd("ord_gen_serial"))
                                'cmd.ExecuteNonQuery()
                                Exit For
                            End If
                        Next
                    End If
                End If
                If GotIt = False Then
                    'MsgBox(CStr(drOrd("ord_gen_ord_serial")) + "-" + CStr(drOrd("ord_gen_rev")) + CStr(drOrd("ord_gen_type")))
                    cmd.CommandText = "update ord_gen set ord_gen_temp='None' where ord_gen_serial=" + CStr(drOrd("ord_gen_serial"))
                    cmd.ExecuteNonQuery()
                End If
                Bar1.Value = (cnt / dsOrd.Tables(0).Rows.Count * 100)
                cnt += 1
                lMin.Text = CStr(cnt)
                Application.DoEvents()
            Next
            cnn.Close()
            Button52.Enabled = True
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        Dim connstr As String
        connstr = String.Format("server={0};user id={1}; password={2}; database=winecellaracct; pooling=false", Server, "sa", "39201")
        cnn0 = New SqlClient.SqlConnection(connstr)

        Dim cmd As New SqlCommand("", cnn)
        Dim cmd0 As New SqlCommand("", cnn0)
        Dim dr As SqlDataReader


        cnn0.Open()
        cnn.Open()
        cmd0.CommandText = "select ord_gen_serial,ord_gen_terr from ord_gen where ord_gen_type='O' and ord_gen_status in ('SHIPPED','STAGED','CANCELED')"
        dr = cmd0.ExecuteReader
        Do While dr.Read
            cmd.CommandText = "update ord_gen set ord_gen_terr='" + nz(dr("ord_gen_terr")) + "' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
            cmd.ExecuteNonQuery()
        Loop
        cnn0.Close()
        cnn.Close()

    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        Dim cnnAcct As New SqlConnection
        Dim cmdAcct As New SqlCommand("", cnnAcct)
        Dim cmd As New SqlCommand("", cnn)
        Dim drAcct, dr As SqlDataReader
        Dim DoIt As Boolean = False

        cnnAcct.ConnectionString = String.Format("server={0};user id={1}; password={2}; database=winecellaracct; pooling=false", Server, "sa", "39201")
        cnnAcct.Open()
        cnn.Open()

        cmdAcct.CommandText = "select ord_gen.ord_gen_serial,ord_itm.* from ord_gen,ord_itm where ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_type=ord_itm_type and ord_gen_rev=ord_itm_rev and  (ord_gen.ord_gen_type = 'O') AND (ord_gen.ord_gen_status IN ('SHIPPED', 'STAGED')) AND ((CASE ord_gen_staged WHEN 1 THEN ord_gen_staged_date ELSE ord_gen_ship_date END) >= '1/1/2008') AND ((CASE ord_gen_staged WHEN 1 THEN ord_gen_staged_date ELSE ord_gen_ship_date END) <= '1/27/2008')"
        drAcct = cmdAcct.ExecuteReader
        Do While drAcct.Read
            cmd.CommandText = "select * from ord_itm where ord_itm_serial=" + CStr(drAcct("ord_itm_serial"))
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If drAcct("ord_itm_qty") <> dr("ord_itm_qty") Then DoIt = True
                If drAcct("ord_itm_unt_sell") <> dr("ord_itm_unt_sell") Then DoIt = True
                If drAcct("ord_itm_disc") <> dr("ord_itm_disc") Then DoIt = True
                If drAcct("ord_itm_disc_amt") <> dr("ord_itm_disc_amt") Then DoIt = True

                If DoIt Then
                    MsgBox("Data is inccorect for serial " + CStr(drAcct("ord_itm_serial")))
                    DoIt = False
                End If
            Else
                MsgBox("No data for serial " + CStr(drAcct("ord_gen_serial")))
            End If
            dr.Close()
        Loop

    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click
        'Button55.Enabled = False
        'Dim dsOrd As New DataSet
        'Dim dsGen As New DataSet
        'Dim cmd As New SqlCommand("select * from ord_file", cnn)
        'Dim da As New SqlDataAdapter(cmd)
        'Dim ro, rg As DataRow
        'Dim sql As String
        'Dim ShipTax As Double
        'Dim cnt As Long = 0

        'Try
        '    cnn.Open()
        '    da.Fill(dsOrd)

        '    For Each ro In dsOrd.Tables(0).Rows
        '        'cmd.CommandText = "select * from ord_gen where ord_gen_ord_serial=" + CStr(ro("ord_serial"))
        '        'da.Fill(dsGen)
        '        'cmd.CommandText = "select tax_ship_percent from tax_state where tax_state='" + nz(ro("ord_ship_state")) + "'"
        '        'ShipTax = nz(cmd.ExecuteScalar, 0)

        '        sql = "update ord_gen set "
        '        sql += "ord_gen_ship_cust_id='" + Replace(nz(ro("ord_ship_cust_id")), "'", "''") + "',"
        '        sql += "ord_gen_ship_name='" + Replace(nz(ro("ord_ship_name")), "'", "''") + "',"
        '        sql += "ord_gen_ship_company='" + Replace(nz(ro("ord_ship_company")), "'", "''") + "',"
        '        sql += "ord_gen_ship_country='" + Replace(nz(ro("ord_ship_country")), "'", "''") + "',"
        '        sql += "ord_gen_ship_addr1='" + Replace(nz(ro("ord_ship_addr1")), "'", "''") + "',"
        '        sql += "ord_gen_ship_addr2='" + Replace(nz(ro("ord_ship_addr2")), "'", "''") + "',"
        '        sql += "ord_gen_ship_addr3='" + Replace(nz(ro("ord_ship_addr3")), "'", "''") + "',"
        '        sql += "ord_gen_ship_city='" + Replace(nz(ro("ord_ship_city")), "'", "''") + "',"
        '        sql += "ord_gen_ship_state='" + Replace(nz(ro("ord_ship_state")), "'", "''") + "',"
        '        sql += "ord_gen_ship_province='" + Replace(nz(ro("ord_ship_province")), "'", "''") + "',"
        '        sql += "ord_gen_ship_zip='" + Replace(nz(ro("ord_ship_zip")), "'", "''") + "',"
        '        sql += "ord_gen_ship_phone1='" + Replace(nz(ro("ord_ship_phone1")), "'", "''") + "',"
        '        sql += "ord_gen_ship_phone2='" + Replace(nz(ro("ord_ship_phone2")), "'", "''") + "',"
        '        sql += "ord_gen_ship_cell='" + Replace(nz(ro("ord_ship_cell")), "'", "''") + "',"
        '        sql += "ord_gen_ship_fax='" + Replace(nz(ro("ord_ship_fax")), "'", "''") + "',"
        '        sql += "ord_gen_ship_email='" + Replace(nz(ro("ord_ship_email")), "'", "''") + "',"
        '        sql += "ord_gen_ship_county='" + Replace(nz(ro("ord_ship_county")), "'", "''") + "',"
        '        sql += "ord_gen_ship_hold=0,"
        '        sql += "ord_gen_tax_ship_perc=" + CStr(ShipTax) + ","
        '        sql += "ord_gen_cust_taxrate=" + CStr(nz(ro("ord_cust_taxrate"), 0)) + ","
        '        sql += "ord_gen_tax_exempt=" + IIf(nz(ro("ord_tax_exempt"), False), "1", "0") + ","
        '        sql += "ord_gen_tax_exempt_no='" + Replace(nz(ro("ord_tax_exempt_no")), "'", "''") + "',"
        '        sql += "ord_gen_tax_installs=" + IIf(nz(ro("ord_tax_installs"), False), "1", "0") + ""
        '        sql += " where ord_gen_ord_serial=" + CStr(ro("ord_serial"))

        '        cmd.CommandText = sql
        '        cmd.ExecuteNonQuery()

        '        Bar1.Value = cnt / dsOrd.Tables(0).Rows.Count * 100
        '        cnt += 1
        '        Application.DoEvents()
        '    Next

        '    cmd.CommandText = "UPDATE ord_gen SET ord_gen_tax_ship_perc = (SELECT tax_ship_percent FROM tax_state WHERE (tax_state = ord_gen.ord_gen_ship_state) and tax_ship_start <= ord_gen_create_date and tax_ship_end >= ord_gen_create_date)"
        '    cmd.ExecuteNonQuery()

        '    cmd.CommandText = "update ord_gen set ord_gen_cust_taxrate=ord_gen_alt_taxrate, ord_gen_tax_installs=ord_gen_alt_taxinstalls where ord_gen_alt_ship=1"
        '    cmd.ExecuteNonQuery()

        'Catch ex As Exception
        '    MsgBox(sql + vbCrLf + vbCrLf + Err.Description)
        'Finally
        '    cnn.Close()
        '    Button55.Enabled = True
        'End Try

        Button55.Enabled = False
        Dim dsOrd As New DataSet
        Dim dsGen As New DataSet
        Dim cmd As New SqlCommand("select * from ord_gen where ord_gen_tax_exempt=1", cnn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ro, rg As DataRow
        Dim sql As String
        Dim ShipTax As Double
        Dim cnt As Long = 0
        Dim ShipCountry, TaxAddr As String

        Try
            cnn.Open()
            da.Fill(dsOrd)

            For Each ro In dsOrd.Tables(0).Rows

                ShipCountry = ro("ord_gen_ship_country")

                If nz(ro("ord_gen_tax_exempt_no")) = "" Then
                    If ShipCountry = "USA" Then
                        TaxAddr = "Not on File"
                    Else
                        TaxAddr = "International"
                    End If
                Else
                    If ShipCountry = "USA" Then
                        cmd.CommandText = "select * from tax_cert where tax_cert_no='" + Replace(ro("ord_gen_tax_exempt_no"), "'", "''") + "'"
                        Dim dr As SqlDataReader
                        dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            dr.Read()
                            TaxAddr = nz(dr("tax_cust_name")) + vbCrLf + nz(dr("tax_cert_addr")) + vbCrLf + nz(dr("tax_cert_city")) + ", " + nz(dr("tax_cert_state")) + "  " + nz(dr("tax_cert_zip"))
                        Else
                            TaxAddr = "Not on File"
                        End If
                        dr.Close()
                    Else
                        TaxAddr = "International"
                    End If
                End If


                sql = "update ord_gen set ord_gen_tax_exempt_addr='" + Replace(TaxAddr, "'", "''") + "' where ord_gen_serial=" + CStr(ro("ord_gen_serial"))

                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

                Bar1.Value = cnt / dsOrd.Tables(0).Rows.Count * 100
                cnt += 1
                Application.DoEvents()
            Next

        Catch ex As Exception
            MsgBox(sql + vbCrLf + vbCrLf + Err.Description)
        Finally
            cnn.Close()
            Button55.Enabled = True
        End Try
    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click
        Dim cmd As New SqlCommand("", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dr, dr2 As DataRow
        Dim fm As fmEstOrd2
        Dim x As Integer

        Button56.Enabled = False
        'fm = LoadForm("Quotes/Orders")

        'cmd.CommandText = "SELECT ord_itm.* FROM ord_itm INNER JOIN ord_gen ON ord_itm.ord_itm_ord_serial = ord_gen.ord_gen_ord_serial AND ord_itm.ord_itm_rev = ord_gen.ord_gen_rev AND ord_itm.ord_itm_type = ord_gen.ord_gen_type WHERE (ord_gen.ord_gen_create_date >= CONVERT(DATETIME, '2008-05-01 00:00:00', 102)) AND ((ord_itm.ord_itm_item_code LIKE 'classic%') or (ord_itm.ord_itm_item_code LIKE 'fresco%')) AND (ord_itm.ord_itm_type = 'Q') AND (ord_gen.ord_gen_create_date <= CONVERT(DATETIME, '2008-07-01 00:00:00', 102))"
        cmd.CommandText = "SELECT distinct ord_gen_serial FROM ord_itm INNER JOIN ord_gen ON ord_itm.ord_itm_ord_serial = ord_gen.ord_gen_ord_serial AND ord_itm.ord_itm_rev = ord_gen.ord_gen_rev AND ord_itm.ord_itm_type = ord_gen.ord_gen_type WHERE (ord_gen.ord_gen_create_date >= CONVERT(DATETIME, '2008-05-01 00:00:00', 102)) AND ((ord_itm.ord_itm_item_code LIKE 'classic%') or (ord_itm.ord_itm_item_code LIKE 'fresco%')) AND (ord_itm.ord_itm_type = 'Q') AND (ord_gen.ord_gen_create_date <= CONVERT(DATETIME, '2008-07-01 00:00:00', 102))"
        cnn.Open()
        da.Fill(ds)
        For Each dr In ds.Tables(0).Rows
            'fm.KeyValue1 = dr("ord_itm_ord_serial")
            'fm.tOrd.Text = dr("ord_itm_ord_serial")
            'fm.LoadPage()
            'fm.Edit()
            'fm.Tab1.Tabs("Q" + CStr(dr("ord_itm_rev"))).Selected = True
            'For x = 0 To fm.DVItems.Count
            '    dr2 = fm.DVItems(x).Row
            '    If dr("ord_itm_serial") = dr2("ord_itm_serial") Then Exit For
            'Next
            'fm.LoadPriceByRow(dr2)
            'fm.DoTotal()
            'fm.Save()
            cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date) values (" + CStr(dr("ord_gen_serial")) + ",'CLASSIC and FRESCOS have been updated to the current price.  The summer special has ended.','SYSTEM','8/2/2008')"
            cmd.ExecuteNonQuery()
        Next
        cnn.Close()
        'fm.Close()
        Button56.Enabled = True
    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click
        Dim cmd As New SqlCommand("", cnn)
        cmd.CommandTimeout = 999

        cmd.CommandText = "UPDATE    ord_itm set ord_itm_fixture = 1 WHERE (ord_itm_serial IN (SELECT     ord_itm_1.ord_itm_serial FROM ord_itm AS ord_itm_1 INNER JOIN itm_file ON ord_itm_1.ord_itm_item_code = itm_file.itm_code  WHERE (itm_file.itm_fixture = 1)))"
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()

        Exit Sub
        LoadCostAnalysis_CPSeries(CDate("1/1/2010"), CDate("3/31/2010"))
    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button58.Click
        Dim cmd As New SqlCommand("select distinct zip_code from zip_file where zip_lat=0", cnn)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow
        Dim ll As New LatLong
        Dim cnt As Integer = 0

        Dim fl As New IO.StreamReader("c:\temp\zip.txt")
        Dim ln As String
        Dim onZip As String

        Button58.Enabled = False
        cnn.Open()

        ln = fl.ReadLine
        Do While ln <> ""
            onZip = Mid(ln, 3, 5)
            cmd.CommandText = "update zip_file set zip_lat=" + Mid(ln, 137, 10) + ", zip_long=" + Mid(ln, 147, 11) + " where zip_code='" + onZip + "'"
            cmd.ExecuteNonQuery()

            ln = fl.ReadLine
        Loop

        'da.Fill(dt)
        'For Each dr In dt.Rows
        '    ll = GetLatLong(dr("zip_code"))
        '    cmd.CommandText = "update zip_file set zip_lat=" + CStr(ll.Latitude) + ", zip_long=" + CStr(ll.Longitude) + " where zip_code='" + dr("zip_code") + "'"
        '    cmd.ExecuteNonQuery()
        '    System.Threading.Thread.Sleep(700)
        '    Bar1.Value = cnt / dt.Rows.Count * 100
        '    cnt = cnt + 1
        'Next
        cnn.Close()
        Button58.Enabled = True
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        Dim fb As New OpenFileDialog
        fb.Filter = "Text Files (*.xls)|*.xls"
        If fb.ShowDialog = DialogResult.OK Then
            Dim ex As New Microsoft.Office.Interop.Excel.Application
            Dim fl As Microsoft.Office.Interop.Excel.Workbook
            Dim sh As Microsoft.Office.Interop.Excel.Worksheet
            Dim rg As Microsoft.Office.Interop.Excel.Range
            Dim rw As Integer
            Dim ord, dt As String
            Dim cmd As New SqlCommand("", cnn)

            Dim ln As String
            Dim x As Integer = 0

            cnn.Open()
            fl = ex.Workbooks.Open(fb.FileName)
            sh = fl.Sheets(3)
            For rw = 1 To sh.UsedRange.Rows.Count
                'lExcel.Text = "Reading Excel Line: " + CStr(rw) + " of " + CStr(sh.UsedRange.Rows.Count)
                'Application.DoEvents()

                'x = 1

                'Dim dr As DataRow = ds.Tables(0).NewRow
                rg = sh.Cells(rw, 2)
                ord = rg.Value

                rg = sh.Cells(rw, 14)
                dt = rg.Value

                If InStr(ord, "-") > 0 And IsDate(dt) Then
                    cmd.CommandText = "insert into tmp (tmp_ord_serial,tmp_ord_rev,tmp_ord_type,tmp_date) values (" + Split(ord, "-")(0) + "," + Split(ord, "-")(2) + ",'O','" + CStr(dt) + "')"
                    cmd.ExecuteNonQuery()
                End If
            Next
            cnn.Close()
            ex.Workbooks.Close()
            ex = Nothing
        End If
    End Sub

    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button60.Click
        Dim cmd As New SqlCommand("", cnn)
        Dim onProdSerial As Long
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        Dim row As DataRow

        cnn.Open()
        cmd.CommandText = "select * from ord_gen where ord_gen_signoff_old=1"
        da.Fill(dt)

        For Each row In dt.Rows
            cmd.CommandText = "select max(ord_prod_serial) from ord_prod where ord_prod_ord_serial=" + CStr(row("ord_gen_ord_serial")) + " and ord_prod_rev=" + CStr(row("ord_gen_rev")) + " and ord_prod_type='" + row("ord_gen_type") + "'"
            onProdSerial = nz(cmd.ExecuteScalar, 0)

            If onProdSerial = 0 Then
                cmd.CommandText = "insert into ord_prod (ord_prod_ord_serial,ord_prod_rev,ord_prod_type,ord_prod_signoffrec,ord_prod_signoffrec_date,ord_prod_signoffrec_by,ord_prod_signoffrec_note,ord_prod_date,ord_prod_who) values (" + CStr(row("ord_gen_ord_serial")) + "," + CStr(row("ord_gen_rev")) + ",'" + row("ord_gen_type") + "',1,'" + row("ord_gen_signoff_date") + "','" + row("ord_gen_signoff_user") + "','" + Replace(nz(row("ord_gen_signoff_note")), "'", "''") + "',getdate(),'System')"
                cmd.ExecuteNonQuery()
            Else
                cmd.CommandText = "update ord_prod set ord_prod_signoffrec=1,ord_prod_signoffrec_date='" + row("ord_gen_signoff_date") + "',ord_prod_signoffrec_by='" + row("ord_gen_signoff_user") + "',ord_prod_signoffrec_note='" + Replace(nz(row("ord_gen_signoff_note")), "'", "''") + "' where ord_prod_serial=" + CStr(onProdSerial)
                cmd.ExecuteNonQuery()
            End If
        Next

        cmd.CommandText = "select * from ord_gen where ord_gen_allclear=1"
        dt.Clear()
        da.Fill(dt)

        For Each row In dt.Rows
            cmd.CommandText = "select max(ord_prod_serial) from ord_prod where ord_prod_ord_serial=" + CStr(row("ord_gen_ord_serial")) + " and ord_prod_rev=" + CStr(row("ord_gen_rev")) + " and ord_prod_type='" + row("ord_gen_type") + "'"
            onProdSerial = nz(cmd.ExecuteScalar, 0)

            If onProdSerial = 0 Then
                cmd.CommandText = "insert into ord_prod (ord_prod_ord_serial,ord_prod_rev,ord_prod_type,ord_prod_allclear,ord_prod_allclear_date,ord_prod_allclear_by,ord_prod_allclear_note,ord_prod_date,ord_prod_who) values (" + CStr(row("ord_gen_ord_serial")) + "," + CStr(row("ord_gen_rev")) + ",'" + row("ord_gen_type") + "',1,'" + row("ord_gen_allclear_date") + "','" + row("ord_gen_allclear_user") + "','',getdate(),'System')"
                cmd.ExecuteNonQuery()
            Else
                cmd.CommandText = "update ord_prod set ord_prod_allclear=1,ord_prod_allclear_date='" + row("ord_gen_signoff_date") + "',ord_prod_allclear_by='" + row("ord_gen_signoff_user") + "',ord_prod_allclear_note='' where ord_prod_serial=" + CStr(onProdSerial)
                cmd.ExecuteNonQuery()
            End If
        Next

        cmd.CommandText = "select * from ord_gen where ord_gen_writeup=1"
        dt.Clear()
        da.Fill(dt)

        For Each row In dt.Rows
            cmd.CommandText = "select max(ord_prod_serial) from ord_prod where ord_prod_ord_serial=" + CStr(row("ord_gen_ord_serial")) + " and ord_prod_rev=" + CStr(row("ord_gen_rev")) + " and ord_prod_type='" + row("ord_gen_type") + "'"
            onProdSerial = nz(cmd.ExecuteScalar, 0)

            If onProdSerial = 0 Then
                cmd.CommandText = "insert into ord_prod (ord_prod_ord_serial,ord_prod_rev,ord_prod_type,ord_prod_tofactory,ord_prod_tofactory_date,ord_prod_tofactory_by,ord_prod_tofactory_note,ord_prod_date,ord_prod_who) values (" + CStr(row("ord_gen_ord_serial")) + "," + CStr(row("ord_gen_rev")) + ",'" + row("ord_gen_type") + "',1,'" + row("ord_gen_writeup_date") + "','" + row("ord_gen_writeup_user") + "','',getdate(),'System')"
                cmd.ExecuteNonQuery()
            Else
                cmd.CommandText = "update ord_prod set ord_prod_tofactory=1,ord_prod_tofactory_date='" + row("ord_gen_writeup_date") + "',ord_prod_tofactory_by='" + row("ord_gen_writeup_user") + "',ord_prod_tofactory_note='' where ord_prod_serial=" + CStr(onProdSerial)
                cmd.ExecuteNonQuery()
            End If
        Next

        cnn.Close()
    End Sub

    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click
        Dim cmd As New SqlCommand("", cnn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow
        Dim dt As New DataTable

        cmd.CommandText = "select ord_gen_ord_serial,ord_gen_rev,ord_gen_type,ord_gen_ship_date from ord_gen where ord_gen_type<>'Q' and ord_gen_status='SHIPPED' and ord_gen_ship_date>='1/1/2010' and (select count(*) from ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_itm_item_code like 'WZ%')>0"
        da.Fill(dt)
        cnn.Open()
        For Each dr In dt.Rows
            cmd.CommandText = "insert into diag_file (diag_ord_serial,diag_rev,diag_type,diag_email,diag_status,diag_next_send,diag_sent_date,diag_created) values (" + CStr(dr("ord_gen_ord_serial")) + "," + CStr(dr("ord_gen_rev")) + ",'" + dr("ord_gen_type") + "','Sent Manually','SENT','12/31/2099','" + CStr(dr("ord_gen_ship_date")) + "',getdate())"
            cmd.ExecuteNonQuery()
        Next
        cnn.Close()
    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click
        Dim cmd As New SqlCommand("", cnn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim ln, itm, name As String
        Button62.Enabled = False
        Try
            cmd.CommandText = "select * from ref_box_import where complete is null"
            da.Fill(dt)
            cnn.Open()
            Dim mult = False
            For Each dr In dt.Rows
                cmd.CommandText = "select itm_box_itm_code from itm_box where itm_box_itm_code='" + dr("itemcode").ToString + "'"
                Dim zz = nz(cmd.ExecuteScalar, -1)
                If zz = -1 Then
                    If nz(dr("box1length5"), -1) <> -1 Then
                        cmd.CommandText = "insert into itm_box (itm_box_itm_code,itm_box_len,itm_box_width,itm_box_height,itm_box_weight,itm_box_name) values ('" + dr("itemcode") + "'," + dr("box1length5").ToString + "," + dr("box1width5").ToString + "," + dr("box1depth5").ToString + "," + dr("box1weight5").ToString + ",'" + dr("itemcode").ToString + " #5" + "')"
                        cmd.ExecuteNonQuery()
                    End If
                    If nz(dr("box1length4"), -1) <> -1 Then
                        cmd.CommandText = "insert into itm_box (itm_box_itm_code,itm_box_len,itm_box_width,itm_box_height,itm_box_weight,itm_box_name) values ('" + dr("itemcode") + "'," + dr("box1length4").ToString + "," + dr("box1width4").ToString + "," + dr("box1depth4").ToString + "," + dr("box1weight4").ToString + ",'" + dr("itemcode").ToString + " #4" + "')"
                        cmd.ExecuteNonQuery()
                    End If
                    If nz(dr("box1length3"), -1) <> -1 Then
                        cmd.CommandText = "insert into itm_box (itm_box_itm_code,itm_box_len,itm_box_width,itm_box_height,itm_box_weight,itm_box_name) values ('" + dr("itemcode") + "'," + dr("box1length3").ToString + "," + dr("box1width3").ToString + "," + dr("box1depth3").ToString + "," + dr("box1weight3").ToString + ",'" + dr("itemcode").ToString + " #3" + "')"
                        cmd.ExecuteNonQuery()
                    End If
                    If nz(dr("box1length2"), -1) <> -1 Then
                        cmd.CommandText = "insert into itm_box (itm_box_itm_code,itm_box_len,itm_box_width,itm_box_height,itm_box_weight,itm_box_name) values ('" + dr("itemcode") + "'," + dr("box1length2").ToString + "," + dr("box1width2").ToString + "," + dr("box1depth2").ToString + "," + dr("box1weight2").ToString + ",'" + dr("itemcode").ToString + " #2" + "')"
                        cmd.ExecuteNonQuery()
                        mult = True
                    End If
                    If nz(dr("box1length1"), -1) <> -1 Then
                        If mult = True Then
                            cmd.CommandText = "insert into itm_box (itm_box_itm_code,itm_box_len,itm_box_width,itm_box_height,itm_box_weight,itm_box_name) values ('" + dr("itemcode") + "'," + dr("box1length1").ToString + "," + dr("box1width1").ToString + "," + dr("box1depth1").ToString + "," + dr("box1weight1").ToString + ",'" + dr("itemcode").ToString + " #1" + "')"
                            cmd.ExecuteNonQuery()
                        Else
                            cmd.CommandText = "insert into itm_box (itm_box_itm_code,itm_box_len,itm_box_width,itm_box_height,itm_box_weight,itm_box_name) values ('" + dr("itemcode") + "'," + dr("box1length1").ToString + "," + dr("box1width1").ToString + "," + dr("box1depth1").ToString + "," + dr("box1weight1").ToString + ",'" + dr("itemcode").ToString + "')"
                            cmd.ExecuteNonQuery()
                        End If
                    End If
                    cmd.CommandText = "update ref_box_import set complete =1 where itemcode='" + dr("itemcode") + "'"
                    cmd.ExecuteNonQuery()
                    mult = False
                Else

                End If
            Next
        Catch
            MsgBox(Err.Description)
        Finally
            cnn.Close()
            Button62.Enabled = True
        End Try
    End Sub
End Class
