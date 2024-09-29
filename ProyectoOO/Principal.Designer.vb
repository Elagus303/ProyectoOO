<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStripPpal = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirInsumoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarInsumoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarInsumoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripPpal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripPpal
        '
        Me.MenuStripPpal.AutoSize = False
        Me.MenuStripPpal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.InsumosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.VendedoresToolStripMenuItem, Me.FinanzasToolStripMenuItem})
        Me.MenuStripPpal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPpal.Name = "MenuStripPpal"
        Me.MenuStripPpal.Size = New System.Drawing.Size(490, 30)
        Me.MenuStripPpal.TabIndex = 0
        Me.MenuStripPpal.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirClienteToolStripMenuItem, Me.EditarClienteToolStripMenuItem, Me.EliminarClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AñadirClienteToolStripMenuItem
        '
        Me.AñadirClienteToolStripMenuItem.Name = "AñadirClienteToolStripMenuItem"
        Me.AñadirClienteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AñadirClienteToolStripMenuItem.Text = "Añadir cliente"
        '
        'EditarClienteToolStripMenuItem
        '
        Me.EditarClienteToolStripMenuItem.Name = "EditarClienteToolStripMenuItem"
        Me.EditarClienteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.EditarClienteToolStripMenuItem.Text = "Editar cliente"
        '
        'EliminarClienteToolStripMenuItem
        '
        Me.EliminarClienteToolStripMenuItem.Name = "EliminarClienteToolStripMenuItem"
        Me.EliminarClienteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.EliminarClienteToolStripMenuItem.Text = "Eliminar cliente"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirProveedorToolStripMenuItem, Me.EditarProveedorToolStripMenuItem, Me.EliminarProveedorToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'AñadirProveedorToolStripMenuItem
        '
        Me.AñadirProveedorToolStripMenuItem.Name = "AñadirProveedorToolStripMenuItem"
        Me.AñadirProveedorToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AñadirProveedorToolStripMenuItem.Text = "Añadir proveedor"
        '
        'EditarProveedorToolStripMenuItem
        '
        Me.EditarProveedorToolStripMenuItem.Name = "EditarProveedorToolStripMenuItem"
        Me.EditarProveedorToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.EditarProveedorToolStripMenuItem.Text = "Editar proveedor"
        '
        'EliminarProveedorToolStripMenuItem
        '
        Me.EliminarProveedorToolStripMenuItem.Name = "EliminarProveedorToolStripMenuItem"
        Me.EliminarProveedorToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.EliminarProveedorToolStripMenuItem.Text = "Eliminar proveedor"
        '
        'InsumosToolStripMenuItem
        '
        Me.InsumosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirInsumoToolStripMenuItem, Me.EditarInsumoToolStripMenuItem, Me.EliminarInsumoToolStripMenuItem})
        Me.InsumosToolStripMenuItem.Name = "InsumosToolStripMenuItem"
        Me.InsumosToolStripMenuItem.Size = New System.Drawing.Size(64, 26)
        Me.InsumosToolStripMenuItem.Text = "Insumos"
        '
        'AñadirInsumoToolStripMenuItem
        '
        Me.AñadirInsumoToolStripMenuItem.Name = "AñadirInsumoToolStripMenuItem"
        Me.AñadirInsumoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AñadirInsumoToolStripMenuItem.Text = "Añadir insumo"
        '
        'EditarInsumoToolStripMenuItem
        '
        Me.EditarInsumoToolStripMenuItem.Name = "EditarInsumoToolStripMenuItem"
        Me.EditarInsumoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EditarInsumoToolStripMenuItem.Text = "Editar insumo"
        '
        'EliminarInsumoToolStripMenuItem
        '
        Me.EliminarInsumoToolStripMenuItem.Name = "EliminarInsumoToolStripMenuItem"
        Me.EliminarInsumoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EliminarInsumoToolStripMenuItem.Text = "Eliminar insumo"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirVentaToolStripMenuItem, Me.EditarVentaToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 26)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'AñadirVentaToolStripMenuItem
        '
        Me.AñadirVentaToolStripMenuItem.Name = "AñadirVentaToolStripMenuItem"
        Me.AñadirVentaToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AñadirVentaToolStripMenuItem.Text = "Ver ventas"
        '
        'EditarVentaToolStripMenuItem
        '
        Me.EditarVentaToolStripMenuItem.Name = "EditarVentaToolStripMenuItem"
        Me.EditarVentaToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.EditarVentaToolStripMenuItem.Text = "Añadir venta"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(81, 26)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'FinanzasToolStripMenuItem
        '
        Me.FinanzasToolStripMenuItem.Name = "FinanzasToolStripMenuItem"
        Me.FinanzasToolStripMenuItem.Size = New System.Drawing.Size(64, 26)
        Me.FinanzasToolStripMenuItem.Text = "Finanzas"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 296)
        Me.Controls.Add(Me.MenuStripPpal)
        Me.MainMenuStrip = Me.MenuStripPpal
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStripPpal.ResumeLayout(False)
        Me.MenuStripPpal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStripPpal As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirInsumoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarInsumoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarInsumoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinanzasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
