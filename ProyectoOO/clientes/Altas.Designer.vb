<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltasClientes
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
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltasClientes))
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolesTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.RolesTableAdapter()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        ApellidoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(95, 87)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 6
        ApellidoLabel.Text = "Apellido:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(95, 113)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 8
        TelefonoLabel.Text = "Teléfono:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(95, 61)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(95, 139)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(41, 13)
        CorreoLabel.TabIndex = 10
        CorreoLabel.Text = "Correo:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(95, 35)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 2
        IdLabel.Text = "Id:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(95, 165)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 12
        DireccionLabel.Text = "Direccion:"
        '
        'BD_ImprentaDataSet
        '
        Me.BD_ImprentaDataSet.DataSetName = "BD_ImprentaDataSet"
        Me.BD_ImprentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataMember = "Roles"
        Me.RolesBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'RolesTableAdapter
        '
        Me.RolesTableAdapter.ClearBeforeFill = True
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(154, 84)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 7
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(154, 58)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(154, 110)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 9
        '
        'IdTextBox
        '
        Me.IdTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(154, 32)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 3
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(154, 136)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CorreoTextBox.TabIndex = 11
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(14, 217)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(154, 53)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar registro"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.Location = New System.Drawing.Point(174, 217)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(154, 52)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar registro"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(154, 162)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 13
        '
        'AltasClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 284)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(IdLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AltasClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar cliente"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RolesTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.RolesTableAdapter
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorreoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
End Class
