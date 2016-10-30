Public Class Form1
    Dim tNumeros(8) As Integer
    Private Sub Ordenación_Click(sender As Object, e As EventArgs) Handles Ordenación.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim valor3 As Integer
        Dim valor4 As Integer
        Dim valor5 As Integer
        Dim valor6 As Integer
        Dim valor7 As Integer
        Dim valor8 As Integer
        If (TextBox1.Text <> "") Then
            Try
                valor1 = CInt(TextBox1.Text)
                TextBox1.BackColor = Color.White

            Catch ex As Exception
                MsgBox("El primer textbox es un valro erroneo")
                TextBox1.Focus()
                TextBox1.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox1.BackColor = Color.White
        End If
        If (TextBox2.Text <> "") Then
            Try
                valor2 = CInt(TextBox2.Text)
                TextBox1.BackColor = Color.White

            Catch ex As Exception
                MsgBox("El segundo textbox es un valro erroneo")
                TextBox2.Focus()
                TextBox2.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox2.BackColor = Color.White
        End If

        If (TextBox3.Text <> "") Then
            Try
                valor3 = CInt(TextBox3.Text)
                TextBox3.BackColor = Color.White

            Catch ex As Exception
                MsgBox("El tercero textbox es un valro erroneo")
                TextBox3.Focus()
                TextBox3.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox3.BackColor = Color.White
        End If

        If (TextBox4.Text <> "") Then
            Try
                valor4 = CInt(TextBox4.Text)
                TextBox4.BackColor = Color.White

            Catch ex As Exception
                MsgBox("El cuarto textbox es un valro erroneo")
                TextBox4.Focus()
                TextBox4.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox4.BackColor = Color.White
        End If

        If (TextBox5.Text <> "") Then
            Try
                valor5 = CInt(TextBox5.Text)
                TextBox5.BackColor = Color.White

            Catch ex As Exception
                MsgBox("El quinto textbox es un valro erroneo")
                TextBox5.Focus()
                TextBox5.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox5.BackColor = Color.White
        End If

        If (TextBox6.Text <> "") Then
            Try
                valor6 = CInt(TextBox6.Text)
                TextBox6.BackColor = Color.White

            Catch ex As Exception
                MsgBox("El sexto textbox es un valro erroneo")
                TextBox6.Focus()
                TextBox6.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox6.BackColor = Color.White
        End If

        If (TextBox7.Text <> "") Then
            Try
                valor7 = CInt(TextBox7.Text)
                TextBox7.BackColor = Color.White

            Catch ex As Exception
                MsgBox("El septimo textbox es un valro erroneo")
                TextBox7.Focus()
                TextBox7.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox7.BackColor = Color.White
        End If

        If (TextBox8.Text <> "") Then
            Try
                valor8 = CInt(TextBox8.Text)
                TextBox8.BackColor = Color.White

            Catch ex As Exception
                MsgBox("El octavo textbox es un valro erroneo")
                TextBox8.Focus()
                TextBox8.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox8.BackColor = Color.White
        End If

        tNumeros = {valor1, valor2, valor3, valor4, valor5, valor6, valor7, valor8}

        For c = 0 To 7
            For c1 = c To 7
                If (tNumeros(c) > tNumeros(c1)) Then
                    Dim auxiliar As Integer
                    auxiliar = tNumeros(c1)
                    tNumeros(c1) = tNumeros(c)
                    tNumeros(c) = auxiliar
                End If
            Next c1
        Next c

        TextBox1.Text = tNumeros(0)
        TextBox2.Text = tNumeros(1)
        TextBox3.Text = tNumeros(2)
        TextBox4.Text = tNumeros(3)
        TextBox5.Text = tNumeros(4)
        TextBox6.Text = tNumeros(5)
        TextBox7.Text = tNumeros(6)
        TextBox8.Text = tNumeros(7)

    End Sub
End Class