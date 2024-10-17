<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregarinventario
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
        Me.prodlab = New System.Windows.Forms.Label()
        Me.preclab = New System.Windows.Forms.Label()
        Me.cantlab = New System.Windows.Forms.Label()
        Me.proovlab = New System.Windows.Forms.Label()
        Me.prodtext = New System.Windows.Forms.TextBox()
        Me.InsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.prectext = New System.Windows.Forms.TextBox()
        Me.cantprec = New System.Windows.Forms.TextBox()
        Me.Aceptbutton = New System.Windows.Forms.Button()
        Me.Canbutton = New System.Windows.Forms.Button()
        Me.InsumoTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.InsumoTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.comboBoxProvs = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.ProveedoresTableAdapter()
        CType(Me.InsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prodlab
        '
        Me.prodlab.AutoSize = True
        Me.prodlab.Location = New System.Drawing.Point(7, 36)
        Me.prodlab.Name = "prodlab"
        Me.prodlab.Size = New System.Drawing.Size(50, 13)
        Me.prodlab.TabIndex = 0
        Me.prodlab.Text = "Producto"
        '
        'preclab
        '
        Me.preclab.AutoSize = True
        Me.preclab.Location = New System.Drawing.Point(7, 65)
        Me.preclab.Name = "preclab"
        Me.preclab.Size = New System.Drawing.Size(37, 13)
        Me.preclab.TabIndex = 1
        Me.preclab.Text = "Precio"
        '
        'cantlab
        '
        Me.cantlab.AutoSize = True
        Me.cantlab.Location = New System.Drawing.Point(7, 89)
        Me.cantlab.Name = "cantlab"
        Me.cantlab.Size = New System.Drawing.Size(49, 13)
        Me.cantlab.TabIndex = 2
        Me.cantlab.Text = "Cantidad"
        '
        'proovlab
        '
        Me.proovlab.AutoSize = True
        Me.proovlab.Location = New System.Drawing.Point(6, 118)
        Me.proovlab.Name = "proovlab"
        Me.proovlab.Size = New System.Drawing.Size(56, 13)
        Me.proovlab.TabIndex = 3
        Me.proovlab.Text = "Proovedor"
        '
        'prodtext
        '
        Me.prodtext.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsumoBindingSource, "nombre", True))
        Me.prodtext.Location = New System.Drawing.Point(88, 28)
        Me.prodtext.MaxLength = 20
        Me.prodtext.Name = "prodtext"
        Me.prodtext.Size = New System.Drawing.Size(100, 20)
        Me.prodtext.TabIndex = 4
        '
        'InsumoBindingSource
        '
        Me.InsumoBindingSource.DataMember = "Insumo"
        Me.InsumoBindingSource.DataSource = Me.BD_ImprentaDataSet
        '
        'BD_ImprentaDataSet
        '
        Me.BD_ImprentaDataSet.DataSetName = "BD_ImprentaDataSet"
        Me.BD_ImprentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'prectext
        '
        Me.prectext.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsumoBindingSource, "precio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.prectext.Location = New System.Drawing.Point(88, 58)
        Me.prectext.MaxLength = 20
        Me.prectext.Name = "prectext"
        Me.prectext.Size = New System.Drawing.Size(100, 20)
        Me.prectext.TabIndex = 5
        '
        'cantprec
        '
        Me.cantprec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsumoBindingSource, "stock", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.cantprec.Location = New System.Drawing.Point(88, 85)
        Me.cantprec.MaxLength = 20
        Me.cantprec.Name = "cantprec"
        Me.cantprec.Size = New System.Drawing.Size(100, 20)
        Me.cantprec.TabIndex = 6
        '
        'Aceptbutton
        '
        Me.Aceptbutton.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Aceptbutton.FlatAppearance.BorderSize = 0
        Me.Aceptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aceptbutton.Location = New System.Drawing.Point(113, 179)
        Me.Aceptbutton.Name = "Aceptbutton"
        Me.Aceptbutton.Size = New System.Drawing.Size(75, 23)
        Me.Aceptbutton.TabIndex = 8
        Me.Aceptbutton.Text = "Aceptar"
        Me.Aceptbutton.UseVisualStyleBackColor = False
        '
        'Canbutton
        '
        Me.Canbutton.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Canbutton.FlatAppearance.BorderSize = 0
        Me.Canbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Canbutton.Location = New System.Drawing.Point(225, 179)
        Me.Canbutton.Name = "Canbutton"
        Me.Canbutton.Size = New System.Drawing.Size(75, 23)
        Me.Canbutton.TabIndex = 9
        Me.Canbutton.Text = "Cancelar"
        Me.Canbutton.UseVisualStyleBackColor = False
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
        'comboBoxProvs
        '
        Me.comboBoxProvs.DataSource = Me.ProveedoresBindingSource
        Me.comboBoxProvs.DisplayMember = "nombre"
        Me.comboBoxProvs.FormattingEnabled = True
        Me.comboBoxProvs.Location = New System.Drawing.Point(88, 115)
        Me.comboBoxProvs.Name = "comboBoxProvs"
        Me.comboBoxProvs.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxProvs.TabIndex = 10
        Me.comboBoxProvs.ValueMember = "id"
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
        'Agregarinventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(444, 214)
        Me.Controls.Add(Me.comboBoxProvs)
        Me.Controls.Add(Me.Canbutton)
        Me.Controls.Add(Me.Aceptbutton)
        Me.Controls.Add(Me.cantprec)
        Me.Controls.Add(Me.prectext)
        Me.Controls.Add(Me.prodtext)
        Me.Controls.Add(Me.proovlab)
        Me.Controls.Add(Me.cantlab)
        Me.Controls.Add(Me.preclab)
        Me.Controls.Add(Me.prodlab)
        Me.Name = "Agregarinventario"
        Me.Text = "Agregar nuevo producto"
        CType(Me.InsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prodlab As System.Windows.Forms.Label
    Friend WithEvents preclab As System.Windows.Forms.Label
    Friend WithEvents cantlab As System.Windows.Forms.Label
    Friend WithEvents proovlab As System.Windows.Forms.Label
    Friend WithEvents prodtext As System.Windows.Forms.TextBox
    Friend WithEvents prectext As System.Windows.Forms.TextBox
    Friend WithEvents cantprec As System.Windows.Forms.TextBox
    Friend WithEvents Aceptbutton As System.Windows.Forms.Button
    Friend WithEvents Canbutton As System.Windows.Forms.Button
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents InsumoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InsumoTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.InsumoTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents comboBoxProvs As System.Windows.Forms.ComboBox
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.ProveedoresTableAdapter
End Class
