﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Me.BD_ImprentaDataSet = New ProyectoOO.BD_ImprentaDataSet()
        Me.InsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InsumoTableAdapter = New ProyectoOO.BD_ImprentaDataSetTableAdapters.InsumoTableAdapter()
        Me.TableAdapterManager = New ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager()
        Me.InsumoDataGridView = New System.Windows.Forms.DataGridView()
        Me.Addbutton = New System.Windows.Forms.Button()
        Me.modbutton = New System.Windows.Forms.Button()
        Me.delbutton = New System.Windows.Forms.Button()
        Me.Inventariolab = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsumoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'InsumoDataGridView
        '
        Me.InsumoDataGridView.AllowUserToAddRows = False
        Me.InsumoDataGridView.AllowUserToDeleteRows = False
        Me.InsumoDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InsumoDataGridView.AutoGenerateColumns = False
        Me.InsumoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InsumoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.precioTotal, Me.DataGridViewTextBoxColumn5})
        Me.InsumoDataGridView.DataSource = Me.InsumoBindingSource
        Me.InsumoDataGridView.Location = New System.Drawing.Point(12, 47)
        Me.InsumoDataGridView.Name = "InsumoDataGridView"
        Me.InsumoDataGridView.ReadOnly = True
        Me.InsumoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InsumoDataGridView.Size = New System.Drawing.Size(617, 220)
        Me.InsumoDataGridView.TabIndex = 1
        '
        'Addbutton
        '
        Me.Addbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Addbutton.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Addbutton.FlatAppearance.BorderSize = 0
        Me.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addbutton.Location = New System.Drawing.Point(635, 47)
        Me.Addbutton.Name = "Addbutton"
        Me.Addbutton.Size = New System.Drawing.Size(75, 23)
        Me.Addbutton.TabIndex = 2
        Me.Addbutton.Text = "Agregar"
        Me.Addbutton.UseVisualStyleBackColor = False
        '
        'modbutton
        '
        Me.modbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.modbutton.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.modbutton.FlatAppearance.BorderSize = 0
        Me.modbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modbutton.Location = New System.Drawing.Point(635, 76)
        Me.modbutton.Name = "modbutton"
        Me.modbutton.Size = New System.Drawing.Size(75, 23)
        Me.modbutton.TabIndex = 3
        Me.modbutton.Text = "Modificar"
        Me.modbutton.UseVisualStyleBackColor = False
        '
        'delbutton
        '
        Me.delbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.delbutton.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.delbutton.FlatAppearance.BorderSize = 0
        Me.delbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delbutton.Location = New System.Drawing.Point(635, 105)
        Me.delbutton.Name = "delbutton"
        Me.delbutton.Size = New System.Drawing.Size(75, 23)
        Me.delbutton.TabIndex = 4
        Me.delbutton.Text = "Eliminar"
        Me.delbutton.UseVisualStyleBackColor = False
        '
        'Inventariolab
        '
        Me.Inventariolab.AutoSize = True
        Me.Inventariolab.Location = New System.Drawing.Point(12, 9)
        Me.Inventariolab.Name = "Inventariolab"
        Me.Inventariolab.Size = New System.Drawing.Size(54, 13)
        Me.Inventariolab.TabIndex = 5
        Me.Inventariolab.Text = "Inventario"
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "stock"
        Me.DataGridViewTextBoxColumn3.HeaderText = "stock"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'precioTotal
        '
        Me.precioTotal.DataPropertyName = "precioTotal"
        Me.precioTotal.HeaderText = "precioTotal"
        Me.precioTotal.Name = "precioTotal"
        Me.precioTotal.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_proovedor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id_proovedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(723, 380)
        Me.Controls.Add(Me.Inventariolab)
        Me.Controls.Add(Me.delbutton)
        Me.Controls.Add(Me.modbutton)
        Me.Controls.Add(Me.Addbutton)
        Me.Controls.Add(Me.InsumoDataGridView)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.BD_ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsumoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_ImprentaDataSet As ProyectoOO.BD_ImprentaDataSet
    Friend WithEvents InsumoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InsumoTableAdapter As ProyectoOO.BD_ImprentaDataSetTableAdapters.InsumoTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoOO.BD_ImprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InsumoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Addbutton As System.Windows.Forms.Button
    Friend WithEvents modbutton As System.Windows.Forms.Button
    Friend WithEvents delbutton As System.Windows.Forms.Button
    Friend WithEvents Inventariolab As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
