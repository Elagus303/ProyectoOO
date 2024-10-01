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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.pbTxtBuscar = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.cbFiltrar = New System.Windows.Forms.ComboBox()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnAnt = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTxtBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnAgregar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(793, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(87, 29)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'VentaDataGridView
        '
        Me.VentaDataGridView.AllowUserToAddRows = False
        Me.VentaDataGridView.AllowUserToDeleteRows = False
        Me.VentaDataGridView.AutoGenerateColumns = False
        Me.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.VentaDataGridView.DataSource = Me.VentaBindingSource
        Me.VentaDataGridView.Location = New System.Drawing.Point(12, 47)
        Me.VentaDataGridView.Name = "VentaDataGridView"
        Me.VentaDataGridView.ReadOnly = True
        Me.VentaDataGridView.Size = New System.Drawing.Size(868, 253)
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
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "precio_venta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_vendedor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id_vendedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Location = New System.Drawing.Point(17, 18)
        Me.txtBuscar.MaxLength = 20
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(243, 20)
        Me.txtBuscar.TabIndex = 22
        '
        'pbTxtBuscar
        '
        Me.pbTxtBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbTxtBuscar.Location = New System.Drawing.Point(12, 12)
        Me.pbTxtBuscar.Name = "pbTxtBuscar"
        Me.pbTxtBuscar.Size = New System.Drawing.Size(254, 29)
        Me.pbTxtBuscar.TabIndex = 21
        Me.pbTxtBuscar.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(266, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(87, 29)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.TabStop = False
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnFiltrar.FlatAppearance.BorderSize = 0
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Location = New System.Drawing.Point(700, 12)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(87, 29)
        Me.btnFiltrar.TabIndex = 24
        Me.btnFiltrar.TabStop = False
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'cbFiltrar
        '
        Me.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltrar.FormattingEnabled = True
        Me.cbFiltrar.Items.AddRange(New Object() {"Fecha", "Vendedor", "Monto"})
        Me.cbFiltrar.Location = New System.Drawing.Point(700, 18)
        Me.cbFiltrar.Name = "cbFiltrar"
        Me.cbFiltrar.Size = New System.Drawing.Size(87, 21)
        Me.cbFiltrar.TabIndex = 23
        '
        'btnPrimero
        '
        Me.btnPrimero.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnPrimero.FlatAppearance.BorderSize = 0
        Me.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimero.Location = New System.Drawing.Point(765, 306)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(37, 27)
        Me.btnPrimero.TabIndex = 25
        Me.btnPrimero.TabStop = False
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = False
        '
        'btnAnt
        '
        Me.btnAnt.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnAnt.FlatAppearance.BorderSize = 0
        Me.btnAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnt.Location = New System.Drawing.Point(808, 306)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Size = New System.Drawing.Size(37, 27)
        Me.btnAnt.TabIndex = 26
        Me.btnAnt.TabStop = False
        Me.btnAnt.Text = "<"
        Me.btnAnt.UseVisualStyleBackColor = False
        '
        'btnSig
        '
        Me.btnSig.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnSig.FlatAppearance.BorderSize = 0
        Me.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSig.Location = New System.Drawing.Point(851, 306)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(37, 27)
        Me.btnSig.TabIndex = 27
        Me.btnSig.TabStop = False
        Me.btnSig.Text = ">"
        Me.btnSig.UseVisualStyleBackColor = False
        '
        'btnUltimo
        '
        Me.btnUltimo.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnUltimo.FlatAppearance.BorderSize = 0
        Me.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimo.Location = New System.Drawing.Point(894, 306)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(37, 27)
        Me.btnUltimo.TabIndex = 28
        Me.btnUltimo.TabStop = False
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(12, 306)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 29)
        Me.btnEliminar.TabIndex = 30
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(105, 306)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(87, 29)
        Me.btnEditar.TabIndex = 29
        Me.btnEditar.TabStop = False
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(892, 347)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnAnt)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.cbFiltrar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.pbTxtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.VentaDataGridView)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "FormVentas"
        Me.Text = "FormVentas"
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTxtBuscar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents pbTxtBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents cbFiltrar As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents btnAnt As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
End Class
