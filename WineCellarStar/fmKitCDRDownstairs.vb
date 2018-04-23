Imports System.Data.SqlClient
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing


Public Class fmKitCDRDownstairs
    Dim cmd As New SqlCommand("", cnn)
    Dim da As New SqlDataAdapter(cmd)
    'Dim dr As SqlDataReader
    Dim dt As New DataTable
    Dim HoldRefresh As Boolean = False
    Private bindingSource1 As New BindingSource()
    Dim strFormat As StringFormat

    Dim arrColumnLefts As New ArrayList()
    'Used to save left coordinates of columns
    Dim arrColumnWidths As New ArrayList()
    'Used to save column widths
    Dim iCellHeight As Integer = 0
    'Used to get/set the datagridview cell height
    Dim iTotalWidth As Integer = 0
    '
    Dim iRow As Integer = 0
    'Used as counter
    Dim bFirstPage As Boolean = False
    'Used to check whether we are printing first page
    Dim bNewPage As Boolean = False
    ' Used to check whether we are printing a new page
    Dim iHeaderHeight As Integer = 0
    'Used for the header height

    Dim icount As Integer

    Private Sub fmKitCDRDownstairs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGrid()
        Try
            Label2.Text = GetSetting("Jcom", "Printing", "KitCDR")
            cbTray.Text = GetSetting("Jcom", "PrintTray", "KitCDR")
        Catch

        End Try
    End Sub

    Private Sub LoadGrid()

        Try
            'Try
            '    If DataGridView1.DataSource IsNot Nothing Then
            '        DataGridView1.DataSource = Nothing
            '    Else
            '        DataGridView1.Rows.Clear()
            '    End If
            'Catch
            'End Try

            dt.Rows.Clear()
            Me.Cursor = Cursors.WaitCursor
            Dim dw As DataRow
            Dim dc As System.Data.DataColumn
            cnn.Open()
            cmd.CommandText = "SELECT distinct ord_gen_ord_serial,ord_gen_rev," + _
            " ord_file.ord_sold_cust_id, ord_file.ord_for, ord_prod.ord_prod_kitdown_date, ord_prod.ord_prod_est_comp, ord_prod.ord_prod_factcomp_date,ord_gen_print_downstairs_by,ord_gen_print_downstairs,ord_prod_estship_emailsent,ord_prod_kitdown_note,ord_prod_committed " + _
            " from ord_itm RIGHT OUTER JOIN" + _
            " ord_file INNER JOIN" + _
            " ord_gen ON ord_file.ord_serial = ord_gen.ord_gen_ord_serial ON ord_itm.ord_itm_ord_serial = ord_gen.ord_gen_ord_serial AND " + _
            " ord_itm.ord_itm_rev = ord_gen.ord_gen_rev AND ord_itm.ord_itm_type = ord_gen.ord_gen_type LEFT OUTER JOIN" + _
            " ord_prod ON ord_gen.ord_gen_ord_serial = ord_prod.ord_prod_ord_serial AND ord_gen.ord_gen_rev = ord_prod.ord_prod_rev AND " + _
            " ord_gen.ord_gen_type = ord_prod.ord_prod_type" + _
            " WHERE (ord_prod.ord_prod_kitdown = 1) AND (ord_gen.ord_gen_type = 'O') AND (NOT (ord_gen.ord_gen_status IN ('CANCELED', 'SHIPPED', 'STAGED'))) " + _
            " AND (ord_itm.ord_itm_prod_type IN ('ARCH', 'BREEZ', 'BUD', 'DES', 'DESKIT', 'FIX', 'FS', 'GOLD', 'IN', 'KIT', 'NON-WCI', 'REFCAB', 'SPL', 'STAIN', 'TOP', 'WHIST'))" + _
            " ORDER BY ord_gen_print_downstairs,ord_prod_est_comp,ord_gen_ord_serial,ord_gen_rev"
            da.Fill(dt)
            cnn.Close()

            Label1.Text = dt.Rows.Count.ToString
            'Application.DoEvents()
            'dt.Columns.Add("order", System.Type.GetType("System.String"))
            'For Each dw In dt.Rows
            '    If dw("ord_gen_print_downstairs").ToString = "1/1/1900" Then dw("ord_gen_print_downstairs") = System.DBNull.Value
            '    If dw("ord_prod_est_comp").ToString = "1/1/1900" Then dw("ord_prod_est_comp") = System.DBNull.Value
            '    If dw("ord_prod_factcomp_date").ToString = "1/1/1900" Then dw("ord_prod_factcomp_date") = System.DBNull.Value
            'Next
            '

            'dc.DataType = System.Type.GetType("System.String")
            'dc.Caption = "Order"
            'dt.Columns.Add(dc)

            'Me.bindingSource1.DataSource = dt

            DataGridView1.DataSource = dt 'bindingSource1

            Try
                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim RowType As String = nz(row.Cells("ord_gen_print_downstairs").Value.ToString())
                    If RowType = "" Or Split(RowType, " ")(0) = "1/1/1900" Then
                        row.DefaultCellStyle.BackColor = Color.MistyRose
                    Else
                        row.DefaultCellStyle.BackColor = Color.White
                    End If

                    RowType = nz(row.Cells("ord_prod_est_comp").Value.ToString())
                    If RowType = "" Or Split(RowType, " ")(0) = "1/1/1900" Then
                        If row.DefaultCellStyle.BackColor = Color.MistyRose Then
                            row.Cells("ord_prod_est_comp").Style.ForeColor = Color.White
                        Else
                            row.Cells("ord_prod_est_comp").Style.ForeColor = Color.LightGray
                        End If
                    Else
                        row.Cells("ord_prod_est_comp").Style.ForeColor = Color.Black
                    End If

                    RowType = nz(row.Cells("ord_prod_factcomp_date").Value.ToString())
                    If RowType = "" Or Split(RowType, " ")(0) = "1/1/1900" Then
                        If row.DefaultCellStyle.BackColor = Color.MistyRose Then
                            row.Cells("ord_prod_factcomp_date").Style.ForeColor = Color.White
                        Else
                            row.Cells("ord_prod_factcomp_date").Style.ForeColor = Color.LightGray
                        End If
                    Else
                        row.Cells("ord_prod_factcomp_date").Style.ForeColor = Color.Black
                    End If

                    RowType = nz(row.Cells("ord_gen_print_downstairs").Value.ToString())
                    If RowType = "" Or Split(RowType, " ")(0) = "1/1/1900" Then
                        If row.DefaultCellStyle.BackColor = Color.MistyRose Then
                            row.Cells("ord_gen_print_downstairs").Style.ForeColor = Color.White
                        Else
                            row.Cells("ord_gen_print_downstairs").Style.ForeColor = Color.LightGray
                        End If
                    Else
                        row.Cells("ord_gen_print_downstairs").Style.ForeColor = Color.Black
                    End If

                    RowType = nz(row.Cells("ord_prod_estship_emailsent").Value.ToString())
                    If RowType = "" Or Split(RowType, " ")(0) = "1/1/1900" Then
                        If row.DefaultCellStyle.BackColor = Color.MistyRose Then
                            row.Cells("ord_prod_estship_emailsent").Style.ForeColor = Color.White
                        Else
                            row.Cells("ord_prod_estship_emailsent").Style.ForeColor = Color.LightGray
                        End If
                    Else
                        row.Cells("ord_prod_estship_emailsent").Style.ForeColor = Color.Black
                    End If

                    RowType = nz(row.Cells("ord_prod_committed").Value.ToString())
                    If RowType = "" Or Split(RowType, " ")(0) = "1/1/1900" Then
                        If row.DefaultCellStyle.BackColor = Color.MistyRose Then
                            row.Cells("ord_prod_committed").Style.ForeColor = Color.White
                        Else
                            row.Cells("ord_prod_committed").Style.ForeColor = Color.LightGray
                        End If
                    Else
                        row.Cells("ord_prod_committed").Style.ForeColor = Color.Black
                    End If

                    RowType = nz(row.Cells("ord_prod_committed").Value.ToString())
                    If CDate(RowType) < Today And Split(RowType, " ")(0) <> "1/1/1900" Then
                        row.DefaultCellStyle.BackColor = Color.Red
                        row.DefaultCellStyle.ForeColor = Color.White
                    Else
                        'row.DefaultCellStyle.BackColor = Color.White
                    End If
                Next
            Catch
            End Try


            '
            Me.Cursor = Cursors.Default
        Catch
            MsgBox(Err.Description)
            cnn.Close()
        Finally

        End Try

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        'Dim dr As DataRow
        'For Each dr In DataGridView1.Rows
        '    dr("Select") = True
        'Next
        'For Each dgvr As DataGridViewRow In DataGridView1.Rows
        '    ' Get the underlying datarow
        '    Dim dr As DataRow = DirectCast(dgvr.DataBoundItem, DataRowView).Row

        '    ' Update the appropriate column in the data row.
        '    ' Assuming this is your column name in your 
        '    ' underlying data table
        '    dr("Select") = 1
        'Next
        HoldRefresh = True
        For Each row As DataGridViewRow In DataGridView1.Rows
            DirectCast(row.Cells("Selectx"), DataGridViewCheckBoxCell).Value = True
        Next
        HoldRefresh = False
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        HoldRefresh = True
        For Each row As DataGridViewRow In DataGridView1.Rows
            DirectCast(row.Cells("Selectx"), DataGridViewCheckBoxCell).Value = False
        Next
        HoldRefresh = False
    End Sub

    Private Sub bPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrint.Click
        If Label2.Text = "" Then
            MsgBox("Please select a printer for printing.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim xprint = DefaultPrinterName()
        'MsgBox(xprint)
        ' ''If InStr(UCase(xprint), "TOSHIBA") = 0 Then
        ' ''    If MsgBox("You do not have the TOSHIBA printer set as default in WINDOWS (not this screen)." + vbCrLf + "Do you want to continue? Printout will be from default tray.", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        ' ''        Exit Sub
        ' ''    End If
        ' ''End If
        'If MsgBox("Continue!", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        HoldRefresh = True
        Me.Cursor = Cursors.WaitCursor
        bPrint.Enabled = False
        Panel1.Enabled = False
        Dim rp As String
        Dim AlreadyPrinted As String = ""
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If DirectCast(row.Cells("Selectx"), DataGridViewCheckBoxCell).Value = True Then

                    rp = row.Cells("ord_gen_ord_serial").Value.ToString
                    'DisplayReport("quote landscape", "{ord_file.ord_serial} = " + tOrd.Text + " and {ord_gen.ord_gen_rev} = " + Mid(Tab1.ActiveTab.Key, 2) + " and {ord_gen.ord_gen_type}='O'", True, 1, True, , False, False, , , Output)
                    Try
                        DisplayReport("quote landscape", "{ord_file.ord_serial} = " + row.Cells("ord_gen_ord_serial").Value.ToString + " and {ord_gen.ord_gen_rev} = " + row.Cells("ord_gen_rev").Value.ToString + " and {ord_gen.ord_gen_type}='O'", False, 1, True, , False, False, , , , , Label2.Text, cbTray.Text)

                    Catch
                        MsgBox("Report Error: " + vbCrLf + rp + vbCrLf + Err.Description.ToString)
                    End Try
                    WaitSec(1)
                    Dim pd
                    Try
                        pd = nz(row.Cells("ord_gen_print_downstairs").Value, CDate("1/1/1900"))
                    Catch
                        MsgBox("Row Error: " + vbCrLf + rp.ToString + vbCrLf + Err.Description.ToString)
                    End Try
                    Try
                        If pd = CDate("1/1/1900") Then
                            cnn.Open()
                            cmd.CommandText = "update ord_gen set ord_gen_print_downstairs ='" + Now.ToString + "', ord_gen_print_downstairs_by='" + User + "' where ord_gen_ord_serial =" + row.Cells("ord_gen_ord_serial").Value.ToString + " and ord_gen_rev = " + row.Cells("ord_gen_rev").Value.ToString + " and ord_gen_type='O'"
                            cmd.ExecuteNonQuery()

                            DirectCast(row.Cells("Selectx"), DataGridViewCheckBoxCell).Value = False
                            'row.Cells("ord_gen_print_downstairs").Value = Now.ToString
                            'row.Cells("ord_gen_print_downstairs_by").Value = User.ToString
                            Application.DoEvents()
                        Else
                            AlreadyPrinted += rp.ToString + "   " + pd.ToString + vbCrLf
                        End If
                    Catch
                        'MsgBox("Row Update Error: " + vbCrLf + rp.ToString + vbCrLf + Err.Description.ToString)
                    Finally
                        cnn.Close()
                    End Try
                    WaitSec(5)
                End If
            Next
            If AlreadyPrinted <> "" Then
                MsgBox("Here is a list of Orders that were printed previously." + vbCrLf + AlreadyPrinted, MsgBoxStyle.Information, "Already Printed Orders")
            End If
        Catch
            MsgBox(rp + vbCrLf + Err.Description.ToString)
        End Try
        ' WaitSec(2)
        LoadGrid()
        Panel1.Enabled = True
        bPrint.Enabled = True
        Me.Cursor = Cursors.Default
        HoldRefresh = False
    End Sub

    Private Sub bSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click
        LoadGrid()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        '       Hours = Milliseconds / (1000 * 60 * 60)
        'Minutes = (Milliseconds % (1000*60*60)) / (1000*60)
        'Seconds = ((Milliseconds % (1000*60*60)) % (1000*60)) / 1000

        '       Label2.Text = Timer1.
        If CheckBox1.CheckState = CheckState.Checked Then

        Else
            If dt.Rows.Count > 0 Then
                Dim rw As DataRow
                For Each rw In dt.Rows
                    If rw.RowState = DataRowState.Modified Then
                        HoldRefresh = True
                    Else
                        HoldRefresh = False
                    End If
                Next
            End If
            If HoldRefresh = False Then
                LoadGrid()
            End If
        End If

    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        HoldRefresh = True
        Me.Cursor = Cursors.WaitCursor
        UltraButton3.Enabled = False
        Panel1.Enabled = False
        Try
            cnn.Open()
            If dt.Rows.Count > 0 Then
                Dim rw As DataRow
                For Each rw In dt.Rows
                    If rw.RowState = DataRowState.Modified Then
                        cmd.CommandText = "Select ord_prod_est_comp from ord_prod where ord_prod_ord_serial =" + rw("ord_gen_ord_serial").ToString + " and ord_prod_rev = " + rw("ord_gen_rev").ToString + " and ord_prod_type='O'"
                        Dim x = nz(cmd.ExecuteScalar, CDate("1/1/1900"))
                        If CDate(rw("ord_prod_est_comp")) <> x And CDate(rw("ord_prod_est_comp")) >= Today Then
                            cmd.CommandText = "update ord_prod set ord_prod_est_comp ='" + rw("ord_prod_est_comp").ToString + "', ord_prod_factcomp_date='" + rw("ord_prod_factcomp_date").ToString + "', ord_prod_estship_emailsent_complete=0 where ord_prod_ord_serial =" + rw("ord_gen_ord_serial").ToString + " and ord_prod_rev = " + rw("ord_gen_rev").ToString + " and ord_prod_type='O'"
                        Else
                            cmd.CommandText = "update ord_prod set ord_prod_est_comp ='" + rw("ord_prod_est_comp").ToString + "', ord_prod_factcomp_date='" + rw("ord_prod_factcomp_date").ToString + "' where ord_prod_ord_serial =" + rw("ord_gen_ord_serial").ToString + " and ord_prod_rev = " + rw("ord_gen_rev").ToString + " and ord_prod_type='O'"
                        End If
                        cmd.ExecuteNonQuery()
                    End If
                Next
            End If
            cnn.Close()
            Timer2.Enabled = False
            UltraButton3.Appearance.ForeColor = Color.Black
            UltraButton5.Visible = False
            UltraButton3.Visible = False
        Catch
            DoError(Err, Me)
        End Try
        Panel1.Enabled = True
        UltraButton3.Enabled = True
        LoadGrid()
        Me.Cursor = Cursors.Default
        HoldRefresh = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'If HoldRefresh = True Then
        If UltraButton3.Appearance.ForeColor = Color.Red Then
            UltraButton3.Appearance.ForeColor = Color.Black
        Else
            UltraButton3.Appearance.ForeColor = Color.Red
        End If

        'End If
    End Sub

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        Timer2.Enabled = False
        UltraButton5.Visible = False
        UltraButton3.Visible = False
        LoadGrid()
        Timer1.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If ActiveControl Is DataGridView1 Then
            If e.ColumnIndex = 7 Then
                UltraButton5.Visible = True
                UltraButton3.Visible = True
                DataGridView1.Rows(e.RowIndex).Cells("ord_prod_factcomp_date").Style.BackColor = Color.Thistle
                Timer2.Enabled = True
            End If
            If e.ColumnIndex = 6 Then
                UltraButton5.Visible = True
                UltraButton3.Visible = True
                DataGridView1.Rows(e.RowIndex).Cells("ord_prod_est_comp").Style.BackColor = Color.Thistle
                Timer2.Enabled = True
            End If
        End If

    End Sub

    'Private Sub DataGridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
    '    HoldRefresh = True
    '    Dim msg As String = String.Format("Cell at row {0}, column {1} value changed", e.RowIndex, e.ColumnIndex)
    '    MessageBox.Show(msg, "Cell Value Changed")

    'End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If ActiveControl Is CheckBox1 Then
            If CheckBox1.CheckState = CheckState.Checked Then
                HoldRefresh = True
            Else
                HoldRefresh = False
            End If
        End If
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        ''Open the print dialog
        'Dim printDialog As New PrintDialog()
        'printDialog.Document = printDocument1
        'printDialog.UseEXDialog = True
        ''Get the document
        'If DialogResult.OK = printDialog.ShowDialog() Then
        '    printDocument1.DocumentName = "Test Page Print"
        '    printDocument1.Print()
        'End If
        '
        '    Note: In case you want to show the Print Preview Dialog instead of 
        '    Print Dialog then comment the above code and uncomment the following code
        '    

        printDocument1.DefaultPageSettings.Landscape = True
        'Open the print preview dialog
        Dim objPPdialog As New PrintPreviewDialog()
        objPPdialog.Document = printDocument1

        objPPdialog.ShowDialog()

    End Sub

#Region "Begin Print Event Handler"
    ''' <summary>
    ''' Handles the begin print event of print document
    ''' </summary>
    ''' <param name=""sender""></param>
    ''' <param name=""e""></param>
    Private Sub printDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles printDocument1.BeginPrint
        Try
            strFormat = New StringFormat()
            strFormat.Alignment = StringAlignment.Near
            strFormat.LineAlignment = StringAlignment.Center
            strFormat.Trimming = StringTrimming.EllipsisCharacter


            arrColumnLefts.Clear()
            arrColumnWidths.Clear()
            iCellHeight = 0
            icount = 0
            bFirstPage = True
            bNewPage = True

            ' Calculating Total Widths
            iTotalWidth = 0
            For Each dgvGridCol As DataGridViewColumn In DataGridView1.Columns
                iTotalWidth += dgvGridCol.Width
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
#End Region


#Region "Print Page Event"
    ''' <summary>
    ''' Handles the print page event of print document
    ''' </summary>
    ''' <param name=""sender""></param>
    ''' <param name=""e""></param>
    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument1.PrintPage
        Try
            'Set the left margin
            Dim iLeftMargin As Integer = e.MarginBounds.Left
            'Set the top margin
            Dim iTopMargin As Integer = e.MarginBounds.Top
            'Whether more pages have to print or not
            Dim bMorePagesToPrint As Boolean = False
            Dim iTmpWidth As Integer = 0

            'For the first page to print set the cell width and header height
            If bFirstPage Then
                For Each GridCol As DataGridViewColumn In DataGridView1.Columns
                    iTmpWidth = CInt(Math.Floor(CDbl(CDbl(GridCol.Width) / CDbl(iTotalWidth) * CDbl(iTotalWidth) * (CDbl(e.MarginBounds.Width) / CDbl(iTotalWidth)))))

                    iHeaderHeight = CInt(Math.Truncate(e.Graphics.MeasureString(GridCol.HeaderText, GridCol.InheritedStyle.Font, iTmpWidth).Height)) + 11

                    ' Save width and height of headers
                    arrColumnLefts.Add(iLeftMargin)
                    arrColumnWidths.Add(iTmpWidth)
                    iLeftMargin += iTmpWidth
                Next
            End If
            'Loop till all the grid rows not get printed
            While iRow <= DataGridView1.Rows.Count - 1
                Dim GridRow As DataGridViewRow = DataGridView1.Rows(iRow)
                'Set the cell height
                iCellHeight = GridRow.Height + 5
                Dim iCount As Integer = 0
                'Check whether the current page settings allows more rows to print
                If iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then
                    bNewPage = True
                    bFirstPage = False
                    bMorePagesToPrint = True
                    Exit While
                Else
                    If bNewPage Then
                        'Draw Header
                        e.Graphics.DrawString("Kit\CDR Downstairs", New Font(DataGridView1.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary", New Font(DataGridView1.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        Dim strDate As [String] = DateTime.Now.ToLongDateString() & " " & DateTime.Now.ToShortTimeString()
                        'Draw Date
                        e.Graphics.DrawString(strDate, New Font(DataGridView1.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(strDate, New Font(DataGridView1.Font, FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary", New Font(New Font(DataGridView1.Font, FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        'Draw Columns                 
                        iTopMargin = e.MarginBounds.Top
                        For Each GridCol As DataGridViewColumn In DataGridView1.Columns
                            e.Graphics.FillRectangle(New SolidBrush(Color.LightGray), New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight))

                            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight))

                            e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font, New SolidBrush(GridCol.InheritedStyle.ForeColor), New RectangleF(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight), strFormat)
                            iCount += 1
                        Next
                        bNewPage = False
                        iTopMargin += iHeaderHeight
                    End If
                    iCount = 0
                    'Draw Columns Contents                
                    For Each Cel As DataGridViewCell In GridRow.Cells
                        If Cel.Value IsNot Nothing Then
                            e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font, New SolidBrush(Cel.InheritedStyle.ForeColor), New RectangleF(CInt(arrColumnLefts(iCount)), CSng(iTopMargin), CInt(arrColumnWidths(iCount)), CSng(iCellHeight)), strFormat)
                        End If
                        'Drawing Cells Borders 
                        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iCellHeight))
                        iCount += 1
                    Next
                End If
                iRow += 1
                iTopMargin += iCellHeight
            End While
            'If more lines exist, print another page.
            If bMorePagesToPrint Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch exc As Exception
            MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
