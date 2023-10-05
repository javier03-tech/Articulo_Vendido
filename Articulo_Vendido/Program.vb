Imports System

Module Program
    ' Función para calcular el cambio
    Function CalcularCambio(precio As Double, pago As Double) As Double
        If pago >= precio Then
            Return pago - precio
        Else
            Return -1 ' Valor especial para indicar que el pago es insuficiente
        End If
    End Function

    Sub ProcesarCompra()
        Console.Write("Ingrese el costo del artículo: ")
        Dim precio As Double = Double.Parse(Console.ReadLine())
        Console.Write("Ingrese la cantidad de dinero entregada por el cliente: ")
        Dim pagoCliente As Double = Double.Parse(Console.ReadLine())

        Dim cambio As Double = CalcularCambio(precio, pagoCliente)

        If cambio = 0 Then
            Console.WriteLine("El cliente ha pagado exactamente el precio del producto. Entregando el producto.")
        ElseIf cambio > 0 Then
            Console.WriteLine($"El cambio a entregar al cliente es: ${cambio}")
        Else
            Console.WriteLine("El pago es insuficiente. Falta dinero por pagar.")
        End If
    End Sub

    Sub Main(args As String())
        Do
            ProcesarCompra()
            Console.Write("¿Desea realizar otra compra? (S/N): ")
            Dim continuar As String = Console.ReadLine().Trim().ToLower()
            If continuar <> "s" Then
                Exit Do
            End If
        Loop While True

        Console.WriteLine("Gracias por su compra. ¡Vuelva pronto!")
        Console.WriteLine("Creadores:Javier Alexander Naranjo Moz y Francisco Andres Garcia Mena")

    End Sub
End Module
