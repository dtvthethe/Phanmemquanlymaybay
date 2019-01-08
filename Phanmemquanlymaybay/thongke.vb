Imports System.Data.OleDb
Public Class thongke

    'khai báo kết nối
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
    Dim cmd As New OleDbCommand
    Dim cmd1 As New OleDbCommand
    Dim cmd2 As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sendid, tong, nguoi As Integer

    ' địa điểm được nhiều người lựa chọn
    Private Sub dia_diem_duoc_nhieu_nguoi_lua_chon()
        cmd.CommandText = "SELECT den, count(*) FROM data group by den"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            diadiemLabel.Text = rd("den")
        End If
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    'đọc id cho việc thống kê


    Private Sub id()

        cmd.Connection = cn
        cn.Open()
        cmd.CommandText = "select * from thongke"
        rd = cmd.ExecuteReader
        If rd.Read Then
            sendid = rd("id")
            nguoi = rd("so_luong_nguoi_dat_ve")
        End If
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    'khi người dùng click vào Xóa thì:
    Private Sub update1()
        id()
        cmd.Connection = cn
        cmd1.Connection = cn
        cmd2.Connection = cn
        cn.Open()
        cmd.CommandText = "update thongke set so_luong_nguoi_dat_ve=" & 0 & " where id =" & sendid & ""
        cmd1.CommandText = "update thongke set so_luong_nguoi_huy_ve=" & 0 & " where id =" & sendid & ""
        cmd2.CommandText = "update thongke set doanh_thu=" & 0 & " where id =" & sendid & ""
        luotnguoidatveLabel.Text = "0"
        soluothuyLabel.Text = "0"
        doanhthuLabel.Text = "0"
        cmd.ExecuteNonQuery()
        cmd1.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        cmd2.Dispose()
        cmd.Dispose()
        cmd1.Dispose()
        cn.Close()
    End Sub
    ' số lượng người đặt vé
    Private Sub so_luong_luong_dat_ve()
        cmd.CommandText = "SELECT * FROM thongke"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            luotnguoidatveLabel.Text = rd("so_luong_nguoi_dat_ve")
        End If
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    ' số lượng người hủy vé
    Private Sub so_luong_luong_huyve()
        cmd.CommandText = "SELECT * FROM thongke"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            soluothuyLabel.Text = rd("so_luong_nguoi_huy_ve")
        End If
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    ' tổng doanh thu
    Private Sub doanh_thu()
        cmd.CommandText = "SELECT * FROM thongke"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            doanhthuLabel.Text = String.Format("{0:c}", rd("doanh_thu"))
        End If
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    Private Sub thoatButton_Click(sender As Object, e As EventArgs)
        Me.Close() ' thoát
    End Sub

    Private Sub thongke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dia_diem_duoc_nhieu_nguoi_lua_chon() ' thực hiện dia_diem_duoc_nhieu_nguoi_lua_chon
        so_luong_luong_dat_ve() ' số lượng người đặt vé
        so_luong_luong_huyve() ' số lượng người hủy vé
        doanh_thu() ' doanh thu
    End Sub

    Private Sub xoaButton_Click(sender As Object, e As EventArgs) Handles xoaButton.Click
        update1() ' về số  0 trong bảng thống kê access
    End Sub
End Class