Public Class fmPrintCustomerOrders
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
    Friend WithEvents tStart As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tEnd As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents tcust As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents bPrint As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tStart = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.tEnd = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.tcust = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.bPrint = New System.Windows.Forms.Button
        CType(Me.tStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tStart
        '
        Me.tStart.Location = New System.Drawing.Point(136, 8)
        Me.tStart.Name = "tStart"
        Me.tStart.Size = New System.Drawing.Size(112, 21)
        Me.tStart.TabIndex = 0
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(136, 32)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Start Date"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(256, 32)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "End Date"
        '
        'tEnd
        '
        Me.tEnd.Location = New System.Drawing.Point(256, 8)
        Me.tEnd.Name = "tEnd"
        Me.tEnd.Size = New System.Drawing.Size(112, 21)
        Me.tEnd.TabIndex = 2
        '
        'tcust
        '
        Me.tcust.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tcust.DisplayMember = ""
        Me.tcust.Location = New System.Drawing.Point(8, 8)
        Me.tcust.Name = "tcust"
        Me.tcust.Size = New System.Drawing.Size(120, 21)
        Me.tcust.TabIndex = 4
        Me.tcust.ValueMember = ""
        '
        'bPrint
        '
        Me.bPrint.Location = New System.Drawing.Point(112, 64)
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Size = New System.Drawing.Size(136, 32)
        Me.bPrint.TabIndex = 5
        Me.bPrint.Text = "Print"
        '
        'fmPrintCustomerOrders
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 126)
        Me.Controls.Add(Me.bPrint)
        Me.Controls.Add(Me.tcust)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.tEnd)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.tStart)
        Me.Name = "fmPrintCustomerOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Customer Orders"
        CType(Me.tStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmPrintCustomerOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tStart.Value = DateAdd(DateInterval.Day, -1, Today)
        tEnd.Value = DateAdd(DateInterval.Day, -1, Today)
        LoadDD2(tcust, "cust_file", "cust_id", "cust_id", , "inactive<>1")
    End Sub

    Private Sub bPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrint.Click
        DisplayReport("quote landscape", "{ord_gen.ord_gen_ship_date} >= #" + CStr(tStart.Value) + "# and {ord_gen.ord_gen_ship_date} <= #" + CStr(tEnd.Value) + "# and {ord_gen.ord_gen_status} = 'SHIPPED' and {ord_file.ord_sold_cust_id} = '" + tcust.Text + "'", True, , True)
        DisplayReport("billing summary", "{ord_gen.ord_gen_ship_date} >= #" + CStr(tStart.Value) + "# and {ord_gen.ord_gen_ship_date} <= #" + CStr(tEnd.Value) + "# and {ord_gen.ord_gen_status} = 'SHIPPED' and {ord_file.ord_sold_cust_id} = '" + tcust.Text + "'", True, , tEnd.Value)
        Me.Close()
    End Sub
End Class
