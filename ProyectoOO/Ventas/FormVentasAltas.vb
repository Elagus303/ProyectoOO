Public Class FormVentasAltas

    Private Sub VentaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub

    Private Sub VentasAltas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.BD_ImprentaDataSet.Venta)
        Me.VentaBindingSource.AddNew()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        Try
            Me.VentaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(BD_ImprentaDataSet)
            Me.VentaTableAdapter.Fill(Me.BD_ImprentaDataSet.Venta)
            FormVentas.VentaTableAdapter.Fill(FormVentas.BD_ImprentaDataSet.Venta)

            MsgBox("Se añadió correctamente la venta")
            Me.VentaBindingSource.AddNew()
        Catch ex As System.Data.NoNullAllowedException
            MsgBox("Hay campos vacios")
        End Try
    End Sub
End Class