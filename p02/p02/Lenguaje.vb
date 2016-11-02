Public Class Lenguaje
    Sub Textos_cambios()
        If (Form1.Lenguaje.SelectedItem = "Español") Then
            Form1.lbl1.Text = "Introduce los números"
            Form1.lbl7.Text = "Ordenar"
            Form1.lbl3.Text = "Introduce mes y año"
            Form1.lbl4.Text = "Mes"
            Form1.lbl5.Text = "Año"
            Form1.lbl6.Text = "Ultimo diá del mes del año"
            Form1.lbl12.Text = "Números de cajas divisibles"
            Form1.lbl13.Text = "Divisor"
            Form1.rbtn1.Text = "Ascendente"
            Form1.rbtn2.Text = "Descendente"
            Form1.btn2.Text = "Ultimo Día"
            Form1.btn4.Text = "Divisibles"
            Form1.btn1.Text = "Ordenación"
            Form1.lbl14.Text = "Elige Idioma"
        ElseIf (Form1.Lenguaje.SelectedItem = "Català") Then
            Form1.lbl1.Text = "Introdueix els números"
            Form1.lbl7.Text = "Ordenar"
            Form1.lbl3.Text = "Introdueix mes i any"
            Form1.lbl4.Text = "Mes"
            Form1.lbl5.Text = "Any"
            Form1.lbl6.Text = "Darrer diá del mes de l'any"
            Form1.lbl12.Text = "Números de caixes divisibles"
            Form1.lbl13.Text = "Divisor"
            Form1.rbtn1.Text = "Ascendent"
            Form1.rbtn2.Text = "Descendent"
            Form1.btn2.Text = "Darrer Dia"
            Form1.btn4.Text = "Divisibles"
            Form1.btn1.Text = "Ordenació"
            Form1.lbl14.Text = "Tria Idioma"
        End If
    End Sub
End Class
