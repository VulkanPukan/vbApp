Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class fmToDoList
    Inherits WineCellar.fmStarter
    Dim dsToDo As New DataSet
    Dim daToDo As New SqlDataAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Dim UserList As String

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
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents bCheckAll As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bClear As Infragistics.Win.Misc.UltraButton
    Friend WithEvents pUsers As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_user")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_button")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_created")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_created_by")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_note")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_complete")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_completed_by")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_next_user")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_type")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_button_type")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_ord_serial")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_ord_rev")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_ord_type")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_completed_date")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_misc_text")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_misc_num")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_sold_cust_id")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_tax_exempt_no")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ord_ship_state")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_popup")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_popup_ack")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_popup_ack_dt")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("to_do_popup_ack_by")
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.bCheckAll = New Infragistics.Win.Misc.UltraButton()
        Me.bClear = New Infragistics.Win.Misc.UltraButton()
        Me.pUsers = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 63
        UltraGridColumn2.Header.Caption = "User"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MinWidth = 75
        UltraGridColumn2.Width = 78
        UltraGridColumn3.Header.Caption = "Go To"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MinWidth = 75
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn3.Width = 82
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn4.Header.Caption = "Created"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.MaxWidth = 100
        UltraGridColumn4.MinWidth = 100
        UltraGridColumn4.Width = 100
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn5.Header.Caption = "Created By"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MaxWidth = 100
        UltraGridColumn5.MinWidth = 100
        UltraGridColumn5.Width = 100
        UltraGridColumn6.Header.Caption = "Note"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.MinWidth = 200
        UltraGridColumn6.Width = 297
        UltraGridColumn7.Header.Caption = "Complete"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.MaxWidth = 60
        UltraGridColumn7.MinWidth = 60
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn7.Width = 60
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 120
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn9.Header.Caption = "Send To"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.MaxWidth = 100
        UltraGridColumn9.MinWidth = 100
        UltraGridColumn9.Width = 100
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 86
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 93
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.Width = 67
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Width = 75
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.Width = 87
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.Width = 84
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.Width = 74
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 89
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.Width = 8
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Width = 33
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.Hidden = True
        UltraGridColumn20.Width = 46
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.Hidden = True
        UltraGridColumn21.Width = 16
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.Width = 17
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.Width = 20
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.Width = 27
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 3)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(838, 561)
        Me.Grid1.TabIndex = 0
        '
        'UltraButton1
        '
        Me.UltraButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(2, 568)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(202, 37)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "Update Changes"
        '
        'bCheckAll
        '
        Me.bCheckAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCheckAll.Location = New System.Drawing.Point(927, 574)
        Me.bCheckAll.Name = "bCheckAll"
        Me.bCheckAll.Size = New System.Drawing.Size(87, 29)
        Me.bCheckAll.TabIndex = 6
        Me.bCheckAll.Text = "Check All"
        '
        'bClear
        '
        Me.bClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bClear.Location = New System.Drawing.Point(844, 574)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(77, 29)
        Me.bClear.TabIndex = 5
        Me.bClear.Text = "Clear"
        '
        'pUsers
        '
        Me.pUsers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pUsers.AutoScroll = True
        Me.pUsers.Location = New System.Drawing.Point(844, 3)
        Me.pUsers.Name = "pUsers"
        Me.pUsers.Size = New System.Drawing.Size(182, 565)
        Me.pUsers.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Grid1)
        Me.Panel1.Controls.Add(Me.UltraButton1)
        Me.Panel1.Controls.Add(Me.bCheckAll)
        Me.Panel1.Controls.Add(Me.pUsers)
        Me.Panel1.Controls.Add(Me.bClear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 610)
        Me.Panel1.TabIndex = 7
        '
        'fmToDoList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1029, 610)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "fmToDoList"
        Me.Text = "To Do List"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmToDoList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If UserISRAdmin Then
        'Dim cmd As New SqlCommand("", cnn2)
        'cmd.CommandText = "select usr_isr_list from usr_file where usr_name='" + User + "'"
        'cnn2.Open()
        'UserList = UCase(nz(cmd.ExecuteScalar, "") + ",*" + User + "*")

        'cmd.CommandText = "select * from usr_file order by usr_name"
        'Dim dr As SqlClient.SqlDataReader
        'Dim cnt As Integer = 0
        'dr = cmd.ExecuteReader
        'Do While dr.Read
        '    If InStr(UserList, "*" + UCase(dr("usr_name")) + "*") > 0 Then
        '        Dim cb As New CheckBox
        '        cb.Text = UCase(dr("usr_name"))
        '        cb.Checked = True
        '        cb.Top = cnt * 20
        '        cnt += 1
        '        AddHandler cb.Click, AddressOf UserClick
        '        pUsers.Controls.Add(cb)
        '    Else
        '        'cb.Checked = False
        '    End If
        'Loop
        'cnn2.Close()
        'Else
        'bClear.Visible = False
        'bCheckAll.Visible = False
        'End If

        Dim cmd As New SqlCommand("", cnn2)
        cnn2.Open()

        cmd.CommandText = "select usr_isr_list from usr_file where usr_name='" + User + "'"
        UserList = UCase(nz(cmd.ExecuteScalar, "") + ",*" + User + "*")
        cmd.CommandText = "select * from rep_file where (rep_active=1 and (rep_type='I' or rep_type='C')) or (rep_code ='ERIK') order by rep_code"
        Dim dr As SqlClient.SqlDataReader
        Dim cnt As Integer = 0
        dr = cmd.ExecuteReader
        Do While dr.Read
            Dim cb As New CheckBox
            cb.Text = UCase(dr("rep_code"))
            If InStr(UserList, "*" + UCase(dr("rep_code")) + "*") > 0 Then
                cb.Checked = True
            Else
                cb.Checked = False
            End If
            cb.Top = cnt * 20
            cb.Width = 175
            cnt += 1
            AddHandler cb.Click, AddressOf UserClick
            pUsers.Controls.Add(cb)
        Loop
        cnn2.Close()

    End Sub
    Private Sub UserClick(ByVal sender As Object, ByVal e As EventArgs)
        LoadList()
        SetUsers()
    End Sub
    Private Sub SetUsers()
        Dim cb As CheckBox
        Dim users As String = ""
        For Each cb In pUsers.Controls
            If cb.Checked Then users += "*" + cb.Text + "*,"
        Next
        Dim cmd As New SqlClient.SqlCommand("update usr_file set usr_isr_list='" + users + "' where usr_name='" + User + "'", cnn2)
        cnn2.Open()
        cmd.ExecuteNonQuery()
        cnn2.Close()
    End Sub
    Public Sub LoadList()
        'Dim cmd As New SqlCommand("select to_do_serial,to_do_type,to_do_ord_serial,to_do_ord_rev,to_do_ord_type,to_do_button,to_do_button_type,to_do_note,to_do_created,to_do_created_by,to_do_complete,to_do_next_user from to_do left outer join ord_gen on (to_do_ord_serial=ord_gen_ord_serial and to_do_ord_rev=ord_gen_rev and to_do_ord_type=ord_gen_type) where to_do_user='" + User + "' and to_do_complete<>1", cnn)
        Dim Users As String = ""
        'If UserISRAdmin Then
        Dim cb As CheckBox
        For Each cb In pUsers.Controls
            If cb.Checked Then Users += "'" + cb.Text + "',"
        Next
        Users += "'" + User + "',"
        If Len(Users) > 0 Then
            Users = Users + Mid(Users, 1, Len(Users) - 1)
        Else
            Users = "''"
        End If
        'Else
        'Users = "'" + User + "'"
        'End If
        Users = UCase(Users)
        Dim cmd As New SqlCommand("", cnn)
        Dim dr As DataRow

        cmd.CommandText = "select to_do_serial,to_do_ord_serial,ord_sold_cust_id,ord_tax_exempt_no,ord_ship_state from to_do,ord_file where to_do_ord_serial=ord_serial and to_do_user in (" + Users + ") and to_do_complete<>1 and to_do_type='TAX'"
        dsToDo.Clear()
        daToDo.SelectCommand = cmd
        cnn.Open()
        daToDo.Fill(dsToDo)
        For Each dr In dsToDo.Tables(0).Rows
            If nz(dr("ord_sold_cust_id")) = "" Then
                cmd.CommandText = "select count(tax_cert_serial) from tax_cert where isnull(tax_cert_cust_id,'')='' and tax_cert_no='" + dr("ord_tax_exempt_no") + "' and tax_cert_state='" + dr("ord_ship_state") + "'"
            Else
                cmd.CommandText = "select count(tax_cert_serial) from tax_cert where tax_cert_cust_id='" + dr("ord_sold_cust_id") + "' and tax_cert_no='" + dr("ord_tax_exempt_no") + "'"
            End If
            If nz(cmd.ExecuteScalar, 0) > 0 Then
                cmd.CommandText = "update to_do set to_do_complete=1 where to_do_serial=" + CStr(dr("to_do_serial"))
                cmd.ExecuteNonQuery()
            Else
                cmd.CommandText = "select ord_serial from ord_file where ord_serial=" + CStr(dr("to_do_ord_serial")) + " and ord_tax_exempt=1"
                If nz(cmd.ExecuteScalar, 0) = 0 Then
                    cmd.CommandText = "update to_do set to_do_complete=1 where to_do_serial=" + CStr(dr("to_do_serial"))
                    cmd.ExecuteNonQuery()
                End If
            End If
        Next

        cmd.CommandText = "select * from to_do where to_do_user in (" + Users + ") and to_do_complete<>1"
        dsToDo.Clear()
        daToDo.SelectCommand = cmd
        daToDo.Fill(dsToDo)
        Grid1.DataSource = dsToDo.Tables(0)
        cnn.Close()
    End Sub

    Private Sub Grid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid1.InitializeLayout

    End Sub

    Private Sub Grid1_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid1.ClickCellButton
        Dim tdType As String = Grid1.ActiveRow.Cells("to_do_button_type").Value.ToString
        Select Case tdType
            Case "Order"
                Dim Tabx As String = ""
                Dim fm As fmEstOrd2

                fm = LoadForm("Quotes/Orders")
                If fm.EditMode <> "" Then
                    MsgBox("You must first save or cancel this Quote/Order", MsgBoxStyle.Information, "Save?")
                    fm = Nothing
                    Exit Sub
                End If
                Select Case Split(Grid1.ActiveCell.Text, "-").Length
                    Case 2
                        Tabx = "Q" + Split(Grid1.ActiveCell.Text, "-")(1)
                    Case 3
                        Tabx = "O" + Split(Grid1.ActiveCell.Text, "-")(2)
                End Select
                fm.KeyValue1 = Split(Grid1.ActiveCell.Text, "-")(0)
                fm.tOrd.Text = fm.KeyValue1
                fm.LoadPage()
                If Tabx <> "" Then
                    fm.Tab1.Tabs(Tabx).Selected = True
                    fm.TabItems.Tabs("General").Selected = True
                End If
            Case Else '-- "Contact"
                Dim fmCont As fmContacts
                fmCont = LoadForm("Contacts")
                fmCont.KeyValue1 = Grid1.ActiveRow.Cells("to_do_ord_serial").Value.ToString
                LoadFields(fmCont)
                fmCont.LoadNotes()
                fmCont.LoadSourceCodes()
                EditButtons("Idle")
        End Select
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim rw As DataRow
        Dim cmd As New SqlCommand("", cnn)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow
        Dim onToDo As Long
        Dim WhoNext, onUser As String

        Try
            Grid1.UpdateData()
            cnn.Open()
            For Each rw In dsToDo.Tables(0).Rows
                If rw.RowState = DataRowState.Modified Then
                    cmd.CommandText = "update to_do set to_do_note='" + Replace(rw("to_do_note"), "'", "''") + "', to_do_complete=" + IIf(rw("to_do_complete"), "1", "0") + " where to_do_serial=" + CStr(rw("to_do_serial"))
                    cmd.ExecuteNonQuery()
                    If rw("to_do_complete") Then
                        cmd.CommandText = "update to_do set to_do_completed_date='" + CStr(Now) + "', to_do_completed_by='" + User + "' where to_do_serial=" + CStr(rw("to_do_serial"))
                        cmd.ExecuteNonQuery()
                        If nz(rw("to_do_next_user")) <> "" Then
                            If Split(rw("to_do_next_user"), ",").Length > 1 Then
                                WhoNext = Mid(rw("to_do_next_user"), Len(Split(rw("to_do_next_user"), ",")(0)) + 2)
                                onUser = Split(rw("to_do_next_user"), ",")(0)
                            Else
                                onUser = rw("to_do_next_user")
                                WhoNext = ""
                            End If
                            onToDo = AddToDo(rw("to_do_type"), onUser, rw("to_do_note"), rw("to_do_ord_serial"), rw("to_do_ord_rev"), rw("to_do_ord_type"), WhoNext, rw("to_do_button"), rw("to_do_button_type"), rw("to_do_misc_text"), rw("to_do_misc_num"))
                        Else
                            Select Case rw("to_do_type")
                                Case "REF"
                                    cmd.CommandText = "update ord_gen set ord_gen_ref_paid = ord_gen_ref_paid + " + CStr(rw("to_do_misc_num")) + " where ord_gen_ord_serial=" + CStr(rw("to_do_ord_serial")) + " and ord_gen_rev=" + CStr(rw("to_do_ord_rev")) + " and ord_gen_type='" + rw("to_do_ord_type") + "'"
                                    cmd.ExecuteNonQuery()
                                    UpdateRefLedger(rw("to_do_ord_serial"), rw("to_do_ord_rev"), rw("to_do_ord_type"), "APPROVED", rw("to_do_serial"), rw("to_do_misc_num"))

                                    Dim SpecNote As String
                                    cmd.CommandText = "select ord_ref_note from ord_file where ord_serial=" + CStr(rw("to_do_ord_serial"))
                                    SpecNote = nz(cmd.ExecuteScalar)
                                    If SpecNote <> "" Then
                                        AddToDo("REFERRAL", "bambim", "Referral Special Handling Required: " + SpecNote, rw("to_do_ord_serial"), , , , CStr(rw("to_do_ord_serial")), "Order")
                                    End If
                                Case "ShipMod"
                                    Dim app As New Outlook.Application
                                    Dim mailx As Outlook.MailItem
                                    Dim itm As String

                                    Try
                                        Dim output As String = ""
                                        'output = PDFPath + fmEstOrd.tOrd.Text + " (" + fmEstOrd.tord_for.Text + ")\" + fmEstOrd.tOrd.Text + "-" + Mid(fmEstOrd.Tab1.ActiveTab.Text, 7) + " (" + fmEstOrd.tord_for.Text + ") ORDER.pdf"
                                        'If IO.File.Exists(output) Then attach = output

                                        cmd.CommandText = "select ord_gen_ord_serial,ord_gen_rev,ord_gen_from_rev,ord_for,ord_gen_install_dt,ord_gen_installer,installer_name from ord_gen left outer join installer_file on ord_gen_installer=installer_serial,ord_file where ord_gen_ord_serial=ord_serial and ord_gen_ord_serial=" + CStr(rw("to_do_ord_serial")) + " and ord_gen_rev=" + CStr(rw("to_do_ord_rev")) + " and ord_gen_type='" + rw("to_do_ord_type") + "'"
                                        dt.Clear()
                                        da.Fill(dt)
                                        If dt.Rows.Count > 0 Then
                                            dr = dt.Rows(0)
                                            If InStr(rw("to_do_note"), "Shipping Address Changed: YES") > 0 Then
                                                Select Case nz(rw("to_do_ord_type"))
                                                    Case "O"
                                                        output = PDFPath + CStr(dr("ord_gen_ord_serial")) + " (" + nz(dr("ord_for")) + ")\" + CStr(dr("ord_gen_ord_serial")) + "-" + CStr(dr("ord_gen_from_rev")) + "-" + CStr(dr("ord_gen_rev")) + " (" + CStr(dr("ord_for")) + ") ORDER.pdf"
                                                    Case "R"
                                                        output = PDFPath + CStr(dr("ord_gen_ord_serial")) + " (" + nz(dr("ord_for")) + ")\" + CStr(dr("ord_gen_ord_serial")) + "-" + CStr(dr("ord_gen_from_rev")) + "-" + CStr(dr("ord_gen_rev")) + " (" + CStr(dr("ord_for")) + ") REPLACEMENT.pdf"
                                                End Select
                                                DisplayReport("quote landscape", "{ord_file.ord_serial} = " + CStr(dr("ord_gen_ord_serial")) + " and {ord_gen.ord_gen_rev} = " + CStr(dr("ord_gen_rev")) + " and {ord_gen.ord_gen_type}='" + rw("to_do_ord_type") + "'", True, 1, True, , False, False, , , output)
                                            End If

                                            mailx = app.CreateItem(Outlook.OlItemType.olMailItem)
                                            mailx.To = "scarr@winecellarinnovations.com"

                                            If InStr(rw("to_do_note"), "Shipping Release: YES") > 0 Then mailx.Subject += "Shipping Release "
                                            If InStr(rw("to_do_note"), "Shipping Hold: YES") > 0 Then mailx.Subject += "Shipping Hold "
                                            If mailx.Subject = "" Then mailx.Subject = "Shipping Modification "
                                            mailx.Subject += " for " + rw("to_do_button") + " (" + nz(dr("ord_for")) + ")"

                                            mailx.Body = mailx.Subject + vbCrLf + vbCrLf + rw("to_do_note") + vbCrLf + vbCrLf
                                            If dr("ord_gen_install_dt") Is DBNull.Value Then
                                                mailx.Body += "Install Date: None"
                                            Else
                                                mailx.Body += "Install Date: " + Format(dr("ord_gen_install_dt"), "MM/dd/yyyy")
                                            End If
                                            mailx.Body += vbCrLf + "Installer: " + nz(dr("installer_name"))

                                            If output <> "" Then mailx.Attachments.Add(output)
                                            mailx.Display()
                                        End If
                                    Catch
                                        DoError(Err, Me)
                                    End Try
                                Case "OrdMod"
                                    Dim app As New Outlook.Application
                                    Dim mailx As Outlook.MailItem
                                    Dim itm As String

                                    Try
                                        Dim output As String
                                        'output = PDFPath + fmEstOrd.tOrd.Text + " (" + fmEstOrd.tord_for.Text + ")\" + fmEstOrd.tOrd.Text + "-" + Mid(fmEstOrd.Tab1.ActiveTab.Text, 7) + " (" + fmEstOrd.tord_for.Text + ") ORDER.pdf"
                                        'If IO.File.Exists(output) Then attach = output

                                        cmd.CommandText = "select ord_gen_ord_serial,ord_gen_rev,ord_gen_from_rev,ord_for,ord_gen_install_dt,ord_gen_installer from ord_gen,ord_file where ord_gen_ord_serial=ord_serial and ord_gen_ord_serial=" + CStr(rw("to_do_ord_serial")) + " and ord_gen_rev=" + CStr(rw("to_do_ord_rev")) + " and ord_gen_type='" + rw("to_do_ord_type") + "'"
                                        dt.Clear()
                                        da.Fill(dt)
                                        If dt.Rows.Count > 0 Then
                                            dr = dt.Rows(0)
                                            'output = PDFPath + CStr(dr("ord_gen_ord_serial")) + " (" + nz(dr("ord_for")) + ")\" + CStr(dr("ord_gen_ord_serial")) + "-" + CStr(dr("ord_gen_from_rev")) + "-" + CStr(dr("ord_gen_rev")) + " (" + CStr(dr("ord_for")) + ") ORDER.pdf"
                                            'DisplayReport("quote landscape", "{ord_file.ord_serial} = " + CStr(dr("ord_gen_ord_serial")) + " and {ord_gen.ord_gen_rev} = " + CStr(dr("ord_gen_from_rev")) + " and {ord_gen.ord_gen_type}='O'", True, 1, True, , False, False, , , output)

                                            mailx = app.CreateItem(Outlook.OlItemType.olMailItem)
                                            mailx.To = "sharonr@winecellarinnovations.com;scarr@winecellarinnovations.com;sgeorge@winecellarinnovations.com;stuttle@winecellarinnovations.com;dgoff@winecellarinnovations.com;christy@winecellarinnovations.com"

                                            'mailx.Body = "Order Modification for " + rw("to_do_button") + vbCrLf + vbCrLf + rw("to_do_note") + vbCrLf + vbCrLf
                                            'If dr("ord_gen_install_dt") Is DBNull.Value Then
                                            '    mailx.Body += "Install Date: None"
                                            'Else
                                            '    mailx.box += "Install Date: " + Format(dr("ord_gen_install_dt"), "MM/dd/yyyy")
                                            'End If
                                            'mailx.Body += vbCrLf + "Installer: " + nz(dr("ord_gen_installer"))
                                            mailx.Body = rw("to_do_note")

                                            mailx.Subject = "Order Modification for " + rw("to_do_button") + " (" + nz(dr("ord_for")) + ")"
                                            'mailx.Attachments.Add(output)
                                            mailx.Display()
                                        End If
                                    Catch
                                        DoError(Err, Me)
                                    End Try

                            End Select
                        End If
                    End If
                End If
            Next
            cnn.Close()
            LoadList()
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Private Sub bClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClear.Click
        Dim cb As CheckBox
        For Each cb In pUsers.Controls
            cb.Checked = False
        Next
        SetUsers()
        LoadList()

    End Sub

    Private Sub bCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCheckAll.Click
        Dim cb As CheckBox
        For Each cb In pUsers.Controls
            cb.Checked = True
        Next
        SetUsers()
        LoadList()

    End Sub

    Private Sub Grid1_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.AfterCellActivate
        If Grid1.ActiveRow.Cells("to_do_type").Value = "TAX" Then
            Grid1.ActiveCell.Activation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Else
            Grid1.ActiveCell.Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
        End If
    End Sub
End Class
