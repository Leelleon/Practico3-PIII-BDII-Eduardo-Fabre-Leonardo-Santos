Imports Logica

Public Class FrmAltaServicio
    Private Sub FrmAltaServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerUltimoID()

    End Sub

    Public Sub ObtenerUltimoID()
        Dim LectorId As IDataReader
        Try
            LectorId = ControladorServicio.ObtenerUltimoID()
            While LectorId.Read
                If IsDBNull(LectorId.GetValue(0)) Then
                    TxtId.Text = 1
                Else
                    TxtId.Text = LectorId.GetValue(0)
                End If
            End While
        Catch ex As Exception
            MsgBox("No se pudo traer el ID", MsgBoxStyle.Critical)
            TxtId.Text = "D:"
        End Try
    End Sub

    Public Sub PermitirAceptar()
        If ((TxtNombre.Text <> "") And (TxtCosto.Text <> "") And (IsNumeric(TxtCosto.Text)) And (CmbTipo.Text <> "")) Then
            BtnAceptar.Enabled = True
            BtnAceptar.BackColor = Color.GhostWhite
            BtnAceptar.Cursor = Cursors.Hand
        Else
            BtnAceptar.Enabled = False
            BtnAceptar.BackColor = Color.Gainsboro
            BtnAceptar.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        PermitirAceptar()
    End Sub

    Private Sub TxtCosto_TextChanged(sender As Object, e As EventArgs) Handles TxtCosto.TextChanged
        PermitirAceptar()
    End Sub

    Private Sub CmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipo.SelectedIndexChanged
        PermitirAceptar()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim Servicio(3) As String
        Servicio(0) = TxtNombre.Text
        Servicio(1) = TxtCosto.Text
        Servicio(2) = CmbTipo.Text

        Try
            ControladorServicio.InsertarServicio(Servicio)
            LimpiarTextBoxes()
            ObtenerUltimoID()
            MsgBox("Ingreso exitoso!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No se pudo ingresar el servicio" + ex.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub LimpiarTextBoxes()
        TxtNombre.Text = ""
        TxtCosto.Text = ""
        CmbTipo.Text = ""
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarTextBoxes()
        Me.Close()
    End Sub

End Class