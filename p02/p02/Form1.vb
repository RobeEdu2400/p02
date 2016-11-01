Public Class Form1
    Dim tNumeros(7) As String
    Dim continuar As Boolean
    Dim qt As Integer
    Private Sub Ordenación_Click(sender As Object, e As EventArgs) Handles Ordenación.Click
        continuar = False
        comprobacionTexto()
        If (continuar = False) Then
            Exit Sub
        End If
        Dim auxiliar As String
        If (RadioButton2.Checked = True) Then
            For c = 0 To 7
                For c1 = c To 7
                    If (CInt(tNumeros(c)) < CInt(tNumeros(c1))) Then
                        auxiliar = tNumeros(c1)
                        tNumeros(c1) = tNumeros(c)
                        tNumeros(c) = auxiliar
                    End If
                Next c1
            Next c
        ElseIf (RadioButton1.Checked = True) Then
            For c = 0 To 7
                For c1 = c To 7
                    If (CInt(tNumeros(c)) > CInt(tNumeros(c1))) Then
                        auxiliar = tNumeros(c1)
                        tNumeros(c1) = tNumeros(c)
                        tNumeros(c) = auxiliar
                    End If
                Next c1
            Next c
        End If
        TextBox1.Text = tNumeros(0)
        TextBox2.Text = tNumeros(1)
        TextBox3.Text = tNumeros(2)
        TextBox4.Text = tNumeros(3)
        TextBox5.Text = tNumeros(4)
        TextBox6.Text = tNumeros(5)
        TextBox7.Text = tNumeros(6)
        TextBox8.Text = tNumeros(7)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        continuar = False
        comprobacionTexto()
        If (continuar = False) Then
            Exit Sub
        End If
        TextBox1.Text = tNumeros(0)
        TextBox2.Text = tNumeros(1)
        TextBox3.Text = tNumeros(2)
        TextBox4.Text = tNumeros(3)
        TextBox5.Text = tNumeros(4)
        TextBox6.Text = tNumeros(5)
        TextBox7.Text = tNumeros(6)
        TextBox8.Text = tNumeros(7)
        Dim contador As Integer = 0
        Dim divisor As Integer
        Try
            divisor = CInt(TextBox9.Text)
            For c = 0 To 7
                If (tNumeros(c) Mod divisor = 0) Then
                    If (tNumeros(c) <> 0) Then
                        contador = contador + 1
                    End If
                End If
            Next
            MsgBox("Hay en total de: " + CStr(contador) + " textbox que son divisibles por el número que ha introducido")

        Catch
            MsgBox("No se puede realizar la operación")
            Exit Sub

        End Try

    End Sub
    Private Sub comprobacionTexto()
        If (TextBox1.Text <> "") Then
            Try
                tNumeros(0) = CDbl(TextBox1.Text)
                TextBox1.BackColor = Color.White
            Catch ex As Exception
                MsgBox("Nº1 es un valor erroneo, introduce un número")
                TextBox1.Focus()
                TextBox1.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox1.BackColor = Color.White
        End If
        If (TextBox2.Text <> "") Then
            Try
                tNumeros(1) = CDbl(TextBox2.Text)
                TextBox2.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº2 es un valor erroneo, introduce un número")
                TextBox2.Focus()
                TextBox2.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox2.BackColor = Color.White
        End If

        If (TextBox3.Text <> "") Then
            Try
                tNumeros(2) = CDbl(TextBox3.Text)
                TextBox3.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº3 es un valor erroneo, introduce un número")
                TextBox3.Focus()
                TextBox3.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox3.BackColor = Color.White
        End If

        If (TextBox4.Text <> "") Then
            Try
                tNumeros(3) = CDbl(TextBox4.Text)
                TextBox4.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº4 es un valor erroneo, introduce un número")
                TextBox4.Focus()
                TextBox4.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox4.BackColor = Color.White
        End If

        If (TextBox5.Text <> "") Then
            Try
                tNumeros(4) = CDbl(TextBox5.Text)
                TextBox5.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº5 es un valor erroneo, introduce un número")
                TextBox5.Focus()
                TextBox5.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox5.BackColor = Color.White
        End If

        If (TextBox6.Text <> "") Then
            Try
                tNumeros(5) = CDbl(TextBox6.Text)
                TextBox6.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº6 es un valor erroneo, introduce un número")
                TextBox6.Focus()
                TextBox6.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox6.BackColor = Color.White
        End If

        If (TextBox7.Text <> "") Then
            Try
                tNumeros(6) = CDbl(TextBox7.Text)
                TextBox7.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº7 es un valor erroneo, introduce un número")
                TextBox7.Focus()
                TextBox7.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox7.BackColor = Color.White
        End If

        If (TextBox8.Text <> "") Then
            Try
                tNumeros(7) = CDbl(TextBox8.Text)
                TextBox8.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº8 es un valor erroneo, introduce un número")
                TextBox8.Focus()
                TextBox8.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            TextBox8.BackColor = Color.White
        End If
        continuar = True
    End Sub

End Class