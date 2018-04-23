Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text


Public Class fmCCportal
    Dim cmd As New SqlCommand("", cnn)
    Dim da As New SqlDataAdapter(cmd)
    'Dim dr As SqlDataReader
    Dim dt As New DataTable
    Dim SelectedOrder As String
    Dim BillToContact As Integer = 0
    Dim SoldToContact As Integer = 0
    Dim MainOrder As String = ""
    Dim SubOrder As String = ""

    Private Sub fmCCportal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 505
        Me.Height = 563
        Button1.Focus()
        LoadList()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub LoadList()
        Try
            dt.Rows.Clear()
            Me.Cursor = Cursors.WaitCursor
            'Dim dw As DataRow
            'Dim dc As System.Data.DataColumn
            cnn.Open()
            cmd.CommandText = "SELECT  'Payment' as Type, cast(cc_pay_ord_serial as varchar) as ordernum,cc_pay_ord_serial as ordnum, cc_pay_serial as ser,cc_pay_submitted as submitted from ord_cc_portal_payment where cc_pay_processed=0 order by cc_pay_submitted desc"
            da.Fill(dt)

            cmd.CommandText = "SELECT  'Bill/Sold' as Type, cast(cc_ord_serial as varchar) as ordernum, cc_ord_serial as ordnum, cc_serial_soldto as ser,cc_submitted as submitted from ord_cc_portal_soldto where cc_processed=0 order by cc_submitted desc"
            da.Fill(dt)

            cmd.CommandText = "SELECT  'Ship' as Type,cast(cc_ord_serial as varchar) + '-' + cast(cc_ord_from_rev as varchar) + '-' + cast(cc_ord_rev as varchar) as ordernum, cc_ord_serial as ordnum, cc_serial_shipto as ser, cc_ship_submitted as submitted from ord_cc_portal_shipto where cc_ship_processed=0 order by cc_ship_submitted desc"
            da.Fill(dt)
            cnn.Close() 'CAST(DocumentNo AS VARCHAR(5) )+ 

            DataGridView1.DataSource = dt
            DataGridView1.Sort(DataGridView1.Columns("submitted"), System.ComponentModel.ListSortDirection.Descending)

            'Dim filterExp As String = "Type <> ''"
            'Dim sortExp As String = "submitted"
            'Dim drarray() As DataRow
            'Dim i As Integer
            'drarray = dt.Select(filterExp, sortExp, DataViewRowState.CurrentRows)
            'For i = 0 To (drarray.Length - 1)
            '    Dim itm As ListViewItem
            '    Dim arr(4) As String
            '    arr(0) = drarray(i)("ordnum").ToString
            '    arr(1) = drarray(i)("Type").ToString
            '    arr(2) = drarray(i)("ordernum").ToString
            '    arr(3) = drarray(i)("ser").ToString
            '    itm = New ListViewItem(arr)
            '    ListView1.Items.Add(itm)
            'Next
            Me.Cursor = Cursors.Default
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Shared Function jDecrypt(ByVal cipherText As String, Optional ByVal saltValue As String = "Jcom39201") As String
        Try
            Dim passPhrase As String = "wineCellar5"
            Dim hashAlgorithm As String = "MD5"
            Dim passwordIterations As Integer = 2
            Dim initVector As String = "jaS9#jif0wqczloS"
            Dim keySize As Integer = 256

            ' Convert strings defining encryption key characteristics into byte
            ' arrays. Let us assume that strings only contain ASCII codes.
            ' If strings include Unicode characters, use Unicode, UTF7, or UTF8
            ' encoding.
            Dim initVectorBytes As Byte()
            initVectorBytes = Encoding.ASCII.GetBytes(initVector)

            Dim saltValueBytes As Byte()
            saltValueBytes = Encoding.ASCII.GetBytes(saltValue)

            ' Convert our ciphertext into a byte array.
            Dim cipherTextBytes As Byte()
            cipherTextBytes = Convert.FromBase64String(cipherText)

            ' First, we must create a password, from which the key will be 
            ' derived. This password will be generated from the specified 
            ' passphrase and salt value. The password will be created using
            ' the specified hash algorithm. Password creation can be done in
            ' several iterations.
            Dim password As PasswordDeriveBytes
            password = New PasswordDeriveBytes(passPhrase, _
                                               saltValueBytes, _
                                               hashAlgorithm, _
                                               passwordIterations)

            ' Use the password to generate pseudo-random bytes for the encryption
            ' key. Specify the size of the key in bytes (instead of bits).
            Dim keyBytes As Byte()
            keyBytes = password.GetBytes(keySize / 8)

            ' Create uninitialized Rijndael encryption object.
            Dim symmetricKey As RijndaelManaged
            symmetricKey = New RijndaelManaged()

            ' It is reasonable to set encryption mode to Cipher Block Chaining
            ' (CBC). Use default options for other symmetric key parameters.
            symmetricKey.Mode = CipherMode.CBC

            ' Generate decryptor from the existing key bytes and initialization 
            ' vector. Key size will be defined based on the number of the key 
            ' bytes.
            Dim decryptor As ICryptoTransform
            decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

            ' Define memory stream which will be used to hold encrypted data.
            Dim memoryStream As IO.MemoryStream
            memoryStream = New IO.MemoryStream(cipherTextBytes)

            ' Define memory stream which will be used to hold encrypted data.
            Dim cryptoStream As CryptoStream
            cryptoStream = New CryptoStream(memoryStream, _
                                            decryptor, _
                                            CryptoStreamMode.Read)

            ' Since at this point we don't know what the size of decrypted data
            ' will be, allocate the buffer long enough to hold ciphertext;
            ' plaintext is never longer than ciphertext.
            Dim plainTextBytes As Byte()
            ReDim plainTextBytes(cipherTextBytes.Length)

            ' Start decrypting.
            Dim decryptedByteCount As Integer
            decryptedByteCount = cryptoStream.Read(plainTextBytes, _
                                                   0, _
                                                   plainTextBytes.Length)

            ' Close both streams.
            memoryStream.Close()
            cryptoStream.Close()

            ' Convert decrypted data into a string. 
            ' Let us assume that the original plaintext string was UTF8-encoded.
            Dim plainText As String
            plainText = Encoding.UTF8.GetString(plainTextBytes, _
                                                0, _
                                                decryptedByteCount)

            ' Return decrypted string.
            jDecrypt = plainText
        Catch
            jDecrypt = ""
            MsgBox(Err.Description)
        End Try
    End Function

    Private Sub bMod()
        tb1.BackColor = Color.MistyRose
        TextBox1.BackColor = Color.MistyRose
        TextBox2.BackColor = Color.MistyRose
        TextBox3.BackColor = Color.MistyRose
        TextBox4.BackColor = Color.MistyRose
        TextBox5.BackColor = Color.MistyRose
        TextBox6.BackColor = Color.MistyRose
        TextBox7.BackColor = Color.MistyRose
        TextBox8.BackColor = Color.MistyRose
        TextBox9.BackColor = Color.MistyRose
        TextBox10.BackColor = Color.MistyRose
        TextBox11.BackColor = Color.MistyRose
        TextBox12.BackColor = Color.MistyRose
        TextBox13.BackColor = Color.MistyRose
        TextBox14.BackColor = Color.MistyRose
    End Sub

    Private Sub bGood()
        tb1.BackColor = Color.PaleGreen
        TextBox1.BackColor = Color.PaleGreen
        TextBox2.BackColor = Color.PaleGreen
        TextBox3.BackColor = Color.PaleGreen
        TextBox4.BackColor = Color.PaleGreen
        TextBox5.BackColor = Color.PaleGreen
        TextBox6.BackColor = Color.PaleGreen
        TextBox7.BackColor = Color.PaleGreen
        TextBox8.BackColor = Color.PaleGreen
        TextBox9.BackColor = Color.PaleGreen
        TextBox10.BackColor = Color.PaleGreen
        TextBox11.BackColor = Color.PaleGreen
        TextBox12.BackColor = Color.PaleGreen
        TextBox13.BackColor = Color.PaleGreen
        TextBox14.BackColor = Color.PaleGreen
    End Sub

    Private Sub bClear()
        tb1.BackColor = Color.White
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox3.BackColor = Color.White
        TextBox4.BackColor = Color.White
        TextBox5.BackColor = Color.White
        TextBox6.BackColor = Color.White
        TextBox7.BackColor = Color.White
        TextBox8.BackColor = Color.White
        TextBox9.BackColor = Color.White
        TextBox10.BackColor = Color.White
        TextBox11.BackColor = Color.White
        TextBox12.BackColor = Color.White
        TextBox13.BackColor = Color.White
        TextBox14.BackColor = Color.White
    End Sub

    Private Sub bMod2()
        txt1.BackColor = Color.MistyRose
        txt2.BackColor = Color.MistyRose
        txt3.BackColor = Color.MistyRose
        txt4.BackColor = Color.MistyRose
        txt5.BackColor = Color.MistyRose
        txt6.BackColor = Color.MistyRose
        txt7.BackColor = Color.MistyRose
        txt8.BackColor = Color.MistyRose
        txt9.BackColor = Color.MistyRose
        txt10.BackColor = Color.MistyRose
        txt11.BackColor = Color.MistyRose
        txt12.BackColor = Color.MistyRose
        txt13.BackColor = Color.MistyRose
        txt14.BackColor = Color.MistyRose
        txt15.BackColor = Color.MistyRose
    End Sub

    Private Sub bGood2()
        txt1.BackColor = Color.PaleGreen
        txt2.BackColor = Color.PaleGreen
        txt3.BackColor = Color.PaleGreen
        txt4.BackColor = Color.PaleGreen
        txt5.BackColor = Color.PaleGreen
        txt6.BackColor = Color.PaleGreen
        txt7.BackColor = Color.PaleGreen
        txt8.BackColor = Color.PaleGreen
        txt9.BackColor = Color.PaleGreen
        txt10.BackColor = Color.PaleGreen
        txt11.BackColor = Color.PaleGreen
        txt12.BackColor = Color.PaleGreen
        txt13.BackColor = Color.PaleGreen
        txt14.BackColor = Color.PaleGreen
        txt15.BackColor = Color.PaleGreen
    End Sub

    Private Sub bClear2()
        txt1.BackColor = Color.White
        txt2.BackColor = Color.White
        txt3.BackColor = Color.White
        txt4.BackColor = Color.White
        txt5.BackColor = Color.White
        txt6.BackColor = Color.White
        txt7.BackColor = Color.White
        txt8.BackColor = Color.White
        txt9.BackColor = Color.White
        txt10.BackColor = Color.White
        txt11.BackColor = Color.White
        txt12.BackColor = Color.White
        txt13.BackColor = Color.White
        txt14.BackColor = Color.White
        txt15.BackColor = Color.White
    End Sub

    Private Sub ClearBoxes()
        txt1.BackColor = Color.White
        txt2.BackColor = Color.White
        txt3.BackColor = Color.White
        txt4.BackColor = Color.White
        txt5.BackColor = Color.White
        txt6.BackColor = Color.White
        txt7.BackColor = Color.White
        txt8.BackColor = Color.White
        txt9.BackColor = Color.White
        txt10.BackColor = Color.White
        txt11.BackColor = Color.White
        txt12.BackColor = Color.White
        txt13.BackColor = Color.White
        txt14.BackColor = Color.White
        txt15.BackColor = Color.White
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txt5.Text = ""
        txt6.Text = ""
        txt7.Text = ""
        txt8.Text = ""
        txt9.Text = ""
        txt10.Text = ""
        txt11.Text = ""
        txt12.Text = ""
        txt13.Text = ""
        txt14.Text = ""
        txt15.Text = ""

        tb1.BackColor = Color.White
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox3.BackColor = Color.White
        TextBox4.BackColor = Color.White
        TextBox5.BackColor = Color.White
        TextBox6.BackColor = Color.White
        TextBox7.BackColor = Color.White
        TextBox8.BackColor = Color.White
        TextBox9.BackColor = Color.White
        TextBox10.BackColor = Color.White
        TextBox11.BackColor = Color.White
        TextBox12.BackColor = Color.White
        TextBox13.BackColor = Color.White
        TextBox14.BackColor = Color.White
        tb1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""

        TextBox29.Text = ""
        TextBox28.Text = ""
        TextBox27.Text = ""
        TextBox26.Text = ""
        TextBox25.Text = ""
        TextBox24.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
        TextBox21.Text = ""
        TextBox20.Text = ""
        TextBox19.Text = ""
        TextBox18.Text = ""
        TextBox17.Text = ""
        TextBox16.Text = ""
        TextBox15.Text = ""

        TextBox62.Text = ""
        TextBox60.Text = ""
        TextBox59.Text = ""
        TextBox55.Text = ""
        TextBox53.Text = ""
        TextBox49.Text = ""
        TextBox48.Text = ""
        TextBox46.Text = ""
        TextBox43.Text = ""
        TextBox42.Text = ""
        TextBox39.Text = ""
        TextBox38.Text = ""
        TextBox36.Text = ""
        TextBox34.Text = ""
        TextBox32.Text = ""

        TextBox33.Text = ""
        TextBox30.Text = ""
        TextBox44.Text = ""
        TextBox47.Text = ""
        TextBox50.Text = ""
        TextBox52.Text = ""
        TextBox54.Text = ""
        TextBox56.Text = ""
        TextBox58.Text = ""



        Label52.Text = "..."
        Label26.Visible = False
        Label49.Visible = False
        Label50.Visible = False
        Label51.Visible = False
        SelectedOrder = ""
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If IsNumeric(SelectedOrder) Then
                If InStr(Label52.Text, "Payment") Then
                    If InStr(TextBox33.Text, ",") Then
                        If MsgBox("This payment is to be applied to multiple orders." + vbCrLf + _
                            "You will need to apply these manually." + vbCrLf + _
                            " " + vbCrLf + _
                            "If already applied then click Yes to close this item, " + vbCrLf + _
                            "else No to keep it open until applied.", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            Exit Sub
                        Else
                            cmd.CommandText = "update ord_cc_portal_payment set cc_pay_processed=1, cc_pay_approved=1,cc_pay_card_number='' where cc_pay_serial=" + SelectedOrder
                            cnn.Open()
                            cmd.ExecuteNonQuery()

                            Dim Occurrences As Integer
                            Dim StringToCheck As String = TextBox33.Text
                            Dim StringToFind As String = ","

                            Dim Start As Integer
                            Dim Found As Integer
                            Do
                                Start = Found + 1
                                Found = InStr(Start, StringToCheck, StringToFind)
                                If Found = 0 Then Exit Do
                                Occurrences += 1
                            Loop
                            Do Until Occurrences = -1
                                Try
                                    Dim ord As String = TextBox33.Text.Split(",")(Occurrences)
                                    Dim zord As String = ord.Split("-")(0)
                                    Dim zfromrev As String = ord.Split("-")(1)
                                    Dim zrev As String = ord.Split("-")(2)
                                    cmd.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + zord.ToString + " and ord_gen_from_rev=" + zfromrev.ToString + " and ord_gen_rev=" + zrev.ToString + " and ord_gen_type='O'"
                                    Dim cid2 As Integer = nz(cmd.ExecuteScalar)
                                    cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date,ord_note_type) values (" + cid2.ToString + ",'Credit Card Portal - payment processed for Multiple Orders. Paid by " + TextBox44.Text + ".','Admin','" + CStr(Now()) + "','Note')"
                                    cmd.ExecuteNonQuery()
                                    Occurrences += -1
                                Catch
                                    DoError(Err, Me)
                                End Try
                            Loop

                            cnn.Close()
                            MsgBox("Payment Closed")
                            Me.Width = 505
                            Me.Height = 563
                            ClearBoxes()
                            DataGridView1.ClearSelection()
                            LoadList()
                            Exit Sub
                        End If
                    End If

                    If TextBox44.Text = "Credit Card" And InStr(TextBox33.Text, ",") = 0 Then
                        If MsgBox("WARNING! Proceed only if you have already processed the credit card." + vbCrLf + "The Credit Card number will be removed and a payment automatically applied to Order." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                        If MsgBox("WARNING! Absolutely sure?" + vbCrLf + "The Credit Card number will be removed and a payment automatically applied to Order." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                        Dim cn As String = Microsoft.VisualBasic.Right(TextBox54.Text, 4)
                        Save_After()

                        cmd.CommandText = "update ord_cc_portal_payment set cc_pay_processed=1, cc_pay_approved=1,cc_pay_card_number=" + cn.ToString + " where cc_pay_serial=" + SelectedOrder
                        cnn.Open()
                        cmd.ExecuteNonQuery()

                        Try
                            Dim zord As String = TextBox33.Text.Split("-")(0)
                            Dim zfromrev As String = TextBox33.Text.Split("-")(1)
                            Dim zrev As String = TextBox33.Text.Split("-")(2)
                            cmd.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + zord.ToString + " and ord_gen_from_rev=" + zfromrev.ToString + " and ord_gen_rev=" + zrev.ToString + " and ord_gen_type='O'"
                            Dim cid2 As Integer = nz(cmd.ExecuteScalar)
                            cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date,ord_note_type) values (" + cid2.ToString + ",'Credit Card Portal - payment processed. Paid by " + TextBox44.Text + ".','Admin','" + CStr(Now()) + "','Note')"
                            cmd.ExecuteNonQuery()
                        Catch
                            DoError(Err, Me)
                        End Try

                        cnn.Close()
                        MsgBox("Payment Processed")
                    Else
                        If MsgBox("This will create a payment record automatically to the Order." + vbCrLf + _
                          "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            If MsgBox("OK, you will need to process this order manually." + vbCrLf + _
                             "Do you want to close this payment record?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                Exit Sub
                            Else
                                cmd.CommandText = "update ord_cc_portal_payment set cc_pay_processed=1, cc_pay_approved=1,cc_pay_card_number='' where cc_pay_serial=" + SelectedOrder
                                cnn.Open()
                                cmd.ExecuteNonQuery()

                                Try
                                    Dim zord As String = TextBox33.Text.Split("-")(0)
                                    Dim zfromrev As String = TextBox33.Text.Split("-")(1)
                                    Dim zrev As String = TextBox33.Text.Split("-")(2)
                                    cmd.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + zord.ToString + " and ord_gen_from_rev=" + zfromrev.ToString + " and ord_gen_rev=" + zrev.ToString + " and ord_gen_type='O'"
                                    Dim cid2 As Integer = nz(cmd.ExecuteScalar)
                                    cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date,ord_note_type) values (" + cid2.ToString + ",'Credit Card Portal - payment processed. Paid by " + TextBox44.Text + ".','Admin','" + CStr(Now()) + "','Note')"
                                    cmd.ExecuteNonQuery()
                                Catch
                                    DoError(Err, Me)
                                End Try

                                cnn.Close()
                                MsgBox("Payment Closed")
                                Me.Width = 505
                                Me.Height = 563
                                ClearBoxes()
                                DataGridView1.ClearSelection()
                                LoadList()
                                Exit Sub
                            End If

                        Else
                            Save_After()
                            cmd.CommandText = "update ord_cc_portal_payment set cc_pay_processed=1, cc_pay_approved=1,cc_pay_card_number='' where cc_pay_serial=" + SelectedOrder
                            cnn.Open()
                            cmd.ExecuteNonQuery()

                            Try
                                Dim zord As String = TextBox33.Text.Split("-")(0)
                                Dim zfromrev As String = TextBox33.Text.Split("-")(1)
                                Dim zrev As String = TextBox33.Text.Split("-")(2)
                                cmd.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + zord.ToString + " and ord_gen_from_rev=" + zfromrev.ToString + " and ord_gen_rev=" + zrev.ToString + " and ord_gen_type='O'"
                                Dim cid2 As Integer = nz(cmd.ExecuteScalar)
                                cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date,ord_note_type) values (" + cid2.ToString + ",'Credit Card Portal - payment processed. Paid by " + TextBox44.Text + ".','Admin','" + CStr(Now()) + "','Note')"
                                cmd.ExecuteNonQuery()
                            Catch
                                DoError(Err, Me)
                            End Try

                            cnn.Close()
                            MsgBox("Payment Processed")
                        End If
                    End If


                End If
                '*********************************
                If InStr(Label52.Text, "Bill/Sold") Then
                    Dim go As Boolean = False
                    If tb1.Text <> TextBox29.Text Then go = True
                    If TextBox1.Text <> TextBox28.Text Then go = True
                    If TextBox2.Text <> TextBox27.Text Then go = True
                    If TextBox3.Text <> TextBox26.Text Then go = True
                    If TextBox4.Text <> TextBox25.Text Then go = True
                    If TextBox5.Text <> TextBox24.Text Then go = True
                    If TextBox6.Text <> TextBox23.Text Then go = True
                    If TextBox7.Text <> TextBox22.Text Then go = True
                    If TextBox8.Text <> TextBox21.Text Then go = True
                    If TextBox9.Text <> TextBox20.Text Then go = True
                    If TextBox10.Text <> TextBox19.Text Then go = True
                    If TextBox11.Text <> TextBox18.Text Then go = True
                    If TextBox12.Text <> TextBox17.Text Then go = True
                    If TextBox13.Text <> TextBox16.Text Then go = True
                    If TextBox14.Text <> TextBox15.Text Then go = True

                    Dim gogo As Boolean = True
                    If go = True Then
                        If MsgBox("There are changes in the Sold To address." + vbCrLf + "This will update the Order with the modified information." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then gogo = False

                    Else
                        'If MsgBox("WARNING! Proceed only if you have already processed the credit card." + vbCrLf + "The Credit Card number will be removed." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                    End If

                    If gogo = True Then
                        If go = True Then
                            cmd.CommandText = "update ord_file set ord_sold_name = @ord_sold_name, ord_sold_company = @ord_sold_company, ord_sold_country = @ord_sold_country, ord_sold_addr1 = @ord_sold_addr1, ord_sold_addr2 = @ord_sold_addr2, ord_sold_addr3 = @ord_sold_addr3, ord_sold_city = @ord_sold_city, ord_sold_state = @ord_sold_state, ord_sold_county = @ord_sold_county, ord_sold_zip = @ord_sold_zip, ord_sold_phone1 = @ord_sold_phone1, ord_sold_phone2 = @ord_sold_phone2, ord_sold_fax = @ord_sold_fax, ord_sold_cell = @ord_sold_cell, ord_sold_email = @ord_sold_email where ord_serial=@1"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_name", tb1.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_company", TextBox1.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_addr1", TextBox2.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_addr2", TextBox3.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_addr3", TextBox4.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_city", TextBox5.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_state", TextBox6.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_zip", TextBox7.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_county", TextBox8.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_country", TextBox9.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_phone1", TextBox10.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_phone2", TextBox11.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_fax", TextBox12.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_cell", TextBox13.Text))
                            cmd.Parameters.Add(New SqlParameter("@ord_sold_email", TextBox14.Text))

                            cmd.Parameters.Add(New SqlParameter("@1", MainOrder))
                            cnn.Open()
                            cmd.ExecuteNonQuery()
                            cnn.Close()
                        End If
                        cnn.Open()
                        cmd.CommandText = "update ord_cc_portal_soldto set cc_processed=1,cc_approved=1 where cc_serial_soldto=" + SelectedOrder
                        cmd.ExecuteNonQuery()
                        cnn.Close()
                        MsgBox("Sold To Info Processed")
                    Else
                        MsgBox("Sold To Info NOT Processed at this time.")
                    End If

                    If Label26.Text = "Bill To is same as Sold To." And Label26.Visible = True Then
                        Dim gogo3 As Boolean = True
                        If lBillWarning.Visible = True Then
                            If MsgBox("There are changes in the Bill To info." + vbCrLf + "Because there is currently no Bill To contact for this order," + vbCrLf + "We will create one and make it the Payee." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then gogo3 = False
                            If gogo3 = True Then
                                'check if contact exists. If not create new contact and link to order as payee
                                Dim IsMatch As Boolean = False
                                Dim onCont As Integer = 0
                                'Dim cName, cAddress, cCity, cState, cZip, cPhone, cEmail, cCatRes, cCatMat, cCatCom, cCompany, cFax, conType, cEmailList, cDelPref, cNotes, cCell, cProvince
                                Dim zName, zAddress, zCity, zState, zZip, zPhone, zEmail, zCompany
                                cnn.Open()
                                Try
                                    cmd.CommandText = "SELECT lower(cont_name) from cont_file where lower(cont_name)='" + LCase(Replace(Trim(txt1.Text), "'", "''")) + "' and lower(cont_addr1)='" + LCase(Replace(Trim(txt3.Text), "'", "''")) + "'"
                                    zName = nz(cmd.ExecuteScalar)

                                    'cmd.CommandText = "SELECT lower(cont_addr1) from cont_file where lower(cont_addr1)='" + LCase(Replace(Trim(cAddress), "'", "''")) + "'"
                                    'zAddress = nz(cmd.ExecuteScalar)
                                    cmd.CommandText = "SELECT cont_phone1 from cont_file where lower(cont_name)='" + LCase(Replace(Trim(txt1.Text), "'", "''")) + "' and cont_phone1='" + Replace(Trim(txt11.Text), "'", "''") + "'"
                                    zPhone = nz(cmd.ExecuteScalar)

                                    cmd.CommandText = "SELECT lower(cont_email) from cont_file where lower(cont_name)='" + LCase(Replace(Trim(txt1.Text), "'", "''")) + "' and lower(cont_email)='" + LCase(Replace(Trim(txt15.Text), "'", "''")) + "'"
                                    zEmail = nz(cmd.ExecuteScalar)

                                    If zEmail = "" Then
                                        cmd.CommandText = "SELECT lower(cont_email) from cont_file where lower(cont_email)='" + LCase(Replace(Trim(txt15.Text), "'", "''")) + "'"
                                        zEmail = nz(cmd.ExecuteScalar)
                                    End If

                                    cmd.CommandText = "SELECT lower(cont_company) from cont_file where lower(cont_name)='" + LCase(Replace(Trim(txt1.Text), "'", "''")) + "' and lower(cont_company)='" + LCase(Replace(Trim(txt2.Text), "'", "''")) + "'"
                                    zCompany = nz(cmd.ExecuteScalar)


                                    If zName <> "" Or zPhone <> "" Or zEmail <> "" Or zCompany <> "" Then
                                        IsMatch = True
                                        If zName <> "" Then
                                            cmd.CommandText = "SELECT cont_serial from cont_file where lower(cont_name)='" + LCase(Replace(Trim(txt1.Text), "'", "''")) + "' and lower(cont_addr1)='" + LCase(Replace(Trim(txt3.Text), "'", "''")) + "'"
                                            onCont = nz(cmd.ExecuteScalar)
                                            GoTo skip0
                                        End If
                                        If zPhone <> "" Then
                                            cmd.CommandText = "SELECT cont_serial from cont_file where lower(cont_name)='" + LCase(Replace(Trim(txt1.Text), "'", "''")) + "' and cont_phone1='" + Replace(Trim(txt11.Text), "'", "''") + "'"
                                            onCont = nz(cmd.ExecuteScalar)
                                            GoTo skip0
                                        End If
                                        If zEmail <> "" Then
                                            cmd.CommandText = "SELECT cont_serial from cont_file where lower(cont_name)='" + LCase(Replace(Trim(txt1.Text), "'", "''")) + "' and lower(cont_email)='" + LCase(Replace(Trim(txt15.Text), "'", "''")) + "'"
                                            onCont = nz(cmd.ExecuteScalar, 0)

                                            If onCont = 0 Then
                                                cmd.CommandText = "SELECT cont_serial from cont_file where lower(cont_email)='" + LCase(Replace(Trim(txt15.Text), "'", "''")) + "'"
                                                onCont = nz(cmd.ExecuteScalar)
                                            End If
                                            GoTo skip0
                                        End If
                                        If zCompany <> "" Then
                                            cmd.CommandText = "SELECT cont_serial from cont_file where lower(cont_name)='" + LCase(Replace(Trim(txt1.Text), "'", "''")) + "' and lower(cont_company)='" + LCase(Replace(Trim(txt2.Text), "'", "''")) + "'"
                                            onCont = nz(cmd.ExecuteScalar)
                                            GoTo skip0
                                        End If
                                    Else


                                    End If
skip0:
                                Catch

                                Finally
                                    cnn.Close()
                                End Try

                                If IsMatch = False Then
                                    Try
                                        cnn.Open()
                                        cmd.CommandText = "insert into cont_file (cont_province,cont_type,cont_name,cont_company,cont_addr1,cont_addr2,cont_addr3,cont_city,cont_state,cont_zip," + _
                                        "last_update,update_by,inactive,cont_status,cont_next_call_by,cont_email,cont_phone1,cont_phone2,cont_cell,cont_fax,cont_county,cont_country) values" + _
                                        "('" + "" + "','Individual','" + Replace(txt1.Text, "'", "''") + "','" + Replace(txt2.Text, "'", "''") + "','" + _
                                        Replace(txt3.Text, "'", "''") + "','" + Replace(txt4.Text, "'", "''") + "','" + Replace(txt5.Text, "'", "''") + "','" + Replace(txt6.Text, "'", "''") + "','" + _
                                        Replace(txt7.Text, "'", "''") + "','" + Replace(txt8.Text, "'", "''") + "','" + Now.ToString + "','System','0','','MGR','" + _
                                        Replace(txt15.Text, "'", "''") + "','" + Replace(txt11.Text, "'", "''") + "','" + Replace(txt12.Text, "'", "''") + "','" + Replace(txt14.Text, "'", "''") + "','" + Replace(txt13.Text, "'", "''") + "','" + _
                                        Replace(txt9.Text, "'", "''") + "','" + Replace(txt10.Text, "'", "''") + "')"
                                        cmd.ExecuteNonQuery()
                                        cmd.CommandText = "select @@IDENTITY as jid"
                                        onCont = cmd.ExecuteScalar
                                        'cmd.CommandText = "insert into cont_src (cont_src_cont_serial,cont_src_ord_src) values(" + onCont.ToString + ",'INT-UNKNOWN')"
                                        'cmd.ExecuteNonQuery()
                                        'cmd.CommandText = "insert into cont_note (cont_note_user,cont_note_cont_serial,cont_note_date,cont_note,cont_note_type) values('" + _
                                        '"System" + "'," + onCont.ToString + ",'" + Now.ToString + "','','System')"
                                        cmd.ExecuteNonQuery()
                                    Catch
                                        MsgBox("1. " + Err.Description.ToString)
                                    Finally
                                        cnn.Close()
                                    End Try
                                Else
                                    Try
                                        cmd.CommandText = "update cont_file set cont_name = @cont_name, cont_company = @cont_company, cont_country = @cont_country, cont_addr1 = @cont_addr1, cont_addr2 = @cont_addr2, cont_addr3 = @cont_addr3, cont_city = @cont_city, cont_state = @cont_state, cont_zip = @cont_zip, cont_county = @cont_county, cont_email = @cont_email, cont_phone1 = @cont_phone1, cont_phone2 = @cont_phone2, cont_cell = @cont_cell, cont_fax = @cont_fax where cont_serial=@1"
                                        cmd.Parameters.Clear()
                                        cmd.Parameters.Add(New SqlParameter("@cont_name", txt1.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_company", txt2.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_country", txt10.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_addr1", txt3.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_addr2", txt4.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_addr3", txt5.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_city", txt6.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_state", txt7.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_zip", txt8.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_county", txt9.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_email", txt15.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_phone1", txt11.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_phone2", txt12.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_cell", txt14.Text))
                                        cmd.Parameters.Add(New SqlParameter("@cont_fax", txt13.Text))

                                        cmd.Parameters.Add(New SqlParameter("@1", onCont))
                                        cnn.Open()
                                        cmd.ExecuteNonQuery()

                                        'Dim dss As New DataSet
                                        'cmd.CommandText = "SELECT cont_src_ord_src from cont_src where cont_src_cont_serial=" + onCont.ToString
                                        'da.Fill(dss)
                                        'If dss.Tables(0).Rows.Count < 1 Then
                                        '    cmd.CommandText = "insert into cont_src (cont_src_cont_serial,cont_src_ord_src) values(" + onCont.ToString + ",'INT-UNKNOWN')"
                                        '    cmd.ExecuteNonQuery()
                                        'Else
                                        '    Dim ngo As Boolean = False
                                        '    For Each rw In dss.Tables(0).Rows
                                        '        If rw("cont_src_ord_src") = "INT-UNKNOWN" Then
                                        '            ngo = True
                                        '        End If
                                        '    Next
                                        '    If ngo = False Then
                                        '        cmd.CommandText = "insert into cont_src (cont_src_cont_serial,cont_src_ord_src) values(" + onCont.ToString + ",'INT-UNKNOWN')"
                                        '        cmd.ExecuteNonQuery()
                                        '    End If
                                        'End If
                                        'dss.Clear()
                                    Catch
                                        MsgBox("2. " + Err.Description.ToString)
                                    Finally
                                        cnn.Close()
                                    End Try
                                End If
                                Try
                                    cmd.CommandTimeout = 0
                                    cmd.CommandText = "insert into ord_cont (ord_cont_ord_serial,ord_cont_cont_serial,ord_cont_note,ord_cont_payee) values(@ord_cont_ord_serial,@ord_cont_cont_serial,@ord_cont_note,@ord_cont_payee)"
                                    cmd.Parameters.Clear()
                                    cmd.Parameters.Add(New SqlParameter("@ord_cont_ord_serial", MainOrder))
                                    cmd.Parameters.Add(New SqlParameter("@ord_cont_cont_serial", onCont))
                                    cmd.Parameters.Add(New SqlParameter("@ord_cont_note", "PAYEE FOR " + TextBox33.Text))
                                    cmd.Parameters.AddWithValue("@ord_cont_payee", Convert.ToByte(True)).DbType = SqlDbType.Bit

                                    cnn.Open()
                                    cmd.ExecuteNonQuery()
                                Catch
                                    MsgBox(Err.Description)
                                Finally
                                    cnn.Close()
                                End Try
                                If IsMatch = False Then
                                    MsgBox("A new contact has been created and linked to this order as the Payee.")
                                Else
                                    'If contact exists. Link contact to order.
                                    MsgBox("This is an existing contact and it has been linked to this order as the Payee.")
                                End If
                            End If
                        End If
                    Else
                        Dim go2 As Boolean = False
                        If txt1.Text <> TextBox62.Text Then go2 = True
                        If txt2.Text <> TextBox60.Text Then go2 = True
                        If txt3.Text <> TextBox59.Text Then go2 = True
                        If txt4.Text <> TextBox55.Text Then go2 = True
                        If txt5.Text <> TextBox53.Text Then go2 = True
                        If txt6.Text <> TextBox49.Text Then go2 = True
                        If txt7.Text <> TextBox48.Text Then go2 = True
                        If txt8.Text <> TextBox46.Text Then go2 = True
                        If txt9.Text <> TextBox43.Text Then go2 = True
                        If txt10.Text <> TextBox42.Text Then go2 = True
                        If txt11.Text <> TextBox39.Text Then go2 = True
                        If txt12.Text <> TextBox38.Text Then go2 = True
                        If txt13.Text <> TextBox36.Text Then go2 = True
                        If txt14.Text <> TextBox34.Text Then go2 = True
                        If txt15.Text <> TextBox32.Text Then go2 = True

                        Dim gogo2 As Boolean = True
                        If go2 = True Then
                            If MsgBox("There are changes in the Bill To info." + vbCrLf + "This will update the Order with the modified information." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then gogo2 = False
                            'Update the existing contact info
                            If gogo2 = True Then
                                cmd.CommandText = "update cont_file set cont_name = @cont_name, cont_company = @cont_company, cont_country = @cont_country, cont_addr1 = @cont_addr1, cont_addr2 = @cont_addr2, cont_addr3 = @cont_addr3, cont_city = @cont_city, cont_state = @cont_state, cont_zip = @cont_zip, cont_county = @cont_county, cont_email = @cont_email, cont_phone1 = @cont_phone1, cont_phone2 = @cont_phone2, cont_cell = @cont_cell, cont_fax = @cont_fax where cont_serial=@1"
                                cmd.Parameters.Clear()
                                cmd.Parameters.Add(New SqlParameter("@cont_name", txt1.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_company", txt2.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_country", txt10.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_addr1", txt3.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_addr2", txt4.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_addr3", txt5.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_city", txt6.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_state", txt7.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_zip", txt8.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_county", txt9.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_email", txt15.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_phone1", txt11.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_phone2", txt12.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_cell", txt14.Text))
                                cmd.Parameters.Add(New SqlParameter("@cont_fax", txt13.Text))

                                cmd.Parameters.Add(New SqlParameter("@1", BillToContact))
                                cnn.Open()
                                cmd.ExecuteNonQuery()
                                cnn.Close()
                                MsgBox("Bill To Info Processed")

                            Else
                                'If MsgBox("WARNING! Proceed only if you have already processed the credit card." + vbCrLf + "The Credit Card number will be removed." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                                MsgBox("Bill To Info NOT Processed")
                            End If
                        End If
                    End If


                End If
                '*******************************

                If InStr(Label52.Text, "Ship") Then
                    Dim go As Boolean = False
                    If tb1.Text <> TextBox29.Text Then go = True
                    If TextBox1.Text <> TextBox28.Text Then go = True
                    If TextBox2.Text <> TextBox27.Text Then go = True
                    If TextBox3.Text <> TextBox26.Text Then go = True
                    If TextBox4.Text <> TextBox25.Text Then go = True
                    If TextBox5.Text <> TextBox24.Text Then go = True
                    If TextBox6.Text <> TextBox23.Text Then go = True
                    If TextBox7.Text <> TextBox22.Text Then go = True
                    If TextBox8.Text <> TextBox21.Text Then go = True
                    If TextBox9.Text <> TextBox20.Text Then go = True
                    If TextBox10.Text <> TextBox19.Text Then go = True
                    If TextBox11.Text <> TextBox18.Text Then go = True
                    If TextBox12.Text <> TextBox17.Text Then go = True
                    If TextBox13.Text <> TextBox16.Text Then go = True
                    If TextBox14.Text <> TextBox15.Text Then go = True

                    Dim gogo As Boolean = True
                    If go = True Then
                        If MsgBox("There are changes in the Ship To address." + vbCrLf + "This will update the Order with the modified information." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then gogo = False

                    Else
                        'If MsgBox("WARNING! Proceed only if you have already processed the credit card." + vbCrLf + "The Credit Card number will be removed." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                    End If
                    Dim zz As String = Label52.Text.Split(" ")(2)
                    Dim zord As String = zz.Split("-")(0)
                    Dim zfromrev As String = zz.Split("-")(1)
                    Dim zrev As String = zz.Split("-")(2)
                    If gogo = True Then
                        If go = True Then
                            If Label26.Text = "This is an alternate shipping address." And Label26.Visible = True Then
                                cmd.CommandText = "update ord_alt_ship set ord_alt_ship_name = @ord_alt_ship_name, ord_alt_ship_company = @ord_alt_ship_company, ord_alt_ship_country = @ord_alt_ship_country, ord_alt_ship_addr1 = @ord_alt_ship_addr1, ord_alt_ship_addr2 = @ord_alt_ship_addr2, ord_alt_ship_addr3 = @ord_alt_ship_addr3, ord_alt_ship_city = @ord_alt_ship_city, ord_alt_ship_state = @ord_alt_ship_state, ord_alt_ship_county = @ord_alt_ship_county, ord_alt_ship_zip = @ord_alt_ship_zip, ord_alt_ship_phone1 = @ord_alt_ship_phone1, ord_alt_ship_phone2 = @ord_alt_ship_phone2, ord_alt_ship_fax = @ord_alt_ship_fax, ord_alt_ship_cell = @ord_alt_ship_cell, ord_alt_ship_email = @ord_alt_ship_email where ord_alt_ship_ord_serial=@1 and ord_alt_ship_rev=@2 and ord_alt_ship_type='O'"
                                cmd.Parameters.Clear()

                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_name", tb1.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_company", TextBox1.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_addr1", TextBox2.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_addr2", TextBox3.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_addr3", TextBox4.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_city", TextBox5.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_state", TextBox6.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_zip", TextBox7.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_county", TextBox8.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_country", TextBox9.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_phone1", TextBox10.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_phone2", TextBox11.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_fax", TextBox12.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_cell", TextBox13.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_alt_ship_email", TextBox14.Text))

                                cmd.Parameters.Add(New SqlParameter("@1", zord))
                                cmd.Parameters.Add(New SqlParameter("@2", zrev))
                                cnn.Open()
                                cmd.ExecuteNonQuery()
                                cnn.Close()
                            Else
                                'TODO: issue with state field truncating to 2 char (need to either updated DB or restrict input)
                                cmd.CommandText = "update ord_gen set ord_gen_ship_name = @ord_gen_ship_name, ord_gen_ship_company = @ord_gen_ship_company, ord_gen_ship_country = @ord_gen_ship_country, ord_gen_ship_addr1 = @ord_gen_ship_addr1, ord_gen_ship_addr2 = @ord_gen_ship_addr2, ord_gen_ship_addr3 = @ord_gen_ship_addr3, ord_gen_ship_city = @ord_gen_ship_city, ord_gen_ship_state = @ord_gen_ship_state, ord_gen_ship_county = @ord_gen_ship_county, ord_gen_ship_zip = @ord_gen_ship_zip, ord_gen_ship_phone1 = @ord_gen_ship_phone1, ord_gen_ship_phone2 = @ord_gen_ship_phone2, ord_gen_ship_fax = @ord_gen_ship_fax, ord_gen_ship_cell = @ord_gen_ship_cell, ord_gen_ship_email = @ord_gen_ship_email where ord_gen_ord_serial=@1 and ord_gen_type='O' and ord_gen_rev=@2 and ord_gen_from_rev=@3"
                                cmd.Parameters.Clear()
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_name", tb1.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_company", TextBox1.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_addr1", TextBox2.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_addr2", TextBox3.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_addr3", TextBox4.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_city", TextBox5.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_state", TextBox6.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_zip", TextBox7.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_county", TextBox8.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_country", TextBox9.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_phone1", TextBox10.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_phone2", TextBox11.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_fax", TextBox12.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_cell", TextBox13.Text))
                                cmd.Parameters.Add(New SqlParameter("@ord_gen_ship_email", TextBox14.Text))

                                cmd.Parameters.Add(New SqlParameter("@1", zord))
                                cmd.Parameters.Add(New SqlParameter("@2", zrev))
                                cmd.Parameters.Add(New SqlParameter("@3", zfromrev))
                                cnn.Open()
                                cmd.ExecuteNonQuery()
                                cnn.Close()
                            End If
                        End If
                        cnn.Open()
                        cmd.CommandText = "update ord_cc_portal_shipto set cc_ship_processed=1,cc_approved=1 where cc_serial_shipto=" + SelectedOrder
                        cmd.ExecuteNonQuery()
                        cnn.Close()
                        MsgBox("Shipping Info Processed")
                    Else
                        MsgBox("Shipping Info NOT Processed at this time.")
                    End If
                End If
                Me.Width = 505
                Me.Height = 563
                ClearBoxes()
                DataGridView1.ClearSelection()
                LoadList()
            End If
        Catch
            MsgBox(Err.Description)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If IsNumeric(SelectedOrder) Then
                If InStr(Label52.Text, "Payment") Then
                    cnn.Open()
                    cmd.CommandText = "update ord_cc_portal_payment set cc_pay_processed=1, cc_pay_approved=0 where cc_pay_serial=" + SelectedOrder
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                    MsgBox("Payment has been Denied")
                    MsgBox("Please notify customer that payment has been denied.")
                End If
                If InStr(Label52.Text, "Bill/Sold") Then
                    cnn.Open()
                    cmd.CommandText = "update ord_cc_portal_soldto set cc_processed=1, cc_approved=0 where cc_serial_soldto=" + SelectedOrder
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                    MsgBox("Bill/Sold Info has been Denied")
                End If
                If InStr(Label52.Text, "Ship") Then
                    cnn.Open()
                    cmd.CommandText = "update ord_cc_portal_shipto set cc_ship_processed=1, cc_approved=0 where cc_serial_shipto=" + SelectedOrder
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                    MsgBox("Shipping Info has been Denied")
                End If
                Me.Width = 505
                Me.Height = 563
                ClearBoxes()
                DataGridView1.ClearSelection()
                LoadList()
            End If
        Catch
            MsgBox(Err.Description)
        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub Save_After()
        Try
            Dim x As Integer
            'Dim cmd As New SqlCommand
            'Dim Trans As SqlTransaction
            Dim Pay As Double
            'Dim row As DataRow
            Dim dr As SqlDataReader
            cmd.CommandTimeout = 0
            cnn.Open()
            cmd.CommandText = "select ord_sold_cust_id from ord_file where ord_serial=" + DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            Dim cid = nz(cmd.ExecuteScalar)
            Dim cid2, ky, ky2
            If TextBox44.Text = "Credit Card" And TextBox50.Text = "American Express" Then
                Dim val2 As Double
                Dim val3 As Double
                Dim val As Double = CDbl(TextBox47.Text)
                If val <= 10000 Then
                    val2 = Math.Round(val - (val * 0.029), 2)
                    val3 = Math.Round((val * 0.029), 2)
                Else
                    val2 = Math.Round(val - ((val * 0.029) - (val * 0.005)), 2)
                    val3 = Math.Round(((val * 0.029) - (val * 0.005)), 2)
                End If
                '*******AMEX charge******************************
                cmd.CommandText = "insert into pay_file (pay_cust_id,pay_date,pay_amt,pay_method,pay_num,pay_exp_date,pay_auth_code,Last_Update,Update_By,pay_applied,pay_sec_code) values(@pay_cust_id,@pay_date,@pay_amt,@pay_method,@pay_num,@pay_exp_date,@pay_auth_code,@Last_Update,@Update_By,@pay_applied,@pay_sec_code)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@pay_cust_id", cid))
                cmd.Parameters.Add(New SqlParameter("@pay_date", Now))
                cmd.Parameters.Add(New SqlParameter("@pay_amt", val2))
                cmd.Parameters.Add(New SqlParameter("@pay_method", TextBox50.Text))
                cmd.Parameters.Add(New SqlParameter("@pay_num", Microsoft.VisualBasic.Right(TextBox54.Text, 4)))
                cmd.Parameters.Add(New SqlParameter("@pay_exp_date", TextBox56.Text))
                cmd.Parameters.Add(New SqlParameter("@pay_auth_code", tAuthCode.Text))
                cmd.Parameters.Add(New SqlParameter("@Last_Update", Now))
                cmd.Parameters.Add(New SqlParameter("@Update_By", Jcom.User))
                cmd.Parameters.Add(New SqlParameter("@pay_applied", Now))
                cmd.Parameters.Add(New SqlParameter("@pay_sec_code", TextBox58.Text))
                cmd.ExecuteNonQuery()
                cmd.CommandText = "select @@IDENTITY as jid"
                ky = cmd.ExecuteScalar
                Dim zord As String = TextBox33.Text.Split("-")(0)
                Dim zfromrev As String = TextBox33.Text.Split("-")(1)
                Dim zrev As String = TextBox33.Text.Split("-")(2)
                cmd.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + zord.ToString + " and ord_gen_from_rev=" + zfromrev.ToString + " and ord_gen_rev=" + zrev.ToString + " and ord_gen_type='O'"
                cid2 = nz(cmd.ExecuteScalar)

                cmd.CommandText = "insert into pay_itm (pay_itm_pay_serial,pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,pay_itm_amt) values ("
                cmd.CommandText = cmd.CommandText + ky.ToString + ","
                cmd.CommandText = cmd.CommandText + CStr(cid2) + ","
                cmd.CommandText = cmd.CommandText + CStr(zord) + ","
                cmd.CommandText = cmd.CommandText + CStr(zrev) + ","
                cmd.CommandText = cmd.CommandText + CStr(val2) + ")"
                cmd.ExecuteNonQuery()

                '*******AMEX surcharge******************************
                cmd.CommandText = "insert into pay_file (pay_cust_id,pay_date,pay_amt,pay_method,pay_num,pay_exp_date,pay_auth_code,Last_Update,Update_By,pay_applied,pay_sec_code) values(@pay_cust_id,@pay_date,@pay_amt,@pay_method,@pay_num,@pay_exp_date,@pay_auth_code,@Last_Update,@Update_By,@pay_applied,@pay_sec_code)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@pay_cust_id", cid))
                cmd.Parameters.Add(New SqlParameter("@pay_date", Now))
                cmd.Parameters.Add(New SqlParameter("@pay_amt", val3))
                cmd.Parameters.Add(New SqlParameter("@pay_method", "Surcharge-AMEX"))
                cmd.Parameters.Add(New SqlParameter("@pay_num", ""))
                cmd.Parameters.Add(New SqlParameter("@pay_exp_date", ""))
                cmd.Parameters.Add(New SqlParameter("@pay_auth_code", ""))
                cmd.Parameters.Add(New SqlParameter("@Last_Update", Now))
                cmd.Parameters.Add(New SqlParameter("@Update_By", Jcom.User))
                cmd.Parameters.Add(New SqlParameter("@pay_applied", Now))
                cmd.Parameters.Add(New SqlParameter("@pay_sec_code", ""))
                cmd.ExecuteNonQuery()
                cmd.CommandText = "select @@IDENTITY as jid"
                ky2 = cmd.ExecuteScalar
                cmd.CommandText = "insert into pay_itm (pay_itm_pay_serial,pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,pay_itm_amt) values ("
                cmd.CommandText = cmd.CommandText + ky2.ToString + ","
                cmd.CommandText = cmd.CommandText + CStr(cid2) + ","
                cmd.CommandText = cmd.CommandText + CStr(zord) + ","
                cmd.CommandText = cmd.CommandText + CStr(zrev) + ","
                cmd.CommandText = cmd.CommandText + CStr(val3) + ")"
                cmd.ExecuteNonQuery()
            Else
                '******************
                cmd.CommandText = "insert into pay_file (pay_cust_id,pay_date,pay_amt,pay_method,pay_num,pay_exp_date,pay_auth_code,Last_Update,Update_By,pay_applied,pay_sec_code) values(@pay_cust_id,@pay_date,@pay_amt,@pay_method,@pay_num,@pay_exp_date,@pay_auth_code,@Last_Update,@Update_By,@pay_applied,@pay_sec_code)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@pay_cust_id", cid))
                cmd.Parameters.Add(New SqlParameter("@pay_date", Now))
                cmd.Parameters.Add(New SqlParameter("@pay_amt", TextBox47.Text))
                Dim tp As String
                If TextBox44.Text <> "Credit Card" Then
                    tp = TextBox44.Text
                Else
                    tp = TextBox50.Text
                End If
                cmd.Parameters.Add(New SqlParameter("@pay_method", tp))
                cmd.Parameters.Add(New SqlParameter("@pay_num", Microsoft.VisualBasic.Right(TextBox54.Text, 4)))
                cmd.Parameters.Add(New SqlParameter("@pay_exp_date", TextBox56.Text))
                cmd.Parameters.Add(New SqlParameter("@pay_auth_code", tAuthCode.Text))
                cmd.Parameters.Add(New SqlParameter("@Last_Update", Now))
                cmd.Parameters.Add(New SqlParameter("@Update_By", Jcom.User))
                cmd.Parameters.Add(New SqlParameter("@pay_applied", Now))
                cmd.Parameters.Add(New SqlParameter("@pay_sec_code", TextBox58.Text))
                cmd.ExecuteNonQuery()
                cmd.CommandText = "select @@IDENTITY as jid"
                ky = cmd.ExecuteScalar
                Dim zord As String = TextBox33.Text.Split("-")(0)
                Dim zfromrev As String = TextBox33.Text.Split("-")(1)
                Dim zrev As String = TextBox33.Text.Split("-")(2)
                cmd.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + zord.ToString + " and ord_gen_from_rev=" + zfromrev.ToString + " and ord_gen_rev=" + zrev.ToString + " and ord_gen_type='O'"
                cid2 = nz(cmd.ExecuteScalar)

                cmd.CommandText = "insert into pay_itm (pay_itm_pay_serial,pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,pay_itm_amt) values ("
                cmd.CommandText = cmd.CommandText + ky.ToString + ","
                cmd.CommandText = cmd.CommandText + CStr(cid2) + ","
                cmd.CommandText = cmd.CommandText + CStr(zord) + ","
                cmd.CommandText = cmd.CommandText + CStr(zrev) + ","
                cmd.CommandText = cmd.CommandText + CStr(TextBox47.Text) + ")"
                cmd.ExecuteNonQuery()
                '******************
            End If

            If TextBox47.Text <> 0 Then
                cmd.CommandText = "select sum(pay_itm_amt) as pay from pay_itm where pay_itm_ord_gen_serial=" + CStr(cid2)
                Pay = cmd.ExecuteScalar
                Do While cnn.State = ConnectionState.Executing
                Loop
                cmd.CommandText = "update ord_gen set ord_gen_balance=ord_gen_total - (" + CStr(Pay) + ") where ord_gen_serial=" + CStr(cid2)
                cmd.ExecuteNonQuery()
                Do While cnn.State = ConnectionState.Executing
                Loop
                cmd.CommandText = "select ord_gen_ord_serial,ord_gen_rev,ord_gen_type from ord_gen where ord_gen_serial=" + CStr(cid2)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    'If tMeth.Text = "Balance Transfer" Then
                    '    CheckRefTransfer(dr("ord_gen_ord_serial"), dr("ord_gen_rev"), dr("ord_gen_type"), KeyValue1, row("amount"))
                    'Else
                    CheckReferral(dr("ord_gen_ord_serial"), dr("ord_gen_rev"), dr("ord_gen_type"), TextBox44.Text, ky)
                    'End If
                End If
                dr.Close()
                SetCommission(CStr(ky))
                'BalanceCheck("Payment Save_after " + cmd.CommandText)
            End If
        Catch
            'Trans.Rollback()
            DoError(Err, MainForm)
        Finally
            If cnn.State <> ConnectionState.Closed Then cnn.Close()
        End Try
    End Sub


    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If ActiveControl Is DataGridView1 Then
            tAuthCode.Text = ""
            Me.Cursor = Cursors.WaitCursor
            Dim dt2 As New DataTable
            Label26.Visible = False
            If DataGridView1.SelectedRows.Count = 0 Then
                Exit Sub
            End If
            lBillWarning.Visible = False
            SelectedOrder = DataGridView1.SelectedRows(0).Cells(3).Value.ToString  'ListView1.SelectedItems(0).SubItems(3).Text
            MainOrder = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            SubOrder = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            Label51.Visible = False
            TextBox47.BackColor = Color.Honeydew
            Try
                bClear()
                bClear2()
                'Dim wd As Integer
                'Dim hd As Integer
                Button1.Enabled = True
                cnn.Open()
                If DataGridView1.SelectedRows(0).Cells(0).Value = "Payment" Then
                    Label52.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString + " " + DataGridView1.SelectedRows(0).Cells(0).Value.ToString   'ListView1.SelectedItems(0).SubItems(0).Text + "  " + ListView1.SelectedItems(0).SubItems(1).Text + "  " + ListView1.SelectedItems(0).SubItems(2).Text

                    Label49.Visible = False
                    Label50.Visible = False
                    Me.Width = 860
                    Me.Height = 563
                    GroupBox1.Visible = False
                    GroupBox3.Visible = False
                    GroupBox4.Visible = False
                    GroupBox2.Visible = True
                    'GroupBox2.Left = 324
                    'GroupBox2.Top = 33
                    cmd.CommandText = "SELECT  * from ord_cc_portal_payment where cc_pay_serial=" + DataGridView1.SelectedRows(0).Cells(3).Value.ToString
                    da.Fill(dt2)
                    If dt2.Rows(0).Item("cc_pay_processed") Then
                        MsgBox("This payment has already been processed.")
                        Button1.Enabled = False
                    End If
                    TextBox33.Text = dt2.Rows(0).Item("cc_pay_order_list")
                    TextBox37.Text = Math.Round(dt2.Rows(0).Item("cc_pay_tot_value"), 2)
                    TextBox40.Text = Math.Round(dt2.Rows(0).Item("cc_pay_payments"), 2)
                    TextBox30.Text = Math.Round(dt2.Rows(0).Item("cc_pay_balance"), 2)
                    TextBox44.Text = dt2.Rows(0).Item("cc_pay_pay_type")
                    If TextBox44.Text = "Credit Card" Then
                        GroupBox3.Visible = True
                    End If
                    TextBox47.Text = Math.Round(dt2.Rows(0).Item("cc_pay_amt_applied"), 2)
                    TextBox50.Text = dt2.Rows(0).Item("cc_pay_card_type")
                    TextBox52.Text = dt2.Rows(0).Item("cc_pay_name")
                    If dt2.Rows(0).Item("cc_pay_card_number") <> "" Then TextBox54.Text = jDecrypt(dt2.Rows(0).Item("cc_pay_card_number")) Else TextBox54.Text = ""

                    TextBox56.Text = dt2.Rows(0).Item("cc_pay_expiration")
                    TextBox58.Text = dt2.Rows(0).Item("cc_pay_security")
                    'Label19.Text = "Submitted: " + dt2.Rows(0).Item("cc_pay_submitted").ToString
                    Label29.Text = "Terms Agreed: " + dt2.Rows(0).Item("cc_pay_terms_agreed_date").ToString

                    If CDbl(TextBox47.Text) < CDbl(TextBox30.Text) Then
                        Label51.Visible = True
                        TextBox47.BackColor = Color.MistyRose
                    End If

                End If
                '*****************************

                If DataGridView1.SelectedRows(0).Cells(0).Value = "Bill/Sold" Then
                    Label52.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString + " " + DataGridView1.SelectedRows(0).Cells(0).Value.ToString   'ListView1.SelectedItems(0).SubItems(0).Text + "  " + ListView1.SelectedItems(0).SubItems(1).Text + "  " + ListView1.SelectedItems(0).SubItems(2).Text

                    Label49.Visible = True
                    Label50.Visible = True
                    dt2.Clear()
                    cmd.CommandText = "SELECT  * from ord_cc_portal_soldto where cc_serial_soldto=" + DataGridView1.SelectedRows(0).Cells(3).Value.ToString
                    da.Fill(dt2)
                    lBillWarning.Visible = False

                    If dt2.Rows(0).Item("cc_processed") Then
                        MsgBox("This bill to / sold to info has already been processed.")
                        Button1.Enabled = False
                    End If
                    BillToContact = dt2.Rows(0).Item("cc_bill_contact_serial")
                    SoldToContact = dt2.Rows(0).Item("cc_sold_contact_serial")
                    tb1.Text = dt2.Rows(0).Item("cc_sold_name")
                    TextBox1.Text = dt2.Rows(0).Item("cc_sold_company")
                    TextBox2.Text = dt2.Rows(0).Item("cc_sold_addr1")
                    TextBox3.Text = dt2.Rows(0).Item("cc_sold_addr2")
                    TextBox4.Text = dt2.Rows(0).Item("cc_sold_addr3")
                    TextBox5.Text = dt2.Rows(0).Item("cc_sold_city")
                    TextBox6.Text = dt2.Rows(0).Item("cc_sold_state")
                    TextBox7.Text = dt2.Rows(0).Item("cc_sold_zip")
                    TextBox8.Text = dt2.Rows(0).Item("cc_sold_county")
                    TextBox9.Text = dt2.Rows(0).Item("cc_sold_country")
                    TextBox10.Text = dt2.Rows(0).Item("cc_sold_ph1")
                    TextBox11.Text = dt2.Rows(0).Item("cc_sold_ph2")
                    TextBox12.Text = dt2.Rows(0).Item("cc_sold_fax")
                    TextBox13.Text = dt2.Rows(0).Item("cc_sold_cell")
                    TextBox14.Text = dt2.Rows(0).Item("cc_sold_email")

                    txt1.Text = dt2.Rows(0).Item("cc_bill_name")
                    txt2.Text = dt2.Rows(0).Item("cc_bill_company")
                    txt3.Text = dt2.Rows(0).Item("cc_bill_addr1")
                    txt4.Text = dt2.Rows(0).Item("cc_bill_addr2")
                    txt5.Text = dt2.Rows(0).Item("cc_bill_addr3")
                    txt6.Text = dt2.Rows(0).Item("cc_bill_city")
                    txt7.Text = dt2.Rows(0).Item("cc_bill_state")
                    txt8.Text = dt2.Rows(0).Item("cc_bill_zip")
                    txt9.Text = dt2.Rows(0).Item("cc_bill_county")
                    txt10.Text = dt2.Rows(0).Item("cc_bill_country")
                    txt11.Text = dt2.Rows(0).Item("cc_bill_ph1")
                    txt12.Text = dt2.Rows(0).Item("cc_bill_ph2")
                    txt13.Text = dt2.Rows(0).Item("cc_bill_fax")
                    txt14.Text = dt2.Rows(0).Item("cc_bill_cell")
                    txt15.Text = dt2.Rows(0).Item("cc_bill_email")
                    If dt2.Rows(0).Item("cc_modified_billto") = True Then
                        'bMod()
                        'bMod2()
                    Else
                        bGood()
                        bGood2()
                    End If



                    Dim dt9 As New DataTable
                    cmd.CommandText = "SELECT  * from ord_file where ord_serial=" + DataGridView1.SelectedRows(0).Cells(2).Value.ToString
                    da.Fill(dt9)
                    If dt9.Rows.Count > 0 Then
                        TextBox29.Text = dt9.Rows(0).Item("ord_sold_name")
                        TextBox28.Text = dt9.Rows(0).Item("ord_sold_company")
                        TextBox27.Text = dt9.Rows(0).Item("ord_sold_addr1")
                        TextBox26.Text = dt9.Rows(0).Item("ord_sold_addr2")
                        TextBox25.Text = dt9.Rows(0).Item("ord_sold_addr3")
                        TextBox24.Text = dt9.Rows(0).Item("ord_sold_city")
                        TextBox23.Text = dt9.Rows(0).Item("ord_sold_state")
                        TextBox22.Text = dt9.Rows(0).Item("ord_sold_zip")
                        TextBox21.Text = dt9.Rows(0).Item("ord_sold_county")
                        TextBox20.Text = dt9.Rows(0).Item("ord_sold_country")
                        TextBox19.Text = dt9.Rows(0).Item("ord_sold_phone1")
                        TextBox18.Text = dt9.Rows(0).Item("ord_sold_phone2")
                        TextBox17.Text = dt9.Rows(0).Item("ord_sold_fax")
                        TextBox16.Text = dt9.Rows(0).Item("ord_sold_cell")
                        TextBox15.Text = dt9.Rows(0).Item("ord_sold_email")

                        If tb1.Text <> TextBox29.Text Then tb1.BackColor = Color.MistyRose Else tb1.BackColor = Color.PaleGreen
                        If TextBox1.Text <> TextBox28.Text Then TextBox1.BackColor = Color.MistyRose Else TextBox1.BackColor = Color.PaleGreen
                        If TextBox2.Text <> TextBox27.Text Then TextBox2.BackColor = Color.MistyRose Else TextBox2.BackColor = Color.PaleGreen
                        If TextBox3.Text <> TextBox26.Text Then TextBox3.BackColor = Color.MistyRose Else TextBox3.BackColor = Color.PaleGreen
                        If TextBox4.Text <> TextBox25.Text Then TextBox4.BackColor = Color.MistyRose Else TextBox4.BackColor = Color.PaleGreen
                        If TextBox5.Text <> TextBox24.Text Then TextBox5.BackColor = Color.MistyRose Else TextBox5.BackColor = Color.PaleGreen
                        If TextBox6.Text <> TextBox23.Text Then TextBox6.BackColor = Color.MistyRose Else TextBox6.BackColor = Color.PaleGreen
                        If TextBox7.Text <> TextBox22.Text Then TextBox7.BackColor = Color.MistyRose Else TextBox7.BackColor = Color.PaleGreen
                        If TextBox8.Text <> TextBox21.Text Then TextBox8.BackColor = Color.MistyRose Else TextBox8.BackColor = Color.PaleGreen
                        If TextBox9.Text <> TextBox20.Text Then TextBox9.BackColor = Color.MistyRose Else TextBox9.BackColor = Color.PaleGreen
                        If TextBox10.Text <> TextBox19.Text Then TextBox10.BackColor = Color.MistyRose Else TextBox10.BackColor = Color.PaleGreen
                        If TextBox11.Text <> TextBox18.Text Then TextBox11.BackColor = Color.MistyRose Else TextBox11.BackColor = Color.PaleGreen
                        If TextBox12.Text <> TextBox17.Text Then TextBox12.BackColor = Color.MistyRose Else TextBox12.BackColor = Color.PaleGreen
                        If TextBox13.Text <> TextBox16.Text Then TextBox13.BackColor = Color.MistyRose Else TextBox13.BackColor = Color.PaleGreen
                        If TextBox14.Text <> TextBox15.Text Then TextBox14.BackColor = Color.MistyRose Else TextBox14.BackColor = Color.PaleGreen


                    End If

                    If dt2.Rows(0).Item("cc_bill_contact_from") = "soldid" Then
                        Me.Width = 1075
                        Me.Height = 563
                        GroupBox4.Visible = False
                        Label26.Visible = True
                        Label26.Text = "Bill To is same as Sold To."
                        If nz(dt2.Rows(0).Item("cc_modified_billto"), False) = True Then
                            GroupBox4.Visible = True
                            GroupBox4.Width = 310
                            GroupBox4.Left = 488
                            GroupBox4.Top = 474
                            Me.Height = 953
                            lBillWarning.Visible = True
                            lBillWarning.Left = 820
                            lBillWarning.Top = 500
                            If txt1.Text <> TextBox29.Text Then txt1.BackColor = Color.MistyRose Else txt1.BackColor = Color.PaleGreen
                            If txt2.Text <> TextBox28.Text Then txt2.BackColor = Color.MistyRose Else txt2.BackColor = Color.PaleGreen
                            If txt3.Text <> TextBox27.Text Then txt3.BackColor = Color.MistyRose Else txt3.BackColor = Color.PaleGreen
                            If txt4.Text <> TextBox26.Text Then txt4.BackColor = Color.MistyRose Else txt4.BackColor = Color.PaleGreen
                            If txt5.Text <> TextBox25.Text Then txt5.BackColor = Color.MistyRose Else txt5.BackColor = Color.PaleGreen
                            If txt6.Text <> TextBox24.Text Then txt6.BackColor = Color.MistyRose Else txt6.BackColor = Color.PaleGreen
                            If txt7.Text <> TextBox23.Text Then txt7.BackColor = Color.MistyRose Else txt7.BackColor = Color.PaleGreen
                            If txt8.Text <> TextBox22.Text Then txt8.BackColor = Color.MistyRose Else txt8.BackColor = Color.PaleGreen
                            If txt9.Text <> TextBox21.Text Then txt9.BackColor = Color.MistyRose Else txt9.BackColor = Color.PaleGreen
                            If txt10.Text <> TextBox20.Text Then txt10.BackColor = Color.MistyRose Else txt10.BackColor = Color.PaleGreen
                            If txt11.Text <> TextBox19.Text Then txt11.BackColor = Color.MistyRose Else txt11.BackColor = Color.PaleGreen
                            If txt12.Text <> TextBox18.Text Then txt12.BackColor = Color.MistyRose Else txt12.BackColor = Color.PaleGreen
                            If txt13.Text <> TextBox17.Text Then txt13.BackColor = Color.MistyRose Else txt13.BackColor = Color.PaleGreen
                            If txt14.Text <> TextBox16.Text Then txt14.BackColor = Color.MistyRose Else txt14.BackColor = Color.PaleGreen
                            If txt15.Text <> TextBox15.Text Then txt15.BackColor = Color.MistyRose Else txt15.BackColor = Color.PaleGreen
                        End If

                    Else
                        GroupBox4.Width = 562
                        Me.Width = 1075
                        Me.Height = 953
                        GroupBox4.Visible = True
                        GroupBox4.Left = 488
                        GroupBox4.Top = 474
                    End If

                    GroupBox2.Visible = False
                    GroupBox3.Visible = False
                    GroupBox1.Visible = True
                    GroupBox1.Left = 488
                    GroupBox1.Top = 32
                    GroupBox1.Text = "SOLD TO INFO"

                    If dt2.Rows(0).Item("cc_bill_contact_from") <> "soldid" Or nz2(dt2.Rows(0).Item("cc_bill_contact_serial"), 0) <> 0 Then
                        Dim dt9aa As New DataTable
                        cmd.CommandText = "SELECT  dbo.cont_file.cont_name, dbo.cont_file.cont_company, dbo.cont_file.cont_addr1, dbo.cont_file.cont_addr2, dbo.cont_file.cont_addr3, dbo.cont_file.cont_city, " + _
                         "dbo.cont_file.cont_state, dbo.cont_file.cont_zip, dbo.cont_file.cont_county, dbo.cont_file.cont_country, dbo.cont_file.cont_phone1, dbo.cont_file.cont_phone2, " + _
                        "dbo.cont_file.cont_fax, dbo.cont_file.cont_cell, dbo.cont_file.cont_email, dbo.ord_cont.ord_cont_note, dbo.ord_cont.ord_cont_payee " + _
                        "FROM dbo.cont_file INNER JOIN " + _
                         "dbo.ord_cont ON dbo.cont_file.cont_serial = dbo.ord_cont.ord_cont_cont_serial " + _
                        "WHERE dbo.ord_cont.ord_cont_cont_serial = " + dt2.Rows(0).Item("cc_bill_contact_serial") + " AND dbo.ord_cont.ord_cont_ord_serial =" + DataGridView1.SelectedRows(0).Cells(2).Value.ToString

                        da.Fill(dt9aa)
                        If dt9aa.Rows.Count > 0 Then
                            TextBox62.Text = dt9aa.Rows(0).Item("cont_name")
                            TextBox60.Text = dt9aa.Rows(0).Item("cont_company")
                            TextBox59.Text = dt9aa.Rows(0).Item("cont_addr1")
                            TextBox55.Text = dt9aa.Rows(0).Item("cont_addr2")
                            TextBox53.Text = dt9aa.Rows(0).Item("cont_addr3")
                            TextBox49.Text = dt9aa.Rows(0).Item("cont_city")
                            TextBox48.Text = dt9aa.Rows(0).Item("cont_state")
                            TextBox46.Text = dt9aa.Rows(0).Item("cont_zip")
                            TextBox43.Text = dt9aa.Rows(0).Item("cont_county")
                            TextBox42.Text = dt9aa.Rows(0).Item("cont_country")
                            TextBox39.Text = dt9aa.Rows(0).Item("cont_ph1")
                            TextBox38.Text = dt9aa.Rows(0).Item("cont_ph2")
                            TextBox36.Text = dt9aa.Rows(0).Item("cont_fax")
                            TextBox34.Text = dt9aa.Rows(0).Item("cont_cell")
                            TextBox32.Text = dt9aa.Rows(0).Item("cont_email")

                            If txt1.Text <> TextBox62.Text Then txt1.BackColor = Color.MistyRose Else txt1.BackColor = Color.PaleGreen
                            If txt2.Text <> TextBox60.Text Then txt2.BackColor = Color.MistyRose Else txt2.BackColor = Color.PaleGreen
                            If txt3.Text <> TextBox59.Text Then txt3.BackColor = Color.MistyRose Else txt3.BackColor = Color.PaleGreen
                            If txt4.Text <> TextBox55.Text Then txt4.BackColor = Color.MistyRose Else txt4.BackColor = Color.PaleGreen
                            If txt5.Text <> TextBox53.Text Then txt5.BackColor = Color.MistyRose Else txt5.BackColor = Color.PaleGreen
                            If txt6.Text <> TextBox49.Text Then txt6.BackColor = Color.MistyRose Else txt6.BackColor = Color.PaleGreen
                            If txt7.Text <> TextBox48.Text Then txt7.BackColor = Color.MistyRose Else txt7.BackColor = Color.PaleGreen
                            If txt8.Text <> TextBox46.Text Then txt8.BackColor = Color.MistyRose Else txt8.BackColor = Color.PaleGreen
                            If txt9.Text <> TextBox43.Text Then txt9.BackColor = Color.MistyRose Else txt9.BackColor = Color.PaleGreen
                            If txt10.Text <> TextBox42.Text Then txt10.BackColor = Color.MistyRose Else txt10.BackColor = Color.PaleGreen
                            If txt11.Text <> TextBox39.Text Then txt11.BackColor = Color.MistyRose Else txt11.BackColor = Color.PaleGreen
                            If txt12.Text <> TextBox38.Text Then txt12.BackColor = Color.MistyRose Else txt12.BackColor = Color.PaleGreen
                            If txt13.Text <> TextBox36.Text Then txt13.BackColor = Color.MistyRose Else txt13.BackColor = Color.PaleGreen
                            If txt14.Text <> TextBox34.Text Then txt14.BackColor = Color.MistyRose Else txt14.BackColor = Color.PaleGreen
                            If txt15.Text <> TextBox32.Text Then txt15.BackColor = Color.MistyRose Else txt15.BackColor = Color.PaleGreen

                        End If
                    End If

                End If

                '*****************************

                If DataGridView1.SelectedRows(0).Cells(0).Value = "Ship" Then
                    Label52.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString + " " + DataGridView1.SelectedRows(0).Cells(0).Value.ToString + " " + DataGridView1.SelectedRows(0).Cells(1).Value.ToString  'ListView1.SelectedItems(0).SubItems(0).Text + "  " + ListView1.SelectedItems(0).SubItems(1).Text + "  " + ListView1.SelectedItems(0).SubItems(2).Text

                    Label49.Visible = True
                    Label50.Visible = True
                    Me.Width = 1075
                    Me.Height = 563
                    dt2.Clear()
                    GroupBox2.Visible = False
                    GroupBox3.Visible = False
                    GroupBox1.Visible = True
                    GroupBox4.Visible = False
                    GroupBox1.Left = 488
                    GroupBox1.Top = 32
                    GroupBox1.Text = "SHIP TO INFO"
                    cmd.CommandText = "SELECT  * from ord_cc_portal_shipto where cc_serial_shipto=" + DataGridView1.SelectedRows(0).Cells(3).Value.ToString
                    da.Fill(dt2)
                    If dt2.Rows(0).Item("cc_ship_processed") Then
                        MsgBox("This ship to info has already been processed.")
                        Button1.Enabled = False
                    End If
                    tb1.Text = dt2.Rows(0).Item("cc_ship_name")
                    TextBox1.Text = dt2.Rows(0).Item("cc_ship_company")
                    TextBox2.Text = dt2.Rows(0).Item("cc_ship_addr1")
                    TextBox3.Text = dt2.Rows(0).Item("cc_ship_addr2")
                    TextBox4.Text = dt2.Rows(0).Item("cc_ship_addr3")
                    TextBox5.Text = dt2.Rows(0).Item("cc_ship_city")
                    TextBox6.Text = dt2.Rows(0).Item("cc_ship_state")
                    TextBox7.Text = dt2.Rows(0).Item("cc_ship_zip")
                    TextBox8.Text = dt2.Rows(0).Item("cc_ship_county")
                    TextBox9.Text = dt2.Rows(0).Item("cc_ship_country")
                    TextBox10.Text = dt2.Rows(0).Item("cc_ship_ph1")
                    TextBox11.Text = dt2.Rows(0).Item("cc_ship_ph2")
                    TextBox12.Text = dt2.Rows(0).Item("cc_ship_fax")
                    TextBox13.Text = dt2.Rows(0).Item("cc_ship_cell")
                    TextBox14.Text = dt2.Rows(0).Item("cc_ship_email")
                    If dt2.Rows(0).Item("cc_ship_modified") = True Then
                        'bMod()
                        'bMod2()
                    Else
                        bGood()
                        bGood2()
                    End If
                    If dt2.Rows(0).Item("cc_ship_alternate") = True Then
                        GroupBox1.Text = "SHIP TO INFO  (alternate)"
                    End If

                    Dim dt8 As New DataTable
                    Dim dt9 As New DataTable
                    cmd.CommandText = "SELECT  * from ord_cc_portal_shipto where cc_ord_serial=" + DataGridView1.SelectedRows(0).Cells(1).Value.Split("-")(0) + " and cc_ord_rev=" + DataGridView1.SelectedRows(0).Cells(1).Value.Split("-")(2) + "and cc_ord_from_rev=" + DataGridView1.SelectedRows(0).Cells(1).Value.Split("-")(1)
                    da.Fill(dt8)
                    If dt8.Rows(0).Item("cc_ship_alternate") = True Then
                        Label26.Text = "This is an alternate shipping address."
                        Label26.Visible = True
                        cmd.CommandText = "SELECT  * from ord_alt_ship where ord_alt_ship_type='O' and ord_alt_ship_ord_serial=" + DataGridView1.SelectedRows(0).Cells(1).Value.Split("-")(0) + " and ord_alt_ship_rev=" + DataGridView1.SelectedRows(0).Cells(1).Value.Split("-")(2)
                        da.Fill(dt9)
                        If dt9.Rows.Count > 0 Then
                            TextBox29.Text = dt9.Rows(0).Item("ord_alt_ship_name")
                            TextBox28.Text = dt9.Rows(0).Item("ord_alt_ship_company")
                            TextBox27.Text = dt9.Rows(0).Item("ord_alt_ship_addr1")
                            TextBox26.Text = dt9.Rows(0).Item("ord_alt_ship_addr2")
                            TextBox25.Text = dt9.Rows(0).Item("ord_alt_ship_addr3")
                            TextBox24.Text = dt9.Rows(0).Item("ord_alt_ship_city")
                            TextBox23.Text = dt9.Rows(0).Item("ord_alt_ship_state")
                            TextBox22.Text = dt9.Rows(0).Item("ord_alt_ship_zip")
                            TextBox21.Text = dt9.Rows(0).Item("ord_alt_ship_county")
                            TextBox20.Text = dt9.Rows(0).Item("ord_alt_ship_country")
                            TextBox19.Text = dt9.Rows(0).Item("ord_alt_ship_phone1")
                            TextBox18.Text = dt9.Rows(0).Item("ord_alt_ship_phone2")
                            TextBox17.Text = dt9.Rows(0).Item("ord_alt_ship_fax")
                            TextBox16.Text = dt9.Rows(0).Item("ord_alt_ship_cell")
                            TextBox15.Text = dt9.Rows(0).Item("ord_alt_ship_email")

                            If tb1.Text <> TextBox29.Text Then tb1.BackColor = Color.MistyRose Else tb1.BackColor = Color.PaleGreen
                            If TextBox1.Text <> TextBox28.Text Then TextBox1.BackColor = Color.MistyRose Else TextBox1.BackColor = Color.PaleGreen
                            If TextBox2.Text <> TextBox27.Text Then TextBox2.BackColor = Color.MistyRose Else TextBox2.BackColor = Color.PaleGreen
                            If TextBox3.Text <> TextBox26.Text Then TextBox3.BackColor = Color.MistyRose Else TextBox3.BackColor = Color.PaleGreen
                            If TextBox4.Text <> TextBox25.Text Then TextBox4.BackColor = Color.MistyRose Else TextBox4.BackColor = Color.PaleGreen
                            If TextBox5.Text <> TextBox24.Text Then TextBox5.BackColor = Color.MistyRose Else TextBox5.BackColor = Color.PaleGreen
                            If TextBox6.Text <> TextBox23.Text Then TextBox6.BackColor = Color.MistyRose Else TextBox6.BackColor = Color.PaleGreen
                            If TextBox7.Text <> TextBox22.Text Then TextBox7.BackColor = Color.MistyRose Else TextBox7.BackColor = Color.PaleGreen
                            If TextBox8.Text <> TextBox21.Text Then TextBox8.BackColor = Color.MistyRose Else TextBox8.BackColor = Color.PaleGreen
                            If TextBox9.Text <> TextBox20.Text Then TextBox9.BackColor = Color.MistyRose Else TextBox9.BackColor = Color.PaleGreen
                            If TextBox10.Text <> TextBox19.Text Then TextBox10.BackColor = Color.MistyRose Else TextBox10.BackColor = Color.PaleGreen
                            If TextBox11.Text <> TextBox18.Text Then TextBox11.BackColor = Color.MistyRose Else TextBox11.BackColor = Color.PaleGreen
                            If TextBox12.Text <> TextBox17.Text Then TextBox12.BackColor = Color.MistyRose Else TextBox12.BackColor = Color.PaleGreen
                            If TextBox13.Text <> TextBox16.Text Then TextBox13.BackColor = Color.MistyRose Else TextBox13.BackColor = Color.PaleGreen
                            If TextBox14.Text <> TextBox15.Text Then TextBox14.BackColor = Color.MistyRose Else TextBox14.BackColor = Color.PaleGreen


                        End If
                    Else
                        cmd.CommandText = "SELECT  * from ord_gen where ord_gen_type='O' and ord_gen_ord_serial=" + DataGridView1.SelectedRows(0).Cells(1).Value.Split("-")(0) + " and ord_gen_from_rev=" + DataGridView1.SelectedRows(0).Cells(1).Value.Split("-")(1) + " and ord_gen_rev=" + DataGridView1.SelectedRows(0).Cells(1).Value.Split("-")(2)
                        da.Fill(dt9)
                        If dt9.Rows.Count > 0 Then
                            TextBox29.Text = dt9.Rows(0).Item("ord_gen_ship_name")
                            TextBox28.Text = dt9.Rows(0).Item("ord_gen_ship_company")
                            TextBox27.Text = dt9.Rows(0).Item("ord_gen_ship_addr1")
                            TextBox26.Text = dt9.Rows(0).Item("ord_gen_ship_addr2")
                            TextBox25.Text = dt9.Rows(0).Item("ord_gen_ship_addr3")
                            TextBox24.Text = dt9.Rows(0).Item("ord_gen_ship_city")
                            TextBox23.Text = dt9.Rows(0).Item("ord_gen_ship_state")
                            TextBox22.Text = dt9.Rows(0).Item("ord_gen_ship_zip")
                            TextBox21.Text = dt9.Rows(0).Item("ord_gen_ship_county")
                            TextBox20.Text = dt9.Rows(0).Item("ord_gen_ship_country")
                            TextBox19.Text = dt9.Rows(0).Item("ord_gen_ship_phone1")
                            TextBox18.Text = dt9.Rows(0).Item("ord_gen_ship_phone2")
                            TextBox17.Text = dt9.Rows(0).Item("ord_gen_ship_fax")
                            TextBox16.Text = dt9.Rows(0).Item("ord_gen_ship_cell")
                            TextBox15.Text = dt9.Rows(0).Item("ord_gen_ship_email")
                            If tb1.Text <> TextBox29.Text Then tb1.BackColor = Color.MistyRose Else tb1.BackColor = Color.PaleGreen
                            If TextBox1.Text <> TextBox28.Text Then TextBox1.BackColor = Color.MistyRose Else TextBox1.BackColor = Color.PaleGreen
                            If TextBox2.Text <> TextBox27.Text Then TextBox2.BackColor = Color.MistyRose Else TextBox2.BackColor = Color.PaleGreen
                            If TextBox3.Text <> TextBox26.Text Then TextBox3.BackColor = Color.MistyRose Else TextBox3.BackColor = Color.PaleGreen
                            If TextBox4.Text <> TextBox25.Text Then TextBox4.BackColor = Color.MistyRose Else TextBox4.BackColor = Color.PaleGreen
                            If TextBox5.Text <> TextBox24.Text Then TextBox5.BackColor = Color.MistyRose Else TextBox5.BackColor = Color.PaleGreen
                            If TextBox6.Text <> TextBox23.Text Then TextBox6.BackColor = Color.MistyRose Else TextBox6.BackColor = Color.PaleGreen
                            If TextBox7.Text <> TextBox22.Text Then TextBox7.BackColor = Color.MistyRose Else TextBox7.BackColor = Color.PaleGreen
                            If TextBox8.Text <> TextBox21.Text Then TextBox8.BackColor = Color.MistyRose Else TextBox8.BackColor = Color.PaleGreen
                            If TextBox9.Text <> TextBox20.Text Then TextBox9.BackColor = Color.MistyRose Else TextBox9.BackColor = Color.PaleGreen
                            If TextBox10.Text <> TextBox19.Text Then TextBox10.BackColor = Color.MistyRose Else TextBox10.BackColor = Color.PaleGreen
                            If TextBox11.Text <> TextBox18.Text Then TextBox11.BackColor = Color.MistyRose Else TextBox11.BackColor = Color.PaleGreen
                            If TextBox12.Text <> TextBox17.Text Then TextBox12.BackColor = Color.MistyRose Else TextBox12.BackColor = Color.PaleGreen
                            If TextBox13.Text <> TextBox16.Text Then TextBox13.BackColor = Color.MistyRose Else TextBox13.BackColor = Color.PaleGreen
                            If TextBox14.Text <> TextBox15.Text Then TextBox14.BackColor = Color.MistyRose Else TextBox14.BackColor = Color.PaleGreen
                        End If
                    End If



                End If
            Catch

            Finally
                cnn.Close()
                Me.Cursor = Cursors.Default
            End Try
        End If
    End Sub

    'Public Shared Function JEncrypt(ByVal plainText As String, Optional ByVal saltValue As String = "Jcom39201") As String
    '    Try
    '        Dim passPhrase As String = "wineCellar5"
    '        Dim hashAlgorithm As String = "MD5"
    '        Dim passwordIterations As Integer = 2
    '        Dim initVector As String = "jaS9#jif0wqczloS"
    '        Dim keySize As Integer = 256


    '        ' Convert strings into byte arrays.
    '        ' Let us assume that strings only contain ASCII codes.
    '        ' If strings include Unicode characters, use Unicode, UTF7, or UTF8 
    '        ' encoding.
    '        Dim initVectorBytes As Byte()
    '        initVectorBytes = Encoding.ASCII.GetBytes(initVector)

    '        Dim saltValueBytes As Byte()
    '        saltValueBytes = Encoding.ASCII.GetBytes(saltValue)

    '        ' Convert our plaintext into a byte array.
    '        ' Let us assume that plaintext contains UTF8-encoded characters.
    '        Dim plainTextBytes As Byte()
    '        plainTextBytes = Encoding.UTF8.GetBytes(plainText)

    '        ' First, we must create a password, from which the key will be derived.
    '        ' This password will be generated from the specified passphrase and 
    '        ' salt value. The password will be created using the specified hash 
    '        ' algorithm. Password creation can be done in several iterations.
    '        Dim password As PasswordDeriveBytes
    '        password = New PasswordDeriveBytes(passPhrase, _
    '                                           saltValueBytes, _
    '                                           hashAlgorithm, _
    '                                           passwordIterations)

    '        ' Use the password to generate pseudo-random bytes for the encryption
    '        ' key. Specify the size of the key in bytes (instead of bits).
    '        Dim keyBytes As Byte()
    '        keyBytes = password.GetBytes(keySize / 8)

    '        ' Create uninitialized Rijndael encryption object.
    '        Dim symmetricKey As RijndaelManaged
    '        symmetricKey = New RijndaelManaged()

    '        ' It is reasonable to set encryption mode to Cipher Block Chaining
    '        ' (CBC). Use default options for other symmetric key parameters.
    '        symmetricKey.Mode = CipherMode.CBC

    '        ' Generate encryptor from the existing key bytes and initialization 
    '        ' vector. Key size will be defined based on the number of the key 
    '        ' bytes.
    '        Dim encryptor As ICryptoTransform
    '        encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

    '        ' Define memory stream which will be used to hold encrypted data.
    '        Dim memoryStream As IO.MemoryStream
    '        memoryStream = New MemoryStream()

    '        ' Define cryptographic stream (always use Write mode for encryption).
    '        Dim cryptoStream As CryptoStream
    '        cryptoStream = New CryptoStream(memoryStream, _
    '                                        encryptor, _
    '                                        CryptoStreamMode.Write)
    '        ' Start encrypting.
    '        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)

    '        ' Finish encrypting.
    '        cryptoStream.FlushFinalBlock()

    '        ' Convert our encrypted data from a memory stream into a byte array.
    '        Dim cipherTextBytes As Byte()
    '        cipherTextBytes = memoryStream.ToArray()

    '        ' Close both streams.
    '        memoryStream.Close()
    '        cryptoStream.Close()

    '        ' Convert encrypted data into a base64-encoded string.
    '        Dim cipherText As String
    '        cipherText = Convert.ToBase64String(cipherTextBytes)

    '        ' Return encrypted string.
    '        JEncrypt = cipherText
    '    Catch
    '        JEncrypt = ""
    '    End Try
    'End Function

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    Dim x = JEncrypt(TextBox54.Text)
    'End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'cnn.Open()
        'Dim dtt As New DataTable

        ''cmd.CommandText = "SELECT        TOP (100) PERCENT ord_serial, dbo.ord_gen.ord_gen_rev, dbo.ord_gen.ord_gen_from_rev, dbo.ord_gen.ord_gen_type,                          dbo.ord_gen.ord_gen_serial, dbo.ord_gen.ord_gen_create_date, dbo.ord_gen.ord_gen_status, dbo.ord_file.ord_cc_random FROM            dbo.ord_file INNER JOIN                         dbo.ord_gen ON dbo.ord_file.ord_serial = dbo.ord_gen.ord_gen_ord_serial WHERE        (dbo.ord_file.ord_cc_random > 0) AND (dbo.ord_gen.ord_gen_type = 'O') AND (dbo.ord_gen.ord_gen_status <> 'CANCELED') ORDER BY dbo.ord_gen.ord_gen_ord_serial, dbo.ord_gen.ord_gen_rev DESC"
        'cmd.CommandText = "SELECT        TOP (100) PERCENT dbo.ord_file.ord_serial, dbo.ord_cc_portal_payment.cc_pay_ord_serial, dbo.ord_cc_portal_payment.cc_pay_order_list,  dbo.ord_cc_portal_payment.cc_pay_processed, dbo.ord_cc_portal_payment.cc_pay_pay_type, dbo.ord_cc_portal_payment.cc_pay_submitted, dbo.ord_cc_portal_payment.cc_pay_approved FROM            dbo.ord_file LEFT OUTER JOIN  dbo.ord_cc_portal_payment ON dbo.ord_file.ord_serial = dbo.ord_cc_portal_payment.cc_pay_ord_serial WHERE        dbo.ord_file.ord_cc_random > 0 ORDER BY dbo.ord_file.ord_serial"
        'da.Fill(dtt)
        'Dim drz As DataRow
        'Dim ord As Integer = 0
        'For Each drz In dtt.Rows
        '    If nz(drz("cc_pay_ord_serial"), 0) <> 0 Then
        '        If drz("cc_pay_approved") = True Then
        '            Dim Occurrences As Integer = 0
        '            Dim StringToCheck As String = drz("cc_pay_order_list")
        '            Dim StringToFind As String = ","

        '            Dim Start As Integer
        '            Dim Found As Integer
        '            Do
        '                Start = Found + 1
        '                Found = InStr(Start, StringToCheck, StringToFind)
        '                If Found = 0 Then Exit Do
        '                Occurrences += 1
        '            Loop
        '            If Occurrences = 0 Then
        '                Try
        '                    Dim zord As String = drz("cc_pay_order_list").Split("-")(0)
        '                    Dim zfromrev As String = drz("cc_pay_order_list").Split("-")(1)
        '                    Dim zrev As String = drz("cc_pay_order_list").Split("-")(2)
        '                    cmd.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + zord.ToString + " and ord_gen_from_rev=" + zfromrev.ToString + " and ord_gen_rev=" + zrev.ToString + " and ord_gen_type='O'"
        '                    Dim cid2 As Integer = nz(cmd.ExecuteScalar)
        '                    cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date,ord_note_type) values (" + cid2.ToString + ",'Credit Card Portal - payment processed. Paid by " + drz("cc_pay_pay_type") + ".','Admin','" + drz("cc_pay_submitted").ToString + "','Note')"
        '                    cmd.ExecuteNonQuery()
        '                Catch
        '                    DoError(Err, Me)
        '                End Try
        '            Else
        '                Do Until Occurrences = -1
        '                    Try
        '                        Dim orda As String = drz("cc_pay_order_list").Split(",")(Occurrences)
        '                        Dim zord As String = orda.Split("-")(0)
        '                        Dim zfromrev As String = orda.Split("-")(1)
        '                        Dim zrev As String = orda.Split("-")(2)
        '                        cmd.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + zord.ToString + " and ord_gen_from_rev=" + zfromrev.ToString + " and ord_gen_rev=" + zrev.ToString + " and ord_gen_type='O'"
        '                        Dim cid2 As Integer = nz(cmd.ExecuteScalar)
        '                        cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date,ord_note_type) values (" + cid2.ToString + ",'Credit Card Portal - payment processed for Multiple Orders. Paid by " + drz("cc_pay_pay_type") + ".','Admin','" + drz("cc_pay_submitted").ToString + "','Note')"
        '                        cmd.ExecuteNonQuery()
        '                        Occurrences += -1
        '                    Catch
        '                        DoError(Err, Me)
        '                    End Try
        '                Loop
        '            End If

        '            'Try
        '            '    cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date,ord_note_type) values (" + drz("ord_gen_serial").ToString + ",'Credit Card Portal - email link created.','Admin','" + drz("ord_gen_create_date").ToString + "','Note')"
        '            '    cmd.ExecuteNonQuery()
        '            'Catch
        '            '    DoError(Err, Me)
        '            'End Try
        '            'ord = drz("ord_serial")
        '        End If
        '    End If

        '    'If drz("") Then

        '    'End If

        '    'Try
        '    '    cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date,ord_note_type) values (" + rw("ord_gen_serial").ToString + ",'Credit Card Portal - email link created.','Admin','" + CStr(Now()) + "','Note')"
        '    '    cmd.ExecuteNonQuery()
        '    'Catch
        '    '    DoError(Err, Me)
        '    'End Try




        '    'Dim Occurrences As Integer
        '    'Dim StringToCheck As String = TextBox33.Text
        '    'Dim StringToFind As String = ","

        '    'Dim Start As Integer
        '    'Dim Found As Integer
        '    'Do
        '    '    Start = Found + 1
        '    '    Found = InStr(Start, StringToCheck, StringToFind)
        '    '    If Found = 0 Then Exit Do
        '    '    Occurrences += 1
        '    'Loop
        '    'Do Until Occurrences = -1
        '    '    Try
        '    '        Dim ord As String = TextBox33.Text.Split(",")(Occurrences)
        '    '        Dim zord As String = ord.Split("-")(0)
        '    '        Dim zfromrev As String = ord.Split("-")(1)
        '    '        Dim zrev As String = ord.Split("-")(2)
        '    '        cmd.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + zord.ToString + " and ord_gen_from_rev=" + zfromrev.ToString + " and ord_gen_rev=" + zrev.ToString + " and ord_gen_type='O'"
        '    '        Dim cid2 As Integer = nz(cmd.ExecuteScalar)
        '    '        cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date,ord_note_type) values (" + cid2.ToString + ",'Credit Card Portal - payment processed for Multiple Orders. Paid by " + TextBox44.Text + ".','Admin','" + CStr(Now()) + "','Note')"
        '    '        cmd.ExecuteNonQuery()
        '    '        Occurrences += -1
        '    '    Catch
        '    '        DoError(Err, Me)
        '    '    End Try
        '    'Loop
        'Next

        'cnn.Close() 'CAST(DocumentNo AS VARCHAR(5) )+ 

    End Sub
End Class