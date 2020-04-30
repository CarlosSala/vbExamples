Public Class Bici

    'Se heredan los campos y metodos public y protected de la clase Padre coche
    'los privated y los constructores no son heredables

    Inherits Car
    'campos

    Public Micolor As String

    'Constructor
    Sub New()
        'Color tiene encapsulacion protected y viene de la clase padre coche
        Me.Micolor = Color

    End Sub

End Class
