Imports Microsoft.Data.SqlClient
Imports System.Net
Imports System.Windows

Public Class Form1
    Private con As SqlConnection
    Private cmd As SqlCommand
    Private rdr As SqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If Textuser.Text <> "" Then
            If Textsh.Text = "" Then
                MsgBox("DIGITE SUA SENHA")
                Textsh.Focus()
                Exit Sub
            End If

            Try
                con = New SqlConnection("Data Source=DESKTOP-2JG23SD\SQLEXPRESS;Initial Catalog=Cadastro1;Integrated Security=True")
                con.Open()
                ServicePointManager.ServerCertificateValidationCallback = Nothing

                cmd = New SqlCommand("SELECT * FROM User_1 WHERE usuario= @usuario AND senha= @senha", con)
                cmd.Parameters.AddWithValue("@usuario", Textuser.Text)
                cmd.Parameters.AddWithValue("@senha", Textsh.Text)
                rdr = cmd.ExecuteReader()

                If rdr.HasRows Then

                    MsgBox("Autenticado com sucesso!")

                    Dim form2 As New Form2()
                    form2.Show()
                    Me.Hide()
                Else

                    MsgBox("Digite um nome de usuário e senha válidos")

                    Textuser.Text = ""
                    Textsh.Text = ""

                    Textuser.Focus()
                End If
            Catch ex As Exception

                MsgBox("Ocorreu um erro: " & ex.Message)
            Finally
                If rdr IsNot Nothing Then rdr.Close()
                If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then con.Close()
            End Try
        Else
            MsgBox("DIGITE O NOME DE USUÁRIO")
            Textuser.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form3 As New Cadastro()
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub



End Class
