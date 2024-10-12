Public Class Editar
    '1) FORMULARIO DE EDITAR DATOS DEL VENDEDOR
    '1.1) Evento Load del formulario
    Private Sub Editar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RolesTableAdapter.Fill(Me.BD_ImprentaDataSet.Roles) 'Cargar datos de Roles
        Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores) 'Cargar datos de Vendedores
        Me.VendedoresBindingSource.Position = PrinVendedores.VendedoresBindingSource.Position 'Sincronizar putero

        'ComboBox
        Dim idRol As Integer = Me.VendedoresBindingSource.Current("id_rol") 'Seleccionar el Id_Rol del Vendedor
        'Seleccionar elemento según idRol
        cBoxRoles.SelectedValue = idRol
    End Sub


    '2) BOTONES DEL FORMULARIO
    '2.1) Botón de Salir
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    '2.2) Botón de Guardar cambios
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'Impedir valores nulos...
        If NombreTextBox.Text <> "" And ContraseñaTextBox.Text <> "" Then
            Me.VendedoresBindingSource.Current("id_rol") = cBoxRoles.SelectedValue
            Me.VendedoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(BD_ImprentaDataSet)
            Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores)
            PrinVendedores.VendedoresTableAdapter.Fill(PrinVendedores.BD_ImprentaDataSet.Vendedores)
            MsgBox("Se guardaron los cambios")
        Else
            MsgBox("Los campos Nombre y Contraseña son obligatorios")
        End If
    End Sub
End Class