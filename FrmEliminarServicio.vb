﻿Imports Logica

Public Class FrmEliminarServicio
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            MsgBox("Seguro quiere eliminar al usuario?", MsgBoxStyle.YesNo)
            If MsgBoxResult.Yes Then
                ControladorServicio.BajarUsuario(TxtId.Text)
                MsgBox("Usuario eliminado con exito!", MsgBoxStyle.Information)
            Else
                MsgBox("No se elimino el usuario")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged
        If TxtId.Text = "" Then
            BtnEliminar.Enabled = False
        Else
            BtnEliminar.Enabled = True
        End If
    End Sub


End Class