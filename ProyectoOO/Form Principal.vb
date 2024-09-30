Public Class Principal
    'Click en el Menu Strip Ventas
    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        FormVentas.Show()
    End Sub

    'Click en el Menu Strip Proveedores
    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        FormProv.Show()
    End Sub

    
    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.Show()
<<<<<<< HEAD:ProyectoOO/Form Principal.vb
=======

>>>>>>> 4105692d8b268d21d6a49db15fdeec3dfd9c4e3b:ProyectoOO/Principal.vb
    End Sub
End Class