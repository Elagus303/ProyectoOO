﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.MenuStripPpal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripPpal
        '
        Me.MenuStripPpal.AutoSize = False
        Me.MenuStripPpal.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStripPpal.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStripPpal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.InsumosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.VendedoresToolStripMenuItem, Me.FinanzasToolStripMenuItem})
        Me.MenuStripPpal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStripPpal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPpal.Name = "MenuStripPpal"
        Me.MenuStripPpal.Padding = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.MenuStripPpal.Size = New System.Drawing.Size(169, 384)
        Me.MenuStripPpal.TabIndex = 0
        Me.MenuStripPpal.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(156, 59)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(156, 59)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'InsumosToolStripMenuItem
        '
        Me.InsumosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirInsumoToolStripMenuItem, Me.EditarInsumoToolStripMenuItem, Me.EliminarInsumoToolStripMenuItem})
        Me.InsumosToolStripMenuItem.Name = "InsumosToolStripMenuItem"
        Me.InsumosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.InsumosToolStripMenuItem.Size = New System.Drawing.Size(156, 59)
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
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(156, 59)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(156, 59)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'FinanzasToolStripMenuItem
        '
        Me.FinanzasToolStripMenuItem.Name = "FinanzasToolStripMenuItem"
        Me.FinanzasToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.FinanzasToolStripMenuItem.Size = New System.Drawing.Size(156, 59)
        Me.FinanzasToolStripMenuItem.Text = "Finanzas"
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(169, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(321, 384)
        Me.PanelPrincipal.TabIndex = 1
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(490, 384)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.MenuStripPpal)
        Me.MainMenuStrip = Me.MenuStripPpal
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
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinanzasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelPrincipal As System.Windows.Forms.Panel
End Class
