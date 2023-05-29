Imports System.Net
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Data.SqlClient

Public Class Cadastro
    Private con As SqlConnection
    Private cmd As SqlCommand

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" AndAlso TextBox3.Text <> "" Then
            Try
                con = New SqlConnection("Data Source=DESKTOP-2JG23SD\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True")
                con.Open()
                ServicePointManager.ServerCertificateValidationCallback = Nothing

                ' Verifique se o usuário já existe no banco de dados
                cmd = New SqlCommand("SELECT COUNT(*) FROM User_1 WHERE usuario = @usuario", con)
                cmd.Parameters.AddWithValue("@usuario", TextBox2.Text)
                Dim userCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If userCount > 0 Then
                    MsgBox("O usuário já existe. Escolha outro nome de usuário.")
                Else
                    ' Insira os dados no banco de dados
                    cmd = New SqlCommand("INSERT INTO User_1 (nome, usuario, senha) VALUES (@nome, @usuario, @senha)", con)
                    cmd.Parameters.AddWithValue("@nome", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@usuario", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@senha", TextBox3.Text)
                    cmd.ExecuteNonQuery()

                    MsgBox("Registro efetuado com sucesso!")

                    ' Limpe os campos de entrada de texto após o registro
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                End If
            Catch ex As Exception
                MsgBox("Ocorreu um erro ao registrar: " & ex.Message)
            Finally
                If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then con.Close()
            End Try
        Else
            MsgBox("Preencha todos os campos para se registrar.")
        End If
    End Sub

    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
