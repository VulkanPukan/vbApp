Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class fmCallCenterAdmin
    Dim cmd As New SqlCommand("", cnn)
    Dim da As New SqlDataAdapter(cmd)
    Dim onCallFilter As Long
    Dim dtImport As DataTable
    Dim daImport As New SqlDataAdapter
    Dim ds As New DataSet

    Private Sub CallCenterAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadCallers()
        LoadDD2(ddFilterName, "rep_call_filters", "rcfs_serial", "rcfs_name", "rcfs_serial,rcfs_name", "rcfs_active=1")
        LoadDD2(tOSRType, "cont_type", "cont_type", "cont_type")
        LoadDD2(ddImportSrc, "ord_src", "ord_src", "ord_src_desc", "ord_src,ord_src_desc", "ord_src_inactive=0", , "Use List")
        LoadDD2(tOSR, "usr_file", "usr_name", "usr_name", , "isnull(inactive,0)=0", False, "Call Center,")
        ddImportSrc.DisplayLayout.Bands(0).Columns(1).Width = 300

        Dim dt As New DataTable
        Dim dr As DataRow
        cmd.CommandText = "select * from cont_type"
        da.Fill(dt)
        dr = dt.NewRow
        dr("cont_type") = "Use List"
        dt.Rows.Add(dr)
        ddImportType.DataSource = dt
        ddImportType.DataBind()
        ddImportType.Text = "Use List"
        'LoadDD2(ddImportType, "cont_type", "cont_type", "cont_type")

        ClearValues()
    End Sub
    Private Sub LoadCallers()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim cnt As Integer = 1
        Dim pn As Panel
        Dim lb As Label
        Dim ct As Control
        Dim ctNew As Control
        Dim Calls As Integer
        Dim dtFilters As DataTable
        Dim drFilters As DataRow

        Try
            cnn.Open()
            cmd.CommandText = "select rep_code from rep_file where rep_type='P' and rep_active=1 order by rep_code"
            da.Fill(dt)

            dt.Columns.Add("Calls Left")
            dt.Columns.Add("Status")

            For Each dr In dt.Rows
                Calls = 0
                cmd.CommandText = "select rcfs_filter from rep_call_filter, rep_call_filters where rcf_rcfs_serial=rcfs_serial and rcf_rep_code='" + dr("rep_code") + "'"
                dtFilters = New DataTable
                da.Fill(dtFilters)
                For Each drFilters In dtFilters.Rows
                    If nz(drFilters("rcfs_filter")) <> "" Then
                        cmd.CommandText = "select count(*) from cont_file where (" + drFilters("rcfs_filter") + ") and cont_status='NEW'"
                        Calls += nz(cmd.ExecuteScalar, 0)
                    End If
                Next
                dr("Calls Left") = Calls
            Next
        Catch
            MsgBox(Err.Description)
        Finally
            cnn.Close()
        End Try

        gCallers.DataSource = dt

        dt = Nothing
    End Sub
    Private Sub lbFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFilter.SelectedIndexChanged
        Select Case lbFilter.Text
            Case "Source Code"
                LoadDD2(ddFilter, "ord_src", "ord_src", "ord_src", "ord_src,ord_src_desc")
                ddFilter.Tag = "cont_src_ord_src = '"
                ddFilter.Visible = True
                tFilter.Visible = False
                ddFilter1.Visible = False
                ddFilterDate.Visible = False
                ddFilter.Focus()
            Case "Zip Code"
                tFilter.Text = ""
                tFilter.Tag = "cont_zip like '"
                ddFilter.Visible = False
                tFilter.Visible = True
                ddFilter1.Visible = False
                ddFilterDate.Visible = False
                tFilter.Focus()
            Case "State"
                tFilter.Text = ""
                tFilter.Tag = "cont_state = '"
                ddFilter.Visible = False
                tFilter.Visible = True
                ddFilter1.Visible = False
                ddFilterDate.Visible = False
                tFilter.Focus()
            Case "Contact Type"
                LoadDD2(ddFilter, "cont_type", "cont_type", "cont_type", "cont_type")
                ddFilter.Tag = "cont_type = '"
                ddFilter.Visible = True
                tFilter.Visible = False
                ddFilter1.Visible = False
                ddFilterDate.Visible = False
                ddFilter.Focus()
            Case "Import Date"
                ddFilter.Tag = "DATEDIFF(DD, cont_import_time, '"
                ddFilter.Visible = False
                tFilter.Visible = False
                ddFilter1.Visible = True
                ddFilterDate.Visible = True
                ddFilterDate.Focus()

        End Select
    End Sub

    Private Sub bAddFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAddFilter.Click
        If tSQL.Text <> "" Then tSQL.Text += " and "
        Select Case lbFilter.Text
            Case "Source Code"
                tSQL.Text += "(" + ddFilter.Tag + ddFilter.Text + "')"
            Case "Zip Code"
                tSQL.Text += "(" + tFilter.Tag + tFilter.Text + "%')"
            Case "State"
                tSQL.Text += "(" + tFilter.Tag + tFilter.Text + "')"
            Case "Contact Type"
                tSQL.Text += "(" + ddFilter.Tag + ddFilter.Text + "')"
            Case "Import Date"
                tSQL.Text += "(" + ddFilter.Tag + ddFilterDate.Text + "') = 0)"
        End Select
        LoadContacts()
    End Sub
    Private Sub LoadContacts()
        Dim dt As New DataTable

        If tSQL.Text = "" Then
            cmd.CommandText = "select cont_file.*, ord_src_desc from cont_file left outer join cont_src on cont_serial=cont_src_cont_serial left outer join ord_src on cont_src_ord_src=ord_src where cont_serial=-1"
        Else
            cmd.CommandText = "select cont_file.*, ord_src_desc from cont_file left outer join cont_src on cont_serial=cont_src_cont_serial left outer join ord_src on cont_src_ord_src=ord_src where " + tSQL.Text
        End If
        da.Fill(dt)
        Grid1.DataSource = dt
        lRecs.Text = CStr(Grid1.Rows.Count) + " Contacts"
    End Sub

    Private Sub bRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRefresh.Click
        LoadContacts()
    End Sub

    Private Sub lbCallers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadCaller()
    End Sub
    Private Sub LoadCaller()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim cnt As Integer = 0

        'tCurFilter.Text = ""
        cmd.CommandText = "select rcf_serial,rcfs_name,rcf_order from rep_call_filter,rep_call_filters where rcf_rcfs_serial=rcfs_serial and rcf_rep_code='" + gCallers.ActiveRow.Cells("rep_code").Value + "'"
        da.Fill(dt)
        gCallFilters.DataSource = dt


        'dt = Nothing
        'pCaller.Visible = True
    End Sub
    Private Sub gFilters_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs)
        'tCurFilter.Text = gFilters.ActiveRow.Cells("rcf_filter").Text
    End Sub

    Private Sub gFilters_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim onOrder As Integer

        'cmd.CommandText = "SELECT max(rcf_order) FROM rep_call_filter WHERE rcf_rep_code = '" + lbCallers.SelectedItem + "'"
        'cnn.Open()
        'onOrder = nz(cmd.ExecuteScalar, 0) + 1
        'cmd.CommandText = "insert into rep_call_filter (rcf_rep_code,rcf_filter_name,rcf_filter,rcf_order) values ('" + lbCallers.SelectedItem + "','" + Replace(ddFilterName.Text, "'", "''") + "','" + Replace(tSQL.Text, "'", "''") + "'," + CStr(onOrder) + ")"
        'cmd.ExecuteNonQuery()
        'cnn.Close()
        'LoadCaller()
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        If ddFilterName.Text = "" Then
            MsgBox("You must name each filter", MsgBoxStyle.Information, "Name?")
            Exit Sub
        End If
        If tSQL.Text = "" Then
            MsgBox("You must have a filter", MsgBoxStyle.Information, "Filter?")
            Exit Sub
        End If
        If ddFilterName.IsItemInList = False Then
            cmd.CommandText = "insert into rep_call_filters (rcfs_name,rcfs_filter,rcfs_active,rcfs_script) values ('" + Replace(ddFilterName.Text, "'", "''") + "','" + Replace(tSQL.Text, "'", "''") + "',1,'" + Replace(tScript.Text, "'", "''") + "')"
        Else
            cmd.CommandText = "update rep_call_filters set rcfs_filter='" + Replace(tSQL.Text, "'", "''") + "',rcfs_script='" + Replace(tScript.Text, "'", "''") + "' where rcfs_serial=" + CStr(ddFilterName.Value)
        End If
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        LoadDD2(ddFilterName, "rep_call_filters", "rcfs_serial", "rcfs_name", "rcfs_serial,rcfs_name", "rcfs_active=1")

    End Sub

    Private Sub ddFilterName_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ddFilterName.InitializeLayout

    End Sub

    Private Sub ddFilterName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddFilterName.Leave
        SelectFilter()
    End Sub

    Private Sub ddFilterName_RowSelected(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles ddFilterName.RowSelected
    End Sub

    Private Sub ddFilterName_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddFilterName.ValueChanged
    End Sub
    Private Sub SelectFilter()
        If ddFilterName.IsItemInList = False Then
            'ClearFilter()
        Else
            cmd.CommandText = "select rcfs_filter from rep_call_filters where rcfs_serial=" + CStr(ddFilterName.Value)
            cnn.Open()
            tSQL.Text = cmd.ExecuteScalar
            cmd.CommandText = "select rcfs_script from rep_call_filters where rcfs_serial=" + CStr(ddFilterName.Value)
            tScript.Text = nz(cmd.ExecuteScalar)
            cnn.Close()
            LoadContacts()
        End If
    End Sub
    Private Sub ClearFilter()
        ddFilterName.Text = ""
        tSQL.Text = ""
        tScript.Text = ""
    End Sub
    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        Select Case e.Tab.Key
            Case "Callers"
                LoadDD2(ddCallFilters, "rep_call_filters", "rcfs_serial", "rcfs_name", "rcfs_serial,rcfs_name", "rcfs_active=1")
                LoadCallers()
            Case "OSR"
                LoadOSRCalls()
        End Select
    End Sub
    Private Sub LoadOSRCalls()
        Dim dt As New DataTable
        Dim dr As DataRow

        cmd.CommandText = "select cont_serial, cont_name, cont_company,cont_next_call, cont_next_call_time from cont_file where cont_status ='Call Back' and cont_next_call_by='MGR' order by cont_next_call"   ' and cont_next_call<='" + CStr(Today) + "'
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            'For Each dr In dt.Rows
            '    If CDate(Format(nz(dr("cont_next_call"), Today), "MM/dd/yyyy") + " " + dr("cont_next_call_time")) > Now Then dr.Delete()
            'Next
            pDetail.Visible = True
        Else
            pDetail.Visible = False
        End If
        dt.AcceptChanges()
        gOSRCalls.DataSource = dt

        dt = Nothing
    End Sub

    Private Sub gCallers_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles gCallers.AfterRowActivate
        LoadCaller()
    End Sub

    Private Sub gCallers_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gCallers.InitializeLayout

    End Sub

    Private Sub bCallFilterAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCallFilterAdd.Click
        cmd.CommandText = "insert into rep_call_filter (rcf_rep_code,rcf_rcfs_serial,rcf_order) values ('" + gCallers.ActiveRow.Cells("rep_code").Text + "'," + CStr(ddCallFilters.Value) + ",0)"
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        LoadCaller()
    End Sub

    Private Sub bNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNew.Click
        ClearFilter()
        ddFilterName.Focus()
    End Sub

    Private Sub bDeleteFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDeleteFilter.Click
        cmd.CommandText = "select rcf_serial from rep_call_filter where rcf_rcfs_serial=" + CStr(ddFilterName.Value)
        cnn.Open()
        If nz(cmd.ExecuteScalar, 0) > 0 Then
            MsgBox("This filter is assigned to callers and can not be deleted", MsgBoxStyle.Information, "Delete?")
            cnn.Close()
            Exit Sub
        End If
        If MsgBox("Are you sure you want to delete this filter", MsgBoxStyle.YesNo, "Delete Filter?") = MsgBoxResult.Yes Then
            cmd.CommandText = "delete from rep_call_filters where rcfs_serial=" + CStr(ddFilterName.Value)
            cmd.ExecuteNonQuery()
            LoadDD2(ddFilterName, "rep_call_filters", "rcfs_serial", "rcfs_name", "rcfs_serial,rcfs_name", "rcfs_active=1")
            ClearFilter()
        End If
        cnn.Close()
    End Sub

    Private Sub gCallFilters_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gCallFilters.BeforeRowsDeleted
        cmd.CommandText = "delete from rep_call_filter where rcf_serial=" + CStr(e.Rows(0).Cells("rcf_serial").Text)
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub

    Private Sub gCallFilters_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gCallFilters.InitializeLayout

    End Sub

    Private Sub gOSRCalls_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles gOSRCalls.AfterRowActivate
        Dim dt As New DataTable
        Dim dr As DataRow

        dt = New DataTable
        cmd.CommandText = "select cont_note_user as [User], cont_note_date as [Date],cont_note_type as [Type], cont_note as [Note] from cont_note where cont_note_cont_serial=" + CStr(gOSRCalls.ActiveRow.Cells(0).Text) + " order by cont_note_date desc"
        da.Fill(dt)
        gOSRNotes.DataSource = dt
        gOSRNotes.DataBind()
        gOSRNotes.DisplayLayout.Bands(0).Columns("Note").CellMultiLine = Infragistics.Win.DefaultableBoolean.True

        dt = New DataTable
        cmd.CommandText = "select * from cont_file where cont_serial=" + CStr(gOSRCalls.ActiveRow.Cells(0).Text)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            tOSRType.Text = dr("cont_type")
            tOSRName.Text = nz(dr("cont_name"))
            tOSRAddr1.Text = nz(dr("cont_addr1"))
            tOSRAddr2.Text = nz(dr("cont_addr2"))
            tOSRAddr3.Text = nz(dr("cont_addr3"))
            tOSRCity.Text = nz(dr("cont_city"))
            tOSRState.Text = nz(dr("cont_state"))
            tOSRZip.Text = nz(dr("cont_zip"))
            tOSRCompany.Text = nz(dr("cont_company"))
            tOSRPhone1.Text = nz(dr("cont_phone1"))
            tOSRPhone2.Text = nz(dr("cont_phone2"))
            tOSRFax.Text = nz(dr("cont_fax"))
            tOSRCell.Text = nz(dr("cont_cell"))
            tOSREmail.Text = nz(dr("cont_email"))
            tOSRWebsite.Text = nz(dr("cont_website"))
            tOSR.Value = nz(dr("cont_osr"))
            cbOSRCatNone.Checked = nz(dr("cont_cat_none"), False)
            cbOSRCatRes.Checked = nz(dr("cont_cat_residential"), False)
            cbOSRCatCom.Checked = nz(dr("cont_cat_commercial"), False)
            cbOSRCatEmail.Checked = nz(dr("cont_cat_email"), False)
            cbOSRCatMail.Checked = nz(dr("cont_cat_mail"), False)
            tCallBackDate.Value = nz(dr("cont_next_call"), Today)
            tCallBackTime.Text = IIf(nz(dr("cont_next_call_time"), "0:00") = "0:00", "Any Time", dr("cont_next_call_time"))
            lSource.Text = nz(dr("cont_ord_src"))
        End If


        dt = Nothing

        If tOSR.Text = "" Then
            tOSR.Value = GetRepFromTerritory(tOSRState.Text, "O", Today, tOSRZip.Text)
        End If

    End Sub

    Private Sub gOSRCalls_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gOSRCalls.InitializeLayout

    End Sub

    Private Sub bOSRSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOSRSave.Click
        If cbDisp.Value = "" Then
            MsgBox("You must pick a disposition for this record", MsgBoxStyle.Information, "What?")
            cbDisp.Focus()
            Exit Sub
        End If
        If (cbDisp.Value = "Call Back" Or cbDisp.Value = "OSR Call Back") And tCallBackDate.Value < Today Then
            MsgBox("You must pick a day in the future", MsgBoxStyle.Information, "Date?")
            tCallBackDate.Focus()
            Exit Sub
        End If
        If (cbDisp.Value = "OSR Call Back") And tOSR.Text = "" Then
            MsgBox("You must pick an OSR", MsgBoxStyle.Information, "OSR?")
            tOSR.Focus()
            Exit Sub
        End If

        cmd.CommandText = "update cont_file set cont_type='" + tOSRType.Text + "',cont_name='" + Replace(tOSRName.Text, "'", "''") + "',cont_company='" + Replace(tOSRCompany.Text, "'", "''") + "',cont_addr1='" + Replace(tOSRAddr1.Text, "'", "''") + "',cont_addr2='" + Replace(tOSRAddr2.Text, "'", "''") + "',cont_addr3='" + Replace(tOSRAddr3.Text, "'", "''") + "',cont_city='" + Replace(tOSRCity.Text, "'", "''") + "',cont_state='" + Replace(tOSRState.Text, "'", "''") + "',cont_zip='" + Replace(tOSRZip.Text, "'", "''") + "',cont_phone1='" + Replace(tOSRPhone1.Text, "'", "''") + "',cont_phone2='" + Replace(tOSRPhone2.Text, "'", "''") + "',cont_cell='" + Replace(tOSRCell.Text, "'", "''") + "',cont_fax='" + Replace(tOSRFax.Text, "'", "''") + "',cont_email='" + Replace(tOSREmail.Text, "'", "''") + "',cont_website='" + Replace(tOSRWebsite.Text, "'", "''") + "',cont_cat_none=" + IIf(cbOSRCatNone.Checked, "1", "0") + ",cont_cat_residential=" + IIf(cbOSRCatRes.Checked, "1", "0") + ",cont_cat_commercial=" + IIf(cbOSRCatCom.Checked, "1", "0") + ",cont_cat_mail=" + IIf(cbOSRCatMail.Checked, "1", "0") + ",cont_cat_email=" + IIf(cbOSRCatEmail.Checked, "1", "0") + ",cont_osr='" + tOSR.Value + "'"

        Select Case cbDisp.Value
            Case "DNC"
                cmd.CommandText += ",cont_status='DNC'"
                'cmd.CommandText = "update cont_file set cont_status='Number No Good' where cont_serial=" + CStr(gOSRCalls.ActiveRow.Cells(0).Value)
            Case "Call Back"
                cmd.CommandText += ",cont_status='Call Back',cont_next_call='" + CStr(tCallBackDate.Value) + "',cont_next_call_time='" + IIf(tCallBackTime.Text = "Any Time", "0:00", tCallBackTime.Text) + "',cont_next_call_by='MGR'"
            Case "OSR to Call"
                cmd.CommandText += ",cont_status='Call Back',cont_next_call='" + CStr(tCallBackDate.Value) + "',cont_next_call_time='" + IIf(tCallBackTime.Text = "Any Time", "0:00", tCallBackTime.Text) + "',cont_next_call_by='" + tOSR.Value + "',cont_osr_date='" + Today.ToString + "'"
            Case Else
                cmd.CommandText += ",cont_status='" + cbDisp.Value + "' "
        End Select
        cmd.CommandText += ",cont_last_contact=getdate()  where cont_serial=" + CStr(CStr(gOSRCalls.ActiveRow.Cells(0).Value))
        cnn.Open()
        cmd.ExecuteNonQuery()
        If cbDisp.Value = "DNC" Then
            cmd.CommandText = "select dnc_serial from dnc_file where dnc_phone='" + Replace(tOSRPhone1.Text, "-", "") + "'"
            If nz(cmd.ExecuteScalar, 0) = 0 Then
                cmd.CommandText = "insert into dnc_file (dnc_phone,dnc_user,dnc_date) values ('" + Replace(tOSRPhone1.Text, "-", "") + "','" + User + "',getdate())"
                cmd.ExecuteNonQuery()
            End If
        End If
        'If tOSRNote.Text = "" Then tOSRNote.Text = "Call Center"
        cmd.CommandText = "insert into cont_note (cont_note_user,cont_note_cont_serial,cont_note_date,cont_note,cont_note_type) values ('" + User + "'," + CStr(gOSRCalls.ActiveRow.Cells(0).Value) + ",getdate(),'" + Replace(tOSRNote.Text, "'", "''") + "','" + cbDisp.Value + "')"
        cmd.ExecuteNonQuery()

        If IsDate(tCallBackDate.Text) = True And tOSR.Text <> "" Then
            Dim dtRep As New DataTable
            cmd.CommandText = "select rep_email from rep_file where rep_code='" + Replace(tOSR.Text, "'", "''") + "' and rep_type='O'"
            da.Fill(dtRep)
            If dtRep.Rows.Count > 1 Then
                SendMail(dtRep.Rows(0)("rep_email"), "toddw@winecellarinnovations.com", "New Lead", "You have a new lead: " + tOSRName.Text + " should be called on " + tCallBackDate.Text, , "dwitsken@jcom.cc")
            Else
                AddToDo("Call", tOSR.Text, "New Lead: " + tOSRName.Text + " should be called on " + tCallBackDate.Text, CLng(gOSRCalls.ActiveRow.Cells(0).Value), , , , tOSRName.Text, "Contact")
            End If
        End If

        cnn.Close()

        ClearValues()

        LoadOSRCalls()
    End Sub
    Private Sub ClearValues()
        cbDisp.Value = ""
        tOSRNote.Text = ""
        tCallBackDate.Value = DateAdd(DateInterval.Day, 1, Today)
        tCallBackTime.Value = "Any Time"
    End Sub

    Private Sub bImportFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImportFile.Click
        Dim ff As New OpenFileDialog

        ff.Filter = "Excel|*.xls;*.xlsx"
        If ff.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim ex As New Microsoft.Office.Interop.Excel.Application
            Dim fl As Microsoft.Office.Interop.Excel.Workbook
            Dim sh As Microsoft.Office.Interop.Excel.Worksheet
            Dim rg As Microsoft.Office.Interop.Excel.Range
            Dim rw As Integer
            Dim cmd As New SqlCommand("", cnn)
            Dim x As Integer = 0
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim doit As Boolean
            Dim cmdImport As New SqlCommand("", cnn)
            Dim data As Object(,)
            Dim importTime As Date = Now
            Dim importRef As Long
            Dim Skipped As Integer = 0

            tImportSrcNote.Text = Mid(IO.Path.GetFileName(ff.FileName), 1, 100)
            bImportFile.Enabled = False
            pbImport.Visible = True
            dtImport = New DataTable
            cmdImport.CommandText = "select cont_serial, cont_type, cont_name, cont_company, cont_addr1, cont_addr2, cont_addr3, cont_city, cont_state, cont_zip,cont_field_consult, last_update, update_by, inactive, "
            cmdImport.CommandText += "cont_ord_src, cont_ord_src_note, cont_status, cont_email, cont_phone1, cont_phone1_ext, cont_phone2, cont_phone2_ext, cont_cell, cont_fax, cont_notes, "
            cmdImport.CommandText += "cont_website, cont_inactive_reason, cont_cat_none, cont_cat_residential, cont_cat_commercial, cont_cat_mail, cont_cat_email, cont_next_call, "
            cmdImport.CommandText += "cont_next_call_time, cont_next_call_reason, cont_next_call_by, cont_next_call_rcfs_serial, cont_call_center_rep_code, cont_import_ref, cont_import_by, cont_import_time,cont_created_from_ord_serial from cont_file where cont_serial=-1"
            daImport.SelectCommand = cmdImport
            daImport.Fill(dtImport)

            fl = ex.Workbooks.Open(ff.FileName)
            sh = fl.Sheets(1)

            rg = sh.Range("A1", "T" + CStr(sh.UsedRange.Rows.Count))
            data = rg.Value

            cnn.Open()
            cmd.CommandText = "select max(cont_import_ref) from cont_file"
            importRef = nz(cmd.ExecuteScalar, 0)

            For rw = 2 To sh.UsedRange.Rows.Count
                dr = dtImport.NewRow

                dr("cont_company") = data(rw, 1)
                dr("cont_name") = data(rw, 2) + IIf(data(rw, 3) <> "", " " + data(rw, 3), "")
                dr("cont_addr1") = data(rw, 4)
                dr("cont_addr2") = data(rw, 5)
                dr("cont_addr3") = data(rw, 6)
                dr("cont_city") = data(rw, 7)
                dr("cont_state") = data(rw, 8)
                dr("cont_zip") = data(rw, 9)
                'dr("cont_type") = UCase(data(rw, 11))
                dr("cont_email") = data(rw, 12)
                dr("cont_website") = data(rw, 13)
                dr("cont_phone1") = CleanPhoneNumber(data(rw, 14))
                dr("cont_phone2") = CleanPhoneNumber(data(rw, 15))
                dr("cont_cell") = CleanPhoneNumber(data(rw, 16))
                dr("cont_fax") = CleanPhoneNumber(data(rw, 17))
                dr("cont_ord_src") = data(rw, 18)
                dr("cont_type") = data(rw, 19)
                If data(rw, 20) Is Nothing Then
                    dr("cont_field_consult") = 14
                Else
                    dr("cont_field_consult") = data(rw, 20)
                End If


                dr("last_update") = Now
                dr("update_by") = "Import"
                dr("cont_status") = "NEW"
                dr("cont_cat_none") = True
                dr("cont_cat_mail") = False
                dr("cont_cat_residential") = False
                dr("cont_cat_commercial") = False
                dr("cont_cat_email") = False
                dr("inactive") = False
                dr("cont_next_call") = Today
                dr("cont_next_call_time") = "0:00"
                dr("cont_next_call_by") = "Call Center"
                dr("cont_import_ref") = importRef + 1
                dr("cont_import_by") = User
                dr("cont_import_time") = importTime

                doit = True
                If nz(dr("cont_phone1")) = "" And nz(dr("cont_phone2")) = "" And nz(dr("cont_cell")) = "" Then
                    doit = False
                Else
                End If

                If doit Then
                    dtImport.Rows.Add(dr)
                Else
                    Skipped += 1
                End If

                pbImport.Value = rw / sh.UsedRange.Rows.Count * 100
            Next
            cnn.Close()
            ex.Workbooks.Close()
            ex = Nothing

            gImport.DataSource = dtImport
            gImport.DataBind()
            bImportFile.Enabled = True
            pbImport.Visible = False
            MsgBox("File loaded.  " + CStr(Skipped) + " records skipped." + vbCrLf + vbCrLf + "Next, review your data and then click 'Save Data'", MsgBoxStyle.OkOnly, "File Loaded")
        End If
    End Sub
    Private Sub bImportSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImportSave.Click
        Dim cname = ""
        Try

            If ddImportSrc.Text = "" Then
                MsgBox("You must have a Source Code", MsgBoxStyle.Information, "Source Code")
                ddImportSrc.Focus()
                Exit Sub
            End If
            If ddImportType.Text = "" Then
                MsgBox("You must have a Contact Type", MsgBoxStyle.Information, "Contact Type")
                ddImportType.Focus()
                Exit Sub
            End If
            If tImportSrcNote.Text = "" Then
                MsgBox("You must have a Source Code Note describing where the source of these leads came from.", MsgBoxStyle.Information, "Source Code Note")
                tImportSrcNote.Focus()
                Exit Sub
            End If

            Dim fm As New fmCallCenterAdminDialog
            If fm.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                fm.Close()
                fm = Nothing
                Exit Sub
            End If

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
            Dim OverwriteData As Boolean = fm.cbOverwrite.Checked
            Dim onNote As String
            Dim onAddr As String
            Dim onContSerial As Long

            fm.Close()
            fm = Nothing

            cnn.Open()
            For Each dr In dtImport.Rows
                If ddImportSrc.Text = "Use List" Then
                    'If InStr(SourceNotFound, dr("cont_ord_src") + ",") = 0 Then
                    cmd.CommandText = "select ord_src from ord_src where ord_src='" + dr("cont_ord_src") + "'"
                    If nz(cmd.ExecuteScalar) = "" Then
                        SourceNotFound += dr("cont_ord_src") + ","
                    End If
                    'End If
                Else
                    dr("cont_ord_src") = ddImportSrc.Value
                End If
                dr("cont_ord_src_note") = tImportSrcNote.Text

                If ddImportType.Text = "Use List" Then
                    If InStr(TypeNotFound, dr("cont_type") + ",") = 0 Then
                        cmd.CommandText = "select cont_type from cont_type where cont_type='" + dr("cont_type") + "'"
                        If nz(cmd.ExecuteScalar) = "" Then
                            TypeNotFound += dr("cont_type") + ","
                        End If
                    End If
                Else
                    dr("cont_type") = ddImportType.Value
                End If
            Next
            If TypeNotFound.Length > 0 Then
                cnn.Close()
                TypeNotFound = Mid(TypeNotFound, 1, TypeNotFound.Length - 1)
                MsgBox("Contact Types do not match valid types.  Invalid types found were " + TypeNotFound + ".")
                Exit Sub
            End If
            If SourceNotFound.Length > 0 Then
                cnn.Close()
                SourceNotFound = Mid(SourceNotFound, 1, SourceNotFound.Length - 1)
                MsgBox("Order Sources do not match valid types.  Invalid sources found were " + SourceNotFound + ".")
                Exit Sub
            End If

            For Each dr In dtImport.Rows
                dtCurrent = New DataTable
                onNote = ""
                cname = ""
                cname = dr("cont_name")
                cmd.CommandText = "select * from cont_file where cont_name='" + Replace(dr("cont_name"), "'", "''") + "' "
                If nz(dr("cont_phone1")) <> "" Or nz(dr("cont_phone2")) <> "" Or nz(dr("cont_cell")) <> "" Then
                    cmd.CommandText += "and ("
                End If
                If nz(dr("cont_phone1")) <> "" Then cmd.CommandText += "cont_phone_search like '%" + CleanPhoneNumber(nz(dr("cont_phone1"))) + "%' or "
                If nz(dr("cont_phone2")) <> "" Then cmd.CommandText += "cont_phone_search like '%" + CleanPhoneNumber(nz(dr("cont_phone2"))) + "%' or "
                If nz(dr("cont_cell")) <> "" Then cmd.CommandText += "cont_phone_search like '%" + CleanPhoneNumber(nz(dr("cont_cell"))) + "%' or "
                If nz(dr("cont_phone1")) <> "" Or nz(dr("cont_phone2")) <> "" Or nz(dr("cont_cell")) <> "" Then
                    cmd.CommandText = Mid(cmd.CommandText, 1, cmd.CommandText.Length - 4) + ") "
                End If
                cmd.CommandText += " and cont_name='" + Replace(dr("cont_name"), "'", "''") + "'"
                daCurrent.Fill(dtCurrent)

                If dtCurrent.Rows.Count = 0 Then
                    cmd.CommandText = "select * from cont_file where cont_name='" + Replace(dr("cont_name"), "'", "''") + "' and cont_addr1='" + Replace(nz(dr("cont_addr1")), "'", "''") + "'"
                    daCurrent.Fill(dtCurrent)
                End If

                If dtCurrent.Rows.Count = 0 And nz(dr("cont_email")) <> "" Then
                    cmd.CommandText = "select * from cont_file where cont_email='" + Replace(nz(dr("cont_email")), "'", "''") + "'"
                    daCurrent.Fill(dtCurrent)
                End If

                If dtCurrent.Rows.Count > 0 Then
                    dr.AcceptChanges()
                    If OverwriteData Then
                        drCurrent = dtCurrent.Rows(0)
                        If nz(dr("cont_addr1")) <> "" Then
                            If nz(drCurrent("cont_addr1")) <> nz(dr("cont_addr1")) Or nz(drCurrent("cont_addr2")) <> nz(dr("cont_addr2")) Or nz(drCurrent("cont_addr3")) <> nz(dr("cont_addr3")) Or nz(drCurrent("cont_city")) <> nz(dr("cont_city")) Or nz(drCurrent("cont_state")) <> nz(dr("cont_state")) Or nz(drCurrent("cont_zip")) <> nz(dr("cont_zip")) Then
                                onNote += "ADDRESS: " + drCurrent("cont_addr1") + ", " + drCurrent("cont_addr2") + ", " + drCurrent("cont_addr3") + ", " + drCurrent("cont_city") + ", " + drCurrent("cont_state") + ", " + drCurrent("cont_zip") + " -> " + dr("cont_addr1") + ", " + dr("cont_addr2") + ", " + dr("cont_addr3") + ", " + dr("cont_city") + ", " + dr("cont_state") + ", " + dr("cont_zip") + "; "
                            End If
                            drCurrent("cont_addr1") = dr("cont_addr1")
                            drCurrent("cont_addr2") = dr("cont_addr2")
                            drCurrent("cont_addr3") = dr("cont_addr3")
                            drCurrent("cont_city") = dr("cont_city")
                            drCurrent("cont_state") = dr("cont_state")
                            drCurrent("cont_zip") = dr("cont_zip")
                        End If
                        If nz(dr("cont_name")) <> "" And nz(drCurrent("cont_name")) <> nz(dr("cont_name")) Then
                            onNote += nz(drCurrent("cont_name")) + " -> " + dr("cont_name") + "; "
                            drCurrent("cont_name") = dr("cont_name")
                        End If
                        If nz(dr("cont_company")) <> "" And nz(drCurrent("cont_company")) <> nz(dr("cont_company")) Then
                            onNote += nz(drCurrent("cont_company")) + " -> " + dr("cont_company") + "; "
                            drCurrent("cont_company") = dr("cont_company")
                        End If
                        If nz(dr("cont_email")) <> "" And nz(drCurrent("cont_email")) <> nz(dr("cont_email")) Then
                            onNote += nz(drCurrent("cont_email")) + " -> " + dr("cont_email") + "; "
                            drCurrent("cont_email") = dr("cont_email")
                        End If
                        If nz(dr("cont_website")) <> "" And nz(drCurrent("cont_website")) <> nz(dr("cont_website")) Then
                            onNote += nz(drCurrent("cont_website")) + " -> " + dr("cont_website") + "; "
                            drCurrent("cont_website") = dr("cont_website")
                        End If
                        If nz(dr("cont_phone1")) <> "" And nz(drCurrent("cont_phone1")) <> nz(dr("cont_phone1")) Then
                            onNote += nz(drCurrent("cont_phone1")) + " -> " + dr("cont_phone1") + "; "
                            drCurrent("cont_phone1") = dr("cont_phone1")
                        End If
                        If nz(dr("cont_phone2")) <> "" And nz(drCurrent("cont_phone2")) <> nz(dr("cont_phone2")) Then
                            onNote += nz(drCurrent("cont_phone2")) + " -> " + dr("cont_phone2") + "; "
                            drCurrent("cont_phone2") = dr("cont_phone2")
                        End If
                        If nz(dr("cont_cell")) <> "" And nz(drCurrent("cont_cell")) <> nz(dr("cont_cell")) Then
                            onNote += nz(drCurrent("cont_cell")) + " -> " + dr("cont_cell") + "; "
                            drCurrent("cont_cell") = dr("cont_cell")
                        End If
                        If nz(dr("cont_fax")) <> "" And nz(drCurrent("cont_fax")) <> nz(dr("cont_fax")) Then
                            onNote += nz(drCurrent("cont_fax")) + " -> " + dr("cont_fax") + "; "
                            drCurrent("cont_fax") = dr("cont_fax")
                        End If
                        If nz(dr("cont_type")) <> "" And nz(drCurrent("cont_type")) <> nz(dr("cont_type")) Then
                            onNote += nz(drCurrent("cont_type")) + " -> " + dr("cont_type") + "; "
                            drCurrent("cont_type") = dr("cont_type")
                        End If
                        AddSourceCode(drCurrent("cont_serial"), dr("cont_ord_src"))
                        cbCurrent.RefreshSchema()
                        Try

                            daCurrent.Update(dtCurrent)
                        Catch ex As Exception

                        End Try
                        If onNote <> "" Then
                            cmd.CommandText = "insert into cont_note (cont_note_cont_serial,cont_note_user,cont_note_date,cont_note_type,cont_note) values (" + CStr(drCurrent("cont_serial")) + ",'" + User + "',getdate(),'Import Update','" + Replace(onNote, "'", "''") + "')"
                            cmd.ExecuteNonQuery()
                        End If
                        cntUpdated += 1
                    Else
                        cntSkipped += 1
                    End If
                Else
                    cmd.CommandText = "insert into cont_file ( cont_type,cont_field_consult, cont_name, cont_company, cont_addr1, cont_addr2, cont_addr3, cont_city, cont_state, cont_zip, last_update, update_by, inactive, "
                    cmd.CommandText += "cont_ord_src, cont_ord_src_note, cont_status, cont_email, cont_phone1, cont_phone1_ext, cont_phone2, cont_phone2_ext, cont_cell, cont_fax, cont_notes, cont_website, "
                    cmd.CommandText += "cont_inactive_reason, cont_cat_none, cont_cat_residential, cont_cat_commercial, cont_cat_mail, cont_cat_email, cont_next_call, cont_next_call_time, "
                    cmd.CommandText += "cont_next_call_reason, cont_next_call_by, cont_next_call_rcfs_serial, cont_call_center_rep_code, cont_import_ref, cont_import_by, "
                    cmd.CommandText += "cont_import_time, cont_created_from_ord_serial,cont_create_date) values ("
                    cmd.CommandText += "'" + Replace(nz(dr("cont_type")), "'", "''") + "',"
                    cmd.CommandText += "" + nz2(dr("cont_field_consult"), 14).ToString + ","
                    cmd.CommandText += "'" + Replace(nz(dr("cont_name")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_company")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_addr1")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_addr2")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_addr3")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_city")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_state")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_zip")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("last_update")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("update_by")), "'", "''") + "',"
                    cmd.CommandText += "" + IIf(nz(dr("inactive"), False), "1", "0") + ","
                    cmd.CommandText += "'" + Replace(nz(dr("cont_ord_src")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_ord_src_note")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_status")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_email")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(CleanPhoneNumber(nz(dr("cont_phone1"))), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_phone1_ext")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(CleanPhoneNumber(nz(dr("cont_phone2"))), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_phone2_ext")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(CleanPhoneNumber(nz(dr("cont_cell"))), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(CleanPhoneNumber(nz(dr("cont_fax"))), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_notes")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_website")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_inactive_reason")), "'", "''") + "',"
                    cmd.CommandText += "" + IIf(nz(dr("cont_cat_none"), False), "1", "0") + ","
                    cmd.CommandText += "" + IIf(nz(dr("cont_cat_residential"), False), "1", "0") + ","
                    cmd.CommandText += "" + IIf(nz(dr("cont_cat_commercial"), False), "1", "0") + ","
                    cmd.CommandText += "" + IIf(nz(dr("cont_cat_mail"), False), "1", "0") + ","
                    cmd.CommandText += "" + IIf(nz(dr("cont_cat_email"), False), "1", "0") + ","
                    cmd.CommandText += "'" + Replace(nz(dr("cont_next_call")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_next_call_time")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_next_call_reason")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_next_call_by")), "'", "''") + "',"
                    cmd.CommandText += "" + CStr(nz(dr("cont_next_call_rcfs_serial"), 0)) + ","
                    cmd.CommandText += "'" + Replace(nz(dr("cont_call_center_rep_code")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_import_ref"), False), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_import_by"), False), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_import_time"), False), "'", "''") + "',"
                    cmd.CommandText += "" + CStr(nz(dr("cont_created_from_ord_serial"), 0)) + ","
                    cmd.CommandText += "'" + CStr(Today) + "')"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "select @@identity"
                    onContSerial = cmd.ExecuteScalar

                    AddSourceCode(onContSerial, dr("cont_ord_src"))

                    cntAdded += 1
                End If
            Next


            bImportSave.Enabled = False

            'cb.RefreshSchema()
            'daImport.Update(dtImport)

            For Each dr In dtImport.Rows
                'cmd.CommandText="update ord_file set ord_cont_serial="+dr(
            Next

            bImportSave.Enabled = True
            MsgBox("Import Complete for " + CStr(dtImport.Rows.Count) + " records. " + vbCrLf + vbCrLf + CStr(cntAdded) + " Added. " + vbCrLf + CStr(cntUpdated) + " Updated." + vbCrLf + CStr(cntSkipped) + " Skipped.", MsgBoxStyle.OkOnly, "Complete")
        Catch
            MsgBox(Err.Description.ToString + " - " + cname)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub UltraTabPageControl4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles UltraTabPageControl4.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fb As New OpenFileDialog
        fb.Filter = "Excel Files (*.xls)|*.xls"
        If fb.ShowDialog = DialogResult.OK Then
            Dim ex As New Excel.Application
            Dim fl As Excel.Workbook
            Dim sh As Excel.Worksheet
            Dim rg As Excel.Range
            Dim rw As Integer
            Dim data As Object(,)
            Dim cb As New SqlCommandBuilder(da)

            Dim x As Integer = 0

            ds = New DataSet
            cmd.CommandText = "select cont_serial, cont_type, cont_name, cont_company, cont_addr1, cont_addr2, cont_addr3, cont_city, cont_state, cont_zip, last_update, update_by, inactive, cont_ord_src, cont_ord_src_note, cont_status, cont_email, cont_phone1, cont_phone1_ext, cont_phone2, cont_phone2_ext, cont_cell, cont_fax, cont_notes, cont_website, cont_inactive_reason, cont_cat_none, cont_cat_residential, cont_cat_commercial, cont_cat_material, cont_cat_mail, cont_cat_email, cont_next_call, cont_next_call_time, cont_next_call_reason, cont_next_call_by, cont_next_call_rcfs_serial, cont_call_center_rep_code, cont_osr, cont_import_ref from cont_file where cont_serial=-1"
            da.Fill(ds)

            fl = ex.Workbooks.Open(fb.FileName)
            sh = fl.Sheets(1)
            data = sh.Range("A1", sh.Cells(sh.UsedRange.Rows.Count, sh.UsedRange.Columns.Count + 1)).Value
            For rw = 1 To sh.UsedRange.Rows.Count
                'lExcel.Text = "Reading Excel Line: " + CStr(rw) + " of " + CStr(sh.UsedRange.Rows.Count)
                Application.DoEvents()
                ReadRowNew(rw, data)
            Next

            da.Update(ds)
            'Grid1.DataSource = ds.Tables(0)
            ex.Workbooks.Close()
            ex = Nothing
        End If
    End Sub
    Private Sub ReadRowNew(ByRef rw As Integer, ByRef sh As Array)
        Dim rg As String
        Dim x As Integer = 1
        Dim ln As String
        Dim doit As Boolean = False

        Dim dr As DataRow = ds.Tables(0).NewRow
        dr("cont_type") = "Not Defined"
        dr("cont_import_ref") = 1

        rg = sh(rw, 3)
        dr("cont_company") = Replace(rg, """", "")
        If rg <> "" Then doit = True
        rg = sh(rw, 4)
        dr("cont_name") = Replace(rg, """", "")
        rg = sh(rw, 5)
        If rg <> "" Then doit = True
        dr("cont_addr1") = Replace(rg, """", "")
        rg = sh(rw, 6)
        dr("cont_addr2") = IIf(rg = "", "", "Suite " + Replace(rg, """", ""))
        rg = sh(rw, 8)
        dr("cont_city") = Replace(rg, """", "")
        rg = sh(rw, 9)
        dr("cont_state") = Replace(rg, """", "")
        rg = sh(rw, 10)
        dr("cont_zip") = Replace(rg, """", "")
        rg = sh(rw, 13)
        dr("cont_phone1") = nz(Replace(rg, """", ""))
        If rg <> "" Then doit = True
        dr("cont_phone2") = ""
        dr("cont_cell") = ""
        dr("cont_osr") = "CHRISM"

        If doit Then ds.Tables(0).Rows.Add(dr)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fb As New OpenFileDialog
        fb.Filter = "Excel Files (*.xls)|*.xls"
        If fb.ShowDialog = DialogResult.OK Then
            Dim ex As New Excel.Application
            Dim fl As Excel.Workbook
            Dim sh As Excel.Worksheet
            Dim rg As String
            Dim rw As Integer
            Dim data As Object(,)
            Dim cb As New SqlCommandBuilder(da)
            Dim onCont As Long

            Dim x As Integer = 0

            fl = ex.Workbooks.Open(fb.FileName)
            sh = fl.Sheets(1)
            data = sh.Range("A1", sh.Cells(sh.UsedRange.Rows.Count, sh.UsedRange.Columns.Count + 1)).Value
            cnn.Open()
            For rw = 1 To sh.UsedRange.Rows.Count
                'lExcel.Text = "Reading Excel Line: " + CStr(rw) + " of " + CStr(sh.UsedRange.Rows.Count)
                'Application.DoEvents()
                'ReadRowNew(rw, data)

                rg = data(rw, 3)
                cmd.CommandText = "select cont_serial from cont_file where cont_phone_search like '%" + rg + "%'"
                onCont = nz(cmd.ExecuteScalar, 0)
                If onCont = 0 Then
                    rg = data(rw, 1)
                    cmd.CommandText = "select cont_serial from cont_file where cont_name = '" + rg + "'"
                    onCont = nz(cmd.ExecuteScalar, 0)
                End If

                If onCont > 0 Then
                    cmd.CommandText = "update cont_file set cont_status='Call Back'"
                    rg = data(rw, 4)
                    If rg = "" Then rg = CStr(Today)
                    cmd.CommandText += ",cont_next_call='" + rg + "',cont_next_call_time='0:00',cont_next_call_by='CHRISM',cont_next_call_reason='On Act To Do List'"
                    cmd.CommandText += " where cont_serial=" + CStr(onCont)
                    cmd.ExecuteNonQuery()
                End If
            Next
            cnn.Close()
            'da.Update(ds)
            'Grid1.DataSource = ds.Tables(0)
            ex.Workbooks.Close()
            ex = Nothing
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LoadCallers()
    End Sub

    Private Sub bLoadOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLoadOrders.Click
        Dim ex As New Microsoft.Office.Interop.Excel.Application
        Dim fl As Microsoft.Office.Interop.Excel.Workbook
        Dim sh As Microsoft.Office.Interop.Excel.Worksheet
        Dim rg As Microsoft.Office.Interop.Excel.Range
        Dim rw As DataRow
        Dim x As Integer = 0
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim doit As Boolean
        Dim cmdImport As New SqlCommand("", cnn)
        Dim data As Object(,)
        Dim importTime As Date = Now
        Dim importRef As Long
        Dim Skipped As Integer = 0

        'cnn.Open()
        'cmd.CommandText = "SELECT     ord_gen.ord_gen_src, ord_file.ord_cont_serial FROM         ord_file INNER JOIN                      ord_gen_latest_rev ON ord_file.ord_serial = ord_gen_latest_rev.ord_gen_ord_serial INNER JOIN                      ord_gen ON ord_gen_latest_rev.ord_gen_ord_serial = ord_gen.ord_gen_ord_serial AND ord_gen_latest_rev.ord_gen_type = ord_gen.ord_gen_type AND                       ord_gen_latest_rev.ord_gen_rev = ord_gen.ord_gen_rev WHERE     (ord_gen_latest_rev.ord_gen_type = 'Q') AND                          ((SELECT     COUNT(*) AS Expr1                              FROM         cont_src                              WHERE     (cont_src_cont_serial = ord_file.ord_cont_serial)) = 0) AND                          ((SELECT     cont_serial                              FROM         cont_file                              WHERE     (cont_serial = ord_file.ord_cont_serial)) > 0)"
        'da.Fill(dt)
        'For Each dr In dt.Rows
        '    AddSourceCode(dr("ord_cont_serial"), dr("ord_gen_src"))
        'Next
        'cnn.Close()
        'Exit Sub

        bLoadOrders.Enabled = False
        pbImport.Visible = True
        dtImport = New DataTable
        cmdImport.CommandText = "select cont_serial, cont_type, cont_name, cont_company, cont_addr1, cont_addr2, cont_addr3, cont_city, cont_state, cont_zip, last_update, update_by, inactive, "
        cmdImport.CommandText += "cont_ord_src, cont_ord_src_note, cont_status, cont_email, cont_phone1, cont_phone1_ext, cont_phone2, cont_phone2_ext, cont_cell, cont_fax, cont_notes, "
        cmdImport.CommandText += "cont_website, cont_inactive_reason, cont_cat_none, cont_cat_residential, cont_cat_commercial, cont_cat_mail, cont_cat_email, cont_next_call, "
        cmdImport.CommandText += "cont_next_call_time, cont_next_call_reason, cont_next_call_by, cont_next_call_rcfs_serial, cont_call_center_rep_code, cont_import_ref, cont_import_by, cont_import_time,cont_created_from_ord_serial from cont_file where cont_serial=-1"
        daImport.SelectCommand = cmdImport
        daImport.Fill(dtImport)

        cnn.Open()
        cmd.CommandText = "select max(cont_import_ref) from cont_file"
        importRef = nz(cmd.ExecuteScalar, 0)

        cmd.CommandText = "select top 10000 ord_file.* from ord_file where ord_serial>=120000 and isnull(ord_sold_cust_id,'')='' and isnull(ord_cont_serial,0)=0 and ord_sold_country='USA'"
        da.Fill(dt)

        dtImport.Clear()
        For Each rw In dt.Rows
            dr = dtImport.NewRow

            dr("cont_company") = rw("ord_sold_company")
            dr("cont_name") = rw("ord_sold_name")
            dr("cont_addr1") = rw("ord_sold_addr1")
            dr("cont_addr2") = rw("ord_sold_addr2")
            dr("cont_addr3") = rw("ord_sold_addr3")
            dr("cont_city") = rw("ord_sold_city")
            dr("cont_state") = rw("ord_sold_state")
            dr("cont_zip") = rw("ord_sold_zip")
            dr("cont_email") = rw("ord_sold_email")
            dr("cont_phone1") = CleanPhoneNumber(nz(rw("ord_sold_phone1")))
            dr("cont_phone2") = CleanPhoneNumber(nz(rw("ord_sold_phone2")))
            dr("cont_cell") = CleanPhoneNumber(nz(rw("ord_sold_cell")))
            dr("cont_fax") = CleanPhoneNumber(nz(rw("ord_sold_fax")))
            dr("cont_ord_src") = ""
            dr("cont_type") = "Other"
            dr("cont_created_from_ord_serial") = rw("ord_serial")

            dr("last_update") = Now
            dr("update_by") = "Import"
            dr("cont_status") = "IDLE"
            dr("cont_cat_none") = True
            dr("cont_cat_mail") = False
            dr("cont_cat_residential") = False
            dr("cont_cat_commercial") = False
            dr("cont_cat_email") = False
            dr("inactive") = False
            dr("cont_next_call") = "1/1/1900"
            dr("cont_next_call_time") = "0:00"
            dr("cont_next_call_by") = ""
            dr("cont_import_ref") = importRef + 1
            dr("cont_import_by") = User
            dr("cont_import_time") = importTime

            doit = True
            'If nz(dr("cont_phone1")) = "" And nz(dr("cont_phone2")) = "" And nz(dr("cont_cell")) = "" Then
            '    doit = False
            'End If
            If nz(dr("cont_name")) = "" And nz(dr("cont_company")) = "" Then
                doit = False
            End If

            If doit Then
                dtImport.Rows.Add(dr)
            Else
                Skipped += 1
            End If

        Next
        cnn.Close()

        gImport.DataSource = dtImport
        gImport.DataBind()
        bLoadOrders.Enabled = True
        pbImport.Visible = False
        MsgBox("Orders loaded.  " + CStr(Skipped) + " records skipped." + vbCrLf + vbCrLf + "Next, review your data and then click 'Save Data'", MsgBoxStyle.OkOnly, "File Loaded")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim fm As New fmCallCenterAdminDialog
        If fm.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            fm.Close()
            fm = Nothing
            Exit Sub
        End If

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
        Dim OverwriteData As Boolean = fm.cbOverwrite.Checked
        Dim onNote As String
        Dim onAddr As String
        Dim UpdateSQL As String = ""
        Dim onContSerial As Long

        fm.Close()
        fm = Nothing

        cnn.Open()
        'For Each dr In dtImport.Rows
        '    If ddImportSrc.Text = "Use List" Then
        '        If InStr(SourceNotFound, dr("cont_ord_src") + ",") = 0 Then
        '            cmd.CommandText = "select ord_src from ord_src where ord_src='" + dr("cont_ord_src") + "'"
        '            If nz(cmd.ExecuteScalar) = "" Then
        '                SourceNotFound += dr("cont_ord_src") + ","
        '            End If
        '        End If
        '    Else
        '        dr("cont_ord_src") = ddImportSrc.Value
        '    End If
        '    dr("cont_ord_src_note") = tImportSrcNote.Text

        '    If ddImportType.Text = "Use List" Then
        '        If InStr(TypeNotFound, dr("cont_type") + ",") = 0 Then
        '            cmd.CommandText = "select cont_type from cont_type where cont_type='" + dr("cont_type") + "'"
        '            If nz(cmd.ExecuteScalar) = "" Then
        '                TypeNotFound += dr("cont_type") + ","
        '            End If
        '        End If
        '    Else
        '        dr("cont_type") = ddImportType.Value
        '    End If
        'Next
        'If TypeNotFound.Length > 0 Then
        '    cnn.Close()
        '    TypeNotFound = Mid(TypeNotFound, 1, TypeNotFound.Length - 1)
        '    MsgBox("Contact Types do not match valid types.  Invalid types found were " + TypeNotFound + ".")
        '    Exit Sub
        'End If
        'If SourceNotFound.Length > 0 Then
        '    cnn.Close()
        '    SourceNotFound = Mid(SourceNotFound, 1, SourceNotFound.Length - 1)
        '    MsgBox("Order Sources do not match valid types.  Invalid sources found were " + SourceNotFound + ".")
        '    Exit Sub
        'End If
        Button4.Enabled = False
        For Each dr In dtImport.Rows
            dtCurrent = New DataTable
            onNote = ""
            UpdateSQL = "update cont_file set "

            cmd.CommandText = "select * from cont_file where cont_name='" + Replace(dr("cont_name"), "'", "''") + "' and ("
            If nz(dr("cont_phone1")) <> "" Then cmd.CommandText += "cont_phone_search like '%" + nz(dr("cont_phone1")) + "%' or "
            If nz(dr("cont_phone2")) <> "" Then cmd.CommandText += "cont_phone_search like '%" + nz(dr("cont_phone2")) + "%' or "
            If nz(dr("cont_cell")) <> "" Then cmd.CommandText += "cont_phone_search like '%" + nz(dr("cont_cell")) + "%' or "
            If Microsoft.VisualBasic.Right(cmd.CommandText, 1) = "(" Then
                cmd.CommandText = Mid(cmd.CommandText, 1, cmd.CommandText.Length - 5)
            Else
                cmd.CommandText = Mid(cmd.CommandText, 1, cmd.CommandText.Length - 4) + ")"
            End If
            daCurrent.Fill(dtCurrent)

            If dtCurrent.Rows.Count = 0 Then
                cmd.CommandText = "select * from cont_file where cont_name='" + Replace(dr("cont_name"), "'", "''") + "' and cont_addr1='" + Replace(nz(dr("cont_addr1")), "'", "''") + "'"
                daCurrent.Fill(dtCurrent)
            End If

            If dtCurrent.Rows.Count = 0 Then
                If nz(dr("cont_email")) <> "" Then
                    cmd.CommandText = "select * from cont_file where cont_email='" + Replace(dr("cont_email"), "'", "''") + "'"
                    daCurrent.Fill(dtCurrent)
                End If
            End If

            If dtCurrent.Rows.Count > 0 Then
                dr.AcceptChanges()
                If OverwriteData Then
                    drCurrent = dtCurrent.Rows(0)
                    onContSerial = drCurrent("cont_serial")
                    If nz(dr("cont_addr1")) <> "" Then
                        If nz(drCurrent("cont_addr1")) <> nz(dr("cont_addr1")) Or nz(drCurrent("cont_addr2")) <> nz(dr("cont_addr2")) Or nz(drCurrent("cont_addr3")) <> nz(dr("cont_addr3")) Or nz(drCurrent("cont_city")) <> nz(dr("cont_city")) Or nz(drCurrent("cont_state")) <> nz(dr("cont_state")) Or nz(drCurrent("cont_zip")) <> nz(dr("cont_zip")) Then
                            onNote += "ADDRESS: " + drCurrent("cont_addr1") + ", " + drCurrent("cont_addr2") + ", " + drCurrent("cont_addr3") + ", " + drCurrent("cont_city") + ", " + drCurrent("cont_state") + ", " + drCurrent("cont_zip") + " -> " + dr("cont_addr1") + ", " + dr("cont_addr2") + ", " + dr("cont_addr3") + ", " + dr("cont_city") + ", " + dr("cont_state") + ", " + dr("cont_zip") + "; "
                        End If
                        drCurrent("cont_addr1") = dr("cont_addr1")
                        drCurrent("cont_addr2") = dr("cont_addr2")
                        drCurrent("cont_addr3") = dr("cont_addr3")
                        drCurrent("cont_city") = dr("cont_city")
                        drCurrent("cont_state") = dr("cont_state")
                        drCurrent("cont_zip") = dr("cont_zip")
                        UpdateSQL += "cont_addr1='" + Replace(dr("cont_addr1"), "'", "''") + "',cont_addr2='" + Replace(dr("cont_addr2"), "'", "''") + "',cont_addr3='" + Replace(dr("cont_addr3"), "'", "''") + "',cont_city='" + Replace(dr("cont_city"), "'", "''") + "',cont_state='" + Replace(dr("cont_state"), "'", "''") + "',cont_zip='" + Replace(dr("cont_zip"), "'", "''") + "',"
                    End If
                    If nz(dr("cont_name")) <> "" And nz(drCurrent("cont_name")) <> nz(dr("cont_name")) Then
                        onNote += nz(drCurrent("cont_name")) + " -> " + dr("cont_name") + "; "
                        drCurrent("cont_name") = dr("cont_name")
                        UpdateSQL += "cont_name='" + Replace(dr("cont_name"), "'", "''") + "',"
                    End If
                    If nz(dr("cont_company")) <> "" And nz(drCurrent("cont_company")) <> nz(dr("cont_company")) Then
                        onNote += nz(drCurrent("cont_company")) + " -> " + dr("cont_company") + "; "
                        drCurrent("cont_company") = dr("cont_company")
                        UpdateSQL += "cont_company='" + Replace(dr("cont_company"), "'", "''") + "',"
                    End If
                    If nz(dr("cont_email")) <> "" And nz(drCurrent("cont_email")) <> nz(dr("cont_email")) Then
                        onNote += nz(drCurrent("cont_email")) + " -> " + dr("cont_email") + "; "
                        drCurrent("cont_email") = dr("cont_email")
                        UpdateSQL += "cont_email='" + Replace(dr("cont_email"), "'", "''") + "',"
                    End If
                    If nz(dr("cont_website")) <> "" And nz(drCurrent("cont_website")) <> nz(dr("cont_website")) Then
                        onNote += nz(drCurrent("cont_website")) + " -> " + dr("cont_website") + "; "
                        drCurrent("cont_website") = dr("cont_website")
                        UpdateSQL += "cont_website='" + Replace(dr("cont_website"), "'", "''") + "',"
                    End If
                    If nz(dr("cont_phone1")) <> "" And nz(drCurrent("cont_phone1")) <> nz(dr("cont_phone1")) Then
                        onNote += nz(drCurrent("cont_phone1")) + " -> " + dr("cont_phone1") + "; "
                        drCurrent("cont_phone1") = dr("cont_phone1")
                        UpdateSQL += "cont_phone1='" + Replace(dr("cont_phone1"), "'", "''") + "',"
                    End If
                    If nz(dr("cont_phone2")) <> "" And nz(drCurrent("cont_phone2")) <> nz(dr("cont_phone2")) Then
                        onNote += nz(drCurrent("cont_phone2")) + " -> " + dr("cont_phone2") + "; "
                        drCurrent("cont_phone2") = dr("cont_phone2")
                        UpdateSQL += "cont_phone2='" + Replace(dr("cont_phone2"), "'", "''") + "',"
                    End If
                    If nz(dr("cont_cell")) <> "" And nz(drCurrent("cont_cell")) <> nz(dr("cont_cell")) Then
                        onNote += nz(drCurrent("cont_cell")) + " -> " + dr("cont_cell") + "; "
                        drCurrent("cont_cell") = dr("cont_cell")
                        UpdateSQL += "cont_cell='" + Replace(dr("cont_cell"), "'", "''") + "',"
                    End If
                    If nz(dr("cont_fax")) <> "" And nz(drCurrent("cont_fax")) <> nz(dr("cont_fax")) Then
                        onNote += nz(drCurrent("cont_fax")) + " -> " + dr("cont_fax") + "; "
                        drCurrent("cont_fax") = dr("cont_fax")
                        UpdateSQL += "cont_fax='" + Replace(dr("cont_fax"), "'", "''") + "',"
                    End If
                    If nz(dr("cont_type")) <> "" And nz(drCurrent("cont_type")) <> nz(dr("cont_type")) Then
                        onNote += nz(drCurrent("cont_type")) + " -> " + dr("cont_type") + "; "
                        drCurrent("cont_type") = dr("cont_type")
                        UpdateSQL += "cont_type='" + Replace(dr("cont_type"), "'", "''") + "',"
                    End If
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
                    cntUpdated += 1
                Else
                    cntSkipped += 1
                End If
            Else
                cntAdded += 1
            End If

            If dr.RowState = DataRowState.Added Then
                cmd.CommandText = "insert into cont_file (cont_type, cont_name, cont_company, cont_addr1, cont_addr2, cont_addr3, cont_city, cont_state, cont_zip, last_update, update_by, inactive,"
                cmd.CommandText += "cont_ord_src, cont_ord_src_note, cont_status, cont_email, cont_phone1, cont_phone1_ext,cont_phone2, cont_phone2_ext, cont_cell, cont_fax, cont_notes,cont_website,"
                cmd.CommandText += " cont_inactive_reason, cont_next_call,cont_next_call_time, cont_next_call_reason, cont_next_call_by, cont_next_call_rcfs_serial, cont_call_center_rep_code, cont_import_ref, cont_import_by, cont_import_time,cont_created_from_ord_serial) values ("
                cmd.CommandText += "'" + dr("cont_type") + "',"
                cmd.CommandText += "'" + Replace(dr("cont_name"), "'", "''") + "',"
                cmd.CommandText += "'" + Replace(dr("cont_company"), "'", "''") + "',"
                cmd.CommandText += "'" + Replace(dr("cont_addr1"), "'", "''") + "',"
                cmd.CommandText += "'" + Replace(dr("cont_addr2"), "'", "''") + "',"
                cmd.CommandText += "'" + Replace(dr("cont_addr3"), "'", "''") + "',"
                cmd.CommandText += "'" + Replace(dr("cont_city"), "'", "''") + "',"
                cmd.CommandText += "'" + dr("cont_state") + "',"
                cmd.CommandText += "'" + dr("cont_zip") + "',"
                cmd.CommandText += "'" + dr("last_update") + "',"
                cmd.CommandText += "'" + dr("update_by") + "',"
                cmd.CommandText += IIf(dr("inactive"), "1", "0") + ","
                cmd.CommandText += "'" + dr("cont_ord_src") + "',"
                cmd.CommandText += "'" + Replace(nz(dr("cont_ord_src_note")), "'", "''") + "',"
                cmd.CommandText += "'" + dr("cont_status") + "',"
                cmd.CommandText += "'" + Replace(dr("cont_email"), "'", "''") + "',"
                cmd.CommandText += "'" + Replace(dr("cont_phone1"), "'", "''") + "',"
                cmd.CommandText += "'" + dr("cont_phone1_ext") + "',"
                cmd.CommandText += "'" + Replace(dr("cont_phone2"), "'", "''") + "',"
                cmd.CommandText += "'" + dr("cont_phone2_ext") + "',"
                cmd.CommandText += "'" + dr("cont_cell") + "',"
                cmd.CommandText += "'" + dr("cont_fax") + "',"
                cmd.CommandText += "'" + dr("cont_notes") + "',"
                cmd.CommandText += "'" + dr("cont_website") + "',"
                cmd.CommandText += "'" + dr("cont_inactive_reason") + "',"
                cmd.CommandText += "'" + dr("cont_next_call") + "',"
                cmd.CommandText += "'" + dr("cont_next_call_time") + "',"
                cmd.CommandText += "'" + dr("cont_next_call_reason") + "',"
                cmd.CommandText += "'" + dr("cont_next_call_by") + "',"
                cmd.CommandText += "'" + CStr(nz(dr("cont_next_call_rcfs_serial"), 0)) + "',"
                cmd.CommandText += "'" + dr("cont_call_center_rep_code") + "',"
                cmd.CommandText += "'" + CStr(dr("cont_import_ref")) + "',"
                cmd.CommandText += "'OrderLink',"
                cmd.CommandText += "'" + CStr(dr("cont_import_time")) + "',"
                cmd.CommandText += "" + CStr(dr("cont_created_from_ord_serial")) + ")"

                cmd.ExecuteNonQuery()
                cmd.CommandText = "select @@identity"
                onContSerial = cmd.ExecuteScalar

                AddSourceCode(onContSerial, dr("cont_ord_src"))

            Else
                If UpdateSQL <> "" Then
                    cmd.CommandText = UpdateSQL
                    cmd.ExecuteNonQuery()
                End If
            End If
            cmd.CommandText = "update ord_file set ord_cont_serial=" + CStr(onContSerial) + " where ord_serial=" + CStr(dr("cont_created_from_ord_serial"))
            cmd.ExecuteNonQuery()
        Next

        bImportSave.Enabled = False

        'cb.RefreshSchema()
        'daImport.Update(dtImport)

        cnn.Close()

        Button4.Enabled = True
        MsgBox("Import Complete for " + CStr(dtImport.Rows.Count) + " records. " + vbCrLf + vbCrLf + CStr(cntAdded) + " Added. " + vbCrLf + CStr(cntUpdated) + " Updated." + vbCrLf + CStr(cntSkipped) + " Skipped.", MsgBoxStyle.OkOnly, "Complete")

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim ff As New OpenFileDialog

        'ff.Filter = "Excel|*.xls;*.xlsx"
        If ff.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Dim ex As New Microsoft.Office.Interop.Excel.Application
            'Dim fl As Microsoft.Office.Interop.Excel.Workbook
            'Dim sh As Microsoft.Office.Interop.Excel.Worksheet
            'Dim rg As Microsoft.Office.Interop.Excel.Range
            Dim fl As New IO.StreamReader(ff.FileName)
            Dim ln As String
            Dim rw As Integer
            Dim cmd As New SqlCommand("", cnn)
            Dim x As Integer = 0
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim doit As Boolean
            Dim cmdImport As New SqlCommand("", cnn)
            Dim data As Object(,)
            Dim importTime As Date = Now
            Dim importRef As Long
            Dim Skipped As Integer = 0
            Dim cnt As Integer = 0

            'tImportSrcNote.Text = Mid(IO.Path.GetFileName(ff.FileName), 1, 100)
            bImportFile.Enabled = False
            pbImport.Visible = True
            dtImport = New DataTable
            cmdImport.CommandText = "select cont_serial, cont_type, cont_name, cont_company, cont_addr1, cont_addr2, cont_addr3, cont_city, cont_state, cont_zip, last_update, update_by, inactive, "
            cmdImport.CommandText += "cont_ord_src, cont_ord_src_note, cont_status, cont_email, cont_phone1, cont_phone1_ext, cont_phone2, cont_phone2_ext, cont_cell, cont_fax, cont_notes, "
            cmdImport.CommandText += "cont_website, cont_inactive_reason, cont_cat_none, cont_cat_residential, cont_cat_commercial, cont_cat_mail, cont_cat_email, cont_next_call, "
            cmdImport.CommandText += "cont_next_call_time, cont_next_call_reason, cont_next_call_by, cont_next_call_rcfs_serial, cont_call_center_rep_code, cont_import_ref, cont_import_by, cont_import_time,cont_created_from_ord_serial,cont_cat_com_email,cont_cat_com_mail,cont_cat_res_email,cont_cat_res_mail,cont_cat_mat_email,cont_cat_mat_mail from cont_file where cont_serial=-1"
            daImport.SelectCommand = cmdImport
            daImport.Fill(dtImport)

            'fl = ex.Workbooks.Open(ff.FileName)
            'sh = fl.Sheets(1)

            'rg = sh.Range("A1", "S" + CStr(sh.UsedRange.Rows.Count))
            'data = rg.Value



            cnn.Open()
            cmd.CommandText = "select max(cont_import_ref) from cont_file"
            importRef = nz(cmd.ExecuteScalar, 0)

            ln = fl.ReadLine
            Do While Not fl.EndOfStream
                Try
                    dr = dtImport.NewRow
                    doit = False

                    dr("cont_company") = Split(ln, "|")(3)
                    dr("cont_name") = Split(ln, "|")(4)
                    dr("cont_addr1") = Split(ln, "|")(5)
                    dr("cont_addr2") = Split(ln, "|")(6)
                    dr("cont_addr3") = Split(ln, "|")(7)
                    dr("cont_city") = Split(ln, "|")(8)
                    dr("cont_state") = Split(ln, "|")(9)
                    dr("cont_zip") = Split(ln, "|")(10)
                    'dr("cont_type") = UCase(data(rw, 11))
                    dr("cont_email") = Split(ln, "|")(13)
                    If Split(ln, "|").Length > 14 Then
                        dr("cont_website") = Split(ln, "|")(14)
                        dr("cont_phone1") = Split(ln, "|")(15)
                        dr("cont_phone2") = Split(ln, "|")(16)
                        dr("cont_cell") = ""
                        dr("cont_fax") = Split(ln, "|")(17)

                        cmd.CommandText = "select temp2 from [temp-jj] where temp1='" + Replace(Split(ln, "|")(18), "'", "''") + "'"
                        dr("cont_ord_src") = nz(cmd.ExecuteScalar)
                        If dr("cont_ord_src") = "" Then dr("cont_ord_src") = "Jan 2012 Mail List Merge"
                        dr("cont_type") = "Other"

                        dr("last_update") = Now
                        dr("update_by") = "MailList"
                        dr("cont_status") = "NEW"
                        Select Case UCase(Trim(Split(ln, "|")(20)))
                            Case "BOTH", "BOTH CALL", "BOTH WG"
                                dr("cont_cat_com_email") = True
                                dr("cont_cat_com_mail") = True
                                dr("cont_cat_res_email") = True
                                dr("cont_cat_res_mail") = True
                                cnt += 1
                                'doit = True
                            Case "RETAIL 2", "RETAIL/CDR", "RETIAL", "RETAIL", "RETAIL WG"
                                dr("cont_cat_com_email") = False
                                dr("cont_cat_com_mail") = False
                                dr("cont_cat_res_email") = True
                                dr("cont_cat_res_mail") = True
                            Case "CDR"
                                dr("cont_cat_com_email") = True
                                dr("cont_cat_com_mail") = True
                                dr("cont_cat_res_email") = False
                                dr("cont_cat_res_mail") = False
                                cnt += 1
                                'doit = True
                            Case "NONE", "NONE WG", ""
                                dr("cont_cat_com_email") = False
                                dr("cont_cat_com_mail") = False
                                dr("cont_cat_res_email") = False
                                dr("cont_cat_res_mail") = False
                            Case Else
                                ListBox1.Items.Add(UCase(Trim(Split(ln, "|")(20))))
                                dr("cont_cat_com_email") = False
                                dr("cont_cat_com_mail") = False
                                dr("cont_cat_res_email") = False
                                dr("cont_cat_res_mail") = False
                        End Select
                        If Split(ln, "|")(24) = "Y" Then
                            dr("cont_cat_mat_email") = True
                            dr("cont_cat_mat_mail") = True
                        Else
                            dr("cont_cat_mat_email") = False
                            dr("cont_cat_mat_mail") = False
                        End If
                    Else
                        dr("cont_website") = ""
                        dr("cont_phone1") = ""
                        dr("cont_phone2") = ""
                        dr("cont_cell") = ""
                        dr("cont_fax") = ""
                        dr("cont_ord_src") = ""
                        dr("cont_type") = "Other"

                        dr("last_update") = Now
                        dr("update_by") = "MailList"
                        dr("cont_status") = "NEW"
                        dr("cont_cat_com_email") = False
                        dr("cont_cat_com_mail") = False
                        dr("cont_cat_res_email") = False
                        dr("cont_cat_res_mail") = False
                        dr("cont_cat_mat_email") = False
                        dr("cont_cat_mat_mail") = False
                    End If
                    dr("inactive") = False
                    dr("cont_next_call") = Today
                    dr("cont_next_call_time") = "0:00"
                    dr("cont_next_call_by") = "Call Center"
                    dr("cont_import_ref") = importRef + 1
                    dr("cont_import_by") = User
                    dr("cont_import_time") = importTime

                    doit = True
                    'If nz(dr("cont_phone1")) = "" And nz(dr("cont_phone2")) = "" And nz(dr("cont_cell")) = "" Then
                    '    doit = False
                    'Else
                    'End If

                    If doit Then
                        dtImport.Rows.Add(dr)
                        rw += 1
                    Else
                        Skipped += 1
                    End If

                    'pbImport.Value = rw / sh.UsedRange.Rows.Count * 100
                Catch
                    'MsgBox(Err.Description)
                End Try
                ln = fl.ReadLine
            Loop
            MsgBox(cnt)
            cnn.Close()
            'ex.Workbooks.Close()
            'ex = Nothing

            gImport.DataSource = dtImport
            gImport.DataBind()
            bImportFile.Enabled = True
            pbImport.Visible = False
            MsgBox(CStr(rw) + " records loaded.  " + CStr(Skipped) + " records skipped." + vbCrLf + vbCrLf + "Next, review your data and then click 'Save Data'", MsgBoxStyle.OkOnly, "File Loaded")
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ddImportSrc.Text = "" Then
            MsgBox("You must have a Source Code", MsgBoxStyle.Information, "Source Code")
            ddImportSrc.Focus()
            Exit Sub
        End If
        If ddImportType.Text = "" Then
            MsgBox("You must have a Contact Type", MsgBoxStyle.Information, "Contact Type")
            ddImportType.Focus()
            Exit Sub
        End If
        If tImportSrcNote.Text = "" Then
            MsgBox("You must have a Source Code Note describing where the source of these leads came from.", MsgBoxStyle.Information, "Source Code Note")
            tImportSrcNote.Focus()
            Exit Sub
        End If

        Dim fm As New fmCallCenterAdminDialog
        If fm.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            fm.Close()
            fm = Nothing
            Exit Sub
        End If

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
        Dim cnt As Integer = 0
        Dim OverwriteData As Boolean = fm.cbOverwrite.Checked
        Dim onNote As String
        Dim onAddr As String
        Dim onContSerial As Long

        fm.Close()
        fm = Nothing

        cnn.Open()
        For Each dr In dtImport.Rows
            If ddImportSrc.Text = "Use List" Then
                'If InStr(SourceNotFound, dr("cont_ord_src") + ",") = 0 Then
                cmd.CommandText = "select ord_src from ord_src where ord_src='" + dr("cont_ord_src") + "'"
                If nz(cmd.ExecuteScalar) = "" Then
                    SourceNotFound += dr("cont_ord_src") + ","
                End If
                'End If
            Else
                dr("cont_ord_src") = ddImportSrc.Value
            End If
            dr("cont_ord_src_note") = tImportSrcNote.Text

            If ddImportType.Text = "Use List" Then
                If InStr(TypeNotFound, dr("cont_type") + ",") = 0 Then
                    cmd.CommandText = "select cont_type from cont_type where cont_type='" + dr("cont_type") + "'"
                    If nz(cmd.ExecuteScalar) = "" Then
                        TypeNotFound += dr("cont_type") + ","
                    End If
                End If
            Else
                dr("cont_type") = ddImportType.Value
            End If
        Next
        If TypeNotFound.Length > 0 Then
            cnn.Close()
            TypeNotFound = Mid(TypeNotFound, 1, TypeNotFound.Length - 1)
            MsgBox("Contact Types do not match valid types.  Invalid types found were " + TypeNotFound + ".")
            Exit Sub
        End If
        If SourceNotFound.Length > 0 Then
            cnn.Close()
            SourceNotFound = Mid(SourceNotFound, 1, SourceNotFound.Length - 1)
            MsgBox("Order Sources do not match valid types.  Invalid sources found were " + SourceNotFound + ".")
            Exit Sub
        End If

        For Each dr In dtImport.Rows
            Try
                dtCurrent = New DataTable
                onNote = ""
                cnt += 1
                If nz(dr("cont_name")) = "" Then
                    cmd.CommandText = "select * from cont_file where cont_company='" + Replace(dr("cont_company"), "'", "''") + "' and "
                Else
                    cmd.CommandText = "select * from cont_file where cont_name='" + Replace(dr("cont_name"), "'", "''") + "' and "
                End If
                If nz(dr("cont_phone1")) + nz(dr("cont_phone2")) + nz(dr("cont_cell")) <> "" Then cmd.CommandText += "("
                If nz(dr("cont_phone1")) <> "" Then cmd.CommandText += "cont_phone_search like '%" + nz(dr("cont_phone1")) + "%' or "
                If nz(dr("cont_phone2")) <> "" Then cmd.CommandText += "cont_phone_search like '%" + nz(dr("cont_phone2")) + "%' or "
                If nz(dr("cont_cell")) <> "" Then cmd.CommandText += "cont_phone_search like '%" + nz(dr("cont_cell")) + "%' or "
                cmd.CommandText = Mid(cmd.CommandText, 1, cmd.CommandText.Length - 4)
                If nz(dr("cont_phone1")) + nz(dr("cont_phone2")) + nz(dr("cont_cell")) <> "" Then cmd.CommandText += ")"
                daCurrent.Fill(dtCurrent)
                'onContSerial = nz(cmd.ExecuteScalar, 0)

                If onContSerial = 0 Then
                    If nz(dr("cont_name")) = "" Then
                        cmd.CommandText = "select * from cont_file where cont_company='" + Replace(dr("cont_company"), "'", "''") + "' and cont_addr1='" + Replace(nz(dr("cont_addr1")), "'", "''") + "'"
                    Else
                        cmd.CommandText = "select * from cont_file where cont_name='" + Replace(dr("cont_name"), "'", "''") + "' and cont_addr1='" + Replace(nz(dr("cont_addr1")), "'", "''") + "'"
                    End If
                    daCurrent.Fill(dtCurrent)

                End If

                If dtCurrent.Rows.Count = 0 And nz(dr("cont_email")) <> "" Then
                    cmd.CommandText = "select * from cont_file where cont_email='" + Replace(nz(dr("cont_email")), "'", "''") + "'"
                    daCurrent.Fill(dtCurrent)
                End If

                If dtCurrent.Rows.Count = 0 Then
                    cmd.CommandText = "select * from cont_file where cont_company='" + Replace(dr("cont_company"), "'", "''") + "' and cont_name='" + Replace(dr("cont_name"), "'", "''") + "' and cont_addr1='" + Replace(nz(dr("cont_addr1")), "'", "''") + "' and cont_phone1='" + Replace(dr("cont_phone1"), "'", "''") + "'"
                    daCurrent.Fill(dtCurrent)
                End If

                'If onContSerial > 0 Then
                '    cmd.CommandText = "update cont_file set cont_cat_com_email=" + IIf(dr("cont_cat_com_email"), "1", "0") + ",cont_cat_com_mail=" + IIf(dr("cont_cat_com_mail"), "1", "0") + ",cont_cat_res_email=" + IIf(dr("cont_cat_res_email"), "1", "0") + ",cont_cat_res_mail=" + IIf(dr("cont_cat_res_mail"), "1", "0") + ",cont_cat_mat_email=" + IIf(dr("cont_cat_mat_email"), "1", "0") + ",cont_cat_mat_mail=" + IIf(dr("cont_cat_mat_mail"), "1", "0") + " where cont_serial=" + CStr(onContSerial)
                '    cmd.ExecuteNonQuery()
                '    'drCurrent("cont_cat_com_email") = dr("cont_cat_com_email")
                '    'drCurrent("cont_cat_com_mail") = dr("cont_cat_com_mail")
                '    'drCurrent("cont_cat_res_email") = dr("cont_cat_res_email")
                '    'drCurrent("cont_cat_res_mail") = dr("cont_cat_res_mail")
                '    'drCurrent("cont_cat_mat_email") = dr("cont_cat_mat_email")
                '    'drCurrent("cont_cat_mat_mail") = dr("cont_cat_mat_mail")
                'Else
                '    MsgBox(dr("cont_name") + " not found")
                'End If

                'If onContSerial = 0 And nz(dr("cont_email")) <> "" Then
                '    cmd.CommandText = "select * from cont_file where cont_email='" + Replace(nz(dr("cont_email")), "'", "''") + "'"
                '    onContSerial = nz(cmd.ExecuteScalar, 0)

                'End If

                If dtCurrent.Rows.Count > 0 Then
                    dr.AcceptChanges()
                    If OverwriteData Then
                        drCurrent = dtCurrent.Rows(0)
                        If nz(dr("cont_addr1")) <> "" Then
                            If nz(drCurrent("cont_addr1")) <> nz(dr("cont_addr1")) Or nz(drCurrent("cont_addr2")) <> nz(dr("cont_addr2")) Or nz(drCurrent("cont_addr3")) <> nz(dr("cont_addr3")) Or nz(drCurrent("cont_city")) <> nz(dr("cont_city")) Or nz(drCurrent("cont_state")) <> nz(dr("cont_state")) Or nz(drCurrent("cont_zip")) <> nz(dr("cont_zip")) Then
                                onNote += "ADDRESS: " + drCurrent("cont_addr1") + ", " + drCurrent("cont_addr2") + ", " + drCurrent("cont_addr3") + ", " + drCurrent("cont_city") + ", " + drCurrent("cont_state") + ", " + drCurrent("cont_zip") + " -> " + dr("cont_addr1") + ", " + dr("cont_addr2") + ", " + dr("cont_addr3") + ", " + dr("cont_city") + ", " + dr("cont_state") + ", " + dr("cont_zip") + "; "
                            End If
                            drCurrent("cont_addr1") = dr("cont_addr1")
                            drCurrent("cont_addr2") = dr("cont_addr2")
                            drCurrent("cont_addr3") = dr("cont_addr3")
                            drCurrent("cont_city") = dr("cont_city")
                            drCurrent("cont_state") = dr("cont_state")
                            drCurrent("cont_zip") = dr("cont_zip")
                        End If
                        If nz(dr("cont_name")) <> "" And nz(drCurrent("cont_name")) <> nz(dr("cont_name")) Then
                            onNote += nz(drCurrent("cont_name")) + " -> " + dr("cont_name") + "; "
                            drCurrent("cont_name") = dr("cont_name")
                        End If
                        If nz(dr("cont_company")) <> "" And nz(drCurrent("cont_company")) <> nz(dr("cont_company")) Then
                            onNote += nz(drCurrent("cont_company")) + " -> " + dr("cont_company") + "; "
                            drCurrent("cont_company") = dr("cont_company")
                        End If
                        If nz(dr("cont_email")) <> "" And nz(drCurrent("cont_email")) = "" And nz(drCurrent("cont_email")) <> nz(dr("cont_email")) Then
                            onNote += nz(drCurrent("cont_email")) + " -> " + dr("cont_email") + "; "
                            drCurrent("cont_email") = dr("cont_email")
                        End If
                        If nz(dr("cont_website")) <> "" And nz(drCurrent("cont_website")) <> nz(dr("cont_website")) Then
                            onNote += nz(drCurrent("cont_website")) + " -> " + dr("cont_website") + "; "
                            drCurrent("cont_website") = dr("cont_website")
                        End If
                        If nz(dr("cont_phone1")) <> "" And nz(drCurrent("cont_phone1")) <> nz(dr("cont_phone1")) Then
                            onNote += nz(drCurrent("cont_phone1")) + " -> " + dr("cont_phone1") + "; "
                            drCurrent("cont_phone1") = dr("cont_phone1")
                        End If
                        If nz(dr("cont_phone2")) <> "" And nz(drCurrent("cont_phone2")) <> nz(dr("cont_phone2")) Then
                            onNote += nz(drCurrent("cont_phone2")) + " -> " + dr("cont_phone2") + "; "
                            drCurrent("cont_phone2") = dr("cont_phone2")
                        End If
                        If nz(dr("cont_cell")) <> "" And nz(drCurrent("cont_cell")) <> nz(dr("cont_cell")) Then
                            onNote += nz(drCurrent("cont_cell")) + " -> " + dr("cont_cell") + "; "
                            drCurrent("cont_cell") = dr("cont_cell")
                        End If
                        If nz(dr("cont_fax")) <> "" And nz(drCurrent("cont_fax")) <> nz(dr("cont_fax")) Then
                            onNote += nz(drCurrent("cont_fax")) + " -> " + dr("cont_fax") + "; "
                            drCurrent("cont_fax") = dr("cont_fax")
                        End If
                        If nz(dr("cont_type")) <> "" And nz(drCurrent("cont_type")) <> nz(dr("cont_type")) Then
                            onNote += nz(drCurrent("cont_type")) + " -> " + dr("cont_type") + "; "
                            drCurrent("cont_type") = dr("cont_type")
                        End If

                        AddSourceCode(drCurrent("cont_serial"), dr("cont_ord_src"))
                        Try
                            cbCurrent.RefreshSchema()
                            daCurrent.Update(dtCurrent)
                            'If onNote <> "" Then
                            '    cmd.CommandText = "insert into cont_note (cont_note_cont_serial,cont_note_user,cont_note_date,cont_note_type,cont_note) values (" + CStr(drCurrent("cont_serial")) + ",'" + User + "',getdate(),'Import Update','" + Replace(onNote, "'", "''") + "')"
                            '    cmd.ExecuteNonQuery()
                            'End If
                            cntUpdated += 1
                        Catch ex As Exception

                        End Try
                    Else
                        cntSkipped += 1
                    End If
                Else
                    cmd.CommandText = "insert into cont_file ( cont_type, cont_name, cont_company, cont_addr1, cont_addr2, cont_addr3, cont_city, cont_state, cont_zip, last_update, update_by, inactive, "
                    cmd.CommandText += "cont_ord_src, cont_ord_src_note, cont_status, cont_email, cont_phone1, cont_phone1_ext, cont_phone2, cont_phone2_ext, cont_cell, cont_fax, cont_notes, cont_website, "
                    cmd.CommandText += "cont_inactive_reason, cont_cat_com_email, cont_cat_com_mail, cont_cat_res_email, cont_cat_res_mail, cont_cat_mat_email, cont_cat_mat_mail, cont_next_call, cont_next_call_time, "
                    cmd.CommandText += "cont_next_call_reason, cont_next_call_by, cont_next_call_rcfs_serial, cont_call_center_rep_code, cont_import_ref, cont_import_by, "
                    cmd.CommandText += "cont_import_time, cont_created_from_ord_serial) values ("
                    cmd.CommandText += "'" + Replace(nz(dr("cont_type")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_name")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_company")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_addr1")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_addr2")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_addr3")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_city")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_state")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_zip")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("last_update")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("update_by")), "'", "''") + "',"
                    cmd.CommandText += "" + IIf(nz(dr("inactive"), False), "1", "0") + ","
                    cmd.CommandText += "'" + Replace(nz(dr("cont_ord_src")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_ord_src_note")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_status")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_email")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_phone1")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_phone1_ext")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_phone2")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_phone2_ext")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_cell")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_fax")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_notes")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_website")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_inactive_reason")), "'", "''") + "',"
                    cmd.CommandText += "" + IIf(nz(dr("cont_cat_com_email"), False), "1", "0") + ","
                    cmd.CommandText += "" + IIf(nz(dr("cont_cat_com_mail"), False), "1", "0") + ","
                    cmd.CommandText += "" + IIf(nz(dr("cont_cat_res_email"), False), "1", "0") + ","
                    cmd.CommandText += "" + IIf(nz(dr("cont_cat_res_mail"), False), "1", "0") + ","
                    cmd.CommandText += "" + IIf(nz(dr("cont_cat_mat_email"), False), "1", "0") + ","
                    cmd.CommandText += "" + IIf(nz(dr("cont_cat_mat_mail"), False), "1", "0") + ","
                    'cmd.CommandText += "" + IIf(nz(dr("cont_cat_none"), False), "1", "0") + ","
                    'cmd.CommandText += "" + IIf(nz(dr("cont_cat_residential"), False), "1", "0") + ","
                    'cmd.CommandText += "" + IIf(nz(dr("cont_cat_commercial"), False), "1", "0") + ","
                    'cmd.CommandText += "" + IIf(nz(dr("cont_cat_mail"), False), "1", "0") + ","
                    'cmd.CommandText += "" + IIf(nz(dr("cont_cat_email"), False), "1", "0") + ","
                    cmd.CommandText += "'" + Replace(nz(dr("cont_next_call")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_next_call_time")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_next_call_reason")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_next_call_by")), "'", "''") + "',"
                    cmd.CommandText += "" + CStr(nz(dr("cont_next_call_rcfs_serial"), 0)) + ","
                    cmd.CommandText += "'" + Replace(nz(dr("cont_call_center_rep_code")), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_import_ref"), False), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_import_by"), False), "'", "''") + "',"
                    cmd.CommandText += "'" + Replace(nz(dr("cont_import_time"), False), "'", "''") + "',"
                    cmd.CommandText += "" + CStr(nz(dr("cont_created_from_ord_serial"), 0)) + ")"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "select @@identity"
                    onContSerial = cmd.ExecuteScalar

                    AddSourceCode(onContSerial, dr("cont_ord_src"))

                    cntAdded += 1
                End If
            Catch
                MsgBox(Err.Description)
            End Try
        Next
        cnn.Close()

        bImportSave.Enabled = False

        cb.RefreshSchema()
        daImport.Update(dtImport)

        'For Each dr In dtImport.Rows
        '    'cmd.CommandText="update ord_file set ord_cont_serial="+dr(
        'Next

        bImportSave.Enabled = True
        MsgBox("Import Complete for " + CStr(dtImport.Rows.Count) + " records. " + vbCrLf + vbCrLf + CStr(cntAdded) + " Added. " + vbCrLf + CStr(cntUpdated) + " Updated." + vbCrLf + CStr(cntSkipped) + " Skipped.", MsgBoxStyle.OkOnly, "Complete")

    End Sub

    Private Sub bDeleteCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDeleteCont.Click
        If MsgBox("Are you sure you want to delete this contact?", MsgBoxStyle.YesNo, "Delete?") = MsgBoxResult.Yes Then
            bDeleteCont.Enabled = False
            cnn.Open()
            cmd.CommandText = "delete from cont_note where cont_note_cont_serial=" + CStr(CStr(gOSRCalls.ActiveRow.Cells(0).Value))
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from cont_file where cont_serial=" + CStr(CStr(gOSRCalls.ActiveRow.Cells(0).Value))
            cmd.ExecuteNonQuery()
            cnn.Close()
            LoadOSRCalls()
            bDeleteCont.Enabled = True
        End If
    End Sub
End Class