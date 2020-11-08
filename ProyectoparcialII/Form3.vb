Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClientesDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.clientes)

    End Sub

   
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles IMPRIMIR.Click
        PrintDocument1.Print()
    End Sub



End Class