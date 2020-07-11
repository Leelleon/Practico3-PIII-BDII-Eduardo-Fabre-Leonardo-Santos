Public Class ModeloPersona
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

    Public Sub Insertar()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()
            MsgBox("transaccion iniciada")
            Try
                Command.CommandText = "Lock TABLE persona WRTIE;
                                       Lock TABLE persona READ;
                                       Lock TABLE persona_tel WRITE;
                                       Lock TABLE persona_tel READ;"
                MsgBox("tabla bloqueada")

                Try
                    Command.CommandText = "INSERT INTO persona(Nombre, Apellido, Mail, activo)
                                           VALUES('" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')"
                    Command.ExecuteNonQuery()
                    MsgBox("Persona atroden")

                    For Each Numero In Telefono
                        Command.CommandText = "INSERT INTO persona_tel(id_persona, telefono)
                                           VALUES((SELECT MAX(id) FROM persona),('" + Numero + "'))"
                        Command.ExecuteNonQuery()
                    Next
                    Command.CommandText = "commit"
                    Command.ExecuteNonQuery()
                    MsgBox("todo pa dentro")

                Catch ex As Exception
                    Command.CommandText = "ROLLBACK"
                    Command.ExecuteNonQuery()
                    MsgBox(ex.ToString)

                End Try
            Catch ex As Exception
                MsgBox("no te bloqueo naranja")

            End Try
        Catch ex As Exception
            MsgBox("no transaciono naaa pelaá")

        End Try

    End Sub
End Class
