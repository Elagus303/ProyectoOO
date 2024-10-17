Public Class FormProv
    '1) FORMULARIO PROVEEDORES
    '1.1) Load del formulario proveedores
    Private Sub FormProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ProveedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Proveedores) 'Cargar datos en la tabla
        EstilosDataGridView(Me.ProveedoresDataGridView) 'EstilosDataGridView

        'Segun cantidad de elementos del binding source...
        If Me.ProveedoresBindingSource.Count = 0 Then
            lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
        End If
    End Sub


    '2) BOTONES 
    '2.1) Click en botón añadir
    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        FormProvAltas.ShowDialog()
    End Sub
    '2.2) Click en botón editar
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        'Seleccionar un elemento para editar
        If Me.ProveedoresDataGridView.SelectedRows.Count < 1 Then
            MsgBox("Seleccione un elemento para editar")
        Else
            FormProvEdicion.ShowDialog()
        End If
    End Sub
    '2.3) Click en botón eliminar
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.ProveedoresDataGridView.SelectedRows.Count > 0 Then 'Si hay por lo menos una fila seleccionada
            Dim x As Integer
            '1) Obtener la lista de elementos seleccionados
            '2) Apuntar al ultimo elemento de esa lista
            '3) Obtener el indice de ese elemento y eliminar
            For x = Me.ProveedoresDataGridView.SelectedRows.Count - 1 To 0 Step -1
                Me.ProveedoresBindingSource.RemoveAt(Me.ProveedoresDataGridView.SelectedRows(x).Index)
            Next
            Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'Confirmar cambios en el DataSet
            MsgBox("Eliminación exitosa")
        Else
            MsgBox("Seleccione, al menos, un elemento para borrar")
        End If
    End Sub
    '2.3) Click en botón mover al primer elemento
    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ProveedoresBindingSource.MoveFirst()
    End Sub
    '2.2) Click en botón mover al anterior elemento
    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ProveedoresBindingSource.MovePrevious()
    End Sub
    '2.2) Click en botón mover al siguiente elemento
    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ProveedoresBindingSource.MoveNext()
    End Sub
    '2.2) Click en botón mover al último elemento
    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ProveedoresBindingSource.MoveLast()
    End Sub


    '3) COMPORTAMIENTO DE BUSCAR ELEMENTO
    '3.1) Click en el fondo del txtBuscar
    Private Sub pbTxtBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTxtBuscar.Click
        txtBuscar.Focus()
    End Sub
    '3.2) Click en botón buscar
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text <> "" Then
            BuscarPorTexto()
            If Me.ProveedoresDataGridView.RowCount <= 0 Then
                lblTabla.Text = "Sin resultados compatibles" : lblTabla.Visible = True
            Else
                lblTabla.Visible = False
            End If
        End If
    End Sub
    'Private dv As New DataView
    Private Sub BuscarPorTexto()
        'dv.Table = Me.BD_ImprentaDataSet.Proveedores
        'dv.RowFilter = "nombre LIKE '" & txtBuscar.Text & "%'"
        'dv.Sort = "nombre ASC"
        '' Asignar el DataView al DataGridView del FormPpal
        'Me.ProveedoresDataGridView.DataSource = dv
        Me.ProveedoresBindingSource.Filter = "nombre LIKE '" & txtBuscar.Text & "%'"
    End Sub
    '3.3) Cuando se deja limpio el txtBuscar
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            'dv.RowFilter = ""
            Me.ProveedoresBindingSource.RemoveFilter()
            If Me.ProveedoresBindingSource.Count <= 0 Then
                lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
            Else
                lblTabla.Visible = False
            End If
        End If
    End Sub


    '4) COMPORTAMIENTO DEL DATAGRIDVIEW
    '4.1) Ocultar botones segun cuantos elementos seleccionemos
    Private Sub ProveedoresDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresDataGridView.SelectionChanged
        If Me.ProveedoresDataGridView.SelectedRows.Count > 1 Then
            btnEditar.Visible = False
        Else
            btnEditar.Visible = True
        End If
    End Sub
    '4.2) Comportamiento cartel si se agrega nuevo elemento
    Private Sub ProveedoresDataGridView_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles ProveedoresDataGridView.RowsAdded
        lblTabla.Visible = False
    End Sub
    '4.3) Comportamiento cartel si se eliminan todos los registros
    Private Sub ProveedoresDataGridView_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles ProveedoresDataGridView.RowsRemoved
        If Me.ProveedoresBindingSource.Count <= 0 Then
            lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
        End If
    End Sub




    '5) COMPORTAMIENTO DEL FILTRO DE RESULTADOS
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        cbFiltrar.DroppedDown = True
    End Sub
End Class