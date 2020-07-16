Imports Datos
Public Module ControladorContrata

    Public Function ObtenerIdPersonas()
        Dim c As New ModeloContrata

        Return c.ObtenerPersonas()
    End Function

    Public Function ObtenerIdServicios()
        Dim c As New ModeloContrata

        Return c.ObtenerServicios()
    End Function

    Public Function ObtenerNombrePersona(id As String)
        Dim c As New ModeloContrata With {
            .Usuario = id
        }

        Return c.ObtenerIdPersona
    End Function

    Public Function ObtenerNombreServicio(id As String)
        Dim c As New ModeloContrata With {
            .Servicio = id
        }

        Return c.ObtenerIdServicio
    End Function

    Public Function ObtenerCosto(diferencia As String, servicio As String)
        Dim c As New ModeloContrata With {
            .DiferenciaDesdeHasta = diferencia,
            .Servicio = servicio
        }

        Return c.ObtenerCosto()
    End Function

    Public Sub GuardarContratacion(usuario As String, servicio As String, desde As String, hasta As String)
        Dim c As New ModeloContrata With {
            .Usuario = usuario,
            .Servicio = servicio,
            .Desde = desde,
            .Hasta = hasta
        }

        c.GuardarContratacion()
    End Sub
End Module
