Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.Shared
Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Xml
Imports System.Net.Mail

Module Jcom
    Public MainForm As fmMain
    Public User As String
    Public UserType As String
    Public UserSerial As Long
    Public UserGroup As String
    Public UserGroupSerial As Long
    Public UserISRAdmin As Boolean
    Public UserOSR As String
    Public Server As String
    Public Path As String
    ' test server file path Public PDFPath As String = "\\server93\Projects$\"
    Public PDFPath As String = "\\10.0.0.245\projects$\"
    Public PDFPathContact As String = "\\10.0.0.245\contacts$\"
    Public ImagePath As String
    Public cnn As SqlClient.SqlConnection
    Public cnn2 As SqlClient.SqlConnection
    Public cnn3 As SqlClient.SqlConnection
    Public cnnAutoCad As New SqlConnection
    Public dsUsrFile As New DataSet
    Public dsCustFile As New DataSet
    Public Const jView As Byte = 1
    Public Const jEdit As Byte = 2
    Public Const jAdd As Byte = 4
    Public Const jDelete As Byte = 8
    Public fmOSearch As fmOrdSearch
    Public fmFindAll As fmFind
    Public AcctClosed As Date
    Public AcctLocked As Date
    Public DefForm As String
    Public connStr As String
    Public QT As String = Chr(34)
    Public onDatabase As String = "winecellar"
    Public Custom As New ArrayList
    Public QuietMode As Boolean = False
    Public QuietModeForIWA As Boolean = False
    Public DoKeyLog As Boolean = False
    Public itmerr As String = ""

    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long


    Class jFld
        Public FieldName As String
        Public Field As String
        Public FieldType As String
        Public Searchable As Boolean
        Public TextBox As TextBox
        Public SearchAll As Boolean = True
    End Class
    Public Class DataGridComboBoxColumn
        Private cb As ComboBox
        Private cm As CurrencyManager
        Private iCurrentRow As Integer
        Public Sub DataGridComboBoxColumn()
            cm = Nothing
            cb = New ComboBox
            cb.DropDownStyle = ComboBoxStyle.DropDownList
            'cb.Leave += New EventHandler(comboBox_Leave)
        End Sub
        Public Combobox As ComboBox

    End Class
    Public Class Param
        Public Name As String
        Public Value As Object
    End Class

    Public Declare Function BringWindowToTop Lib "user32" (ByVal hwnd As Long) As Long
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Long
    Public Class LatLong
        Public Longitude As Double
        Public Latitude As Double
    End Class
    Public Sub LoadAcctClosed()
        Dim cmd As New SqlClient.SqlCommand("select mas_acct_closed from mas_file where mas_serial=1", cnn)
        'cnn.Open()
        AcctClosed = cmd.ExecuteScalar
        cmd.CommandText = "select mas_acct_locked from mas_file where mas_serial=1"
        AcctLocked = cmd.ExecuteScalar
        'cnn.Close()
    End Sub
    Public Sub cnnConnect()
        If Not cnn Is Nothing Then cnn.Close()

        connStr = "server=dev1.myprogrammer.com,10591;user id=igor.lazarev; password=JGMn4wbhnHL9s3be; database=wci-dev2"
        'String.Format("server={0};user id={1}; password={2}; database=" + onDatabase + "; pooling=false", Server, "WCIStar", "39201")
        'connStr = String.Format("server={0};user id={1}; password={2}; database=" + onDatabase + "; pooling=false", Server, "sa", "39201")
        ' connStr = String.Format("server={0};user id={1}; password={2}; database=" + onDatabase + "; pooling=false", "devsql08\sqlserv8", "WCIStar", "39201")

        Try
            cnn = New SqlClient.SqlConnection(connStr)
            cnn2 = New SqlClient.SqlConnection(connStr)
            cnn3 = New SqlClient.SqlConnection(connStr)

            cnnAutoCad.ConnectionString = "server=dev1.myprogrammer.com,10591;user id=igor.lazarev; password=JGMn4wbhnHL9s3be; database=wci-dev2"
            '"server=" + Server + "; user id=sa; password='JGMn4wbhnHL9s3be'; database=AutoCad_Automation; pooling=false"
        Catch
            MsgBox(Err.Description)
            End
            DoError(Err, MainForm)
            Dim fm As New fmSetting
            fm.ID = "Server"
            fm.ShowDialog()
        End Try

    End Sub
    Public Sub LoadActiveForm(ByRef Mainx As Form, ByRef Formx As Form)
        Dim x As Integer
        Dim DoIt As Boolean
        For x = 0 To Mainx.MdiChildren.Length - 1
            If Mainx.MdiChildren(x).Name = Formx.Name Then DoIt = False
        Next
        If DoIt Then
            Formx.Show()
        End If
    End Sub
    Public Sub LockCtr(ByVal cts As Control.ControlCollection)
        Dim ct As New Control
        Dim fStat, fField, fType As String
        For Each ct In cts
            GetTag(ct.Tag, fStat, fField, fType)
            If fStat = "EDIT" Then
                ct.Enabled = False
            End If
            If ct.Controls.Count > 0 Then LockCtr(ct.Controls)
        Next
        If ct.GetType Is GetType(Infragistics.Win.UltraWinGrid.UltraGrid) Then
            Dim Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
            Grid1 = ct
            Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
            Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Grid1 = Nothing
        End If

    End Sub
    Public Sub UnLockCtr(ByVal cts As Control.ControlCollection)
        Dim ct As New Control
        Dim fStat, fField, fType As String
        For Each ct In cts
            GetTag(ct.Tag, fStat, fField, fType)
            If fStat = "EDIT" Then
                ct.Enabled = True
            End If
            If ct.GetType Is GetType(Infragistics.Win.UltraWinGrid.UltraGrid) And fStat <> "NOEDIT" Then
                Dim Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
                Grid1 = ct
                Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
                Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True
                Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
                Grid1 = Nothing
            End If
            If ct.Controls.Count > 0 Then UnLockCtr(ct.Controls)
        Next
    End Sub
    Public Sub GetTag(ByVal Tags As String, ByRef fStat As String, ByRef fField As String, ByRef fType As String)
        Dim flds() As String = Split(Tags, ";")
        Try
            fStat = ""
            fField = ""
            fType = ""
            fStat = UCase(flds(0))
            If flds.Length > 1 Then fField = UCase(flds(1))
            If flds.Length > 2 Then
                fType = UCase(flds(2))
            Else
                fType = "TX"
            End If
        Catch
            MsgBox("Could not get field information for " + Tags)
        End Try
    End Sub
    Public Sub GetTagOld(ByVal Tags As String, ByRef fStat As String, ByRef fField As String, ByRef fType As String)

        Dim Endx As Integer
        Dim cnt As Integer
        cnt = 1
        fStat = ""
        fField = ""
        fType = ""
        Do While Tags <> ""
            Endx = InStr(1, Tags, ";")
            If Endx = 0 Then Endx = 999
            Select Case cnt
                Case 1
                    fStat = UCase(Mid(Tags, 1, Endx - 1))
                Case 2
                    fField = UCase(Mid(Tags, 1, Endx - 1))
                Case 3
                    fType = UCase(Mid(Tags, 1, Endx - 1))
            End Select
            Tags = Mid(Tags, Endx + 1)
            cnt = cnt + 1
        Loop
        If fType = "" Then fType = "TX"
    End Sub
    Public Sub ClearFields(ByRef cts As Control.ControlCollection, ByVal UnlockIt As Boolean)
        Dim ct As New Control
        For Each ct In cts
            ClearFieldsSub(ct, UnlockIt)
            If UnlockIt Then
                If ct.GetType Is GetType(Infragistics.Win.UltraWinGrid.UltraGrid) And ct.Tag <> "NOEDIT" Then
                    Dim Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
                    Grid1 = ct
                    Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
                    Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True
                    Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
                    Grid1 = Nothing
                End If
            End If
            If ct.Controls.Count > 0 Then ClearFields(ct.Controls, UnlockIt)
        Next
    End Sub
    Private Sub ClearFieldsSub(ByVal ct As Control, ByVal UnLockIt As Boolean)
        Dim fStat, fField, fType As String
        GetTag(ct.Tag, fStat, fField, fType)
        If ((fStat = "EDIT") Or (fStat = "SHOW") Or (fStat = "KEY")) Then
            If (fType <> "CB") And (ct.GetType.ToString <> GetType(Infragistics.Win.UltraWinEditors.UltraCheckEditor).ToString) Then
                On Error Resume Next
                If (Not ct.GetType Is GetType(Infragistics.Win.Misc.UltraButton)) And (Not ct.GetType Is GetType(Button)) Then
                    If ct.GetType Is GetType(Infragistics.Win.UltraWinEditors.UltraCurrencyEditor) Then
                        Dim ct2 As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
                        ct2 = ct
                        ct2.Value = 0
                        ct2 = Nothing
                    Else
                        ct.Text = ""
                    End If
                End If
                On Error GoTo 0
            Else
                If ct.GetType Is GetType(Infragistics.Win.UltraWinEditors.UltraCheckEditor) Then
                    Dim ct3 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
                    ct3 = ct
                    ct3.Checked = False
                End If
            End If
            If fStat = "EDIT" Then ct.Enabled = UnLockIt
        End If
    End Sub

    Public Function LoadFields(ByRef frm As fmStarter) As Boolean
        Try
            If frm.KeyValue1 = "" Then Exit Function
            Dim cmd As New SqlClient.SqlCommand
            Dim rst As SqlClient.SqlDataReader
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            Dim ct As Control
            Dim sqlx As String
            Dim fStat, fField, fType As String

            sqlx = "select * from " + frm.Table + " where " + frm.Key1 + "='" + frm.KeyValue1 + "'"
            cmd.CommandText = sqlx
            cnn2.Open()
            cmd.Connection = cnn2
            da.Fill(tbl)
            cnn2.Close()
            If tbl.Rows.Count = 0 Then
                MsgBox("Record NOT FOUND", vbCritical, "NOT FOUND")
                cmd = Nothing
                LoadFields = False
                Exit Function
            End If
            frm.KeyValue1 = CStr(tbl.Rows(0)(frm.Key1))

            LoadFieldsSub(frm.Controls, tbl.Rows(0))

            cnn2.Close()
            LoadFields = True
        Catch
            DoError(Err, MainForm)
        End Try
    End Function
    Private Sub LoadFieldsSub(ByVal cts As Control.ControlCollection, ByVal rst As DataRow)
        Try
            Dim ct As New Control
            Dim fStat, fField, fType As String
            For Each ct In cts
                GetTag(ct.Tag, fStat, fField, fType)
                If (fStat = "EDIT") Or (fStat = "SHOW") Or (fStat = "KEY") Then
                    If fField <> "" Then
                        If Not rst(fField) Is DBNull.Value Then
                            Select Case fType
                                Case "TX"
                                    If ct.GetType Is GetType(Infragistics.Win.UltraWinGrid.UltraCombo) Then
                                        Dim ct2 As Infragistics.Win.UltraWinGrid.UltraCombo
                                        ct2 = ct
                                        ct2.Value = rst(fField)
                                        ct2.Text = rst(fField)
                                        ct2 = Nothing
                                    ElseIf ct.GetType Is GetType(Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit) Then
                                        Dim ct2 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
                                        ct2 = ct
                                        ct2.Value = rst(fField)
                                        ct2.Text = rst(fField)
                                        ct2 = Nothing
                                    Else
                                        ct.Text = Trim(rst(fField).ToString)
                                    End If
                                Case "DC"
                                    Dim ct2 As Infragistics.Win.UltraWinGrid.UltraCombo
                                    ct2 = ct
                                    ct2.Text = rst(fField)
                                    ct2.Value = rst(fField)
                                    ct2 = Nothing
                                Case "NM"
                                    If ct.GetType Is GetType(Infragistics.Win.UltraWinGrid.UltraCombo) Then
                                        Dim ct2 As Infragistics.Win.UltraWinGrid.UltraCombo
                                        ct2 = ct
                                        ct2.Value = rst(fField)
                                        ct2 = Nothing
                                    Else
                                        ct.Text = rst(fField).ToString
                                    End If
                                Case "CB"
                                    Dim ct2 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
                                    ct2 = ct
                                    ct2.Checked = rst(fField) ' And 1
                                    ct2 = Nothing
                                Case "DT"
                                    If ct.GetType Is GetType(Infragistics.Win.UltraWinEditors.UltraDateTimeEditor) Then
                                        Dim ct2 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
                                        ct2 = ct
                                        ct2.Value = rst(fField)
                                    Else
                                        ct.Text = Format(rst(fField), "MM/dd/yyyy")
                                    End If
                                Case "CU"
                                    If ct.GetType Is GetType(Infragistics.Win.UltraWinEditors.UltraCurrencyEditor) Then
                                        Dim ct2 As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
                                        ct2 = ct
                                        ct2.Value = rst(fField)
                                    Else
                                        ct.Text = FormatCurrency(rst(fField))
                                    End If
                                Case "LB"
                                    ct.Text = Trim(rst(fField).ToString)
                            End Select
                        Else
                            Select Case ct.GetType.ToString
                                Case GetType(Infragistics.Win.UltraWinEditors.UltraNumericEditor).ToString
                                    Dim ct3 As Infragistics.Win.UltraWinEditors.UltraNumericEditor
                                    ct3 = ct
                                    ct3.Value = 0
                                    ct3 = Nothing
                                Case GetType(Infragistics.Win.UltraWinEditors.UltraCurrencyEditor).ToString
                                Case GetType(Infragistics.Win.UltraWinEditors.UltraCheckEditor).ToString
                                    Dim ct4 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
                                    ct4 = ct
                                    ct4.Checked = False
                                    ct4 = Nothing
                                Case Else
                                    If (Not ct.GetType Is GetType(Infragistics.Win.Misc.UltraButton)) And (Not ct.GetType Is GetType(Infragistics.Win.UltraWinEditors.UltraCheckEditor)) And (Not ct.GetType Is GetType(Button)) Then
                                        ct.Text = ""
                                    End If
                            End Select
                        End If
                    End If
                    ct.Enabled = False
                End If
                If ct.Controls.Count > 0 Then LoadFieldsSub(ct.Controls, rst)
            Next
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Function jSave(ByRef frm As fmStarter) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        Dim x As Integer
        Dim fStat, fField, fType As String
        Dim FieldList As String = ""
        Dim DataList As String = ""
        Dim ct As New Control

        jSave = False
        On Error GoTo ErrOut
        If frm.EditMode = "Add" Then
            JSaveAdd(frm.Controls, FieldList, DataList)
            If FieldList <> "" Then FieldList = Mid(FieldList, 1, Len(FieldList) - 1)
            If DataList <> "" Then DataList = Mid(DataList, 1, Len(DataList) - 1)
            cmd.CommandText = "insert into " + frm.Table + " (" + FieldList + ",LAST_UPDATE,UPDATE_BY) values (" + DataList + ",'" + Format(Today, "yyyy-MM-dd") + "','" + Jcom.User + "')"
            cnn.Open()
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
            Do While cnn.State = ConnectionState.Executing
            Loop
            cmd.CommandText = "select @@IDENTITY as jid"
            frm.KeyValue1 = cmd.ExecuteScalar
            cnn.Close()
            'KeyValue = CStr(LastAuto)
        Else
            JSaveEdit(frm.Controls, DataList)
            DataList = Mid(DataList, 1, Len(DataList) - 1)
            cmd.CommandText = "update " + frm.Table + " set " + DataList + ",last_update='" + CStr(Now) + "',update_by='" + Jcom.User + "' where " + frm.Key1 + "=" + frm.KeyValue1
            cnn.Open()
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
            cnn.Close()
        End If
        On Error GoTo 0
        frm.EditMode = ""
        jSave = True
        Exit Function
