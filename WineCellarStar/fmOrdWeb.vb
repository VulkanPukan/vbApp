Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports Microsoft.Office.Interop

Public Class fmOrdWeb
    Inherits System.Windows.Forms.Form
    Public fmOrd As fmEstOrd2
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
    Friend WithEvents lMan As System.Windows.Forms.Label
    Friend WithEvents tMan As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents WebOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Import As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents StarOrder As System.Windows.Forms.DataGridViewTextBoxColumn

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("web_ord_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("web_ord_ordernumber")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("web_ord_timeoforder")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("web_ord_lastupdated")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("web_ord_ord_serial")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("web_ord_imported")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("web_ord_entered_manually")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Submit", 0)
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.lMan = New System.Windows.Forms.Label
        Me.tMan = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.WebOrder = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Import = New System.Windows.Forms.DataGridViewButtonColumn
        Me.StarOrder = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Order Number"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Format = "MM/dd/yyyy hh:mm"
        UltraGridColumn3.Header.Caption = "Time of Order"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 147
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(522, 559)
        Me.Grid1.TabIndex = 0
        '
        'lMan
        '
        Me.lMan.AutoSize = True
        Me.lMan.Location = New System.Drawing.Point(20, 458)
        Me.lMan.Name = "lMan"
        Me.lMan.Size = New System.Drawing.Size(309, 17)
        Me.lMan.TabIndex = 1
        Me.lMan.Text = "Manually entered order 0000 on order number: "
        '
        'tMan
        '
        Me.tMan.Location = New System.Drawing.Point(301, 457)
        Me.tMan.Name = "tMan"
        Me.tMan.Size = New System.Drawing.Size(141, 22)
        Me.tMan.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(451, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Set"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 505)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Remove order 0000 and DO NOT make an order:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(317, 501)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WebOrder, Me.Import, Me.StarOrder})
        Me.DataGridView1.Location = New System.Drawing.Point(583, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(356, 362)
        Me.DataGridView1.TabIndex = 6
        '
        'WebOrder
        '
        Me.WebOrder.DataPropertyName = "orderid"
        Me.WebOrder.HeaderText = "Web order"
        Me.WebOrder.Name = "WebOrder"
        '
        'Import
        '
        Me.Import.HeaderText = "Import"
        Me.Import.Name = "Import"
        '
        'StarOrder
        '
        Me.StarOrder.HeaderText = "StarOrder"
        Me.StarOrder.Name = "StarOrder"
        '
        'fmOrdWeb
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1009, 644)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tMan)
        Me.Controls.Add(Me.lMan)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "fmOrdWeb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Web Orders"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim cmd As New SqlCommand("", cnn)
    Private Sub fmOrdWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        'GetOrders()
        LoadOrders()
        GetNewSiteOrders()
    End Sub
    Private Sub LoadOrders()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)

        cmd.CommandText = "select web_ord.* from web_ord left outer join ord_gen on web_ord_ordernumber=ord_gen_web_order where ord_gen_serial is null and web_ord_entered_manually=0 order by web_ord_ordernumber"
        'cmd.CommandText = "select web_ord.* from web_ord left outer join ord_gen on web_ord_ordernumber=ord_gen_web_order where web_ord_ordernumber =6382 "
        da.Fill(dt)
        Grid1.DataSource = dt
        Grid1.DataBind()
    End Sub
    Private Sub GetOrders()
        Dim oWeb As New System.Net.WebClient()
        Dim xml As String
        Dim MD5 As String
        Dim str As String
        Dim xmlReturn As New Xml.XmlDocument
        Dim xmlOut As Xml.XmlDocument
        Dim xmlNode, nd As Xml.XmlNode
        Dim xmlNodes As Xml.XmlNodeList
        Dim onOrdRetrieveDateStart As Date
        Dim onOrdRetrieveDateEnd As Date = DateAdd(DateInterval.Day, 1, Now)

        Try
            cnn.Open()
            cmd.CommandText = "select mas_last_web_ord_retrieved from mas_file"
            'onOrdRetrieveDateStart = DateAdd(DateInterval.Hour, -72, nz(cmd.ExecuteScalar, CDate("1/1/1900")))
            onOrdRetrieveDateStart = DateAdd(DateInterval.Day, -7, nz(cmd.ExecuteScalar, CDate("1/1/1900")))
            xml = ""
            xml += "<?xml version='1.0' encoding='ISO-8859-1'?>" + vbCrLf
            xml += "<Criteria xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xsi:noNamespaceSchemaLocation='http://schemas.smartz.com/StoreOrderSchema.xsd'>" + vbCrLf
            xml += "<DateRange Start='" + Format(onOrdRetrieveDateStart, "yyyy-MM-ddThh:mm:ss") + "' End='" + Format(onOrdRetrieveDateEnd, "yyyy-MM-ddThh:mm:ss") + "'/>" + vbCrLf  '2010-08-31T00:00:00
            xml += "</Criteria>" + vbCrLf

            MD5 = HashString(xml + "788473594")
            MD5 = HashString(MD5 + "788473594")

            Dim wR As System.Net.WebRequest = System.Net.WebRequest.Create("http://store.winecellarinnovations.com/API/") '  http://winecellarstore.smartzsites.com/API/
            Dim wResponse As System.Net.WebResponse

            wR.Timeout = 40000
            Dim postBuffer As Byte()
            postBuffer = System.Text.Encoding.UTF8.GetBytes(xml)

            wR.Method = "POST"
            wR.ContentType = "text/xml"
            wR.ContentLength = postBuffer.Length
            wR.Headers.Add("X-Command", "export-orders")
            wR.Headers.Add("X-Signature", MD5)

            Dim postStream As System.IO.Stream = wR.GetRequestStream()

            postStream.Write(postBuffer, 0, postBuffer.Length)
            postStream.Close()
            MsgBox("1")
            ' pass the response from webRequest to a webResponse.
            Try
                wResponse = wR.GetResponse()
                Dim rdr As New IO.StreamReader(wResponse.GetResponseStream)
                Dim OrderNumber As String
                Dim TimeOfOrder As String
                Dim LastUpdated As String
                Dim OrderStatus As String

                str = rdr.ReadToEnd

                xmlReturn.LoadXml(str)

                xmlNodes = xmlReturn.GetElementsByTagName("Order")
                For Each xmlNode In xmlNodes

                    nd = xmlNode.SelectSingleNode("OrderNumber")
                    OrderNumber = nd.InnerText
                    If OrderNumber <> "" Then
                        cmd.CommandText = "select count(*) from web_ord where web_ord_ordernumber=" + OrderNumber
                        If nz(cmd.ExecuteScalar, 0) = 0 Then
                            xmlOut = New Xml.XmlDocument
                            xmlOut.LoadXml(xmlNode.OuterXml)
                            xmlOut.Save("\\10.0.0.245\jcom$\weborders\Order" + nd.InnerText + ".xml")

                            nd = xmlNode.SelectSingleNode("TimeOfOrder")
                            TimeOfOrder = nd.InnerText
                            nd = xmlNode.SelectSingleNode("LastUpdated")
                            LastUpdated = nd.InnerText
                            nd = xmlNode.SelectSingleNode("OrderStatus")
                            OrderStatus = nd.InnerText

                            cmd.CommandText = "insert into web_ord (web_ord_ordernumber,web_ord_timeoforder,web_ord_lastupdated) values (" + OrderNumber + ",'" + TimeOfOrder + "','" + LastUpdated + "')"
                            cmd.ExecuteScalar()
                        Else
                        End If
                    End If
                Next
                cmd.CommandText = "update mas_file set mas_last_web_ord_retrieved='" + CStr(onOrdRetrieveDateEnd) + "'"
                cmd.ExecuteNonQuery()
                cnn.Close()

            Catch
                MsgBox(Err.Description)
                Me.Close()
            End Try
        Catch
            MsgBox(Err.Description)
            Me.Close()
        Finally
            cnn.Close()
        End Try
    End Sub
    Protected Function HashString(ByVal Value As String) As String
        Dim x As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        Dim data As Byte() = System.Text.Encoding.ASCII.GetBytes(Value)
        data = x.ComputeHash(data)
        Dim result As String = String.Empty
        For i As Integer = 0 To data.Length - 1
            result += data(i).ToString("x2").ToLower()
        Next
        Return result
    End Function
    Protected Function HashString(ByVal ByteArray As Byte()) As String
        Dim x As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        'Dim data As Byte() = System.Text.Encoding.ASCII.GetBytes(Value)
        ByteArray = x.ComputeHash(ByteArray)
        Dim result As String = String.Empty
        For i As Integer = 0 To ByteArray.Length - 1
            result += ByteArray(i).ToString("x2").ToLower()
        Next
        Return result
    End Function

    Private Sub Grid1_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterRowActivate
        lMan.Text = "Manually entered order " + CStr(Grid1.ActiveRow.Cells(1).Value) + " on order number: "
        Label1.Text = "Remove order " + CStr(Grid1.ActiveRow.Cells(1).Value) + " and DO NOT make an order:"
    End Sub
    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub Grid1_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid1.ClickCellButton
        Try
            If fmOrd.EditMode = "Edit" Or fmOrd.EditMode = "Add" Then
                MsgBox("You must not be in EDIT mode on the quote screen.", MsgBoxStyle.Information, "Edit?")
                Exit Sub
            End If
            Dim xmlDoc As New Xml.XmlDocument
            Dim gr As Infragistics.Win.UltraWinGrid.UltraGridRow = e.Cell.Row
            Dim nd As Xml.XmlNode
            Dim nds As Xml.XmlNodeList
            Dim x As Integer
            Dim sqlx, sqlxData As String
            Dim onOrd As Long
            Dim shipNode, soldNode, ProdNode As Xml.XmlNode
            Dim row As DataRow
            Dim onShipState, onSoldState As String

            Dim daImport As New SqlDataAdapter(cmd)
            Dim cb As New SqlCommandBuilder(daImport)
            Dim dr As DataRow
            Dim TypeNotFound As String = ""
            Dim SourceNotFound As String = ""
            Dim dtCurrent As DataTable
            Dim drCurrent As DataRow
            Dim daCurrent As New SqlDataAdapter(cmd)
            Dim cbCurrent As New SqlCommandBuilder(daCurrent)
            Dim cntAdded As Integer = 0
            Dim cntUpdated As Integer = 0
            Dim cntSkipped As Integer = 0
            Dim OverwriteData As Boolean = True
            Dim onNote As String
            Dim onAddr As String
            Dim UpdateSQL As String = ""
            Dim onContSerial As Long
            Dim onName, onCompany, onAddr1, onAddr2, onAddr3, onCity, onState, onZip, onPhone, onEmail, onCounty As String

            xmlDoc.Load(Path + "weborders\order" + CStr(gr.Cells("web_ord_ordernumber").Value) + ".xml")

            nds = xmlDoc.GetElementsByTagName("ShippingInformation")
            shipNode = nds(0)
            nds = xmlDoc.GetElementsByTagName("PurchaseInformation")
            soldNode = nds(0)
            nds = xmlDoc.GetElementsByTagName("Products")
            ProdNode = nds(0)


            onShipState = nz(shipNode.Item("State").InnerText)
            cmd.CommandText = "select state_abbr from state_weborder_var where lower(state_abbr)='" + LCase(onShipState) + "'"
            cnn.Open()
            onShipState = nz(cmd.ExecuteScalar)
            cnn.Close()
            If onShipState = "" Then
                cmd.CommandText = "select state_abbr from state_weborder_var where lower(state_variation)='" + LCase(nz(shipNode.Item("State").InnerText)) + "'"
                cnn.Open()
                onShipState = nz(cmd.ExecuteScalar)
                cnn.Close()
            End If
            If onShipState = "" Then onShipState = nz(shipNode.Item("State").InnerText)
            'If onShipState.Length > 2 Then
            '    cmd.CommandText = "select state_time_zone_state from state_time_zone where state_time_zone_name='" + onShipState + "'"
            '    cnn.Open()
            '    onShipState = nz(cmd.ExecuteScalar)
            '    cnn.Close()
            '    If onShipState = "" Then onShipState = nz(shipNode.Item("State").InnerText)
            'End If

            onSoldState = nz(soldNode.Item("State").InnerText)
            cmd.CommandText = "select state_abbr from state_weborder_var where lower(state_abbr)='" + LCase(onSoldState) + "'"
            cnn.Open()
            onSoldState = nz(cmd.ExecuteScalar)
            cnn.Close()
            If onSoldState = "" Then
                cmd.CommandText = "select state_abbr from state_weborder_var where lower(state_variation)='" + LCase(nz(soldNode.Item("State").InnerText)) + "'"
                cnn.Open()
                onSoldState = nz(cmd.ExecuteScalar)
                cnn.Close()
            End If
            If onSoldState = "" Then onSoldState = nz(soldNode.Item("State").InnerText)
            'If onSoldState.Length > 2 Then
            '    cmd.CommandText = "select state_time_zone_state from state_time_zone where state_time_zone_name='" + onSoldState + "'"
            '    cnn.Open()
            '    onSoldState = nz(cmd.ExecuteScalar)
            '    cnn.Close()
            '    If onSoldState = "" Then onSoldState = nz(soldNode.Item("State").InnerText)
            'End If

            'Find or Create Contact
            onName = shipNode.Item("FirstName").InnerText + " " + shipNode.Item("LastName").InnerText
            onCompany = shipNode.Item("Company").InnerText
            onAddr1 = shipNode.Item("Address1").InnerText
            onAddr2 = shipNode.Item("Address2").InnerText
            onAddr3 = shipNode.Item("Address3").InnerText
            onCity = shipNode.Item("City").InnerText
            onState = onShipState
            onZip = shipNode.Item("Zip").InnerText
            onCounty = GetCounty(shipNode.Item("Zip").InnerText, shipNode.Item("City").InnerText)
            onPhone = CleanPhoneNumber(shipNode.Item("Phone").InnerText)
            onEmail = soldNode.Item("EmailAddress").InnerText

            If soldNode.Item("Address1").InnerText <> "" Then
                onName = soldNode.Item("FirstName").InnerText + " " + soldNode.Item("LastName").InnerText
                onCompany = soldNode.Item("Company").InnerText
                onAddr1 = soldNode.Item("Address1").InnerText
                onAddr2 = soldNode.Item("Address2").InnerText
                onAddr3 = soldNode.Item("Address3").InnerText
                onCity = soldNode.Item("City").InnerText
                onState = onSoldState
                onZip = soldNode.Item("Zip").InnerText
                onCounty = GetCounty(soldNode.Item("Zip").InnerText, soldNode.Item("City").InnerText)
                onPhone = CleanPhoneNumber(soldNode.Item("Phone").InnerText)
                onEmail = soldNode.Item("EmailAddress").InnerText
            End If

            dtCurrent = New DataTable
            onNote = ""
            UpdateSQL = "update cont_file set "

            cmd.CommandText = "select * from cont_file where cont_name='" + Replace(onName, "'", "''") + "'"
            If nz(onPhone) <> "" Then cmd.CommandText += " and cont_phone_search like '%" + nz(onPhone) + "%' "
            daCurrent.Fill(dtCurrent)

            If dtCurrent.Rows.Count = 0 Then
                cmd.CommandText = "select * from cont_file where cont_name='" + Replace(onName, "'", "''") + "' and cont_addr1='" + Replace(nz(onAddr1), "'", "''") + "'"
                daCurrent.Fill(dtCurrent)
            End If

            If dtCurrent.Rows.Count = 0 Then
                If nz(onEmail) <> "" Then
                    cmd.CommandText = "select * from cont_file where cont_email='" + Replace(onEmail, "'", "''") + "'"
                    daCurrent.Fill(dtCurrent)
                End If
            End If

            If dtCurrent.Rows.Count > 0 Then
                'dr.AcceptChanges()
                If OverwriteData Then
                    drCurrent = dtCurrent.Rows(0)
                    onContSerial = drCurrent("cont_serial")
                    If nz(onAddr1) <> "" Then
                        If nz(drCurrent("cont_addr1")) <> nz(onAddr1) Or nz(drCurrent("cont_addr2")) <> nz(onAddr2) Or nz(drCurrent("cont_addr3")) <> nz(onAddr3) Or nz(drCurrent("cont_city")) <> nz(onCity) Or nz(drCurrent("cont_state")) <> nz(onState) Or nz(drCurrent("cont_zip")) <> nz(onZip) Then
                            onNote += "ADDRESS: " + drCurrent("cont_addr1") + ", " + drCurrent("cont_addr2") + ", " + drCurrent("cont_addr3") + ", " + drCurrent("cont_city") + ", " + drCurrent("cont_state") + ", " + drCurrent("cont_zip") + " -> " + onAddr1 + ", " + onAddr2 + ", " + onAddr3 + ", " + onCity + ", " + onState + ", " + onZip + "; "
                        End If
                        drCurrent("cont_addr1") = onAddr1
                        drCurrent("cont_addr2") = onAddr2
                        drCurrent("cont_addr3") = onAddr3
                        drCurrent("cont_city") = onCity
                        drCurrent("cont_state") = onState
                        drCurrent("cont_zip") = onZip
                        UpdateSQL += "cont_addr1='" + Replace(onAddr1, "'", "''") + "',cont_addr2='" + Replace(onAddr2, "'", "''") + "',cont_addr3='" + Replace(onAddr3, "'", "''") + "',cont_city='" + Replace(onCity, "'", "''") + "',cont_state='" + Replace(onState, "'", "''") + "',cont_zip='" + Replace(onZip, "'", "''") + "',"
                    End If
                    If nz(onName) <> "" And nz(drCurrent("cont_name")) <> nz(onName) Then
                        onNote += nz(drCurrent("cont_name")) + " -> " + onName + "; "
                        drCurrent("cont_name") = onName
                        UpdateSQL += "cont_name='" + Replace(onName, "'", "''") + "',"
                    End If
                    If nz(onCompany) <> "" And nz(drCurrent("cont_company")) <> nz(onCompany) Then
                        onNote += nz(drCurrent("cont_company")) + " -> " + onCompany + "; "
                        drCurrent("cont_company") = onCompany
                        UpdateSQL += "cont_company='" + Replace(onCompany, "'", "''") + "',"
                    End If
                    If nz(onEmail) <> "" And nz(drCurrent("cont_email")) <> nz(onEmail) Then
                        onNote += nz(drCurrent("cont_email")) + " -> " + onEmail + "; "
                        drCurrent("cont_email") = onEmail
                        UpdateSQL += "cont_email='" + Replace(onEmail, "'", "''") + "',"
                    End If
                    'If nz(dr("cont_website")) <> "" And nz(drCurrent("cont_website")) <> nz(dr("cont_website")) Then
                    '    onNote += nz(drCurrent("cont_website")) + " -> " + dr("cont_website") + "; "
                    '    drCurrent("cont_website") = dr("cont_website")
                    '    UpdateSQL += "cont_website='" + Replace(dr("cont_website"), "'", "''") + "',"
                    'End If
                    If nz(onPhone) <> "" And nz(drCurrent("cont_phone1")) <> nz(onPhone) Then
                        onNote += nz(drCurrent("cont_phone1")) + " -> " + onPhone + "; "
                        drCurrent("cont_phone1") = onPhone
                        UpdateSQL += "cont_phone1='" + Replace(onPhone, "'", "''") + "',"
                    End If
                    'If nz(dr("cont_phone2")) <> "" And nz(drCurrent("cont_phone2")) <> nz(dr("cont_phone2")) Then
                    '    onNote += nz(drCurrent("cont_phone2")) + " -> " + dr("cont_phone2") + "; "
                    '    drCurrent("cont_phone2") = dr("cont_phone2")
                    '    UpdateSQL += "cont_phone2='" + Replace(dr("cont_phone2"), "'", "''") + "',"
                    'End If
                    'If nz(dr("cont_cell")) <> "" And nz(drCurrent("cont_cell")) <> nz(dr("cont_cell")) Then
                    '    onNote += nz(drCurrent("cont_cell")) + " -> " + dr("cont_cell") + "; "
                    '    drCurrent("cont_cell") = dr("cont_cell")
                    '    UpdateSQL += "cont_cell='" + Replace(dr("cont_cell"), "'", "''") + "',"
                    'End If
                    'If nz(dr("cont_fax")) <> "" And nz(drCurrent("cont_fax")) <> nz(dr("cont_fax")) Then
                    '    onNote += nz(drCurrent("cont_fax")) + " -> " + dr("cont_fax") + "; "
                    '    drCurrent("cont_fax") = dr("cont_fax")
                    '    UpdateSQL += "cont_fax='" + Replace(dr("cont_fax"), "'", "''") + "',"
                    'End If
                    'If nz(dr("cont_type")) <> "" And nz(drCurrent("cont_type")) <> nz(dr("cont_type")) Then
                    '    onNote += nz(drCurrent("cont_type")) + " -> " + dr("cont_type") + "; "
                    '    drCurrent("cont_type") = dr("cont_type")
                    '    UpdateSQL += "cont_type='" + Replace(dr("cont_type"), "'", "''") + "',"
                    'End If
                    cnn.Open()
                    cbCurrent.RefreshSchema()
                    daCurrent.Update(dtCurrent)
                    If onNote <> "" Then
                        cmd.CommandText = "insert into cont_note (cont_note_cont_serial,cont_note_user,cont_note_date,cont_note_type,cont_note) values (" + CStr(drCurrent("cont_serial")) + ",'" + User + "',getdate(),'Import Update','" + Replace(onNote, "'", "''") + "')"
                        cmd.ExecuteNonQuery()
                        UpdateSQL = Mid(UpdateSQL, 1, UpdateSQL.Length - 1)
                        UpdateSQL += " where cont_serial=" + CStr(drCurrent("cont_serial"))
                    Else
                        UpdateSQL = ""
                    End If
                    cnn.Close()
                    cntUpdated += 1
                Else
                    cntSkipped += 1
                End If
            Else
                cntAdded += 1
            End If

            If cntAdded > 0 Then
                cmd.CommandText = "insert into cont_file (cont_type, cont_name, cont_company, cont_addr1, cont_addr2, cont_addr3, cont_city, cont_state, cont_zip, last_update, update_by, inactive,"
                cmd.CommandText += "cont_ord_src, cont_ord_src_note, cont_status, cont_email, cont_phone1, cont_phone1_ext,cont_phone2, cont_phone2_ext, cont_cell, cont_fax, cont_notes,cont_website,"
                cmd.CommandText += " cont_inactive_reason, cont_import_by, cont_import_time) values ("
                cmd.CommandText += "'Individual',"
                cmd.CommandText += "'" + Replace(onName, "'", "''") + "',"
                cmd.CommandText += "'" + Replace(onCompany, "'", "''") + "',"
                cmd.CommandText += "'" + Replace(onAddr1, "'", "''") + "',"
                cmd.CommandText += "'" + Replace(onAddr2, "'", "''") + "',"
                cmd.CommandText += "'" + Replace(onAddr3, "'", "''") + "',"
                cmd.CommandText += "'" + Replace(onCity, "'", "''") + "',"
                cmd.CommandText += "'" + onState + "',"
                cmd.CommandText += "'" + onZip + "',"
                cmd.CommandText += "'" + CStr(Now) + "',"
                cmd.CommandText += "'" + User + "',"
                cmd.CommandText += "0,"
                cmd.CommandText += "'WEBSTORE',"
                cmd.CommandText += "'',"
                cmd.CommandText += "'Idle',"
                cmd.CommandText += "'" + Replace(onEmail, "'", "''") + "',"
                cmd.CommandText += "'" + Replace(onPhone, "'", "''") + "',"
                cmd.CommandText += "'',"
                cmd.CommandText += "'',"
                cmd.CommandText += "'',"
                cmd.CommandText += "'',"
                cmd.CommandText += "'',"
                cmd.CommandText += "'',"
                cmd.CommandText += "'',"
                cmd.CommandText += "'',"
                'cmd.CommandText += "'" + dr("cont_next_call") + "',"
                'cmd.CommandText += "'" + dr("cont_next_call_time") + "',"
                'cmd.CommandText += "'" + dr("cont_next_call_reason") + "',"
                'cmd.CommandText += "'" + dr("cont_next_call_by") + "',"
                'cmd.CommandText += "'" + CStr(nz(dr("cont_next_call_rcfs_serial"), 0)) + "',"
                'cmd.CommandText += "'" + dr("cont_call_center_rep_code") + "',"
                'cmd.CommandText += "'" + CStr(dr("cont_import_ref")) + "',"
                cmd.CommandText += "'OrderLink',"
                cmd.CommandText += "'" + CStr(Now) + "')"
                'cmd.CommandText += "" + CStr(dr("cont_created_from_ord_serial")) + ")"

                cnn.Open()
                cmd.ExecuteNonQuery()
                cmd.CommandText = "select @@identity"
                onContSerial = cmd.ExecuteScalar

                AddSourceCode(onContSerial, "WEBSTORE")
                cnn.Close()
            Else
                If UpdateSQL <> "" Then
                    cmd.CommandText = UpdateSQL
                    cnn.Open()
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                End If
            End If
            'cmd.CommandText = "update ord_file set ord_cont_serial=" + CStr(onContSerial) + " where ord_serial=" + CStr(dr("cont_created_from_ord_serial"))
            'cmd.ExecuteNonQuery()

            'End... Find or Add Contact

            fmOrd.ShowContactsOnAdd = False
            fmOrd.Add()

            fmOrd.tSold_Name.Text = shipNode.Item("FirstName").InnerText + " " + shipNode.Item("LastName").InnerText
            fmOrd.tsold_company.Text = shipNode.Item("Company").InnerText
            fmOrd.tsold_addr1.Text = shipNode.Item("Address1").InnerText
            fmOrd.tsold_addr2.Text = shipNode.Item("Address2").InnerText
            fmOrd.tsold_addr3.Text = shipNode.Item("Address3").InnerText
            fmOrd.tSold_City.Text = shipNode.Item("City").InnerText
            fmOrd.tsold_state.Text = onShipState
            fmOrd.tsold_zip.Text = shipNode.Item("Zip").InnerText
            fmOrd.tSoldCounty.Text = GetCounty(shipNode.Item("Zip").InnerText, shipNode.Item("City").InnerText)
            fmOrd.tsold_phone1.Text = CleanPhoneNumber(shipNode.Item("Phone").InnerText)
            fmOrd.tsold_email.Text = soldNode.Item("EmailAddress").InnerText
            fmOrd.tord_for.Text = shipNode.Item("LastName").InnerText + " web order " + CStr(gr.Cells("web_ord_ordernumber").Value)
            fmOrd.UpdateSalesRep()

            fmOrd.Tab1.Tabs("Q0").Selected = True
            fmOrd.TabItems.Tabs("Shipping").Selected = True
            fmOrd.CopyShipAddress()
            fmOrd.GetGenTaxRate()

            If soldNode.Item("Address1").InnerText <> "" Then
                fmOrd.tSold_Name.Text = soldNode.Item("FirstName").InnerText + " " + soldNode.Item("LastName").InnerText
                fmOrd.tsold_company.Text = soldNode.Item("Company").InnerText
                fmOrd.tsold_addr1.Text = soldNode.Item("Address1").InnerText
                fmOrd.tsold_addr2.Text = soldNode.Item("Address2").InnerText
                fmOrd.tsold_addr3.Text = soldNode.Item("Address3").InnerText
                fmOrd.tSold_City.Text = soldNode.Item("City").InnerText
                fmOrd.tsold_state.Text = onSoldState
                fmOrd.tsold_zip.Text = soldNode.Item("Zip").InnerText
                fmOrd.tSoldCounty.Text = GetCounty(soldNode.Item("Zip").InnerText, soldNode.Item("City").InnerText)
                fmOrd.tsold_phone1.Text = CleanPhoneNumber(soldNode.Item("Phone").InnerText)
                fmOrd.tsold_email.Text = soldNode.Item("EmailAddress").InnerText
                fmOrd.tord_for.Text = soldNode.Item("LastName").InnerText + " web order " + CStr(gr.Cells("web_ord_ordernumber").Value)
            End If
            fmOrd.tOrdContSerial.Text = CStr(onContSerial)

            fmOrd.TabItems.Tabs("Items").Selected = True
            For Each nd In ProdNode.ChildNodes
                If nd.Name = "Product" Then
                    row = fmOrd.dsItems.Tables("ord_itm").NewRow
                    row("ord_itm_item_code") = nd("SKU").InnerText
                    row("ord_itm_up_color") = 0
                    row("ord_itm_bom_import") = False
                    fmOrd.LoadPriceByRow(row, True)
                    row("ord_itm_qty") = Math.Round(CDbl(nd("Quantity").InnerText), 2)
                    row("ord_itm_unt_sell") = Math.Round(CDbl(nd("AdjustedPrice").InnerText), 2)
                    fmOrd.dsItems.Tables("ord_itm").Rows.Add(row)
                End If
            Next

            fmOrd.DVGen(0)("ord_gen_line_total") = Math.Round(CDbl(soldNode.Item("SubTotal").InnerText), 2)
            fmOrd.DVGen(0)("ord_gen_tax") = Math.Round(CDbl(soldNode.Item("Taxes").InnerText), 2)
            fmOrd.DVGen(0)("ord_gen_ship") = Math.Round(CDbl(soldNode.Item("ShippingTotal").InnerText), 2)
            fmOrd.DVGen(0)("ord_gen_total") = Math.Round(CDbl(soldNode.Item("GrandTotal").InnerText), 2)
            fmOrd.DVGen(0)("ord_gen_web_order") = CLng(gr.Cells("web_ord_ordernumber").Value)
            fmOrd.DVGen(0)("ord_gen_src") = "WEBSTORE"
            fmOrd.DVGen(0)("ord_gen_des_type") = "None"
            fmOrd.DVGen(0)("ord_gen_des_type_auto") = "None"
            fmOrd.DVGen(0)("ord_gen_special_notes") = shipNode.Item("SpecialInstructions").InnerText
            If shipNode.Item("Company").InnerText = "" Then
                fmOrd.DVGen(0)("ord_gen_shiptotype") = "R"
            Else
                fmOrd.DVGen(0)("ord_gen_shiptotype") = "C"
            End If
            fmOrd.DoTotal()

            QuietMode = True
            fmOrd.SplitOMatic(True)
            QuietMode = False

            xmlDoc = Nothing
            Me.Close()
        Catch
            DoError(Err, Me)
        End Try
    End Sub
    Private Function GetCounty(ByVal zip As String, ByVal city As String) As String
        Dim cmd As New SqlCommand("select zip_county_name from zip_file where zip_code='" + zip + "' and zip_city='" + Replace(city, "'", "''") + "' order by zip_sales_tax desc", cnn)
        cnn.Open()
        GetCounty = nz(cmd.ExecuteScalar)
        cnn.Close()
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tMan.Text = "" Then
            MsgBox("You must enter and order", MsgBoxStyle.OkOnly, "Order?")
            Exit Sub
        End If
        If Split(tMan.Text, "-").Length <> 3 Then
            MsgBox("Make sure your order is in the format: 123456-0-0", MsgBoxStyle.OkOnly, "Order?")
            Exit Sub
        End If
        Dim cmd As New SqlCommand("select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + Split(tMan.Text, "-")(0) + " and ord_gen_rev=" + Split(tMan.Text, "-")(2) + " and ord_gen_type='O'", cnn)
        Dim onOrd As Long
        cnn.Open()
        onOrd = nz(cmd.ExecuteScalar, 0)
        If onOrd = 0 Then
            MsgBox("Order is not found.", MsgBoxStyle.OkOnly, "Order?")
            cnn.Close()
            Exit Sub
        End If
        cmd.CommandText = "select ord_gen_web_order from ord_gen where ord_gen_ord_serial=" + Split(tMan.Text, "-")(0) + " and ord_gen_rev=" + Split(tMan.Text, "-")(2) + " and ord_gen_type='O'"
        If nz(cmd.ExecuteScalar, 0) <> 0 Then
            MsgBox("Web Order " + CStr(cmd.ExecuteScalar) + " already assigned to this order.", MsgBoxStyle.OkOnly, "Order?")
            cnn.Close()
            Exit Sub
        End If
        cmd.CommandText = "update ord_gen set ord_gen_web_order=" + CStr(Grid1.ActiveRow.Cells(1).Value) + " where ord_gen_serial=" + CStr(onOrd)
        cmd.ExecuteNonQuery()
        tMan.Text = ""
        LoadOrders()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you want to REMOVE this order?", MsgBoxStyle.YesNo, "Remove?") = MsgBoxResult.No Then Exit Sub
        cnn.Open()
        cmd.CommandText = "update web_ord set web_ord_entered_manually=1 where web_ord_ordernumber=" + CStr(Grid1.ActiveRow.Cells(1).Value)
        cmd.ExecuteNonQuery()
        cnn.Close()
        LoadOrders()
    End Sub
    Private Sub GetNewSiteOrders()
        Try
            Dim starconn As New SqlConnection(cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'")
            Dim webconn As New SqlConnection
            webconn.ConnectionString = "server=wci-live.c6u36j5sk3af.us-east-1.rds.amazonaws.com;Initial Catalog=WCI;User ID=wci_sa;password=jcom39201"
            Dim webcmd As New SqlCommand("select orderid from orderhead where ordernumber is null and statusname ='ordered'", webconn)
            Dim dbs As New BindingSource
            Dim dr As SqlClient.SqlDataReader
            Dim dt As New DataTable
            webconn.Open()
            dr = webcmd.ExecuteReader
            dt.Load(dr)
            dbs.DataSource = dt
            With Me.DataGridView1
                .DataSource = dbs
            End With
            webconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub AddParam(ByRef cmd As SqlCommand, ByVal paramname As String, ByVal paramval As String)
        Dim param As New SqlParameter
        param.DbType = DbType.String
        param.ParameterName = "@" + paramname
        param.Value = paramval
        cmd.Parameters.Add(param)
    End Sub

    Private Sub DataGridView1_AutoSizeRowsModeChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewAutoSizeModeEventArgs) Handles DataGridView1.AutoSizeRowsModeChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim StarID As Integer, webid As Integer
            Dim Starconn As New SqlConnection(cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'")
            Dim webconn As New SqlConnection("server=wci-live.c6u36j5sk3af.us-east-1.rds.amazonaws.com;Initial Catalog=WCI;User ID=wci_sa;password=jcom39201")
            Dim webcmd As New SqlCommand("exportorder", webconn)
            webcmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlClient.SqlDataReader
            With DataGridView1
                'AddParam(webcmd, "orderid", .Rows(e.ColumnIndex).Cells("WebOrder").Value)
                Dim param As New SqlParameter
                param.ParameterName = "@orderid"
                param.DbType = DbType.String
                param.Value = .Rows(e.RowIndex).Cells("weborder").Value
                webcmd.Parameters.Add(param)
                webconn.Open()
                dr = webcmd.ExecuteReader
                If Not dr.HasRows Then Exit Sub
                dr.Read()
                Dim tax As Decimal = 0
                Dim ttlprice As Decimal = 0
                Dim ttlship As Decimal = 0
                Dim cmdAddOrder As New SqlCommand("insert_orderhead", Starconn)
                cmdAddOrder.CommandType = CommandType.StoredProcedure
                AddParam(cmdAddOrder, "ord_sold_name", dr("billname").ToString)
                AddParam(cmdAddOrder, "ord_sold_company", dr("billcompany").ToString)
                AddParam(cmdAddOrder, "ord_sold_addr1", dr("billaddr1").ToString)
                AddParam(cmdAddOrder, "ord_sold_addr2", dr("billaddr2").ToString)
                AddParam(cmdAddOrder, "ord_sold_city", dr("billcity").ToString)
                AddParam(cmdAddOrder, "ord_sold_state", dr("billstate").ToString)
                AddParam(cmdAddOrder, "ord_sold_zip", dr("billzip").ToString)
                AddParam(cmdAddOrder, "ord_sold_country", dr("billcountry").ToString)
                AddParam(cmdAddOrder, "ord_sold_phone1", dr("billingphone").ToString)
                AddParam(cmdAddOrder, "ord_sold_fax", dr("billingfax").ToString)
                AddParam(cmdAddOrder, "ord_sold_email", dr("useremail").ToString)
                AddParam(cmdAddOrder, "ord_ship_name", dr("shipname").ToString)
                AddParam(cmdAddOrder, "ord_ship_company", dr("shipcompany").ToString)
                AddParam(cmdAddOrder, "ord_ship_addr1", dr("shipaddr1").ToString)
                AddParam(cmdAddOrder, "ord_ship_addr2", dr("shipaddr2").ToString)
                AddParam(cmdAddOrder, "ord_ship_city", dr("shipcity").ToString)
                AddParam(cmdAddOrder, "ord_ship_state", dr("shipstate").ToString)
                AddParam(cmdAddOrder, "ord_ship_zip", dr("shipzip").ToString)
                AddParam(cmdAddOrder, "ord_ship_country", dr("shipcountry").ToString)
                AddParam(cmdAddOrder, "ord_ship_phone1", dr("shippingphone").ToString)
                AddParam(cmdAddOrder, "ord_ship_fax", dr("shippingfax").ToString)
                AddParam(cmdAddOrder, "tax", dr("taxtotal").ToString)
                AddParam(cmdAddOrder, "webord", dr("orderid").ToString)
                AddParam(cmdAddOrder, "notes", dr("instructions").ToString)
                AddParam(cmdAddOrder, "billlast", dr("billlast").ToString)
                AddParam(cmdAddOrder, "shipping", dr("shipping").ToString)
                tax = dr("taxtotal")
                Starconn.Open()
                StarID = cmdAddOrder.ExecuteScalar
                Starconn.Close()
                DataGridView1.Rows(e.RowIndex).Cells("StarOrder").Value = StarID
                webid = dr("orderid")
                dr.Close()

                Dim cmdReturn As New SqlCommand("update orderhead set ordernumber = " + StarID.ToString + " where orderid = " + webid.ToString, webconn)
                cmdReturn.CommandType = CommandType.Text
                cmdReturn.ExecuteNonQuery()

                Dim cmdLines As New SqlCommand("select * from orderline where orderid =" & webid.ToString, webconn)
                cmdLines.CommandType = CommandType.Text

                Dim drLines As SqlDataReader = cmdLines.ExecuteReader
                While drLines.Read()
                    Dim cmdAddLine As New SqlCommand("insert_orderline", Starconn)
                    cmdAddLine.CommandType = CommandType.StoredProcedure
                    AddParam(cmdAddLine, "id", StarID.ToString)
                    AddParam(cmdAddLine, "desc", drLines("ProductName").ToString)
                    AddParam(cmdAddLine, "price", drLines("baseprice").ToString)
                    AddParam(cmdAddLine, "lastdt", drLines("lastupdated").ToString)
                    AddParam(cmdAddLine, "qty", drLines("quantity").ToString)
                    AddParam(cmdAddLine, "sku", drLines("ProductSKU").ToString)
                    AddParam(cmdAddLine, "mod", drLines("Modifications").ToString)
                    AddParam(cmdAddLine, "ship", drLines("shippingportion").ToString)
                    Starconn.Open()
                    cmdAddLine.ExecuteNonQuery()
                    Starconn.Close()
                    ttlprice = ttlprice + drLines("baseprice") * drLines("quantity")
                    ttlship = ttlship + drLines("shippingportion") * drLines("quantity")
                End While
                drLines.Close()
                webconn.Close()

                Dim cmdUpdatePrice As New SqlCommand("update ord_gen set ord_gen_total = " + LTrim(ttlprice + tax + ttlship) + " ,ord_gen_line_total = " + ttlprice.ToString + " where ord_gen_ord_serial = " + StarID.ToString, Starconn)
                Starconn.Open()
                cmdUpdatePrice.ExecuteNonQuery()

                'Dim cmdSplitOrder As New SqlCommand("SplitWebOrder", Starconn)
                'cmdSplitOrder.CommandType = CommandType.StoredProcedure
                'AddParam(cmdSplitOrder, "Ord", StarID.ToString)
                'cmdSplitOrder.ExecuteNonQuery()
                Starconn.Close()
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
