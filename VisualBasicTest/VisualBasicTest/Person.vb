'una clase tiene: Identidad, Estado y Comportamiento
Public Class Person 'Identidad

    'Estado -> atributos o campos

    Private NombreCompleto As String
    Private Direccion As String
    Private Nacionalidad As String
    Private EstadoCivil As String
    Private Estatura As Integer


    'Comportamiento -> Metodos constructores

    'El constructor se ejecuta antes que nada, inicaliza objetos de la clase, no retorna nada
    Sub New(ByVal nombreCompleto As String, ByVal direccion As String, ByVal nacionalidad As String, ByVal estadoCivil As String, ByVal estatura As Integer)

        Me.NombreCompleto = nombreCompleto
        Me.Direccion = direccion
        Me.Nacionalidad = nacionalidad
        Me.EstadoCivil = estadoCivil
        Me.Estatura = estatura

    End Sub

    'Comportamiento -> Metodos normales

    Function getNombreCompleto() As String

        Return NombreCompleto
    End Function

    Function setNombreCompleto(ByVal nombreCompleto As String)

        Me.NombreCompleto = nombreCompleto
        Return Nothing
    End Function

End Class
