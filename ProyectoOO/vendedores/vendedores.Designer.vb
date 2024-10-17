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
        Dim Id_rolLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendedores))
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.VendedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendedoresTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.VendedoresTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.RolesTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.RolesTableAdapter()
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Id_rolLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_rolLabel
        '
        Id_rolLabel.AutoSize = True
        Id_rolLabel.Location = New System.Drawing.Point(32, 142)
        Id_rolLabel.Name = "Id_rolLabel"
        Id_rolLabel.Size = New System.Drawing.Size(32, 13)
        Id_rolLabel.TabIndex = 6
        Id_rolLabel.Text = "id rol:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(32, 64)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "nombre:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(32, 90)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(63, 13)
        ContraseñaLabel.TabIndex = 2
        ContraseñaLabel.Text = "contraseña:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(32, 38)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(32, 116)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(109, 13)
        Label1.TabIndex = 17
        Label1.Text = "confirmar contraseña:"
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
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataMember = "Roles"
        Me.RolesBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.Location = New System.Drawing.Point(12, 213)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(110, 40)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Nuevo")
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedoresBindingSource, "contraseña", True))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(149, 87)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(187, 20)
        Me.ContraseñaTextBox.TabIndex = 3
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedoresBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(149, 35)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(187, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(128, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 42)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Guardar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(241, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 40)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.RolesBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(149, 139)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.ValueMember = "id"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedoresBindingSource, "contraseña", True))
        Me.TextBox1.Location = New System.Drawing.Point(149, 113)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 20)
        Me.TextBox1.TabIndex = 18
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedoresBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(149, 61)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(187, 20)
        Me.NombreTextBox.TabIndex = 23
        '
        'Vendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(362, 273)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Id_rolLabel)
        Me.Name = "Vendedores"
        Me.Text = "Vendedores"
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents VendedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendedoresTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.VendedoresTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RolesTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.RolesTableAdapter
    Friend WithEvents RolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents ContraseñaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
End Class
