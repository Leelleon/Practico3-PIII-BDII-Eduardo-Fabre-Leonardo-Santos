Imports Logica

Public Class FrmEliminarServicio
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        MsgBox("Seguro quiere eliminar al usuario?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            Try
                ControladorServicio.BajarServicio(TxtId.Text)
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If


    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged
        If TxtId.Text = "" Then
            BtnEliminar.Enabled = False
        Else
            BtnEliminar.Enabled = True
        End If
    End Sub


End Class