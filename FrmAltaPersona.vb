﻿Imports Logica
Public Class FrmAltaPersona
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Try
            ControladorPersona.NuevaPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FrmMenuPrincipal.Show()
        Me.Close()

    End Sub
End Class