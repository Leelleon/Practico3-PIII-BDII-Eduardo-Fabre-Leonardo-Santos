Imports Logica

Public Class FrmAltaServicio
    Private Sub FrmAltaServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtId.Text = ObtenerUltimoID.ToString()
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
        PermitirAceptar()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim Servicio(3) As String
        Servicio(0) = TxtNombre.Text
        Servicio(1) = TxtCosto.Text
        Servicio(2) = CmbTipo.Text

        ControladorServicio.InsertarServicio(Servicio)
    End Sub

    Public Sub PermitirAceptar()
        If ((TxtNombre.Text <> "") And (TxtCosto.Text <> "") And (CmbTipo.Text <> "")) Then
            BtnAceptar.Enabled = True
        Else
            BtnAceptar.Enabled = False
        End If
    End Sub


End Class