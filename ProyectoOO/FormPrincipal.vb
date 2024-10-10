
Public Class FormPrincipal
    'Click en el Menu Strip Ventas
    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        FormProv.Close() : FormProv.Dispose()
        altas.Close() : altas.Dispose()
        MostrarFormPanel(FormVentas)
    End Sub

    'Click en el Menu Strip Proveedores
    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        FormVentas.Close() : FormVentas.Dispose()
        clientes.Close() : clientes.Dispose()
        MostrarFormPanel(FormProv)
        FormProv.Show()
    End Sub


    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        MostrarFormPanel(clientes)
        clientes.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Vendedores.Show()
    End Sub

    Private Sub FormPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit() 'Cerrar definitivamente todas las ventanas
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuStripPpal.Renderer = New RenderPersonalizadoMenuStrip() 'Instanciar para poder cambiar Render
        MostrarFormPanel(FormVentas) 'Cargar automaticamente la ventana de ventas
    End Sub

    Private Sub FinanzasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(Me.ClientSize.Width & " : " & Me.ClientSize.Height)
    End Sub

    Private Sub VendedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresToolStripMenuItem1.Click
        Vendedores.Show()
    End Sub

    Private Sub InsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsumosToolStripMenuItem.Click
        inventario.Show()
    End Sub
End Class