Imports System
'4.2. Crear un proyecto llamado �Ventas� y un m�dulo que cuenta con tres vectores cargados
'program�ticamente referente a productos: el primero tiene el c�digo, el segundo el nombre y
'el tercero el precio unitario.
'* Repetitivamente se ingresa un c�digo de producto y el programa muestra su descripci�n
'y precio, si el c�digo no existe mostrar un mensaje de Error.
'* luego el usuario ingresa la cantidad con lo que el programa responde calculando el total
'de venta por ese producto y el total general (acumulado los productos anteriores).
'* Se repite el proceso hasta que el c�digo sea cero.
Module Ventas
    Sub Main(args As String())
        Dim codigos = New UShort() {1, 2, 5}
        Dim nombres = New String() {"papa", "manzana", "uva"}
        Dim precios = New Single() {2.6, 1.2, 4.5}
        Dim codigo, indice As UShort
        Dim cantidad, subtotal, total As Decimal
        codigo = LeerCodigo()
        Do Until codigo = 0
            If isCodigoExiste(codigo, codigos) Then
                indice = GetIndiceCodigos(codigo, codigos)
                Console.WriteLine("Producto: " & nombres(indice))
                Console.WriteLine("Precio: " & precios(indice))
                Console.WriteLine("Ingrese cantidad: ")
                cantidad = Console.ReadLine()
                subtotal = precios(indice) * cantidad
                Console.WriteLine("SubTotal: " & subtotal)
                total += subtotal
                Console.WriteLine("Total: " & total)
            Else
                Console.WriteLine("Código no existe")
            End If
            codigo = LeerCodigo()
        Loop
    End Sub
    Function LeerCodigo() As UShort
        Console.Write("Ingrese un codigo de producto: ")
        Return Console.ReadLine()
    End Function
    Function isCodigoExiste(codigo As UShort, codigos() As UShort) As Boolean
        For Each valor In codigos
            If valor = codigo Then
                Return True
            End If
        Next
        Return False
    End Function
    Function GetIndiceCodigos(codigo As UShort, codigos() As UShort) As UShort
        For x = 0 To codigos.Length - 1
            If codigo = codigos(x) Then
                Return x
            End If
        Next
        Return Nothing
    End Function
End Module