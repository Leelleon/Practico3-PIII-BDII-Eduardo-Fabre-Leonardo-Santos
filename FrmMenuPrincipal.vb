Public Class FrmMenuPrincipal
    Private Sub NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NToolStripMenuItem.Click
        FrmAltaPersona.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        FrmModificarPersona.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        FrmEliminarPersona.Show()

    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        FrmListarPersona.Show()

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        FrmAltaServicio.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem1.Click
        FrmModificarServicio.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        FrmEliminarServicio.Show()
    End Sub

    Private Sub ListarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem1.Click
        FrmListarServicio.Show()
    End Sub


    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()


    End Sub

    Private Sub ListarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem2.Click
        FrmListarContrata.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem2.Click
        FrmEliminarContrata.Show()

    End Sub
End Class
