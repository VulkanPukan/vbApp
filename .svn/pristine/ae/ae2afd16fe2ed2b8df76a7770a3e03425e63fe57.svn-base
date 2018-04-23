Imports System
Imports System.Messaging
Imports System.Threading
Imports Microsoft.Win32
Imports Microsoft.Office.Interop
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class fmMain
    Inherits System.Windows.Forms.Form
    'Public fmEstOrd2 As fmEstOrd2
    Dim onColor As Integer
    Dim shtdwn As Boolean = False
    Friend WithEvents MenuItem252 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem253 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem254 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem255 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem257 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem256 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem261 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem258 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem259 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem260 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem262 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem263 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem264 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem265 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem266 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem267 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem268 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem269 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem270 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem271 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem272 As System.Windows.Forms.MenuItem
    Friend WithEvents mnCheckForUpdates As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem274 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem275 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem250 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem273 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem276 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem277 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem278 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem279 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem280 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem281 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem282 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem283 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem284 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem285 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem286 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem287 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem288 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem289 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem290 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem292 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem291 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem293 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem294 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem295 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem296 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem297 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem298 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem299 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem300 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem301 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem302 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem303 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem304 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem305 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem306 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem307 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem308 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem309 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem310 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem311 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem312 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem313 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem314 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem315 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem316 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem317 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem318 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem319 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem320 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem321 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem322 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem323 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem324 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem325 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem326 As System.Windows.Forms.MenuItem
    Dim TimerCnt As Integer
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
    Friend WithEvents _fmMain_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _fmMain_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _fmMain_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _fmMain_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Toolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents mFile As System.Windows.Forms.MenuItem
    Friend WithEvents mUtilities As System.Windows.Forms.MenuItem
    Friend WithEvents mMaintenance As System.Windows.Forms.MenuItem
    Friend WithEvents mReports As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem105 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem106 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem107 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem110 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents MenuItem111 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem112 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem113 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem116 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem117 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem118 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem119 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem120 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem121 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem122 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem123 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem124 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem125 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem126 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem127 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem128 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem130 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem131 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem132 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem136 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem138 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem140 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem148 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem149 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem150 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem157 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem159 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem137 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem164 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem165 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem166 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem167 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem168 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem169 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem170 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem171 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem172 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem173 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem175 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem176 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem177 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem178 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem179 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem180 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem181 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem182 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem183 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem184 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem185 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem186 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem187 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem188 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem189 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem190 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem191 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem192 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem193 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem194 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem174 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem195 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem196 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem197 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem198 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem199 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem200 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem201 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem202 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem203 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem204 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem205 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem206 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem207 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem208 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem209 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem210 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem211 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem212 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem213 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem214 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem215 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem216 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem217 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem218 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem219 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem220 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem221 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem222 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem223 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem224 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem225 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem226 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem227 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem228 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem229 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem230 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem231 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem232 As System.Windows.Forms.MenuItem
    Friend WithEvents sMain As System.Windows.Forms.StatusBarPanel
    Friend WithEvents sIcon As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem233 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem234 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem235 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem236 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem237 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem238 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem239 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem240 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem241 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem242 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem243 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem244 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem245 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem247 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem246 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem248 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem249 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem251 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmMain))
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("ToolBar1")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Parts")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Customers")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quotes/Orders")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Payments")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Shipments")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Billing")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Check Off")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("To Do List")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Contacts")
        Dim ButtonTool37 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Production")
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("AddEdit")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Add")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Edit")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Save")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancel")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Delete")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Print")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("PDF")
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Done")
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Find")
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Customers")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quotes/Orders")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Parts")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Add")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Edit")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Save")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancel")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Delete")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Print")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Done")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool29 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Find")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool30 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Payments")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool31 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Shipments")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool32 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Billing")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool33 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Check Off")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool34 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("To Do List")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool35 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("PDF")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool36 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Contacts")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool38 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Production")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me._fmMain_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._fmMain_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._fmMain_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._fmMain_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mFile = New System.Windows.Forms.MenuItem()
        Me.mnCheckForUpdates = New System.Windows.Forms.MenuItem()
        Me.mUtilities = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.MenuItem267 = New System.Windows.Forms.MenuItem()
        Me.MenuItem320 = New System.Windows.Forms.MenuItem()
        Me.mMaintenance = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem181 = New System.Windows.Forms.MenuItem()
        Me.MenuItem186 = New System.Windows.Forms.MenuItem()
        Me.MenuItem118 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem225 = New System.Windows.Forms.MenuItem()
        Me.MenuItem226 = New System.Windows.Forms.MenuItem()
        Me.MenuItem239 = New System.Windows.Forms.MenuItem()
        Me.MenuItem227 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem70 = New System.Windows.Forms.MenuItem()
        Me.MenuItem143 = New System.Windows.Forms.MenuItem()
        Me.MenuItem137 = New System.Windows.Forms.MenuItem()
        Me.MenuItem305 = New System.Windows.Forms.MenuItem()
        Me.MenuItem248 = New System.Windows.Forms.MenuItem()
        Me.MenuItem100 = New System.Windows.Forms.MenuItem()
        Me.MenuItem222 = New System.Windows.Forms.MenuItem()
        Me.MenuItem190 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem95 = New System.Windows.Forms.MenuItem()
        Me.MenuItem192 = New System.Windows.Forms.MenuItem()
        Me.MenuItem120 = New System.Windows.Forms.MenuItem()
        Me.MenuItem121 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem208 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem156 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.MenuItem55 = New System.Windows.Forms.MenuItem()
        Me.MenuItem88 = New System.Windows.Forms.MenuItem()
        Me.MenuItem165 = New System.Windows.Forms.MenuItem()
        Me.MenuItem188 = New System.Windows.Forms.MenuItem()
        Me.MenuItem216 = New System.Windows.Forms.MenuItem()
        Me.MenuItem187 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem64 = New System.Windows.Forms.MenuItem()
        Me.MenuItem65 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem63 = New System.Windows.Forms.MenuItem()
        Me.MenuItem177 = New System.Windows.Forms.MenuItem()
        Me.MenuItem77 = New System.Windows.Forms.MenuItem()
        Me.MenuItem96 = New System.Windows.Forms.MenuItem()
        Me.MenuItem169 = New System.Windows.Forms.MenuItem()
        Me.MenuItem197 = New System.Windows.Forms.MenuItem()
        Me.MenuItem66 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem194 = New System.Windows.Forms.MenuItem()
        Me.MenuItem75 = New System.Windows.Forms.MenuItem()
        Me.MenuItem180 = New System.Windows.Forms.MenuItem()
        Me.MenuItem196 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem295 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem125 = New System.Windows.Forms.MenuItem()
        Me.mReports = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem111 = New System.Windows.Forms.MenuItem()
        Me.MenuItem110 = New System.Windows.Forms.MenuItem()
        Me.MenuItem108 = New System.Windows.Forms.MenuItem()
        Me.MenuItem105 = New System.Windows.Forms.MenuItem()
        Me.MenuItem106 = New System.Windows.Forms.MenuItem()
        Me.MenuItem107 = New System.Windows.Forms.MenuItem()
        Me.MenuItem153 = New System.Windows.Forms.MenuItem()
        Me.MenuItem109 = New System.Windows.Forms.MenuItem()
        Me.MenuItem102 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem300 = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem86 = New System.Windows.Forms.MenuItem()
        Me.MenuItem79 = New System.Windows.Forms.MenuItem()
        Me.MenuItem255 = New System.Windows.Forms.MenuItem()
        Me.MenuItem257 = New System.Windows.Forms.MenuItem()
        Me.MenuItem261 = New System.Windows.Forms.MenuItem()
        Me.MenuItem256 = New System.Windows.Forms.MenuItem()
        Me.MenuItem258 = New System.Windows.Forms.MenuItem()
        Me.MenuItem259 = New System.Windows.Forms.MenuItem()
        Me.MenuItem260 = New System.Windows.Forms.MenuItem()
        Me.MenuItem262 = New System.Windows.Forms.MenuItem()
        Me.MenuItem103 = New System.Windows.Forms.MenuItem()
        Me.MenuItem104 = New System.Windows.Forms.MenuItem()
        Me.MenuItem293 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem99 = New System.Windows.Forms.MenuItem()
        Me.MenuItem172 = New System.Windows.Forms.MenuItem()
        Me.MenuItem229 = New System.Windows.Forms.MenuItem()
        Me.MenuItem183 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem217 = New System.Windows.Forms.MenuItem()
        Me.MenuItem115 = New System.Windows.Forms.MenuItem()
        Me.MenuItem61 = New System.Windows.Forms.MenuItem()
        Me.MenuItem310 = New System.Windows.Forms.MenuItem()
        Me.MenuItem251 = New System.Windows.Forms.MenuItem()
        Me.MenuItem182 = New System.Windows.Forms.MenuItem()
        Me.MenuItem157 = New System.Windows.Forms.MenuItem()
        Me.MenuItem158 = New System.Windows.Forms.MenuItem()
        Me.MenuItem134 = New System.Windows.Forms.MenuItem()
        Me.MenuItem140 = New System.Windows.Forms.MenuItem()
        Me.MenuItem148 = New System.Windows.Forms.MenuItem()
        Me.MenuItem224 = New System.Windows.Forms.MenuItem()
        Me.MenuItem279 = New System.Windows.Forms.MenuItem()
        Me.MenuItem76 = New System.Windows.Forms.MenuItem()
        Me.MenuItem292 = New System.Windows.Forms.MenuItem()
        Me.MenuItem240 = New System.Windows.Forms.MenuItem()
        Me.MenuItem284 = New System.Windows.Forms.MenuItem()
        Me.MenuItem291 = New System.Windows.Forms.MenuItem()
        Me.MenuItem139 = New System.Windows.Forms.MenuItem()
        Me.MenuItem147 = New System.Windows.Forms.MenuItem()
        Me.MenuItem184 = New System.Windows.Forms.MenuItem()
        Me.MenuItem141 = New System.Windows.Forms.MenuItem()
        Me.MenuItem142 = New System.Windows.Forms.MenuItem()
        Me.MenuItem159 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem119 = New System.Windows.Forms.MenuItem()
        Me.MenuItem164 = New System.Windows.Forms.MenuItem()
        Me.MenuItem202 = New System.Windows.Forms.MenuItem()
        Me.MenuItem203 = New System.Windows.Forms.MenuItem()
        Me.MenuItem204 = New System.Windows.Forms.MenuItem()
        Me.MenuItem205 = New System.Windows.Forms.MenuItem()
        Me.MenuItem206 = New System.Windows.Forms.MenuItem()
        Me.MenuItem288 = New System.Windows.Forms.MenuItem()
        Me.MenuItem301 = New System.Windows.Forms.MenuItem()
        Me.MenuItem289 = New System.Windows.Forms.MenuItem()
        Me.MenuItem296 = New System.Windows.Forms.MenuItem()
        Me.MenuItem290 = New System.Windows.Forms.MenuItem()
        Me.MenuItem324 = New System.Windows.Forms.MenuItem()
        Me.MenuItem306 = New System.Windows.Forms.MenuItem()
        Me.MenuItem307 = New System.Windows.Forms.MenuItem()
        Me.MenuItem314 = New System.Windows.Forms.MenuItem()
        Me.MenuItem68 = New System.Windows.Forms.MenuItem()
        Me.MenuItem72 = New System.Windows.Forms.MenuItem()
        Me.MenuItem277 = New System.Windows.Forms.MenuItem()
        Me.MenuItem214 = New System.Windows.Forms.MenuItem()
        Me.MenuItem69 = New System.Windows.Forms.MenuItem()
        Me.MenuItem87 = New System.Windows.Forms.MenuItem()
        Me.MenuItem185 = New System.Windows.Forms.MenuItem()
        Me.MenuItem238 = New System.Windows.Forms.MenuItem()
        Me.MenuItem81 = New System.Windows.Forms.MenuItem()
        Me.MenuItem74 = New System.Windows.Forms.MenuItem()
        Me.MenuItem71 = New System.Windows.Forms.MenuItem()
        Me.MenuItem316 = New System.Windows.Forms.MenuItem()
        Me.MenuItem318 = New System.Windows.Forms.MenuItem()
        Me.MenuItem317 = New System.Windows.Forms.MenuItem()
        Me.MenuItem319 = New System.Windows.Forms.MenuItem()
        Me.MenuItem242 = New System.Windows.Forms.MenuItem()
        Me.MenuItem280 = New System.Windows.Forms.MenuItem()
        Me.MenuItem263 = New System.Windows.Forms.MenuItem()
        Me.MenuItem264 = New System.Windows.Forms.MenuItem()
        Me.MenuItem265 = New System.Windows.Forms.MenuItem()
        Me.MenuItem273 = New System.Windows.Forms.MenuItem()
        Me.MenuItem244 = New System.Windows.Forms.MenuItem()
        Me.MenuItem245 = New System.Windows.Forms.MenuItem()
        Me.MenuItem243 = New System.Windows.Forms.MenuItem()
        Me.MenuItem247 = New System.Windows.Forms.MenuItem()
        Me.MenuItem268 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem210 = New System.Windows.Forms.MenuItem()
        Me.MenuItem211 = New System.Windows.Forms.MenuItem()
        Me.MenuItem146 = New System.Windows.Forms.MenuItem()
        Me.MenuItem278 = New System.Windows.Forms.MenuItem()
        Me.MenuItem313 = New System.Windows.Forms.MenuItem()
        Me.MenuItem321 = New System.Windows.Forms.MenuItem()
        Me.MenuItem322 = New System.Windows.Forms.MenuItem()
        Me.MenuItem323 = New System.Windows.Forms.MenuItem()
        Me.MenuItem325 = New System.Windows.Forms.MenuItem()
        Me.MenuItem311 = New System.Windows.Forms.MenuItem()
        Me.MenuItem219 = New System.Windows.Forms.MenuItem()
        Me.MenuItem94 = New System.Windows.Forms.MenuItem()
        Me.MenuItem150 = New System.Windows.Forms.MenuItem()
        Me.MenuItem67 = New System.Windows.Forms.MenuItem()
        Me.MenuItem90 = New System.Windows.Forms.MenuItem()
        Me.MenuItem228 = New System.Windows.Forms.MenuItem()
        Me.MenuItem85 = New System.Windows.Forms.MenuItem()
        Me.MenuItem155 = New System.Windows.Forms.MenuItem()
        Me.MenuItem161 = New System.Windows.Forms.MenuItem()
        Me.MenuItem270 = New System.Windows.Forms.MenuItem()
        Me.MenuItem271 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem122 = New System.Windows.Forms.MenuItem()
        Me.MenuItem123 = New System.Windows.Forms.MenuItem()
        Me.MenuItem233 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem230 = New System.Windows.Forms.MenuItem()
        Me.MenuItem253 = New System.Windows.Forms.MenuItem()
        Me.MenuItem212 = New System.Windows.Forms.MenuItem()
        Me.MenuItem154 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem84 = New System.Windows.Forms.MenuItem()
        Me.MenuItem315 = New System.Windows.Forms.MenuItem()
        Me.MenuItem231 = New System.Windows.Forms.MenuItem()
        Me.MenuItem167 = New System.Windows.Forms.MenuItem()
        Me.MenuItem168 = New System.Windows.Forms.MenuItem()
        Me.MenuItem220 = New System.Windows.Forms.MenuItem()
        Me.MenuItem176 = New System.Windows.Forms.MenuItem()
        Me.MenuItem178 = New System.Windows.Forms.MenuItem()
        Me.MenuItem173 = New System.Windows.Forms.MenuItem()
        Me.MenuItem304 = New System.Windows.Forms.MenuItem()
        Me.MenuItem283 = New System.Windows.Forms.MenuItem()
        Me.MenuItem198 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem116 = New System.Windows.Forms.MenuItem()
        Me.MenuItem83 = New System.Windows.Forms.MenuItem()
        Me.MenuItem237 = New System.Windows.Forms.MenuItem()
        Me.MenuItem89 = New System.Windows.Forms.MenuItem()
        Me.MenuItem297 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem294 = New System.Windows.Forms.MenuItem()
        Me.MenuItem62 = New System.Windows.Forms.MenuItem()
        Me.MenuItem97 = New System.Windows.Forms.MenuItem()
        Me.MenuItem303 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem274 = New System.Windows.Forms.MenuItem()
        Me.MenuItem144 = New System.Windows.Forms.MenuItem()
        Me.MenuItem275 = New System.Windows.Forms.MenuItem()
        Me.MenuItem235 = New System.Windows.Forms.MenuItem()
        Me.MenuItem93 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem309 = New System.Windows.Forms.MenuItem()
        Me.MenuItem163 = New System.Windows.Forms.MenuItem()
        Me.MenuItem124 = New System.Windows.Forms.MenuItem()
        Me.MenuItem252 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem174 = New System.Windows.Forms.MenuItem()
        Me.MenuItem285 = New System.Windows.Forms.MenuItem()
        Me.MenuItem236 = New System.Windows.Forms.MenuItem()
        Me.MenuItem145 = New System.Windows.Forms.MenuItem()
        Me.MenuItem249 = New System.Windows.Forms.MenuItem()
        Me.MenuItem269 = New System.Windows.Forms.MenuItem()
        Me.MenuItem200 = New System.Windows.Forms.MenuItem()
        Me.MenuItem117 = New System.Windows.Forms.MenuItem()
        Me.MenuItem195 = New System.Windows.Forms.MenuItem()
        Me.MenuItem112 = New System.Windows.Forms.MenuItem()
        Me.MenuItem113 = New System.Windows.Forms.MenuItem()
        Me.MenuItem149 = New System.Windows.Forms.MenuItem()
        Me.MenuItem162 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem215 = New System.Windows.Forms.MenuItem()
        Me.MenuItem80 = New System.Windows.Forms.MenuItem()
        Me.MenuItem223 = New System.Windows.Forms.MenuItem()
        Me.MenuItem282 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem298 = New System.Windows.Forms.MenuItem()
        Me.MenuItem312 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem191 = New System.Windows.Forms.MenuItem()
        Me.MenuItem246 = New System.Windows.Forms.MenuItem()
        Me.MenuItem286 = New System.Windows.Forms.MenuItem()
        Me.MenuItem287 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem91 = New System.Windows.Forms.MenuItem()
        Me.MenuItem128 = New System.Windows.Forms.MenuItem()
        Me.MenuItem129 = New System.Windows.Forms.MenuItem()
        Me.MenuItem199 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem82 = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.MenuItem98 = New System.Windows.Forms.MenuItem()
        Me.MenuItem221 = New System.Windows.Forms.MenuItem()
        Me.MenuItem131 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem209 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem73 = New System.Windows.Forms.MenuItem()
        Me.MenuItem201 = New System.Windows.Forms.MenuItem()
        Me.MenuItem213 = New System.Windows.Forms.MenuItem()
        Me.MenuItem78 = New System.Windows.Forms.MenuItem()
        Me.MenuItem189 = New System.Windows.Forms.MenuItem()
        Me.MenuItem207 = New System.Windows.Forms.MenuItem()
        Me.MenuItem92 = New System.Windows.Forms.MenuItem()
        Me.MenuItem135 = New System.Windows.Forms.MenuItem()
        Me.MenuItem60 = New System.Windows.Forms.MenuItem()
        Me.MenuItem234 = New System.Windows.Forms.MenuItem()
        Me.MenuItem276 = New System.Windows.Forms.MenuItem()
        Me.MenuItem241 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem218 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem299 = New System.Windows.Forms.MenuItem()
        Me.MenuItem132 = New System.Windows.Forms.MenuItem()
        Me.MenuItem133 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem166 = New System.Windows.Forms.MenuItem()
        Me.MenuItem272 = New System.Windows.Forms.MenuItem()
        Me.MenuItem281 = New System.Windows.Forms.MenuItem()
        Me.MenuItem193 = New System.Windows.Forms.MenuItem()
        Me.MenuItem308 = New System.Windows.Forms.MenuItem()
        Me.MenuItem101 = New System.Windows.Forms.MenuItem()
        Me.MenuItem126 = New System.Windows.Forms.MenuItem()
        Me.MenuItem179 = New System.Windows.Forms.MenuItem()
        Me.MenuItem160 = New System.Windows.Forms.MenuItem()
        Me.MenuItem232 = New System.Windows.Forms.MenuItem()
        Me.MenuItem266 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem250 = New System.Windows.Forms.MenuItem()
        Me.MenuItem326 = New System.Windows.Forms.MenuItem()
        Me.MenuItem136 = New System.Windows.Forms.MenuItem()
        Me.MenuItem130 = New System.Windows.Forms.MenuItem()
        Me.MenuItem138 = New System.Windows.Forms.MenuItem()
        Me.MenuItem114 = New System.Windows.Forms.MenuItem()
        Me.MenuItem175 = New System.Windows.Forms.MenuItem()
        Me.MenuItem151 = New System.Windows.Forms.MenuItem()
        Me.MenuItem152 = New System.Windows.Forms.MenuItem()
        Me.MenuItem170 = New System.Windows.Forms.MenuItem()
        Me.MenuItem171 = New System.Windows.Forms.MenuItem()
        Me.MenuItem254 = New System.Windows.Forms.MenuItem()
        Me.MenuItem302 = New System.Windows.Forms.MenuItem()
        Me.MenuItem58 = New System.Windows.Forms.MenuItem()
        Me.MenuItem59 = New System.Windows.Forms.MenuItem()
        Me.MenuItem127 = New System.Windows.Forms.MenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.sIcon = New System.Windows.Forms.StatusBarPanel()
        Me.sMain = New System.Windows.Forms.StatusBarPanel()
        Me.Toolbar1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        CType(Me.sIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "hammer.jpg")
        Me.ImageList1.Images.SetKeyName(10, "contacts.png")
        '
        '_fmMain_Toolbars_Dock_Area_Left
        '
        Me._fmMain_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._fmMain_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._fmMain_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._fmMain_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._fmMain_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 79)
        Me._fmMain_Toolbars_Dock_Area_Left.Name = "_fmMain_Toolbars_Dock_Area_Left"
        Me._fmMain_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 0)
        Me._fmMain_Toolbars_Dock_Area_Left.ToolbarsManager = Me.Toolbar1
        '
        '_fmMain_Toolbars_Dock_Area_Right
        '
        Me._fmMain_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._fmMain_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._fmMain_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._fmMain_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._fmMain_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1266, 79)
        Me._fmMain_Toolbars_Dock_Area_Right.Name = "_fmMain_Toolbars_Dock_Area_Right"
        Me._fmMain_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 0)
        Me._fmMain_Toolbars_Dock_Area_Right.ToolbarsManager = Me.Toolbar1
        '
        '_fmMain_Toolbars_Dock_Area_Top
        '
        Me._fmMain_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._fmMain_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._fmMain_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._fmMain_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._fmMain_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._fmMain_Toolbars_Dock_Area_Top.Name = "_fmMain_Toolbars_Dock_Area_Top"
        Me._fmMain_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1266, 79)
        Me._fmMain_Toolbars_Dock_Area_Top.ToolbarsManager = Me.Toolbar1
        '
        '_fmMain_Toolbars_Dock_Area_Bottom
        '
        Me._fmMain_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._fmMain_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._fmMain_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._fmMain_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._fmMain_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, -18)
        Me._fmMain_Toolbars_Dock_Area_Bottom.Name = "_fmMain_Toolbars_Dock_Area_Bottom"
        Me._fmMain_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1266, 0)
        Me._fmMain_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.Toolbar1
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mFile, Me.mUtilities, Me.mMaintenance, Me.mReports, Me.MenuItem26, Me.MenuItem136, Me.MenuItem58, Me.MenuItem127})
        '
        'mFile
        '
        Me.mFile.Index = 0
        Me.mFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnCheckForUpdates})
        Me.mFile.Text = "File"
        '
        'mnCheckForUpdates
        '
        Me.mnCheckForUpdates.Checked = True
        Me.mnCheckForUpdates.Index = 0
        Me.mnCheckForUpdates.Text = "Check for Updates"
        '
        'mUtilities
        '
        Me.mUtilities.Index = 1
        Me.mUtilities.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4, Me.MenuItem2, Me.MenuItem7, Me.MenuItem36, Me.MenuItem51, Me.MenuItem267, Me.MenuItem320})
        Me.mUtilities.Text = "Utilities"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Set Server"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "Set Path"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "Set Image Path"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 3
        Me.MenuItem7.Text = "Import"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 4
        Me.MenuItem36.Text = "Total Test"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 5
        Me.MenuItem51.Text = "Balance Test"
        '
        'MenuItem267
        '
        Me.MenuItem267.Index = 6
        Me.MenuItem267.Text = "Rename Part Number"
        '
        'MenuItem320
        '
        Me.MenuItem320.Index = 7
        Me.MenuItem320.Text = "Marriot Hotel Orders"
        Me.MenuItem320.Visible = False
        '
        'mMaintenance
        '
        Me.mMaintenance.Index = 2
        Me.mMaintenance.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem181, Me.MenuItem186, Me.MenuItem118, Me.MenuItem41, Me.MenuItem225, Me.MenuItem40, Me.MenuItem70, Me.MenuItem143, Me.MenuItem137, Me.MenuItem305, Me.MenuItem248, Me.MenuItem100, Me.MenuItem222, Me.MenuItem190, Me.MenuItem35, Me.MenuItem95, Me.MenuItem192, Me.MenuItem120, Me.MenuItem121, Me.MenuItem50, Me.MenuItem208, Me.MenuItem1, Me.MenuItem156, Me.MenuItem54, Me.MenuItem187, Me.MenuItem10, Me.MenuItem64, Me.MenuItem65, Me.MenuItem32, Me.MenuItem63, Me.MenuItem177, Me.MenuItem77, Me.MenuItem96, Me.MenuItem169, Me.MenuItem197, Me.MenuItem66, Me.MenuItem44, Me.MenuItem75, Me.MenuItem180, Me.MenuItem196, Me.MenuItem11, Me.MenuItem42, Me.MenuItem295, Me.MenuItem9, Me.MenuItem125})
        Me.mMaintenance.Text = "Maintenance"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Text = "Accounting Closed Date"
        '
        'MenuItem181
        '
        Me.MenuItem181.Index = 1
        Me.MenuItem181.Text = "Accounting Close Month"
        '
        'MenuItem186
        '
        Me.MenuItem186.Index = 2
        Me.MenuItem186.Text = "Accounting Lock Orders"
        '
        'MenuItem118
        '
        Me.MenuItem118.Index = 3
        Me.MenuItem118.Text = "Accounting Open Order/Quote"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 4
        Me.MenuItem41.Text = "Adjust Balance"
        '
        'MenuItem225
        '
        Me.MenuItem225.Index = 5
        Me.MenuItem225.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem226, Me.MenuItem239, Me.MenuItem227})
        Me.MenuItem225.Text = "AutoCAD"
        '
        'MenuItem226
        '
        Me.MenuItem226.Index = 0
        Me.MenuItem226.Text = "BOM"
        '
        'MenuItem239
        '
        Me.MenuItem239.Index = 1
        Me.MenuItem239.Text = "RD Table"
        '
        'MenuItem227
        '
        Me.MenuItem227.Index = 2
        Me.MenuItem227.Text = "Render"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 6
        Me.MenuItem40.Text = "Commissions"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 7
        Me.MenuItem70.Text = "Country Codes"
        '
        'MenuItem143
        '
        Me.MenuItem143.Index = 8
        Me.MenuItem143.Text = "Design Types"
        '
        'MenuItem137
        '
        Me.MenuItem137.Index = 9
        Me.MenuItem137.Text = "Errors"
        '
        'MenuItem305
        '
        Me.MenuItem305.Index = 10
        Me.MenuItem305.Text = "Field Consultants"
        '
        'MenuItem248
        '
        Me.MenuItem248.Index = 11
        Me.MenuItem248.Text = "Finish Codes"
        '
        'MenuItem100
        '
        Me.MenuItem100.Index = 12
        Me.MenuItem100.Text = "Imports Item Codes"
        '
        'MenuItem222
        '
        Me.MenuItem222.Index = 13
        Me.MenuItem222.Text = "Installers"
        '
        'MenuItem190
        '
        Me.MenuItem190.Index = 14
        Me.MenuItem190.Text = "Items Codes for ""Items Shipped (Certain Item Codes)"" Report"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 15
        Me.MenuItem35.Text = "Order Source Codes"
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 16
        Me.MenuItem95.Text = "Material Codes"
        '
        'MenuItem192
        '
        Me.MenuItem192.Index = 17
        Me.MenuItem192.Text = "Material Codes Wood Factors"
        '
        'MenuItem120
        '
        Me.MenuItem120.Index = 18
        Me.MenuItem120.Text = "Material Colors"
        '
        'MenuItem121
        '
        Me.MenuItem121.Index = 19
        Me.MenuItem121.Text = "Material Colors Active"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 20
        Me.MenuItem50.Text = "Payment Methods"
        '
        'MenuItem208
        '
        Me.MenuItem208.Index = 21
        Me.MenuItem208.Text = "Price Increase"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 22
        Me.MenuItem1.Text = "Product Types"
        '
        'MenuItem156
        '
        Me.MenuItem156.Index = 23
        Me.MenuItem156.Text = "Referred By Names"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 24
        Me.MenuItem54.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem55, Me.MenuItem88, Me.MenuItem165, Me.MenuItem188, Me.MenuItem216})
        Me.MenuItem54.Text = "Reports"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 0
        Me.MenuItem55.Text = "Multi-Rev Orders with Shipments"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 1
        Me.MenuItem88.Text = "Adjustments"
        '
        'MenuItem165
        '
        Me.MenuItem165.Index = 2
        Me.MenuItem165.Text = "Tax Exemptions"
        '
        'MenuItem188
        '
        Me.MenuItem188.Index = 3
        Me.MenuItem188.Text = "Test Accounting"
        '
        'MenuItem216
        '
        Me.MenuItem216.Index = 4
        Me.MenuItem216.Text = "Check Shipping Status"
        '
        'MenuItem187
        '
        Me.MenuItem187.Index = 25
        Me.MenuItem187.Text = "Reset Order from Previous Database"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 26
        Me.MenuItem10.Text = "Sales Categories"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 27
        Me.MenuItem64.Text = "Sales Category Product Margin"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 28
        Me.MenuItem65.Text = "Sales Category Product Price"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 29
        Me.MenuItem32.Text = "Sales Reps"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 30
        Me.MenuItem63.Text = "Sales Rep Territories"
        '
        'MenuItem177
        '
        Me.MenuItem177.Index = 31
        Me.MenuItem177.Text = "Sales Reps Commissions"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 32
        Me.MenuItem77.Text = "Ship Bill Categories"
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 33
        Me.MenuItem96.Text = "Ship Via"
        '
        'MenuItem169
        '
        Me.MenuItem169.Index = 34
        Me.MenuItem169.Text = "Stain vs Unstained"
        '
        'MenuItem197
        '
        Me.MenuItem197.Index = 35
        Me.MenuItem197.Text = "Stain Codes"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 36
        Me.MenuItem66.Text = "Surcharges"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 37
        Me.MenuItem44.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem45, Me.MenuItem12, Me.MenuItem43, Me.MenuItem194})
        Me.MenuItem44.Text = "Tax"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 0
        Me.MenuItem45.Text = "Import Tax by Zip File"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 1
        Me.MenuItem12.Text = "Tax Codes"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 2
        Me.MenuItem43.Text = "Taxable States"
        '
        'MenuItem194
        '
        Me.MenuItem194.Index = 3
        Me.MenuItem194.Text = "Tax Exempt Certificats"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 38
        Me.MenuItem75.Text = "Territories"
        '
        'MenuItem180
        '
        Me.MenuItem180.Index = 39
        Me.MenuItem180.Text = "Update ISR from Speed Codes"
        '
        'MenuItem196
        '
        Me.MenuItem196.Index = 40
        Me.MenuItem196.Text = "Update Reps"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 41
        Me.MenuItem11.Text = "Users"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 42
        Me.MenuItem42.Text = "User Statistics"
        '
        'MenuItem295
        '
        Me.MenuItem295.Index = 43
        Me.MenuItem295.Text = "Web Order State Variations Check"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 44
        Me.MenuItem9.Text = "Zip Codes"
        '
        'MenuItem125
        '
        Me.MenuItem125.Index = 45
        Me.MenuItem125.Text = "Zip Shipping Zones"
        '
        'mReports
        '
        Me.mReports.Index = 3
        Me.mReports.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem19, Me.MenuItem37, Me.MenuItem289, Me.MenuItem306, Me.MenuItem68, Me.MenuItem316, Me.MenuItem242, Me.MenuItem15, Me.MenuItem17, Me.MenuItem49})
        Me.mReports.Text = "Reports"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 0
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem111, Me.MenuItem110, Me.MenuItem108, Me.MenuItem105, Me.MenuItem106, Me.MenuItem107, Me.MenuItem153, Me.MenuItem109, Me.MenuItem102, Me.MenuItem25, Me.MenuItem46, Me.MenuItem300, Me.MenuItem57, Me.MenuItem86, Me.MenuItem79, Me.MenuItem255, Me.MenuItem103, Me.MenuItem104, Me.MenuItem293, Me.MenuItem56, Me.MenuItem99, Me.MenuItem172, Me.MenuItem229, Me.MenuItem183, Me.MenuItem20, Me.MenuItem217, Me.MenuItem115, Me.MenuItem61, Me.MenuItem310, Me.MenuItem251, Me.MenuItem182, Me.MenuItem157, Me.MenuItem158, Me.MenuItem134, Me.MenuItem140, Me.MenuItem148, Me.MenuItem224, Me.MenuItem279, Me.MenuItem76, Me.MenuItem292, Me.MenuItem240, Me.MenuItem284, Me.MenuItem291, Me.MenuItem139, Me.MenuItem147, Me.MenuItem184, Me.MenuItem141, Me.MenuItem142, Me.MenuItem159})
        Me.MenuItem19.Text = "A/R"
        '
        'MenuItem111
        '
        Me.MenuItem111.Index = 0
        Me.MenuItem111.Text = "Accounting Customer Deposits Balance As Of"
        '
        'MenuItem110
        '
        Me.MenuItem110.Index = 1
        Me.MenuItem110.Text = "Accounting Customer Deposits Movement"
        '
        'MenuItem108
        '
        Me.MenuItem108.Index = 2
        Me.MenuItem108.Text = "Accounting Customer Deposits Received"
        '
        'MenuItem105
        '
        Me.MenuItem105.Index = 3
        Me.MenuItem105.Text = "Accounting Sales and Recepts"
        '
        'MenuItem106
        '
        Me.MenuItem106.Index = 4
        Me.MenuItem106.Text = "Accounting Sales and Payment Credits Detail"
        '
        'MenuItem107
        '
        Me.MenuItem107.Index = 5
        Me.MenuItem107.Text = "Accounting Sales Tax and Shipping"
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 6
        Me.MenuItem153.Text = "Accounting Shipping by OSR"
        '
        'MenuItem109
        '
        Me.MenuItem109.Index = 7
        Me.MenuItem109.Text = "Accounting Receipts Detail"
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 8
        Me.MenuItem102.Text = "Accounts Receivable"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 9
        Me.MenuItem25.Text = "Aging by Customer"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 10
        Me.MenuItem46.Text = "Aging by Customer After 1-1-2005"
        '
        'MenuItem300
        '
        Me.MenuItem300.Index = 11
        Me.MenuItem300.Text = "Aging by Customer No Credits"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 12
        Me.MenuItem57.Text = "Aging by Customer As Of"
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = 13
        Me.MenuItem86.Text = "Aging by Customer As Of (With Staged)"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 14
        Me.MenuItem79.Text = "Aging by Customer As Of After 1-1-2005 (With Staged)"
        '
        'MenuItem255
        '
        Me.MenuItem255.Index = 15
        Me.MenuItem255.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem257, Me.MenuItem261, Me.MenuItem256, Me.MenuItem258, Me.MenuItem259, Me.MenuItem260, Me.MenuItem262})
        Me.MenuItem255.Text = "Cost Analysis"
        '
        'MenuItem257
        '
        Me.MenuItem257.Index = 0
        Me.MenuItem257.Text = "CDR"
        '
        'MenuItem261
        '
        Me.MenuItem261.Index = 1
        Me.MenuItem261.Text = "CP Series"
        '
        'MenuItem256
        '
        Me.MenuItem256.Index = 2
        Me.MenuItem256.Text = "DKS"
        '
        'MenuItem258
        '
        Me.MenuItem258.Index = 3
        Me.MenuItem258.Text = "VIN3"
        '
        'MenuItem259
        '
        Me.MenuItem259.Index = 4
        Me.MenuItem259.Text = "VIN4"
        '
        'MenuItem260
        '
        Me.MenuItem260.Index = 5
        Me.MenuItem260.Text = "R Series"
        '
        'MenuItem262
        '
        Me.MenuItem262.Index = 6
        Me.MenuItem262.Text = "SRS"
        '
        'MenuItem103
        '
        Me.MenuItem103.Index = 16
        Me.MenuItem103.Text = "Customer Deposits for Month as Of"
        '
        'MenuItem104
        '
        Me.MenuItem104.Index = 17
        Me.MenuItem104.Text = "Customer Deposits for All as Of"
        '
        'MenuItem293
        '
        Me.MenuItem293.Index = 18
        Me.MenuItem293.Text = "Design Quotes by OSR"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 19
        Me.MenuItem56.Text = "Open Unshipped Orders by Payment Code As Of"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 20
        Me.MenuItem99.Text = "Open Unshipped Orders As Of"
        '
        'MenuItem172
        '
        Me.MenuItem172.Index = 21
        Me.MenuItem172.Text = "Orders by Division"
        '
        'MenuItem229
        '
        Me.MenuItem229.Index = 22
        Me.MenuItem229.Text = "Orders Shipped Not Billed"
        '
        'MenuItem183
        '
        Me.MenuItem183.Index = 23
        Me.MenuItem183.Text = "Payment Credit Detail"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 24
        Me.MenuItem20.Text = "Payment Receipts"
        '
        'MenuItem217
        '
        Me.MenuItem217.Index = 25
        Me.MenuItem217.Text = "Payment Receipts (All Dates)"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 26
        Me.MenuItem115.Text = "Payment Receipts by OSR"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 27
        Me.MenuItem61.Text = "Payment Receipts Cash Only"
        '
        'MenuItem310
        '
        Me.MenuItem310.Index = 28
        Me.MenuItem310.Text = "Payment Receipts Daily"
        '
        'MenuItem251
        '
        Me.MenuItem251.Index = 29
        Me.MenuItem251.Text = "Proposed Staged Summary"
        '
        'MenuItem182
        '
        Me.MenuItem182.Index = 30
        Me.MenuItem182.Text = "Referral Payment Detail"
        '
        'MenuItem157
        '
        Me.MenuItem157.Index = 31
        Me.MenuItem157.Text = "Referrals To Be Paid"
        '
        'MenuItem158
        '
        Me.MenuItem158.Index = 32
        Me.MenuItem158.Text = "Referrals Paid"
        '
        'MenuItem134
        '
        Me.MenuItem134.Index = 33
        Me.MenuItem134.Text = "Margins"
        '
        'MenuItem140
        '
        Me.MenuItem140.Index = 34
        Me.MenuItem140.Text = "Margins by Current Sales Rep"
        '
        'MenuItem148
        '
        Me.MenuItem148.Index = 35
        Me.MenuItem148.Text = "Margins by Current Sales Rep (No Speed Codes)"
        '
        'MenuItem224
        '
        Me.MenuItem224.Index = 36
        Me.MenuItem224.Text = "Margins by Designer"
        '
        'MenuItem279
        '
        Me.MenuItem279.Index = 37
        Me.MenuItem279.Text = "Margins by OSR per Order Group"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 38
        Me.MenuItem76.Text = "Margins by Product Type"
        '
        'MenuItem292
        '
        Me.MenuItem292.Index = 39
        Me.MenuItem292.Text = "Margins by Product Type by Source Code"
        '
        'MenuItem240
        '
        Me.MenuItem240.Index = 40
        Me.MenuItem240.Text = "Margins by Product Type Summary"
        '
        'MenuItem284
        '
        Me.MenuItem284.Index = 41
        Me.MenuItem284.Text = "Margins by Source Code"
        '
        'MenuItem291
        '
        Me.MenuItem291.Index = 42
        Me.MenuItem291.Text = "Margins by Source Code by Product Type"
        '
        'MenuItem139
        '
        Me.MenuItem139.Index = 43
        Me.MenuItem139.Text = "Margins by Territory"
        '
        'MenuItem147
        '
        Me.MenuItem147.Index = 44
        Me.MenuItem147.Text = "Margins by Territory (No speed codes)"
        '
        'MenuItem184
        '
        Me.MenuItem184.Index = 45
        Me.MenuItem184.Text = "Margins by Territory (Some Product Codes)"
        '
        'MenuItem141
        '
        Me.MenuItem141.Index = 46
        Me.MenuItem141.Text = "Margins for Stain"
        '
        'MenuItem142
        '
        Me.MenuItem142.Index = 47
        Me.MenuItem142.Text = "Margins Per Sales (No speed codes)"
        '
        'MenuItem159
        '
        Me.MenuItem159.Index = 48
        Me.MenuItem159.Text = "Tax Credits"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 1
        Me.MenuItem37.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem38, Me.MenuItem39, Me.MenuItem119, Me.MenuItem164, Me.MenuItem202, Me.MenuItem203, Me.MenuItem204, Me.MenuItem205, Me.MenuItem206, Me.MenuItem288, Me.MenuItem301})
        Me.MenuItem37.Text = "Commissions"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 0
        Me.MenuItem38.Text = "By Product Type"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 1
        Me.MenuItem39.Text = "By Sales Category"
        '
        'MenuItem119
        '
        Me.MenuItem119.Index = 2
        Me.MenuItem119.Text = "Design Checker"
        '
        'MenuItem164
        '
        Me.MenuItem164.Index = 3
        Me.MenuItem164.Text = "Commissions for ISR, OSR, MGR and Supervisor"
        '
        'MenuItem202
        '
        Me.MenuItem202.Index = 4
        Me.MenuItem202.Text = "For PCA"
        '
        'MenuItem203
        '
        Me.MenuItem203.Index = 5
        Me.MenuItem203.Text = "For Weekly Sales by Category"
        '
        'MenuItem204
        '
        Me.MenuItem204.Index = 6
        Me.MenuItem204.Text = "For Rack Design"
        '
        'MenuItem205
        '
        Me.MenuItem205.Index = 7
        Me.MenuItem205.Text = "For Cellar Art"
        '
        'MenuItem206
        '
        Me.MenuItem206.Index = 8
        Me.MenuItem206.Text = "For Refrigeration"
        '
        'MenuItem288
        '
        Me.MenuItem288.Index = 9
        Me.MenuItem288.Text = "Margins by OSR per Order Shipped/Staged"
        '
        'MenuItem301
        '
        Me.MenuItem301.Index = 10
        Me.MenuItem301.Text = "Sales by Responsibility by Ship date"
        '
        'MenuItem289
        '
        Me.MenuItem289.Index = 2
        Me.MenuItem289.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem296, Me.MenuItem290, Me.MenuItem324, Me.MenuItem325})
        Me.MenuItem289.Text = "CRM"

        Me.MenuItem325.Index = 3
        Me.MenuItem325.Text = "Leads Log"
        '
        'MenuItem296
        '
        Me.MenuItem296.Index = 0
        Me.MenuItem296.Text = "Call Center Calls Tracking"
        '
        'MenuItem290
        '
        Me.MenuItem290.Index = 1
        Me.MenuItem290.Text = "OSR Contact Notes"
        '
        'MenuItem324
        '
        Me.MenuItem324.Index = 2
        Me.MenuItem324.Text = "Leads Without Quotes"
        '
        'MenuItem306
        '
        Me.MenuItem306.Index = 3
        Me.MenuItem306.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem307, Me.MenuItem314})
        Me.MenuItem306.Text = "Field Consultant"
        '
        'MenuItem307
        '
        Me.MenuItem307.Index = 0
        Me.MenuItem307.Text = "Field Consultant Report"
        '
        'MenuItem314
        '
        Me.MenuItem314.Index = 1
        Me.MenuItem314.Text = "Field Consult by Type"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 4
        Me.MenuItem68.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem72, Me.MenuItem277, Me.MenuItem214, Me.MenuItem69, Me.MenuItem87, Me.MenuItem185, Me.MenuItem238, Me.MenuItem81, Me.MenuItem74, Me.MenuItem71})
        Me.MenuItem68.Text = "Forecasting"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 0
        Me.MenuItem72.Text = "Crosstab"
        '
        'MenuItem277
        '
        Me.MenuItem277.Index = 1
        Me.MenuItem277.Text = "Crosstab - Quantity"
        '
        'MenuItem214
        '
        Me.MenuItem214.Index = 2
        Me.MenuItem214.Text = "Forecast Not Checked Off"
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 3
        Me.MenuItem69.Text = "Forecasting"
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 4
        Me.MenuItem87.Text = "Forecasting Detail"
        '
        'MenuItem185
        '
        Me.MenuItem185.Index = 5
        Me.MenuItem185.Text = "Forecasting For PCA"
        '
        'MenuItem238
        '
        Me.MenuItem238.Index = 6
        Me.MenuItem238.Text = "Forecasting For PCA by Create Date"
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 7
        Me.MenuItem81.Text = "Forecasting Lost"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 8
        Me.MenuItem74.Text = "Forecasting Needed"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 9
        Me.MenuItem71.Text = "Summary"
        '
        'MenuItem316
        '
        Me.MenuItem316.Index = 5
        Me.MenuItem316.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem318, Me.MenuItem317, Me.MenuItem319})
        Me.MenuItem316.Text = "Livechat"
        '
        'MenuItem318
        '
        Me.MenuItem318.Index = 0
        Me.MenuItem318.Text = "Quotes"
        '
        'MenuItem317
        '
        Me.MenuItem317.Index = 1
        Me.MenuItem317.Text = "Orders"
        '
        'MenuItem319
        '
        Me.MenuItem319.Index = 2
        Me.MenuItem319.Text = "Shipped"
        '
        'MenuItem325
        Me.MenuItem325.Index = 3
        Me.MenuItem325.Text = "Leads Log"
        '
        'MenuItem242
        '
        Me.MenuItem242.Index = 6
        Me.MenuItem242.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem280, Me.MenuItem263, Me.MenuItem264, Me.MenuItem265, Me.MenuItem273, Me.MenuItem244, Me.MenuItem245, Me.MenuItem243, Me.MenuItem247, Me.MenuItem268})
        Me.MenuItem242.Text = "Production"
        '
        'MenuItem280
        '
        Me.MenuItem280.Index = 0
        Me.MenuItem280.Text = "Custom to Factory by Date"
        '
        'MenuItem263
        '
        Me.MenuItem263.Index = 1
        Me.MenuItem263.Text = "In Process Orders with Base Price"
        '
        'MenuItem264
        '
        Me.MenuItem264.Index = 2
        Me.MenuItem264.Text = "In Process Orders with Base Price (Excel)"
        '
        'MenuItem265
        '
        Me.MenuItem265.Index = 3
        Me.MenuItem265.Text = "In Process Orders with Base Price - Install"
        '
        'MenuItem273
        '
        Me.MenuItem273.Index = 4
        Me.MenuItem273.Text = "Kits Ordered"
        '
        'MenuItem244
        '
        Me.MenuItem244.Index = 5
        Me.MenuItem244.Text = "Production Install Dates"
        '
        'MenuItem245
        '
        Me.MenuItem245.Index = 6
        Me.MenuItem245.Text = "Production Install Service Calls"
        '
        'MenuItem243
        '
        Me.MenuItem243.Index = 7
        Me.MenuItem243.Text = "Production Status"
        '
        'MenuItem247
        '
        Me.MenuItem247.Index = 8
        Me.MenuItem247.Text = "Production Status - Email It"
        Me.MenuItem247.Visible = False
        '
        'MenuItem268
        '
        Me.MenuItem268.Index = 9
        Me.MenuItem268.Text = "Rack Design - Time Review"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 7
        Me.MenuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem210, Me.MenuItem211, Me.MenuItem146, Me.MenuItem278, Me.MenuItem313, Me.MenuItem321, Me.MenuItem322, Me.MenuItem323, Me.MenuItem311, Me.MenuItem219, Me.MenuItem94, Me.MenuItem150, Me.MenuItem67, Me.MenuItem90, Me.MenuItem228, Me.MenuItem85, Me.MenuItem155, Me.MenuItem161, Me.MenuItem270, Me.MenuItem271, Me.MenuItem22, Me.MenuItem122, Me.MenuItem123, Me.MenuItem233, Me.MenuItem33, Me.MenuItem230, Me.MenuItem253, Me.MenuItem212, Me.MenuItem154, Me.MenuItem16, Me.MenuItem84, Me.MenuItem315, Me.MenuItem231, Me.MenuItem167, Me.MenuItem168, Me.MenuItem220, Me.MenuItem176, Me.MenuItem178, Me.MenuItem173, Me.MenuItem304, Me.MenuItem283, Me.MenuItem198, Me.MenuItem5, Me.MenuItem116, Me.MenuItem83, Me.MenuItem237, Me.MenuItem89, Me.MenuItem297, Me.MenuItem21, Me.MenuItem294, Me.MenuItem62, Me.MenuItem97, Me.MenuItem303, Me.MenuItem30, Me.MenuItem274, Me.MenuItem144, Me.MenuItem275, Me.MenuItem235, Me.MenuItem93, Me.MenuItem28, Me.MenuItem309, Me.MenuItem163, Me.MenuItem124, Me.MenuItem252, Me.MenuItem14, Me.MenuItem174, Me.MenuItem285, Me.MenuItem236, Me.MenuItem145, Me.MenuItem249, Me.MenuItem269, Me.MenuItem200, Me.MenuItem117, Me.MenuItem195, Me.MenuItem112, Me.MenuItem113, Me.MenuItem149, Me.MenuItem162, Me.MenuItem6, Me.MenuItem8, Me.MenuItem215, Me.MenuItem80, Me.MenuItem223, Me.MenuItem282})
        Me.MenuItem15.Text = "Sales"
        '
        'MenuItem210
        '
        Me.MenuItem210.Index = 0
        Me.MenuItem210.Text = "Amber Blaze Quotes"
        '
        'MenuItem211
        '
        Me.MenuItem211.Index = 1
        Me.MenuItem211.Text = "Amber Blaze Orders"
        '
        'MenuItem146
        '
        Me.MenuItem146.Index = 2
        Me.MenuItem146.Text = "Average Item Sold Dollar"
        '
        'MenuItem278
        '
        Me.MenuItem278.Index = 3
        Me.MenuItem278.Text = "Call Center Calls"
        '
        'MenuItem313
        '
        Me.MenuItem313.Index = 4
        Me.MenuItem313.Text = "Cancelled Orders"
        '
        'MenuItem321
        '
        Me.MenuItem321.Index = 5
        Me.MenuItem321.Text = "CC Portal Report"
        '
        'MenuItem322
        '
        Me.MenuItem322.Index = 6
        Me.MenuItem322.Text = "Chris M Leads Report"
        '
        'MenuItem323
        '
        Me.MenuItem323.Index = 7
        Me.MenuItem323.Text = "Chris M Contacts Report"
        '
        'MenuItem311
        '
        Me.MenuItem311.Index = 8
        Me.MenuItem311.Text = "Contacts List"
        '
        'MenuItem219
        '
        Me.MenuItem219.Index = 9
        Me.MenuItem219.Text = "Credit Tracking"
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 10
        Me.MenuItem94.Text = "Customer Forum"
        '
        'MenuItem150
        '
        Me.MenuItem150.Index = 11
        Me.MenuItem150.Text = "Customer Forum - Custom"
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 12
        Me.MenuItem67.Text = "Customer List"
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 13
        Me.MenuItem90.Text = "Customer Ship to List by Order Number"
        '
        'MenuItem228
        '
        Me.MenuItem228.Index = 14
        Me.MenuItem228.Text = "Customers with 3rd Party Billing and Orders Not"
        '
        'MenuItem85
        '
        Me.MenuItem85.Index = 15
        Me.MenuItem85.Text = "Direct Sales Customer Email List"
        '
        'MenuItem155
        '
        Me.MenuItem155.Index = 16
        Me.MenuItem155.Text = "Designer Productivity by Design Type"
        '
        'MenuItem161
        '
        Me.MenuItem161.Index = 17
        Me.MenuItem161.Text = "Design Type Win Ratio"
        '
        'MenuItem270
        '
        Me.MenuItem270.Index = 18
        Me.MenuItem270.Text = "Diagnostics Outstanding"
        '
        'MenuItem271
        '
        Me.MenuItem271.Index = 19
        Me.MenuItem271.Text = "Diagnostics Received"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 20
        Me.MenuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem23, Me.MenuItem24})
        Me.MenuItem22.Text = "Forecast"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 0
        Me.MenuItem23.Text = "By Territory"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 1
        Me.MenuItem24.Text = "This Week"
        '
        'MenuItem122
        '
        Me.MenuItem122.Index = 21
        Me.MenuItem122.Text = "Fountains - Splits -Whisp - Breez"
        '
        'MenuItem123
        '
        Me.MenuItem123.Index = 22
        Me.MenuItem123.Text = "Humidor Totals"
        '
        'MenuItem233
        '
        Me.MenuItem233.Index = 23
        Me.MenuItem233.Text = "Install Minutes by Item Code"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 24
        Me.MenuItem33.Text = "Item Pricing"
        '
        'MenuItem230
        '
        Me.MenuItem230.Index = 25
        Me.MenuItem230.Text = "Item Price Updates"
        '
        'MenuItem253
        '
        Me.MenuItem253.Index = 26
        Me.MenuItem253.Text = "Item Export for Import"
        '
        'MenuItem212
        '
        Me.MenuItem212.Index = 27
        Me.MenuItem212.Text = "Kits Per Week"
        '
        'MenuItem154
        '
        Me.MenuItem154.Index = 28
        Me.MenuItem154.Text = "Order Analysis Art to Custom"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 29
        Me.MenuItem16.Text = "Order Analysis by Date, Product Type"
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 30
        Me.MenuItem84.Text = "Order Analysis by Product Type, Date"
        '
        'MenuItem315
        '
        Me.MenuItem315.Index = 31
        Me.MenuItem315.Text = "Order Analysis by Product Type, Date (FIX)"
        '
        'MenuItem231
        '
        Me.MenuItem231.Index = 32
        Me.MenuItem231.Text = "Order Analysis Canceled by Customer"
        '
        'MenuItem167
        '
        Me.MenuItem167.Index = 33
        Me.MenuItem167.Text = "Order Analysis Canceled by Product Code"
        '
        'MenuItem168
        '
        Me.MenuItem168.Index = 34
        Me.MenuItem168.Text = "Order Analysis - Credits"
        '
        'MenuItem220
        '
        Me.MenuItem220.Index = 35
        Me.MenuItem220.Text = "Order Analysis - Shipping Promotions"
        '
        'MenuItem176
        '
        Me.MenuItem176.Index = 36
        Me.MenuItem176.Text = "Order Analysis - Tax Exempt"
        '
        'MenuItem178
        '
        Me.MenuItem178.Index = 37
        Me.MenuItem178.Text = "Order Analysis - Test Margins for Zero Base Price"
        '
        'MenuItem173
        '
        Me.MenuItem173.Index = 38
        Me.MenuItem173.Text = "Orders with Quotes Forecasted"
        '
        'MenuItem304
        '
        Me.MenuItem304.Index = 39
        Me.MenuItem304.Text = "Open Custom Orders – Current Status"
        '
        'MenuItem283
        '
        Me.MenuItem283.Index = 40
        Me.MenuItem283.Text = "Open Order Kit and CDR Status"
        '
        'MenuItem198
        '
        Me.MenuItem198.Index = 41
        Me.MenuItem198.Text = "Open Order Summary"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 42
        Me.MenuItem5.Text = "Open Orders by Product Code"
        '
        'MenuItem116
        '
        Me.MenuItem116.Index = 43
        Me.MenuItem116.Text = "Open Order by Product Code for Cellar Art"
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 44
        Me.MenuItem83.Text = "Open Orders by Product Code, Sales Category"
        '
        'MenuItem237
        '
        Me.MenuItem237.Index = 45
        Me.MenuItem237.Text = "Open Orders by Product Code, Sign Off Status"
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 46
        Me.MenuItem89.Text = "Open Orders by Territory with Payments"
        '
        'MenuItem297
        '
        Me.MenuItem297.Index = 47
        Me.MenuItem297.Text = "Open Orders by To Factory"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 48
        Me.MenuItem21.Text = "Orders by Order Sources"
        '
        'MenuItem294
        '
        Me.MenuItem294.Index = 49
        Me.MenuItem294.Text = "Orders by Responsibilty"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 50
        Me.MenuItem62.Text = "OSR Tracking"
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 51
        Me.MenuItem97.Text = "OSR Tracking Crosstab"
        '
        'MenuItem303
        '
        Me.MenuItem303.Index = 52
        Me.MenuItem303.Text = "Payments by Responsibility"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 53
        Me.MenuItem30.Text = "Products Ordered by Customer"
        '
        'MenuItem274
        '
        Me.MenuItem274.Index = 54
        Me.MenuItem274.Text = "Products Ordered by Customer - All Currently Active"
        '
        'MenuItem144
        '
        Me.MenuItem144.Index = 55
        Me.MenuItem144.Text = "Products Ordered by Customer by Ship/Stage Date"
        '
        'MenuItem275
        '
        Me.MenuItem275.Index = 56
        Me.MenuItem275.Text = "Products Ordered by Customer by Ship/Stage Date - All Currently Active"
        '
        'MenuItem235
        '
        Me.MenuItem235.Index = 57
        Me.MenuItem235.Text = "Quotes"
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = 58
        Me.MenuItem93.Text = "Quote Analysis by Designer"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 59
        Me.MenuItem28.Text = "Quote Analysis by Rep"
        '
        'MenuItem309
        '
        Me.MenuItem309.Index = 60
        Me.MenuItem309.Text = "Quote - Design - Start Checking"
        '
        'MenuItem163
        '
        Me.MenuItem163.Index = 61
        Me.MenuItem163.Text = "Quotes by Division"
        '
        'MenuItem124
        '
        Me.MenuItem124.Index = 62
        Me.MenuItem124.Text = "Quotes by Division for Custom"
        '
        'MenuItem252
        '
        Me.MenuItem252.Index = 63
        Me.MenuItem252.Text = "All Quotes by Order Sources"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 64
        Me.MenuItem14.Text = "New Quotes by Order Sources"
        '
        'MenuItem174
        '
        Me.MenuItem174.Index = 65
        Me.MenuItem174.Text = "Quotes by Material"
        '
        'MenuItem285
        '
        Me.MenuItem285.Index = 66
        Me.MenuItem285.Text = "Quotes by Call Center Rep"
        '
        'MenuItem236
        '
        Me.MenuItem236.Index = 67
        Me.MenuItem236.Text = "Quotes Released"
        '
        'MenuItem145
        '
        Me.MenuItem145.Index = 68
        Me.MenuItem145.Text = "Quote Count by Designer"
        '
        'MenuItem249
        '
        Me.MenuItem249.Index = 69
        Me.MenuItem249.Text = "Quote Design Analysis 2D"
        '
        'MenuItem269
        '
        Me.MenuItem269.Index = 70
        Me.MenuItem269.Text = "Quote design Analysis 2D (Excel)"
        '
        'MenuItem200
        '
        Me.MenuItem200.Index = 71
        Me.MenuItem200.Text = "Quote Detail Per Customer"
        '
        'MenuItem117
        '
        Me.MenuItem117.Index = 72
        Me.MenuItem117.Text = "Quote Rev by Territory"
        '
        'MenuItem195
        '
        Me.MenuItem195.Index = 73
        Me.MenuItem195.Text = "Quote Win Ratio for Custom by Customer ID"
        '
        'MenuItem112
        '
        Me.MenuItem112.Index = 74
        Me.MenuItem112.Text = "Quote Win Ratio for Custom"
        '
        'MenuItem113
        '
        Me.MenuItem113.Index = 75
        Me.MenuItem113.Text = "Quote Win Ratio for Fixtures"
        '
        'MenuItem149
        '
        Me.MenuItem149.Index = 76
        Me.MenuItem149.Text = "Replacements"
        '
        'MenuItem162
        '
        Me.MenuItem162.Index = 77
        Me.MenuItem162.Text = "Sales Margins Top 5"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 78
        Me.MenuItem6.Text = "Sales Report by Rep"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 79
        Me.MenuItem8.Text = "Ship Analysis by Product Type"
        '
        'MenuItem215
        '
        Me.MenuItem215.Index = 80
        Me.MenuItem215.Text = "Source Code Analysis"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 81
        Me.MenuItem80.Text = "Staged Order Summary"
        '
        'MenuItem223
        '
        Me.MenuItem223.Index = 82
        Me.MenuItem223.Text = "Stain Price at Base"
        '
        'MenuItem282
        '
        Me.MenuItem282.Index = 83
        Me.MenuItem282.Text = "Total Sales Per Dealer Rep"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 8
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem298, Me.MenuItem312, Me.MenuItem34, Me.MenuItem191, Me.MenuItem246, Me.MenuItem286, Me.MenuItem287, Me.MenuItem18, Me.MenuItem91, Me.MenuItem128, Me.MenuItem129, Me.MenuItem199, Me.MenuItem29, Me.MenuItem82, Me.MenuItem52, Me.MenuItem98, Me.MenuItem221, Me.MenuItem131, Me.MenuItem31, Me.MenuItem209, Me.MenuItem53, Me.MenuItem73, Me.MenuItem201, Me.MenuItem213, Me.MenuItem78, Me.MenuItem189, Me.MenuItem207, Me.MenuItem92, Me.MenuItem135, Me.MenuItem60, Me.MenuItem234, Me.MenuItem276, Me.MenuItem241})
        Me.MenuItem17.Text = "Shipping"
        '
        'MenuItem298
        '
        Me.MenuItem298.Index = 0
        Me.MenuItem298.Text = "Custom Order MAT-BOT-RH"
        '
        'MenuItem312
        '
        Me.MenuItem312.Index = 1
        Me.MenuItem312.Text = "Custom Order MAT-BOT-RH by Order Date"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 2
        Me.MenuItem34.Text = "Items Shipped"
        '
        'MenuItem191
        '
        Me.MenuItem191.Index = 3
        Me.MenuItem191.Text = "Items Shipped (Certain Item Codes)"
        '
        'MenuItem246
        '
        Me.MenuItem246.Index = 4
        Me.MenuItem246.Text = "Items Shipped (All Part Numbers Listed)"
        '
        'MenuItem286
        '
        Me.MenuItem286.Index = 5
        Me.MenuItem286.Text = "Kits Shipped with Box Count"
        '
        'MenuItem287
        '
        Me.MenuItem287.Index = 6
        Me.MenuItem287.Text = "Order with Kits Downstairs"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 7
        Me.MenuItem18.Text = "Ship Analysis by Ship Date, Product Type"
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = 8
        Me.MenuItem91.Text = "Ship Analysis by OSR, ARCH Product Code"
        '
        'MenuItem128
        '
        Me.MenuItem128.Index = 9
        Me.MenuItem128.Text = "Ship Analysis by OSR, ARCH Product Code Crosstab"
        '
        'MenuItem129
        '
        Me.MenuItem129.Index = 10
        Me.MenuItem129.Text = "Ship Analysis Art to Custom"
        '
        'MenuItem199
        '
        Me.MenuItem199.Index = 11
        Me.MenuItem199.Text = "Ship Analysis by Product Type, Boxes"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 12
        Me.MenuItem29.Text = "Ship Analysis by Product Type, Ship Date"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 13
        Me.MenuItem82.Text = "Ship Analysis by Product Type, OSR"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 14
        Me.MenuItem52.Text = "Ship Analysis by Product Type, Territory"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 15
        Me.MenuItem98.Text = "Ship Analysis Tax and Shipping Charged to Customer"
        '
        'MenuItem221
        '
        Me.MenuItem221.Index = 16
        Me.MenuItem221.Text = "Shipped Staged Crosstab"
        '
        'MenuItem131
        '
        Me.MenuItem131.Index = 17
        Me.MenuItem131.Text = "Shipped Staged Price Analysis by Product Type"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 18
        Me.MenuItem31.Text = "Shipments"
        '
        'MenuItem209
        '
        Me.MenuItem209.Index = 19
        Me.MenuItem209.Text = "Shipments by Days"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 20
        Me.MenuItem53.Text = "Shipments for Accounting"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 21
        Me.MenuItem73.Text = "Shipments by Order Source"
        '
        'MenuItem201
        '
        Me.MenuItem201.Index = 22
        Me.MenuItem201.Text = "Shipments by Zone"
        '
        'MenuItem213
        '
        Me.MenuItem213.Index = 23
        Me.MenuItem213.Text = "Shipments by Zone with Product Type"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 24
        Me.MenuItem78.Text = "Shipments and Staged by Order Source"
        '
        'MenuItem189
        '
        Me.MenuItem189.Index = 25
        Me.MenuItem189.Text = "Shipments and Staged by Order Source by State"
        '
        'MenuItem207
        '
        Me.MenuItem207.Index = 26
        Me.MenuItem207.Text = "Shipments for Customers"
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = 27
        Me.MenuItem92.Text = "Shipped Orders by State"
        '
        'MenuItem135
        '
        Me.MenuItem135.Index = 28
        Me.MenuItem135.Text = "Shipped Splits by Shipped Date"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 29
        Me.MenuItem60.Text = "Shipping Costs"
        '
        'MenuItem234
        '
        Me.MenuItem234.Index = 30
        Me.MenuItem234.Text = "Shipping Discount by Promotional Code"
        '
        'MenuItem276
        '
        Me.MenuItem276.Index = 31
        Me.MenuItem276.Text = "Shipping Discounts by Promotional Code - Extended"
        '
        'MenuItem241
        '
        Me.MenuItem241.Index = 32
        Me.MenuItem241.Text = "Shipping Releases"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 9
        Me.MenuItem49.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem218, Me.MenuItem47, Me.MenuItem48, Me.MenuItem299, Me.MenuItem132, Me.MenuItem133})
        Me.MenuItem49.Text = "Tax"
        '
        'MenuItem218
        '
        Me.MenuItem218.Index = 0
        Me.MenuItem218.Text = "Tax Certification Usage"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 1
        Me.MenuItem47.Text = "Tax Compare Report-OLD"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 2
        Me.MenuItem48.Text = "Tax Summary Report-OLD"
        '
        'MenuItem299
        '
        Me.MenuItem299.Index = 3
        Me.MenuItem299.Text = "Tax Compare Audit Report"
        '
        'MenuItem132
        '
        Me.MenuItem132.Index = 4
        Me.MenuItem132.Text = "Tax Compare Report"
        '
        'MenuItem133
        '
        Me.MenuItem133.Index = 5
        Me.MenuItem133.Text = "Tax Summary Report"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 4
        'Me.MenuItem26.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem166, Me.MenuItem272, Me.MenuItem281, Me.MenuItem193, Me.MenuItem308, Me.MenuItem101, Me.MenuItem126, Me.MenuItem179, Me.MenuItem160, Me.MenuItem232, Me.MenuItem266, Me.MenuItem27, Me.MenuItem250, Me.MenuItem326})
        Me.MenuItem26.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem166, Me.MenuItem272, Me.MenuItem281, Me.MenuItem193, Me.MenuItem308, Me.MenuItem101, Me.MenuItem126, Me.MenuItem179, Me.MenuItem160, Me.MenuItem232, Me.MenuItem266, Me.MenuItem27, Me.MenuItem250})
        Me.MenuItem26.Text = "Functions"
        '
        'MenuItem166
        '
        Me.MenuItem166.Index = 0
        Me.MenuItem166.Text = "Approve Discount"
        '
        'MenuItem272
        '
        Me.MenuItem272.Index = 1
        Me.MenuItem272.Text = "Call Center Admin"
        '
        'MenuItem281
        '
        Me.MenuItem281.Index = 2
        Me.MenuItem281.Text = "Catalog Requests"
        '
        'MenuItem193
        '
        Me.MenuItem193.Index = 3
        Me.MenuItem193.Text = "Commissions"
        '
        'MenuItem308
        '
        Me.MenuItem308.Index = 4
        Me.MenuItem308.Text = "Credit Card Portal Processing"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 5
        Me.MenuItem101.Text = "Designer Check Off"
        '
        'MenuItem126
        '
        Me.MenuItem126.Index = 6
        Me.MenuItem126.Text = "Make This My Default Form"
        '
        'MenuItem179
        '
        Me.MenuItem179.Index = 7
        Me.MenuItem179.Text = "Order Commission Override"
        '
        'MenuItem160
        '
        Me.MenuItem160.Index = 8
        Me.MenuItem160.Text = "Pay Referrals"
        '
        'MenuItem232
        '
        Me.MenuItem232.Index = 9
        Me.MenuItem232.Text = "Print Customer Orders"
        '
        'MenuItem266
        '
        Me.MenuItem266.Index = 10
        Me.MenuItem266.Text = "Production Lock"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 11
        Me.MenuItem27.Text = "Stage Orders"
        '
        'MenuItem250
        '
        Me.MenuItem250.Index = 12
        Me.MenuItem250.Text = "Website - Export Items"
        '
        'MenuItem326
        '
        Me.MenuItem326.Index = 13
        Me.MenuItem326.Text = "Website - Export Items"
        '
        'MenuItem136
        '
        Me.MenuItem136.Index = 5
        Me.MenuItem136.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem130, Me.MenuItem138, Me.MenuItem114, Me.MenuItem175, Me.MenuItem151, Me.MenuItem170, Me.MenuItem302})
        Me.MenuItem136.Text = "Shipping"
        '
        'MenuItem130
        '
        Me.MenuItem130.Index = 0
        Me.MenuItem130.Text = "Shipping Import Bill"
        '
        'MenuItem138
        '
        Me.MenuItem138.Index = 1
        Me.MenuItem138.Text = "Shipping Import Bill Reprint"
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 2
        Me.MenuItem114.Text = "Ship Today Selection"
        '
        'MenuItem175
        '
        Me.MenuItem175.Index = 3
        Me.MenuItem175.Text = "Shipment Picker"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 4
        Me.MenuItem151.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem152})
        Me.MenuItem151.Text = "End of Day"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 0
        Me.MenuItem152.Text = "FedEx"
        '
        'MenuItem170
        '
        Me.MenuItem170.Index = 5
        Me.MenuItem170.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem171, Me.MenuItem254})
        Me.MenuItem170.Text = "Setup Label Printer"
        '
        'MenuItem171
        '
        Me.MenuItem171.Index = 0
        Me.MenuItem171.Text = "FedEx"
        '
        'MenuItem254
        '
        Me.MenuItem254.Index = 1
        Me.MenuItem254.Text = "Choose Label Printer"
        '
        'MenuItem302
        '
        Me.MenuItem302.Index = 6
        Me.MenuItem302.Text = "Open Orders Kit\CDR"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 6
        Me.MenuItem58.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem59})
        Me.MenuItem58.Text = "VendorNet"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 0
        Me.MenuItem59.Text = "Send / Receive Files"
        '
        'MenuItem127
        '
        Me.MenuItem127.Index = 7
        Me.MenuItem127.MdiList = True
        Me.MenuItem127.Text = "Window"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, -18)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.sIcon, Me.sMain})
        Me.StatusBar1.Size = New System.Drawing.Size(1266, 18)
        Me.StatusBar1.TabIndex = 5
        '
        'sIcon
        '
        Me.sIcon.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.sIcon.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.sIcon.Icon = CType(resources.GetObject("sIcon.Icon"), System.Drawing.Icon)
        Me.sIcon.Name = "sIcon"
        Me.sIcon.Width = 39
        '
        'sMain
        '
        Me.sMain.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.sMain.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.sMain.Name = "sMain"
        Me.sMain.Width = 745
        '
        'Toolbar1
        '
        Me.Toolbar1.DesignerFlags = 1
        Me.Toolbar1.DockWithinContainer = Me
        Me.Toolbar1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        Me.Toolbar1.ImageListLarge = Me.ImageList1
        Me.Toolbar1.ImageListSmall = Me.ImageList1
        Me.Toolbar1.ShowFullMenusDelay = 500
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingSize = New System.Drawing.Size(448, 38)
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4, ButtonTool5, ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool37})
        UltraToolbar1.Settings.CaptionPlacement = Infragistics.Win.TextPlacement.BelowImage
        UltraToolbar1.Settings.FillEntireRow = Infragistics.Win.DefaultableBoolean.[True]
        UltraToolbar1.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        UltraToolbar1.Settings.ToolSpacing = 5
        UltraToolbar1.Text = "ToolBar1"
        UltraToolbar2.DockedColumn = 0
        UltraToolbar2.DockedRow = 1
        UltraToolbar2.FloatingLocation = New System.Drawing.Point(465, 359)
        UltraToolbar2.FloatingSize = New System.Drawing.Size(558, 24)
        ButtonTool14.InstanceProps.IsFirstInGroup = True
        ButtonTool15.InstanceProps.IsFirstInGroup = True
        ButtonTool17.InstanceProps.IsFirstInGroup = True
        UltraToolbar2.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool10, ButtonTool11, ButtonTool12, ButtonTool13, ButtonTool14, ButtonTool15, ButtonTool16, ButtonTool17, ButtonTool18})
        UltraToolbar2.Settings.CaptionPlacement = Infragistics.Win.TextPlacement.RightOfImage
        UltraToolbar2.Settings.FillEntireRow = Infragistics.Win.DefaultableBoolean.[True]
        UltraToolbar2.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        UltraToolbar2.Text = "AddEdit"
        Me.Toolbar1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1, UltraToolbar2})
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        ButtonTool19.SharedPropsInternal.AppearancesLarge.Appearance = Appearance1
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        ButtonTool19.SharedPropsInternal.AppearancesSmall.Appearance = Appearance2
        ButtonTool19.SharedPropsInternal.Caption = "Customers"
        ButtonTool19.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance3.Image = 1
        ButtonTool20.SharedPropsInternal.AppearancesLarge.Appearance = Appearance3
        Appearance4.Image = 1
        ButtonTool20.SharedPropsInternal.AppearancesSmall.Appearance = Appearance4
        ButtonTool20.SharedPropsInternal.Caption = "Quotes/Orders"
        ButtonTool20.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance5.Image = 3
        ButtonTool21.SharedPropsInternal.AppearancesLarge.Appearance = Appearance5
        Appearance6.Image = 3
        ButtonTool21.SharedPropsInternal.AppearancesSmall.Appearance = Appearance6
        ButtonTool21.SharedPropsInternal.Caption = "Parts"
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        ButtonTool22.SharedPropsInternal.AppearancesSmall.Appearance = Appearance7
        ButtonTool22.SharedPropsInternal.Caption = "Add"
        ButtonTool22.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.F1
        ButtonTool22.SharedPropsInternal.ToolTipText = "Add (F1)"
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        ButtonTool23.SharedPropsInternal.AppearancesSmall.Appearance = Appearance8
        ButtonTool23.SharedPropsInternal.Caption = "Edit"
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        ButtonTool24.SharedPropsInternal.AppearancesSmall.Appearance = Appearance9
        ButtonTool24.SharedPropsInternal.Caption = "Save"
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        ButtonTool25.SharedPropsInternal.AppearancesSmall.Appearance = Appearance10
        ButtonTool25.SharedPropsInternal.Caption = "Cancel"
        Appearance11.Image = CType(resources.GetObject("Appearance11.Image"), Object)
        ButtonTool26.SharedPropsInternal.AppearancesSmall.Appearance = Appearance11
        ButtonTool26.SharedPropsInternal.Caption = "Delete"
        Appearance12.Image = CType(resources.GetObject("Appearance12.Image"), Object)
        ButtonTool27.SharedPropsInternal.AppearancesSmall.Appearance = Appearance12
        ButtonTool27.SharedPropsInternal.Caption = "Print"
        Appearance13.Image = CType(resources.GetObject("Appearance13.Image"), Object)
        ButtonTool28.SharedPropsInternal.AppearancesSmall.Appearance = Appearance13
        ButtonTool28.SharedPropsInternal.Caption = "Done"
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        ButtonTool29.SharedPropsInternal.AppearancesSmall.Appearance = Appearance14
        ButtonTool29.SharedPropsInternal.Caption = "Find"
        ButtonTool29.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.F3
        ButtonTool29.SharedPropsInternal.ToolTipText = "Find (F3)"
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        ButtonTool30.SharedPropsInternal.AppearancesSmall.Appearance = Appearance15
        ButtonTool30.SharedPropsInternal.Caption = "Payments"
        Appearance16.Image = CType(resources.GetObject("Appearance16.Image"), Object)
        ButtonTool31.SharedPropsInternal.AppearancesSmall.Appearance = Appearance16
        ButtonTool31.SharedPropsInternal.Caption = "Shipments"
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ButtonTool32.SharedPropsInternal.AppearancesLarge.Appearance = Appearance17
        Appearance18.Image = 6
        ButtonTool32.SharedPropsInternal.AppearancesSmall.Appearance = Appearance18
        ButtonTool32.SharedPropsInternal.Caption = "Billing"
        Appearance19.Image = CType(resources.GetObject("Appearance19.Image"), Object)
        ButtonTool33.SharedPropsInternal.AppearancesSmall.Appearance = Appearance19
        ButtonTool33.SharedPropsInternal.Caption = "Check Off"
        Appearance20.Image = CType(resources.GetObject("Appearance20.Image"), Object)
        ButtonTool34.SharedPropsInternal.AppearancesSmall.Appearance = Appearance20
        ButtonTool34.SharedPropsInternal.Caption = "To Do List"
        Appearance21.Image = 7
        ButtonTool35.SharedPropsInternal.AppearancesSmall.Appearance = Appearance21
        ButtonTool35.SharedPropsInternal.Caption = "PDF"
        Appearance22.Image = 8
        ButtonTool36.SharedPropsInternal.AppearancesLarge.Appearance = Appearance22
        Appearance23.Image = 8
        ButtonTool36.SharedPropsInternal.AppearancesSmall.Appearance = Appearance23
        ButtonTool36.SharedPropsInternal.Caption = "Contacts"
        ButtonTool36.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance34.Image = "hammer.jpg"
        ButtonTool38.SharedPropsInternal.AppearancesSmall.Appearance = Appearance34
        ButtonTool38.SharedPropsInternal.Caption = "Production"
        Me.Toolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool19, ButtonTool20, ButtonTool21, ButtonTool22, ButtonTool23, ButtonTool24, ButtonTool25, ButtonTool26, ButtonTool27, ButtonTool28, ButtonTool29, ButtonTool30, ButtonTool31, ButtonTool32, ButtonTool33, ButtonTool34, ButtonTool35, ButtonTool36, ButtonTool38})
        '
        'fmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1266, 0)
        Me.Controls.Add(Me._fmMain_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._fmMain_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._fmMain_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._fmMain_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me.StatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "fmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wine Cellar Innovations STaR System (Sales, Tracking and Reporting)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub fmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            'Dim rg As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\ODBC\ODBC.INI\WineCellar", True)
            'If rg.GetValue("server") = "" Then
            '    rg.SetValue("Server", "10.0.0.245")
            'End If
            'rg.Close()
            SaveSetting("Jcom", "CheckForUpdate", "Check", "False")
            'SaveSetting("Jcom", "Messages", "Jump", "")
            MainForm = Me
            Dim fm As New fmLogin
            'set to False since we dont have ht app settings yet
            
            mnCheckForUpdates.Checked = (GetSetting("Jcom", "CheckForUpdate", "Check", "True") = "True")
            
            Jcom.Server = GetSetting("Jcom", "Settings", "Server", "")
            
            If Jcom.Server = "" Then
                Jcom.Server = "10.0.0.245"
                SaveSetting("Jcom", "Settings", "Server", "10.0.0.245")
            End If
            
            Jcom.Path = GetSetting("Jcom", "Settings", "Path", "")
            If Jcom.Path = "" Then

                Jcom.Path = "\\10.0.0.245\jcom$\"
                'Jcom.Path = "c:\data\customers\wine cellar\"

                SaveSetting("Jcom", "Settings", "Path", "\\10.0.0.245\jcom$\")
            End If
            
            'Jcom.ImagePath = GetSetting("Jcom", "Settings", "ImagePath", "")
            'If Jcom.ImagePath = "" Then
            Jcom.ImagePath = "\\10.0.0.245\DatabaseGraphics\"
            '    SaveSetting("Jcom", "Settings", "ImagePath", "\\10.0.0.245\DatabaseGraphics\")
            'End If
            'If System.IO.Directory.Exists(Jcom.Path) = False Then
            '    Dim fm2 As New fmSetting
            '    fm2.ID = "Path"
            '    fm2.ShowDialog()
            '    Jcom.Path = GetSetting("Jcom", "Settings", "Path", "")
            'End If
            'If System.IO.File.GetLastWriteTime(Jcom.Path + "winecellar.exe").ToString <> GetSetting("Jcom", "Settings", "FileTime", "") Then
            '    System.IO.File.Copy(Jcom.Path + "CopyIt.exe", "c:\program files\jcom$\winecellar\CopyIt.exe", True)
            '    SaveSetting("Jcom", "Settings", "FileTime", System.IO.File.GetLastWriteTime(Jcom.Path + "winecellar.exe").ToString)
            '    Shell("c:\program files\jcom$\winecellar\CopyIt.exe " + Jcom.Path + "WineCellar.exe" + ",c:\program files\jcom$\winecellar\WineCellar.exe", AppWinStyle.NormalFocus, False)
            '    End
            'End If
            
            If mnCheckForUpdates.Checked Then
                If System.IO.File.GetLastWriteTime(Jcom.Path + "winecellar.exe") > System.IO.File.GetLastWriteTime("winecellar.exe") Then
                    System.IO.File.Copy(Jcom.Path + "CopyIt.exe", IO.Directory.GetCurrentDirectory + "\CopyIt.exe", True)
                    'SaveSetting("Jcom", "Settings", "FileTime", System.IO.File.GetLastWriteTime(Jcom.Path + "winecellar.exe").ToString)
                    'Shell("c:\program files\jcom$\winecellar\CopyIt.exe " + Jcom.Path + "WineCellar.exe" + ",c:\program files\jcom$\winecellar\WineCellar.exe", AppWinStyle.NormalFocus, False)
                    Shell(IO.Directory.GetCurrentDirectory + "\CopyIt.exe " + Jcom.Path + "WineCellar.exe" + "," + IO.Directory.GetCurrentDirectory + "\WineCellar.exe", AppWinStyle.NormalFocus, False)
                    End
                End If
            End If
            cnnConnect()
            fm.ShowDialog()
            If User = "" Then End
            Me.Text += " (" + UCase(User) + ")"
            If onDatabase = "winecellar test" Then Me.BackColor = Color.Yellow
            EditButtons("None")
            cnn.Open()
            LoadCust()
            LoadUsr()
            LoadAcctClosed()
            'LoadMenu(MainMenu1.MenuItems)
            LoadMenu2()

            cnn.Close()
            'If System.IO.File.GetLastWriteTime(Jcom.Path + "winecellar.exe").ToString <> GetSetting("Jcom", "Settings", "FileTime", "") Then
            '    MsgBox("Latest version of program did not load properly.  See Administrator.", MsgBoxStyle.Exclamation, "Load?")
            '    End
            'End If
            If UserType = "I" Or UserType = "C" Then CheckToDo()
            If DefForm <> "" Then LoadForm(DefForm)
            CheckToDoList()

            Custom.Add("BUD")
            Custom.Add("TOP")
            Custom.Add("GOLD")

            Timer2.Enabled = True

            If User = "jadep" Then
                MenuItem26.Visible = True
                MenuItem272.Visible = True
            End If

        Catch
            DoError(Err, MainForm)
            End
        End Try
    End Sub
    Private Sub LoadMenu(ByVal mns As Menu.MenuItemCollection)
        Dim mn As MenuItem
        Dim sec As Integer

        For Each mn In mns
            sec = CheckSecurity("M-" + mn.Text)
            If sec = 0 Then
                mn.Visible = False
                mn.Enabled = False
            Else
                mn.Enabled = True
            End If
            If (mn.MenuItems.Count > 0) And (mn.Text = "Reports") Then LoadMenu(mn.MenuItems)
            'If (mn.MenuItems.Count > 0) And (sec = 1) Then LoadMenu(mn.MenuItems)
        Next
    End Sub
    Private Sub LoadMenu2()
        MenuDisable(Menu.MenuItems)
        Dim cmd As New SqlClient.SqlCommand("select * from usr_mnu where usr_mnu_usr_serial=" + UserGroup)
        Dim dr As SqlClient.SqlDataReader

        MenuSec(Menu.MenuItems, "Menu")

        'cnn.Open()
        'dr = cmd.ExecuteReader
        'Do While dr.Read
        '    Menu.MenuItems.Item()
        'Loop
    End Sub
    Private Sub MenuSec(ByVal mns As MenuItem.MenuItemCollection, ByVal path As String)
        Dim mn As MenuItem
        For Each mn In mns
            If CheckMenuSecurity(path + "\" + mn.Text) = 1 Then mn.Visible = True
            If mn.MenuItems.Count > 0 Then MenuSec(mn.MenuItems, path + "\" + mn.Text)
        Next
    End Sub
    Private Sub MenuDisable(ByVal mns As MenuItem.MenuItemCollection)
        Dim mn As MenuItem
        For Each mn In mns
            If mn.Text <> "Window" And mn.Text <> "File" Then
                mn.Visible = False
                If mn.MenuItems.Count > 0 Then MenuDisable(mn.MenuItems)
            End If
        Next
    End Sub
    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles Toolbar1.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Customers"
                    LoadForm("Customers")
                Case "Check Off"
                    Dim fm As fmToDo = LoadForm("Check Off")
                    If Not fm Is Nothing Then fm.LoadGrid()
                Case "To Do List"
                    Dim fm As fmToDoList = LoadForm("To Do List")
                    If Not fm Is Nothing Then fm.LoadList()
                Case "Quotes/Orders"
                    LoadForm("Quotes/Orders")
                Case "Parts"
                    LoadForm("Parts")
                Case "Payments"
                    LoadForm("Payments")
                Case "Billing"
                    LoadForm("Billing")
                Case "Shipments"
                    LoadForm("Shipments")
                Case "Contacts"
                    LoadForm("Contacts")
                Case "Production"
                    LoadForm("Production")
                Case "Add"
                    Dim fm As fmStarter
                    fm = Me.ActiveMdiChild
                    fm.Add()
                    fm = Nothing
                Case "Edit"
                    Dim fm As fmStarter
                    fm = Me.ActiveMdiChild
                    fm.Edit()
                    fm = Nothing
                Case "Save"
                    Dim fm As fmStarter
                    fm = Me.ActiveMdiChild
                    fm.Save()
                    fm = Nothing
                Case "Cancel"
                    Dim fm As fmStarter
                    fm = Me.ActiveMdiChild
                    fm.Cancel()
                    fm = Nothing
                Case "Delete"
                    Dim fm As fmStarter
                    fm = Me.ActiveMdiChild
                    fm.Delete()
                    fm = Nothing
                Case "Done"
                    Dim fm As fmStarter
                    fm = Me.ActiveMdiChild
                    fm.Done()
                    fm = Nothing
                Case "Print"
                    Dim fm As fmStarter
                    fm = Me.ActiveMdiChild
                    fm.Print()
                    fm = Nothing
                Case "PDF"
                    Dim fm As fmStarter
                    fm = Me.ActiveMdiChild
                    fm.Print("PDF")
                    fm = Nothing
                Case "Find"
                    Dim fm As fmStarter
                    fm = Me.ActiveMdiChild
                    fm.Find()
                    fm = Nothing
            End Select
        Catch
            DoError(Err, MainForm)
        End Try
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim fm As New fmSetting
        fm.ID = "Server"
        fm.ShowDialog()
        Jcom.Server = GetSetting("Jcom", "Settings", "Server", "")
        cnnConnect()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim fm As New fmImport
        fm.Show()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim fm As New fmSetting
        fm.ID = "Path"
        fm.Show()
        Jcom.Path = GetSetting("Jcom", "Settings", "Path", "")
    End Sub

    Private Sub fmMain_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
    End Sub

    Private Sub fmMain_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        'On Error Resume Next
        'EditButtons("None")
        'On Error GoTo 0
    End Sub

    Private Sub fmMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
        If Me.ActiveMdiChild Is Nothing Then
            EditButtons("None")
            Exit Sub
        End If
        Dim tp As Type
        tp = Me.ActiveMdiChild.GetType
        Select Case tp.BaseType.Name
            Case "fmStarter"
                Dim fm As fmStarter
                fm = Me.ActiveMdiChild
                If fm.EditMode = "Add" Or fm.EditMode = "Edit" Then
                    EditButtons("Edit")
                    Exit Sub
                End If
                If fm.KeyValue1 <> "" Then
                    EditButtons("Idle")
                    Exit Sub
                End If
                EditButtons("Blank")
            Case Else
                EditButtons("None")
        End Select

    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from zip_file order by zip_code,zip_city"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.FilterField = "zip_code"
        fm.FilterName = "Zip"
        fm.Show()
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Dim fm As New fmSalesCat
        fm.MdiParent = MainForm
        fm.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'LoadAcctClosed()
        Try
            Dim cmd As New SqlClient.SqlCommand("update usr_file set usr_active_time='" + Date.Now + "' where usr_serial=" + CStr(UserSerial))
            Dim cnn9 As New SqlClient.SqlConnection
            cnn9.ConnectionString = cnn.ConnectionString + ";password=39201"

            cmd.Connection = cnn9
            cnn9.Open()
            cmd.ExecuteNonQuery()
            cnn9.Close()
            cnn9 = Nothing
            'TimerCnt = TimerCnt + 1
            'If TimerCnt > 10 Then
            '    If DateDiff(DateInterval.Minute, CDate(CStr(Date.Today) + " 4:00"), Now) < 30 Then
            '        End
            '    End If
            'End If

            If UserType = "I" Or UserType = "C" Then CheckToDo()
            CheckToDoList()

            'Dim pn As New StatusBarPanel
            'pn.AutoSize = StatusBarPanelAutoSize.Spring
            'pn.Text = "North: $12,234"
            'StatusBar1.Panels.Add(pn)
            'StatusBar1.ShowPanels = True

        Catch ex As Exception
        End Try
    End Sub
    Private Sub Blinker()
        If onColor = 0 Then
            onColor = 1
            Toolbar1.Tools(0).SharedProps.AppearancesSmall.Appearance.BackColor = Color.White
        Else
            onColor = 0
            Toolbar1.Tools(0).SharedProps.AppearancesSmall.Appearance.BackColor = Color.Red
        End If

    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        LoadForm("Users")
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim fm As New fmTaxCodes
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Dim fm As New fmAcctClosed
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        DisplayReport("order analysis by product type", , True, 1, , , True)
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        DisplayReport("ship analysis by product type", , True, 1, , , True)
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        DisplayReport("payment receipts", , True, 1, , , True)
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fm As New fmTaskList
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        DisplayReport("forecast", , True, 1, , , False)
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        DisplayReport("forecast this week", , True, , , , False)
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        DisplayReport("ar aging", , True, 1, , , True)
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from itm_prod_type order by itm_prod_type_type"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim fm As New fmSetting
        fm.ID = "ImagePath"
        fm.Show()
        Jcom.ImagePath = GetSetting("Jcom", "Settings", "ImagePath", "")
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        DisplayReport("open orders by product code", , True, 1, , , True)
    End Sub

    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        DisplayReport("sales report by rep", , True, , , , True)
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        DisplayReport("ship analysis by product type", , True, , , , True)
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        DisplayReport("new quotes by order source", "", True, 1, , , True)
    End Sub

    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        DisplayReport("orders by order source", "", True, 1, , , True)

    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        Dim fm As New fmStaged
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        DisplayReport("quote analysis by rep", , True, 1, , , True)
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        DisplayReport("ship analysis by product type, ship date", , True, 1, , , True)

    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        DisplayReport("products ordered by customer", , True, 1, , , True)
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        DisplayReport("Shipments", , True, 1, , , True)
    End Sub

    Private Sub MenuItem290_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem290.Click
        DisplayReport("contactnotesosr3", , True, 1, , , True)
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from rep_file order by rep_name"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.Show()
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        Dim fm As New fmItemPricing
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        DisplayReport("items shipped", , True, 1, , , True)
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from ord_src order by ord_src"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        DisplayReport("total test", , True, 1, , , False)
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        DisplayReport("commissions by product type", , True, 1, , , True)
    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        DisplayReport("commissions by sales category", , True, 1, , , True, , "LoadCurrentSalesCat")
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from sales_com order by sales_com_rep_code"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        Dim fm As New fmAdjustBalance
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from usr_file order by usr_name"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.AllowChanges = False
        fm.ShowDialog()


    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from tax_state order by tax_state"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        Dim fm As New fmTaxImport
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        DisplayReport("ar aging", "{ord_gen.ord_gen_balance} <> $0.00 and {ord_gen.ord_gen_type} = 'O' and {ord_gen.ord_gen_show_date}>=cdate(2005,1,1) and {ord_gen.ord_gen_status} = 'SHIPPED'", True, , , , True)
    End Sub

    Private Sub MenuItem47_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        DisplayReport("tax compare-old", , True, 1, , , True)
    End Sub

    Private Sub MenuItem48_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        DisplayReport("tax summary-old", , True, 1, , , True)
    End Sub

    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from meth_file order by meth_type"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        DisplayReport("test balance", , True, , , , False)
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DisplayReport("open orders by payment group", , True, 1, , , True)
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        DisplayReport("shipments for accounting", , True, 1, , , False)
    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click

    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        DisplayReport("multiple shipped orders", , True, 1, , , False)
    End Sub

    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        DisplayReport("ar aging as of", , True, 1, , , False)
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        DisplayReport("open orders by payment group as of", , True, 1, , , False)

    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click

    End Sub

    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem59.Click
        LoadForm("VendorNet")
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        DisplayReport("payment receipts cash only", , True, 1, , , True)
    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        DisplayReport("osr tracking", , True)
    End Sub



    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from rep_ter order by rep_ter_state,rep_ter_zip"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.Show()
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from sales_cat_prod_mar"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.Show()
    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from sales_cat_itm_price"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.Show()
    End Sub

    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from itm_surcharge"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.Show()

    End Sub

    Private Sub MenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem67.Click
        DisplayReport("customer list", , True)
    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        DisplayReport("shipping costs", , True, 1, , , False)
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click

    End Sub

    Private Sub MenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem69.Click
        DisplayReport("forecasting", , True, 1, , , True)
    End Sub

    Private Sub MenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem70.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from country_file order by country_code"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        DisplayReport("forecasting summary", , True, 1, , , True)

    End Sub

    Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem72.Click
        DisplayReport("forecasting crosstab", , True, 1, , , True, , "LoadCurrentRegion")

    End Sub

    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        DisplayReport("shipments by order source", , True, 1, , , True)
    End Sub
    Private Sub StartQue()
        'Dim msg As New MessageQueue(".\orders")
        'AddHandler msg.ReceiveCompleted, AddressOf ReceiveQue
        'msg.BeginReceive()
    End Sub
    Private Sub ReceiveQue(ByVal sender As Object, ByVal e As ReceiveCompletedEventArgs)
        'Dim mq As MessageQueue = CType(sender, MessageQueue)

        'Dim m As Message = mq.EndReceive(e.AsyncResult)
        'mq.BeginReceive()

        'MsgBox(m.Body)

    End Sub

    Private Sub MenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem74.Click
        DisplayReport("forecasting needed", , True, 1, , , True)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            If GetSetting("Jcom", "Messages", "Jump", "") <> "" Then
                Dim Jump As String = GetSetting("Jcom", "Messages", "Jump", "")
                Timer2.Enabled = False
                AppActivate(Me.Text)
                Select Case Split(UCase(Jump), ";")(0)
                    Case "Q"
                        Dim fm As fmEstOrd2
                        Dim Qt As String = ""
                        fm = LoadForm("Quotes/Orders")
                        If fm.EditMode <> "" Then
                            MsgBox("You must first save or cancel this Quote/Order", MsgBoxStyle.Information, "Save?")
                            fm = Nothing
                            SaveSetting("Jcom", "Messages", "Jump", "")
                            Exit Sub
                        End If
                        Qt = Split(Jump, ";")(1)
                        If Split(Qt, "-").Length > 1 Then
                            fm.KeyValue1 = Split(Qt, "-")(0)
                            fm.tOrd.Text = fm.KeyValue1
                            fm.LoadPage()
                            fm.Tab1.Tabs("Q" + Split(Qt, "-")(1)).Selected = True
                        Else
                            fm.KeyValue1 = Qt
                            fm.tOrd.Text = fm.KeyValue1
                            fm.LoadPage()
                        End If
                        If Split(Jump, ";").Length > 2 Then
                            'MsgBox(Split(Jump, ";")(2))
                            fm.TabItems.Tabs(Split(Jump, ";")(2)).Selected = True
                        End If
                    Case "O"
                        Dim fm As fmEstOrd2
                        Dim Qt As String = ""
                        fm = LoadForm("Quotes/Orders")
                        If fm.EditMode <> "" Then
                            MsgBox("You must first save or cancel this Quote/Order", MsgBoxStyle.Information, "Save?")
                            fm = Nothing
                            SaveSetting("Jcom", "Messages", "Jump", "")
                            Exit Sub
                        End If
                        Qt = Split(Jump, ";")(1)
                        If Split(Qt, "-").Length > 1 Then
                            fm.KeyValue1 = Split(Qt, "-")(0)
                            fm.tOrd.Text = fm.KeyValue1
                            fm.LoadPage()
                            fm.Tab1.Tabs("O" + Split(Qt, "-")(2)).Selected = True
                            If Split(Qt, "-").Length > 2 Then
                                fm.Tab1.Tabs("O" + Split(Qt, "-")(2)).Selected = True
                            End If
                            If Split(Jump, ";").Length > 2 Then
                                'MsgBox(Split(Jump, ";")(2))
                                fm.TabItems.Tabs(Split(Jump, ";")(2)).Selected = True
                            End If
                        Else
                            fm.KeyValue1 = Qt
                            fm.tOrd.Text = fm.KeyValue1
                            fm.LoadPage()
                        End If
                    Case "TODO"
                        Dim fm As fmToDoList = LoadForm("To Do List")
                        fm.LoadList()
                        If Split(UCase(Jump), ";").Length > 1 Then
                            Dim rw As Infragistics.Win.UltraWinGrid.UltraGridRow
                            For Each rw In fm.Grid1.Rows
                                If rw.Cells("to_do_serial").Value = CLng(Split(UCase(Jump), ";")(1)) Then
                                    rw.Appearance.BackColor = Color.Yellow
                                    Exit For
                                End If
                            Next
                        End If
                End Select
            End If
        Catch
        Finally
            SaveSetting("Jcom", "Messages", "Jump", "")
            Timer2.Enabled = True
        End Try
        'If System.IO.File.GetLastWriteTime(Jcom.Path + "winecellar.exe") > System.IO.File.GetLastWriteTime("winecellar.exe") Then
        '    If shtdwn = False Then
        '        If DateDiff(DateInterval.Second, Now, CDate(CStr(Date.Today) + " 2:00")) > 0 And DateDiff(DateInterval.Second, Now, CDate(CStr(Date.Today) + " 2:00")) < 180 Then
        '            shtdwn = True
        '            Shutdown.Show()
        '        End If
        '    End If
        '    If DateDiff(DateInterval.Second, Now, CDate(CStr(Date.Today) + " 2:00")) > 0 And DateDiff(DateInterval.Second, Now, CDate(CStr(Date.Today) + " 2:00")) < 2 And shtdwn = True Then
        '        End
        '    End If
        'End If
    End Sub

    Private Sub MenuItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem75.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from terr_file order by terr_state"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.Show()

    End Sub

    Private Sub MenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DisplayReport("forecasting", "+ AND ({ord_gen.ord_gen_inside}='" + User + "' OR {ord_gen.ord_gen_outside}='" + User + "')", True, 1, , , True)
    End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem78.Click
        DisplayReport("shipments and staged by order source", , True, 1, , , True)

    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        DisplayReport("AR Aging Including Staged After As Of", , True, , , , True)
    End Sub

    Private Sub MenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem80.Click
        DisplayReport("staged order summary", , True)
    End Sub

    Private Sub mFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mFile.Click

    End Sub

    Private Sub MenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem81.Click
        DisplayReport("forecasting lost crosstab", , True, 1, , , True)

    End Sub

    Private Sub MenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem82.Click
        DisplayReport("ship analysis by osr product type", , True, 1, , , True)
    End Sub

    Private Sub MenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem83.Click
        DisplayReport("open orders by product code sales cat", , True, 1, , , True)
    End Sub

    Private Sub MenuItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem84.Click
        DisplayReport("order analysis by product type by date", , True, 1, , , True)
    End Sub

    Private Sub MenuItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem85.Click
        DisplayReport("direct sales customer email list", , True, 1, , , False)
    End Sub

    Private Sub MenuItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem86.Click
        DisplayReport("AR Aging Including Staged After As Of All", , True, 1, , , False)

    End Sub

    Private Sub MenuItem87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem87.Click
        DisplayReport("forecasting detail", , True, 1, , , True)
    End Sub

    Private Sub MenuItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem88.Click
        DisplayReport("adjustments", , True, 1, , , False)
    End Sub

    Private Sub MenuItem52_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        DisplayReport("Ship Analysis by OSR, Territory", , True, 1, , , True)
    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        DisplayReport("open orders by territory with payments", , True, 1, , , True)
    End Sub

    Private Sub MenuItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem90.Click
        DisplayReport("Customer Ship to List by Order Number", , True)
    End Sub

    Private Sub MenuItem91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem91.Click
        DisplayReport("Ship Analysis by OSR Product Code", , True, 1, , , True)
    End Sub

    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        DisplayReport("Shipped Orders by State", , True, 1, , , True)
    End Sub

    Private Sub MenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem93.Click
        DisplayReport("quote analysis by designer", , True, 1, , , True)
    End Sub

    Private Sub MenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem94.Click
        DisplayReport("customer forum", , True, 1, , , True)
    End Sub

    Private Sub MenuItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem95.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from mat_file order by mat_code"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem96.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from ship_via order by ship_via_code"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem97.Click
        DisplayReport("osr tracking crosstab", , True, 1, , , True, , "LoadCurrentOSR")
    End Sub

    Private Sub MenuItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem98.Click
        DisplayReport("ship analysis tax and shipping charged", , True, , , , True)
    End Sub

    Private Sub MenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem99_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem99.Click
        DisplayReport("open orders as of", , True, , , , False)
    End Sub

    Private Sub MenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem100.Click
        Dim fm As New fmImportItems
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem101.Click
        Dim fm As New fmDesignerCheckoff
        'Try
        '    Dim tt = fmEstOrd2.Tab1.ActiveTab.Text
        '    tt = Trim(Replace(tt, "Quote", ""))
        '    fm.tQuote.Text = fmEstOrd2.tOrd.Text + "-" + tt
        '    fm.ComboBox1.Text = fmEstOrd2.Label8.Text
        'Catch
        'End Try
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem102.Click
        DisplayReport("ar accounts receivable", , True, 1, , , False)
    End Sub

    Private Sub MenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem103.Click
        DisplayReport("Open Orders by Payment Group Per Month As Of", , True, 1, , , False)
    End Sub

    Private Sub MenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem104.Click
        DisplayReport("Open Orders by Payment Group for all As Of", , True, 1, , , False)

    End Sub

    Private Sub MenuItem105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem105.Click
        DisplayReport("accounting sales & receipts", , True, 1, , , False)
    End Sub

    Private Sub MenuItem106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem106.Click
        DisplayReport("accounting sales detail", , True, 1, , , True)
    End Sub

    Private Sub MenuItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem107.Click
        DisplayReport("accounting sales tax and ship", , True, 1, , , True)
    End Sub

    Private Sub MenuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem108.Click
        DisplayReport("accounting customer deposits received", , True, 1, , , True)
    End Sub

    Private Sub MenuItem109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem109.Click
        DisplayReport("accounting receipts detail", , True, 1, , , True)
    End Sub

    Private Sub MenuItem110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem110.Click
        DisplayReport("accounting customer deposits movement", , True, 1, , , True)
    End Sub

    Private Sub MenuItem111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem111.Click
        DisplayReport("accounting customer deposits balance", , True, 1, , , True)
    End Sub

    Private Sub MenuItem112_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem112.Click
        DisplayReport("quote win ratio", , True, 1, "'TOP','BUD','GOLD'", , True)
    End Sub

    Private Sub MenuItem113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem113.Click
        DisplayReport("quote win ratio", , True, 1, "'FIX'", , True)
    End Sub

    Private Sub MenuItem114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem114.Click
        Dim fm As New fmShipSelect
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem115.Click
        DisplayReport("payment receipts by osr", , True, 1, , , True)

    End Sub

    Private Sub MenuItem116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem116.Click
        DisplayReport("open orders by product code for cellar art", , True, 1, , , False)
    End Sub

    Private Sub MenuItem117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem117.Click
        DisplayReport("Quote Rev by Territory", , True, 1, , , True)
    End Sub

    Private Sub MenuItem118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem118.Click
        Dim fm As New fmAcctOpen
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem119.Click
        DisplayReport("design checker", , True, 1, , , True)
    End Sub

    Private Sub MenuItem120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem120.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from mat_color order by mat_color_mat_code,mat_color"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem121.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from mat_color_act order by mat_color_act_mat_code,mat_color_act_color,mat_color_act_start"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click

    End Sub

    Private Sub MenuItem122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem122.Click
        DisplayReport("Fountains - Splits - Whisp - Breez.rpt", , True, 1, , , True)
    End Sub

    Private Sub MenuItem123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem123.Click
        DisplayReport("humidor totals", , True, 1, , , False)
    End Sub

    Private Sub MenuItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem124.Click
        DisplayReport("quotes by division for custom", , True, 1, , , False)
    End Sub

    Private Sub MenuItem125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem125.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from zip_zone order by zip_zone_start"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.Show()
    End Sub

    Private Sub MenuItem126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem126.Click
        Dim cmd As New SqlClient.SqlCommand("", cnn)
        If Me.MdiChildren.Length > 0 Then
            cmd.CommandText = "update usr_file set usr_def_form='" + nz(MainForm.ActiveMdiChild.Tag) + "' where usr_name='" + User + "'"
        Else
            cmd.CommandText = "update usr_file set usr_def_form='' where usr_name='" + User + "'"
        End If
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub

    Private Sub MenuItem128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem128.Click
        DisplayReport("Ship Analysis by OSR Product Code Crosstab", , True, 1, , , True)

    End Sub

    Private Sub MenuItem129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem129.Click
        DisplayReport("Ship Analysis Art to Custom", , True, 1, , , False)
    End Sub

    Private Sub MenuItem130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem130.Click
        Dim fd As New OpenFileDialog
        If fd.ShowDialog = DialogResult.OK Then
            Select Case LCase(Microsoft.VisualBasic.Right(System.IO.Path.GetFileName(fd.FileName), 3))
                Case "xml"
                    Me.StatusBar1.Text = "Uploading FEDEX Billing File... Please wait"
                    Me.StatusBar1.BackColor = Color.Yellow
                    Dim FDX As New DoFedEx
                    FDX.LoadFromFile(fd.FileName)
                    Me.StatusBar1.Text = ""
                    Me.StatusBar1.BackColor = Color.Empty
                    MsgBox("FedEx Billing File Load Complete", MsgBoxStyle.Information, "Complete")
                Case Else
                    MsgBox("File Type Not Found", MsgBoxStyle.Information, "Not Found")
            End Select
        End If
    End Sub

    Private Sub MenuItem131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem131.Click
        DisplayReport("shipped staged price analysis by product type", , True, 1, , , True)
    End Sub

    Private Sub MenuItem132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem132.Click
        DisplayReport("tax compare", , True, 1, , , True)
    End Sub

    Private Sub MenuItem133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem133.Click
        DisplayReport("tax summary", , True, 1, , , True)
    End Sub

    Private Sub MenuItem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem134.Click
        DisplayReport("Margins", , True, 1, , , True, , "LoadCurrentOSR")
    End Sub

    Private Sub MenuItem76_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem76.Click
        DisplayReport("Margins by prod type", , True, 1, , , True)
    End Sub

    Private Sub MenuItem77_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem77.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from ship_bill_cat order by ship_bill_cat_code"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem135_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem135.Click
        DisplayReport("Shipped SPLs by Ship Date", , True, 1, , , False)
    End Sub


    Private Sub StatusBar1_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles StatusBar1.PanelClick

    End Sub

    Private Sub MenuItem138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem138.Click
        Dim fm As New fmShipBillReprint
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem139.Click
        DisplayReport("Margins by territory", , True, 1, , , True, , "LoadCurrentOSR")
    End Sub

    Private Sub MenuItem140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem140.Click
        DisplayReport("Margins by osr", , True, 1, , , True)
    End Sub

    Private Sub MenuItem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem141.Click
        DisplayReport("margins for stain", , True, , , , , , "LoadUnstained")
    End Sub

    Private Sub MenuItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem142.Click
        DisplayReport("Margins per sale", , True, 1, , , True, , "LoadCurrentOSR")
    End Sub

    Private Sub MenuItem143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem143.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from des_type order by des_type"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem144.Click
        DisplayReport("products ordered by customer by shipped-staged date", , True, 1, , , True)
    End Sub

    Private Sub MenuItem145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem145.Click
        DisplayReport("quote count by designer", , True)
    End Sub

    Private Sub MenuItem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem146.Click
        DisplayReport("average item sold dollar", , True, 1, , , True, , "LoadCurrentBase")
    End Sub

    Private Sub MenuItem147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem147.Click
        DisplayReport("Margins by territory (no speed codes)", , True, 1, , , True, , "LoadCurrentOSR")
    End Sub

    Private Sub MenuItem148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem148.Click
        DisplayReport("Margins by osr (no speed codes)", , True, 1, , , True)
    End Sub

    Private Sub MenuItem150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem150.Click
        DisplayReport("Customer Forum - Custom", , True)
    End Sub

    Private Sub MenuItem149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem149.Click
        DisplayReport("replacements", , True)
    End Sub

    Private Sub MenuItem152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem152.Click
        Dim data As String = "0," + QT + "007" + QT + "498," + QT + "2498" + QT + "3025," + QT + QT + "99," + QT + QT
        Dim rt As String = ShipFedEx(data)
        Dim fe As New FedExData(rt)

        If fe.GetData("3") <> "" Then
            MsgBox(fe.GetData("3"))
        Else
            MsgBox("End of Day Successful")
        End If

    End Sub

    Private Sub MenuItem155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem155.Click
        DisplayReport("designer productivity by design type", , True)

    End Sub

    Private Sub MenuItem154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem154.Click
        DisplayReport("order analysis art to custom", , True)
    End Sub

    Private Sub MenuItem156_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem156.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from ref_file order by ref_name"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem157.Click
        DisplayReport("referrals to be paid", , True)
    End Sub

    Private Sub MenuItem158_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem158.Click
        DisplayReport("referrals paid", , True)
    End Sub

    Private Sub MenuItem159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem159.Click
        DisplayReport("tax credits", , True)
    End Sub

    Private Sub MenuItem160_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem160.Click
        Dim fm As New fmReferralPayment
        fm.Height = MainForm.Height * 0.8
        fm.Width = MainForm.Width * 0.8
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem161_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem161.Click
        DisplayReport("design type win ratio", , True)
    End Sub

    Private Sub MenuItem162_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem162.Click
        Dim ds As New DataSet
        Dim cmd As New SqlClient.SqlCommand("", cnn)
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim fm As New fmDateSelect
        Dim row As DataRow
        Dim dr As SqlClient.SqlDataReader
        Dim fmStat As New fmStatusBar

        fm.ShowDialog()
        If IsDate(fm.StartDate) And IsDate(fm.EndDate) Then
            cmd.CommandTimeout = 900
            fmStat.Show()
            cnn.Open()
            Dim dt1 As DateTime = Convert.ToDateTime(fm.StartDate.ToString)
            Dim dt2 As DateTime = Convert.ToDateTime(fm.EndDate.ToString).AddHours(23).AddMinutes(59).AddSeconds(59)
            fmStat.Label1.Text = "Clearing data..."
            Application.DoEvents()
            cmd.CommandText = "delete from tmp_top5 where user_name='" + User + "'"
            cmd.ExecuteNonQuery()

            'fmStat.Label1.Text = "Loading Responsible Reps..."
            'Application.DoEvents()
            'cmd.CommandText = "select rep_code,rep_name from rep_file where rep_type='O'"
            'ds.Clear()
            'da.Fill(ds)
            'For Each row In ds.Tables(0).Rows
            '    cmd.CommandText = "insert into tmp_top5 (user_name,osr,osr_name,resp_rep,resp_rep_name,startdate,enddate) values ('" + User + "','" + row("rep_code") + "','" + row("rep_name") + "','" + CStr(fm.StartDate) + "','" + CStr(fm.EndDate) + "')"
            '    cmd.ExecuteNonQuery()
            'Next
            Dim replist As String = "|"
            fmStat.Label1.Text = "Getting total and base data..."
            Application.DoEvents()
            cmd.CommandText = "select CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END AS repid,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt,sum(ord_itm_base_price * ord_itm_qty) as base from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (ord_gen_create_date) >='" + CStr(dt1) + "' and (ord_gen_create_date)<='" + CStr(dt2) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') group by CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END"
            ds.Clear()
            da.Fill(ds)
            For Each row In ds.Tables(0).Rows
                cmd.CommandText = "insert into tmp_top5 (user_name,resp_rep,startdate,enddate) values ('" + User + "','" + row("repid") + "','" + CStr(dt1) + "','" + CStr(dt2) + "')"
                cmd.ExecuteNonQuery()
                replist += row("repid") + "|"
                cmd.CommandText = "update tmp_top5 set sales=" + CStr(row("amt")) + ",base=" + CStr(row("base")) + " where resp_rep='" + nz(row("repid")) + "'"
                cmd.ExecuteNonQuery()
            Next
            fmStat.Bar1.Value = 12

            fmStat.Label1.Text = "Getting humidification totals..."
            Application.DoEvents()
            cmd.CommandText = "select CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END AS repid,sum(ord_itm_qty) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (ord_gen_create_date) >='" + CStr(dt1) + "' and (ord_gen_create_date)<='" + CStr(dt2) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_item_code like 'FNT%' or ord_itm_item_code in ('HUMSTAT','MISTFOG')) group by CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END"
            ds.Clear()
            da.Fill(ds)
            For Each row In ds.Tables(0).Rows
                If InStr(replist, "|" + nz(row("repid")) + "|") = 0 Then
                    cmd.CommandText = "insert into tmp_top5 (user_name,resp_rep,startdate,enddate) values ('" + User + "','" + row("repid") + "','" + CStr(dt1) + "','" + CStr(dt2) + "')"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "update tmp_top5 set humid=" + CStr(row("amt")) + " where resp_rep='" + nz(row("repid")) + "' and user_name='" + User + "'"
                cmd.ExecuteNonQuery()
            Next
            fmStat.Bar1.Value = 25

            fmStat.Label1.Text = "Getting refrigeration totals..."
            Application.DoEvents()
            cmd.CommandText = "select CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END AS repid,sum(ord_itm_qty) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (ord_gen_create_date) >='" + CStr(dt1) + "' and (ord_gen_create_date)<='" + CStr(dt2) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type in ('SPL','BREEZ','WHISP')) group by CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END"
            ds.Clear()
            da.Fill(ds)
            For Each row In ds.Tables(0).Rows
                If InStr(replist, "|" + nz(row("repid")) + "|") = 0 Then
                    cmd.CommandText = "insert into tmp_top5 (user_name,resp_rep,startdate,enddate) values ('" + User + "','" + row("repid") + "','" + CStr(dt1) + "','" + CStr(dt2) + "')"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "update tmp_top5 set refrig=" + CStr(row("amt")) + " where resp_rep='" + nz(row("repid")) + "' and user_name='" + User + "'"
                cmd.ExecuteNonQuery()
            Next
            fmStat.Bar1.Value = 37

            fmStat.Label1.Text = "Getting wine zone totals..."
            Application.DoEvents()
            cmd.CommandText = "select CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END AS repid,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (ord_gen_create_date) >='" + CStr(dt1) + "' and (ord_gen_create_date)<='" + CStr(dt2) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type in ('SPL')) group by CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END"
            ds.Clear()
            da.Fill(ds)
            For Each row In ds.Tables(0).Rows
                If InStr(replist, "|" + nz(row("repid")) + "|") = 0 Then
                    cmd.CommandText = "insert into tmp_top5 (user_name,resp_rep,startdate,enddate) values ('" + User + "','" + row("repid") + "','" + CStr(dt1) + "','" + CStr(dt2) + "')"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "update tmp_top5 set winezone=" + CStr(row("amt")) + " where resp_rep='" + nz(row("repid")) + "' and user_name='" + User + "'"
                cmd.ExecuteNonQuery()
            Next
            fmStat.Bar1.Value = 50

            fmStat.Label1.Text = "Getting kit/custom totals..."
            Application.DoEvents()

            'cmd.CommandText = "select CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END AS repid,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt,sum(ord_itm_base_price * ord_itm_qty) as base from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (ord_gen_create_date) >='" + CStr(fm.StartDate) + "' and (ord_gen_create_date)<='" + CStr(dt2) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type in ('BUD','TOP','GOLD','DESKIT','KIT','STAIN')) group by CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END"
            cmd.CommandText = "SELECT CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END AS repid, " + _
                         "SUM(dbo.ord_itm.ord_itm_qty * dbo.ord_itm.ord_itm_unt_sell + dbo.ord_itm.ord_itm_disc + dbo.ord_itm.ord_itm_disc_amt) AS amt,  " + _
                         "SUM(dbo.ord_itm.ord_itm_base_price * dbo.ord_itm.ord_itm_qty) AS base " + _
                         "FROM  dbo.ord_itm INNER JOIN " + _
                         "dbo.ord_gen ON dbo.ord_itm.ord_itm_ord_serial = dbo.ord_gen.ord_gen_ord_serial AND dbo.ord_itm.ord_itm_rev = dbo.ord_gen.ord_gen_rev AND  " + _
                         "dbo.ord_itm.ord_itm_type = dbo.ord_gen.ord_gen_type INNER JOIN " + _
                         "dbo.ord_file ON dbo.ord_gen.ord_gen_ord_serial = dbo.ord_file.ord_serial " + _
                         "WHERE (dbo.ord_gen.ord_gen_create_date >= '" + CStr(dt1) + "') AND (dbo.ord_gen.ord_gen_create_date <='" + CStr(dt2) + "') AND (dbo.ord_gen.ord_gen_type = 'O') AND  " + _
                         "(dbo.ord_itm.ord_itm_is_disc = 0) AND (dbo.ord_itm.ord_itm_is_up = 0) AND (ISNULL(dbo.ord_file.ord_sold_cust_id, '') = '') AND  " + _
                         "(dbo.ord_itm.ord_itm_prod_type <> 'IN') AND (dbo.ord_gen.ord_gen_status <> 'CANCELED') AND (dbo.ord_itm.ord_itm_prod_type IN ('BUD', 'TOP', 'GOLD', 'DESKIT','KIT', 'STAIN')) " + _
                         "GROUP BY CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END"
            ds.Clear()
            da.Fill(ds)
            For Each row In ds.Tables(0).Rows
                If InStr(replist, "|" + nz(row("repid")) + "|") = 0 Then
                    cmd.CommandText = "insert into tmp_top5 (user_name,resp_rep,startdate,enddate) values ('" + User + "','" + row("repid") + "','" + CStr(dt1) + "','" + CStr(dt2) + "')"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "update tmp_top5 set KitsCustom=" + CStr(row("amt")) + ",KitsCustomBase=" + CStr(row("base")) + " where resp_rep='" + nz(row("repid")) + "' and user_name='" + User + "'"
                cmd.ExecuteNonQuery()
            Next
            fmStat.Bar1.Value = 59


            fmStat.Label1.Text = "Getting custom totals..."
            Application.DoEvents()
            cmd.CommandText = "select CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END AS repid,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (ord_gen_create_date) >='" + CStr(dt1) + "' and (ord_gen_create_date)<='" + CStr(dt2) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type in ('BUD','TOP','GOLD')) group by CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END"
            ds.Clear()
            da.Fill(ds)
            For Each row In ds.Tables(0).Rows
                If InStr(replist, "|" + nz(row("repid")) + "|") = 0 Then
                    cmd.CommandText = "insert into tmp_top5 (user_name,resp_rep,startdate,enddate) values ('" + User + "','" + row("repid") + "','" + CStr(dt1) + "','" + CStr(dt2) + "')"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "update tmp_top5 set custom=" + CStr(row("amt")) + " where resp_rep='" + nz(row("repid")) + "' and user_name='" + User + "'"
                cmd.ExecuteNonQuery()
            Next
            fmStat.Bar1.Value = 67

            fmStat.Label1.Text = "Getting cellar art totals..."
            Application.DoEvents()
            cmd.CommandText = "select CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END AS repid,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (ord_gen_create_date) >='" + CStr(dt1) + "' and (ord_gen_create_date)<='" + CStr(dt2) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type = 'ARCH') group by CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END"
            ds.Clear()
            da.Fill(ds)
            For Each row In ds.Tables(0).Rows
                If InStr(replist, "|" + nz(row("repid")) + "|") = 0 Then
                    cmd.CommandText = "insert into tmp_top5 (user_name,resp_rep,startdate,enddate) values ('" + User + "','" + row("repid") + "','" + CStr(dt1) + "','" + CStr(dt2) + "')"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "update tmp_top5 set cellarart=" + CStr(row("amt")) + " where resp_rep='" + nz(row("repid")) + "' and user_name='" + User + "'"
                cmd.ExecuteNonQuery()
            Next
            fmStat.Bar1.Value = 75

            fmStat.Label1.Text = "Getting installation totals..."
            Application.DoEvents()
            cmd.CommandText = "select CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END AS repid,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (ord_gen_create_date) >='" + CStr(dt1) + "' and (ord_gen_create_date)<='" + CStr(dt2) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type in ('IN')) group by CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END"
            ds.Clear()
            da.Fill(ds)
            For Each row In ds.Tables(0).Rows
                If InStr(replist, "|" + nz(row("repid")) + "|") = 0 Then
                    cmd.CommandText = "insert into tmp_top5 (user_name,resp_rep,startdate,enddate) values ('" + User + "','" + row("repid") + "','" + CStr(dt1) + "','" + CStr(dt2) + "')"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "update tmp_top5 set install=" + CStr(row("amt")) + " where resp_rep='" + nz(row("repid")) + "' and user_name='" + User + "'"
                cmd.ExecuteNonQuery()
            Next
            fmStat.Bar1.Value = 87

            fmStat.Label1.Text = "Getting stain totals..."
            Application.DoEvents()
            cmd.CommandText = "select CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END AS repid,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (ord_gen_create_date) >='" + CStr(dt1) + "' and (ord_gen_create_date)<='" + CStr(dt2) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type in ('STAIN')) group by CASE ord_gen_resp_rep WHEN 'I' THEN ord_gen_inside WHEN 'O' THEN ord_gen_outside WHEN 'F' THEN ord_gen_floating END"
            ds.Clear()
            da.Fill(ds)
            For Each row In ds.Tables(0).Rows
                If InStr(replist, "|" + nz(row("repid")) + "|") = 0 Then
                    cmd.CommandText = "insert into tmp_top5 (user_name,resp_rep,startdate,enddate) values ('" + User + "','" + row("repid") + "','" + CStr(dt1) + "','" + CStr(dt2) + "')"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "update tmp_top5 set stain=" + CStr(row("amt")) + " where resp_rep='" + nz(row("repid")) + "' and user_name='" + User + "'"
                cmd.ExecuteNonQuery()
            Next
            fmStat.Bar1.Value = 100

            cmd.CommandText = "select * from tmp_top5 where user_name='" + User + "'"
            Dim dt As New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                cmd.CommandText = "select rep_name from rep_file where rep_code='" + CStr(row("resp_rep")) + "'"
                Dim cn = cmd.ExecuteScalar
                cmd.CommandText = "update tmp_top5 set resp_rep_name='" + cn + "' where resp_rep='" + nz(row("resp_rep")) + "'"
                cmd.ExecuteNonQuery()
            Next
            cnn.Close()
            fmStat.Close()
            DisplayReport("sales margins top 5", , True, 1, User)
        End If

        'If IsDate(fm.StartDate) And IsDate(fm.EndDate) Then
        '    cmd.CommandTimeout = 900
        '    fmStat.Show()
        '    cnn.Open()

        '    fmStat.Label1.Text = "Clearing data..."
        '    Application.DoEvents()
        '    cmd.CommandText = "delete from tmp_top5 where user_name='" + User + "'"
        '    cmd.ExecuteNonQuery()

        '    fmStat.Label1.Text = "Loading Responsible Reps..."
        '    Application.DoEvents()
        '    cmd.CommandText = "select rep_code,rep_name from rep_file where rep_type='O'"
        '    ds.Clear()
        '    da.Fill(ds)
        '    For Each row In ds.Tables(0).Rows
        '        cmd.CommandText = "insert into tmp_top5 (user_name,osr,osr_name,resp_rep,resp_rep_name,startdate,enddate) values ('" + User + "','" + row("rep_code") + "','" + row("rep_name") + "','" + CStr(fm.StartDate) + "','" + CStr(fm.EndDate) + "')"
        '        cmd.ExecuteNonQuery()
        '    Next

        '    fmStat.Label1.Text = "Getting total and base data..."
        '    Application.DoEvents()
        '    cmd.CommandText = "select ord_gen_outside,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt,sum(ord_itm_base_price * ord_itm_qty) as base from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end) >='" + CStr(fm.StartDate) + "' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(fm.EndDate) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') group by ord_gen_outside"
        '    ds.Clear()
        '    da.Fill(ds)
        '    For Each row In ds.Tables(0).Rows
        '        cmd.CommandText = "update tmp_top5 set sales=" + CStr(row("amt")) + ",base=" + CStr(row("base")) + " where osr='" + nz(row("ord_gen_outside")) + "'"
        '        cmd.ExecuteNonQuery()
        '    Next
        '    fmStat.Bar1.Value = 12

        '    fmStat.Label1.Text = "Getting humidification totals..."
        '    Application.DoEvents()
        '    cmd.CommandText = "select ord_gen_outside,sum(ord_itm_qty) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end) >='" + CStr(fm.StartDate) + "' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(fm.EndDate) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_item_code like 'FNT%' or ord_itm_item_code in ('HUMSTAT','MISTFOG')) group by ord_gen_outside"
        '    ds.Clear()
        '    da.Fill(ds)
        '    For Each row In ds.Tables(0).Rows
        '        cmd.CommandText = "update tmp_top5 set humid=" + CStr(row("amt")) + " where osr='" + nz(row("ord_gen_outside")) + "'"
        '        cmd.ExecuteNonQuery()
        '    Next
        '    fmStat.Bar1.Value = 25

        '    fmStat.Label1.Text = "Getting refrigeration totals..."
        '    Application.DoEvents()
        '    cmd.CommandText = "select ord_gen_outside,sum(ord_itm_qty) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end) >='" + CStr(fm.StartDate) + "' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(fm.EndDate) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type in ('SPL','BREEZ','WHISP')) group by ord_gen_outside"
        '    ds.Clear()
        '    da.Fill(ds)
        '    For Each row In ds.Tables(0).Rows
        '        cmd.CommandText = "update tmp_top5 set refrig=" + CStr(row("amt")) + " where osr='" + nz(row("ord_gen_outside")) + "'"
        '        cmd.ExecuteNonQuery()
        '    Next
        '    fmStat.Bar1.Value = 37

        '    fmStat.Label1.Text = "Getting wine zone totals..."
        '    Application.DoEvents()
        '    cmd.CommandText = "select ord_gen_outside,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end) >='" + CStr(fm.StartDate) + "' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(fm.EndDate) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type in ('SPL')) group by ord_gen_outside"
        '    ds.Clear()
        '    da.Fill(ds)
        '    For Each row In ds.Tables(0).Rows
        '        cmd.CommandText = "update tmp_top5 set winezone=" + CStr(row("amt")) + " where osr='" + nz(row("ord_gen_outside")) + "'"
        '        cmd.ExecuteNonQuery()
        '    Next
        '    fmStat.Bar1.Value = 50

        '    fmStat.Label1.Text = "Getting custom totals..."
        '    Application.DoEvents()
        '    cmd.CommandText = "select ord_gen_outside,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end) >='" + CStr(fm.StartDate) + "' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(fm.EndDate) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type in ('BUD','TOP','GOLD')) group by ord_gen_outside"
        '    ds.Clear()
        '    da.Fill(ds)
        '    For Each row In ds.Tables(0).Rows
        '        cmd.CommandText = "update tmp_top5 set custom=" + CStr(row("amt")) + " where osr='" + nz(row("ord_gen_outside")) + "'"
        '        cmd.ExecuteNonQuery()
        '    Next
        '    fmStat.Bar1.Value = 67

        '    fmStat.Label1.Text = "Getting cellar art totals..."
        '    Application.DoEvents()
        '    cmd.CommandText = "select ord_gen_outside,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end) >='" + CStr(fm.StartDate) + "' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(fm.EndDate) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type = 'ARCH') group by ord_gen_outside"
        '    ds.Clear()
        '    da.Fill(ds)
        '    For Each row In ds.Tables(0).Rows
        '        cmd.CommandText = "update tmp_top5 set cellarart=" + CStr(row("amt")) + " where osr='" + nz(row("ord_gen_outside")) + "'"
        '        cmd.ExecuteNonQuery()
        '    Next
        '    fmStat.Bar1.Value = 75

        '    fmStat.Label1.Text = "Getting installation totals..."
        '    Application.DoEvents()
        '    cmd.CommandText = "select ord_gen_outside,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end) >='" + CStr(fm.StartDate) + "' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(fm.EndDate) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type in ('IN')) group by ord_gen_outside"
        '    ds.Clear()
        '    da.Fill(ds)
        '    For Each row In ds.Tables(0).Rows
        '        cmd.CommandText = "update tmp_top5 set install=" + CStr(row("amt")) + " where osr='" + nz(row("ord_gen_outside")) + "'"
        '        cmd.ExecuteNonQuery()
        '    Next
        '    fmStat.Bar1.Value = 87

        '    fmStat.Label1.Text = "Getting stain totals..."
        '    Application.DoEvents()
        '    cmd.CommandText = "select ord_gen_outside,sum((ord_itm_qty*ord_itm_unt_sell)+ord_itm_disc+ord_itm_disc_amt) as amt from ord_itm,ord_gen,ord_file where ord_itm_ord_serial=ord_gen_ord_serial and ord_itm_rev=ord_gen_rev and ord_itm_type=ord_gen_type and ord_gen_ord_serial=ord_serial and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end) >='" + CStr(fm.StartDate) + "' and (case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end)<='" + CStr(fm.EndDate) + "' and ord_gen_type='O' and ord_itm_is_disc=0 and ord_itm_is_up=0 and isnull(ord_sold_cust_id,'')='' and ord_itm_prod_type<>'IN' and (ord_gen_status='SHIPPED' or ord_gen_status='STAGED') and (ord_itm_prod_type in ('STAIN')) group by ord_gen_outside"
        '    ds.Clear()
        '    da.Fill(ds)
        '    For Each row In ds.Tables(0).Rows
        '        cmd.CommandText = "update tmp_top5 set stain=" + CStr(row("amt")) + " where osr='" + nz(row("ord_gen_outside")) + "'"
        '        cmd.ExecuteNonQuery()
        '    Next
        '    fmStat.Bar1.Value = 100

        '    cnn.Close()
        '    fmStat.Close()
        '    DisplayReport("sales margins top 5", , True, 1, User)
        'End If

    End Sub




    Private Sub MenuItem163_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem163.Click
        DisplayReport("quotes by division", , True, 1, , , False)
    End Sub

    Private Sub MenuItem137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem137.Click
        Dim fm As New fmErrors
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem153.Click
        DisplayReport("Accounting Shipping by OSR", , True)
    End Sub

    Private Sub MenuItem164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem164.Click
        Dim cmd As New SqlClient.SqlCommand("select rep_comm_level from rep_file where rep_code='" + User + "'", cnn)
        Dim Params As New Collection
        Dim pr As New Param

        pr.Name = "UserLevel"
        cnn.Open()
        pr.Value = nz(cmd.ExecuteScalar, "")
        cnn.Close()
        Params.Add(pr)

        pr = New Param
        pr.Name = "User"
        pr.Value = User
        Params.Add(pr)

        DisplayReport("commissions", , True, , , , True, , "LoadCurrentSalesCommission", Params)
    End Sub

    Private Sub MenuItem165_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem165.Click
        DisplayReport("tax exemptions", , True)
    End Sub

    Private Sub MenuItem166_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem166.Click
        Dim fm As New fmOrdApproveDiscount
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem167.Click
        DisplayReport("order analysis canceled by product code", , True)
    End Sub

    Private Sub MenuItem168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem168.Click
        DisplayReport("order analysis credits", , True)
    End Sub

    Private Sub MenuItem169_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem169.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from itm_stain"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem171_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem171.Click
        Dim fm As New fmShipPrinterFedex
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem172_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem172.Click
        DisplayReport("orders by division", , True)
    End Sub

    Private Sub MenuItem173_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem173.Click
        DisplayReport("orders with quotes forecasted", , True)
    End Sub

    Private Sub MenuItem175_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem175.Click
        Dim fm As New fmShipPick
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem176_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem176.Click
        DisplayReport("order analysis tax exempt", , True)
    End Sub

    Private Sub MenuItem177_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem177.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from rep_comm order by rep_comm_rep_code"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.Show()
    End Sub

    Private Sub MenuItem178_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem178.Click
        DisplayReport("order analysis test margins for zero base price", , True)
    End Sub

    Private Sub MenuItem179_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem179.Click
        Dim fm As New fmOrdCommOverride
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem180.Click
        Dim fm As New fmUpdateISR
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem181_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem181.Click
        Dim fm As New fmCloseMonth
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem182_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem182.Click
        DisplayReport("referral payment detail", , True)
    End Sub

    Private Sub MenuItem183_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem183.Click
        DisplayReport("payment credit detail", , True)
    End Sub

    Private Sub MenuItem184_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem184.Click
        DisplayReport("margins by territory some product codes", , True)
    End Sub

    Private Sub MenuItem185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem185.Click
        DisplayReport("forecasting crosstab for we", , True)
    End Sub

    Private Sub MenuItem187_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem187.Click
        Dim fm As New fmResetOrder
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem188_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem188.Click
        DisplayReport("test accounting", , True)
    End Sub

    Private Sub MenuItem189_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem189.Click
        DisplayReport("shipments and staged by order source by state", , True, 1, , , True)
    End Sub

    Private Sub MenuItem190_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem190.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from itm_ship_code order by itm_ship_code"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem191_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem191.Click
        DisplayReport("items shipped (certain item codes)", , True)
    End Sub

    Private Sub MenuItem192_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem192.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from mat_fac order by mat_fac_mat_code,mat_fac_start"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem193_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem193.Click
        Dim fm As New fmCommission2
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem194_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem194.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from tax_cert order by tax_cert_cust_id,tax_cert_no"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.FilterField = "tax_cert_cust_id"
        fm.FilterName = "Cust Id"
        fm.Show()

    End Sub

    Private Sub MenuItem174_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem174.Click
        DisplayReport("quotes by material", "", True, 1, , , True, , "LoadLatestRev")
    End Sub

    Private Sub MenuItem195_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem195.Click
        DisplayReport("Quote revs win ratio", , True, , , , True)
    End Sub

    Private Sub MenuItem196_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem196.Click
        Dim fm As New fmUpdateRep
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem197_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem197.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from stain_file order by stain_name"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.Show()

    End Sub

    Private Sub MenuItem198_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem198.Click
        DisplayReport("open order summary", , True)
    End Sub

    Private Sub MenuItem199_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem199.Click
        DisplayReport("Ship Analysis by Product Type, Boxes", , True)
    End Sub

    Private Sub MenuItem200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem200.Click
        DisplayReport("quote detail per customer", , True)
    End Sub

    Private Sub MenuItem201_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem201.Click
        DisplayReport("Shipments by zone", , True)
    End Sub

    Private Sub MenuItem202_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem202.Click
        Dim Params As New Collection
        Dim pr As New Param

        pr.Name = "Report Type"
        pr.Value = "PCA"
        Params.Add(pr)

        pr = New Param
        pr.Name = "ForWho"
        If UCase(User) = "JON" Or UCase(User) = "TONY" Or UCase(User) = "TODDW" Then
            pr.Value = "All"
        Else
            pr.Value = User
        End If
        Params.Add(pr)

        DisplayReport("commissions for groups sales cat", , True, , , , False, , "LoadCurrentSalesCat", Params)
    End Sub

    Private Sub MenuItem203_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem203.Click
        Dim Params As New Collection
        Dim pr As New Param

        pr.Name = "Report Type"
        pr.Value = "Weekly Sales by Category"
        Params.Add(pr)

        pr = New Param
        pr.Name = "ForWho"
        pr.Value = "All"
        Params.Add(pr)

        DisplayReport("commissions for groups sales cat", , True, , , , False, , "LoadCurrentSalesCat", Params)
    End Sub

    Private Sub MenuItem204_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem204.Click
        Dim Params As New Collection
        Dim pr As New Param

        pr.Name = "Report Type"
        pr.Value = "Rack Design"
        Params.Add(pr)

        pr = New Param
        pr.Name = "ForWho"
        If UCase(User) = "JON" Or UCase(User) = "TONY" Or UCase(User) = "TODDW" Then
            pr.Value = "All"
        Else
            pr.Value = User
        End If
        Params.Add(pr)

        DisplayReport("commissions for groups prod type", , True, , , , False, , , Params)

    End Sub

    Private Sub MenuItem205_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem205.Click
        Dim Params As New Collection
        Dim pr As New Param
        Dim ShowGroup As Boolean = False

        pr.Name = "Report Type"
        pr.Value = "Cellar Art"
        Params.Add(pr)

        pr = New Param
        pr.Name = "ForWho"
        If UCase(User) = "JON" Or UCase(User) = "TONY" Or UCase(User) = "TODDW" Then
            pr.Value = "All"
            ShowGroup = True
        Else
            pr.Value = User
        End If
        Params.Add(pr)

        DisplayReport("commissions for groups prod type", , True, , , , ShowGroup, , , Params)

    End Sub

    Private Sub MenuItem206_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem206.Click
        Dim Params As New Collection
        Dim pr As New Param

        pr.Name = "Report Type"
        pr.Value = "Refrigeration"
        Params.Add(pr)

        pr = New Param
        pr.Name = "ForWho"
        If UCase(User) = "JON" Or UCase(User) = "TONY" Or UCase(User) = "TODDW" Then
            pr.Value = "All"
        Else
            pr.Value = User
        End If
        Params.Add(pr)

        DisplayReport("commissions for groups prod type", , True, , , , False, , , Params)

    End Sub

    Private Sub MenuItem207_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem207.Click
        DisplayReport("Shipments for Customers", , True)
    End Sub

    Private Sub MenuItem208_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem208.Click
        Dim fm As New fmPriceIncrease
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem209_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem209.Click
        DisplayReport("shipment days", , True)
    End Sub

    Private Sub MenuItem210_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem210.Click
        DisplayReport("amber blaze quotes", , True)
    End Sub

    Private Sub MenuItem211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem211.Click
        DisplayReport("amber blaze orders", , True)
    End Sub

    Private Sub MenuItem212_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem212.Click
        DisplayReport("kits per week", , True)
    End Sub

    Private Sub MenuItem213_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem213.Click
        DisplayReport("shipments by zone with product type", , True)
    End Sub

    Private Sub MenuItem214_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem214.Click
        DisplayReport("Forecast Not Checked Off", , True)
    End Sub

    Private Sub MenuItem215_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem215.Click
        DisplayReport("source code analysis", , True)
    End Sub

    Private Sub MenuItem216_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem216.Click
        DisplayReport("check ship status", , True)
    End Sub

    Private Sub MenuItem217_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem217.Click
        DisplayReport("payment receipts all dates", , True)
    End Sub

    Private Sub MenuItem218_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem218.Click
        DisplayReport("tax certification usage", , True)
    End Sub

    Private Sub MenuItem219_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem219.Click
        DisplayReport("credit tracking", , True)
    End Sub

    Private Sub MenuItem220_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem220.Click
        DisplayReport("order analysis shipping promotions", , True)
    End Sub

    Private Sub MenuItem221_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem221.Click
        DisplayReport("shipped staged crosstab", , True)
    End Sub

    Private Sub MenuItem222_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem222.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from installer_file order by installer_serial"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem223_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem223.Click
        DisplayReport("stain price at base", , True)
    End Sub

    Private Sub MenuItem224_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem224.Click
        DisplayReport("margins by designer", , True, , , , True)
    End Sub

    Private Sub MenuItem226_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem226.Click
        Dim fm As New fmCodes
        fm.onCNN = cnnAutoCad
        fm.SQLx = "select * from bom"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem227_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem227.Click
        Dim fm As New fmCodes
        fm.onCNN = cnnAutoCad
        fm.SQLx = "select * from render"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem228_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem228.Click
        DisplayReport("Customers with 3rd Party Billing and Orders Not", , True)
    End Sub

    Private Sub MenuItem229_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem229.Click
        DisplayReport("orders shipped not billed", , True)
    End Sub

    Private Sub MenuItem230_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem230.Click
        DisplayReport("item price updates", , True)
    End Sub

    Private Sub MenuItem231_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem231.Click
        DisplayReport("order analysis canceled by customer", , True, , , , True)
    End Sub

    Private Sub MenuItem232_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem232.Click
        Dim fm As New fmPrintCustomerOrders
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem233_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem233.Click
        Dim fm As New fmItemPricing
        fm.bRun.Enabled = False
        fm.Show()
        fm.GetGeneral()
        fm.Close()
        DisplayReport("install minutes by item code", , True, , User)
    End Sub

    Private Sub MenuItem234_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem234.Click
        DisplayReport("shipping discount by promotional code", , True)
    End Sub

    Private Sub MenuItem236_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem236.Click
        DisplayReport("quotes released", , True)
    End Sub

    Private Sub MenuItem237_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem237.Click
        DisplayReport("open orders by product code signoff status", , True)
    End Sub

    Private Sub fmMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        KeyLog("[" + Me.GetChildAtPoint(New Point(e.X, e.Y)).Name + "]")
    End Sub

    Private Sub MenuItem238_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem238.Click
        DisplayReport("forecasting crosstab for pca by created", , True)
    End Sub

    Private Sub MenuItem239_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem239.Click
        Dim fm As New fmCodes
        fm.onCNN = cnnAutoCad
        fm.SQLx = "select * from rd"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.ShowDialog()

    End Sub

    Private Sub MenuItem240_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem240.Click
        DisplayReport("Margins by prod type summary", , True, 1, , , True)
    End Sub

    Private Sub MenuItem241_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem241.Click
        DisplayReport("shipping modifications", , True)
    End Sub

    Private Sub MenuItem244_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem244.Click
        DisplayReport("production install dates", , True)
    End Sub

    Private Sub MenuItem245_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem245.Click
        DisplayReport("production install service calls", , True)
    End Sub

    Private Sub MenuItem243_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem243.Click
        DisplayReport("production status", , True, , , , True)
    End Sub

    Private Sub MenuItem247_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem247.Click
        Dim ol As New Outlook.Application
        Dim mess As Outlook.MailItem

        DisplayReport("production status", , True, , "OSR", , , , , , "Production Status.pdf")

        mess = ol.CreateItem(Outlook.OlItemType.olMailItem)
        mess.Subject = "Production Status Report"
        mess.Attachments.Add("Production Status.pdf")
        mess.Display()

    End Sub

    Private Sub MenuItem246_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem246.Click
        DisplayReport("items shipped - all parts", , True, , , , , , "LoadItemsShippedAllParts")
    End Sub

    Private Sub MenuItem248_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem248.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from finish_file order by finish_name"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.Show()
    End Sub

    Private Sub MenuItem249_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem249.Click
        DisplayReport("quote design analysis 2d", , True)
    End Sub

    Private Sub MenuItem250_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fm As New fmOrdWeb
        fm.Show()
    End Sub
    Private Sub MenuItem326_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem326.Click
        Dim fm As New fmWebExportTest
        fm.Show()
    End Sub

    Private Sub MenuItem251_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem251.Click
        DisplayReport("proposed staged summary", , True)
    End Sub

    Private Sub MenuItem252_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem252.Click
        DisplayReport("all quotes by order source", "", True, 1, , , True)

    End Sub

    Private Sub MenuItem253_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem253.Click
        Dim fm As New fmImportItems
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem254_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem254.Click
        Dim printer As New PrintDialog
        If printer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SaveSetting("Jcom", "Printing", "ShippingLabel", printer.PrinterSettings.PrinterName)
        End If
    End Sub



    Private Sub MenuItem291_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem291.Click
        DisplayReport("Margins by Source Code by Prod Type", , True)
    End Sub

    Private Sub MenuItem292_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem292.Click
        DisplayReport("Margins by Prod Type by Source Code", , True)
    End Sub

    Private Sub MenuItem256_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem256.Click
        Dim fmDate As New fmDateSelect
        Dim StartDate As Date
        Dim EndDate As Date

        fmDate.ShowDialog()
        If IsDate(fmDate.StartDate) Then
            StartDate = fmDate.StartDate
        End If
        If IsDate(fmDate.EndDate) Then
            EndDate = fmDate.EndDate
        End If
        LoadCostAnalysis_DKS(StartDate, EndDate)

    End Sub

    Private Sub MenuItem257_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem257.Click
        Dim fmDate As New fmDateSelect
        Dim StartDate As Date
        Dim EndDate As Date

        fmDate.ShowDialog()
        If IsDate(fmDate.StartDate) Then
            StartDate = fmDate.StartDate
        End If
        If IsDate(fmDate.EndDate) Then
            EndDate = fmDate.EndDate
        End If
        LoadCostAnalysis_CDR(StartDate, EndDate)
    End Sub

    Private Sub MenuItem258_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem258.Click
        Dim fmDate As New fmDateSelect
        Dim StartDate As Date
        Dim EndDate As Date

        fmDate.ShowDialog()
        If IsDate(fmDate.StartDate) Then
            StartDate = fmDate.StartDate
        End If
        If IsDate(fmDate.EndDate) Then
            EndDate = fmDate.EndDate
        End If
        LoadCostAnalysis_VIN3(StartDate, EndDate)

    End Sub

    Private Sub MenuItem259_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem259.Click
        Dim fmDate As New fmDateSelect
        Dim StartDate As Date
        Dim EndDate As Date

        fmDate.ShowDialog()
        If IsDate(fmDate.StartDate) Then
            StartDate = fmDate.StartDate
        End If
        If IsDate(fmDate.EndDate) Then
            EndDate = fmDate.EndDate
        End If
        LoadCostAnalysis_VIN4(StartDate, EndDate)

    End Sub

    Private Sub MenuItem261_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem261.Click
        Dim fmDate As New fmDateSelect
        Dim StartDate As Date
        Dim EndDate As Date

        fmDate.ShowDialog()
        If IsDate(fmDate.StartDate) Then
            StartDate = fmDate.StartDate
        End If
        If IsDate(fmDate.EndDate) Then
            EndDate = fmDate.EndDate
        End If
        LoadCostAnalysis_CPSeries(StartDate, EndDate)
    End Sub

    Private Sub MenuItem260_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem260.Click
        Dim fmDate As New fmDateSelect
        Dim StartDate As Date
        Dim EndDate As Date

        fmDate.ShowDialog()
        If IsDate(fmDate.StartDate) Then
            StartDate = fmDate.StartDate
        End If
        If IsDate(fmDate.EndDate) Then
            EndDate = fmDate.EndDate
        End If
        LoadCostAnalysis_RSeries(StartDate, EndDate)
    End Sub

    Private Sub MenuItem262_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem262.Click
        Dim fmDate As New fmDateSelect
        Dim StartDate As Date
        Dim EndDate As Date

        fmDate.ShowDialog()
        If IsDate(fmDate.StartDate) Then
            StartDate = fmDate.StartDate
        End If
        If IsDate(fmDate.EndDate) Then
            EndDate = fmDate.EndDate
        End If
        LoadCostAnalysis_SRS(StartDate, EndDate)
    End Sub

    Private Sub MenuItem263_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem263.Click
        DisplayReport("In Process Orders with Base Price", , True)
    End Sub

    Private Sub MenuItem264_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem264.Click
        Dim par As New Param
        Dim pars As New Collection
        Dim rw As Integer
        Try
            par.Name = "Group By"
            par.Value = "Estimated Date"
            pars.Add(par)

            DisplayReport("In Process Orders with Base Price (excel)", , , , , , , , , pars, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\In Process Orders with Base Price.xls", "XLS")

            Dim ex As New Excel.Application
            Dim fl As Excel.Workbook
            Dim sh As Excel.Worksheet
            Dim rg As Excel.Range
            Dim cmd As New SqlClient.SqlCommand("", cnn)
            Dim onOrder As String
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As DataTable
            Dim dr As DataRow
            Dim onDates As String
            Dim KitCust As Boolean

            cnn.Open()
            'fl = ex.Workbooks.Open(System.IO.Directory.GetCurrentDirectory + "\In Process Orders with Base Price.xls")
            fl = ex.Workbooks.Open(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\In Process Orders with Base Price.xls")
            sh = fl.ActiveSheet

            rg = sh.Range("A1", "Z1")
            rg.EntireColumn.AutoFit()

            rg = sh.Range("B1", "B" + CStr(sh.UsedRange.Rows.Count))
            rg.ColumnWidth = 20
            rg.EntireColumn.WrapText = True
            rg.EntireRow.AutoFit()

            rg = sh.Range("E1", "E" + CStr(sh.UsedRange.Rows.Count))
            rg.ColumnWidth = 40
            rg.EntireColumn.WrapText = True
            rg.EntireRow.AutoFit()

            For rw = 1 To sh.UsedRange.Rows.Count
                rg = sh.Range("A" + CStr(rw), "A" + CStr(rw))
                If Mid(rg.Text, 1, 4) = "Week" Then
                    sh.Range("A" + CStr(rw), "R" + CStr(rw)).Interior.ColorIndex = 15
                    sh.Range("A" + CStr(rw), "R" + CStr(rw)).Font.Bold = True
                Else
                    onOrder = rg.Text
                    rg = sh.Range("D" + CStr(rw), "D" + CStr(rw))
                    If rg.Text = "QUOTED" Then
                        sh.Range("A" + CStr(rw), "R" + CStr(rw)).Interior.ColorIndex = 17
                    Else
                        KitCust = False
                        If Split(onOrder, "-").Length > 1 Then
                            cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(onOrder, "-")(0) + " and ord_itm_rev=" + Split(onOrder, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='KIT' or ord_itm_prod_type='DESKIT')"
                            KitCust = nz(cmd.ExecuteScalar, 0) > 0
                            cmd.CommandText = "select count(*) from ord_itm where ord_itm_ord_serial=" + Split(onOrder, "-")(0) + " and ord_itm_rev=" + Split(onOrder, "-")(2) + " and ord_itm_type='O' and (ord_itm_prod_type='TOP' or ord_itm_prod_type='BUD' or ord_itm_prod_type='GOLD')"
                            KitCust = KitCust And (nz(cmd.ExecuteScalar, 0) > 0)

                            rg = sh.Range("D" + CStr(rw), "D" + CStr(rw))
                            If rg.Text <> "SHIPPED" Then
                                rg = sh.Range("F" + CStr(rw), "F" + CStr(rw))
                                dt = New DataTable
                                cmd.CommandText = "select distinct ord_prod_est_comp from ord_prod_hist where ord_prod_ord_serial=" + Split(onOrder, "-")(0) + " and ord_prod_rev=" + Split(onOrder, "-")(2) + " and ord_prod_type='O' and ord_prod_est_comp>'1/1/1900' and ord_prod_est_comp<>'" + rg.Text + "' order by ord_prod_est_comp"
                                da.Fill(dt)
                                If dt.Rows.Count > 0 Then
                                    onDates = "Est Orig Dts: "
                                    For Each dr In dt.Rows
                                        onDates += Format(dr("ord_prod_est_comp"), "MM/dd/yyyy") + ", "
                                    Next
                                    onDates = Mid(onDates, 1, Len(onDates) - 2)
                                    If sh.Range("E" + CStr(rw), "E" + CStr(rw)).Text <> "" Then sh.Range("E" + CStr(rw), "E" + CStr(rw)).Value += "; "
                                    sh.Range("E" + CStr(rw), "E" + CStr(rw)).Value = sh.Range("E" + CStr(rw), "E" + CStr(rw)).Text + onDates
                                End If
                            End If
                        End If

                        'Add Color
                        rg = sh.Range("D" + CStr(rw), "D" + CStr(rw))
                        If rg.Text <> "SHIPPED" Then
                            If KitCust Then
                                sh.Range("A" + CStr(rw), "R" + CStr(rw)).Interior.ColorIndex = 6
                            Else
                                rg = sh.Range("E" + CStr(rw), "E" + CStr(rw))
                                If (Mid(rg.Text, 1, 2) = "O-") Or (Mid(rg.Text, 1, 3) = "O -") Then
                                    sh.Range("A" + CStr(rw), "R" + CStr(rw)).Interior.ColorIndex = 45
                                Else
                                    If Split(onOrder, "-").Length > 1 Then
                                        If InStr(rg.Text, "Est Orig Dts:") > 0 Then
                                            sh.Range("A" + CStr(rw), "R" + CStr(rw)).Interior.ColorIndex = 4
                                        Else
                                            cmd.CommandText = "select ord_prod_notes_flag from ord_prod where ord_prod_ord_serial=" + Split(onOrder, "-")(0) + " and ord_prod_rev=" + Split(onOrder, "-")(2) + " and ord_prod_type='O'"
                                            If nz(cmd.ExecuteScalar, False) = True Then
                                                sh.Range("A" + CStr(rw), "R" + CStr(rw)).Interior.ColorIndex = 33
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            If Split(onOrder, "-").Length > 1 Then
                                cmd.CommandText = "select ord_prod_added_to_closed_week from ord_prod where ord_prod_ord_serial=" + Split(onOrder, "-")(0) + " and ord_prod_rev=" + Split(onOrder, "-")(2) + " and ord_prod_type='O'"
                                If nz(cmd.ExecuteScalar, False) = True Then
                                    sh.Range("A" + CStr(rw), "R" + CStr(rw)).Font.ColorIndex = 3
                                End If
                            End If
                        End If
                    End If
                End If
            Next
            cnn.Close()

            rw = sh.UsedRange.Rows.Count + 2
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "Key"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Font.Bold = True
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 2
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "On schedule to ship prior to today or unable to complete by original completion date"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 4
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "Kit/Custom Combo orders"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 6
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "Added to week (had to do Production Unlock)"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 2
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Font.ColorIndex = 3
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "Completion date pushed up by JLD"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 45
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "Still a QUOTE! Commit added to schedule for production purposes. Date subject to change"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 17
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "Production Notes-Important notes concerning completion date"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 33
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = ""
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 2
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "PIF=Paid In Full"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 2
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "O-Date=Original completion date"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 2
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "IWU=In Write Up Process"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 2
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "Commit=WCI committed to shipping ON this day"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 2
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "D=In boxing for QC. Not yet boxed"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 2
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "D-$=In boxing for QC. Not yet boxed. Order owes $"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 2
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "B=Order is boxed and skidded-ready to go"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 2
            rw += 1
            sh.Range("A" + CStr(rw), "A" + CStr(rw)).Value = "B-$=Order is boxed and skidded-ready to go. Order owes $"
            sh.Range("A" + CStr(rw), "D" + CStr(rw)).Interior.ColorIndex = 2
            sh.Range("A" + CStr(rw - 15), "D" + CStr(rw)).BorderAround()

            ex.Visible = True
            ex.ActiveWindow.FreezePanes = False
            sh.Range("A2", "A2").EntireRow.Select()
            ex.ActiveWindow.FreezePanes = True

            sh.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
            sh.PageSetup.PrintGridlines = True
            sh.PageSetup.FitToPagesWide = 1
            sh.PageSetup.FitToPagesTall = 99
            sh.PageSetup.Zoom = False

            fl.Save()

            fl.PrintPreview()
            ex = Nothing
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub MenuItem265_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem265.Click
        DisplayReport("In Process Orders with Base Price - Install", , True)
    End Sub

    Private Sub MenuItem266_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem266.Click
        Dim cmd As New SqlClient.SqlCommand("select max(prod_lock_date) from prod_lock", cnn)
        Dim onDate, maxDate As Date

        cnn.Open()
        maxDate = cmd.ExecuteScalar
        onDate = maxDate
        Do While onDate < DateAdd(DateInterval.Day, 120, maxDate)
            onDate = DateAdd(DateInterval.Day, 7, onDate)
            cmd.CommandText = "insert into prod_lock (prod_lock_date,prod_lock_checked,prod_lock_checked_by,prod_lock_checked_on) values ('" + CStr(onDate) + "',0,'','1/1/1900')"
            cmd.ExecuteNonQuery()
        Loop
        cnn.Close()

        Dim fm As New fmProductionLock
        fm.Height = Me.Height * 0.7
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem267_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem267.Click
        Dim fm As New fmPartRename
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem268_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem268.Click
        DisplayReport("rack design - time review", , True)
    End Sub

    Private Sub MenuItem269_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem269.Click
        DisplayReport("quote design analysis 2d (excel)", , True)
    End Sub

    Private Sub MenuItem270_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem270.Click
        DisplayReport("diagnostics outstanding", , True)
    End Sub

    Private Sub MenuItem271_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem271.Click
        DisplayReport("diagnostics received", , True)
    End Sub

    Private Sub MenuItem272_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem272.Click
        Dim fm As New fmCallCenterAdmin
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub mnCheckForUpdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCheckForUpdates.Click
        If UCase(User) = "TODDW" Or UCase(User) = "JON" Then
            If mnCheckForUpdates.Checked Then
                mnCheckForUpdates.Checked = False
            Else
                mnCheckForUpdates.Checked = True
            End If
            SaveSetting("Jcom", "CheckForUpdate", "Check", IIf(mnCheckForUpdates.Checked, "True", "False"))
        End If
    End Sub

    Private Sub MenuItem273_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("This should only be run by an administrator.  Are you sure?", MsgBoxStyle.YesNo, "Sure?") = MsgBoxResult.Yes Then
            Dim cmd As New SqlClient.SqlCommand("DELETE FROM cont_file WHERE (update_by = 'import')", cnn)
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
            MsgBox("Import Deleted")
        End If
    End Sub

    Private Sub MenuItem275_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem275.Click
        DisplayReport("products ordered by customer by shipped-staged date - all", , True, 1, , , True)
    End Sub

    Private Sub MenuItem274_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem274.Click
        DisplayReport("products ordered by customer - all", , True, 1, , , True)
    End Sub

    Private Sub MenuItem250_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem250.Click
        'Dim fm As New fmWebExport
        Dim fm As New fmWebExportTest 'Changing as we don't need the earlier form
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem273_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem273.Click
        DisplayReport("kits ordered", , True)
    End Sub

    Private Sub MenuItem276_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem276.Click
        DisplayReport("shipping discount by promotional code - extended", , True)
    End Sub

    Private Sub MenuItem277_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem277.Click
        DisplayReport("forecasting crosstab-qty", , True, 1, , , True, , "LoadCurrentRegion")
    End Sub

    Private Sub MenuItem278_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem278.Click
        DisplayReport("call center calls", , True)
    End Sub

    Private Sub MenuItem279_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem279.Click
        DisplayReport("margins by osr per order", , True)
    End Sub

    Private Sub MenuItem280_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem280.Click
        DisplayReport("custom to factory by date", , True)
    End Sub

    Private Sub MenuItem281_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem281.Click
        Dim fm As New fmCatalogs
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem282_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem282.Click
        DisplayReport("total sales per dealer rep", , True)
    End Sub

    Private Sub MenuItem283_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem283.Click
        DisplayReport("open order kit and cdr status", , True)
    End Sub

    Private Sub MenuItem284_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem284.Click
        DisplayReport("margins by source code", , True)
    End Sub

    Private Sub MenuItem285_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem285.Click
        DisplayReport("quotes by call center rep", , True)
    End Sub

    Private Sub MenuItem286_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem286.Click
        DisplayReport("kits shipped with box count", , True)
    End Sub

    Private Sub MenuItem287_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem287.Click
        DisplayReport("orders with kits downstairs", , True)
    End Sub

    Private Sub MenuItem288_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem288.Click
        Try
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim cmd As New SqlClient.SqlCommand
            Dim dr As DataRow
            Dim ds As New DataSet
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim base, md, con, retail, ship, install As Double
            Dim cnt As Long = 0

            cmd.Connection = cnn
            cmd.CommandTimeout = 3600

            cnn.Open()
            cmd.CommandText = "delete from item_price where item_user='" + User + "'"
            cmd.ExecuteNonQuery()

            'cmd.CommandText = "select * from itm_file"
            cmd.CommandText = "select ord_itm_serial,ord_itm_item_code,ord_itm_qty,ord_itm_prod_type,case when ord_gen_staged=1 then ord_gen_staged_date else ord_gen_ship_date end as ord_gen_ship_date from ord_itm left outer join ord_itm_price on ord_itm_serial=ord_itm_price_ord_itm_serial inner join ord_gen ON ord_itm.ord_itm_ord_serial = ord_gen.ord_gen_ord_serial AND ord_itm.ord_itm_rev = ord_gen.ord_gen_rev AND ord_itm.ord_itm_type = ord_gen.ord_gen_type where ord_itm_type='O' and (ord_gen_ship_date>='1/1/2011' or ord_gen_staged_date>='1/1/2011') and isnull(ord_itm_price_ord_itm_serial,0)=0"
            da.Fill(ds, "itm")
            For Each dr In ds.Tables(0).Rows
                cnt = cnt + 1
                'If nz(dr("inactive"), 0) <> True Then
                cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("ord_itm_item_code")) + "' and itm_price_type='BASE' and itm_price_start<='" + CStr(dr("ord_gen_ship_date")) + "' and itm_price_end>='" + CStr(dr("ord_gen_ship_date")) + "'"
                base = nz(cmd.ExecuteScalar, 0)

                'If nz(dr("itm_flat_rate"), False) = True Then
                '    md = base
                'Else
                cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("ord_itm_item_code")) + "' and itm_price_type='MD' and itm_price_start<='" + CStr(dr("ord_gen_ship_date")) + "' and itm_price_end>='" + CStr(dr("ord_gen_ship_date")) + "'"
                md = nz(cmd.ExecuteScalar, 0)
                If md = 0 Then
                    cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + nz(dr("ord_itm_prod_type")) + "' and sales_cat_prod_mar_cat='MD' and sales_cat_prod_mar_start<='" + CStr(dr("ord_gen_ship_date")) + "' and sales_cat_prod_mar_end>='" + CStr(dr("ord_gen_ship_date")) + "'"
                    md = nz(cmd.ExecuteScalar, 0)
                    md = md * base
                End If
                'End If

                'If nz(dr("itm_flat_rate"), False) = True Then
                '    con = base
                'Else
                cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("ord_itm_item_code")) + "' and itm_price_type='CON' and itm_price_start<='" + CStr(dr("ord_gen_ship_date")) + "' and itm_price_end>='" + CStr(dr("ord_gen_ship_date")) + "'"
                con = nz(cmd.ExecuteScalar, 0)
                If con = 0 Then
                    cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + nz(dr("ord_itm_prod_type")) + "' and sales_cat_prod_mar_cat='CON' and sales_cat_prod_mar_start<='" + CStr(dr("ord_gen_ship_date")) + "' and sales_cat_prod_mar_end>='" + CStr(dr("ord_gen_ship_date")) + "'"
                    con = nz(cmd.ExecuteScalar, 0)
                    con = con * base
                End If
                'End If

                'If nz(dr("itm_flat_rate"), False) = True Then
                '    retail = base
                'Else
                cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("ord_itm_item_code")) + "' and itm_price_type='RET' and itm_price_start<='" + CStr(dr("ord_gen_ship_date")) + "' and itm_price_end>='" + CStr(dr("ord_gen_ship_date")) + "'"
                retail = nz(cmd.ExecuteScalar, 0)
                If retail = 0 Then
                    cmd.CommandText = "select sales_cat_prod_mar_mar from sales_cat_prod_mar where sales_cat_prod_mar_type='" + nz(dr("ord_itm_prod_type")) + "' and sales_cat_prod_mar_cat='RET' and sales_cat_prod_mar_start<='" + CStr(dr("ord_gen_ship_date")) + "' and sales_cat_prod_mar_end>='" + CStr(dr("ord_gen_ship_date")) + "'"
                    retail = nz(cmd.ExecuteScalar, 0)
                    retail = retail * base
                End If
                'End If

                'cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("ord_itm_item_code")) + "' and itm_price_type='SHIP' and itm_price_start<='" + CStr(dr("ord_gen_ship_date")) + "' and itm_price_end>='" + CStr(dr("ord_gen_ship_date")) + "'"
                'ship = nz(cmd.ExecuteScalar, 0)

                'cmd.CommandText = "select itm_price_price from itm_price where itm_price_itm_code='" + nz(dr("ord_itm_item_code")) + "' and itm_price_type='Install' and itm_price_start<='" + CStr(dr("ord_gen_ship_date")) + "' and itm_price_end>='" + CStr(dr("ord_gen_ship_date")) + "'"
                'install = nz(cmd.ExecuteScalar, 0)

                cmd.CommandText = "insert into ord_itm_price (ord_itm_price_ord_itm_serial,ord_itm_price_base,ord_itm_price_md,ord_itm_price_con,ord_itm_price_ret,ord_itm_price_date) values (" + CStr(dr("ord_itm_serial")) + "," + CStr(base) + "," + CStr(md) + "," + CStr(con) + "," + CStr(retail) + ",getdate())"
                cmd.ExecuteNonQuery()
                'End If
                'Bar1.Value = cnt / ds.Tables("itm").Rows.Count * 100
            Next
            cnn.Close()
            DisplayReport("margins by osr per order shipped", , True)
        Catch
            MsgBox(Err.Description)
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
            cnn.Close()
        End Try

    End Sub

    Private Sub MenuItem293_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem293.Click
        DisplayReport("Design Quotes by OSR", , True, 1, , , False)
    End Sub

    Private Sub MenuItem294_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem294.Click
        DisplayReport("OrdersbyResponsibility", , True, 1, , , False)
    End Sub

    Private Sub MenuItem295_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem295.Click
        Dim fm As New fmCodes
        fm.SQLx = "select * from state_weborder_var order by state_abbr"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8
        fm.Show()
    End Sub

    Private Sub MenuItem296_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem296.Click
        DisplayReport("call center calls tracking", , True)
    End Sub


    Private Sub MenuItem297_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem297.Click
        DisplayReport("open orders by to factory", , True, 1, , , True)
    End Sub

    Private Sub MenuItem298_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem298.Click
        DisplayReport("Custom Order MAT-BOT-RH", , True, 1, , , True)
    End Sub

    Private Sub MenuItem299_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem299.Click
        DisplayReport("tax compare audit", , True, 1, , , True)
    End Sub

    Private Sub MenuItem300_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem300.Click
        DisplayReport("ar aging no credits", "{ord_gen.ord_gen_balance} > $0.00 and {ord_gen.ord_gen_type} = 'O' and {ord_gen.ord_gen_show_date}>=cdate(2005,1,1) and {ord_gen.ord_gen_status} = 'SHIPPED'", True, , , , True)

    End Sub

    Private Sub MenuItem301_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem301.Click
        'Sales by Responsibility by Ship Date
        DisplayReport("Sales by Responsibility by Ship Date", , True, 1, , , True)
    End Sub

    Private Sub MenuItem302_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem302.Click
        Dim fm As New fmKitCDRDownstairs
        'fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub MenuItem303_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem303.Click
        DisplayReport("PaymentsbyResponsibility", , True, 1, , , True)
    End Sub

    Private Sub MenuItem304_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem304.Click
        DisplayReport("Open Custom Orders – Current Status", , True, 1, , , True)
    End Sub

    Private Sub MenuItem305_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem305.Click
        Dim fm As New fmCodes
        fm.SQLx = "select fc_last_name,fc_first_name,fc_weekly_total,fc_serial from field_consultant order by fc_last_name,fc_first_name"
        fm.Height = Me.Height * 0.95
        fm.Width = Me.Width * 0.8

        fm.Show()
    End Sub

    Private Sub MenuItem307_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem307.Click
        DisplayReport("Field Consultant Orders", , True, 1, , , True)
    End Sub


    Private Sub MenuItem308_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem308.Click
        Dim fm As New fmCCportal
        fm.Show()
    End Sub

    Private Sub MenuItem309_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem309.Click
        DisplayReport("quote-designstartchecking", , True, 1, , , True)
    End Sub

    Private Sub MenuItem310_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem310.Click
        DisplayReport("payment receipts daily", , True, 1, , , True)
    End Sub

    Private Sub MenuItem311_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem311.Click
        DisplayReport("contactslist", , True, 1, , , True)
    End Sub

    Private Sub MenuItem312_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem312.Click
        DisplayReport("Custom Order MAT-BOT-RH by Order", , True, 1, , , True)
    End Sub

    Private Sub MenuItem313_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem313.Click
        DisplayReport("Cancelled Orders", , True, 1, , , True)
    End Sub

    Private Sub MenuItem314_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem314.Click
        DisplayReport("Field Consultant Orders by Type", , True, 1, , , True)
    End Sub

    Private Sub MenuItem315_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem315.Click
        DisplayReport("order analysis by product type by date for FIX", , True, 1, , , True)
    End Sub

    Private Sub MenuItem317_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem317.Click
        DisplayReport("Livechat Orders Crosstab", , True, 1, , , True)
    End Sub

    Private Sub MenuItem318_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem318.Click
        DisplayReport("Livechat Quotes Crosstab", , True, 1, , , True)
    End Sub

    Private Sub MenuItem325_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem325.Click
        DisplayReport("Leads Chat Log Orders", , True, 1, , , False)
    End Sub

    Private Sub MenuItem319_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem319.Click
        DisplayReport("Livechat Ship Crosstab", , True, 1, , , True)
    End Sub

    Private Sub MenuItem320_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem320.Click
        ' If MsgBox("Continue", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        ' Dim dts As New DataSet
        ' Dim dtt As New DataTable
        ' Dim cnntest As New SqlConnection("server=10.0.0.245; user id=sa; password=39201; database=winecellar; pooling=false")
        ' Dim cmdtest As New SqlCommand("", cnntest)
        ' Dim datest As New SqlDataAdapter(cmdtest)
        ' Dim str As String = ""
        ' cnntest.Open()
        ' Try

        '     cmdtest.CommandText = "select * from z where qty=2"
        '     datest.Fill(dtt)
        '     Dim ct As Integer = dtt.Rows.Count
        '     Dim i As Integer
        '     cmdtest.Parameters.Clear()
        '     cmdtest.Parameters.Add(New SqlParameter("@ORDFOR", "256351 Order."))
        '     For i = 0 To (ct - 1)
        '         cmdtest.CommandText = "INSERT INTO ord_file (" + _
        '         "ord_rev, ord_amt, ord_for, ord_for2, ord_sold_cust_serial, ord_sold_cust_id, ord_sold_name, ord_sold_company, ord_sold_country, ord_sold_addr1, " + _
        '         "ord_sold_addr2, ord_sold_addr3, ord_sold_city, ord_sold_state, ord_sold_county, ord_sold_province, ord_sold_zip, ord_sold_phone1, ord_sold_phone2,  " + _
        '         "ord_sold_fax, ord_sold_alt_phone, ord_sold_cell, ord_sold_email, ord_ship_cust_serial, ord_ship_cust_id, ord_ship_name, ord_ship_company, ord_ship_country, " + _
        '         "ord_ship_addr1, ord_ship_addr2, ord_ship_addr3, ord_ship_city, ord_ship_state, ord_ship_county, ord_ship_province, ord_ship_zip, ord_ship_phone1, " + _
        '         "ord_ship_phone2, ord_ship_fax, ord_ship_alt_phone, ord_ship_cell, ord_ship_email, ord_same_as_sold, update_by, last_update, ord_sales_cat, ord_cust_taxrate, " + _
        '         "ord_tax_exempt, ord_tax_exempt_no, ord_tax_installs, ord_appl_5_perc, ord_acct_open, ord_ref_name, ord_ref_company, ord_ref_addr1, ord_ref_addr2, " + _
        '         "ord_ref_addr3, ord_ref_city, ord_ref_state, ord_ref_zip, ord_ref_perc, ord_ref_phone, ord_ref_serial, ord_ref_note, ord_temp, ord_is_split, ord_exempt_addr, " + _
        '         "ord_email_shipment, ord_email_osr_shipment, ord_cont_serial, ord_cc_random, ord_cc_open_orders" + _
        '         ") select " + _
        '          "ord_rev, ord_amt, @ORDFOR as ord_for, ord_for2, ord_sold_cust_serial, ord_sold_cust_id, ord_sold_name, ord_sold_company, ord_sold_country, ord_sold_addr1, " + _
        '         "ord_sold_addr2, ord_sold_addr3, ord_sold_city, ord_sold_state, ord_sold_county, ord_sold_province, ord_sold_zip, ord_sold_phone1, ord_sold_phone2,  " + _
        '         "ord_sold_fax, ord_sold_alt_phone, ord_sold_cell, ord_sold_email, ord_ship_cust_serial, ord_ship_cust_id, ord_ship_name, ord_ship_company, ord_ship_country, " + _
        '         "ord_ship_addr1, ord_ship_addr2, ord_ship_addr3, ord_ship_city, ord_ship_state, ord_ship_county, ord_ship_province, ord_ship_zip, ord_ship_phone1, " + _
        '         "ord_ship_phone2, ord_ship_fax, ord_ship_alt_phone, ord_ship_cell, ord_ship_email, ord_same_as_sold, update_by, last_update, ord_sales_cat, ord_cust_taxrate, " + _
        '         "ord_tax_exempt, ord_tax_exempt_no, ord_tax_installs, ord_appl_5_perc, ord_acct_open, ord_ref_name, ord_ref_company, ord_ref_addr1, ord_ref_addr2, " + _
        '         "ord_ref_addr3, ord_ref_city, ord_ref_state, ord_ref_zip, ord_ref_perc, ord_ref_phone, ord_ref_serial, ord_ref_note, ord_temp, ord_is_split, ord_exempt_addr, " + _
        '         "ord_email_shipment, ord_email_osr_shipment, ord_cont_serial, ord_cc_random, ord_cc_open_orders" + _
        '         " from ord_file where ord_serial = 257519"
        '         cmdtest.ExecuteNonQuery()
        '     Next

        '     cmdtest.CommandText = "select * from ord_file where ord_for = '256351 Order.' and ord_serial<>257519 order by ord_serial"
        '     datest.Fill(dts, "ordfile")

        '     Dim strt As String
        '     Dim cty As String
        '     Dim state As String
        '     Dim zip As String
        '     Dim cnty As String = ""
        '     Dim TAXEXEMPT As String

        '     Dim cnt As Integer = 0
        '     Dim drow As DataRow
        '     For Each drow In dts.Tables("ordfile").Rows
        '         cmdtest.Parameters.Clear()
        '         strt = dtt.Rows.Item(cnt).Item("street")
        '         cty = dtt.Rows.Item(cnt).Item("city")
        '         state = dtt.Rows.Item(cnt).Item("st")
        '         zip = dtt.Rows.Item(cnt).Item("zip")
        '         TAXEXEMPT = dtt.Rows.Item(cnt).Item("taxexempt")

        '         cmdtest.Parameters.Add(New SqlParameter("@serial", drow("ord_serial")))
        '         cmdtest.Parameters.Add(New SqlParameter("@strt", strt))
        '         cmdtest.Parameters.Add(New SqlParameter("@cty", cty))
        '         cmdtest.Parameters.Add(New SqlParameter("@state", state))
        '         cmdtest.Parameters.Add(New SqlParameter("@zip", zip))
        '         cmdtest.Parameters.Add(New SqlParameter("@cnty", cnty))
        '         cmdtest.Parameters.Add(New SqlParameter("@TAXEXEMPT", TAXEXEMPT))

        '         cmdtest.CommandText = "INSERT INTO ord_gen (" + _
        '     "ord_gen_ord_serial, ord_gen_rev, ord_gen_type, ord_gen_inside, ord_gen_outside, ord_gen_floating, ord_gen_designer, ord_gen_show_date, " + _
        '                     "ord_gen_create_date, ord_gen_create_by, ord_gen_update_date, ord_gen_update_by, ord_gen_notes, ord_gen_total, ord_gen_line_total, ord_gen_balance,  " + _
        '                     "ord_gen_ship, ord_gen_tax, ord_gen_ship_extra, ord_gen_ship_disc, ord_gen_def_fin, ord_gen_status, ord_gen_status2, ord_gen_ship_inside,  " + _
        '                     "ord_gen_ship_gated, ord_gen_ship_smalltruck, ord_gen_ship_call, ord_gen_ship_callname, ord_gen_ship_callphone, ord_gen_ship_twoman,  " + _
        '                     "ord_gen_ship_liftgate, ord_gen_ship_steps, ord_gen_ship_numsteps, ord_gen_ship_turns, ord_gen_ship_numturns, ord_gen_ship_thirdparty,  " + _
        '                     "ord_gen_ship_thirdpartyname, ord_gen_ship_thirdpartyshipvia, ord_gen_ship_thirdpartyacct, ord_gen_ship_alert, ord_gen_ship_overnite, ord_gen_ship_skids,  " + _
        '                     "ord_gen_ship_numskids, ord_gen_ship_intlship, ord_gen_ship_collect, ord_gen_ship_cust_pickup, ord_gen_ship_white_glove, ord_gen_billed, ord_gen_billdate,  " + _
        '                     "ord_gen_cust_po, ord_gen_material, ord_gen_finish, ord_gen_from_rev, ord_gen_forecast, ord_gen_lost_reason, ord_gen_lost_date, ord_gen_ship_date,  " + _
        '                     "ord_gen_src, ord_gen_special_notes, ord_gen_ship_prepaid, ord_gen_sales_cat, ord_gen_staged_date, ord_gen_staged, ord_gen_latest_rev,  " + _
        '                     "ord_gen_vend_net_date, ord_gen_forecast_date, ord_gen_forecast_status_date, ord_gen_forecast_updated, ord_gen_forecast_updatedby, ord_gen_forecast_note,  " + _
        '                     "ord_gen_forecast_next_contact, ord_gen_forecast_perc, ord_gen_resp_rep, ord_gen_current_osr, ord_gen_co_isr, ord_gen_co_isruser, ord_gen_co_isrdate,  " + _
        '                     "ord_gen_co_desreq, ord_gen_co_designer, ord_gen_co_desuser, ord_gen_co_desdate, ord_gen_co_designer_opened, ord_gen_co_art, ord_gen_co_priority,  " + _
        '                     "ord_gen_co_toart, ord_gen_co_emailsent, ord_gen_co_ca, ord_gen_co_causer, ord_gen_co_cadate, ord_gen_co_factoryinstall_req, ord_gen_co_factoryinstall,  " + _
        '                     "ord_gen_co_factoryinstall_user, ord_gen_co_factoryinstall_date, ord_gen_toship, ord_gen_toshipvia, ord_gen_ship_roundoff, ord_gen_des_type,  " + _
        '                     "ord_gen_des_type_auto, ord_gen_cur_sales_cat, ord_gen_ref_fee, ord_gen_ref_paid, ord_gen_alt_ship, ord_gen_tax_override, ord_gen_tax_override_perc,  " + _
        '                     "ord_gen_alt_taxrate, ord_gen_alt_taxinstalls, ord_gen_comm_disc, ord_gen_acct_closed, ord_gen_acct_total, ord_gen_acct_lock, ord_gen_bottles,  " + _
        '                     "ord_gen_bom_import, ord_gen_terr, ord_gen_def_stain_serial, ord_gen_def_finish_serial, ord_gen_def_lacquer, ord_gen_cust_with_terms,  " + _
        '                     "ord_gen_cust_with_terms_ship, ord_gen_temp, ord_gen_ship_active, ord_gen_from_quote, ord_gen_ship_white_glove_override, ord_gen_ship_overnite_override,  " + _
        '                     "ord_gen_cust_order, ord_gen_tab_title, ord_gen_tax_ship_perc, ord_gen_upsell_sqft, ord_gen_ship_cust_id, ord_gen_ship_name, ord_gen_ship_company,  " + _
        '                     "ord_gen_ship_country, ord_gen_ship_addr1, ord_gen_ship_addr2, ord_gen_ship_addr3, ord_gen_ship_city, ord_gen_ship_state, ord_gen_ship_county,  " + _
        '                     "ord_gen_ship_province, ord_gen_ship_zip, ord_gen_ship_phone1, ord_gen_ship_phone2, ord_gen_ship_fax, ord_gen_ship_alt_phone, ord_gen_ship_cell,  " + _
        '                     "ord_gen_ship_email, ord_gen_cust_taxrate, ord_gen_tax_exempt, ord_gen_tax_exempt_no, ord_gen_tax_exempt_addr, ord_gen_tax_installs, ord_gen_ship_hold,  " + _
        '                     "ord_gen_ship_promo_serial, ord_gen_tgwall, ord_gen_tgceiling, ord_gen_circles, ord_gen_current_region, ord_gen_addon, ord_gen_addon_noemail,  " + _
        '                     "ord_gen_shiptotype, ord_gen_signoff_note, ord_gen_moldings, ord_gen_ship_notify, ord_gen_priority_note, ord_gen_des_status, ord_gen_writeup_email_sent,  " + _
        '                     "ord_gen_rack_height, ord_gen_install_dt, ord_gen_installer, ord_gen_install_note, ord_gen_prop_stage, ord_gen_pc_date, ord_gen_pc_days, ord_gen_pc_notes,  " + _
        '                     "ord_gen_pc_date_last, ord_gen_pc_report, ord_gen_cust_tot, ord_gen_stain_tot, ord_gen_ok_to_bill_early, ord_gen_pca_signoffsent, ord_gen_pca_signoffsent_by,  " + _
        '                     "ord_gen_pca_signoffsent_date, ord_gen_pca_signoffrec, ord_gen_pca_signoffrec_by, ord_gen_pca_signoffrec_date, ord_gen_web_order, ord_gen_diag_note,  " + _
        '                     "ord_gen_ccsrc, ord_gen_def_lacq3, ord_gen_start_design, ord_gen_design_required, ord_gen_print_downstairs, ord_gen_print_downstairs_by,  " + _
        '                     "ord_gen_field_consultant, ord_gen_start_checking, ord_gen_field_consult_type, ord_gen_designer_grade " + _
        '    ") select " + _
        '      "@serial as ord_gen_ord_serial, 0, ord_gen_type, ord_gen_inside, ord_gen_outside, ord_gen_floating, ord_gen_designer, ord_gen_show_date, " + _
        '                     "ord_gen_create_date, ord_gen_create_by, ord_gen_update_date, ord_gen_update_by, ord_gen_notes, ord_gen_total, ord_gen_line_total, 0,  " + _
        '                     "ord_gen_ship, ord_gen_tax, ord_gen_ship_extra, ord_gen_ship_disc, ord_gen_def_fin, ord_gen_status, ord_gen_status2, ord_gen_ship_inside,  " + _
        '                     "ord_gen_ship_gated, ord_gen_ship_smalltruck, ord_gen_ship_call, ord_gen_ship_callname, ord_gen_ship_callphone, ord_gen_ship_twoman,  " + _
        '                     "ord_gen_ship_liftgate, ord_gen_ship_steps, ord_gen_ship_numsteps, ord_gen_ship_turns, ord_gen_ship_numturns, ord_gen_ship_thirdparty,  " + _
        '                     "ord_gen_ship_thirdpartyname, ord_gen_ship_thirdpartyshipvia, ord_gen_ship_thirdpartyacct, ord_gen_ship_alert, ord_gen_ship_overnite, ord_gen_ship_skids,  " + _
        '                     "ord_gen_ship_numskids, ord_gen_ship_intlship, ord_gen_ship_collect, ord_gen_ship_cust_pickup, ord_gen_ship_white_glove, ord_gen_billed, ord_gen_billdate,  " + _
        '                     "ord_gen_cust_po, ord_gen_material, ord_gen_finish, 0, ord_gen_forecast, ord_gen_lost_reason, ord_gen_lost_date, ord_gen_ship_date,  " + _
        '                     "ord_gen_src, ord_gen_special_notes, ord_gen_ship_prepaid, ord_gen_sales_cat, ord_gen_staged_date, ord_gen_staged, ord_gen_latest_rev,  " + _
        '                     "ord_gen_vend_net_date, ord_gen_forecast_date, ord_gen_forecast_status_date, ord_gen_forecast_updated, ord_gen_forecast_updatedby, ord_gen_forecast_note,  " + _
        '                     "ord_gen_forecast_next_contact, ord_gen_forecast_perc, ord_gen_resp_rep, ord_gen_current_osr, ord_gen_co_isr, ord_gen_co_isruser, ord_gen_co_isrdate,  " + _
        '                     "ord_gen_co_desreq, ord_gen_co_designer, ord_gen_co_desuser, ord_gen_co_desdate, ord_gen_co_designer_opened, ord_gen_co_art, ord_gen_co_priority,  " + _
        '                     "ord_gen_co_toart, ord_gen_co_emailsent, ord_gen_co_ca, ord_gen_co_causer, ord_gen_co_cadate, ord_gen_co_factoryinstall_req, ord_gen_co_factoryinstall,  " + _
        '                     "ord_gen_co_factoryinstall_user, ord_gen_co_factoryinstall_date, ord_gen_toship, ord_gen_toshipvia, ord_gen_ship_roundoff, ord_gen_des_type,  " + _
        '                     "ord_gen_des_type_auto, ord_gen_cur_sales_cat, ord_gen_ref_fee, ord_gen_ref_paid, ord_gen_alt_ship, ord_gen_tax_override, ord_gen_tax_override_perc,  " + _
        '                     "ord_gen_alt_taxrate, ord_gen_alt_taxinstalls, ord_gen_comm_disc, ord_gen_acct_closed, ord_gen_acct_total, ord_gen_acct_lock, ord_gen_bottles,  " + _
        '                     "ord_gen_bom_import, ord_gen_terr, ord_gen_def_stain_serial, ord_gen_def_finish_serial, ord_gen_def_lacquer, ord_gen_cust_with_terms,  " + _
        '                     "ord_gen_cust_with_terms_ship, ord_gen_temp, ord_gen_ship_active, ord_gen_from_quote, ord_gen_ship_white_glove_override, ord_gen_ship_overnite_override,  " + _
        '                     "ord_gen_cust_order, ord_gen_tab_title, ord_gen_tax_ship_perc, ord_gen_upsell_sqft, ord_gen_ship_cust_id, ord_gen_ship_name, ord_gen_ship_company,  " + _
        '                     "ord_gen_ship_country, @strt as ord_gen_ship_addr1, ord_gen_ship_addr2, ord_gen_ship_addr3, @cty as ord_gen_ship_city, @state as ord_gen_ship_state, @cnty as ord_gen_ship_county,  " + _
        '                     "ord_gen_ship_province, @zip as ord_gen_ship_zip, ord_gen_ship_phone1, ord_gen_ship_phone2, ord_gen_ship_fax, ord_gen_ship_alt_phone, ord_gen_ship_cell,  " + _
        '                     "ord_gen_ship_email, ord_gen_cust_taxrate, ord_gen_tax_exempt, @TAXEXEMPT as ord_gen_tax_exempt_no, ord_gen_tax_exempt_addr, ord_gen_tax_installs, ord_gen_ship_hold,  " + _
        '                     "ord_gen_ship_promo_serial, ord_gen_tgwall, ord_gen_tgceiling, ord_gen_circles, ord_gen_current_region, ord_gen_addon, ord_gen_addon_noemail,  " + _
        '                     "ord_gen_shiptotype, ord_gen_signoff_note, ord_gen_moldings, ord_gen_ship_notify, ord_gen_priority_note, ord_gen_des_status, ord_gen_writeup_email_sent,  " + _
        '                     "ord_gen_rack_height, ord_gen_install_dt, ord_gen_installer, ord_gen_install_note, ord_gen_prop_stage, ord_gen_pc_date, ord_gen_pc_days, ord_gen_pc_notes,  " + _
        '                     "ord_gen_pc_date_last, ord_gen_pc_report, ord_gen_cust_tot, ord_gen_stain_tot, ord_gen_ok_to_bill_early, ord_gen_pca_signoffsent, ord_gen_pca_signoffsent_by,  " + _
        '                     "ord_gen_pca_signoffsent_date, ord_gen_pca_signoffrec, ord_gen_pca_signoffrec_by, ord_gen_pca_signoffrec_date, ord_gen_web_order, ord_gen_diag_note,  " + _
        '                     "ord_gen_ccsrc, ord_gen_def_lacq3, ord_gen_start_design, ord_gen_design_required, ord_gen_print_downstairs, ord_gen_print_downstairs_by,  " + _
        '                     "ord_gen_field_consultant, ord_gen_start_checking, ord_gen_field_consult_type, ord_gen_designer_grade " + _
        '                     "FROM            ord_gen WHERE        ord_gen_ord_serial = 257519 and ord_gen_rev = 1 and ord_gen_type='O' "
        '         cmdtest.ExecuteNonQuery()
        '         cmdtest.CommandText = "select @@IDENTITY as jid"
        '         Dim ordGENserial = cmdtest.ExecuteScalar

        '         cmdtest.CommandText = "INSERT INTO ord_gen (" + _
        ' "ord_gen_ord_serial, ord_gen_rev, ord_gen_type, ord_gen_inside, ord_gen_outside, ord_gen_floating, ord_gen_designer, ord_gen_show_date, " + _
        '                 "ord_gen_create_date, ord_gen_create_by, ord_gen_update_date, ord_gen_update_by, ord_gen_notes, ord_gen_total, ord_gen_line_total, ord_gen_balance,  " + _
        '                 "ord_gen_ship, ord_gen_tax, ord_gen_ship_extra, ord_gen_ship_disc, ord_gen_def_fin, ord_gen_status, ord_gen_status2, ord_gen_ship_inside,  " + _
        '                 "ord_gen_ship_gated, ord_gen_ship_smalltruck, ord_gen_ship_call, ord_gen_ship_callname, ord_gen_ship_callphone, ord_gen_ship_twoman,  " + _
        '                 "ord_gen_ship_liftgate, ord_gen_ship_steps, ord_gen_ship_numsteps, ord_gen_ship_turns, ord_gen_ship_numturns, ord_gen_ship_thirdparty,  " + _
        '                 "ord_gen_ship_thirdpartyname, ord_gen_ship_thirdpartyshipvia, ord_gen_ship_thirdpartyacct, ord_gen_ship_alert, ord_gen_ship_overnite, ord_gen_ship_skids,  " + _
        '                 "ord_gen_ship_numskids, ord_gen_ship_intlship, ord_gen_ship_collect, ord_gen_ship_cust_pickup, ord_gen_ship_white_glove, ord_gen_billed, ord_gen_billdate,  " + _
        '                 "ord_gen_cust_po, ord_gen_material, ord_gen_finish, ord_gen_from_rev, ord_gen_forecast, ord_gen_lost_reason, ord_gen_lost_date, ord_gen_ship_date,  " + _
        '                 "ord_gen_src, ord_gen_special_notes, ord_gen_ship_prepaid, ord_gen_sales_cat, ord_gen_staged_date, ord_gen_staged, ord_gen_latest_rev,  " + _
        '                 "ord_gen_vend_net_date, ord_gen_forecast_date, ord_gen_forecast_status_date, ord_gen_forecast_updated, ord_gen_forecast_updatedby, ord_gen_forecast_note,  " + _
        '                 "ord_gen_forecast_next_contact, ord_gen_forecast_perc, ord_gen_resp_rep, ord_gen_current_osr, ord_gen_co_isr, ord_gen_co_isruser, ord_gen_co_isrdate,  " + _
        '                 "ord_gen_co_desreq, ord_gen_co_designer, ord_gen_co_desuser, ord_gen_co_desdate, ord_gen_co_designer_opened, ord_gen_co_art, ord_gen_co_priority,  " + _
        '                 "ord_gen_co_toart, ord_gen_co_emailsent, ord_gen_co_ca, ord_gen_co_causer, ord_gen_co_cadate, ord_gen_co_factoryinstall_req, ord_gen_co_factoryinstall,  " + _
        '                 "ord_gen_co_factoryinstall_user, ord_gen_co_factoryinstall_date, ord_gen_toship, ord_gen_toshipvia, ord_gen_ship_roundoff, ord_gen_des_type,  " + _
        '                 "ord_gen_des_type_auto, ord_gen_cur_sales_cat, ord_gen_ref_fee, ord_gen_ref_paid, ord_gen_alt_ship, ord_gen_tax_override, ord_gen_tax_override_perc,  " + _
        '                 "ord_gen_alt_taxrate, ord_gen_alt_taxinstalls, ord_gen_comm_disc, ord_gen_acct_closed, ord_gen_acct_total, ord_gen_acct_lock, ord_gen_bottles,  " + _
        '                 "ord_gen_bom_import, ord_gen_terr, ord_gen_def_stain_serial, ord_gen_def_finish_serial, ord_gen_def_lacquer, ord_gen_cust_with_terms,  " + _
        '                 "ord_gen_cust_with_terms_ship, ord_gen_temp, ord_gen_ship_active, ord_gen_from_quote, ord_gen_ship_white_glove_override, ord_gen_ship_overnite_override,  " + _
        '                 "ord_gen_cust_order, ord_gen_tab_title, ord_gen_tax_ship_perc, ord_gen_upsell_sqft, ord_gen_ship_cust_id, ord_gen_ship_name, ord_gen_ship_company,  " + _
        '                 "ord_gen_ship_country, ord_gen_ship_addr1, ord_gen_ship_addr2, ord_gen_ship_addr3, ord_gen_ship_city, ord_gen_ship_state, ord_gen_ship_county,  " + _
        '                 "ord_gen_ship_province, ord_gen_ship_zip, ord_gen_ship_phone1, ord_gen_ship_phone2, ord_gen_ship_fax, ord_gen_ship_alt_phone, ord_gen_ship_cell,  " + _
        '                 "ord_gen_ship_email, ord_gen_cust_taxrate, ord_gen_tax_exempt, ord_gen_tax_exempt_no, ord_gen_tax_exempt_addr, ord_gen_tax_installs, ord_gen_ship_hold,  " + _
        '                 "ord_gen_ship_promo_serial, ord_gen_tgwall, ord_gen_tgceiling, ord_gen_circles, ord_gen_current_region, ord_gen_addon, ord_gen_addon_noemail,  " + _
        '                 "ord_gen_shiptotype, ord_gen_signoff_note, ord_gen_moldings, ord_gen_ship_notify, ord_gen_priority_note, ord_gen_des_status, ord_gen_writeup_email_sent,  " + _
        '                 "ord_gen_rack_height, ord_gen_install_dt, ord_gen_installer, ord_gen_install_note, ord_gen_prop_stage, ord_gen_pc_date, ord_gen_pc_days, ord_gen_pc_notes,  " + _
        '                 "ord_gen_pc_date_last, ord_gen_pc_report, ord_gen_cust_tot, ord_gen_stain_tot, ord_gen_ok_to_bill_early, ord_gen_pca_signoffsent, ord_gen_pca_signoffsent_by,  " + _
        '                 "ord_gen_pca_signoffsent_date, ord_gen_pca_signoffrec, ord_gen_pca_signoffrec_by, ord_gen_pca_signoffrec_date, ord_gen_web_order, ord_gen_diag_note,  " + _
        '                 "ord_gen_ccsrc, ord_gen_def_lacq3, ord_gen_start_design, ord_gen_design_required, ord_gen_print_downstairs, ord_gen_print_downstairs_by,  " + _
        '                 "ord_gen_field_consultant, ord_gen_start_checking, ord_gen_field_consult_type, ord_gen_designer_grade " + _
        '") select " + _
        '     "@serial as ord_gen_ord_serial, 0, ord_gen_type, ord_gen_inside, ord_gen_outside, ord_gen_floating, ord_gen_designer, ord_gen_show_date, " + _
        '                     "ord_gen_create_date, ord_gen_create_by, ord_gen_update_date, ord_gen_update_by, ord_gen_notes, ord_gen_total, ord_gen_line_total, 0,  " + _
        '                     "ord_gen_ship, ord_gen_tax, ord_gen_ship_extra, ord_gen_ship_disc, ord_gen_def_fin, ord_gen_status, ord_gen_status2, ord_gen_ship_inside,  " + _
        '                     "ord_gen_ship_gated, ord_gen_ship_smalltruck, ord_gen_ship_call, ord_gen_ship_callname, ord_gen_ship_callphone, ord_gen_ship_twoman,  " + _
        '                     "ord_gen_ship_liftgate, ord_gen_ship_steps, ord_gen_ship_numsteps, ord_gen_ship_turns, ord_gen_ship_numturns, ord_gen_ship_thirdparty,  " + _
        '                     "ord_gen_ship_thirdpartyname, ord_gen_ship_thirdpartyshipvia, ord_gen_ship_thirdpartyacct, ord_gen_ship_alert, ord_gen_ship_overnite, ord_gen_ship_skids,  " + _
        '                     "ord_gen_ship_numskids, ord_gen_ship_intlship, ord_gen_ship_collect, ord_gen_ship_cust_pickup, ord_gen_ship_white_glove, ord_gen_billed, ord_gen_billdate,  " + _
        '                     "ord_gen_cust_po, ord_gen_material, ord_gen_finish, ord_gen_from_rev, ord_gen_forecast, ord_gen_lost_reason, ord_gen_lost_date, ord_gen_ship_date,  " + _
        '                     "ord_gen_src, ord_gen_special_notes, ord_gen_ship_prepaid, ord_gen_sales_cat, ord_gen_staged_date, ord_gen_staged, ord_gen_latest_rev,  " + _
        '                     "ord_gen_vend_net_date, ord_gen_forecast_date, ord_gen_forecast_status_date, ord_gen_forecast_updated, ord_gen_forecast_updatedby, ord_gen_forecast_note,  " + _
        '                     "ord_gen_forecast_next_contact, ord_gen_forecast_perc, ord_gen_resp_rep, ord_gen_current_osr, ord_gen_co_isr, ord_gen_co_isruser, ord_gen_co_isrdate,  " + _
        '                     "ord_gen_co_desreq, ord_gen_co_designer, ord_gen_co_desuser, ord_gen_co_desdate, ord_gen_co_designer_opened, ord_gen_co_art, ord_gen_co_priority,  " + _
        '                     "ord_gen_co_toart, ord_gen_co_emailsent, ord_gen_co_ca, ord_gen_co_causer, ord_gen_co_cadate, ord_gen_co_factoryinstall_req, ord_gen_co_factoryinstall,  " + _
        '                     "ord_gen_co_factoryinstall_user, ord_gen_co_factoryinstall_date, ord_gen_toship, ord_gen_toshipvia, ord_gen_ship_roundoff, ord_gen_des_type,  " + _
        '                     "ord_gen_des_type_auto, ord_gen_cur_sales_cat, ord_gen_ref_fee, ord_gen_ref_paid, ord_gen_alt_ship, ord_gen_tax_override, ord_gen_tax_override_perc,  " + _
        '                     "ord_gen_alt_taxrate, ord_gen_alt_taxinstalls, ord_gen_comm_disc, ord_gen_acct_closed, ord_gen_acct_total, ord_gen_acct_lock, ord_gen_bottles,  " + _
        '                     "ord_gen_bom_import, ord_gen_terr, ord_gen_def_stain_serial, ord_gen_def_finish_serial, ord_gen_def_lacquer, ord_gen_cust_with_terms,  " + _
        '                     "ord_gen_cust_with_terms_ship, ord_gen_temp, ord_gen_ship_active, ord_gen_from_quote, ord_gen_ship_white_glove_override, ord_gen_ship_overnite_override,  " + _
        '                     "ord_gen_cust_order, ord_gen_tab_title, ord_gen_tax_ship_perc, ord_gen_upsell_sqft, ord_gen_ship_cust_id, ord_gen_ship_name, ord_gen_ship_company,  " + _
        '                     "ord_gen_ship_country, @strt as ord_gen_ship_addr1, ord_gen_ship_addr2, ord_gen_ship_addr3, @cty as ord_gen_ship_city, @state as ord_gen_ship_state, @cnty as ord_gen_ship_county,  " + _
        '                     "ord_gen_ship_province, @zip as ord_gen_ship_zip, ord_gen_ship_phone1, ord_gen_ship_phone2, ord_gen_ship_fax, ord_gen_ship_alt_phone, ord_gen_ship_cell,  " + _
        '                     "ord_gen_ship_email, ord_gen_cust_taxrate, ord_gen_tax_exempt, @TAXEXEMPT as ord_gen_tax_exempt_no, ord_gen_tax_exempt_addr, ord_gen_tax_installs, ord_gen_ship_hold,  " + _
        '                     "ord_gen_ship_promo_serial, ord_gen_tgwall, ord_gen_tgceiling, ord_gen_circles, ord_gen_current_region, ord_gen_addon, ord_gen_addon_noemail,  " + _
        '                     "ord_gen_shiptotype, ord_gen_signoff_note, ord_gen_moldings, ord_gen_ship_notify, ord_gen_priority_note, ord_gen_des_status, ord_gen_writeup_email_sent,  " + _
        '                     "ord_gen_rack_height, ord_gen_install_dt, ord_gen_installer, ord_gen_install_note, ord_gen_prop_stage, ord_gen_pc_date, ord_gen_pc_days, ord_gen_pc_notes,  " + _
        '                     "ord_gen_pc_date_last, ord_gen_pc_report, ord_gen_cust_tot, ord_gen_stain_tot, ord_gen_ok_to_bill_early, ord_gen_pca_signoffsent, ord_gen_pca_signoffsent_by,  " + _
        '                     "ord_gen_pca_signoffsent_date, ord_gen_pca_signoffrec, ord_gen_pca_signoffrec_by, ord_gen_pca_signoffrec_date, ord_gen_web_order, ord_gen_diag_note,  " + _
        '                     "ord_gen_ccsrc, ord_gen_def_lacq3, ord_gen_start_design, ord_gen_design_required, ord_gen_print_downstairs, ord_gen_print_downstairs_by,  " + _
        '                     "ord_gen_field_consultant, ord_gen_start_checking, ord_gen_field_consult_type, ord_gen_designer_grade " + _
        '                 "FROM            ord_gen WHERE        ord_gen_ord_serial = 257519 and ord_gen_rev = 1 and ord_gen_type='Q' "
        '         cmdtest.ExecuteNonQuery()



        '         cmdtest.CommandText = "INSERT INTO ord_itm (" + _
        '          "ord_itm_ord_serial, ord_itm_rev, ord_itm_type, ord_itm_line, ord_itm_item_code, ord_itm_desc, ord_itm_qty, ord_itm_unt_sell, ord_itm_unt_ship, " + _
        '                      "ord_itm_unt_base, ord_itm_mpf, ord_itm_markup, ord_itm_disc_perc, ord_itm_disc, ord_itm_base_price, ord_itm_taxable, ord_itm_fixture, ord_itm_sel_material,  " + _
        '                      "ord_itm_price_method, ord_itm_mat_code, ord_itm_fin_code, ord_itm_shipped, ord_itm_prod_type, ord_itm_from_ord_itm_serial, ord_itm_forecast_overide,  " + _
        '                      "ord_itm_order_id, ord_itm_note, ord_itm_mat_color, ord_itm_up_color, ord_itm_disc_type, ord_itm_disc_val, ord_itm_disc_amt, ord_itm_is_disc, ord_itm_is_up,  " + _
        '                      "ord_itm_disc_prod, ord_itm_disc_matl, ord_itm_is_perc_price, ord_itm_perc_price, ord_itm_perc_prodtypes, ord_itm_perc_itemcodes, ord_itm_user,  " + _
        '                      "ord_itm_updated, ord_itm_margin_factor, ord_itm_change_base, ord_itm_stain_bottles, ord_itm_lacq_bottles, ord_itm_bottle_search, ord_itm_wood_factor,  " + _
        '                      "ord_itm_ship_flat, ord_itm_bom_import, ord_itm_created, ord_itm_created_by, ord_itm_acct_lock, ord_itm_acct_total, ord_itm_stain_serial, ord_itm_finish_serial,  " + _
        '                      "ord_itm_lacquer_old, ord_itm_stain_bottles_add, ord_itm_lacq_bottles_add, ord_itm_ship_value, ord_itm_group, ord_itm_group_do, ord_itm_width, ord_itm_height,  " + _
        '                      "ord_itm_depth, ord_itm_width_req, ord_itm_height_req, ord_itm_depth_req, ord_itm_wizard_serial, ord_itm_install_min, ord_itm_install_use, ord_itm_class,  " + _
        '                      "ord_itm_price_track_inches, ord_itm_lacq3, ord_itm_retail " + _
        '                      ") select " + _
        '                                  "@serial as ord_itm_ord_serial, 0, ord_itm_type, ord_itm_line, ord_itm_item_code, ord_itm_desc, ord_itm_qty, ord_itm_unt_sell, ord_itm_unt_ship, " + _
        '                      "ord_itm_unt_base, ord_itm_mpf, ord_itm_markup, ord_itm_disc_perc, ord_itm_disc, ord_itm_base_price, ord_itm_taxable, ord_itm_fixture, ord_itm_sel_material,  " + _
        '                      "ord_itm_price_method, ord_itm_mat_code, ord_itm_fin_code, ord_itm_shipped, ord_itm_prod_type, ord_itm_from_ord_itm_serial, ord_itm_forecast_overide,  " + _
        '                      "ord_itm_order_id, ord_itm_note, ord_itm_mat_color, ord_itm_up_color, ord_itm_disc_type, ord_itm_disc_val, ord_itm_disc_amt, ord_itm_is_disc, ord_itm_is_up,  " + _
        '                      "ord_itm_disc_prod, ord_itm_disc_matl, ord_itm_is_perc_price, ord_itm_perc_price, ord_itm_perc_prodtypes, ord_itm_perc_itemcodes, ord_itm_user,  " + _
        '                      "ord_itm_updated, ord_itm_margin_factor, ord_itm_change_base, ord_itm_stain_bottles, ord_itm_lacq_bottles, ord_itm_bottle_search, ord_itm_wood_factor,  " + _
        '                      "ord_itm_ship_flat, ord_itm_bom_import, ord_itm_created, ord_itm_created_by, ord_itm_acct_lock, ord_itm_acct_total, ord_itm_stain_serial, ord_itm_finish_serial,  " + _
        '                      "ord_itm_lacquer_old, ord_itm_stain_bottles_add, ord_itm_lacq_bottles_add, ord_itm_ship_value, ord_itm_group, ord_itm_group_do, ord_itm_width, ord_itm_height,  " + _
        '                      "ord_itm_depth, ord_itm_width_req, ord_itm_height_req, ord_itm_depth_req, ord_itm_wizard_serial, ord_itm_install_min, ord_itm_install_use, ord_itm_class,  " + _
        '                      "ord_itm_price_track_inches, ord_itm_lacq3, ord_itm_retail " + _
        '                      "FROM            ord_itm WHERE  ord_itm_ord_serial = 257519 and ord_itm_rev = 1 and ord_itm_type='O'"
        '         cmdtest.ExecuteNonQuery()

        '         cmdtest.CommandText = "INSERT INTO ord_itm (" + _
        '       "ord_itm_ord_serial, ord_itm_rev, ord_itm_type, ord_itm_line, ord_itm_item_code, ord_itm_desc, ord_itm_qty, ord_itm_unt_sell, ord_itm_unt_ship, " + _
        '                    "ord_itm_unt_base, ord_itm_mpf, ord_itm_markup, ord_itm_disc_perc, ord_itm_disc, ord_itm_base_price, ord_itm_taxable, ord_itm_fixture, ord_itm_sel_material,  " + _
        '                    "ord_itm_price_method, ord_itm_mat_code, ord_itm_fin_code, ord_itm_shipped, ord_itm_prod_type, ord_itm_from_ord_itm_serial, ord_itm_forecast_overide,  " + _
        '                    "ord_itm_order_id, ord_itm_note, ord_itm_mat_color, ord_itm_up_color, ord_itm_disc_type, ord_itm_disc_val, ord_itm_disc_amt, ord_itm_is_disc, ord_itm_is_up,  " + _
        '                    "ord_itm_disc_prod, ord_itm_disc_matl, ord_itm_is_perc_price, ord_itm_perc_price, ord_itm_perc_prodtypes, ord_itm_perc_itemcodes, ord_itm_user,  " + _
        '                    "ord_itm_updated, ord_itm_margin_factor, ord_itm_change_base, ord_itm_stain_bottles, ord_itm_lacq_bottles, ord_itm_bottle_search, ord_itm_wood_factor,  " + _
        '                    "ord_itm_ship_flat, ord_itm_bom_import, ord_itm_created, ord_itm_created_by, ord_itm_acct_lock, ord_itm_acct_total, ord_itm_stain_serial, ord_itm_finish_serial,  " + _
        '                    "ord_itm_lacquer_old, ord_itm_stain_bottles_add, ord_itm_lacq_bottles_add, ord_itm_ship_value, ord_itm_group, ord_itm_group_do, ord_itm_width, ord_itm_height,  " + _
        '                    "ord_itm_depth, ord_itm_width_req, ord_itm_height_req, ord_itm_depth_req, ord_itm_wizard_serial, ord_itm_install_min, ord_itm_install_use, ord_itm_class,  " + _
        '                    "ord_itm_price_track_inches, ord_itm_lacq3, ord_itm_retail " + _
        '                    ") select " + _
        '                                 "@serial as ord_itm_ord_serial, 0, ord_itm_type, ord_itm_line, ord_itm_item_code, ord_itm_desc, ord_itm_qty, ord_itm_unt_sell, ord_itm_unt_ship, " + _
        '                    "ord_itm_unt_base, ord_itm_mpf, ord_itm_markup, ord_itm_disc_perc, ord_itm_disc, ord_itm_base_price, ord_itm_taxable, ord_itm_fixture, ord_itm_sel_material,  " + _
        '                    "ord_itm_price_method, ord_itm_mat_code, ord_itm_fin_code, ord_itm_shipped, ord_itm_prod_type, ord_itm_from_ord_itm_serial, ord_itm_forecast_overide,  " + _
        '                    "ord_itm_order_id, ord_itm_note, ord_itm_mat_color, ord_itm_up_color, ord_itm_disc_type, ord_itm_disc_val, ord_itm_disc_amt, ord_itm_is_disc, ord_itm_is_up,  " + _
        '                    "ord_itm_disc_prod, ord_itm_disc_matl, ord_itm_is_perc_price, ord_itm_perc_price, ord_itm_perc_prodtypes, ord_itm_perc_itemcodes, ord_itm_user,  " + _
        '                    "ord_itm_updated, ord_itm_margin_factor, ord_itm_change_base, ord_itm_stain_bottles, ord_itm_lacq_bottles, ord_itm_bottle_search, ord_itm_wood_factor,  " + _
        '                    "ord_itm_ship_flat, ord_itm_bom_import, ord_itm_created, ord_itm_created_by, ord_itm_acct_lock, ord_itm_acct_total, ord_itm_stain_serial, ord_itm_finish_serial,  " + _
        '                    "ord_itm_lacquer_old, ord_itm_stain_bottles_add, ord_itm_lacq_bottles_add, ord_itm_ship_value, ord_itm_group, ord_itm_group_do, ord_itm_width, ord_itm_height,  " + _
        '                    "ord_itm_depth, ord_itm_width_req, ord_itm_height_req, ord_itm_depth_req, ord_itm_wizard_serial, ord_itm_install_min, ord_itm_install_use, ord_itm_class,  " + _
        '                    "ord_itm_price_track_inches, ord_itm_lacq3, ord_itm_retail " + _
        '                    "FROM            ord_itm WHERE  ord_itm_ord_serial = 257519 and ord_itm_rev = 1 and ord_itm_type='Q'"
        '         cmdtest.ExecuteNonQuery()

        '         '***Production
        '         cmdtest.CommandText = "INSERT INTO ord_prod (" + _
        '                              "ord_prod_ord_serial, ord_prod_rev,ord_prod_type,ord_prod_date,ord_prod_who,ord_prod_status,ord_prod_must_ship,ord_prod_must_ship_by, " + _
        '                 "ord_prod_must_ship_note,ord_prod_committed,ord_prod_committed_by,ord_prod_committed_note,ord_prod_est_comp,ord_prod_est_comp_by,ord_prod_est_comp_note,ord_prod_art,ord_prod_art_by,  " + _
        '                 "ord_prod_art_note,ord_prod_sign_stain,ord_prod_sign_stain_by,ord_prod_sign_stain_dt,ord_prod_signoff,ord_prod_signoff_date,ord_prod_signoff_by,ord_prod_signoff_note,ord_prod_roomnotready,  " + _
        '                 "ord_prod_roomnotready_date,ord_prod_roomnotready_by,ord_prod_roomnotready_note,ord_prod_roomrevision,ord_prod_roomrevision_date,ord_prod_roomrevision_by,ord_prod_roomrevision_note,  " + _
        '                 "ord_prod_waitingsignoff,ord_prod_waitingsignoff_date,ord_prod_waitingsignoff_by,ord_prod_waitingsignoff_note,ord_prod_signoffrec,ord_prod_signoffrec_date,ord_prod_signoffrec_by,  " + _
        '                 "ord_prod_signoffrec_note,ord_prod_allclear,ord_prod_allclear_date,ord_prod_allclear_by,ord_prod_allclear_note,ord_prod_designstart,ord_prod_designstart_date,ord_prod_designstart_by,  " + _
        '                 "ord_prod_designstart_note,ord_prod_designcomplete,ord_prod_designcomplete_date,ord_prod_designcomplete_by,ord_prod_designcomplete_note,ord_prod_tofactory,ord_prod_tofactory_date,  " + _
        '                 "ord_prod_tofactory_by,ord_prod_tofactory_note,ord_prod_added_to_closed_week,ord_prod_notes_flag,ord_prod_production_note,ord_prod_kitdown,ord_prod_kitdown_date,ord_prod_kitdown_by,  " + _
        '                 "ord_prod_kitdown_note,ord_prod_cdrdown,ord_prod_cdrdown_date,ord_prod_cdrdown_by,ord_prod_cdrdown_note,ord_prod_kit_email_sent,ord_prod_factcomp,ord_prod_factcomp_date,ord_prod_factcomp_by,  " + _
        '                 "ord_prod_factcomp_note,ord_prod_estship_emailsent,ord_prod_estship_emailsent_complete,ord_prod_cellar_art,ord_prod_cellar_art_date,ord_prod_cellar_art_by,ord_prod_cellar_art_note  " + _
        '                 ") select " + _
        '                              "@serial as ord_prod_ord_serial, 0,ord_prod_type,ord_prod_date,ord_prod_who,ord_prod_status,ord_prod_must_ship,ord_prod_must_ship_by, " + _
        '                 "ord_prod_must_ship_note,ord_prod_committed,ord_prod_committed_by,ord_prod_committed_note,ord_prod_est_comp,ord_prod_est_comp_by,ord_prod_est_comp_note,ord_prod_art,ord_prod_art_by,  " + _
        '                 "ord_prod_art_note,ord_prod_sign_stain,ord_prod_sign_stain_by,ord_prod_sign_stain_dt,ord_prod_signoff,ord_prod_signoff_date,ord_prod_signoff_by,ord_prod_signoff_note,ord_prod_roomnotready,  " + _
        '                 "ord_prod_roomnotready_date,ord_prod_roomnotready_by,ord_prod_roomnotready_note,ord_prod_roomrevision,ord_prod_roomrevision_date,ord_prod_roomrevision_by,ord_prod_roomrevision_note,  " + _
        '                 "ord_prod_waitingsignoff,ord_prod_waitingsignoff_date,ord_prod_waitingsignoff_by,ord_prod_waitingsignoff_note,ord_prod_signoffrec,ord_prod_signoffrec_date,ord_prod_signoffrec_by,  " + _
        '                 "ord_prod_signoffrec_note,ord_prod_allclear,ord_prod_allclear_date,ord_prod_allclear_by,ord_prod_allclear_note,ord_prod_designstart,ord_prod_designstart_date,ord_prod_designstart_by,  " + _
        '                 "ord_prod_designstart_note,ord_prod_designcomplete,ord_prod_designcomplete_date,ord_prod_designcomplete_by,ord_prod_designcomplete_note,ord_prod_tofactory,ord_prod_tofactory_date,  " + _
        '                 "ord_prod_tofactory_by,ord_prod_tofactory_note,ord_prod_added_to_closed_week,ord_prod_notes_flag,ord_prod_production_note,ord_prod_kitdown,ord_prod_kitdown_date,ord_prod_kitdown_by,  " + _
        '                 "ord_prod_kitdown_note,ord_prod_cdrdown,ord_prod_cdrdown_date,ord_prod_cdrdown_by,ord_prod_cdrdown_note,ord_prod_kit_email_sent,ord_prod_factcomp,ord_prod_factcomp_date,ord_prod_factcomp_by,  " + _
        '                 "ord_prod_factcomp_note,ord_prod_estship_emailsent,ord_prod_estship_emailsent_complete,ord_prod_cellar_art,ord_prod_cellar_art_date,ord_prod_cellar_art_by,ord_prod_cellar_art_note  " + _
        '                 "FROM    ord_prod WHERE  ord_prod_ord_serial = 257519 and ord_prod_rev = 1 and ord_prod_type='O'"
        '         cmdtest.ExecuteNonQuery()



        '         cmdtest.Parameters.Add(New SqlParameter("@pay_num", "SEE INVOICE " + drow("ord_serial").ToString + "-0-0"))
        '         cmdtest.Parameters.Add(New SqlParameter("@pay_num2", "SEE INVOICE 257519-1-1"))
        '         cmdtest.Parameters.Add(New SqlParameter("@pay_amt", -80))
        '         cmdtest.Parameters.Add(New SqlParameter("@pay_amt2", 80))
        '         '***pay file
        '         cmdtest.CommandText = "INSERT INTO pay_file (" + _
        '                   "pay_cust_id,pay_date,pay_amt,pay_method,pay_num,pay_exp_date,pay_auth_code,Last_Update,Update_By,billing_id,pay_id,pay_applied,pay_sec_code " + _
        '                  ") select " + _
        '                  "pay_cust_id,pay_date,@pay_amt as pay_amt,pay_method,@pay_num as pay_num,pay_exp_date,pay_auth_code,Last_Update,Update_By,billing_id,pay_id,pay_applied,pay_sec_code   " + _
        '                  "FROM    pay_file WHERE  pay_serial = 290303"
        '         cmdtest.ExecuteNonQuery()
        '         cmdtest.CommandText = "select @@IDENTITY as jid"
        '         Dim LastPay = cmdtest.ExecuteScalar

        '         cmdtest.CommandText = "INSERT INTO pay_file (" + _
        '                   "pay_cust_id,pay_date,pay_amt,pay_method,pay_num,pay_exp_date,pay_auth_code,Last_Update,Update_By,billing_id,pay_id,pay_applied,pay_sec_code " + _
        '                  ") select " + _
        '                  "pay_cust_id,pay_date,@pay_amt2 as pay_amt,pay_method,@pay_num2 as pay_num,pay_exp_date,pay_auth_code,Last_Update,Update_By,billing_id,pay_id,pay_applied,pay_sec_code   " + _
        '                  "FROM    pay_file WHERE  pay_serial = 290304"
        '         cmdtest.ExecuteNonQuery()
        '         cmdtest.CommandText = "select @@IDENTITY as jid"
        '         Dim LastPay2 = cmdtest.ExecuteScalar

        '         '***pay item
        '         cmdtest.Parameters.Add(New SqlParameter("@lastpay", LastPay))
        '         cmdtest.Parameters.Add(New SqlParameter("@ordGENserial", ordGENserial))
        '         cmdtest.CommandText = "INSERT INTO pay_itm (" + _
        '                  "pay_itm_pay_serial,pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,pay_itm_amt,billing_id,pay_id,pay_itm_sent_cust " + _
        '                 ") select " + _
        '                 "@lastpay as pay_itm_pay_serial, pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,@pay_amt as pay_itm_amt,billing_id,pay_id,pay_itm_sent_cust   " + _
        '                 "FROM    pay_itm WHERE  pay_itm_serial = 699135"
        '         cmdtest.ExecuteNonQuery()

        '         cmdtest.Parameters.Add(New SqlParameter("@lastpay2", LastPay2))
        '         cmdtest.CommandText = "INSERT INTO pay_itm (" + _
        '                  "pay_itm_pay_serial,pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,pay_itm_amt,billing_id,pay_id,pay_itm_sent_cust " + _
        '                 ") select " + _
        '                 "@lastpay2 as pay_itm_pay_serial,@ordGENserial as pay_itm_ord_gen_serial,@serial as pay_itm_ord_serial,0,@pay_amt2 as pay_itm_amt,billing_id,pay_id,pay_itm_sent_cust   " + _
        '                 "FROM    pay_itm WHERE  pay_itm_serial = 699139"
        '         cmdtest.ExecuteNonQuery()

        '         cnt += 1
        '     Next
        '     '*****************************************************************************
        '     dtt.Rows.Clear()
        '     cmdtest.CommandText = "select * from z where qty=1"
        '     datest.Fill(dtt)
        '     ct = dtt.Rows.Count
        '     cmdtest.Parameters.Clear()
        '     cmdtest.Parameters.Add(New SqlParameter("@ORDFOR", "Marriott Mini Stack."))

        '     For i = 0 To (ct - 1)
        '         cmdtest.CommandText = "INSERT INTO ord_file (" + _
        '         "ord_rev, ord_amt, ord_for, ord_for2, ord_sold_cust_serial, ord_sold_cust_id, ord_sold_name, ord_sold_company, ord_sold_country, ord_sold_addr1, " + _
        '         "ord_sold_addr2, ord_sold_addr3, ord_sold_city, ord_sold_state, ord_sold_county, ord_sold_province, ord_sold_zip, ord_sold_phone1, ord_sold_phone2,  " + _
        '         "ord_sold_fax, ord_sold_alt_phone, ord_sold_cell, ord_sold_email, ord_ship_cust_serial, ord_ship_cust_id, ord_ship_name, ord_ship_company, ord_ship_country, " + _
        '         "ord_ship_addr1, ord_ship_addr2, ord_ship_addr3, ord_ship_city, ord_ship_state, ord_ship_county, ord_ship_province, ord_ship_zip, ord_ship_phone1, " + _
        '         "ord_ship_phone2, ord_ship_fax, ord_ship_alt_phone, ord_ship_cell, ord_ship_email, ord_same_as_sold, update_by, last_update, ord_sales_cat, ord_cust_taxrate, " + _
        '         "ord_tax_exempt, ord_tax_exempt_no, ord_tax_installs, ord_appl_5_perc, ord_acct_open, ord_ref_name, ord_ref_company, ord_ref_addr1, ord_ref_addr2, " + _
        '         "ord_ref_addr3, ord_ref_city, ord_ref_state, ord_ref_zip, ord_ref_perc, ord_ref_phone, ord_ref_serial, ord_ref_note, ord_temp, ord_is_split, ord_exempt_addr, " + _
        '         "ord_email_shipment, ord_email_osr_shipment, ord_cont_serial, ord_cc_random, ord_cc_open_orders" + _
        '         ") select " + _
        '          "ord_rev, ord_amt, @ORDFOR as ord_for, ord_for2, ord_sold_cust_serial, ord_sold_cust_id, ord_sold_name, ord_sold_company, ord_sold_country, ord_sold_addr1, " + _
        '         "ord_sold_addr2, ord_sold_addr3, ord_sold_city, ord_sold_state, ord_sold_county, ord_sold_province, ord_sold_zip, ord_sold_phone1, ord_sold_phone2,  " + _
        '         "ord_sold_fax, ord_sold_alt_phone, ord_sold_cell, ord_sold_email, ord_ship_cust_serial, ord_ship_cust_id, ord_ship_name, ord_ship_company, ord_ship_country, " + _
        '         "ord_ship_addr1, ord_ship_addr2, ord_ship_addr3, ord_ship_city, ord_ship_state, ord_ship_county, ord_ship_province, ord_ship_zip, ord_ship_phone1, " + _
        '         "ord_ship_phone2, ord_ship_fax, ord_ship_alt_phone, ord_ship_cell, ord_ship_email, ord_same_as_sold, update_by, last_update, ord_sales_cat, ord_cust_taxrate, " + _
        '         "ord_tax_exempt, ord_tax_exempt_no, ord_tax_installs, ord_appl_5_perc, ord_acct_open, ord_ref_name, ord_ref_company, ord_ref_addr1, ord_ref_addr2, " + _
        '         "ord_ref_addr3, ord_ref_city, ord_ref_state, ord_ref_zip, ord_ref_perc, ord_ref_phone, ord_ref_serial, ord_ref_note, ord_temp, ord_is_split, ord_exempt_addr, " + _
        '         "ord_email_shipment, ord_email_osr_shipment, ord_cont_serial, ord_cc_random, ord_cc_open_orders" + _
        '         " from ord_file where ord_serial = 256351"
        '         cmdtest.ExecuteNonQuery()
        '     Next
        '     'dts.Tables("ordfile").Rows.Clear()
        '     cmdtest.CommandText = "select * from ord_file where ord_for = 'Marriott Mini Stack.' and ord_serial<>256351 order by ord_serial"
        '     datest.Fill(dts, "ordfile2")


        '     cnt = 0
        '     For Each drow In dts.Tables("ordfile2").Rows
        '         cmdtest.Parameters.Clear()
        '         strt = dtt.Rows.Item(cnt).Item("street")
        '         cty = dtt.Rows.Item(cnt).Item("city")
        '         state = dtt.Rows.Item(cnt).Item("st")
        '         zip = dtt.Rows.Item(cnt).Item("zip")
        '         TAXEXEMPT = dtt.Rows.Item(cnt).Item("taxexempt")

        '         cmdtest.Parameters.Add(New SqlParameter("@serial", drow("ord_serial")))
        '         cmdtest.Parameters.Add(New SqlParameter("@strt", strt))
        '         cmdtest.Parameters.Add(New SqlParameter("@cty", cty))
        '         cmdtest.Parameters.Add(New SqlParameter("@state", state))
        '         cmdtest.Parameters.Add(New SqlParameter("@zip", zip))
        '         cmdtest.Parameters.Add(New SqlParameter("@cnty", cnty))
        '         cmdtest.Parameters.Add(New SqlParameter("@TAXEXEMPT", TAXEXEMPT))

        '         cmdtest.CommandText = "INSERT INTO ord_gen (" + _
        '     "ord_gen_ord_serial, ord_gen_rev, ord_gen_type, ord_gen_inside, ord_gen_outside, ord_gen_floating, ord_gen_designer, ord_gen_show_date, " + _
        '                     "ord_gen_create_date, ord_gen_create_by, ord_gen_update_date, ord_gen_update_by, ord_gen_notes, ord_gen_total, ord_gen_line_total, ord_gen_balance,  " + _
        '                     "ord_gen_ship, ord_gen_tax, ord_gen_ship_extra, ord_gen_ship_disc, ord_gen_def_fin, ord_gen_status, ord_gen_status2, ord_gen_ship_inside,  " + _
        '                     "ord_gen_ship_gated, ord_gen_ship_smalltruck, ord_gen_ship_call, ord_gen_ship_callname, ord_gen_ship_callphone, ord_gen_ship_twoman,  " + _
        '                     "ord_gen_ship_liftgate, ord_gen_ship_steps, ord_gen_ship_numsteps, ord_gen_ship_turns, ord_gen_ship_numturns, ord_gen_ship_thirdparty,  " + _
        '                     "ord_gen_ship_thirdpartyname, ord_gen_ship_thirdpartyshipvia, ord_gen_ship_thirdpartyacct, ord_gen_ship_alert, ord_gen_ship_overnite, ord_gen_ship_skids,  " + _
        '                     "ord_gen_ship_numskids, ord_gen_ship_intlship, ord_gen_ship_collect, ord_gen_ship_cust_pickup, ord_gen_ship_white_glove, ord_gen_billed, ord_gen_billdate,  " + _
        '                     "ord_gen_cust_po, ord_gen_material, ord_gen_finish, ord_gen_from_rev, ord_gen_forecast, ord_gen_lost_reason, ord_gen_lost_date, ord_gen_ship_date,  " + _
        '                     "ord_gen_src, ord_gen_special_notes, ord_gen_ship_prepaid, ord_gen_sales_cat, ord_gen_staged_date, ord_gen_staged, ord_gen_latest_rev,  " + _
        '                     "ord_gen_vend_net_date, ord_gen_forecast_date, ord_gen_forecast_status_date, ord_gen_forecast_updated, ord_gen_forecast_updatedby, ord_gen_forecast_note,  " + _
        '                     "ord_gen_forecast_next_contact, ord_gen_forecast_perc, ord_gen_resp_rep, ord_gen_current_osr, ord_gen_co_isr, ord_gen_co_isruser, ord_gen_co_isrdate,  " + _
        '                     "ord_gen_co_desreq, ord_gen_co_designer, ord_gen_co_desuser, ord_gen_co_desdate, ord_gen_co_designer_opened, ord_gen_co_art, ord_gen_co_priority,  " + _
        '                     "ord_gen_co_toart, ord_gen_co_emailsent, ord_gen_co_ca, ord_gen_co_causer, ord_gen_co_cadate, ord_gen_co_factoryinstall_req, ord_gen_co_factoryinstall,  " + _
        '                     "ord_gen_co_factoryinstall_user, ord_gen_co_factoryinstall_date, ord_gen_toship, ord_gen_toshipvia, ord_gen_ship_roundoff, ord_gen_des_type,  " + _
        '                     "ord_gen_des_type_auto, ord_gen_cur_sales_cat, ord_gen_ref_fee, ord_gen_ref_paid, ord_gen_alt_ship, ord_gen_tax_override, ord_gen_tax_override_perc,  " + _
        '                     "ord_gen_alt_taxrate, ord_gen_alt_taxinstalls, ord_gen_comm_disc, ord_gen_acct_closed, ord_gen_acct_total, ord_gen_acct_lock, ord_gen_bottles,  " + _
        '                     "ord_gen_bom_import, ord_gen_terr, ord_gen_def_stain_serial, ord_gen_def_finish_serial, ord_gen_def_lacquer, ord_gen_cust_with_terms,  " + _
        '                     "ord_gen_cust_with_terms_ship, ord_gen_temp, ord_gen_ship_active, ord_gen_from_quote, ord_gen_ship_white_glove_override, ord_gen_ship_overnite_override,  " + _
        '                     "ord_gen_cust_order, ord_gen_tab_title, ord_gen_tax_ship_perc, ord_gen_upsell_sqft, ord_gen_ship_cust_id, ord_gen_ship_name, ord_gen_ship_company,  " + _
        '                     "ord_gen_ship_country, ord_gen_ship_addr1, ord_gen_ship_addr2, ord_gen_ship_addr3, ord_gen_ship_city, ord_gen_ship_state, ord_gen_ship_county,  " + _
        '                     "ord_gen_ship_province, ord_gen_ship_zip, ord_gen_ship_phone1, ord_gen_ship_phone2, ord_gen_ship_fax, ord_gen_ship_alt_phone, ord_gen_ship_cell,  " + _
        '                     "ord_gen_ship_email, ord_gen_cust_taxrate, ord_gen_tax_exempt, ord_gen_tax_exempt_no, ord_gen_tax_exempt_addr, ord_gen_tax_installs, ord_gen_ship_hold,  " + _
        '                     "ord_gen_ship_promo_serial, ord_gen_tgwall, ord_gen_tgceiling, ord_gen_circles, ord_gen_current_region, ord_gen_addon, ord_gen_addon_noemail,  " + _
        '                     "ord_gen_shiptotype, ord_gen_signoff_note, ord_gen_moldings, ord_gen_ship_notify, ord_gen_priority_note, ord_gen_des_status, ord_gen_writeup_email_sent,  " + _
        '                     "ord_gen_rack_height, ord_gen_install_dt, ord_gen_installer, ord_gen_install_note, ord_gen_prop_stage, ord_gen_pc_date, ord_gen_pc_days, ord_gen_pc_notes,  " + _
        '                     "ord_gen_pc_date_last, ord_gen_pc_report, ord_gen_cust_tot, ord_gen_stain_tot, ord_gen_ok_to_bill_early, ord_gen_pca_signoffsent, ord_gen_pca_signoffsent_by,  " + _
        '                     "ord_gen_pca_signoffsent_date, ord_gen_pca_signoffrec, ord_gen_pca_signoffrec_by, ord_gen_pca_signoffrec_date, ord_gen_web_order, ord_gen_diag_note,  " + _
        '                     "ord_gen_ccsrc, ord_gen_def_lacq3, ord_gen_start_design, ord_gen_design_required, ord_gen_print_downstairs, ord_gen_print_downstairs_by,  " + _
        '                     "ord_gen_field_consultant, ord_gen_start_checking, ord_gen_field_consult_type, ord_gen_designer_grade " + _
        '    ") select " + _
        '      "@serial as ord_gen_ord_serial, 0, ord_gen_type, ord_gen_inside, ord_gen_outside, ord_gen_floating, ord_gen_designer, ord_gen_show_date, " + _
        '                     "ord_gen_create_date, ord_gen_create_by, ord_gen_update_date, ord_gen_update_by, ord_gen_notes, ord_gen_total, ord_gen_line_total, 0,  " + _
        '                     "ord_gen_ship, ord_gen_tax, ord_gen_ship_extra, ord_gen_ship_disc, ord_gen_def_fin, ord_gen_status, ord_gen_status2, ord_gen_ship_inside,  " + _
        '                     "ord_gen_ship_gated, ord_gen_ship_smalltruck, ord_gen_ship_call, ord_gen_ship_callname, ord_gen_ship_callphone, ord_gen_ship_twoman,  " + _
        '                     "ord_gen_ship_liftgate, ord_gen_ship_steps, ord_gen_ship_numsteps, ord_gen_ship_turns, ord_gen_ship_numturns, ord_gen_ship_thirdparty,  " + _
        '                     "ord_gen_ship_thirdpartyname, ord_gen_ship_thirdpartyshipvia, ord_gen_ship_thirdpartyacct, ord_gen_ship_alert, ord_gen_ship_overnite, ord_gen_ship_skids,  " + _
        '                     "ord_gen_ship_numskids, ord_gen_ship_intlship, ord_gen_ship_collect, ord_gen_ship_cust_pickup, ord_gen_ship_white_glove, ord_gen_billed, ord_gen_billdate,  " + _
        '                     "ord_gen_cust_po, ord_gen_material, ord_gen_finish, 0, ord_gen_forecast, ord_gen_lost_reason, ord_gen_lost_date, ord_gen_ship_date,  " + _
        '                     "ord_gen_src, ord_gen_special_notes, ord_gen_ship_prepaid, ord_gen_sales_cat, ord_gen_staged_date, ord_gen_staged, ord_gen_latest_rev,  " + _
        '                     "ord_gen_vend_net_date, ord_gen_forecast_date, ord_gen_forecast_status_date, ord_gen_forecast_updated, ord_gen_forecast_updatedby, ord_gen_forecast_note,  " + _
        '                     "ord_gen_forecast_next_contact, ord_gen_forecast_perc, ord_gen_resp_rep, ord_gen_current_osr, ord_gen_co_isr, ord_gen_co_isruser, ord_gen_co_isrdate,  " + _
        '                     "ord_gen_co_desreq, ord_gen_co_designer, ord_gen_co_desuser, ord_gen_co_desdate, ord_gen_co_designer_opened, ord_gen_co_art, ord_gen_co_priority,  " + _
        '                     "ord_gen_co_toart, ord_gen_co_emailsent, ord_gen_co_ca, ord_gen_co_causer, ord_gen_co_cadate, ord_gen_co_factoryinstall_req, ord_gen_co_factoryinstall,  " + _
        '                     "ord_gen_co_factoryinstall_user, ord_gen_co_factoryinstall_date, ord_gen_toship, ord_gen_toshipvia, ord_gen_ship_roundoff, ord_gen_des_type,  " + _
        '                     "ord_gen_des_type_auto, ord_gen_cur_sales_cat, ord_gen_ref_fee, ord_gen_ref_paid, ord_gen_alt_ship, ord_gen_tax_override, ord_gen_tax_override_perc,  " + _
        '                     "ord_gen_alt_taxrate, ord_gen_alt_taxinstalls, ord_gen_comm_disc, ord_gen_acct_closed, ord_gen_acct_total, ord_gen_acct_lock, ord_gen_bottles,  " + _
        '                     "ord_gen_bom_import, ord_gen_terr, ord_gen_def_stain_serial, ord_gen_def_finish_serial, ord_gen_def_lacquer, ord_gen_cust_with_terms,  " + _
        '                     "ord_gen_cust_with_terms_ship, ord_gen_temp, ord_gen_ship_active, ord_gen_from_quote, ord_gen_ship_white_glove_override, ord_gen_ship_overnite_override,  " + _
        '                     "ord_gen_cust_order, ord_gen_tab_title, ord_gen_tax_ship_perc, ord_gen_upsell_sqft, ord_gen_ship_cust_id, ord_gen_ship_name, ord_gen_ship_company,  " + _
        '                     "ord_gen_ship_country, @strt as ord_gen_ship_addr1, ord_gen_ship_addr2, ord_gen_ship_addr3, @cty as ord_gen_ship_city, @state as ord_gen_ship_state, @cnty as ord_gen_ship_county,  " + _
        '                     "ord_gen_ship_province, @zip as ord_gen_ship_zip, ord_gen_ship_phone1, ord_gen_ship_phone2, ord_gen_ship_fax, ord_gen_ship_alt_phone, ord_gen_ship_cell,  " + _
        '                     "ord_gen_ship_email, ord_gen_cust_taxrate, ord_gen_tax_exempt,  @TAXEXEMPT as ord_gen_tax_exempt_no, ord_gen_tax_exempt_addr, ord_gen_tax_installs, ord_gen_ship_hold,  " + _
        '                     "ord_gen_ship_promo_serial, ord_gen_tgwall, ord_gen_tgceiling, ord_gen_circles, ord_gen_current_region, ord_gen_addon, ord_gen_addon_noemail,  " + _
        '                     "ord_gen_shiptotype, ord_gen_signoff_note, ord_gen_moldings, ord_gen_ship_notify, ord_gen_priority_note, ord_gen_des_status, ord_gen_writeup_email_sent,  " + _
        '                     "ord_gen_rack_height, ord_gen_install_dt, ord_gen_installer, ord_gen_install_note, ord_gen_prop_stage, ord_gen_pc_date, ord_gen_pc_days, ord_gen_pc_notes,  " + _
        '                     "ord_gen_pc_date_last, ord_gen_pc_report, ord_gen_cust_tot, ord_gen_stain_tot, ord_gen_ok_to_bill_early, ord_gen_pca_signoffsent, ord_gen_pca_signoffsent_by,  " + _
        '                     "ord_gen_pca_signoffsent_date, ord_gen_pca_signoffrec, ord_gen_pca_signoffrec_by, ord_gen_pca_signoffrec_date, ord_gen_web_order, ord_gen_diag_note,  " + _
        '                     "ord_gen_ccsrc, ord_gen_def_lacq3, ord_gen_start_design, ord_gen_design_required, ord_gen_print_downstairs, ord_gen_print_downstairs_by,  " + _
        '                     "ord_gen_field_consultant, ord_gen_start_checking, ord_gen_field_consult_type, ord_gen_designer_grade " + _
        '                     "FROM            ord_gen WHERE        ord_gen_ord_serial = 256351 and ord_gen_rev = 3 and ord_gen_type='O' "
        '         cmdtest.ExecuteNonQuery()
        '         cmdtest.CommandText = "select @@IDENTITY as jid"
        '         Dim ordGENserial = cmdtest.ExecuteScalar

        '         cmdtest.CommandText = "INSERT INTO ord_gen (" + _
        ' "ord_gen_ord_serial, ord_gen_rev, ord_gen_type, ord_gen_inside, ord_gen_outside, ord_gen_floating, ord_gen_designer, ord_gen_show_date, " + _
        '                 "ord_gen_create_date, ord_gen_create_by, ord_gen_update_date, ord_gen_update_by, ord_gen_notes, ord_gen_total, ord_gen_line_total, ord_gen_balance,  " + _
        '                 "ord_gen_ship, ord_gen_tax, ord_gen_ship_extra, ord_gen_ship_disc, ord_gen_def_fin, ord_gen_status, ord_gen_status2, ord_gen_ship_inside,  " + _
        '                 "ord_gen_ship_gated, ord_gen_ship_smalltruck, ord_gen_ship_call, ord_gen_ship_callname, ord_gen_ship_callphone, ord_gen_ship_twoman,  " + _
        '                 "ord_gen_ship_liftgate, ord_gen_ship_steps, ord_gen_ship_numsteps, ord_gen_ship_turns, ord_gen_ship_numturns, ord_gen_ship_thirdparty,  " + _
        '                 "ord_gen_ship_thirdpartyname, ord_gen_ship_thirdpartyshipvia, ord_gen_ship_thirdpartyacct, ord_gen_ship_alert, ord_gen_ship_overnite, ord_gen_ship_skids,  " + _
        '                 "ord_gen_ship_numskids, ord_gen_ship_intlship, ord_gen_ship_collect, ord_gen_ship_cust_pickup, ord_gen_ship_white_glove, ord_gen_billed, ord_gen_billdate,  " + _
        '                 "ord_gen_cust_po, ord_gen_material, ord_gen_finish, ord_gen_from_rev, ord_gen_forecast, ord_gen_lost_reason, ord_gen_lost_date, ord_gen_ship_date,  " + _
        '                 "ord_gen_src, ord_gen_special_notes, ord_gen_ship_prepaid, ord_gen_sales_cat, ord_gen_staged_date, ord_gen_staged, ord_gen_latest_rev,  " + _
        '                 "ord_gen_vend_net_date, ord_gen_forecast_date, ord_gen_forecast_status_date, ord_gen_forecast_updated, ord_gen_forecast_updatedby, ord_gen_forecast_note,  " + _
        '                 "ord_gen_forecast_next_contact, ord_gen_forecast_perc, ord_gen_resp_rep, ord_gen_current_osr, ord_gen_co_isr, ord_gen_co_isruser, ord_gen_co_isrdate,  " + _
        '                 "ord_gen_co_desreq, ord_gen_co_designer, ord_gen_co_desuser, ord_gen_co_desdate, ord_gen_co_designer_opened, ord_gen_co_art, ord_gen_co_priority,  " + _
        '                 "ord_gen_co_toart, ord_gen_co_emailsent, ord_gen_co_ca, ord_gen_co_causer, ord_gen_co_cadate, ord_gen_co_factoryinstall_req, ord_gen_co_factoryinstall,  " + _
        '                 "ord_gen_co_factoryinstall_user, ord_gen_co_factoryinstall_date, ord_gen_toship, ord_gen_toshipvia, ord_gen_ship_roundoff, ord_gen_des_type,  " + _
        '                 "ord_gen_des_type_auto, ord_gen_cur_sales_cat, ord_gen_ref_fee, ord_gen_ref_paid, ord_gen_alt_ship, ord_gen_tax_override, ord_gen_tax_override_perc,  " + _
        '                 "ord_gen_alt_taxrate, ord_gen_alt_taxinstalls, ord_gen_comm_disc, ord_gen_acct_closed, ord_gen_acct_total, ord_gen_acct_lock, ord_gen_bottles,  " + _
        '                 "ord_gen_bom_import, ord_gen_terr, ord_gen_def_stain_serial, ord_gen_def_finish_serial, ord_gen_def_lacquer, ord_gen_cust_with_terms,  " + _
        '                 "ord_gen_cust_with_terms_ship, ord_gen_temp, ord_gen_ship_active, ord_gen_from_quote, ord_gen_ship_white_glove_override, ord_gen_ship_overnite_override,  " + _
        '                 "ord_gen_cust_order, ord_gen_tab_title, ord_gen_tax_ship_perc, ord_gen_upsell_sqft, ord_gen_ship_cust_id, ord_gen_ship_name, ord_gen_ship_company,  " + _
        '                 "ord_gen_ship_country, ord_gen_ship_addr1, ord_gen_ship_addr2, ord_gen_ship_addr3, ord_gen_ship_city, ord_gen_ship_state, ord_gen_ship_county,  " + _
        '                 "ord_gen_ship_province, ord_gen_ship_zip, ord_gen_ship_phone1, ord_gen_ship_phone2, ord_gen_ship_fax, ord_gen_ship_alt_phone, ord_gen_ship_cell,  " + _
        '                 "ord_gen_ship_email, ord_gen_cust_taxrate, ord_gen_tax_exempt, ord_gen_tax_exempt_no, ord_gen_tax_exempt_addr, ord_gen_tax_installs, ord_gen_ship_hold,  " + _
        '                 "ord_gen_ship_promo_serial, ord_gen_tgwall, ord_gen_tgceiling, ord_gen_circles, ord_gen_current_region, ord_gen_addon, ord_gen_addon_noemail,  " + _
        '                 "ord_gen_shiptotype, ord_gen_signoff_note, ord_gen_moldings, ord_gen_ship_notify, ord_gen_priority_note, ord_gen_des_status, ord_gen_writeup_email_sent,  " + _
        '                 "ord_gen_rack_height, ord_gen_install_dt, ord_gen_installer, ord_gen_install_note, ord_gen_prop_stage, ord_gen_pc_date, ord_gen_pc_days, ord_gen_pc_notes,  " + _
        '                 "ord_gen_pc_date_last, ord_gen_pc_report, ord_gen_cust_tot, ord_gen_stain_tot, ord_gen_ok_to_bill_early, ord_gen_pca_signoffsent, ord_gen_pca_signoffsent_by,  " + _
        '                 "ord_gen_pca_signoffsent_date, ord_gen_pca_signoffrec, ord_gen_pca_signoffrec_by, ord_gen_pca_signoffrec_date, ord_gen_web_order, ord_gen_diag_note,  " + _
        '                 "ord_gen_ccsrc, ord_gen_def_lacq3, ord_gen_start_design, ord_gen_design_required, ord_gen_print_downstairs, ord_gen_print_downstairs_by,  " + _
        '                 "ord_gen_field_consultant, ord_gen_start_checking, ord_gen_field_consult_type, ord_gen_designer_grade " + _
        '") select " + _
        '     "@serial as ord_gen_ord_serial, 0, ord_gen_type, ord_gen_inside, ord_gen_outside, ord_gen_floating, ord_gen_designer, ord_gen_show_date, " + _
        '                     "ord_gen_create_date, ord_gen_create_by, ord_gen_update_date, ord_gen_update_by, ord_gen_notes, ord_gen_total, ord_gen_line_total, 0,  " + _
        '                     "ord_gen_ship, ord_gen_tax, ord_gen_ship_extra, ord_gen_ship_disc, ord_gen_def_fin, ord_gen_status, ord_gen_status2, ord_gen_ship_inside,  " + _
        '                     "ord_gen_ship_gated, ord_gen_ship_smalltruck, ord_gen_ship_call, ord_gen_ship_callname, ord_gen_ship_callphone, ord_gen_ship_twoman,  " + _
        '                     "ord_gen_ship_liftgate, ord_gen_ship_steps, ord_gen_ship_numsteps, ord_gen_ship_turns, ord_gen_ship_numturns, ord_gen_ship_thirdparty,  " + _
        '                     "ord_gen_ship_thirdpartyname, ord_gen_ship_thirdpartyshipvia, ord_gen_ship_thirdpartyacct, ord_gen_ship_alert, ord_gen_ship_overnite, ord_gen_ship_skids,  " + _
        '                     "ord_gen_ship_numskids, ord_gen_ship_intlship, ord_gen_ship_collect, ord_gen_ship_cust_pickup, ord_gen_ship_white_glove, ord_gen_billed, ord_gen_billdate,  " + _
        '                     "ord_gen_cust_po, ord_gen_material, ord_gen_finish, 0, ord_gen_forecast, ord_gen_lost_reason, ord_gen_lost_date, ord_gen_ship_date,  " + _
        '                     "ord_gen_src, ord_gen_special_notes, ord_gen_ship_prepaid, ord_gen_sales_cat, ord_gen_staged_date, ord_gen_staged, ord_gen_latest_rev,  " + _
        '                     "ord_gen_vend_net_date, ord_gen_forecast_date, ord_gen_forecast_status_date, ord_gen_forecast_updated, ord_gen_forecast_updatedby, ord_gen_forecast_note,  " + _
        '                     "ord_gen_forecast_next_contact, ord_gen_forecast_perc, ord_gen_resp_rep, ord_gen_current_osr, ord_gen_co_isr, ord_gen_co_isruser, ord_gen_co_isrdate,  " + _
        '                     "ord_gen_co_desreq, ord_gen_co_designer, ord_gen_co_desuser, ord_gen_co_desdate, ord_gen_co_designer_opened, ord_gen_co_art, ord_gen_co_priority,  " + _
        '                     "ord_gen_co_toart, ord_gen_co_emailsent, ord_gen_co_ca, ord_gen_co_causer, ord_gen_co_cadate, ord_gen_co_factoryinstall_req, ord_gen_co_factoryinstall,  " + _
        '                     "ord_gen_co_factoryinstall_user, ord_gen_co_factoryinstall_date, ord_gen_toship, ord_gen_toshipvia, ord_gen_ship_roundoff, ord_gen_des_type,  " + _
        '                     "ord_gen_des_type_auto, ord_gen_cur_sales_cat, ord_gen_ref_fee, ord_gen_ref_paid, ord_gen_alt_ship, ord_gen_tax_override, ord_gen_tax_override_perc,  " + _
        '                     "ord_gen_alt_taxrate, ord_gen_alt_taxinstalls, ord_gen_comm_disc, ord_gen_acct_closed, ord_gen_acct_total, ord_gen_acct_lock, ord_gen_bottles,  " + _
        '                     "ord_gen_bom_import, ord_gen_terr, ord_gen_def_stain_serial, ord_gen_def_finish_serial, ord_gen_def_lacquer, ord_gen_cust_with_terms,  " + _
        '                     "ord_gen_cust_with_terms_ship, ord_gen_temp, ord_gen_ship_active, ord_gen_from_quote, ord_gen_ship_white_glove_override, ord_gen_ship_overnite_override,  " + _
        '                     "ord_gen_cust_order, ord_gen_tab_title, ord_gen_tax_ship_perc, ord_gen_upsell_sqft, ord_gen_ship_cust_id, ord_gen_ship_name, ord_gen_ship_company,  " + _
        '                     "ord_gen_ship_country, @strt as ord_gen_ship_addr1, ord_gen_ship_addr2, ord_gen_ship_addr3, @cty as ord_gen_ship_city, @state as ord_gen_ship_state, @cnty as ord_gen_ship_county,  " + _
        '                     "ord_gen_ship_province, @zip as ord_gen_ship_zip, ord_gen_ship_phone1, ord_gen_ship_phone2, ord_gen_ship_fax, ord_gen_ship_alt_phone, ord_gen_ship_cell,  " + _
        '                     "ord_gen_ship_email, ord_gen_cust_taxrate, ord_gen_tax_exempt,  @TAXEXEMPT as ord_gen_tax_exempt_no, ord_gen_tax_exempt_addr, ord_gen_tax_installs, ord_gen_ship_hold,  " + _
        '                     "ord_gen_ship_promo_serial, ord_gen_tgwall, ord_gen_tgceiling, ord_gen_circles, ord_gen_current_region, ord_gen_addon, ord_gen_addon_noemail,  " + _
        '                     "ord_gen_shiptotype, ord_gen_signoff_note, ord_gen_moldings, ord_gen_ship_notify, ord_gen_priority_note, ord_gen_des_status, ord_gen_writeup_email_sent,  " + _
        '                     "ord_gen_rack_height, ord_gen_install_dt, ord_gen_installer, ord_gen_install_note, ord_gen_prop_stage, ord_gen_pc_date, ord_gen_pc_days, ord_gen_pc_notes,  " + _
        '                     "ord_gen_pc_date_last, ord_gen_pc_report, ord_gen_cust_tot, ord_gen_stain_tot, ord_gen_ok_to_bill_early, ord_gen_pca_signoffsent, ord_gen_pca_signoffsent_by,  " + _
        '                     "ord_gen_pca_signoffsent_date, ord_gen_pca_signoffrec, ord_gen_pca_signoffrec_by, ord_gen_pca_signoffrec_date, ord_gen_web_order, ord_gen_diag_note,  " + _
        '                     "ord_gen_ccsrc, ord_gen_def_lacq3, ord_gen_start_design, ord_gen_design_required, ord_gen_print_downstairs, ord_gen_print_downstairs_by,  " + _
        '                     "ord_gen_field_consultant, ord_gen_start_checking, ord_gen_field_consult_type, ord_gen_designer_grade " + _
        '                 "FROM            ord_gen WHERE        ord_gen_ord_serial = 256351 and ord_gen_rev = 15 and ord_gen_type='Q' "
        '         cmdtest.ExecuteNonQuery()



        '         cmdtest.CommandText = "INSERT INTO ord_itm (" + _
        '          "ord_itm_ord_serial, ord_itm_rev, ord_itm_type, ord_itm_line, ord_itm_item_code, ord_itm_desc, ord_itm_qty, ord_itm_unt_sell, ord_itm_unt_ship, " + _
        '                      "ord_itm_unt_base, ord_itm_mpf, ord_itm_markup, ord_itm_disc_perc, ord_itm_disc, ord_itm_base_price, ord_itm_taxable, ord_itm_fixture, ord_itm_sel_material,  " + _
        '                      "ord_itm_price_method, ord_itm_mat_code, ord_itm_fin_code, ord_itm_shipped, ord_itm_prod_type, ord_itm_from_ord_itm_serial, ord_itm_forecast_overide,  " + _
        '                      "ord_itm_order_id, ord_itm_note, ord_itm_mat_color, ord_itm_up_color, ord_itm_disc_type, ord_itm_disc_val, ord_itm_disc_amt, ord_itm_is_disc, ord_itm_is_up,  " + _
        '                      "ord_itm_disc_prod, ord_itm_disc_matl, ord_itm_is_perc_price, ord_itm_perc_price, ord_itm_perc_prodtypes, ord_itm_perc_itemcodes, ord_itm_user,  " + _
        '                      "ord_itm_updated, ord_itm_margin_factor, ord_itm_change_base, ord_itm_stain_bottles, ord_itm_lacq_bottles, ord_itm_bottle_search, ord_itm_wood_factor,  " + _
        '                      "ord_itm_ship_flat, ord_itm_bom_import, ord_itm_created, ord_itm_created_by, ord_itm_acct_lock, ord_itm_acct_total, ord_itm_stain_serial, ord_itm_finish_serial,  " + _
        '                      "ord_itm_lacquer_old, ord_itm_stain_bottles_add, ord_itm_lacq_bottles_add, ord_itm_ship_value, ord_itm_group, ord_itm_group_do, ord_itm_width, ord_itm_height,  " + _
        '                      "ord_itm_depth, ord_itm_width_req, ord_itm_height_req, ord_itm_depth_req, ord_itm_wizard_serial, ord_itm_install_min, ord_itm_install_use, ord_itm_class,  " + _
        '                      "ord_itm_price_track_inches, ord_itm_lacq3, ord_itm_retail " + _
        '                      ") select " + _
        '                                  "@serial as ord_itm_ord_serial, 0, ord_itm_type, ord_itm_line, ord_itm_item_code, ord_itm_desc, ord_itm_qty, ord_itm_unt_sell, ord_itm_unt_ship, " + _
        '                      "ord_itm_unt_base, ord_itm_mpf, ord_itm_markup, ord_itm_disc_perc, ord_itm_disc, ord_itm_base_price, ord_itm_taxable, ord_itm_fixture, ord_itm_sel_material,  " + _
        '                      "ord_itm_price_method, ord_itm_mat_code, ord_itm_fin_code, ord_itm_shipped, ord_itm_prod_type, ord_itm_from_ord_itm_serial, ord_itm_forecast_overide,  " + _
        '                      "ord_itm_order_id, ord_itm_note, ord_itm_mat_color, ord_itm_up_color, ord_itm_disc_type, ord_itm_disc_val, ord_itm_disc_amt, ord_itm_is_disc, ord_itm_is_up,  " + _
        '                      "ord_itm_disc_prod, ord_itm_disc_matl, ord_itm_is_perc_price, ord_itm_perc_price, ord_itm_perc_prodtypes, ord_itm_perc_itemcodes, ord_itm_user,  " + _
        '                      "ord_itm_updated, ord_itm_margin_factor, ord_itm_change_base, ord_itm_stain_bottles, ord_itm_lacq_bottles, ord_itm_bottle_search, ord_itm_wood_factor,  " + _
        '                      "ord_itm_ship_flat, ord_itm_bom_import, ord_itm_created, ord_itm_created_by, ord_itm_acct_lock, ord_itm_acct_total, ord_itm_stain_serial, ord_itm_finish_serial,  " + _
        '                      "ord_itm_lacquer_old, ord_itm_stain_bottles_add, ord_itm_lacq_bottles_add, ord_itm_ship_value, ord_itm_group, ord_itm_group_do, ord_itm_width, ord_itm_height,  " + _
        '                      "ord_itm_depth, ord_itm_width_req, ord_itm_height_req, ord_itm_depth_req, ord_itm_wizard_serial, ord_itm_install_min, ord_itm_install_use, ord_itm_class,  " + _
        '                      "ord_itm_price_track_inches, ord_itm_lacq3, ord_itm_retail " + _
        '                      "FROM            ord_itm WHERE  ord_itm_ord_serial = 256351 and ord_itm_rev = 3 and ord_itm_type='O'"
        '         cmdtest.ExecuteNonQuery()

        '         cmdtest.CommandText = "INSERT INTO ord_itm (" + _
        '       "ord_itm_ord_serial, ord_itm_rev, ord_itm_type, ord_itm_line, ord_itm_item_code, ord_itm_desc, ord_itm_qty, ord_itm_unt_sell, ord_itm_unt_ship, " + _
        '                    "ord_itm_unt_base, ord_itm_mpf, ord_itm_markup, ord_itm_disc_perc, ord_itm_disc, ord_itm_base_price, ord_itm_taxable, ord_itm_fixture, ord_itm_sel_material,  " + _
        '                    "ord_itm_price_method, ord_itm_mat_code, ord_itm_fin_code, ord_itm_shipped, ord_itm_prod_type, ord_itm_from_ord_itm_serial, ord_itm_forecast_overide,  " + _
        '                    "ord_itm_order_id, ord_itm_note, ord_itm_mat_color, ord_itm_up_color, ord_itm_disc_type, ord_itm_disc_val, ord_itm_disc_amt, ord_itm_is_disc, ord_itm_is_up,  " + _
        '                    "ord_itm_disc_prod, ord_itm_disc_matl, ord_itm_is_perc_price, ord_itm_perc_price, ord_itm_perc_prodtypes, ord_itm_perc_itemcodes, ord_itm_user,  " + _
        '                    "ord_itm_updated, ord_itm_margin_factor, ord_itm_change_base, ord_itm_stain_bottles, ord_itm_lacq_bottles, ord_itm_bottle_search, ord_itm_wood_factor,  " + _
        '                    "ord_itm_ship_flat, ord_itm_bom_import, ord_itm_created, ord_itm_created_by, ord_itm_acct_lock, ord_itm_acct_total, ord_itm_stain_serial, ord_itm_finish_serial,  " + _
        '                    "ord_itm_lacquer_old, ord_itm_stain_bottles_add, ord_itm_lacq_bottles_add, ord_itm_ship_value, ord_itm_group, ord_itm_group_do, ord_itm_width, ord_itm_height,  " + _
        '                    "ord_itm_depth, ord_itm_width_req, ord_itm_height_req, ord_itm_depth_req, ord_itm_wizard_serial, ord_itm_install_min, ord_itm_install_use, ord_itm_class,  " + _
        '                    "ord_itm_price_track_inches, ord_itm_lacq3, ord_itm_retail " + _
        '                    ") select " + _
        '                                 "@serial as ord_itm_ord_serial, 0, ord_itm_type, ord_itm_line, ord_itm_item_code, ord_itm_desc, ord_itm_qty, ord_itm_unt_sell, ord_itm_unt_ship, " + _
        '                    "ord_itm_unt_base, ord_itm_mpf, ord_itm_markup, ord_itm_disc_perc, ord_itm_disc, ord_itm_base_price, ord_itm_taxable, ord_itm_fixture, ord_itm_sel_material,  " + _
        '                    "ord_itm_price_method, ord_itm_mat_code, ord_itm_fin_code, ord_itm_shipped, ord_itm_prod_type, ord_itm_from_ord_itm_serial, ord_itm_forecast_overide,  " + _
        '                    "ord_itm_order_id, ord_itm_note, ord_itm_mat_color, ord_itm_up_color, ord_itm_disc_type, ord_itm_disc_val, ord_itm_disc_amt, ord_itm_is_disc, ord_itm_is_up,  " + _
        '                    "ord_itm_disc_prod, ord_itm_disc_matl, ord_itm_is_perc_price, ord_itm_perc_price, ord_itm_perc_prodtypes, ord_itm_perc_itemcodes, ord_itm_user,  " + _
        '                    "ord_itm_updated, ord_itm_margin_factor, ord_itm_change_base, ord_itm_stain_bottles, ord_itm_lacq_bottles, ord_itm_bottle_search, ord_itm_wood_factor,  " + _
        '                    "ord_itm_ship_flat, ord_itm_bom_import, ord_itm_created, ord_itm_created_by, ord_itm_acct_lock, ord_itm_acct_total, ord_itm_stain_serial, ord_itm_finish_serial,  " + _
        '                    "ord_itm_lacquer_old, ord_itm_stain_bottles_add, ord_itm_lacq_bottles_add, ord_itm_ship_value, ord_itm_group, ord_itm_group_do, ord_itm_width, ord_itm_height,  " + _
        '                    "ord_itm_depth, ord_itm_width_req, ord_itm_height_req, ord_itm_depth_req, ord_itm_wizard_serial, ord_itm_install_min, ord_itm_install_use, ord_itm_class,  " + _
        '                    "ord_itm_price_track_inches, ord_itm_lacq3, ord_itm_retail " + _
        '                    "FROM            ord_itm WHERE  ord_itm_ord_serial = 256351 and ord_itm_rev = 15 and ord_itm_type='Q'"
        '         cmdtest.ExecuteNonQuery()

        '         '***Production
        '         cmdtest.CommandText = "INSERT INTO ord_prod (" + _
        '                              "ord_prod_ord_serial, ord_prod_rev,ord_prod_type,ord_prod_date,ord_prod_who,ord_prod_status,ord_prod_must_ship,ord_prod_must_ship_by, " + _
        '                 "ord_prod_must_ship_note,ord_prod_committed,ord_prod_committed_by,ord_prod_committed_note,ord_prod_est_comp,ord_prod_est_comp_by,ord_prod_est_comp_note,ord_prod_art,ord_prod_art_by,  " + _
        '                 "ord_prod_art_note,ord_prod_sign_stain,ord_prod_sign_stain_by,ord_prod_sign_stain_dt,ord_prod_signoff,ord_prod_signoff_date,ord_prod_signoff_by,ord_prod_signoff_note,ord_prod_roomnotready,  " + _
        '                 "ord_prod_roomnotready_date,ord_prod_roomnotready_by,ord_prod_roomnotready_note,ord_prod_roomrevision,ord_prod_roomrevision_date,ord_prod_roomrevision_by,ord_prod_roomrevision_note,  " + _
        '                 "ord_prod_waitingsignoff,ord_prod_waitingsignoff_date,ord_prod_waitingsignoff_by,ord_prod_waitingsignoff_note,ord_prod_signoffrec,ord_prod_signoffrec_date,ord_prod_signoffrec_by,  " + _
        '                 "ord_prod_signoffrec_note,ord_prod_allclear,ord_prod_allclear_date,ord_prod_allclear_by,ord_prod_allclear_note,ord_prod_designstart,ord_prod_designstart_date,ord_prod_designstart_by,  " + _
        '                 "ord_prod_designstart_note,ord_prod_designcomplete,ord_prod_designcomplete_date,ord_prod_designcomplete_by,ord_prod_designcomplete_note,ord_prod_tofactory,ord_prod_tofactory_date,  " + _
        '                 "ord_prod_tofactory_by,ord_prod_tofactory_note,ord_prod_added_to_closed_week,ord_prod_notes_flag,ord_prod_production_note,ord_prod_kitdown,ord_prod_kitdown_date,ord_prod_kitdown_by,  " + _
        '                 "ord_prod_kitdown_note,ord_prod_cdrdown,ord_prod_cdrdown_date,ord_prod_cdrdown_by,ord_prod_cdrdown_note,ord_prod_kit_email_sent,ord_prod_factcomp,ord_prod_factcomp_date,ord_prod_factcomp_by,  " + _
        '                 "ord_prod_factcomp_note,ord_prod_estship_emailsent,ord_prod_estship_emailsent_complete,ord_prod_cellar_art,ord_prod_cellar_art_date,ord_prod_cellar_art_by,ord_prod_cellar_art_note  " + _
        '                 ") select " + _
        '                              "@serial as ord_prod_ord_serial, 0,ord_prod_type,ord_prod_date,ord_prod_who,ord_prod_status,ord_prod_must_ship,ord_prod_must_ship_by, " + _
        '                 "ord_prod_must_ship_note,ord_prod_committed,ord_prod_committed_by,ord_prod_committed_note,ord_prod_est_comp,ord_prod_est_comp_by,ord_prod_est_comp_note,ord_prod_art,ord_prod_art_by,  " + _
        '                 "ord_prod_art_note,ord_prod_sign_stain,ord_prod_sign_stain_by,ord_prod_sign_stain_dt,ord_prod_signoff,ord_prod_signoff_date,ord_prod_signoff_by,ord_prod_signoff_note,ord_prod_roomnotready,  " + _
        '                 "ord_prod_roomnotready_date,ord_prod_roomnotready_by,ord_prod_roomnotready_note,ord_prod_roomrevision,ord_prod_roomrevision_date,ord_prod_roomrevision_by,ord_prod_roomrevision_note,  " + _
        '                 "ord_prod_waitingsignoff,ord_prod_waitingsignoff_date,ord_prod_waitingsignoff_by,ord_prod_waitingsignoff_note,ord_prod_signoffrec,ord_prod_signoffrec_date,ord_prod_signoffrec_by,  " + _
        '                 "ord_prod_signoffrec_note,ord_prod_allclear,ord_prod_allclear_date,ord_prod_allclear_by,ord_prod_allclear_note,ord_prod_designstart,ord_prod_designstart_date,ord_prod_designstart_by,  " + _
        '                 "ord_prod_designstart_note,ord_prod_designcomplete,ord_prod_designcomplete_date,ord_prod_designcomplete_by,ord_prod_designcomplete_note,ord_prod_tofactory,ord_prod_tofactory_date,  " + _
        '                 "ord_prod_tofactory_by,ord_prod_tofactory_note,ord_prod_added_to_closed_week,ord_prod_notes_flag,ord_prod_production_note,ord_prod_kitdown,ord_prod_kitdown_date,ord_prod_kitdown_by,  " + _
        '                 "ord_prod_kitdown_note,ord_prod_cdrdown,ord_prod_cdrdown_date,ord_prod_cdrdown_by,ord_prod_cdrdown_note,ord_prod_kit_email_sent,ord_prod_factcomp,ord_prod_factcomp_date,ord_prod_factcomp_by,  " + _
        '                 "ord_prod_factcomp_note,ord_prod_estship_emailsent,ord_prod_estship_emailsent_complete,ord_prod_cellar_art,ord_prod_cellar_art_date,ord_prod_cellar_art_by,ord_prod_cellar_art_note  " + _
        '                 "FROM    ord_prod WHERE  ord_prod_ord_serial = 256351 and ord_prod_rev = 3 and ord_prod_type='O'"
        '         cmdtest.ExecuteNonQuery()



        '         cmdtest.Parameters.Add(New SqlParameter("@pay_num", "SEE INVOICE " + drow("ord_serial").ToString + "-0-0"))
        '         cmdtest.Parameters.Add(New SqlParameter("@pay_num2", "SEE INVOICE 257519-1-1"))
        '         cmdtest.Parameters.Add(New SqlParameter("@pay_amt", -40))
        '         cmdtest.Parameters.Add(New SqlParameter("@pay_amt2", 40))
        '         '***pay file
        '         cmdtest.CommandText = "INSERT INTO pay_file (" + _
        '                   "pay_cust_id,pay_date,pay_amt,pay_method,pay_num,pay_exp_date,pay_auth_code,Last_Update,Update_By,billing_id,pay_id,pay_applied,pay_sec_code " + _
        '                  ") select " + _
        '                  "pay_cust_id,pay_date,@pay_amt as pay_amt,pay_method,@pay_num as pay_num,pay_exp_date,pay_auth_code,Last_Update,Update_By,billing_id,pay_id,pay_applied,pay_sec_code   " + _
        '                  "FROM    pay_file WHERE  pay_serial = 290303"
        '         cmdtest.ExecuteNonQuery()
        '         cmdtest.CommandText = "select @@IDENTITY as jid"
        '         Dim LastPay = cmdtest.ExecuteScalar

        '         cmdtest.CommandText = "INSERT INTO pay_file (" + _
        '                   "pay_cust_id,pay_date,pay_amt,pay_method,pay_num,pay_exp_date,pay_auth_code,Last_Update,Update_By,billing_id,pay_id,pay_applied,pay_sec_code " + _
        '                  ") select " + _
        '                  "pay_cust_id,pay_date,@pay_amt2 as pay_amt,pay_method,@pay_num2 as pay_num,pay_exp_date,pay_auth_code,Last_Update,Update_By,billing_id,pay_id,pay_applied,pay_sec_code   " + _
        '                  "FROM    pay_file WHERE  pay_serial = 290304"
        '         cmdtest.ExecuteNonQuery()
        '         cmdtest.CommandText = "select @@IDENTITY as jid"
        '         Dim LastPay2 = cmdtest.ExecuteScalar

        '         '***pay item
        '         cmdtest.Parameters.Add(New SqlParameter("@lastpay", LastPay))
        '         cmdtest.Parameters.Add(New SqlParameter("@ordGENserial", ordGENserial))
        '         cmdtest.CommandText = "INSERT INTO pay_itm (" + _
        '                  "pay_itm_pay_serial,pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,pay_itm_amt,billing_id,pay_id,pay_itm_sent_cust " + _
        '                 ") select " + _
        '                 "@lastpay as pay_itm_pay_serial, pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,@pay_amt as pay_itm_amt,billing_id,pay_id,pay_itm_sent_cust   " + _
        '                 "FROM    pay_itm WHERE  pay_itm_serial = 699135"
        '         cmdtest.ExecuteNonQuery()

        '         cmdtest.Parameters.Add(New SqlParameter("@lastpay2", LastPay2))
        '         cmdtest.CommandText = "INSERT INTO pay_itm (" + _
        '                  "pay_itm_pay_serial,pay_itm_ord_gen_serial,pay_itm_ord_serial,pay_itm_ord_rev,pay_itm_amt,billing_id,pay_id,pay_itm_sent_cust " + _
        '                 ") select " + _
        '                 "@lastpay2 as pay_itm_pay_serial,@ordGENserial as pay_itm_ord_gen_serial,@serial as pay_itm_ord_serial,0,@pay_amt2 as pay_itm_amt,billing_id,pay_id,pay_itm_sent_cust   " + _
        '                 "FROM    pay_itm WHERE  pay_itm_serial = 699139"
        '         cmdtest.ExecuteNonQuery()

        '         cnt += 1
        '     Next
        ' Catch
        '     MsgBox(Err.Description)
        ' Finally
        '     cnntest.Close()
        ' End Try
        ' MsgBox("done")
    End Sub

    Private Sub MenuItem321_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem321.Click
        DisplayReport("CreditCardPortalReport", , True, 1, , , True)
    End Sub

    Private Sub MenuItem322_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem322.Click
        DisplayReport("ChrisMeutschOrders", , True, 1, , , True)
    End Sub

    Private Sub MenuItem323_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem323.Click
        DisplayReport("ChrisMeutschContacts", , True, 1, , , True)
    End Sub


    Private Sub MenuItem324_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem324.Click

        DisplayReport("LeadsWithoutQuotes", , True, 1, , , True)
    End Sub
End Class
