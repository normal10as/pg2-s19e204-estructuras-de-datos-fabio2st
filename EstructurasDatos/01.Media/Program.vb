Imports System
'4.1. Crear un proyecto llamado “Media” y un módulo que permita cargar 5 números en un
'arreglo de 5 elementos; calcular la media y luego imprimir cada elemento del arreglo y la
'desviación que tiene respecto a la media. La MEDIA se obtiene la sumatoria de los todos
'elementos del arreglo y se divide por la cantidad de estos. La DESVIACION de cada
'elemento se obtiene restándole al elemento la MEDIA
Module Program
    Sub Main(args As String())
        Dim numeros(), suma As Integer
        numeros = IngresarNumeros()
        suma = Sumatoria(numeros)
        Console.WriteLine("Sumatoria: " & suma)
        Console.WriteLine("Media: " & Media(numeros))
        MostrarDesviacion(numeros)
    End Sub

    Function IngresarNumeros() As Integer()
        Dim numeros(4) As Integer
        For x = 1 To numeros.Length
            Console.Write("Ingrese número {0}: ", x)
            numeros(x - 1) = Console.ReadLine()
        Next
        Return numeros
    End Function

    Function Sumatoria(numeros() As Integer) As Integer
        Dim suma As Integer
        For Each numero In numeros
            suma += numero
        Next
        Return suma
    End Function

    Function Media(numeros() As Integer) As Single
        Return Sumatoria(numeros) / numeros.Length
    End Function

    Sub MostrarDesviacion(numeros() As Integer)
        Dim media As Single = Program.Media(numeros)
        Console.WriteLine("Valor - Desviacion")
        For Each numero In numeros
            Console.WriteLine(numero & vbTab & numero - media)
        Next
    End Sub
End Module


