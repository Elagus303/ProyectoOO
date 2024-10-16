Public Class PrinVendedores

    Private Sub VendedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VendedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)
        EstilosDataGridView(Me.VendedoresDataGridView) 'EstilosDataGridView

        If Me.VendedoresBindingSource.Count = 0 Then
            lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
        End If
    End Sub

    Private Sub PrinVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores)

    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        Vendedores.Show()

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        cbFiltrar.DroppedDown = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
       
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.VendedoresDataGridView.SelectedRows.Count > 0 Then 'Si hay por lo menos una fila seleccionada
            Dim selectedRow = Me.VendedoresDataGridView.SelectedRows(0)
            Dim clientName As String = selectedRow.Cells(0).Value.ToString() ' Ajusta el índice de la columna si es necesario
            Dim result As DialogResult = MessageBox.Show("¿Desea eliminar el registro de '" & clientName & "'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim x As Integer
                For x = Me.VendedoresDataGridView.SelectedRows.Count - 1 To 0 Step -1
                    ' Eliminar el elemento seleccionado
                    Me.VendedoresBindingSource.RemoveAt(Me.VendedoresDataGridView.SelectedRows(x).Index)
                Next
                Me.VendedoresBindingSource.EndEdit()

                MsgBox("Eliminación exitosa")
            Else
                ' El usuario eligió "No", no se realiza ninguna acción
                MsgBox("Eliminación cancelada")
            End If
        Else
            MsgBox("Seleccione, al menos, un elemento para borrar")
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If TextBox1.Text <> "" Then
            Me.VendedoresBindingSource.Filter = "nombre LIKE '" & TextBox1.Text & "%'"
            If Me.VendedoresDataGridView.RowCount <= 0 Then
                lblTabla.Text = "Sin resultados compatibles" : lblTabla.Visible = True
            Else
                lblTabla.Visible = False
            End If
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Editar.ShowDialog()
    End Sub
End Class