#End Region



    
    
   
    Private Sub DataGridView1_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim RowType As String = nz(row.Cells("ord_gen_print_downstairs").Value.ToString())
            If RowType = "" Or Split(RowType, " ")(0) = "1/1/1900" Then
                row.DefaultCellStyle.BackColor = Color.MistyRose
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If

            RowType = nz(row.Cells("ord_prod_est_comp").Value.ToString())
            If RowType = "" Or Split(RowType, " ")(0) = "1/1/1900" Then
                If row.DefaultCellStyle.BackColor = Color.MistyRose Then
                    row.Cells("ord_prod_est_comp").Style.ForeColor = Color.White
                Else
                    row.Cells("ord_prod_est_comp").Style.ForeColor = Color.LightGray
                End If
            Else
                row.Cells("ord_prod_est_comp").Style.ForeColor = Color.Black
            End If

            RowType = nz(row.Cells("ord_prod_factcomp_date").Value.ToString())
            If RowType = "" Or Split(RowType, " ")(0) = "1/1/1900" Then
                If row.DefaultCellStyle.BackColor = Color.MistyRose Then
                    row.Cells("ord_prod_factcomp_date").Style.ForeColor = Color.White
                Else
                    row.Cells("ord_prod_factcomp_date").Style.ForeColor = Color.LightGray
                End If
            Else
                row.Cells("ord_prod_factcomp_date").Style.ForeColor = Color.Black
            End If

            RowType = nz(row.Cells("ord_gen_print_downstairs").Value.ToString())
            If RowType = "" Or Split(RowType, " ")(0) = "1/1/1900" Then
                If row.DefaultCellStyle.BackColor = Color.MistyRose Then
                    row.Cells("ord_gen_print_downstairs").Style.ForeColor = Color.White
                Else
                    row.Cells("ord_gen_print_downstairs").Style.ForeColor = Color.LightGray
                End If
            Else
                row.Cells("ord_gen_print_downstairs").Style.ForeColor = Color.Black
            End If

            RowType = nz(row.Cells("ord_prod_estship_emailsent").Value.ToString())
            If RowType = "" Or Split(RowType, " ")(0) = "1/1/1900" Then
                If row.DefaultCellStyle.BackColor = Color.MistyRose Then
                    row.Cells("ord_prod_estship_emailsent").Style.ForeColor = Color.White
                Else
                    row.Cells("ord_prod_estship_emailsent").Style.ForeColor = Color.LightGray
                End If
            Else
                row.Cells("ord_prod_estship_emailsent").Style.ForeColor = Color.Black
            End If
        Next
        
    End Sub

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        Dim printer As New PrintDialog
        If printer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SaveSetting("Jcom", "Printing", "KitCDR", printer.PrinterSettings.PrinterName)
            Label2.Text = GetSetting("Jcom", "Printing", "KitCDR")
        End If
    End Sub

    Private Sub cbTray_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTray.SelectedValueChanged
        If ActiveControl Is cbTray Then
            SaveSetting("Jcom", "PrintTray", "KitCDR", cbTray.Text)
        End If
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        DisplayReport("factorykitsbudget", , True) ' cbTray.Text
    End Sub

    'Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
    '    Dim x = DefaultPrinterName()

    '    DisplayReport("printertest", , False, 1, , , False, False, , , , , Label2.Text, cbTray.Text)
    'End Sub

    Private Function DefaultPrinterName() As String
        Dim oPS As New System.Drawing.Printing.PrinterSettings
        Try
            DefaultPrinterName = oPS.PrinterName
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Capturing Default Printer", MessageBoxButtons.OK)
        Finally
            oPS = Nothing
        End Try
    End Function

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        DisplayReport("factorykitsdailyreportbyprintdate", , True) ' cbTray.Text

    End Sub
End Class