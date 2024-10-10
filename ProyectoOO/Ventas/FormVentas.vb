Public Class FormVentas
    '1) FORMULARIO VENTAS
    '1.1) Load del formulario ventas
    Private Sub FormVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VentaTableAdapter.Fill(Me.BD_ImprentaDataSet.Venta) 'Llenar datos en DataGridView
        EstilosDataGridView(Me.VentaDataGridView) 'Estilizar DataGridView
    End Sub


    '2) BOTONES DEL FORMULARIO
    '2.1) Evento click en btn agregar
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        FormVentasAltas.ShowDialog()
    End Sub
    '2.2) Evento click en btn eliminar
    '2.3) Evento click en btn editar
    '2.4) Evento click en btn mover al primer elemento
    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        Me.VentaBindingSource.MoveFirst()
    End Sub
    '2.5) Evento click en btn mover al anterior elemento
    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        Me.VentaBindingSource.MovePrevious()
    End Sub
    '2.6) Evento click en btn mover al siguiente elemento
    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        Me.VentaBindingSource.MoveNext()
    End Sub
    '2.7) Evento click en btn mover al ultimo elemento
    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Me.VentaBindingSource.MoveLast()
    End Sub

    '3) COMPORTAMIENTO ORDENAR DATAGRIDVIEW
    '3.1) Evento click en btn ordenar (Mascara)
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenar.Click
        cbFiltrar.DroppedDown = True 'Desplegar lista
    End Sub
End Class