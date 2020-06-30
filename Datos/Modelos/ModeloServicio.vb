Public Class ModeloServicio
    Inherits Conexion

    Public Id As String
    Public Nombre As String
    Public CostoMensual As String
    Public Tipo As String

    Public Function ObtenerUltimoID()
        Command.CommandText = "
            SELECT 
                MAX(id)
            FROM
                servicio
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Sub InsertarServicio()
        Command.CommandText = "
            INSERT INTO
                servicio(nombre, costo_mensual, tipo, activo)
            VALUES
                ('" + Me.Nombre + "','" + Me.CostoMensual + "','" + Me.Tipo + "',1)
        "
        Command.ExecuteNonQuery()
    End Sub

    Public Function ObtenerDatos()
        Command.CommandText = "
            SELECT 
                nombre, costo_mensual, tipo
            FROM
                servicio
            WHERE
                id = " + Me.Id + " AND
                activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ObtenerIDs()
        Command.CommandText = "
            SELECT
                id
            FROM 
                servicio
            WHERE
                activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

End Class
