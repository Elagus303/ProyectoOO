Module Module1
    'Variables del sistema
    Public Id_Global_Vendedor As Integer = -1
    Public usuarioEsAdmin As Boolean
    'Variables de Colores
    Public ColorBase As Color = Color.LemonChiffon
    Public ColorControl As Color = Color.PaleGoldenrod
    Public ColorSobreBase As Color = Color.DarkKhaki
    Public ColorTextoPrimario As Color = Color.Black
    Public ColorTextoSecundario As Color = Color.White


    Public Sub MostrarFormPanel(ByVal form As Form)
        FormPrincipal.PanelPrincipal.Controls.Clear() 'Borrar todos los controles
        form.TopLevel = False 'Para que pueda ser contenido por el pnl
        form.FormBorderStyle = Windows.Forms.FormBorderStyle.None 'Quitar bordes
        form.Dock = DockStyle.Fill 'Expandir totalmente
        FormPrincipal.PanelPrincipal.SuspendLayout()
        FormPrincipal.PanelPrincipal.Controls.Add(form) 'Agregar el form como control del pnl
        form.Show()
        FormPrincipal.PanelPrincipal.ResumeLayout()
    End Sub

    Public Sub limpiar(ByVal formx As Form)
        Dim aux As Control
        For Each aux In formx.Controls
            If TypeOf aux Is TextBox Then
                aux.Text = ""
            End If
        Next
    End Sub
    Function SoloLetras(ByVal teclas As System.Windows.Forms.KeyPressEventArgs)
        Dim tecla_presionada As Integer
        tecla_presionada = AscW(teclas.KeyChar)

        If tecla_presionada >= 65 And tecla_presionada <= 90 Or
            tecla_presionada >= 97 And tecla_presionada <= 122 Or
            tecla_presionada = 13 Or
            tecla_presionada = 8 Or
            tecla_presionada = 46 Or
            tecla_presionada = 9 Then
            SoloLetras = AscW(teclas.KeyChar)
        Else
            SoloLetras = 0
        End If


    End Function
    Function SoloNumeros(ByVal teclas As System.Windows.Forms.KeyPressEventArgs) As Boolean
        Dim tecla_presionada As Integer
        tecla_presionada = AscW(teclas.KeyChar)

        ' Verificamos si la tecla es un número (del 0 al 9) o una tecla especial como retroceso o tabulador
        If (tecla_presionada >= 48 And tecla_presionada <= 57) Or
            tecla_presionada = 8 Or tecla_presionada = 9 Or tecla_presionada = 44 Then  ' Tecla Tab ' Tecla Backspace

            ' Permitimos la tecla presionada
            Return False
        Else
            ' Si no es un número o tecla especial, la cancelamos
            System.Media.SystemSounds.Exclamation.Play()
            Return True
        End If
    End Function

    Function LetrasNumeros(ByVal teclas As System.Windows.Forms.KeyPressEventArgs) As Boolean
        Dim tecla_presionada As Integer
        tecla_presionada = AscW(teclas.KeyChar)

        ' Verificamos si la tecla es un número (del 0 al 9) o una tecla especial como retroceso o tabulador
        If (tecla_presionada >= 48 And tecla_presionada <= 57) Or
            tecla_presionada = 8 Or tecla_presionada = 9 Or tecla_presionada = 44 Or tecla_presionada >= 65 And tecla_presionada <= 90 Or
            tecla_presionada >= 97 And tecla_presionada <= 122 Or
            tecla_presionada = 13 Or
            tecla_presionada = 46 Or tecla_presionada = 64 Or tecla_presionada = 46 Then  ' Tecla Tab ' Tecla Backspace

            ' Permitimos la tecla presionada
            Return False
        Else
            ' Si no es un número o tecla especial, la cancelamos
            Return True
        End If
    End Function

    Public Sub EstilosDataGridView(ByVal x As DataGridView)
        x.BackgroundColor = ColorBase
        x.BorderStyle = BorderStyle.None
        x.RowHeadersVisible = False
        x.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        x.AllowUserToResizeColumns = False
        x.AllowUserToResizeRows = False
        x.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        x.EnableHeadersVisualStyles = False
        x.ColumnHeadersDefaultCellStyle.BackColor = ColorSobreBase
        x.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        x.RowsDefaultCellStyle.BackColor = ColorBase
        x.RowsDefaultCellStyle.SelectionBackColor = ColorControl
        x.RowsDefaultCellStyle.SelectionForeColor = ColorTextoPrimario
        x.GridColor = ColorSobreBase
    End Sub
    
End Module
