Imports System

Module Program
    <Obsolete>
    Sub Main(args As String()) 'Creacion de Menu para seleccionar un ejercicio 
        Dim opcionMenu As Integer = 0

        Do ' El boucle nos va a permitir ingresar a realizar cada ejercicio
            Console.WriteLine("     * ---------------------*")
            Console.WriteLine("     Seleccione Ejercicio")
            Console.WriteLine("     * ---------------------*" & vbNewLine)
            Console.WriteLine("     1. Saludador ")
            Console.WriteLine("     2. Tabla de Multiplicar ")
            Console.WriteLine("     3. Numero del 0 al 100 Divicible entre 2 ")
            Console.WriteLine("     4. Rango de Numero Entre el 0 al 10")
            Console.WriteLine("     5. Generar un numero Aleatorio Entre 1 - 10 ")
            Console.WriteLine("     0. Salir  ")
            Console.Write(vbNewLine & "Ingrese el numero de su Opcion  ")



            If Integer.TryParse(Console.ReadLine(), opcionMenu) Then  'validacion y Captura de munero de accion para el menu
                Select Case opcionMenu

                    Case 1 'Saludador
                        Console.WriteLine("     Usted Selecciono la Opcion 1. Saludador ")


                        Dim New_Saludor As New Saludador 'Creacion del Objeto Saludo

                        New_Saludor.Saludo = "Hola "

                        Console.Write(vbNewLine & "Escriba su Nombre:  ")
                        New_Saludor.Nombres = Console.ReadLine() 'capturar Nombre


                        Console.WriteLine(vbNewLine & "¡" & New_Saludor.Saludo & New_Saludor.Nombres & "!") 'Mostrar Saludo

                        Console.Write(vbNewLine & "Presione Enter Para regresar a Menu")
                        Console.ReadLine()


                    Case 2 'Tablas de Multiplicar

                        Dim New_Sub_Menu As New Sub_Menu
                        Do  'capturar El numero de tabla a operar

                            Console.WriteLine("     Usted Selecciono la Opcion 2. Tabla de Multiplicar ")
                            Console.Write(vbNewLine & "Presione S Para ir a Calcular Tabla y N para Regresar a Menu ")
                            New_Sub_Menu.AccionM = Console.ReadLine()


                            If New_Sub_Menu.AccionM = "S" Or New_Sub_Menu.AccionM = "s" Then

                                Dim New_Tabla_Multiplicar As New Tabla_Multiplicar 'Crear Objeto Tabla Multiplicar

                                Console.WriteLine("    Calculador de Tabla de Multiplocar ")
                                Console.Write(vbNewLine & " Ingrese Numero de la Tabla ")

                                If Int64.TryParse(Console.ReadLine(), New_Tabla_Multiplicar.Numero_Tabla) Then 'Validamos si el dato ingresado es Nunmero
                                    For multiplicador = 1 To 10  'Recorremos la multiplicacion hasta el 10

                                        Console.WriteLine(vbNewLine & New_Tabla_Multiplicar.Numero_Tabla & " X " & multiplicador & " = " & New_Tabla_Multiplicar.Numero_Tabla * multiplicador)
                                    Next

                                    Console.Write(vbNewLine & "Presione Enter Para regresar a Menu Principal")
                                    Console.ReadLine()
                                Else
                                    Console.WriteLine("Usted No ingreso un numero")
                                End If

                            End If

                        Loop Until New_Sub_Menu.AccionM = "N" Or New_Sub_Menu.AccionM = "n"


                    Case 3 'Numero Divisibles  entre el 0 al 100
                        Console.WriteLine(vbNewLine & "     Usted Selecciono la Opcion 4. Rango de Numero Entre el 0 al 100")
                        Dim NewDivior As New Divisores  'Creacion de Nuevo Objeto para crear lista de numeros Divisibles
                        Console.WriteLine(NewDivior.Divisor("")) 'Se llama el objeto y se imprime list
                        Console.Write(vbNewLine & "Presione Enter Para regresar a Menu Principal")
                        Console.ReadLine()

                    Case 4 ' Ingresar un numero entre 1 - 10
                        Try 'Realizar Excepcion por si usuario ingresa una lebra o dato en blanco
                            Dim CapturaXn As Integer  'Variable para capturar numero a validar 
                            Console.WriteLine(vbNewLine & "     Usted Selecciono la Opcion 5. Generar un numero Aleatorio Entre 1 - 10 ")
                            Dim NewRangon As New Rango_Numero 'Creacion de Objeto para validar si numero existe en el rango 
                            Console.WriteLine(vbNewLine & " Ingrese Un Numero Entre el 0 y el 10 .")
                            CapturaXn = Console.ReadLine() 'Captura de numero
                            NewRangon.RangoN(CapturaXn) 'Se llama la class Rango Numero
                            Console.Write(vbNewLine & "Presione Enter Para regresar a Menu Principal")
                            Console.ReadLine()

                        Catch ex As Exception
                            Console.WriteLine("Usted No Ingreso un Numero")
                        End Try


                    Case 5 ' generar un numero aleatorio entre 1 - 10
                        Randomize() 'Se llama metodo RNd de Vb 
                        Dim NumeroRando As Integer 'Declaracion de Variable Rango
                        NumeroRando = CInt(Math.Floor((16 - 1 + 1) * Rnd())) + 1  ' Funcion para creacion de numero Aleatorio entre 1 y 16 
                        Console.WriteLine(NumeroRando) 'Mostrar numero Aleatorio

                    Case 0 ' Para Salir del sistema
                        Exit Sub
                    Case Else
                        'Mensaje para usuario que ingrese un numero que no pertenece aun opcion de Menu
                        Console.WriteLine(vbNewLine & "<<<<<  Por Favor Ingrese un Numero del 1 al 4, 0 para salir   >>>>>" & vbNewLine)


                End Select

            Else
                'Mensaje para usuario por si ingresa espacios vacios o letra
                Console.WriteLine(vbNewLine & "<<<<<  Usted No Ingreso un Dato Numerico  >>>>>" & vbNewLine)

            End If

        Loop
    End Sub
End Module
