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
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.VentaDataGridView.SelectedRows.Count > 0 Then 'Si hay por lo menos una fila seleccionada
            Dim x As Integer
            '1) Obtener la lista de elementos seleccionados
            '2) Apuntar al ultimo elemento de esa lista
            '3) Obtener el indice de ese elemento y eliminar
            For x = Me.VentaDataGridView.SelectedRows.Count - 1 To 0 Step -1
                Me.VentaBindingSource.RemoveAt(Me.VentaDataGridView.SelectedRows(x).Index)
            Next
            Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'Confirmar cambios en el DataSet
            MsgBox("Eliminación exitosa")
        Else
            MsgBox("Seleccione, al menos, un elemento para borrar")
        End If
    End Sub
    '2.3) Evento click en btn editar
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        'Verifica que exista un elemento seleccionado
        If Me.VentaDataGridView.SelectedRows.Count < 1 Then
            MsgBox("Seleccione un elemento para editar")
        Else
            FormProvEdicion.ShowDialog()
        End If
    End Sub
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