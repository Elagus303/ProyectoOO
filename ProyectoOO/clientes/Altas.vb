Public Class AltasClientes
    '1) FORMULARIO DE AGREGAR CLIENTES
    '1.1) Evento Load del formulario
    Private Sub altas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cargar datos de Clientes
        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes)
        'Añadir cliente nuevo
        Me.ClientesBindingSource.AddNew()
        'Focus en el primer campo
        Me.NombreTextBox.Focus()
    End Sub


    '2) BOTONES DEL FORMULARIO 
    '2.1) Botón de guardar nuevo registro
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'Impedir campos vacios
        If NombreTextBox.Text = "" Or ApellidoTextBox.Text = "" Or TelefonoTextBox.Text = "" Then
            MsgBox("No deje los campos vacios en NOMBRE, APELLIDO O TELEFONO ")
        Else
            Me.ClientesBindingSource.EndEdit() 'cierro la base
            Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'guardo
            Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes) 'actualizo la tabla de datos
            clientes.ClientesTableAdapter.Fill(clientes.BD_ImprentaDataSet.Clientes) 'actualizo la tabla clientes
            Me.ClientesBindingSource.AddNew()
            NombreTextBox.Focus()
            MsgBox("Se a guardado con exito")
        End If
    End Sub
    '2.2) Botón de cancelar nuevo registro
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        ' Cancelamos cualquier edición pendiente en el BindingSource
        If ClientesBindingSource.Current IsNot Nothing Then
            ClientesBindingSource.CancelEdit()
        End If
        'Cerrar el formulario
        Me.Close()
    End Sub


    '3) VALIDACIONES DE TEXTBOXS
    '3.1) Validaciones del campo texto
    Private Sub NombreTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTextBox.KeyPress
        e.KeyChar = ChrW(SoloLetras(e))
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Then         'al precionar enter(13) se enviara al siguiente textbox en este caso apellido
            ApellidoTextBox.Focus()
            e.Handled = True
        End If
    End Sub
    '3.2) Validaciones del campo apellido
    Private Sub ApellidoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidoTextBox.KeyPress
        e.KeyChar = ChrW(SoloLetras(e))
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Then         'al precionar enter(13) se enviara al siguiente textbox en este caso apellido
            TelefonoTextBox.Focus()
            e.Handled = True
        End If
    End Sub
    '3.3) Validaciones del campo teléfono
    Private Sub TelefonoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefonoTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            ' Si es Enter, movemos el foco al siguiente TextBox (en este caso, TextBox2)
            CorreoTextBox.Focus()
            ' Evitamos que se procese la tecla Enter en el TextBox1
            e.Handled = True
        Else
            ' Llamamos a la función para permitir solo números
            If SoloNumeros(e) Then
                e.Handled = True ' Cancelamos la tecla si no es válida
            End If
        End If
    End Sub
    '3.4) Campo correo electrónico
    Private Sub CorreoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CorreoTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            DireccionTextBox.Focus()
        End If
    End Sub
    '3.5) Campo de dirección
    Private Sub DireccionTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DireccionTextBox.KeyPress
        If e.KeyChar = Chr(13) Then

        Else
            If LetrasNumeros(e) Then
                e.Handled = True ' Cancelamos la tecla si no es válida
            End If
        End If
    End Sub

    Private Sub NombreTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreTextBox.TextChanged

    End Sub
End Class