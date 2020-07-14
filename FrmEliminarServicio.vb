Imports Logica

Public Class FrmEliminarServicio

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Select Case MsgBox("Seguro quiere eliminar al usuario?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    ControladorServicio.BajarServicio(TxtId.Text)
                Catch ex As Exception
                    MsgBox("No se pudo eliminar a la persona", MsgBoxStyle.Critical)
                End Try
            Case MsgBoxResult.No
                TxtId.Text = ""
        End Select

    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged
        If TxtId.Text = "" Then
            BtnEliminar.Enabled = False
        Else
            BtnEliminar.Enabled = True
        End If
    End Sub


End Class