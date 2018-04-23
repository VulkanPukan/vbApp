Imports System.Text
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Data

Public Class fmTaxImport
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
    Friend WithEvents OpenFile1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tDate1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Bar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents chkImportColorado As System.Windows.Forms.CheckBox
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OpenFile1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tDate1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Bar1 = New System.Windows.Forms.ProgressBar()
        Me.chkImportColorado = New CheckBox()
        CType(Me.tDate1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(29, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Browse for File"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(343, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Update Website"
        '
        'tDate1
        '
        Me.tDate1.Location = New System.Drawing.Point(115, 83)
        Me.tDate1.Name = "tDate1"
        Me.tDate1.Size = New System.Drawing.Size(173, 24)
        Me.tDate1.TabIndex = 4
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(19, 83)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(192, 19)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "Import to Start"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(343, 121)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(240, 37)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Import Time Zones"
        '
        'Bar1
        '
        Me.Bar1.Location = New System.Drawing.Point(10, 9)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(528, 28)
        Me.Bar1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.chkImportColorado.AutoSize = True
        Me.chkImportColorado.Location = New System.Drawing.Point(24, 184)
        Me.chkImportColorado.Name = "CheckBox1"
        Me.chkImportColorado.Size = New System.Drawing.Size(168, 17)
        Me.chkImportColorado.TabIndex = 7
        Me.chkImportColorado.Text = "Import CO (Colorado) sales tax"
        Me.chkImportColorado.UseVisualStyleBackColor = True
        '
        'fmTaxImport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(654, 245)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tDate1)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.chkImportColorado)
        Me.Name = "fmTaxImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tax by Zip Import"
        CType(Me.tDate1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If OpenFile1.ShowDialog = DialogResult.OK Then
                Dim ln As String
                Dim fl As New IO.StreamReader(OpenFile1.FileName)
                Dim cnt, tot As Integer
                Dim itm As Array
                Dim cmd As New SqlCommand
                Dim dt As New DataTable
                Dim dr As DataRow
                Dim da As New SqlDataAdapter(cmd)
                Dim importTax As Boolean = True 'By default true only in case of Colorado to be changed

                Button1.Enabled = False
                cmd.Connection = cnn

                cnt = 0
                tot = 0
                Do
                    ln = fl.ReadLine()
                    tot = tot + 1
                Loop Until ln Is Nothing
                fl.Close()


                fl = New IO.StreamReader(OpenFile1.FileName)

                cnn.Open()
                Application.DoEvents()
                'cmd.CommandText = "truncate table tax_file"
                'cmd.ExecuteNonQuery()
                'cmd.CommandText = "delete from zip_file where zip_state='CO'"
                'cmd.ExecuteNonQuery()
                Do
                    ln = fl.ReadLine
                    If Not ln Is Nothing Then
                        ln = Replace(ln, "'", "''")
                        itm = Split(ln, vbTab)
                        If IsNumeric(itm(0)) Then
                            If itm(1) = "CO" Then
                                importTax = chkImportColorado.Checked
                            End If

                            If importTax = True Then

                                cmd.CommandText = "select * from zip_file where zip_code='" + itm(0) + "' and zip_state='" + itm(1) + "' and zip_city='" + itm(3) + "' and zip_county_name='" + itm(2) + "' and zip_start<='" + CStr(tDate1.Value) + "' and zip_end>='" + CStr(tDate1.Value) + "'"
                                dt.Clear()
                                da.Fill(dt)
                                If dt.Rows.Count > 0 Then
                                    Try
                                        For Each dr In dt.Rows
                                            If (dr("zip_sales_tax") <> CDbl(itm(22)) Or dr("zip_tax_shipping") <> IIf(itm(38) = "Y", True, False)) And nz(dr("zip_manual"), False) <> True Then
                                                cmd.CommandText = "update zip_file set zip_end='" + CStr(DateAdd(DateInterval.Day, -1, tDate1.Value)) + "',zip_updated='" + CStr(Today) + "' where zip_serial=" + CStr(dr("zip_serial"))
                                                cmd.ExecuteNonQuery()
                                                cmd.CommandText = "insert into zip_file (zip_code,zip_state,zip_county_name,zip_county_fips,zip_city,zip_sales_tax,zip_tax_shipping,zip_updated,zip_start,zip_end) values ('" + itm(0) + "','" + itm(1) + "','" + itm(2) + "','" + Mid(itm(24), 1, 10) + "','" + itm(3) + "'," + itm(22) + "," + IIf(itm(38) = "Y", "1", "0") + ",'" + CStr(Today) + "','" + CStr(tDate1.Value) + "','12/31/2099')"
                                                cmd.ExecuteNonQuery()
                                            End If
                                        Next
                                    Catch ex As Exception

                                    End Try
                                Else
                                    cmd.CommandText = "insert into zip_file (zip_code,zip_state,zip_county_name,zip_county_fips,zip_city,zip_sales_tax,zip_tax_shipping,zip_updated,zip_start,zip_end) values ('" + itm(0) + "','" + itm(1) + "','" + itm(2) + "','" + Mid(itm(24), 1, 10) + "','" + itm(3) + "'," + itm(22) + "," + IIf(itm(38) = "Y", "1", "0") + ",'" + CStr(Today) + "','" + CStr(Today) + "','12/31/2099')"
                                    cmd.ExecuteNonQuery()
                                End If
                                'cmd.CommandText = "update zip_file set zip_updated='" + CStr(Today) + "' where zip_code='" + itm(0) + "' and zip_state='" + itm(1) + "' and zip_city='" + itm(3) + "'"
                                'cmd.ExecuteNonQuery()
                                cnt = cnt + 1
                                Bar1.Value = cnt / tot * 100
                                Application.DoEvents()
                            End If 'Import Tax for Colorado if then
                        End If 'isnumeric if then
                    End If
                Loop Until ln Is Nothing
                'cmd.CommandText = "delete from zip_file where zip_updated<'" + CStr(Today) + "' and isnull(zip_manual,0)<>1"
                'cmd.ExecuteNonQuery()
                'cmd.CommandText = "update zip_file set zip_sales_tax=.029,zip_use_tax=.029 where zip_state='CO' and zip_manual<>1"
                'cmd.ExecuteNonQuery()
                cnn.Close()
                Button1.Enabled = True
                MsgBox("Import Complete.", MsgBoxStyle.Information, "Complete")
            End If
        Catch
            MsgBox("Err: " + Err.Source + " stact trace: " + Err.Source)
            DoError(Err, MainForm)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            Dim statecmd As New SqlClient.SqlCommand("select tax_state from tax_state")
            Dim cnn9 As New SqlClient.SqlConnection
            cnn9.ConnectionString = cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'"
            Dim ds As New DataSet
            Dim stateda As New SqlDataAdapter

            Dim cmd As New SqlCommand("", cnn)
            Dim wciconn As String = String.Format("server={0};user id={1}; password={2}; database=WCI; pooling=false", "wci-live.c6u36j5sk3af.us-east-1.rds.amazonaws.com", "wci_sa", "jcom39201")
            Dim cnnwci As New SqlConnection(wciconn)
            Dim cmdwci As New SqlCommand("Updatezipfile", cnnwci)
            cmdwci.CommandType = CommandType.Text 'CommandType.StoredProcedure
            cmdwci.Connection = cnnwci
            cmd.CommandText = "Select max(zip_sales_tax) as zip_sales_tax,zip_code,zip_state,zip_city From zip_file where zip_start>getdate() -90 and zip_end > getdate() group by zip_code,zip_state,zip_city order by zip_code,zip_state,zip_city"
            cnn.Open()
            cnnwci.Open()

            statecmd.Connection = cnn9
            stateda.SelectCommand = statecmd
            stateda.Fill(ds)
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Dim pzip As New SqlParameter("@zip_code", SqlDbType.Text)
            'Dim pcity As New SqlParameter("@city", SqlDbType.Text)
            'Dim pstate As New SqlParameter("@state", SqlDbType.Text)
            'Dim prate As New SqlParameter("@rate", SqlDbType.Decimal)

            'cmdwci.Parameters.Clear()
            'cmdwci.Parameters.Add(pzip)
            'cmdwci.Parameters.Add(pcity)
            'cmdwci.Parameters.Add(pstate)
            'cmdwci.Parameters.Add(prate)
            da.Fill(dt)
            Dim reccnt As Integer
            Dim cntr As Integer
            cntr = 0
            For Each dr In dt.Rows
                cntr = cntr + 1
                Bar1.Value = cntr / dt.Rows.Count * 100

                cmdwci.CommandText = "select count(*) from zip_file where zip_city = '" & dr("zip_city") & "' and zip_state = '" & dr("zip_state") & "' and zip_code ='" & dr("zip_code") & "'"
                reccnt = cmdwci.ExecuteScalar
                If reccnt = 0 Then
                    cmdwci.CommandText = "insert zip_file (zip_start, zip_end, zip_serial, zip_tax_shipping, zip_city, zip_state, zip_code, zip_sales_tax) select getdate(),getdate()+300,1,1,'" & dr("zip_city") & "','" & dr("zip_state") & "','" & dr("zip_code") & "'," & dr("zip_sales_tax")
                Else
                    cmdwci.CommandText = "update zip_file set zip_sales_tax = " & dr("zip_sales_tax") & " where zip_city = '" & dr("zip_city") & "' and zip_state = '" & dr("zip_state") & "' and zip_code ='" & dr("zip_code") & "'"
                End If
                'Exit For
                cmdwci.ExecuteNonQuery()
                'pzip.Value = dr("zip_code")
                'pcity.Value = dr("zip_city")
                'pstate.Value = dr("zip_state")
                'prate.Value = dr("zip_sales_tax")
                'cmdwci.Parameters.Clear()
                'cmdwci.Parameters.Add(pzip)
                'cmdwci.Parameters.Add(pcity)
                'cmdwci.Parameters.Add(pstate)
                'cmdwci.Parameters.Add(prate)
                'cmdwci.ExecuteNonQuery()
            Next
            '------------ delete unused states
            cmdwci.CommandText = "update zip_file set zip_sales_tax = 0 where zip_state not in ("
            For ii As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If ii < ds.Tables(0).Rows.Count - 1 Then

                    cmdwci.CommandText = cmdwci.CommandText & "'" & ds.Tables(0).Rows(ii)(0).ToString & "',"
                Else
                    cmdwci.CommandText = cmdwci.CommandText + "'" + ds.Tables(0).Rows(ii)(0).ToString + "')"
                End If
            Next

            cmdwci.ExecuteNonQuery()
            cnn.Close()
            cnnwci.Close()

            MsgBox("done")

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub Button2_old(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button2.Enabled = False

        Dim cmd As New SqlCommand("", cnn)
        Dim oWeb As New System.Net.WebClient()
        Dim xml As String
        Dim MD5 As String
        Dim str As String
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        Dim fl As New IO.StreamWriter("c:\temp\xml.txt")
        Dim xmlDoc As New Xml.XmlDocument
        Dim onState As String = ""
        Dim dtStates As New DataTable
        Dim cnt As Integer = 0

        cnn.Open()

        xml = "<?xml version='1.0' encoding='ISO-8859-1'?>" + vbCrLf
        xml += "<Taxes xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xsi:noNamespaceSchemaLocation='http://schemas.smartz.com/StoreTaxTableSchema.xsd'>" + vbCrLf

        cmd.CommandText = "Select max(zip_sales_tax) as zip_sales_tax,zip_code,zip_state,zip_tax_shipping From zip_file where zip_start<=getdate() and zip_end>=getdate() group by zip_code,zip_state,zip_tax_shipping"

        fl.Write("<?xml version='1.0' encoding='ISO-8859-1'?>" + vbCrLf)
        fl.Write("<Taxes xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xsi:noNamespaceSchemaLocation='http://schemas.smartz.com/StoreTaxTableSchema.xsd'>" + vbCrLf)

        da.Fill(dt)
        For Each dr In dt.Rows
            xml = "<Tax>" + vbCrLf
            xml += "<Rate>" + CStr(Math.Round(dr("zip_sales_tax") * 100, 4)) + "</Rate>" + vbCrLf
            xml += "<PostalCode>" + CStr(dr("zip_code")) + "</PostalCode>" + vbCrLf
            xml += "<State>" + dr("zip_state") + "</State>" + vbCrLf
            xml += "<ApplyToShipping>" + IIf(dr("zip_tax_shipping"), "1", "0") + "</ApplyToShipping>" + vbCrLf
            xml += "</Tax>" + vbCrLf
            cnt += 1
            fl.Write(xml)
            Bar1.Value = cnt / dt.Rows.Count * 100
        Next
        'dr.Close()

        xml = "</Taxes>" + vbCrLf
        fl.Write(xml)
        fl.Close()


        Dim wR As System.Net.WebRequest = System.Net.WebRequest.Create("http://store.winecellarinnovations.com/API/")
        Dim wResponse As System.Net.WebResponse
        Dim flRead As New IO.StreamReader("c:\temp\xml.txt")

        xml = flRead.ReadToEnd

        wR.Timeout = 900000
        Dim postBuffer As Byte()
        postBuffer = System.Text.Encoding.UTF8.GetBytes(xml)

        MD5 = HashString(xml + "788473594")
        MD5 = HashString(MD5 + "788473594")

        wR.Method = "POST"
        wR.ContentType = "text/xml"
        wR.ContentLength = postBuffer.Length
        wR.Headers.Add("X-Command", "import-taxes")
        wR.Headers.Add("X-Signature", MD5)

        Dim postStream As System.IO.Stream = wR.GetRequestStream()
        Dim xmlOut As Xml.XmlDocument
        Dim nd As Xml.XmlNode
        Dim nds As Xml.XmlNodeList

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
                MsgBox(str)
            Else
                MsgBox(nds(0).InnerText)
            End If
        Catch
            MsgBox(Err.Description)
        End Try
        cnn.Close()
        Button2.Enabled = True

    End Sub
    Public Function FileToByteArray(ByVal _FileName As String) As Byte()
        Dim _Buffer() As Byte = Nothing

        Try
            ' Open file for reading
            Dim _FileStream As New System.IO.FileStream(_FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read)

            ' attach filestream to binary reader
            Dim _BinaryReader As New System.IO.BinaryReader(_FileStream)

            ' get total byte length of the file
            Dim _TotalBytes As Long = New System.IO.FileInfo(_FileName).Length

            ' read entire file into buffer
            _Buffer = _BinaryReader.ReadBytes(CInt(Fix(_TotalBytes)))

            ' close file reader
            _FileStream.Close()
            _FileStream.Dispose()
            _BinaryReader.Close()
        Catch _Exception As Exception
            ' Error
            Console.WriteLine("Exception caught in process: {0}", _Exception.ToString())
        End Try

        Return _Buffer
    End Function
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

    Private Sub fmTaxImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tDate1.Value = Today
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd As New SqlCommand("", cnn)
        Dim fl As IO.StreamReader
        Dim fd As New OpenFileDialog
        Dim ln As String

        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            fl = New IO.StreamReader(fd.FileName)
            cnn.Open()
            Do While fl.EndOfStream = False
                ln = fl.ReadLine
                If ln <> "" Then
                    If IsNumeric(Replace(Split(ln, """,""")(0), """", "")) Then
                        cmd.CommandText = "update zip_file set zip_long=" + Split(ln, """,""")(4) + ",zip_lat=" + Split(ln, """,""")(3) + ",zip_time_zone=" + Split(ln, """,""")(5) + ",zip_dst=" + Replace(Split(ln, """,""")(6), """", "") + " where zip_code='" + Replace(Split(ln, """,""")(0), """", "") + "'"
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Loop
            cnn.Close()
            fl.Close()
        End If

    End Sub
End Class
