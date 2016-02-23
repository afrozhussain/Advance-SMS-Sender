Imports System.Windows.Forms

Public Class frmSendMessage

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If txtCellNumber.Text = "" Then
            MsgBox("Ener Cell Number and Send again", MsgBoxStyle.Exclamation)
            txtCellNumber.Focus()
            Exit Sub
        End If

        If txtMessage.Text = "" Then
            MsgBox("Enter Message and Send again", MsgBoxStyle.Exclamation)
            txtMessage.Focus()
            Exit Sub
        End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSendMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCellNumber.Focus()

        txtCellNumber.Text = String.Empty
        txtMessage.Text = String.Empty

    End Sub
End Class
