Imports System.Data.OleDb
Module xDBConnection
    Public xConn As New OleDbConnection
    Dim DBprovider As String
    Dim DBSourse As String

    Friend Sub xConnopen()
        xConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\My\Projects\D\F Project\Database.mdb"
        xConn.Open()
    End Sub

    Friend Sub xConnClose()
        xConn.Close()
    End Sub
End Module
