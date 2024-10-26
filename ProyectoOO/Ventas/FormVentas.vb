Public Class FormVentas
    '1) FORMULARIO VENTAS
    '1.1) Load del formulario ventas
    Private Sub FormVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores)
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes)
        Me.VentaTableAdapter.Fill(Me.BD_ImprentaDataSet.Venta) 'Llenar datos en DataGridView
        EstilosDataGridView(Me.TablaVentas) 'Estilizar DataGridView


        LlenarTablaVentas()
    End Sub
    '1.2) Función para llenar la tabla compuesta de Ventas
    Public Sub LlenarTablaVentas()
        Dim fila As Integer = 0 'Valor de fila
        Dim x As Integer = 0 'Contador para usar en el bucle
        Dim totVentas As Long = 0
        Me.VentaBindingSource.MoveFirst() 'Mover al primer elemento
        Me.TablaVentas.Rows.Clear() 'Eliminar todas las filas
        If Me.VentaBindingSource.Count >= 1 Then
            lblTabla.Visible = False 'Si hay min un elemento ocultar cartel
            Do
                Me.TablaVentas.Rows.Add()
                Me.TablaVentas.Item(0, fila).Value = Me.VentaBindingSource.Current("id")
                Me.TablaVentas.Item(1, fila).Value = Me.VentaBindingSource.Current("fecha_venta")



                If Me.VentaBindingSource.Current("id_vendedor") <> 0 Then
                    Me.VendedoresBindingSource.Position = Me.VendedoresBindingSource.Find("id", Me.VentaBindingSource.Current("id_vendedor"))
                    Me.TablaVentas.Item(2, fila).Value = Me.VendedoresBindingSource.Current("nombre")
                Else
                    Me.TablaVentas.Item(2, fila).Value = "Agustin"
                End If


                Me.ClientesBindingSource.Position = Me.ClientesBindingSource.Find("id", Me.VentaBindingSource.Current("id_cliente"))
                Me.TablaVentas.Item(3, fila).Value = Me.ClientesBindingSource.Current("nombre") & " " & Me.ClientesBindingSource.Current("apellido")

                Me.TablaVentas.Item(4, fila).Value = Me.VentaBindingSource.Current("cantidad")
                Me.TablaVentas.Item(5, fila).Value = "$ " & Me.VentaBindingSource.Current("precio_venta")

                totVentas += Val(Me.VentaBindingSource.Current("precio_venta"))
                fila += 1 'Para seguir a llenar la siguiente fila
                x += 1 'Incrementar el contador del bucle
                Me.VentaBindingSource.MoveNext() 'Necesario para seguir avanzando en el llenado
            Loop Until x = Me.VentaBindingSource.Count

            Me.TablaVentas.Rows.Add()
            Me.TablaVentas.Item(4, fila).Value = "TOTAL:"
            Me.TablaVentas.Item(5, fila).Value = "$" & totVentas
        Else
            lblTabla.Text = "No hay registros cargados" : lblTabla.Visible = True
        End If
    End Sub

    '2) BOTONES DEL FORMULARIO
    '2.1) Evento click en btn agregar
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        FormVentasAltas.ShowDialog()
    End Sub
    '2.2) Evento click en btn eliminar
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
<<<<<<< HEAD
        If Me.TablaVentas.SelectedRows.Count > 0 Then 'Si hay por lo menos una fila seleccionada
            Dim resultado As DialogResult = MessageBox.Show("¿Desea eliminar " & Me.TablaVentas.SelectedRows.Count.ToString & " registro/s?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = Windows.Forms.DialogResult.Yes Then
                Dim x As Integer 'Contador para bucle

                For x = Me.TablaVentas.SelectedRows.Count - 1 To 0 Step -1 'Indiced del último al primero (0)
                    Me.VentaBindingSource.Position = Me.VentaBindingSource.Find("id", Me.TablaVentas.SelectedRows(x).Cells("id_venta").Value)
                    Me.VentaBindingSource.RemoveAt(Me.VentaBindingSource.Position)
                Next
                Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'Confirmar cambios en el DataSet
                LlenarTablaVentas()
                MsgBox("Eliminación exitosa")
=======
        If usuarioEsAdminx Then
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
>>>>>>> bbd23672514508db511e48a767a0656eb3d9db73
            End If
        Else
            MsgBox("acceso denegado, solo los administradores pueden usar esta funcion")
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
        Me.TablaVentas.CurrentCell = Me.TablaVentas.Rows(0).Cells(0) 'Mover a la primera fila
    End Sub
    '2.5) Evento click en btn mover al anterior elemento
    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        If Me.TablaVentas.CurrentRow.Index > 0 Then
            'Mover a la anterior fila
            Me.TablaVentas.CurrentCell = Me.TablaVentas.Rows(Me.TablaVentas.CurrentRow.Index - 1).Cells(0)
        End If
    End Sub
    '2.6) Evento click en btn mover al siguiente elemento
    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        If Me.TablaVentas.CurrentRow.Index < Me.TablaVentas.Rows.Count - 1 Then
            'Mover a la siguiente fila
            Me.TablaVentas.CurrentCell = Me.TablaVentas.Rows(Me.TablaVentas.CurrentRow.Index + 1).Cells(0)
        End If
    End Sub
    '2.7) Evento click en btn mover al ultimo elemento
    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Me.TablaVentas.CurrentCell = Me.TablaVentas.Rows(Me.TablaVentas.Rows.Count - 1).Cells(0) 'Mover a la ultima fila
    End Sub



    '3) COMPORTAMIENTO ORDENAR DATAGRIDVIEW
    '3.1) Evento click en btn ordenar (Mascara)
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenar.Click
        cbFiltrar.DroppedDown = True 'Desplegar lista
    End Sub
    '3.2) Ordenamiento según la selección del elemento
    Private Sub cbFiltrar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFiltrar.SelectedIndexChanged
        Select Case cbFiltrar.SelectedIndex
            Case 0
                Me.VentaBindingSource.Sort = "fecha_venta DESC"
            Case 1
                Me.VentaBindingSource.Sort = "id_vendedor ASC, fecha_venta DESC"
            Case 2
                Me.VentaBindingSource.Sort = "precio_venta DESC, fecha_venta DESC"
        End Select
    End Sub




    '4)COMPORTAMIENTO DE FILTRADO POR FECHAS
    '4.1) Evento Click en el boton de buscar
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'Parametros de fecha inicial y final
        Dim fechaInicio As String = dTimePickerInicio.Value.ToString("yyyy-MM-dd")
        Dim fechaFinal As String = dTimePickerFinal.Value.AddDays(1).ToString("yyyy-MM-dd") 'Para incluir el último día

        Me.VentaBindingSource.Filter = "fecha_venta >= #" & fechaInicio & "# AND fecha_venta < #" & fechaFinal & "#" 'Sacar el <= por el <, por el cambio anterior
        Me.btnRemoverFiltro.Visible = True
    End Sub
    '4.2) Evento Click en quitar filtro
    Private Sub RemoverFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoverFiltro.Click
        Me.VentaBindingSource.RemoveFilter() 'Quitar filtro de busqueda de ventas por fechas
        Me.btnRemoverFiltro.Visible = False
    End Sub




    ''5) VENTAS BINDING SOURCE
    ''5.1) Evento cuando cambia el binding source
    'Private Sub VentaBindingSource_ListChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles VentaBindingSource.ListChanged
    '    'Condicional para detectar que se agregó y que no se eliminó o editó
    '    If e.ListChangedType = System.ComponentModel.ListChangedType.ItemAdded Then
    '        LlenarTablaVentas() 'Volver a llenar los datos en la tabla
    '        MsgBox(1)
    '    End If
    'End Sub
End Class