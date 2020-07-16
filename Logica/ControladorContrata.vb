Imports Datos
Public Module ControladorContrata

    Public Function ObtenerIdPersonas()
        Dim c As New ModeloContrata
        Return c.ObtenerIdPersonas()

    End Function

    Public Function ObtenerIdServicios(id As String)
        Dim c As New ModeloContrata With {
            .Usuario = id
        }
        Return c.ObtenerIdServicios()

    End Function

    Public Function ObtenerTodosIdPersonas()
        Dim c As New ModeloContrata
        Return c.ObtenerTodosIdPersonas()

    End Function

    Public Function ObtenerTodosIdServicios()
        Dim c As New ModeloContrata
        Return c.ObtenerTodosIdServicios()

    End Function

    Public Function ObtenerNombrePersona(id As String)
        Dim c As New ModeloContrata With {
            .Usuario = id
        }

        Return c.ObtenerNombrePersona()
    End Function

    Public Function ObtenerNombreServicio(id As String)
        Dim c As New ModeloContrata With {
            .Servicio = id
        }

        Return c.ObtenerNombreServicio()
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

    Public Function ObtenerServiciosContratados()
        Dim c As New ModeloContrata

        Return c.ObtenerServiciosContratados()
    End Function

    Public Function ObtenerContratos(nombre As String)
        Dim c As New ModeloContrata With {
            .Servicio = nombre
        }

        Return c.ObtenerServiciosContratadosPorNombre()
    End Function

    Public Function ObtenerContratoYPersonas(usuario As String, servicio As String, fecha As String)
        Dim c As New ModeloContrata With {
            .Usuario = usuario,
            .Servicio = servicio,
            .FechaContratacion = fecha
        }

        Return c.ObtenerContratoYPersonas()
    End Function

    Public Function ListarContratos()
        Dim c As New ModeloContrata
        Return c.ListarContratos()

    End Function

    Public Sub EliminarContratacion(persona As String, servicio As String, fecha As String)
        Dim c As New ModeloContrata With {
            .Usuario = persona,
            .Servicio = servicio,
            .FechaContratacion = fecha
        }

        c.EliminarContratacion()
    End Sub
End Module
