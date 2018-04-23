Public Class fmResetOrder
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents tOrd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tOrd = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tOrd
        '
        Me.tOrd.Location = New System.Drawing.Point(16, 16)
        Me.tOrd.Name = "tOrd"
        Me.tOrd.Size = New System.Drawing.Size(144, 21)
        Me.tOrd.TabIndex = 0
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(32, 56)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(96, 24)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "OK"
        '
        'fmResetOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(208, 102)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.tOrd)
        Me.Name = "fmResetOrder"
        Me.Text = "fmResetOrder"
        CType(Me.tOrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        If Split(tOrd.Text, "-").Length <> 3 Then
            MsgBox("Invalid order number", MsgBoxStyle.Critical, "Order?")
            Exit Sub
        End If
        UltraButton1.Enabled = False
        connStr = String.Format("server={0};user id={1}; password={2}; database=WineCellarAcct; pooling=false", Server, "sa", "39201")

        Dim cnnAcct As New SqlClient.SqlConnection(connStr)
        Dim dsAcct As New DataSet
        Dim dsNew As New DataSet
        Dim cmdAcct As New SqlClient.SqlCommand("", cnnAcct)
        Dim daAcct As New SqlClient.SqlDataAdapter(cmdAcct)
        Dim dr As DataRow
        Dim drNew As DataRow
        Dim cmdNew As New SqlClient.SqlCommand("", cnn)
        Dim daNew As New SqlClient.SqlDataAdapter(cmdNew)
        Dim cb As SqlClient.SqlCommandBuilder
        Dim tbl As New DataTable
        Dim col, col2 As DataColumn

        cnnAcct.Open()
        cnn.Open()


        'cmdNew.CommandText = "delete from ord_gen where ord_gen_ord_serial=" + Split(tOrd.Text, "-")(0) + " and ord_gen_rev=" + Split(tOrd.Text, "-")(2) + " and ord_gen_type='O'"
        'cmdNew.ExecuteNonQuery()

        'cmdAcct.CommandText = "select * from ord_gen where ord_gen_ord_serial=" + Split(tOrd.Text, "-")(0) + " and ord_gen_rev=" + Split(tOrd.Text, "-")(2) + " and ord_gen_type='O'"
        'daAcct.Fill(dsAcct)
        'cmdNew.CommandText = "select * from ord_gen where ord_gen_ord_serial=-1"
        'daNew.Fill(dsNew)

        'tbl = New DataTable
        'For Each col In dsNew.Tables(0).Columns
        '    col2 = New DataColumn(col.ColumnName, col.GetType())
        '    tbl.Columns.Add(col2)
        'Next

        'For Each dr In dsAcct.Tables(0).Rows
        '    drNew = tbl.NewRow
        '    drNew.ItemArray = dr.ItemArray
        '    tbl.Rows.Add(drNew)
        'Next

        'cb = New SqlClient.SqlCommandBuilder(daNew)
        'daNew.Update(tbl)



        cmdNew.CommandText = "delete from ord_itm where ord_itm_ord_serial=" + Split(tOrd.Text, "-")(0) + " and ord_itm_rev=" + Split(tOrd.Text, "-")(2) + " and ord_itm_type='O'"
        cmdNew.ExecuteNonQuery()

        cmdAcct.CommandText = "select * from ord_itm where ord_itm_ord_serial=" + Split(tOrd.Text, "-")(0) + " and ord_itm_rev=" + Split(tOrd.Text, "-")(2) + " and ord_itm_type='O'"
        daAcct.Fill(dsAcct)
        cmdNew.CommandText = "select * from ord_itm where ord_itm_ord_serial=-1"
        daNew.Fill(dsNew)

        tbl = New DataTable
        For Each col In dsNew.Tables(0).Columns
            col2 = New DataColumn(col.ColumnName, col.GetType())
            tbl.Columns.Add(col2)
        Next

        For Each dr In dsAcct.Tables(0).Rows
            drNew = tbl.NewRow
            drNew.ItemArray = dr.ItemArray
            tbl.Rows.Add(drNew)
        Next

        cb = New SqlClient.SqlCommandBuilder(daNew)
        daNew.Update(tbl)

        cnn.Close()
        cnnAcct.Close()
        tOrd.Focus()
        tOrd.SelectAll()
        UltraButton1.Enabled = True
    End Sub
End Class
