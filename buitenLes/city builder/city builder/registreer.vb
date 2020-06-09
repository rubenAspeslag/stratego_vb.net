Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Public Class registreer
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistreer_Click(sender As Object, e As EventArgs) Handles btnRegistreer.Click


        registreeren()



    End Sub

    Private Sub registreeren()

        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Dim connectionString As String = "server=localhost;user=root;database=cityBuilder;port=3307;password=usbw;"
        Dim SQLConnection As MySqlConnection = New MySqlConnection
        Dim oDt_sched As New DataTable()
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Try

            str_carSql = "insert into user (voornaam, naam, password,admin, username  ) values (@naam,@voornaam,@w1 ,@admin,@username)"
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = str_carSql
            sqlCommand.Parameters.AddWithValue("@naam", txtNaam.Text)
            sqlCommand.Parameters.AddWithValue("@username", txtUsername.Text)
            sqlCommand.Parameters.AddWithValue("@voornaam", txtVoornaam.Text)
            sqlCommand.Parameters.AddWithValue("@w1", txtWachtwoord1.Text)
            sqlCommand.Parameters.AddWithValue("@Admin", False)




            sqlCommand.ExecuteNonQuery()

            play.Show()
            Me.Hide()

        Catch ex As Exception
            If ex.Message.Contains("username") Then
                MsgBox("username reeds in gebruik, gelieve eens een andere te probeeren")
            Else
                MsgBox("there went somthing wrong, please try again. registreer.vb")
            End If

        End Try
    End Sub

    Private Sub registreer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class