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
            e.SuppressKeyPress = True
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
        ' Verifica si el nombre y la contraseña son correctos
        If txtNombre.Text = "agustin" And txtContraseña.Text = "1234" Then
            ' Usuario predefinido
            usuarioEsAdminx = True  ' Si deseas que Agustin sea un administrador
            usuarioNombre = "Agustin"
            usuarioID = 0 ' O un valor que quieras asignar como id para el usuario predefinido

            ' Ocultar el formulario de login y mostrar el principal
            Me.Hide()
            Id_Global_Vendedor = 0

            FormPrincipal.Show()
        ElseIf txtNombre.Text <> "" And txtContraseña.Text <> "" Then
            ' Busca el nombre en la base de datos
            Dim indice_fila As Integer = Me.VendedoresBindingSource.Find("nombre", txtNombre.Text)

            If indice_fila >= 0 Then
                VendedoresBindingSource.Position = indice_fila

                ' Verifica si la contraseña es correcta
                If txtContraseña.Text = VendedoresBindingSource.Current("contraseña").ToString() Then
                    ' Asignar el rol del usuario
                    Dim idRol As Integer = CInt(VendedoresBindingSource.Current("id_rol"))

                    ' Verificar el rol
                    If idRol = 1 Then
                        usuarioEsAdminx = True  ' Es administrador
                    ElseIf idRol = 2 Then
                        usuarioEsAdminx = False  ' Es usuario estándar
                    End If

                    ' Guardar el nombre del usuario logueado
                    usuarioNombre = VendedoresBindingSource.Current("nombre").ToString()
                    usuarioID = CInt(VendedoresBindingSource.Current("id")) ' Asignar el id correctamente

                    ' Ocultar el formulario de login y mostrar el principal
                    Me.Hide()
                    Id_Global_Vendedor = Me.VendedoresBindingSource.Current("id")
                    FormPrincipal.Show()
                Else
                    MsgBox("Contraseña incorrecta")
                    txtContraseña.Clear()
                    txtContraseña.Focus()
                End If
            Else
                MsgBox("Nombre incorrecto")
                txtNombre.Clear()
                txtNombre.Focus()
            End If
        Else
            MsgBox("Revise y complete los datos")
        End If
    End Sub
End Class