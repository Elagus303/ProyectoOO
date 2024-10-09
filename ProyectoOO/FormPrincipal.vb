
Public Class FormPrincipal
    'Click en el Menu Strip Ventas
    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        FormVentas.Show()
    End Sub

    'Click en el Menu Strip Proveedores
    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        FormProv.Show()
    End Sub


    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        altas.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresToolStripMenuItem.Click
        Vendedores.Show()
    End Sub

    Private Sub FormPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit() 'Cerrar definitivamente todas las ventanas
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuStripPpal.Renderer = New RenderPersonalizadoMenuStrip() 'Instanciar para poder cambiar Render
        MostrarFormPanel(FormVentas) 'Cargar automaticamente la ventana de ventas
    End Sub
End Class