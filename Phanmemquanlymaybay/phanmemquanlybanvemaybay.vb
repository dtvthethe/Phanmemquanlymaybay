Public Class phanmemquanlybanvemaybay

    Private Sub banvechuyenbayButton_Click(sender As Object, e As EventArgs) Handles banvechuyenbayButton.Click
        banvechuyenbay.Show() ' hiển thị form banvechuyenbay
    End Sub

    Private Sub quanlychuyenbayButton_Click(sender As Object, e As EventArgs) Handles quanlychuyenbayButton.Click
        quanlychuyenbay.Show() ' hiển thị form quanlychuyenbay
    End Sub

    Private Sub thongkeButton_Click(sender As Object, e As EventArgs) Handles thongkeButton.Click
        thongke.Show() ' hiển thị form thongke
    End Sub

    Private Sub lichsuButton_Click(sender As Object, e As EventArgs) Handles lichsuButton.Click
        lichsu.Show() ' hiển thị form lichsu
    End Sub

    Private Sub managerButton_Click(sender As Object, e As EventArgs) Handles managerButton.Click
        manager.Show() ' hiển thị form manager
    End Sub

    Private Sub thongtinButton_Click(sender As Object, e As EventArgs) Handles thongtinButton.Click
        thongtin.ShowDialog() ' hiển thị form thongtin
    End Sub

    Private Sub thoatButton_Click(sender As Object, e As EventArgs) Handles thoatButton.Click
        End ' đóng tất cả các form
    End Sub

    Private Sub banvechuyenbaymenu_Click(sender As Object, e As EventArgs) Handles banvechuyenbaymenu.Click
        banvechuyenbay.Show() ' hiển thị form banvechuyenbay
    End Sub

    Private Sub quanlychuyenbaymenu_Click(sender As Object, e As EventArgs) Handles quanlychuyenbaymenu.Click
        quanlychuyenbay.Show() ' hiển thị form quanlychuyenbay
    End Sub

    Private Sub thongkemenu_Click(sender As Object, e As EventArgs) Handles thongkemenu.Click
        thongke.Show() ' hiển thị form thongke
    End Sub

    Private Sub lichsumenu_Click(sender As Object, e As EventArgs) Handles lichsumenu.Click
        lichsu.Show() ' hiển thị form lichsu
    End Sub

    Private Sub managermenu_Click(sender As Object, e As EventArgs) Handles managermenu.Click
        manager.Show() ' hiển thị form manager
    End Sub

    Private Sub ThôngTinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinToolStripMenuItem.Click
        thongtin.ShowDialog() ' hiển thị form thongtin
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        End ' đóng tất cả các form
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() 'đóng form
        dangnhap.Show() ' form đăng nhập hiển thị
    End Sub
End Class