ErrOut:
        DoError(Err, MainForm)
    End Function
    Private Sub JSaveAdd(ByRef cts As Control.ControlCollection, ByRef FieldList As String, ByRef DataList As String)
        Dim ct As New Control
        For Each ct In cts
            JSaveAddSub(ct, FieldList, DataList)
            If ct.Controls.Count > 0 Then JSaveAdd(ct.Controls, FieldList, DataList)
        Next
    End Sub

    Private Sub JSaveAddSub(ByVal ct As Control, ByRef FieldList As String, ByRef DataList As String)
        Dim fStat, fField, fType As String
        GetTag(ct.Tag, fStat, fField, fType)
        If ((fStat = "EDIT") Or (fStat = "SHOW")) And (fField <> "") Then
            FieldList = FieldList + fField + ","
            Select Case fType
                Case "TX"
                    DataList = DataList + "'" + Replace(ct.Text, "'", "''") + "',"
                Case "DC"
                    Dim ct2 As Infragistics.Win.UltraWinGrid.UltraCombo
                    ct2 = ct
                    DataList = DataList + "'" + CStr(ct2.Value) + "',"
                    ct2 = Nothing
                Case "LB"
                    DataList = DataList + "'" + Replace(ct.Text, "'", "''") + "',"
                Case "NM"
                    If ct.GetType() Is GetType(Infragistics.Win.UltraWinGrid.UltraCombo) Then
                        Dim fm As Infragistics.Win.UltraWinGrid.UltraCombo
                        fm = ct
                        If fm.Value Is Nothing Then
                            DataList = DataList + "0,"
                        Else
                            DataList = DataList + CStr(fm.Value) + ","
                        End If
                        fm = Nothing
                    Else
                        If Trim(ct.Text) = "" Then ct.Text = "0"
                        If Not IsNumeric(Replace(Replace(ct.Text, "$", ""), "%", "")) Then
                            MsgBox("Must be NUMERIC", vbCritical, "Numeric?")
                            'UnLockCtr(frm)
                            ct.Focus()
                            Exit Sub
                        End If
                        DataList = DataList + Replace(Replace(ct.Text, "$", ""), "%", "") + ","
                    End If
                Case "CU"
                    If Trim(ct.Text) = "" Then ct.Text = "0"
                    If Not IsNumeric(Replace(ct.Text, "$", "")) Then
                        MsgBox("Must be NUMERIC", vbCritical, "Numeric?")
                        'UnLockCtr(frm)
                        ct.Focus()
                        Exit Sub
                    End If
                    DataList = DataList + Replace(Replace(ct.Text, "$", ""), ",", "") + ","
                Case "CB"
                    Dim ct2 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
                    ct2 = ct
                    If ct2.Checked Then
                        DataList = DataList + "1,"
                    Else
                        DataList = DataList + "0,"
                    End If
                Case "DT"
                    If (Not IsDate(ct.Text)) And (Not Trim(ct.Text) = "") Then
                        MsgBox("Must be a DATE", vbCritical, "Date?")
                        'UnLockCtr(frm)
                        ct.Focus()
                        Exit Sub
                    End If
                    If IsDate(ct.Text) Then
                        DataList = DataList + "'" + Format(CDate(ct.Text), "yyyy-MM-dd") + "',"
                    Else
                        DataList = DataList + "'',"
                    End If
            End Select
        End If
        If fStat = "EDIT" Then ct.Enabled = False
        If ct.GetType Is GetType(Infragistics.Win.UltraWinGrid.UltraGrid) And fStat <> "NOEDIT" Then
            Dim Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
            Grid1 = ct
            Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
            Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Grid1 = Nothing
        End If
    End Sub
    Private Sub JSaveEdit(ByRef cts As Control.ControlCollection, ByRef DataList As String)
        Dim ct As New Control
        For Each ct In cts
            JSaveEditSub(ct, DataList)
            If ct.Controls.Count > 0 Then JSaveEdit(ct.Controls, DataList)
        Next
    End Sub
    Private Sub JSaveEditSub(ByVal ct As Control, ByRef DataList As String)
        Dim fStat, fField, fType As String
        GetTag(ct.Tag, fStat, fField, fType)
        If ((fStat = "EDIT") Or (fStat = "SHOW")) And (fField <> "") Then
            DataList = DataList + fField + "="
            Select Case fType
                Case "TX"
                    DataList = DataList + "'" + Replace(ct.Text, "'", "''") + "',"
                Case "DC"
                    Dim ct2 As Infragistics.Win.UltraWinGrid.UltraCombo
                    ct2 = ct
                    DataList = DataList + "'" + Replace(ct2.Value, "'", "''") + "',"
                    ct2 = Nothing
                Case "LB"
                    DataList = DataList + "'" + Replace(ct.Text, "'", "''") + "',"
                Case "NM"
                    If ct.GetType() Is GetType(Infragistics.Win.UltraWinGrid.UltraCombo) Then
                        Dim fm As Infragistics.Win.UltraWinGrid.UltraCombo
                        fm = ct
                        If fm.Value Is Nothing Then
                            DataList = DataList + "0,"
                        Else
                            DataList = DataList + CStr(fm.Value) + ","
                        End If
                        fm = Nothing
                    Else
                        If Trim(ct.Text) = "" Then ct.Text = "0"
                        If Not IsNumeric(Replace(Replace(ct.Text, "$", ""), "%", "")) Then
                            MsgBox("Must be NUMERIC", vbCritical, "Numeric?")
                            'UnLockCtr(frm)
                            ct.Focus()
                            Exit Sub
                        End If
                        DataList = DataList + Replace(Replace(Replace(ct.Text, "$", ""), "%", ""), ",", "") + ","
                    End If
                Case "CU"
                    If Trim(ct.Text) = "" Then ct.Text = "0"
                    If Not IsNumeric(Replace(ct.Text, "$", "")) Then
                        MsgBox("Must be NUMERIC", vbCritical, "Numeric?")
                        'UnLockCtr(frm)
                        ct.Focus()
                        Exit Sub
                    End If
                    DataList = DataList + Replace(Replace(ct.Text, "$", ""), ",", "") + ","
                Case "CB"
                    Dim ct2 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
                    ct2 = ct
                    If ct2.Checked Then
                        DataList = DataList + "1,"
                    Else
                        DataList = DataList + "0,"
                    End If
                Case "DT"
                    If (Not IsDate(ct.Text)) And (Not Trim(ct.Text) = "") Then
                        MsgBox("Must be a DATE", vbCritical, "Date?")
                        'UnLockCtr(frm)
                        ct.Focus()
                        Exit Sub
                    End If
                    If IsDate(ct.Text) Then
                        DataList = DataList + "'" + Format(CDate(ct.Text), "yyyy-MM-dd") + "',"
                    Else
                        DataList = DataList + "'',"
                    End If
                Case Else
                    MsgBox("Field type " + fType + " is not valid")
            End Select
        End If
        If fStat = "EDIT" Then ct.Enabled = False
        If ct.GetType Is GetType(Infragistics.Win.UltraWinGrid.UltraGrid) And fStat <> "NOEDIT" Then
            Dim Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
            Grid1 = ct
            Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
            Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Grid1 = Nothing
        End If
    End Sub
    Public Sub DoError(ByVal Errx As ErrObject, ByVal Sender As Object, Optional ByVal AdditionalInfo As String = "")
        Try
            Dim ord As Long = 0
            Dim src As String = ""

            If Sender.GetType Is GetType(fmEstOrd2) Then
                Dim fm As fmEstOrd2 = Sender
                If IsNumeric(fm.tOrd.Text) Then ord = CLng(fm.tOrd.Text)
                src = fm.Name + "(" + fm.Tab1.ActiveTab.Key + ";" + fm.TabItems.ActiveTab.Key + ")"
            Else
                src = Sender.GetType.Name
            End If

            If cnn.State <> ConnectionState.Closed Then cnn.Close()
            If cnn2.State <> ConnectionState.Closed Then cnn2.Close()
            Dim Stack As String = Errx.GetException.StackTrace
            If AdditionalInfo <> "" Then Stack = Stack + vbCrLf + vbCrLf + AdditionalInfo
            Dim cmd As New SqlCommand("insert into err_file (err_num,err_desc,err_source,err_user,err_date,err_stack,err_ord_serial) values (" + CStr(Errx.Number) + ",'" + Mid(Replace(Errx.Description, "'", "''"), 1, 255) + "','" + src + "','" + User + "','" + Now + "','" + Stack + "'," + CStr(ord) + ")", cnn)
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
        Catch
            'MsgBox(Err.Description)
        Finally
            MsgBox("(" + Errx.Number.ToString + ") " + Errx.Description + vbCrLf + "(" + Errx.Erl.ToString + ") " + Errx.Source)

        End Try
    End Sub
    Public Sub DeleteRecord(ByVal Tablex As String, ByVal Wherex As String)
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "delete from " + Tablex + " where " + Wherex
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
            cmd = Nothing
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Function FoundItem(ByVal Tablex As String, ByVal Fieldx As String, ByVal Valuex As String) As Boolean
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "select count(*) from " + Tablex + " where " + Fieldx + "='" + Valuex + "'"
            cnn.Open()
            FoundItem = cmd.ExecuteScalar() <> 0
            cnn.Close()
        Catch ex As Exception
            DoError(Err, MainForm)
        End Try
    End Function
    Public Sub AddItem(ByVal Tablex As String, ByVal Fieldx As String, ByVal Valuex As String)
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "insert into " + Tablex + " (" + Fieldx + ") values ('" + Valuex + "')"
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Sub CheckItem(ByRef ct As ComboBox, ByVal Tablex As String, ByVal Fieldx As String, ByVal Valuex As String)
        If ct.Text = "" Then Exit Sub
        ct.Text = UCase(ct.Text)
        If FoundItem(Tablex, Fieldx, ct.Text) = True Then
        Else
            If MsgBox(ct.Text + " does not exist.  Do you want to ADD it now?", MsgBoxStyle.YesNo, "Add?") = MsgBoxResult.Yes Then
                AddItem(Tablex, Fieldx, ct.Text)
                LoadList(ct, Tablex, Fieldx, Fieldx)
                ct.DropDownStyle = ComboBoxStyle.DropDownList
                ct.Text = Valuex
            Else
                ct.DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End If
    End Sub
    Public Sub LoadList(ByRef ct As ComboBox, ByVal Tablex As String, ByVal Fieldx As String, ByVal Datax As String, Optional ByVal Wherex As String = "")
        Dim cmd As New SqlClient.SqlCommand
        Dim da As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        cmd.Connection = cnn
        cmd.CommandText = "select " + Datax + "," + Fieldx + " from " + Tablex
        If Wherex <> "" Then cmd.CommandText = cmd.CommandText + " where " + Wherex
        cmd.CommandText = cmd.CommandText + " order by " + Fieldx
        da.SelectCommand = cmd
        cnn.Open()
        da.Fill(ds, Tablex)
        cnn.Close()
        ct.DisplayMember = Fieldx
        ct.ValueMember = Datax
        ct.DataSource = ds.Tables(0)
        '        ct.Items.Clear()
        '        Do While dr.Read
        '        ct.Items.Add(dr(0))
        '        Loop
        da = Nothing
        ds = Nothing
        cmd = Nothing
    End Sub
    Public Function LoadForm(ByVal Formx As String) As Form
        Dim SecLevel As Byte = CheckSecurity(Formx)
        If SecLevel = 0 Then
            MsgBox("You do not have access to this screen.", MsgBoxStyle.Critical, "Access?")
            Exit Function
        End If

        Dim x, cnt As Integer
        Dim DoIt As Boolean = True
        Dim HasButton As Boolean = True
        cnt = 0
        For x = 0 To MainForm.MdiChildren.Length - 1
            If MainForm.MdiChildren(x).Tag = Formx Then
                cnt = cnt + 1
                'DoIt = False
                Exit For
            End If
        Next
        If MainForm.ActiveMdiChild Is Nothing Then
            DoIt = True
            cnt = cnt + 1
        Else
            If (MainForm.ActiveMdiChild.Tag = Formx) And (Formx <> "Check Off") And (Formx <> "To Do List") Then
                DoIt = True
                cnt = cnt + 1
            Else
                If cnt = 0 Then
                    DoIt = True
                    cnt = cnt + 1
                Else
                    DoIt = False
                End If
            End If
        End If
        Select Case Formx
            Case "Customers"
                Dim fm As fmCustomer
                If DoIt Then
                    fm = New fmCustomer
                    fm.MdiParent = MainForm
                    fm.Tag = Formx
                    fm.SecLevel = SecLevel
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
            Case "Check Off"
                Dim fm As fmToDo
                If DoIt Then
                    fm = New fmToDo
                    fm.MdiParent = MainForm
                    fm.Tag = Formx
                    fm.SecLevel = SecLevel
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
            Case "To Do List"
                Dim fm As fmToDoList
                If DoIt Then
                    fm = New fmToDoList
                    fm.MdiParent = MainForm
                    fm.Tag = Formx
                    fm.SecLevel = SecLevel
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
            Case "Quotes/Orders"
                'If CheckSecurity("Orders2") > 0 Then
                Dim fm As New fmEstOrd2
                If DoIt Then
                    fm = New fmEstOrd2
                    fm.MdiParent = MainForm
                    fm.Tag = Formx
                    fm.SecLevel = SecLevel
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
                'Else
                'Dim fm As fmEstOrd
                'If DoIt Then
                '    fm = New fmEstOrd
                '    fm.MdiParent = MainForm
                '    fm.Tag = Formx
                '    fm.SecLevel = SecLevel
                '    fm.Show()
                'Else
                '    fm = MainForm.MdiChildren(x)
                '    fm.BringToFront()
                'End If
                'LoadForm = fm
                'End If
            Case "Parts"
                Dim fm As fmParts
                If DoIt Then
                    fm = New fmParts
                    fm.MdiParent = MainForm
                    fm.Tag = Formx
                    fm.SecLevel = SecLevel
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
            Case "Payments"
                Dim fm As fmPayment
                If DoIt Then
                    fm = New fmPayment
                    fm.MdiParent = MainForm
                    fm.Tag = Formx
                    fm.SecLevel = SecLevel
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
            Case "Shipments"
                Dim fm As fmShipment
                If DoIt Then
                    fm = New fmShipment
                    fm.MdiParent = MainForm
                    fm.SecLevel = SecLevel
                    fm.Tag = Formx
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
            Case "Contacts"
                Dim fm As fmContacts
                If DoIt Then
                    fm = New fmContacts
                    fm.MdiParent = MainForm
                    fm.SecLevel = SecLevel
                    fm.Tag = Formx
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
            Case "Production"
                Dim fm As fmProduction
                If DoIt Then
                    fm = New fmProduction
                    fm.MdiParent = MainForm
                    fm.SecLevel = SecLevel
                    fm.Tag = Formx
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
            Case "Billing"
                Dim fm As fmBilling
                If DoIt Then
                    fm = New fmBilling
                    fm.MdiParent = MainForm
                    fm.SecLevel = SecLevel
                    fm.Tag = Formx
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
            Case "Report"
                Dim fm As fmReport
                If DoIt Then
                    fm = New fmReport
                    fm.MdiParent = MainForm
                    fm.Tag = Formx
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
                HasButton = False
            Case "Users"
                Dim fm As fmUsers
                If DoIt Then
                    fm = New fmUsers
                    fm.MdiParent = MainForm
                    fm.Tag = Formx
                    fm.SecLevel = SecLevel
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
                HasButton = False
            Case "VendorNet"
                Dim fm As fmVendorNet
                If DoIt Then
                    fm = New fmVendorNet
                    fm.MdiParent = MainForm
                    fm.Tag = Formx
                    fm.SecLevel = SecLevel
                    fm.Show()
                Else
                    fm = MainForm.MdiChildren(x)
                    fm.BringToFront()
                End If
                LoadForm = fm
                HasButton = False
        End Select
        If HasButton Then
            MainForm.Toolbar1.Toolbars(0).Tools(Formx).SharedProps.Caption = MainForm.Toolbar1.Toolbars(0).Tools(Formx).Key.ToString + " (" + cnt.ToString + ")"
            'EditButtons("Blank")
        End If
    End Function
    Public Function FormsLoaded(ByVal Formx As String) As Integer
        Try
            If Formx Is Nothing Then Exit Function
            Dim x, cnt As Integer
            cnt = 0
            If MainForm.MdiChildren.Length > 0 Then
                For x = 0 To MainForm.MdiChildren.Length - 1
                    If MainForm.MdiChildren(x).Tag = Formx Then
                        cnt = cnt + 1
                    End If
                Next
            End If
            cnt = cnt - 1
            FormsLoaded = cnt
            If cnt <= 1 Then
                MainForm.Toolbar1.Toolbars(0).Tools(Formx).SharedProps.Caption = MainForm.Toolbar1.Toolbars(0).Tools(Formx).Key.ToString
            Else
                MainForm.Toolbar1.Toolbars(0).Tools(Formx).SharedProps.Caption = MainForm.Toolbar1.Toolbars(0).Tools(Formx).Key.ToString + " (" + cnt.ToString + ")"
            End If
        Catch
            FormsLoaded = 0
        End Try
    End Function
    Public Sub DisplayReport(ByVal Report As String, Optional ByVal Filter As String = "", Optional ByVal Preview As Boolean = False, Optional ByVal copies As Integer = 1, Optional ByVal Param1 As Object = Nothing, Optional ByVal Param2 As Object = Nothing, Optional ByVal ShowGroup As Boolean = False, Optional ByVal PrintOnMain As Boolean = False, Optional ByVal PreProcess As String = "", Optional ByVal Params As Collection = Nothing, Optional ByVal Output As String = "", Optional ByVal OutputType As String = "PDF", Optional ByVal PrinterName As String = "", Optional ByVal Tray As String = "")
        Try
            Dim StartDate, EndDate As Date
            'MainForm.Toolbar1.Toolbars("AddEdit").Tools(5).SharedProps.Enabled = False
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim cr As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim cnnState As ConnectionState = cnn.State

            If Right(Report, 4) <> ".rpt" Then Report = Report + ".rpt"

            If Report.ToLower() = "FactoryKitsBudget.rpt".ToLower() Then
                Report = "FactoryKitsBudget - 13Apr2017.rpt"
            End If

            Try
                Dim cmd As New SqlCommand("select reports_ran_count from reports_ran where reports_ran_report='" + Replace(Path + "Reports\" + Report, "'", "''") + "' and reports_ran_user='" + User + "'", cnn)
                If cnn.State <> ConnectionState.Open Then cnn.Open()
                Dim onReportsRanSerial As Long = nz(cmd.ExecuteScalar, 0)
                If onReportsRanSerial = 0 Then
                    cmd.CommandText = "insert into reports_ran (reports_ran_report,reports_ran_user,reports_ran_count,reports_ran_last) values ('" + Replace(Path + "Reports\" + Report, "'", "''") + "','" + User + "',1,'" + CStr(Now) + "')"
                Else
                    cmd.CommandText = "update reports_ran set reports_ran_count=reports_ran_count+1 where reports_ran_serial=" + CStr(onReportsRanSerial)
                End If
                cmd.ExecuteNonQuery()
                If cnnState = ConnectionState.Closed Then cnn.Close()
            Catch
            End Try

            cr.Load(Path + "Reports\" + Report)

            If PrinterName <> "" Then cr.PrintOptions.PrinterName = PrinterName

            Dim tb As CrystalDecisions.CrystalReports.Engine.Table
            Dim sr As CrystalDecisions.CrystalReports.Engine.ReportDocument

            If onDatabase <> "winecellar" Then
                For Each tb In cr.Database.Tables
                    tb.LogOnInfo.ConnectionInfo.ServerName = onDatabase
                Next
                For Each sr In cr.Subreports
                    For Each tb In sr.Database.Tables
                        tb.LogOnInfo.ConnectionInfo.ServerName = onDatabase
                    Next
                Next
            End If

            Dim p As CrystalDecisions.Shared.ParameterField
            Dim cnt As Integer = 0
            Dim p1, p2 As String
            For Each p In cr.ParameterFields
                If p.Name = "StartDate" Then
                    cnt = cnt + 1
                    p1 = "StartDate"
                End If
                If p.Name = "Start Date" Then
                    cnt = cnt + 1
                    p1 = "Start Date"
                End If

                If p.Name = "EndDate" Then
                    cnt = cnt + 1
                    p2 = "EndDate"
                End If
                If p.Name = "End Date" Then
                    cnt = cnt + 1
                    p2 = "End Date"
                End If
            Next

            StartDate = CDate("1/1/1900")
            EndDate = CDate("12/31/2099")
            If cnt >= 2 Then
                Dim fmDate As New fmDateSelect
                fmDate.ShowDialog()
                If IsDate(fmDate.StartDate) Then
                    StartDate = fmDate.StartDate
                    cr.SetParameterValue(p1, fmDate.StartDate)
                End If
                If IsDate(fmDate.EndDate) Then
                    EndDate = fmDate.EndDate
                    cr.SetParameterValue(p2, fmDate.EndDate)
                End If
            End If

            If PreProcess <> "" Then
                Select Case PreProcess
                    Case "LoadCurrentOSR"
                        LoadCurrentOSR(StartDate, EndDate, "O")
                    Case "LoadCurrentRegion"
                        LoadCurrentOSR(StartDate, EndDate, "R")
                    Case "LoadCurrentBase"
                        LoadCurrentBase()
                    Case "LoadCurrentSalesCat"
                        LoadCurrentSalesCat(StartDate, EndDate)
                        'Case "LoadCurrentSalesCommission"
                        '    LoadCurrentSalesCommission(StartDate, EndDate)
                    Case "LoadUnstained"
                        LoadUnstained(StartDate, EndDate)
                    Case "LoadLatestRev"
                        LoadLatestRev(StartDate, EndDate)
                    Case "LoadItemsShippedAllParts"
                        LoadItemsShippedAllParts(StartDate, EndDate)
                    Case Else
                        If QuietMode = False Then MsgBox("PreProcess '" + PreProcess + "' did not run.", MsgBoxStyle.Critical, "Preprocess?")
                End Select
            End If

            If Filter <> "" Then
                If Mid(Filter, 1, 1) = "+" Then
                    cr.RecordSelectionFormula = cr.RecordSelectionFormula + Mid(Filter, 2)
                Else
                    cr.RecordSelectionFormula = Filter
                End If
            End If
            If Not Param1 Is Nothing Then cr.SetParameterValue(0, Param1)
            If Not Param2 Is Nothing Then cr.SetParameterValue(1, Param2)

            If Not Params Is Nothing Then
                If Params.Count > 0 Then
                    Dim pr As Param
                    For Each pr In Params
                        cr.SetParameterValue(pr.Name, pr.Value)
                    Next
                End If
            End If
            'If Not StDate Is Nothing Then
            '    cr.ParameterFields.Item("StartDate").DefaultValues = StDate
            '    cr.ParameterFields.Item("EndDate").DefaultValues = EdDate
            'End If


            Dim dsc As CrystalDecisions.Shared.IConnectionInfo
            For Each dsc In cr.DataSourceConnections
                If (cr.FileName.Contains("Leads Chat Log Orders.rpt") Or cr.FileName.Contains("FactoryKitsBudget - 13Apr2017.rpt")) Then
                    dsc.SetConnection("WineCellar", "WineCellar", "sa", "39201")
                Else
                    dsc.SetLogon("sa", "39201")
                End If
            Next

            If Output = "" Then
                If Preview Then
                    Dim fm As fmReport
                    fm = LoadForm("Report")
                    fm.Text = Replace(Report, ".rpt", "")
                    If ShowGroup Then
                        fm.CRV1.ToolPanelView = ToolPanelViewType.GroupTree
                    Else
                        fm.CRV1.ToolPanelView = ToolPanelViewType.None
                    End If

                    If Report.ToLower() = "FactoryKitsBudget - 13Apr2017.rpt".ToLower() Or Report.ToLower() = "FactoryKitsBudget - 13Apr2017".ToLower() Then
                        Dim exportFormatOptions As ExcelFormatOptions
                        exportFormatOptions = ExportOptions.CreateExcelFormatOptions()
                        'exportFormatOptions.ShowGridLines = True
                        exportFormatOptions.ExcelUseConstantColumnWidth = True
                        exportFormatOptions.ExcelConstantColumnWidth = 100
                        cr.ExportOptions.ExportFormatType = ExportFormatType.Excel
                        cr.ExportOptions.ExportFormatOptions = exportFormatOptions
                    End If

                    fm.CRV1.ReportSource = cr
                    fm.CRV1.ShowRefreshButton = False
                    fm.Show()
                    Application.DoEvents()
                    fm.CRV1.Show()
                Else
                    If PrinterName = "" Then
                        Dim pr As New Windows.Forms.PrintDialog
                        Dim pg As New Drawing.Printing.PageSettings
                        Dim ps As New Drawing.Printing.PrinterSettings
                        Dim prName As String

                        pr.PrinterSettings = ps
                        If pr.ShowDialog() = DialogResult.OK Then
                            prName = ps.PrinterName
                            cr.PrintOptions.PrinterName = prName
                            cr.PrintToPrinter(copies, False, 0, 0)
                        End If
                    Else

                        'pd.DocumentName = "SPS - Information Form for " & dr.OffenderName
                        'pd.PrinterSettings.PrinterName = Configuration.ConfigurationSettings.AppSettings.Get("InfoPrinter")
                        ''If Not pd.PrinterSettings.IsValid Then
                        ''    Throw New Exception("Printer '" + pd.PrinterSettings.PrinterName + "' is invalid.")
                        ''End If
                        'strReturn = strReturn & "Printer: " & pd.PrinterSettings.PrinterName.ToString & "<br />"
                        'For Each PSource In pd.PrinterSettings.PaperSources
                        '    If Trim(PSource.SourceName) = Trim(Configuration.ConfigurationSettings.AppSettings.Get("InfoTray")) Then
                        '        pd.DefaultPageSettings.PaperSource = PSource
                        '        pd.PrinterSettings.DefaultPageSettings.PaperSource = PSource
                        '        strReturn = strReturn & "Tray: " & pd.DefaultPageSettings.PaperSource.ToString() & "<br />"
                        '    End If
                        'Next
                        'For Each pkSize In pd.PrinterSettings.PaperSizes
                        '    If Trim(pkSize.PaperName.ToString()) = Trim(Configuration.ConfigurationSettings.AppSettings.Get("InfoPaper")) Then
                        '        pd.DefaultPageSettings.PaperSize = pkSize
                        '        pd.PrinterSettings.DefaultPageSettings.PaperSize = pkSize
                        '        strReturn = strReturn & "Size: " & pd.DefaultPageSettings.PaperSize.ToString() & "<br />"
                        '    End If
                        'Next
                        'cr.PrintOptions.p()
                        'Dim PapSource As System.Drawing.Printing.PaperSource
                        'Dim intx As Integer = 0
                        'With PrintDocument1.PrintOptions.PrinterSettings
                        '    For Each PapSource In .PaperSources
                        '        If PapSource.Kind = PaperSourceKind.Lower Then
                        '            PrintDocument1.DefaultPageSettings.PaperSource = PrintDocument1.PrinterSettings.PaperSources(intx)
                        '            .DefaultPageSettings.PaperSource = PrintDocument1.PrinterSettings.PaperSources(intx)
                        '            Exit For
                        '        End If
                        '        intx += 1
                        '    Next
                        'End With


                        ''Dim crReportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
                        'Dim PrinterSettings As New System.Drawing.Printing.PrinterSettings
                        'Dim RptSource As System.Drawing.Printing.PaperSource

                        ''crReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        'For Each RptSource In PrinterSettings.PaperSources
                        '    If RptSource.SourceName.ToString = "Drawer 3" Then
                        '        cr.PrintOptions.CustomPaperSource = RptSource
                        '        Exit For
                        '    End If
                        'Next


                        If Tray <> "" Then
                            ''cr.PrintOptions.PrinterName = PrinterName

                            'Dim PrinterSettings As New System.Drawing.Printing.PrinterSettings
                            'Dim RptSource As New System.Drawing.Printing.PaperSource
                            ''MsgBox(Tray)

                            'For Each RptSource In PrinterSettings.PaperSources
                            '    'MsgBox(RptSource.SourceName)
                            '    If Trim(RptSource.SourceName) = Tray Or InStr(RptSource.SourceName, Tray) Then
                            '        'MsgBox("Printing to Drawer 3")
                            '        cr.PrintOptions.CustomPaperSource = RptSource
                            '        'MsgBox("go")
                            '        Exit For
                            '    End If
                            '    'MsgBox("No Go")
                            '    'Exit Sub
                            'Next
                            ''If MsgBox("Continue!", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                            ''Select Case Tray
                            ''    Case "Upper"
                            ''        cr.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Upper
                            ''        cr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
                            ''    Case "Middle"
                            ''        cr.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Middle
                            ''        cr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
                            ''    Case "Lower"
                            ''        cr.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Lower
                            ''        cr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
                            ''End Select
                        End If
                        cr.PrintToPrinter(copies, False, 0, 0)
                        cr.Close()
                        cr.Dispose()

                    End If
                End If
            Else
                If OutputType = "PDF" Then
                    If IO.File.Exists(Output) Then
                        If QuietMode Then
                            cr.ExportToDisk(CrystalDecisions.[Shared].ExportFormatType.PortableDocFormat, Output)
                        Else
                            If MsgBox("This PDF already exists.  Do you want to overwrite it?", MsgBoxStyle.YesNo, "Overwrite?") = MsgBoxResult.Yes Then
                                cr.ExportToDisk(CrystalDecisions.[Shared].ExportFormatType.PortableDocFormat, Output)
                                MsgBox("PDF " + Output + " has been created.", MsgBoxStyle.Information, "PDF Created")
                            End If
                        End If
                    Else
                        cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Output)
                        If QuietMode = False Then MsgBox("PDF " + Output + " has been created.", MsgBoxStyle.Information, "PDF Created")
                    End If
                End If
                If OutputType = "XLS" Then
                    cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.ExcelRecord, Output)
                End If
            End If
            cr = Nothing
            'MainForm.Toolbar1.Toolbars("AddEdit").Tools(5).SharedProps.Enabled = True

        Catch
            'MainForm.Toolbar1.Toolbars("AddEdit").Tools(5).SharedProps.Enabled = True
            DoError(Err, MainForm)
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub



    Public Sub LoadCostAnalysis_DKS(ByVal SD As Date, ByVal ED As Date)
        Dim fm As New fmStatusBar
        fm.Label1.Text = "Loading Cost Analysis... Designer Series"
        fm.Show()
        Application.DoEvents()

        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim rw As DataRow
        Dim rw2 As DataRow
        Dim cnt As Long = 0
        Dim avg As Double
        Dim Code As String
        Dim dtWood As New ArrayList
        Dim dtStain As New ArrayList
        Dim onStain As String
        Dim fl As New IO.StreamWriter("\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis DKS " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv", False)
        Dim ln As String
        Dim onStn As String = ""
        Dim onWood As String
        Dim onBase As Double
        Dim RootCodes As New ArrayList
        Dim RootCode As String

        dtWood.Add("DR")
        dtWood.Add("DAB")
        dtWood.Add("DROK")
        dtWood.Add("DSM")
        dtWood.Add("DCW")
        dtWood.Add("DP")

        dtStain.Add("LI")
        dtStain.Add("CM")
        dtStain.Add("DW")
        dtStain.Add("MB")

        cnn.Open()
        cmd.CommandText = "truncate table cost_val"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "truncate table cost_val_stn"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "truncate table cost_itm_code"
        cmd.ExecuteNonQuery()
        fm.Bar1.Value = 10

        'Designer Series Kits
        cmd.CommandTimeout = 300

        cmd.CommandText = "select itm_code from itm_file where itm_series='DESIGNER' and itm_code like '%-un-%' and isnull(inactive,0)=0"
        da.Fill(dt)
        For Each rw In dt.Rows
            If RootCodes.Contains(Mid(Mid(rw("itm_code"), InStr(rw("itm_code"), "-") + 1), InStr(Mid(rw("itm_code"), InStr(rw("itm_code"), "-") + 1), "-") + 1)) = False Then RootCodes.Add(Mid(Mid(rw("itm_code"), InStr(rw("itm_code"), "-") + 1), InStr(Mid(rw("itm_code"), InStr(rw("itm_code"), "-") + 1), "-") + 1))
        Next
        RootCodes.Sort()
        For Each RootCode In RootCodes
            For Each onWood In dtWood
                cmd.CommandText = "insert into cost_itm_code (itm_code) values ('" + onWood + "-UN-" + RootCode + "')"
                cmd.ExecuteNonQuery()
            Next
        Next
        dt = New DataTable

        cmd.CommandText = "select itm_code "
        'cmd.CommandText += ",0 as base,0 as qty, 0 as totalsales"
        cmd.CommandText += ",(select max(itm_price_price) from itm_price where itm_price_itm_code=itm_code and itm_price_start<='" + CStr(ED) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE') as base,"
        cmd.CommandText += "(select sum(ord_itm_qty) from ord_gen,ord_itm,ord_gen_acct_date where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and acct_ord_serial=ord_gen_ord_serial and acct_rev=ord_gen_rev and acct_type=ord_gen_type and acct_date>='" + CStr(SD) + "' and acct_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as qty,"
        cmd.CommandText += "(select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm,ord_gen_acct_date where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and acct_ord_serial=ord_gen_ord_serial and acct_rev=ord_gen_rev and acct_type=ord_gen_type and acct_date>='" + CStr(SD) + "' and acct_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as totalsales"
        cmd.CommandText += " from cost_itm_code" ' where itm_series='DESIGNER' and itm_code like '%-un-%' "
        da.Fill(dt)

        For Each rw In dt.Rows
            'cmd.CommandText = "select max(itm_price_price) from itm_price where itm_price_itm_code='" + rw("itm_code") + "' and itm_price_start<='" + CStr(SD) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE'"
            'rw("base") = nz(cmd.ExecuteScalar, 0)
            'cmd.CommandText = "select sum(ord_itm_qty) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code='" + rw("itm_code") + "'"
            'rw("qty") = nz(cmd.ExecuteScalar, 0)
            'cmd.CommandText = "select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code='" + rw("itm_code") + "'"
            'rw("totalsales") = nz(cmd.ExecuteScalar, 0)
            If nz(rw("qty"), 0) = 0 Then
                avg = 0
            Else
                avg = Math.Round(nz(rw("totalsales"), 0) / rw("qty"), 2)
            End If

            cmd.CommandText = "insert into cost_val (cost_itm_code,cost_itm_code_root,cost_base,cost_current_base,cost_qty_sold,cost_total_sales,cost_avg_sale,cost_wood) values ('" + rw("itm_code") + "','" + Mid(Mid(rw("itm_code"), InStr(rw("itm_code"), "-") + 1), InStr(Mid(rw("itm_code"), InStr(rw("itm_code"), "-") + 1), "-") + 1) + "'," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("qty"), 0)) + "," + CStr(nz(rw("totalsales"), 0)) + "," + CStr(avg) + ",'" + Mid(rw("itm_code"), 1, InStr(rw("itm_code"), "-") - 1) + "')"
            cmd.ExecuteNonQuery()
            If fm.Bar1.Value < 95 Then fm.Bar1.Value += 2
        Next

        For Each onStain In dtStain
            fm.Label1.Text = "Loading Cost Analysis... Designer Series... " + onStain
            If fm.Bar1.Value < 95 Then fm.Bar1.Value += 2
            Application.DoEvents()
            LoadCostAnalysis_Stain(dt, onStain, SD, ED)
        Next

        For Each onWood In dtWood
            fm.Label1.Text = "Loading Cost Analysis... Designer Series... " + onWood
            If fm.Bar1.Value < 95 Then fm.Bar1.Value += 2
            Application.DoEvents()
            ln = onWood + "-UN," + "DR-UN Base,Item Code,Qty,Current Base,Line Total,Average,Added Value at Base,Added Value Sold"
            For Each onStain In dtStain
                ln += ",," + onStain + " itm code," + onStain + " Qty," + onStain + " Current Base," + onStain + "Line Total," + onStain + " Avg," + onStain + " Added Value at Base," + onStain + " Added Value Sold"
            Next
            fl.WriteLine(ln)
            fl.WriteLine()

            dt.Clear()
            cmd.CommandText = "select * from cost_val where cost_wood='" + onWood + "' order by cost_itm_code_root"
            da.Fill(dt)

            For Each rw In dt.Rows
                cmd.CommandText = "select cost_base from cost_val where cost_itm_code='DR-UN-" + rw("cost_itm_code_root") + "'"
                onBase = nz(cmd.ExecuteScalar, 0)
                ln = rw("cost_itm_code_root") + "," + CStr(onBase) + "," + rw("cost_itm_code") + "," + CStr(nz(rw("cost_qty_sold"))) + "," + CStr(nz(rw("cost_current_base"))) + "," + CStr(nz(rw("cost_total_sales"))) + "," + CStr(nz(rw("cost_avg_sale"))) + "," + CStr(nz(rw("cost_current_base"), 0) - onBase) + "," + IIf(nz(rw("cost_qty_sold"), 0) = 0, "0", CStr(nz(rw("cost_avg_sale"), 0) - onBase))
                For Each onStain In dtStain
                    cmd.CommandText = "select * from cost_val_stn where cost_stn_itm_code='" + onWood + "-" + onStain + "-" + rw("cost_itm_code_root") + "'"
                    dt2.Clear()
                    da.Fill(dt2)
                    For Each rw2 In dt2.Rows
                        ln += ",," + CStr(nz(rw2("cost_stn_itm_code"))) + "," + CStr(nz(rw2("cost_stn_qty_sold"))) + "," + CStr(nz(rw2("cost_stn_current_base"))) + "," + CStr(nz(rw2("cost_stn_total_sales"))) + "," + CStr(nz(rw2("cost_stn_avg_sale"))) + "," + CStr(nz(rw2("cost_stn_add_value"))) + "," + IIf(nz(rw2("cost_stn_qty_sold"), 0) = 0, "0", CStr(nz(rw2("cost_stn_add_value_sold"))))
                    Next
                Next

                fl.WriteLine(ln)
            Next
            fl.WriteLine()
            fl.WriteLine()

        Next

        fm.Bar1.Value = 100
        fm.Close()
        fl.Close()
        cnn.Close()

        Try
            Dim ex As New Excel.Application
            Dim wb As Excel.Workbook
            Dim sh As Excel.Worksheet
            Dim rg As Excel.Range

            ex.Visible = True
            wb = ex.Workbooks.Open("\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis DKS " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv")
            sh = wb.ActiveSheet

            rg = sh.Range("A1", "ZZ1")
            rg.EntireColumn.AutoFit()

            'sh.PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait
            'sh.PageSetup.PrintGridlines = True
            'sh.PageSetup.FitToPagesWide = 1
            'sh.PageSetup.FitToPagesTall = 99
            'sh.PageSetup.Zoom = False

            'fl.Save()

            'fl.PrintPreview()

            'Dim myProc As New Process
            'myProc.StartInfo.FileName = "\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis DKS " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv"
            'myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            'myProc.Start()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Private Sub LoadCostAnalysis_Stain(ByRef dt As DataTable, ByVal code As String, ByVal SD As Date, ByVal ED As Date)
        Dim rw As DataRow
        Dim dt2 As New DataTable
        Dim cmd As New SqlCommand("", cnn)
        Dim avg As Double
        Dim da As New SqlDataAdapter(cmd)

        For Each rw In dt.Rows
            If Not rw("itm_code") Is DBNull.Value Then
                cmd.CommandText = "select itm_code, "
                cmd.CommandText += "(select max(itm_price_price) from itm_price where itm_price_itm_code=itm_code and itm_price_start<='" + CStr(ED) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE') as base,"
                cmd.CommandText += "(select sum(ord_itm_qty) from ord_gen,ord_itm,ord_gen_acct_date where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and acct_ord_serial=ord_gen_ord_serial and acct_rev=ord_gen_rev and acct_type=ord_gen_type and acct_date>='" + CStr(SD) + "' and acct_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as qty,"
                cmd.CommandText += "(select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm,ord_gen_acct_date where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and acct_ord_serial=ord_gen_ord_serial and acct_rev=ord_gen_rev and acct_type=ord_gen_type and acct_date>='" + CStr(SD) + "' and acct_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as totalsales"
                cmd.CommandText += " from itm_file where itm_code = '" + Replace(rw("itm_code"), "-UN-", "-" + code + "-") + "'"
                dt2.Clear()
                da.Fill(dt2)

                If dt2.Rows.Count > 0 Then
                    If nz(dt2.Rows(0).Item("qty"), 0) = 0 Then
                        avg = 0
                    Else
                        avg = Math.Round(nz(dt2.Rows(0).Item("totalsales"), 0) / dt2.Rows(0).Item("qty"), 2)
                    End If
                    cmd.CommandText = "insert into cost_val_stn (cost_stn_root_itm_code,cost_stn_itm_code,cost_stn_current_base,cost_stn_qty_sold,cost_stn_total_sales,cost_stn_avg_sale,cost_stn_add_value,cost_stn_add_value_sold,cost_stn_code) values ('" + rw("itm_code") + "','" + dt2.Rows(0).Item("itm_code") + "'," + CStr(nz(dt2.Rows(0).Item("base"), 0)) + "," + CStr(nz(dt2.Rows(0).Item("qty"), 0)) + "," + CStr(nz(dt2.Rows(0).Item("totalsales"), 0)) + "," + CStr(avg) + "," + CStr(nz(dt2.Rows(0).Item("base"), 0) - nz(rw("base"), 0)) + "," + IIf(nz(dt2.Rows(0).Item("qty"), 0) = 0, "0", CStr(avg - nz(rw("base"), 0))) + ",'" + code + "')"
                    cmd.ExecuteNonQuery()
                Else
                    cmd.CommandText = "insert into cost_val_stn (cost_stn_root_itm_code,cost_stn_itm_code,cost_stn_code) values ('" + rw("itm_code") + "','" + Replace(rw("itm_code"), "-UN-", "-" + code + "-") + "','" + code + "')"
                    cmd.ExecuteNonQuery()
                End If
            End If
        Next
    End Sub
    Public Sub LoadCostAnalysis_CDR(ByVal SD As Date, ByVal ED As Date)
        Dim fm As New fmStatusBar
        fm.Label1.Text = "Loading Cost Analysis... CDR"
        fm.Show()
        Application.DoEvents()

        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim rw As DataRow
        Dim rw2 As DataRow
        Dim cnt As Long = 0
        Dim avg As Double
        Dim Code As String
        Dim dtWood As New ArrayList
        Dim dtStain As New ArrayList
        Dim onStain As String
        Dim fl As New IO.StreamWriter("\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis CDR " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv", False)
        Dim ln As String
        Dim onStn As String = ""
        Dim onWood As String
        Dim onBase As Double


        cnn.Open()
        cmd.CommandText = "truncate table cost_val"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "truncate table cost_val_stn"
        cmd.ExecuteNonQuery()
        fm.Bar1.Value = 10

        'CDR
        cmd.CommandTimeout = 500
        cmd.CommandText = "select itm_code "
        'cmd.CommandText += ",0 as base,0 as qty, 0 as totalsales"
        cmd.CommandText += ",(select max(itm_price_price) from itm_price where itm_price_itm_code=itm_code and itm_price_start<='" + CStr(ED) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE') as base,"
        cmd.CommandText += "(select sum(ord_itm_qty) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as qty,"
        cmd.CommandText += "(select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as totalsales"
        cmd.CommandText += " from itm_file where itm_prod_type='FIX' and itm_code like '%-un-%' "
        da.Fill(dt)

        For Each rw In dt.Rows
            'cmd.CommandText = "select max(itm_price_price) from itm_price where itm_price_itm_code='" + rw("itm_code") + "' and itm_price_start<='" + CStr(SD) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE'"
            'rw("base") = nz(cmd.ExecuteScalar, 0)
            'cmd.CommandText = "select sum(ord_itm_qty) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code='" + rw("itm_code") + "'"
            'rw("qty") = nz(cmd.ExecuteScalar, 0)
            'cmd.CommandText = "select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code='" + rw("itm_code") + "'"
            'rw("totalsales") = nz(cmd.ExecuteScalar, 0)
            If nz(rw("qty"), 0) = 0 Then
                avg = 0
            Else
                avg = Math.Round(nz(rw("totalsales"), 0) / rw("qty"), 2)
            End If

            cmd.CommandText = "insert into cost_val (cost_itm_code,cost_itm_code_root,cost_base,cost_current_base,cost_qty_sold,cost_total_sales,cost_avg_sale,cost_wood) values ('" + rw("itm_code") + "','" + Mid(Mid(rw("itm_code"), InStr(rw("itm_code"), "-") + 1), InStr(Mid(rw("itm_code"), InStr(rw("itm_code"), "-") + 1), "-") + 1) + "'," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("qty"), 0)) + "," + CStr(nz(rw("totalsales"), 0)) + "," + CStr(avg) + ",'" + Mid(rw("itm_code"), 1, InStr(rw("itm_code"), "-") - 1) + "')"
            cmd.ExecuteNonQuery()
        Next
        fm.Bar1.Value = 25

        dtWood.Add("FPR")
        dtWood.Add("FAB")
        dtWood.Add("FAH")
        dtWood.Add("FCW")
        dtWood.Add("FPI")
        dtWood.Add("FPP")
        dtWood.Add("FROK")
        dtWood.Add("FSM")

        dtStain.Add("LI")
        dtStain.Add("CM")
        dtStain.Add("DW")
        dtStain.Add("MB")

        For Each onStain In dtStain
            fm.Label1.Text = "Loading Cost Analysis... CDR... " + onStain
            If fm.Bar1.Value < 95 Then fm.Bar1.Value += 2
            Application.DoEvents()
            LoadCostAnalysis_Stain(dt, onStain, SD, ED)
        Next

        For Each onWood In dtWood
            fm.Label1.Text = "Loading Cost Analysis... CDR... " + onWood
            If fm.Bar1.Value < 95 Then fm.Bar1.Value += 2
            Application.DoEvents()
            ln = onWood + "-UN," + "FPR-UN Base,Item Code,Qty,Current Base,Line Total,Average,Added Value at Base,Added Value Sold"
            For Each onStain In dtStain
                ln += ",," + onStain + " itm code," + onStain + " Qty," + onStain + " Current Base," + onStain + "Line Total," + onStain + " Avg," + onStain + " Added Value at Base," + onStain + " Added Value Sold"
            Next
            fl.WriteLine(ln)

            dt.Clear()
            cmd.CommandText = "select * from cost_val where cost_wood='" + onWood + "' order by cost_itm_code_root"
            da.Fill(dt)

            For Each rw In dt.Rows
                cmd.CommandText = "select cost_base from cost_val where cost_itm_code='FPR-UN-" + rw("cost_itm_code_root") + "'"
                onBase = nz(cmd.ExecuteScalar, 0)
                ln = rw("cost_itm_code_root") + "," + CStr(onBase) + "," + rw("cost_itm_code") + "," + CStr(nz(rw("cost_qty_sold"))) + "," + CStr(nz(rw("cost_current_base"))) + "," + CStr(nz(rw("cost_total_sales"))) + "," + CStr(nz(rw("cost_avg_sale"))) + "," + CStr(nz(rw("cost_current_base"), 0) - onBase) + "," + IIf(nz(rw("cost_qty_sold"), 0) = 0, "0", CStr(nz(rw("cost_avg_sale"), 0) - onBase))
                For Each onStain In dtStain
                    cmd.CommandText = "select * from cost_val_stn where cost_stn_itm_code='" + onWood + "-" + onStain + "-" + rw("cost_itm_code_root") + "'"
                    dt2.Clear()
                    da.Fill(dt2)
                    For Each rw2 In dt2.Rows
                        ln += ",," + CStr(nz(rw2("cost_stn_itm_code"))) + "," + CStr(nz(rw2("cost_stn_qty_sold"))) + "," + CStr(nz(rw2("cost_stn_current_base"))) + "," + CStr(nz(rw2("cost_stn_total_sales"))) + "," + CStr(nz(rw2("cost_stn_avg_sale"))) + "," + CStr(nz(rw2("cost_stn_add_value"))) + "," + IIf(nz(rw2("cost_stn_qty_sold"), 0) = 0, "0", CStr(nz(rw2("cost_stn_add_value_sold"))))
                    Next
                Next

                fl.WriteLine(ln)
            Next
            fl.WriteLine()
            fl.WriteLine()

        Next

        fm.Bar1.Value = 100
        fm.Close()
        fl.Close()
        cnn.Close()

        Try
            Dim myProc As New Process
            myProc.StartInfo.FileName = "\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis CDR " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv"
            myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProc.Start()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Sub LoadCostAnalysis_VIN3(ByVal SD As Date, ByVal ED As Date)
        Dim fm As New fmStatusBar
        fm.Label1.Text = "Loading Cost Analysis... VIN3"
        fm.Show()
        Application.DoEvents()

        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim rw As DataRow
        Dim rw2 As DataRow
        Dim cnt As Long = 0
        Dim avg As Double
        Dim Code As String
        Dim dtWood As New ArrayList
        Dim dtStain As New ArrayList
        Dim onStain As String
        Dim fl As New IO.StreamWriter("\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis VIN3 " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv", False)
        Dim ln As String
        Dim onStn As String = ""
        Dim onWood As String
        Dim onBase As Double


        cnn.Open()
        cmd.CommandText = "truncate table cost_val"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "truncate table cost_val_stn"
        cmd.ExecuteNonQuery()
        fm.Bar1.Value = 10

        'CDR
        cmd.CommandTimeout = 500
        cmd.CommandText = "select itm_code "
        'cmd.CommandText += ",0 as base,0 as qty, 0 as totalsales"
        cmd.CommandText += ",(select max(itm_price_price) from itm_price where itm_price_itm_code=itm_code and itm_price_start<='" + CStr(ED) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE') as base,"
        cmd.CommandText += "(select sum(ord_itm_qty) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as qty,"
        cmd.CommandText += "(select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as totalsales"
        cmd.CommandText += " from itm_file where itm_prod_type='KIT' and itm_code like 'vin3-%' and itm_code like '%-un-%'"
        da.Fill(dt)

        For Each rw In dt.Rows
            'cmd.CommandText = "select max(itm_price_price) from itm_price where itm_price_itm_code='" + rw("itm_code") + "' and itm_price_start<='" + CStr(SD) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE'"
            'rw("base") = nz(cmd.ExecuteScalar, 0)
            'cmd.CommandText = "select sum(ord_itm_qty) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code='" + rw("itm_code") + "'"
            'rw("qty") = nz(cmd.ExecuteScalar, 0)
            'cmd.CommandText = "select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code='" + rw("itm_code") + "'"
            'rw("totalsales") = nz(cmd.ExecuteScalar, 0)
            If nz(rw("qty"), 0) = 0 Then
                avg = 0
            Else
                avg = Math.Round(nz(rw("totalsales"), 0) / rw("qty"), 2)
            End If

            cmd.CommandText = "insert into cost_val (cost_itm_code,cost_itm_code_root,cost_base,cost_current_base,cost_qty_sold,cost_total_sales,cost_avg_sale,cost_wood) values ('" + rw("itm_code") + "','" + Mid(rw("itm_code"), Len(Split(rw("itm_code"), "-")(0) + "-" + Split(rw("itm_code"), "-")(1) + "-" + Split(rw("itm_code"), "-")(2) + "-") + 1) + "'," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("qty"), 0)) + "," + CStr(nz(rw("totalsales"), 0)) + "," + CStr(avg) + ",'" + Split(rw("itm_code"), "-")(0) + "-" + Split(rw("itm_code"), "-")(1) + "')"
            cmd.ExecuteNonQuery()
        Next
        fm.Bar1.Value = 25

        dtWood.Add("VIN3-PR")
        dtWood.Add("VIN3-AB")
        dtWood.Add("VIN3-CW")
        dtWood.Add("VIN3-SM")

        dtStain.Add("LI")
        dtStain.Add("CM")
        dtStain.Add("DW")
        dtStain.Add("MB")

        For Each onStain In dtStain
            fm.Label1.Text = "Loading Cost Analysis... VIN3... " + onStain
            If fm.Bar1.Value < 95 Then fm.Bar1.Value += 2
            Application.DoEvents()
            LoadCostAnalysis_Stain(dt, onStain, SD, ED)
        Next

        For Each onWood In dtWood
            fm.Label1.Text = "Loading Cost Analysis... VIN3... " + onWood
            If fm.Bar1.Value < 95 Then fm.Bar1.Value += 2
            Application.DoEvents()
            ln = onWood + "-UN," + "VIN3-PR-UN Base,Item Code,Qty,Current Base,Line Total,Average,Added Value at Base,Added Value Sold"
            For Each onStain In dtStain
                ln += ",," + onStain + " itm code," + onStain + " Qty," + onStain + " Current Base," + onStain + "Line Total," + onStain + " Avg," + onStain + " Added Value at Base," + onStain + " Added Value Sold"
            Next
            fl.WriteLine(ln)

            dt.Clear()
            cmd.CommandText = "select * from cost_val where cost_wood='" + onWood + "' order by cost_itm_code_root"
            da.Fill(dt)

            For Each rw In dt.Rows
                cmd.CommandText = "select cost_base from cost_val where cost_itm_code='VIN3-PR-UN-" + rw("cost_itm_code_root") + "'"
                onBase = nz(cmd.ExecuteScalar, 0)
                ln = rw("cost_itm_code_root") + "," + CStr(onBase) + "," + rw("cost_itm_code") + "," + CStr(nz(rw("cost_qty_sold"))) + "," + CStr(nz(rw("cost_current_base"))) + "," + CStr(nz(rw("cost_total_sales"))) + "," + CStr(nz(rw("cost_avg_sale"))) + "," + CStr(nz(rw("cost_current_base"), 0) - onBase) + "," + IIf(nz(rw("cost_qty_sold"), 0) = 0, "0", CStr(nz(rw("cost_avg_sale"), 0) - onBase))
                For Each onStain In dtStain
                    cmd.CommandText = "select * from cost_val_stn where cost_stn_itm_code='" + onWood + "-" + onStain + "-" + rw("cost_itm_code_root") + "'"
                    dt2.Clear()
                    da.Fill(dt2)
                    For Each rw2 In dt2.Rows
                        ln += ",," + CStr(nz(rw2("cost_stn_itm_code"))) + "," + CStr(nz(rw2("cost_stn_qty_sold"))) + "," + CStr(nz(rw2("cost_stn_current_base"))) + "," + CStr(nz(rw2("cost_stn_total_sales"))) + "," + CStr(nz(rw2("cost_stn_avg_sale"))) + "," + CStr(nz(rw2("cost_stn_add_value"))) + "," + IIf(nz(rw2("cost_stn_qty_sold"), 0) = 0, "0", CStr(nz(rw2("cost_stn_add_value_sold"))))
                    Next
                Next

                fl.WriteLine(ln)
            Next
            fl.WriteLine()
            fl.WriteLine()

        Next

        fm.Bar1.Value = 100
        fm.Close()
        fl.Close()
        cnn.Close()

        Try
            Dim myProc As New Process
            myProc.StartInfo.FileName = "\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis VIN3 " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv"
            myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProc.Start()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Sub LoadCostAnalysis_VIN4(ByVal SD As Date, ByVal ED As Date)
        Dim fm As New fmStatusBar
        fm.Label1.Text = "Loading Cost Analysis... VIN4"
        fm.Show()
        Application.DoEvents()

        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim rw As DataRow
        Dim rw2 As DataRow
        Dim cnt As Long = 0
        Dim avg As Double
        Dim Code As String
        Dim dtWood As New ArrayList
        Dim dtStain As New ArrayList
        Dim onStain As String
        Dim fl As New IO.StreamWriter("\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis VIN4 " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv", False)
        Dim ln As String
        Dim onStn As String = ""
        Dim onWood As String
        Dim onBase As Double


        cnn.Open()
        cmd.CommandText = "truncate table cost_val"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "truncate table cost_val_stn"
        cmd.ExecuteNonQuery()
        fm.Bar1.Value = 10

        'CDR
        cmd.CommandTimeout = 500
        cmd.CommandText = "select itm_code "
        'cmd.CommandText += ",0 as base,0 as qty, 0 as totalsales"
        cmd.CommandText += ",(select max(itm_price_price) from itm_price where itm_price_itm_code=itm_code and itm_price_start<='" + CStr(ED) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE') as base,"
        cmd.CommandText += "(select sum(ord_itm_qty) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as qty,"
        cmd.CommandText += "(select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as totalsales"
        cmd.CommandText += " from itm_file where itm_prod_type='KIT' and itm_code like 'vin-%' and itm_code like '%-un-%'"
        da.Fill(dt)

        For Each rw In dt.Rows
            'cmd.CommandText = "select max(itm_price_price) from itm_price where itm_price_itm_code='" + rw("itm_code") + "' and itm_price_start<='" + CStr(SD) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE'"
            'rw("base") = nz(cmd.ExecuteScalar, 0)
            'cmd.CommandText = "select sum(ord_itm_qty) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code='" + rw("itm_code") + "'"
            'rw("qty") = nz(cmd.ExecuteScalar, 0)
            'cmd.CommandText = "select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code='" + rw("itm_code") + "'"
            'rw("totalsales") = nz(cmd.ExecuteScalar, 0)
            If nz(rw("qty"), 0) = 0 Then
                avg = 0
            Else
                avg = Math.Round(nz(rw("totalsales"), 0) / rw("qty"), 2)
            End If

            cmd.CommandText = "insert into cost_val (cost_itm_code,cost_itm_code_root,cost_base,cost_current_base,cost_qty_sold,cost_total_sales,cost_avg_sale,cost_wood) values ('" + rw("itm_code") + "','" + Mid(rw("itm_code"), Len(Split(rw("itm_code"), "-")(0) + "-" + Split(rw("itm_code"), "-")(1) + "-" + Split(rw("itm_code"), "-")(2) + "-") + 1) + "'," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("qty"), 0)) + "," + CStr(nz(rw("totalsales"), 0)) + "," + CStr(avg) + ",'" + Split(rw("itm_code"), "-")(0) + "-" + Split(rw("itm_code"), "-")(1) + "')"
            cmd.ExecuteNonQuery()
        Next
        fm.Bar1.Value = 25

        dtWood.Add("VIN-PR")
        dtWood.Add("VIN-AB")
        dtWood.Add("VIN-CW")
        dtWood.Add("VIN-SM")

        dtStain.Add("LI")
        dtStain.Add("CM")
        dtStain.Add("DW")
        dtStain.Add("MB")

        For Each onStain In dtStain
            fm.Label1.Text = "Loading Cost Analysis... VIN4... " + onStain
            If fm.Bar1.Value < 95 Then fm.Bar1.Value += 2
            Application.DoEvents()
            LoadCostAnalysis_Stain(dt, onStain, SD, ED)
        Next

        For Each onWood In dtWood
            fm.Label1.Text = "Loading Cost Analysis... VIN4... " + onWood
            If fm.Bar1.Value < 95 Then fm.Bar1.Value += 2
            Application.DoEvents()
            ln = onWood + "-UN," + "VIN-PR-UN Base,Item Code,Qty,Current Base,Line Total,Average,Added Value at Base,Added Value Sold"
            For Each onStain In dtStain
                ln += ",," + onStain + " itm code," + onStain + " Qty," + onStain + " Current Base," + onStain + "Line Total," + onStain + " Avg," + onStain + " Added Value at Base," + onStain + " Added Value Sold"
            Next
            fl.WriteLine(ln)

            dt.Clear()
            cmd.CommandText = "select * from cost_val where cost_wood='" + onWood + "' order by cost_itm_code_root"
            da.Fill(dt)

            For Each rw In dt.Rows
                cmd.CommandText = "select cost_base from cost_val where cost_itm_code='VIN-PR-UN-" + rw("cost_itm_code_root") + "'"
                onBase = nz(cmd.ExecuteScalar, 0)
                ln = rw("cost_itm_code_root") + "," + CStr(onBase) + "," + rw("cost_itm_code") + "," + CStr(nz(rw("cost_qty_sold"))) + "," + CStr(nz(rw("cost_current_base"))) + "," + CStr(nz(rw("cost_total_sales"))) + "," + CStr(nz(rw("cost_avg_sale"))) + "," + CStr(nz(rw("cost_current_base"), 0) - onBase) + "," + IIf(nz(rw("cost_qty_sold"), 0) = 0, "0", CStr(nz(rw("cost_avg_sale"), 0) - onBase))
                For Each onStain In dtStain
                    cmd.CommandText = "select * from cost_val_stn where cost_stn_itm_code='" + onWood + "-" + onStain + "-" + rw("cost_itm_code_root") + "'"
                    dt2.Clear()
                    da.Fill(dt2)
                    For Each rw2 In dt2.Rows
                        ln += ",," + CStr(nz(rw2("cost_stn_itm_code"))) + "," + CStr(nz(rw2("cost_stn_qty_sold"))) + "," + CStr(nz(rw2("cost_stn_current_base"))) + "," + CStr(nz(rw2("cost_stn_total_sales"))) + "," + CStr(nz(rw2("cost_stn_avg_sale"))) + "," + CStr(nz(rw2("cost_stn_add_value"))) + "," + IIf(nz(rw2("cost_stn_qty_sold"), 0) = 0, "0", CStr(nz(rw2("cost_stn_add_value_sold"))))
                    Next
                Next

                fl.WriteLine(ln)
            Next
            fl.WriteLine()
            fl.WriteLine()

        Next

        fm.Bar1.Value = 100
        fm.Close()
        fl.Close()
        cnn.Close()

        Try
            Dim myProc As New Process
            myProc.StartInfo.FileName = "\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis VIN4 " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv"
            myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProc.Start()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Public Sub LoadCostAnalysis_SRS(ByVal SD As Date, ByVal ED As Date)
        Dim fm As New fmStatusBar
        fm.Label1.Text = "Loading Cost Analysis... SRS"
        fm.Show()
        Application.DoEvents()

        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim rw As DataRow
        Dim rw2 As DataRow
        Dim cnt As Long = 0
        Dim avg As Double
        Dim Code As String
        Dim dtWood As New ArrayList
        Dim dtStain As New ArrayList
        Dim onStain As String
        Dim fl As New IO.StreamWriter("\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis SRS " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv", False)
        Dim ln As String
        Dim onStn As String = ""
        Dim onWood As String
        Dim onBase As Double


        cnn.Open()
        cmd.CommandText = "truncate table cost_val"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "truncate table cost_val_stn"
        cmd.ExecuteNonQuery()
        fm.Bar1.Value = 10

        'CDR
        cmd.CommandTimeout = 500
        cmd.CommandText = "select itm_code "
        'cmd.CommandText += ",0 as base,0 as qty, 0 as totalsales"
        cmd.CommandText += ",(select max(itm_price_price) from itm_price where itm_price_itm_code=itm_code and itm_price_start<='" + CStr(ED) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE') as base,"
        cmd.CommandText += "(select sum(ord_itm_qty) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as qty,"
        cmd.CommandText += "(select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as totalsales"
        cmd.CommandText += " from itm_file where itm_prod_type='KIT' and itm_code like 'srs-%'"
        da.Fill(dt)

        For Each rw In dt.Rows
            'cmd.CommandText = "select max(itm_price_price) from itm_price where itm_price_itm_code='" + rw("itm_code") + "' and itm_price_start<='" + CStr(SD) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE'"
            'rw("base") = nz(cmd.ExecuteScalar, 0)
            'cmd.CommandText = "select sum(ord_itm_qty) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code='" + rw("itm_code") + "'"
            'rw("qty") = nz(cmd.ExecuteScalar, 0)
            'cmd.CommandText = "select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code='" + rw("itm_code") + "'"
            'rw("totalsales") = nz(cmd.ExecuteScalar, 0)
            If nz(rw("qty"), 0) = 0 Then
                avg = 0
            Else
                avg = Math.Round(nz(rw("totalsales"), 0) / rw("qty"), 2)
            End If

            cmd.CommandText = "insert into cost_val (cost_itm_code,cost_itm_code_root,cost_base,cost_current_base,cost_qty_sold,cost_total_sales,cost_avg_sale,cost_wood) values ('" + rw("itm_code") + "','" + Mid(rw("itm_code"), Len(Split(rw("itm_code"), "-")(0) + "-") + 1) + "'," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("qty"), 0)) + "," + CStr(nz(rw("totalsales"), 0)) + "," + CStr(avg) + ",'')"
            cmd.ExecuteNonQuery()
        Next
        fm.Bar1.Value = 25

        ln = "SRS," + "SRS Base,Item Code,Qty,Current Base,Line Total,Average,Added Value at Base,Added Value Sold"
        fl.WriteLine(ln)

        dt.Clear()
        cmd.CommandText = "select * from cost_val order by cost_itm_code_root"
        da.Fill(dt)

        For Each rw In dt.Rows
            cmd.CommandText = "select cost_base from cost_val where cost_itm_code='SRS-" + rw("cost_itm_code_root") + "'"
            onBase = nz(cmd.ExecuteScalar, 0)
            ln = rw("cost_itm_code_root") + "," + CStr(onBase) + "," + rw("cost_itm_code") + "," + CStr(nz(rw("cost_qty_sold"))) + "," + CStr(nz(rw("cost_current_base"))) + "," + CStr(nz(rw("cost_total_sales"))) + "," + CStr(nz(rw("cost_avg_sale"))) + "," + CStr(nz(rw("cost_current_base"), 0) - onBase) + "," + IIf(nz(rw("cost_qty_sold"), 0) = 0, "0", CStr(nz(rw("cost_avg_sale"), 0) - onBase))

            fl.WriteLine(ln)
        Next
        fl.WriteLine()
        fl.WriteLine()


        fm.Bar1.Value = 100
        fm.Close()
        fl.Close()
        cnn.Close()

        Try
            Dim myProc As New Process
            myProc.StartInfo.FileName = "\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis SRS " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv"
            myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProc.Start()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Public Sub LoadCostAnalysis_RSeries(ByVal SD As Date, ByVal ED As Date)
        Dim fm As New fmStatusBar
        fm.Label1.Text = "Loading Cost Analysis... R Series"
        fm.Show()
        Application.DoEvents()

        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim rw As DataRow
        Dim rw2 As DataRow
        Dim cnt As Long = 0
        Dim avg As Double
        Dim Code As String
        Dim dtWood As New ArrayList
        Dim dtStain As New ArrayList
        Dim onStain As String
        Dim fl As New IO.StreamWriter("\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis R Series " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv", False)
        Dim ln As String
        Dim onStn As String = ""
        Dim onWood As String
        Dim onBase As Double


        cnn.Open()
        cmd.CommandText = "truncate table cost_val"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "truncate table cost_val_stn"
        cmd.ExecuteNonQuery()
        fm.Bar1.Value = 10

        cmd.CommandTimeout = 500
        cmd.CommandText = "select itm_code "
        cmd.CommandText += ",(select max(itm_price_price) from itm_price where itm_price_itm_code=itm_code and itm_price_start<='" + CStr(ED) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE') as base,"
        cmd.CommandText += "(select sum(ord_itm_qty) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as qty,"
        cmd.CommandText += "(select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as totalsales"
        cmd.CommandText += " from itm_file where itm_prod_type='KIT' and itm_code like 'r%' and itm_code not like 'return%' and itm_code not like 'replace%'"
        da.Fill(dt)

        For Each rw In dt.Rows
            If nz(rw("qty"), 0) = 0 Then
                avg = 0
            Else
                avg = Math.Round(nz(rw("totalsales"), 0) / rw("qty"), 2)
            End If

            cmd.CommandText = "insert into cost_val (cost_itm_code,cost_itm_code_root,cost_base,cost_current_base,cost_qty_sold,cost_total_sales,cost_avg_sale,cost_wood) values ('" + rw("itm_code") + "','" + Mid(rw("itm_code"), 2) + "'," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("qty"), 0)) + "," + CStr(nz(rw("totalsales"), 0)) + "," + CStr(avg) + ",'')"
            cmd.ExecuteNonQuery()
        Next
        fm.Bar1.Value = 25

        ln = "R Series," + "R Series Base,Item Code,Qty,Current Base,Line Total,Average,Added Value at Base,Added Value Sold"
        fl.WriteLine(ln)

        dt.Clear()
        cmd.CommandText = "select * from cost_val order by cost_itm_code_root"
        da.Fill(dt)

        For Each rw In dt.Rows
            cmd.CommandText = "select cost_base from cost_val where cost_itm_code='" + rw("cost_itm_code") + "'"
            onBase = nz(cmd.ExecuteScalar, 0)
            ln = rw("cost_itm_code_root") + "," + CStr(onBase) + "," + rw("cost_itm_code") + "," + CStr(nz(rw("cost_qty_sold"))) + "," + CStr(nz(rw("cost_current_base"))) + "," + CStr(nz(rw("cost_total_sales"))) + "," + CStr(nz(rw("cost_avg_sale"))) + "," + CStr(nz(rw("cost_current_base"), 0) - onBase) + "," + IIf(nz(rw("cost_qty_sold"), 0) = 0, "0", CStr(nz(rw("cost_avg_sale"), 0) - onBase))

            fl.WriteLine(ln)
        Next
        fl.WriteLine()
        fl.WriteLine()


        fm.Bar1.Value = 100
        fm.Close()
        fl.Close()
        cnn.Close()

        Try
            Dim myProc As New Process
            myProc.StartInfo.FileName = "\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis R Series " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv"
            myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProc.Start()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Public Sub LoadCostAnalysis_CPSeries(ByVal SD As Date, ByVal ED As Date)
        Dim fm As New fmStatusBar
        fm.Label1.Text = "Loading Cost Analysis... CP Series"
        fm.Show()
        Application.DoEvents()

        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim rw As DataRow
        Dim rw2 As DataRow
        Dim cnt As Long = 0
        Dim avg As Double
        Dim Code As String
        Dim dtWood As New ArrayList
        Dim dtStain As New ArrayList
        Dim onStain As String
        Dim fl As New IO.StreamWriter("\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis CP Series " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv", False)
        Dim ln As String
        Dim onStn As String = ""
        Dim onWood As String
        Dim onBase As Double


        cnn.Open()
        cmd.CommandText = "truncate table cost_val"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "truncate table cost_val_stn"
        cmd.ExecuteNonQuery()
        fm.Bar1.Value = 10

        cmd.CommandTimeout = 500
        cmd.CommandText = "select itm_code "
        cmd.CommandText += ",(select max(itm_price_price) from itm_price where itm_price_itm_code=itm_code and itm_price_start<='" + CStr(ED) + "' and itm_price_end>='" + CStr(ED) + "' and itm_price_type='BASE') as base,"
        cmd.CommandText += "(select sum(ord_itm_qty) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as qty,"
        cmd.CommandText += "(select sum((ord_itm_qty * ord_itm_unt_sell) + ord_itm_disc + ord_itm_margin_factor) from ord_gen,ord_itm where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_create_date>='" + CStr(SD) + "' and ord_gen_create_date<='" + CStr(ED) + "' and ord_itm_item_code=itm_code) as totalsales"
        cmd.CommandText += " from itm_file where itm_prod_type='KIT' and (itm_code like 'cp%' or itm_code = 'cube' or itm_code = 'woodcase')"
        da.Fill(dt)

        For Each rw In dt.Rows
            If nz(rw("qty"), 0) = 0 Then
                avg = 0
            Else
                avg = Math.Round(nz(rw("totalsales"), 0) / rw("qty"), 2)
            End If

            cmd.CommandText = "insert into cost_val (cost_itm_code,cost_itm_code_root,cost_base,cost_current_base,cost_qty_sold,cost_total_sales,cost_avg_sale,cost_wood) values ('" + rw("itm_code") + "','" + IIf(Mid(rw("itm_code"), 1, 2) = "CP", Mid(rw("itm_code"), 3), rw("itm_code")) + "'," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("base"), 0)) + "," + CStr(nz(rw("qty"), 0)) + "," + CStr(nz(rw("totalsales"), 0)) + "," + CStr(avg) + ",'')"
            cmd.ExecuteNonQuery()
        Next
        fm.Bar1.Value = 25

        ln = "CP Series," + "CP Series Base,Item Code,Qty,Current Base,Line Total,Average,Added Value at Base,Added Value Sold"
        fl.WriteLine(ln)

        dt.Clear()
        cmd.CommandText = "select * from cost_val order by cost_itm_code_root"
        da.Fill(dt)

        For Each rw In dt.Rows
            cmd.CommandText = "select cost_base from cost_val where cost_itm_code='" + rw("cost_itm_code") + "'"
            onBase = nz(cmd.ExecuteScalar, 0)
            ln = rw("cost_itm_code_root") + "," + CStr(onBase) + "," + rw("cost_itm_code") + "," + CStr(nz(rw("cost_qty_sold"))) + "," + CStr(nz(rw("cost_current_base"))) + "," + CStr(nz(rw("cost_total_sales"))) + "," + CStr(nz(rw("cost_avg_sale"))) + "," + CStr(nz(rw("cost_current_base"), 0) - onBase) + "," + IIf(nz(rw("cost_qty_sold"), 0) = 0, "0", CStr(nz(rw("cost_avg_sale"), 0) - onBase))

            fl.WriteLine(ln)
        Next
        fl.WriteLine()
        fl.WriteLine()


        fm.Bar1.Value = 100
        fm.Close()
        fl.Close()
        cnn.Close()

        Try
            Dim myProc As New Process
            myProc.StartInfo.FileName = "\\10.0.0.245\jcom$\Cost Analysis\Cost Analysis CP Series " + Format(SD, "yyyy-MM-dd") + " to " + Format(ED, "yyyy-MM-dd") + ".csv"
            myProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProc.Start()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Private Sub LoadItemsShippedAllParts(ByVal SD As Date, ByVal ED As Date)
        Dim fm As New fmStatusBar
        fm.Label1.Text = "Loading quantities shipped."
        fm.Show()
        Application.DoEvents()

        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim rw As DataRow
        Dim cnt As Long = 0

        cnn.Open()
        cmd.CommandText = "truncate table tmp_items_shipped_all_parts"
        cmd.ExecuteNonQuery()
        fm.Bar1.Value = 25
        cmd.CommandText = "insert into tmp_items_shipped_all_parts (tmp_itm_code,tmp_prod_type) select itm_code,itm_prod_type from itm_file"
        cmd.ExecuteNonQuery()
        fm.Bar1.Value = 50
        cmd.CommandText = "delete from tmp_items_shipped_all_parts where tmp_itm_code in (SELECT distinct ord_itm_item_code from ord_gen,ord_itm WHERE ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev = ord_itm_rev and ord_gen_type=ord_itm_type and (ord_gen_type = 'O') and ord_gen_status='SHIPPED' and ord_gen_ship_date>='" + CStr(SD) + "' and ord_gen_ship_date<='" + CStr(ED) + "')"
        cmd.ExecuteNonQuery()
        fm.Bar1.Value = 75
        cmd.CommandText = "insert into tmp_items_shipped_all_parts (tmp_itm_code,tmp_prod_type,tmp_material,tmp_qty) SELECT ord_itm_item_code,itm_prod_type,ord_itm_mat_code,sum(ord_itm_qty) as qty from ord_gen,ord_itm left outer join itm_file on ord_itm_item_code=itm_code WHERE ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev = ord_itm_rev and ord_gen_type=ord_itm_type and (ord_gen_type = 'O') and ord_gen_status='SHIPPED' and ord_gen_ship_date>='" + CStr(SD) + "' and ord_gen_ship_date<='" + CStr(ED) + "' AND (ord_itm.ord_itm_item_code <> '') GROUP BY ord_itm_item_code,itm_prod_type,ord_itm_mat_code"
        cmd.ExecuteNonQuery()
        fm.Bar1.Value = 100
        'da.Fill(ds)
        'For Each rw In ds.Tables(0).Rows
        'cmd.CommandText = "update ord_gen set ord_gen_latest_rev=1 where ord_gen_ord_serial=" + CStr(rw("ord_gen_ord_serial")) + " and ord_gen_rev=" + CStr(rw("rev")) + " and ord_gen_type='Q'"
        'cmd.ExecuteNonQuery()
        'fm.Bar1.Value = cnt / ds.Tables(0).Rows.Count * 100
        'cnt += 1
        'Next
        cnn.Close()
        fm.Close()
    End Sub
    Private Sub LoadLatestRev(ByVal SD As Date, ByVal ED As Date)
        Dim fm As New fmStatusBar
        fm.Label1.Text = "Loading most recent quote revisions."
        fm.Show()
        Application.DoEvents()

        Dim cmd As New SqlClient.SqlCommand("update ord_gen set ord_gen_latest_rev=0", cnn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim rw As DataRow
        Dim cnt As Long = 0

        cnn.Open()
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SELECT ord_gen_ord_serial, MAX(ord_gen_rev) AS Rev FROM ord_gen WHERE (ord_gen_type = 'Q') and ord_gen_create_date>='" + CStr(SD) + "' GROUP BY ord_gen_ord_serial"
        da.Fill(ds)
        For Each rw In ds.Tables(0).Rows
            cmd.CommandText = "update ord_gen set ord_gen_latest_rev=1 where ord_gen_ord_serial=" + CStr(rw("ord_gen_ord_serial")) + " and ord_gen_rev=" + CStr(rw("rev")) + " and ord_gen_type='Q'"
            cmd.ExecuteNonQuery()
            fm.Bar1.Value = cnt / ds.Tables(0).Rows.Count * 100
            cnt += 1
        Next
        cnn.Close()
        fm.Close()

    End Sub

    Private Sub LoadCurrentBase()
        Dim cmd As New SqlCommand("select * from itm_file", cnn)
        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dr As DataRow
        Dim onBase As Double
        Dim cnt As Long = 0
        Dim fm As New fmStatusBar

        fm.Label1.Text = "Loading Base Prices.  Please Wait..."
        fm.Show()
        Application.DoEvents()

        cnn.Open()
        da.Fill(ds)

        For Each dr In ds.Tables(0).Rows
            cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + dr("itm_code") + "' and itm_price_type='BASE' and itm_price_qty_from<=1 and itm_price_qty_to>=1 and itm_price_start<='" + CStr(Today) + "' and itm_price_end>='" + CStr(Today) + "'"
            onBase = cmd.ExecuteScalar
            cmd.CommandText = "update itm_file set itm_cur_base=" + CStr(onBase) + " where itm_code='" + dr("itm_code") + "'"
            cmd.ExecuteNonQuery()
            fm.Bar1.Value = cnt / ds.Tables(0).Rows.Count * 100
            cnt += 1
        Next
        cnn.Close()
        cnn2.Close()
        fm.Close()
    End Sub
    'Private Sub LoadCurrentSalesCat(ByVal SD As Date, ByVal ED As Date)
    '    Dim cmd As New SqlClient.SqlCommand("select ord_gen_serial,ord_gen_sales_cat,cust_sales_cat,cust_terr from ord_gen,ord_file left outer join cust_file on ord_sold_cust_id=cust_id where ord_gen_ord_serial=ord_serial and ((ord_gen_ship_date>='" + CStr(SD) + "' and ord_gen_ship_date<='" + CStr(ED) + "') or (ord_gen_staged_date>='" + CStr(SD) + "' and ord_gen_staged_date<='" + CStr(ED) + "'))", cnn)
    '    Dim dr As DataRow
    '    Dim da As New SqlClient.SqlDataAdapter(cmd)
    '    Dim ds As New DataSet
    '    Dim fm As New fmStatusBar
    '    Dim cnt As Long = 0

    '    fm.Label1.Text = "Loading Current Sales Categories.  Please Wait..."
    '    fm.Show()
    '    Application.DoEvents()

    '    cnn.Open()
    '    da.Fill(ds)

    '    For Each dr In ds.Tables(0).Rows
    '        If nz(dr("cust_terr")) = "CAT" Then
    '            cmd.CommandText = "update ord_gen set ord_gen_cur_sales_cat='CAT' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
    '        Else
    '            If dr("cust_sales_cat") Is DBNull.Value Then
    '                cmd.CommandText = "update ord_gen set ord_gen_cur_sales_cat='" + dr("ord_gen_sales_cat") + "' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
    '            Else
    '                cmd.CommandText = "update ord_gen set ord_gen_cur_sales_cat='" + dr("cust_sales_cat") + "' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
    '            End If
    '        End If
    '        cmd.ExecuteNonQuery()
    '        fm.Bar1.Value = cnt / ds.Tables(0).Rows.Count * 100
    '        cnt += 1
    '    Next
    '    cnn.Close()
    '    fm.Close()
    'End Sub
    Private Sub LoadCurrentSalesCat(ByVal SD As Date, ByVal ED As Date)
        Dim cmd As New SqlClient.SqlCommand("update  ord_gen set ord_gen_cur_sales_cat=''", cnn)
        cnn.Open()
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update ord_gen set ord_gen_cur_sales_cat='CAT' where ord_gen_ord_serial= (select ord_serial from ord_file where ord_serial=ord_gen_ord_serial and ord_sold_cust_id<>'' and ord_sold_cust_id<>'WRU' and ord_sold_cust_id<>'WRS')"
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub
    'Private Sub LoadCurrentSalesCommission(ByVal SD As Date, ByVal ED As Date)
    '    'Dim cmd As New SqlClient.SqlCommand("select ord_gen_ord_serial,sum(ord_gen_total) as total,sum(ord_gen_line_total) as linetot,sum(ord_itm_disc_amt) as disc_amt from ord_gen,ord_itm,pay_itm,pay_file where ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev=ord_itm_rev and ord_gen_type=ord_itm_type and ord_gen_serial=pay_itm_ord_gen_serial and pay_itm_pay_serial=pay_serial and pay_applied>='" + CStr(SD) + "' and pay_applied<='" + CStr(ED) + "' and ord_gen_type='O' and ord_gen_status<>'CANCELED' and ord_gen_ord_serial=155384 group by ord_gen_ord_serial", cnn)
    '    Dim cmd As New SqlClient.SqlCommand("select distinct ord_gen_ord_serial from ord_gen,pay_itm,pay_file where ord_gen_serial=pay_itm_ord_gen_serial and pay_itm_pay_serial=pay_serial and pay_applied>='" + CStr(SD) + "' and pay_applied<='" + CStr(ED) + "' and ord_gen_type='O' and ord_gen_status<>'CANCELED' and ord_gen_ord_serial=155384 group by ord_gen_ord_serial", cnn)
    '    Dim dr As DataRow
    '    Dim da As New SqlClient.SqlDataAdapter(cmd)
    '    Dim ds As New DataSet
    '    Dim fm As New fmStatusBar
    '    Dim cnt As Long = 0
    '    Dim LineTot, DiscTot As Double

    '    fm.Label1.Text = "Loading Current Sales Commissions.  Please Wait..."
    '    fm.Show()
    '    Application.DoEvents()

    '    cnn.Open()
    '    da.Fill(ds)

    '    For Each dr In ds.Tables(0).Rows
    '        'If dr("cust_sales_cat") Is DBNull.Value Then
    '        '    cmd.CommandText = "update ord_gen set ord_gen_cur_sales_cat='" + dr("ord_gen_sales_cat") + "' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
    '        'Else
    '        '    cmd.CommandText = "update ord_gen set ord_gen_cur_sales_cat='" + dr("cust_sales_cat") + "' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
    '        'End If
    '        'cmd.ExecuteNonQuery()
    '        cmd.CommandText = "select sum(ord_gen_line_total) from ord_gen where ord_gen_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_gen_status<>'CANCELED' and ord_gen_type='O'"
    '        LineTot = cmd.ExecuteScalar
    '        cmd.CommandText = "select sum(ord_itm_disc_amt) from ord_gen,ord_itm where ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_rev=ord_itm_rev and ord_gen_type=ord_itm_type and ord_gen_ord_serial=" + CStr(dr("ord_gen_ord_serial")) + " and ord_gen_status<>'CANCELED' and ord_gen_type='O'"
    '        DiscTot = cmd.ExecuteScalar

    '        If LineTot + DiscTot = 0 Then
    '            cmd.CommandText = "update ord_gen set ord_gen_comm_disc=0 where ord_gen_ord_serial=" + CStr(dr("ord_gen_ord_serial"))
    '        Else
    '            cmd.CommandText = "update ord_gen set ord_gen_comm_disc=" + CStr(Math.Round(DiscTot / (LineTot + DiscTot), 4)) + " where ord_gen_ord_serial=" + CStr(dr("ord_gen_ord_serial"))
    '        End If
    '        cmd.ExecuteNonQuery()
    '        fm.Bar1.Value = cnt / ds.Tables(0).Rows.Count * 100
    '        cnt += 1
    '    Next
    '    cnn.Close()
    '    fm.Close()
    'End Sub
    Private Sub LoadUnstained(ByVal SD As Date, ByVal ED As Date)
        Dim cmd As New SqlClient.SqlCommand("truncate table itm_unstn", cnn)
        Dim dr As DataRow
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim fm As New fmStatusBar
        Dim cnt As Long = 0
        Dim onPrice, onBase As Double

        fm.Label1.Text = "Loading unstained base prices.  Please Wait..."
        fm.Show()
        Application.DoEvents()

        cnn.Open()
        cmd.CommandTimeout = 0
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "select ord_itm.*,ord_sold_cust_serial,ord_gen_sales_cat,ord_gen_create_date,itm_unstained_itm_code from ord_file,ord_gen,ord_itm,itm_stain where ord_serial=ord_gen_ord_serial and ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_type=ord_itm_type and ord_gen_rev=ord_itm_rev and ord_itm_item_code=itm_stained_itm_code and ord_gen_type='O' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)>='" + CStr(SD) + "' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(ED) + "' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)>=itm_stained_start and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)<=itm_stained_end"
        cmd.CommandText = "select ord_itm.*,ord_sold_cust_serial,ord_gen_sales_cat,ord_gen_create_date,itm_unstained_itm_code from ord_file,ord_gen,ord_itm,itm_stain where ord_serial=ord_gen_ord_serial and ord_gen_ord_serial=ord_itm_ord_serial and ord_gen_type=ord_itm_type and ord_gen_rev=ord_itm_rev and ord_itm_item_code=itm_stained_itm_code and ord_gen_type='O' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)>='" + CStr(SD) + "' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(ED) + "'"
        Try
            da.Fill(ds)
            itmerr = ""

            For Each dr In ds.Tables(0).Rows
                'If dr("ord_itm_ord_serial") = 232447 Then MsgBox("hi")
                onPrice = GetItemPrice2(CStr(nz(dr("ord_sold_cust_serial"), "")), dr("itm_unstained_itm_code"), dr("ord_itm_qty"), dr("ord_gen_sales_cat"), dr("ord_gen_create_date"), True)
                onBase = GetItemPrice2(CStr(nz(dr("ord_sold_cust_serial"), "")), dr("itm_unstained_itm_code"), dr("ord_itm_qty"), "Base", dr("ord_gen_create_date"), True)
                Dim pp As Double = 0
                If nz2(dr("ord_itm_retail"), 0) = 0 Then
                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + dr("ord_itm_item_code") + "' and itm_price_qty_from<=1 and " + _
                   "itm_price_qty_to>=999999 and itm_price_start<='" + Format(Today, "MM/dd/yy") + "' and itm_price_end>='" + Format(Today, "MM/dd/yy") + "' " + _
                   "and itm_price_type='RET'"
                    pp = nz2(cmd.ExecuteScalar, 0)
                End If
                cmd.CommandText = "insert into itm_unstn (itm_unstn_ord_itm_serial,itm_unstn_base,itm_unstn_cat,itm_stain_retail) values (" + CStr(dr("ord_itm_serial")) + "," + CStr(onBase) + "," + CStr(onPrice) + "," + pp.ToString + ")"
                cmd.ExecuteNonQuery()
                fm.Bar1.Value = cnt / ds.Tables(0).Rows.Count * 100
                cnt += 1
            Next
        Catch
            MsgBox(Err.Description + vbCrLf + vbCrLf + cmd.CommandText)
        End Try
        If itmerr <> "" Then
            MsgBox("Base Price not found for these items... " + vbCrLf + itmerr, MsgBoxStyle.Critical, "Base Price?")
        End If
        cnn.Close()
        fm.Close()
    End Sub
    Private Sub LoadCurrentOSR(ByVal SD As Date, ByVal ED As Date, Optional ByVal RepType As String = "O")
        Dim cmd As New SqlClient.SqlCommand("select ord_gen_serial,ord_sold_state,ord_sold_zip,ord_gen_create_date from ord_gen,ord_file where ord_gen_ord_serial=ord_serial and ((ord_gen_ship_date>='" + CStr(SD) + "' and ord_gen_ship_date<='" + CStr(ED) + "') or (ord_gen_staged_date>='" + CStr(SD) + "' and ord_gen_staged_date<='" + CStr(ED) + "'))", cnn)
        Dim dr As DataRow
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim fm As New fmStatusBar
        Dim cnt As Long = 0

        Try
            Select Case RepType
                Case "O"
                    fm.Label1.Text = "Loading Current OSRs.  Please Wait..."
                Case "R"
                    fm.Label1.Text = "Loading Current Regions.  Please Wait..."
                    cmd.CommandText = "select ord_gen_serial,ord_sold_state,ord_sold_zip,ord_gen_create_date from ord_gen,ord_file where ord_gen_ord_serial=ord_serial and ((ord_gen_ship_date>='" + CStr(SD) + "' and ord_gen_ship_date<='" + CStr(ED) + "') or (ord_gen_staged_date>='" + CStr(SD) + "' and ord_gen_staged_date<='" + CStr(ED) + "')) and ord_gen_type='Q' and ord_gen_forecast='Forecasted'"
                Case Else
                    Exit Sub
            End Select
            fm.Show()
            Application.DoEvents()

            cnn.Open()
            da.Fill(ds)

            For Each dr In ds.Tables(0).Rows
                Try
                    cmd.CommandText = "update ord_gen set ord_gen_current_region='" + GetRepFromTerritory(nz(dr("ord_sold_state"), ""), "R", dr("ord_gen_create_date"), nz(dr("ord_sold_zip"))) + "' where ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                    cmd.ExecuteNonQuery()
                    fm.Bar1.Value = cnt / ds.Tables(0).Rows.Count * 100
                    cnt += 1
                Catch
                    MsgBox(Err.Description)
                End Try
            Next
            cnn.Close()
            fm.Close()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Function GetRepFromTerritory(ByVal State As String, ByVal RepType As String, ByVal SearchDate As Date, Optional ByVal ZipCode As String = "") As String
        GetRepFromTerritory = "NONE"
        If State = "" Then Exit Function
        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim dr As DataRow
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim zips As String
        Dim row As DataRow
        Dim Zip As Integer
        Dim doOutside As Boolean
        Try
            'cnn2.Open()

            cmd.CommandText = "select * from rep_ter where rep_ter_state='" + State + "' and rep_ter_start<='" + CStr(SearchDate) + "' and rep_ter_end>='" + CStr(SearchDate) + "'"
            da.Fill(ds, "rep")
            If ds.Tables("rep").Rows.Count > 0 Then
                For Each dr In ds.Tables("rep").Rows
                    If nz(dr("rep_ter_zip")) <> "" Then
                        If ZipCode <> "" Then
                            For Each zips In Split(dr("rep_ter_zip"), ",")
                                For Zip = CInt(Split(zips, "-")(0)) To CInt(Split(zips, "-")(Split(zips, "-").Length - 1))
                                    If Mid(ZipCode, 1, 3) = Mid(Trim(Zip), 1, 3) Then
                                        Select Case RepType
                                            Case "O"
                                                GetRepFromTerritory = nz(dr("rep_ter_out_rep_code"))
                                            Case "I"
                                                GetRepFromTerritory = nz(dr("rep_ter_in_rep_code"))
                                            Case "R"
                                                GetRepFromTerritory = nz(dr("rep_ter_region"))
                                            Case "M"
                                                GetRepFromTerritory = nz(dr("rep_ter_manager"))
                                        End Select
                                        cnn2.Close()
                                        If GetRepFromTerritory <> "" Then Exit Function
                                    End If
                                Next
                            Next
                        End If
                    Else
                        Select Case RepType
                            Case "O"
                                GetRepFromTerritory = nz(dr("rep_ter_out_rep_code"))
                            Case "I"
                                GetRepFromTerritory = nz(dr("rep_ter_in_rep_code"))
                            Case "R"
                                GetRepFromTerritory = nz(dr("rep_ter_region"))
                            Case "M"
                                GetRepFromTerritory = nz(dr("rep_ter_manager"))
                        End Select
                        If GetRepFromTerritory <> "" Then Exit Function
                    End If
                Next
            End If
            If GetRepFromTerritory = "" Then GetRepFromTerritory = "None"
            'cnn2.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Function
    Public Function GetCommFromTerritory(ByVal Rep As String, ByVal State As String, ByVal CommType As String, ByVal SearchDate As Date, Optional ByVal ZipCode As String = "") As Double
        GetCommFromTerritory = 0
        'If State = "" Then Exit Function
        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim dr As DataRow
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim zips As String
        Dim row As DataRow
        Dim Zip As Integer
        Dim doOutside As Boolean
        Try
            'cnn2.Open()

            cmd.CommandText = "select * from rep_ter where rep_ter_out_rep_code='" + Rep + "' and rep_ter_state='" + State + "' and rep_ter_start<='" + CStr(SearchDate) + "' and rep_ter_end>='" + CStr(SearchDate) + "'"
            da.Fill(ds, "rep")
            If ds.Tables("rep").Rows.Count > 0 Then
                For Each dr In ds.Tables("rep").Rows
                    If nz(dr("rep_ter_zip")) <> "" Then
                        If ZipCode <> "" Then
                            For Each zips In Split(dr("rep_ter_zip"), ",")
                                For Zip = CInt(Split(zips, "-")(0)) To CInt(Split(zips, "-")(Split(zips, "-").Length - 1))
                                    If Mid(ZipCode, 1, 3) = Mid(Trim(Zip), 1, 3) Then
                                        Select Case UCase(CommType)
                                            Case "RET"
                                                GetCommFromTerritory = nz(dr("rep_ter_out_comm_ret"), 0)
                                            Case "CON"
                                                GetCommFromTerritory = nz(dr("rep_ter_out_comm_con"), 0)
                                            Case "MD"
                                                GetCommFromTerritory = nz(dr("rep_ter_out_comm_md"), 0)
                                            Case "FIX"
                                                GetCommFromTerritory = nz(dr("rep_ter_out_comm_fix"), 0)
                                            Case "MR"
                                                GetCommFromTerritory = nz(dr("rep_ter_out_comm_mr"), 0)
                                            Case "TIER1"
                                                GetCommFromTerritory = nz(dr("rep_ter_out_tier1"), 0)
                                            Case "TIER2"
                                                GetCommFromTerritory = nz(dr("rep_ter_out_tier2"), 0)
                                            Case "TIER3"
                                                GetCommFromTerritory = nz(dr("rep_ter_out_tier3"), 0)
                                        End Select
                                        cnn2.Close()
                                        If GetCommFromTerritory <> 0 Then Exit Function
                                    End If
                                Next
                            Next
                        End If
                    Else
                        Select Case UCase(CommType)
                            Case "RET"
                                GetCommFromTerritory = nz(dr("rep_ter_out_comm_ret"), 0)
                            Case "CON"
                                GetCommFromTerritory = nz(dr("rep_ter_out_comm_con"), 0)
                            Case "MD"
                                GetCommFromTerritory = nz(dr("rep_ter_out_comm_md"), 0)
                            Case "FIX"
                                GetCommFromTerritory = nz(dr("rep_ter_out_comm_fix"), 0)
                            Case "MR"
                                GetCommFromTerritory = nz(dr("rep_ter_out_comm_mr"), 0)
                            Case "TIER1"
                                GetCommFromTerritory = nz(dr("rep_ter_out_tier1"), 0)
                            Case "TIER2"
                                GetCommFromTerritory = nz(dr("rep_ter_out_tier2"), 0)
                            Case "TIER3"
                                GetCommFromTerritory = nz(dr("rep_ter_out_tier3"), 0)
                        End Select
                        If GetCommFromTerritory <> 0 Then Exit Function
                    End If
                Next
            End If

            If GetCommFromTerritory = 0 Then
                Select Case UCase(CommType)
                    Case "RET"
                        cmd.CommandText = "select min(rep_ter_out_comm_ret) as commRate from rep_ter where rep_ter_out_rep_code='" + Rep + "' and rep_ter_start<='" + CStr(SearchDate) + "' and rep_ter_end>='" + CStr(SearchDate) + "'"
                        GetCommFromTerritory = nz(cmd.ExecuteScalar, 0)
                    Case "CON"
                        cmd.CommandText = "select min(rep_ter_out_comm_con) as commRate from rep_ter where rep_ter_out_rep_code='" + Rep + "' and rep_ter_start<='" + CStr(SearchDate) + "' and rep_ter_end>='" + CStr(SearchDate) + "'"
                        GetCommFromTerritory = nz(cmd.ExecuteScalar, 0)
                    Case "MD"
                        cmd.CommandText = "select min(rep_ter_out_comm_md) as commRate from rep_ter where rep_ter_out_rep_code='" + Rep + "' and rep_ter_start<='" + CStr(SearchDate) + "' and rep_ter_end>='" + CStr(SearchDate) + "'"
                        GetCommFromTerritory = nz(cmd.ExecuteScalar, 0)
                    Case "FIX"
                        cmd.CommandText = "select min(rep_ter_out_comm_fix) as commRate from rep_ter where rep_ter_out_rep_code='" + Rep + "' and rep_ter_start<='" + CStr(SearchDate) + "' and rep_ter_end>='" + CStr(SearchDate) + "'"
                        GetCommFromTerritory = nz(cmd.ExecuteScalar, 0)
                    Case "MR"
                        cmd.CommandText = "select min(rep_ter_out_comm_mr) as commRate from rep_ter where rep_ter_out_rep_code='" + Rep + "' and rep_ter_start<='" + CStr(SearchDate) + "' and rep_ter_end>='" + CStr(SearchDate) + "'"
                        GetCommFromTerritory = nz(cmd.ExecuteScalar, 0)
                    Case "TIER1"
                        GetCommFromTerritory = 0.07
                    Case "TIER2"
                        GetCommFromTerritory = 0.08
                    Case "TIER3"
                        GetCommFromTerritory = 0.09
                End Select

            End If
            'cnn2.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Function
    Public Sub PopulateValueList(ByRef grid1 As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal Table1 As String, ByVal SQLx As String, ByVal DisplayField As String, ByVal ValueField As String, ByVal GridField As String)
        If grid1.DisplayLayout.ValueLists.Exists(Table1) Then Exit Sub
        Dim objValueList As Infragistics.Win.ValueList
        Dim cmd As New SqlClient.SqlCommand
        Dim da As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        cmd.Connection = cnn
        cmd.CommandText = SQLx
        da.SelectCommand = cmd
        cnn.Open()
        da.Fill(ds, Table1)
        cnn.Close()

        objValueList = grid1.DisplayLayout.ValueLists.Add(Table1)
        Dim i As Integer
        For i = 0 To ds.Tables(Table1).Rows.Count - 1
            objValueList.ValueListItems.Add(ds.Tables(Table1).Rows(i).Item(ValueField), ds.Tables(Table1).Rows(i).Item(DisplayField))
        Next
        grid1.DisplayLayout.Bands(0).Columns(GridField).ValueList = grid1.DisplayLayout.ValueLists(Table1)
    End Sub
    Public Sub PopulateValueList_ID_File(ByRef grid1 As Infragistics.Win.UltraWinGrid.UltraGrid)
        If grid1.DisplayLayout.ValueLists.Exists("id_file") Then Exit Sub
        Dim objValueList As Infragistics.Win.ValueList
        Dim cmd As New SqlClient.SqlCommand
        Dim da As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        cmd.Connection = cnn
        cmd.CommandText = "select id_serial,id_full from id_file order by id_full"
        da.SelectCommand = cmd
        cnn.Open()
        da.Fill(ds, "id_file")
        cnn.Close()

        objValueList = grid1.DisplayLayout.ValueLists.Add("id_file")
        Dim i As Integer
        For i = 0 To ds.Tables("id_file").Rows.Count - 1
            objValueList.ValueListItems.Add(ds.Tables("id_file").Rows(i).Item("id_serial"), ds.Tables("id_file").Rows(i).Item("id_full"))
        Next
    End Sub
    Public Sub PopulateValueList_Acct_Type(ByRef grid1 As Infragistics.Win.UltraWinGrid.UltraGrid)
        If grid1.DisplayLayout.ValueLists.Exists("acct_type") Then Exit Sub
        Dim objValueList As Infragistics.Win.ValueList
        Dim cmd As New SqlClient.SqlCommand
        Dim da As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        cmd.Connection = cnn
        cmd.CommandText = "select acct_type from acct_type order by acct_type"
        da.SelectCommand = cmd
        cnn.Open()
        da.Fill(ds, "acct_type")
        cnn.Close()

        objValueList = grid1.DisplayLayout.ValueLists.Add("acct_type")
        Dim i As Integer
        For i = 0 To ds.Tables("acct_type").Rows.Count - 1
            objValueList.ValueListItems.Add(ds.Tables("acct_type").Rows(i).Item("acct_type"), ds.Tables("acct_type").Rows(i).Item("acct_type"))
        Next
    End Sub
    Public Sub EditButtons(ByVal eMode As String)
        Select Case eMode
            Case "Add"
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(0).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(1).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(2).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(3).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(4).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(5).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(6).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(7).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(8).SharedProps.Enabled = False
            Case "Edit"
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(0).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(1).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(2).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(3).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(4).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(5).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(6).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(7).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(8).SharedProps.Enabled = False
            Case "Idle"
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(0).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(1).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(2).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(3).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(4).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(5).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(6).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(7).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(8).SharedProps.Enabled = True
            Case "Blank"
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(0).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(1).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(2).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(3).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(4).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(5).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(6).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(7).SharedProps.Enabled = True
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(8).SharedProps.Enabled = True
            Case "None"
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(0).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(1).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(2).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(3).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(4).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(5).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(6).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(7).SharedProps.Enabled = False
                MainForm.Toolbar1.Toolbars("AddEdit").Tools(8).SharedProps.Enabled = False
        End Select
    End Sub
    Public Sub LoadCust()
        Try
            Dim da As New SqlClient.SqlDataAdapter
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = cnn
            cmd.CommandText = "select cust_serial,cust_id,cust_name from cust_file where inactive=0 order by cust_id"
            da.SelectCommand = cmd
            'cnn.Open()
            da.Fill(dsCustFile, "Customers")
            'cnn.Close()
            cmd = Nothing
            da = Nothing
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Sub LoadUsr()
        Try
            Dim da As New SqlClient.SqlDataAdapter
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = cnn
            cmd.CommandText = "select * from usr_file order by usr_name"
            da.SelectCommand = cmd
            'cnn.Open()
            da.Fill(dsUsrFile, "Users")
            'cnn.Close()
            cmd = Nothing
            da = Nothing
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Function nzz(ByVal x As VariantType) As VariantType
        If x.GetType Is DBNull.Value Then
            nzz = 0
        Else
            nzz = x
        End If
    End Function
    Public Sub LoadGrid(ByVal grid1 As Infragistics.Win.UltraWinGrid.UltraGrid, ByRef da As SqlClient.SqlDataAdapter, ByRef ds As DataSet, ByVal Sqlx As String, ByVal Table1 As String, Optional ByVal Clear As Boolean = True, Optional ByRef DV As DataView = Nothing)
        Try
            da.SelectCommand = New SqlClient.SqlCommand(Sqlx, cnn)
            Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
            Dim cnnState As ConnectionState = cnn.State

            If Clear Then ds.Clear()
            If cnn.State <> ConnectionState.Open Then cnn.Open()
            da.Fill(ds, Table1)
            If DV Is Nothing Then
                grid1.DataSource = ds
            Else
                DV = New DataView(ds.Tables(Table1))
                grid1.DataSource = DV
            End If
            If cnnState = ConnectionState.Closed Then cnn.Close()
            grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
            grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Sub LoadProdTypes(ByVal ds As DataSet)
        Dim da As New SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand("select itm_prod_type_type,itm_prod_type_desc from itm_prod_type order by itm_prod_type_type", cnn)
        da.SelectCommand = cmd
        cnn.Open()
        da.Fill(ds)
        cnn.Close()
    End Sub
    Public Sub LoadDD(ByVal DD As Infragistics.Win.UltraWinGrid.UltraCombo, ByRef ds As DataSet, ByVal Tbl As String, ByVal fVal As String, ByVal fDis As String, Optional ByVal fList As String = "", Optional ByVal WhereClause As String = "", Optional ByVal NoGroup As Boolean = False, Optional ByVal OrderBy As String = "")
        Try
            ds.Clear()
            Dim cmd As New SqlClient.SqlCommand
            Dim cn As New SqlClient.SqlConnection(connStr)
            Dim da As New SqlClient.SqlDataAdapter

            If fList = "" Then
                fList = fVal
                If fVal <> fDis Then fList += "," + fDis
            End If
            cmd.Connection = cn
            cmd.CommandText = "select " + fList + " from " + Tbl
            If WhereClause <> "" Then cmd.CommandText = cmd.CommandText + " where " + WhereClause
            If OrderBy <> "" Then
                cmd.CommandText = cmd.CommandText + " order by " + OrderBy
            Else
                If NoGroup = True Then
                    cmd.CommandText = cmd.CommandText
                Else
                    cmd.CommandText = cmd.CommandText + " order by " + fDis
                End If
            End If
            da.SelectCommand = cmd
            cn.Open()
            da.Fill(ds)
            cn.Close()
            DD.DataSource = ds.Tables(0)
            DD.ValueMember = fVal
            DD.DisplayMember = fDis
            DD.DataBind()
            cn = Nothing
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Sub LoadDD2(ByVal DD As Infragistics.Win.UltraWinGrid.UltraCombo, ByVal Tbl As String, ByVal fVal As String, ByVal fDis As String, Optional ByVal fList As String = "", Optional ByVal WhereClause As String = "", Optional ByVal AddNone As Boolean = False, Optional ByVal AddItemAtTop As String = "")
        Dim ds As New DataSet
        If ds.Tables.Count > 0 Then Exit Sub
        Dim cmd As New SqlClient.SqlCommand
        Dim da As New SqlClient.SqlDataAdapter

        If fList = "" Then
            fList = fVal
            If fVal <> fDis Then fList += "," + fDis
        End If
        cmd.Connection = cnn
        cmd.CommandText = "select " + fList + " from " + Tbl
        If WhereClause <> "" Then cmd.CommandText = cmd.CommandText + " where " + WhereClause
        cmd.CommandText = cmd.CommandText + " order by " + fDis
        da.SelectCommand = cmd
        da.Fill(ds)
        If AddNone Then
            Dim rw As DataRow
            Dim x As Integer
            rw = ds.Tables(0).NewRow
            For x = 0 To rw.ItemArray.Length - 1
                rw(x) = "<None>"
            Next
            ds.Tables(0).Rows.Add(rw)
        End If
        If AddItemAtTop <> "" Then
            Dim itm As String
            For Each itm In Split(AddItemAtTop, ",")
                Dim rw As DataRow
                Dim x As Integer
                rw = ds.Tables(0).NewRow
                rw(fVal) = itm
                rw(fDis) = itm
                ds.Tables(0).Rows.InsertAt(rw, 0)
            Next
        End If
        DD.DataSource = ds.Tables(0)
        DD.ValueMember = fVal
        DD.DisplayMember = fDis
        DD.DataBind()
        If AddItemAtTop <> "" Then DD.Value = AddItemAtTop
    End Sub
    Public Function CheckSecurity(ByVal Scrn As String) As Byte
        Dim cnn0 As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand("select sec_access from usr_file left outer join sec_file on usr_file.usr_group=sec_usr_serial where usr_serial=" + CStr(UserSerial) + " and sec_screen='" + Scrn + "'", cnn0)
        Dim dr As SqlClient.SqlDataReader
        cnn0.ConnectionString = cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'"
        cnn0.Open()

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            CheckSecurity = dr("sec_access")
            dr.Close()
        Else
            CheckSecurity = 0
        End If
        dr.Close()
        cmd.CommandText = "select sec_access from sec_file where sec_usr_serial=" + CStr(UserSerial) + " and sec_screen='" + Scrn + "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            CheckSecurity = dr("sec_access")
        End If
        dr.Close()
        cnn0.Close()
    End Function
    Public Function CheckMenuSecurity(ByVal mnu As String) As Integer
        'Dim cnn0 As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand("select usr_mnu_value from usr_mnu where usr_mnu_usr_serial=" + CStr(UserGroupSerial) + " and usr_mnu_itm='" + mnu + "'", cnn)
        'cnn0.ConnectionString = cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'"
        'cnn0.Open()

        CheckMenuSecurity = nz(cmd.ExecuteScalar, 0)
        cmd.CommandText = "select usr_mnu_value from usr_mnu where usr_mnu_usr_serial=" + CStr(UserSerial) + " and usr_mnu_itm='" + mnu + "'"
        CheckMenuSecurity = nz(cmd.ExecuteScalar, CheckMenuSecurity)

        'cnn0.Close()
    End Function
    Public Function jstr(ByVal x As Object) As String
        If x Is DBNull.Value Then
            jstr = "null"
        Else
            jstr = CStr(x)
        End If
    End Function
    Public Function nz(ByVal x As Object, Optional ByVal Def As String = "") As Object
        If (x Is DBNull.Value) Or (x Is Nothing) Then
            If Def <> "" Then
                nz = Def
            Else
                nz = ""
            End If
        Else
            nz = x
        End If
    End Function
    Public Function nz2(ByVal x As Object, Optional ByVal Def As Object = "") As Object
        If (x Is DBNull.Value) Or (x Is Nothing) Then
            nz2 = Def
        Else
            nz2 = x
        End If
    End Function
    Public Function JSaveRows(ByRef ds As DataSet, ByVal tbl As String, ByVal key As String, Optional ByVal cols As DataColumnCollection = Nothing) As Boolean
        Dim dr As DataRow
        Dim dc As DataColumn
        Dim sqlx, fld, dat, strx, onKey As String
        Dim cmd As New SqlClient.SqlCommand

        If cols Is Nothing Then cols = ds.Tables(tbl).Columns

        cmd.Connection = cnn
        cnn.Open()
        For Each dr In ds.Tables(tbl).Rows
            sqlx = ""
            fld = ""
            dat = ""
            Select Case dr.RowState
                Case DataRowState.Added
                    For Each dc In cols    'dr.Table.Columns
                        If dc.ColumnName <> key Then
                            fld = fld + dc.ColumnName + ","
                            dat = dat + JGetItemStr(dc.DataType.ToString, dr.Item(dc.ColumnName)) + ","
                        End If
                    Next
                    If fld.Length > 0 Then fld = Mid(fld, 1, fld.Length - 1)
                    If dat.Length > 0 Then dat = Mid(dat, 1, dat.Length - 1)
                    cmd.CommandText = "insert into " + tbl + " (" + fld + ") values (" + dat + ")"
                    cmd.ExecuteNonQuery()
                    Do While cnn.State = ConnectionState.Executing

                    Loop
                    cmd.CommandText = "select @@IDENTITY as jid"
                    dr(key) = cmd.ExecuteScalar
                    dr.AcceptChanges()
                Case DataRowState.Modified
                    For Each dc In cols    'dr.Table.Columns
                        If dc.ColumnName <> key Then
                            fld = fld + dc.ColumnName + "=" + JGetItemStr(dc.DataType.ToString, dr.Item(dc.ColumnName)) + ","
                        Else
                            onKey = JGetItemStr(dc.DataType.ToString, dr.Item(dc.ColumnName))
                        End If
                    Next
                    If fld.Length > 0 Then fld = Mid(fld, 1, fld.Length - 1)
                    cmd.CommandText = "update " + tbl + " set " + fld + " where " + key + "=" + onKey
                    cmd.ExecuteNonQuery()
                    dr.AcceptChanges()
                Case DataRowState.Deleted
                    For Each dc In cols   'dr.Table.Columns
                        If dc.ColumnName = key Then
                            onKey = JGetItemStr(dc.DataType.ToString, dr.Item(dc.ColumnName, DataRowVersion.Original))
                            Exit For
                        End If
                    Next
                    cmd.CommandText = "delete from " + tbl + " where " + key + "=" + onKey
                    cmd.ExecuteNonQuery()
                    'dr.AcceptChanges()
            End Select
        Next
        cnn.Close()
    End Function
    Public Function JGetItemStr(ByVal dtype As String, ByVal itm As Object) As String
        Select Case dtype
            Case "System.Int64"
                JGetItemStr = nz(itm, 0)
            Case "System.Int32"
                JGetItemStr = nz(itm, 0)
            Case "System.Decimal"
                JGetItemStr = nz(itm, 0)
            Case "System.Single"
                JGetItemStr = nz(itm, 0)
            Case "System.Boolean"
                JGetItemStr = IIf(nz(itm, False), "1", "0")
            Case "System.String"
                JGetItemStr = "'" + Replace(nz(itm), "'", "''") + "'"
            Case "System.DateTime"
                JGetItemStr = "'" + nz(itm) + "'"
            Case Else
                MsgBox("Type not defined, " + dtype + ".  See Jon Jansen")
        End Select
    End Function
    'Public Function CheckTaxRate(ByVal State As String, ByVal County As String)
    '    Dim cmd As New SqlClient.SqlCommand
    '    Dim cnn9 As New SqlClient.SqlConnection
    '    cnn9.ConnectionString = cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'"

    '    cmd.Connection = cnn9
    '    If County = "" Then
    '        cmd.CommandText = "select tax_rate from tax_file where tax_state='" + State + "' and tax_county='" + County + "'"
    '    Else
    '        cmd.CommandText = "select tax_rate from tax_file where tax_state='" + State + "' and ((tax_county='') or (tax_county is null))"
    '    End If
    '    Dim TaxRate As Double
    '    cnn9.Open()
    '    TaxRate = cmd.ExecuteScalar
    '    If TaxRate = 0 Then
    '        cmd.CommandText = "select tax_rate from tax_file where tax_state='" + State + "' and ((tax_county='') or (tax_county is null))"
    '        TaxRate = cmd.ExecuteScalar
    '    End If
    '    cnn9.Close()
    '    CheckTaxRate = TaxRate
    'End Function
    Public Sub BalanceCheck(Optional ByVal Stuff As String = "")
        Try
            Dim cmd As New SqlClient.SqlCommand("select sum(ord_gen_balance) as amt from ord_gen where ord_gen_type='O'", cnn2)
            Dim amt As Double
            cnn2.Open()
            amt = cmd.ExecuteScalar
            cmd.CommandText = "insert into bal_file (bal_amt,bal_user,bal_date,bal_stuff) values (" + CStr(amt) + ",'" + User + "','" + CStr(Date.Now) + "','" + Stuff + "')"
            cmd.ExecuteNonQuery()

            If amt > 4000000 Then
                cmd.CommandText = "select mas_email_sent from mas_file where mas_serial=1"
                Dim emailDate As Date
                emailDate = cmd.ExecuteScalar
                If DateDiff(DateInterval.Minute, emailDate, Now) > 10 Then
                    Dim email As New System.Net.Mail.MailMessage
                    Dim smtp As New SmtpClient("relay.appriver.com")
                    smtp.Port = 2525
                    email.To.Add("jon.jansen@jcom-inc.com")
                    email.From = New MailAddress("tlarkin@winecellarinnovations.com")
                    email.Subject = "Wine Cellar"
                    email.Body = "Balance Check " + FormatCurrency(amt) + " " + User + " " + Stuff
                    smtp.Send(email)
                    cmd.CommandText = "update mas_file set mas_email_sent='" + CStr(Now) + "'"
                    cmd.ExecuteNonQuery()
                End If
            End If
        Catch
            'MsgBox(Err.Description)
        Finally
            cnn2.Close()
        End Try
    End Sub
    Public Sub StatusCheck(ByVal Ord As String, ByVal OrdType As String, ByVal OrdRev As String, ByVal Stat As String, ByVal Source As String)
        Try
            Dim cmd As New SqlClient.SqlCommand("select ord_stat_stat from ord_stat where ord_stat_ord_serial=" + Ord + " and ord_stat_type='" + OrdType + "' and ord_stat_rev=" + OrdRev + " order by ord_stat_date desc", cnn2)
            Dim onStat As String
            If cnn2.State <> ConnectionState.Open Then cnn2.Open()
            onStat = nz(cmd.ExecuteScalar, "")
            If onStat <> Stat Then
                cmd.CommandText = "insert into ord_stat (ord_stat_ord_serial,ord_stat_type,ord_stat_rev,ord_stat_date,ord_stat_user,ord_stat_stat,ord_stat_source) values (" + Ord + ",'" + OrdType + "'," + OrdRev + ",'" + CStr(Now) + "','" + User + "','" + Stat + "','" + Source + "')"
                cmd.ExecuteNonQuery()
            End If
            If onStat = "CANCELED" And (onStat <> Stat) Then
                Dim email As New System.Net.Mail.MailMessage
                Dim smtp As New SmtpClient("relay.appriver.com")
                smtp.Port = 2525
                email.To.Add("5132577633@vtext.com;trishas@winecellarinnovations.com")
                email.From = New MailAddress("tlarkin@winecellarinnovations.com")
                email.Subject = "Status Changed"
                email.Body = "Status changed from " + onStat + " to " + Stat + " by " + User + " on order " + Ord + "-" + OrdRev + " at " + CStr(Now)
                smtp.Send(email)
            End If
        Catch
            MsgBox(Err.Description)
        Finally
            cnn2.Close()
        End Try
    End Sub
    Public Sub TotalCheck(ByVal Ord As String, Optional ByVal Stuff As String = "")
        Try
            Dim cmd As New SqlClient.SqlCommand("select * from ord_gen where ord_gen_ord_serial=" + Ord, cnn2)
            Dim amt As Double
            Dim row As DataRow
            Dim ds As New DataSet
            Dim da As New SqlClient.SqlDataAdapter(cmd)

            cnn2.Open()
            da.Fill(ds, "ord")

            For Each row In ds.Tables("ord").Rows
                If row("ord_gen_line_total") = 0 Then
                    cmd.CommandText = "select sum(ord_itm_unt_sell) as amt from ord_itm where ord_itm_ord_serial=" + CStr(row("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(row("ord_gen_rev")) + " and ord_itm_type='" + row("ord_gen_type") + "'"
                    If cmd.ExecuteScalar > 0 Then
                        Dim email As New System.Net.Mail.MailMessage
                        Dim smtp As New SmtpClient("relay.appriver.com")
                        smtp.Port = 2525
                        email.To.add("5132577633@vtext.com")
                        email.From = New MailAddress("tlarkin@winecellarinnovations.com")
                        email.Subject = "Wine Cellar"
                        email.Body = "Total Check " + CStr(Now) + " " + Stuff
                        smtp.Send(email)

                        Exit For
                    End If
                End If
            Next

        Catch
            'MsgBox(Err.Description)
        Finally
            cnn2.Close()
        End Try
    End Sub
    Public Function ItemPrice(ByVal onCust As Long, ByVal SalesCat As String, ByVal Itm As String, ByVal Qty As Double, ByRef pType As String, ByVal onDate As Date) As Double
        Try
            If Qty = 0 Then Qty = 1
            Dim cmd As New SqlClient.SqlCommand
            Dim dr As SqlClient.SqlDataReader
            Dim Base As Double

            If onCust = 0 Then
                onCust = -1
            End If
            cmd.Connection = cnn2
            cnn2.Open()

            cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + CStr(onDate) + "' and itm_price_end>='" + CStr(onDate) + "' and itm_price_type='Base'"
            ItemPrice = nz(cmd.ExecuteScalar, -999999)
            If ItemPrice <> -999999 Then
                Base = ItemPrice
            Else
                MsgBox("Base Price not found for " + Itm + ".  Not able to continue price calculation.", MsgBoxStyle.Critical, "Base Price?")
                Exit Function
            End If
            pType = ""

            cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_itm_code='" + Itm + "' and cust_itm_price_cust_serial=" + CStr(onCust) + " and cust_itm_price_from<=" + CStr(Qty) + " and cust_itm_price_to>=" + CStr(Qty) + " and cust_itm_price_start<='" + CStr(onDate) + "' and cust_itm_price_end>='" + CStr(onDate) + "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                ItemPrice = nz(dr.Item(0), 0)
                dr.Close()
                pType = "Customer Item Price"
            Else
                Dim ProdType As String = ""
                dr.Close()
                cmd.CommandText = "select itm_prod_type from itm_file where itm_code='" + Itm + "'"
                dr = cmd.ExecuteReader
                If Not dr.HasRows Then
                    MsgBox("Product Type NOT FOUND for item " + Itm + ".  Pricing not able to calculate.")
                    dr.Close()
                    Exit Function
                Else
                    dr.Read()
                    ProdType = nz(dr.Item(0), "")
                    dr.Close()
                    cmd.CommandText = "select cust_prod_mar_margin from cust_prod_mar where cust_prod_mar_type='" + ProdType + "' and cust_prod_mar_cust_serial=" + CStr(onCust) + " and cust_prod_mar_from<=" + CStr(Qty) + " and cust_prod_mar_to>=" + CStr(Qty) + " and cust_prod_mar_start<='" + CStr(onDate) + "' and cust_prod_mar_end>='" + CStr(onDate) + "'"
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        ItemPrice = nz(dr.Item(0), 0)
                        dr.Close()
                        ItemPrice = Base * ItemPrice
                        pType = "Customer Product Margin"
                    Else
                        dr.Close()
                        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_type='" + SalesCat + "' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + CStr(onDate) + "' and itm_price_end>='" + CStr(onDate) + "'"
                        dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            dr.Read()
                            ItemPrice = nz(dr.Item(0), 0)
                            dr.Close()
                            pType = "Sales Category Item Price"
                        Else
                            dr.Close()
                            cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + ProdType + "' and sales_cat_prod_mar_cat='" + SalesCat + "' and sales_cat_prod_mar_from<=" + CStr(Qty) + " and sales_cat_prod_mar_to>=" + CStr(Qty) + " and sales_cat_prod_mar_start<='" + CStr(onDate) + "' and sales_cat_prod_mar_end>='" + CStr(onDate) + "'"
                            dr = cmd.ExecuteReader
                            If dr.HasRows Then
                                dr.Read()
                                ItemPrice = nz(dr.Item(0), 0)
                                dr.Close()
                                ItemPrice = Base * ItemPrice
                                pType = "Sales Category Product Type"
                            Else
                                ItemPrice = Base
                                pType = "Base Price Method"
                                dr.Close()
                            End If
                        End If
                    End If
                End If
            End If
            ItemPrice = Math.Round(ItemPrice + 0.00001, 2)

            cmd.CommandText = "select itm_surcharge from itm_file where itm_code='" + Itm + "'"
            If cmd.ExecuteScalar = True Then
                Dim rate As Double
                cmd.CommandText = "select itm_surcharge_rate from itm_surcharge where itm_surcharge_from<=" + CStr(Qty) + " and itm_surcharge_to>=" + CStr(Qty)
                rate = nz(cmd.ExecuteScalar, 0)
                If rate <> 0 Then ItemPrice = ItemPrice * rate
            End If
            ItemPrice = Math.Round(ItemPrice + 0.00001, 2)
        Catch
            DoError(Err, MainForm)
        End Try
    End Function
    Public Sub DelRecord(ByVal tbl As String, ByVal notes As String)
        Dim cmd As New SqlClient.SqlCommand("insert into del_file (del_tbl,del_user,del_date,del_notes) values ('" + tbl + "','" + User + "','" + CStr(Now) + "','" + notes + "')", cnn2)
        cnn2.Open()
        cmd.ExecuteNonQuery()
        cnn2.Close()
    End Sub
    Public Sub CheckToDo()
        Try
            Dim cmd As New SqlClient.SqlCommand("", cnn2)
            Dim dr As SqlClient.SqlDataReader
            Dim UserList As String

            If UserISRAdmin Then
                cmd.CommandText = "select usr_isr_list from usr_file where usr_name='" + User + "'"
                UserList = Replace(nz(cmd.ExecuteScalar, "''"), "*", "'")
                If Microsoft.VisualBasic.Right(UserList, 1) = "," Then UserList = Mid(UserList, 1, Len(UserList) - 1)
            Else
                UserList = "'" + User + "'"
            End If

            cmd.CommandText = "select rep_code from rep_file where rep_code in (" + UserList + ") and isnull(rep_designer_time,'1/1/1900')>isnull(rep_isr_time,'1/1/1900')"
            cnn2.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then MainForm.Toolbar1.Tools("Check Off").SharedProps.AppearancesSmall.Appearance.BackColor = Color.Yellow
            dr.Close()
            cnn2.Close()
        Catch
        End Try
    End Sub
    Public Sub CheckToDoList()
        Try
            Dim cmd As New SqlClient.SqlCommand("select count(to_do_serial) as cnt from to_do where to_do_user='" + User + "' and to_do_complete=0", cnn2)

            cnn2.Open()
            If nz(cmd.ExecuteScalar, 0) > 0 Then
                MainForm.Toolbar1.Tools("To Do List").SharedProps.AppearancesSmall.Appearance.BackColor = Color.Yellow
            Else
                MainForm.Toolbar1.Tools("To Do List").SharedProps.AppearancesSmall.Appearance.BackColor = Color.Empty
            End If
            cnn2.Close()
        Catch
        End Try
    End Sub
    Public Function GetControl(ByVal Ctls As Control.ControlCollection, ByVal Name As String) As Object
        Dim ct As Control
        For Each ct In Ctls
            If ct.Name = Name Then
                GetControl = ct
                Exit For
            End If
        Next
    End Function
    Public Function ShipFedEx(ByVal Data As String) As String
        Try
            Dim st As System.Net.Sockets.NetworkStream
            Dim tcp As New System.Net.Sockets.TcpClient
            Dim buff(1023) As Byte
            Dim ln, rt As String
            Dim read As Integer
            Dim sendData As Byte()
            'ln = "0," + """403""" + "1537," + """687869695271""" + "99,"""""
            ln = Data

            tcp.Connect("10.0.0.245", 2000)
            st = tcp.GetStream
            sendData = System.Text.Encoding.ASCII.GetBytes(ln)
            st.Write(sendData, 0, ln.Length)

            tcp.ReceiveTimeout = 10000
            Dim getData(tcp.ReceiveBufferSize) As Byte
            st.Read(getData, 0, CInt(tcp.ReceiveBufferSize))
            rt = System.Text.Encoding.ASCII.GetString(getData)
            ShipFedEx = rt

            tcp.Close()

            Try
                Dim fl As New IO.StreamWriter("\\10.0.0.245\jcom$\FedEx\Results\FedEx " + Format(Now, "yyyy-MM-dd hh-mm-ss") + ".txt", True)
                fl.WriteLine(Data)
                fl.WriteLine(rt)
                fl.Close()
            Catch ex As Exception
                DoError(Err, MainForm, "Submit to Fedex")
            End Try
        Catch
            MsgBox(Err.Description)
        End Try

    End Function
    Public Class FedExData
        Public DataString As String
        Dim dsFedEx As DataSet
        Public Sub New(ByVal Datax As String)
            DataString = Datax
            dsFedEx = New DataSet
            Dim rw As DataRow
            Dim itm As String
            Dim x As Integer

            dsFedEx.Tables.Add("itm")
            dsFedEx.Tables("itm").Columns.Add("Code", System.Type.GetType("System.String"))
            dsFedEx.Tables("itm").Columns.Add("Data", System.Type.GetType("System.String"))

            For x = 0 To Split(Datax, Chr(34)).Length - 1 Step 2
                itm = Split(Datax, Chr(34))(x)
                If InStr(itm, ",") Then
                    rw = dsFedEx.Tables("itm").NewRow
                    rw("code") = Split(itm, ",")(0)
                    rw("data") = Split(Datax, Chr(34))(x + 1)
                    dsFedEx.Tables("itm").Rows.Add(rw)
                End If
            Next
        End Sub
        Public Function GetData(ByVal Code As String) As String
            Dim rws As DataRow()
            rws = dsFedEx.Tables("itm").Select("code='" + Code + "'")
            If rws.Length > 0 Then
                GetData = rws(0).Item("data")
            Else
                GetData = ""
            End If
        End Function
    End Class
    Public Class RawPrinterHelper
        ' Structure and API declarions:
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Structure DOCINFOW
            <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
        End Structure

        <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As Long) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="WritePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
        End Function

        ' SendBytesToPrinter()
        ' When the function is given a printer name and an unmanaged array of  
        ' bytes, the function sends those bytes to the print queue.
        ' Returns True on success or False on failure.
        Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
            Dim hPrinter As IntPtr      ' The printer handle.
            Dim dwError As Int32        ' Last error - in case there was trouble.
            Dim di As DOCINFOW          ' Describes your document (name, port, data type).
            Dim dwWritten As Int32      ' The number of bytes written by WritePrinter().
            Dim bSuccess As Boolean     ' Your success code.

            ' Set up the DOCINFO structure.
            With di
                .pDocName = "My Visual Basic .NET RAW Document"
                .pDataType = "RAW"
            End With
            ' Assume failure unless you specifically succeed.
            bSuccess = False
            If OpenPrinter(szPrinterName, hPrinter, 0) Then
                If StartDocPrinter(hPrinter, 1, di) Then
                    If StartPagePrinter(hPrinter) Then
                        ' Write your printer-specific bytes to the printer.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                        EndPagePrinter(hPrinter)
                    End If
                    EndDocPrinter(hPrinter)
                End If
                ClosePrinter(hPrinter)
            End If
            ' If you did not succeed, GetLastError may give more information
            ' about why not.
            If bSuccess = False Then
                dwError = Marshal.GetLastWin32Error()
            End If
            Return bSuccess
        End Function ' SendBytesToPrinter()

        ' SendFileToPrinter()
        ' When the function is given a file name and a printer name, 
        ' the function reads the contents of the file and sends the
        ' contents to the printer.
        ' Presumes that the file contains printer-ready data.
        ' Shows how to use the SendBytesToPrinter function.
        ' Returns True on success or False on failure.
        Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
            ' Open the file.
            Dim fs As New FileStream(szFileName, FileMode.Open)
            ' Create a BinaryReader on the file.
            Dim br As New BinaryReader(fs)
            ' Dim an array of bytes large enough to hold the file's contents.
            Dim bytes(fs.Length) As Byte
            Dim bSuccess As Boolean
            ' Your unmanaged pointer.
            Dim pUnmanagedBytes As IntPtr

            ' Read the contents of the file into the array.
            bytes = br.ReadBytes(fs.Length)
            ' Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(fs.Length)
            ' Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, fs.Length)
            ' Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, fs.Length)
            ' Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes)
            Return bSuccess
        End Function ' SendFileToPrinter()

        ' When the function is given a string and a printer name,
        ' the function sends the string to the printer as raw bytes.
        Public Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String)
            Dim pBytes As IntPtr
            Dim dwCount As Int32
            ' How many characters are in the string?
            dwCount = szString.Length()
            ' Assume that the printer is expecting ANSI text, and then convert
            ' the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString)
            ' Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount)
            Marshal.FreeCoTaskMem(pBytes)
        End Function
    End Class


    Public Class DoFedEx
        Public Shared Sub LoadFromFile(ByVal FileName As String)
            Dim fl As New IO.StreamReader(FileName)
            Dim ln As String
            Dim fld As String
            Dim rw As DataRow
            Dim cmd As New SqlCommand("", cnn)
            Dim dt As String
            Dim dsData As New DataSet
            Dim dsImport As New DataSet
            Dim da As New SqlDataAdapter(cmd)
            Dim onInvoice As String
            Dim onShipSerial As Long
            Dim Skip = False
            Dim rName = ""
            Try

                cmd.CommandText = "select * from ship_bill where ship_bill_serial=-1"
                cnn.Open()
                da.Fill(dsData, "itm")

                Dim reader As XmlTextReader = New XmlTextReader(FileName)

                Do While (reader.Read())
                    Select Case reader.NodeType
                        Case XmlNodeType.Element 'Display beginning of element.
                            rName = reader.Name
                            If reader.Name = "Invoice_Download" Then
                                rw = dsData.Tables("itm").NewRow
                            End If
                            If reader.HasAttributes Then 'If attributes exist
                                While reader.MoveToNextAttribute()
                                    ''Display attribute name and value.
                                    Console.Write(" {0}='{1}'", reader.Name, reader.Value)
                                End While
                            End If
                        Case XmlNodeType.Text 'Display the text in each element.
                            'Console.WriteLine(reader.Value)
                            Dim x = reader.Value
                            Select Case rName
                                Case "invoice_date"
                                    rw("ship_bill_invdate") = GetDate(reader.Value, "yyyymmdd")
                                Case "invoice_number"
                                    Skip = False
                                    cmd.CommandText = "select top 1 ship_bill_serial from ship_bill where ship_bill_invoice='" + reader.Value + "'"
                                    onInvoice = reader.Value
                                    If Not cmd.ExecuteScalar Is Nothing Then
                                        If MsgBox("FedEx invoice " + onInvoice + " has already been imported.  Do you want to clear this invoice and re-import", MsgBoxStyle.YesNo, "Import?") = MsgBoxResult.No Then
                                            cnn.Close()
                                            Skip = True
                                        Else
                                            cmd.CommandText = "delete from ship_bill where ship_bill_invoice='" + reader.Value + "'"
                                            cmd.ExecuteNonQuery()
                                        End If
                                    End If
                                    rw("ship_bill_invoice") = reader.Value
                                    rw("ship_bill_qty") = 1
                                    rw("ship_bill_shipcompany") = "WINE CELLAR INNOVATIONS"
                                    rw("ship_bill_shipname") = "WINE CEL"
                                Case "original_amount_due"
                                    rw("ship_bill_amt") = reader.Value
                                Case "payor"
                                    rw("ship_bill_payor") = reader.Value
                                Case "express_ground_tracking_id"
                                    rw("ship_bill_tracking") = reader.Value
                                    cmd.CommandText = "select ship_serial from ship_file where ship_track='" + rw("ship_bill_tracking") + "'"
                                    onShipSerial = nz(cmd.ExecuteScalar, -1)
                                    If onShipSerial = -1 Then
                                        cmd.CommandText = "select ship_serial from ship_file where ship_track='045" + rw("ship_bill_tracking") + "'"
                                        onShipSerial = nz(cmd.ExecuteScalar, -1)
                                    End If
                                    rw("ship_bill_ship_serial") = onShipSerial

                                Case "service_type"
                                    rw("ship_bill_company") = reader.Value
                                    rw("ship_bill_shipvia") = reader.Value
                                Case "shipment_date"
                                    rw("ship_bill_shipdate") = GetDate(reader.Value, "yyyymmdd")
                                Case "pod_deliverly_date", "pod_delivery_date"
                                    rw("ship_bill_deldate") = GetDate(reader.Value, "yyyymmdd")
                                Case "recipient_name"
                                    rw("ship_bill_toname") = reader.Value
                                Case "recipient_company"
                                    rw("ship_bill_tocompany") = reader.Value
                                Case "recipient_address_line_1"
                                    rw("ship_bill_toaddr1") = reader.Value
                                    rw("ship_bill_toaddr2") = ""
                                Case "recipient_city"
                                    rw("ship_bill_tocity") = reader.Value
                                Case "recipient_state"
                                    rw("ship_bill_tostate") = reader.Value
                                Case "recipient_zip_code"
                                    rw("ship_bill_tozip") = reader.Value
                                Case "original_customer_reference"
                                    rw("ship_bill_ref") = reader.Value
                                Case ""
                            End Select
                        Case XmlNodeType.EndElement 'Display end of element.
                            'Console.Write("</" + reader.Name)
                            If reader.Name = "Invoice_Download" Then
                                If Skip = False Then
                                    dsData.Tables("itm").Rows.Add(rw)
                                Else
                                    rw.Delete()
                                End If
                            End If
                            If reader.Name = "Download" Then
                                Exit Do
                            End If
                    End Select
                Loop

                'Do While ln <> Nothing
                '    'rw("ship_bill_weight") = Split(ln, "|")(17)
                '    rw("ship_bill_meter") = Split(ln, "|")(23)
                '    rw("ship_bill_toaddr2") = Split(ln, "|")(27)

                '    rw("ship_bill_shipname") = Split(ln, "|")(33)
                '    If Split(ln, "|")(40).Length >= 4 And Split(ln, "|")(40) <> "NO REFERENCE INFORMATION" Then
                '        rw("ship_bill_group") = Mid(Split(ln, "|")(40), 1, 2)
                '        rw("ship_bill_content") = Mid(Split(ln, "|")(40), 3, 3)
                '        rw("ship_bill_initials") = Mid(Split(ln, "|")(40), 6, 3)
                '    End If
                '    ln = fl.ReadLine
                '    ln = Replace(ln, """,""", """;""")
                'Loop

                da = New SqlDataAdapter(New SqlCommand("select * from ship_bill where ship_bill_serial=-1", cnn))
                Dim cb As New SqlCommandBuilder(da)
                cb.RefreshSchema()
                da.Update(dsData.Tables("itm"))

                cnn.Close()
                DisplayReport("shipping late", , False, 1, onInvoice)
                DisplayReport("Shipping - Items not matched from bill.rpt", , False, 1, onInvoice)
            Catch
                cnn.Close()
                MsgBox(Err.Description + vbCrLf + ln)
            End Try
        End Sub

        'Public Shared Sub LoadFromFileOLD(ByVal FileName As String)
        '    Dim fl As New IO.StreamReader(FileName)
        '    Dim ln As String
        '    Dim fld As String
        '    Dim rw As DataRow
        '    Dim cmd As New SqlCommand("", cnn)
        '    Dim dt As String
        '    Dim dsData As New DataSet
        '    Dim dsImport As New DataSet
        '    Dim da As New SqlDataAdapter(cmd)
        '    Dim onInvoice As String
        '    Dim onShipSerial As Long

        '    Try
        '        cmd.CommandText = "select * from ship_bill where ship_bill_serial=-1"
        '        cnn.Open()
        '        da.Fill(dsData, "itm")

        '        ln = fl.ReadLine
        '        'ln = fl.ReadLine

        '        ln = fl.ReadLine
        '        ln = Replace(ln, """,""", """;""")
        '        cmd.CommandText = "select top 1 ship_bill_serial from ship_bill where ship_bill_invoice='" + Split(ln, """;""")(2) + "'"
        '        onInvoice = Split(ln, """;""")(2)
        '        If Not cmd.ExecuteScalar Is Nothing Then
        '            If MsgBox("FedEx invoice " + onInvoice + " has already been imported.  Do you want to clear this invoice and re-import", MsgBoxStyle.YesNo, "Import?") = MsgBoxResult.No Then
        '                cnn.Close()
        '                Exit Sub
        '            Else
        '                cmd.CommandText = "delete from ship_bill where ship_bill_invoice='" + Split(ln, """;""")(2) + "'"
        '                cmd.ExecuteNonQuery()
        '            End If
        '        End If
        '        Do While ln <> Nothing
        '            rw = dsData.Tables("itm").NewRow
        '            If Microsoft.VisualBasic.Left(ln, 1) = """" Then ln = Mid(ln, 2)
        '            If Microsoft.VisualBasic.Right(ln, 1) = """" Then ln = Mid(ln, 1, Len(ln) - 1)
        '            'rw.ItemArray = Split(ln, """;""", , CompareMethod.Text)

        '            rw("ship_bill_company") = Split(ln, """;""")(10)
        '            rw("ship_bill_invoice") = Split(ln, """;""")(2)
        '            rw("ship_bill_invdate") = GetDate(Split(ln, """;""")(1), "yyyymmdd")
        '            rw("ship_bill_tracking") = Split(ln, """;""")(7)
        '            rw("ship_bill_amt") = Split(ln, """;""")(9)
        '            rw("ship_bill_shipvia") = Split(ln, """;""")(10)
        '            rw("ship_bill_qty") = 1
        '            rw("ship_bill_weight") = Split(ln, """;""")(17)
        '            rw("ship_bill_shipdate") = GetDate(Split(ln, """;""")(12), "yyyymmdd")
        '            rw("ship_bill_deldate") = GetDate(Split(ln, """;""")(13), "yyyymmdd", Split(ln, """;""")(14))
        '            rw("ship_bill_payor") = Split(ln, """;""")(5)
        '            rw("ship_bill_meter") = Split(ln, """;""")(23)
        '            rw("ship_bill_toname") = Split(ln, """;""")(24)
        '            rw("ship_bill_tocompany") = Split(ln, """;""")(25)
        '            rw("ship_bill_toaddr1") = Split(ln, """;""")(26)
        '            rw("ship_bill_toaddr2") = Split(ln, """;""")(27)
        '            rw("ship_bill_tocity") = Split(ln, """;""")(28)
        '            rw("ship_bill_tostate") = Split(ln, """;""")(29)
        '            rw("ship_bill_tozip") = Split(ln, """;""")(30)
        '            rw("ship_bill_shipcompany") = Split(ln, """;""")(32)
        '            rw("ship_bill_shipname") = Split(ln, """;""")(33)
        '            rw("ship_bill_ref") = Split(ln, """;""")(40)
        '            If Split(ln, """;""")(40).Length >= 4 And Split(ln, """;""")(40) <> "NO REFERENCE INFORMATION" Then
        '                rw("ship_bill_group") = Mid(Split(ln, """;""")(40), 1, 2)
        '                rw("ship_bill_content") = Mid(Split(ln, """;""")(40), 3, 3)
        '                rw("ship_bill_initials") = Mid(Split(ln, """;""")(40), 6, 3)
        '            End If

        '            cmd.CommandText = "select ship_serial from ship_file where ship_track='" + rw("ship_bill_tracking") + "'"
        '            onShipSerial = nz(cmd.ExecuteScalar, -1)
        '            If onShipSerial = -1 Then
        '                cmd.CommandText = "select ship_serial from ship_file where ship_track='045" + rw("ship_bill_tracking") + "'"
        '                onShipSerial = nz(cmd.ExecuteScalar, -1)
        '            End If
        '            rw("ship_bill_ship_serial") = onShipSerial
        '            'If rw("ship_bill_ship_serial") = -1 Then
        '            '    rw("ship_bill_cat") = "NONE"
        '            'Else
        '            '    rw("ship_bill_cat") = "ORDER"
        '            'End If

        '            dsData.Tables("itm").Rows.Add(rw)
        '            ln = fl.ReadLine
        '            ln = Replace(ln, """,""", """;""")
        '        Loop

        '        da = New SqlDataAdapter(New SqlCommand("select * from ship_bill where ship_bill_serial=-1", cnn))
        '        Dim cb As New SqlCommandBuilder(da)
        '        cb.RefreshSchema()
        '        da.Update(dsData.Tables("itm"))

        '        cnn.Close()
        '        DisplayReport("shipping late", , False, 1, onInvoice)
        '        DisplayReport("Shipping - Items not matched from bill.rpt", , False, 1, onInvoice)
        '    Catch
        '        cnn.Close()
        '        MsgBox(Err.Description + vbCrLf + ln)
        '    End Try
        'End Sub

        Private Shared Function GetDate(ByVal dt As String, ByVal frm As String, Optional ByVal tm As String = "") As Object
            Select Case frm
                Case "yyyymmdd"
                    If dt = "00000000" Then
                        GetDate = DBNull.Value
                    Else
                        If tm <> "" Then tm = " " + Mid(tm, 2, 2) + ":" + Mid(tm, 4, 2)
                        GetDate = CDate(Mid(dt, 5, 2) + "/" + Mid(dt, 7, 2) + "/" + Mid(dt, 1, 4) + tm)
                    End If
            End Select
        End Function
    End Class

    'Public Function GetItemPrice(ByVal CustID As String, ByVal Itm As String, ByVal Qty As Double, ByRef SalesCat As String, ByVal onDate As Date) As Double
    '    Try
    '        If Qty = 0 Then Qty = 1
    '        Dim cmd As New SqlCommand
    '        Dim onCust As Long
    '        Dim dr As SqlDataReader
    '        Dim BasePrice As Double = 0
    '        Dim onPrice As Double

    '        'If tCustId.Value = Nothing Then
    '        '    onCust = -1
    '        'Else
    '        '    onCust = tCustId.Value
    '        'End If
    '        onCust = CLng(CustID)
    '        cmd.Connection = cnn2
    '        cnn2.Open()

    '        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + Format(onDate, "MM/dd/yy") + "' and itm_price_end>='" + Format(onDate, "MM/dd/yy") + "' and itm_price_type='Base'"
    '        onPrice = nz(cmd.ExecuteScalar, -1)
    '        If onPrice >= 0 Then
    '            BasePrice = onPrice
    '        Else
    '            MsgBox("Base Price not found for " + Itm + ".  Not able to continue price calculation.", MsgBoxStyle.Critical, "Base Price?")
    '            cnn2.Close()
    '            Exit Function
    '        End If
    '        If SalesCat = "Base" Then
    '            GetItemPrice = onPrice
    '            cnn2.Close()
    '            Exit Function
    '        End If

    '        cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_itm_code='" + Itm + "' and cust_itm_price_cust_serial=" + CStr(onCust) + " and cust_itm_price_from<=" + CStr(Qty) + " and cust_itm_price_to>=" + CStr(Qty) + " and cust_itm_price_start<='" + Format(onDate, "MM/dd/yy") + "' and cust_itm_price_end>='" + Format(onDate, "MM/dd/yy") + "'"
    '        dr = cmd.ExecuteReader
    '        If dr.HasRows Then
    '            dr.Read()
    '            onPrice = nz(dr.Item(0), 0)
    '            dr.Close()
    '        Else
    '            Dim ProdType As String = ""
    '            dr.Close()
    '            cmd.CommandText = "select itm_prod_type from itm_file where itm_code='" + Itm + "'"
    '            dr = cmd.ExecuteReader
    '            If Not dr.HasRows Then
    '                MsgBox("Product Type NOT FOUND for item " + Itm + ".  Pricing not able to calculate.")
    '                dr.Close()
    '                Exit Function
    '            Else
    '                dr.Read()
    '                ProdType = nz(dr.Item(0), "")
    '                dr.Close()
    '                cmd.CommandText = "select cust_prod_mar_margin from cust_prod_mar where cust_prod_mar_type='" + ProdType + "' and cust_prod_mar_cust_serial=" + CStr(onCust) + " and cust_prod_mar_from<=" + CStr(Qty) + " and cust_prod_mar_to>=" + CStr(Qty) + " and cust_prod_mar_start<='" + Format(onDate, "MM/dd/yy") + "' and cust_prod_mar_end>='" + Format(onDate, "MM/dd/yy") + "'"
    '                dr = cmd.ExecuteReader
    '                If dr.HasRows Then
    '                    dr.Read()
    '                    onPrice = nz(dr.Item(0), 0)
    '                    dr.Close()
    '                    onPrice = BasePrice * onPrice
    '                Else
    '                    dr.Close()
    '                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_type='" + SalesCat + "' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + Format(onDate, "MM/dd/yy") + "' and itm_price_end>='" + Format(onDate, "MM/dd/yy") + "'"
    '                    dr = cmd.ExecuteReader
    '                    If dr.HasRows Then
    '                        dr.Read()
    '                        onPrice = nz(dr.Item(0), 0)
    '                        dr.Close()
    '                    Else
    '                        dr.Close()
    '                        cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + ProdType + "' and sales_cat_prod_mar_cat='" + ProdType + "' and sales_cat_prod_mar_from<=" + CStr(Qty) + " and sales_cat_prod_mar_to>=" + CStr(Qty) + " and sales_cat_prod_mar_start<='" + Format(onDate, "MM/dd/yy") + "' and sales_cat_prod_mar_end>='" + Format(onDate, "MM/dd/yy") + "'"
    '                        dr = cmd.ExecuteReader
    '                        If dr.HasRows Then
    '                            dr.Read()
    '                            onPrice = nz(dr.Item(0), 0)
    '                            dr.Close()
    '                            onPrice = BasePrice * onPrice
    '                        Else
    '                            onPrice = BasePrice
    '                            dr.Close()
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '        onPrice = Math.Round(onPrice + 0.00001, 2)

    '        cmd.CommandText = "select itm_surcharge from itm_file where itm_code='" + Itm + "'"
    '        If cmd.ExecuteScalar = True Then
    '            Dim rate As Double
    '            cmd.CommandText = "select itm_surcharge_rate from itm_surcharge where itm_surcharge_from<=" + CStr(Qty) + " and itm_surcharge_to>=" + CStr(Qty)
    '            rate = nz(cmd.ExecuteScalar, 0)
    '            If rate <> 0 Then onPrice = onPrice * rate
    '        End If
    '        onPrice = Math.Round(onPrice + 0.00001, 2)

    '        'If row Is Nothing Then
    '        '    If cb5Perc.Checked = True And (nz(tProdType.Value, "") = "TOP" Or nz(tProdType.Value, "") = "BUD" Or nz(tProdType.Value, "") = "GOLD") And Mid(Tab1.ActiveTab.Key, 1, 1) = "O" Then
    '        '        tDisc.Value = Math.Round((onPrice * Qty * 0.05) + 0.00001, 2)
    '        '    End If
    '        'Else
    '        '    If cb5Perc.Checked = True And (nz(row("ord_itm_prod_type"), "") = "TOP" Or nz(row("ord_itm_prod_type"), "") = "BUD" Or nz(row("ord_itm_prod_type"), "") = "GOLD") And Mid(Tab1.ActiveTab.Key, 1, 1) = "O" Then
    '        '        row("ord_itm_disc") = Math.Round((onPrice * Qty * 0.05 * -1) + 0.00001, 2)
    '        '    End If
    '        'End If

    '        cnn2.Close()
    '        GetItemPrice = onPrice
    '    Catch
    '        DoError(Err, MainForm)
    '    End Try
    'End Function

    Public Function GetItemPrice2(ByVal CustID As String, ByVal Itm As String, ByVal Qty As Double, ByRef SalesCat As String, ByVal onDate As Date, Optional ByVal BaseNotFoundUseCurrent As Boolean = False) As Double
        Try
            If Qty = 0 Then Qty = 1
            Dim cmd As New SqlCommand
            Dim onCust As Long
            Dim dr As SqlDataReader
            Dim BasePrice As Double = 0
            Dim onPrice As Double

            onCust = CLng(CustID)
            cmd.Connection = cnn
            'cnn2.Open()

            cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and " + _
            "itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and " + _
            "itm_price_start<='" + Format(onDate, "MM/dd/yy") + "' and itm_price_end>='" + Format(onDate, "MM/dd/yy") + "' and itm_price_type='Base'"
            onPrice = nz(cmd.ExecuteScalar, -999999)
            If onPrice <> -999999 Then
                BasePrice = onPrice
            Else
                If BaseNotFoundUseCurrent Then
                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_qty_from<=" + CStr(Qty) + " and " + _
                    "itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + Format(Today, "MM/dd/yy") + "' and itm_price_end>='" + Format(Today, "MM/dd/yy") + "' " + _
                    "and itm_price_type='Base'"
                    onPrice = nz(cmd.ExecuteScalar, -999999)
                    If onPrice <> -999999 Then
                        BasePrice = onPrice
                    Else
                        itmerr += Itm + vbCrLf
                        'MsgBox("Base Price not found for " + Itm + ".  Not able to continue price calculation.", MsgBoxStyle.Critical, "Base Price?")
                        cnn2.Close()
                        Exit Function
                    End If
                Else
                    itmerr += Itm + vbCrLf
                    'MsgBox("Base Price not found for " + Itm + ".  Not able to continue price calculation.", MsgBoxStyle.Critical, "Base Price?")
                    cnn2.Close()
                    Exit Function
                End If
            End If

            If SalesCat = "Base" Then
                GetItemPrice2 = onPrice
                cnn2.Close()
                Exit Function
            End If

            cmd.CommandText = "select cust_itm_price_price from cust_itm_price " + _
            "where cust_itm_price_itm_code='" + Itm + "' and cust_itm_price_cust_serial=" + CStr(onCust) + " " + _
            "and cust_itm_price_from<=" + CStr(Qty) + " and cust_itm_price_to>=" + CStr(Qty) + " " + _
            "and cust_itm_price_start<='" + Format(onDate, "MM/dd/yy") + "' and cust_itm_price_end>='" + Format(onDate, "MM/dd/yy") + "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                onPrice = nz(dr.Item(0), 0)
                dr.Close()
            Else
                Dim ProdType As String = ""
                dr.Close()
                cmd.CommandText = "select itm_prod_type from itm_file where itm_code='" + Itm + "'"
                dr = cmd.ExecuteReader
                If Not dr.HasRows Then
                    MsgBox("Product Type NOT FOUND for item " + Itm + ".  Pricing not able to calculate.")
                    dr.Close()
                    Exit Function
                Else
                    dr.Read()
                    ProdType = nz(dr.Item(0), "")
                    dr.Close()
                    cmd.CommandText = "select cust_prod_mar_margin from cust_prod_mar where cust_prod_mar_type='" + ProdType + "' and " + _
                    "cust_prod_mar_cust_serial=" + CStr(onCust) + " and cust_prod_mar_from<=" + CStr(Qty) + " and cust_prod_mar_to>=" + CStr(Qty) + " and " + _
                    "cust_prod_mar_start<='" + Format(onDate, "MM/dd/yy") + "' and cust_prod_mar_end>='" + Format(onDate, "MM/dd/yy") + "'"
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        onPrice = nz(dr.Item(0), 0)
                        dr.Close()
                        onPrice = BasePrice * onPrice
                    Else
                        dr.Close()
                        cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_type='" + SalesCat + "' " + _
                        "and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + Format(onDate, "MM/dd/yy") + "' " + _
                        "and itm_price_end>='" + Format(onDate, "MM/dd/yy") + "'"
                        dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            dr.Read()
                            onPrice = nz(dr.Item(0), 0)
                            dr.Close()
                        Else
                            dr.Close()
                            cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + ProdType + "' and " + _
                            "sales_cat_prod_mar_cat='" + ProdType + "' and sales_cat_prod_mar_from<=" + CStr(Qty) + " and sales_cat_prod_mar_to>=" + CStr(Qty) + " " + _
                            "and sales_cat_prod_mar_start<='" + Format(onDate, "MM/dd/yy") + "' and sales_cat_prod_mar_end>='" + Format(onDate, "MM/dd/yy") + "'"
                            dr = cmd.ExecuteReader
                            If dr.HasRows Then
                                dr.Read()
                                onPrice = nz(dr.Item(0), 0)
                                dr.Close()
                                onPrice = BasePrice * onPrice
                            Else
                                onPrice = BasePrice
                                dr.Close()
                            End If
                        End If
                    End If
                End If
            End If
            onPrice = Math.Round(onPrice + 0.00001, 2)

            cmd.CommandText = "select itm_surcharge from itm_file where itm_code='" + Itm + "'"
            If cmd.ExecuteScalar = True Then
                Dim rate As Double
                cmd.CommandText = "select itm_surcharge_rate from itm_surcharge where itm_surcharge_from<=" + CStr(Qty) + " and itm_surcharge_to>=" + CStr(Qty)
                rate = nz(cmd.ExecuteScalar, 0)
                If rate <> 0 Then onPrice = onPrice * rate
            End If
            onPrice = Math.Round(onPrice + 0.00001, 2)

            'If row Is Nothing Then
            '    If cb5Perc.Checked = True And (nz(tProdType.Value, "") = "TOP" Or nz(tProdType.Value, "") = "BUD" Or nz(tProdType.Value, "") = "GOLD") And Mid(Tab1.ActiveTab.Key, 1, 1) = "O" Then
            '        tDisc.Value = Math.Round((onPrice * Qty * 0.05) + 0.00001, 2)
            '    End If
            'Else
            '    If cb5Perc.Checked = True And (nz(row("ord_itm_prod_type"), "") = "TOP" Or nz(row("ord_itm_prod_type"), "") = "BUD" Or nz(row("ord_itm_prod_type"), "") = "GOLD") And Mid(Tab1.ActiveTab.Key, 1, 1) = "O" Then
            '        row("ord_itm_disc") = Math.Round((onPrice * Qty * 0.05 * -1) + 0.00001, 2)
            '    End If
            'End If

            'cnn2.Close()
            GetItemPrice2 = onPrice
        Catch
            DoError(Err, MainForm)
        End Try
    End Function

    Public Function AddToDo(ByVal Type As String, ByVal Who As String, ByVal Note As String, Optional ByVal Ord As Long = -1, Optional ByVal Rev As Integer = -1, Optional ByVal OrdType As String = "", Optional ByVal WhoNext As String = "", Optional ByVal Button As String = "", Optional ByVal ButtonType As String = "", Optional ByVal MiscText As String = "", Optional ByVal MiscNum As Double = 0, Optional ByVal PopUp As Boolean = False) As Long
        Dim cnnx As New SqlConnection(cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'")
        Dim cmd As New SqlCommand("", cnnx)
        Dim sqlx As String
        Dim onToDo As Long

        cnnx.Open()
        Select Case Type
            Case "REF"
                'If Ord = -1 Then
                '    onToDo = -1
                'Else
                '    cmd.CommandText = "select to_do_serial from to_do where to_do_ord_serial=" + CStr(Ord) + " and to_do_ord_rev=" + CStr(Rev) + " and to_do_ord_type='" + OrdType + "' and to_do_complete=0 and to_do_type='REF'"
                '    onToDo = nz(cmd.ExecuteScalar, -1)
                'End If
                'If onToDo = -1 Then
                If MiscNum <> 0 Then
                    cmd.CommandText = "insert into to_do (to_do_user,to_do_ord_serial,to_do_ord_rev,to_do_ord_type,to_do_note,to_do_created,to_do_created_by,to_do_complete,to_do_next_user,to_do_type,to_do_button,to_do_button_type,to_do_misc_text,to_do_misc_num) values ('" + Who + "'," + CStr(Ord) + "," + CStr(Rev) + ",'" + OrdType + "','" + Replace(Note, "'", "''") + "','" + CStr(Now) + "','" + User + "',0,'" + WhoNext + "','REF','" + Button + "','" + ButtonType + "','" + MiscText + "'," + CStr(MiscNum) + ")"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "select @@identity"
                    AddToDo = cmd.ExecuteScalar
                End If
                'Else
                '    cmd.CommandText = "update to_do set to_do_note='" + Note + "' where to_do_serial=" + CStr(onToDo)
                '    cmd.ExecuteNonQuery()
                '    AddToDo = onToDo
                'End If
            Case "SHIP"
                cmd.CommandText = "select rep_ship_notify from rep_file where rep_code='" + Who + "'"
                If nz(cmd.ExecuteScalar, False) = True Then
                    If Ord = -1 Then
                        onToDo = -1
                    Else
                        If MiscText = "Ship Delete" Then
                            onToDo = -1
                        Else
                            cmd.CommandText = "select to_do_serial from to_do where to_do_ord_serial=" + CStr(Ord) + " and to_do_ord_rev=" + CStr(Rev) + " and to_do_ord_type='" + OrdType + "' and to_do_type='SHIP'"
                            onToDo = nz(cmd.ExecuteScalar, -1)
                        End If
                    End If
                    If onToDo = -1 Then
                        cmd.CommandText = "insert into to_do (to_do_user,to_do_ord_serial,to_do_ord_rev,to_do_ord_type,to_do_note,to_do_created,to_do_created_by,to_do_complete,to_do_next_user,to_do_type,to_do_button,to_do_button_type,to_do_misc_text,to_do_misc_num) values ('" + Who + "'," + CStr(Ord) + "," + CStr(Rev) + ",'" + OrdType + "','" + Replace(Note, "'", "''") + "','" + CStr(Now) + "','" + User + "',0,'" + WhoNext + "','SHIP','" + Button + "','" + ButtonType + "','" + MiscText + "'," + CStr(MiscNum) + ")"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "select @@identity"
                        AddToDo = cmd.ExecuteScalar
                    Else
                        cmd.CommandText = "update to_do set to_do_note='" + Replace(Note, "'", "''") + "' where to_do_serial=" + CStr(onToDo)
                        cmd.ExecuteNonQuery()
                        AddToDo = onToDo
                    End If
                End If
            Case "TAX"
                ' Turned off for now per Todd 1/22/2008
                'If Ord = -1 Then
                '    onToDo = -1
                'Else
                '    cmd.CommandText = "select to_do_serial from to_do where to_do_ord_serial=" + CStr(Ord) + " and to_do_type='TAX' and to_do_user='" + Who + "'"
                '    onToDo = nz(cmd.ExecuteScalar, -1)
                'End If
                'If onToDo = -1 Then
                '    cmd.CommandText = "insert into to_do (to_do_user,to_do_ord_serial,to_do_note,to_do_created,to_do_created_by,to_do_complete,to_do_next_user,to_do_type,to_do_button,to_do_button_type,to_do_misc_text,to_do_misc_num) values ('" + Who + "'," + CStr(Ord) + ",'" + Replace(Note, "'", "''") + "','" + CStr(Now) + "','" + User + "',0,'" + WhoNext + "','TAX','" + Button + "','" + ButtonType + "','" + MiscText + "'," + CStr(MiscNum) + ")"
                '    cmd.ExecuteNonQuery()
                '    cmd.CommandText = "select @@identity"
                '    AddToDo = cmd.ExecuteScalar
                'Else
                '    cmd.CommandText = "update to_do set to_do_note='" + Replace(Note, "'", "''") + "' where to_do_serial=" + CStr(onToDo)
                '    cmd.ExecuteNonQuery()
                '    AddToDo = onToDo
                'End If
            Case "TAX-NOTIFY"
                If Ord = -1 Then
                    onToDo = -1
                Else
                    cmd.CommandText = "select to_do_serial from to_do where to_do_ord_serial=" + CStr(Ord) + " and to_do_type='TAX-NOTIFY' and to_do_user='" + Who + "' and to_do_complete=0"
                    onToDo = nz(cmd.ExecuteScalar, -1)
                End If
                If onToDo = -1 Then
                    cmd.CommandText = "insert into to_do (to_do_user,to_do_ord_serial,to_do_note,to_do_created,to_do_created_by,to_do_complete,to_do_next_user,to_do_type,to_do_button,to_do_button_type,to_do_misc_text,to_do_misc_num) values ('" + Who + "'," + CStr(Ord) + ",'" + Replace(Note, "'", "''") + "','" + CStr(Now) + "','" + User + "',0,'" + WhoNext + "','TAX-NOTIFY','" + Button + "','" + ButtonType + "','" + MiscText + "'," + CStr(MiscNum) + ")"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "select @@identity"
                    AddToDo = cmd.ExecuteScalar
                Else
                    cmd.CommandText = "update to_do set to_do_note='" + Replace(Note, "'", "''") + "' where to_do_serial=" + CStr(onToDo)
                    cmd.ExecuteNonQuery()
                    AddToDo = onToDo
                End If
            Case "REFERRAL"
                If Ord = -1 Then
                    onToDo = -1
                Else
                    cmd.CommandText = "select to_do_serial from to_do where to_do_ord_serial=" + CStr(Ord) + " and to_do_type='REFERRAL'"
                    onToDo = nz(cmd.ExecuteScalar, -1)
                End If
                If onToDo = -1 Then
                    cmd.CommandText = "insert into to_do (to_do_user,to_do_ord_serial,to_do_note,to_do_created,to_do_created_by,to_do_complete,to_do_next_user,to_do_type,to_do_button,to_do_button_type,to_do_misc_text,to_do_misc_num) values ('" + Who + "'," + CStr(Ord) + ",'" + Replace(Note, "'", "''") + "','" + CStr(Now) + "','" + User + "',0,'" + WhoNext + "','REFERRAL','" + Button + "','" + ButtonType + "','" + MiscText + "'," + CStr(MiscNum) + ")"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "select @@identity"
                    AddToDo = cmd.ExecuteScalar
                Else
                    cmd.CommandText = "update to_do set to_do_note='" + Replace(Note, "'", "''") + "' where to_do_serial=" + CStr(onToDo)
                    cmd.ExecuteNonQuery()
                    AddToDo = onToDo
                End If
            Case "ART-ALLCLEAR"
                If Ord = -1 Then
                    onToDo = -1
                Else
                    cmd.CommandText = "select to_do_serial from to_do where to_do_ord_serial=" + CStr(Ord) + " and to_do_ord_rev=" + CStr(Rev) + " and to_do_ord_type='" + OrdType + "' and to_do_type='ART-ALLCLEAR'"
                    onToDo = nz(cmd.ExecuteScalar, -1)
                End If
                If onToDo = -1 Then
                    cmd.CommandText = "insert into to_do (to_do_user,to_do_ord_serial,to_do_ord_rev,to_do_ord_type,to_do_note,to_do_created,to_do_created_by,to_do_complete,to_do_next_user,to_do_type,to_do_button,to_do_button_type,to_do_misc_text,to_do_misc_num) values ('" + Who + "'," + CStr(Ord) + "," + CStr(Rev) + ",'" + OrdType + "','" + Replace(Note, "'", "''") + "','" + CStr(Now) + "','" + User + "',0,'" + WhoNext + "','ART-ALLCLEAR','" + Button + "','" + ButtonType + "','" + MiscText + "'," + CStr(MiscNum) + ")"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "select @@identity"
                    AddToDo = cmd.ExecuteScalar
                Else
                    cmd.CommandText = "update to_do set to_do_note='" + Replace(Note, "'", "''") + "' where to_do_serial=" + CStr(onToDo)
                    cmd.ExecuteNonQuery()
                    AddToDo = onToDo
                End If
            Case "GEN"
            Case "OrdMod", "ShipMod"
                If Who <> "MELISSAB" Then
                    cmd.CommandText = "insert into to_do (to_do_user,to_do_ord_serial,to_do_ord_rev,to_do_ord_type,to_do_note,to_do_created,to_do_created_by,to_do_complete,to_do_next_user,to_do_type,to_do_button,to_do_button_type,to_do_misc_text,to_do_misc_num,to_do_popup) values ('" + Who + "'," + CStr(Ord) + "," + CStr(Rev) + ",'" + OrdType + "','" + Replace(Note, "'", "''") + "','" + CStr(Now) + "','" + User + "',0,'" + WhoNext + "','" + Type + "','" + Button + "','" + ButtonType + "','" + MiscText + "'," + CStr(MiscNum) + "," + IIf(PopUp, "1", "0") + ")"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "select @@identity"
                    AddToDo = cmd.ExecuteScalar
                End If
            Case "Call"
                cmd.CommandText = "select to_do_serial from to_do where to_do_ord_serial=" + CStr(Ord) + " and to_do_type='Call'"
                onToDo = nz(cmd.ExecuteScalar, -1)
                If onToDo = -1 Then
                    cmd.CommandText = "insert into to_do (to_do_user,to_do_ord_serial,to_do_note,to_do_created,to_do_created_by,to_do_complete,to_do_next_user,to_do_type,to_do_button,to_do_button_type,to_do_misc_text,to_do_misc_num) values ('" + Who + "'," + CStr(Ord) + ",'" + Replace(Note, "'", "''") + "','" + CStr(Now) + "','" + User + "',0,'" + WhoNext + "','Call','" + Button + "','" + ButtonType + "','" + MiscText + "'," + CStr(MiscNum) + ")"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "select @@identity"
                    AddToDo = cmd.ExecuteScalar
                Else
                    cmd.CommandText = "update to_do set to_do_user='" + Who + "',to_do_note='" + Replace(Note, "'", "''") + "',to_do_complete=0 where to_do_serial=" + CStr(onToDo)
                    cmd.ExecuteNonQuery()
                    AddToDo = onToDo
                End If

        End Select
        cnnx.Close()
    End Function
    Public Sub CheckReferral(ByVal Ord As Long, ByVal Rev As Integer, ByVal Type As String, Optional ByVal PayType As String = "", Optional ByVal PaySerial As Long = 0)
        Try
            Dim cnnx As New SqlConnection(cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'")
            Dim cmd As New SqlCommand("select ord_ref_perc from ord_file where ord_serial=" + CStr(Ord), cnnx)
            Dim dr As DataRow
            Dim onPerc As Double
            Dim PayOnRecpt As Boolean
            Dim RefFeeTotal, PaidAmt, PaidSoFar, MaxPay, DontPayAmt As Double
            Dim dsOrdGen As New DataSet
            Dim da As New SqlDataAdapter(cmd)

            PaidSoFar = RefPaid(Ord, Rev, True)
            cnnx.Open()
            onPerc = nz(cmd.ExecuteScalar, 0)
            If onPerc = 0 Then
                cnnx.Close()
                Exit Sub
            End If

            cmd.CommandText = "select ref_pay_on_recpt from ord_file left outer join ref_file on ord_ref_serial=ref_serial where ord_serial=" + CStr(Ord)
            PayOnRecpt = nz(cmd.ExecuteScalar, 0)
            'cmd.CommandText = "select sum(to_do_misc_num) from to_do where to_do_ord_serial=" + CStr(Ord) + " and to_do_ord_rev=" + CStr(Rev) + " and to_do_ord_type='" + Type + "' and to_do_complete=0"
            'AmtOnToDo = nz(cmd.ExecuteScalar, 0)

            cmd.CommandText = "select * from ord_gen where ord_gen_ord_serial=" + CStr(Ord) + " and ord_gen_rev=" + CStr(Rev) + " and ord_gen_type='" + Type + "'"
            da.Fill(dsOrdGen)
            If dsOrdGen.Tables(0).Rows.Count > 0 Then
                dr = dsOrdGen.Tables(0).Rows(0)
                'If (dr("ord_gen_status") = "SHIPPED" And dr("ord_gen_ship_date") <> Today) Or dr("ord_gen_status") = "CANCELED" Then
                '    cnnx.Close()
                '    Exit Sub
                'End If
                If PayOnRecpt Then
                    cmd.CommandText = "select sum(pay_itm_amt) as amt from pay_itm,pay_file,meth_file where pay_itm_pay_serial=pay_serial and pay_method=meth_type and pay_date>='1/1/2007' and meth_pay_referral=1 and pay_itm_ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                Else
                    cmd.CommandText = "select sum(pay_itm_amt) as amt from pay_itm,pay_file,meth_file where pay_itm_pay_serial=pay_serial and pay_method=meth_type and meth_pay_referral=1 and pay_itm_ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                End If
                PaidAmt = nz(cmd.ExecuteScalar, 0)
                'If PaidAmt <> 0 Then  '* Remmed out on 9/23/2008 to account for Balance Transfer zeroing out PaidAmt -jpj
                If PayOnRecpt Then
                    cmd.CommandText = "select sum(pay_itm_amt) as amt from pay_itm,pay_file,meth_file where pay_itm_pay_serial=pay_serial and pay_method=meth_type and pay_date>='1/1/2007' and meth_pay_referral=0 and pay_itm_ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                Else
                    cmd.CommandText = "select sum(pay_itm_amt) as amt from pay_itm,pay_file,meth_file where pay_itm_pay_serial=pay_serial and pay_method=meth_type and meth_pay_referral=0 and pay_itm_ord_gen_serial=" + CStr(dr("ord_gen_serial"))
                End If
                DontPayAmt = nz(cmd.ExecuteScalar, 0)

                If PaidAmt < 0 Then PaidAmt = 0
                RefFeeTotal = Math.Round(PaidAmt * onPerc / 100, 2)
                MaxPay = Math.Round((dr("ord_gen_line_total") - Math.Abs(DontPayAmt)) * onPerc / 100, 2)
                If RefFeeTotal > MaxPay Then RefFeeTotal = MaxPay
                If PayOnRecpt Then
                    'RefFeeOwed = Math.Round(dr("ord_gen_line_total") * (dr("ord_gen_total") - dr("ord_gen_balance")) / dr("ord_gen_total") * onPerc / 100, 2)
                    If Math.Round((RefFeeTotal - PaidSoFar), 2) <> 0 And (dr("ord_gen_total") <> 0) Then
                        If PayType = "Balance Transfer" Then
                            UpdateRefLedger(Ord, Rev, Type, "APPROVED", PaySerial, Math.Round(RefFeeTotal - PaidSoFar, 2))
                        Else
                            AddToDo("REF", dr("ord_gen_inside"), "Pay referral fee on this order for " + FormatCurrency(Math.Round(RefFeeTotal - PaidSoFar, 2)), dr("ord_gen_ord_serial"), dr("ord_gen_rev"), "O", "CLAREC", CStr(dr("ord_gen_ord_serial")) + "-" + CStr(dr("ord_gen_from_rev")) + "-" + CStr(dr("ord_gen_rev")), "Order", , Math.Round(RefFeeTotal - PaidSoFar, 2))
                        End If
                    End If
                Else
                    If Math.Round((RefFeeTotal - PaidSoFar), 2) <> 0 And (dr("ord_gen_total") <> 0) And (dr("ord_gen_balance") = 0) And (dr("ord_gen_status") = "SHIPPED") And dr("ord_gen_ship_date") >= CDate("1/1/2007") Then AddToDo("REF", dr("ord_gen_inside"), "Pay referral fee on this order for " + FormatCurrency(RefFeeTotal - PaidSoFar), dr("ord_gen_ord_serial"), dr("ord_gen_rev"), "O", "CLAREC", CStr(dr("ord_gen_ord_serial")) + "-" + CStr(dr("ord_gen_from_rev")) + "-" + CStr(dr("ord_gen_rev")), "Order", , RefFeeTotal - PaidSoFar)
                End If
            End If
            'End If
            cnnx.Close()
            setMarginFactor(Ord, Rev, Type)
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub
    Public Sub UpdateRefLedger(ByVal Ord As Long, ByVal Rev As Integer, ByVal Type As String, ByVal RefStatus As String, ByVal RefNum As Long, ByVal Amt As Double)
        Dim cmd As New SqlCommand("select ref_ledger_serial from ref_ledger where ref_ledger_ref='" + RefStatus + "' and ref_ledger_refnum=" + CStr(RefNum), cnn2)
        Dim onRef As Long

        cnn2.Open()
        onRef = nz(cmd.ExecuteScalar, -1)

        If onRef > 0 Then
            cmd.CommandText = "update ref_ledger set ref_ledger_amt=" + CStr(Amt) + ",ref_ledger_user='" + User + "',ref_ledger_date='" + CStr(Now) + "' where ref_ledger_serial=" + CStr(onRef)
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = "insert into ref_ledger (ref_ledger_ord_serial,ref_ledger_ord_rev,ref_ledger_ord_type,ref_ledger_ref,ref_ledger_refnum,ref_ledger_amt,ref_ledger_user,ref_ledger_date) values (" + CStr(Ord) + "," + CStr(Rev) + ",'" + Type + "','" + RefStatus + "'," + CStr(RefNum) + "," + CStr(Amt) + ",'" + User + "','" + CStr(Now) + "')"
            cmd.ExecuteNonQuery()
        End If
        cnn2.Close()
    End Sub
    Public Sub setMarginFactor(ByVal Ord As Long, ByVal Rev As Integer, ByVal Type As String)
        Dim cnnx As New SqlConnection(cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'")
        Try
            Dim cmd As New SqlCommand("select ord_gen.*,ord_file.ord_acct_open,ord_file.ord_ref_perc from ord_gen,ord_file where ord_gen_ord_serial=ord_serial and ord_gen_ord_serial=" + CStr(Ord) + " and ord_gen_rev=" + CStr(Rev) + " and ord_gen_type='" + Type + "'", cnnx)
            Dim da As New SqlDataAdapter(cmd)
            Dim dsOrdGen As New DataSet
            Dim dsOrdItm As New DataSet
            Dim row, rw As DataRow
            Dim PaidAmt, RefFee, RefFeeLeft, RefFeeTotal As Double
            Dim PayOnRecpt As Boolean

            cnnx.Open()
            da.Fill(dsOrdGen)

            If dsOrdGen.Tables(0).Rows.Count > 0 Then
                row = dsOrdGen.Tables(0).Rows(0)
                If ((row("ord_gen_type") = "O") And (row("ord_gen_create_date") > AcctClosed)) Or (nz(row("ord_acct_open"), CDate("1/1/1900")) = Today) Or (row("ord_gen_type") = "Q") Then
                    If nz(row("ord_ref_perc"), 0) = 0 Then
                        cmd.CommandText = "update ord_itm set ord_itm_margin_factor=ord_itm_disc_amt where ord_itm_ord_serial=" + CStr(Ord) + " and ord_itm_rev=" + CStr(Rev) + " and ord_itm_type='" + Type + "'"
                        cmd.ExecuteNonQuery()
                    Else
                        cmd.CommandText = "select sum(pay_itm_amt) as amt from pay_itm,pay_file,meth_file where pay_itm_pay_serial=pay_serial and pay_method=meth_type and pay_itm_ord_gen_serial=" + CStr(row("ord_gen_serial"))
                        PaidAmt = nz(cmd.ExecuteScalar, 0) - row("ord_gen_ship") - row("ord_gen_tax")
                        cmd.CommandText = "select ref_pay_on_recpt from ord_file left outer join ref_file on ord_ref_name=ref_name where ord_serial=" + CStr(Ord)
                        PayOnRecpt = nz(cmd.ExecuteScalar, False)

                        If PaidAmt <= 0 Then
                            cmd.CommandText = "update ord_itm set ord_itm_margin_factor=ord_itm_disc_amt where ord_itm_ord_serial=" + CStr(Ord) + " and ord_itm_rev=" + CStr(Rev) + " and ord_itm_type='" + Type + "'"
                            cmd.ExecuteNonQuery()
                        Else
                            If (row("ord_gen_type") = "O" And row("ord_gen_status") = "SHIPPED") Or PayOnRecpt Then
                                RefFeeTotal = Math.Round(PaidAmt * row("ord_ref_perc") / 100, 2)
                                cmd.CommandText = "update ord_gen set ord_gen_ref_fee=" + CStr(RefFeeTotal) + " where ord_gen_serial=" + CStr(row("ord_gen_serial"))
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "select * from ord_itm where ord_itm_ord_serial=" + CStr(Ord) + " and ord_itm_rev=" + CStr(Rev) + " and ord_itm_type='" + Type + "'"
                                da.Fill(dsOrdItm)

                                RefFeeLeft = RefFeeTotal
                                For Each rw In dsOrdItm.Tables(0).Rows
                                    If (rw("ord_itm_is_disc") Or rw("ord_itm_is_up")) = False Then
                                        If RefFeeTotal = 0 Then
                                            RefFee = 0
                                        Else
                                            RefFee = Math.Round((((rw("ord_itm_qty") * rw("ord_itm_unt_sell")) + rw("ord_itm_disc_amt")) / row("ord_gen_line_total")) * RefFeeTotal, 2)
                                        End If
                                        cmd.CommandText = "update ord_itm set ord_itm_margin_factor=ord_itm_disc_amt - " + CStr(RefFee) + " where ord_itm_serial=" + CStr(rw("ord_itm_serial"))
                                        cmd.ExecuteNonQuery()
                                        RefFeeLeft = Math.Round(RefFeeLeft - RefFee, 2)
                                    Else
                                        cmd.CommandText = "update ord_itm set ord_itm_margin_factor=ord_itm_disc_amt where ord_itm_serial=" + CStr(rw("ord_itm_serial"))
                                        cmd.ExecuteNonQuery()
                                    End If
                                Next
                                If RefFeeLeft <> 0 Then
                                    For Each rw In dsOrdItm.Tables(0).Rows
                                        If (rw("ord_itm_is_disc") Or rw("ord_itm_is_up")) = False Then
                                            cmd.CommandText = "update ord_itm set ord_itm_margin_factor=ord_itm_margin_factor - " + CStr(RefFeeLeft) + " where ord_itm_serial=" + CStr(rw("ord_itm_serial"))
                                            cmd.ExecuteNonQuery()
                                            Exit For
                                        End If
                                    Next
                                End If
                            Else
                                cmd.CommandText = "update ord_itm set ord_itm_margin_factor=ord_itm_disc_amt where ord_itm_ord_serial=" + CStr(Ord) + " and ord_itm_rev=" + CStr(Rev) + " and ord_itm_type='" + Type + "'"
                                cmd.ExecuteNonQuery()
                            End If
                        End If
                    End If
                End If
            End If
        Catch
            DoError(Err, MainForm)
        Finally
            If cnnx.State <> ConnectionState.Closed Then cnnx.Close()
        End Try

    End Sub
    Public Function MakeNumeric(ByVal Str As String) As String
        Dim x As Integer

        MakeNumeric = ""
        For x = 0 To Len(Str) - 1
            If IsNumeric(Str.Chars(x)) Then MakeNumeric += Str.Chars(x)
        Next
    End Function
    Private Function RefPaid(ByVal Ord As Long, ByVal Rev As Integer, ByVal IncludeSubmitted As Boolean) As Double
        Dim cnnx As New SqlConnection(cnn.ConnectionString + ";password='JGMn4wbhnHL9s3be'")
        Dim cmd As New SqlCommand("select sum(ref_ledger_amt) as amt from ref_ledger where ref_ledger_ord_serial=" + CStr(Ord) + " and ref_ledger_ord_rev=" + CStr(Rev) + " and ref_ledger_ord_type='O' and ((ref_ledger_ref='APPROVED'))", cnnx)
        cnnx.Open()
        RefPaid = nz(cmd.ExecuteScalar, 0)
        If IncludeSubmitted = True Then
            cmd.CommandText = "select sum(to_do_misc_num) as amt from to_do where to_do_ord_serial=" + CStr(Ord) + " and to_do_ord_rev=" + CStr(Rev) + " and to_do_ord_type='O' and isnull(to_do_complete,0)=0"
            RefPaid += nz(cmd.ExecuteScalar, 0)
        End If
        cmd.CommandText = "select sum(ref_ledger_amt) as amt from ref_ledger where ref_ledger_ord_serial=" + CStr(Ord) + " and ref_ledger_ord_rev=" + CStr(Rev) + " and ref_ledger_ord_type='O' and ref_ledger_ref='ADJUST'"
        RefPaid -= nz(cmd.ExecuteScalar, 0)
        cnnx.Close()
    End Function
    Public Sub SendMail(ByVal Tox As String, ByVal From As String, ByVal Subj As String, ByVal Body As String, Optional ByVal Attachments As String = "", Optional ByVal BCC As String = "")
        Try
            Dim email As New System.Net.Mail.MailMessage
            Dim smtp As New SmtpClient("relay.appriver.com")
            smtp.Port = 2525
            Dim at As String

            email.To.Add(Tox)
            email.From = New MailAddress(From)
            email.Bcc.Add(BCC)
            email.Subject = Subj
            email.Body = Body
            If Attachments <> "" Then
                For Each at In Split(Attachments, ";")
                    email.Attachments.Add(New System.Net.Mail.Attachment(at))
                Next
            End If
            smtp.Send(email)
        Catch
            DoError(Err, MainForm)
        End Try

    End Sub
    Public Function GetItemPriceNew(ByVal Itm As String, ByVal Qty As Integer, ByVal SalesCat As String, ByVal Material As String, Optional ByVal CustSerial As Long = 0, Optional ByVal MPF As Double = 1, Optional ByVal onDate As Date = #1/1/1900#) As Double
        Try
            Dim Start As Date = Now
            Dim cmd As New SqlCommand("", cnn)
            Dim dsItem As New DataSet
            Dim daItem As New SqlDataAdapter(cmd)
            Dim Base, Price As Double
            Dim dr As SqlDataReader
            Dim BasePrice As Double = 0
            Dim WoodFactor, MatFactor As Double
            Dim ProdType As String = ""
            Dim FlatRate As Boolean = False
            Dim SelMaterial As Boolean
            Dim PriceType As String
            Dim SurCharge As Boolean

            If Qty = 0 Then Qty = 1
            Price = 0
            If onDate = #1/1/1900# Then onDate = Date.Today
            onDate = onDate.ToShortDateString

            cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + CStr(onDate) + "' and itm_price_end>='" + CStr(onDate) + "' and itm_price_type='Base'"
            Price = nz(cmd.ExecuteScalar, -999999)
            If Price = -1 Then
                cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + CStr(Today) + "' and itm_price_end>='" + CStr(Today) + "' and itm_price_type='Base'"
                Price = nz(cmd.ExecuteScalar, -1)
                If Price <> -1 Then onDate = Today
            End If
            Price = Math.Round(Price * MPF, 2)

            cmd.CommandText = "select itm_prod_type,itm_material_sel,itm_wood_factor,itm_flat_rate,itm_surcharge from itm_file where itm_code='" + Itm + "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                ProdType = dr("itm_prod_type")
                SelMaterial = dr("itm_material_sel")
                WoodFactor = dr("itm_wood_factor")
                FlatRate = dr("itm_flat_rate")
                SurCharge = dr("itm_surcharge")
            Else
                ProdType = ""
                SelMaterial = False
                WoodFactor = 0
                FlatRate = False
                SurCharge = False
            End If
            dr.Close()

            If Price <> -999999 Then
                If SelMaterial = True Then
                    Select Case ProdType
                        Case "BUD"
                            cmd.CommandText = "select mat_fac_bud from mat_fac where mat_fac_mat_code='" + Material + "' and mat_fac_start<='" + onDate + "' and mat_fac_end>='" + onDate + "'"
                            MatFactor = nz(cmd.ExecuteScalar, 0)
                        Case Else
                            cmd.CommandText = "select mat_fac_top from mat_fac where mat_fac_mat_code='" + Material + "' and mat_fac_start<='" + onDate + "' and mat_fac_end>='" + onDate + "'"
                            MatFactor = nz(cmd.ExecuteScalar, 0)
                    End Select
                Else
                    MatFactor = 0
                    WoodFactor = 0
                End If

                BasePrice = Price
            Else
                'MsgBox("Base Price not found for " + Itm + ".  Not able to continue price calculation.", MsgBoxStyle.Critical, "Base Price?")
                GetItemPriceNew = -3
                Exit Function
            End If

            If CustSerial > 0 Then
                cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_itm_code='" + Itm + "' and cust_itm_price_cust_serial=" + CStr(CustSerial) + " and cust_itm_price_from<=" + CStr(Qty) + " and cust_itm_price_to>=" + CStr(Qty) + " and cust_itm_price_start<='" + CStr(onDate) + "' and cust_itm_price_end>='" + CStr(onDate) + "'"
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    Price = dr("cust_itm_price_price")
                    Price = Price * (1 + (WoodFactor * MatFactor))
                    dr.Close()
                    PriceType = "Customer Item Price"
                Else
                    dr.Close()
                    If FlatRate Then
                        Price = BasePrice
                        PriceType = "Flat Rate"
                        Exit Function
                    Else
                        cmd.CommandText = "select cust_prod_mar_margin from cust_prod_mar where cust_prod_mar_type='" + ProdType + "' and cust_prod_mar_cust_serial=" + CStr(CustSerial) + " and cust_prod_mar_from<=" + CStr(Qty) + " and cust_prod_mar_to>=" + CStr(Qty) + " and cust_prod_mar_start<='" + CStr(onDate) + "' and cust_prod_mar_end>='" + CStr(onDate) + "'"
                        dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            dr.Read()
                            Price = dr("cust_prod_mar_margin")
                            dr.Close()
                            Price = BasePrice * Price
                            PriceType = "Customer Product Margin"
                        Else
                            dr.Close()
                            cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_type='" + SalesCat + "' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + CStr(onDate) + "' and itm_price_end>='" + CStr(onDate) + "'"
                            dr = cmd.ExecuteReader
                            If dr.HasRows Then
                                dr.Read()
                                Price = dr("itm_price_price")
                                Price = Price * (1 + (WoodFactor * MatFactor))
                                dr.Close()
                                PriceType = "Sales Category Item Price"
                            Else
                                dr.Close()
                                cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + ProdType + "' and sales_cat_prod_mar_cat='" + SalesCat + "' and sales_cat_prod_mar_from<=" + CStr(Qty) + " and sales_cat_prod_mar_to>=" + CStr(Qty) + " and sales_cat_prod_mar_start<='" + CStr(onDate) + "' and sales_cat_prod_mar_end>='" + CStr(onDate) + "'"
                                dr = cmd.ExecuteReader
                                If dr.HasRows Then
                                    dr.Read()
                                    Price = dr("sales_cat_prod_mar_mar")
                                    dr.Close()
                                    Price = BasePrice * Price
                                    PriceType = "Sales Category Product Type"
                                Else
                                    Price = BasePrice
                                    PriceType = "Base Price Method"
                                    dr.Close()
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                If FlatRate Then
                    Price = BasePrice
                    PriceType = "Flat Rate"
                    GetItemPriceNew = Price
                    Exit Function
                Else
                    cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_type='" + SalesCat + "' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + CStr(onDate) + "' and itm_price_end>='" + CStr(onDate) + "'"
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        Price = dr("itm_price_price")
                        Price = Price * (1 + (WoodFactor * MatFactor))
                        dr.Close()
                        PriceType = "Sales Category Item Price"
                    Else
                        dr.Close()
                        cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + ProdType + "' and sales_cat_prod_mar_cat='" + SalesCat + "' and sales_cat_prod_mar_from<=" + CStr(Qty) + " and sales_cat_prod_mar_to>=" + CStr(Qty) + " and sales_cat_prod_mar_start<='" + CStr(onDate) + "' and sales_cat_prod_mar_end>='" + CStr(onDate) + "'"
                        dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            dr.Read()
                            Price = dr("sales_cat_prod_mar_mar")
                            dr.Close()
                            Price = BasePrice * Price
                            PriceType = "Sales Category Product Type"
                        Else
                            Price = BasePrice
                            PriceType = "Base Price Method"
                            dr.Close()
                        End If
                    End If
                End If
            End If
            Price = Math.Round(Price + 0.00001, 2)

            If SurCharge = True Then
                Dim rate As Double
                cmd.CommandText = "select itm_surcharge_rate from itm_surcharge where itm_surcharge_from<=" + CStr(Qty) + " and itm_surcharge_to>=" + CStr(Qty)
                rate = cmd.ExecuteScalar
                If rate <> 0 Then Price = Math.Round(Price * rate, 2)
            End If
            GetItemPriceNew = Price
            Dim mil As System.TimeSpan = Now.Subtract(Start)
            cmd.CommandText = "insert into tmp_mil (tmp_itm_code,tmp_milsec) values ('" + Itm + "'," + CStr(mil.Milliseconds) + ")"
            cmd.ExecuteNonQuery()
        Catch
            DoError(Err, MainForm)
        End Try
    End Function
    Public Function Days(ByVal dt As Date) As Integer
        Days = Microsoft.VisualBasic.Day(DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Month, 1, DateAdd(DateInterval.Day, (-1 * Microsoft.VisualBasic.Day(Today)) + 1, Today)))))
    End Function
    Public Sub jBindFields(ByVal cts As Control.ControlCollection, ByVal rw As DataRow, Optional ByVal NumberDefaultToZero As Boolean = True)
        Dim ct As Control
        Dim fStat, fField, fType As String
        Dim dd As Infragistics.Win.UltraWinGrid.UltraCombo
        Dim chbox As Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Dim op As Infragistics.Win.UltraWinEditors.UltraOptionSet
        For Each ct In cts
            GetTag(ct.Tag, fStat, fField, fType)
            If fStat = "EDIT" Then
                Select Case fType
                    Case "TX"
                        ct.Text = nz(rw(fField), "")
                    Case "DD"
                        dd = ct
                        dd.Value = nz(rw(fField), "")
                    Case "OP"
                        op = ct
                        op.Value = nz(rw(fField), "")
                    Case "CB"
                        chbox = ct
                        chbox.Checked = nz(rw(fField), False)
                    Case "NM"
                        ct.Text = nz(rw(fField), IIf(NumberDefaultToZero, "0", ""))
                    Case "CU"
                        ct.Text = nz(rw(fField), IIf(NumberDefaultToZero, "0", ""))
                        If ct.Text <> "" And IsNumeric(ct.Text) Then ct.Text = FormatCurrency(CDbl(ct.Text))
                End Select
            End If
            If ct.Controls.Count > 0 Then jBindFields(ct.Controls, rw)
        Next
    End Sub
    Public Sub jSaveFields(ByVal cts As Control.ControlCollection, ByRef rw As DataRow)
        Dim ct As Control
        Dim fStat, fField, fType As String
        Dim dd As Infragistics.Win.UltraWinGrid.UltraCombo
        Dim chbox As Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Dim op As Infragistics.Win.UltraWinEditors.UltraOptionSet

        For Each ct In cts
            GetTag(ct.Tag, fStat, fField, fType)
            If fStat = "EDIT" Then
                Select Case fType
                    Case "TX"
                        rw(fField) = ct.Text
                    Case "DD"
                        dd = ct
                        rw(fField) = dd.Value
                    Case "OP"
                        op = ct
                        rw(fField) = op.Value
                    Case "CB"
                        chbox = ct
                        rw(fField) = chbox.Checked
                    Case "NM"
                        rw(fField) = num(ct.Text)
                    Case "CU"
                        rw(fField) = num(ct.Text)
                End Select
            End If
            If ct.Controls.Count > 0 Then jSaveFields(ct.Controls, rw)
        Next

    End Sub
    Public Function num(ByVal x As String) As Double
        If IsNumeric(Replace(x, "$", "")) And x <> "NaN" And x <> "Infinity" Then
            num = CDbl(Replace(x, "$", ""))
        Else
            num = 0
        End If
    End Function
    'Public Function GetPrice(ByVal Part As String, ByVal onDate As Date, ByVal SalesCat As String) As Double

    '    Dim cmd As New SqlCommand("", cnn)
    '    Dim Param As SqlParameter
    '    ' Configure the SqlCommand object
    '    With cmd
    '        .CommandType = CommandType.StoredProcedure      'Set type to StoredProcedure
    '        .CommandText = "GetPrice"                    'Specify stored procedure to run

    '        ' Loop through parmameter collection adding parameters to the command object
    '        Param = New SqlParameter("@Part", Part)
    '        cmd.Parameters.Add(Param)
    '        Param = New SqlParameter("@Date", onDate)
    '        cmd.Parameters.Add(Param)
    '        Param = New SqlParameter("@SalesCat", SalesCat)
    '        cmd.Parameters.Add(Param)

    '    End With

    '    ' Configure Adapter to use newly created command object and fill the dataset.

    '    Return cmd.ExecuteScalar
    'End Function
    Public Function GetPriceNew(ByVal CustID As String, ByVal Itm As String, ByVal Qty As Double, ByVal SalesCat As String, ByRef pType As String, ByVal mType As String, ByVal onDate As Date, Optional ByVal row As DataRow = Nothing, Optional ByVal ForceRetail As Boolean = False) As Double
        Try
            If Qty = 0 Then Qty = 1
            Qty = Math.Abs(Qty)
            Dim cmd As New SqlCommand
            Dim onCust As Long
            Dim dr As SqlDataReader
            Dim BasePrice As Double = 0
            Dim WoodFactor, MatFactor As Double
            Dim ProdType As String = ""
            'Dim SelMaterial As Boolean = False
            Dim FlatRate As Boolean = False

            'CheckMaterialSel()
            'If row Is Nothing Then
            '    SelMaterial = tMaterial.Enabled 'Or tProdType.Text = "TOP" Or tProdType.Text = "BUD"
            'Else
            '    SelMaterial = row("ord_itm_sel_material") 'Or row("ord_itm_prod_type") = "TOP" Or row("ord_itm_prod_type") = "BUD"
            'End If
            If CustID = "" Then
                onCust = -1
            Else
                onCust = CustID
            End If
            cmd.Connection = cnn2
            cnn2.Open()

            onDate = onDate.ToShortDateString

            cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + CStr(onDate) + "' and itm_price_end>='" + CStr(onDate) + "' and itm_price_type='Base'"
            GetPriceNew = nz(cmd.ExecuteScalar, -1)
            If GetPriceNew = -1 Then
                cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + CStr(Today) + "' and itm_price_end>='" + CStr(Today) + "' and itm_price_type='Base'"
                GetPriceNew = nz(cmd.ExecuteScalar, -999999)
                If GetPriceNew <> -1 Then onDate = Today
            End If
            If row Is Nothing Then
                'GetPriceNew = Math.Round(GetPriceNew * tMPF.Value, 2)
            Else
                GetPriceNew = Math.Round(GetPriceNew * row("ord_itm_mpf"), 2)
            End If

            cmd.CommandText = "select itm_prod_type from itm_file where itm_code='" + Itm + "'"
            ProdType = nz(cmd.ExecuteScalar, "")
            If GetPriceNew <> -999999 Then
                ''******************MPF Old
                'If SelMaterial = True Then
                '    cmd.CommandText = "select itm_wood_factor from itm_file where itm_code='" + Itm + "'"
                '    WoodFactor = nz(cmd.ExecuteScalar, 1)
                '    Select Case ProdType
                '        Case "BUD"
                '            cmd.CommandText = "select mat_fac_bud from mat_fac where mat_fac_mat_code='" + mType + "' and mat_fac_start<='" + CStr(onDate) + "' and mat_fac_end>='" + CStr(onDate) + "'"
                '            MatFactor = nz(cmd.ExecuteScalar, 0)
                '        Case "GOLD"
                '            cmd.CommandText = "select mat_fac_gold from mat_fac where mat_fac_mat_code='" + mType + "' and mat_fac_start<='" + CStr(onDate) + "' and mat_fac_end>='" + CStr(onDate) + "'"
                '            MatFactor = nz(cmd.ExecuteScalar, 0)
                '        Case Else '"TOP"
                '            cmd.CommandText = "select mat_fac_top from mat_fac where mat_fac_mat_code='" + mType + "' and mat_fac_start<='" + CStr(onDate) + "' and mat_fac_end>='" + CStr(onDate) + "'"
                '            MatFactor = nz(cmd.ExecuteScalar, 0)
                '    End Select
                'Else
                '    MatFactor = 0
                'End If
                ''****************

                If row Is Nothing Then
                    'tBase.Value = GetPriceNew
                Else
                    If row("ord_itm_change_base") Then
                        If row("ord_itm_base_price") = 0 Then row("ord_itm_base_price") = GetPriceNew
                    Else
                        row("ord_itm_base_price") = GetPriceNew
                    End If
                End If
                BasePrice = GetPriceNew
            Else
                MsgBox("Base Price not found for " + Itm + ".  Not able to continue price calculation.", MsgBoxStyle.Critical, "Base Price?")
                cnn2.Close()
                Exit Function
            End If
            cmd.CommandText = "select itm_flat_rate from itm_file where itm_code='" + Itm + "'"
            If cmd.ExecuteScalar = True Then
                FlatRate = True
            End If
            pType = ""

            If ForceRetail = False Then
                cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_itm_code='" + Itm + "' and cust_itm_price_cust_serial=" + CStr(onCust) + " and cust_itm_price_from<=" + CStr(Qty) + " and cust_itm_price_to>=" + CStr(Qty) + " and cust_itm_price_start<='" + CStr(onDate) + "' and cust_itm_price_end>='" + CStr(onDate) + "'"
            Else
                cmd.CommandText = "select cust_itm_price_price from cust_itm_price where cust_itm_price_serial=-1"
            End If
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                GetPriceNew = nz(dr.Item(0), 0)
                GetPriceNew = GetPriceNew + (GetPriceNew * WoodFactor * MatFactor)
                dr.Close()
                pType = "Customer Item Price"
            Else
                dr.Close()
                If FlatRate Then
                    GetPriceNew = BasePrice
                    cnn2.Close()
                    pType = "Base Price"
                    Exit Function
                Else
                    cmd.CommandText = "select itm_prod_type from itm_file where itm_code='" + Itm + "'"
                    dr = cmd.ExecuteReader
                    If Not dr.HasRows Then
                        MsgBox("Product Type NOT FOUND for item " + Itm + ".  Pricing not able to calculate.")
                        dr.Close()
                        Exit Function
                    Else
                        dr.Read()
                        ProdType = nz(dr.Item(0), "")
                        dr.Close()
                        If ForceRetail = False Then
                            cmd.CommandText = "select cust_prod_mar_margin from cust_prod_mar where cust_prod_mar_type='" + ProdType + "' and cust_prod_mar_cust_serial=" + CStr(onCust) + " and cust_prod_mar_from<=" + CStr(Qty) + " and cust_prod_mar_to>=" + CStr(Qty) + " and cust_prod_mar_start<='" + CStr(onDate) + "' and cust_prod_mar_end>='" + CStr(onDate) + "'"
                        Else
                            cmd.CommandText = "select cust_prod_mar_margin from cust_prod_mar where cust_prod_mar_serial=-1"
                        End If
                        dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            dr.Read()
                            GetPriceNew = nz(dr.Item(0), 0)
                            dr.Close()
                            GetPriceNew = BasePrice * GetPriceNew
                            pType = "Customer Product Margin"
                        Else
                            dr.Close()
                            If ForceRetail Then
                                cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_type='RET' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + CStr(onDate) + "' and itm_price_end>='" + CStr(onDate) + "'"
                            Else
                                cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + Itm + "' and itm_price_type='" + SalesCat + "' and itm_price_qty_from<=" + CStr(Qty) + " and itm_price_qty_to>=" + CStr(Qty) + " and itm_price_start<='" + CStr(onDate) + "' and itm_price_end>='" + CStr(onDate) + "'"
                            End If
                            dr = cmd.ExecuteReader
                            If dr.HasRows Then
                                dr.Read()
                                GetPriceNew = nz(dr.Item(0), 0)
                                GetPriceNew = GetPriceNew + (GetPriceNew * WoodFactor * MatFactor)
                                dr.Close()
                                pType = "Sales Category Item Price"
                            Else
                                dr.Close()
                                If ForceRetail Then
                                    cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + ProdType + "' and sales_cat_prod_mar_cat='RET' and sales_cat_prod_mar_from<=" + CStr(Qty) + " and sales_cat_prod_mar_to>=" + CStr(Qty) + " and sales_cat_prod_mar_start<='" + CStr(onDate) + "' and sales_cat_prod_mar_end>='" + CStr(onDate) + "'"
                                Else
                                    cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + ProdType + "' and sales_cat_prod_mar_cat='" + SalesCat + "' and sales_cat_prod_mar_from<=" + CStr(Qty) + " and sales_cat_prod_mar_to>=" + CStr(Qty) + " and sales_cat_prod_mar_start<='" + CStr(onDate) + "' and sales_cat_prod_mar_end>='" + CStr(onDate) + "'"
                                End If
                                dr = cmd.ExecuteReader
                                If dr.HasRows Then
                                    dr.Read()
                                    GetPriceNew = nz(dr.Item(0), 0)
                                    dr.Close()
                                    GetPriceNew = BasePrice * GetPriceNew
                                    pType = "Sales Category Product Type"
                                Else
                                    GetPriceNew = BasePrice
                                    pType = "Base Price Method"
                                    dr.Close()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            'tPriceCalc.Text = pType
            GetPriceNew = Math.Round(GetPriceNew + 0.00001, 2)

            cmd.CommandText = "select itm_surcharge from itm_file where itm_code='" + Itm + "'"
            If nz(cmd.ExecuteScalar, False) = True Then
                Dim rate As Double
                cmd.CommandText = "select itm_surcharge_rate from itm_surcharge where itm_surcharge_from<=" + CStr(Qty) + " and itm_surcharge_to>=" + CStr(Qty)
                rate = nz(cmd.ExecuteScalar, 0)
                If rate <> 0 Then GetPriceNew = GetPriceNew * rate
            End If
            GetPriceNew = Math.Round(GetPriceNew + 0.00001, 2)

            'If row Is Nothing Then
            '    If cb5Perc.Checked = True And (nz(tProdType.Value, "") = "TOP" Or nz(tProdType.Value, "") = "BUD" Or nz(tProdType.Value, "") = "GOLD") And Mid(Tab1.ActiveTab.Key, 1, 1) = "O" Then
            '        tDisc.Value = Math.Round((GetPriceNew * Qty * 0.05) + 0.00001, 2)
            '    End If
            'Else
            '    If cb5Perc.Checked = True And (nz(row("ord_itm_prod_type"), "") = "TOP" Or nz(row("ord_itm_prod_type"), "") = "BUD" Or nz(row("ord_itm_prod_type"), "") = "GOLD") And Mid(Tab1.ActiveTab.Key, 1, 1) = "O" Then
            '        row("ord_itm_disc") = Math.Round((GetPriceNew * Qty * 0.05 * -1) + 0.00001, 2)
            '    End If
            'End If

            cnn2.Close()
        Catch
            'DoError(Err)
        End Try
    End Function
    Public Sub SetCommission(ByVal PaySerial As Long)
        Dim cmd As New SqlCommand("", cnn)
        Dim ds As New DataSet
        Dim dsItem As New DataSet
        Dim dsTemp As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim row, rowItem, rowTemp As DataRow
        Dim SalesCat As String
        Dim Rate, Comm, ShipComm, TierRate As Double
        Dim dr As SqlDataReader
        Dim cmRet, cmMD, cmCon, cmShip, cmFix, cmMr As Double
        Dim Manager, Supervisor, Rep As String
        Dim onState As ConnectionState = cnn.State
        Dim rule As String
        Dim dtItems As New DataTable
        Dim drI As DataRow
        Dim TierTot, RegTot, TierBase, TierRetail, RetailPrice As Double
        Dim Prods As New ArrayList
        Dim SkipManager As Boolean = False

        Prods.Add("BUD")
        Prods.Add("TOP")
        Prods.Add("GOLD")
        Prods.Add("STAIN")
        Prods.Add("KIT")
        Prods.Add("DESKIT")

        If onState <> ConnectionState.Open Then cnn.Open()
        cmd.CommandText = "delete from comm_file where comm_pay_serial=" + CStr(PaySerial)
        cmd.ExecuteNonQuery()
        cmd.CommandText = "select distinct pay_file.pay_serial from pay_file left outer join comm_file on pay_serial=comm_pay_serial left outer join meth_file on pay_method=meth_type where meth_pay_commission=1 and pay_serial=" + CStr(PaySerial)
        da.Fill(ds)
        For Each row In ds.Tables(0).Rows
            cmd.CommandText = "select ord_gen.ord_gen_ord_serial, ord_gen_from_rev, ord_gen.ord_gen_rev, ord_gen_from_rev, ord_gen_ship, ord_gen_total, ord_gen_terr, pay_serial,ord_gen_inside," + _
            "ord_gen_outside, ord_gen_web_order,ord_gen_floating, ord_gen_resp_rep,ord_gen_create_date, pay_applied, pay_itm_amt, round(pay_itm_amt*(ord_gen_line_total)/ord_gen_total,2) as Payment,case when disc_line_total+disc_amt=0 then 0 else round(disc_amt/(disc_line_total-disc_amt),2) end as SalesCatMod,ord_gen_sales_cat,terr_territory,ord_sold_cust_id,ord_sold_state,ord_sold_zip,ord_gen_create_date, " + _
            " ord_alt_ship.ord_alt_ship_country, ord_alt_ship.ord_alt_ship_state,ord_gen.ord_gen_alt_ship, ord_gen.ord_gen_ship_state, ord_gen.ord_gen_ship_country " + _
            " from ord_gen LEFT OUTER JOIN ord_alt_ship ON ord_gen.ord_gen_ord_serial = ord_alt_ship.ord_alt_ship_ord_serial AND ord_gen.ord_gen_rev = ord_alt_ship.ord_alt_ship_rev And ord_gen.ord_gen_type = ord_alt_ship.ord_alt_ship_type " + _
            " left outer join ord_file on ord_gen.ord_gen_ord_serial=ord_serial " + _
            " left outer join pay_itm on ord_gen.ord_gen_serial=pay_itm_ord_gen_serial " + _
            " left outer join pay_file on pay_itm_pay_serial=pay_serial " + _
            " left outer join meth_file on pay_method=meth_type " + _
            " left outer join ord_itm_disc_totals_by_parent on ord_gen.ord_gen_ord_serial=ord_itm_disc_totals_by_parent.ord_gen_ord_serial and ord_gen.ord_gen_type=ord_itm_disc_totals_by_parent.ord_gen_type and ord_gen.ord_gen_rev=ord_itm_disc_totals_by_parent.ord_gen_rev " + _
            " left outer join terr_file on ord_sold_state=terr_state " + _
            " WHERE ord_gen.ord_gen_type='O' and pay_itm_pay_serial=" + CStr(row("pay_serial")) + " and pay_itm_amt<>0 and ord_gen_total<>0"

            dsItem.Clear()
            da.Fill(dsItem)
            For Each rowItem In dsItem.Tables(0).Rows
                '********* ISR *******************
                'If UCase(rowItem("ord_gen_inside")) = "KEITHL" And UCase(rowItem("ord_gen_outside")) = "DIRECTK" Then
                '    'SkipManager = True
                '    'SalesCat = rowItem("ord_gen_sales_cat")
                '    'Comm = Math.Round(0.0 * rowItem("payment"), 2)
                '    'Rep = "keithl"
                '    'Rate = 0.0
                '    'If rowItem("ord_gen_total") = 0 Then
                '    '    ShipComm = 0
                '    'Else
                '    '    ShipComm = Math.Round(0.0 * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '    'End If
                '    'cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','ISR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                '    'cmd.ExecuteNonQuery()
                'ElseIf UCase(rowItem("ord_gen_inside")) = "JACKD" And UCase(rowItem("ord_gen_outside")) = "DIRECTJ" Then
                '    'SkipManager = True
                '    'SalesCat = rowItem("ord_gen_sales_cat")
                '    'Comm = Math.Round(0.02 * rowItem("payment"), 2)
                '    'Rep = "jackd"
                '    'Rate = 0.02
                '    'If rowItem("ord_gen_total") = 0 Then
                '    '    ShipComm = 0
                '    'Else
                '    '    ShipComm = Math.Round(0.02 * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '    'End If
                '    'cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','ISR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                '    'cmd.ExecuteNonQuery()
                'ElseIf UCase(rowItem("ord_gen_inside")) = "MIKEP" And UCase(rowItem("ord_gen_outside")) = "DIRECTK" Then
                '    SkipManager = True
                '    SalesCat = rowItem("ord_gen_sales_cat")
                '    Comm = Math.Round(0.005 * rowItem("payment"), 2)
                '    Rep = "mikep"
                '    Rate = 0.005
                '    If rowItem("ord_gen_total") = 0 Then
                '        ShipComm = 0
                '    Else
                '        ShipComm = Math.Round(0.005 * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '    End If
                '    cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','ISR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                '    cmd.ExecuteNonQuery()

                '    Comm = Math.Round(0.015 * rowItem("payment"), 2)
                '    Rep = "keithl"
                '    Rate = 0.015
                '    If rowItem("ord_gen_total") = 0 Then
                '        ShipComm = 0
                '    Else
                '        ShipComm = Math.Round(0.015 * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '    End If
                '    cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','ISR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                '    cmd.ExecuteNonQuery()
                'ElseIf UCase(rowItem("ord_gen_inside")) = "MIKEP" And UCase(rowItem("ord_gen_outside")) = "DIRECTJ" Then
                '    SkipManager = True
                '    SalesCat = rowItem("ord_gen_sales_cat")
                '    Comm = Math.Round(0.005 * rowItem("payment"), 2)
                '    Rep = "mikep"
                '    Rate = 0.005
                '    If rowItem("ord_gen_total") = 0 Then
                '        ShipComm = 0
                '    Else
                '        ShipComm = Math.Round(0.005 * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '    End If
                '    cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','ISR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                '    cmd.ExecuteNonQuery()

                '    Comm = Math.Round(0.015 * rowItem("payment"), 2)
                '    Rep = "jackd"
                '    Rate = 0.015
                '    If rowItem("ord_gen_total") = 0 Then
                '        ShipComm = 0
                '    Else
                '        ShipComm = Math.Round(0.015 * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '    End If
                '    cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','ISR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                '    cmd.ExecuteNonQuery()
                'Else
                SkipManager = False
                If (Not (nz(rowItem("ord_gen_resp_rep")) = "F" And UCase(rowItem("ord_gen_inside")) = "RANDALLM")) And nz(rowItem("ord_sold_cust_id")) = "" And Not (UCase(rowItem("ord_gen_inside")) = "RANDALLM" And UCase(rowItem("ord_gen_outside")) = "MIKESCHOECH") Then
                    Rep = GetRepFromTerritory(nz(rowItem("ord_sold_state")), "I", rowItem("ord_gen_create_date"), nz(rowItem("ord_sold_zip")))
                    If Trim(Rep) = "NONE" Then Rep = nz(rowItem("ord_gen_inside"))

                    cmd.CommandText = "select rep_comm_level from rep_file where rep_code='" + Rep + "'"
                    If UCase(nz(cmd.ExecuteScalar)) <> "MANAGER" Then
                        cmd.CommandText = "select * from rep_comm where rep_comm_rep_code='" + Rep + "' and rep_comm_start<='" + CStr(rowItem("pay_applied")) + "' and rep_comm_end>='" + CStr(rowItem("pay_applied")) + "'"
                        dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            dr.Read()
                            cmRet = dr("rep_comm_ret")
                            cmCon = dr("rep_comm_con")
                            cmMD = dr("rep_comm_md")
                            cmFix = dr("rep_comm_fix")
                            cmMr = dr("rep_comm_mr")
                            SalesCat = rowItem("ord_gen_sales_cat")
                            If rowItem("salescatmod") Is DBNull.Value Then rowItem("salescatmod") = 0
                            Select Case rowItem("ord_gen_sales_cat")
                                Case "RET"
                                    If rowItem("salescatmod") < -0.1 Then SalesCat = "CON"
                                    If rowItem("salescatmod") < -0.2 Then SalesCat = "MD"
                                    If rowItem("salescatmod") < -0.3 Then SalesCat = "MR"
                                Case "CON"
                                    If rowItem("salescatmod") < -0.1 Then SalesCat = "MD"
                                    If rowItem("salescatmod") < -0.2 Then SalesCat = "MR"
                                Case "MD"
                                    If rowItem("salescatmod") < -0.1 Then SalesCat = "MR"
                                Case "MR"
                                    SalesCat = "MR"
                                Case "BASE"
                                    SalesCat = "MR"
                                Case Else
                                    SalesCat = ""
                            End Select
                            Select Case SalesCat
                                Case "RET"
                                    Rate = cmRet
                                Case "CON"
                                    Rate = cmCon
                                Case "MD"
                                    Rate = cmMD
                                Case "MR"
                                    Rate = cmMr
                                Case "BASE"
                                    Rate = cmMr
                                Case Else
                                    Rate = 0
                            End Select

                            If nz(dr("rep_comm_rule")) <> "" Then
                                For Each rule In Split(dr("rep_comm_rule"), ",")
                                    Select Case UCase(Split(rule, ";")(0))
                                        Case "OSR"
                                            If UCase(Split(rule, ";")(1)) = UCase(rowItem("ord_gen_outside")) Then
                                                Rate = Math.Round(Rate * CDbl(UCase(Split(rule, ";")(2))), 6)
                                            End If
                                    End Select
                                Next
                            End If
                            dr.Close()

                            If rowItem("ord_gen_total") = 0 Then
                                ShipComm = 0
                            Else
                                Select Case rowItem("ord_gen_sales_cat")
                                    Case "RET"
                                        ShipComm = Math.Round(cmRet * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                    Case "CON"
                                        ShipComm = Math.Round(cmCon * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                    Case "MD"
                                        ShipComm = Math.Round(cmMD * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                    Case "MR"
                                        ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                    Case "BASE"
                                        ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                    Case Else
                                        ShipComm = 0
                                End Select
                            End If


                            Dim shST = ""
                            Dim shCO = ""
                            If nz(rowItem("ord_gen_alt_ship"), False) = True Then
                                shST = nz(rowItem("ord_alt_ship_state"))
                                shCO = nz(rowItem("ord_alt_ship_country"))
                            Else
                                shST = nz(rowItem("ord_gen_ship_state"))
                                shCO = nz(rowItem("ord_gen_ship_country"))
                            End If

                            Dim goz As Boolean = True
                            If Rep = "MELISSAB" Then
                                If (InStr("TX, IL, IN, MI, OH, WI, CT, MA, ME, NH, NY, PA, RI, VT, FL, AK, AZ, CO, HI, IA, ID, MN, MT, ND, NE, NM, OR, SD. UT, WA, WY", shST) = 0) And shCO = "USA" Then
                                    goz = False
                                End If
                                If nz(rowItem("ord_gen_web_order"), 0) > 0 Then
                                    goz = False
                                End If
                            End If


                            If goz = True Then
                                Comm = Math.Round(Rate * rowItem("payment"), 2)
                                cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','ISR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                                cmd.ExecuteNonQuery()
                            End If
                        Else
                            dr.Close()
                        End If
                    End If
                End If

                'End If



                '********* OSR *******************
                If nz(rowItem("ord_sold_cust_id")) = "" Then
                    'Used previous to 10/24/2008
                    'Rep = GetRepFromTerritory(nz(rowItem("ord_sold_state")), "O", nz(rowItem("ord_sold_zip")))
                    'If Rep = "NONE" Then Rep = nz(rowItem("ord_gen_outside"))

                    If (nz(rowItem("ord_gen_outside")) = "NONE") Or (nz(rowItem("ord_gen_outside")) = "") Or (RepIsRoaming(nz(rowItem("ord_gen_outside"))) = True) Then
                        Rep = GetRepFromTerritory(nz(rowItem("ord_sold_state")), "O", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                    Else
                        Rep = rowItem("ord_gen_outside")
                    End If
                    If Rep <> "NONE" Then
                        ' Replaced with code below on 2/22/2010
                        '    cmd.CommandText = "select * from rep_comm where rep_comm_rep_code='" + Rep + "' and rep_comm_start<='" + CStr(rowItem("pay_applied")) + "' and rep_comm_end>='" + CStr(rowItem("pay_applied")) + "'"
                        '    dr = cmd.ExecuteReader
                        '    If dr.HasRows Then
                        '        dr.Read()
                        '        cmRet = dr("rep_comm_ret")
                        '        cmCon = dr("rep_comm_con")
                        '        cmMD = dr("rep_comm_md")
                        '        cmFix = dr("rep_comm_fix")
                        '        cmMr = dr("rep_comm_mr")
                        '        dr.Close()
                        '        SalesCat = rowItem("ord_gen_sales_cat")
                        '        If rowItem("salescatmod") Is DBNull.Value Then rowItem("salescatmod") = 0
                        '        Select Case rowItem("ord_gen_sales_cat")
                        '            Case "RET"
                        '                If rowItem("salescatmod") < -0.1 Then SalesCat = "CON"
                        '                If rowItem("salescatmod") < -0.2 Then SalesCat = "MD"
                        '                If rowItem("salescatmod") < -0.3 Then SalesCat = "MR"
                        '            Case "CON"
                        '                If rowItem("salescatmod") < -0.1 Then SalesCat = "MD"
                        '                If rowItem("salescatmod") < -0.2 Then SalesCat = "MR"
                        '            Case "MD"
                        '                If rowItem("salescatmod") < -0.1 Then SalesCat = "MR"
                        '            Case "MR"
                        '                SalesCat = "MR"
                        '            Case "BASE"
                        '                SalesCat = "MR"
                        '            Case Else
                        '                SalesCat = ""
                        '        End Select
                        '        Select Case SalesCat
                        '            Case "RET"
                        '                Rate = cmRet
                        '            Case "CON"
                        '                Rate = cmCon
                        '            Case "MD"
                        '                Rate = cmMD
                        '            Case "MR"
                        '                Rate = cmMr
                        '            Case "BASE"
                        '                Rate = cmMr
                        '            Case Else
                        '                Rate = 0
                        '        End Select
                        '        If rowItem("ord_gen_total") = 0 Then
                        '            ShipComm = 0
                        '        Else
                        '            Select Case rowItem("ord_gen_sales_cat")
                        '                Case "RET"
                        '                    ShipComm = Math.Round(cmRet * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                        '                Case "CON"
                        '                    ShipComm = Math.Round(cmCon * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                        '                Case "MD"
                        '                    ShipComm = Math.Round(cmMD * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                        '                Case "MR"
                        '                    ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                        '                Case "BASE"
                        '                    ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                        '                Case Else
                        '                    ShipComm = 0
                        '            End Select
                        '        End If

                        '        Comm = Math.Round(Rate * rowItem("payment"), 2)
                        '        cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','OSR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                        '        cmd.ExecuteNonQuery()
                        '    Else
                        '        dr.Close()
                        '    End If

                        'cmd.CommandText = "select * from rep_comm where rep_comm_rep_code='" + Rep + "' and rep_comm_start<='" + CStr(rowItem("pay_applied")) + "' and rep_comm_end>='" + CStr(rowItem("pay_applied")) + "'"
                        'dsTemp = New DataSet
                        'da.Fill(dsTemp)
                        ''dr = cmd.ExecuteReader
                        'For Each rowTemp In dsTemp.Tables(0).Rows
                        'If dr.HasRows Then
                        'dr.Read()
                        cmRet = GetCommFromTerritory(Rep, nz(rowItem("ord_sold_state")), "RET", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                        cmCon = GetCommFromTerritory(Rep, nz(rowItem("ord_sold_state")), "CON", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                        cmMD = GetCommFromTerritory(Rep, nz(rowItem("ord_sold_state")), "MD", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                        cmFix = GetCommFromTerritory(Rep, nz(rowItem("ord_sold_state")), "FIX", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                        cmMr = GetCommFromTerritory(Rep, nz(rowItem("ord_sold_state")), "MR", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                        'dr.Close()
                        SalesCat = rowItem("ord_gen_sales_cat")
                        If rowItem("salescatmod") Is DBNull.Value Then rowItem("salescatmod") = 0
                        Select Case rowItem("ord_gen_sales_cat")
                            Case "RET"
                                If rowItem("salescatmod") < -0.1 Then SalesCat = "CON"
                                If rowItem("salescatmod") < -0.2 Then SalesCat = "MD"
                                If rowItem("salescatmod") < -0.3 Then SalesCat = "MR"
                            Case "CON"
                                If rowItem("salescatmod") < -0.1 Then SalesCat = "MD"
                                If rowItem("salescatmod") < -0.2 Then SalesCat = "MR"
                            Case "MD"
                                If rowItem("salescatmod") < -0.1 Then SalesCat = "MR"
                            Case "MR"
                                SalesCat = "MR"
                            Case "BASE"
                                SalesCat = "MR"
                            Case Else
                                SalesCat = ""
                        End Select
                        Select Case SalesCat
                            Case "RET"
                                Rate = cmRet
                            Case "CON"
                                Rate = cmCon
                            Case "MD"
                                Rate = cmMD
                            Case "MR"
                                Rate = cmMr
                            Case "BASE"
                                Rate = cmMr
                            Case Else
                                Rate = 0
                        End Select

                        If Rate = 0 Then
                            Select Case SalesCat
                                Case "RET"
                                    cmd.CommandText = "select min(rep_ter_out_comm_ret) as rate from rep_ter where rep_ter_out_rep_code='" + Rep + "' and rep_ter_start<='" + CDate(nz(rowItem("pay_applied"), Today)) + "' and rep_ter_end>='" + CDate(nz(rowItem("ord_gen_create_date"), Today)) + "'"
                                    Rate = nz(cmd.ExecuteScalar, 0)
                                Case "CON"
                                    cmd.CommandText = "select min(rep_ter_out_comm_con) as rate from rep_ter where rep_ter_out_rep_code='" + Rep + "' and rep_ter_start<='" + CDate(nz(rowItem("pay_applied"), Today)) + "' and rep_ter_end>='" + CDate(nz(rowItem("ord_gen_create_date"), Today)) + "'"
                                    Rate = nz(cmd.ExecuteScalar, 0)
                                Case "MD"
                                    cmd.CommandText = "select min(rep_ter_out_comm_md) as rate from rep_ter where rep_ter_out_rep_code='" + Rep + "' and rep_ter_start<='" + CDate(nz(rowItem("pay_applied"), Today)) + "' and rep_ter_end>='" + CDate(nz(rowItem("ord_gen_create_date"), Today)) + "'"
                                    Rate = nz(cmd.ExecuteScalar, 0)
                                Case "MR"
                                    cmd.CommandText = "select min(rep_ter_out_comm_mr) as rate from rep_ter where rep_ter_out_rep_code='" + Rep + "' and rep_ter_start<='" + CDate(nz(rowItem("pay_applied"), Today)) + "' and rep_ter_end>='" + CDate(nz(rowItem("ord_gen_create_date"), Today)) + "'"
                                    Rate = nz(cmd.ExecuteScalar, 0)
                                Case "BASE"
                                    cmd.CommandText = "select min(rep_ter_out_comm_mr) as rate from rep_ter where rep_ter_out_rep_code='" + Rep + "' and rep_ter_start<='" + CDate(nz(rowItem("pay_applied"), Today)) + "' and rep_ter_end>='" + CDate(nz(rowItem("ord_gen_create_date"), Today)) + "'"
                                    Rate = nz(cmd.ExecuteScalar, 0)
                                Case Else
                                    Rate = 0
                            End Select
                        End If
                        If rowItem("ord_gen_total") = 0 Then
                            ShipComm = 0
                        Else
                            Select Case rowItem("ord_gen_sales_cat")
                                Case "RET"
                                    ShipComm = Math.Round(cmRet * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "CON"
                                    ShipComm = Math.Round(cmCon * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "MD"
                                    ShipComm = Math.Round(cmMD * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "MR"
                                    ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "BASE"
                                    ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case Else
                                    ShipComm = 0
                            End Select
                        End If

                        'Comm = Math.Round(Rate * rowItem("payment"), 2)

                        cmd.CommandText = "select * from ord_itm where ord_itm_ord_serial=" + CStr(rowItem("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(rowItem("ord_gen_rev")) + " and ord_itm_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0"
                        dtItems.Rows.Clear()
                        da.Fill(dtItems)
                        TierTot = 0
                        RegTot = 0
                        For Each drI In dtItems.Rows
                            RetailPrice = GetItemPriceNew(drI("ord_itm_item_code"), drI("ord_itm_qty"), "RET", drI("ord_itm_mat_code"), , , rowItem("ord_gen_create_date"))
                            If nz(drI("ord_itm_base_price"), 0) = 0 Or RetailPrice <= 0 Or nz(drI("ord_itm_base_price"), 0) >= RetailPrice Or Prods.Contains(drI("ord_itm_prod_type")) = False Then
                                RegTot += (drI("ord_itm_qty") * drI("ord_itm_unt_sell")) + drI("ord_itm_disc")
                            Else
                                TierTot += (drI("ord_itm_qty") * drI("ord_itm_unt_sell")) + drI("ord_itm_disc")
                                TierBase += drI("ord_itm_qty") * drI("ord_itm_base_price")
                                TierRetail += drI("ord_itm_qty") * RetailPrice
                            End If
                        Next
                        If (TierTot + RegTot) = 0 Then
                            Comm = 0
                            TierRate = 0
                        Else
                            Comm = Math.Round(Rate * rowItem("payment") * RegTot / (TierTot + RegTot), 2)
                            If TierTot >= TierBase + ((TierRetail - TierBase) * 0.8) Then
                                TierRate = GetCommFromTerritory(Rep, nz(rowItem("ord_sold_state")), "TIER3", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                            ElseIf TierTot >= TierBase + ((TierRetail - TierBase) * 0.2) Then
                                TierRate = GetCommFromTerritory(Rep, nz(rowItem("ord_sold_state")), "TIER2", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                            Else
                                TierRate = GetCommFromTerritory(Rep, nz(rowItem("ord_sold_state")), "TIER1", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                            End If
                            Comm += Math.Round(TierRate * rowItem("payment") * TierTot / (TierTot + RegTot), 2)
                        End If

                        If TierTot = 0 Then TierRate = 0

                        Dim shST = ""
                        Dim shCO = ""
                        If nz(rowItem("ord_gen_alt_ship"), False) = True Then
                            shST = nz(rowItem("ord_alt_ship_state"))
                            shCO = nz(rowItem("ord_alt_ship_country"))
                        Else
                            shST = nz(rowItem("ord_gen_ship_state"))
                            shCO = nz(rowItem("ord_gen_ship_country"))
                        End If

                        Dim goz As Boolean = True
                        If Rep = "DONC" Or Rep = "TSKOKES" Or Rep = "BRETTN" Then
                            If nz(rowItem("ord_gen_web_order"), 0) > 0 Then
                                goz = False
                            End If
                        End If

                        If Rep = "ERIK" Then
                            goz = False
                            Dim repz = nz(rowItem("ord_gen_resp_rep"))
                            Select Case repz
                                Case "O"
                                    If nz(rowItem("ord_gen_outside")) = "ERIK" Then
                                        If (InStr("TX, FL, LA", shST) > 0) Then
                                            goz = True
                                        End If
                                    End If
                            End Select
                            If (InStr("GA, AL, MS, NC, SC", shST) > 0) Then
                                goz = True
                            End If
                            If nz(rowItem("ord_gen_web_order"), 0) > 0 Then
                                goz = False
                            End If
                        End If


                        If goz = True Then
                            cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_ret_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','OSR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(TierRate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                            cmd.ExecuteNonQuery()
                        End If
                        'Next
                        'Else
                        'dr.Close()
                        'End If

                    End If
                End If

                ''********* OSR - Roaming *******************
                'If nz(rowItem("ord_sold_cust_id")) = "" Then
                '    If (RepIsRoaming(nz(rowItem("ord_gen_outside"))) = True) Then
                '        Rep = rowItem("ord_gen_outside")

                '        cmd.CommandText = "select * from rep_comm where rep_comm_rep_code='" + Rep + "' and rep_comm_start<='" + CStr(rowItem("pay_applied")) + "' and rep_comm_end>='" + CStr(rowItem("pay_applied")) + "'"
                '        dr = cmd.ExecuteReader
                '        If dr.HasRows Then
                '            dr.Read()
                '            cmRet = dr("rep_comm_ret")
                '            cmCon = dr("rep_comm_con")
                '            cmMD = dr("rep_comm_md")
                '            cmFix = dr("rep_comm_fix")
                '            cmMr = dr("rep_comm_mr")
                '            dr.Close()
                '            SalesCat = rowItem("ord_gen_sales_cat")
                '            If rowItem("salescatmod") Is DBNull.Value Then rowItem("salescatmod") = 0
                '            Select Case rowItem("ord_gen_sales_cat")
                '                Case "RET"
                '                    If rowItem("salescatmod") < -0.1 Then SalesCat = "CON"
                '                    If rowItem("salescatmod") < -0.2 Then SalesCat = "MD"
                '                    If rowItem("salescatmod") < -0.3 Then SalesCat = "MR"
                '                Case "CON"
                '                    If rowItem("salescatmod") < -0.1 Then SalesCat = "MD"
                '                    If rowItem("salescatmod") < -0.2 Then SalesCat = "MR"
                '                Case "MD"
                '                    If rowItem("salescatmod") < -0.1 Then SalesCat = "MR"
                '                Case "MR"
                '                    SalesCat = "MR"
                '                Case "BASE"
                '                    SalesCat = "MR"
                '                Case Else
                '                    SalesCat = ""
                '            End Select
                '            Select Case SalesCat
                '                Case "RET"
                '                    Rate = cmRet
                '                Case "CON"
                '                    Rate = cmCon
                '                Case "MD"
                '                    Rate = cmMD
                '                Case "MR"
                '                    Rate = cmMr
                '                Case "BASE"
                '                    Rate = cmMr
                '                Case Else
                '                    Rate = 0
                '            End Select
                '            If rowItem("ord_gen_total") = 0 Then
                '                ShipComm = 0
                '            Else
                '                Select Case rowItem("ord_gen_sales_cat")
                '                    Case "RET"
                '                        ShipComm = Math.Round(cmRet * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '                    Case "CON"
                '                        ShipComm = Math.Round(cmCon * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '                    Case "MD"
                '                        ShipComm = Math.Round(cmMD * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '                    Case "MR"
                '                        ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '                    Case "BASE"
                '                        ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                '                    Case Else
                '                        ShipComm = 0
                '                End Select
                '            End If

                '            'Comm = Math.Round(Rate * rowItem("payment"), 2)
                '            'cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','OSR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                '            'cmd.ExecuteNonQuery()

                '            cmd.CommandText = "select * from ord_itm where ord_itm_ord_serial=" + CStr(rowItem("ord_gen_ord_serial")) + " and ord_itm_rev=" + CStr(rowItem("ord_gen_rev")) + " and ord_itm_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0"
                '            dtItems.Rows.Clear()
                '            da.Fill(dtItems)
                '            TierTot = 0
                '            RegTot = 0
                '            For Each drI In dtItems.Rows
                '                RetailPrice = GetItemPriceNew(drI("ord_itm_item_code"), drI("ord_itm_qty"), "RET", drI("ord_itm_mat_code"), , , rowItem("ord_gen_create_date"))
                '                If nz(drI("ord_itm_base_price"), 0) = 0 Or RetailPrice <= 0 Or nz(drI("ord_itm_base_price"), 0) >= RetailPrice Or Prods.Contains(drI("ord_itm_prod_type")) = False Then
                '                    RegTot += (drI("ord_itm_qty") * drI("ord_itm_unt_sell")) + drI("ord_itm_disc")
                '                Else
                '                    TierTot += (drI("ord_itm_qty") * drI("ord_itm_unt_sell")) + drI("ord_itm_disc")
                '                    TierBase += drI("ord_itm_qty") * drI("ord_itm_base_price")
                '                    TierRetail += drI("ord_itm_qty") * RetailPrice
                '                End If
                '            Next
                '            If (TierTot + RegTot) = 0 Then
                '                Comm = 0
                '                TierRate = 0
                '            Else
                '                Comm = Math.Round(Rate * rowItem("payment") * RegTot / (TierTot + RegTot), 2)
                '                If TierTot >= TierBase + ((TierRetail - TierBase) * 0.8) Then
                '                    TierRate = GetCommFromTerritory(Rep, nz(rowItem("ord_sold_state")), "TIER3", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                '                ElseIf TierTot >= TierBase + ((TierRetail - TierBase) * 0.2) Then
                '                    TierRate = GetCommFromTerritory(Rep, nz(rowItem("ord_sold_state")), "TIER2", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                '                Else
                '                    TierRate = GetCommFromTerritory(Rep, nz(rowItem("ord_sold_state")), "TIER1", rowItem("pay_applied"), nz(rowItem("ord_sold_zip")))
                '                End If
                '                Comm += Math.Round(TierRate * rowItem("payment") * TierTot / (TierTot + RegTot), 2)
                '            End If

                '            If TierTot = 0 Then TierRate = 0
                '            cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_ret_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','OSR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(TierRate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                '            cmd.ExecuteNonQuery()
                '        Else
                '            dr.Close()
                '        End If
                '    End If
                'End If

                '********* Manager *******************
                If SkipManager = False Then
                    If nz(rowItem("ord_sold_cust_id")) = "" Then
                        'Rep = GetRepFromTerritory(nz(rowItem("ord_sold_state")), "O", nz(rowItem("ord_sold_zip")))

                        'Changed 12/22/2009
                        'Rep = nz(rowItem("ord_gen_outside"), "NONE")
                        'If Rep = "NONE" Then
                        '    cmd.CommandText = "select terr_territory from terr_file where terr_state='" + nz(rowItem("ord_sold_state")) + "'"
                        '    Rep = nz(cmd.ExecuteScalar, "NONE")
                        'End If
                        'If Rep = "NONE" Then Rep = nz(rowItem("ord_gen_inside"))
                        'cmd.CommandText = "select rep_manager from rep_file where rep_code='" + Rep + "'"
                        'Manager = nz(cmd.ExecuteScalar, "")


                        Manager = "KEITHL"
                        ' ''Manager = GetRepFromTerritory(nz(rowItem("ord_sold_state")), "M", rowItem("ord_gen_create_date"), nz(rowItem("ord_sold_zip")))
                        ' ''If Manager = "" Or Manager = "NONE" Then
                        ' ''    If nz(rowItem("ord_gen_outside")) = "NONE" Or nz(rowItem("ord_gen_outside")) = "" Then
                        ' ''        Manager = "JACKD"
                        ' ''    Else
                        ' ''        cmd.CommandText = "select rep_manager from rep_file where rep_code='" + rowItem("ord_gen_outside") + "'"
                        ' ''        Manager = nz(cmd.ExecuteScalar, "")
                        ' ''        If Manager = "" Or Manager = "NONE" Then
                        ' ''            Manager = "JACKD"
                        ' ''        End If
                        ' ''    End If
                        ' ''End If

                        ' ''cmd.CommandText = "select * from rep_comm where rep_comm_rep_code='" + Manager + "' and rep_comm_start<='" + CStr(rowItem("pay_applied")) + "' and rep_comm_end>='" + CStr(rowItem("pay_applied")) + "'"
                        ' ''dr = cmd.ExecuteReader
                        ' ''If dr.HasRows Then
                        ' ''    dr.Read()
                        cmRet = 0.00625
                        cmCon = 0.00625
                        cmMD = 0.00625
                        cmFix = 0.00625
                        cmMr = 0.00625

                        ' ''    cmRet = dr("rep_comm_ret")
                        ' ''    cmCon = dr("rep_comm_con")
                        ' ''    cmMD = dr("rep_comm_md")
                        ' ''    cmFix = dr("rep_comm_fix")
                        ' ''    cmMr = dr("rep_comm_mr")
                        ' ''    dr.Close()
                        ' ''    SalesCat = rowItem("ord_gen_sales_cat")
                        ' ''    If rowItem("salescatmod") Is DBNull.Value Then rowItem("salescatmod") = 0
                        ' ''    Select Case rowItem("ord_gen_sales_cat")
                        ' ''        Case "RET"
                        ' ''            If rowItem("salescatmod") < -0.1 Then SalesCat = "CON"
                        ' ''            If rowItem("salescatmod") < -0.2 Then SalesCat = "MD"
                        ' ''            If rowItem("salescatmod") < -0.3 Then SalesCat = "MR"
                        ' ''        Case "CON"
                        ' ''            If rowItem("salescatmod") < -0.1 Then SalesCat = "MD"
                        ' ''            If rowItem("salescatmod") < -0.2 Then SalesCat = "MR"
                        ' ''        Case "MD"
                        ' ''            If rowItem("salescatmod") < -0.1 Then SalesCat = "MR"
                        ' ''        Case "MR"
                        ' ''            SalesCat = "MR"
                        ' ''        Case "BASE"
                        ' ''            SalesCat = "MR"
                        ' ''        Case Else
                        ' ''            SalesCat = ""
                        ' ''    End Select
                        ' ''    Select Case SalesCat
                        ' ''        Case "RET"
                        ' ''            Rate = cmRet
                        ' ''        Case "CON"
                        ' ''            Rate = cmCon
                        ' ''        Case "MD"
                        ' ''            Rate = cmMD
                        ' ''        Case "MR"
                        ' ''            Rate = cmMr
                        ' ''        Case "BASE"
                        ' ''            Rate = cmMr
                        ' ''        Case Else
                        ' ''            Rate = 0
                        ' ''    End Select
                        If rowItem("ord_gen_total") = 0 Then
                            ShipComm = 0
                        Else
                            Select Case rowItem("ord_gen_sales_cat")
                                Case "RET"
                                    ShipComm = Math.Round(cmRet * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "CON"
                                    ShipComm = Math.Round(cmCon * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "MD"
                                    ShipComm = Math.Round(cmMD * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "MR"
                                    ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "BASE"
                                    ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case Else
                                    ShipComm = 0
                            End Select
                        End If
                        Rate = 0.00625
                        Comm = Math.Round(Rate * rowItem("payment"), 2)
                        'If nz(rowItem("ord_gen_resp_rep")) = "F" Then
                        '    Rep = GetRepFromTerritory(nz(rowItem("ord_sold_state")), "I", rowItem("ord_gen_create_date"), nz(rowItem("ord_sold_zip")))
                        '    If Rep = "NONE" Then
                        '        If Manager = "JACKD" Then
                        '            Comm = Comm + Math.Round(0.0025 * rowItem("payment"), 2)
                        '        Else
                        '            cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + "JACKD" + "','MAN','" + SalesCat + "'," + CStr(0.0025) + "," + CStr(Math.Round(0.0025 * rowItem("payment"), 2)) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(0) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                        '            cmd.ExecuteNonQuery()
                        '        End If
                        '    End If
                        'End If
                        cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Manager + "','MAN','" + SalesCat + "'," + CStr(Rate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                        cmd.ExecuteNonQuery()
                        ' ''Else
                        ' ''    dr.Close()
                        ' ''End If
                    End If
                End If

                '********* FSR *******************
                If nz(rowItem("ord_sold_cust_id")) = "" Then
                    Rep = nz(rowItem("ord_gen_floating"), "xxxx")
                    cmd.CommandText = "select * from rep_comm where rep_comm_rep_code='" + Rep + "' and rep_comm_start<='" + CStr(rowItem("pay_applied")) + "' and rep_comm_end>='" + CStr(rowItem("pay_applied")) + "'"
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        cmRet = dr("rep_comm_ret")
                        cmCon = dr("rep_comm_con")
                        cmMD = dr("rep_comm_md")
                        cmFix = dr("rep_comm_fix")
                        cmMr = dr("rep_comm_mr")
                        dr.Close()
                        SalesCat = rowItem("ord_gen_sales_cat")
                        If rowItem("salescatmod") Is DBNull.Value Then rowItem("salescatmod") = 0
                        Select Case rowItem("ord_gen_sales_cat")
                            Case "RET"
                                If rowItem("salescatmod") < -0.1 Then SalesCat = "CON"
                                If rowItem("salescatmod") < -0.2 Then SalesCat = "MD"
                                If rowItem("salescatmod") < -0.3 Then SalesCat = "MR"
                            Case "CON"
                                If rowItem("salescatmod") < -0.1 Then SalesCat = "MD"
                                If rowItem("salescatmod") < -0.2 Then SalesCat = "MR"
                            Case "MD"
                                If rowItem("salescatmod") < -0.1 Then SalesCat = "MR"
                            Case "MR"
                                SalesCat = "MR"
                            Case "BASE"
                                SalesCat = "MR"
                            Case Else
                                SalesCat = ""
                        End Select
                        Select Case SalesCat
                            Case "RET"
                                Rate = cmRet
                            Case "CON"
                                Rate = cmCon
                            Case "MD"
                                Rate = cmMD
                            Case "MR"
                                Rate = cmMr
                            Case "BASE"
                                Rate = cmMr
                            Case Else
                                Rate = 0
                        End Select
                        If rowItem("ord_gen_total") = 0 Then
                            ShipComm = 0
                        Else
                            Select Case rowItem("ord_gen_sales_cat")
                                Case "RET"
                                    ShipComm = Math.Round(cmRet * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "CON"
                                    ShipComm = Math.Round(cmCon * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "MD"
                                    ShipComm = Math.Round(cmMD * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "MR"
                                    ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case "BASE"
                                    ShipComm = Math.Round(cmMr * rowItem("ord_gen_ship") / rowItem("ord_gen_total") * rowItem("pay_itm_amt"), 2)
                                Case Else
                                    ShipComm = 0
                            End Select
                        End If

                        Comm = Math.Round(Rate * rowItem("payment"), 2)
                        cmd.CommandText = "insert into comm_file (comm_pay_serial,comm_ord_serial,comm_from_rev,comm_ord_rev,comm_ord_type,comm_payment,comm_rep,comm_level,comm_sales_cat,comm_rate,comm_amt,comm_ship_amt,comm_ship_comm,comm_created,comm_created_by,comm_payment_full) values (" + CStr(rowItem("pay_serial")) + "," + CStr(rowItem("ord_gen_ord_serial")) + "," + CStr(rowItem("ord_gen_from_rev")) + "," + CStr(rowItem("ord_gen_rev")) + ",'O'," + CStr(rowItem("payment")) + ",'" + Rep + "','FSR','" + SalesCat + "'," + CStr(Rate) + "," + CStr(Comm) + "," + CStr(rowItem("ord_gen_ship")) + "," + CStr(ShipComm) + ",'" + CStr(Now) + "','" + User + "'," + CStr(rowItem("pay_itm_amt")) + ")"
                        cmd.ExecuteNonQuery()
                    Else
                        dr.Close()
                    End If
                End If

            Next
        Next
        If onState <> ConnectionState.Open Then cnn.Close()
    End Sub
    Public Function RepIsRoaming(ByVal Rep As String) As Boolean
        Dim cmd As New SqlCommand("select rep_roaming from rep_file where rep_code='" + Rep + "'", cnn)
        RepIsRoaming = nz(cmd.ExecuteScalar, False)
    End Function
    Public Function GetLatLong(ByVal postcode As String) As LatLong
        Dim myKey As String = "ABQIAAAAmYMrtvBO8oZC3ts5HAikCRR-jWeypE3PYtP3BFEAghwPMYrI-RQu36Qc7HN3h4eNBTEww87KCwDPOg"
        Dim URL As String = "http://maps.google.com/maps/geo?q=" + postcode + "&output=xml&key=" + myKey
        Dim doc As System.Net.WebRequest
        Dim resp As System.Net.WebResponse
        Dim xml As New System.Xml.XmlDocument
        Dim coordinates As Xml.XmlNodeList

        GetLatLong = New LatLong

        doc = System.Net.WebRequest.Create(URL)
        resp = doc.GetResponse

        If resp.ContentLength < 0 Then
            GetLatLong.Latitude = 0
            GetLatLong.Longitude = 0
        Else
            xml.Load(resp.GetResponseStream)
            coordinates = xml.GetElementsByTagName("coordinates")
            If coordinates.Count > 0 Then
                GetLatLong.Latitude = CDbl(Split(coordinates(0).InnerText, ",")(0))
                GetLatLong.Longitude = CDbl(Split(coordinates(0).InnerText, ",")(1))
            Else
                GetLatLong.Latitude = 0
                GetLatLong.Longitude = 0
            End If
        End If
    End Function
    Public Sub UpdateChild(ByVal Parent As String, ByVal Child As String)
        Dim dr, dr2 As DataRow
        Dim tbl As New DataTable
        Dim col, col2 As DataColumn
        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim cb As New SqlClient.SqlCommandBuilder(da)
        Dim dtChild As New DataTable
        Dim dtParent As New DataTable
        Dim doit As Boolean

        cnn.Open()
        cmd.CommandText = "select * from itm_file where itm_code='" + Parent + "'"
        da.Fill(dtParent)
        cmd.CommandText = "select * from itm_file where itm_code='" + Child + "'"
        da.Fill(dtChild)

        For Each col In dtParent.Columns
            For Each dr In dtChild.Rows
                doit = True
                If col.ColumnName = "itm_code" Then doit = False
                If col.ColumnName = "itm_serial" Then doit = False
                If col.ColumnName = "inactive" Then doit = False
                If col.ColumnName = "itm_parent_code" Then doit = False
                If col.ColumnName = "itm_desc" Then doit = False

                If doit Then dr(col.ColumnName) = dtParent.Rows(0)(col.ColumnName)
            Next
        Next

        da.Update(dtChild)

        cmd.CommandText = "delete from itm_price where itm_price_itm_code='" + Child + "'"
        cmd.ExecuteNonQuery()
        dtChild = New DataTable
        dtParent = New DataTable

        cmd.CommandText = "select * from itm_price where itm_price_itm_code='" + Parent + "'"
        da.Fill(dtParent)
        cmd.CommandText = "select * from itm_price where itm_price_itm_code='" + Child + "'"
        da.Fill(dtChild)

        For Each dr In dtParent.Rows
            dr2 = dtChild.NewRow
            dr2.ItemArray = dr.ItemArray
            dr2("itm_price_itm_code") = Child
            dtChild.Rows.Add(dr2)
        Next

        cb = New SqlClient.SqlCommandBuilder(da)
        da.Update(dtChild)

        cnn.Close()

    End Sub
    Public Sub KeyLog(ByVal key As String)
        Try
            If DoKeyLog = False Then Exit Sub
            Dim cmd As New SqlCommand("insert into key_log (key_user,key_time,key_stroke) values ('" + User + "','" + CStr(Now) + "','" + key + "')", cnn)
            Dim cnnState As ConnectionState = cnn.State

            If cnn.State <> ConnectionState.Open Then cnn.Open()
            cmd.ExecuteNonQuery()
            If cnnState = ConnectionState.Closed Then cnn.Close()
        Catch
            DoError(Err, MainForm, "KeyLog")
        End Try
    End Sub
    Public Function CreateTrackRequest(ByVal TrackingNo As String)
        'Build a TrackRequest
        Dim request As WineCellar.TrackingServiceWebReference.TrackRequest = New WineCellar.TrackingServiceWebReference.TrackRequest()
        '
        request.WebAuthenticationDetail = New WineCellar.TrackingServiceWebReference.WebAuthenticationDetail()
        request.WebAuthenticationDetail.UserCredential = New WineCellar.TrackingServiceWebReference.WebAuthenticationCredential()
        request.WebAuthenticationDetail.UserCredential.Key = "3vpzP1rr97rzZjaA" ' Replace "XXX" with the Key
        request.WebAuthenticationDetail.UserCredential.Password = "4pnubEiEfKCoVErhNr2p5y3o8" ' Replace "XXX" with the Password
        '
        request.ClientDetail = New WineCellar.TrackingServiceWebReference.ClientDetail()
        request.ClientDetail.AccountNumber = "128395695" ' Replace "XXX" with client's account number
        request.ClientDetail.MeterNumber = "101818115"   ' Replace "XXX" with client's meter number
        request.TransactionDetail = New WineCellar.TrackingServiceWebReference.TransactionDetail()
        request.TransactionDetail.CustomerTransactionId = "***Track v4 Request using VB.NET***" 'The client will get the same value back in the response
        request.Version = New WineCellar.TrackingServiceWebReference.VersionId()
        '
        request.PackageIdentifier = New WineCellar.TrackingServiceWebReference.TrackPackageIdentifier() 'Tracking information
        request.PackageIdentifier.Value = TrackingNo ' Replace "XXX" with your tracking number
        request.PackageIdentifier.Type = WineCellar.TrackingServiceWebReference.TrackIdentifierType.TRACKING_NUMBER_OR_DOORTAG
        '
        request.IncludeDetailedScans = True ' Optional Use if all scans should be returned
        request.IncludeDetailedScansSpecified = True

        '26504273  case number for "Signed For" issue.
        Return request
    End Function
    Public Function AddProductionDays(ByVal onDate As Date, ByVal Days As Integer) As Date
        onDate = DateAdd(DateInterval.Day, Days, onDate)
        If Weekday(onDate) = 6 Then onDate = DateAdd(DateInterval.Day, 3, onDate)
        If Weekday(onDate) = 7 Then onDate = DateAdd(DateInterval.Day, 2, onDate)
        If Weekday(onDate) = 1 Then onDate = DateAdd(DateInterval.Day, 1, onDate)
        AddProductionDays = onDate
    End Function
    Public Function NeedsDiagnostic(ByVal ItmCode As String)
        Dim cmd As New SqlCommand("select itm_send_diag from itm_file where itm_code='" + ItmCode + "'", cnn)
        NeedsDiagnostic = cmd.ExecuteScalar
    End Function
    Public Declare Function ShowWindow Lib "user32" (ByVal handle As IntPtr, ByVal nCmdShow As Integer) As Integer

    Public Function CleanPhoneNumber(ByVal PhoneNumber As String) As String
        If PhoneNumber Is Nothing Then
            CleanPhoneNumber = ""
            Exit Function
        End If

        Dim c As Char

        CleanPhoneNumber = ""
        For Each c In PhoneNumber.ToCharArray
            If c >= "0" And c <= "9" Then CleanPhoneNumber += c
        Next
    End Function
    Public Function AddLinksAtBottom(ByVal sHTMLBody As String) As String
        sHTMLBody += "<p><strong><b><font size=2 face=Arial><span style='font-size:10.0pt;font-family:"
        sHTMLBody += "Arial'>Stay Connected to Wine Cellar Innovations</span></font></b></strong><font"
        sHTMLBody += "size=2 face=Arial><span style='font-size:10.0pt;font-family:Arial'><br>"
        sHTMLBody += "Join us on<o:p></o:p></span></font></p>"

        sHTMLBody += "<table class=MsoNormalTable border=0 cellpadding=0 width=330 style='width:247.5pt'>"
        sHTMLBody += " <tr>"
        sHTMLBody += "  <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'>"
        sHTMLBody += "<a href='http://www.winecellarinnovations.com/blog/' target='_blank'><img src='http://www.winecellarinnovations.com/footer-blog-img.png' alt='Blog' width='55' height='58' align='middle' /></a> "
        sHTMLBody += "<a href='http://twitter.com/WCICellars' target='_blank'><img src='http://www.winecellarinnovations.com/twitter-social-img-footer.png' alt='Twitter' width='55' height='58' align='middle' /></a> "
        sHTMLBody += "<a href='http://www.facebook.com/WineCellarInnovations' target='_blank'><img src='http://www.winecellarinnovations.com/facebook-social-img-2.png' alt='Facebook' width='55' height='58' align='middle' /></a>"
        sHTMLBody += "<a href='http://www.youtube.com/winecellarinnovation'  target='_blank'><img src='http://www.winecellarinnovations.com/you-tube-social-img-2.png'  alt='YouTube' width='55' height='58' align='middle' /></a>"
        sHTMLBody += "  </td>"
        sHTMLBody += " </tr>"
        sHTMLBody += " <tr>"
        sHTMLBody += "  <td style='padding:.75pt .75pt .75pt .75pt'>"
        sHTMLBody += "  <p class=MsoNormal><font size=2 face=Arial><span style='font-size:10.0pt;"
        sHTMLBody += "  font-family:Arial'><o:p>&nbsp;</o:p></span></font></p>"
        sHTMLBody += "  <p class=MsoNormal><font size=2 face=Arial><span style='font-size:10.0pt;"
        sHTMLBody += "  font-family:Arial'><a"
        sHTMLBody += "  href='https://secure.campaigner.com/Campaigner/Public/Form10.aspx?fid=463152'><font"
        sHTMLBody += "  color=black><span style='color:windowtext;text-decoration:none'><img"
        sHTMLBody += "  border=0 id='_x0000_i1053' width='46' height='58'"
        sHTMLBody += "  src='http://www.winecellarinnovations.com/email-social-img-footer.png'></span></font></a>&nbsp;Would you"
        sHTMLBody += "  like to hear from us?<span class=textlinksstyle2><o:p></o:p></span></span></font></p>"
        sHTMLBody += "  <p class=MsoNormal><strong><b><font size=2 face=Arial><span style='font-size:"
        sHTMLBody += "  10.0pt;font-family:Arial;font-weight:normal'><span xmlns='http://www.w3.org/1999/xhtml'>Subscribe</span></font></b></strong><font"
        sHTMLBody += "  size=2 face=Arial><span style='font-size:10.0pt;font-family:Arial'> to"
        sHTMLBody += "  receive quarterly emails from us, as well as important announcements and"
        sHTMLBody += "  sales info.</span></font><font size=2><span style='font-size:10.0pt'> </span></span></font><o:p></o:p></p>"
        sHTMLBody += "  </td>"
        sHTMLBody += "  <td style='padding:.75pt .75pt .75pt .75pt'>"
        sHTMLBody += "  <p class=MsoNormal><font size=2 face='Times New Roman'><span"
        sHTMLBody += "  style='font-size:10.0pt'><o:p>&nbsp;</o:p></span></font></p>"
        sHTMLBody += "  </td>"
        sHTMLBody += " </tr>"
        sHTMLBody += "</table>"

        AddLinksAtBottom = sHTMLBody
    End Function
    Public Sub AddSourceCode(ByVal ContactSerial As Long, ByVal SourceCode As String)
        Dim cmd As New SqlCommand("select cont_src_serial from cont_src where cont_src_cont_serial=" + CStr(ContactSerial) + " and cont_src_ord_src='" + Replace(SourceCode, "'", "''") + "'", cnn)
        If nz(cmd.ExecuteScalar, 0) = 0 Then
            cmd.CommandText = "insert into cont_src (cont_src_cont_serial,cont_src_ord_src) values (" + CStr(ContactSerial) + ",'" + Replace(SourceCode, "'", "''") + "')"
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Public Sub WaitSec(ByVal Sec As Integer)
        Dim start As Date = Now
        Do While DateDiff(DateInterval.Second, start, Now) <= Sec
            Application.DoEvents()
        Loop
    End Sub
End Module
