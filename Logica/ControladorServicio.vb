Imports Datos

Public Module ControladorServicio

    Public Function ObtenerUltimoID()
        Dim s As New ModeloServicio

        Return s.ObtenerUltimoID()
    End Function

    Public Sub InsertarServicio(Servicio() As String)
        Dim s As New ModeloServicio With {
            .Nombre = Servicio(0),
            .CostoMensual = Servicio(1),
            .Tipo = Servicio(2)
        }

        s.InsertarServicio()
    End Sub

End Module
