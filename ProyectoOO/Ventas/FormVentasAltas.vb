Public Class FormVentasAltas
    Private precio_unidad_final,
            precio_total,
            precio_anillado,
            precio_blanco_negro,
            precio_color,
            precio_faz_simple,
            precio_faz_doble As Integer

    Private Sub FormVentasAltas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Insumo' Puede moverla o quitarla según sea necesario.
        Me.InsumoTableAdapter.Fill(Me.BD_ImprentaDataSet.Insumo)
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores)
        Me.InsumoBindingSource.Filter = "nombre LIKE '%hoj%'"
        cBoxHojas.SelectedIndex = -1 : ComboBox2.SelectedIndex = -1
        cBoxHojas.Text = "Seleccione una hoja"

        'Me.InsumosBindingSource1.Filter = "nombre LIKE '%anill%'"
        ComboBox2.Text = "Seleccione un anillado"
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.BD_ImprentaDataSet.Venta)
        Me.VentaBindingSource.AddNew()

        precio_anillado = 200
        precio_blanco_negro = 10
        precio_color = 20
        precio_faz_simple = 0
        precio_faz_doble = 10
        precio_unidad_final = 0

    End Sub


    Private Sub cBoxAnillado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBoxAnillado.CheckedChanged
        If cBoxAnillado.Checked Then
            precio_total += precio_anillado

        Else
            precio_total -= precio_anillado
        End If
        lblUnidad.Text = "Precio: $ " & precio_total
        ComboBox2.Enabled = cBoxAnillado.Checked
    End Sub

    Private Sub rBtnColor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBtnColor.CheckedChanged, rBtnBlancoNegro.CheckedChanged
        If rBtnBlancoNegro.Checked Then
            If rBtnDoble.Checked Then
                precio_unidad_final = precio_blanco_negro + precio_faz_doble
            ElseIf rBtnSimple.Checked Then
                precio_unidad_final = precio_blanco_negro + precio_faz_simple
            Else
                precio_unidad_final = precio_blanco_negro
            End If
        ElseIf rBtnColor.Checked Then
            If rBtnDoble.Checked Then
                precio_unidad_final = precio_color + precio_faz_doble
            ElseIf rBtnSimple.Checked Then
                precio_unidad_final = precio_color + precio_faz_simple
            Else
                precio_unidad_final = precio_color
            End If
        End If
        lblUnidad.Text = "Precio: $ " & precio_total
    End Sub

    Private Sub rBtnSimple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBtnSimple.CheckedChanged, rBtnDoble.CheckedChanged
        If rBtnDoble.Checked Then
            If rBtnColor.Checked Then
                precio_unidad_final = precio_color + precio_faz_doble
            ElseIf rBtnBlancoNegro.Checked Then
                precio_unidad_final = precio_blanco_negro + precio_faz_doble
            Else
                precio_unidad_final = precio_faz_doble
            End If
        ElseIf rBtnSimple.Checked Then
            If rBtnDoble.Checked Then
                precio_unidad_final = precio_color + precio_faz_simple
            ElseIf rBtnSimple.Checked Then
                precio_unidad_final = precio_color + precio_faz_simple
            Else
                precio_unidad_final = 0
            End If
        End If
        lblUnidad.Text = "Precio: $ " & precio_total

    End Sub

    Private Sub CantidadTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CantidadTextBox.TextChanged
        If CantidadTextBox.Text = "" Then
            If cBoxAnillado.Checked Then
                precio_total = precio_anillado
            Else
                precio_total = 0
            End If
        Else
            precio_total += Val(CantidadTextBox.Text) * precio_unidad_final
        End If
        lblUnidad.Text = "Precio: $ " & precio_total
    End Sub
    'Evento que se ejecuta cuando se abre el ComboBox
    Private Sub ComboBox1_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBoxHojas.DropDown

    End Sub

    Private Sub ComboBox2_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.DropDown

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'If cBoxAnillado.Checked Then
        '    If cBoxHojas.SelectedIndex <> -1 And ComboBox2.SelectedIndex <> -1 Then
        anadirNuevaVenta()
        '    Else
        '        MsgBox("Seleccione elementos ..")
        '    End If
        'Else
        '    If cBoxHojas.SelectedIndex <> -1 Then
        '        anadirNuevaVenta()
        '    Else
        '        MsgBox("Seleccione elementos ..")
        '    End If
        'End If

    End Sub




    Private Sub anadirNuevaVenta()
        Dim cant As Integer = Val(CantidadTextBox.Text)
        Me.VentaBindingSource.Current("fecha_venta") = DateTime.Now
        Me.VentaBindingSource.Current("precio_venta") = precio_total
        Me.VentaBindingSource.Current("id_vendedor") = Id_Global_Vendedor
        Me.VentaBindingSource.Current("id_cliente") = cBoxClientes.SelectedValue
        Me.VentaBindingSource.EndEdit() '-------- Terminar edicion de Ventas ------------





        Dim x As Integer = Me.InsumoBindingSource.Find("id", cBoxHojas.SelectedValue)
        Me.InsumoBindingSource.Position = x
        'MsgBox(Me.InsumoBindingSource.Current("stock") - cant)
        'MsgBox(x)
        Me.InsumoBindingSource.Current("stock") -= cant
        'InsumoBindingSource.Current("nombre") = "hoj"
        Me.InsumoBindingSource.EndEdit() '-------- Terminar edicion del Stock ------------



        Me.InsumoTableAdapter.Update(BD_ImprentaDataSet.Insumo)
        Me.TableAdapterManager.UpdateAll(BD_ImprentaDataSet)
        Me.InsumoTableAdapter.Fill(Me.BD_ImprentaDataSet.Insumo)
        Inventario.InsumoTableAdapter.Fill(Inventario.BD_ImprentaDataSet.Insumo)
        Me.VentaTableAdapter.Fill(Me.BD_ImprentaDataSet.Venta)
        FormVentas.VentaTableAdapter.Fill(FormVentas.BD_ImprentaDataSet.Venta)

        FormVentas.LlenarTablaVentas() 'Volver a llenar los datos en la tabla



        Me.VentaBindingSource.AddNew()
        rBtnBlancoNegro.Checked = False
        rBtnColor.Checked = False
        rBtnSimple.Checked = False
        rBtnDoble.Checked = False
    End Sub
End Class

