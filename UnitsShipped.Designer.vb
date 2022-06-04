<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnitsShipped
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtEmployee3List = New System.Windows.Forms.TextBox()
        Me.txtEmployee2List = New System.Windows.Forms.TextBox()
        Me.txtEmployee1List = New System.Windows.Forms.TextBox()
        Me.txtUnitInput = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblOverallAverage = New System.Windows.Forms.Label()
        Me.lblAverageDisplay3 = New System.Windows.Forms.Label()
        Me.lblAverageDisplay2 = New System.Windows.Forms.Label()
        Me.lblAverageDisplay1 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblUnitsPrompt = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.ttpUnitsShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtEmployee3List
        '
        Me.txtEmployee3List.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEmployee3List.Location = New System.Drawing.Point(281, 118)
        Me.txtEmployee3List.Multiline = True
        Me.txtEmployee3List.Name = "txtEmployee3List"
        Me.txtEmployee3List.ReadOnly = True
        Me.txtEmployee3List.Size = New System.Drawing.Size(125, 125)
        Me.txtEmployee3List.TabIndex = 8
        Me.txtEmployee3List.TabStop = False
        Me.ttpUnitsShipped.SetToolTip(Me.txtEmployee3List, "Employee 3 input list")
        '
        'txtEmployee2List
        '
        Me.txtEmployee2List.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEmployee2List.Location = New System.Drawing.Point(146, 118)
        Me.txtEmployee2List.Multiline = True
        Me.txtEmployee2List.Name = "txtEmployee2List"
        Me.txtEmployee2List.ReadOnly = True
        Me.txtEmployee2List.Size = New System.Drawing.Size(125, 125)
        Me.txtEmployee2List.TabIndex = 7
        Me.txtEmployee2List.TabStop = False
        Me.ttpUnitsShipped.SetToolTip(Me.txtEmployee2List, "Employee 2 input list")
        '
        'txtEmployee1List
        '
        Me.txtEmployee1List.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEmployee1List.Location = New System.Drawing.Point(11, 118)
        Me.txtEmployee1List.Multiline = True
        Me.txtEmployee1List.Name = "txtEmployee1List"
        Me.txtEmployee1List.ReadOnly = True
        Me.txtEmployee1List.Size = New System.Drawing.Size(125, 125)
        Me.txtEmployee1List.TabIndex = 6
        Me.txtEmployee1List.TabStop = False
        Me.ttpUnitsShipped.SetToolTip(Me.txtEmployee1List, "Employee 1 input list")
        '
        'txtUnitInput
        '
        Me.txtUnitInput.Location = New System.Drawing.Point(70, 46)
        Me.txtUnitInput.Name = "txtUnitInput"
        Me.txtUnitInput.Size = New System.Drawing.Size(60, 22)
        Me.txtUnitInput.TabIndex = 2
        Me.ttpUnitsShipped.SetToolTip(Me.txtUnitInput, "Input units here")
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(281, 318)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 28)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "&Close"
        Me.ttpUnitsShipped.SetToolTip(Me.btnClose, "Click to close units shipped")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(146, 318)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(125, 28)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ttpUnitsShipped.SetToolTip(Me.btnReset, "Click to reset form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(11, 318)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(125, 28)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ttpUnitsShipped.SetToolTip(Me.btnEnter, "Click to enter input")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblOverallAverage
        '
        Me.lblOverallAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverallAverage.Location = New System.Drawing.Point(11, 282)
        Me.lblOverallAverage.Name = "lblOverallAverage"
        Me.lblOverallAverage.Size = New System.Drawing.Size(397, 27)
        Me.lblOverallAverage.TabIndex = 12
        Me.lblOverallAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpUnitsShipped.SetToolTip(Me.lblOverallAverage, "Per day average display")
        '
        'lblAverageDisplay3
        '
        Me.lblAverageDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageDisplay3.Location = New System.Drawing.Point(281, 248)
        Me.lblAverageDisplay3.Name = "lblAverageDisplay3"
        Me.lblAverageDisplay3.Size = New System.Drawing.Size(127, 25)
        Me.lblAverageDisplay3.TabIndex = 11
        Me.lblAverageDisplay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpUnitsShipped.SetToolTip(Me.lblAverageDisplay3, "Employee 3 average")
        '
        'lblAverageDisplay2
        '
        Me.lblAverageDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageDisplay2.Location = New System.Drawing.Point(146, 248)
        Me.lblAverageDisplay2.Name = "lblAverageDisplay2"
        Me.lblAverageDisplay2.Size = New System.Drawing.Size(125, 25)
        Me.lblAverageDisplay2.TabIndex = 10
        Me.lblAverageDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpUnitsShipped.SetToolTip(Me.lblAverageDisplay2, "Employee 2 average")
        '
        'lblAverageDisplay1
        '
        Me.lblAverageDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageDisplay1.Location = New System.Drawing.Point(11, 248)
        Me.lblAverageDisplay1.Name = "lblAverageDisplay1"
        Me.lblAverageDisplay1.Size = New System.Drawing.Size(125, 25)
        Me.lblAverageDisplay1.TabIndex = 9
        Me.lblAverageDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpUnitsShipped.SetToolTip(Me.lblAverageDisplay1, "Employee 1 average")
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(302, 89)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee3.TabIndex = 5
        Me.lblEmployee3.Text = "Employee 3"
        Me.ttpUnitsShipped.SetToolTip(Me.lblEmployee3, "Employee 3 input list")
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(169, 89)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee2.TabIndex = 4
        Me.lblEmployee2.Text = "Employee 2"
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Location = New System.Drawing.Point(35, 89)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        Me.ttpUnitsShipped.SetToolTip(Me.lblEmployee1, "Employee 2 input list")
        '
        'lblUnitsPrompt
        '
        Me.lblUnitsPrompt.AutoSize = True
        Me.lblUnitsPrompt.Location = New System.Drawing.Point(20, 49)
        Me.lblUnitsPrompt.Name = "lblUnitsPrompt"
        Me.lblUnitsPrompt.Size = New System.Drawing.Size(44, 17)
        Me.lblUnitsPrompt.TabIndex = 1
        Me.lblUnitsPrompt.Text = "Units:"
        Me.ttpUnitsShipped.SetToolTip(Me.lblUnitsPrompt, "Input units in textbox")
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(20, 16)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(45, 17)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        Me.ttpUnitsShipped.SetToolTip(Me.lblDay, "Current day")
        '
        'frmUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(418, 363)
        Me.Controls.Add(Me.txtEmployee3List)
        Me.Controls.Add(Me.txtEmployee2List)
        Me.Controls.Add(Me.txtEmployee1List)
        Me.Controls.Add(Me.txtUnitInput)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOverallAverage)
        Me.Controls.Add(Me.lblAverageDisplay3)
        Me.Controls.Add(Me.lblAverageDisplay2)
        Me.Controls.Add(Me.lblAverageDisplay1)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblUnitsPrompt)
        Me.Controls.Add(Me.lblDay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UnitsShipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmployee3List As TextBox
    Friend WithEvents txtEmployee2List As TextBox
    Friend WithEvents txtEmployee1List As TextBox
    Friend WithEvents txtUnitInput As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblOverallAverage As Label
    Friend WithEvents lblAverageDisplay3 As Label
    Friend WithEvents lblAverageDisplay2 As Label
    Friend WithEvents lblAverageDisplay1 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblUnitsPrompt As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents ttpUnitsShipped As ToolTip
End Class
