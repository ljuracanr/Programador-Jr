Public Class Divisores

    Function Divisor(Print As String) As String


        Dim Temp As String
        Dim Validador As String
        Dim NumeroX As Integer

        NumeroX = 0

        While NumeroX <= 100 'Realizamos Recorrigo para ver si su resultado es 0 2,4,6 y 8
            Temp = CStr(NumeroX) 'Convertimos el resultado en Cadema para recorrer y validar el ultimo numero
            Validador = If(Temp.Length < 0, Temp, Temp.Substring(Temp.Length - 1))  'Recorremos cadema para obtener el ultimo numero

            If Validador = 1 Or Validador = 3 Or Validador = 5 Or Validador = 7 Or Validador = 9 Then
                Console.WriteLine(NumeroX)
            End If


            NumeroX += 1
        End While


        Return "Se Imprimio la lista de Numero no Divisible por el numero 2"


    End Function


End Class
