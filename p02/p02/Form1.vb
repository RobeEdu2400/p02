Public Class Form1
    Private Sub Ordenación_Click(sender As Object, e As EventArgs) Handles Ordenación.Click

        If (TextBox1.Text <> "") Then
            Try
                Dim valor1 As Integer
                valor1 = CInt(TextBox1.Text)
                TextBox1.BackColor = Color.White

            Catch ex As Exception
                MsgBox("El primer textbox es un valro erroneo")
                TextBox1.Focus()
                TextBox1.BackColor = Color.Red
                Exit Sub
            End Try
        End If
        Try

            Dim valor2 As Integer
            valor2 = CInt(TextBox2.Text)
            TextBox2.BackColor = Color.White

        Catch ex As Exception
            MsgBox("El segundo textbox es un valro erroneo")
            TextBox2.Focus()
            TextBox2.BackColor = Color.Red
            Exit Sub
        End Try

        Try

            Dim valor3 As Integer
            valor3 = CInt(TextBox3.Text)
            TextBox3.BackColor = Color.White

        Catch ex As Exception
            MsgBox("El tercer textbox es un valro erroneo")
            TextBox3.Focus()
            TextBox3.BackColor = Color.Red
            Exit Sub
        End Try

        Try

            Dim valor4 As Integer
            valor4 = CInt(TextBox4.Text)
            TextBox4.BackColor = Color.White


        Catch ex As Exception
            MsgBox("El cuarto textbox es un valro erroneo")
            TextBox4.Focus()
            TextBox4.BackColor = Color.Red
            Exit Sub
        End Try

        Try

            Dim valor5 As Integer
            valor5 = CInt(TextBox5.Text)
            TextBox5.BackColor = Color.White


        Catch ex As Exception
            MsgBox("El quinto textbox es un valro erroneo")
            TextBox5.Focus()
            TextBox5.BackColor = Color.Red
            Exit Sub
        End Try

        Try

            Dim valor6 As Integer
            valor6 = CInt(TextBox6.Text)
            TextBox6.BackColor = Color.White


        Catch ex As Exception
            MsgBox("El sexo textbox es un valro erroneo")
            TextBox6.Focus()
            TextBox6.BackColor = Color.Red
            Exit Sub
        End Try

        Try

            Dim valor7 As Integer
            valor7 = CInt(TextBox7.Text)
            TextBox7.BackColor = Color.White


        Catch ex As Exception
            MsgBox("El septimo textbox es un valro erroneo")
            TextBox7.Focus()
            TextBox7.BackColor = Color.Red
            Exit Sub
        End Try

        Try

            Dim valor8 As Integer
            valor8 = CInt(TextBox8.Text)
            TextBox8.BackColor = Color.White


        Catch ex As Exception
            MsgBox("El octavo textbox es un valro erroneo")
            TextBox8.BackColor = Color.Red
            TextBox8.Focus()
            Exit Sub
        End Try

    End Sub


End Class
