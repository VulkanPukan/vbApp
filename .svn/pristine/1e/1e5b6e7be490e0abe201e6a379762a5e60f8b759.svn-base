Imports System.Data
Imports System.Data.SqlClient

Public Class fmCatalogs
    Dim cmd As New SqlCommand("", cnn)
    Dim da As New SqlDataAdapter(cmd)

    Private Sub fmCatalogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DateTimePicker1.Value = Today.AddDays(-7)
        LoadContacts()
    End Sub
    Private Sub LoadContacts()
        Dim dt As New DataTable

        cmd.CommandText = "select cont_serial,1 as selected, cont_name,cont_company,cont_addr1,cont_addr2,cont_city,cont_state,cont_zip,cont_cat_res_inmailque,cont_cat_com_inmailque,cont_cat_mat_inmailque from cont_file where cont_cat_res_inmailque=1 or cont_cat_com_inmailque=1 or cont_cat_mat_inmailque=1"
        da.Fill(dt)
        Grid1.DataSource = dt
        Grid1.DataBind()

        If dt.Rows.Count > 0 Then
            Button1.Enabled = True
        Else
            'lName.Text = "No names found."
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GetSetting("Jcom", "Printing", "ShippingLabel", "") = "" Then
            MsgBox("Please choose a Shipping Label Printer first under Shipping / Setup Label Printer / Shipping Label Printer from the menu", MsgBoxStyle.Critical, "Printer?")
            Exit Sub
        End If

        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
        Dim serials As String = ""

        Button1.Enabled = False

        For Each rw In Grid1.Rows
            If rw.Cells("selected").Value = 1 Then serials += CStr(rw.Cells("cont_serial").Value) + ","
        Next
        If serials = "" Then
            MsgBox("Nothing to print", MsgBoxStyle.Information, "Print?")
            Button1.Enabled = True
            Exit Sub
        Else
            serials = Mid(serials, 1, Len(serials) - 1)
        End If
        DisplayReport("address labels", "{cont_file.cont_serial} in [" + serials + "]", False, , , , , , , , , , GetSetting("Jcom", "Printing", "ShippingLabel", ""))
        DisplayReport("catalog request", "{cont_file.cont_serial} in [" + serials + "]", False)

        Button1.Enabled = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim dr As Infragistics.Win.UltraWinGrid.UltraGridRow

        For Each dr In Grid1.Rows
            dr.Cells("selected").Value = 1
        Next
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Dim dr As Infragistics.Win.UltraWinGrid.UltraGridRow

        For Each dr In Grid1.Rows
            dr.Cells("selected").Value = 0
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
        Dim serials As String = ""

        Button2.Enabled = False
        If Button3.Text = "View" Then
            For Each rw In Grid1.Rows
                If rw.Cells("selected").Value = 1 Then serials += CStr(rw.Cells("cont_serial").Value) + ","
            Next
            If serials = "" Then
                MsgBox("No rows selected", MsgBoxStyle.Information, "Complete?")
                Button2.Enabled = True
                Exit Sub
            Else
                serials = Mid(serials, 1, Len(serials) - 1)
            End If

            cnn.Open()
            For Each rw In Grid1.Rows
                If rw.Cells("selected").Value = 1 Then
                    cmd.CommandText = "update cont_file set cont_cat_res_inmailque=0, cont_cat_com_inmailque=0, cont_cat_mat_inmailque=0" + _
                    IIf(rw.Cells("cont_cat_res_inmailque").Value = True, ",cont_cat_res_last_sent=getdate()", "") + IIf(rw.Cells("cont_cat_com_inmailque").Value = True, ",cont_cat_com_last_sent=getdate()", "") + IIf(rw.Cells("cont_cat_mat_inmailque").Value = True, ",cont_cat_mat_last_sent=getdate()", "") + " where cont_serial=" + CStr(rw.Cells("cont_serial").Value)
                    cmd.ExecuteNonQuery()
                End If
            Next
            cnn.Close()

            LoadContacts()

            MsgBox("Removal Complete", MsgBoxStyle.Information, "Removed")
        Else
            For Each rw In Grid1.Rows
                If rw.Cells("selected").Value = 1 Then serials += CStr(rw.Cells("cont_serial").Value) + ","
            Next
            If serials = "" Then
                MsgBox("No rows selected", MsgBoxStyle.Information, "Complete?")
                Button2.Enabled = True
                Exit Sub
            Else
                serials = Mid(serials, 1, Len(serials) - 1)
            End If

            cnn.Open()
            For Each rw In Grid1.Rows
                If rw.Cells("selected").Value = 1 Then
                    cmd.CommandText = "update cont_file set " + IIf(rw.Cells("cont_cat_res_inmailque").Value = True, "cont_cat_res_inmailque=1,", "cont_cat_res_inmailque=0,") + IIf(rw.Cells("cont_cat_com_inmailque").Value = True, "cont_cat_com_inmailque=1,", "cont_cat_com_inmailque=0,") + IIf(rw.Cells("cont_cat_mat_inmailque").Value = True, "cont_cat_mat_inmailque=1", "cont_cat_mat_inmailque=0") + " where cont_serial=" + CStr(rw.Cells("cont_serial").Value)
                    cmd.ExecuteNonQuery()
                End If
            Next
            cnn.Close()

            'LoadContacts()

            MsgBox("Restore Complete", MsgBoxStyle.Information, "Restored")
        End If
        Button1.Enabled = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        
        Grid1.DataSource = Nothing
        If Button3.Text = "View" Then
            Button1.Enabled = False
            Button2.Text = "Restore Selected Requests"
            Button2.BackColor = Color.LightBlue
            Button3.Text = "Return"
            Grid1.DisplayLayout.Override.RowAppearance.BackColor = Color.LightYellow
            Dim dt As New DataTable

            cmd.CommandText = "select cont_serial,0 as selected, cont_name,cont_company,cont_addr1,cont_addr2,cont_city,cont_state,cont_zip,cont_cat_res_inmailque,cont_cat_res_last_sent,cont_cat_com_inmailque,cont_cat_com_last_sent,cont_cat_mat_inmailque,cont_cat_mat_last_sent from cont_file where (cont_cat_res_inmailque=0 and cont_cat_res_last_sent >='" + DateTimePicker1.Value.ToString + "') or (cont_cat_com_inmailque=0 and cont_cat_com_last_sent >='" + DateTimePicker1.Value.ToString + "') or (cont_cat_mat_inmailque=0 and cont_cat_mat_last_sent >='" + DateTimePicker1.Value.ToString + "')"
            da.Fill(dt)
            Grid1.DataSource = dt
            Grid1.DataBind()
        Else
            Button1.Enabled = True
            Button2.Enabled = True
            Button2.Text = "Remove Selected Requests"
            Button2.BackColor = Color.Salmon
            Button3.Text = "View"
            Grid1.DisplayLayout.Override.RowAppearance.BackColor = Color.White
            LoadContacts()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dt As New DataTable
        Grid1.DataSource = Nothing
        cmd.CommandText = "select cont_serial,0 as selected, cont_name,cont_company,cont_addr1,cont_addr2,cont_city,cont_state,cont_zip,cont_cat_res_inmailque,cont_cat_com_inmailque,cont_cat_mat_inmailque from cont_file where (cont_cat_res_inmailque=0 and cont_cat_res_last_sent >='" + DateTimePicker1.Value.ToString + "') or (cont_cat_com_inmailque=0 and cont_cat_com_last_sent >='" + DateTimePicker1.Value.ToString + "') or (cont_cat_mat_inmailque=0 and cont_cat_mat_last_sent >='" + DateTimePicker1.Value.ToString + "')"
        da.Fill(dt)
        Grid1.DataSource = dt
        Grid1.DataBind()
    End Sub
End Class