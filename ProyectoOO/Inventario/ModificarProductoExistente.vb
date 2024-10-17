Public Class ModificarProductoExistente

    Private Sub InsumoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InsumoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub

    Private Sub ModificarProductoExistente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Insumo' Puede moverla o quitarla según sea necesario.
        Me.InsumoTableAdapter.Fill(Me.BD_ImprentaDataSet.Insumo)
        Me.InsumoBindingSource.Position = Inventario.InsumoBindingSource.Position


    End Sub

    Private Sub NombreTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreTextBox.TextChanged

    End Sub

    Private Sub acpbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acpbutton.Click
        Me.InsumoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)
        Inventario.InsumoTableAdapter.Fill(Inventario.BD_ImprentaDataSet.Insumo)
        Me.Close()

    End Sub

    Private Sub cncbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cncbutton.Click
        Me.Close()
    End Sub
End Class