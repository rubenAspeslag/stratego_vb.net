Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb
Module functions
    Public Function executeQ(Query)

        Dim connStr As String = "server=localhost;user=root;database=stratego;port=3307;password=usbw;"
        Dim con As New MySqlConnection(connStr)
        con.Open()

        Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
        MsgBox(Query)
        Dim y As Integer = cmd.ExecuteNonQuery()
        Dim x
        If (y > 0) Then
            x = True
        Else
            x = False
        End If

        Return x
    End Function
End Module
