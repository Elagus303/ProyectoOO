Public Class FormProvAltas
    Private Sub FormProvAltas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ProveedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Proveedores) 'Cargar datos 
        Me.ProveedoresBindingSource.AddNew()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        Try
            If NombreTextBox.Text <> "" And
                CorreoTextBox.Text = "" And
                TelefonoTextBox.Text = "" Then
                MsgBox("Ingrese, por lo menos, algún teléfono o correo")
                Exit Sub
            End If
            If NombreTextBox.Text <> "" And
                TelefonoTextBox.Text <> "" And
                TelefonoTextBox.Text.Length < 10 Then
                MsgBox("Ingrese un telefono válido")
                Exit Sub
            End If
            If NombreTextBox.Text <> "" And
                CorreoTextBox.Text <> "" And
                Not CorreoTextBox.Text.Contains("@") Then
                MsgBox("Ingrese un correo válido")
                Exit Sub
            End If
            Me.ProveedoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(BD_ImprentaDataSet)
            Me.ProveedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Proveedores)
            FormProv.ProveedoresTableAdapter.Fill(FormProv.BD_ImprentaDataSet.Proveedores)
            Me.ProveedoresBindingSource.AddNew()

            MsgBox("Se añadió correctamente el proveedor")
        Catch ex As System.Data.NoNullAllowedException
            MsgBox("El campo 'Nombre' es obligatorio")
        Catch ex As System.ArgumentException
            MsgBox(ex.Message)
        End Try
        NombreTextBox.Focus()
    End Sub

    Private Sub TelefonoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefonoTextBox.KeyPress
        If SoloNumeros(e) Then
            e.Handled = True ' Cancelamos la tecla si no es válida
            System.Media.SystemSounds.Exclamation.Play()
        End If
    End Sub

    Private Sub LocalidadTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LocalidadTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Simula el clic en el botón
            btnAnadir.PerformClick()
            ' Opcionalmente, puedes evitar que el sonido de "ding" suene al presionar Enter
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LocalidadTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadTextBox.TextChanged

    End Sub
End Class