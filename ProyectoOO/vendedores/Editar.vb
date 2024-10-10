Public Class Editar

    Private Sub VendedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VendedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub

    Private Sub Editar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores)

    End Sub
End Class