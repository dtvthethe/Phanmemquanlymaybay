Imports System.Data.OleDb
Public Class quanlychuyenbay

    'kết nối dến access và lấy tên user
    Dim user As String = phanmemquanlybanvemaybay.userLabel.Text
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim di_tu1, ngay_di1, ho_va_ten1, giodi1, den21, so_dien_thoai1, cmnd11, quoc_tich1 As String

    ' hiển thị dữ liệu lên DataGridView từ data
    Private Sub read()
        Dim tb As New DataTable("data")
        cmd.CommandText = "select id, di_tu, den, time1, so_ghe, so_hieu_bay, cua_bay, ho_va_ten, cmnd, so_dien_thoai from data"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        tb.Load(rd)
        DataGridView.DataSource = tb
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    ' hiển thị tương đương với id được chọn
    Private Sub read2()
        Dim selectedRow As DataGridViewSelectedRowCollection = DataGridView.SelectedRows
        Dim selectedId As String = selectedRow.Item(0).Cells(0).Value.ToString()
        cmd.CommandText = "SELECT * FROM data WHERE (((data.ID)=" & selectedId & "))"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        If rd.Read() Then
            di_tu1 = rd("di_tu")
            ngay_di1 = rd("di_tu")
            ho_va_ten1 = rd("ho_va_ten")
            giodi1 = rd("time1")
            den21 = rd("den")
            so_dien_thoai1 = rd("so_dien_thoai")
            cmnd11 = rd("cmnd")
            quoc_tich1 = rd("quoc_tich")
        End If
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    'tìm kiếm trên DataGridView theo :
    Private Sub timkiem()
        Dim da As New OleDbDataAdapter
        Dim tb As New DataTable
        If timtheoComboBox.SelectedItem = "Số ghế" Then
            cmd.CommandText = "SELECT di_tu, den, time1, so_ghe, so_hieu_bay, cua_bay, ho_va_ten, cmnd, so_dien_thoai FROM data WHERE (((data.so_ghe)='" & timkiemTextBox.Text & "'))"
        ElseIf timtheoComboBox.SelectedItem = "Số hiệu bay" Then
            cmd.CommandText = "SELECT di_tu, den, time1, so_ghe, so_hieu_bay, cua_bay, ho_va_ten, cmnd, so_dien_thoai FROM data WHERE (((data.so_hieu_bay)='" & timkiemTextBox.Text & "'))"
        ElseIf timtheoComboBox.SelectedItem = "Cửa bay" Then
            cmd.CommandText = "SELECT di_tu, den, time1, so_ghe, so_hieu_bay, cua_bay, ho_va_ten, cmnd, so_dien_thoai FROM data WHERE (((data.cua_bay)='" & timkiemTextBox.Text & "'))"
        ElseIf timtheoComboBox.SelectedItem = "Họ và tên" Then
            cmd.CommandText = "SELECT di_tu, den, time1, so_ghe, so_hieu_bay, cua_bay, ho_va_ten, cmnd, so_dien_thoai FROM data WHERE (((data.ho_va_ten)='" & timkiemTextBox.Text & "'))"
        ElseIf timtheoComboBox.SelectedItem = "CMND" Then
            cmd.CommandText = "SELECT di_tu, den, time1, so_ghe, so_hieu_bay, cua_bay, ho_va_ten, cmnd, so_dien_thoai FROM data WHERE (((data.cmnd)='" & timkiemTextBox.Text & "'))"
        ElseIf timtheoComboBox.SelectedItem = "SĐT" Then
            cmd.CommandText = "SELECT di_tu, den, time1, so_ghe, so_hieu_bay, cua_bay, ho_va_ten, cmnd, so_dien_thoai FROM data WHERE (((data.so_dien_thoai)='" & timkiemTextBox.Text & "'))"
        End If
        cmd.Connection = cn
        cn.Open()
        da.SelectCommand = cmd
        da.Fill(tb)
        DataGridView.DataSource = tb
        If tb.Rows.Count = 0 Then
            errorLabel.Text = "Từ khóa tìm kiếm không chính xác"
        End If
        cmd.Dispose()
        cn.Close()
    End Sub

    ' ghi dữ liệu khi thực hiện sửa
    Private Sub coppy()
        cmd.Connection = cn
        cn.Open()
        cmd.CommandText = "insert into  huyve (di_tu, ngay_di, time1, den, ho_va_ten, cmnd, so_dien_thoai, quoc_tich, nguoi_dung) values ('" & di_tu1 & "','" & ngay_di1 & "','" & giodi1 & "','" & den21 & "','" & ho_va_ten1 & "','" & cmnd11 & "','" & so_dien_thoai1 & "','" & quoc_tich1 & "','" & user & "')"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cn.Close()
    End Sub

    ' xóa :
    Private Sub delete()
        Dim selectedRow As DataGridViewSelectedRowCollection = DataGridView.SelectedRows
        Dim selectedId As String = selectedRow.Item(0).Cells(0).Value.ToString()
        cmd.Connection = cn
        cn.Open()
        MessageBox.Show("Bạn chắc chắn muốn xóa thông tin của hành khách " + ho_va_ten1 & "!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If selectedId > 0 Then
            cmd.CommandText = "delete from  data where  id =(" & selectedId & ")"
            cmd.ExecuteNonQuery()
        End If
        cmd.Dispose()
        cn.Close()
    End Sub

    'đọc id cho việc thống kê
    Dim sendid As Integer
    Dim tong As Integer
    Dim nguoi As Integer
    Private Sub id1()

        cmd.Connection = cn
        cn.Open()
        cmd.CommandText = "select * from thongke"
        rd = cmd.ExecuteReader
        If rd.Read Then
            sendid = rd("id")
            nguoi = rd("so_luong_nguoi_huy_ve")
        End If
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    ' số người đặt vé
    Private Sub so_luong_nguoi_huyve()
        id1()
        cmd.Connection = cn
        cn.Open()
        tong = nguoi + 1
        cmd.CommandText = "update thongke set so_luong_nguoi_huy_ve=" & tong & " where id =" & sendid & ""
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cn.Close()
    End Sub

    Private Sub quanlychuyenbay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        read() ' thực hiện read
    End Sub


    Private Sub timkiemButton_Click(sender As Object, e As EventArgs) Handles timkiemButton.Click
        timkiem() ' thực hiện timkiem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles lammoiButton.Click
        read() ' thực hiện read
        timkiemTextBox.Text = "" ' làm rỗng textbox
    End Sub

    Private Sub suaButton_Click(sender As Object, e As EventArgs) Handles suaButton.Click
        'lấy id từ DataGridView khi lựa chọn và hiển thị lên form sua
        Dim selectedRow As DataGridViewSelectedRowCollection = DataGridView.SelectedRows
        Dim selectedId As String = selectedRow.Item(0).Cells(0).Value.ToString()
        Dim sua As New sua(selectedId)
        sua.ShowDialog()
    End Sub

    Private Sub huybayButton_Click(sender As Object, e As EventArgs) Handles huybayButton.Click
        ' thực hiện read, coppy, delete,read
        read2()
        coppy()
        so_luong_nguoi_huyve() ' sô người hủy vé
        delete()
        read()
    End Sub

    Private Sub thongtinButton_Click(sender As Object, e As EventArgs) Handles thongtinButton.Click
        'lấy id từ DataGridView khi lựa chọn và hiển thị lên form thongtin_kh
        Dim selectedRow As DataGridViewSelectedRowCollection = DataGridView.SelectedRows
        Dim selectedId As String = selectedRow.Item(0).Cells(0).Value.ToString()
        Dim thongtin_kh As New thongtin_khachhang(selectedId)
        thongtin_kh.ShowDialog()
    End Sub

    Private Sub thoatButton_Click(sender As Object, e As EventArgs) Handles thoatButton.Click
        Me.Close() ' thoát
    End Sub

End Class