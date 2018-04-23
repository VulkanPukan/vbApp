Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class fmWebExport
    Dim cmd As New SqlCommand("", cnn)
    Dim da As New SqlDataAdapter(cmd)

    Class STaRItem
        Public Shared ItemCode As String
        Public Shared Price As Double
    End Class
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        bStart.Enabled = False
        bClear.Enabled = False
        Dim dt As New DataTable
        Dim dr As DataRow

        cmd.CommandText = "SELECT distinct itm_serial, itm_code, itm_desc, (SELECT MAX(itm_price_price) AS Expr1 FROM itm_price WHERE (itm_price_itm_code = itm_file.itm_code) AND (itm_price_type = 'RET') AND (itm_price_start <= GETDATE()) AND (itm_price_end >= GETDATE())) AS Price, (SELECT MAX(itm_price_price) AS Expr1 FROM itm_price AS itm_price_1 WHERE (itm_price_itm_code = itm_file.itm_code) AND (itm_price_type = 'SHIP') AND (itm_price_start <= GETDATE()) AND (itm_price_end >= GETDATE())) AS Ship,1 as export FROM  itm_file, itm_price WHERE itm_code=itm_price_itm_code and inactive<>1 and itm_price_exported_to_web<>1 ORDER BY itm_code"
        da.Fill(dt)
        For Each dr In dt.Rows
            tItems.Text += dr("itm_code") + vbCrLf
        Next
        Button1.Enabled = True
        bStart.Enabled = True
        bClear.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClear.Click
        tItems.Text = ""
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bStart.Enabled = False
        Button2.Enabled = False
        If pr01.Checked Or pr02.Checked Then
            If MsgBox("You have a Parent Items only option Checked." + vbCrLf + "Items must be Parent Items only!" + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Dim dtItems As New DataTable
        Dim dr As DataRow
        Dim itms As String = Replace(Replace(tItems.Text, vbTab, ""), vbLf, ",")
        Dim itm As String
        Dim itmsIn As String = ""
        dtItems.Clear()
        If Not pr02.Checked Then
            For Each itm In Split(itms, ",")
                If Trim(itm) <> "" Then
                    itmsIn += "'" + Trim(itm) + "',"
                End If
            Next
            If itmsIn.Length > 1 Then itmsIn = Mid(itmsIn, 1, Len(itmsIn) - 1)

            cmd.CommandText = "SELECT distinct itm_serial, itm_code, itm_desc, (case inactive when 1 then 0 else (SELECT MAX(itm_price_price) AS Expr1 FROM itm_price WHERE (itm_price_itm_code = itm_file.itm_code) AND (itm_price_type = 'RET') AND (itm_price_start <= GETDATE()) AND (itm_price_end >= GETDATE())) end) AS Price, (select MAX(itm_price_price) AS Expr1 from itm_price where (itm_price_itm_code = itm_file.itm_code) AND (itm_price_type = 'SHIP') AND (itm_price_start <= GETDATE()) AND (itm_price_end >= GETDATE()) and itm_price_qty_from<=1 and itm_price_qty_to>=1) AS Ship,1 as export FROM  itm_file, itm_price WHERE itm_code=itm_price_itm_code and itm_price_itm_code in (" + itmsIn + ") ORDER BY itm_code"
            da.Fill(dtItems)
            DataGridView1.DataSource = dtItems
        End If
        Button2.Enabled = True
        bStart.Enabled = True
    End Sub

    Private Sub bStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bStart.Click
        bStart.Enabled = False

        If rbcust.Checked Or pr02.Checked Then
            If MsgBox("You have a Parent Items only option Checked." + vbCrLf + "Items must be Parent Items only!" + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Dim dtItems As New DataTable
        Dim dr As DataRow
        Dim itms As String = Replace(Replace(tItems.Text, vbTab, ""), vbLf, ",")
        Dim itm As String
        Dim itmsIn As String = ""
        If Not pr02.Checked And Not rbcust.Checked Then
            For Each itm In Split(itms, ",")
                If Trim(itm) <> "" Then
                    itmsIn += "'" + Trim(itm) + "',"
                End If
            Next
            If itmsIn.Length > 1 Then itmsIn = Mid(itmsIn, 1, Len(itmsIn) - 1)

            cmd.CommandText = "SELECT distinct itm_serial, itm_code, itm_desc, (case inactive when 1 then 0 else (SELECT MAX(itm_price_price) AS Expr1 FROM itm_price WHERE (itm_price_itm_code = itm_file.itm_code) AND (itm_price_type = 'RET') AND (itm_price_start <= GETDATE()) AND (itm_price_end >= GETDATE())) end) AS Price, (select MAX(itm_price_price) AS Expr1 from itm_price where (itm_price_itm_code = itm_file.itm_code) AND (itm_price_type = 'SHIP') AND (itm_price_start <= GETDATE()) AND (itm_price_end >= GETDATE()) and itm_price_qty_from<=1 and itm_price_qty_to>=1) AS Ship,1 as export FROM  itm_file, itm_price WHERE itm_code=itm_price_itm_code and itm_price_itm_code in (" + itmsIn + ") ORDER BY itm_code"
            da.Fill(dtItems)

        End If
        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
        Dim oWeb As New System.Net.WebClient()
        Dim xml As String
        Dim MD5 As String
        Dim str As String
        Dim xmlOut As Xml.XmlDocument
        Dim nds As Xml.XmlNodeList
        Dim cnt As Integer = 0
        If Not pr02.Checked And Not rbcust.Checked Then
            cnn.Open()
            For Each dr In dtItems.Rows
                xml = ""
                xml += "<?xml version='1.0' encoding='ISO-8859-1'?>" + vbCrLf
                xml += "<Products xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xsi:noNamespaceSchemaLocation='http://schemas.smartz.com/StoreProductSchema.xsd'>" + vbCrLf
                xml += "<UpdateType>Partial</UpdateType>" + vbCrLf
                xml += "<Product>" + vbCrLf
                If Not pr02.Checked Then
                    xml += "<Id>" + dr("itm_code") + "</Id>" + vbCrLf
                Else
                    xml += "<Id>" + dr("itm_code") + "</Id>" + vbCrLf
                End If
                xml += "<CategoryId></CategoryId>" + vbCrLf

                If cbDesc.Checked Then
                    xml += "<ShortDescription>" + Replace(dr("itm_desc"), "&", " and ") + "</ShortDescription>" + vbCrLf
                End If
                If prDB.Checked Then
                    xml += "<Price>" + CStr(Math.Round(nz2(dr("price"), 0), 2)) + "</Price>" + vbCrLf
                    xml += "<ListPrice>0</ListPrice>" + vbCrLf
                ElseIf prDBSH.Checked Then
                    rbShip0.Checked = True
                    xml += "<Price>" + CStr(Math.Round(nz2(dr("price"), 0) + nz2(dr("ship"), 0), 2)) + "</Price>" + vbCrLf
                    xml += "<ListPrice>0</ListPrice>" + vbCrLf
                ElseIf prDBSH2.Checked Then
                    'rbShip0.Checked = True
                    xml += "<Price>" + CStr(Math.Round((nz2(dr("price"), 0) * CDbl(tPricePerc2.Text)) + nz2(dr("ship"), 0), 2)) + "</Price>" + vbCrLf
                    xml += "<ListPrice>" + CStr(Math.Round(nz2(dr("price"), 0), 2)) + "</ListPrice>" + vbCrLf
                ElseIf MSRP1.Checked Then
                    xml += "<Price>" + CStr(Math.Round((nz2(dr("price"), 0) + nz2(dr("ship"), 0)) * CDbl(tPricePerc3.Text), 2)) + "</Price>" + vbCrLf
                    xml += "<ListPrice>" + CStr(Math.Round(nz2(dr("price"), 0) + nz2(dr("ship"), 0), 2)) + "</ListPrice>" + vbCrLf
                Else
                    If pr0.Checked Then
                        xml += "<Price>0</Price>" + vbCrLf
                        xml += "<ListPrice>0</ListPrice>" + vbCrLf
                        'ElseIf pr01.Checked Then
                        '    xml += "<Price>0.01</Price>" + vbCrLf
                        '    xml += "<ListPrice>0</ListPrice>" + vbCrLf
                        '    xml += "<ExtraShippingFee>0</ExtraShippingFee>" + vbCrLf
                    Else
                        If prPerc.Checked Then
                            xml += "<Price>" + CStr(Math.Round(nz2(dr("price"), 0) * CDbl(tPricePerc.Text), 2)) + "</Price>" + vbCrLf
                            xml += "<ListPrice>" + CStr(Math.Round(nz2(dr("price"), 0), 2)) + "</ListPrice>" + vbCrLf
                        End If
                    End If
                End If


                If rbShip0.Checked Then
                    xml += "<ExtraShippingFee>0</ExtraShippingFee>" + vbCrLf
                Else
                    If prDBSH.Checked Then
                        xml += "<ExtraShippingFee>0</ExtraShippingFee>" + vbCrLf
                    ElseIf pr01.Checked Then

                    Else
                        xml += "<ExtraShippingFee>" + CStr(Math.Round(nz2(dr("ship"), 0), 2)) + "</ExtraShippingFee>" + vbCrLf
                    End If
                End If

                xml += "<UnitOfMeasure>ea</UnitOfMeasure>" + vbCrLf
                xml += "</Product>" + vbCrLf
                xml += "</Products>" + vbCrLf

                MD5 = HashString(xml + "788473594")
                MD5 = HashString(MD5 + "788473594")



                Dim wR As System.Net.WebRequest = System.Net.WebRequest.Create("http://store.winecellarinnovations.com/API/")
                Dim wResponse As System.Net.WebResponse

                wR.Timeout = 10000
                Dim postBuffer As Byte()
                postBuffer = System.Text.Encoding.UTF8.GetBytes(xml)

                wR.Method = "POST"
                wR.ContentType = "text/xml"
                wR.ContentLength = postBuffer.Length
                wR.Headers.Add("X-Command", "import-products")
                wR.Headers.Add("X-Signature", MD5)


                Dim postStream As System.IO.Stream = wR.GetRequestStream()

                postStream.Write(postBuffer, 0, postBuffer.Length)
                postStream.Close()
                ' pass the response from webRequest to a webResponse.

                Try
                    wResponse = wR.GetResponse()
                    Dim rdr As New IO.StreamReader(wResponse.GetResponseStream)
                    str = rdr.ReadToEnd

                    xmlOut = New Xml.XmlDocument()
                    xmlOut.LoadXml(str)
                    nds = xmlOut.GetElementsByTagName("Result")
                    If nds(0).InnerText <> "Success" Then
                        MsgBox("Failed on item: " + dr("itm_code") + vbCrLf + vbCrLf + nds(0).OuterXml)
                    Else
                        cmd.CommandText = "update itm_file set itm_web_export=1, itm_web_export_date=getdate() where itm_code='" + dr("itm_code") + "'"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update itm_price set itm_price_exported_to_web=1,itm_price_exported_date=getdate() where itm_price_itm_code='" + dr("itm_code") + "' and itm_price_exported_to_web<>1"
                        cmd.ExecuteNonQuery()
                    End If

                Catch
                    MsgBox(Err.Description)
                End Try
                cnt += 1
                bPrices.Value = Math.Truncate(cnt / dtItems.Rows.Count * 100)
            Next
            cnn.Close()


            'If dtItems.Rows.Count = 0 And pr01.Checked Then
            '    For Each str2 As String In tItems.Lines
            '        If str2 <> "" Then
            '            xml = ""
            '            xml += "<?xml version='1.0' encoding='ISO-8859-1'?>" + vbCrLf
            '            xml += "<Products xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xsi:noNamespaceSchemaLocation='http://schemas.smartz.com/StoreProductSchema.xsd'>" + vbCrLf
            '            xml += "<UpdateType>Partial</UpdateType>" + vbCrLf
            '            xml += "<Product>" + vbCrLf
            '            xml += "<Id>" + str2 + "</Id>" + vbCrLf
            '            xml += "<CategoryId></CategoryId>" + vbCrLf


            '            xml += "<Price>0.01</Price>" + vbCrLf
            '            xml += "<ListPrice>0</ListPrice>" + vbCrLf
            '            xml += "<ExtraShippingFee>0</ExtraShippingFee>" + vbCrLf


            '            xml += "<UnitOfMeasure>ea</UnitOfMeasure>" + vbCrLf
            '            xml += "</Product>" + vbCrLf
            '            xml += "</Products>" + vbCrLf

            '            MD5 = HashString(xml + "788473594")
            '            MD5 = HashString(MD5 + "788473594")



            '            Dim wR As System.Net.WebRequest = System.Net.WebRequest.Create("http://store.winecellarinnovations.com/API/")
            '            Dim wResponse As System.Net.WebResponse

            '            wR.Timeout = 10000
            '            Dim postBuffer As Byte()
            '            postBuffer = System.Text.Encoding.UTF8.GetBytes(xml)

            '            wR.Method = "POST"
            '            wR.ContentType = "text/xml"
            '            wR.ContentLength = postBuffer.Length
            '            wR.Headers.Add("X-Command", "import-products")
            '            wR.Headers.Add("X-Signature", MD5)


            '            Dim postStream As System.IO.Stream = wR.GetRequestStream()

            '            postStream.Write(postBuffer, 0, postBuffer.Length)
            '            postStream.Close()
            '            ' pass the response from webRequest to a webResponse.

            '            Try
            '                wResponse = wR.GetResponse()
            '                Dim rdr As New IO.StreamReader(wResponse.GetResponseStream)
            '                str = rdr.ReadToEnd

            '                xmlOut = New Xml.XmlDocument()
            '                xmlOut.LoadXml(str)
            '                nds = xmlOut.GetElementsByTagName("Result")
            '                If nds(0).InnerText <> "Success" Then
            '                    MsgBox("Failed on item: " + str2 + vbCrLf + vbCrLf + nds(0).OuterXml)
            '                Else
            '                    'cmd.CommandText = "update itm_file set itm_web_export=1, itm_web_export_date=getdate() where itm_code='" + dr("itm_code") + "'"
            '                    'cmd.ExecuteNonQuery()
            '                    'cmd.CommandText = "update itm_price set itm_price_exported_to_web=1,itm_price_exported_date=getdate() where itm_price_itm_code='" + dr("itm_code") + "' and itm_price_exported_to_web<>1"
            '                    'cmd.ExecuteNonQuery()
            '                End If

            '            Catch
            '                MsgBox(Err.Description)
            '            End Try
            '            cnt += 1
            '            'bPrices.Value = Math.Truncate(cnt / dtItems.Rows.Count * 100)
            '        End If
            '    Next


            'End If

        Else
            Dim errmsg As String = ""
            For Each str2 As String In tItems.Lines
                If str2 <> "" Then
                    If InStr(str2, "|") = 0 Then
                        errmsg += str2 + vbCrLf
                    End If
                    If pr02.Checked Then
                        xml = ""
                        xml += "<?xml version='1.0' encoding='ISO-8859-1'?>" + vbCrLf
                        xml += "<Products xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xsi:noNamespaceSchemaLocation='http://schemas.smartz.com/StoreProductSchema.xsd'>" + vbCrLf
                        xml += "<UpdateType>Partial</UpdateType>" + vbCrLf
                        xml += "<Product>" + vbCrLf
                        xml += "<Id>" + Trim(Split(str2, "|")(0)) + "</Id>" + vbCrLf
                        xml += "<CategoryId></CategoryId>" + vbCrLf
                        'xml += "<Price>0.01</Price>" + vbCrLf
                        'xml += "<ListPrice>0</ListPrice>" + vbCrLf
                        xml += "<ExtraShippingFee>" + Trim(Split(str2, "|")(1)) + "</ExtraShippingFee>" + vbCrLf
                        xml += "<UnitOfMeasure>ea</UnitOfMeasure>" + vbCrLf
                        xml += "</Product>" + vbCrLf
                        xml += "</Products>" + vbCrLf
                        MD5 = HashString(xml + "788473594")
                        MD5 = HashString(MD5 + "788473594")
                        Dim wR As System.Net.WebRequest = System.Net.WebRequest.Create("http://store.winecellarinnovations.com/API/")
                        Dim wResponse As System.Net.WebResponse
                        wR.Timeout = 10000
                        Dim postBuffer As Byte()
                        postBuffer = System.Text.Encoding.UTF8.GetBytes(xml)
                        wR.Method = "POST"
                        wR.ContentType = "text/xml"
                        wR.ContentLength = postBuffer.Length
                        wR.Headers.Add("X-Command", "import-products")
                        wR.Headers.Add("X-Signature", MD5)

                        Dim postStream As System.IO.Stream = wR.GetRequestStream()
                        postStream.Write(postBuffer, 0, postBuffer.Length)
                        postStream.Close()
                        ' pass the response from webRequest to a webResponse.
                        Try
                            wResponse = wR.GetResponse()
                            Dim rdr As New IO.StreamReader(wResponse.GetResponseStream)
                            str = rdr.ReadToEnd

                            xmlOut = New Xml.XmlDocument()
                            xmlOut.LoadXml(str)
                            nds = xmlOut.GetElementsByTagName("Result")
                            If nds(0).InnerText <> "Success" Then
                                MsgBox("Failed on item: " + str2 + vbCrLf + vbCrLf + nds(0).OuterXml)
                            Else
                                'cmd.CommandText = "update itm_file set itm_web_export=1, itm_web_export_date=getdate() where itm_code='" + dr("itm_code") + "'"
                                'cmd.ExecuteNonQuery()
                                'cmd.CommandText = "update itm_price set itm_price_exported_to_web=1,itm_price_exported_date=getdate() where itm_price_itm_code='" + dr("itm_code") + "' and itm_price_exported_to_web<>1"
                                'cmd.ExecuteNonQuery()
                            End If

                        Catch
                            MsgBox(Err.Description)
                        End Try
                        cnt += 1
                        'bPrices.Value = Math.Truncate(cnt / dtItems.Rows.Count * 100)
                    End If

                    If rbcust.Checked Then
                        xml = ""
                        xml += "<?xml version='1.0' encoding='ISO-8859-1'?>" + vbCrLf
                        xml += "<Products xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xsi:noNamespaceSchemaLocation='http://schemas.smartz.com/StoreProductSchema.xsd'>" + vbCrLf
                        xml += "<UpdateType>Partial</UpdateType>" + vbCrLf
                        xml += "<Product>" + vbCrLf
                        xml += "<Id>" + Trim(Split(str2, "|")(0)) + "</Id>" + vbCrLf
                        xml += "<CategoryId></CategoryId>" + vbCrLf
                        xml += "<Price>" + Trim(Replace(Split(str2, "|")(1), "$", "")) + "</Price>" + vbCrLf

                        If cbMSRP.CheckState = CheckState.Unchecked Then
                            xml += "<ListPrice>0</ListPrice>" + vbCrLf
                        End If

                        If cbShip.CheckState = CheckState.Unchecked Then
                            xml += "<ExtraShippingFee>0</ExtraShippingFee>" + vbCrLf
                        End If

                        xml += "<UnitOfMeasure>ea</UnitOfMeasure>" + vbCrLf
                        xml += "</Product>" + vbCrLf
                        xml += "</Products>" + vbCrLf

                        MD5 = HashString(xml + "788473594")
                        MD5 = HashString(MD5 + "788473594")



                        Dim wR As System.Net.WebRequest = System.Net.WebRequest.Create("http://store.winecellarinnovations.com/API/")
                        Dim wResponse As System.Net.WebResponse

                        wR.Timeout = 10000
                        Dim postBuffer As Byte()
                        postBuffer = System.Text.Encoding.UTF8.GetBytes(xml)

                        wR.Method = "POST"
                        wR.ContentType = "text/xml"
                        wR.ContentLength = postBuffer.Length
                        wR.Headers.Add("X-Command", "import-products")
                        wR.Headers.Add("X-Signature", MD5)


                        Dim postStream As System.IO.Stream = wR.GetRequestStream()

                        postStream.Write(postBuffer, 0, postBuffer.Length)
                        postStream.Close()
                        ' pass the response from webRequest to a webResponse.

                        Try
                            wResponse = wR.GetResponse()
                            Dim rdr As New IO.StreamReader(wResponse.GetResponseStream)
                            str = rdr.ReadToEnd

                            xmlOut = New Xml.XmlDocument()
                            xmlOut.LoadXml(str)
                            nds = xmlOut.GetElementsByTagName("Result")
                            If nds(0).InnerText <> "Success" Then
                                MsgBox("Failed on item: " + str2 + vbCrLf + vbCrLf + nds(0).OuterXml)
                            Else
                                'cmd.CommandText = "update itm_file set itm_web_export=1, itm_web_export_date=getdate() where itm_code='" + dr("itm_code") + "'"
                                'cmd.ExecuteNonQuery()
                                'cmd.CommandText = "update itm_price set itm_price_exported_to_web=1,itm_price_exported_date=getdate() where itm_price_itm_code='" + dr("itm_code") + "' and itm_price_exported_to_web<>1"
                                'cmd.ExecuteNonQuery()
                            End If

                        Catch
                            MsgBox(Err.Description)
                        End Try
                        cnt += 1
                        'bPrices.Value = Math.Truncate(cnt / dtItems.Rows.Count * 100)
                    End If
                End If
            Next
            If errmsg <> "" Then
                MsgBox("These items did not have a | delimeter and were skipped." + vbCrLf + errmsg)
            End If
        End If
        bStart.Enabled = True
        MsgBox("Export Complete", MsgBoxStyle.OkOnly, "Complete")
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

    
    
    Private Sub DateTimePicker3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DateTimePicker3.ValueChanged
        TextBox1.Text = DateTimePicker3.Value
    End Sub


    Private Sub rbNEXT_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbNEXT.CheckedChanged
        If rbLIVE.Checked = False Then
            Panel4.Visible = True
        Else
            Panel4.Visible = False
        End If
    End Sub

    Private Sub rbLIVE_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbLIVE.CheckedChanged
        If rbLIVE.Checked = False Then
            Panel4.Visible = True
        Else
            Panel4.Visible = False
        End If
    End Sub
  
    Private Sub btnExportNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportNEW.Click
        Dim cnn0 As New SqlClient.SqlConnection
        Try
            connStr = String.Format("server={0};user id={1}; password={2}; database=WCI; pooling=false", "wci-live.c6u36j5sk3af.us-east-1.rds.amazonaws.com", "wci_sa", "jcom39201")
            cnn0 = New SqlClient.SqlConnection(connStr)
            Dim cmd0 As New SqlCommand("", cnn0)
            cmd0.CommandTimeout = 0

            btnExportNEW.Enabled = False

            If rbcust.Checked Or pr02.Checked Then
                MsgBox("You have a Parent Items only option Checked. Not an option for NEW website", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim dtItems As New DataTable
            Dim dr As DataRow
            Dim itms As String = Replace(Replace(tItems.Text, vbTab, ""), vbLf, ",")
            Dim itm As String
            Dim itmsIn As String = ""
            If Not pr02.Checked And Not rbcust.Checked Then
                For Each itm In Split(itms, ",")
                    If Trim(itm) <> "" Then
                        itmsIn += "'" + Trim(itm) + "',"
                    End If
                Next
                If itmsIn.Length > 1 Then itmsIn = Mid(itmsIn, 1, Len(itmsIn) - 1)

                cmd.CommandText = "SELECT distinct itm_serial, itm_code, itm_desc, (case inactive when 1 then 0 else (SELECT MAX(itm_price_price) AS Expr1 FROM itm_price WHERE (itm_price_itm_code = itm_file.itm_code) AND (itm_price_type = 'RET') AND (itm_price_start <= GETDATE()) AND (itm_price_end >= GETDATE())) end) AS Price, (select MAX(itm_price_price) AS Expr1 from itm_price where (itm_price_itm_code = itm_file.itm_code) AND (itm_price_type = 'SHIP') AND (itm_price_start <= GETDATE()) AND (itm_price_end >= GETDATE()) and itm_price_qty_from<=1 and itm_price_qty_to>=1) AS Ship,1 as export FROM  itm_file, itm_price WHERE itm_code=itm_price_itm_code and itm_price_itm_code in (" + itmsIn + ") ORDER BY itm_code"
                da.Fill(dtItems)

            End If
            Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
            Dim oWeb As New System.Net.WebClient()
            Dim xml As String
            Dim MD5 As String
            Dim str As String
            Dim pric As String
            Dim msrp As String
            Dim serl As String
            Dim desc As String
            Dim ship As String
            Dim cnt As Integer = 0
            If Not pr02.Checked And Not rbcust.Checked Then
                cnn.Open()
                For Each dr In dtItems.Rows
                    If rbShip0.Checked Then
                        ship = "0"
                    Else
                        If pr0.Checked Then
                            ship = "0"
                        ElseIf pr01.Checked Then

                        Else
                            ship = CStr(Math.Round(nz2(dr("ship"), 0), 2))
                        End If
                    End If


                    pric = "0"
                    msrp = "0"
                    If Not pr02.Checked Then
                        serl = dr("itm_code")
                    End If

                    If cbDesc.Checked Then
                        desc = Replace(dr("itm_desc"), "&", " and ")
                    End If
                    If prDB.Checked Then
                        pric = CStr(Math.Round(nz2(dr("price"), 0), 2))
                        msrp = pric
                    ElseIf prDBSH.Checked Then
                        rbShip0.Checked = True
                        pric = CStr(Math.Round(nz2(dr("price"), 0) + nz2(dr("ship"), 0), 2))
                        ship = "0"
                        msrp = pric
                    ElseIf prDBSH2.Checked Then
                        'rbShip0.Checked = True
                        pric = CStr(Math.Round((nz2(dr("price"), 0) * CDbl(tPricePerc2.Text)) + nz2(dr("ship"), 0), 2))
                        msrp = CStr(Math.Round(nz2(dr("price"), 0), 2))
                        ship = "0"
                    ElseIf MSRP1.Checked Then
                        pric = CStr(Math.Round((nz2(dr("price"), 0) + nz2(dr("ship"), 0)) * CDbl(tPricePerc3.Text), 2))
                        msrp = CStr(Math.Round(nz2(dr("price"), 0) + nz2(dr("ship"), 0), 2))
                        ship = "0"
                    Else
                        If pr0.Checked Then
                            pric = "0"
                            msrp = "0"
                            ship = "0"
                        Else
                            If prPerc.Checked Then
                                pric = CStr(Math.Round(nz2(dr("price"), 0) * CDbl(tPricePerc.Text), 2))
                                msrp = CStr(Math.Round(nz2(dr("price"), 0), 2))
                            End If
                        End If
                    End If

                    Try
                        cnn0.Open()
                        cmd0.Parameters.Clear()
                        cmd0.Parameters.Add(New SqlParameter("@msrp", msrp))
                        cmd0.Parameters.Add(New SqlParameter("@price", pric))
                        cmd0.Parameters.Add(New SqlParameter("@serial", serl))
                        cmd0.Parameters.Add(New SqlParameter("@ship", ship))
                        cmd0.Parameters.Add(New SqlParameter("@now", Now))
                        If rbLIVE.Checked = True Then
                            cmd0.CommandText = "update prod_tbl set prd_msrp=@msrp, prd_price=@price,prd_extra_ship_fee=@ship, prd_last_update=@now where prd_sku=@serial"
                        Else
                            If Not IsDate(TextBox1.Text) Then
                                MsgBox("Please correct date time for " + dr("itm_code"))
                                Exit Sub
                            End If

                            cmd0.CommandText = "update prod_tbl set prd_msrp_next=@msrp, prd_price_next=@price,prd_extra_ship_fee=@ship, prd_last_update=@now,prd_msrp_next_date=@priceDate, prd_price_next_date=@priceDate where prd_sku=@serial"
                            cmd0.Parameters.Add(New SqlParameter("@priceDate", TextBox1.Text))
                        End If
                        cmd0.ExecuteNonQuery()
                        cnn0.Close()
                        cmd.CommandText = "update itm_file set itm_web_export=1, itm_web_export_date=getdate() where itm_code='" + dr("itm_code") + "'"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update itm_price set itm_price_exported_to_web=1,itm_price_exported_date=getdate() where itm_price_itm_code='" + dr("itm_code") + "' and itm_price_exported_to_web<>1"
                        cmd.ExecuteNonQuery()


                    Catch
                        MsgBox(Err.Description)
                    End Try
                    cnt += 1
                    bPrices.Value = Math.Truncate(cnt / dtItems.Rows.Count * 100)
                Next
                cnn.Close()
            Else

                Dim errmsg As String = ""
                For Each str2 As String In tItems.Lines
                    ship = "0"
                    pric = "0"
                    msrp = "0"
                    If str2 <> "" Then
                        If InStr(str2, "|") = 0 Then
                            errmsg += str2 + vbCrLf
                        End If
                        If pr02.Checked Then
                            serl = Trim(Split(str2, "|")(0))
                            ship = Trim(Split(str2, "|")(1))
                            Try
                                cnn0.Open()
                                cmd0.Parameters.Clear()
                                cmd0.Parameters.Add(New SqlParameter("@msrp", msrp))
                                cmd0.Parameters.Add(New SqlParameter("@price", pric))
                                cmd0.Parameters.Add(New SqlParameter("@serial", serl))
                                cmd0.Parameters.Add(New SqlParameter("@ship", ship))
                                cmd0.Parameters.Add(New SqlParameter("@now", Now))
                                If rbLIVE.Checked = True Then
                                    cmd0.CommandText = "update prod_tbl set prd_msrp=@msrp, prd_price=@price,prd_extra_ship_fee=@ship, prd_last_update=@now where prd_sku=@serial"
                                Else
                                    If Not IsDate(TextBox1.Text) Then
                                        MsgBox("Please correct PRICE date time for " + dr("itm_code"))
                                        Exit Sub
                                    End If

                                    cmd0.CommandText = "update prod_tbl set prd_msrp_next=@msrp, prd_price_next=@price,prd_extra_ship_fee=@ship, prd_last_update=@now,prd_msrp_next_date=@priceDate, prd_price_next_date=@priceDate where prd_sku=@serial"
                                    cmd0.Parameters.Add(New SqlParameter("@priceDate", TextBox1.Text))
                                End If
                                cmd0.ExecuteNonQuery()

                                cnn0.Close()
                            Catch
                                MsgBox(Err.Description)
                            End Try
                            cnt += 1
                            'bPrices.Value = Math.Truncate(cnt / dtItems.Rows.Count * 100)
                        End If

                        If rbcust.Checked Then

                            serl = Trim(Split(str2, "|")(0))
                            pric = Trim(Replace(Split(str2, "|")(1), "$", ""))

                            If cbMSRP.CheckState = CheckState.Unchecked Then
                                msrp = "0"
                            End If

                            If cbShip.CheckState = CheckState.Unchecked Then
                                ship = "0"
                            End If


                            Try
                                cnn0.Open()
                                cmd0.Parameters.Clear()
                                cmd0.Parameters.Add(New SqlParameter("@msrp", msrp))
                                cmd0.Parameters.Add(New SqlParameter("@price", pric))
                                cmd0.Parameters.Add(New SqlParameter("@serial", serl))
                                cmd0.Parameters.Add(New SqlParameter("@ship", ship))
                                cmd0.Parameters.Add(New SqlParameter("@now", Now))
                                If rbLIVE.Checked = True Then
                                    cmd0.CommandText = "update prod_tbl set prd_msrp=@msrp, prd_price=@price,prd_extra_ship_fee=@ship, prd_last_update=@now where prd_sku=@serial"
                                Else
                                    If Not IsDate(TextBox1.Text) Then
                                        MsgBox("Please correct PRICE date time for " + dr("itm_code"))
                                        Exit Sub
                                    End If

                                    cmd0.CommandText = "update prod_tbl set prd_msrp_next=@msrp, prd_price_next=@price,prd_extra_ship_fee=@ship, prd_last_update=@now,prd_msrp_next_date=@priceDate, prd_price_next_date=@priceDate where prd_sku=@serial"
                                    cmd0.Parameters.Add(New SqlParameter("@priceDate", TextBox1.Text))
                                End If
                                cmd0.ExecuteNonQuery()
                                cnn0.Close()
                            Catch
                                MsgBox(Err.Description)
                            End Try
                            cnt += 1
                            'bPrices.Value = Math.Truncate(cnt / dtItems.Rows.Count * 100)
                        End If
                    End If
                Next
                If errmsg <> "" Then
                    MsgBox("These items did not have a | delimeter and were skipped." + vbCrLf + errmsg)
                End If
            End If
            btnExportNEW.Enabled = True
            MsgBox("Export Complete", MsgBoxStyle.OkOnly, "Complete")

        Catch
            MsgBox(Err.Description)
        Finally
            cnn.Close()
        End Try
    End Sub

    
End Class