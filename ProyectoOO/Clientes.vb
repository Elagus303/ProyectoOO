Public Class Clientes

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.BD_ImprentaDataSet.Venta)

        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes)


    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.ClientesBindingSource.MovePrevious()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.ClientesBindingSource.MoveFirst()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.ClientesBindingSource.MoveNext()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.ClientesBindingSource.MoveLast()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If NombreTextBox.Text = "" Or ApellidoTextBox.Text = "" Or TelefonoTextBox.Text = "" Then
            MsgBox("No deje los campos vacios en NOMBRE, APELLIDO O TELEFONO ")

        Else
            Me.ClientesBindingSource.EndEdit() 'cierro la base
            Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'guardo

            Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes) 'actualizo la tabla de datos

            Me.ClientesBindingSource.AddNew()
            NombreTextBox.Focus()
            MsgBox("Se a guardado con exito")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ClientesBindingSource.AddNew()
        NombreTextBox.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila As Integer

        ' Verificamos si el TextBox1 no está vacío y si el valor ingresado es numérico
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso IsNumeric(TextBox1.Text) Then

            ' Buscamos el registro por 'id'
            fila = Me.ClientesBindingSource.Find("id", CInt(TextBox1.Text))

            ' Si el registro se encuentra (Find retorna -1 si no encuentra nada)
            If fila <> -1 Then
                ' Establecemos la posición del BindingSource en la fila encontrada
                Me.ClientesBindingSource.Position = fila

                ' Llenamos los TextBox con los datos del registro actual

            Else
                ' Si no se encuentra el registro
                MsgBox("No se encontró ningún cliente con ese ID.")
            End If
        Else
            ' Validación si no se ingresa un valor válido
            MsgBox("Por favor ingrese un ID numérico válido.")
        End If
    End Sub

    Private Sub ClientesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

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

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ClientesBindingSource.EndEdit() 'cierro la base
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'guardo

        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes) 'actualizo la tabla de datos

    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


        ' Cancelamos cualquier edición pendiente en el BindingSource
        If ClientesBindingSource.Current IsNot Nothing Then
            ClientesBindingSource.CancelEdit()
        End If

        MessageBox.Show("El nuevo registro ha sido cancelado.")
    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Dim nombreBuscado As String = TextBox1.Text.Trim()

        ' Verificamos que el nombre no esté vacío
        If nombreBuscado <> "" Then

            ' Buscamos la fila en el BindingSource
            For i As Integer = 0 To Me.ClientesBindingSource.Count - 1
                Dim fila As DataRowView = CType(Me.ClientesBindingSource(i), DataRowView)

                ' Comparamos el nombre
                If fila("nombre").ToString().ToLower() = nombreBuscado.ToLower() Then
                    ' Si se encuentra coincidencia, movemos la posición
                    Me.ClientesBindingSource.Position = i

                    ' Llenamos los TextBox con los datos del registro encontrado


                    Exit Sub
                End If
            Next

            ' Si no se encontró el nombre
            MsgBox("No se encontró el cliente con ese nombre.")
        Else
            MsgBox("Por favor ingresa un nombre.")
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        altas.Show()



    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
       
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class