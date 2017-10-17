Option Strict On
Module Module1

    Sub Main()
        'Lectura de datos por teclado
        Dim precioinicial, rebaja, precioFinal As Double
        Console.WriteLine("introduzca el precio del producto: ")
        precioinicial = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("introduzca el precio de la rebaja: ")
        rebaja = Convert.ToDouble(Console.ReadLine())

        precioFinal = precioinicial - (rebaja / 100) * precioinicial

        Console.WriteLine("el precio Final es : " & precioFinal)

        Console.ReadLine()
    End Sub

End Module
