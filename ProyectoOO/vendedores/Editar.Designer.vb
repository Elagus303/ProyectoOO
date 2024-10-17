<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar
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
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editar))
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.VendedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendedoresTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.VendedoresTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.cBoxRoles = New System.Windows.Forms.ComboBox()
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.RolesTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.RolesTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Id_rolLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(35, 50)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(35, 102)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(64, 13)
        ContraseñaLabel.TabIndex = 3
        ContraseñaLabel.Text = "Contraseña:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(35, 76)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'Id_rolLabel
        '
        Id_rolLabel.AutoSize = True
        Id_rolLabel.Location = New System.Drawing.Point(35, 154)
        Id_rolLabel.Name = "Id_rolLabel"
        Id_rolLabel.Size = New System.Drawing.Size(26, 13)
        Id_rolLabel.TabIndex = 7
        Id_rolLabel.Text = "Rol:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(35, 128)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(106, 13)
        Label1.TabIndex = 19
        Label1.Text = "confirmar contraseña"
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
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendedoresTableAdapter = Me.VendedoresTableAdapter
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedoresBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(150, 47)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(182, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedoresBindingSource, "contraseña", True))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(150, 99)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(182, 20)
        Me.ContraseñaTextBox.TabIndex = 4
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedoresBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(150, 73)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(182, 20)
        Me.NombreTextBox.TabIndex = 6
        '
        'cBoxRoles
        '
        Me.cBoxRoles.DataSource = Me.RolesBindingSource
        Me.cBoxRoles.DisplayMember = "nombre"
        Me.cBoxRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cBoxRoles.FormattingEnabled = True
        Me.cBoxRoles.Location = New System.Drawing.Point(150, 151)
        Me.cBoxRoles.Name = "cBoxRoles"
        Me.cBoxRoles.Size = New System.Drawing.Size(182, 21)
        Me.cBoxRoles.TabIndex = 10
        Me.cBoxRoles.ValueMember = "id"
        '
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataMember = "Roles"
        Me.RolesBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(237, 212)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(128, 37)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(12, 212)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(128, 37)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'RolesTableAdapter
        '
        Me.RolesTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedoresBindingSource, "contraseña", True))
        Me.TextBox1.Location = New System.Drawing.Point(150, 125)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(182, 20)
        Me.TextBox1.TabIndex = 20
        '
        'Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(377, 261)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cBoxRoles)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Id_rolLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Editar"
        Me.Text = "Editar datos"
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
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContraseñaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cBoxRoles As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents RolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RolesTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.RolesTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
