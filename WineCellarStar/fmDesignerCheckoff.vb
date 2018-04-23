Imports System.Data.SqlClient


Public Class fmDesignerCheckoff
    Inherits System.Windows.Forms.Form
    Dim cmd As New SqlCommand("", cnn)

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
    Friend WithEvents tQuote As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lCompany As System.Windows.Forms.Label
    Friend WithEvents lRef As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lCellarArt As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tQuote = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lCompany = New System.Windows.Forms.Label
        Me.lRef = New System.Windows.Forms.Label
        Me.lCellarArt = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'tQuote
        '
        Me.tQuote.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.tQuote.Location = New System.Drawing.Point(8, 23)
        Me.tQuote.Name = "tQuote"
        Me.tQuote.Size = New System.Drawing.Size(152, 20)
        Me.tQuote.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quote Number (eg 123456-1)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(284, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Update"
        '
        'lCompany
        '
        Me.lCompany.Location = New System.Drawing.Point(272, 18)
        Me.lCompany.Name = "lCompany"
        Me.lCompany.Size = New System.Drawing.Size(243, 14)
        Me.lCompany.TabIndex = 3
        '
        'lRef
        '
        Me.lRef.Location = New System.Drawing.Point(272, 42)
        Me.lRef.Name = "lRef"
        Me.lRef.Size = New System.Drawing.Size(243, 14)
        Me.lRef.TabIndex = 4
        '
        'lCellarArt
        '
        Me.lCellarArt.Location = New System.Drawing.Point(272, 66)
        Me.lCellarArt.Name = "lCellarArt"
        Me.lCellarArt.Size = New System.Drawing.Size(243, 14)
        Me.lCellarArt.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Correct", "Minor Mistake", "Careless Mistake", "Lack of Knowledge Mistake"})
        Me.ComboBox1.Location = New System.Drawing.Point(8, 69)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(243, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(8, 115)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(507, 133)
        Me.TextBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Add Note"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Grade"
        Me.Label4.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(390, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Close"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(166, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 25)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Verify"
        '
        'fmDesignerCheckoff
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 300)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lCellarArt)
        Me.Controls.Add(Me.lRef)
        Me.Controls.Add(Me.lCompany)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tQuote)
        Me.Name = "fmDesignerCheckoff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Designer Checkoff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            tQuote.BackColor = Color.LightGoldenrodYellow
            If Split(tQuote.Text, "-").Length <> 2 Then
                MsgBox("Invalid Quote Number", MsgBoxStyle.Critical, "Invalid")
                tQuote.Focus()
                tQuote.SelectAll()
                Exit Sub
            End If
            'Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "select ord_gen.*,ord_sold_company,ord_sold_name,ord_for,ord_sold_cust_id from ord_gen inner join ord_file on ord_gen_ord_serial=ord_serial where ord_gen_ord_serial=" + Split(tQuote.Text, "-")(0) + " and ord_gen_rev=" + Split(tQuote.Text, "-")(1) + " and ord_gen_type='Q'"
            Dim dr As SqlClient.SqlDataReader
            Dim ISR As String
            'Dim isIWA As Boolean = False



            cnn.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                lCompany.Text = nz(dr("ord_sold_company")) + " (" + nz(dr("ord_sold_name")) + ")"
                lRef.Text = nz(dr("ord_for"))
                ISR = nz(dr("ord_gen_inside"))
                'ComboBox1.Text = nz(dr("ord_gen_designer_grade"))
                If dr("ord_gen_co_toart") Is DBNull.Value Then
                    lCellarArt.Text = ""
                Else
                    If dr("ord_gen_co_toart") = True Then
                        lCellarArt.Text = "To Cellar Art"
                    Else
                        lCellarArt.Text = "No Cellar Art"
                    End If
                End If
                Dim onOrdGen As String
                onOrdGen = CStr(dr("ord_gen_serial"))
                If nz(dr("ord_gen_co_designer"), False) = True Then
                    MsgBox("Quote has been checked off previously by " + nz(dr("ord_gen_co_desuser"), "") + " on " + CStr(dr("ord_gen_co_desdate")) + ".  Quote will NOT be updated.", MsgBoxStyle.Information, "Already signed off")
                    cnn.Close()
                    Exit Sub
                End If
                If nz(dr("ord_gen_designer")) = "" Then
                    MsgBox("Quote has to have a Designer assigned.  Designer is blank.", MsgBoxStyle.Critical, "Designer?")
                    cnn.Close()
                    Exit Sub
                End If
                'If nz(dr("ord_gen_co_desreq"), False) = False Then
                '    If MsgBox("Design Required is not checked off.  This will check Design Required.  Do you want to continue?", MsgBoxStyle.YesNo, "Design Required?") = MsgBoxResult.No Then
                '        dr.Close()
                '        cnn.Close()
                '        Exit Sub
                '    End If
                'End If

                If ISR = "" Then
                    MsgBox("Please enter an ISR on the order before processing!", MsgBoxStyle.Critical, "ISR?")
                    dr.Close()
                    cnn.Close()
                    Exit Sub
                End If

                'If nz(dr("ord_sold_cust_id")) = "IWA" Then isIWA = True
                dr.Close()
                cmd.CommandText = "update ord_gen set ord_gen_co_desreq=1,ord_gen_co_designer=1,ord_gen_designer_grade='" + ComboBox1.Text + "',ord_gen_co_desuser='" + User + "',ord_gen_co_desdate='" + CStr(Now) + "',ord_gen_des_status='DESIGN COMPLETE' where ord_gen_serial=" + onOrdGen
                cmd.ExecuteNonQuery()
                cmd.CommandText = "update rep_file set rep_designer_time='" + CStr(Now) + "' where rep_code='" + ISR + "'"
                cmd.ExecuteNonQuery()
                cnn.Close()




                'Check IWA and add order if necessary
                ' Turned off per Todd 1/16/2012
                'If isIWA Then
                '    Dim recs As Integer

                '    cmd.CommandText = "SELECT COUNT(*) FROM  ord_gen INNER JOIN  ord_itm ON ord_gen.ord_gen_ord_serial = ord_itm.ord_itm_ord_serial AND ord_gen.ord_gen_rev = ord_itm.ord_itm_rev AND ord_gen.ord_gen_type = ord_itm.ord_itm_type WHERE (ord_gen.ord_gen_ord_serial = " + Split(tQuote.Text, "-")(0) + ") AND (ord_gen.ord_gen_type = 'O') AND (ord_gen.ord_gen_from_rev = " + Split(tQuote.Text, "-")(1) + ") GROUP BY ord_itm.ord_itm_item_code HAVING (ord_itm.ord_itm_item_code = 'DDP-IWA')"
                '    cnn.Open()
                '    recs = cmd.ExecuteScalar
                '    cnn.Close()

                '    If recs = 0 Then
                '        Dim fm As fmEstOrd2
                '        Dim row As DataRow
                '        Dim x As Long
                '        Dim onOrd As String

                '        fm = LoadForm("Quotes/Orders")
                '        If fm.EditMode = "Edit" Or fm.EditMode = "Add" Then
                '            fm.Focus()
                '            fm = LoadForm("Quotes/Orders")
                '        End If
                '        QuietMode = True
                '        QuietModeForIWA = True
                '        fm.tOrd.Text = Split(tQuote.Text, "-")(0)
                '        fm.KeyValue1 = fm.tOrd.Text
                '        fm.LoadPage()
                '        fm.Edit()
                '        fm.Tab1.Tabs("Q" + Split(tQuote.Text, "-")(1)).Selected = True
                '        onOrd = fm.SplitOMatic(False)

                '        row = fm.dsItems.Tables("ord_itm").NewRow
                '        row("ord_itm_item_code") = "DDP-IWA"
                '        row("ord_itm_up_color") = 0
                '        row("ord_itm_bom_import") = False
                '        fm.LoadPriceByRow(row, True)
                '        fm.dsItems.Tables("ord_itm").Rows.Add(row)
                '        row = Nothing


                '        fm.DVGen(0).Item("ord_gen_status") = "SHIPPED"
                '        fm.tStatus.Text = "SHIPPED"
                '        fm.DVGen(0).Item("ord_gen_ship_date") = Now
                '        fm.tShipDate.Text = CStr(Now)
                '        fm.DVGen(0).Item("ord_gen_ship") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_extra") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_inside") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_collect") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_white_glove") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_cust_pickup") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_gated") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_smalltruck") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_call") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_callname") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_callphone") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_twoman") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_liftgate") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_steps") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_numsteps") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_turns") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_numturns") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_thirdparty") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_thirdpartyname") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_alert") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_overnite") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_skids") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_numskids") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_intlship") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_disc") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_extra") = 0
                '        fm.DVGen(0).Item("ord_gen_ship_promo_serial") = DBNull.Value

                '        fm.Save()

                '        cnn.Open()
                '        cmd.CommandText = "insert into ship_file (ship_via,ship_date,ship_track,ship_weight,ship_boxes,ship_cost,ship_notes,ship_ord_serial,ship_ord_rev,ship_ord_type,update_by,last_update,ship_note,ship_created,ship_vendornet,ship_vendornet_date,ship_no_status_change,ship_live_via) values ('DESIGN',getdate(),'',0,0,0,''," + fm.tOrd.Text + "," + Mid(fm.Tab1.ActiveTab.Key, 2) + ",'O','" + User + "',getdate(),'',getdate(),0,null,null,'')"
                '        cmd.ExecuteNonQuery()
                '        cmd.CommandText = "select @@IDENTITY"
                '        x = cmd.ExecuteScalar
                '        cmd.CommandText = "insert into ship_itm (ship_itm_ship_serial,ship_itm_ord_serial,ship_itm_ord_rev,ship_itm_ord_itm_serial,ship_itm_qty,ship_itm_code,ship_itm_desc)values (" + CStr(x) + "," + fm.tOrd.Text + "," + Mid(fm.Tab1.ActiveTab.Key, 2) + ",0,1,'','DDP-IWA')"
                '        cmd.ExecuteNonQuery()
                '        cnn.Close()

                '        QuietMode = False
                '        QuietModeForIWA = False
                '        MsgBox("IWA order for DDP-IWA entered successfully", MsgBoxStyle.OkOnly, "DDP-IWA")
                '    End If
                'End If

                If TextBox1.Text <> "" Then
                    cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date,ord_note_type) values (" + onOrdGen.ToString + ",'" + Replace(TextBox1.Text, "'", "''") + "','" + User + "','" + CStr(Now()) + "','DNote')"
                    cnn.Open()
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                End If
                'tNote.Visible = False
                'pOrdMod.Visible = True
                'bAddNote.Text = "Add Note"
                'tNote.Text = ""
                'LoadNotes()
                tQuote.BackColor = Color.LightGreen
            Else
                tQuote.BackColor = Color.MistyRose
                MsgBox("Quote not found", MsgBoxStyle.Critical, "Not Found")
            End If
        Catch
            tQuote.BackColor = Color.MistyRose
            MsgBox("Quote may have not been checked off.  Please report this error to your administrator:" + vbCrLf + Err.Description, MsgBoxStyle.Critical, "Error")
        Finally
            If cnn.State <> ConnectionState.Closed Then cnn.Close()
            tQuote.Focus()
            tQuote.SelectAll()
        End Try
    End Sub


    Private Sub fmDesignerCheckoff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Split(tQuote.Text, "-").Length <> 2 Then
            MsgBox("Invalid Quote Number", MsgBoxStyle.Critical, "Invalid")
            tQuote.Focus()
            tQuote.SelectAll()
            Exit Sub
        End If
        'Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "select ord_gen.*,ord_sold_company,ord_sold_name,ord_for,ord_sold_cust_id from ord_gen inner join ord_file on ord_gen_ord_serial=ord_serial where ord_gen_ord_serial=" + Split(tQuote.Text, "-")(0) + " and ord_gen_rev=" + Split(tQuote.Text, "-")(1) + " and ord_gen_type='Q'"
        Dim dr As SqlClient.SqlDataReader
        Dim ISR As String
        'Dim isIWA As Boolean = False
        Button1.Enabled = False
        TextBox1.Enabled = False
        ComboBox1.Enabled = False
        Try
            cnn.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                lCompany.Text = nz(dr("ord_sold_company")) + " (" + nz(dr("ord_sold_name")) + ")"
                lRef.Text = nz(dr("ord_for"))
                ISR = nz(dr("ord_gen_inside"), "")
                ComboBox1.Text = nz(dr("ord_gen_designer_grade"))
                If dr("ord_gen_co_toart") Is DBNull.Value Then
                    lCellarArt.Text = ""
                Else
                    If dr("ord_gen_co_toart") = True Then
                        lCellarArt.Text = "To Cellar Art"
                    Else
                        lCellarArt.Text = "No Cellar Art"
                    End If
                End If
                Dim onOrdGen As String
                onOrdGen = CStr(dr("ord_gen_serial"))
                If nz(dr("ord_gen_co_designer"), False) = True Then
                    MsgBox("Quote has been checked off previously by " + nz(dr("ord_gen_co_desuser"), "") + " on " + CStr(dr("ord_gen_co_desdate")) + ".  Quote will NOT be updated.", MsgBoxStyle.Information, "Already signed off")
                    cnn.Close()
                    Exit Sub
                End If
                If nz(dr("ord_gen_designer")) = "" Then
                    MsgBox("Quote has to have a Designer assigned.  Designer is blank.", MsgBoxStyle.Critical, "Designer?")
                    cnn.Close()
                    Exit Sub
                End If

                If ISR = "" Then
                    MsgBox("Please enter an ISR on the order before processing!", MsgBoxStyle.Critical, "ISR?")
                End If

                dr.Close()
              


                Button1.Enabled = True
                TextBox1.Enabled = True
                ComboBox1.Enabled = True

               
                
            Else
                tQuote.BackColor = Color.MistyRose
                MsgBox("Quote not found", MsgBoxStyle.Critical, "Not Found")
            End If
        Catch
            MsgBox(Err.Description)
        Finally

            cnn.Close()
        End Try
    End Sub
End Class
