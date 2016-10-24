Public Class Form1
    Private Sub Ordenación_Click(sender As Object, e As EventArgs) Handles Ordenación.Click
        Try
            TextBox1.Text = CInt(Text)

        Catch ex As Exception
            MsgBox()
        End Try
    End Sub
End Class
