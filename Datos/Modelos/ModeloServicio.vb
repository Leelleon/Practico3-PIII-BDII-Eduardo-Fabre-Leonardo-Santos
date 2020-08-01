Public Class ModeloServicio
    Inherits Conexion

    Public Id As String
    Public Nombre As String
    Public CostoMensual As String
    Public Tipo As String
    Public Desde As String
    Public Hasta As String

    Public Function ObtenerUltimoID()

        Command.CommandText = "
            SELECT 
                MAX(id) + 1
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
                nombre, 
                costo_mensual AS Costo, 
                tipo AS Tipo
            FROM
                servicio
            WHERE
                id = " + Me.Id + " 
                AND
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

    Public Function Listar()
        Command.CommandText = "
            SELECT
                id AS ID,
                nombre AS Nombre, 
                costo_mensual AS Costo, 
                tipo AS Tipo
            FROM
                servicio
            WHERE
                activo = 1 
        "
        Reader = Command.ExecuteReader
        Return Reader

    End Function

    Public Sub BajarServicio()
        Command.CommandText = "
            UPDATE
                servicio
            SET
                activo = 0
            WHERE 
                id = " + Me.Id + "
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub ModificarServicio()
        Command.CommandText = "
            UPDATE 
                Servicio
            SET
                nombre = '" + Me.Nombre + "',
                costo_mensual = '" + Me.CostoMensual + "',
                tipo = '" + Me.Tipo + "'
            WHERE
                id = " + Me.Id + "
        "
        Command.ExecuteNonQuery()

    End Sub
End Class
