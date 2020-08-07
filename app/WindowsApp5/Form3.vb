Imports MaterialSkin
Public Class MessageBox
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        'Dim SkinManager1 As MaterialSkinManager = MaterialSkinManager.Instance
        'SkinManager1.AddFormToManage(Me)
        'SkinManager1.Theme = MaterialSkinManager.Themes.DARK
        'SkinManager1.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue700, Primary.Blue700, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class