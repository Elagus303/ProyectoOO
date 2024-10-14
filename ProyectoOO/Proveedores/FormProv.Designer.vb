<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProv
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
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.ProveedoresTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.pbTxtBuscar = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblTabla = New System.Windows.Forms.Label()
        Me.cbFiltrar = New System.Windows.Forms.ComboBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnAnt = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTxtBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_ImprentaDataSet
        '
        Me.BD_ImprentaDataSet.DataSetName = "BD_ImprentaDataSet"
        Me.BD_ImprentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.InsumoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendedoresTableAdapter = Nothing
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AllowUserToAddRows = False
        Me.ProveedoresDataGridView.AllowUserToDeleteRows = False
        Me.ProveedoresDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(12, 49)
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.ReadOnly = True
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(919, 291)
        Me.ProveedoresDataGridView.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.FillWeight = 20.0!
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn1.FillWeight = 240.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre/Razon"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn2.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "correo"
        Me.DataGridViewTextBoxColumn3.FillWeight = 160.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "localidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Localidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(12, 346)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 29)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(105, 346)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(87, 29)
        Me.btnEditar.TabIndex = 14
        Me.btnEditar.TabStop = False
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAnadir
        '
        Me.btnAnadir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnadir.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnAnadir.FlatAppearance.BorderSize = 0
        Me.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnadir.Location = New System.Drawing.Point(844, 14)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(87, 29)
        Me.btnAnadir.TabIndex = 13
        Me.btnAnadir.TabStop = False
        Me.btnAnadir.Text = "Agregar"
        Me.btnAnadir.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(266, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(87, 29)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.TabStop = False
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'pbTxtBuscar
        '
        Me.pbTxtBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbTxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pbTxtBuscar.Location = New System.Drawing.Point(12, 14)
        Me.pbTxtBuscar.Name = "pbTxtBuscar"
        Me.pbTxtBuscar.Size = New System.Drawing.Size(254, 29)
        Me.pbTxtBuscar.TabIndex = 18
        Me.pbTxtBuscar.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Location = New System.Drawing.Point(17, 20)
        Me.txtBuscar.MaxLength = 20
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(243, 20)
        Me.txtBuscar.TabIndex = 19
        '
        'lblTabla
        '
        Me.lblTabla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTabla.Location = New System.Drawing.Point(12, 92)
        Me.lblTabla.Name = "lblTabla"
        Me.lblTabla.Size = New System.Drawing.Size(919, 20)
        Me.lblTabla.TabIndex = 20
        Me.lblTabla.Text = "Sin resultados compatibles"
        Me.lblTabla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTabla.Visible = False
        '
        'cbFiltrar
        '
        Me.cbFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltrar.FormattingEnabled = True
        Me.cbFiltrar.Items.AddRange(New Object() {"Razon", "Localidad"})
        Me.cbFiltrar.Location = New System.Drawing.Point(751, 20)
        Me.cbFiltrar.Name = "cbFiltrar"
        Me.cbFiltrar.Size = New System.Drawing.Size(87, 23)
        Me.cbFiltrar.TabIndex = 21
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnFiltrar.FlatAppearance.BorderSize = 0
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Location = New System.Drawing.Point(751, 14)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(87, 29)
        Me.btnFiltrar.TabIndex = 22
        Me.btnFiltrar.TabStop = False
        Me.btnFiltrar.Text = "Ordenar"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'btnPrimero
        '
        Me.btnPrimero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrimero.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnPrimero.FlatAppearance.BorderSize = 0
        Me.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimero.Location = New System.Drawing.Point(765, 349)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(37, 27)
        Me.btnPrimero.TabIndex = 23
        Me.btnPrimero.TabStop = False
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = False
        '
        'btnAnt
        '
        Me.btnAnt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnt.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnAnt.FlatAppearance.BorderSize = 0
        Me.btnAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnt.Location = New System.Drawing.Point(808, 349)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Size = New System.Drawing.Size(37, 27)
        Me.btnAnt.TabIndex = 24
        Me.btnAnt.TabStop = False
        Me.btnAnt.Text = "<"
        Me.btnAnt.UseVisualStyleBackColor = False
        '
        'btnSig
        '
        Me.btnSig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSig.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnSig.FlatAppearance.BorderSize = 0
        Me.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSig.Location = New System.Drawing.Point(851, 349)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(37, 27)
        Me.btnSig.TabIndex = 25
        Me.btnSig.TabStop = False
        Me.btnSig.Text = ">"
        Me.btnSig.UseVisualStyleBackColor = False
        '
        'btnUltimo
        '
        Me.btnUltimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUltimo.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnUltimo.FlatAppearance.BorderSize = 0
        Me.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimo.Location = New System.Drawing.Point(894, 348)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(37, 27)
        Me.btnUltimo.TabIndex = 26
        Me.btnUltimo.TabStop = False
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = False
        '
        'FormProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(943, 385)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnAnt)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.cbFiltrar)
        Me.Controls.Add(Me.lblTabla)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.pbTxtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.ProveedoresDataGridView)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProv"
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTxtBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents pbTxtBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblTabla As System.Windows.Forms.Label
    Friend WithEvents cbFiltrar As System.Windows.Forms.ComboBox
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents btnAnt As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
End Class
