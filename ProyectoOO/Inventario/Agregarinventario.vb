﻿Public Class Agregarinventario

    Private Sub Canbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Canbutton.Click


        Me.Close()
    End Sub

    Private Sub Agregarinventario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.InsumoBindingSource.CancelEdit()
    End Sub

    Private Sub LOAD_FORMULARIO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Proveedores)
        Me.InsumoBindingSource.AddNew()
        comboBoxProvs.SelectedIndex = -1
        comboBoxProvs.Text = "Eliga proveedor"
    End Sub


    Private Sub Aceptbutton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptbutton.Click

        If prodtext.Text = "" And prectext.Text = "" And cantprec.Text = "" Then
            MsgBox("No deje campos vacíos.")
        ElseIf comboBoxProvs.SelectedIndex = -1 Then
            MsgBox("Por favor, seleccione un proveedor.")
        Else

        If prodtext.Text <> "" And prectext.Text <> "" And comboBoxProvs.SelectedIndex >= 0 Then

            Me.InsumoBindingSource.Current("id_proovedor") = comboBoxProvs.SelectedValue
            Me.InsumoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(BD_ImprentaDataSet)
            Inventario.InsumoTableAdapter.Fill(Inventario.BD_ImprentaDataSet.Insumo)
            Me.Close()
            MsgBox("se agrego con exito")
Else
            MsgBox("No deje campos vacios")
        End If


        End If
    End Sub
End Class