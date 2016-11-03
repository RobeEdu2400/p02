Public Class Lenguaje
    Public Error1 As String
    Public Error2 As String
    Public Error3 As String
    Public Error4 As String
    Public Error5 As String
    Public Error6 As String
    Public Error7 As String
    Public Error8 As String
    Public Error9 As String
    Public Error10 As String

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
            Error1 = "Nº1 es un valor erroneo, introduce un número"
            Error2 = "Nº2 es un valor erroneo, introduce un número"
            Error3 = "Nº3 es un valor erroneo, introduce un número"
            Error4 = "Nº4 es un valor erroneo, introduce un número"
            Error5 = "Nº5 es un valor erroneo, introduce un número"
            Error6 = "Nº6 es un valor erroneo, introduce un número"
            Error7 = "Nº7 es un valor erroneo, introduce un número"
            Error8 = "Nº8 es un valor erroneo, introduce un número"
            Error9 = "Introduce un número entero en el año"
            Error10 = "Introduce un número entero en el mes"

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
            Error1 = "Nº1 és un valor erroni, introdueix un nombre"
            Error2 = "Nº2 és un valor erroni, introdueix un nombre"
            Error3 = "Nº3 és un valor erroni, introdueix un nombre"
            Error4 = "Nº4 és un valor erroni, introdueix un nombre"
            Error5 = "Nº5 és un valor erroni, introdueix un nombre"
            Error6 = "Nº6 és un valor erroni, introdueix un nombre"
            Error7 = "Nº7 és un valor erroni, introdueix un nombre"
            Error8 = "Nº8 és un valor erroni, introdueix un nombre"
            Error9 = "Introdueix un nombre enter a l'any"
            Error10 = "Introdueix un nombre enter a l'any"
        End If
    End Sub
End Class
