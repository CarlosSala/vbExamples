Public Class Principal

    'los procedimientos y las funciones son metodos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    'funcion para sumar
    Function Sumar(ByVal n1 As Integer, ByVal n2 As Integer)
        Dim total As Integer

        total = n1 + n2
        Return total

    End Function

    'procedimiento para mostrar la suma en pantalla
    Private Sub mostrarResultadoSuma(result As Integer)
        MsgBox("El resultado de la suma es: " & result)
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim value1 As Integer
        Dim value2 As Integer
        Dim result As Integer

        value1 = Convert.ToInt32(tb_value1.Text)
        value2 = Convert.ToInt32(tb_value2.Text)
        result = Sumar(value1, value2)

        mostrarResultadoSuma(result)

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim alumno(2) As String

        alumno(0) = "Carlos"
        alumno(1) = "Rafaela"

        MsgBox("Array de strings, posicion 0: " & alumno(0) & ", posicion 1: " & alumno(1))

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim opcion As Integer = 1

        Select Case opcion
            Case 1
                MsgBox("case 1")
            Case 2
                MsgBox("case 2")
            Case 3
                MsgBox("case 3")
            Case Else
                MsgBox("default case")
        End Select
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        Dim Contador As Integer = 1

        'Do se repite eternamente
        'Do
        '    MsgBox("vuelta :" & Contador)

        '    If Contador = 3 Then
        '        Exit Do
        '    End If
        '    Contador = Contador + 1
        'Loop

        ' Ciclo While
        'While Contador <= 3
        '    MsgBox("vuelta :" & Contador)
        '    Contador += 1
        'End While

        For contador1 = 1 To 3
            MsgBox("vuelta :" & contador1)
        Next

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        'Se instancia el objeto de la clasePersona
        Dim persona As New Person("Carlos salazar", "Santiago de Chile", "Chileno", "Soltero", 175)

        MsgBox("El nombre del niño es " & persona.getNombreCompleto)

        ' se cambia el atributo NombreCompleto de la clase 
        persona.setNombreCompleto("Lalo tasa")

        MsgBox("El nuevo nombre es " & persona.getNombreCompleto)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        'Instanciar la clase coche con el primer constructor
        Dim transporte1 As New Car(4, 2, "red")

        MsgBox("objeto con tres valores personalizados" & Environment.NewLine &
               " Color: " & transporte1.getColor() & Environment.NewLine &
               " Cantidad de ruedas: " & transporte1.getCantidadRuedas() & Environment.NewLine &
               " Cantidad de puertas: " & transporte1.getCantidadPuertas())

        'Instanciar la clase coche con el tercer constructor
        Dim transporte2 As New Car("green")

        MsgBox("objeto con un valor personalizdo" & Environment.NewLine &
               " Color: " & transporte2.getColor() & Environment.NewLine &
               " Cantidad de ruedas: " & transporte2.getCantidadRuedas() & Environment.NewLine &
               " Cantidad de puertas: " & transporte2.getCantidadPuertas())
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Encapsulacion, es el nivel de acceso que se le otorgan a los elementos de una clase

        Dim auto As New Car(4, 2, "amarillo")
        'auto.getColor2() NO es accesible
        MsgBox("los constructores, metodos y campos con encapsulación private o simplemente dim no son accesible desde otras clases")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Se crea el objeto bicicleta
        Dim bicicleta As New Bici()

        'El campo Micolor es heredado por la clase bici desde la clase coche
        MsgBox(bicicleta.Micolor)

    End Sub
End Class
