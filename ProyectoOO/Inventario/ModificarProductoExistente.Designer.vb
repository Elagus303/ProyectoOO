<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProductoExistente
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
        Dim StockLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.InsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InsumoTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.InsumoTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.acpbutton = New System.Windows.Forms.Button()
        Me.cncbutton = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(23, 54)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 7
        NombreLabel.Text = "Nombre:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(23, 82)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(52, 13)
        StockLabel.TabIndex = 9
        StockLabel.Text = "Cantidad:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(23, 108)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 11
        PrecioLabel.Text = "Precio:"
        '
        'BD_ImprentaDataSet
        '
        Me.BD_ImprentaDataSet.DataSetName = "BD_ImprentaDataSet"
        Me.BD_ImprentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InsumoBindingSource
        '
        Me.InsumoBindingSource.DataMember = "Insumo"
        Me.InsumoBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'InsumoTableAdapter
        '
        Me.InsumoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.InsumoTableAdapter = Me.InsumoTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendedoresTableAdapter = Nothing
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsumoBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(104, 54)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 8
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsumoBindingSource, "stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(104, 80)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StockTextBox.TabIndex = 10
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsumoBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(104, 105)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 12
        '
        'acpbutton
        '
        Me.acpbutton.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.acpbutton.FlatAppearance.BorderSize = 0
        Me.acpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.acpbutton.Location = New System.Drawing.Point(89, 193)
        Me.acpbutton.Name = "acpbutton"
        Me.acpbutton.Size = New System.Drawing.Size(75, 23)
        Me.acpbutton.TabIndex = 13
        Me.acpbutton.Text = "Aceptar"
        Me.acpbutton.UseVisualStyleBackColor = False
        '
        'cncbutton
        '
        Me.cncbutton.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cncbutton.FlatAppearance.BorderSize = 0
        Me.cncbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cncbutton.Location = New System.Drawing.Point(202, 193)
        Me.cncbutton.Name = "cncbutton"
        Me.cncbutton.Size = New System.Drawing.Size(75, 23)
        Me.cncbutton.TabIndex = 14
        Me.cncbutton.Text = "Cancelar"
        Me.cncbutton.UseVisualStyleBackColor = False
        '
        'ModificarProductoExistente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(402, 228)
        Me.Controls.Add(Me.cncbutton)
        Me.Controls.Add(Me.acpbutton)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Name = "ModificarProductoExistente"
        Me.Text = "Modificar Producto"
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents InsumoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InsumoTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.InsumoTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents acpbutton As System.Windows.Forms.Button
    Friend WithEvents cncbutton As System.Windows.Forms.Button
End Class
