Imports System.Data.OleDb

Public Class lichsu
    ' khai báo kết nối đến access
    Dim read As String
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader

    'đọc phần lịch sử từ access
    Private Sub sua()
        Dim tb As New DataTable("lichsu")
        cmd.CommandText = "select ho_va_ten, di_tu, den, ngay_di, time1, cmnd, so_dien_thoai, quoc_tich, nguoi_dung, id from lichsu"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        tb.Load(rd)
        suaDataGridView.DataSource = tb
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    'đọc phần hủy vé từ access
    Private Sub huyve()
        Dim tb As New DataTable("huyve")
        cmd.CommandText = "select ho_va_ten, di_tu, den, ngay_di, time1, cmnd, so_dien_thoai, quoc_tich, nguoi_dung, id from huyve"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        tb.Load(rd)
        huyDataGridView.DataSource = tb
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    'xóa phần lịch sử trong access
    Private Sub xoa_lich_su()
        cmd.Connection = cn
        cn.Open()
        MessageBox.Show("Nếu bạn thực hiện thao tác này sẽ xóa tất cả dữ liệu có trong phần các thông tin đã sửa!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        cmd.CommandText = "delete * from lichsu"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cn.Close()
    End Sub

    'xóa phần hủy vé trong access
    Private Sub xoa_huy_ve()
        cmd.Connection = cn
        cn.Open()
        MessageBox.Show("Nếu bạn thực hiện thao tác này sẽ xóa tất cả dữ liệu có trong phần hủy vé!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        cmd.CommandText = "delete * from huyve"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cn.Close()
        huyve()
    End Sub

    Private Sub lichsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sua() 'khi form load thì hiển thị phần lịch sử từ access
        huyve()
        ' hiển thị bảng các thông tin đã sửa
        suaDataGridView.Visible = True
        xoa1Button.Visible = True
        ' ngược lại ẩn bảng lịch sử hủy vé
        huyDataGridView.Visible = False
        xoa2Button.Visible = False
    End Sub

    Private Sub xoa1Button_Click(sender As Object, e As EventArgs) Handles xoa1Button.Click
        xoa_lich_su() ' xóa lịch sử 
        sua() ' hiển thị lại nội dung từ access
    End Sub

    Private Sub xoa2Button_Click(sender As Object, e As EventArgs) Handles xoa2Button.Click
        xoa_huy_ve() ' xóa hủy vé
        huyve() ' hiển thị lại nội dung từ access
    End Sub

    Private Sub suaButton_Click(sender As Object, e As EventArgs) Handles suaButton.Click
        ' hiển thị bảng các thông tin đã sửa
        suaDataGridView.Visible = True
        xoa1Button.Visible = True
        ' ngược lại ẩn bảng lịch sử hủy vé
        huyDataGridView.Visible = False
        xoa2Button.Visible = False
    End Sub

    Private Sub huyButton_Click(sender As Object, e As EventArgs) Handles huyButton.Click
        'hiển thị bảng lịch sử hủy vé
        huyDataGridView.Visible = True
        xoa2Button.Visible = True
        ' ngược lại ẩn bảng các thông tin đã sửa
        suaDataGridView.Visible = False
        xoa1Button.Visible = False
    End Sub

End Class