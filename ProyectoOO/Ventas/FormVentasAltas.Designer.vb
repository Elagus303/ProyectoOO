<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentasAltas
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Id_vendedorLabel As System.Windows.Forms.Label
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.VentaTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.rBtnBlancoNegro = New System.Windows.Forms.RadioButton()
        Me.rBtnColor = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rBtnSimple = New System.Windows.Forms.RadioButton()
        Me.rBtnDoble = New System.Windows.Forms.RadioButton()
        Me.cBoxAnillado = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.VendedoresTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.VendedoresTableAdapter()
        Me.VendedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.InsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InsumoTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.InsumoTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.InsumosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.ClientesTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Id_vendedorLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsumosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(55, 15)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(50, 270)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(51, 13)
        CantidadLabel.TabIndex = 9
        CantidadLabel.Text = "cantidad:"
        '
        'Id_vendedorLabel
        '
        Id_vendedorLabel.AutoSize = True
        Id_vendedorLabel.Location = New System.Drawing.Point(12, 41)
        Id_vendedorLabel.Name = "Id_vendedorLabel"
        Id_vendedorLabel.Size = New System.Drawing.Size(34, 13)
        Id_vendedorLabel.TabIndex = 11
        Id_vendedorLabel.Text = "Hojas"
        '
        'BD_ImprentaDataSet
        '
        Me.BD_ImprentaDataSet.DataSetName = "BD_ImprentaDataSet"
        Me.BD_ImprentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "Venta"
        Me.VentaBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.InsumoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendedoresTableAdapter = Nothing
        Me.TableAdapterManager.VentaTableAdapter = Me.VentaTableAdapter
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(146, 12)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IdTextBox.TabIndex = 26
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(116, 267)
        Me.CantidadTextBox.MaxLength = 4
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CantidadTextBox.TabIndex = 2
        '
        'rBtnBlancoNegro
        '
        Me.rBtnBlancoNegro.AutoSize = True
        Me.rBtnBlancoNegro.Location = New System.Drawing.Point(23, 19)
        Me.rBtnBlancoNegro.Name = "rBtnBlancoNegro"
        Me.rBtnBlancoNegro.Size = New System.Drawing.Size(98, 17)
        Me.rBtnBlancoNegro.TabIndex = 13
        Me.rBtnBlancoNegro.TabStop = True
        Me.rBtnBlancoNegro.Text = "Blanco y Negro"
        Me.rBtnBlancoNegro.UseVisualStyleBackColor = True
        '
        'rBtnColor
        '
        Me.rBtnColor.AutoSize = True
        Me.rBtnColor.Location = New System.Drawing.Point(23, 42)
        Me.rBtnColor.Name = "rBtnColor"
        Me.rBtnColor.Size = New System.Drawing.Size(49, 17)
        Me.rBtnColor.TabIndex = 14
        Me.rBtnColor.TabStop = True
        Me.rBtnColor.Text = "Color"
        Me.rBtnColor.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rBtnBlancoNegro)
        Me.GroupBox1.Controls.Add(Me.rBtnColor)
        Me.GroupBox1.Location = New System.Drawing.Point(93, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 100)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de tinta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rBtnSimple)
        Me.GroupBox2.Controls.Add(Me.rBtnDoble)
        Me.GroupBox2.Location = New System.Drawing.Point(93, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 72)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de impresión"
        '
        'rBtnSimple
        '
        Me.rBtnSimple.AutoSize = True
        Me.rBtnSimple.Location = New System.Drawing.Point(23, 19)
        Me.rBtnSimple.Name = "rBtnSimple"
        Me.rBtnSimple.Size = New System.Drawing.Size(56, 17)
        Me.rBtnSimple.TabIndex = 13
        Me.rBtnSimple.TabStop = True
        Me.rBtnSimple.Text = "Simple"
        Me.rBtnSimple.UseVisualStyleBackColor = True
        '
        'rBtnDoble
        '
        Me.rBtnDoble.AutoSize = True
        Me.rBtnDoble.Location = New System.Drawing.Point(23, 42)
        Me.rBtnDoble.Name = "rBtnDoble"
        Me.rBtnDoble.Size = New System.Drawing.Size(53, 17)
        Me.rBtnDoble.TabIndex = 14
        Me.rBtnDoble.TabStop = True
        Me.rBtnDoble.Text = "Doble"
        Me.rBtnDoble.UseVisualStyleBackColor = True
        '
        'cBoxAnillado
        '
        Me.cBoxAnillado.AutoSize = True
        Me.cBoxAnillado.Location = New System.Drawing.Point(12, 299)
        Me.cBoxAnillado.Name = "cBoxAnillado"
        Me.cBoxAnillado.Size = New System.Drawing.Size(63, 17)
        Me.cBoxAnillado.TabIndex = 21
        Me.cBoxAnillado.TabStop = False
        Me.cBoxAnillado.Text = "Anillado"
        Me.cBoxAnillado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Precio: $ 0"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(23, 354)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 13)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = "Total: $ 0"
        '
        'VendedoresTableAdapter
        '
        Me.VendedoresTableAdapter.ClearBeforeFill = True
        '
        'VendedoresBindingSource
        '
        Me.VendedoresBindingSource.DataMember = "Vendedores"
        Me.VendedoresBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(235, 380)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(87, 29)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.InsumoBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(58, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "id"
        '
        'InsumoBindingSource
        '
        Me.InsumoBindingSource.DataMember = "Insumo"
        Me.InsumoBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'InsumoTableAdapter
        '
        Me.InsumoTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.InsumosBindingSource1
        Me.ComboBox2.DisplayMember = "nombre"
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(97, 299)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.ValueMember = "id"
        '
        'InsumosBindingSource1
        '
        Me.InsumosBindingSource1.DataMember = "Insumo"
        Me.InsumosBindingSource1.DataSource = Me.BD_ImprentaDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.ClientesBindingSource
        Me.ComboBox3.DisplayMember = "nombre"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(269, 38)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 27
        Me.ComboBox3.ValueMember = "id"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'FormVentasAltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(424, 426)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cBoxAnillado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Id_vendedorLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormVentasAltas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar venta"
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsumosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents VentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentaTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.VentaTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents rBtnBlancoNegro As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnColor As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rBtnSimple As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnDoble As System.Windows.Forms.RadioButton
    Friend WithEvents cBoxAnillado As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents VendedoresTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.VendedoresTableAdapter
    Friend WithEvents VendedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents InsumoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InsumoTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.InsumoTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents InsumosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.ClientesTableAdapter
End Class
