
Public Class Form1

    Private _TableName As String = "WebsiteInfo"

    'Private objSMS As mCore.SMS
    Private m_TotalContacts As Integer
    Private m_ContinueSending As Boolean = False
    Private max_sms_limit As Integer
    Private max_time_limit As Integer


    Private Sub SetModemConnected(ByVal status As Boolean)

        txtConnectionParameter.Enabled = Not status
        btnConnect.Enabled = Not status
        btnDisconnect.Enabled = status
        Button_SendTextMessage.Enabled = status
        btnSend.Enabled = status
        txtMessage.Enabled = status

    End Sub


    Private Sub FormatRowColor()

        Dim i As Integer

        For i = 0 To Grid.Rows.Count - 1

            If Grid.Rows(i).Cells("sent_status").Value = "1" Then
                Grid.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen

            End If


        Next

    End Sub


    Private Sub LoadGroupDetails()


        Dim cnn As New SQLite.SQLiteConnection
        cnn.ConnectionString = Global_ConnectionString

        Dim dt As New DataTable
        Dim da As New SQLite.SQLiteDataAdapter
        Dim command As SQLite.SQLiteCommand = cnn.CreateCommand

        Try
            cnn.Open()
            da.SelectCommand = command

            'command.CommandText = String.Format("SELECT * FROM Contacts WHERE GroupCode = '{0}'", cboGroupName.SelectedValue.ToString())
            command.CommandText = String.Format(" SELECT code,CellNumber,GroupCode,Sent_Time,ref, " & _
                                                " CASE WHEN Sent_Status = '0' THEN '-' WHEN Sent_Status = '1' THEN 'SENT' END as Sent_Status" & _
                                                " FROM Contacts WHERE GroupCode = '{0}'", cboGroupName.SelectedValue.ToString())


            da.Fill(dt)

            With Grid
                .DataSource = dt
                '.Rows(0).DefaultCellStyle.BackColor = Color.LightGreen
            End With

            m_TotalContacts = dt.Rows.Count
            ToolStripStatusLabel_TotalContacts.Text = "Total Contacts : " & String.Format("{0:#,###,##0}", m_TotalContacts)

            'FormatRowColor()

            With Grid
                .Columns("Code").Visible = False
                .Columns("GroupCode").Visible = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns("Sent_Time").ReadOnly = True
                .Columns("ref").ReadOnly = True
                .Columns("sent_status").ReadOnly = True

                .Columns("cellNumber").HeaderText = "Cell Number"
                .Columns("Sent_Status").HeaderText = "Sent Status"
                .Columns("Sent_Time").HeaderText = "Sent Time"



                If cboGroupName.SelectedValue.ToString = "" Then

                    ToolStripButton_Delete.Enabled = False
                    ToolStripButton_Refresh.Enabled = False
                    ToolStripButton_Add.Enabled = False

                    ClearFilter()

                    cboFilter.Enabled = False
                    txtFilterValue.Enabled = False
                    btnAddFilter.Enabled = False
                    btnClearFilter.Enabled = False
                    cboFilter.SelectedIndex = -1
                    txtFilterValue.Text = ""
                    ToolStripStatusLabel_Filter.Text = ""
                    ToolStripStatusLabel_Filter.Visible = False
                    ToolStripStatusLabel_FilteredRows.Text = ""




                    ToolStripButton_SetStatus.Enabled = False


                Else
                    ToolStripButton_Delete.Enabled = True
                    ToolStripButton_Refresh.Enabled = True
                    ToolStripButton_Add.Enabled = True
                    ToolStripButton_SetStatus.Enabled = True

                    ClearFilter()
                    cboFilter.Enabled = True
                    txtFilterValue.Enabled = True
                    btnAddFilter.Enabled = True
                    btnClearFilter.Enabled = False

                End If

            End With

            ' ClearFilter()

        Catch ex As Exception
            MsgBox("Error in LoadGroupNames " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cnn.Close()
            cnn.Dispose()
            command.Dispose()
            da.Dispose()
        End Try

    End Sub

    Private Sub LoadGroupNames()

        Dim cnn As New SQLite.SQLiteConnection
        cnn.ConnectionString = Global_ConnectionString

        Dim dt As New DataTable
        Dim da As New SQLite.SQLiteDataAdapter
        Dim command As SQLite.SQLiteCommand = cnn.CreateCommand

        Try
            cnn.Open()
            da.SelectCommand = command

            command.CommandText = "SELECT * FROM ContactGroups"
            dt.Rows.Add(dt.NewRow)
            da.Fill(dt)

            With cboGroupName
                .DataSource = dt
                .DisplayMember = "GroupName"
                .ValueMember = "Code"
            End With


        Catch ex As Exception
            MsgBox("Error in LoadGroupNames " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cnn.Close()
            cnn.Dispose()
            command.Dispose()
            da.Dispose()
        End Try


    End Sub

    Private Function Connect() As Boolean

        With AxKylixSMS1

            .NeedLog = 1
            .PINCode = ""
            .ConnectionMode = 1
            .ConnectionProtocol = 1
            .ConnectionParameter = txtConnectionParameter.Text
            .RejectIncomingCall = 1
            .IsConcatenatedSMS = True
            .RequestDeliveryReport = False

        End With


        If AxKylixSMS1.Connect = 1 Then

            Me.Text = "Short Message Sender [Ver 2.5] - " & " Connected"
            SetModemConnected(True)
            SaveConfig(txtConnectionParameter.Text)
            Return True

        Else

            MsgBox("Problem in connecting the Modem", MsgBoxStyle.Exclamation)
            Me.Text = "Short Message Sender [Ver 2.5] - " & " Not Connected"

        End If

    End Function

    Private Sub SendSMS(ByVal GroupCode As String)

        SetStartSending(True)

        Dim sMSG = txtMessage.Text

        Timer1.Enabled = False

        'Dim strConn As String = "Data Source=.\sqlexpress;Initial Catalog=sms;Integrated Security=True"
        Dim cnn As New SQLite.SQLiteConnection
        cnn.ConnectionString = Global_ConnectionString

        Try
            cnn.Open()

            Dim command As New SQLite.SQLiteCommand
            command = cnn.CreateCommand()
            command.CommandText = String.Format("SELECT * FROM Contacts WHERE sent_status = '{0}' AND GroupCode = '{1}' LIMIT 450 ", "0", GroupCode)

            Dim da As New SQLite.SQLiteDataAdapter
            Dim ds As New DataSet

            da.SelectCommand = command
            da.Fill(ds)

            '----------------------
            Dim cnt As Integer = 0
            Dim cellNo As String
            Dim ref As Integer
            Dim ContactCode As String


            Dim Total_25min As Integer

            For cnt = 0 To ds.Tables(0).Rows.Count - 1

                'command.CommandText = String.Format("SELECT COUNT(*) Total FROM Contacts WHERE GroupCode = '{0}' AND " & _
                '                                   " strftime('%d-%m-%Y %H:%M:%S',sent_time) >=  strftime('%d-%m-%Y %H:%M:%S',datetime('now', 'localtime','-25 minutes'))", GroupCode)


                command.CommandText = String.Format("SELECT COUNT(*) Total FROM Contacts WHERE GroupCode = '{0}' AND " & _
                                                    "sent_time >= '{1}'", GroupCode, String.Format("{0:yyyy-MM-dd HH:mm}", Now.AddMinutes(-1)))


                Total_25min = command.ExecuteScalar
                lblLast25Min.Text = "Total SMS Sent in Last 25 min is " & Total_25min

                If Total_25min >= 450 Then
                    Exit For
                End If

                '------ Sent to Number ---- 
                cellNo = ds.Tables(0).Rows(cnt).Item("CellNumber").ToString
                ContactCode = ds.Tables(0).Rows(cnt).Item("Code").ToString

                ref = AxKylixSMS1.SendSMS(cellNo, sMSG)

                lblStatus.Text = "Counter = " & cnt + 1 & " -> Sending sms to : " & cellNo

                command.CommandText = " UPDATE Contacts SET sent_status=1, ref=" & ref & _
                                      " , sent_time= DateTime('now', 'localtime') " & _
                                      " WHERE Code='" & ContactCode & "' " & _
                                      " AND GroupCode = '" & GroupCode & "'"



                command.ExecuteNonQuery()

                If Not m_ContinueSending Then
                    lblStatus.Text = "Total " & cnt & " sms has been sent."
                    lblStatus.Text = "Stopped by user"
                    Timer1.Enabled = False
                    Exit For
                End If

            Next

            lblStatus.Text = "Total " & cnt & " sms has been sent."

            '---- Decide here to continue or not.

            command.CommandText = String.Format("SELECT Count(*) Total_Pending FROM Contacts WHERE sent_status = '{0}' AND GroupCode = '{1}' ", "0", GroupCode)

            If command.ExecuteScalar = 0 Then

                Timer1.Enabled = False
                MsgBox("Task Completed!", MsgBoxStyle.Information)
                lblStatus.Text = "Task Complete"
                SetStartSending(False)
            Else

                Timer1.Enabled = True
                Timer1.Start()
                lblStatus.Text = "Waiting for " & Timer1.Interval / 60000 & " minutes"
            End If


        Catch ex As Exception
            MsgBox("Err Connecting Database " & " Err:" & ex.Message, MsgBoxStyle.Critical)
        Finally
            cnn.Close()
            cnn.Dispose()

        End Try


        'Disposing ...
        'da.Dispose()
        'Command.Dispose()
        'cnn.Dispose()

    End Sub

    Private Sub SetStartSending(ByVal status As Boolean)


        btnSend.Enabled = Not status
        btnStop.Enabled = status
        btnDisconnect.Enabled = Not status
        Button_SendTextMessage.Enabled = Not status
        txtMessage.Enabled = Not status

        cboGroupName.Enabled = Not status
        btnImport.Enabled = Not status
        btnDelete.Enabled = Not status

        ToolStripButton_SetStatus.Enabled = Not status
        ToolStripButton_Add.Enabled = Not status
        ToolStripButton_Delete.Enabled = Not status


    End Sub


    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        If txtMessage.Text = String.Empty Then
            MsgBox("Provide Message Text and Try again", MsgBoxStyle.Exclamation)
            txtMessage.FindForm()
            Exit Sub
        End If

        m_ContinueSending = True
        TabControl1.SelectedIndex = 1
        SendSMS(cboGroupName.SelectedValue.ToString)

    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Connect()
        AxKylixSMS1.Visible = True

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        AxKylixSMS1.Disconnect()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        lblStatus.Text = ""
        lblLast25Min.Text = ""


        LoadErrors()
        Timer1.Interval = 60000 * 5
        Timer1.Enabled = False


        AxKylixSMS1.Visible = True

        AxKylixSMS1.RequestDeliveryReport = 0
        AxKylixSMS1.IsConcatenatedSMS = 1
        AxKylixSMS1.RejectIncomingCall = 1
        AxKylixSMS1.AutoDeleteNewSMS = True

        btnDisconnect.Enabled = True
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False
        Button_SendTextMessage.Enabled = False
        btnSend.Enabled = False
        btnStop.Enabled = False

        txtMessage.Enabled = False
        txtConnectionParameter.Enabled = True

        ToolStripButton_Add.Enabled = False
        ToolStripButton_Delete.Enabled = False
        ToolStripButton_Refresh.Enabled = False
        ToolStripStatusLabel_TotalContacts.Text = ""

        ToolStripStatusLabel_Filter.Visible = False
        ToolStripStatusLabel_Filter.Text = ""
        ToolStripStatusLabel_FilteredRows.Text = ""
        ToolStripButton_SetStatus.Enabled = False

        '------ Set Filter Controls

        cboFilter.Items.Add("")
        cboFilter.Items.Add("Cell Number")
        cboFilter.Items.Add("Sent Status")
        cboFilter.Items.Add("Sent Date")
        cboFilter.Items.Add("ref")

        cboFilter.Enabled = False
        txtFilterValue.Enabled = False
        btnAddFilter.Enabled = False
        btnClearFilter.Enabled = False


        With Grid
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .MultiSelect = False
        End With

        '-----------------------------
        LoadGroupNames()
        LoadConfig()


    End Sub

    Private Sub AxKylixSMS1_NewDeliveryReport(ByVal sender As Object, ByVal e As AxKYLIXSMSLib._DKylixSMSEvents_NewDeliveryReportEvent) Handles AxKylixSMS1.NewDeliveryReport
        MsgBox("Test")
        MsgBox(e.number, MsgBoxStyle.Information)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SendSMS(cboGroupName.SelectedValue)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxKylixSMS1.SendSMS("3326865439", "Salam...")
    End Sub

    Private Sub ImportContactsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportContactsToolStripMenuItem.Click
        frmImportCSV.ShowDialog()
    End Sub

    Private Sub btnConnect_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        Connect()

        'SetModemConnected(True)


    End Sub

    Private Sub btnDisconnect_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click

        SetModemConnected(False)

        With AxKylixSMS1
            .Disconnect()
        End With

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim cnn As New SQLite.SQLiteConnection
        cnn.ConnectionString = Global_ConnectionString

        Dim command As SQLite.SQLiteCommand = cnn.CreateCommand


        If MsgBox(String.Format("Do you want to Delete Group '{0}' and all it's contacts?", cboGroupName.SelectedText), MsgBoxStyle.Question + MessageBoxButtons.YesNo, "Please Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If


        Try
            cnn.Open()

            command.CommandText = String.Format("DELETE FROM Contacts WHERE GRoupCode = '{0}'", cboGroupName.SelectedValue)
            command.ExecuteNonQuery()

            command.CommandText = String.Format("DELETE FROM ContactGroups WHERE Code = '{0}'", cboGroupName.SelectedValue)
            command.ExecuteNonQuery()

            LoadGroupNames()
            LoadGroupDetails()

        Catch ex As Exception
            MsgBox("Error in btnDelete_Click() " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub ToolStripButton_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Refresh.Click

        LoadGroupDetails()

    End Sub

    Private Sub DeleteContact(ByVal code As Integer, ByVal CellNumber As String)

        Dim cnn As New SQLite.SQLiteConnection
        cnn.ConnectionString = Global_ConnectionString

        Dim command As SQLite.SQLiteCommand = cnn.CreateCommand


        If MsgBox(String.Format("Do you want to Delete Contact Number'{0}'?", CellNumber), MsgBoxStyle.Question + MessageBoxButtons.YesNo, "Please Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If


        Try
            cnn.Open()
            command.CommandText = String.Format("DELETE FROM Contacts WHERE Code = '{0}'", code)
            command.ExecuteNonQuery()
            LoadGroupDetails()
            Grid.Refresh()


        Catch ex As Exception
            MsgBox("Error in DeleteContact()" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub ToolStripButton_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Delete.Click

        If Grid.SelectedRows.Count = 0 Then
            MsgBox("Select Contact/Cell Number and try again", MsgBoxStyle.Exclamation)
            Grid.Focus()
            Exit Sub
        End If

        Dim code As String
        Dim cellnumber As String

        code = Grid.CurrentRow.Cells("Code").Value  'Grid.Rows(Grid.CurrentRow.).Cells("Code")
        cellnumber = Grid.CurrentRow.Cells("CellNumber").Value
        DeleteContact(code, cellnumber)

    End Sub

    Private Sub Grid_UserAddedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles Grid.UserAddedRow

        ToolStripButton_Add.Enabled = True

    End Sub

    Private Sub Grid_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellEndEdit

        ToolStripButton_Add.Enabled = True

    End Sub


    Private Sub cboGroupName_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGroupName.SelectionChangeCommitted
        LoadGroupDetails()
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click

        'LoadGroupNames()
        'LoadGroupDetails()

        If frmImportCSV.ShowDialog() = Windows.Forms.DialogResult.OK Then
            LoadGroupNames()
            cboGroupName.SelectedIndex = cboGroupName.Items.Count - 1
            LoadGroupDetails()
        End If

    End Sub

    Private Sub ToolStripButton_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Add.Click

        If frmAddNewContact.ShowDialog() = Windows.Forms.DialogResult.OK Then


            Dim CellNumnber As String = frmAddNewContact.txtCellNumber.Text.ToString
            Dim GroupCode As String = cboGroupName.SelectedValue



            Dim cnn As New SQLite.SQLiteConnection
            cnn.ConnectionString = Global_ConnectionString

            Try
                cnn.Open()
                Dim command As SQLite.SQLiteCommand = cnn.CreateCommand
                command.CommandText = String.Format("INSERT INTO Contacts (CellNumber, GroupCode) VALUES ( '{0}', '{1}')", CellNumnber, GroupCode)
                command.ExecuteNonQuery()

                LoadGroupDetails()

            Catch ex As Exception
                MsgBox("Error in ToolStripButton_Save_Click() " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            Finally
                cnn.Dispose()
            End Try


        End If

    End Sub


    Private Sub cboGroupName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGroupName.SelectedIndexChanged

    End Sub

    Private Sub btnAddFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFilter.Click

        '< Validate Filter>

        If cboFilter.SelectedIndex = 0 Or cboFilter.SelectedIndex = -1 Then
            MsgBox("Please select filed and try again", MsgBoxStyle.Information)
            cboFilter.Focus()
            Exit Sub
        End If

        If txtFilterValue.Text = "" Then
            MsgBox("Please provide filter value and try again", MsgBoxStyle.Information)
            txtFilterValue.Focus()
            Exit Sub
        End If

        '</ End Validation >


        '< Build Filter String >
        Dim sFilter As String = String.Empty


        Select Case cboFilter.SelectedIndex

            Case "1"    'Cell Number
                sFilter = String.Format("CellNumber= '{0}'", txtFilterValue.Text)
            Case "2"    'Sent_Status
                sFilter = String.Format("Sent_Status= '{0}'", txtFilterValue.Text)
            Case "3"    'Sent Date
                If Not (IsDate(txtFilterValue.Text)) Then
                    MsgBox("Date format is not correct, please provide date in correct format", MsgBoxStyle.Exclamation)
                    txtFilterValue.Focus()
                    Exit Sub
                End If

                Dim sDate As DateTime = txtFilterValue.Text

                Dim FilterDate As String = String.Format(sDate, "yyyy-mon-dd").ToString

                sFilter = String.Format("Sent_Time= '{0}'", String.Format(sDate, "dd-mm-yyyy"))

            Case "4"    'ref
                sFilter = String.Format("ref= '{0}'", txtFilterValue.Text)
        End Select

        '</ End Build>


        Dim dt As DataTable = Grid.DataSource
        dt.DefaultView.RowFilter = sFilter

        ToolStripStatusLabel_Filter.Text = String.Format("Filter: {0}", sFilter)
        ToolStripStatusLabel_Filter.Visible = True
        ToolStripStatusLabel_FilteredRows.Text = "| Filterd Contacts: " & dt.DefaultView.Count

        btnClearFilter.Enabled = True
        btnAddFilter.Enabled = False

        cboFilter.Enabled = False
        txtFilterValue.Enabled = False

    End Sub

    Private Sub ClearFilter()


        Dim dt As DataTable = Grid.DataSource
        dt.DefaultView.RowFilter = ""
        ToolStripStatusLabel_Filter.Text = ""
        ToolStripStatusLabel_Filter.Visible = False
        ToolStripStatusLabel_FilteredRows.Text = ""

        txtFilterValue.Text = ""
        cboFilter.SelectedIndex = 0

        btnClearFilter.Enabled = False
        btnAddFilter.Enabled = True

        cboFilter.Enabled = True
        txtFilterValue.Enabled = True

    End Sub

    Private Sub btnClearFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFilter.Click
        ClearFilter()
    End Sub

    Private Sub ToolStripButton_SetStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_SetStatus.Click


        If Grid.SelectedRows.Count = 0 Then
            MsgBox("Select Contact/Cell Number and try again", MsgBoxStyle.Exclamation)
            Grid.Focus()
            Exit Sub
        End If


        Dim current_Sent_Status As String = Grid.CurrentRow.Cells("Sent_Status").Value.ToString()
        Dim rsp As DialogResult

        With frmSetStatus
            .optCellNumber.Text = "Cell Number ->" & Grid.CurrentRow.Cells("CellNumber").Value
            .optCellNumber.Tag = Grid.CurrentRow.Cells("code").Value
            .optCellNumber.Checked = True

            If current_Sent_Status.ToUpper = "SENT" Then
                .optNotSent.Checked = True
            Else
                .optSent.Checked = True
            End If
            rsp = .ShowDialog()
        End With

        '------------------------------------------------------------
        If rsp = Windows.Forms.DialogResult.OK Then

            Dim New_Sent_Status As String
            Dim ContactCode As String

            If frmSetStatus.optNotSent.Checked Then
                New_Sent_Status = "0"
            Else
                New_Sent_Status = "1"
            End If

            Dim cnn As New SQLite.SQLiteConnection
            cnn.ConnectionString = Global_ConnectionString
            Dim command As SQLite.SQLiteCommand = cnn.CreateCommand

            '------
            Try
                cnn.Open()

                If frmSetStatus.optCellNumber.Checked Then
                    ContactCode = frmSetStatus.optCellNumber.Tag
                Else

                    Dim dt As DataTable = Grid.DataSource

                    If dt.DefaultView.Count = 0 Then
                        MsgBox("Nothing to Update", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                    Me.Cursor = Cursors.WaitCursor

                    Dim sComma As String
                    For i As Integer = 0 To dt.DefaultView.Count - 1

                        If i = 0 Then
                            sComma = ""
                        Else
                            sComma = ","
                        End If
                        ContactCode = ContactCode & sComma & dt.DefaultView.Item(i).Item("Code").ToString
                    Next
                End If

                command.CommandText = String.Format("UPDATE Contacts Set Sent_Status= '{0}' , Sent_Time = null, ref= null WHERE Code IN ({1})", New_Sent_Status, ContactCode)
                command.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox("Error in ToolStripButton_SetStatus_Click()" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            Finally
                Me.Cursor = Cursors.Default
                cnn.Dispose()
            End Try

            MsgBox("Status Changed Successfully", MsgBoxStyle.Information)
            LoadGroupDetails()

        End If

    End Sub

    Private Sub Button_SendTextMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SendTextMessage.Click




        If frmSendMessage.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Try
                Dim ref = AxKylixSMS1.SendSMS(frmSendMessage.txtCellNumber.Text, frmSendMessage.txtMessage.Text)

                If ErrorsList.Contains(ref.ToString) Then
                    MsgBox("Message Not Sent" & vbCrLf & vbCrLf & "Result: " & ErrorsList(ref.ToString).ToString, MsgBoxStyle.Information)
                Else

                    MsgBox("Message Sent" & vbCrLf & vbCrLf & "Ref=" & ref, MsgBoxStyle.Information)
                End If

            Catch ex As Exception
                MsgBox("Error in Sending " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

    Private Sub SaveConfig(ByVal ConnectionPara As String)

        Dim cnn As New SQLite.SQLiteConnection
        cnn.ConnectionString = Global_ConnectionString
        Dim command As SQLite.SQLiteCommand = cnn.CreateCommand

        Try

            cnn.Open()

            command.CommandText = String.Format("UPDATE Config SET ConnectionPara = '{0}' ", ConnectionPara)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error in Saving Configuration" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            cnn.Close()
            cnn.Dispose()
            command.Dispose()
        End Try

    End Sub

    Private Sub LoadConfig()

        Dim cnn As New SQLite.SQLiteConnection
        cnn.ConnectionString = Global_ConnectionString

        Try
            cnn.Open()
            Dim command As SQLite.SQLiteCommand = cnn.CreateCommand
            command.CommandText = "SELECT * FROM Config"
            Dim reader As SQLite.SQLiteDataReader = command.ExecuteReader

            If reader.Read Then
                txtConnectionParameter.Text = reader.Item("ConnectionPara").ToString
            End If

            reader.Close()
            cnn.Close()

        Catch ex As Exception
            MsgBox("Error in Saving Configuration" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            cnn.Close()
            cnn.Dispose()
        End Try
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click

        m_ContinueSending = False
        SetStartSending(False)
        Timer1.Enabled = False
        lblStatus.Text = "Stopped!"

    End Sub

    
    Private Sub AboutToolStripMenuItem_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem_About.Click
        MsgBox("Program Developed by ٓAfroz Hussain.", MsgBoxStyle.Information)
    End Sub

    
End Class
