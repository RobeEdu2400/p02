Public Class Lenguaje
    Sub Textos_cambios()
        If (Form1.Lenguaje.SelectedItem = "Español") Then
            Form1.Label1.Text = "Introduce los números"
            Form1.Label16.Text = "Ordenar"
            Form1.Label15.Text = "Introduce mes y año"
            Form1.Label12.Text = "Mes"
            Form1.Label13.Text = "Año"
            Form1.Label17.Text = "Ultimo diá del mes del año"
            Form1.Label11.Text = "Números de cajas divisibles"
            Form1.Label14.Text = "Divisor"
            Form1.RadioButton1.Text = "Ascendente"
            Form1.RadioButton2.Text = "Descendente"
            Form1.Button3.Text = "Ultimo Día"
            Form1.Button1.Text = "Divisibles"
            Form1.Ordenación.Text = "Ordenación"
        ElseIf (Form1.Lenguaje.SelectedItem = "Català") Then
            Form1.Label1.Text = "Introdueix els números"
            Form1.Label16.Text = "Ordenar"
            Form1.Label15.Text = "Introdueix mes i any"
            Form1.Label12.Text = "Mes"
            Form1.Label13.Text = "Any"
            Form1.Label17.Text = "Darrer diá del mes de l'any"
            Form1.Label11.Text = "Números de caixes divisibles"
            Form1.Label14.Text = "Divisor"
            Form1.RadioButton1.Text = "Ascendent"
            Form1.RadioButton2.Text = "Descendant"
            Form1.Button3.Text = "Darrer Dia"
            Form1.Button1.Text = "Divisibles"
            Form1.Ordenación.Text = "Ordenació"
        End If
    End Sub
End Class
