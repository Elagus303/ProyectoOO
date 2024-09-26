Module Module1
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
End Module
