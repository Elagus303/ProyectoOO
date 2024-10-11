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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.MenuStripPpal = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStripPpal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripPpal
        '
        Me.MenuStripPpal.AutoSize = False
        Me.MenuStripPpal.BackColor = System.Drawing.Color.Black
        Me.MenuStripPpal.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStripPpal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ToolStripMenuItem7, Me.ToolStripMenuItem3, Me.ToolStripMenuItem2})
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
        Me.ProveedoresToolStripMenuItem.Text = "Vendedores"
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
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(112, 59)
        Me.ToolStripMenuItem3.Text = "Insumos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(112, 59)
        Me.ToolStripMenuItem2.Text = "Proveedores"
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(125, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(659, 525)
        Me.PanelPrincipal.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LawnGreen
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(0, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Nuevo registros"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(784, 525)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents PanelPrincipal As System.Windows.Forms.Panel
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
