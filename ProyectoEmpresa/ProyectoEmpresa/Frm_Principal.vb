Public Class Frm_Principal
    Private Sub For1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AgregarNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoToolStripMenuItem.Click
        Dim FAR As New Frm_AgregarRegistros
        FAR.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim FMR As New Frm_ModificarRegistros
        FMR.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim FER As New Frm_EliminarRegistros
        FER.ShowDialog()
    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDelSistemaToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarRegistroToolStripMenuItem.Click
        Dim Frm As New Frm_ListarRegistros
        Frm_ListarRegistros.Show()
    End Sub
End Class
