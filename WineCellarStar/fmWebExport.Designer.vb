﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmWebExport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tItems = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cbShip = New System.Windows.Forms.CheckBox
        Me.cbMSRP = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.rbcust = New System.Windows.Forms.RadioButton
        Me.tPricePerc3 = New System.Windows.Forms.TextBox
        Me.pr02 = New System.Windows.Forms.RadioButton
        Me.MSRP1 = New System.Windows.Forms.RadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.tPricePerc2 = New System.Windows.Forms.TextBox
        Me.prDBSH2 = New System.Windows.Forms.RadioButton
        Me.prDBSH = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.tPricePerc = New System.Windows.Forms.TextBox
        Me.prPerc = New System.Windows.Forms.RadioButton
        Me.pr0 = New System.Windows.Forms.RadioButton
        Me.prDB = New System.Windows.Forms.RadioButton
        Me.pr01 = New System.Windows.Forms.RadioButton
        Me.cbDesc = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.bStart = New System.Windows.Forms.Button
        Me.bPrices = New System.Windows.Forms.ProgressBar
        Me.bClear = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rbShipData = New System.Windows.Forms.RadioButton
        Me.rbShip0 = New System.Windows.Forms.RadioButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rbLIVE = New System.Windows.Forms.RadioButton
        Me.rbNEXT = New System.Windows.Forms.RadioButton
        Me.btnExportNEW = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tItems
        '
        Me.tItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tItems.DetectUrls = False
        Me.tItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tItems.Location = New System.Drawing.Point(11, 74)
        Me.tItems.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tItems.Name = "tItems"
        Me.tItems.Size = New System.Drawing.Size(431, 747)
        Me.tItems.TabIndex = 0
        Me.tItems.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1) Load list with part number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Paste part numbers or click "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(228, 36)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Parts Needing Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(465, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "2) Set your parameters"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbShip)
        Me.Panel1.Controls.Add(Me.cbMSRP)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.rbcust)
        Me.Panel1.Controls.Add(Me.tPricePerc3)
        Me.Panel1.Controls.Add(Me.pr02)
        Me.Panel1.Controls.Add(Me.MSRP1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tPricePerc2)
        Me.Panel1.Controls.Add(Me.prDBSH2)
        Me.Panel1.Controls.Add(Me.prDBSH)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tPricePerc)
        Me.Panel1.Controls.Add(Me.prPerc)
        Me.Panel1.Controls.Add(Me.pr0)
        Me.Panel1.Controls.Add(Me.prDB)
        Me.Panel1.Location = New System.Drawing.Point(459, 74)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 446)
        Me.Panel1.TabIndex = 5
        '
        'cbShip
        '
        Me.cbShip.AutoSize = True
        Me.cbShip.Location = New System.Drawing.Point(231, 404)
        Me.cbShip.Margin = New System.Windows.Forms.Padding(4)
        Me.cbShip.Name = "cbShip"
        Me.cbShip.Size = New System.Drawing.Size(178, 21)
        Me.cbShip.TabIndex = 25
        Me.cbShip.Text = "Bypass Shipping pricing"
        Me.cbShip.UseVisualStyleBackColor = True
        '
        'cbMSRP
        '
        Me.cbMSRP.AutoSize = True
        Me.cbMSRP.Location = New System.Drawing.Point(52, 404)
        Me.cbMSRP.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMSRP.Name = "cbMSRP"
        Me.cbMSRP.Size = New System.Drawing.Size(162, 21)
        Me.cbMSRP.TabIndex = 24
        Me.cbMSRP.Text = "Bypass MSRP pricing"
        Me.cbMSRP.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(33, 382)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(236, 18)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Format = Parent SKU | Price Amnt"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(268, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "(example .85 = 15% off)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(7, 283)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 18)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "For Parent SKU's ONLY"
        '
        'rbcust
        '
        Me.rbcust.AutoSize = True
        Me.rbcust.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcust.Location = New System.Drawing.Point(7, 359)
        Me.rbcust.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbcust.Name = "rbcust"
        Me.rbcust.Size = New System.Drawing.Size(367, 22)
        Me.rbcust.TabIndex = 22
        Me.rbcust.Text = "Set Price - Custom   (MSRP and Shipping set to $0)"
        Me.rbcust.UseVisualStyleBackColor = True
        '
        'tPricePerc3
        '
        Me.tPricePerc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPricePerc3.Location = New System.Drawing.Point(343, 208)
        Me.tPricePerc3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tPricePerc3.Name = "tPricePerc3"
        Me.tPricePerc3.Size = New System.Drawing.Size(63, 24)
        Me.tPricePerc3.TabIndex = 17
        '
        'pr02
        '
        Me.pr02.AutoSize = True
        Me.pr02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pr02.Location = New System.Drawing.Point(7, 308)
        Me.pr02.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pr02.Name = "pr02"
        Me.pr02.Size = New System.Drawing.Size(317, 22)
        Me.pr02.TabIndex = 19
        Me.pr02.Text = "Set Shipping  (Price and MSRP not updated)"
        Me.pr02.UseVisualStyleBackColor = True
        '
        'MSRP1
        '
        Me.MSRP1.AutoSize = True
        Me.MSRP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSRP1.Location = New System.Drawing.Point(5, 209)
        Me.MSRP1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MSRP1.Name = "MSRP1"
        Me.MSRP1.Size = New System.Drawing.Size(301, 22)
        Me.MSRP1.TabIndex = 16
        Me.MSRP1.Text = "MSRP=Price + Ship; Sale Price=MSRP X"
        Me.MSRP1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(33, 330)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(258, 18)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Format = Parent SKU | Shipping Amnt"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(344, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "+ shipping"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(212, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "(example .85 = 15% off)"
        '
        'tPricePerc2
        '
        Me.tPricePerc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPricePerc2.Location = New System.Drawing.Point(272, 156)
        Me.tPricePerc2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tPricePerc2.Name = "tPricePerc2"
        Me.tPricePerc2.Size = New System.Drawing.Size(63, 24)
        Me.tPricePerc2.TabIndex = 8
        '
        'prDBSH2
        '
        Me.prDBSH2.AutoSize = True
        Me.prDBSH2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prDBSH2.Location = New System.Drawing.Point(5, 158)
        Me.prDBSH2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.prDBSH2.Name = "prDBSH2"
        Me.prDBSH2.Size = New System.Drawing.Size(236, 22)
        Me.prDBSH2.TabIndex = 7
        Me.prDBSH2.Text = "Get Price from Database then X"
        Me.prDBSH2.UseVisualStyleBackColor = True
        '
        'prDBSH
        '
        Me.prDBSH.AutoSize = True
        Me.prDBSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prDBSH.Location = New System.Drawing.Point(5, 116)
        Me.prDBSH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.prDBSH.Name = "prDBSH"
        Me.prDBSH.Size = New System.Drawing.Size(263, 22)
        Me.prDBSH.TabIndex = 5
        Me.prDBSH.Text = "Get Price from Database + Shipping"
        Me.prDBSH.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "(example .85 = 15% off)"
        '
        'tPricePerc
        '
        Me.tPricePerc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPricePerc.Location = New System.Drawing.Point(159, 70)
        Me.tPricePerc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tPricePerc.Name = "tPricePerc"
        Me.tPricePerc.Size = New System.Drawing.Size(63, 24)
        Me.tPricePerc.TabIndex = 3
        '
        'prPerc
        '
        Me.prPerc.AutoSize = True
        Me.prPerc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prPerc.Location = New System.Drawing.Point(5, 73)
        Me.prPerc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.prPerc.Name = "prPerc"
        Me.prPerc.Size = New System.Drawing.Size(138, 22)
        Me.prPerc.TabIndex = 2
        Me.prPerc.Text = "Get Price then X "
        Me.prPerc.UseVisualStyleBackColor = True
        '
        'pr0
        '
        Me.pr0.AutoSize = True
        Me.pr0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pr0.Location = New System.Drawing.Point(5, 36)
        Me.pr0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pr0.Name = "pr0"
        Me.pr0.Size = New System.Drawing.Size(105, 22)
        Me.pr0.TabIndex = 1
        Me.pr0.Text = "Set to $0.00"
        Me.pr0.UseVisualStyleBackColor = True
        '
        'prDB
        '
        Me.prDB.AutoSize = True
        Me.prDB.Checked = True
        Me.prDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prDB.Location = New System.Drawing.Point(5, 4)
        Me.prDB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.prDB.Name = "prDB"
        Me.prDB.Size = New System.Drawing.Size(190, 22)
        Me.prDB.TabIndex = 0
        Me.prDB.TabStop = True
        Me.prDB.Text = "Get Price from Database"
        Me.prDB.UseVisualStyleBackColor = True
        '
        'pr01
        '
        Me.pr01.AutoSize = True
        Me.pr01.Location = New System.Drawing.Point(515, 526)
        Me.pr01.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pr01.Name = "pr01"
        Me.pr01.Size = New System.Drawing.Size(139, 21)
        Me.pr01.TabIndex = 6
        Me.pr01.Text = "Set Price to $0.01"
        Me.pr01.UseVisualStyleBackColor = True
        Me.pr01.Visible = False
        '
        'cbDesc
        '
        Me.cbDesc.AutoSize = True
        Me.cbDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDesc.Location = New System.Drawing.Point(465, 645)
        Me.cbDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbDesc.Name = "cbDesc"
        Me.cbDesc.Size = New System.Drawing.Size(226, 22)
        Me.cbDesc.TabIndex = 6
        Me.cbDesc.Text = "Pull description from database"
        Me.cbDesc.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(941, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "3) Run the export"
        '
        'bStart
        '
        Me.bStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bStart.Location = New System.Drawing.Point(947, 78)
        Me.bStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bStart.Name = "bStart"
        Me.bStart.Size = New System.Drawing.Size(248, 38)
        Me.bStart.TabIndex = 8
        Me.bStart.Text = "Start Exporting to OLD website"
        Me.bStart.UseVisualStyleBackColor = True
        '
        'bPrices
        '
        Me.bPrices.Location = New System.Drawing.Point(947, 134)
        Me.bPrices.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bPrices.Name = "bPrices"
        Me.bPrices.Size = New System.Drawing.Size(248, 21)
        Me.bPrices.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.bPrices.TabIndex = 9
        '
        'bClear
        '
        Me.bClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClear.Location = New System.Drawing.Point(449, 778)
        Me.bClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(163, 37)
        Me.bClear.TabIndex = 10
        Me.bClear.Text = "Clear List"
        Me.bClear.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(947, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Exporting Items"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.rbShipData)
        Me.Panel2.Controls.Add(Me.rbShip0)
        Me.Panel2.Location = New System.Drawing.Point(459, 564)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(455, 61)
        Me.Panel2.TabIndex = 14
        '
        'rbShipData
        '
        Me.rbShipData.AutoSize = True
        Me.rbShipData.Checked = True
        Me.rbShipData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbShipData.Location = New System.Drawing.Point(4, 32)
        Me.rbShipData.Margin = New System.Windows.Forms.Padding(4)
        Me.rbShipData.Name = "rbShipData"
        Me.rbShipData.Size = New System.Drawing.Size(171, 22)
        Me.rbShipData.TabIndex = 1
        Me.rbShipData.TabStop = True
        Me.rbShipData.Text = "Update Shipping Price"
        Me.rbShipData.UseVisualStyleBackColor = True
        '
        'rbShip0
        '
        Me.rbShip0.AutoSize = True
        Me.rbShip0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbShip0.Location = New System.Drawing.Point(4, 4)
        Me.rbShip0.Margin = New System.Windows.Forms.Padding(4)
        Me.rbShip0.Name = "rbShip0"
        Me.rbShip0.Size = New System.Drawing.Size(165, 22)
        Me.rbShip0.TabIndex = 0
        Me.rbShip0.Text = "Set Shipping to $0.00"
        Me.rbShip0.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(952, 662)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(295, 48)
        Me.DataGridView1.TabIndex = 15
        Me.DataGridView1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(921, 746)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 32)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Load Grid"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1083, 731)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "3) Load Grid to Review"
        Me.Label9.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.DateTimePicker3)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Location = New System.Drawing.Point(1159, 315)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(319, 184)
        Me.Panel4.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkRed
        Me.Label16.Location = New System.Drawing.Point(12, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(287, 48)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Select date and modify time for Next posting."
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(16, 64)
        Me.DateTimePicker3.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(132, 22)
        Me.DateTimePicker3.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 17)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Next Post Date-Time"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(17, 117)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 24)
        Me.TextBox1.TabIndex = 26
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.rbLIVE)
        Me.Panel3.Controls.Add(Me.rbNEXT)
        Me.Panel3.Location = New System.Drawing.Point(1159, 270)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(319, 38)
        Me.Panel3.TabIndex = 31
        '
        'rbLIVE
        '
        Me.rbLIVE.AutoSize = True
        Me.rbLIVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLIVE.Location = New System.Drawing.Point(175, 4)
        Me.rbLIVE.Margin = New System.Windows.Forms.Padding(4)
        Me.rbLIVE.Name = "rbLIVE"
        Me.rbLIVE.Size = New System.Drawing.Size(107, 22)
        Me.rbLIVE.TabIndex = 1
        Me.rbLIVE.Text = "Update LIVE"
        Me.rbLIVE.UseVisualStyleBackColor = True
        '
        'rbNEXT
        '
        Me.rbNEXT.AutoSize = True
        Me.rbNEXT.Checked = True
        Me.rbNEXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNEXT.Location = New System.Drawing.Point(16, 4)
        Me.rbNEXT.Margin = New System.Windows.Forms.Padding(4)
        Me.rbNEXT.Name = "rbNEXT"
        Me.rbNEXT.Size = New System.Drawing.Size(117, 22)
        Me.rbNEXT.TabIndex = 0
        Me.rbNEXT.TabStop = True
        Me.rbNEXT.Text = "Update NEXT"
        Me.rbNEXT.UseVisualStyleBackColor = True
        '
        'btnExportNEW
        '
        Me.btnExportNEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportNEW.Location = New System.Drawing.Point(1159, 225)
        Me.btnExportNEW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExportNEW.Name = "btnExportNEW"
        Me.btnExportNEW.Size = New System.Drawing.Size(320, 38)
        Me.btnExportNEW.TabIndex = 30
        Me.btnExportNEW.Text = "Start Exporting to NEW Website"
        Me.btnExportNEW.UseVisualStyleBackColor = True
        '
        'fmWebExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1505, 828)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnExportNEW)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bClear)
        Me.Controls.Add(Me.bPrices)
        Me.Controls.Add(Me.bStart)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pr01)
        Me.Controls.Add(Me.cbDesc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tItems)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "fmWebExport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "u"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tItems As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tPricePerc As System.Windows.Forms.TextBox
    Friend WithEvents prPerc As System.Windows.Forms.RadioButton
    Friend WithEvents pr0 As System.Windows.Forms.RadioButton
    Friend WithEvents prDB As System.Windows.Forms.RadioButton
    Friend WithEvents cbDesc As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bStart As System.Windows.Forms.Button
    Friend WithEvents bPrices As System.Windows.Forms.ProgressBar
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbShipData As System.Windows.Forms.RadioButton
    Friend WithEvents rbShip0 As System.Windows.Forms.RadioButton
    Friend WithEvents prDBSH As System.Windows.Forms.RadioButton
    Friend WithEvents pr01 As System.Windows.Forms.RadioButton
    Friend WithEvents tPricePerc2 As System.Windows.Forms.TextBox
    Friend WithEvents prDBSH2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tPricePerc3 As System.Windows.Forms.TextBox
    Friend WithEvents MSRP1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pr02 As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbcust As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbMSRP As System.Windows.Forms.CheckBox
    Friend WithEvents cbShip As System.Windows.Forms.CheckBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rbLIVE As System.Windows.Forms.RadioButton
    Friend WithEvents rbNEXT As System.Windows.Forms.RadioButton
    Friend WithEvents btnExportNEW As System.Windows.Forms.Button
End Class
