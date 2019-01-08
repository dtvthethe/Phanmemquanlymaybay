Imports System.Data.OleDb

Public Class manager
    ' khai báo user và kết nối
    Dim taikhoan As String
    Dim id As String
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader

    'hiển thị địa điểm ho_chi_minh từ access
    Private Sub ho_chi_minh()
        denComboBox.Items.Clear()
        cmd.CommandText = "select den from saigon"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        While rd.Read()
            denComboBox.Items.Add(rd("den"))
        End While
        cn.Close()
        cmd.Dispose()
        rd.Close()
    End Sub

    'hiển thị địa điểm hanoi từ access
    Private Sub hanoi()
        denComboBox.Items.Clear()
        cmd.CommandText = "select den from hanoi"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        While rd.Read()
            denComboBox.Items.Add(rd("den"))
        End While
        cn.Close()
        cmd.Dispose()
        rd.Close()
    End Sub

    'hiển thị địa điểm danang từ access
    Private Sub danang()
        denComboBox.Items.Clear()
        cmd.CommandText = "select id, den from danang"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        While rd.Read()
            denComboBox.Items.Add(rd("den"))
        End While
        cn.Close()
        cmd.Dispose()
        rd.Close()
    End Sub

    'hiển thị dữ liệu giá vé Đà Nẵng
    Private Sub gia_ve_da_nang()
        cmd.CommandText = " SELECT * FROM danang WHERE (((danang.den)= '" & denComboBox.SelectedItem & "' )) "
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            thuonggiaLabel.Text = String.Format("{0:c}", rd("thuong_gia"))
            phothongLabel.Text = String.Format("{0:c}", rd("pho_thong"))
            tietkiemLabel.Text = String.Format("{0:c}", rd("tiet_kiem"))
            id = rd("id")
        End If
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    'hiển thị dữ liệu giá vé Hà Nội
    Private Sub gia_ve_ha_noi()
        cmd.CommandText = " SELECT * FROM hanoi WHERE (((hanoi.den)= '" & denComboBox.SelectedItem & "' )) "
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            thuonggiaLabel.Text = String.Format("{0:c}", rd("thuong_gia"))
            phothongLabel.Text = String.Format("{0:c}", rd("pho_thong"))
            tietkiemLabel.Text = String.Format("{0:c}", rd("tiet_kiem"))
            id = rd("id")
        End If
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    'hiển thị dữ liệu giá vé TP.Hồ Chí Minh
    Private Sub gia_ve_HCM()
        cmd.CommandText = " SELECT * FROM saigon WHERE (((saigon.den)= '" & denComboBox.SelectedItem & "' )) "
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            thuonggiaLabel.Text = String.Format("{0:c}", rd("thuong_gia"))
            phothongLabel.Text = String.Format("{0:c}", rd("pho_thong"))
            tietkiemLabel.Text = String.Format("{0:c}", rd("tiet_kiem"))
            id = rd("id")
        End If
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    ' nếu giá trị = "$0.00" thì hiển thị :"Bổ sung thêm hạng này!"
    Private Sub empty()
        If thuonggiaTextBox.Text = "$0.00" Then
            thuonggiaTextBox.Text = "Bổ sung thêm hạng này!"
        ElseIf phothongTextBox.Text = "$0.00" Then
            phothongTextBox.Text = "Bổ sung thêm hạng này!"
        ElseIf tietkiemTextBox.Text = "$0.00" Then
            tietkiemTextBox.Text = "Bổ sung thêm hạng này!"
        End If
    End Sub

    Private Sub dituComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dituComboBox.SelectedIndexChanged
        If dituComboBox.SelectedItem = "TP. Hồ Chí Minh" Then 'nếu dituComboBox chọn TP. Hồ Chí Minh thì sẽ hiển các điểm đến xuất phát từ TP. Hồ Chí Minh
            ho_chi_minh()
        ElseIf dituComboBox.SelectedItem = "Đà Nẵng" Then 'nếu dituComboBox chọn Đà Nẵng thì sẽ hiển các điểm đến xuất phát từ Đà Nẵng
            danang()
        ElseIf dituComboBox.SelectedItem = "Hà Nội" Then 'nếu dituComboBox chọn Hà Nội thì sẽ hiển các điểm đến xuất phát từ Hà Nội
            hanoi()
        End If
    End Sub

    ' thay đổi giá vé Đà Nẵng
    Private Sub sua_gia_ve_DN()
        cmd.Connection = cn
        cn.Open()
        MessageBox.Show("Bạn chắc chắn muốn thay đổi giá vé mới!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If thuonggiaTextBox.Text <> "" Then
            cmd.CommandText = "update danang set thuong_gia=" & thuonggiaTextBox.Text & " where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If phothongTextBox.Text <> "" Then
            cmd.CommandText = "update danang set pho_thong=" & phothongTextBox.Text & " where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If thuonggiaTextBox.Text <> "" Then
            cmd.CommandText = "update danang set tiet_kiem=" & tietkiemTextBox.Text & " where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        cmd.Dispose()
        cn.Close()
    End Sub

    ' thay đổi giá vé Hà Nội
    Private Sub sua_gia_ve_HN()
        cmd.Connection = cn
        cn.Open()
        MessageBox.Show("Bạn chắc chắn muốn thay đổi giá vé mới!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If thuonggiaTextBox.Text <> "" Then
            cmd.CommandText = "update hanoi set thuong_gia=" & thuonggiaTextBox.Text & " where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If phothongTextBox.Text <> "" Then
            cmd.CommandText = "update hanoi set pho_thong=" & phothongTextBox.Text & " where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If thuonggiaTextBox.Text <> "" Then
            cmd.CommandText = "update hanoi set tiet_kiem=" & tietkiemTextBox.Text & " where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        cmd.Dispose()
        cn.Close()
    End Sub

    ' thay đổi giá vé TP.HCM
    Private Sub sua_gia_ve_HCM()
        cmd.Connection = cn
        cn.Open()
        MessageBox.Show("Bạn chắc chắn muốn thay đổi giá vé mới!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If thuonggiaTextBox.Text <> "" Then
            cmd.CommandText = "update saigon set thuong_gia=" & thuonggiaTextBox.Text & " where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If phothongTextBox.Text <> "" Then
            cmd.CommandText = "update saigon set pho_thong=" & phothongTextBox.Text & " where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If thuonggiaTextBox.Text <> "" Then
            cmd.CommandText = "update saigon set tiet_kiem=" & tietkiemTextBox.Text & " where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        cmd.Dispose()
        cn.Close()
    End Sub

    ' hiển thị tên đăng nhập của nhân viên
    Private Sub nhan_vien()
        cmd.CommandText = "select tendangnhap from dangnhap"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        While rd.Read()
            taikhoanListBox.Items.Add(rd("tendangnhap"))
        End While
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    ' hiển thị tên đăng nhập của admin
    Private Sub admin()
        cmd.CommandText = "select ten_dang_nhap_master from admin"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        While rd.Read()
            taikhoanListBox.Items.Add(rd("ten_dang_nhap_master"))
        End While
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    'thêm tài khoản vào nhân viên
    Private Sub them_mot_tai_khoan_nhan_vien()
        cmd.CommandText = "insert into dangnhap(tendangnhap, matkhau) values ('" & tendangnhapTextBox.Text & "','" & matkhauTextBox.Text & "') "
        cmd.Connection = cn
        cn.Open()
        cmd.ExecuteNonQuery()
        taikhoanListBox.Items.Add(tendangnhapTextBox.Text)
        MessageBox.Show("Đã thêm một tài khoản vào nhân viên")
        cmd.Dispose()
        cn.Close()
    End Sub

    'thêm tài khoản vào admin
    Private Sub them_mot_tai_khoan_admin()
        cmd.CommandText = "insert into admin(ten_dang_nhap_master, mat_khau_master) values ('" & tendangnhapTextBox.Text & "','" & matkhauTextBox.Text & "') "
        cmd.Connection = cn
        cn.Open()
        cmd.ExecuteNonQuery()
        taikhoanListBox.Items.Add(tendangnhapTextBox.Text)
        MessageBox.Show("Đã thêm một tài khoản vào Admin")
        cmd.Dispose()
        cn.Close()
    End Sub

    'hiển thị mật khẩu tương đương với tài khoản nhân viên
    Private Sub hien_thi_tai_khoan()
        cmd.CommandText = "SELECT * FROM dangnhap WHERE (((dangnhap.tendangnhap)= '" & taikhoanListBox.SelectedItem & "'))"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            taikhoanLabel.Text = taikhoanListBox.SelectedItem
            matkhauTextBox1.Text = rd("matkhau")
            id = rd("id")
        End If
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    'hiển thị mật khẩu tương đương với tài khoản admin
    Private Sub hien_thi_tai_khoan_admin()
        cmd.CommandText = "SELECT * FROM admin WHERE (((admin.ten_dang_nhap_master)= '" & taikhoanListBox.SelectedItem & "'))"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            taikhoanLabel.Text = taikhoanListBox.SelectedItem
            matkhauTextBox1.Text = rd("mat_khau_master")
            id = rd("id")
        End If
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    'xóa tài khoản nhân viên
    Private Sub xoa_tai_khoan()
        cmd.Connection = cn
        cn.Open()
        If taikhoanLabel.Text <> "" Then
            MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            cmd.CommandText = "delete from dangnhap where  tendangnhap=('" & taikhoanLabel.Text & "')"
            cmd.ExecuteNonQuery()
            taikhoanListBox.Items.Clear()
        End If
        cmd.Dispose()
        cn.Close()
    End Sub

    'xóa tài khoản admin
    Private Sub xoa_tai_khoan_admin()
        cmd.Connection = cn
        cn.Open()
        If taikhoanLabel.Text <> "" Then
            MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            cmd.CommandText = "delete from admin where  ten_dang_nhap_master=('" & taikhoanLabel.Text & "')"
            cmd.ExecuteNonQuery()
            taikhoanListBox.Items.Clear()
        End If
        cmd.Dispose()
        cn.Close()
    End Sub

    ' làm mới form và đọc tên tài khoản nhân viên
    Private Sub refesh1()
        taikhoanLabel.Text = ""
        matkhauTextBox1.Text = ""
        cmd.CommandText = "SELECT tendangnhap FROM dangnhap"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            taikhoanListBox.Items.Add(rd("tendangnhap"))
        End While
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    ' làm mới form và đọc tên tài khoản admin
    Private Sub refesh2()
        taikhoanLabel.Text = ""
        matkhauTextBox1.Text = ""
        cmd.CommandText = "SELECT ten_dang_nhap_master FROM admin"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            taikhoanListBox.Items.Add(rd("ten_dang_nhap_master"))
        End While
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    ' đổi mật khẩu nhân viên
    Private Sub doimatkhau()
        cmd.Connection = cn
        cn.Open()
        If TextBox1.Text <> "" Then
            MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu của tài khoản " + taikhoanLabel.Text & "!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            cmd.CommandText = "update dangnhap set matkhau='" & TextBox1.Text & "' where id=" & id & ""
            cmd.ExecuteNonQuery()
        End If
        cmd.Dispose()
        cn.Close()
    End Sub

    ' đổi mật khẩu admin
    Private Sub doimatkhau_admin()
        cmd.Connection = cn
        cn.Open()
        If TextBox1.Text <> "" Then
            ' "update table1 set field1='" & TextBox2.Text & "' where field1='" & TextBox1.Text & "'"
            MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu của tài khoản " + taikhoanLabel.Text & "!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            cmd.CommandText = "update admin set mat_khau_master='" & TextBox1.Text & "' where id=" & id & ""
            cmd.ExecuteNonQuery()
        End If
        cmd.Dispose()
        cn.Close()
    End Sub

    Private Sub denComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles denComboBox.SelectedIndexChanged
        If dituComboBox.Text = "Đà Nẵng" Then 'hiển thị giá vé Đà Nẵng khi dituComboBox chọn Đà Nẵng
            gia_ve_da_nang()
        ElseIf dituComboBox.Text = "Hà Nội" Then 'hiển thị giá vé Hà Nội khi dituComboBox chọn Hà Nội
            gia_ve_ha_noi()
        ElseIf dituComboBox.Text = "TP. Hồ Chí Minh" Then 'hiển thị giá vé TP. Hồ Chí Minh khi dituComboBox chọn TP. Hồ Chí Minh
            gia_ve_HCM()
        End If
    End Sub

    Private Sub thuonggiaTextBox_TextChanged(sender As Object, e As EventArgs)
        empty() ' nếu giá trị = "$0.00" thì hiển thị :"Bổ sung thêm hạng này!"
    End Sub

    Private Sub phothongTextBox_TextChanged(sender As Object, e As EventArgs)
        empty() ' nếu giá trị = "$0.00" thì hiển thị :"Bổ sung thêm hạng này!"
    End Sub

    Private Sub tietkiemTextBox_TextChanged(sender As Object, e As EventArgs)
        empty() ' nếu giá trị = "$0.00" thì hiển thị :"Bổ sung thêm hạng này!"
    End Sub

    Private Sub suaButton_Click(sender As Object, e As EventArgs) Handles suaButton.Click
        ' hiển thị các lable, textbox, radiobutton lên form
        thuonggiaTextBox.Visible = True
        phothongTextBox.Visible = True
        tietkiemTextBox.Visible = True
        luuButton.Visible = True
        ' ẩn các lable, textbox, radiobutton không cần thiết lên form
        suaButton.Visible = False
        thuonggiaLabel.Visible = False
        phothongLabel.Visible = False
        tietkiemLabel.Visible = False
    End Sub

    Private Sub luuButton_Click(sender As Object, e As EventArgs) Handles luuButton.Click
        If dituComboBox.SelectedItem = "TP. Hồ Chí Minh" Then 'nếu dituComboBox = TP. Hồ Chí Minh thì thực hiện sua_gia_ve_HCM
            sua_gia_ve_HCM()
        ElseIf dituComboBox.SelectedItem = "Đà Nẵng" Then 'nếu dituComboBox = Đà Nẵng thì thực hiện sua_gia_ve_DN
            sua_gia_ve_DN()
        ElseIf dituComboBox.SelectedItem = "Hà Nội" Then 'nếu dituComboBox = Hà Nội thì thực hiện sua_gia_ve_HN
            sua_gia_ve_HN()
        End If
        ' hiển thị các lable, textbox, radiobutton lên form
        thuonggiaTextBox.Visible = False
        phothongTextBox.Visible = False
        tietkiemTextBox.Visible = False
        luuButton.Visible = False
        ' ẩn các lable, textbox, radiobutton không cần thiết lên form
        suaButton.Visible = True
        thuonggiaLabel.Visible = True
        phothongLabel.Visible = True
        tietkiemLabel.Visible = True
        thuonggiaLabel.Text = ""
        phothongLabel.Text = ""
        tietkiemLabel.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles taikhoanComboBox.SelectedIndexChanged
        If taikhoanComboBox.SelectedItem = "Admin" Then 'nếu taikhoanComboBox = Admin thì thực hiện admin và xóa dữ liệu trên taikhoanListBox
            taikhoanListBox.Items.Clear()
            admin()
        ElseIf taikhoanComboBox.SelectedItem = "Nhân viên" Then 'nếu taikhoanComboBox = Nhân viên thì thực hiện nhan_vien và xóa dữ liệu trên taikhoanListBox
            taikhoanListBox.Items.Clear()
            nhan_vien()
        End If
    End Sub

    Private Sub themButton1_Click(sender As Object, e As EventArgs) Handles themButton1.Click
        If nhanvienRadioButton.Checked = True Then ' nếu nhanvienRadioButton được chọn thì thực hiện them_mot_tai_khoan_nhan_vien làm rỗng 2 textbox tendangnhapTextBox và matkhauTextBox
            them_mot_tai_khoan_nhan_vien()
            tendangnhapTextBox.Text = ""
            matkhauTextBox.Text = ""
        ElseIf adminRadioButton.Checked = True Then ' nếu adminRadioButton được chọn thì thực hiện them_mot_tai_khoan_admin làm rỗng 2 textbox tendangnhapTextBox và matkhauTextBox
            them_mot_tai_khoan_admin()
            tendangnhapTextBox.Text = ""
            matkhauTextBox.Text = ""
        End If
        ' hiển thị các lable, textbox, radiobutton lên form
        Label5.Visible = False
        Label6.Visible = False
        tendangnhapTextBox.Visible = False
        matkhauTextBox.Visible = False
        CheckBox1.Visible = False
        ' ẩn các lable, textbox, radiobutton không cần thiết lên form
        Label7.Visible = True
        Label9.Visible = True
        taikhoanLabel.Visible = True
        matkhauTextBox1.Visible = True
        showCheckBox.Visible = True
        nhanvienRadioButton.Visible = False
        adminRadioButton.Visible = False
        themButton1.Visible = False
    End Sub

    Private Sub taikhoanListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles taikhoanListBox.SelectedIndexChanged
        If taikhoanComboBox.SelectedItem = "Admin" Then ' nếu taikhoanComboBox= Admin thì thực hiện hien_thi_tai_khoan_admin
            hien_thi_tai_khoan_admin()
        ElseIf taikhoanComboBox.SelectedItem = "Nhân viên" Then ' nếu taikhoanComboBox= Nhân viên thì thực hiện hien_thi_tai_khoan
            hien_thi_tai_khoan()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles showCheckBox.CheckedChanged
        If showCheckBox.Checked = True Then ' nếu showCheckBox được chọn thì hiển thị mật khẩu
            matkhauTextBox1.UseSystemPasswordChar = False
            TextBox1.UseSystemPasswordChar = False
        Else 'ngược lại nếu showCheckBox không được chọn thì ẩn mật khẩu
            matkhauTextBox1.UseSystemPasswordChar = True
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub xoaButton1_Click(sender As Object, e As EventArgs) Handles xoaButton1.Click
        If taikhoanComboBox.SelectedItem = "Admin" Then ' nếu taikhoanComboBox= Admin thì thực hiện xoa_tai_khoan_admin và refesh2
            xoa_tai_khoan_admin()
            refesh2()
        ElseIf taikhoanComboBox.SelectedItem = "Nhân viên" Then ' nếu taikhoanComboBox= Nhân viên thì thực hiện xoa_tai_khoan_admin và refesh1
            xoa_tai_khoan()
            refesh1()
        End If
        ' ẩn các lable, textbox, radiobutton không cần thiết lên form
        Label7.Visible = True
        Label9.Visible = True
        taikhoanLabel.Visible = True
        matkhauTextBox1.Visible = True
        showCheckBox.Visible = True
        ' hiển thị các lable, textbox, radiobutton lên form
        xoaButton1.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then ' nếu CheckBox1 được chọn thì hiển thị mật khẩu
            matkhauTextBox.UseSystemPasswordChar = False
        Else ' ngược lại nếu CheckBox1 không được chọn thì ẩn mật khẩu
            matkhauTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub suaButton2_Click(sender As Object, e As EventArgs) Handles suaButton2.Click
        If taikhoanComboBox.SelectedItem = "Admin" Then ' nếu taikhoanComboBox= Admin thì thực hiện xoa_tai_khoan_admin
            doimatkhau_admin()
        ElseIf taikhoanComboBox.SelectedItem = "Nhân viên" Then ' nếu taikhoanComboBox= Admin thì thực hiện doimatkhau
            doimatkhau()
        End If
        'làm rỗng các lable và các textbox
        taikhoanLabel.Text = ""
        matkhauTextBox1.Text = ""
        TextBox1.Text = ""
        ' ẩn các lable, textbox, radiobutton không cần thiết lên form
        Label7.Visible = True
        Label9.Visible = True
        taikhoanLabel.Visible = True
        matkhauTextBox1.Visible = True
        showCheckBox.Visible = True
        ' hiển thị các lable, textbox, radiobutton lên form
        suaButton2.Visible = False
        TextBox1.Visible = False
    End Sub


    Private Sub manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ẩn các lable, textbox, radiobutton không cần thiết lên form
        Label7.Visible = True
        Label9.Visible = True
        taikhoanLabel.Visible = True
        matkhauTextBox1.Visible = True
        showCheckBox.Visible = True
        ' hiển thị các lable, textbox, radiobutton lên form
        themButton1.Visible = False
        thuonggiaTextBox.Visible = False
        phothongTextBox.Visible = False
        tietkiemTextBox.Visible = False
        luuButton.Visible = False
        xoaButton1.Visible = False
        TextBox1.Visible = False
        suaButton2.Visible = False


        Label5.Visible = False
        Label6.Visible = False
        tendangnhapTextBox.Visible = False
        matkhauTextBox.Visible = False
        CheckBox1.Visible = False
        nhanvienRadioButton.Visible = False
        adminRadioButton.Visible = False
    End Sub

    Private Sub suaButton1_Click(sender As Object, e As EventArgs) Handles suaButton1.Click
        ' hiển thị các lable, textbox, radiobutton lên form
        xoaButton1.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        tendangnhapTextBox.Visible = False
        matkhauTextBox.Visible = False
        CheckBox1.Visible = False
        nhanvienRadioButton.Visible = False
        adminRadioButton.Visible = False
        themButton1.Visible = False
        ' ẩn các lable, textbox, radiobutton không cần thiết lên form
        Label7.Visible = True
        Label9.Visible = True
        taikhoanLabel.Visible = True
        matkhauTextBox1.Visible = True
        showCheckBox.Visible = True
        TextBox1.Visible = True
        TextBox1.UseSystemPasswordChar = True
        suaButton2.Visible = True
    End Sub

    Private Sub themButton_Click(sender As Object, e As EventArgs) Handles themButton.Click
        ' ẩn các lable, textbox, radiobutton không cần thiết lên form
        Label5.Visible = True
        Label6.Visible = True
        tendangnhapTextBox.Visible = True
        matkhauTextBox.Visible = True
        CheckBox1.Visible = True
        nhanvienRadioButton.Visible = True
        adminRadioButton.Visible = True
        themButton.Visible = True
        ' hiển thị các lable, textbox, radiobutton lên form
        Label7.Visible = False
        Label9.Visible = False
        taikhoanLabel.Visible = False
        matkhauTextBox1.Visible = False
        showCheckBox.Visible = False
        themButton1.Visible = True
        xoaButton1.Visible = False
        suaButton2.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub xoaButton_Click(sender As Object, e As EventArgs) Handles xoaButton.Click
        ' hiển thị các lable, textbox, radiobutton lên form
        suaButton2.Visible = False
        TextBox1.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        tendangnhapTextBox.Visible = False
        matkhauTextBox.Visible = False
        CheckBox1.Visible = False
        nhanvienRadioButton.Visible = False
        adminRadioButton.Visible = False
        themButton1.Visible = False
        ' ẩn các lable, textbox, radiobutton không cần thiết lên form
        Label7.Visible = True
        Label9.Visible = True
        taikhoanLabel.Visible = True
        matkhauTextBox1.Visible = True
        showCheckBox.Visible = True
        xoaButton1.Visible = True
    End Sub

    Private Sub hienthiButton_Click(sender As Object, e As EventArgs) Handles hienthiButton.Click
        ' ẩn các lable, textbox, radiobutton không cần thiết lên form
        Label7.Visible = True
        Label9.Visible = True
        taikhoanLabel.Visible = True
        matkhauTextBox1.Visible = True
        showCheckBox.Visible = True
        ' hiển thị các lable, textbox, radiobutton lên form
        themButton1.Visible = False
        thuonggiaTextBox.Visible = False
        phothongTextBox.Visible = False
        tietkiemTextBox.Visible = False
        luuButton.Visible = False
        xoaButton1.Visible = False
        TextBox1.Visible = False
        suaButton2.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        tendangnhapTextBox.Visible = False
        matkhauTextBox.Visible = False
        CheckBox1.Visible = False
        nhanvienRadioButton.Visible = False
        adminRadioButton.Visible = False
    End Sub
End Class