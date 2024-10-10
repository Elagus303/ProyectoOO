Public Class FormVentasAltas
    Private precio_unidad_final,
            precio_total,
            precio_anillado,
            precio_blanco_negro,
            precio_color,
            precio_faz_simple,
            precio_faz_doble As Integer

    Private Sub FormVentasAltas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores)

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
        Label1.Text = "Precio: $ " & precio_total
        Label2.Text = "Precio: $ " & precio_unidad_final
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
        Label1.Text = "Precio: $ " & precio_total
        Label2.Text = "Precio: $ " & precio_unidad_final
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
        Label1.Text = "Precio: $ " & precio_total
        Label2.Text = "Precio: $ " & precio_unidad_final
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
        Label1.Text = "Precio: $ " & precio_total
    End Sub
End Class