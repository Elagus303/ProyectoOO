Public Class clientes

    Private Sub clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes)
        EstilosDataGridView(Me.ClientesDataGridView) 'EstilosDataGridView

        If Me.ClientesBindingSource.Count = 0 Then
            lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
        End If

    End Sub
    
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

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click

        AltasClientes.Show()

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        cbFiltrar.DroppedDown = True

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

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

    Private Sub txtBuscar_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            Me.ClientesBindingSource.RemoveFilter()
            If Me.ClientesBindingSource.Count <= 0 Then
                lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
            Else
                lblTabla.Visible = False
            End If
        End If
    End Sub

    Private Sub cbFiltrar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFiltrar.SelectedIndexChanged
         Select cbFiltrar.SelectedIndex
            Case 0
                Me.ClientesBindingSource.Sort = "nombre ASC"
            Case 1
                Me.ClientesBindingSource.Sort = "apellido ASC"
        End Select
    End Sub

    Private Sub pbTxtBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTxtBuscar.Click
        txtBuscar.Focus()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        'Seleccionar un elemento para editar
        If Me.ClientesDataGridView.SelectedRows.Count < 1 Then
            MsgBox("Seleccione un elemento para editar")
        Else
            modificar.ShowDialog()
        End If
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        'arriba de todo
        Me.ClientesBindingSource.MoveFirst()

    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        Me.ClientesBindingSource.MoveLast() 'abajo de todo

    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        Me.ClientesBindingSource.MoveNext()
        'siguiente
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Me.ClientesBindingSource.MovePrevious()
        'anterior
    End Sub
End Class