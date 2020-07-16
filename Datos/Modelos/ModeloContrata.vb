Public Class ModeloContrata
    Inherits Conexion

    Public Usuario As String
    Public Servicio As String
    Public Desde As String
    Public Hasta As String

    Public Function ObtenerPersonas()
        Command.CommandText = "
            SELECT
                id, nombre
            FROM
                persona
            WHERE
                activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ObtenerServicios()
        Command.CommandText = "
            SELECT
                id, nombre
            FROM
                Servicio
            WHERE
                activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ObtenerIdPersona()
        Command.CommandText = "
            SELECT 
                nombre
            FROM
                persona
            WHERE
                id = " + Me.Usuario + "
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ObtenerIdServicio()
        Command.CommandText = "
            SELECT 
                nombre
            FROM
                servicio
            WHERE
                id = " + Me.Servicio + "
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ObtenerCosto()
        Command.CommandText = "
        
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function
End Class
