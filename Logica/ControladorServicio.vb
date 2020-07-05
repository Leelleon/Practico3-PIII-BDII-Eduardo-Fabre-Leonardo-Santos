Imports Datos

Public Module ControladorServicio

    Public Function ObtenerUltimoID()
        Dim s As New ModeloServicio

        Return s.ObtenerUltimoID()
    End Function

    Public Sub InsertarServicio(servicio() As String)
        Dim s As New ModeloServicio With {
            .Nombre = servicio(0),
            .CostoMensual = servicio(1),
            .Tipo = servicio(2)
        }

        s.InsertarServicio()
    End Sub

    Public Function ObtenerDatos(id As String)
        Dim s As New ModeloServicio With {
            .Id = id
        }

        Return s.ObtenerDatos()
    End Function

    Public Function ObtenerIDs()
        Dim s As New ModeloServicio

        Return s.ObtenerIDs
    End Function

    Public Function ListarServicio()
        Dim s As New ModeloServicio

        Return s.Listar()
    End Function

    Public Sub BajarServicio(id As String)
        Dim s As New ModeloServicio With {
            .Id = id
        }

        s.BajarServicio()
    End Sub

    Public Sub ModificarServicio(servicio() As String)
        Dim s As New ModeloServicio With {
            .Id = servicio(0),
            .Nombre = servicio(1),
            .CostoMensual = servicio(2),
            .Tipo = servicio(3)
        }

        s.ModificarServicio()
    End Sub
End Module
