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
        NombreTextBox.Focus()

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
            If TextBox1.Text = ContraseñaTextBox.Text Then

                Me.VendedoresBindingSource.Current("id_rol") = cBoxRoles.SelectedValue
                Me.VendedoresBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(BD_ImprentaDataSet)
                Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores)
                PrinVendedores.VendedoresTableAdapter.Fill(PrinVendedores.BD_ImprentaDataSet.Vendedores)
                MsgBox("Se guardaron los cambios")
            Else
                MsgBox("las contraseñas no son iguales")
            End If
           
        Else
            MsgBox("Los campos Nombre y Contraseña son obligatorios")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = Chr(13) Then
            cBoxRoles.DroppedDown = True


        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub NombreTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTextBox.KeyPress
        e.KeyChar = ChrW(SoloLetras(e))
        If e.KeyChar = Chr(13) Then
            ContraseñaTextBox.Focus()

        End If
        ' Si es Enter, movemos el foco al siguiente TextBox (en este caso, TextBox2)

        ' Evitamos que se procese la tecla Enter en el TextBox1
        e.Handled = True
    End Sub

    Private Sub NombreTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreTextBox.TextChanged

    End Sub

    Private Sub ContraseñaTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContraseñaTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox1.Focus()

        End If
    End Sub

    Private Sub ContraseñaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContraseñaTextBox.TextChanged

    End Sub
End Class