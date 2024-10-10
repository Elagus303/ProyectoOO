Public Class FormInicioSesion
    '1)FORMULARIO DE INICIO DE SESIÓN
    '1.a) Evento Load
    Private Sub FormInicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Hide()
            FormPrincipal.Show()
        Else
            MsgBox("Contraseña incorrecta")
        End If
    End Sub
End Class