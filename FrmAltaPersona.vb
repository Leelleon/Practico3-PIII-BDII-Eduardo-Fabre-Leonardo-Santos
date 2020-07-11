Imports Logica
Public Class FrmAltaPersona
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim Telefonos As New List(Of String)
        For x = 0 To LstTelefono.Items.Count - 1
            Telefonos.Add(LstTelefono.Items(x).ToString)
        Next
        Try
            ControladorPersona.NuevaPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FrmMenuPrincipal.Show()
        Me.Close()

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        LstTelefono.Items.Add(TxtTelefono.Text)

    End Sub

    Private Sub FrmAltaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class