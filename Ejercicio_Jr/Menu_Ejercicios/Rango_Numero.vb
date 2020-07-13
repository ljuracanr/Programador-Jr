Public Class Rango_Numero

    Function RangoN(X_Numero As Integer) As Integer
        If X_Numero >= 0 And X_Numero <= 10 Then

            Console.WriteLine("El numero Es correcto")

        Else
            Console.WriteLine("El numero no esta en el Rango Solicitado")

        End If

        Return 0
    End Function

End Class
