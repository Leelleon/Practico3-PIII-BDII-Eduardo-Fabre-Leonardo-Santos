Public Class ModeloPersona
    Inherits Conexion

    Public IdPersona As String
    Public Nombre As String
    Public Apellido As String
    Public Mail As String
    Public Telefono As String

    Public Function ListarDatosPersona()
        Command.CommandText = "SELECT * FROM persona WHERE activo = 1"

        Reader = Command.ExecuteReader
        Return Reader

    End Function

    Public Sub Insertar()
        Command.CommandText = "INSERT INTO persona (nombre, apellido, mail) VALUES ('" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "')"
        Command.ExecuteNonQuery()

        Command.CommandText = "INSERT INTO telefono (id, telefono) VALUES (" + (SELECT id_persona FROM persona ORDER BY DESC LIMIT 1) +",'" + Me.Telefono"')"
    End Sub
End Class
