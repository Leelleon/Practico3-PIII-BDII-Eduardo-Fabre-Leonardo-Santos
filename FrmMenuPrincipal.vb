Public Class FrmMenuPrincipal
    Private Sub NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NToolStripMenuItem.Click
        FrmAltaPersona.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        FrmModificarPersona.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        FrmEliminarPersona.Show()

    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        FrmListarPersona.Show()

    End Sub
End Class
