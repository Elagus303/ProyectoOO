Public Class FormInicioSesion

    Private Sub pbTxtNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTxtNombre.Click
        txtNombre.Focus()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        txtContraseña.Focus()
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If txtNombre.Text = "agustin" And txtContraseña.Text = "1234" Then
            Me.Hide()
            FormPrincipal.Show()
        Else
            MsgBox("Contraseña incorrecta")
        End If
    End Sub

    Private Sub FormInicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (System.Windows.Forms.Screen.GetBounds(Me).Width - Me.Width) / 2
        Me.Top = (System.Windows.Forms.Screen.GetBounds(Me).Height - Me.Height) / 2
    End Sub
End Class