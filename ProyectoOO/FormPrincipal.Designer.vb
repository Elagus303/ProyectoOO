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
        Me.InsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.MenuStripPpal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripPpal
        '
        Me.MenuStripPpal.AutoSize = False
        Me.MenuStripPpal.BackColor = System.Drawing.Color.Black
        Me.MenuStripPpal.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStripPpal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.InsumosToolStripMenuItem, Me.ToolStripMenuItem7, Me.ToolStripMenuItem2, Me.VendedoresToolStripMenuItem1})
        Me.MenuStripPpal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStripPpal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPpal.Name = "MenuStripPpal"
        Me.MenuStripPpal.Padding = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.MenuStripPpal.Size = New System.Drawing.Size(125, 439)
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
        'InsumosToolStripMenuItem
        '
        Me.InsumosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.InsumosToolStripMenuItem.Name = "InsumosToolStripMenuItem"
        Me.InsumosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.InsumosToolStripMenuItem.Size = New System.Drawing.Size(112, 59)
        Me.InsumosToolStripMenuItem.Text = "Insumos"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(112, 59)
        Me.ToolStripMenuItem7.Text = "Ventas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(112, 59)
        Me.ToolStripMenuItem2.Text = "Proveedores"
        '
        'VendedoresToolStripMenuItem1
        '
        Me.VendedoresToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VendedoresToolStripMenuItem1.Name = "VendedoresToolStripMenuItem1"
        Me.VendedoresToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.VendedoresToolStripMenuItem1.Size = New System.Drawing.Size(112, 59)
        Me.VendedoresToolStripMenuItem1.Text = "Vendedores"
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(125, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(659, 439)
        Me.PanelPrincipal.TabIndex = 1
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(784, 439)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.MenuStripPpal)
        Me.DoubleBuffered = True
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
    Friend WithEvents InsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelPrincipal As System.Windows.Forms.Panel
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
