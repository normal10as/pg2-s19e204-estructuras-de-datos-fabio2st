Imports System
'4.3. Crear un proyecto llamado “Notas” y un módulo que utilice arrays para almacenar las notas
'(entre 0 y 10) de una serie de alumnos.
'• Primero paso es ingresar la cantidad de alumnos y la cantidad de notas que tiene cada
'uno teniendo en cuenta un máximo aceptado de 40 alumnos y 4 notas por alumno.
'• Iterativamente ingresar el nombre de un alumno y sus notas. Validar que tenga un
'nombre de al menos 3 caracteres, que no sea repetido y el rango de la nota correcto.
'• Al completar la iteración informar por cada alumno el nombre, el promedio, si aprobó o
'desaprobó teniendo en cuenta que aprueba con 6 o más.
'• También informar quien es el mejor alumno (puede haber más de uno).
'• Implementar procedimientos para resolver las siguientes tareas:
'➢ Para validar el nombre
'➢ Para validar la inexistencia de un nombre igual
'➢ Para validar el rango de la nota
'➢ Para determinar el promedio
'➢ Para imprimir si el alumno aprobó o no
'➢ Para determinar la lista de mejores alumnos
Module Program
    Sub Main(args As String())
        Dim promedio As Int16
        Dim nombre As String
        Console.Write("Ingrese la cantidad de alumnos (40 máximo): ")
        Dim Alumno As Int16 = Console.ReadLine()
        Console.Write("Ingrese la cantidad de Notas (4 máximo): ")
        Dim Notas As Int16 = Console.ReadLine()
        Dim lista = New Object(Alumno, Notas) {}
        For i = 0 To Alumno - 1
            Console.Write("Ingrese el nombre: ")
            nombre = Console.ReadLine()
            For X = 0 To Alumno - 1
                If nombre = lista(X, 0) Then
                    Console.WriteLine("El alumno YA EXISTE!")
                End If
            Next
            lista(i, 0) = nombre

            For r = 0 To Notas - 1
                Console.Write("Ingrese La nota: ")
                lista(i, r) = Console.ReadLine()
                If lista(i, r) < 1 And lista(i, r) > 10 Then
                    Console.WriteLine("NOTA FUERA DE RANGO!")
                End If
                promedio += lista(i, r)
            Next
            promedio /= Notas
            If promedio >= 6 Then
                Console.WriteLine("El alumno Aprobo con " & promedio)
            Else
                Console.WriteLine("El alumno Desaprobo con " & promedio)
            End If
            promedio = 0
        Next
    End Sub
End Module
