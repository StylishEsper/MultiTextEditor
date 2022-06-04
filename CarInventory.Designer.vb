<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.cboSelectYear = New System.Windows.Forms.ComboBox()
        Me.txtInputModel = New System.Windows.Forms.TextBox()
        Me.cboSelectMake = New System.Windows.Forms.ComboBox()
        Me.txtInputPrice = New System.Windows.Forms.TextBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lblPromptNew = New System.Windows.Forms.Label()
        Me.lblPromptPrice = New System.Windows.Forms.Label()
        Me.lblPromptYear = New System.Windows.Forms.Label()
        Me.lblPromptModel = New System.Windows.Forms.Label()
        Me.lblPromptMake = New System.Windows.Forms.Label()
        Me.ttpCarInventory = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lvwCars
        '
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCars.HideSelection = False
        Me.lvwCars.Location = New System.Drawing.Point(12, 203)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(459, 220)
        Me.lvwCars.TabIndex = 10
        Me.ttpCarInventory.SetToolTip(Me.lvwCars, "Select a car to modify")
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 40
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 35
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 75
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 75
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 45
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 75
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(391, 545)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 25)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "&Close"
        Me.ttpCarInventory.SetToolTip(Me.btnExit, "Click to close form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(305, 545)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 25)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ttpCarInventory.SetToolTip(Me.btnReset, "Click to clear input controls")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(219, 545)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(80, 25)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ttpCarInventory.SetToolTip(Me.btnEnter, "Click to confirm data entry")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(12, 431)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(459, 108)
        Me.lblResult.TabIndex = 11
        Me.ttpCarInventory.SetToolTip(Me.lblResult, "Displays error message or entry valid message")
        '
        'cboSelectYear
        '
        Me.cboSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectYear.FormattingEnabled = True
        Me.cboSelectYear.Location = New System.Drawing.Point(125, 96)
        Me.cboSelectYear.Name = "cboSelectYear"
        Me.cboSelectYear.Size = New System.Drawing.Size(121, 24)
        Me.cboSelectYear.TabIndex = 5
        Me.ttpCarInventory.SetToolTip(Me.cboSelectYear, "Select the year")
        '
        'txtInputModel
        '
        Me.txtInputModel.Location = New System.Drawing.Point(125, 16)
        Me.txtInputModel.Name = "txtInputModel"
        Me.txtInputModel.Size = New System.Drawing.Size(121, 22)
        Me.txtInputModel.TabIndex = 1
        Me.ttpCarInventory.SetToolTip(Me.txtInputModel, "Type the model here")
        '
        'cboSelectMake
        '
        Me.cboSelectMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectMake.FormattingEnabled = True
        Me.cboSelectMake.Items.AddRange(New Object() {"BMW", "Daimler", "Fiat Chrysler", "Ford", "General Motors", "Honda", "Nissan", "Tesla", "Toyota", "Volkswagen"})
        Me.cboSelectMake.Location = New System.Drawing.Point(125, 56)
        Me.cboSelectMake.Name = "cboSelectMake"
        Me.cboSelectMake.Size = New System.Drawing.Size(121, 24)
        Me.cboSelectMake.TabIndex = 3
        Me.ttpCarInventory.SetToolTip(Me.cboSelectMake, "Select a make")
        '
        'txtInputPrice
        '
        Me.txtInputPrice.Location = New System.Drawing.Point(125, 136)
        Me.txtInputPrice.Name = "txtInputPrice"
        Me.txtInputPrice.Size = New System.Drawing.Size(121, 22)
        Me.txtInputPrice.TabIndex = 7
        Me.ttpCarInventory.SetToolTip(Me.txtInputPrice, "Type the price here")
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(125, 176)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(18, 17)
        Me.chkNew.TabIndex = 9
        Me.ttpCarInventory.SetToolTip(Me.chkNew, "Click checkbox if car is new")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lblPromptNew
        '
        Me.lblPromptNew.Location = New System.Drawing.Point(54, 176)
        Me.lblPromptNew.Name = "lblPromptNew"
        Me.lblPromptNew.Size = New System.Drawing.Size(52, 17)
        Me.lblPromptNew.TabIndex = 8
        Me.lblPromptNew.Text = "&New:"
        Me.lblPromptNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPromptPrice
        '
        Me.lblPromptPrice.Location = New System.Drawing.Point(51, 136)
        Me.lblPromptPrice.Name = "lblPromptPrice"
        Me.lblPromptPrice.Size = New System.Drawing.Size(55, 17)
        Me.lblPromptPrice.TabIndex = 6
        Me.lblPromptPrice.Text = "&Price:"
        Me.lblPromptPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPromptYear
        '
        Me.lblPromptYear.Location = New System.Drawing.Point(51, 96)
        Me.lblPromptYear.Name = "lblPromptYear"
        Me.lblPromptYear.Size = New System.Drawing.Size(55, 17)
        Me.lblPromptYear.TabIndex = 4
        Me.lblPromptYear.Text = "&Year:"
        Me.lblPromptYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPromptModel
        '
        Me.lblPromptModel.Location = New System.Drawing.Point(48, 16)
        Me.lblPromptModel.Name = "lblPromptModel"
        Me.lblPromptModel.Size = New System.Drawing.Size(58, 17)
        Me.lblPromptModel.TabIndex = 0
        Me.lblPromptModel.Text = "M&odel:"
        Me.lblPromptModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPromptMake
        '
        Me.lblPromptMake.Location = New System.Drawing.Point(51, 56)
        Me.lblPromptMake.Name = "lblPromptMake"
        Me.lblPromptMake.Size = New System.Drawing.Size(55, 17)
        Me.lblPromptMake.TabIndex = 2
        Me.lblPromptMake.Text = "&Make:"
        Me.lblPromptMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(482, 586)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.cboSelectYear)
        Me.Controls.Add(Me.txtInputModel)
        Me.Controls.Add(Me.cboSelectMake)
        Me.Controls.Add(Me.txtInputPrice)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lblPromptNew)
        Me.Controls.Add(Me.lblPromptPrice)
        Me.Controls.Add(Me.lblPromptYear)
        Me.Controls.Add(Me.lblPromptModel)
        Me.Controls.Add(Me.lblPromptMake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwCars As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents cboSelectYear As ComboBox
    Friend WithEvents txtInputModel As TextBox
    Friend WithEvents cboSelectMake As ComboBox
    Friend WithEvents txtInputPrice As TextBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lblPromptNew As Label
    Friend WithEvents lblPromptPrice As Label
    Friend WithEvents lblPromptYear As Label
    Friend WithEvents lblPromptModel As Label
    Friend WithEvents lblPromptMake As Label
    Friend WithEvents ttpCarInventory As ToolTip
End Class
