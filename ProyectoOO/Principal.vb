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

    End Sub
End Class