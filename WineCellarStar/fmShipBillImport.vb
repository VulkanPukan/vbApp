Imports System.Data.SqlClient
Public Class fmShipBillImport
    Inherits System.Windows.Forms.Form
    Dim dsData As New DataSet
    Dim dsImport As New DataSet
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
    Friend WithEvents Grid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.Location = New System.Drawing.Point(112, 8)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(792, 640)
        Me.Grid1.TabIndex = 0
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(8, 16)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(96, 32)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "Browse"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(8, 80)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(96, 32)
        Me.UltraButton2.TabIndex = 2
        Me.UltraButton2.Text = "Test"
        '
        'fmShipBillImport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(912, 662)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "fmShipBillImport"
        Me.Text = "fmShipBillImport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim fd As New OpenFileDialog
        If fd.ShowDialog = DialogResult.OK Then
            Select Case Mid(System.IO.Path.GetFileName(fd.FileName), 1, 3)
                Case "FDX"
                    DoFedEx(fd.FileName)
                Case Else
                    MsgBox("File Type Not Found", MsgBoxStyle.Information, "Not Found")
            End Select
        End If
    End Sub
    Private Sub DoFedEx(ByVal FileName As String)
        Dim fl As New IO.StreamReader(FileName)
        Dim ln As String
        Dim fld As String
        Dim rw As DataRow
        Dim cmd As New SqlCommand("", cnn)
        Dim dt As String

        'Try
        ln = fl.ReadLine
        ln = fl.ReadLine

        ln = fl.ReadLine
        Replace(ln, """,""", """;""")
        cnn.Open()
        cmd.CommandText = "select top 1 ship_bill_serial from ship_bill where ship_bill_invoice='" + Split(ln, """;""")(2) + "'"
        If Not cmd.ExecuteScalar Is Nothing Then
            MsgBox("FedEx invoice " + Split(ln, """;""")(2) + " has already been imported.", MsgBoxStyle.Information, "Import?")
            cnn.Close()
            Exit Sub
        End If
        Do While ln <> Nothing
            rw = dsData.Tables("itm").NewRow
            If Microsoft.VisualBasic.Left(ln, 1) = """" Then ln = Mid(ln, 2)
            If Microsoft.VisualBasic.Right(ln, 1) = """" Then ln = Mid(ln, 1, Len(ln) - 1)
            'rw.ItemArray = Split(ln, """;""", , CompareMethod.Text)

            rw("ship_bill_company") = Split(ln, """;""")(10)
            rw("ship_bill_invoice") = Split(ln, """;""")(2)
            rw("ship_bill_invdate") = GetDate(Split(ln, """;""")(1), "yyyymmdd")
            rw("ship_bill_tracking") = Split(ln, """;""")(7)
            rw("ship_bill_amt") = Split(ln, """;""")(9)
            rw("ship_bill_shipvia") = Split(ln, """;""")(10)
            rw("ship_bill_qty") = 1
            rw("ship_bill_weight") = Split(ln, """;""")(17)
            rw("ship_bill_shipdate") = GetDate(Split(ln, """;""")(12), "yyyymmdd")
            rw("ship_bill_deldate") = GetDate(Split(ln, """;""")(13), "yyyymmdd", Split(ln, """;""")(14))
            rw("ship_bill_payor") = Split(ln, """;""")(5)
            rw("ship_bill_meter") = Split(ln, """;""")(23)
            rw("ship_bill_toname") = Split(ln, """;""")(24)
            rw("ship_bill_tocompany") = Split(ln, """;""")(25)
            rw("ship_bill_toaddr1") = Split(ln, """;""")(26)
            rw("ship_bill_toaddr2") = Split(ln, """;""")(27)
            rw("ship_bill_tocity") = Split(ln, """;""")(28)
            rw("ship_bill_tostate") = Split(ln, """;""")(29)
            rw("ship_bill_tozip") = Split(ln, """;""")(30)
            rw("ship_bill_shipcompany") = Split(ln, """;""")(32)
            rw("ship_bill_shipname") = Split(ln, """;""")(33)
            rw("ship_bill_ref") = Split(ln, """;""")(40)
            If Split(ln, """;""")(40).Length >= 4 And Split(ln, """;""")(40) <> "NO REFERENCE INFORMATION" Then
                rw("ship_bill_group") = Mid(Split(ln, """;""")(40), 1, 2)
                rw("ship_bill_content") = Mid(Split(ln, """;""")(40), 4, 3)
                rw("ship_bill_initials") = Mid(Split(ln, """;""")(40), 8, 3)
            End If

            cmd.CommandText = "select ship_serial from ship_file where ship_track='" + rw("ship_bill_tracking") + "'"
            rw("ship_bill_ship_serial") = nz(cmd.ExecuteScalar, -1)
            'If rw("ship_bill_ship_serial") = -1 Then
            '    rw("ship_bill_cat") = "NONE"
            'Else
            '    rw("ship_bill_cat") = "ORDER"
            'End If

            dsData.Tables("itm").Rows.Add(rw)
            ln = fl.ReadLine
        Loop

        Dim da As New SqlDataAdapter(New SqlCommand("select * from ship_bill where ship_bill_serial=-1", cnn))
        Dim cb As New SqlCommandBuilder(da)
        cb.RefreshSchema()
        da.Update(dsData.Tables("itm"))

        cnn.Close()
        Grid1.DataSource = dsData.Tables("itm")
        Grid1.DataBind()
        'Catch
        cnn.Close()
        'MsgBox(Err.Description + vbCrLf + ln)
        'End Try
    End Sub
    Private Function GetDate(ByVal dt As String, ByVal frm As String, Optional ByVal tm As String = "") As Object
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

    Private Sub fmShipBillImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("select * from ship_bill where ship_bill_serial=-1", cnn)
        Dim da As New SqlDataAdapter(cmd)
        cnn.Open()
        da.Fill(dsData, "itm")
        cnn.Close()
        Grid1.DataSource = dsData.Tables("itm")
        Grid1.DataBind()
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click

    End Sub
End Class
