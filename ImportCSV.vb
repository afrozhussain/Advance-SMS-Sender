Imports System.Windows.Forms
Imports System.Data.SQLite
Imports System.IO

Public Class frmImportCSV

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

 
    Private Sub Button_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Browse.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "CSV (*.csv)|*.csv"
            If (.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                txtPath.Text = OpenFileDialog1.FileName
            End If
        End With
    End Sub


    Private Function LoadCSV(ByVal FilePath As String, ByVal GroupName As String) As Boolean

        ' ---- Try to Read CSV File
        Dim CSVData As String()

        Try

            CSVData = File.ReadAllLines(FilePath)
            lblFileLength.Text = "File Contains: " & CSVData.Length.ToString("#,###,##0") & " Contacts"

            If CSVData.Length = 0 Then
                MsgBox("CSV File is Empty, No Data Uploaded", MsgBoxStyle.Exclamation)
                Return False
            End If

        Catch ex As Exception
            MsgBox("Error in LoadCSV() " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try


        '------------------------------------------
        Dim cnn As New SQLite.SQLiteConnection(String.Format("Data Source={0}", Application.StartupPath + "\database.s3db"))
        Dim tx As SQLiteTransaction
        Dim para_CellNumber As New SQLiteParameter("p_CellNumber")
        Dim para_GroupCode As New SQLiteParameter("p_GroupCode")
        Dim command As SQLiteCommand = cnn.CreateCommand
        Dim Reader As SQLiteDataReader

        Try

            cnn.Open()

            '====================== Create Group Name ================
            command.CommandText = String.Format("SELECT * FROM ContactGroups WHERE GroupName = '{0}'", GroupName)
            command.Connection = cnn

            Reader = command.ExecuteReader

            If Reader.Read Then
                MsgBox("Group Name " & GroupName & " already exist! Please provide another name", MsgBoxStyle.Exclamation)
                txtGroupName.SelectAll()
                txtGroupName.Focus()
                Return False
            End If

            Reader.Close()

            command.CommandText = String.Format("INSERT INTO ContactGroups (GroupName) VALUES ('{0}')", GroupName)
            command.ExecuteNonQuery()

            '>> Read Group Code
            command.CommandText = "SELECT MAX(code) Max_Code FROM ContactGroups"
            Reader = command.ExecuteReader

            Dim GroupCode As Integer
            If Reader.Read Then
                GroupCode = Reader.Item("Max_Code")
            Else
                MsgBox("Error in Reading Group Code", "Upload Failed", MsgBoxStyle.Critical)
                Return False
            End If

            Reader.Close()

            '=================== Start Inserting Contacts ============

            command.Parameters.Add(para_CellNumber)
            command.Parameters.Add(para_GroupCode)

            tx = cnn.BeginTransaction

            Dim counter As Integer

            While (counter <= CSVData.Length - 1)

                para_CellNumber.Value = CSVData(counter)
                para_GroupCode.Value = GroupCode

                command.CommandText = " INSERT INTO Contacts (CellNumber, GroupCode) " & _
                                               " VALUES (@p_CellNumber, @p_GroupCode) "

                command.ExecuteNonQuery()
                counter = counter + 1

            End While

            tx.Commit()

        Catch ex As Exception
            MsgBox("Error in LoadCSV() " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            cnn.Close()
            cnn.Dispose()
            command.Dispose()
        End Try

        Return True


    End Function


    Private Sub frmImportCSV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFileLength.Text = ""
        lblLoadStatus.Text = ""
        txtGroupName.Text = ""
        txtPath.Text = ""

    End Sub

    Private Sub Button_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_load.Click


        If txtGroupName.Text = "" Then
            MsgBox("Please Provide valid Group Name and try again", MsgBoxStyle.Exclamation)
            txtGroupName.Focus()
            Exit Sub
        End If

        If txtPath.Text = "" Then
            MsgBox("Please Provide valid CVS File Name and try again", MsgBoxStyle.Exclamation)
            txtPath.Focus()
            Exit Sub
        End If


        If LoadCSV(txtPath.Text, txtGroupName.Text) Then
            MsgBox("Uploaded", MsgBoxStyle.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
