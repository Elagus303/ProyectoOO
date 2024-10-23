Public Class clientes
    '1) FORMULARIO DE CLIENTES
    '1.1) Evento Load del formulario
    Private Sub clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes) 'Cargar datos
        EstilosDataGridView(Me.ClientesDataGridView) 'EstilosDataGridView

        'Si no hay elementos, mostrar cartel
        If Me.ClientesBindingSource.Count = 0 Then
            lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
        End If
    End Sub



    '2) BOTONES DEL FORMULARIO
    '2.1) Boton de eliminar elemento
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.ClientesDataGridView.SelectedRows.Count > 0 Then ' Si hay al menos una fila seleccionada
            Dim selectedRow = Me.ClientesDataGridView.SelectedRows(0)
            Dim clientName As String = selectedRow.Cells(0).Value.ToString() ' Ajusta el índice de la columna si es necesario
            Dim result As DialogResult = MessageBox.Show("¿Desea eliminar el registro de '" & clientName & "'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    For x As Integer = Me.ClientesDataGridView.SelectedRows.Count - 1 To 0 Step -1
                        ' Eliminar el elemento seleccionado
                        Me.ClientesBindingSource.RemoveAt(Me.ClientesDataGridView.SelectedRows(x).Index)
                    Next

                    Me.ClientesBindingSource.EndEdit() ' Confirma los cambios

                    ' Guarda los cambios en la base de datos
                    Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)
                    If Me.ClientesBindingSource.Count = 0 Then
                        lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
                    End If
                    MsgBox("Eliminación exitosa")
                Catch ex As Exception
                    MsgBox("Ocurrió un error al intentar eliminar: " & ex.Message)
                End Try
            Else
                MsgBox("Eliminación cancelada")
            End If
        Else
            MsgBox("Seleccione, al menos, un elemento para borrar")
        End If
    End Sub
    '2.2) Boton de añadir elemento
    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        AltasClientes.ShowDialog()
    End Sub
    '2.3) Boton de editar elemento
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        'Seleccionar un elemento para editar
        If Me.ClientesDataGridView.SelectedRows.Count < 1 Then
            MsgBox("Seleccione un elemento para editar")
        Else
            modificar.ShowDialog()
        End If
    End Sub
    '2.4) Boton de mover al primer elemento
    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        'arriba de todo
        Me.ClientesBindingSource.MoveFirst()

    End Sub
    '2.5) Boton de mover al anterior elemento
    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        Me.ClientesBindingSource.MoveLast() 'abajo de todo

    End Sub
    '2.6) Boton de mover al siguiente elemento
    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        Me.ClientesBindingSource.MoveNext()
        'siguiente
    End Sub
    '2.7) Boton de mover al último elemento
    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Me.ClientesBindingSource.MovePrevious()
        'anterior
    End Sub





    '3) COMPORTAMIENTO DE BUSCAR ELEMENTO
    '3.1) Click en boton de buscar elemento
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text <> "" Then
            Me.ClientesBindingSource.Filter = "nombre LIKE '" & txtBuscar.Text & "%'"
            If Me.ClientesDataGridView.RowCount <= 0 Then
                lblTabla.Text = "Sin resultados compatibles" : lblTabla.Visible = True
            Else
                lblTabla.Visible = False
            End If
        End If
    End Sub
    '3.2) Click en el fondo del campo buscar
    Private Sub pbTxtBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTxtBuscar.Click
        txtBuscar.Focus() 'Simular unidad
    End Sub
    '3.3) Evento KeyPress en el campo de buscar
    Private Sub txtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If AscW(e.KeyChar) = 13 Then
            btnBuscar.PerformClick() 'Simular CLICK en el botón
            e.Handled = True
        End If
    End Sub
    '3.2) Evento TextChanged en el campo buscar
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        'Borrar busqueda si el campo esta vacío
        If txtBuscar.Text = "" Then
            Me.ClientesBindingSource.RemoveFilter()
            If Me.ClientesBindingSource.Count <= 0 Then
                lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
            Else
                lblTabla.Visible = False
            End If
        End If
    End Sub



    '4) COMPORTAMIENTO DE ORDENAR ELEMENTOS
    '4.1) Simular abrir lista desplegabl con botón
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        cbFiltrar.DroppedDown = True
    End Sub
    '4.2) Aplicar ordenamiento según elemento seleccionado en la lista 
    Private Sub cbFiltrar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFiltrar.SelectedIndexChanged
         Select cbFiltrar.SelectedIndex
            Case 0
                Me.ClientesBindingSource.Sort = "nombre ASC"
            Case 1
                Me.ClientesBindingSource.Sort = "apellido ASC"
        End Select
    End Sub
End Class