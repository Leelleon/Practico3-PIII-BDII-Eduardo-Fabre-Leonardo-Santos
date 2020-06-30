Public Class FrmListarPersona
    Private Sub FrmListarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DgvListaPersona_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListaPersona.CellContentClick

    End Sub

    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FrmMenuPrincipal.Show()
        Me.Close()
    End Sub
End Class