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
        Dim Es_colorLabel As System.Windows.Forms.Label
        Dim Es_doble_fazLabel As System.Windows.Forms.Label
        Dim Es_anilladoLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Id_vendedorLabel As System.Windows.Forms.Label
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.VentaTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Es_colorCheckBox = New System.Windows.Forms.CheckBox()
        Me.Es_doble_fazCheckBox = New System.Windows.Forms.CheckBox()
        Me.Es_anilladoCheckBox = New System.Windows.Forms.CheckBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Id_vendedorTextBox = New System.Windows.Forms.TextBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Id_clienteComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Es_colorLabel = New System.Windows.Forms.Label()
        Es_doble_fazLabel = New System.Windows.Forms.Label()
        Es_anilladoLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Id_vendedorLabel = New System.Windows.Forms.Label()
        Id_clienteLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(193, 81)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'Es_colorLabel
        '
        Es_colorLabel.AutoSize = True
        Es_colorLabel.Location = New System.Drawing.Point(193, 161)
        Es_colorLabel.Name = "Es_colorLabel"
        Es_colorLabel.Size = New System.Drawing.Size(47, 13)
        Es_colorLabel.TabIndex = 7
        Es_colorLabel.Text = "es color:"
        '
        'Es_doble_fazLabel
        '
        Es_doble_fazLabel.AutoSize = True
        Es_doble_fazLabel.Location = New System.Drawing.Point(193, 191)
        Es_doble_fazLabel.Name = "Es_doble_fazLabel"
        Es_doble_fazLabel.Size = New System.Drawing.Size(67, 13)
        Es_doble_fazLabel.TabIndex = 9
        Es_doble_fazLabel.Text = "es doble faz:"
        '
        'Es_anilladoLabel
        '
        Es_anilladoLabel.AutoSize = True
        Es_anilladoLabel.Location = New System.Drawing.Point(193, 221)
        Es_anilladoLabel.Name = "Es_anilladoLabel"
        Es_anilladoLabel.Size = New System.Drawing.Size(60, 13)
        Es_anilladoLabel.TabIndex = 11
        Es_anilladoLabel.Text = "es anillado:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(193, 249)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(51, 13)
        CantidadLabel.TabIndex = 13
        CantidadLabel.Text = "cantidad:"
        '
        'Id_vendedorLabel
        '
        Id_vendedorLabel.AutoSize = True
        Id_vendedorLabel.Location = New System.Drawing.Point(193, 275)
        Id_vendedorLabel.Name = "Id_vendedorLabel"
        Id_vendedorLabel.Size = New System.Drawing.Size(66, 13)
        Id_vendedorLabel.TabIndex = 15
        Id_vendedorLabel.Text = "id vendedor:"
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
        Me.IdTextBox.Location = New System.Drawing.Point(268, 78)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'Es_colorCheckBox
        '
        Me.Es_colorCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VentaBindingSource, "es_color", True))
        Me.Es_colorCheckBox.Location = New System.Drawing.Point(268, 156)
        Me.Es_colorCheckBox.Name = "Es_colorCheckBox"
        Me.Es_colorCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Es_colorCheckBox.TabIndex = 8
        Me.Es_colorCheckBox.Text = "CheckBox1"
        Me.Es_colorCheckBox.UseVisualStyleBackColor = True
        '
        'Es_doble_fazCheckBox
        '
        Me.Es_doble_fazCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VentaBindingSource, "es_doble_faz", True))
        Me.Es_doble_fazCheckBox.Location = New System.Drawing.Point(268, 186)
        Me.Es_doble_fazCheckBox.Name = "Es_doble_fazCheckBox"
        Me.Es_doble_fazCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Es_doble_fazCheckBox.TabIndex = 10
        Me.Es_doble_fazCheckBox.Text = "CheckBox1"
        Me.Es_doble_fazCheckBox.UseVisualStyleBackColor = True
        '
        'Es_anilladoCheckBox
        '
        Me.Es_anilladoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VentaBindingSource, "es_anillado", True))
        Me.Es_anilladoCheckBox.Location = New System.Drawing.Point(268, 216)
        Me.Es_anilladoCheckBox.Name = "Es_anilladoCheckBox"
        Me.Es_anilladoCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Es_anilladoCheckBox.TabIndex = 12
        Me.Es_anilladoCheckBox.Text = "CheckBox1"
        Me.Es_anilladoCheckBox.UseVisualStyleBackColor = True
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(268, 246)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CantidadTextBox.TabIndex = 14
        '
        'Id_vendedorTextBox
        '
        Me.Id_vendedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "id_vendedor", True))
        Me.Id_vendedorTextBox.Location = New System.Drawing.Point(268, 272)
        Me.Id_vendedorTextBox.Name = "Id_vendedorTextBox"
        Me.Id_vendedorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_vendedorTextBox.TabIndex = 16
        '
        'btnAnadir
        '
        Me.btnAnadir.Location = New System.Drawing.Point(213, 340)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAnadir.TabIndex = 19
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(325, 340)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(474, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 20)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Busq. Avanz."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.Location = New System.Drawing.Point(210, 302)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(52, 13)
        Id_clienteLabel.TabIndex = 21
        Id_clienteLabel.Text = "id cliente:"
        '
        'Id_clienteComboBox
        '
        Me.Id_clienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "id_cliente", True))
        Me.Id_clienteComboBox.FormattingEnabled = True
        Me.Id_clienteComboBox.Location = New System.Drawing.Point(268, 299)
        Me.Id_clienteComboBox.Name = "Id_clienteComboBox"
        Me.Id_clienteComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Id_clienteComboBox.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(559, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Unidad: $0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(559, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Total: $0"
        '
        'FormVentasAltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 383)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Id_clienteLabel)
        Me.Controls.Add(Me.Id_clienteComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Es_colorLabel)
        Me.Controls.Add(Me.Es_colorCheckBox)
        Me.Controls.Add(Es_doble_fazLabel)
        Me.Controls.Add(Me.Es_doble_fazCheckBox)
        Me.Controls.Add(Es_anilladoLabel)
        Me.Controls.Add(Me.Es_anilladoCheckBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Id_vendedorLabel)
        Me.Controls.Add(Me.Id_vendedorTextBox)
        Me.Name = "FormVentasAltas"
        Me.Text = "VentasAltas"
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents VentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentaTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.VentaTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Es_colorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Es_doble_fazCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Es_anilladoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_vendedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Id_clienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
