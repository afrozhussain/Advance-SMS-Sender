<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetStatus
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optSent = New System.Windows.Forms.RadioButton
        Me.optNotSent = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.optCellNumber = New System.Windows.Forms.RadioButton
        Me.optApplyAll = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 176)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSent)
        Me.GroupBox1.Controls.Add(Me.optNotSent)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 65)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set Status To: "
        '
        'optSent
        '
        Me.optSent.AutoSize = True
        Me.optSent.Location = New System.Drawing.Point(104, 28)
        Me.optSent.Name = "optSent"
        Me.optSent.Size = New System.Drawing.Size(47, 17)
        Me.optSent.TabIndex = 7
        Me.optSent.TabStop = True
        Me.optSent.Text = "Sent"
        Me.optSent.UseVisualStyleBackColor = True
        '
        'optNotSent
        '
        Me.optNotSent.AutoSize = True
        Me.optNotSent.Location = New System.Drawing.Point(18, 28)
        Me.optNotSent.Name = "optNotSent"
        Me.optNotSent.Size = New System.Drawing.Size(67, 17)
        Me.optNotSent.TabIndex = 6
        Me.optNotSent.TabStop = True
        Me.optNotSent.Text = "Not Sent"
        Me.optNotSent.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SMS_Sender.My.Resources.Resources.Folder_Options_icon
        Me.PictureBox1.Location = New System.Drawing.Point(280, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 138)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optCellNumber)
        Me.GroupBox2.Controls.Add(Me.optApplyAll)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 81)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apply To"
        '
        'optCellNumber
        '
        Me.optCellNumber.AutoSize = True
        Me.optCellNumber.Location = New System.Drawing.Point(18, 23)
        Me.optCellNumber.Name = "optCellNumber"
        Me.optCellNumber.Size = New System.Drawing.Size(118, 17)
        Me.optCellNumber.TabIndex = 7
        Me.optCellNumber.TabStop = True
        Me.optCellNumber.Text = "Only to Cell Number"
        Me.optCellNumber.UseVisualStyleBackColor = True
        '
        'optApplyAll
        '
        Me.optApplyAll.AutoSize = True
        Me.optApplyAll.Location = New System.Drawing.Point(18, 50)
        Me.optApplyAll.Name = "optApplyAll"
        Me.optApplyAll.Size = New System.Drawing.Size(126, 17)
        Me.optApplyAll.TabIndex = 6
        Me.optApplyAll.TabStop = True
        Me.optApplyAll.Text = "All Selected Contacts"
        Me.optApplyAll.UseVisualStyleBackColor = True
        '
        'frmSetStatus
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 217)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetStatus"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Set Status"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optSent As System.Windows.Forms.RadioButton
    Friend WithEvents optNotSent As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optCellNumber As System.Windows.Forms.RadioButton
    Friend WithEvents optApplyAll As System.Windows.Forms.RadioButton

End Class
