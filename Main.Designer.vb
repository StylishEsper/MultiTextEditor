<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.stsStatusBar = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ttpFormTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlbButtonBar = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCarList = New System.Windows.Forms.ToolStripButton()
        Me.btnUnitsShipped = New System.Windows.Forms.ToolStripButton()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuStripFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStripFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStripFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuWindowsOpenCarList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsOpenAverageUnits = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStripHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.opdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.stsStatusBar.SuspendLayout()
        Me.tlbButtonBar.SuspendLayout()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'stsStatusBar
        '
        Me.stsStatusBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.stsStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.stsStatusBar.Location = New System.Drawing.Point(0, 513)
        Me.stsStatusBar.Name = "stsStatusBar"
        Me.stsStatusBar.Size = New System.Drawing.Size(997, 26)
        Me.stsStatusBar.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(49, 20)
        Me.lblStatus.Text = "Status"
        '
        'tlbButtonBar
        '
        Me.tlbButtonBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlbButtonBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnOpen, Me.btnSave, Me.btnCarList, Me.btnUnitsShipped})
        Me.tlbButtonBar.Location = New System.Drawing.Point(0, 28)
        Me.tlbButtonBar.Name = "tlbButtonBar"
        Me.tlbButtonBar.Size = New System.Drawing.Size(997, 27)
        Me.tlbButtonBar.TabIndex = 1
        Me.tlbButtonBar.Text = "ToolStrip1"
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(29, 24)
        Me.btnNew.Text = "&New"
        '
        'btnOpen
        '
        Me.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(29, 28)
        Me.btnOpen.Text = "&Open"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(29, 28)
        Me.btnSave.Text = "&Save"
        '
        'btnCarList
        '
        Me.btnCarList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCarList.Image = CType(resources.GetObject("btnCarList.Image"), System.Drawing.Image)
        Me.btnCarList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCarList.Name = "btnCarList"
        Me.btnCarList.Size = New System.Drawing.Size(29, 28)
        Me.btnCarList.Text = "Car &List"
        '
        'btnUnitsShipped
        '
        Me.btnUnitsShipped.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUnitsShipped.Image = CType(resources.GetObject("btnUnitsShipped.Image"), System.Drawing.Image)
        Me.btnUnitsShipped.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUnitsShipped.Name = "btnUnitsShipped"
        Me.btnUnitsShipped.Size = New System.Drawing.Size(29, 28)
        Me.btnUnitsShipped.Text = "Average &Units Shipped"
        '
        'mnuStrip
        '
        Me.mnuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStripFile, Me.mnuStripEdit, Me.mnuStripWindows, Me.mnuStripHelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(997, 28)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuStripFile
        '
        Me.mnuStripFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStripFileNew, Me.mnuStripFileOpen, Me.toolStripSeparator, Me.mnuStripFileSave, Me.mnuStripFileSaveAs, Me.toolStripSeparator1, Me.mnuStripFileClose, Me.mnuStripFileExit})
        Me.mnuStripFile.Name = "mnuStripFile"
        Me.mnuStripFile.Size = New System.Drawing.Size(46, 26)
        Me.mnuStripFile.Text = "&File"
        '
        'mnuStripFileNew
        '
        Me.mnuStripFileNew.Image = CType(resources.GetObject("mnuStripFileNew.Image"), System.Drawing.Image)
        Me.mnuStripFileNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuStripFileNew.Name = "mnuStripFileNew"
        Me.mnuStripFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuStripFileNew.Size = New System.Drawing.Size(181, 26)
        Me.mnuStripFileNew.Text = "&New"
        Me.mnuStripFileNew.ToolTipText = "Click to create a new text editor"
        '
        'mnuStripFileOpen
        '
        Me.mnuStripFileOpen.Image = CType(resources.GetObject("mnuStripFileOpen.Image"), System.Drawing.Image)
        Me.mnuStripFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuStripFileOpen.Name = "mnuStripFileOpen"
        Me.mnuStripFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuStripFileOpen.Size = New System.Drawing.Size(181, 26)
        Me.mnuStripFileOpen.Text = "&Open"
        Me.mnuStripFileOpen.ToolTipText = "Click to open an existing text file"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(178, 6)
        '
        'mnuStripFileSave
        '
        Me.mnuStripFileSave.Image = CType(resources.GetObject("mnuStripFileSave.Image"), System.Drawing.Image)
        Me.mnuStripFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuStripFileSave.Name = "mnuStripFileSave"
        Me.mnuStripFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuStripFileSave.Size = New System.Drawing.Size(181, 26)
        Me.mnuStripFileSave.Text = "&Save"
        Me.mnuStripFileSave.ToolTipText = "Click to save"
        '
        'mnuStripFileSaveAs
        '
        Me.mnuStripFileSaveAs.Name = "mnuStripFileSaveAs"
        Me.mnuStripFileSaveAs.Size = New System.Drawing.Size(181, 26)
        Me.mnuStripFileSaveAs.Text = "Save &As"
        Me.mnuStripFileSaveAs.ToolTipText = "Click to choose where to save this file"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'mnuStripFileClose
        '
        Me.mnuStripFileClose.Name = "mnuStripFileClose"
        Me.mnuStripFileClose.Size = New System.Drawing.Size(181, 26)
        Me.mnuStripFileClose.Text = "C&lose"
        Me.mnuStripFileClose.ToolTipText = "Click to close selected window"
        '
        'mnuStripFileExit
        '
        Me.mnuStripFileExit.Name = "mnuStripFileExit"
        Me.mnuStripFileExit.Size = New System.Drawing.Size(181, 26)
        Me.mnuStripFileExit.Text = "E&xit"
        Me.mnuStripFileExit.ToolTipText = "Click to exit application"
        '
        'mnuStripEdit
        '
        Me.mnuStripEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStripEditCut, Me.mnuStripEditCopy, Me.mnuStripEditPaste})
        Me.mnuStripEdit.Name = "mnuStripEdit"
        Me.mnuStripEdit.Size = New System.Drawing.Size(49, 26)
        Me.mnuStripEdit.Text = "&Edit"
        '
        'mnuStripEditCut
        '
        Me.mnuStripEditCut.Image = CType(resources.GetObject("mnuStripEditCut.Image"), System.Drawing.Image)
        Me.mnuStripEditCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuStripEditCut.Name = "mnuStripEditCut"
        Me.mnuStripEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuStripEditCut.Size = New System.Drawing.Size(177, 26)
        Me.mnuStripEditCut.Text = "Cu&t"
        Me.mnuStripEditCut.ToolTipText = "Click to cut selected text"
        '
        'mnuStripEditCopy
        '
        Me.mnuStripEditCopy.Image = CType(resources.GetObject("mnuStripEditCopy.Image"), System.Drawing.Image)
        Me.mnuStripEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuStripEditCopy.Name = "mnuStripEditCopy"
        Me.mnuStripEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuStripEditCopy.Size = New System.Drawing.Size(177, 26)
        Me.mnuStripEditCopy.Text = "&Copy"
        Me.mnuStripEditCopy.ToolTipText = "Click to copy selected text"
        '
        'mnuStripEditPaste
        '
        Me.mnuStripEditPaste.Image = CType(resources.GetObject("mnuStripEditPaste.Image"), System.Drawing.Image)
        Me.mnuStripEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuStripEditPaste.Name = "mnuStripEditPaste"
        Me.mnuStripEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuStripEditPaste.Size = New System.Drawing.Size(177, 26)
        Me.mnuStripEditPaste.Text = "&Paste"
        Me.mnuStripEditPaste.ToolTipText = "Click to paste selected text"
        '
        'mnuStripWindows
        '
        Me.mnuStripWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowsCascade, Me.mnuWindowsTileVertical, Me.mnuWindowsTileHorizontal, Me.ToolStripMenuItem1, Me.mnuWindowsOpenCarList, Me.mnuWindowsOpenAverageUnits, Me.ToolStripMenuItem2})
        Me.mnuStripWindows.Name = "mnuStripWindows"
        Me.mnuStripWindows.Size = New System.Drawing.Size(84, 26)
        Me.mnuStripWindows.Text = "&Windows"
        '
        'mnuWindowsCascade
        '
        Me.mnuWindowsCascade.Name = "mnuWindowsCascade"
        Me.mnuWindowsCascade.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowsCascade.Text = "Casca&de"
        '
        'mnuWindowsTileVertical
        '
        Me.mnuWindowsTileVertical.Name = "mnuWindowsTileVertical"
        Me.mnuWindowsTileVertical.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowsTileVertical.Text = "Tile &Vertical"
        '
        'mnuWindowsTileHorizontal
        '
        Me.mnuWindowsTileHorizontal.Name = "mnuWindowsTileHorizontal"
        Me.mnuWindowsTileHorizontal.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowsTileHorizontal.Text = "Tile &Horizontal"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 6)
        '
        'mnuWindowsOpenCarList
        '
        Me.mnuWindowsOpenCarList.Name = "mnuWindowsOpenCarList"
        Me.mnuWindowsOpenCarList.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowsOpenCarList.Text = "Open Car &List"
        Me.mnuWindowsOpenCarList.ToolTipText = "Click to open car list"
        '
        'mnuWindowsOpenAverageUnits
        '
        Me.mnuWindowsOpenAverageUnits.Name = "mnuWindowsOpenAverageUnits"
        Me.mnuWindowsOpenAverageUnits.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowsOpenAverageUnits.Text = "Open Average &Units"
        Me.mnuWindowsOpenAverageUnits.ToolTipText = "Click to open average units"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(221, 6)
        '
        'mnuStripHelp
        '
        Me.mnuStripHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStripHelpAbout})
        Me.mnuStripHelp.Name = "mnuStripHelp"
        Me.mnuStripHelp.Size = New System.Drawing.Size(55, 24)
        Me.mnuStripHelp.Text = "&Help"
        '
        'mnuStripHelpAbout
        '
        Me.mnuStripHelpAbout.Name = "mnuStripHelpAbout"
        Me.mnuStripHelpAbout.Size = New System.Drawing.Size(142, 26)
        Me.mnuStripHelpAbout.Text = "&About..."
        Me.mnuStripHelpAbout.ToolTipText = "Click to open application information"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(997, 539)
        Me.Controls.Add(Me.tlbButtonBar)
        Me.Controls.Add(Me.stsStatusBar)
        Me.Controls.Add(Me.mnuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi-Text Editor"
        Me.stsStatusBar.ResumeLayout(False)
        Me.stsStatusBar.PerformLayout()
        Me.tlbButtonBar.ResumeLayout(False)
        Me.tlbButtonBar.PerformLayout()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsStatusBar As StatusStrip
    Friend WithEvents ttpFormTips As ToolTip
    Friend WithEvents tlbButtonBar As ToolStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnOpen As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton

    Private Sub frmMultiTextMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents mnuStripFile As ToolStripMenuItem
    Friend WithEvents mnuStripFileNew As ToolStripMenuItem
    Friend WithEvents mnuStripFileOpen As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents mnuStripFileSave As ToolStripMenuItem
    Friend WithEvents mnuStripFileSaveAs As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuStripFileExit As ToolStripMenuItem
    Friend WithEvents mnuStripEdit As ToolStripMenuItem
    Friend WithEvents mnuStripEditCut As ToolStripMenuItem
    Friend WithEvents mnuStripEditCopy As ToolStripMenuItem
    Friend WithEvents mnuStripEditPaste As ToolStripMenuItem
    Friend WithEvents mnuStripWindows As ToolStripMenuItem
    Friend WithEvents mnuStripHelp As ToolStripMenuItem
    Friend WithEvents mnuStripHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuStripFileClose As ToolStripMenuItem
    Friend WithEvents mnuWindowsCascade As ToolStripMenuItem
    Friend WithEvents mnuWindowsTileVertical As ToolStripMenuItem
    Friend WithEvents mnuWindowsTileHorizontal As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuWindowsOpenCarList As ToolStripMenuItem
    Friend WithEvents mnuWindowsOpenAverageUnits As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents opdOpen As OpenFileDialog
    Friend WithEvents btnCarList As ToolStripButton
    Friend WithEvents btnUnitsShipped As ToolStripButton
End Class
