<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProvEdicion
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.ProveedoresTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(66, 36)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(125, 33)
        Me.NombreTextBox.MaxLength = 20
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(66, 62)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 3
        TelefonoLabel.Text = "Teléfono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(125, 59)
        Me.TelefonoTextBox.MaxLength = 10
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 4
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(66, 88)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(41, 13)
        CorreoLabel.TabIndex = 5
        CorreoLabel.Text = "Correo:"
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(125, 85)
        Me.CorreoTextBox.MaxLength = 100
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CorreoTextBox.TabIndex = 6
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(66, 114)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 7
        DireccionLabel.Text = "Dirección:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(125, 111)
        Me.DireccionTextBox.MaxLength = 100
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 8
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(66, 140)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(56, 13)
        LocalidadLabel.TabIndex = 9
        LocalidadLabel.Text = "Localidad:"
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(125, 137)
        Me.LocalidadTextBox.MaxLength = 100
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocalidadTextBox.TabIndex = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(32, 214)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(179, 214)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 12
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'FormProvEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(LocalidadLabel)
        Me.Controls.Add(Me.LocalidadTextBox)
        Me.Name = "FormProvEdicion"
        Me.Text = "FormEditar"
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorreoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
