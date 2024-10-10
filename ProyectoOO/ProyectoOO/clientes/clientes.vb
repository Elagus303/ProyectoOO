Public Class clientes

    Private Sub clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes)
        If Me.ClientesBindingSource1.Count = 0 Then
            lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
        End If

    End Sub
    Private Sub BuscarPorTexto()
        'dv.Table = Me.BD_ImprentaDataSet.Proveedores
        'dv.RowFilter = "nombre LIKE '" & txtBuscar.Text & "%'"
        'dv.Sort = "nombre ASC"
        '' Asignar el DataView al DataGridView del FormPpal
        'Me.ProveedoresDataGridView.DataSource = dv
        Me.ClientesBindingSource.Filter = "nombre LIKE '" & txtBuscar.Text & "%'"
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.ClientesDataGridView.SelectedRows.Count > 0 Then 'Si hay por lo menos una fila seleccionada
            Dim selectedRow = Me.ClientesDataGridView.SelectedRows(0)
            Dim clientName As String = selectedRow.Cells(0).Value.ToString() ' Ajusta el índice de la columna si es necesario
            Dim result As DialogResult = MessageBox.Show("¿Desea eliminar el registro de '" & clientName & "'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim x As Integer
                For x = Me.ClientesDataGridView.SelectedRows.Count - 1 To 0 Step -1
                    ' Eliminar el elemento seleccionado
                    Me.ClientesBindingSource.RemoveAt(Me.ClientesDataGridView.SelectedRows(x).Index)
                Next
                Me.ClientesBindingSource.EndEdit()

                MsgBox("Eliminación exitosa")
            Else
                ' El usuario eligió "No", no se realiza ninguna acción
                MsgBox("Eliminación cancelada")
            End If
        Else
            MsgBox("Seleccione, al menos, un elemento para borrar")
        End If
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        altas.Show()

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        cbFiltrar.DroppedDown = True

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim vista As New DataView
        vista.Table = Me.BD_ImprentaDataSet.Clientes

        ' Seleccionar la columna en base a la opción del ComboBox
        Select Case cbFiltrar.Text.ToLower()
            Case "nombre"
                vista.RowFilter = "nombre LIKE '" & txtBuscar.Text & "%'"

            Case "apellido"
                vista.RowFilter = "apellido LIKE '" & txtBuscar.Text & "%'"

            Case "id"
                ' Filtrar las ID que comiencen con el número ingresado
                If IsNumeric(txtBuscar.Text) Then
                    vista.RowFilter = "Convert(id, 'System.String') LIKE '" & txtBuscar.Text & "%'"
                Else
                    vista.RowFilter = "" ' Limpiar el filtro si el id no es válido
                End If

            Case Else
                vista.RowFilter = "" ' Limpiar el filtro si no hay selección válida en ComboBox
        End Select

        ' Asignar la vista al DataGridView
        Me.ClientesDataGridView.DataSource = vista
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text <> "" Then
            BuscarPorTexto()
            If Me.ClientesDataGridView.RowCount <= 0 Then
                lblTabla.Text = "Sin resultados compatibles" : lblTabla.Visible = True
            Else
                lblTabla.Visible = False
            End If
        End If
        
    End Sub

    Private Sub txtBuscar_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim vista As New DataView
        vista.Table = Me.BD_ImprentaDataSet.Clientes

        ' Seleccionar la columna en base a la opción del ComboBox
        Select Case cbFiltrar.Text.ToLower()
            Case "nombre"
                vista.RowFilter = "nombre LIKE '" & txtBuscar.Text & "%'"

            Case "apellido"
                vista.RowFilter = "apellido LIKE '" & txtBuscar.Text & "%'"

            Case "id"
                ' Filtrar las ID que comiencen con el número ingresado
                If IsNumeric(txtBuscar.Text) Then
                    vista.RowFilter = "Convert(id, 'System.String') LIKE '" & txtBuscar.Text & "%'"
                Else
                    vista.RowFilter = "" ' Limpiar el filtro si el id no es válido
                End If

            Case Else
                vista.RowFilter = "" ' Limpiar el filtro si no hay selección válida en ComboBox
        End Select

        ' Asignar la vista al DataGridView
        Me.ClientesDataGridView.DataSource = vista
    End Sub
End Class