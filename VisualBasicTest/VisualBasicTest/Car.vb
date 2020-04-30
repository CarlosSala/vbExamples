Public Class Car

    'Campos
    Private CantidadRuedas As Integer
    Private CantidadPuertas As Integer
    Protected Color As String

    'Cuando existen mas de 1 constructor se le llama sobrecarga de constructores
    'Metodo constructor de 3 parametros
    Sub New(ByVal cantidadRuedas As Integer, ByVal cantidadPuertas As Integer, ByVal color As String)

        Me.CantidadRuedas = cantidadRuedas
        Me.CantidadPuertas = cantidadPuertas
        Me.Color = color
    End Sub

    'Metodo constructor de 1 parametros
    Sub New(ByVal color As String)
        Me.CantidadRuedas = 10
        Me.CantidadPuertas = 2
        Me.Color = color
    End Sub

    'Metodo constructor sin parametros
    'La herencia es la capacidad de heredar campos, metodos y funciones de una clase a otra
    ' esto permite reciclar codigo
    Sub New()
        Me.CantidadRuedas = 15
        Me.CantidadPuertas = 4
        Me.Color = "blue"
    End Sub

    Function getColor() As String
        Return Me.Color
    End Function

    Function getCantidadRuedas() As Integer
        Return Me.CantidadRuedas
    End Function

    Function getCantidadPuertas() As Integer
        Return Me.CantidadPuertas
    End Function

    'metodos encapsulados, a diferencia de public 
    'Dim y Private no permiten el acceso a 
    'elementos de la clase
    Private Function getColor2()
        Return Me.Color
    End Function

    Private Function getCantidadRuedas2() As Integer
        Return Me.CantidadRuedas
    End Function

End Class
