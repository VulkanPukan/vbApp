Imports System.Data
Imports System.Data.SqlClient
Public Class fmProduction

    Dim cmd As New SqlCommand("", cnn)
    Dim da As New SqlDataAdapter(cmd)
    Dim onSilentUpdate As Boolean = False
    Dim onLoadGrids As Boolean = False

    Private Sub Tab1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles Tab1.SelectedTabChanged
        If Not Me.ActiveControl Is Tab1 Then Exit Sub
        LoadGrids()
    End Sub
    Private Sub LoadGrids()
        Select Case Tab1.ActiveTab.Key
            Case "Plan"
                lOrderFilter.Visible = False
                tOrderFilter.Visible = False
                LoadPlanning()
            Case "Design"
                lOrderFilter.Visible = False
                tOrderFilter.Visible = False
                LoadRackDesign()
            Case "Factory"
                lOrderFilter.Visible = True
                tOrderFilter.Visible = True
                LoadFactory()
        End Select
        SaveSetting("Jcom", "Production", "Tab", Tab1.ActiveTab.Key)
    End Sub
    Private Sub LoadRackDesign()
        If onLoadGrids = False Then Exit Sub

        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim dr As DataRow
        Dim dr2 As DataRow
        Dim onStatus As String = ""
        Dim rowCnt As Integer = 0
        Dim rowTot As Double = 0
        Dim grndTot As Double = 0

        Try
            cmd.CommandText = "select case when ord_prod_designcomplete=1 then 'Design Complete' else case when ord_prod_designstart=1 then 'Design Started' else 'All Clear' end end as Status,  ord_for,ord_gen_type, case when ord_gen_type='O' then convert(varchar,ord_gen.ord_gen_ord_serial)+'-'+ convert(varchar,ord_gen.ord_gen_from_rev)+'-'+ convert(varchar, ord_gen.ord_gen_rev) else convert(varchar,ord_gen.ord_gen_ord_serial)+'-'+ convert(varchar,ord_gen.ord_gen_from_quote)+'-'+ convert(varchar,ord_gen.ord_gen_from_rev)+'-'+ convert(varchar, ord_gen.ord_gen_rev) end as [Order],  case when ord_sold_cust_id='' then 'WCI' else ord_sold_cust_id end as ord_sold_cust_id, ord_gen_rack_height, "
            cmd.CommandText += " isnull(ord_gen_cust_tot,0) + isnull(ord_gen_stain_tot,0) as custstain, ord_gen_inside,ord_gen_outside, ord_prod_signoff_date, ord_prod_signoffrec_date, ord_prod_allclear_date, ord_prod_roomnotready_date, ord_prod_roomrevision_date, ord_prod_committed, ord_prod_waitingsignoff_date, ord_prod_signoff_note, ord_prod_roomnotready_note, ord_prod_roomrevision_note, ord_prod_waitingsignoff_note, ord_prod_signoffrec_note, '' as note, '' as wood, '' as stain, '12/31/2099' as Added, ord_gen_addon,0 as hasart, ord_prod_designstart_by, ord_prod_est_comp, ord_prod_designstart_note, ord_prod_designcomplete_note "
            cmd.CommandText += " from ord_file, ord_gen, ord_prod where ord_serial=ord_gen_ord_serial and ord_gen_ord_serial=ord_prod_ord_serial and ord_gen_rev=ord_prod_rev and ord_gen_type=ord_prod_type and ord_gen_type in ('O','R') and ord_prod_allclear=1 and ord_prod_tofactory=0 and ord_gen_status not in ('SHIPPED','CANCELED')"   '(ord_prod_signoff=1 or ord_prod_roomnotready=1 or ord_prod_roomrevision=1 or ord_prod_waitingsignoff=1 or ord_prod_signoffrec=1)
            cmd.CommandText += " order by case when ord_prod_designcomplete=1 then 2 else case when ord_prod_designstart=1 then 1 else 0 end end"

            da.Fill(dt)
            da.Fill(dt2)

            dt2.Clear()
            For Each dr In dt.Rows
                If onStatus = "" Then
                    onStatus = dr("status")
                Else
                    If onStatus <> dr("status") Then
                        dr2 = dt2.NewRow
                        dr2("ord_for") = onStatus + " (" + CStr(rowCnt) + ")"
                        dr2("custstain") = rowTot
                        dr2("hasart") = 0
                        dr2("ord_gen_addon") = 0
                        dt2.Rows.Add(dr2)
                        onStatus = dr("status")
                        rowCnt = 0
                        rowTot = 0
                    End If
                End If
                dr2 = dt2.NewRow
                dr2.ItemArray = dr.ItemArray
                If nz(dr2("ord_prod_signoff_date"), CDate("1/1/1900")) = CDate("1/1/1900") Then dr2("ord_prod_signoff_date") = DBNull.Value
                If nz(dr2("ord_prod_signoffrec_date"), CDate("1/1/1900")) = CDate("1/1/1900") Then dr2("ord_prod_signoffrec_date") = DBNull.Value
                If nz(dr2("ord_prod_allclear_date"), CDate("1/1/1900")) = CDate("1/1/1900") Then dr2("ord_prod_allclear_date") = DBNull.Value
                If nz(dr2("ord_prod_committed"), CDate("1/1/1900")) = CDate("1/1/1900") Then dr2("ord_prod_committed") = DBNull.Value

                If nz(dr2("ord_prod_signoff_date"), CDate("1/1/1900")) <> CDate("1/1/1900") And nz(dr2("ord_prod_signoff_date"), CDate("1/1/1900")) < CDate(dr2("added")) Then dr2("added") = Format(dr2("ord_prod_signoff_date"), "MM/dd/yyyy")
                If nz(dr2("ord_prod_roomnotready_date"), CDate("1/1/1900")) <> CDate("1/1/1900") And nz(dr2("ord_prod_roomnotready_date"), CDate("1/1/1900")) < CDate(dr2("added")) Then dr2("added") = Format(dr2("ord_prod_roomnotready_date"), "MM/dd/yyyy")
                If nz(dr2("ord_prod_roomrevision_date"), CDate("1/1/1900")) <> CDate("1/1/1900") And nz(dr2("ord_prod_roomrevision_date"), CDate("1/1/1900")) < CDate(dr2("added")) Then dr2("added") = Format(dr2("ord_prod_roomrevision_date"), "MM/dd/yyyy")
                If nz(dr2("ord_prod_waitingsignoff_date"), CDate("1/1/1900")) <> CDate("1/1/1900") And nz(dr2("ord_prod_waitingsignoff_date"), CDate("1/1/1900")) < CDate(dr2("added")) Then dr2("added") = Format(dr2("ord_prod_waitingsignoff_date"), "MM/dd/yyyy")
                If nz(dr2("ord_prod_signoffrec_date"), CDate("1/1/1900")) <> CDate("1/1/1900") And nz(dr2("ord_prod_signoffrec_date"), CDate("1/1/1900")) < CDate(dr2("added")) Then dr2("added") = Format(dr2("ord_prod_signoffrec_date"), "MM/dd/yyyy")
                If dr2("added") = CDate("12/31/2099") Then dr2("added") = DBNull.Value

                If nz(dr2("ord_prod_designstart_note")) <> "" Then dr2("note") += dr2("ord_prod_designstart_note") + vbCrLf
                If nz(dr2("ord_prod_designcomplete_note")) <> "" Then dr2("note") += dr2("ord_prod_designcomplete_note") + vbCrLf

                dt2.Rows.Add(dr2)
                rowCnt += 1
                rowTot += nz(dr("custstain"), 0)
                grndTot += nz(dr("custstain"), 0)
            Next
            dr2 = dt2.NewRow
            dr2("ord_for") = onStatus + " (" + CStr(rowCnt) + ")"
            dr2("custstain") = rowTot
            dr2("hasart") = 0
            dr2("ord_gen_addon") = 0
            dt2.Rows.Add(dr2)
            dr2 = dt2.NewRow
            dr2("ord_for") = "Grand Total"
            dr2("custstain") = grndTot
            dr2("hasart") = 0
            dr2("ord_gen_addon") = 0
            dt2.Rows.Add(dr2)

            grRackDesign.DataSource = dt2
            'grrackdesign.DataBind()

            cnn.Open()
            Dim gr As Infragistics.Win.UltraWinGrid.UltraGridRow
            Dim KitCust As Boolean = False
            For Each gr In grRackDesign.Rows
                If gr.Cells("status").Value Is DBNull.Value Then
                    gr.Appearance.BackColor = Color.Gainsboro
                    gr.Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                End If
                If nz(gr.Cells("order").Value) <> "" Then
                    If gr.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select distinct ord_itm_mat_code from ord_itm, mat_file where ord_itm_mat_code=mat_code and ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(2) + " and ord_itm_type='O' and mat_iswood=1"
                    Else
                        cmd.CommandText = "select distinct ord_itm_mat_code from ord_itm, mat_file where ord_itm_mat_code=mat_code and ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(3) + " and ord_itm_type='R' and mat_iswood=1"
                    End If
                    dt = New DataTable
                    da.Fill(dt)
                    For Each dr In dt.Rows
                        gr.Cells("wood").Value += dr("ord_itm_mat_code") + ","
                    Next
                    If Len(gr.Cells("wood").Value) > 1 Then gr.Cells("wood").Value = Mid(gr.Cells("wood").Value, 1, Len(gr.Cells("wood").Value) - 1)

                    If gr.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select distinct stain_name from ord_itm, stain_file where ord_itm_stain_serial=stain_serial and ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(2) + " and ord_itm_type='O' and stain_name<>'<None>'"
                    Else
                        cmd.CommandText = "select distinct stain_name from ord_itm, stain_file where ord_itm_stain_serial=stain_serial and ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(3) + " and ord_itm_type='R' and stain_name<>'<None>'"
                    End If
                    dt = New DataTable
                    da.Fill(dt)
                    For Each dr In dt.Rows
                        gr.Cells("stain").Value += dr("stain_name") + ","
                    Next
                    If Len(gr.Cells("stain").Value) > 1 Then gr.Cells("stain").Value = Mid(gr.Cells("stain").Value, 1, Len(gr.Cells("stain").Value) - 1)
                    If gr.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select top 1 ord_itm_serial from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(2) + " and ord_itm_type='O' and ord_itm_lacq3<>' '"
                    Else
                        cmd.CommandText = "select top 1 ord_itm_serial from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(3) + " and ord_itm_type='R' and ord_itm_lacq3<>' '"
                    End If
                    If nz(cmd.ExecuteScalar, 0) > 0 Then gr.Cells("stain").Value += "/LAQ"

                    KitCust = False
                    If gr.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='KIT' or ord_itm_prod_type='DESKIT')"
                        KitCust = nz(cmd.ExecuteScalar, 0) > 0
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='TOP' or ord_itm_prod_type='BUD' or ord_itm_prod_type='GOLD')"
                        KitCust = KitCust And ((nz(cmd.ExecuteScalar, 0)) > 0)
                    Else
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(3) + " and ord_itm_type='R' and (ord_itm_prod_type='KIT' or ord_itm_prod_type='DESKIT')"
                        KitCust = nz(cmd.ExecuteScalar, 0) > 0
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(3) + " and ord_itm_type='R' and (ord_itm_prod_type='TOP' or ord_itm_prod_type='BUD' or ord_itm_prod_type='GOLD')"
                        KitCust = KitCust And ((nz(cmd.ExecuteScalar, 0)) > 0)
                    End If
                    If KitCust Then
                        gr.Appearance.BackColor = Color.Yellow
                    End If

                    'cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='ARCH')"
                    'If nz(cmd.ExecuteScalar, 0) > 0 Then gr.Cells("hasart").Value = True
                End If
            Next
            cnn.Close()

            Dim col As Infragistics.Win.UltraWinGrid.UltraGridColumn
            For Each col In grRackDesign.DisplayLayout.Bands(0).Columns
                If col.Hidden = False Then
                    If col.Key = "note" Or col.Key = "wood" Or col.Key = "ord_prod_production_note" Then
                        col.Width = 200
                    Else
                        col.PerformAutoResize(Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand, True)
                    End If
                End If
            Next

            grRackDesign.UpdateData()
        Catch
            DoError(Err, Me)
        End Try

    End Sub
    Private Sub LoadPlanning()
        If onLoadGrids = False Then Exit Sub

        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim dr As DataRow
        Dim dr2 As DataRow
        Dim onStatus As String = ""
        Dim rowCnt As Integer = 0
        Dim rowTot As Double = 0
        Dim grndTot As Double = 0

        Try
            cmd.CommandText = "select case when ord_prod_signoffrec=1 then 'Sign Off Received' else case when ord_prod_waitingsignoff=1 then 'Waiting for Signoff' else case when ord_prod_roomrevision=1 then 'Room in Revision' else case when ord_prod_roomnotready=1 then 'Room Not Ready' else case when ord_prod_signoff=1 then 'Signoff Sent' else 'New' end end end end end as Status, ord_gen_type, ord_for, case when ord_gen_type='O' then convert(varchar,ord_gen.ord_gen_ord_serial)+'-'+ convert(varchar,ord_gen.ord_gen_from_rev)+'-'+ convert(varchar, ord_gen.ord_gen_rev) else convert(varchar,ord_gen.ord_gen_ord_serial)+'-'+ convert(varchar,ord_gen.ord_gen_from_quote)+'-'+convert(varchar,ord_gen.ord_gen_from_rev)+'-'+ convert(varchar, ord_gen.ord_gen_rev) end as [Order],  case when ord_sold_cust_id='' then 'WCI' else ord_sold_cust_id end as ord_sold_cust_id, ord_gen_rack_height, "
            cmd.CommandText += " isnull(ord_gen_cust_tot,0) + isnull(ord_gen_stain_tot,0) as custstain, ord_gen_inside,ord_gen_outside, ord_prod_signoff_date, ord_prod_signoffrec_date, ord_prod_allclear_date, ord_prod_roomnotready_date, ord_prod_roomrevision_date, ord_prod_committed, ord_prod_waitingsignoff_date, ord_prod_signoff_note, ord_prod_roomnotready_note, ord_prod_roomrevision_note, ord_prod_waitingsignoff_note, ord_prod_signoffrec_note, '' as note, '' as wood, '' as stain, '12/31/2099' as Added, ord_gen_addon,0 as hasart "
            cmd.CommandText += " from ord_file, ord_gen, ord_prod where ord_serial=ord_gen_ord_serial and ord_gen_ord_serial=ord_prod_ord_serial and ord_gen_rev=ord_prod_rev and ord_gen_type=ord_prod_type and ord_gen_type in ('O','R') and ord_gen_cust_tot > 0 and ord_prod_allclear=0 and ord_gen_status not in ('SHIPPED','CANCELED')"   '(ord_prod_signoff=1 or ord_prod_roomnotready=1 or ord_prod_roomrevision=1 or ord_prod_waitingsignoff=1 or ord_prod_signoffrec=1)
            cmd.CommandText += " order by case when ord_prod_signoffrec=1 then 5 else case when ord_prod_waitingsignoff=1 then 4 else case when ord_prod_roomrevision=1 then 3 else case when ord_prod_roomnotready=1 then 2 else case when ord_prod_signoff=1 then 1 else 0 end end end end end"

            da.Fill(dt)
            da.Fill(dt2)

            dt2.Clear()
            For Each dr In dt.Rows
                If onStatus = "" Then
                    onStatus = dr("status")
                Else
                    If onStatus <> dr("status") Then
                        dr2 = dt2.NewRow
                        dr2("ord_for") = onStatus + " (" + CStr(rowCnt) + ")"
                        dr2("custstain") = rowTot
                        dr2("hasart") = 0
                        dr2("ord_gen_addon") = 0
                        dt2.Rows.Add(dr2)
                        onStatus = dr("status")
                        rowCnt = 0
                        rowTot = 0
                    End If
                End If
                dr2 = dt2.NewRow
                dr2.ItemArray = dr.ItemArray
                If nz(dr2("ord_prod_signoff_date"), CDate("1/1/1900")) = CDate("1/1/1900") Then dr2("ord_prod_signoff_date") = DBNull.Value
                If nz(dr2("ord_prod_signoffrec_date"), CDate("1/1/1900")) = CDate("1/1/1900") Then dr2("ord_prod_signoffrec_date") = DBNull.Value
                If nz(dr2("ord_prod_allclear_date"), CDate("1/1/1900")) = CDate("1/1/1900") Then dr2("ord_prod_allclear_date") = DBNull.Value
                If nz(dr2("ord_prod_committed"), CDate("1/1/1900")) = CDate("1/1/1900") Then dr2("ord_prod_committed") = DBNull.Value

                If nz(dr2("ord_prod_signoff_date"), CDate("1/1/1900")) <> CDate("1/1/1900") And nz(dr2("ord_prod_signoff_date"), CDate("1/1/1900")) < CDate(dr2("added")) Then dr2("added") = Format(dr2("ord_prod_signoff_date"), "MM/dd/yyyy")
                If nz(dr2("ord_prod_roomnotready_date"), CDate("1/1/1900")) <> CDate("1/1/1900") And nz(dr2("ord_prod_roomnotready_date"), CDate("1/1/1900")) < CDate(dr2("added")) Then dr2("added") = Format(dr2("ord_prod_roomnotready_date"), "MM/dd/yyyy")
                If nz(dr2("ord_prod_roomrevision_date"), CDate("1/1/1900")) <> CDate("1/1/1900") And nz(dr2("ord_prod_roomrevision_date"), CDate("1/1/1900")) < CDate(dr2("added")) Then dr2("added") = Format(dr2("ord_prod_roomrevision_date"), "MM/dd/yyyy")
                If nz(dr2("ord_prod_waitingsignoff_date"), CDate("1/1/1900")) <> CDate("1/1/1900") And nz(dr2("ord_prod_waitingsignoff_date"), CDate("1/1/1900")) < CDate(dr2("added")) Then dr2("added") = Format(dr2("ord_prod_waitingsignoff_date"), "MM/dd/yyyy")
                If nz(dr2("ord_prod_signoffrec_date"), CDate("1/1/1900")) <> CDate("1/1/1900") And nz(dr2("ord_prod_signoffrec_date"), CDate("1/1/1900")) < CDate(dr2("added")) Then dr2("added") = Format(dr2("ord_prod_signoffrec_date"), "MM/dd/yyyy")
                If dr2("added") = CDate("12/31/2099") Then dr2("added") = DBNull.Value

                If nz(dr2("ord_prod_signoff_note")) <> "" Then dr2("note") += dr2("ord_prod_signoff_note") + vbCrLf
                If nz(dr2("ord_prod_roomnotready_note")) <> "" Then dr2("note") += dr2("ord_prod_roomnotready_note") + vbCrLf
                If nz(dr2("ord_prod_roomrevision_note")) <> "" Then dr2("note") += dr2("ord_prod_roomrevision_note") + vbCrLf
                If nz(dr2("ord_prod_waitingsignoff_note")) <> "" Then dr2("note") += dr2("ord_prod_waitingsignoff_note") + vbCrLf
                If nz(dr2("ord_prod_signoffrec_note")) <> "" Then dr2("note") += dr2("ord_prod_signoffrec_note") + vbCrLf

                dt2.Rows.Add(dr2)
                rowCnt += 1
                rowTot += nz(dr("custstain"), 0)
                grndTot += nz(dr("custstain"), 0)
            Next
            dr2 = dt2.NewRow
            dr2("ord_for") = onStatus + " (" + CStr(rowCnt) + ")"
            dr2("custstain") = rowTot
            dr2("hasart") = 0
            dr2("ord_gen_addon") = 0
            dt2.Rows.Add(dr2)
            dr2 = dt2.NewRow
            dr2("ord_for") = "Grand Total"
            dr2("custstain") = grndTot
            dr2("hasart") = 0
            dr2("ord_gen_addon") = 0
            dt2.Rows.Add(dr2)

            grPlanning.DataSource = dt2
            'grPlanning.DataBind()

            cnn.Open()
            Dim gr As Infragistics.Win.UltraWinGrid.UltraGridRow
            Dim KitCust As Boolean = False
            For Each gr In grPlanning.Rows
                If gr.Cells("status").Value Is DBNull.Value Then
                    gr.Appearance.BackColor = Color.Gainsboro
                    gr.Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                End If
                If nz(gr.Cells("order").Value) <> "" Then
                    If gr.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select distinct ord_itm_mat_code from ord_itm, mat_file where ord_itm_mat_code=mat_code and ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(2) + " and ord_itm_type='O' and mat_iswood=1"
                    Else
                        cmd.CommandText = "select distinct ord_itm_mat_code from ord_itm, mat_file where ord_itm_mat_code=mat_code and ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(3) + " and ord_itm_type='R' and mat_iswood=1"
                    End If
                    dt = New DataTable
                    da.Fill(dt)
                    For Each dr In dt.Rows
                        gr.Cells("wood").Value += dr("ord_itm_mat_code") + ","
                    Next
                    If Len(gr.Cells("wood").Value) > 1 Then gr.Cells("wood").Value = Mid(gr.Cells("wood").Value, 1, Len(gr.Cells("wood").Value) - 1)

                    If gr.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select distinct stain_name from ord_itm, stain_file where ord_itm_stain_serial=stain_serial and ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(2) + " and ord_itm_type='O' and stain_name<>'<None>'"
                    Else
                        cmd.CommandText = "select distinct stain_name from ord_itm, stain_file where ord_itm_stain_serial=stain_serial and ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(3) + " and ord_itm_type='R' and stain_name<>'<None>'"
                    End If
                    dt = New DataTable
                    da.Fill(dt)
                    For Each dr In dt.Rows
                        gr.Cells("stain").Value += dr("stain_name") + ","
                    Next
                    If Len(gr.Cells("stain").Value) > 1 Then gr.Cells("stain").Value = Mid(gr.Cells("stain").Value, 1, Len(gr.Cells("stain").Value) - 1)
                    If gr.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select top 1 ord_itm_serial from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(2) + " and ord_itm_type='O' and ord_itm_lacq3<>' '"
                    Else
                        cmd.CommandText = "select top 1 ord_itm_serial from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("order").Value, "-")(3) + " and ord_itm_type='R' and ord_itm_lacq3<>' '"
                    End If
                    If nz(cmd.ExecuteScalar, 0) > 0 Then gr.Cells("stain").Value += "/LAQ"

                    KitCust = False
                    If gr.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='KIT' or ord_itm_prod_type='DESKIT')"
                        KitCust = nz(cmd.ExecuteScalar, 0) > 0
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='TOP' or ord_itm_prod_type='BUD' or ord_itm_prod_type='GOLD')"
                        KitCust = KitCust And ((nz(cmd.ExecuteScalar, 0)) > 0)
                    Else
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(3) + " and ord_itm_type='R' and (ord_itm_prod_type='KIT' or ord_itm_prod_type='DESKIT')"
                        KitCust = nz(cmd.ExecuteScalar, 0) > 0
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(3) + " and ord_itm_type='R' and (ord_itm_prod_type='TOP' or ord_itm_prod_type='BUD' or ord_itm_prod_type='GOLD')"
                        KitCust = KitCust And ((nz(cmd.ExecuteScalar, 0)) > 0)
                    End If
                    If KitCust Then
                        gr.Appearance.BackColor = Color.Yellow
                    End If

                    If gr.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='ARCH')"
                    Else
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(3) + " and ord_itm_type='R' and (ord_itm_prod_type='ARCH')"
                    End If
                    If nz(cmd.ExecuteScalar, 0) > 0 Then gr.Cells("hasart").Value = True
                End If
            Next
            cnn.Close()

            Dim col As Infragistics.Win.UltraWinGrid.UltraGridColumn
            For Each col In grPlanning.DisplayLayout.Bands(0).Columns
                If col.Hidden = False Then
                    If col.Key = "note" Or col.Key = "wood" Then
                        col.Width = 200
                    Else
                        col.PerformAutoResize(Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand, True)
                    End If
                End If
            Next

            grPlanning.UpdateData()
        Catch
            DoError(Err, Me)
        End Try
    End Sub
    Private Sub LoadFactory()
        If onLoadGrids = False Then Exit Sub
        Me.Cursor = Cursors.WaitCursor

        SplitContainer1.Visible = False
        Application.DoEvents()
        onSilentUpdate = True

        Dim dt As New DataTable
        Dim dtGrid As New DataTable
        Dim TwoWeeksAgo As Date = DateAdd(DateInterval.Day, -14, DateAdd(DateInterval.Day, (Weekday(Today) * -1) - 1, Today))

        'cmd.CommandText = "SELECT ord_gen.ord_gen_type, ord_gen.ord_gen_status,case when ord_gen_type='O' then convert(varchar,ord_gen.ord_gen_ord_serial)+'-'+ convert(varchar,ord_gen.ord_gen_from_rev)+'-'+ convert(varchar, ord_gen.ord_gen_rev) else convert(varchar,ord_gen.ord_gen_ord_serial)+'-'+ convert(varchar,ord_gen.ord_gen_from_quote)+'-'+ convert(varchar,ord_gen.ord_gen_from_rev)+'-'+ convert(varchar, ord_gen.ord_gen_rev) end as [Order], ord_prod_allclear, ord_prod_signoffrec, "
        'cmd.CommandText += "ord_prod_tofactory, ord_prod_tofactory_date, ord_file.ord_for, ord_file.ord_sold_cust_id, ord_prod.ord_prod_committed, ord_prod.ord_prod_must_ship, ord_itm.ord_itm_prod_type, ord_prod_production_note, "
        'cmd.CommandText += "ord_itm.ord_itm_qty, ord_itm.ord_itm_base_price, ord_itm.ord_itm_unt_sell, ord_itm.ord_itm_disc, ord_itm.ord_itm_margin_factor, ord_itm.ord_itm_item_code, "
        'cmd.CommandText += "ord_itm.ord_itm_is_disc, ord_itm.ord_itm_is_up, ISNULL(ord_prod.ord_prod_est_comp, '1/1/1900') AS ord_prod_est_comp, ord_prod_est_comp_note, ord_prod_art, ord_gen.ord_gen_status2,ord_gen_inside,ord_gen_outside,ord_gen_install_dt,ord_prod_sign_stain, ord_gen_balance, cust_billable "
        'cmd.CommandText += "FROM  ord_file AS ord_file LEFT OUTER JOIN "
        'cmd.CommandText += "ord_gen AS ord_gen ON ord_file.ord_serial = ord_gen.ord_gen_ord_serial LEFT OUTER JOIN "
        'cmd.CommandText += "ord_itm AS ord_itm ON ord_gen.ord_gen_ord_serial = ord_itm.ord_itm_ord_serial AND ord_gen.ord_gen_rev = ord_itm.ord_itm_rev AND "
        'cmd.CommandText += "ord_gen.ord_gen_type = ord_itm.ord_itm_type LEFT OUTER JOIN "
        'cmd.CommandText += "ord_prod AS ord_prod ON ord_gen.ord_gen_rev = ord_prod.ord_prod_rev AND ord_gen.ord_gen_ord_serial = ord_prod.ord_prod_ord_serial AND "
        'cmd.CommandText += "ord_gen.ord_gen_type = ord_prod.ord_prod_type left outer join cust_file on ord_sold_cust_id=cust_id "
        'cmd.CommandText += "WHERE (ord_gen.ord_gen_type in ('O','R')) AND (ord_gen.ord_gen_status <> 'CANCELED') AND (ord_gen.ord_gen_status <> 'SHIPPED') AND (ord_prod_allclear = 1) AND "
        'cmd.CommandText += "(ord_itm.ord_itm_is_disc = 0) AND (ord_itm.ord_itm_is_up = 0) OR "
        'cmd.CommandText += "(ord_gen.ord_gen_type in ('O','R')) AND (ord_gen.ord_gen_status <> 'CANCELED') AND (ord_gen.ord_gen_status <> 'SHIPPED') AND (ord_itm.ord_itm_is_disc = 0) AND "
        'cmd.CommandText += "(ord_itm.ord_itm_is_up = 0) AND (ord_prod_tofactory = 1) OR "
        'cmd.CommandText += "(ord_gen.ord_gen_type in ('O','R')) AND (ord_gen.ord_gen_status <> 'CANCELED') AND (ord_gen.ord_gen_status <> 'SHIPPED') AND (ord_itm.ord_itm_is_disc = 0) AND "
        'cmd.CommandText += "(ord_itm.ord_itm_is_up = 0) AND (ord_itm.ord_itm_prod_type = 'ARCH') AND (ord_prod.ord_prod_est_comp > '1900-01-01') or "
        'cmd.CommandText += "(ord_gen.ord_gen_type in ('O','R')) AND (ord_gen.ord_gen_status = 'SHIPPED') AND (ord_prod_allclear = 1) AND (ord_itm.ord_itm_is_disc = 0) AND "
        'cmd.CommandText += "(ord_itm.ord_itm_is_up = 0) AND (ord_prod.ord_prod_est_comp > '" + CStr(TwoWeeksAgo) + "') OR"
        'cmd.CommandText += "(ord_gen.ord_gen_type in ('O','R')) AND (ord_gen.ord_gen_status = 'SHIPPED') AND (ord_itm.ord_itm_is_disc = 0) AND (ord_itm.ord_itm_is_up = 0) AND "
        'cmd.CommandText += "(ord_prod_tofactory = 1) AND (ord_prod.ord_prod_est_comp > '" + CStr(TwoWeeksAgo) + "')"
        'cmd.CommandText += "ORDER BY ord_prod.ord_prod_est_comp,[Order]"

        cmd.CommandText = "SELECT ord_gen.ord_gen_type, ord_gen.ord_gen_status,case when ord_gen_type='O' then convert(varchar,ord_gen.ord_gen_ord_serial)+'-'+ convert(varchar,ord_gen.ord_gen_from_rev)+'-'+ convert(varchar, ord_gen.ord_gen_rev) else convert(varchar,ord_gen.ord_gen_ord_serial)+'-'+ convert(varchar,ord_gen.ord_gen_from_quote)+'-'+ convert(varchar,ord_gen.ord_gen_from_rev)+'-'+ convert(varchar, ord_gen.ord_gen_rev) end as [Order], ord_prod_allclear, ord_prod_signoffrec, "
        cmd.CommandText += "ord_prod_tofactory, ord_prod_tofactory_date, ord_file.ord_for, ord_file.ord_sold_cust_id, ord_prod.ord_prod_committed, ord_prod.ord_prod_must_ship, ord_itm.ord_itm_prod_type, ord_prod_production_note, "
        cmd.CommandText += "ord_itm.ord_itm_qty, ord_itm.ord_itm_base_price, ord_itm.ord_itm_unt_sell, ord_itm.ord_itm_disc, ord_itm.ord_itm_margin_factor, ord_itm.ord_itm_item_code, "
        cmd.CommandText += "ord_itm.ord_itm_is_disc, ord_itm.ord_itm_is_up, ISNULL(ord_prod.ord_prod_est_comp, '1/1/1900') AS ord_prod_est_comp, ord_prod_est_comp_note, ord_prod_art, ord_gen.ord_gen_status2,ord_gen_inside,ord_gen_outside,ord_gen_install_dt,ord_prod_sign_stain, ord_gen_balance, cust_billable,ord_gen.ord_gen_ord_serial,ord_gen.ord_gen_rev,ord_gen_type "
        cmd.CommandText += "FROM  ord_file AS ord_file LEFT OUTER JOIN "
        cmd.CommandText += "ord_gen AS ord_gen ON ord_file.ord_serial = ord_gen.ord_gen_ord_serial LEFT OUTER JOIN "
        cmd.CommandText += "ord_itm AS ord_itm ON ord_gen.ord_gen_ord_serial = ord_itm.ord_itm_ord_serial AND ord_gen.ord_gen_rev = ord_itm.ord_itm_rev AND "
        cmd.CommandText += "ord_gen.ord_gen_type = ord_itm.ord_itm_type LEFT OUTER JOIN "
        cmd.CommandText += "ord_prod AS ord_prod ON ord_gen.ord_gen_rev = ord_prod.ord_prod_rev AND ord_gen.ord_gen_ord_serial = ord_prod.ord_prod_ord_serial AND "
        cmd.CommandText += "ord_gen.ord_gen_type = ord_prod.ord_prod_type left outer join cust_file on ord_sold_cust_id=cust_id "
        cmd.CommandText += "WHERE "
        'cmd.CommandText += "(ord_gen.ord_gen_type in ('O','R')) AND (ord_gen.ord_gen_status <> 'CANCELED') AND (ord_gen.ord_gen_status <> 'SHIPPED') AND (ord_prod_allclear = 1) AND "
        'cmd.CommandText += "(ord_itm.ord_itm_is_disc = 0) AND (ord_itm.ord_itm_is_up = 0) OR "
        cmd.CommandText += "(ord_gen.ord_gen_type in ('O','R')) AND (ord_gen.ord_gen_status <> 'CANCELED') AND (ord_gen.ord_gen_status <> 'SHIPPED') AND (ord_itm.ord_itm_is_disc = 0) AND "
        cmd.CommandText += "(ord_itm.ord_itm_is_up = 0) AND (ord_prod_tofactory = 1) OR "
        cmd.CommandText += "(ord_gen.ord_gen_type in ('O','R')) AND (ord_gen.ord_gen_status <> 'CANCELED') AND (ord_gen.ord_gen_status <> 'SHIPPED') AND (ord_itm.ord_itm_is_disc = 0) AND "
        cmd.CommandText += "(ord_itm.ord_itm_is_up = 0) AND (ord_itm.ord_itm_prod_type = 'ARCH') AND (ord_prod.ord_prod_est_comp > '1900-01-01') or "
        'cmd.CommandText += "(ord_gen.ord_gen_type in ('O','R')) AND (ord_gen.ord_gen_status = 'SHIPPED') AND (ord_prod_allclear = 1) AND (ord_itm.ord_itm_is_disc = 0) AND "
        'cmd.CommandText += "(ord_itm.ord_itm_is_up = 0) AND (ord_prod.ord_prod_est_comp > '" + CStr(TwoWeeksAgo) + "') OR"
        cmd.CommandText += "(ord_gen.ord_gen_type in ('O','R')) AND (ord_gen.ord_gen_status = 'SHIPPED') AND (ord_itm.ord_itm_is_disc = 0) AND (ord_itm.ord_itm_is_up = 0) AND "
        cmd.CommandText += "(ord_prod_tofactory = 1) AND (ord_prod.ord_prod_est_comp > '" + CStr(TwoWeeksAgo) + "')"
        cmd.CommandText += "ORDER BY ord_prod.ord_prod_est_comp,[Order]"

        da.Fill(dt)

        dtGrid.Columns.Add("Order")
        dtGrid.Columns.Add("Primary Ref")
        dtGrid.Columns.Add("Sold To")
        dtGrid.Columns.Add("Status")
        dtGrid.Columns.Add("Status 2")
        dtGrid.Columns.Add("To Factory", GetType(Date))
        dtGrid.Columns.Add("Est Ship", GetType(Date))
        dtGrid.Columns.Add("Est Ship Note")
        dtGrid.Columns.Add("Committed", GetType(Date))
        dtGrid.Columns.Add("Art", GetType(Date))
        dtGrid.Columns.Add("Install", GetType(Date))
        dtGrid.Columns.Add("ISR")
        dtGrid.Columns.Add("OSR")
        dtGrid.Columns.Add("Sample")
        dtGrid.Columns.Add("Cust/Stain Total", GetType(Double))
        dtGrid.Columns.Add("Cust/Stain Total w/ Shipping", GetType(Double))
        dtGrid.Columns.Add("Cust/Stain Base", GetType(Double))
        dtGrid.Columns.Add("Cust/Stain Above Base", GetType(Double))
        dtGrid.Columns.Add("Cust/Stain Perc", GetType(Double))
        dtGrid.Columns.Add("Art Total", GetType(Double))
        dtGrid.Columns.Add("Art Base", GetType(Double))
        dtGrid.Columns.Add("Order Total", GetType(Double))
        dtGrid.Columns.Add("Order Base", GetType(Double))
        dtGrid.Columns.Add("Order Above Base", GetType(Double))
        dtGrid.Columns.Add("Order Perc", GetType(Double))
        dtGrid.Columns.Add("Balance")
       
        dtGrid.Columns.Add("Need Addr", GetType(Boolean))
        dtGrid.Columns.Add("ord_gen_type")
        dtGrid.Columns.Add("ord_prod_production_note")
        dtGrid.Columns.Add("KitValue", GetType(Double))
        dtGrid.Columns.Add("CustValue", GetType(Double))
        dtGrid.Columns.Add("WoodType")
        dtGrid.Columns.Add("Stain")

        Dim onOrder As String = ""
        Dim onWeek As Date = CDate("1/5/1900")
        Dim rw As DataRow
        Dim drw As DataRow
        Dim CSTotal As Double
        Dim CSTotal_wk As Double
        Dim CSTotalWShip As Double
        Dim CSTotalWShip_wk As Double
        Dim CSBase As Double
        Dim CSBase_wk As Double
        Dim ATotal As Double
        Dim ATotal_wk As Double
        Dim ABase As Double
        Dim ABase_wk As Double
        Dim OTotal As Double
        Dim OTotal_wk As Double
        Dim OBase As Double
        Dim OBase_wk As Double
        Dim LTotal As Double
        Dim LBase As Double
        Dim x As Integer
        Dim doIt As Boolean = False

        For Each rw In dt.Rows
            If onOrder <> rw("order") Then
                If onOrder <> "" Then
                    drw("Cust/Stain Total") = CSTotal
                    drw("Cust/Stain Total w/ Shipping") = CSTotalWShip
                    drw("Cust/Stain Base") = CSBase
                    drw("Cust/Stain Above Base") = Math.Round(CSTotalWShip - CSBase, 2)
                    drw("Cust/Stain Perc") = IIf(CSBase = 0, 0, Math.Round(drw("Cust/Stain Above Base") / CSBase, 4))
                    drw("Art Total") = ATotal
                    drw("Art Base") = Math.Round(ATotal - ABase, 2)
                    drw("Order Total") = OTotal
                    drw("Order Base") = OBase
                    drw("Order Above Base") = Math.Round(OTotal - OBase, 2)
                    drw("Order Perc") = IIf(OBase = 0, 0, Math.Round(drw("Order Above Base") / OBase, 4))

                    dtGrid.Rows.Add(drw)

                    ATotal_wk = Math.Round(ATotal_wk + ATotal, 2)
                    ABase_wk = Math.Round(ABase_wk + ABase, 2)
                    OTotal_wk = Math.Round(OTotal_wk + OTotal, 2)
                    OBase_wk = Math.Round(OBase_wk + OBase, 2)

                    CSTotal = 0
                    CSTotalWShip = 0
                    CSBase = 0
                    ATotal = 0
                    ABase = 0
                    OTotal = 0
                    OBase = 0
                End If
            End If
            LTotal = Math.Round((rw("ord_itm_qty") * rw("ord_itm_unt_sell")) + rw("ord_itm_disc") + rw("ord_itm_margin_factor"), 2)
            LBase = Math.Round((rw("ord_itm_qty") * rw("ord_itm_base_price")), 2)
            If (rw("ord_itm_prod_type") = "BUD" Or rw("ord_itm_prod_type") = "TOP" Or rw("ord_itm_prod_type") = "GOLD" Or rw("ord_itm_prod_type") = "STAIN") And rw("ord_gen_status") <> "SHIPPED" Then
                CSTotal += LTotal
                CSTotal_wk += LTotal
            End If
            If (rw("ord_itm_prod_type") = "BUD" Or rw("ord_itm_prod_type") = "TOP" Or rw("ord_itm_prod_type") = "GOLD" Or rw("ord_itm_prod_type") = "STAIN") Then
                CSTotalWShip += LTotal
                CSTotalWShip_wk += LTotal
                CSBase += LBase
                CSBase_wk += LBase
            End If
            If (rw("ord_itm_prod_type") = "ARCH") Then
                ATotal = Math.Round(ATotal + LTotal, 2)
                ABase = Math.Round(ABase + LBase, 2)
            End If
            OTotal += LTotal
            OBase += LBase

            If onOrder <> rw("order") Then
                If onWeek <> DateAdd(DateInterval.Day, 6 - Weekday(rw("ord_prod_est_comp")), rw("ord_prod_est_comp")) Then
                    drw = dtGrid.NewRow
                    drw("order") = "Week ending " + CStr(onWeek)
                    drw("Cust/Stain Total") = CSTotal_wk
                    drw("Cust/Stain Total w/ Shipping") = CSTotalWShip_wk
                    drw("Cust/Stain Base") = CSBase_wk
                    drw("Cust/Stain Above Base") = Math.Round(CSTotalWShip_wk - CSBase_wk, 2)
                    drw("Cust/Stain Perc") = IIf(CSBase_wk = 0, 0, Math.Round(drw("Cust/Stain Above Base") / CSBase_wk, 4))
                    drw("Art Total") = ATotal_wk
                    drw("Art Base") = ABase_wk
                    drw("Order Total") = OTotal_wk
                    drw("Order Base") = OBase_wk
                    drw("Order Above Base") = Math.Round(OTotal_wk - OBase_wk, 2)
                    drw("Order Perc") = IIf(OBase_wk = 0, 0, Math.Round(drw("Order Above Base") / OBase_wk, 4))
                    dtGrid.Rows.Add(drw)
                    onWeek = DateAdd(DateInterval.Day, 6 - Weekday(rw("ord_prod_est_comp")), rw("ord_prod_est_comp"))
                    CSTotal_wk = 0
                    CSTotalWShip_wk = 0
                    CSBase_wk = 0
                    ATotal_wk = 0
                    ABase_wk = 0
                    OTotal_wk = 0
                    OBase_wk = 0
                End If

                drw = dtGrid.NewRow
                drw("order") = rw("order")
                drw("primary ref") = rw("ord_for")
                drw("sold to") = rw("ord_sold_cust_id")
                drw("status") = rw("ord_gen_status")
                drw("status 2") = IIf(rw("ord_prod_signoffrec") = True And rw("ord_prod_allclear") = True And rw("ord_prod_tofactory") = False, "IWU ", "") + rw("ord_gen_status2")
                drw("to factory") = IIf(rw("ord_prod_tofactory_date") > CDate("1/1/1900"), rw("ord_prod_tofactory_date"), DBNull.Value)
                drw("est ship") = IIf(rw("ord_prod_est_comp") > CDate("1/1/1900"), rw("ord_prod_est_comp"), DBNull.Value)
                drw("est ship note") = rw("ord_prod_est_comp_note")
                drw("committed") = IIf(rw("ord_prod_committed") > CDate("1/1/1900"), rw("ord_prod_committed"), DBNull.Value)
                drw("art") = IIf(rw("ord_prod_art") > CDate("1/1/1900"), rw("ord_prod_art"), DBNull.Value)
                drw("install") = IIf(rw("ord_gen_install_dt") > CDate("1/1/1900"), rw("ord_gen_install_dt"), DBNull.Value)
                drw("isr") = rw("ord_gen_inside")
                drw("osr") = rw("ord_gen_outside")
                drw("sample") = rw("ord_prod_sign_stain")
                drw("balance") = FormatCurrency(rw("ord_gen_balance"), 2)
                drw("ord_gen_type") = rw("ord_gen_type")
                drw("ord_prod_production_note") = rw("ord_prod_production_note")

                cmd.CommandText = "SELECT ord_itm.ord_itm_ord_serial, ord_itm.ord_itm_rev, ord_itm.ord_itm_type, ord_itm.ord_itm_from_ord_itm_serial, mat_file.mat_code, " + _
                                         "mat_file.mat_desc, mat_file.mat_iswood, stain_file.stain_name, stain_file.stain_desc, ord_itm.ord_itm_mat_code,ord_itm.ord_itm_prod_type, " + _
                                         "ord_itm_qty, ord_itm_unt_sell, ord_itm_disc, ord_itm_margin_factor " + _
                "FROM   dbo.ord_itm INNER JOIN " + _
                                         "dbo.ord_gen ON dbo.ord_itm.ord_itm_ord_serial = dbo.ord_gen.ord_gen_ord_serial AND dbo.ord_itm.ord_itm_rev = dbo.ord_gen.ord_gen_rev AND  " + _
                                         "dbo.ord_itm.ord_itm_type = dbo.ord_gen.ord_gen_type LEFT OUTER JOIN " + _
                                         "dbo.mat_file ON dbo.ord_itm.ord_itm_mat_code = dbo.mat_file.mat_code LEFT OUTER JOIN " + _
                                         "dbo.stain_file ON dbo.ord_itm.ord_itm_stain_serial = dbo.stain_file.stain_serial " + _
                "WHERE  (ord_itm_ord_serial =" + rw("ord_gen_ord_serial").ToString + ") AND (dbo.ord_itm.ord_itm_type = '" + rw("ord_gen_type") + "') AND (dbo.ord_itm.ord_itm_rev = " + rw("ord_gen_rev").ToString + ")"
                Dim dtn As New DataTable
                da.Fill(dtn)
                Dim drr As DataRow
                Dim stn As String = ""
                Dim wt As String = ""
                Dim kit
                Dim cust
                For Each drr In dtn.Rows
                    Try
                        If nz2(drr("mat_iswood"), False) Then
                            If InStr(wt, nz(drr("mat_code"))) = 0 Then
                                wt += drr("ord_itm_mat_code").ToString + ","
                            End If
                        End If
                        If UCase(nz(drr("mat_code"))) = "STAIN" Then
                            If InStr(stn, nz(drr("stain_desc"))) = 0 Then
                                stn += nz(drr("stain_desc")).ToString + ","
                            End If
                        End If
                        If InStr("KIT,FS,DESKIT", nz(drr("ord_itm_prod_type"))) And nz(drr("ord_itm_prod_type")) <> "DES" Then
                            kit += drr("ord_itm_qty") * drr("ord_itm_unt_sell") + (drr("ord_itm_disc") + drr("ord_itm_margin_factor"))
                        End If
                        If InStr("BUD,GOLD,TOP,STAIN", nz(drr("ord_itm_prod_type"))) Then
                            cust += drr("ord_itm_qty") * drr("ord_itm_unt_sell") + (drr("ord_itm_disc") + drr("ord_itm_margin_factor"))
                        End If
                    Catch
                        MsgBox(Err.Description)
                    End Try
                Next

                'if {ord_itm.ord_itm_prod_type} in ["KIT","FS","DESKIT"] THEN {@ItemPrice} else 0
                'if {ord_itm.ord_itm_prod_type} in ["BUD","GOLD","TOP","STAIN"] THEN {@ItemPrice} else 0
                '{ord_itm.ord_itm_qty}*{ord_itm.ord_itm_unt_sell}+({ord_itm.ord_itm_disc}+{ord_itm.ord_itm_margin_factor})

                If stn <> "" Then stn = Mid(stn, 1, Len(stn) - 1)
                If wt <> "" Then wt = Mid(wt, 1, Len(wt) - 1)
                drw("KitValue") = Math.Round(kit, 2)
                drw("CustValue") = Math.Round(cust, 2)
                drw("WoodType") = wt
                drw("Stain") = stn
                wt = ""
                stn = ""
                kit = 0
                cust = 0
                onOrder = rw("order")

                If nz(rw("cust_billable"), False) Then drw("balance") = "Billable"
            End If
        Next
        dtGrid.Rows.Add(drw)


        grFactory.DataSource = dtGrid
        'grFactory.DisplayLayout.Bands(0).Columns("Primary Ref").PerformAutoResize(Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand, True)

        Dim ProdColumns As String
        Dim col As Infragistics.Win.UltraWinGrid.UltraGridColumn
        Dim cb As CheckBox

        cmd.CommandText = "select usr_prodcolumns_hidden from usr_file where usr_name='" + User + "'"
        cnn.Open()
        ProdColumns = nz(cmd.ExecuteScalar)

        If CheckSecurity("Production Dollars") = 0 Then
            grFactory.DisplayLayout.Bands(0).Columns("Cust/Stain Total").Hidden = True
            grFactory.DisplayLayout.Bands(0).Columns("Cust/Stain Total w/ Shipping").Hidden = True
            grFactory.DisplayLayout.Bands(0).Columns("Cust/Stain Base").Hidden = True
            grFactory.DisplayLayout.Bands(0).Columns("Cust/Stain Above Base").Hidden = True
            grFactory.DisplayLayout.Bands(0).Columns("Cust/Stain Perc").Hidden = True
            grFactory.DisplayLayout.Bands(0).Columns("Art Total").Hidden = True
            grFactory.DisplayLayout.Bands(0).Columns("Art Base").Hidden = True
            grFactory.DisplayLayout.Bands(0).Columns("Order Total").Hidden = True
            grFactory.DisplayLayout.Bands(0).Columns("Order Base").Hidden = True
            grFactory.DisplayLayout.Bands(0).Columns("Order Above Base").Hidden = True
            grFactory.DisplayLayout.Bands(0).Columns("Order Perc").Hidden = True
        End If

        x = 0
        SplitContainer1.Panel1.Controls.Clear()
        For Each col In grFactory.DisplayLayout.Bands(0).Columns
            If col.Hidden = False Then
                cb = New CheckBox
                cb.Text = col.Key
                cb.Top = x * 20
                cb.Width = 400
                AddHandler cb.Click, AddressOf cbFactColumnsChecked
                If InStr(ProdColumns, col.Key + ",") > 0 Then
                    col.Hidden = True
                    cb.Checked = False
                Else
                    cb.Checked = True
                    If col.Header.Caption = "Est Ship Note" Or col.Header.Caption = "Status 2" Then
                        col.Width = 200
                    Else
                        col.PerformAutoResize(Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand, True)
                    End If

                End If
                SplitContainer1.Panel1.Controls.Add(cb)
                x += 1
            End If
        Next

        SplitContainer1.Visible = True

        Dim gr As Infragistics.Win.UltraWinGrid.UltraGridRow
        Dim KitCust As Boolean
        For Each gr In grFactory.Rows
            If Mid(gr.Cells("order").Value, 1, 4) = "Week" Then gr.Appearance.BackColor = Color.Gainsboro

            KitCust = False
            If Split(nz(gr.Cells("Order").Value), "-").Length > 1 And nz(gr.Cells("status").Value) <> "QUOTE" Then
                cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='KIT' or ord_itm_prod_type='DESKIT')"
                KitCust = nz(cmd.ExecuteScalar, 0) > 0
                cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_itm_rev=" + Split(gr.Cells("Order").Value, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='TOP' or ord_itm_prod_type='BUD' or ord_itm_prod_type='GOLD')"
                KitCust = KitCust And (nz(cmd.ExecuteScalar, 0) > 0)
            End If
            If KitCust Then
                gr.Appearance.BackColor = Color.Yellow
            Else
                If UserType = "I" Then
                    If UCase(nz(gr.Cells("ISR").Value)) = UCase(Jcom.User) Then gr.Appearance.BackColor = Color.Khaki
                End If
            End If

            If Split(nz(gr.Cells("Order").Value), "-").Length > 1 And nz(gr.Cells("status").Value) <> "SHIPPED" Then
                gr.Cells("status 2").Value = GetEstCompDates(gr.Cells("Order").Value, nz(gr.Cells("status 2").Value), nz(gr.Cells("Est Ship").Value, CDate("1/1/1900")), gr.Cells("ord_gen_type").Value)
            End If

            gr.Cells("Need Addr").Value = False
            If Split(nz(gr.Cells("Order").Value), "-").Length > 1 Then
                If gr.Cells("ord_gen_type").Value = "O" Then
                    cmd.CommandText = "select ord_gen_alt_ship from ord_gen where ord_gen_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_gen_rev=" + Split(gr.Cells("Order").Value, "-")(2) + " and ord_gen_type='O'"
                Else
                    cmd.CommandText = "select ord_gen_alt_ship from ord_gen where ord_gen_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_gen_rev=" + Split(gr.Cells("Order").Value, "-")(3) + " and ord_gen_type='R'"
                End If
                If nz(cmd.ExecuteScalar, False) = True Then
                    If gr.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select ord_alt_ship_serial from ord_alt_ship where ord_alt_ship_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_alt_ship_rev=" + Split(gr.Cells("Order").Value, "-")(2) + " and ord_alt_ship_type='O' and ((isnull(ord_alt_ship_name,'')='') or (isnull(ord_alt_ship_addr1,'')='') or (isnull(ord_alt_ship_city,'')='') or (isnull(ord_alt_ship_state,'')='') or (isnull(ord_alt_ship_zip,'')='') or (isnull(ord_alt_ship_phone1,'')=''))"
                    Else
                        cmd.CommandText = "select ord_alt_ship_serial from ord_alt_ship where ord_alt_ship_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_alt_ship_rev=" + Split(gr.Cells("Order").Value, "-")(3) + " and ord_alt_ship_type='R' and ((isnull(ord_alt_ship_name,'')='') or (isnull(ord_alt_ship_addr1,'')='') or (isnull(ord_alt_ship_city,'')='') or (isnull(ord_alt_ship_state,'')='') or (isnull(ord_alt_ship_zip,'')='') or (isnull(ord_alt_ship_phone1,'')=''))"
                    End If
                    If nz(cmd.ExecuteScalar, 0) > 0 Then
                        gr.Cells("Need Addr").Value = True
                    End If
                Else
                    If gr.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_gen_rev=" + Split(gr.Cells("Order").Value, "-")(2) + " and ord_gen_type='O' and ((isnull(ord_gen_ship_name,'')='') or (isnull(ord_gen_ship_addr1,'')='') or (isnull(ord_gen_ship_city,'')='') or (isnull(ord_gen_ship_state,'')='') or (isnull(ord_gen_ship_zip,'')='') or (isnull(ord_gen_ship_phone1,'')=''))"
                    Else
                        cmd.CommandText = "select ord_gen_serial from ord_gen where ord_gen_ord_serial=" + Split(gr.Cells("Order").Value, "-")(0) + " and ord_gen_rev=" + Split(gr.Cells("Order").Value, "-")(3) + " and ord_gen_type='R' and ((isnull(ord_gen_ship_name,'')='') or (isnull(ord_gen_ship_addr1,'')='') or (isnull(ord_gen_ship_city,'')='') or (isnull(ord_gen_ship_state,'')='') or (isnull(ord_gen_ship_zip,'')='') or (isnull(ord_gen_ship_phone1,'')=''))"
                    End If
                    If nz(cmd.ExecuteScalar, 0) > 0 Then
                        gr.Cells("Need Addr").Value = True
                    End If
                End If

            End If
        Next
        'ShowHideShipped()
        'ShowHideArt()
        ShowHideRows()
        cnn.Close()
        grFactory.UpdateData()
        onSilentUpdate = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Function GetEstCompDates(ByVal onOrder As String, ByVal Note As String, ByVal EstShipDt As Date, ByVal OrdType As String) As String
        Dim onDates As String = ""
        Dim dt As New DataTable
        Dim dr As DataRow

        dt = New DataTable
        If OrdType = "O" Then
            cmd.CommandText = "select distinct ord_prod_est_comp from ord_prod_hist where ord_prod_ord_serial=" + Split(onOrder, "-")(0) + " and ord_prod_rev=" + Split(onOrder, "-")(2) + " and ord_prod_type='O' and ord_prod_est_comp>'1/1/1900' and ord_prod_est_comp<>'" + CStr(EstShipDt) + "' order by ord_prod_est_comp"
        Else
            cmd.CommandText = "select distinct ord_prod_est_comp from ord_prod_hist where ord_prod_ord_serial=" + Split(onOrder, "-")(0) + " and ord_prod_rev=" + Split(onOrder, "-")(3) + " and ord_prod_type='R' and ord_prod_est_comp>'1/1/1900' and ord_prod_est_comp<>'" + CStr(EstShipDt) + "' order by ord_prod_est_comp"
        End If

        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            onDates = "Est Orig Dts: "
            For Each dr In dt.Rows
                onDates += Format(dr("ord_prod_est_comp"), "MM/dd/yyyy") + ", "
            Next
            onDates = Mid(onDates, 1, Len(onDates) - 2)
            If Note <> "" Then Note += "; "
            Note = Note + onDates
        End If
        Return Note
    End Function
    'Private Sub ShowHideShipped()
    '    Dim gr As Infragistics.Win.UltraWinGrid.UltraGridRow
    '    For Each gr In grFactory.Rows
    '        If nz(gr.Cells("status").Value) = "SHIPPED" Then gr.Hidden = (cbShipped.Checked = False)
    '    Next
    'End Sub
    'Private Sub ShowHideArt()
    '    Dim gr As Infragistics.Win.UltraWinGrid.UltraGridRow
    '    For Each gr In grFactory.Rows
    '        If nz(gr.Cells("Cust/Stain Total w/ Shipping").Value, 0) = 0 And nz(gr.Cells("Art Total").Value, 0) > 0 Then gr.Hidden = (cbShowArt.Checked = False)
    '    Next
    'End Sub
    Private Sub ShowHideRows()
        Dim gr As Infragistics.Win.UltraWinGrid.UltraGridRow
        For Each gr In grFactory.Rows
            gr.Hidden = False
            If gr.Hidden = False Then
                If nz(gr.Cells("Cust/Stain Total w/ Shipping").Value, 0) = 0 And nz(gr.Cells("Art Total").Value, 0) > 0 Then gr.Hidden = (cbShowArt.Checked = False)
            End If
            If gr.Hidden = False Then
                If nz(gr.Cells("status").Value) = "SHIPPED" Then gr.Hidden = (cbShipped.Checked = False)
            End If
            If tOrderFilter.Text <> "" Then
                If Mid(nz(gr.Cells("order").Value), 1, Len(tOrderFilter.Text)) <> tOrderFilter.Text Then gr.Hidden = True
            End If
        Next
    End Sub
    Private Sub cbFactColumnsChecked(ByVal sender As Object, ByVal e As EventArgs)
        Dim ProdColumns As String = ""
        Dim cb As CheckBox
        Dim cmd As New SqlCommand("", cnn)

        For Each cb In SplitContainer1.Panel1.Controls
            If cb.Checked = False Then
                ProdColumns += cb.Text + ","
                grFactory.DisplayLayout.Bands(0).Columns(cb.Text).Hidden = True
            Else
                grFactory.DisplayLayout.Bands(0).Columns(cb.Text).Hidden = False
            End If
        Next
        cmd.CommandText = "update usr_file set usr_prodcolumns_hidden='" + ProdColumns + "' where usr_name='" + User + "'"
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub
    Private Sub bColPicker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bColPicker.Click
        If bColPicker.Text = "Show Column Picker" Then
            SplitContainer1.Panel1Collapsed = False
            bColPicker.Text = "Hide Column Picker"
        Else
            SplitContainer1.Panel1Collapsed = True
            bColPicker.Text = "Show Column Picker"
        End If
    End Sub

    Private Sub grFactory_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grFactory.AfterCellUpdate
        If onSilentUpdate Then Exit Sub
        Try
            Select Case e.Cell.Column.Header.Caption
                Case "Status 2"
                    cnn.Open()
                    If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "update ord_gen set ord_gen_status2='" + Replace(nz(e.Cell.Value), "'", "''") + "' where ord_gen_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_gen_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_gen_type='O'"
                    Else
                        cmd.CommandText = "update ord_gen set ord_gen_status2='" + Replace(nz(e.Cell.Value), "'", "''") + "' where ord_gen_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_gen_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_gen_type='R'"
                    End If
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                    e.Cell.Appearance.BackColor = Color.PaleGreen
                Case "Est Ship"
                    If Weekday(e.Cell.Value) = 6 Or Weekday(e.Cell.Value) = 7 Or Weekday(e.Cell.Value) = 1 Then
                        MsgBox("Estimated Ship Date can not be a FRIDAY, SATURDAY or SUNDAY.", MsgBoxStyle.Information, "Date?")
                        e.Cell.Appearance.BackColor = Color.Red
                        Exit Sub
                    End If
                    cnn.Open()
                    Dim onDate As Date = DateAdd(DateInterval.Day, 6 - Weekday(e.Cell.Value), e.Cell.Value)
                    cmd.CommandText = "select prod_lock_checked from prod_lock where prod_lock_date='" + CStr(onDate) + "'"
                    If nz(cmd.ExecuteScalar, False) = True Then
                        MsgBox("This date is in a Locked Week.  Please select a different date or have a Production Supervisor open this week.", MsgBoxStyle.Information, "Date?")
                        e.Cell.Appearance.BackColor = Color.Red
                        cnn.Close()
                        Exit Sub
                    End If

                    CopyOrdProdToHist()
                    If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "update ord_prod set ord_prod_est_comp='" + CStr(e.Cell.Value) + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_prod_type='O'"
                    Else
                        cmd.CommandText = "update ord_prod set ord_prod_est_comp='" + CStr(e.Cell.Value) + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_prod_type='R'"
                    End If
                    cmd.ExecuteNonQuery()

                    Dim KitCust As Boolean = False
                    If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='KIT' or ord_itm_prod_type='DESKIT')"
                        KitCust = nz(cmd.ExecuteScalar, 0) > 0
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='TOP' or ord_itm_prod_type='BUD' or ord_itm_prod_type='GOLD')"
                        KitCust = KitCust And ((nz(cmd.ExecuteScalar, 0)) > 0)
                    Else
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_itm_type='R' and (ord_itm_prod_type='KIT' or ord_itm_prod_type='DESKIT')"
                        KitCust = nz(cmd.ExecuteScalar, 0) > 0
                        cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_itm_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_itm_type='R' and (ord_itm_prod_type='TOP' or ord_itm_prod_type='BUD' or ord_itm_prod_type='GOLD')"
                        KitCust = KitCust And ((nz(cmd.ExecuteScalar, 0)) > 0)
                    End If
                    If KitCust Then
                        Dim onNote As String = nz(grFactory.ActiveRow.Cells("est ship note").Value)
                        Dim onNoteDate As Date = DateAdd(DateInterval.Day, 2, e.Cell.Value)

                        If Weekday(onNoteDate) = 6 Or Weekday(onNoteDate) = 7 Or Weekday(onNoteDate) = 1 Then onNoteDate = DateAdd(DateInterval.Day, 3, onNoteDate)

                        If InStr(onNote, "May not ship until ") > 0 Then
                            onNote = Split(onNote, "May not ship until ")(0) + Mid(Split(onNote, "May not ship until ")(1), InStr(Split(onNote, "May not ship until ")(1) + " ", " ") + 1)
                        End If
                        onNote = "May not ship until " + CStr(onNoteDate) + ". " + onNote
                        If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
                            cmd.CommandText = "update ord_prod set ord_prod_est_comp_note='" + Replace(nz(onNote), "'", "''") + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_prod_type='O'"
                        Else
                            cmd.CommandText = "update ord_prod set ord_prod_est_comp_note='" + Replace(nz(onNote), "'", "''") + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_prod_type='R'"
                        End If
                        cmd.ExecuteNonQuery()
                        onSilentUpdate = True
                        grFactory.ActiveRow.Cells("est ship note").Value = onNote
                        onSilentUpdate = False
                    End If
                    cnn.Close()
                    e.Cell.Appearance.BackColor = Color.PaleGreen
                Case "Est Ship Note"
                    cnn.Open()
                    CopyOrdProdToHist()
                    If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "update ord_prod set ord_prod_est_comp_note='" + Replace(nz(e.Cell.Value), "'", "''") + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_prod_type='O'"
                    Else
                        cmd.CommandText = "update ord_prod set ord_prod_est_comp_note='" + Replace(nz(e.Cell.Value), "'", "''") + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_prod_type='R'"
                    End If
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                    e.Cell.Appearance.BackColor = Color.PaleGreen
                Case "Committed"
                    cnn.Open()
                    CopyOrdProdToHist()
                    If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "update ord_prod set ord_prod_committed='" + CStr(e.Cell.Value) + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_prod_type='O'"
                    Else
                        cmd.CommandText = "update ord_prod set ord_prod_committed='" + CStr(e.Cell.Value) + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_prod_type='R'"
                    End If
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                    e.Cell.Appearance.BackColor = Color.PaleGreen
                Case "Art"
                    cnn.Open()
                    CopyOrdProdToHist()
                    If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "update ord_prod set ord_prod_art='" + CStr(e.Cell.Value) + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_prod_type='O'"
                    Else
                        cmd.CommandText = "update ord_prod set ord_prod_art='" + CStr(e.Cell.Value) + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_prod_type='R'"
                    End If
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                    e.Cell.Appearance.BackColor = Color.PaleGreen
                Case "Install"
                    cnn.Open()
                    If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "update ord_gen set ord_gen_install_dt='" + CStr(e.Cell.Value) + "' where ord_gen_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_gen_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_gen_type='O'"
                    Else
                        cmd.CommandText = "update ord_gen set ord_gen_install_dt='" + CStr(e.Cell.Value) + "' where ord_gen_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_gen_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_gen_type='R'"
                    End If
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                    e.Cell.Appearance.BackColor = Color.PaleGreen
                Case "Production Note"
                    cnn.Open()
                    CopyOrdProdToHist()
                    If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
                        cmd.CommandText = "update ord_prod set ord_prod_production_note='" + Replace(nz(e.Cell.Value), "'", "''") + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_prod_type='O'"
                    Else
                        cmd.CommandText = "update ord_prod set ord_prod_production_note='" + Replace(nz(e.Cell.Value), "'", "''") + "',ord_prod_who='" + Jcom.User + "',ord_prod_date=getdate() where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_prod_type='R'"
                    End If
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                    e.Cell.Appearance.BackColor = Color.PaleGreen
            End Select
        Catch ex As Exception
            DoError(Err, Me)
        End Try
    End Sub
    Private Sub CopyOrdProdToHist()
        If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
            cmd.CommandText = "INSERT INTO ord_prod_hist SELECT ord_prod_ord_serial, ord_prod_rev, ord_prod_type, ord_prod_date, ord_prod_who, ord_prod_status, ord_prod_must_ship, ord_prod_must_ship_by, ord_prod_must_ship_note, ord_prod_committed, ord_prod_committed_by, ord_prod_committed_note, ord_prod_est_comp, ord_prod_est_comp_by, ord_prod_est_comp_note, ord_prod_art, ord_prod_art_by, ord_prod_art_note, ord_prod_sign_stain, ord_prod_sign_stain_by, ord_prod_sign_stain_dt, ord_prod_signoff, ord_prod_signoff_date, ord_prod_signoff_by, ord_prod_signoff_note, ord_prod_roomnotready, ord_prod_roomnotready_date, ord_prod_roomnotready_by, ord_prod_roomnotready_note, ord_prod_roomrevision, ord_prod_roomrevision_date, ord_prod_roomrevision_by, ord_prod_roomrevision_note, ord_prod_waitingsignoff, ord_prod_waitingsignoff_date, ord_prod_waitingsignoff_by, ord_prod_waitingsignoff_note, ord_prod_signoffrec, ord_prod_signoffrec_date, ord_prod_signoffrec_by, ord_prod_signoffrec_note, ord_prod_allclear, ord_prod_allclear_date, ord_prod_allclear_by, ord_prod_allclear_note, ord_prod_designstart, ord_prod_designstart_date, ord_prod_designstart_by, ord_prod_designstart_note, ord_prod_designcomplete, ord_prod_designcomplete_date, ord_prod_designcomplete_by, ord_prod_designcomplete_note, ord_prod_tofactory, ord_prod_tofactory_date, ord_prod_tofactory_by, ord_prod_tofactory_note, ord_prod_added_to_closed_week, ord_prod_notes_flag, ord_prod_production_note, ord_prod_kitdown, ord_prod_kitdown_date, ord_prod_kitdown_by, ord_prod_kitdown_note, ord_prod_cdrdown, ord_prod_cdrdown_date, ord_prod_cdrdown_by, ord_prod_cdrdown_note FROM  ord_prod WHERE (ord_prod_ord_serial = " + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + ") and (ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + ") AND (ord_prod_type = 'O')"
        Else
            cmd.CommandText = "INSERT INTO ord_prod_hist SELECT ord_prod_ord_serial, ord_prod_rev, ord_prod_type, ord_prod_date, ord_prod_who, ord_prod_status, ord_prod_must_ship, ord_prod_must_ship_by, ord_prod_must_ship_note, ord_prod_committed, ord_prod_committed_by, ord_prod_committed_note, ord_prod_est_comp, ord_prod_est_comp_by, ord_prod_est_comp_note, ord_prod_art, ord_prod_art_by, ord_prod_art_note, ord_prod_sign_stain, ord_prod_sign_stain_by, ord_prod_sign_stain_dt, ord_prod_signoff, ord_prod_signoff_date, ord_prod_signoff_by, ord_prod_signoff_note, ord_prod_roomnotready, ord_prod_roomnotready_date, ord_prod_roomnotready_by, ord_prod_roomnotready_note, ord_prod_roomrevision, ord_prod_roomrevision_date, ord_prod_roomrevision_by, ord_prod_roomrevision_note, ord_prod_waitingsignoff, ord_prod_waitingsignoff_date, ord_prod_waitingsignoff_by, ord_prod_waitingsignoff_note, ord_prod_signoffrec, ord_prod_signoffrec_date, ord_prod_signoffrec_by, ord_prod_signoffrec_note, ord_prod_allclear, ord_prod_allclear_date, ord_prod_allclear_by, ord_prod_allclear_note, ord_prod_designstart, ord_prod_designstart_date, ord_prod_designstart_by, ord_prod_designstart_note, ord_prod_designcomplete, ord_prod_designcomplete_date, ord_prod_designcomplete_by, ord_prod_designcomplete_note, ord_prod_tofactory, ord_prod_tofactory_date, ord_prod_tofactory_by, ord_prod_tofactory_note, ord_prod_added_to_closed_week, ord_prod_notes_flag, ord_prod_production_note, ord_prod_kitdown, ord_prod_kitdown_date, ord_prod_kitdown_by, ord_prod_kitdown_note, ord_prod_cdrdown, ord_prod_cdrdown_date, ord_prod_cdrdown_by, ord_prod_cdrdown_note FROM  ord_prod WHERE (ord_prod_ord_serial = " + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + ") and (ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + ") AND (ord_prod_type = 'R')"
        End If
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub grFactory_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles grFactory.AfterExitEditMode
        If grFactory.ActiveCell.Column.Header.Caption = "Status 2" Then
            If onSilentUpdate Then Exit Sub
            If grFactory.ActiveRow Is Nothing Then Exit Sub
            onSilentUpdate = True
            grFactory.ActiveCell.Value = GetEstCompDates(grFactory.ActiveRow.Cells("order").Value, nz(grFactory.ActiveCell.Value), nz(grFactory.ActiveRow.Cells("Est Ship").Value, CDate("1/1/1900")), grFactory.ActiveRow.Cells("ord_gen_type").Value)
            If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
                cmd.CommandText = "select ord_prod_serial from ord_prod where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_prod_type='O' and ord_prod_signoffrec=1 and ord_prod_allclear=1 and ord_prod_tofactory=0"
            Else
                cmd.CommandText = "select ord_prod_serial from ord_prod where ord_prod_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_prod_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_prod_type='R' and ord_prod_signoffrec=1 and ord_prod_allclear=1 and ord_prod_tofactory=0"
            End If
            cnn.Open()
            If nz(cmd.ExecuteScalar, 0) > 0 Then grFactory.ActiveCell.Value = "IWU " + grFactory.ActiveCell.Value
            cnn.Close()
            onSilentUpdate = False
        End If
    End Sub


    Private Sub grFactory_BeforeEnterEditMode(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles grFactory.BeforeEnterEditMode
        If grFactory.ActiveCell.Column.Header.Caption = "Status 2" Then
            onSilentUpdate = True
            If grFactory.ActiveRow.Cells("ord_gen_type").Value = "O" Then
                cmd.CommandText = "select ord_gen_status2 from ord_gen where ord_gen_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_gen_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(2) + " and ord_gen_type='O'"
            Else
                cmd.CommandText = "select ord_gen_status2 from ord_gen where ord_gen_ord_serial=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(0) + " and ord_gen_rev=" + Split(grFactory.ActiveRow.Cells("order").Value, "-")(3) + " and ord_gen_type='R'"
            End If
            cnn.Open()
            grFactory.ActiveCell.Value = nz(cmd.ExecuteScalar)
            cnn.Close()
            onSilentUpdate = False
        End If
    End Sub
    Private Sub grFactory_BeforeSortChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeSortChangeEventArgs) Handles grFactory.BeforeSortChange
        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow

        For Each rw In grFactory.Rows
            If Mid(rw.Cells(0).Text, 1, 4) = "Week" Then rw.Delete(False)
        Next
    End Sub
    Private Sub grFactory_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grFactory.ClickCellButton
        Dim fm As fmEstOrd2
        fm = LoadForm("Quotes/Orders")
        fm.KeyValue1 = Split(e.Cell.Text, "-")(0)
        fm.tOrd.Text = fm.KeyValue1
        fm.LoadPage()
        If e.Cell.Row.Cells("ord_gen_type").Value = "O" Then
            fm.Tab1.Tabs("O" + Split(e.Cell.Text, "-")(2)).Selected = True
        Else
            fm.Tab1.Tabs("R" + Split(e.Cell.Text, "-")(3)).Selected = True
        End If
        fm.TabItems.Tabs("Prod").Selected = True
    End Sub
    Private Sub cbShipped_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShipped.CheckedChanged
        'ShowHideShipped()
        ShowHideRows()
    End Sub

    Private Sub grFactory_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grFactory.InitializeLayout

    End Sub

    Private Sub fmProduction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmd.CommandTimeout = 120
        If UserType = "I" Then lMyOrders.Visible = True
        If GetSetting("Jcom", "Production", "Tab", "") <> "" Then Tab1.Tabs(GetSetting("Jcom", "Production", "Tab", "")).Selected = True
        onLoadGrids = True
        LoadGrids()
    End Sub

    Private Sub cbShowArt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShowArt.CheckedChanged
        'ShowHideArt()
        ShowHideRows()
    End Sub

    Private Sub grPlanning_BeforeSortChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeSortChangeEventArgs) Handles grPlanning.BeforeSortChange
        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow

        For Each rw In grPlanning.Rows
            If nz(rw.Cells("Order").Value) = "" Then rw.Delete(False)
        Next
    End Sub

    Private Sub grPlanning_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grPlanning.ClickCellButton
        Dim fm As fmEstOrd2
        fm = LoadForm("Quotes/Orders")
        fm.KeyValue1 = Split(e.Cell.Text, "-")(0)
        fm.tOrd.Text = fm.KeyValue1
        fm.LoadPage()
        If e.Cell.Row.Cells("ord_gen_type").Value = "O" Then
            fm.Tab1.Tabs("O" + Split(e.Cell.Text, "-")(2)).Selected = True
        Else
            fm.Tab1.Tabs("R" + Split(e.Cell.Text, "-")(3)).Selected = True
        End If
        fm.TabItems.Tabs("Prod").Selected = True
    End Sub

    Private Sub grPlanning_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grPlanning.InitializeLayout

    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        UltraGridExcelExporter1.Export(grPlanning, "temp.xls")
        System.Diagnostics.Process.Start("temp.xls")
    End Sub

    Private Sub grRackDesign_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grRackDesign.ClickCellButton
        Dim fm As fmEstOrd2
        fm = LoadForm("Quotes/Orders")
        fm.KeyValue1 = Split(e.Cell.Text, "-")(0)
        fm.tOrd.Text = fm.KeyValue1
        fm.LoadPage()
        If e.Cell.Row.Cells("ord_gen_type").Value = "O" Then
            fm.Tab1.Tabs("O" + Split(e.Cell.Text, "-")(2)).Selected = True
        Else
            fm.Tab1.Tabs("R" + Split(e.Cell.Text, "-")(3)).Selected = True
        End If
        fm.TabItems.Tabs("Prod").Selected = True
    End Sub

    Private Sub grRackDesign_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grRackDesign.InitializeLayout
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        UltraGridExcelExporter1.Export(grRackDesign, "temp.xls")
        System.Diagnostics.Process.Start("temp.xls")
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        UltraGridExcelExporter1.Export(grFactory, "temp.xls")
        System.Diagnostics.Process.Start("temp.xls")
    End Sub

    Private Sub tOrderFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tOrderFilter.TextChanged
        ShowHideRows()
    End Sub
End Class
