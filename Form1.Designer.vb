<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnSend = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem_About = New System.Windows.Forms.ToolStripMenuItem
        Me.btnStop = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel_TotalContacts = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel_Filter = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel_FilteredRows = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboGroupName = New System.Windows.Forms.ComboBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabGroupDetail = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton_SetStatus = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.cboFilter = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.txtFilterValue = New System.Windows.Forms.ToolStripTextBox
        Me.btnAddFilter = New System.Windows.Forms.ToolStripButton
        Me.btnClearFilter = New System.Windows.Forms.ToolStripButton
        Me.TabStatus = New System.Windows.Forms.TabPage
        Me.lblLast25Min = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button_SendTextMessage = New System.Windows.Forms.Button
        Me.btnDisconnect = New System.Windows.Forms.Button
        Me.btnConnect = New System.Windows.Forms.Button
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtConnectionParameter = New System.Windows.Forms.TextBox
        Me.btnImport = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.AxKylixSMS1 = New AxKYLIXSMSLib.AxKylixSMS
        Me.AxKylixSMS2 = New AxKYLIXSMSLib.AxKylixSMS
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabGroupDetail.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabStatus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxKylixSMS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxKylixSMS2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(503, 245)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(83, 23)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Start"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportContactsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ImportContactsToolStripMenuItem
        '
        Me.ImportContactsToolStripMenuItem.Name = "ImportContactsToolStripMenuItem"
        Me.ImportContactsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ImportContactsToolStripMenuItem.Text = "&Import Contacts"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem_About})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem_About
        '
        Me.AboutToolStripMenuItem_About.Name = "AboutToolStripMenuItem_About"
        Me.AboutToolStripMenuItem_About.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem_About.Text = "&About"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(589, 245)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(76, 23)
        Me.btnStop.TabIndex = 14
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_TotalContacts, Me.ToolStripStatusLabel_Filter, Me.ToolStripStatusLabel_FilteredRows})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 567)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(676, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel_TotalContacts
        '
        Me.ToolStripStatusLabel_TotalContacts.Name = "ToolStripStatusLabel_TotalContacts"
        Me.ToolStripStatusLabel_TotalContacts.Size = New System.Drawing.Size(194, 17)
        Me.ToolStripStatusLabel_TotalContacts.Text = "ToolStripStatusLabel_TotalContacts"
        '
        'ToolStripStatusLabel_Filter
        '
        Me.ToolStripStatusLabel_Filter.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatusLabel_Filter.Image = Global.SMS_Sender.My.Resources.Resources.filter_add_icon
        Me.ToolStripStatusLabel_Filter.Name = "ToolStripStatusLabel_Filter"
        Me.ToolStripStatusLabel_Filter.Size = New System.Drawing.Size(162, 17)
        Me.ToolStripStatusLabel_Filter.Text = "ToolStripStatusLabel_Filter"
        '
        'ToolStripStatusLabel_FilteredRows
        '
        Me.ToolStripStatusLabel_FilteredRows.Name = "ToolStripStatusLabel_FilteredRows"
        Me.ToolStripStatusLabel_FilteredRows.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel_FilteredRows.Text = "ToolStripStatusLabel1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Group:"
        '
        'cboGroupName
        '
        Me.cboGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGroupName.FormattingEnabled = True
        Me.cboGroupName.Location = New System.Drawing.Point(58, 246)
        Me.cboGroupName.Name = "cboGroupName"
        Me.cboGroupName.Size = New System.Drawing.Size(229, 21)
        Me.cboGroupName.TabIndex = 18
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabGroupDetail)
        Me.TabControl1.Controls.Add(Me.TabStatus)
        Me.TabControl1.Location = New System.Drawing.Point(10, 275)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(653, 289)
        Me.TabControl1.TabIndex = 19
        '
        'TabGroupDetail
        '
        Me.TabGroupDetail.Controls.Add(Me.Panel2)
        Me.TabGroupDetail.Controls.Add(Me.Panel1)
        Me.TabGroupDetail.Location = New System.Drawing.Point(4, 22)
        Me.TabGroupDetail.Name = "TabGroupDetail"
        Me.TabGroupDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGroupDetail.Size = New System.Drawing.Size(645, 263)
        Me.TabGroupDetail.TabIndex = 1
        Me.TabGroupDetail.Text = "Group Details"
        Me.TabGroupDetail.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Grid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(639, 230)
        Me.Panel2.TabIndex = 1
        '
        'Grid
        '
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(639, 230)
        Me.Grid.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 27)
        Me.Panel1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Refresh, Me.ToolStripSeparator2, Me.ToolStripButton_SetStatus, Me.ToolStripButton_Add, Me.ToolStripButton_Delete, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cboFilter, Me.ToolStripLabel2, Me.txtFilterValue, Me.btnAddFilter, Me.btnClearFilter})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(639, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton_Refresh
        '
        Me.ToolStripButton_Refresh.Image = CType(resources.GetObject("ToolStripButton_Refresh.Image"), System.Drawing.Image)
        Me.ToolStripButton_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
        Me.ToolStripButton_Refresh.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton_Refresh.Text = "Refresh"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_SetStatus
        '
        Me.ToolStripButton_SetStatus.Image = CType(resources.GetObject("ToolStripButton_SetStatus.Image"), System.Drawing.Image)
        Me.ToolStripButton_SetStatus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_SetStatus.Name = "ToolStripButton_SetStatus"
        Me.ToolStripButton_SetStatus.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton_SetStatus.Text = "Set..."
        Me.ToolStripButton_SetStatus.ToolTipText = "Set Status AS"
        '
        'ToolStripButton_Add
        '
        Me.ToolStripButton_Add.Image = CType(resources.GetObject("ToolStripButton_Add.Image"), System.Drawing.Image)
        Me.ToolStripButton_Add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Add.Name = "ToolStripButton_Add"
        Me.ToolStripButton_Add.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton_Add.Text = "&Add"
        Me.ToolStripButton_Add.ToolTipText = "Add New Contact"
        '
        'ToolStripButton_Delete
        '
        Me.ToolStripButton_Delete.Image = CType(resources.GetObject("ToolStripButton_Delete.Image"), System.Drawing.Image)
        Me.ToolStripButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
        Me.ToolStripButton_Delete.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton_Delete.Text = "Remove "
        Me.ToolStripButton_Delete.ToolTipText = "Remove  Contact"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(33, 22)
        Me.ToolStripLabel1.Text = "Filter"
        '
        'cboFilter
        '
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(121, 25)
        Me.cboFilter.ToolTipText = "Select Filed to Filter"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "value"
        '
        'txtFilterValue
        '
        Me.txtFilterValue.Name = "txtFilterValue"
        Me.txtFilterValue.Size = New System.Drawing.Size(100, 25)
        Me.txtFilterValue.ToolTipText = "Type Filter Value here.."
        '
        'btnAddFilter
        '
        Me.btnAddFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddFilter.Image = CType(resources.GetObject("btnAddFilter.Image"), System.Drawing.Image)
        Me.btnAddFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddFilter.Name = "btnAddFilter"
        Me.btnAddFilter.Size = New System.Drawing.Size(23, 22)
        Me.btnAddFilter.Text = "ToolStripButton1"
        Me.btnAddFilter.ToolTipText = "Apply Filter"
        '
        'btnClearFilter
        '
        Me.btnClearFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClearFilter.Image = CType(resources.GetObject("btnClearFilter.Image"), System.Drawing.Image)
        Me.btnClearFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(23, 22)
        Me.btnClearFilter.Text = "ToolStripButton2"
        Me.btnClearFilter.ToolTipText = "Clear Filter"
        '
        'TabStatus
        '
        Me.TabStatus.BackColor = System.Drawing.Color.Transparent
        Me.TabStatus.Controls.Add(Me.lblLast25Min)
        Me.TabStatus.Controls.Add(Me.lblStatus)
        Me.TabStatus.Location = New System.Drawing.Point(4, 22)
        Me.TabStatus.Name = "TabStatus"
        Me.TabStatus.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStatus.Size = New System.Drawing.Size(645, 263)
        Me.TabStatus.TabIndex = 0
        Me.TabStatus.Text = "Status"
        Me.TabStatus.UseVisualStyleBackColor = True
        '
        'lblLast25Min
        '
        Me.lblLast25Min.AutoSize = True
        Me.lblLast25Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast25Min.Location = New System.Drawing.Point(16, 59)
        Me.lblLast25Min.Name = "lblLast25Min"
        Me.lblLast25Min.Size = New System.Drawing.Size(98, 20)
        Me.lblLast25Min.TabIndex = 14
        Me.lblLast25Min.Text = "lblLast25Min"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(16, 28)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(71, 20)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "lblStatus"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button_SendTextMessage)
        Me.GroupBox1.Controls.Add(Me.btnDisconnect)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.txtMessage)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtConnectionParameter)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 195)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Message:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SMS_Sender.My.Resources.Resources.sms_icon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 134)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Button_SendTextMessage
        '
        Me.Button_SendTextMessage.Location = New System.Drawing.Point(497, 19)
        Me.Button_SendTextMessage.Name = "Button_SendTextMessage"
        Me.Button_SendTextMessage.Size = New System.Drawing.Size(132, 24)
        Me.Button_SendTextMessage.TabIndex = 26
        Me.Button_SendTextMessage.Text = "Send Test Message"
        Me.Button_SendTextMessage.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(394, 20)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(97, 23)
        Me.btnDisconnect.TabIndex = 25
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(300, 19)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(88, 23)
        Me.btnConnect.TabIndex = 24
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(139, 76)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(490, 102)
        Me.txtMessage.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Connection Paramerter :"
        '
        'txtConnectionParameter
        '
        Me.txtConnectionParameter.Location = New System.Drawing.Point(139, 21)
        Me.txtConnectionParameter.Name = "txtConnectionParameter"
        Me.txtConnectionParameter.Size = New System.Drawing.Size(155, 20)
        Me.txtConnectionParameter.TabIndex = 21
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(291, 245)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(80, 23)
        Me.btnImport.TabIndex = 21
        Me.btnImport.Text = "&Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(370, 245)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 23)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'AxKylixSMS1
        '
        Me.AxKylixSMS1.Enabled = True
        Me.AxKylixSMS1.Location = New System.Drawing.Point(761, 404)
        Me.AxKylixSMS1.Name = "AxKylixSMS1"
        Me.AxKylixSMS1.OcxState = CType(resources.GetObject("AxKylixSMS1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxKylixSMS1.Size = New System.Drawing.Size(32, 32)
        Me.AxKylixSMS1.TabIndex = 0
        '
        'AxKylixSMS2
        '
        Me.AxKylixSMS2.Enabled = True
        Me.AxKylixSMS2.Location = New System.Drawing.Point(469, 256)
        Me.AxKylixSMS2.Name = "AxKylixSMS2"
        Me.AxKylixSMS2.OcxState = CType(resources.GetObject("AxKylixSMS2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxKylixSMS2.Size = New System.Drawing.Size(32, 32)
        Me.AxKylixSMS2.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 589)
        Me.Controls.Add(Me.AxKylixSMS2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cboGroupName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.AxKylixSMS1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Short Message Sender [Version 2.5]"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabGroupDetail.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabStatus.ResumeLayout(False)
        Me.TabStatus.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxKylixSMS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxKylixSMS2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxKylixSMS1 As AxKYLIXSMSLib.AxKylixSMS
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportContactsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboGroupName As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabStatus As System.Windows.Forms.TabPage
    Friend WithEvents TabGroupDetail As System.Windows.Forms.TabPage
    Friend WithEvents lblLast25Min As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents AboutToolStripMenuItem_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_SendTextMessage As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConnectionParameter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Add As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel_TotalContacts As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFilterValue As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnAddFilter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClearFilter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel_Filter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_FilteredRows As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_SetStatus As System.Windows.Forms.ToolStripButton
    Friend WithEvents AxKylixSMS2 As AxKYLIXSMSLib.AxKylixSMS

End Class
