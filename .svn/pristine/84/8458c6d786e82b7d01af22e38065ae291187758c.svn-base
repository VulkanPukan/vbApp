Public Class fmPartRename
    Dim cmd As New SqlClient.SqlCommand("", cnn)
    Private Sub fmPartRename_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter(cmd)

        cmd.CommandText = "select itm_code from itm_file where isnull(inactive,0)=0 order by itm_code"
        da.Fill(dt)
        tOld.DataSource = dt
        tOld.DisplayMember = "itm_code"
        tOld.ValueMember = "itm_code"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tOld.Text = "" Then Exit Sub
        If tNew.Text = "" Then Exit Sub

        Button1.Enabled = False
        cnn.Open()
        cmd.CommandText = "update itm_file set itm_code='" + tNew.Text + "' where itm_code='" + tOld.Text + "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update ord_itm set ord_itm_item_code='" + tNew.Text + "' where ord_itm_item_code='" + tOld.Text + "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update itm_box set itm_box_itm_code='" + tNew.Text + "' where itm_box_itm_code='" + tOld.Text + "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update itm_img set itm_img_itm_code='" + tNew.Text + "' where itm_img_itm_code='" + tOld.Text + "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update itm_price set itm_price_itm_code='" + tNew.Text + "' where itm_price_itm_code='" + tOld.Text + "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update ord_itm_hist set ord_itm_item_code='" + tNew.Text + "' where ord_itm_item_code='" + tOld.Text + "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update sales_cat_itm_price set itm_price_itm_code='" + tNew.Text + "' where itm_price_itm_code='" + tOld.Text + "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update ship_itm set ship_itm_code='" + tNew.Text + "' where ship_itm_code='" + tOld.Text + "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update upsell_file set upsell_parent_itm_code='" + tNew.Text + "' where upsell_parent_itm_code='" + tOld.Text + "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update upsell_file set upsell_child_itm_code='" + tNew.Text + "' where upsell_child_itm_code='" + tOld.Text + "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update cust_itm_price set cust_itm_price_itm_code='" + tNew.Text + "' where cust_itm_price_itm_code='" + tOld.Text + "'"
        cmd.ExecuteNonQuery()
        cnn.Close()

        Button1.Enabled = True
    End Sub
End Class