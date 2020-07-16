Imports Logica

Public Class FrmListarPersona

    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
        Try
            Dim TablaPersona As New DataTable
            TablaPersona.Load(ControladorPersona.ListarDatosDePersona)
            DgvListaPersona.DataSource = TablaPersona

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FrmMenuPrincipal.Show()
        Me.Close()
    End Sub
End Class