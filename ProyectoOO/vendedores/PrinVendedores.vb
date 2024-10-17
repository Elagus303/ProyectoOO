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
        EstilosDataGridView(Me.VendedoresDataGridView) 'EstilosDataGridView
        If Me.VendedoresBindingSource.Count = 0 Then
            lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
        End If

    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        Vendedores.ShowDialog()
        Vendedores.NombreTextBox.Focus()

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        cbFiltrar.DroppedDown = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.VendedoresDataGridView.SelectedRows.Count > 0 Then ' Si hay al menos una fila seleccionada
            Dim selectedRow = Me.VendedoresDataGridView.SelectedRows(0)
            Dim clientName As String = selectedRow.Cells(0).Value.ToString() ' Ajusta el índice de la columna si es necesario
            Dim result As DialogResult = MessageBox.Show("¿Desea eliminar el registro de '" & clientName & "'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    For x As Integer = Me.VendedoresDataGridView.SelectedRows.Count - 1 To 0 Step -1
                        ' Eliminar el elemento seleccionado
                        Me.VendedoresBindingSource.RemoveAt(Me.VendedoresDataGridView.SelectedRows(x).Index)
                    Next

                    Me.VendedoresBindingSource.EndEdit() ' Confirma los cambios

                    ' Guarda los cambios en la base de datos
                    Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)
                    If Me.VendedoresBindingSource.Count = 0 Then
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

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text <> "" Then
            Me.VendedoresBindingSource.Filter = "nombre LIKE '" & txtBuscar.Text & "%'"
            If Me.VendedoresDataGridView.RowCount <= 0 Then
                lblTabla.Text = "Sin resultados compatibles" : lblTabla.Visible = True
            Else
                lblTabla.Visible = False
            End If
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If Me.VendedoresDataGridView.SelectedRows.Count > 0 Then
            Editar.ShowDialog()
        Else
            MsgBox("seleccione un registro a editar")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.VendedoresBindingSource.MoveFirst()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.VendedoresBindingSource.MoveLast()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.VendedoresBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.VendedoresBindingSource.MovePrevious()

    End Sub

    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Simula el clic en el botón
            btnBuscar.PerformClick()
            ' Opcionalmente, puedes evitar que el sonido de "ding" suene al presionar Enter
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        
    End Sub




    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub
End Class