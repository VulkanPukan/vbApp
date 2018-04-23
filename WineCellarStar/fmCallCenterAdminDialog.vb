Imports System.Windows.Forms

Public Class fmCallCenterAdminDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If cbOverwrite.Checked = False And cbSkip.Checked = False Then
            MsgBox("Please choose an option", MsgBoxStyle.Information, "Choose?")
            Exit Sub
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cbSkip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSkip.CheckedChanged
        If cbSkip.Checked Then cbOverwrite.Checked = False
    End Sub

    Private Sub cbOverwrite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOverwrite.CheckedChanged
        If cbOverwrite.Checked Then cbSkip.Checked = False
    End Sub
End Class
