Public Class FormProv

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub


    Private Sub ProveedoresBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub

    Private Sub FormProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Proveedores)
        'EstilosDataGridView
        ProveedoresDataGridView.BackgroundColor = ColorBase
        ProveedoresDataGridView.BorderStyle = BorderStyle.None
        ProveedoresDataGridView.RowHeadersVisible = False
        ProveedoresDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ProveedoresDataGridView.AllowUserToResizeColumns = False
        ProveedoresDataGridView.AllowUserToResizeRows = False
        ProveedoresDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ProveedoresDataGridView.EnableHeadersVisualStyles = False
        ProveedoresDataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorSobreBase
        ProveedoresDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        'ProveedoresDataGridView.ColumnHeadersDefaultCellStyle.Padding = New Padding(20)
    End Sub

    Private Sub btnOrdenarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenarTabla.Click
        cboxOrdenarTabla.DroppedDown = Not cboxOrdenarTabla.DroppedDown
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        FormProvAltas.ShowDialog()
    End Sub
End Class