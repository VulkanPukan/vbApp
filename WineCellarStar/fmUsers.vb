Imports System.Data.SqlClient
Public Class fmUsers
    Inherits WineCellar.fmStarter
    Dim dsSec As New DataSet
    Dim daSec As New SqlDataAdapter
    Dim AllowSelect As Boolean = True
    Friend WithEvents cbInactive As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbShowInactive As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Dim cmd As New SqlCommand("", cnn)
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
    Friend WithEvents tUsers As System.Windows.Forms.ListBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tUserType As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents tUserName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tGroup As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Tree1 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sec_serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sec_usr_serial")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sec_screen")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sec_access")
        Dim UltraTreeNode1 As Infragistics.Win.UltraWinTree.UltraTreeNode = New Infragistics.Win.UltraWinTree.UltraTreeNode
        Dim Override1 As Infragistics.Win.UltraWinTree.Override = New Infragistics.Win.UltraWinTree.Override
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmUsers))
        Me.tUsers = New System.Windows.Forms.ListBox
        Me.tUserName = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.tUserType = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.tGroup = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Tree1 = New Infragistics.Win.UltraWinTree.UltraTree
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cbInactive = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbShowInactive = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.tUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tUserType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbInactive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbShowInactive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tUsers
        '
        Me.tUsers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tUsers.ItemHeight = 16
        Me.tUsers.Location = New System.Drawing.Point(10, 9)
        Me.tUsers.Name = "tUsers"
        Me.tUsers.Size = New System.Drawing.Size(163, 740)
        Me.tUsers.TabIndex = 0
        '
        'tUserName
        '
        Me.tUserName.Enabled = False
        Me.tUserName.Location = New System.Drawing.Point(298, 18)
        Me.tUserName.Name = "tUserName"
        Me.tUserName.Size = New System.Drawing.Size(163, 24)
        Me.tUserName.TabIndex = 1
        Me.tUserName.Tag = "edit;usr_name"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(182, 18)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(116, 19)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "User Name"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(182, 46)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(116, 19)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Password"
        '
        'UltraTextEditor2
        '
        Me.UltraTextEditor2.Enabled = False
        Me.UltraTextEditor2.Location = New System.Drawing.Point(298, 46)
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.Size = New System.Drawing.Size(163, 24)
        Me.UltraTextEditor2.TabIndex = 3
        Me.UltraTextEditor2.Tag = "edit;usr_password"
        '
        'tUserType
        '
        Appearance1.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Me.tUserType.Appearance = Appearance1
        Me.tUserType.BackColor = System.Drawing.Color.Transparent
        Me.tUserType.BackColorInternal = System.Drawing.Color.Transparent
        Me.tUserType.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.tUserType.Enabled = False
        ValueListItem1.DataValue = "User"
        ValueListItem1.DisplayText = "User"
        ValueListItem2.DataValue = "Group"
        ValueListItem2.DisplayText = "Group"
        Me.tUserType.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.tUserType.Location = New System.Drawing.Point(490, 18)
        Me.tUserType.Name = "tUserType"
        Me.tUserType.Size = New System.Drawing.Size(316, 56)
        Me.tUserType.TabIndex = 5
        Me.tUserType.Tag = "edit;usr_type"
        '
        'tGroup
        '
        Me.tGroup.CheckedListSettings.CheckStateMember = ""
        Me.tGroup.Enabled = False
        Me.tGroup.Location = New System.Drawing.Point(298, 119)
        Me.tGroup.Name = "tGroup"
        Me.tGroup.Size = New System.Drawing.Size(163, 25)
        Me.tGroup.TabIndex = 6
        Me.tGroup.Tag = "edit;usr_group;nm"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(182, 119)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(116, 18)
        Me.UltraLabel3.TabIndex = 7
        Me.UltraLabel3.Text = "Member Of"
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.Caption = "Screen Name"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 177
        UltraGridColumn4.Header.Caption = "Access"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.Grid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.Grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(184, 151)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(402, 658)
        Me.Grid1.TabIndex = 8
        Me.Grid1.Tag = "edit"
        '
        'Tree1
        '
        Me.Tree1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Tree1.Enabled = False
        Me.Tree1.ImageList = Me.ImageList1
        Me.Tree1.Location = New System.Drawing.Point(614, 9)
        Me.Tree1.Name = "Tree1"
        UltraTreeNode1.Text = "Menu"
        Me.Tree1.Nodes.AddRange(New Infragistics.Win.UltraWinTree.UltraTreeNode() {UltraTreeNode1})
        Override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.[Single]
        Me.Tree1.Override = Override1
        Me.Tree1.Size = New System.Drawing.Size(442, 800)
        Me.Tree1.TabIndex = 9
        Me.Tree1.Tag = "Edit"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        '
        'cbInactive
        '
        Me.cbInactive.Enabled = False
        Me.cbInactive.Location = New System.Drawing.Point(491, 72)
        Me.cbInactive.Name = "cbInactive"
        Me.cbInactive.Size = New System.Drawing.Size(93, 15)
        Me.cbInactive.TabIndex = 10
        Me.cbInactive.Tag = "edit;inactive;cb"
        Me.cbInactive.Text = "Inactive"
        '
        'cbShowInactive
        '
        Me.cbShowInactive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbShowInactive.Location = New System.Drawing.Point(10, 795)
        Me.cbShowInactive.Name = "cbShowInactive"
        Me.cbShowInactive.Size = New System.Drawing.Size(129, 14)
        Me.cbShowInactive.TabIndex = 11
        Me.cbShowInactive.Tag = ""
        Me.cbShowInactive.Text = "Show Inactive"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(182, 72)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(116, 18)
        Me.UltraLabel4.TabIndex = 13
        Me.UltraLabel4.Text = "Rep Code"
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.Enabled = False
        Me.UltraTextEditor1.Location = New System.Drawing.Point(298, 72)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(163, 24)
        Me.UltraTextEditor1.TabIndex = 12
        Me.UltraTextEditor1.Tag = "edit;usr_osr"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "(if user is an OSR)"
        '
        'fmUsers
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1457, 816)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.UltraTextEditor1)
        Me.Controls.Add(Me.cbShowInactive)
        Me.Controls.Add(Me.cbInactive)
        Me.Controls.Add(Me.Tree1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.tGroup)
        Me.Controls.Add(Me.tUserType)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraTextEditor2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.tUserName)
        Me.Controls.Add(Me.tUsers)
        Me.Name = "fmUsers"
        Me.Text = "Users"
        CType(Me.tUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tUserType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbInactive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbShowInactive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub fmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Table = "usr_file"
        Me.Key1 = "usr_serial"
        Me.FocusField = "tusername"
        LoadUsers()
        LoadDD2(tGroup, "usr_file", "usr_serial", "usr_name", "usr_serial,usr_name", "usr_type='Group'")
        AddValueList(Grid1, "sec_screen", "sec_scrn_name", "sec_scrn_name", "select * from sec_scrn")
        AddValueList(Grid1, "sec_access", "sec_value", "sec_level", "select * from sec_levels")
        LoadGrid(Grid1, daSec, dsSec, "select * from sec_file where sec_usr_serial=-1 order by sec_screen", "sec_file")
        LoadMenu(MainForm.Menu.MenuItems, Tree1.Nodes(0), "Menu")
        Tree1.ExpandAll(Infragistics.Win.UltraWinTree.ExpandAllType.Always)
    End Sub
    Private Sub LoadMenu(ByVal MI As Menu.MenuItemCollection, ByVal Node As Infragistics.Win.UltraWinTree.UltraTreeNode, ByVal ParentName As String)
        Dim Child As MenuItem
        For Each Child In MI
            Dim NewNode As New Infragistics.Win.UltraWinTree.UltraTreeNode
            NewNode = Node.Nodes.Add(ParentName + "/" + Child.Text, Child.Text)
            NewNode.Key = NewNode.FullPath
            If Child.MenuItems.Count > 0 Then
                LoadMenu(Child.MenuItems, NewNode, Child.Text)
            End If
        Next
    End Sub
    Private Sub AddValueList(ByVal Gridx As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal ColName As String, ByVal ValField As String, ByVal DisField As String, ByVal Wherex As String)
        If Grid1.DisplayLayout.ValueLists.Exists(ColName) Then Exit Sub
        Dim objValueList As Infragistics.Win.ValueList
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dr As SqlDataReader

        cmd.Connection = cnn
        cmd.CommandText = Wherex
        da.SelectCommand = cmd
        cnn.Open()
        dr = cmd.ExecuteReader

        objValueList = Grid1.DisplayLayout.ValueLists.Add(ColName)
        Do While dr.Read
            If Not dr(ValField) Is DBNull.Value Then
                objValueList.ValueListItems.Add(dr(ValField), dr(DisField))
            End If
        Loop
        cnn.Close()
        Grid1.DisplayLayout.Bands(0).Columns(ColName).ValueList = Grid1.DisplayLayout.ValueLists(ColName)
    End Sub
    Private Sub LoadUsers()
        Dim cmd As New SqlCommand("select usr_name from usr_file" + IIf(cbShowInactive.Checked, "", " where inactive<>1") + " order by usr_name", cnn)
        Dim dr As SqlDataReader
        Try
            cnn.Open()
            dr = cmd.ExecuteReader
            tUsers.Items.Clear()
            Do While dr.Read
                tUsers.Items.Add(dr("usr_name"))
            Loop
            dr.Close()
        Catch
            DoError(Err, Me)
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tUserType.Value = "G"
    End Sub

    Private Sub tUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tUsers.SelectedIndexChanged
        Dim cmd As New SqlCommand("select usr_serial from usr_file where usr_name='" + Trim(tUsers.SelectedItem) + "'", cnn)
        cnn.Open()
        KeyValue1 = CStr(cmd.ExecuteScalar)
        cnn.Close()
        LoadFields(Me)
        LoadGrid(Grid1, daSec, dsSec, "select * from sec_file where sec_usr_serial=" + KeyValue1 + " order by sec_screen", "sec_file")
        LoadTreeImg()
        EditButtons("Idle")
    End Sub
    Private Sub LoadTreeImg()
        ClearTreeImg(Tree1.Nodes)
        Dim dr As SqlDataReader
        Dim key As String
        cmd.CommandText = "select * from usr_mnu where usr_mnu_usr_serial=" + KeyValue1
        cnn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            Dim nd As New Infragistics.Win.UltraWinTree.UltraTreeNode
            key = dr("usr_mnu_itm")
            nd = Tree1.GetNodeByKey(key)
            If key <> "Menu" And Not nd Is Nothing Then nd.Override.NodeAppearance.Image = dr("usr_mnu_value")
        Loop
        dr.Close()
        cnn.Close()
    End Sub
    Private Sub ClearTreeImg(ByVal nds As Infragistics.Win.UltraWinTree.TreeNodesCollection)
        Dim nd As Infragistics.Win.UltraWinTree.UltraTreeNode
        For Each nd In nds
            nd.Override.NodeAppearance.Image = Nothing
            If nd.HasNodes Then ClearTreeImg(nd.Nodes)
        Next
    End Sub
    Private Sub tUsers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tUsers.Click
    End Sub

    Public Overrides Sub Add_After()
        tUserType.Text = "User"
        dsSec.Clear()
    End Sub

    Public Overrides Sub Save_After()
        Dim x As Integer
        Grid1.UpdateData()
        BindingContext(dsSec, "sec_file").EndCurrentEdit()
        For x = 0 To dsSec.Tables("sec_file").Rows.Count - 1
            If dsSec.Tables("sec_file").Rows(x).RowState <> DataRowState.Deleted Then
                dsSec.Tables("sec_file").Rows(x).Item("sec_usr_serial") = CLng(KeyValue1)
            End If
        Next
        cnn.Open()
        daSec.Update(dsSec, "sec_file")

        cmd.CommandText = "delete from usr_mnu where usr_mnu_usr_serial=" + KeyValue1
        cmd.ExecuteNonQuery()
        SaveMenu(Tree1.Nodes(0))
        cnn.Close()

        LoadUsers()
    End Sub
    Private Sub SaveMenu(ByVal nd As Infragistics.Win.UltraWinTree.UltraTreeNode)
        If nd.Override.NodeAppearance.Image <> Nothing Then
            cmd.CommandText = "insert into usr_mnu (usr_mnu_usr_serial,usr_mnu_itm,usr_mnu_value) values (" + KeyValue1 + ",'" + nd.FullPath + "'," + CStr(nd.Override.NodeAppearance.Image) + ")"
            cmd.ExecuteNonQuery()
        End If
        If nd.HasNodes Then
            Dim nd2 As New Infragistics.Win.UltraWinTree.UltraTreeNode
            For Each nd2 In nd.Nodes
                SaveMenu(nd2)
            Next
        End If
    End Sub
    Private Sub Tree1_AfterSelect(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTree.SelectEventArgs) Handles Tree1.AfterSelect
        If AllowSelect Then
            AllowSelect = False
            If Tree1.ActiveNode.Override.NodeAppearance.Image = 1 Then
                NodeImage(e.NewSelections.Item(0), 2)
            Else
                If Tree1.ActiveNode.Override.NodeAppearance.Image = 2 Then
                    NodeImage(e.NewSelections.Item(0), Nothing)
                Else
                    NodeImage(e.NewSelections.Item(0), 1)
                    If Not e.NewSelections.Item(0).Parent Is Nothing Then
                        NodeImageUp(e.NewSelections.Item(0).Parent, 1)
                    End If
                End If
            End If
            e.NewSelections.Item(0).Selected = False
            AllowSelect = True
        End If
    End Sub
    Private Sub NodeImage(ByVal Nd As Infragistics.Win.UltraWinTree.UltraTreeNode, ByVal img As Object)
        Nd.Override.NodeAppearance.Image = img
        If Nd.HasNodes Then
            Dim nd2 As Infragistics.Win.UltraWinTree.UltraTreeNode
            For Each nd2 In Nd.Nodes
                NodeImage(nd2, img)
            Next
        End If
    End Sub
    Private Sub NodeImageUp(ByVal Nd As Infragistics.Win.UltraWinTree.UltraTreeNode, ByVal img As Object)
        Nd.Override.NodeAppearance.Image = img
        If Not Nd.Parent Is Nothing Then NodeImageUp(Nd.Parent, img)
    End Sub
    Private Sub Tree1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tree1.Click
    End Sub

    Private Sub Tree1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tree1.DoubleClick
        MsgBox(Tree1.ActiveNode.Key)
    End Sub

    Private Sub cbShowInactive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShowInactive.CheckedChanged
        If Me.ActiveControl Is cbShowInactive Then LoadUsers()
    End Sub
End Class
