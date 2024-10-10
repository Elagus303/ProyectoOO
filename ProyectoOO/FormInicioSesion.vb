Public Class FormInicioSesion
    '1)FORMULARIO DE INICIO DE SESIÓN
    '1.a) Evento Load
    Private Sub FormInicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores)
        'TODO: esta línea de código carga datos en la tabla 'BD_ImprentaDataSet.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.BD_ImprentaDataSet.Vendedores)
        Me.Left = (System.Windows.Forms.Screen.GetBounds(Me).Width - Me.Width) / 2
        Me.Top = (System.Windows.Forms.Screen.GetBounds(Me).Height - Me.Height) / 2
    End Sub
    '1.b) Evento KeyDown: Pulsar la tecla ENTER
    Private Sub FormInicioSesion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnIngresar_Click()
        End If
    End Sub


    '2) CAMPO NOMBRE 
    Private Sub pbTxtNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTxtNombre.Click
        txtNombre.Focus()
    End Sub


    '3) CAMPO CONTRASEÑA
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTxtContrasena.Click
        txtContraseña.Focus()
    End Sub


    '4) BOTÓN DE INGRESAR A LA APLICACIÓN 
    Private Sub btnIngresar_Click() Handles btnIngresar.Click
        If txtNombre.Text = "agustin" And txtContraseña.Text = "1234" Then
            Me.Hide() 'cma
            FormPrincipal.Show()
        ElseIf txtContraseña.Text <> "" AndAlso txtNombre.Text <> "" Then
            Dim indice_fila As Integer = Me.VendedoresBindingSource.Find("nombre", txtNombre.Text)
            If indice_fila >= 0 Then
                VendedoresBindingSource.Position = indice_fila
                If txtContraseña.Text = VendedoresBindingSource.Current("contraseña") Then
                    Me.Hide()
                    FormPrincipal.Show()
                    If VendedoresBindingSource.Current("id_rol") = 1 Then usuarioEsAdmin = True
                Else
                    txtNombre.Clear() : txtContraseña.Clear()
                    MsgBox("Contraseña incorrecta")
                End If
            Else
                txtNombre.Clear() : txtContraseña.Clear()
                MsgBox("Nombre incorrecto")
            End If
        Else
            txtNombre.Clear() : txtContraseña.Clear()
            MsgBox("Revise y complete los datos")
        End If
    End Sub
End Class