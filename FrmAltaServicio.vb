﻿Imports Logica

Public Class FrmAltaServicio
    Private Sub FrmAltaServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim LectorId As IDataReader
        LectorId = ControladorServicio.ObtenerUltimoID()
        While LectorId.Read
            TxtId.Text = LectorId.GetValue(0)
        End While
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TxtId.Text = ""
        TxtNombre.Text = ""
        TxtCosto.Text = ""
        CmbTipo.Text = ""
        Me.Close()
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        PermitirAceptar()
    End Sub

    Private Sub TxtCosto_TextChanged(sender As Object, e As EventArgs) Handles TxtCosto.TextChanged
        PermitirAceptar()
    End Sub

    Private Sub CmbTipo_TextChanged(sender As Object, e As EventArgs) Handles CmbTipo.TextChanged

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim Servicio(3) As String
        Servicio(0) = TxtNombre.Text
        Servicio(1) = TxtCosto.Text
        Servicio(2) = CmbTipo.Text

        Try
            ControladorServicio.InsertarServicio(Servicio)
            TxtNombre.Text = ""
            TxtCosto.Text = ""
            CmbTipo.Text = ""
            MsgBox("Ingreso exitoso!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No se pudo ingresar el servicio" + ex.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub PermitirAceptar()
        If ((TxtNombre.Text <> "") And (TxtCosto.Text <> "") And (CmbTipo.Text <> "")) Then
            BtnAceptar.Enabled = True
        Else
            BtnAceptar.Enabled = False
        End If
    End Sub

    Private Sub CmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipo.SelectedIndexChanged
        PermitirAceptar()
    End Sub
End Class