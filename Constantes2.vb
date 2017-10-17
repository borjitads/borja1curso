Option Strict On
Module Module1

    Sub Main()
        ' 1 declarar 2 variables x,y
        ' Calcular: y= (2/5) * x + 20
        '3 salida : valor de y

        'Dim x As Double
        'Dim y As Single
        'x = 10
        'y = Convert.ToSingle((2 / 5) * x + 20)
        'Console.WriteLine("valor de y :" & y)
        'Console.ReadLine()
        ' math para raizes
        Dim numero As Integer
        Dim raiz As Single
        numero = 99


        raiz = Convert.ToSingle(Math.Sqrt(numero))
        'math para redondear
        Console.WriteLine("el resultado de la raiz es :" & Math.Round(raiz, 2))

        ' math para potencias
        Dim x As Integer = 9
        Dim potencia As Long
        potencia = Convert.ToInt64(Math.Pow(x, 5))
        Console.WriteLine("el resultado de la potencia es :" & potencia)

        Console.ReadLine()

    End Sub

End Module
