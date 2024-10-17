Public Class Agregarinventario

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prodlab.Click

    End Sub

    Private Sub Canbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Canbutton.Click
        Me.Close()

    End Sub

    Private Sub Aceptbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.InsumoBindingSource.AddNew()
    End Sub

    Private Sub InsumoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Aceptbutton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptbutton.Click
        Me.InsumoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(BD_ImprentaDataSet)
        Inventario.InsumoTableAdapter.Fill(Inventario.BD_ImprentaDataSet.Insumo)
        Me.Close()

    End Sub
End Class