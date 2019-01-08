Imports System.Data.OleDb
Public Class thongtin_khachhang

    'khai báo kết nối
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader

    'lấy id khi lựa chọn trên DataGridView và hiển thị dữ liệu tương đương
    Sub New(selectedId As String)
        InitializeComponent()
        cmd.CommandText = "SELECT * FROM data WHERE (((data.Id)=" & selectedId & "))"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        Dim a, b, c, d As String
        If rd.Read Then
            hovaten.Text = rd("ho_va_ten")
            cmnd.Text = rd("cmnd")
            ditu.Text = rd("di_tu")
            den.Text = rd("den")
            treem.Text = rd("tre_em")
            embe.Text = rd("em_be")
            namsinh.Text = rd("ngay_sinh")
            nguoilon.Text = rd("nguoi_lon")
            sohieubay.Text = rd("so_hieu_bay")
            thongtincuabay.Text = rd("cua_bay")
            sdt.Text = rd("so_dien_thoai")
            gioitinh.Text = rd("gioi_tinh")
            quoctich.Text = rd("quoc_tich")
            time1lable.Text = rd("time1")
            time2lable.Text = rd("time2")
            soghe.Text = rd("so_ghe")
            ngaydi.Text = rd("ngay_di")
            ngayve.Text = rd("ngay_ve")
            giaveLabel.Text = rd("gia_ve")
            a = rd("khu_hoi")
            b = rd("tiet_kiem")
            c = rd("pho_thong")
            d = rd("thuong_gia")
            If a = "0" Then
                loaive1.Text = "Khứ hồi"
                ngayve.Visible = True
                ngayveLabel.Visible = True
                Label19.Visible = True
                time2lable.Visible = True
            ElseIf a = " " Then
                loaive1.Text = "Một chiều"
                ngayve.Visible = False
                ngayveLabel.Visible = False
                Label19.Visible = False
                time2lable.Visible = False
            End If
            If b = "2" Then
                loaive.Text = "Tiết kiệm linh hoạt"
            ElseIf c = "3" Then
                loaive.Text = "Phổ thông linh hoạt"
            ElseIf d = "4" Then
                loaive.Text = "Thương gia linh hoạt"
            End If
        End If
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub


    Private Sub dongButton_Click(sender As Object, e As EventArgs)
        Me.Close() ' thoát
    End Sub

End Class