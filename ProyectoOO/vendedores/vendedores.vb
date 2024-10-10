Public Class Vendedores

    Private Sub VendedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VendedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub

    Private Sub Vendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Roles' Puede moverla o quitarla según sea necesario.
        Me.RolesTableAdapter.Fill(Me.BD_ImprentaDataSet.Roles)
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores)
        Me.VendedoresBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Me.VendedoresBindingSource.AddNew()
        NombreTextBox.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If NombreTextBox.Text = "" Or ContraseñaTextBox.Text = "" Then
            MsgBox("No deje los campos vacios en NOMBRE")

        Else
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
End Class