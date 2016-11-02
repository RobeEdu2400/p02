Public Class Form1
    Dim cambio As New Lenguaje
    Dim tNumeros(7) As String
    Dim continuar As Boolean
    Dim qt As Integer
    Private Sub Ordenación_Click(sender As Object, e As EventArgs) Handles btn1.Click
        continuar = False
        comprobacionTexto()
        If (continuar = False) Then
            Exit Sub
        End If
        Dim auxiliar As String
        If (rbtn2.Checked = True) Then
            For c = 0 To 7
                For c1 = c To 7
                    If (CInt(tNumeros(c)) < CInt(tNumeros(c1))) Then
                        auxiliar = tNumeros(c1)
                        tNumeros(c1) = tNumeros(c)
                        tNumeros(c) = auxiliar
                    End If
                Next c1
            Next c
        ElseIf (rbtn1.Checked = True) Then
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
        txt1.Text = tNumeros(0)
        txt2.Text = tNumeros(1)
        txt3.Text = tNumeros(2)
        txt4.Text = tNumeros(3)
        txt5.Text = tNumeros(4)
        txt6.Text = tNumeros(5)
        txt7.Text = tNumeros(6)
        txt8.Text = tNumeros(7)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn4.Click
        continuar = False
        comprobacionTexto()
        If (continuar = False) Then
            Exit Sub
        End If
        txt1.Text = tNumeros(0)
        txt2.Text = tNumeros(1)
        txt3.Text = tNumeros(2)
        txt4.Text = tNumeros(3)
        txt5.Text = tNumeros(4)
        txt6.Text = tNumeros(5)
        txt7.Text = tNumeros(6)
        txt8.Text = tNumeros(7)
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
        If (txt1.Text <> "") Then
            Try
                tNumeros(0) = CDbl(txt1.Text)
                txt1.BackColor = Color.White
            Catch ex As Exception
                MsgBox("Nº1 es un valor erroneo, introduce un número")
                txt1.Focus()
                txt1.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            txt1.BackColor = Color.White
        End If
        If (txt2.Text <> "") Then
            Try
                tNumeros(1) = CDbl(txt2.Text)
                txt2.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº2 es un valor erroneo, introduce un número")
                txt2.Focus()
                txt2.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            txt2.BackColor = Color.White
        End If

        If (txt3.Text <> "") Then
            Try
                tNumeros(2) = CDbl(txt3.Text)
                txt3.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº3 es un valor erroneo, introduce un número")
                txt3.Focus()
                txt3.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            txt3.BackColor = Color.White
        End If

        If (txt4.Text <> "") Then
            Try
                tNumeros(3) = CDbl(txt4.Text)
                txt4.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº4 es un valor erroneo, introduce un número")
                txt4.Focus()
                txt4.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            txt4.BackColor = Color.White
        End If

        If (txt5.Text <> "") Then
            Try
                tNumeros(4) = CDbl(txt5.Text)
                txt5.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº5 es un valor erroneo, introduce un número")
                txt5.Focus()
                txt5.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            txt5.BackColor = Color.White
        End If

        If (txt6.Text <> "") Then
            Try
                tNumeros(5) = CDbl(txt6.Text)
                txt6.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº6 es un valor erroneo, introduce un número")
                txt6.Focus()
                txt6.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            txt6.BackColor = Color.White
        End If

        If (txt7.Text <> "") Then
            Try
                tNumeros(6) = CDbl(txt7.Text)
                txt7.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº7 es un valor erroneo, introduce un número")
                txt7.Focus()
                txt7.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            txt7.BackColor = Color.White
        End If

        If (txt8.Text <> "") Then
            Try
                tNumeros(7) = CDbl(txt8.Text)
                txt8.BackColor = Color.White

            Catch ex As Exception
                MsgBox("Nº8 es un valor erroneo, introduce un número")
                txt8.Focus()
                txt8.BackColor = Color.Red
                Exit Sub
            End Try
        Else
            txt8.BackColor = Color.White
        End If
        continuar = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lenguaje.SelectedItem = "Español"
    End Sub

    Private Sub Lenguaje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lenguaje.SelectedIndexChanged
        cambio.Textos_cambios()
    End Sub
End Class