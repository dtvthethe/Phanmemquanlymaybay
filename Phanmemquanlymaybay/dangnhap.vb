Imports System.Data.OleDb

Public Class dangnhap
    'kết nối đến access
    Dim cn1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb") ' tài khoản nhân viên
    Dim cn2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb") ' tài khoản master 
    Dim cmd1 As New OleDbCommand ' tài khoản nhân viên
    Dim cmd2 As New OleDbCommand ' tài khoản master 
    Dim read1 As OleDbDataReader ' tài khoản nhân viên
    Dim read2 As OleDbDataReader ' tài khoản master

    ' tài khoản nhân viên
    Sub dang_nhap()
        cmd1.CommandText = "SELECT dangnhap.tendangnhap, dangnhap.matkhau FROM dangnhap WHERE (((dangnhap.tendangnhap)='" & tendangnhapTextBox.Text & "') AND ((dangnhap.matkhau)='" & matkhauTextBox.Text & "'))" 'truy xuất đến access
        cmd1.Connection = cn1 'kết nối
        cn1.Open()
        read1 = cmd1.ExecuteReader
        If read1.Read() = True Then ' nếu đúng thì sẽ bị giới hạn một số chức năng
            check = True
            phanmemquanlybanvemaybay.Show()
            phanmemquanlybanvemaybay.thongkeButton.Enabled = False
            phanmemquanlybanvemaybay.lichsuButton.Enabled = False
            phanmemquanlybanvemaybay.managerButton.Enabled = False
            phanmemquanlybanvemaybay.thongkemenu.Enabled = False
            phanmemquanlybanvemaybay.lichsumenu.Enabled = False
            phanmemquanlybanvemaybay.managermenu.Enabled = False
            Me.Close()
        Else ' nếu sai thì sẽ chuyển sang Sub dangnhap_master()
            dangnhap_master()
        End If
        cmd1.Dispose()
        read1.Close()
        cn1.Close()
    End Sub

    ' tài khoản master
    Sub dangnhap_master()
        cmd2.CommandText = "SELECT admin.ten_dang_nhap_master, admin.mat_khau_master FROM admin WHERE (((admin.ten_dang_nhap_master)='" & tendangnhapTextBox.Text & "') AND ((admin.mat_khau_master)='" & matkhauTextBox.Text & "'))" 'truy xuất đến access
        cmd2.Connection = cn2 'kết nối
        cn2.Open()
        read2 = cmd2.ExecuteReader
        If read2.Read() = True Then ' nếu đúng sẽ không bị giới hạn các chức năng
            check = True
            phanmemquanlybanvemaybay.Show()
            Me.Close()
        Else ' nếu sai thì sẽ hiển thị thông báo
            check = False
            loiLabel.Text = "Sai tài khoản hoặc mật khẩu"
            clear() 'xóa mật khẩu trên 2 texboxt
        End If
        cmd2.Dispose()
        read2.Close()
        cn2.Close()
    End Sub

    'xóa mật khẩu trên 2 texboxt
    Private Sub clear()
        tendangnhapTextBox.Text = ""
        matkhauTextBox.Text = ""
    End Sub

    Private Sub thoatButton_Click(sender As Object, e As EventArgs) Handles thoatButton.Click
        'Me.Close() ' khi nhấn vào button này thì sẽ thoát khỏi chương trình
        'start.Close()
        End
    End Sub

    Private Sub dangnhapButton_Click(sender As Object, e As EventArgs) Handles dangnhapButton.Click
        'lưu tên tài khoản
        phanmemquanlybanvemaybay.userLabel.Text = tendangnhapTextBox.Text
        'thực hiện đăng nhập
        dang_nhap()
    End Sub

End Class
