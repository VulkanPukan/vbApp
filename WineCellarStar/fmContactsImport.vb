Imports System.Data
Imports System.Data.SqlClient

Public Class fmContactsImport
    Inherits System.Windows.Forms.Form
    Dim dt As New DataTable
    Dim cmdMain As New SqlCommand("", cnn)
    Dim daMain As New SqlDataAdapter(cmdMain)
    Dim cb As New SqlCommandBuilder(daMain)

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
    Friend WithEvents tFormat As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tDelimeter As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tFields As System.Windows.Forms.ListBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents bBrowse As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tFieldsFile As System.Windows.Forms.ListBox
    Friend WithEvents tPairings As System.Windows.Forms.ListBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tFormula As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents bSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bImport As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lFile As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbSkip As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tFormat = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.tDelimeter = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tFields = New System.Windows.Forms.ListBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.tFieldsFile = New System.Windows.Forms.ListBox()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.tPairings = New System.Windows.Forms.ListBox()
        Me.bBrowse = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.bSave = New Infragistics.Win.Misc.UltraButton()
        Me.tFormula = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.bImport = New Infragistics.Win.Misc.UltraButton()
        Me.lFile = New Infragistics.Win.Misc.UltraLabel()
        Me.cbSkip = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.tFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDelimeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tFormula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSkip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tFormat
        '
        Me.tFormat.CheckedListSettings.CheckStateMember = ""
        Me.tFormat.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.VisibleRows
        Me.tFormat.DisplayLayout.Override.DefaultColWidth = 200
        Me.tFormat.Location = New System.Drawing.Point(10, 9)
        Me.tFormat.Name = "tFormat"
        Me.tFormat.Size = New System.Drawing.Size(211, 25)
        Me.tFormat.TabIndex = 0
        '
        'tDelimeter
        '
        Me.tDelimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDelimeter.Location = New System.Drawing.Point(10, 65)
        Me.tDelimeter.Name = "tDelimeter"
        Me.tDelimeter.Size = New System.Drawing.Size(67, 28)
        Me.tDelimeter.TabIndex = 1
        Me.tDelimeter.Text = ","
        '
        'tFields
        '
        Me.tFields.ItemHeight = 16
        Me.tFields.Location = New System.Drawing.Point(528, 28)
        Me.tFields.Name = "tFields"
        Me.tFields.Size = New System.Drawing.Size(182, 548)
        Me.tFields.TabIndex = 2
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(10, 37)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(182, 18)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Saved Layout"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(10, 92)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(76, 19)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Delimeter"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(528, 9)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(125, 19)
        Me.UltraLabel3.TabIndex = 5
        Me.UltraLabel3.Text = "Fields in Database"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(336, 9)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(125, 19)
        Me.UltraLabel4.TabIndex = 7
        Me.UltraLabel4.Text = "Fields in File"
        '
        'tFieldsFile
        '
        Me.tFieldsFile.ItemHeight = 16
        Me.tFieldsFile.Location = New System.Drawing.Point(336, 28)
        Me.tFieldsFile.Name = "tFieldsFile"
        Me.tFieldsFile.Size = New System.Drawing.Size(182, 516)
        Me.tFieldsFile.TabIndex = 6
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(816, 9)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(125, 19)
        Me.UltraLabel5.TabIndex = 9
        Me.UltraLabel5.Text = "Field Pairings"
        '
        'tPairings
        '
        Me.tPairings.ItemHeight = 16
        Me.tPairings.Location = New System.Drawing.Point(816, 28)
        Me.tPairings.Name = "tPairings"
        Me.tPairings.Size = New System.Drawing.Size(307, 548)
        Me.tPairings.TabIndex = 8
        '
        'bBrowse
        '
        Me.bBrowse.Location = New System.Drawing.Point(10, 212)
        Me.bBrowse.Name = "bBrowse"
        Me.bBrowse.Size = New System.Drawing.Size(163, 37)
        Me.bBrowse.TabIndex = 12
        Me.bBrowse.Text = "Load File"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(730, 74)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(76, 28)
        Me.UltraButton1.TabIndex = 13
        Me.UltraButton1.Tag = ""
        Me.UltraButton1.Text = "-->"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(730, 120)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(76, 28)
        Me.UltraButton2.TabIndex = 14
        Me.UltraButton2.Tag = ""
        Me.UltraButton2.Text = "<--"
        '
        'bSave
        '
        Me.bSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSave.Location = New System.Drawing.Point(221, 9)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(96, 28)
        Me.bSave.TabIndex = 15
        Me.bSave.Text = "Save"
        '
        'tFormula
        '
        Me.tFormula.Location = New System.Drawing.Point(336, 563)
        Me.tFormula.Name = "tFormula"
        Me.tFormula.Size = New System.Drawing.Size(182, 24)
        Me.tFormula.TabIndex = 16
        '
        'bImport
        '
        Me.bImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bImport.Location = New System.Drawing.Point(10, 295)
        Me.bImport.Name = "bImport"
        Me.bImport.Size = New System.Drawing.Size(163, 37)
        Me.bImport.TabIndex = 17
        Me.bImport.Text = "Import"
        '
        'lFile
        '
        Me.lFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lFile.Location = New System.Drawing.Point(10, 600)
        Me.lFile.Name = "lFile"
        Me.lFile.Size = New System.Drawing.Size(924, 27)
        Me.lFile.TabIndex = 18
        '
        'cbSkip
        '
        Me.cbSkip.Checked = True
        Me.cbSkip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSkip.Location = New System.Drawing.Point(10, 120)
        Me.cbSkip.Name = "cbSkip"
        Me.cbSkip.Size = New System.Drawing.Size(144, 23)
        Me.cbSkip.TabIndex = 19
        Me.cbSkip.Text = "Skip First Line"
        '
        'fmContactsImport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(944, 542)
        Me.Controls.Add(Me.cbSkip)
        Me.Controls.Add(Me.lFile)
        Me.Controls.Add(Me.bImport)
        Me.Controls.Add(Me.tFormula)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.bBrowse)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.tPairings)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.tFieldsFile)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.tFields)
        Me.Controls.Add(Me.tDelimeter)
        Me.Controls.Add(Me.tFormat)
        Me.Name = "fmContactsImport"
        Me.Text = "Import Contacts"
        CType(Me.tFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDelimeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tFormula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSkip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub bBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBrowse.Click
        Dim fl As New OpenFileDialog
        Dim ln As String
        Dim itm As String
        Dim cnt As Integer = 0

        If fl.ShowDialog = DialogResult.OK Then
            lFile.Text = fl.FileName
            tFieldsFile.Items.Clear()
            Dim strm As New IO.StreamReader(fl.FileName)
            ln = strm.ReadLine
            For Each itm In Split(ln, tDelimeter.Text)
                tFieldsFile.Items.Add("{" + CStr(cnt) + ":" + itm + "}")
                cnt += 1
            Next
        End If
    End Sub

    Private Sub fmContactsImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.Columns where TABLE_NAME = 'cont_file'", cnn)
        Dim dr As SqlDataReader
        Dim da As New SqlDataAdapter(cmd)
        Dim dtNames As New DataTable

        tFields.Items.Clear()
        cnn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            tFields.Items.Add(dr("column_name"))
        Loop
        dr.Close()

        cmdMain.CommandText = "select * from cont_pair where cont_pair_serial=-1"
        daMain.Fill(dt)
        tPairings.DataSource = dt
        tPairings.DisplayMember = "cont_pair_data"

        cmd.CommandText = "select distinct cont_pair_name as Layout from cont_pair order by cont_pair_name"
        da.Fill(dtNames)
        tFormat.DataSource = dtNames
        tFormat.DisplayMember = "Layout"

        cnn.Close()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim rw As DataRow

        rw = dt.NewRow
        rw("cont_pair_data") = tFieldsFile.SelectedItem + " -> " + tFields.SelectedItem
        dt.Rows.Add(rw)
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Dim rw As DataRow
        Dim onItem As String = tPairings.Text

        For Each rw In dt.Rows
            If rw("cont_pair_data") = onItem Then
                rw.Delete()
                Exit Sub
            End If
        Next
    End Sub

    Private Sub bSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click
        Dim rw As DataRow
        Dim cmd As New SqlCommand("delete from cont_pair where cont_pair_name='" + tFormat.Text + "'", cnn)

        For Each rw In dt.Rows
            rw("cont_pair_name") = Me.tFormat.Text
        Next

        cnn.Open()
        cmd.ExecuteNonQuery()
        daMain.Update(dt)
        cnn.Close()
    End Sub

    Private Sub tFormat_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles tFormat.InitializeLayout

    End Sub

    Private Sub tFormat_RowSelected(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles tFormat.RowSelected
        cmdMain.CommandText = "select * from cont_pair where cont_pair_name='" + tFormat.Text + "' order by cont_pair_serial"
        cnn.Open()
        daMain.Fill(dt)
        cnn.Close()
        tPairings.DataSource = dt

    End Sub

    Private Sub bImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImport.Click
        Dim cmd As New SqlCommand("", cnn)
        Dim rw As DataRow
        Dim fl As New IO.StreamReader(lFile.Text)
        Dim ln As String
        Dim onField As Integer
        Dim Trans As SqlTransaction
        bImport.Enabled = False
        cnn.Open()
        Trans = cnn.BeginTransaction
        cmd.Transaction = Trans
        Try
            ln = fl.ReadLine
            If cbSkip.Checked Then ln = fl.ReadLine
            Do While ln <> ""
                cmd.CommandText = "insert into cont_file ("
                For Each rw In dt.Rows
                    cmd.CommandText += Trim(Split(rw("cont_pair_data"), "->")(1)) + ","
                Next
                cmd.CommandText += "cont_type,"
                cmd.CommandText += "cont_status,"
                cmd.CommandText += "inactive,"
                cmd.CommandText = Mid(cmd.CommandText, 1, Len(cmd.CommandText) - 1) + ") values ("

                For Each rw In dt.Rows
                    onField = CInt(Replace(Split(Split(rw("cont_pair_data"), "->")(0), ":")(0), "{", ""))
                    If Trim(Split(rw("cont_pair_data"), "->")(1)) = "cont_field_consult" Then
                        cmd.CommandText += "" + Replace(Split(ln, Me.tDelimeter.Text)(onField), "'", "''").ToString + ","
                    Else
                        cmd.CommandText += "'" + Replace(Split(ln, Me.tDelimeter.Text)(onField), "'", "''") + "',"
                    End If
                Next
                cmd.CommandText += "'Other',"
                cmd.CommandText += "'Unknown',"
                cmd.CommandText += "0,"
                cmd.CommandText = Mid(cmd.CommandText, 1, Len(cmd.CommandText) - 1) + ")"

                cmd.ExecuteNonQuery()

                ln = fl.ReadLine
            Loop
            Trans.Commit()
        Catch
            Trans.Rollback()
            MsgBox(Err.Description)
        End Try
        bImport.Enabled = True
        cnn.Close()
    End Sub
End Class
