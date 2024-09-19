Public Class Clientes

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes)
        NombreTextBox.Focus()
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ClientesBindingSource.EndEdit() 'cierro la base
        Me.TableAdapterManager.UpdateAll(Me.BD_ImprentaDataSet) 'guardo

        Me.ClientesTableAdapter.Fill(Me.BD_ImprentaDataSet.Clientes) 'actualizo la tabla de datos

        Me.ClientesBindingSource.AddNew()
        NombreTextBox.Focus()
        MsgBox("Se a guardado con exito")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ClientesBindingSource.AddNew()
        NombreTextBox.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila As Integer
        If TextBox1.Text <> "" And IsNumeric(TextBox1.Text) Then

            fila = Me.ClientesBindingSource.Find("id", TextBox1.Text)

            If fila <> -1 Then

                Me.ClientesBindingSource.Position = fila
                TextBox2.Text = Me.ClientesBindingSource.Current("id")
                TextBox3.Text = Me.ClientesBindingSource.Current("nombre")
                TextBox4.Text = Me.ClientesBindingSource.Current("Apellido")
                TextBox5.Text = Me.ClientesBindingSource.Current("telefono")
                TextBox6.Text = Me.ClientesBindingSource.Current("correo")
                TextBox7.Text = Me.ClientesBindingSource.Current("direccion")
            Else
                MsgBox("no se encontro")


            End If
        Else

        End If
    End Sub

    Private Sub ClientesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesDataGridView.CellContentClick

    End Sub
End Class
