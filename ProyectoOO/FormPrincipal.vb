
Public Class FormPrincipal
    'Click en el Menu Strip Ventas
    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        FormProv.Close() : FormProv.Dispose()
        altas.Close() : altas.Dispose()
        MostrarFormPanel(FormVentas)
    End Sub

    'Click en el Menu Strip Proveedores
    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click, ToolStripMenuItem2.Click
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
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Vendedores' Puede moverla o quitarla según sea necesario.

        MenuStripPpal.Renderer = New RenderPersonalizadoMenuStrip() 'Instanciar para poder cambiar Render
        MostrarFormPanel(FormVentas) 'Cargar automaticamente la ventana de ventas
    End Sub

    Private Sub FinanzasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(Me.ClientSize.Width & " : " & Me.ClientSize.Height)
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresToolStripMenuItem.Click
        MostrarFormPanel(PrinVendedores)
        PrinVendedores.Show()
    End Sub

    Private Sub VendedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
       

    End Sub
End Class