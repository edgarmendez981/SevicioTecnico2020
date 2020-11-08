Public Class Administracion

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Btn_aceptar_Click(sender As Object, e As EventArgs) Handles Btn_aceptar.Click
        Dim usuario As String
        Dim contraseña As Integer
        usuario = Text_usuario.Text
        contraseña = Text_contraseña.Text
        If (usuario = "Edgar") And (contraseña = "123") Then
            Form2.Show()
        Else
            MsgBox("Contraseña Incorrecta")

        End If
        Text_usuario.Text = ""
        Text_contraseña.Text = ""

    End Sub

    Private Sub txt_salir_Click(sender As Object, e As EventArgs) Handles txt_salir.Click
        Me.Close()
    End Sub
End Class
