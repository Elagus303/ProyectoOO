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
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Id_vendedorLabel As System.Windows.Forms.Label
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.VentaTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Id_vendedorComboBox = New System.Windows.Forms.ComboBox()
        Me.rBtnBlancoNegro = New System.Windows.Forms.RadioButton()
        Me.rBtnColor = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rBtnSimple = New System.Windows.Forms.RadioButton()
        Me.rBtnDoble = New System.Windows.Forms.RadioButton()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cBoxAnillado = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Id_vendedorLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(101, 15)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(101, 174)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(51, 13)
        CantidadLabel.TabIndex = 9
        CantidadLabel.Text = "cantidad:"
        '
        'Id_vendedorLabel
        '
        Id_vendedorLabel.AutoSize = True
        Id_vendedorLabel.Location = New System.Drawing.Point(101, 41)
        Id_vendedorLabel.Name = "Id_vendedorLabel"
        Id_vendedorLabel.Size = New System.Drawing.Size(66, 13)
        Id_vendedorLabel.TabIndex = 11
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
        Me.IdTextBox.Location = New System.Drawing.Point(192, 12)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(192, 171)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CantidadTextBox.TabIndex = 10
        '
        'Id_vendedorComboBox
        '
        Me.Id_vendedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "id_vendedor", True))
        Me.Id_vendedorComboBox.DataSource = Me.VentaBindingSource
        Me.Id_vendedorComboBox.DisplayMember = "id"
        Me.Id_vendedorComboBox.FormattingEnabled = True
        Me.Id_vendedorComboBox.Location = New System.Drawing.Point(192, 38)
        Me.Id_vendedorComboBox.Name = "Id_vendedorComboBox"
        Me.Id_vendedorComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Id_vendedorComboBox.TabIndex = 12
        Me.Id_vendedorComboBox.ValueMember = "id"
        '
        'rBtnBlancoNegro
        '
        Me.rBtnBlancoNegro.AutoSize = True
        Me.rBtnBlancoNegro.Location = New System.Drawing.Point(23, 19)
        Me.rBtnBlancoNegro.Name = "rBtnBlancoNegro"
        Me.rBtnBlancoNegro.Size = New System.Drawing.Size(98, 17)
        Me.rBtnBlancoNegro.TabIndex = 13
        Me.rBtnBlancoNegro.TabStop = True
        Me.rBtnBlancoNegro.Text = "Blanco y Negro"
        Me.rBtnBlancoNegro.UseVisualStyleBackColor = True
        '
        'rBtnColor
        '
        Me.rBtnColor.AutoSize = True
        Me.rBtnColor.Location = New System.Drawing.Point(23, 42)
        Me.rBtnColor.Name = "rBtnColor"
        Me.rBtnColor.Size = New System.Drawing.Size(49, 17)
        Me.rBtnColor.TabIndex = 14
        Me.rBtnColor.TabStop = True
        Me.rBtnColor.Text = "Color"
        Me.rBtnColor.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rBtnBlancoNegro)
        Me.GroupBox1.Controls.Add(Me.rBtnColor)
        Me.GroupBox1.Location = New System.Drawing.Point(76, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 100)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rBtnSimple)
        Me.GroupBox2.Controls.Add(Me.rBtnDoble)
        Me.GroupBox2.Location = New System.Drawing.Point(246, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 100)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'rBtnSimple
        '
        Me.rBtnSimple.AutoSize = True
        Me.rBtnSimple.Location = New System.Drawing.Point(23, 19)
        Me.rBtnSimple.Name = "rBtnSimple"
        Me.rBtnSimple.Size = New System.Drawing.Size(56, 17)
        Me.rBtnSimple.TabIndex = 13
        Me.rBtnSimple.TabStop = True
        Me.rBtnSimple.Text = "Simple"
        Me.rBtnSimple.UseVisualStyleBackColor = True
        '
        'rBtnDoble
        '
        Me.rBtnDoble.AutoSize = True
        Me.rBtnDoble.Location = New System.Drawing.Point(23, 42)
        Me.rBtnDoble.Name = "rBtnDoble"
        Me.rBtnDoble.Size = New System.Drawing.Size(53, 17)
        Me.rBtnDoble.TabIndex = 14
        Me.rBtnDoble.TabStop = True
        Me.rBtnDoble.Text = "Doble"
        Me.rBtnDoble.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(223, 248)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cBoxAnillado
        '
        Me.cBoxAnillado.AutoSize = True
        Me.cBoxAnillado.Location = New System.Drawing.Point(183, 197)
        Me.cBoxAnillado.Name = "cBoxAnillado"
        Me.cBoxAnillado.Size = New System.Drawing.Size(63, 17)
        Me.cBoxAnillado.TabIndex = 21
        Me.cBoxAnillado.Text = "Anillado"
        Me.cBoxAnillado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Precio: $ 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Total: $ 0"
        '
        'FormVentasAltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 283)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cBoxAnillado)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Id_vendedorLabel)
        Me.Controls.Add(Me.Id_vendedorComboBox)
        Me.Name = "FormVentasAltas"
        Me.Text = "FormVentasAltas"
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents VentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentaTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.VentaTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_vendedorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents rBtnBlancoNegro As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnColor As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rBtnSimple As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnDoble As System.Windows.Forms.RadioButton
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cBoxAnillado As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
