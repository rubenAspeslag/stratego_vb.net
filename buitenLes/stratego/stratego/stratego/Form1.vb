Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class frmJoin
    Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        Dim x = functions.executeQ("INSERT INTO `stratego`.`player` (`username`) VALUES ('" & txtUsername.Text & "')")
        If x = True Then
            'joint sucsefully 

            Dim connStr As String = "server=localhost;user=root;database=stratego;port=3307;password=usbw;"
            Dim conn As New MySqlConnection(connStr)

            Dim mySelectQuery As String = "SELECT * FROM stratego.player where username ='" & txtUsername.Text & "' "
            MsgBox(mySelectQuery)
            Dim myCommand As New MySqlCommand(mySelectQuery, conn)

            Dim rd As MySqlDataReader
            rd = myCommand.ExecuteReader()

            While (rd.Read())
                iduser = rd(0)
                username = rd(1)

            End While
        Else
            MsgBox("er ging iets mis. uw gebruikersnaam is moogelijk in gebruik.")

        End If
    End Sub
End Class
