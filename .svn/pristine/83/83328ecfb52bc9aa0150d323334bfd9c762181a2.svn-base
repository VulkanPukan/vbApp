Public Class fmContactList
    Public fmOrd As fmEstOrd2

    Private Sub fmContactList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Visible = False
        e.Cancel = True
    End Sub

    Private Sub fmContactList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub fmContactList_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
    End Sub

    Private Sub Grid1_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterRowActivate
    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout
    End Sub
    Private Sub SetContact()
        If Grid1.ActiveRow Is Nothing Then Exit Sub

        Dim Phone As String = Grid1.ActiveRow.Cells("Phone").Text

        Phone = Replace(Phone, "(", "")
        Phone = Replace(Phone, ")", "")
        Phone = Replace(Phone, "-", "")

        fmOrd.tSold_Name.Text = Grid1.ActiveRow.Cells("Name").Text
        fmOrd.tsold_phone1.Text = Grid1.ActiveRow.Cells("cont_phone_search").Text
        fmOrd.tsold_company.Text = Grid1.ActiveRow.Cells("Company").Text
        fmOrd.tsold_addr1.Text = Grid1.ActiveRow.Cells("Address").Text
        fmOrd.tSold_City.Text = Grid1.ActiveRow.Cells("City").Text
        fmOrd.tsold_state.Text = Grid1.ActiveRow.Cells("State").Text
        fmOrd.tsold_zip.Text = Grid1.ActiveRow.Cells("Zip").Text
        Me.Visible = False
    End Sub

    Private Sub Grid1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid1.MouseClick
        SetContact()
    End Sub
End Class