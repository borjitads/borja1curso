Option Strict On
Module Module1

    Sub Main()
        'la longitud de una circunferencia a partir del radio 

        Dim hola As Integer = 1
        Console.WriteLine("dele a 0 o 1 :" & hola)
        hola = Convert.ToInt32(Console.ReadLine())
        Select Case hola
            Case 0
                Dim longitud, radio As Single
                radio = 10
                Dim pi As Double = 3.141596
                longitud = Convert.ToSingle(2 * pi * radio)
                Console.WriteLine("la longitud seria : " & longitud)
            Case 1
                Dim contador As Byte = 60
                    
                    'conversiones esplicitas : clase Convert
                    contador = Convert.ToByte(contador + 1)
                    'conversiones implicitas
                    Dim loquesea As Byte = contador
                Console.WriteLine("contador seria :" & loquesea)
                'Case 2
                '    Dim sabio As Integer = 8
                '    Dim suma As Integer
                '    While sabio <= 100
                '        suma = sabio + 1
                End While

        End Select
                Console.ReadLine()
    End Sub

End Module
