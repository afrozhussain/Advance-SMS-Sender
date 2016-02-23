<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportCSV
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.Button_Browse = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtGroupName = New System.Windows.Forms.TextBox
        Me.lblFileLength = New System.Windows.Forms.Label
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Button_load = New System.Windows.Forms.Button
        Me.lblLoadStatus = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Path:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(174, 28)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(208, 20)
        Me.txtPath.TabIndex = 0
        '
        'Button_Browse
        '
        Me.Button_Browse.Location = New System.Drawing.Point(388, 25)
        Me.Button_Browse.Name = "Button_Browse"
        Me.Button_Browse.Size = New System.Drawing.Size(75, 23)
        Me.Button_Browse.TabIndex = 1
        Me.Button_Browse.Text = "Browse ..."
        Me.Button_Browse.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(5, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(154, 215)
        Me.Panel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Import Contacts"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SMS_Sender.My.Resources.Resources.file_import_icon
        Me.PictureBox1.Location = New System.Drawing.Point(10, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 137)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Group Name:"
        '
        'txtGroupName
        '
        Me.txtGroupName.Location = New System.Drawing.Point(174, 79)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(289, 20)
        Me.txtGroupName.TabIndex = 2
        '
        'lblFileLength
        '
        Me.lblFileLength.AutoSize = True
        Me.lblFileLength.Location = New System.Drawing.Point(174, 112)
        Me.lblFileLength.Name = "lblFileLength"
        Me.lblFileLength.Size = New System.Drawing.Size(62, 13)
        Me.lblFileLength.TabIndex = 9
        Me.lblFileLength.Text = "File Length:"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(388, 197)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 4
        Me.Cancel_Button.Text = "Close"
        '
        'Button_load
        '
        Me.Button_load.Location = New System.Drawing.Point(174, 197)
        Me.Button_load.Name = "Button_load"
        Me.Button_load.Size = New System.Drawing.Size(75, 23)
        Me.Button_load.TabIndex = 3
        Me.Button_load.Text = "Load"
        Me.Button_load.UseVisualStyleBackColor = True
        '
        'lblLoadStatus
        '
        Me.lblLoadStatus.AutoSize = True
        Me.lblLoadStatus.Location = New System.Drawing.Point(260, 202)
        Me.lblLoadStatus.Name = "lblLoadStatus"
        Me.lblLoadStatus.Size = New System.Drawing.Size(71, 13)
        Me.lblLoadStatus.TabIndex = 11
        Me.lblLoadStatus.Text = "lblLoadStatus"
        '
        'frmImportCSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(489, 232)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.lblLoadStatus)
        Me.Controls.Add(Me.Button_load)
        Me.Controls.Add(Me.lblFileLength)
        Me.Controls.Add(Me.txtGroupName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_Browse)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportCSV"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import CSV File"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Button_Browse As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGroupName As System.Windows.Forms.TextBox
    Friend WithEvents lblFileLength As System.Windows.Forms.Label
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Button_load As System.Windows.Forms.Button
    Friend WithEvents lblLoadStatus As System.Windows.Forms.Label

End Class
