Imports System.IO
Module GlobalValues


    Public Global_ConnectionString = String.Format("Data Source={0}", Application.StartupPath + "\database.s3db")

    Public ErrorsList As Hashtable = New Hashtable


    Public Sub LoadErrors()

        ErrorsList.Add("1", "SUCCEED")
        ErrorsList.Add("-1", "FAILED")
        ErrorsList.Add("-5", "NOT CONNECTED")
        ErrorsList.Add("-9", "PHONE BUSY")
        ErrorsList.Add("-63", "BUSY SENDING")

    End Sub


End Module
