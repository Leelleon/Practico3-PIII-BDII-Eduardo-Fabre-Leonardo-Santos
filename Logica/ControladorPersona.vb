﻿Imports Datos

Public Module ControladorPersona

    Public Function ListarDatosDePersona()
        Dim p As New ModeloPersona
        Return p.ListarDatosPersona()
    End Function

    Public Function NuevaPersona(Nombre As String, Apellido As String, Mail As String, Telefono As List(Of String))
        Dim p As New ModeloPersona

        p.Nombre = Nombre
        p.Apellido = Apellido
        p.Mail = Mail
        p.Telefono = Telefono

        Return p.Insertar()

    End Function

    Public Function ObtenerIdPersona()
        Dim p As New ModeloPersona
        Return p.ObtenerIdPersona

    End Function
    Public Function TraerDatosDePersona(Id As String)
        Dim p As New ModeloPersona
        p.IdPersona = Id
        Return p.TraerDatos()

    End Function
End Module