<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientes
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.cbFiltrar = New System.Windows.Forms.ComboBox()
        Me.lblTabla = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.pbTxtBuscar = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDImprentaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.ClientesTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.ClientesTableAdapter()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnAnt = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        CType(Me.pbTxtBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDImprentaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnFiltrar.FlatAppearance.BorderSize = 0
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Location = New System.Drawing.Point(765, 12)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(87, 29)
        Me.btnFiltrar.TabIndex = 30
        Me.btnFiltrar.TabStop = False
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'cbFiltrar
        '
        Me.cbFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltrar.FormattingEnabled = True
        Me.cbFiltrar.Items.AddRange(New Object() {"id", "nombre", "apellido"})
        Me.cbFiltrar.Location = New System.Drawing.Point(765, 18)
        Me.cbFiltrar.Name = "cbFiltrar"
        Me.cbFiltrar.Size = New System.Drawing.Size(87, 21)
        Me.cbFiltrar.TabIndex = 29
        '
        'lblTabla
        '
        Me.lblTabla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTabla.Location = New System.Drawing.Point(8, 64)
        Me.lblTabla.Name = "lblTabla"
        Me.lblTabla.Size = New System.Drawing.Size(943, 20)
        Me.lblTabla.TabIndex = 28
        Me.lblTabla.Text = "Sin resultados compatibles"
        Me.lblTabla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTabla.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Location = New System.Drawing.Point(12, 20)
        Me.txtBuscar.MaxLength = 20
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(243, 20)
        Me.txtBuscar.TabIndex = 27
        '
        'pbTxtBuscar
        '
        Me.pbTxtBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbTxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pbTxtBuscar.Location = New System.Drawing.Point(10, 12)
        Me.pbTxtBuscar.Name = "pbTxtBuscar"
        Me.pbTxtBuscar.Size = New System.Drawing.Size(254, 29)
        Me.pbTxtBuscar.TabIndex = 26
        Me.pbTxtBuscar.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(264, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(87, 29)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.TabStop = False
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnAnadir
        '
        Me.btnAnadir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnadir.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnAnadir.FlatAppearance.BorderSize = 0
        Me.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnadir.Location = New System.Drawing.Point(858, 12)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(87, 29)
        Me.btnAnadir.TabIndex = 24
        Me.btnAnadir.TabStop = False
        Me.btnAnadir.Text = "Agregar"
        Me.btnAnadir.UseVisualStyleBackColor = False
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AllowUserToAddRows = False
        Me.ClientesDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        Me.ClientesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.ClientesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClientesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.ClientesDataGridView.BackgroundColor = System.Drawing.Color.AntiqueWhite
        Me.ClientesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClientesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClientesDataGridView.DefaultCellStyle = DataGridViewCellStyle14
        Me.ClientesDataGridView.GridColor = System.Drawing.SystemColors.ControlText
        Me.ClientesDataGridView.Location = New System.Drawing.Point(8, 47)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.ReadOnly = True
        Me.ClientesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ClientesDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        Me.ClientesDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.ClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ClientesDataGridView.Size = New System.Drawing.Size(943, 239)
        Me.ClientesDataGridView.TabIndex = 31
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BDImprentaDataSetBindingSource
        '
        'BDImprentaDataSetBindingSource
        '
        Me.BDImprentaDataSetBindingSource.DataSource = Me.BD_ImprentaDataSet
        Me.BDImprentaDataSetBindingSource.Position = 0
        '
        'BD_ImprentaDataSet
        '
        Me.BD_ImprentaDataSet.DataSetName = "BD_ImprentaDataSet"
        Me.BD_ImprentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrimero.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnPrimero.FlatAppearance.BorderSize = 0
        Me.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimero.Location = New System.Drawing.Point(785, 533)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(37, 27)
        Me.btnPrimero.TabIndex = 34
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
        Me.btnAnt.Location = New System.Drawing.Point(914, 533)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Size = New System.Drawing.Size(37, 27)
        Me.btnAnt.TabIndex = 35
        Me.btnAnt.TabStop = False
        Me.btnAnt.Text = ">>"
        Me.btnAnt.UseVisualStyleBackColor = False
        '
        'btnSig
        '
        Me.btnSig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSig.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnSig.FlatAppearance.BorderSize = 0
        Me.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSig.Location = New System.Drawing.Point(871, 533)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(37, 27)
        Me.btnSig.TabIndex = 36
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
        Me.btnUltimo.Location = New System.Drawing.Point(828, 533)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(37, 27)
        Me.btnUltimo.TabIndex = 37
        Me.btnUltimo.TabStop = False
        Me.btnUltimo.Text = "<"
        Me.btnUltimo.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(9, 530)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 29)
        Me.btnEliminar.TabIndex = 33
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
        Me.btnEditar.Location = New System.Drawing.Point(102, 530)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(87, 29)
        Me.btnEditar.TabIndex = 32
        Me.btnEditar.TabStop = False
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.InsumoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendedoresTableAdapter = Nothing
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(957, 571)
        Me.Controls.Add(Me.lblTabla)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnAnt)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.cbFiltrar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.pbTxtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Name = "clientes"
        Me.Text = "clientes"
        CType(Me.pbTxtBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDImprentaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents cbFiltrar As System.Windows.Forms.ComboBox
    Friend WithEvents lblTabla As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents pbTxtBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents ClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BDImprentaDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents btnAnt As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
