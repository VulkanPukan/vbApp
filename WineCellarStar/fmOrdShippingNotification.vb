Imports System.Data.SqlClient

Public Class fmOrdShippingNotification
    Inherits System.Windows.Forms.Form
    Public fmEstOrd As fmEstOrd2
    Public OrdNoteSerial As Long = 0
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
    Friend WithEvents cbShippingRelease As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbShippingAddrChange As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tPayMethod As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tNote As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents bOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tAdminNotes As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbShippingHold As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbShippingRelease = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbShippingAddrChange = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.tPayMethod = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.tNote = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.bOK = New Infragistics.Win.Misc.UltraButton
        Me.bCancel = New Infragistics.Win.Misc.UltraButton
        Me.tAdminNotes = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.cbShippingHold = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        CType(Me.cbShippingRelease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbShippingAddrChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPayMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAdminNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbShippingHold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbShippingRelease
        '
        Me.cbShippingRelease.Location = New System.Drawing.Point(10, 9)
        Me.cbShippingRelease.Name = "cbShippingRelease"
        Me.cbShippingRelease.Size = New System.Drawing.Size(211, 19)
        Me.cbShippingRelease.TabIndex = 0
        Me.cbShippingRelease.Text = "Shipping Release"
        '
        'cbShippingAddrChange
        '
        Me.cbShippingAddrChange.Location = New System.Drawing.Point(10, 28)
        Me.cbShippingAddrChange.Name = "cbShippingAddrChange"
        Me.cbShippingAddrChange.Size = New System.Drawing.Size(259, 18)
        Me.cbShippingAddrChange.TabIndex = 1
        Me.cbShippingAddrChange.Text = "Shipping Address Changing"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(288, 9)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(134, 19)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Payment Method"
        '
        'tPayMethod
        '
        Me.tPayMethod.Location = New System.Drawing.Point(403, 9)
        Me.tPayMethod.MaxLength = 50
        Me.tPayMethod.Name = "tPayMethod"
        Me.tPayMethod.Size = New System.Drawing.Size(173, 24)
        Me.tPayMethod.TabIndex = 3
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(10, 83)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(76, 19)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Notes:"
        '
        'tNote
        '
        Me.tNote.AcceptsReturn = True
        Me.tNote.Location = New System.Drawing.Point(10, 102)
        Me.tNote.Multiline = True
        Me.tNote.Name = "tNote"
        Me.tNote.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.tNote.Size = New System.Drawing.Size(806, 166)
        Me.tNote.TabIndex = 5
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(10, 471)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(96, 27)
        Me.bOK.TabIndex = 6
        Me.bOK.Text = "OK"
        '
        'bCancel
        '
        Me.bCancel.Location = New System.Drawing.Point(115, 471)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(96, 27)
        Me.bCancel.TabIndex = 7
        Me.bCancel.Text = "Cancel"
        '
        'tAdminNotes
        '
        Me.tAdminNotes.AcceptsReturn = True
        Me.tAdminNotes.Enabled = False
        Me.tAdminNotes.Location = New System.Drawing.Point(10, 295)
        Me.tAdminNotes.Multiline = True
        Me.tAdminNotes.Name = "tAdminNotes"
        Me.tAdminNotes.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.tAdminNotes.Size = New System.Drawing.Size(806, 167)
        Me.tAdminNotes.TabIndex = 9
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(10, 277)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(153, 18)
        Me.UltraLabel3.TabIndex = 8
        Me.UltraLabel3.Text = "Admin Notes:"
        '
        'cbShippingHold
        '
        Me.cbShippingHold.Location = New System.Drawing.Point(10, 46)
        Me.cbShippingHold.Name = "cbShippingHold"
        Me.cbShippingHold.Size = New System.Drawing.Size(259, 19)
        Me.cbShippingHold.TabIndex = 10
        Me.cbShippingHold.Text = "Shipping Hold"
        '
        'fmOrdShippingNotification
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(838, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbShippingHold)
        Me.Controls.Add(Me.tAdminNotes)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tNote)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.tPayMethod)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.cbShippingAddrChange)
        Me.Controls.Add(Me.cbShippingRelease)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fmOrdShippingNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping Notification"
        CType(Me.cbShippingRelease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbShippingAddrChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPayMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAdminNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbShippingHold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub bCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub

    Private Sub fmOrdShippingNotification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Jcom.UserGroup = "Admins" Then
        '    tAdminNotes.Enabled = True
        '    If tAdminNotes.Text = "" Then tAdminNotes.Text = tNote.Text
        'Else
        '    tNote.Enabled = True
        'End If
    End Sub

    Private Sub bOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOK.Click
        bOK.Enabled = False
        Dim cmd As New SqlCommand("", cnn)
        Dim onToDo As Long
        Dim txt As String

        If OrdNoteSerial = 0 Then
            If tNote.Text = "" Then
                MsgBox("You must enter a note.", MsgBoxStyle.Critical, "Note?")
                bOK.Enabled = True
                Exit Sub
            End If
            tAdminNotes.Text = tNote.Text

            txt = "Tab Title: " + Me.fmEstOrd.Tab1.ActiveTab.ToolTipText
            txt += "Shipping Release: " + IIf(cbShippingRelease.Checked, "YES", "NO") + vbCrLf
            txt += "Payment Method: " + tPayMethod.Text + vbCrLf
            txt += "Shipping Address Changed: " + IIf(cbShippingAddrChange.Checked, "YES", "NO") + vbCrLf
            txt += "Shipping Hold: " + IIf(cbShippingHold.Checked, "YES", "NO") + vbCrLf
            txt += "Notes: " + Replace(tAdminNotes.Text, "'", "''")

            'onToDo = Jcom.AddToDo("ShipMod", "melissab", "(" + fmEstOrd.tord_for.Text + ") " + txt, fmEstOrd.tOrd.Text, CInt(Mid(fmEstOrd.Tab1.ActiveTab.Key, 2)), Mid(fmEstOrd.Tab1.ActiveTab.Key, 1, 1), , fmEstOrd.onOrd + "-" + Mid(fmEstOrd.Tab1.ActiveTab.Text, 7), "Order", , , True)
            onToDo = Jcom.AddToDo("ShipMod", "tonyap", "(" + fmEstOrd.tord_for.Text + ") " + txt, fmEstOrd.tOrd.Text, CInt(Mid(fmEstOrd.Tab1.ActiveTab.Key, 2)), Mid(fmEstOrd.Tab1.ActiveTab.Key, 1, 1), , fmEstOrd.onOrd + "-" + Mid(fmEstOrd.Tab1.ActiveTab.Text, 7), "Order", , , True)

            cmd.CommandText = "insert into ord_note (ord_note_ord_gen_serial,ord_note,ord_note_user,ord_note_date,ord_note_type,ord_note_ship_release,ord_note_pay_method,ord_note_ship_change,ord_note_admin,ord_note_ship_hold,ord_note_to_do_serial) values (" + CStr(fmEstOrd.DVGen(0).Item("ord_gen_serial")) + ",'" + Replace(tNote.Text, "'", "''") + "','" + User + "','" + CStr(Now()) + "','ShipNo'," + IIf(cbShippingRelease.Checked, "1", "0") + ",'" + tPayMethod.Text + "'," + IIf(cbShippingAddrChange.Checked, "1", "0") + ",'" + Replace(tAdminNotes.Text, "'", "''") + "'," + IIf(cbShippingHold.Checked, "1", "0") + "," + CStr(onToDo) + ")"
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
        Else
            If tAdminNotes.Text = "" Then
                MsgBox("You must enter an Admin note.", MsgBoxStyle.Critical, "Note?")
                bOK.Enabled = True
                Exit Sub
            End If
            cmd.CommandText = "update ord_note set ord_note_admin='" + Replace(tAdminNotes.Text, "'", "''") + "',ord_note_ship_release=" + IIf(cbShippingRelease.Checked, "1", "0") + ",ord_note_pay_method='" + tPayMethod.Text + "',ord_note_ship_change=" + IIf(cbShippingAddrChange.Checked, "1", "0") + ",ord_note_ship_hold=" + IIf(cbShippingHold.Checked, "1", "0") + " where ord_note_serial=" + CStr(OrdNoteSerial)
            cnn.Open()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "select ord_note_to_do_serial from ord_note where ord_note_serial=" + CStr(OrdNoteSerial)
            onToDo = cmd.ExecuteScalar

            txt = "Tab Title: " + Me.fmEstOrd.Tab1.ActiveTab.ToolTipText
            txt += "Shipping Release: " + IIf(cbShippingRelease.Checked, "YES", "NO") + vbCrLf
            txt += "Payment Method: " + tPayMethod.Text + vbCrLf
            txt += "Shipping Address Changed: " + IIf(cbShippingAddrChange.Checked, "YES", "NO") + vbCrLf
            txt += "Shipping Hold: " + IIf(cbShippingHold.Checked, "YES", "NO") + vbCrLf
            txt += "Notes: " + Replace(tAdminNotes.Text, "'", "''")
            cmd.CommandText = "update to_do set to_do_note='" + txt + "' where to_do_serial=" + CStr(onToDo)
            cmd.ExecuteNonQuery()
            cnn.Close()
        End If
        Me.Close()
    End Sub
End Class
