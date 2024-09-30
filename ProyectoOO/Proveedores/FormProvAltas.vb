Public Class FormProvAltas

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub

    Private Sub FormProvAltas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Proveedores)
        Me.ProveedoresBindingSource.AddNew()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If NombreTextBox.Text <> "" And CorreoTextBox.Text = "" And TelefonoTextBox.Text = "" Then
            MsgBox("Ingrese, por lo menos algún teléfono o correo")
            Exit Sub
        End If
        Try
            Me.ProveedoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(BD_ImprentaDataSet)
            Me.ProveedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Proveedores)
            FormProv.ProveedoresTableAdapter.Fill(FormProv.BD_ImprentaDataSet.Proveedores)

            MsgBox("Se añadió correctamente el proveedor")
            Me.ProveedoresBindingSource.AddNew()
        Catch ex As System.Data.NoNullAllowedException
            MsgBox("El campo 'Nombre' es obligatorio")
        End Try

    End Sub
End Class