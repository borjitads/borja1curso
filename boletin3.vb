Option Strict On
Module Module1

    Sub Main()
        '9 Diseñar un programa que lea dos números y calcule el mayor elevado al más pequeño (usar la clase Math.pow (base,exponente).
        'Dim x, y As Integer
        'Dim resultadoverdadero, resultadofalso As Double
        'x = 2
        'y = 3



        'If x >= y Then
        '    resultadoverdadero = Math.Pow(x, y)
        '    Console.WriteLine("el resultado es : " & resultadoverdadero)
        'Else
        '    resultadofalso = Math.Pow(y, x)
        '    Console.WriteLine("el resultado es : " & resultadofalso)

        'End If

        '12 Diseñar un programa que aplique un descuento del 10% si el precio de un producto es inferior a 100 y del 15% si es superior.
        'Dim producto As Integer
        'Dim productodescuento As Double
        'producto = 120
        'If producto < 100 Then
        '    productodescuento = producto - (producto * 0.1)
        '    Console.WriteLine("el prducto con el descuento del 10% es : " & productodescuento)
        'Else
        '    productodescuento = producto - (producto * 0.15)
        '    Console.WriteLine("el prducto con el descuento del 15% es : " & productodescuento)
        'End If

        '7
        'Dim num1, num2, resultado As Double
        'Dim raiz As Boolean

        'num1 = 2
        'num2 = 6
        'resultado = num1 + num2
        'If resultado > 0 Then
        '    raiz = True
        '    raiz = Math.Sqrt()

        'Else
        '    raiz = False
        '    Console.WriteLine(" no se puede calcular la raíz")

        'End If
        'Console.ReadLine()
        '8
        'Dim contraseña1, contraseña2 As String
        'Dim aceptado As Boolean = False

        'Console.WriteLine("introduzca su contraseña")
        'contraseña1 = Console.ReadLine()

        'Console.WriteLine("introduzca su contraseña")
        'contraseña2 = Console.ReadLine()

        'aceptado = contraseña1 = contraseña2

        'Console.ReadLine()

        'If contraseña1 = contraseña2 Then
        '    aceptado = True
        '    Console.WriteLine("esta bien")
        'Else
        '    aceptado = False
        '    Console.WriteLine("esta mal")
        'End If

        'Console.ReadLine()
        '10 Debido al sobrepeso Homer tiene que realizar su actividad laboral desde casa, para ello la central necesita realizar 
        'un programa que lo ayude a gestionar la seguridad de la central. Esta aplicación medirá la presión y la temperatura del núcleo. 
        'Si la presión es superior a 2 atm debe mostrar el mensaje “Abrir válvula de seguridad”.Si la temperatura supera los 500 Kelvin 
        'el mensaje debe ser “Reducir la temperatura". Si suceden ambas situaciones debe mostrar ambos mensajes. Si no debe aparecer “Todo en orden”.

        'Dim presion, temperatura As Double
        'Console.WriteLine("si la presion en atm son")
        'Console.ReadLine()

        'Console.WriteLine("si la temperatura en kelvin son")
        'Console.ReadLine()


        'If presion > 2 Then

        '    Console.WriteLine("reducir presion")
        'End If

        'If temperatura > 500 Then

        '    Console.WriteLine("Reducir la temperatura")

        'End If

        'If presion <= 2 And temperatura <= 500 Then

        '    Console.WriteLine("Todo bien")

        'End If


        '13
        'Dim rescelta, resRealMadrid, resFeliz As String


        'Console.WriteLine("Es usted socio del Celta s/n")
        'rescelta = Console.ReadLine()
        'Console.WriteLine("Es usted socio del Real Madrid s/n")
        'resRealMadrid = Console.ReadLine()
        'Console.WriteLine("Es usted  feliz s/n")
        'resFeliz = Console.ReadLine()

        'If (rescelta = "s" Or resRealMadrid = "s") And resFeliz = "s" Then
        '    Console.WriteLine("enhorabuena")
        'Else
        '    Console.WriteLine("menudo problema")
        'End If

        'Console.ReadLine()

        '14
        'Dim a, b, c As String

        'Console.WriteLine("Es usted Empleado por cuenta ajena  si/no")
        'a = Console.ReadLine()
        'Console.WriteLine("Es usted Autónomo si/no")
        'b = Console.ReadLine()
        'Console.WriteLine("Es usted  Parado  si/no")
        'c = Console.ReadLine()

        'If a = "si" Or (b = "si" Or c = "si") Then
        '    Console.WriteLine("es usted empleado " & a)
        '    Console.WriteLine("es usted Autónomo " & b)
        '    Console.WriteLine("es usted Parado " & c)

        'End If
        'If a = "no" And (b = "si" Or c = "si") Then
        '    Console.WriteLine(" si usted cobra un prestamo")
        'Else
        '    Console.WriteLine(" no usted no cobra un prestamo")
        'End If

        'Console.ReadLine()








    End Sub

End Module
