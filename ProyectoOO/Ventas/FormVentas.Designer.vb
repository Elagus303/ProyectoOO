<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Dim Fecha_ventaLabel As System.Windows.Forms.Label
        Dim Precio_ventaLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Id_vendedorLabel As System.Windows.Forms.Label
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.VentaTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.VentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_ventaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Precio_ventaTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Id_vendedorComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_clienteComboBox = New System.Windows.Forms.ComboBox()
        IdLabel = New System.Windows.Forms.Label()
        Fecha_ventaLabel = New System.Windows.Forms.Label()
        Precio_ventaLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Id_vendedorLabel = New System.Windows.Forms.Label()
        Id_clienteLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(558, 13)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'VentaDataGridView
        '
        Me.VentaDataGridView.AllowUserToAddRows = False
        Me.VentaDataGridView.AllowUserToDeleteRows = False
        Me.VentaDataGridView.AutoGenerateColumns = False
        Me.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.VentaDataGridView.DataSource = Me.VentaBindingSource
        Me.VentaDataGridView.Location = New System.Drawing.Point(359, 75)
        Me.VentaDataGridView.Name = "VentaDataGridView"
        Me.VentaDataGridView.ReadOnly = True
        Me.VentaDataGridView.Size = New System.Drawing.Size(513, 220)
        Me.VentaDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha_venta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fecha_venta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "precio_venta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_vendedor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id_vendedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(78, 103)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 2
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(153, 100)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 3
        '
        'Fecha_ventaLabel
        '
        Fecha_ventaLabel.AutoSize = True
        Fecha_ventaLabel.Location = New System.Drawing.Point(78, 130)
        Fecha_ventaLabel.Name = "Fecha_ventaLabel"
        Fecha_ventaLabel.Size = New System.Drawing.Size(67, 13)
        Fecha_ventaLabel.TabIndex = 4
        Fecha_ventaLabel.Text = "fecha venta:"
        '
        'Fecha_ventaDateTimePicker
        '
        Me.Fecha_ventaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentaBindingSource, "fecha_venta", True))
        Me.Fecha_ventaDateTimePicker.Location = New System.Drawing.Point(153, 126)
        Me.Fecha_ventaDateTimePicker.Name = "Fecha_ventaDateTimePicker"
        Me.Fecha_ventaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_ventaDateTimePicker.TabIndex = 5
        '
        'Precio_ventaLabel
        '
        Precio_ventaLabel.AutoSize = True
        Precio_ventaLabel.Location = New System.Drawing.Point(78, 155)
        Precio_ventaLabel.Name = "Precio_ventaLabel"
        Precio_ventaLabel.Size = New System.Drawing.Size(69, 13)
        Precio_ventaLabel.TabIndex = 6
        Precio_ventaLabel.Text = "precio venta:"
        '
        'Precio_ventaTextBox
        '
        Me.Precio_ventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "precio_venta", True))
        Me.Precio_ventaTextBox.Location = New System.Drawing.Point(153, 152)
        Me.Precio_ventaTextBox.Name = "Precio_ventaTextBox"
        Me.Precio_ventaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Precio_ventaTextBox.TabIndex = 7
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(78, 181)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(51, 13)
        CantidadLabel.TabIndex = 8
        CantidadLabel.Text = "cantidad:"
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(153, 178)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CantidadTextBox.TabIndex = 9
        '
        'Id_vendedorLabel
        '
        Id_vendedorLabel.AutoSize = True
        Id_vendedorLabel.Location = New System.Drawing.Point(78, 207)
        Id_vendedorLabel.Name = "Id_vendedorLabel"
        Id_vendedorLabel.Size = New System.Drawing.Size(66, 13)
        Id_vendedorLabel.TabIndex = 10
        Id_vendedorLabel.Text = "id vendedor:"
        '
        'Id_vendedorComboBox
        '
        Me.Id_vendedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "id_vendedor", True))
        Me.Id_vendedorComboBox.FormattingEnabled = True
        Me.Id_vendedorComboBox.Location = New System.Drawing.Point(153, 204)
        Me.Id_vendedorComboBox.Name = "Id_vendedorComboBox"
        Me.Id_vendedorComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Id_vendedorComboBox.TabIndex = 11
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.Location = New System.Drawing.Point(78, 234)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(52, 13)
        Id_clienteLabel.TabIndex = 12
        Id_clienteLabel.Text = "id cliente:"
        '
        'Id_clienteComboBox
        '
        Me.Id_clienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "id_cliente", True))
        Me.Id_clienteComboBox.FormattingEnabled = True
        Me.Id_clienteComboBox.Location = New System.Drawing.Point(153, 231)
        Me.Id_clienteComboBox.Name = "Id_clienteComboBox"
        Me.Id_clienteComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Id_clienteComboBox.TabIndex = 13
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 347)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Fecha_ventaLabel)
        Me.Controls.Add(Me.Fecha_ventaDateTimePicker)
        Me.Controls.Add(Precio_ventaLabel)
        Me.Controls.Add(Me.Precio_ventaTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Id_vendedorLabel)
        Me.Controls.Add(Me.Id_vendedorComboBox)
        Me.Controls.Add(Id_clienteLabel)
        Me.Controls.Add(Me.Id_clienteComboBox)
        Me.Controls.Add(Me.VentaDataGridView)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "FormVentas"
        Me.Text = "FormVentas"
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents VentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentaTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.VentaTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents VentaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_ventaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Precio_ventaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_vendedorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Id_clienteComboBox As System.Windows.Forms.ComboBox
End Class
