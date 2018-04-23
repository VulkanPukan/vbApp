Imports System.Data
Imports System.Data.SqlClient

Public Class fmProductionLock
    Dim dt As New DataTable

    Private Sub fmProductionLock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Grid1.UpdateData()
    End Sub

    Private Sub fmProductionLock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        Dim cmd As New SqlCommand("", cnn)
        Dim da As New SqlDataAdapter(cmd)

        cmd.CommandText = "select * from prod_lock where prod_lock_date > '" + CStr(DateAdd(DateInterval.Day, -7, Today)) + "' order by prod_lock_date"
        da.Fill(dt)

        Grid1.DataSource = dt
    End Sub

    Private Sub Grid1_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid1.AfterCellUpdate
        Dim cmd As New SqlCommand("", cnn)

        cmd.CommandText = "update prod_lock set prod_lock_checked=" + IIf(e.Cell.Value, "1", "0") + ", prod_lock_checked_by='" + User + "',prod_lock_checked_on=getdate() where prod_lock_date='" + CStr(e.Cell.Row.Cells("prod_lock_date").Value) + "'"
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub

End Class