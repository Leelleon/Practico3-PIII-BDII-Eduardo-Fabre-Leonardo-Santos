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

    Public Function ObtenerCosto(servicio As String, desde As String, hasta As String)
        Dim c As New ModeloContrata With {
            .Servicio = servicio,
            .Desde = desde,
            .Hasta = hasta
        }

        Return c.ObtenerCosto()
    End Function


End Module
