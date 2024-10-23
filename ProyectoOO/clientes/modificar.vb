Public Class modificar
    '1) FORMULARIO DE MODIFICAR CLIENTE
    '1.1) Evento Load del formulario
    Private Sub modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes) 'Cargar datos
    End Sub
    '1.2) Devolver el Foco al primer campo
    Private Sub modificar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NombreTextBox.Focus()
    End Sub


    '2) BOTONES DEL FORMULARIO
    '2.1) Botón de guardar cambios
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If NombreTextBox.Text = "" Or ApellidoTextBox.Text = "" Or TelefonoTextBox.Text = "" Then
            MsgBox("No deje los campos vacios en NOMBRE, APELLIDO O TELÉFONO ")
        Else
            Me.ClientesBindingSource.EndEdit() 'cierro la base
            Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'guardo

            Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes) 'actualizo la tabla de datos
            clientes.ClientesTableAdapter.Fill(clientes.BD_ImprentaDataSet.Clientes)
            MsgBox("Se a modificado con exito")
        End If
    End Sub
    '2.2) Botón de salir 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub




    '3) VALIDACIONES DE LOS TEXTBOXs
    '3.1) Validación del Nombre
    Private Sub NombreTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTextBox.KeyPress
        e.KeyChar = ChrW(SoloLetras(e)) 'Permitido solo letras
        If e.KeyChar = Chr(13) Then
            ApellidoTextBox.Focus()
            e.Handled = True
        End If
    End Sub
    '3.2) Validación del Apellido
    Private Sub ApellidoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidoTextBox.KeyPress
        e.KeyChar = ChrW(SoloLetras(e)) 'Permitido solo letras
        If e.KeyChar = Chr(13) Then
            TelefonoTextBox.Focus()
            e.Handled = True
        End If
    End Sub
    '3.3) Validación del Teléfono
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
    '3.4) Validación del Correo
    Private Sub CorreoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CorreoTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            DireccionTextBox.Focus()
        End If
    End Sub
    '3.5) Validación de la Dirección
    Private Sub DireccionTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DireccionTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Simula el clic en el botón
            btnGuardar.PerformClick()
            ' Opcionalmente, puedes evitar que el sonido de "ding" suene al presionar Enter
            e.SuppressKeyPress = True
        End If
    End Sub
End Class