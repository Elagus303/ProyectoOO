Public Class altas

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

       
    End Sub

    Private Sub altas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Roles' Puede moverla o quitarla según sea necesario.
        Me.RolesTableAdapter.Fill(Me.BD_ImprentaDataSet.Roles)
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ClientesBindingSource.AddNew()
        NombreTextBox.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If NombreTextBox.Text = "" Or ApellidoTextBox.Text = "" Or TelefonoTextBox.Text = "" Then
            MsgBox("No deje los campos vacios en NOMBRE, APELLIDO O TELEFONO ")

        Else
            Me.ClientesBindingSource.EndEdit() 'cierro la base

            Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'guardo

            Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes) 'actualizo la tabla de datos

            'sos agustin?
            'cambios en minrama1
            Me.ClientesBindingSource.AddNew()
            NombreTextBox.Focus()
            MsgBox("Se a guardado con exito")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        

        ' Cancelamos cualquier edición pendiente en el BindingSource
        If ClientesBindingSource.Current IsNot Nothing Then
            ClientesBindingSource.CancelEdit()
        End If

        MessageBox.Show("El nuevo registro ha sido cancelado.")
    End Sub

    Private Sub NombreTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTextBox.KeyPress
        e.KeyChar = ChrW(SoloLetras(e))
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Then         'al precionar enter(13) se enviara al siguiente textbox en este caso apellido
            ApellidoTextBox.Focus()
            e.Handled = True
        End If
       
    End Sub

    Private Sub NombreTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreTextBox.TextChanged

    End Sub

    Private Sub ApellidoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidoTextBox.KeyPress
        e.KeyChar = ChrW(SoloLetras(e))
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Then         'al precionar enter(13) se enviara al siguiente textbox en este caso apellido
            TelefonoTextBox.Focus()
            e.Handled = True

        End If
    End Sub

    Private Sub ApellidoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApellidoTextBox.TextChanged

    End Sub

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

    Private Sub TelefonoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelefonoTextBox.TextChanged

    End Sub

    Private Sub CorreoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CorreoTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            DireccionTextBox.Focus()
        End If
    End Sub

    Private Sub CorreoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorreoTextBox.TextChanged

    End Sub

    Private Sub DireccionTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DireccionTextBox.KeyPress
        If e.KeyChar = Chr(13) Then

        Else
            If LetrasNumeros(e) Then
                e.Handled = True ' Cancelamos la tecla si no es válida
            End If
        End If
    End Sub

    Private Sub DireccionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DireccionTextBox.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        Dim codigodeconsulta As String
        codigodeconsulta = InputBox("ingrese codigo de articulo")
        i = 0
        Me.ClientesBindingSource.MoveFirst() 'HACE QUE EL PUNTERO EMPIEZE DESDE LA FILA 1

        If codigodeconsulta <> "" And IsNumeric(codigodeconsulta) Then
            Do

                If Me.ClientesBindingSource.Current("id") = codigodeconsulta Then
                    IdTextBox.Text = Me.ClientesBindingSource.Current("id")
                    NombreTextBox.Text = Me.ClientesBindingSource.Current("nombre")
                    ApellidoTextBox.Text = Me.ClientesBindingSource.Current("Apellido")
                    CorreoTextBox.Text = Me.ClientesBindingSource.Current("correo")
                    TelefonoTextBox.Text = Me.ClientesBindingSource.Current("telefono")
                    DireccionTextBox.Text = Me.ClientesBindingSource.Current("direccion")

                    Exit Sub

                End If
                i = 1 + i
                Me.ClientesBindingSource.MoveNext()
            Loop Until i = Me.ClientesBindingSource.Count

            MsgBox("NO SE ENCONTRO EL REGISTRO")

        Else
            MsgBox("el codigo ingresado no es valido")

            'do while --> repita hasta, que...
            'while -> repita mientras, que...
            'try catch buscar en google
        End If
    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ClientesBindingSource.MoveLast()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ClientesBindingSource.MoveFirst()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ClientesBindingSource.MovePrevious()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ClientesBindingSource.MoveNext()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class