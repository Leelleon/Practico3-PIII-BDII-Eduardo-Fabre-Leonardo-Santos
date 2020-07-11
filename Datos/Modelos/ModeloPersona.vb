Public Class ModeloPersona
    Inherits Conexion

    Public IdPersona As String
    Public Nombre As String
    Public Apellido As String
    Public Mail As String
    Public Telefono As List(Of String)

    Public Function ListarDatosPersona()
        Command.CommandText = "SELECT * FROM persona WHERE activo = 1"

        Reader = Command.ExecuteReader
        Return Reader

    End Function

    Public Sub Insertar()
        Command.CommandText = " 
            BEGIN;
            LOCK TABLE persona WRTIE;
            LOCK TABLE persona READ;
            LOCK TABLE persona_tel WRITE;
            LOCK TABLE persona_tel READ;
        "
        Command.CommandText = "
            INSERT INTO 
                persona (nombre, apellido, mail, activo) 
            VALUES ('" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "1")
        ""

        Command.ExecuteNonQuery()


    End Sub
End Class
