Public Class Inventario

    Private Sub InsumoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InsumoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub

    Private Sub Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Insumo' Puede moverla o quitarla según sea necesario.
        Me.InsumoTableAdapter.Fill(Me.BD_ImprentaDataSet.Insumo)

    End Sub

    Private Sub Addbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addbutton.Click
        Agregarinventario.Show()

    End Sub

    Private Sub modbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modbutton.Click
        ModificarProductoExistente.Show()

    End Sub

    Private Sub delbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delbutton.Click
        Consultacambio.Show()
    End Sub
End Class