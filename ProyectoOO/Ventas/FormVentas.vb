Public Class FormVentas
    Private Sub FormVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.BD_ImprentaDataSet.Venta)
        EstilosDataGridView(Me.VentaDataGridView)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        FormVentasAltas.ShowDialog()
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenar.Click
        cbFiltrar.DroppedDown = True
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        Me.VentaBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        Me.VentaBindingSource.MovePrevious()
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        Me.VentaBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Me.VentaBindingSource.MoveLast()
    End Sub
End Class