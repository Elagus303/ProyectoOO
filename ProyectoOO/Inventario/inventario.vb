Public Class inventario
    Dim canthojas As Integer
    Dim canttinta As Integer
    Dim cantanillos As Integer
    Dim cantaposc As Integer
    Dim cantaptrans As Integer


    Private Sub inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Hojas.Text += canthojas.ToString


    End Sub

    Private Sub Hojas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hojas.Click

    End Sub

    Private Sub PrecHoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrecHoja.Click

    End Sub

    Private Sub inventario_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Prichangehoj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prichangehoj.Click

    End Sub
End Class