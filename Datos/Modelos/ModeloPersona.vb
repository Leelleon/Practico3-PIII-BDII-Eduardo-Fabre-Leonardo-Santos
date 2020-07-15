﻿Public Class ModeloPersona
    Inherits Conexion

    Public IdPersona As String
    Public Nombre As String
    Public Apellido As String
    Public Mail As String
    Public Telefono As List(Of String)

    Public Function ListarDatosPersona()
        Command.CommandText = "SELECT * FROM persona WHERE activo = 1"

        Reader = Command.ExecuteReader
        Return Reader

    End Function

    Public Function Insertar()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()
            Return True
            Try
                Command.CommandText = "Lock TABLE persona WRTIE;
                                       Lock TABLE persona READ;
                                       Lock TABLE persona_tel WRITE;
                                       Lock TABLE persona_tel READ;"
                Return True
                Try
                    Command.CommandText = "INSERT INTO persona(Nombre, Apellido, Mail, activo)
                                           VALUES('" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')"
                    Command.ExecuteNonQuery()

                    For Each Numero In Telefono
                        Command.CommandText = "INSERT INTO persona_tel(id_persona, telefono)
                                           VALUES((SELECT MAX(id) FROM persona),('" + Numero + "'))"
                        Command.ExecuteNonQuery()
                    Next
                    Command.CommandText = "commit"
                    Command.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    Command.CommandText = "ROLLBACK"
                    Command.ExecuteNonQuery()
                    Return 3

                End Try
            Catch ex As Exception
                Return 2
            End Try
        Catch ex As Exception
            Return 1
        End Try

    End Function

    Public Function ObtenerIdPersona()
        Command.CommandText = "SELECT id FROM persona WHERE activo = 1"
        Reader = Command.ExecuteReader
        Return Reader
    End Function

    Public Function TraerDatos()
        Command.CommandText = "SELECT nombre, apellido, mail, telefono 
                                FROM persona, persona_tel 
                                WHERE id = '" + Me.IdPersona + "' AND activo = 1 AND id_persona = '" + Me.IdPersona + "'"
        Reader = Command.ExecuteReader
        Return Reader
    End Function

End Class