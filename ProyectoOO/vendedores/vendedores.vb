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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.VendedoresBindingSource.Current("id_rol") = ComboBox1.SelectedValue
        Me.VendedoresBindingSource.AddNew()
        NombreTextBox.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If NombreTextBox.Text = "" Or ContraseñaTextBox.Text = "" Then
            MsgBox("No deje los campos vacios en NOMBRE")

        Else
            Me.VendedoresBindingSource.EndEdit() 'cierro la base
            Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'guardo

            Me.VendedoresTableAdapter.Fill(BD_ImprentaDataSet.Vendedores) 'actualizo la tabla de datos
            'sos agustin?
            'cambios en minrama1
            Me.VendedoresBindingSource.AddNew()
            NombreTextBox.Focus()
            MsgBox("Se a guardado con exito")
        End If
    End Sub
End Class