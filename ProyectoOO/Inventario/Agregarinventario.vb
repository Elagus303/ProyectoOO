Public Class Agregarinventario

    Private Sub Canbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Canbutton.Click
        Me.Close()

    End Sub

    Private Sub Aceptbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Proveedores)
        Me.InsumoBindingSource.AddNew()

<<<<<<< HEAD
=======
        comboBoxProvs.Text = "Eliga proveedor"
        comboBoxProvs.SelectedIndex = -1
>>>>>>> 0181cd6b0704dd72cdd2a9ecc846eee1f05629ff
    End Sub

    Private Sub InsumoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Aceptbutton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptbutton.Click
<<<<<<< HEAD
        If prodtext.Text = "" And prectext.Text = "" And cantprec.Text = "" Then
            MsgBox("No deje campos vacíos.")
        ElseIf comboBoxProvs.SelectedIndex = -1 Then
            MsgBox("Por favor, seleccione un proveedor.")
        Else
=======
        If prodtext.Text <> "" And prectext.Text <> "" And comboBoxProvs.SelectedIndex >= 0 Then
>>>>>>> 0181cd6b0704dd72cdd2a9ecc846eee1f05629ff
            Me.InsumoBindingSource.Current("id_proovedor") = comboBoxProvs.SelectedValue
            Me.InsumoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(BD_ImprentaDataSet)
            Inventario.InsumoTableAdapter.Fill(Inventario.BD_ImprentaDataSet.Insumo)
            Me.Close()
<<<<<<< HEAD
            MsgBox("se agrego con exito")
        End If

=======
        Else
            MsgBox("No deje campos vacios")
        End If
>>>>>>> 0181cd6b0704dd72cdd2a9ecc846eee1f05629ff
    End Sub
End Class