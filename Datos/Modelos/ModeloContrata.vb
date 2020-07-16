Public Class ModeloContrata
    Inherits Conexion

    Public Usuario As String
    Public Servicio As String
    Public Desde As String
    Public Hasta As String
    Public DiferenciaDesdeHasta As String

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
            SELECT
                costo_mensual * " + (Me.DiferenciaDesdeHasta) + " As 'Costo'
            FROM
                servicio
            WHERE
                id = " + Me.Servicio + "
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Sub GuardarContratacion()
        Command.CommandText = "
            INSERT INTO
                contrata(id_persona, id_servicio, fecha_creacion, fecha_contratacion, fecha_fin_contrato)
            VALUES
                (" + Me.Usuario + "," + Me.Servicio + ",CURDATE(), '" + Me.Desde + "', '" + Me.Hasta + "');
        "
        Command.ExecuteNonQuery()
    End Sub
End Class
