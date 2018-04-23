Public Class fmStarter
    Inherits System.Windows.Forms.Form
    Public Key1 As String
    Public Key2 As String
    Public KeyValue1 As String
    Public KeyValue2 As String
    Public Table As String
    Public EditMode As String
    Public FocusField As String
    Public SaveCanceled As Boolean = False
    Public EditCanceled As Boolean = False
    Public SecLevel As Byte = 0

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'fmStarter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(744, 478)
        Me.Name = "fmStarter"
        Me.Text = "fmStarter"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

#End Region

    Private Sub fmStarter_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        FormsLoaded(Me.Tag)
    End Sub
    Public Overridable Sub Add()
        Try
            If SecLevel < jAdd Then
                MsgBox("You do not have ADD permision on this screen.", MsgBoxStyle.Critical, "Permission?")
                Exit Sub
            End If
            Add_Before()
            If EditCanceled = True Then
                EditCanceled = False
                Exit Sub
            End If
            ClearFields(Me.Controls, True)
            'DataSet1.Clear()
            EditMode = "Add"
            KeyValue1 = ""
            KeyValue2 = ""
            EditButtons("Add")
            Dim cnt As Control
            For Each cnt In Me.Controls
                If UCase(cnt.Name) = UCase(FocusField) Then
                    cnt.Focus()
                    Exit For
                End If
            Next
            Add_After()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Overridable Sub Add_Before()
        EditMode = "Add"
    End Sub
    Public Overridable Sub Add_After()
    End Sub
    Public Overridable Sub Edit_Before()
        EditMode = "Edit"
    End Sub
    Public Overridable Sub Edit()
        Try
            If SecLevel < jEdit Then
                MsgBox("You do not have EDIT permision on this screen.", MsgBoxStyle.Critical, "Permission?")
                Exit Sub
            End If
            Edit_Before()
            If EditCanceled = True Then
                EditCanceled = False
                Exit Sub
            End If
            UnLockCtr(Me.Controls)
            EditMode = "Edit"
            EditButtons("Edit")
            Edit_After()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Overridable Sub Edit_After()

    End Sub
    Public Overridable Sub Save()
        Try
            Save_Before()
            If SaveCanceled = True Then
                SaveCanceled = False
                Exit Sub
            End If
            If jSave(Me) = True Then
                EditButtons("Idle")
            End If
            Save_After()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Overridable Sub Save_After()
    End Sub
    Public Overridable Sub Save_Before()
    End Sub
    Public Overridable Sub Cancel()
        Try
            Dim DoIt As Boolean
            If QuietMode = True Then DoIt = True
            If DoIt = False Then
                If MsgBox("Are you sure you want to CANCEL?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then DoIt = True
            End If
            If DoIt Then
                ClearFields(Me.Controls, False)
                LockCtr(Me.Controls)
                If KeyValue1 = "" Then
                    EditButtons("Blank")
                    LoadFields(Me)
                Else
                    EditButtons("Idle")
                End If
                Cancel_After()
            End If
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Overridable Sub Cancel_After()
    End Sub
    Public Overridable Sub Delete()
    End Sub
    Public Overridable Sub Done()
        MainForm.ActiveMdiChild.Close()
    End Sub
    Public Overridable Sub Print(Optional ByVal Output As String = "")
    End Sub
    Public Overridable Sub Find()
    End Sub


    Private Sub fmStarter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub fmStarter_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    End Sub
End Class
