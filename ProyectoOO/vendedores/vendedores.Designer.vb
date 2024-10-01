<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendedores
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
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Id_rolLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendedores))
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.VendedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendedoresTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.VendedoresTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.RolesTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.RolesTableAdapter()
        Me.VendedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Id_rolLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(24, 40)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(24, 66)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(63, 13)
        ContraseñaLabel.TabIndex = 2
        ContraseñaLabel.Text = "contraseña:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(24, 92)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "nombre:"
        '
        'Id_rolLabel
        '
        Id_rolLabel.AutoSize = True
        Id_rolLabel.Location = New System.Drawing.Point(24, 118)
        Id_rolLabel.Name = "Id_rolLabel"
        Id_rolLabel.Size = New System.Drawing.Size(32, 13)
        Id_rolLabel.TabIndex = 6
        Id_rolLabel.Text = "id rol:"
        '
        'BD_ImprentaDataSet
        '
        Me.BD_ImprentaDataSet.DataSetName = "BD_ImprentaDataSet"
        Me.BD_ImprentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendedoresBindingSource
        '
        Me.VendedoresBindingSource.DataMember = "Vendedores"
        Me.VendedoresBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'VendedoresTableAdapter
        '
        Me.VendedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.InsumoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RolesTableAdapter = Me.RolesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendedoresTableAdapter = Me.VendedoresTableAdapter
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'RolesTableAdapter
        '
        Me.RolesTableAdapter.ClearBeforeFill = True
        '
        'VendedoresDataGridView
        '
        Me.VendedoresDataGridView.AutoGenerateColumns = False
        Me.VendedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VendedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.VendedoresDataGridView.DataSource = Me.VendedoresBindingSource
        Me.VendedoresDataGridView.Location = New System.Drawing.Point(358, -1)
        Me.VendedoresDataGridView.Name = "VendedoresDataGridView"
        Me.VendedoresDataGridView.Size = New System.Drawing.Size(444, 471)
        Me.VendedoresDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "contraseña"
        Me.DataGridViewTextBoxColumn2.HeaderText = "contraseña"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_rol"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_rol"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataMember = "Roles"
        Me.RolesBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(ContraseñaLabel)
        Me.GroupBox1.Controls.Add(Me.ContraseñaTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Id_rolLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 248)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Añadir vendedor"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(17, 202)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 40)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(17, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 42)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Guardar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.RolesBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(93, 114)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.ValueMember = "id"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(130, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 42)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Nuevo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedoresBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(93, 37)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedoresBindingSource, "contraseña", True))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(93, 63)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ContraseñaTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedoresBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(93, 89)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(26, 53)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 28)
        Me.TextBox1.TabIndex = 37
        '
        'ComboBox2
        '
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(26, 26)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 38
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(296, 286)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(41, 42)
        Me.Button7.TabIndex = 23
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(296, 238)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 42)
        Me.Button6.TabIndex = 22
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(296, 192)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 40)
        Me.Button5.TabIndex = 21
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(296, 146)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(41, 40)
        Me.Button4.TabIndex = 20
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 383)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 74)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "eliminar"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Red
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.Location = New System.Drawing.Point(16, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(150, 45)
        Me.Button10.TabIndex = 1
        Me.Button10.Text = "Eliminar"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseCompatibleTextRendering = True
        Me.Button10.UseMnemonic = False
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Vendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 469)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VendedoresDataGridView)
        Me.Name = "Vendedores"
        Me.Text = "Vendedores"
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents VendedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendedoresTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.VendedoresTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RolesTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.RolesTableAdapter
    Friend WithEvents VendedoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContraseñaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class
