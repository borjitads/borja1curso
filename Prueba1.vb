Option Strict On
Module Module1

    Sub Main()
        'Console.WriteLine("Hola mundo")

        'Console.ForegroundColor = ConsoleColor.Yellow
        'Console.WriteLine("loco")

        'Dim numero As Integer = 8
        'numero = Convert.ToInt32(Console.ReadLine())
        'If numero > 0 Then
        '    Console.WriteLine("el tio esta muy loco")
        'Else
        '    Console.WriteLine("no esta loco")
        'End If
        'Console.ReadLine()


        'Console.WriteLine("***    *****  *****     ********     *    ")
        'Console.WriteLine("*   *  *   *  *  **         *      *   *   ")
        'Console.WriteLine("*  *   *   *  *  *          *     *******   ")
        'Console.WriteLine("*   *  *   *  *    *        *    *       *  ")
        'Console.WriteLine("***    *****  *     *    ****   *         * ")


        'Dim suma, i As Integer
        'i = 1
        'suma = 0
        'While (i <= 100)
        '    suma = suma + i
        '    i = i + 2
        'End While
        'Console.WriteLine("La suma es " & suma)
        'Console.ReadLine()

        'calcular base por altura del triangulo
        'Dim base, altura, area As Single
        'base = 8
        'altura = 7
        'area = (base + altura) / 2
        'Console.WriteLine("el calculo del area es : " & area)
        'Console.ReadLine()

        Dim precioinicial, preciofinal, rebaja As Single
        precioinicial = 2
        rebaja = precioinicial * 15 / 100
        preciofinal = precioinicial - rebaja
        Console.WriteLine("el precio final : " & preciofinal)
        Console.ReadLine()
    End Sub

End Module
