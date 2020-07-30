Public Class ModeloContrata
    Inherits Conexion

    Public Usuario As String
    Public Servicio As String
    Public FechaContratacion As String
    Public Desde As String
    Public Hasta As String
    Public DiferenciaDesdeHasta As String

    Public Function ObtenerTodosIdPersonas()
        Command.CommandText = "
            SELECT
                id
            FROM
                persona
            WHERE
                activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ObtenerTodosIdServicios()
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

    Public Function ObtenerIdPersonas()
        Command.CommandText = "
            SELECT
                DISTINCT(p.id)
            FROM
                persona p, contrata c
            WHERE
                p.id = c.id_persona
                AND
                c.activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ObtenerIdServicios()
        Command.CommandText = "
             SELECT 
                DISTINCT(c.id_servicio) 
             FROM  
                servicio s, contrata c 
            WHERE 
                c.id_servicio = s.id 
                AND 
                c.id_persona = " + Me.Usuario + "
                AND
                c.activo = 1;
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ObtenerNombrePersona()
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

    Public Function ObtenerNombreServicio()
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
                contrata(id_persona, id_servicio, fecha_creacion, fecha_contratacion, fecha_fin_contrato, activo)
            VALUES
                (" + Me.Usuario + "," + Me.Servicio + ",CURDATE(), '" + Me.Desde + "', '" + Me.Hasta + "', 1);
        "
        Command.ExecuteNonQuery()
    End Sub

    Public Function ObtenerServiciosContratados()
        Command.CommandText = "
            SELECT 
                DISTINCT(s.tipo)
            FROM
                servicio s, contrata c
            WHERE
                s.id = c.id_servicio
                AND
                c.activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ObtenerServiciosContratadosPorNombre()
        Command.CommandText = "
            SELECT
                id_persona AS Usuario, 
                id_servicio As Servicio, 
                fecha_creacion As Creado, 
                fecha_contratacion As Inicia, 
                fecha_fin_contrato As Termina
            FROM
                contrata c
                JOIN
                servicio s ON c.id_servicio = s.id
            WHERE
                s.tipo = '" + Me.Servicio + "'
                AND
                c.Activo = 1;
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ObtenerContratoYPersonas()
        Command.CommandText = "
            SELECT 
                p.nombre, 
                s.nombre, 
                c.fecha_contratacion, 
                c.fecha_fin_contrato 
            FROM 
                persona p 
                JOIN 
                contrata c ON p.id = c.id_persona 
                JOIN 
                servicio s ON c.id_servicio = s.id 
            WHERE 
                c.id_servicio = " + Me.Servicio + "
                AND         
                c.id_persona = " + Me.Usuario + "
                AND 
                c.fecha_creacion = '" + Me.FechaContratacion + "'
                AND
                c.activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Sub EliminarContratacion()
        Command.CommandText = "
            UPDATE 
                contrata 
            SET 
                activo = 0 
            WHERE 
                id_persona = " + Me.Usuario + "
                AND 
                id_servicio = " + Me.Servicio + " 
                AND 
                fecha_creacion = '" + Me.FechaContratacion + "'
        "
        Command.ExecuteNonQuery()
    End Sub

    Public Function ListarContratos()
        Command.CommandText = "
            SELECT 
                p.id As Id,
                p.nombre As Usuario,
                s.id As Id,
                s.nombre As Servicio,
                c.fecha_creacion As Efectuado,
                c.fecha_contratacion As Empieza, 
                c.fecha_fin_contrato As Termina 
            FROM 
                persona p 
                JOIN 
                contrata c ON p.id = c.id_persona 
                JOIN 
                servicio s ON c.id_servicio = s.id 
            WHERE
                c.activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Sub ModificarContrato()
        Command.CommandText = "
            UPDATE
                contrata
            SET
                fecha_contratacion = '" + Me.Desde + "',
                fecha_fin_contrato = '" + Me.Hasta + "'
            WHERE
                id_persona = " + Me.Usuario + "
                AND
                id_servicio = " + Me.Servicio + "
                AND
                fecha_creacion = '" + Me.FechaContratacion + "'
               
        "
        Command.ExecuteNonQuery()
    End Sub
End Class
