Imports System.Data.SqlClient
Imports System.Data

Public Class fmAddSourceCode
    Public SrcCode As String
    Public SrcCodeDesc As String

    Private Sub fmAddSourceCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCodes()
    End Sub
    Private Sub LoadCodes()
        Dim cmd As New SqlCommand("", cnn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        If TextBox1.Text = "" Then
            cmd.CommandText = "select ord_src,ord_src_desc from ord_src where ord_src_inactive<>1 order by ord_src_desc"
        Else
            cmd.CommandText = "select ord_src,ord_src_desc from ord_src where ord_src_inactive<>1 and ord_src like '%" + TextBox1.Text + "%' or ord_src_desc like '%" + TextBox1.Text + "%' order by ord_src_desc"
        End If
        da.Fill(dt)
        Grid1.DataSource = dt
        Grid1.DataBind()
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Down
                If Grid1.Rows.Count > 0 Then
                    If Grid1.ActiveRow Is Nothing Then
                        Grid1.Rows(0).Activated = True
                    Else
                        If Grid1.ActiveRow.Index + 1 < Grid1.Rows.Count Then Grid1.Rows(Grid1.ActiveRow.Index + 1).Activated = True
                    End If
                End If
            Case Keys.Up
                If Grid1.Rows.Count > 0 Then
                    If Grid1.ActiveRow Is Nothing Then
                        Grid1.Rows(0).Activated = True
                    Else
                        If Grid1.ActiveRow.Index > 0 Then Grid1.Rows(Grid1.ActiveRow.Index - 1).Activated = True
                    End If
                End If
            Case Else
                LoadCodes()
        End Select
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub bAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAdd.Click
        If Grid1.ActiveRow Is Nothing Then
            SrcCode = ""
        Else
            SrcCode = Grid1.ActiveRow.Cells("ord_src").Value
            SrcCodeDesc = Grid1.ActiveRow.Cells("ord_src_desc").Value
        End If
        Me.Hide()
    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        SrcCode = Grid1.ActiveRow.Cells("ord_src").Value
        SrcCodeDesc = Grid1.ActiveRow.Cells("ord_src_desc").Value
        Me.Hide()
    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub
End Class