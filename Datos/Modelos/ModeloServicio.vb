﻿Public Class ModeloServicio
    Inherits Conexion

    Public Id As String
    Public Nombre As String
    Public CostoMensual As String
    Public Tipo As String

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

    Public Function Listar()
        Command.CommandText = "
            SELECT 
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
        Try
            Command.CommandText = "
            UPDATE
                servicio
            SET
                activo = 0
            WHERE 
                id = " + Me.Id + "
        "

            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Public Sub ModificarServicio()
        Try
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
            MsgBox("Servicio modificado con exito!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error #" + ex.ToString + ", No se pudo modificar el servicio", MsgBoxStyle.Critical)
        End Try

    End Sub
End Class
