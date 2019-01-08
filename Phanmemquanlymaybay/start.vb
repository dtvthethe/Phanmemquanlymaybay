Public Class start

    ' khi ProgressBar1 chạy đến giá trị nào thì thực hiện theo tứng giá trị đó và hiển thi form đăng nhập
    Private Sub timer()
        Select Case ProgressBar1.Value
            Case Is = 20
                startLabel.Text = "Starting."
            Case Is = 40
                startLabel.Text = "Starting.."
            Case Is = 60
                startLabel.Text = "Starting..."
            Case Is = 80
                startLabel.Text = "Starting."
            Case Is = 100
                startLabel.Text = "Starting.."
                Me.Hide()
                ProgressBar1.Value = 0
                Timer1.Stop()
                dangnhap.Show()
                If check = True Then
                    dangnhap.Close()
                End If
        End Select
    End Sub

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start() ' Timer1 bắt đầu chạy 
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1) ' khởi tạo giá trị là 1
        phantramLabel.Text = ProgressBar1.Value & " %" 'hiển thị % 
        timer() ' thực hiện time
    End Sub

End Class