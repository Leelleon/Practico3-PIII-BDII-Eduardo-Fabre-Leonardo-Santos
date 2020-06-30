Imports Logica

Public Class FrmAltaServicio
    Private Sub FrmAltaServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtId.Text = ObtenerUltimoID.ToString()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim Servicio(3) As String
        Servicio(0) = TxtNombre.Text
        Servicio(1) = TxtCosto.Text
        Servicio(2) = CmbTipo.Text

        ControladorServicio.InsertarServicio(Servicio)
    End Sub
End Class