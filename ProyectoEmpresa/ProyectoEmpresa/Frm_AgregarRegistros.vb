
Imports System.Data.OleDb ' manejo de BD Access
Public Class Frm_AgregarRegistros

    'El método load se carga primero que nada y automaticamente
    Private Sub Frm_AgregarRegistros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llama al metodo Interface_Entrada()
        Interface_Entrada()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Interface_Entrada()
        'Se ejecuta cuando se carga el formulario
        Lab_Id.Enabled = True
        Text_Id.Enabled = True
        btn_search.Enabled = True

        Lab_Name.Enabled = False
        Text_Name.Enabled = False
        Lab_Address.Enabled = False
        Text_Address.Enabled = False
        Lab_Age.Enabled = False
        Text_Age.Enabled = False
        btn_save.Enabled = False
    End Sub

    Private Sub Interface_Datos()
        'Se ejecuta cuando se ingresan nuevos datos
        Lab_Id.Enabled = False
        Text_Id.Enabled = False
        btn_search.Enabled = False

        Lab_Name.Enabled = True
        Text_Name.Enabled = True
        Lab_Address.Enabled = True
        Text_Address.Enabled = True
        Lab_Age.Enabled = True
        Text_Age.Enabled = True
        btn_save.Enabled = True
    End Sub

    Private Sub Btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If Buscar_Registro(Text_Id.Text) = True Then
            'Mostrar mensaje que diga que el registro existe
            MsgBox("El registro existe")
            Text_Id.Focus()
        Else
            Interface_Datos()
            Limpiar_Formulario()
            Text_Name.Focus()
        End If
    End Sub

    'Buscar registro en la base de datos
    Function Buscar_Registro(ByVal xId As String) As Boolean

        'Convertir cadena a numero
        Dim Id As Double
        Id = Convert.ToInt32(xId)

        'Conexión, el puente entre la BD y el software
        Dim Conexion As New OleDbConnection
        Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & My.Settings.Database
        Dim CadenaSql As String = "SELECT * FROM Personal WHERE id = " & Id

        'Adaptador, es una vacija que recibe todo tipo de datos, ej xml
        Dim Adaptador As New OleDbDataAdapter(CadenaSql, Conexion)

        'Data set, es el esqueleto de una base de datos
        Dim Ds As New DataSet

        'Llamar al Data Set
        Conexion.Open() 'se abre la conexion
        Adaptador.Fill(Ds) 'El adaptador llena con datos al data set o esqueleto vacio
        Conexion.Close()

        'Contar registro
        If (Ds.Tables(0).Rows.Count = 0) Then
            'No se encontró el registro
            Return False
        Else
            'se encontró el registro
            'cargar los textBox del formulario con la informacion del registro encontrado
            Text_Name.Text = Ds.Tables(0).Rows(0)("nombre").ToString()
            Text_Address.Text = Ds.Tables(0).Rows(0)("direccion").ToString()
            Text_Age.Text = Ds.Tables(0).Rows(0)("edad").ToString()
            Ds.Dispose()
            Return True
        End If
    End Function

    Function Agregar_Registro(ByVal Id As String, ByVal Nombre As String, ByVal Direccion As String, ByVal Edad As String) As Boolean
        'Convertir al tipo de dato que espera recibir la BD
        Dim Cod As Integer = Convert.ToInt32(Id)
        Dim Eda As Integer = Convert.ToInt32(Edad)

        'Conexión, el puente entre la BD y el software
        Dim Conexion As New OleDbConnection
        Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & My.Settings.Database

        'Instruccion SQL 
        'Se insertan datos en la tabla Personal, el nombre de la tabla va en minusculas
        Dim cadenaSQl As String = "INSERT INTO personal (id, nombre, direccion, edad)"
        cadenaSQl = cadenaSQl + " VALUES ( " & Cod & ","
        cadenaSQl = cadenaSQl + "         '" & Nombre & "',"
        cadenaSQl = cadenaSQl + "         '" & Direccion & "',"
        cadenaSQl = cadenaSQl + "          " & Eda & ")"

        'Crear un comando
        Dim Comando As OleDbCommand = Conexion.CreateCommand()
        Comando.CommandText = cadenaSQl

        'Ejecutar la consulta de accion (agregan registros)
        Conexion.Open()
        Comando.ExecuteNonQuery()
        Conexion.Close()
        Return True
    End Function
    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        'Se guarda informacion en la base de datos
        If Text_Name.Text.Length = 0 Or Text_Address.Text.Length = 0 Or Text_Age.Text.Length = 0 Then
            MsgBox("Todos los campos son obligatorios", MsgBoxStyle.Exclamation)
        Else
            Agregar_Registro(Text_Id.Text, Text_Name.Text, Text_Address.Text, Text_Age.Text)
            Interface_Entrada()
            'Se limpian los campos
            Limpiar_Formulario()
            Text_Id.Focus()
        End If
    End Sub

    Private Sub Limpiar_Formulario()
        Text_Name.Clear()
        Text_Address.Clear()
        Text_Age.Clear()
    End Sub
    Private Sub Btn_canceled_Click(sender As Object, e As EventArgs) Handles btn_canceled.Click
        Me.Close()
    End Sub
End Class