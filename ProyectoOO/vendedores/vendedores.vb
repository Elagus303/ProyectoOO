Public Class Vendedores

    Private Sub VendedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VendedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub

    Private Sub Vendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NombreTextBox.Focus()
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Roles' Puede moverla o quitarla según sea necesario.
        Me.RolesTableAdapter.Fill(Me.BD_ImprentaDataSet.Roles)
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores)
        Me.VendedoresBindingSource.AddNew()




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Me.VendedoresBindingSource.AddNew()
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If NombreTextBox.Text = "" Or ContraseñaTextBox.Text = "" Then
            MsgBox("No deje los campos vacios en NOMBRE y contraseña")

        Else
            If TextBox1.Text = ContraseñaTextBox.Text Then
                Me.VendedoresBindingSource.Current("id_rol") = ComboBox1.SelectedValue
                Me.VendedoresBindingSource.EndEdit() 'cierro la base
                Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'guardo

                Me.VendedoresTableAdapter.Fill(BD_ImprentaDataSet.Vendedores) 'actualizo la tabla de datos
                PrinVendedores.VendedoresTableAdapter.Fill(PrinVendedores.BD_ImprentaDataSet.Vendedores)

                'sos agustin?
                'cambios en minrama1
                Me.VendedoresBindingSource.AddNew()
                NombreTextBox.Focus()
                MsgBox("Se a guardado con exito")

            Else
                MsgBox("las contraseñas no son iguales")
            End If
           
        End If
    End Sub



    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ' Cancelamos cualquier edición pendiente en el BindingSource
        If VendedoresBindingSource.Current IsNot Nothing Then
            VendedoresBindingSource.CancelEdit()
        End If

        MessageBox.Show("El nuevo registro ha sido cancelado.")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub NombreTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


        If e.KeyChar = Chr(13) Then
            ContraseñaTextBox.Focus()
        End If
        ' Si es Enter, movemos el foco al siguiente TextBox (en este caso, TextBox2)
        ' Evitamos que se procese la tecla Enter en el TextBox1
        e.Handled = True
    End Sub

    Private Sub NombreTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ContraseñaTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContraseñaTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox1.Focus()

        End If
    End Sub

    Private Sub ContraseñaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContraseñaTextBox.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            ComboBox1.DroppedDown = True


        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub NombreTextBox_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTextBox.KeyPress
       
    End Sub

    Private Sub NombreTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreTextBox.TextChanged

    End Sub
End Class