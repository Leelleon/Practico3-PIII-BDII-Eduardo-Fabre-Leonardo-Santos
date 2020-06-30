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
End Module
