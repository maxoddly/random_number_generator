Public Class Form
    Dim allStuNum As Integer = 42
    Dim allStuName As New ArrayList
    Dim useName As Boolean
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer1.Interval = 20
        Try
            Dim fn = FreeFile()
            FileOpen(fn, "config.txt", OpenMode.Input)
            Dim num As Integer
            Input(fn, num)
            allStuNum = num
        Catch
            allStuNum = 42
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()
        Dim randNum As Integer = Rnd() * (allStuNum - 1) + 1
        Label1.Text = randNum
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "开始" Then
            Timer1.Enabled = True
            Button1.Text = "关闭"
        Else
            Timer1.Enabled = False
            Button1.Text = "开始"
        End If
    End Sub
End Class
