Imports MaterialSkin
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Load.Width += 5
        If Load.Width >= 290 Then
            Me.Close()
            Form1.Show()
        End If
    End Sub
End Class