
Public Class FormPrincipal
    'Click en el Menu Strip Ventas
    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        FormProv.Close() : FormProv.Dispose()
        AltasClientes.Close() : AltasClientes.Dispose()
        MostrarFormPanel(FormVentas)
    End Sub

    'Abrir formulario de vendedores
    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        FormVentas.Close() : FormVentas.Dispose()
        clientes.Close() : clientes.Dispose()
        MostrarFormPanel(PrinVendedores)
    End Sub
    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        MostrarFormPanel(clientes)
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
    'Abrir formulario de proveedores
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MostrarFormPanel(FormProv)
    End Sub
End Class