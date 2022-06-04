<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTextEditor
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
        Me.txtEditor = New System.Windows.Forms.TextBox()
        Me.sfdSaveAs = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'txtEditor
        '
        Me.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEditor.Location = New System.Drawing.Point(0, 0)
        Me.txtEditor.Multiline = True
        Me.txtEditor.Name = "txtEditor"
        Me.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEditor.Size = New System.Drawing.Size(800, 450)
        Me.txtEditor.TabIndex = 0
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtEditor)
        Me.Name = "frmTextEditor"
        Me.Text = "Text Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEditor As TextBox
    Friend WithEvents sfdSaveAs As SaveFileDialog
End Class
