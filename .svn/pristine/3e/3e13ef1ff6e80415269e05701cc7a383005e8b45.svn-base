Imports System.Data.SqlClient
Public Class fmShipPick
    Inherits WineCellar.fmStarter
    Dim ShipTop As Integer = 3
    Dim LastTop As Integer = 3
    Dim ddShip As New ComboBox
    Dim ShipPrinterFedEx As String
    Dim dsBoxes As New DataSet
    Dim onShipment As Panel

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
    Friend WithEvents pShip As System.Windows.Forms.Panel
    Friend WithEvents pInfo As System.Windows.Forms.Panel
    Friend WithEvents bCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents gBoxes As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Weight")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Length")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Width")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Height")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracking")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Declared")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cost")
        Me.pShip = New System.Windows.Forms.Panel
        Me.pInfo = New System.Windows.Forms.Panel
        Me.gBoxes = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.bPrint = New Infragistics.Win.Misc.UltraButton
        Me.bCancel = New Infragistics.Win.Misc.UltraButton
        Me.pInfo.SuspendLayout()
        CType(Me.gBoxes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pShip
        '
        Me.pShip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pShip.Location = New System.Drawing.Point(8, 8)
        Me.pShip.Name = "pShip"
        Me.pShip.Size = New System.Drawing.Size(500, 680)
        Me.pShip.TabIndex = 0
        '
        'pInfo
        '
        Me.pInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pInfo.Controls.Add(Me.gBoxes)
        Me.pInfo.Controls.Add(Me.bPrint)
        Me.pInfo.Controls.Add(Me.bCancel)
        Me.pInfo.Location = New System.Drawing.Point(512, 8)
        Me.pInfo.Name = "pInfo"
        Me.pInfo.Size = New System.Drawing.Size(500, 680)
        Me.pInfo.TabIndex = 1
        Me.pInfo.Visible = False
        '
        'gBoxes
        '
        Me.gBoxes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.Khaki
        Me.gBoxes.DisplayLayout.Appearance = Appearance1
        Me.gBoxes.DisplayLayout.AutoFitColumns = True
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 81
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 133
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 82
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 85
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.Width = 84
        UltraGridColumn6.Header.Caption = "Declared $$$"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 78
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 83
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.gBoxes.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gBoxes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.gBoxes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True
        Me.gBoxes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        Me.gBoxes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gBoxes.Enabled = False
        Me.gBoxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gBoxes.Location = New System.Drawing.Point(8, 64)
        Me.gBoxes.Name = "gBoxes"
        Me.gBoxes.Size = New System.Drawing.Size(480, 552)
        Me.gBoxes.TabIndex = 95
        Me.gBoxes.Tag = "edit"
        Me.gBoxes.Text = "Boxes"
        '
        'bPrint
        '
        Me.bPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPrint.Location = New System.Drawing.Point(328, 624)
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Size = New System.Drawing.Size(160, 50)
        Me.bPrint.TabIndex = 1
        Me.bPrint.Text = "Print Label"
        '
        'bCancel
        '
        Me.bCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancel.Location = New System.Drawing.Point(344, 8)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(144, 50)
        Me.bCancel.TabIndex = 0
        Me.bCancel.Text = "Cancel"
        '
        'fmShipPick
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1032, 694)
        Me.Controls.Add(Me.pInfo)
        Me.Controls.Add(Me.pShip)
        Me.Name = "fmShipPick"
        Me.Text = "Ship Pick"
        Me.pInfo.ResumeLayout(False)
        CType(Me.gBoxes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmShipPick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShipPrinterFedEx = GetSetting("Jcom", "Shipping", "PrinterFedEx", "\\fedex\eltron")

    End Sub
    Private Sub LoadGrid()
        Dim cmd As New SqlCommand("SELECT DISTINCT ord_gen_serial,ord_gen.ord_gen_ord_serial, ord_gen.ord_gen_from_rev,ord_gen.ord_gen_rev, ord_gen.ord_gen_toship FROM ord_file LEFT OUTER JOIN ord_gen ON ord_file.ord_serial = ord_gen.ord_gen_ord_serial LEFT OUTER JOIN ord_itm ON ord_gen.ord_gen_ord_serial = ord_itm.ord_itm_ord_serial AND ord_gen.ord_gen_rev = ord_itm.ord_itm_rev AND ord_gen.ord_gen_type = ord_itm.ord_itm_type WHERE (ord_gen.ord_gen_type = 'O') AND (ord_gen.ord_gen_status <> 'SHIPPED') AND (ord_itm.ord_itm_prod_type = 'KIT') AND (ord_gen.ord_gen_status <> 'CANCELED') and ord_gen_balance=0 and ord_gen.ord_gen_toship>'1/1/1900' ORDER BY ord_gen.ord_gen_ord_serial, ord_gen.ord_gen_rev", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim rw As DataRow

        ShipTop = 3
        LastTop = 3
        pShip.Controls.Clear()
        cnn.Open()
        da.Fill(ds)
        cnn.Close()

        For Each rw In ds.Tables(0).Rows
            If nz(rw("ord_gen_toship"), CDate("12/31/2099")) <= Today And nz(rw("ord_gen_toship"), CDate("1/1/1900")) > CDate("1/1/1900") Then
                GetShipPanel(rw("ord_gen_serial"))
            End If
        Next
    End Sub
    Private Function GetShipPanel(ByVal OrdGenSerial As Long) As Panel
        Dim pCnt As Integer = 0
        Dim cmd As New SqlCommand("", cnn)
        Dim dr As SqlDataReader
        Dim iCnt As Integer
        Dim Ord As String
        Dim Name As String

        cnn.Open()
        cmd.CommandText = "select ord_gen_serial,ord_gen_ord_serial,ord_gen_from_rev,ord_gen_rev,ord_sold_company,ord_sold_name,ord_itm_item_code,ord_itm_desc,ord_itm_qty,ord_itm_prod_type,ord_gen_toshipvia,ord_gen_toship from ord_file,ord_gen,ord_itm where ord_serial=ord_gen_ord_serial and ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev=ord_itm_rev and ord_gen_type=ord_itm_type and ord_gen_serial=" + CStr(OrdGenSerial)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            iCnt = 1
            dr.Read()
            Ord = CStr(dr("ord_gen_ord_serial")) + "-" + CStr(dr("ord_gen_from_rev")) + "-" + CStr(dr("ord_gen_rev"))

            Dim pn As New Panel
            pn.Parent = pShip
            pn.Height = 45
            pn.Width = 472
            pn.Visible = True
            pn.Top = ShipTop
            pn.BackColor = Color.PaleGoldenrod
            pn.Name = "s" + CStr(OrdGenSerial)

            If nz(dr("ord_sold_company")) <> "" Then
                Name = dr("ord_sold_company")
            Else
                Name = nz(dr("ord_sold_name"))
            End If

            Dim lb As New Label
            lb.Parent = pn
            lb.Height = 20
            lb.Width = 100
            lb.Font = New Font(lb.Font, lb.Font.Style Or FontStyle.Bold)
            lb.Font = New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
            lb.Text = Ord
            lb.Cursor = Cursors.Hand
            AddHandler lb.Click, AddressOf OrderClick

            lb = New Label
            lb.Parent = pn
            lb.Height = 20
            lb.Width = 275
            lb.Left = 105
            'lb.Font = New Font(lb.Font, lb.Font.Style Or FontStyle.Bold)
            lb.Font = New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
            lb.Text = Name

            lb = New Label
            lb.Parent = pn
            lb.Height = 14
            lb.Width = 275
            lb.Left = 105
            lb.Top = 20
            'lb.Font = New Font(lb.Font, lb.Font.Style Or FontStyle.Bold)
            lb.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
            lb.Text = "Ship Via: " + nz(dr("ord_gen_toshipvia")) + " on " + CStr(nz(dr("ord_gen_toship"), "(Unknown)"))

            Do
                lb = New Label
                lb.Parent = pn
                lb.Height = 14
                lb.Width = 370
                lb.Top = (14 * iCnt) + 28
                lb.Text = "(" + CStr(nz(dr("ord_itm_qty"), 0)) + ") " + nz(dr("ord_itm_item_code")) + " " + nz(dr("ord_itm_desc"))
                If nz(dr("ord_itm_prod_type")) <> "KIT" Then lb.Font = New Font(lb.Font, lb.Font.Style Or FontStyle.Bold)
                pn.Height += 14
                iCnt += 1
            Loop Until dr.Read = Nothing
            dr.Close()

            Dim bt As New Infragistics.Win.Misc.UltraButton
            bt.Parent = pn
            bt.Text = "SHIP"
            bt.Left = 385
            bt.Top = 8
            bt.Height = 50
            bt.Width = 80
            bt.Font = New Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point)
            bt.Name = "b" + CStr(OrdGenSerial)
            AddHandler bt.Click, AddressOf OrderClick

            pCnt += 1
            ShipTop = pn.Top + pn.Height + 3
        End If
        cnn.Close()
    End Function
    Private Sub OrderClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim bt As Infragistics.Win.Misc.UltraButton = sender
        Dim cmd As New SqlCommand("select itm_box.* from ord_itm, itm_box, ord_gen where ord_itm_item_code=itm_box_itm_code and ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev=ord_itm_rev and ord_gen_type=ord_itm_type and ord_gen_serial=" + Mid(bt.Name, 2), cnn)
        Dim da As New SqlClient.SqlDataAdapter(cmd)

        cnn.Open()
        da.Fill(dsBoxes)
        cnn.Close()

        gBoxes.DataSource = dsBoxes.Tables(0)
        gBoxes.DataBind()
        pInfo.Tag = Mid(bt.Name, 2)
        pInfo.Visible = True
        pShip.Enabled = False
        onShipment = bt.Parent
        onShipment.BackColor = Color.Yellow
    End Sub

    Private Sub fmShipPick_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        LoadGrid()
    End Sub

    Private Sub bPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrint.Click
        If ShipPrinterFedEx = "" Then
            MsgBox("You must first setup a FedEx printer.", MsgBoxStyle.Exclamation, "Printer?")
            SaveCanceled = True
            Exit Sub
        End If
        'If SubmitFedEx() = False Then
        '    MsgBox("Shipment Failed", MsgBoxStyle.Critical, "Shipment?")
        '    Exit Sub
        'End If

    End Sub

    Private Sub pShip_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pShip.Paint

    End Sub

    Private Sub bCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
        pInfo.Visible = False
        pShip.Enabled = True
        onShipment.BackColor = Color.PaleGoldenrod
    End Sub
End Class
