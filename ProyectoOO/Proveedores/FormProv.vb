Public Class FormProv

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub


    Private Sub ProveedoresBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub

    Private Sub FormProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Proveedores)
        'EstilosDataGridView
        ProveedoresDataGridView.BackgroundColor = ColorBase
        ProveedoresDataGridView.BorderStyle = BorderStyle.None
        ProveedoresDataGridView.RowHeadersVisible = False
        ProveedoresDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ProveedoresDataGridView.AllowUserToResizeColumns = False
        ProveedoresDataGridView.AllowUserToResizeRows = False
        ProveedoresDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ProveedoresDataGridView.EnableHeadersVisualStyles = False
        ProveedoresDataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorSobreBase
        ProveedoresDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        ProveedoresDataGridView.RowsDefaultCellStyle.BackColor = ColorBase
        ProveedoresDataGridView.RowsDefaultCellStyle.SelectionBackColor = ColorControl
        ProveedoresDataGridView.RowsDefaultCellStyle.SelectionForeColor = ColorTextoPrimario
        ProveedoresDataGridView.GridColor = ColorSobreBase
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        FormProvAltas.ShowDialog()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ProveedoresBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ProveedoresBindingSource.MovePrevious()
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ProveedoresBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ProveedoresBindingSource.MoveLast()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If Me.ProveedoresDataGridView.SelectedRows.Count < 1 Then
            MsgBox("Seleccione un elemento para editar")
        ElseIf Me.ProveedoresDataGridView.SelectedRows.Count > 1 Then
            MsgBox("Seleccione solo un elemento para editar")
        Else
            FormProvEdicion.ShowDialog()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.ProveedoresDataGridView.SelectedRows.Count > 0 Then 'Si hay por lo menos una fila seleccionada
            Dim x As Integer
            For x = Me.ProveedoresDataGridView.SelectedRows.Count - 1 To 0 Step -1
                '1) Obtener la lista de elementos seleccionados
                '2) Apuntar al ultimo elemento de esa lista
                '3) Obtener el indice de ese elemento y eliminar
                Me.ProveedoresBindingSource.RemoveAt(Me.ProveedoresDataGridView.SelectedRows(x).Index)
            Next
            Me.ProveedoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'Confirmar cambios en el DataSet
            MsgBox("Eliminación exitosa")
        Else
            MsgBox("Seleccione, al menos, un elemento para borrar")
        End If
    End Sub

    Private Sub pbTxtBuscar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbTxtBuscar.MouseMove
        pbTxtBuscar.Cursor = Cursors.IBeam
    End Sub

    Private Sub pbTxtBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTxtBuscar.Click
        txtBuscar.Focus()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text <> "" Then
            BuscarPorTexto()
            If Me.ProveedoresDataGridView.RowCount <= 0 Then
                lblTabla.Visible = True
            Else
                lblTabla.Visible = False
            End If
        End If
    End Sub
    Private dv As New DataView
    Private Sub BuscarPorTexto()
        'dv.Table = Me.BD_ImprentaDataSet.Proveedores
        'dv.RowFilter = "nombre LIKE '" & txtBuscar.Text & "%'"
        'dv.Sort = "nombre ASC"
        '' Asignar el DataView al DataGridView del FormPpal
        'Me.ProveedoresDataGridView.DataSource = dv
        Me.ProveedoresBindingSource.Filter = "nombre LIKE '" & txtBuscar.Text & "%'"
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            'dv.RowFilter = ""
            Me.ProveedoresBindingSource.RemoveFilter()
            lblTabla.Visible = False
        End If
    End Sub

    Private Sub ProveedoresDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresDataGridView.SelectionChanged
        If Me.ProveedoresDataGridView.SelectedRows.Count > 1 Then
            btnEditar.Visible = False
        Else
            btnEditar.Visible = True
        End If
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        cbFiltrar.DroppedDown = True
    End Sub

    Private Sub btnPrimero_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click

    End Sub
End Class