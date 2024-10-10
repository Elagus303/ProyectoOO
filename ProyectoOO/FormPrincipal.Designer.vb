<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirInsumoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarInsumoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarInsumoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripPpal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripPpal
        '
        Me.MenuStripPpal.AutoSize = False
        Me.MenuStripPpal.BackColor = System.Drawing.Color.Black
        Me.MenuStripPpal.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStripPpal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.InsumosToolStripMenuItem, Me.ToolStripMenuItem7, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStripPpal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStripPpal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPpal.Name = "MenuStripPpal"
        Me.MenuStripPpal.Padding = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.MenuStripPpal.Size = New System.Drawing.Size(125, 525)
        Me.MenuStripPpal.TabIndex = 0
        Me.MenuStripPpal.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(112, 59)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(112, 59)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'InsumosToolStripMenuItem
        '
        Me.InsumosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirInsumoToolStripMenuItem, Me.EditarInsumoToolStripMenuItem, Me.EliminarInsumoToolStripMenuItem})
        Me.InsumosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.InsumosToolStripMenuItem.Name = "InsumosToolStripMenuItem"
        Me.InsumosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.InsumosToolStripMenuItem.Size = New System.Drawing.Size(112, 59)
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
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(112, 59)
        Me.ToolStripMenuItem7.Text = "Ventas"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(112, 59)
        Me.ToolStripMenuItem3.Text = "Insumos"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem4.Text = "Añadir insumo"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem5.Text = "Editar insumo"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem6.Text = "Eliminar insumo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(112, 59)
        Me.ToolStripMenuItem2.Text = "Vendedores"
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(125, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(659, 525)
        Me.PanelPrincipal.TabIndex = 1
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(112, 59)
        Me.ToolStripMenuItem1.Text = "Proveedores"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(784, 525)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.MenuStripPpal)
        Me.MainMenuStrip = Me.MenuStripPpal
        Me.MinimumSize = New System.Drawing.Size(800, 400)
        Me.Name = "FormPrincipal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStripPpal.ResumeLayout(False)
        Me.MenuStripPpal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStripPpal As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirInsumoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarInsumoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarInsumoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelPrincipal As System.Windows.Forms.Panel
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
