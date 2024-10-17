Public Class Consultaeliminar

    Private Sub Consultacambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Canchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Canchange.Click
        Me.Close()

    End Sub

    Private Sub Confchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confchange.Click
        Inventario.InsumoBindingSource.RemoveAt(Inventario.InsumoBindingSource.Position)
        Inventario.TableAdapterManager.UpdateAll(Inventario.BD_ImprentaDataSet)
        Me.Close()

    End Sub
End Class