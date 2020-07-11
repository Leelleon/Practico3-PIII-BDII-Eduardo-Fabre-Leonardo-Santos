Imports Datos

Public Module ControladorPersona

    Public Function ListarDatosDePersona()
        Dim p As New ModeloPersona
        Return p.ListarDatosPersona()
    End Function

    Public Sub NuevaPersona(Nombre As String, Apellido As String, Mail As String, Telefono As List(Of String))
        Dim p As New ModeloPersona

        p.Nombre = Nombre
        p.Apellido = Apellido
        p.Mail = Mail
        p.Telefono = Telefono

        p.Insertar()


    End Sub


End Module
