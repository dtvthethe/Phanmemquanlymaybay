Imports System.Data.OleDb
Public Class sua

    'khai báo tỷ lệ giá vé đối với các đối tượng , giá vé và id
    Private id As String
    Dim thongke As Integer
    Dim giave_thongke As Decimal
    Dim tong_gia_ve As Decimal
    Private user As String = phanmemquanlybanvemaybay.userLabel.Text
    Dim ticked As Double
    Const VAT As Double = 0.1
    Const TRE_EM As Double = 0.75
    Const EM_BE As Double = 0.1
    Const THANH_TOAN As Decimal = 100000
    Const PHI_SAN_BAY As Decimal = 44000
    Dim treem, embe, nguoilon As Integer
    Dim result As Decimal
    ' khai báo đọc lưu dữ liệu
    Dim di_tu, ngay_di, ho_va_ten, giodi, den2, so_dien_thoai, cmnd1, quoc_tich, nguoi_dung As String

    ' khai báo kết nối
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader

    'lấy id từ form banvechuyenbay và hiển thị lên thông tin khách hàng
    Sub New(selectedId As String)
        InitializeComponent()
        id = selectedId
        cmd.CommandText = "SELECT * FROM data WHERE (((data.Id)=" & selectedId & "))"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        Dim a, b, c, d As String
        If rd.Read Then
            hovatenTextBoxn.Text = rd("ho_va_ten")
            cmndTextBox.Text = rd("cmnd")
            dituComboBox.Text = rd("di_tu")
            denComboBox.Text = rd("den")
            treemComboBox.Text = rd("tre_em")
            embeComboBox.Text = rd("em_be")
            nguoilonComboBox.Text = rd("nguoi_lon")
            sohieubayComboBox.Text = rd("so_hieu_bay")
            thongtincuabayComboBox.Text = rd("cua_bay")
            dienthoaiTextBox.Text = rd("so_dien_thoai")
            gioitinhComboBox.Text = rd("gioi_tinh")
            quoctichTextBox.Text = rd("quoc_tich")
            time1.Text = rd("time1")
            di_tu = rd("di_tu")
            ngay_di = rd("di_tu")
            ho_va_ten = rd("ho_va_ten")
            giodi = rd("time1")
            den2 = rd("den")
            so_dien_thoai = rd("so_dien_thoai")
            cmnd1 = rd("cmnd")
            quoc_tich = rd("quoc_tich")
            nguoi_dung = user
            giaveLabel.Text = rd("gia_ve")
            a = rd("khu_hoi")
            b = rd("tiet_kiem")
            c = rd("pho_thong")
            d = rd("thuong_gia")
            If a = "0" Then
                khuhoiRadioButton.Checked = True
                motchieuRadioButton.Checked = False
            ElseIf a = " " Then

                khuhoiRadioButton.Checked = False
                motchieuRadioButton.Checked = True
            End If
            If b = "2" Then
                tietkiemRadioButton.Checked = True
                phothongRadioButton.Checked = False
                thuonggiaRadioButton.Checked = False
            ElseIf c = "3" Then
                tietkiemRadioButton.Checked = False
                phothongRadioButton.Checked = True
                thuonggiaRadioButton.Checked = False
            ElseIf d = "4" Then
                tietkiemRadioButton.Checked = False
                phothongRadioButton.Checked = False
                thuonggiaRadioButton.Checked = True
            End If
        End If
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    'tính giá vé
    Private Sub giave()
        nguoilon = nguoilonComboBox.Text
        embe = embeComboBox.Text
        treem = treemComboBox.Text
        result = (ticked * VAT) + PHI_SAN_BAY + THANH_TOAN + (ticked * nguoilon) + ((ticked * TRE_EM) * treem) + ((ticked * EM_BE) * embe)
        giaveLabel.Text = String.Format("{0:C}", result)
    End Sub

    'hiển thị địa điểm ho_chi_minh từ access
    Private Sub ho_chi_minh()
        denComboBox.Items.Clear()
        Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
        Dim cmd As New OleDbCommand
        Dim rd As OleDbDataReader
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
        Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
        Dim cmd As New OleDbCommand
        Dim rd As OleDbDataReader
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
        Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
        Dim cmd As New OleDbCommand
        Dim rd As OleDbDataReader
        cmd.CommandText = "select den from danang"
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

    'nếu khuhoiRadioButton được chọn thì giá trị của khứ hồi là 0 ngược lại giá trị sẽ là ""
    Private Sub khuhoi()
        If khuhoiRadioButton.Checked = True Then
            khuhoiRadioButton.Text = "0"
        Else
            khuhoiRadioButton.Text = " "
        End If
    End Sub

    'nếu motchieuRadioButton được chọn thì giá trị của khứ hồi là 1 ngược lại giá trị sẽ là ""
    Private Sub motchieu()
        If motchieuRadioButton.Checked = True Then
            motchieuRadioButton.Text = "1"
        Else
            motchieuRadioButton.Text = " "
        End If
    End Sub

    'nếu thuonggiaRadioButton được chọn thì giá trị của khứ hồi là 4 ngược lại giá trị sẽ là ""
    Private Sub thuonggia()
        If thuonggiaRadioButton.Checked = True Then
            thuonggiaRadioButton.Text = "4"
        Else
            thuonggiaRadioButton.Text = " "
        End If
    End Sub

    'nếu phothongRadioButton được chọn thì giá trị của khứ hồi là 3 ngược lại giá trị sẽ là ""
    Private Sub phothong()
        If phothongRadioButton.Checked = True Then
            phothongRadioButton.Text = "3"
        Else
            phothongRadioButton.Text = " "
        End If
    End Sub
    'nếu phothongRadioButton được chọn thì giá trị của khứ hồi là 3 ngược lại giá trị sẽ là ""
    Private Sub tietkiem()

        If tietkiemRadioButton.Checked = True Then
            tietkiemRadioButton.Text = "2"
        Else
            tietkiemRadioButton.Text = " "
        End If
    End Sub

    ' hiển thị quốc kỳ tương đương các địa điểm được chọn
    Private Sub flags()
        Select Case denComboBox.SelectedItem
            Case Is = "Buôn Ma Thuột (BMV)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Chu Lai (VCL)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Cà Mau (CAH)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Côn Đảo (VCS)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Cần Thơ (VCA)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Huế (HUI)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Hà Nội (HAN)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Hải Phòng (HPH)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Nha Trang (NHA)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Phú Quốc (PQC)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Pleiku (PXU)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Quy Nhơn (UIH)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Rạch Giá (VKG)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Thanh Hóa (THD)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Tp Hồ Chí Minh (SGN)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Tuy Hòa (TBB)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Vinh (VII)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Điện Biên (DIN)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Đà Lạt (DLI)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Đà Nẵng (DAD)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "Đồng Hới (VDH)"
                denPictureBox.Image = My.Resources.vietnam
            Case Is = "London (LON)"
                denPictureBox.Image = My.Resources.anh
            Case Is = "Melbourne (MEL)"
                denPictureBox.Image = My.Resources.australia
            Case Is = "Sydney (SYD)"
                denPictureBox.Image = My.Resources.australia
            Case Is = "Amsterdam (AMS)"
                denPictureBox.Image = My.Resources.halan
            Case Is = "Barcelona (BCN)"
                denPictureBox.Image = My.Resources.tbn
            Case Is = "Frankfurt (FRA)"
                denPictureBox.Image = My.Resources.duc
            Case Is = "Moscow (MOW)"
                denPictureBox.Image = My.Resources.nga
            Case Is = "Nice (NCE)"
                denPictureBox.Image = My.Resources.phap
            Case Is = "Paris (PAR)"
                denPictureBox.Image = My.Resources.phap
            Case Is = "Prague (PRG)"
                denPictureBox.Image = My.Resources.sec
            Case Is = "Rome (ROM)"
                denPictureBox.Image = My.Resources.y
            Case Is = "Luang Prabang (LPQ)"
                denPictureBox.Image = My.Resources.lao
            Case Is = "Vientiane (VTE)"
                denPictureBox.Image = My.Resources.lao
            Case Is = "Phnom Penh (PNH)"
                denPictureBox.Image = My.Resources.cpc
            Case Is = "Siem Riep (REP)"
                denPictureBox.Image = My.Resources.cpc
            Case Is = "Beijing (BJS)"
                denPictureBox.Image = My.Resources.cn
            Case Is = "Busan (PUS)"
                denPictureBox.Image = My.Resources.hanquoc
            Case Is = "Chengdu (CTU)"
                denPictureBox.Image = My.Resources.cn
            Case Is = "Fukuoka (FUK)"
                denPictureBox.Image = My.Resources.nhatban
            Case Is = "Guangzhou (CAN)"
                denPictureBox.Image = My.Resources.cn
            Case Is = "Hong Kong (HKG)"
                denPictureBox.Image = My.Resources.cn
            Case Is = "Kaohsiung (KHH)"
                denPictureBox.Image = My.Resources.cn
            Case Is = "Nagoya (NGO)"
                denPictureBox.Image = My.Resources.nhatban
            Case Is = "Osaka (OSA)"
                denPictureBox.Image = My.Resources.nhatban
            Case Is = "Seoul (SEL)"
                denPictureBox.Image = My.Resources.hanquoc
            Case Is = "Shanghai (SHA)"
                denPictureBox.Image = My.Resources.cn
            Case Is = "Taipei (TPE)"
                denPictureBox.Image = My.Resources.cn
            Case Is = "Tokyo (TYO)"
                denPictureBox.Image = My.Resources.nhatban
            Case Is = "Bangkok (BKK)"
                denPictureBox.Image = My.Resources.thailan
            Case Is = "Jakarta (JKT)"
                denPictureBox.Image = My.Resources.ind
            Case Is = "Kuala Lumpur (KUL)"
                denPictureBox.Image = My.Resources.mala
            Case Is = "Manila (MNL)"
                denPictureBox.Image = My.Resources.philip
            Case Is = "Singapore (SIN)"
                denPictureBox.Image = My.Resources.sigapore
            Case Is = "Yangon (RGN)"
                denPictureBox.Image = My.Resources.myanma
            Case Is = "Atlanta Hartsfield (ATL)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Austin (AUS)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Boston, Logan (BOS)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Chicago IL (CHI)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Dallas Fort Worth (DFW)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Denver (DEN)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Honolulu (HNL)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Los Angeles (LAX)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Miami (MIA)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Minneapolis/St.Paul (MSP)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Philadelphia (PHL)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Portland (PDX)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "San Francisco (SFO)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Seattle, Tacoma (SEA)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "St Louis, Lambert (STL)"
                denPictureBox.Image = My.Resources.my2
            Case Is = "Washington (WAS)"
                denPictureBox.Image = My.Resources.my2
        End Select

    End Sub

    Private Sub denComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles denComboBox.SelectedIndexChanged
        giaveLabel.Text = ""
        denLabel.Text = denComboBox.SelectedItem ' giá trị của denLabel = denComboBox được chọn
        flags() 'hiển thị quốc kỳ tương đương
    End Sub

    ' xóa:
    Private Sub xoa()
        cmd.Connection = cn
        cn.Open()
        If hovatenTextBoxn.Text <> "" Then
            cmd.CommandText = "delete from data where  ho_vaten=('" & hovatenTextBoxn.Text & "')"
            cmd.ExecuteNonQuery()
        End If
        cmd.Dispose()
        cn.Close()
    End Sub

    ' sửa
    Private Sub sua()
        cmd.Connection = cn
        cn.Open()
        MessageBox.Show("Bạn chắc chắn muốn thay đổi thông tin của hành khách " + ho_va_ten & "!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If hovatenTextBoxn.Text <> "" Then
            cmd.CommandText = "update data set ho_va_ten='" & hovatenTextBoxn.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If cmndTextBox.Text <> "" Then
            cmd.CommandText = "update data set cmnd='" & cmndTextBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If dienthoaiTextBox.Text <> "" Then
            cmd.CommandText = "update data set so_dien_thoai='" & dienthoaiTextBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If quoctichTextBox.Text <> "" Then
            cmd.CommandText = "update data set quoc_tich='" & quoctichTextBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If gioitinhComboBox.Text <> "" Then
            cmd.CommandText = "update data set gioi_tinh='" & gioitinhComboBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If ngaysinhDateTimePicker.Text <> "" Then
            cmd.CommandText = "update data set ngay_sinh='" & ngaysinhDateTimePicker.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If dituComboBox.Text <> "" Then
            cmd.CommandText = "update data set di_tu='" & dituComboBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If denComboBox.Text <> "" Then
            cmd.CommandText = "update data set den='" & denComboBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If ngaydiDateTimePicker.Text <> "" Then
            cmd.CommandText = "update data set ngay_di='" & ngaydiDateTimePicker.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If ngayveDateTimePicker.Text <> "" Then
            cmd.CommandText = "update data set ngay_ve='" & ngayveDateTimePicker.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If giokhoihanhComboBox.Text <> "" Then
            cmd.CommandText = "update data set time1='" & giokhoihanhComboBox.Text + AMComboBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If giokhoihanh2ComboBox.Text <> "" Then
            cmd.CommandText = "update data set time2='" & giokhoihanh2ComboBox.Text + AM2ComboBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If sogheComboBox.Text <> "" Then
            cmd.CommandText = "update data set so_ghe='" & sogheComboBox.Text + soghe2ComboBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If treemComboBox.Text <> "" Then
            cmd.CommandText = "update data set tre_em='" & treemComboBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If embeComboBox.Text <> "" Then
            cmd.CommandText = "update data set em_be='" & embeComboBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If nguoilonComboBox.Text <> "" Then
            cmd.CommandText = "update data set nguoi_lon='" & nguoilonComboBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If sohieubayComboBox.Text <> "" Then
            cmd.CommandText = "update data set so_hieu_bay='" & sohieubayComboBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        If thongtincuabayComboBox.Text <> "" Then
            cmd.CommandText = "update data set cua_bay='" & thongtincuabayComboBox.Text & "' where id =" & id & ""
            cmd.ExecuteNonQuery()
        End If
        cmd.Dispose()
        cn.Close()
    End Sub

    'tính giá vé thương gia đi từ Đà Nẵng
    Private Sub tinh_gia_ve_thuong_gia_DN()
        If nguoilonComboBox.Text = "" Or embeComboBox.Text = "" Or treemComboBox.Text = "" Then
            MessageBox.Show("Vui lòng chọn/kiểm tra lại số người lớn- trẻ em- en bé!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
            Dim cmd As New OleDbCommand
            Dim rd As OleDbDataReader
            cmd.CommandText = "SELECT danang.den, danang.thuong_gia FROM danang WHERE (((danang.den)='" & denComboBox.SelectedItem & "'))"
            cmd.Connection = cn
            cn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                ticked = rd("thuong_gia")
                If ticked = "0" Then
                    giaveLabel.Text = "Bổ sung thêm hạng này!"
                Else
                    giave()
                End If
            End If
            rd.Close()
            cmd.Dispose()
            cn.Close()
        End If
    End Sub

    'tính giá vé Phổ thông đi từ Đà Nẵng
    Private Sub tinh_gia_ve_pho_thong_DN()
        If nguoilonComboBox.Text = "" Or embeComboBox.Text = "" Or treemComboBox.Text = "" Then
            MessageBox.Show("Vui lòng chọn/kiểm tra lại số người lớn- trẻ em- en bé!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
            Dim cmd As New OleDbCommand
            Dim rd As OleDbDataReader
            cmd.CommandText = "SELECT danang.den, danang.pho_thong FROM danang WHERE (((danang.den)='" & denComboBox.SelectedItem & "'))"
            cmd.Connection = cn
            cn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                ticked = rd("pho_thong")
                If ticked = "0" Then
                    giaveLabel.Text = "Bổ sung thêm hạng này!"
                Else
                    giave()
                End If
            End If
            rd.Close()
            cmd.Dispose()
            cn.Close()
        End If
    End Sub

    'tính giá vé tiết kiệm đi từ Đà Nẵng
    Private Sub tinh_gia_ve_tiet_kiem_DN()
        If nguoilonComboBox.Text = "" Or embeComboBox.Text = "" Or treemComboBox.Text = "" Then
            MessageBox.Show("Vui lòng chọn/kiểm tra lại số người lớn- trẻ em- en bé!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
            Dim cmd As New OleDbCommand
            Dim rd As OleDbDataReader
            cmd.CommandText = "SELECT danang.den, danang.tiet_kiem FROM danang WHERE (((danang.den)='" & denComboBox.SelectedItem & "'))"
            cmd.Connection = cn
            cn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                ticked = rd("tiet_kiem")
                If ticked = "0" Then
                    giaveLabel.Text = "Bổ sung thêm hạng này!"
                Else
                    giave()
                End If
            End If
            rd.Close()
            cmd.Dispose()
            cn.Close()
        End If
    End Sub

    'tính giá vé thương gia đi từ Hà Nội
    Private Sub tinh_gia_ve_thuong_gia_HN()
        If nguoilonComboBox.Text = "" Or embeComboBox.Text = "" Or treemComboBox.Text = "" Then
            MessageBox.Show("Vui lòng chọn/kiểm tra lại số người lớn- trẻ em- en bé!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
            Dim cmd As New OleDbCommand
            Dim rd As OleDbDataReader
            cmd.CommandText = "SELECT hanoi.den, hanoi.thuong_gia FROM hanoi WHERE (((hanoi.den)='" & denComboBox.SelectedItem & "'))"
            cmd.Connection = cn
            cn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then

                ticked = rd("thuong_gia")
                If ticked = "0" Then
                    giaveLabel.Text = "Bổ sung thêm hạng này!"
                Else
                    giave()
                End If
            End If
            rd.Close()
            cmd.Dispose()
            cn.Close()
        End If
    End Sub

    'tính giá vé phổ thông đi từ Hà Nội
    Private Sub tinh_gia_ve_pho_thong_HN()
        If nguoilonComboBox.Text = "" Or embeComboBox.Text = "" Or treemComboBox.Text = "" Then
            MessageBox.Show("Vui lòng chọn/kiểm tra lại số người lớn- trẻ em- en bé!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
            Dim cmd As New OleDbCommand
            Dim rd As OleDbDataReader
            cmd.CommandText = "SELECT hanoi.den, hanoi.pho_thong FROM hanoi WHERE (((hanoi.den)='" & denComboBox.SelectedItem & "'))"
            cmd.Connection = cn
            cn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                ticked = rd("pho_thong")
                If ticked = "0" Then
                    giaveLabel.Text = "Bổ sung thêm hạng này!"
                Else
                    giave()
                End If
            End If
            rd.Close()
            cmd.Dispose()
            cn.Close()
        End If
    End Sub

    'tính giá vé tiết kiệm đi từ Hà Nội
    Private Sub tinh_gia_ve_tiet_kiem_HN()
        If nguoilonComboBox.Text = "" Or embeComboBox.Text = "" Or treemComboBox.Text = "" Then
            MessageBox.Show("Vui lòng chọn/kiểm tra lại số người lớn- trẻ em- en bé!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
            Dim cmd As New OleDbCommand
            Dim rd As OleDbDataReader
            cmd.CommandText = "SELECT hanoi.den, hanoi.tiet_kiem FROM hanoi WHERE (((hanoi.den)='" & denComboBox.SelectedItem & "'))"
            cmd.Connection = cn
            cn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                ticked = rd("tiet_kiem")
                If ticked = "0" Then
                    giaveLabel.Text = "Bổ sung thêm hạng này!"
                Else
                    giave()
                End If
            End If
            rd.Close()
            cmd.Dispose()
            cn.Close()
        End If
    End Sub

    'tính giá vé thương gia đi từ Hồ Chí Minh
    Private Sub tinh_gia_ve_thuong_gia_HCM()
        If nguoilonComboBox.Text = "" Or embeComboBox.Text = "" Or treemComboBox.Text = "" Then
            MessageBox.Show("Vui lòng chọn/kiểm tra lại số người lớn- trẻ em- en bé!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
            Dim cmd As New OleDbCommand
            Dim rd As OleDbDataReader
            cmd.CommandText = "SELECT saigon.den, saigon.thuong_gia FROM saigon WHERE (((saigon.den)='" & denComboBox.SelectedItem & "'))"
            cmd.Connection = cn
            cn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                ticked = rd("thuong_gia")
                If ticked = "0" Then
                    giaveLabel.Text = "Bổ sung thêm hạng này!"
                Else
                    giave()
                End If
            End If
            rd.Close()
            cmd.Dispose()
            cn.Close()
        End If
    End Sub

    'tính giá vé phổ thông đi từ Hồ Chí Minh
    Private Sub tinh_gia_ve_pho_thong_HCM()
        If nguoilonComboBox.Text = "" Or embeComboBox.Text = "" Or treemComboBox.Text = "" Then
            MessageBox.Show("Vui lòng chọn/kiểm tra lại số người lớn- trẻ em- en bé!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
            Dim cmd As New OleDbCommand
            Dim rd As OleDbDataReader
            cmd.CommandText = "SELECT saigon.den, saigon.pho_thong FROM saigon WHERE (((saigon.den)='" & denComboBox.SelectedItem & "'))"
            cmd.Connection = cn
            cn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                ticked = rd("pho_thong")
                If ticked = "0" Then
                    giaveLabel.Text = "Bổ sung thêm hạng này!"
                Else
                    giave()
                End If
            End If
            rd.Close()
            cmd.Dispose()
            cn.Close()
        End If
    End Sub

    'tính giá vé tiết kiệm đi từ Hồ Chí Minh
    Private Sub tinh_gia_ve_tiet_kiem_HCM()
        If nguoilonComboBox.Text = "" Or embeComboBox.Text = "" Or treemComboBox.Text = "" Then
            MessageBox.Show("Vui lòng chọn/kiểm tra lại số người lớn- trẻ em- en bé!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
            Dim cmd As New OleDbCommand
            Dim rd As OleDbDataReader
            cmd.CommandText = "SELECT saigon.den, saigon.tiet_kiem FROM saigon WHERE (((saigon.den)='" & denComboBox.SelectedItem & "'))"
            cmd.Connection = cn
            cn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                ticked = rd("tiet_kiem")
                If ticked = "0" Then
                    giaveLabel.Text = "Bổ sung thêm hạng này!"
                Else
                    giave()
                End If
            End If
            rd.Close()
            cmd.Dispose()
            cn.Close()
        End If
    End Sub

    'nếu là loại vé khứ hồi thì nhân cho 2
    Private Sub tinh_gia_ve()
        Try
            Dim gia_ve As Double
            If khuhoiRadioButton.Checked = True And tietkiemRadioButton.Checked = True Then
                gia_ve = (giaveLabel.Text) * 2
                giaveLabel.Text = String.Format("{0:c}", gia_ve)
            ElseIf khuhoiRadioButton.Checked = True And phothongRadioButton.Checked = True Then
                gia_ve = (giaveLabel.Text) * 2
                giaveLabel.Text = String.Format("{0:c}", gia_ve)
            ElseIf khuhoiRadioButton.Checked = True And thuonggiaRadioButton.Checked = True Then
                gia_ve = (giaveLabel.Text) * 2
                giaveLabel.Text = String.Format("{0:c}", gia_ve)
            ElseIf motchieuRadioButton.Checked = True Then
                giaveLabel.Text = giaveLabel.Text
            End If
        Catch ex As Exception

        End Try
    End Sub
    'tính giá vé cho các trường hợp
    Private Sub check()
        If dituComboBox.SelectedItem = "TP. Hồ Chí Minh" And thuonggiaRadioButton.Checked = True Then
            tinh_gia_ve_thuong_gia_HCM()
        ElseIf dituComboBox.SelectedItem = "TP. Hồ Chí Minh" And phothongRadioButton.Checked = True Then
            tinh_gia_ve_pho_thong_HCM()
        ElseIf dituComboBox.SelectedItem = "TP. Hồ Chí Minh" And tietkiemRadioButton.Checked = True Then
            tinh_gia_ve_tiet_kiem_HCM()
        ElseIf dituComboBox.SelectedItem = "Đà Nẵng" And phothongRadioButton.Checked = True Then
            tinh_gia_ve_pho_thong_DN()
        ElseIf dituComboBox.SelectedItem = "Đà Nẵng" And tietkiemRadioButton.Checked = True Then
            tinh_gia_ve_tiet_kiem_DN()
        ElseIf dituComboBox.SelectedItem = "Đà Nẵng" And thuonggiaRadioButton.Checked = True Then
            tinh_gia_ve_thuong_gia_DN()
        ElseIf dituComboBox.SelectedItem = "Hà Nội" And thuonggiaRadioButton.Checked = True Then
            tinh_gia_ve_thuong_gia_HN()
        ElseIf dituComboBox.SelectedItem = "Hà Nội" And phothongRadioButton.Checked = True Then
            tinh_gia_ve_pho_thong_HN()
        ElseIf dituComboBox.SelectedItem = "Hà Nội" And tietkiemRadioButton.Checked = True Then
            tinh_gia_ve_tiet_kiem_HN()
        End If
        tinh_gia_ve()
    End Sub

    'lấy id 
    Private Sub doc_thong_ke()
        Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
        Dim cmd As New OleDbCommand
        Dim rd As OleDbDataReader
        cmd.CommandText = "select * from thongke "
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            thongke = rd("id")
            giave_thongke = rd("gia")
        End If
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub


    ' lưu giá vé để hiển thị lên form thống kê
    Private Sub thong_ke()

        Dim nhan As Decimal
        doc_thong_ke()
        cmd.Connection = cn
        cn.Open()
        If khuhoiRadioButton.Checked = True And giave_thongke = "0" Then
            nhan = result * 2
            cmd.CommandText = "insert into  thongke (gia) values (" & nhan & ")"
        ElseIf giave_thongke = "0" Then

            cmd.CommandText = "insert into  thongke (gia) values (" & result & ")"
        Else
            tong_gia_ve = giave_thongke + result
            cmd.CommandText = "update thongke set gia=" & tong_gia_ve & " where id = " & thongke & ""
        End If
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cn.Close()
    End Sub

    'làm mới form
    Private Sub clear()
        giaveLabel.Text = ""
        hovatenTextBoxn.Text = ""
        cmndTextBox.Text = ""
        ngaysinhDateTimePicker.Text = "26 / 06 / 2013"
        ngaydiDateTimePicker.Text = "26 / 06 / 2013"
        ngayveDateTimePicker.Text = "26 / 06 / 2013"
        dienthoaiTextBox.Text = ""
        quoctichTextBox.Text = ""
        dituLabel1.Text = ""
        denLabel.Text = ""
    End Sub

    'hiển thị dữ liệu lên lable từ access
    Private Sub read()
        cmd.CommandText = "select * from data"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            giokhoihanh1Label.Text = rd("time1")
            giokhoihanh2Label.Text = rd("time2")
            sogheLabel.Text = rd("so_ghe")
        End While
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    ' hiển thị thời gian
    Private Sub reader()
        cmd.CommandText = "select * from time2"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            giokhoihanhComboBox.Items.Add(rd("timeAM"))
            giokhoihanh2ComboBox.Items.Add(rd("timeAM"))
        End While
        cmd.Dispose()
        rd.Close()
        cn.Close()
    End Sub

    'lưu dữ liệu vào lịch sử
    Private Sub coppy()
        cmd.CommandText = "insert into  lichsu (di_tu, ngay_di, time1, den, ho_va_ten, cmnd, so_dien_thoai, quoc_tich, nguoi_dung) values ('" & di_tu & "','" & ngay_di & "','" & giodi & "','" & den2 & "','" & ho_va_ten & "','" & cmnd1 & "','" & so_dien_thoai & "','" & quoc_tich & "','" & nguoi_dung & "')"
        cmd.Connection = cn
        cn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cn.Close()
    End Sub

    Private Sub dituComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dituComboBox.SelectedIndexChanged
        If dituComboBox.SelectedItem = "TP. Hồ Chí Minh" Then 'nếu dituComboBox chọn TP. Hồ Chí Minh thì sẽ hiển các điểm đến xuất phát từ TP. Hồ Chí Minh
            ho_chi_minh()
        ElseIf dituComboBox.SelectedItem = "Đà Nẵng" Then 'nếu dituComboBox chọn Đà Nẵng thì sẽ hiển các điểm đến xuất phát từ Đà Nẵng
            danang()
        ElseIf dituComboBox.SelectedItem = "Hà Nội" Then 'nếu dituComboBox chọn Hà Nội thì sẽ hiển các điểm đến xuất phát từ Hà Nội
            hanoi()
        End If
        dituPictureBox.Image = My.Resources.vietnam ' hiển thị quốc kỳ tương đương
        dituLabel1.Text = dituComboBox.SelectedItem ' hiển thị = giá trị dituComboBox
    End Sub

    Private Sub sua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        read() ' thực hiện read
        reader() ' thực hiện reader
    End Sub


    Private Sub tietkiemRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles tietkiemRadioButton.CheckedChanged
        tinh_gia_ve() ' thực hiện tinh_gia_ve
        check() ' thực hiện check
    End Sub

    Private Sub phothongRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles phothongRadioButton.CheckedChanged
        tinh_gia_ve() ' thực hiện tinh_gia_ve
        check() ' thực hiện check
    End Sub

    Private Sub thuonggiaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles thuonggiaRadioButton.CheckedChanged
        tinh_gia_ve() ' thực hiện tinh_gia_ve
        check() ' thực hiện check
    End Sub

    Private Sub khuhoiRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles khuhoiRadioButton.CheckedChanged
        tinh_gia_ve() ' thực hiện tinh_gia_ve
        check() ' thực hiện check
    End Sub

    Private Sub motchieuRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles motchieuRadioButton.CheckedChanged
        giaveLabel.Text = "" 'nếu  motchieuRadioButton = "" giaveLabel hiển thị ""
        If motchieuRadioButton.Checked = True Then ' nếu motchieuRadioButton không được chọn thì ẩn một số thành phần trên form
            ngayveLabel.Visible = False
            ngayveDateTimePicker.Visible = False
            Label19.Visible = False
            giokhoihanh2ComboBox.Visible = False
            AM2ComboBox.Visible = False
            giokhoihanh2Label.Visible = False
        Else ' nếu motchieuRadioButton được chọn thì hiển thị  một số thành phần trên form
            ngayveLabel.Visible = True
            ngayveDateTimePicker.Visible = True
            Label19.Visible = True
            giokhoihanh2ComboBox.Visible = True
            AM2ComboBox.Visible = True
            giokhoihanh2Label.Visible = True
        End If
    End Sub


    Private Sub sua2Button_Click(sender As Object, e As EventArgs) Handles sua2Button.Click
        coppy() ' thực hiện coppy

        sua() ' thực hiện sua
        clear() ' thực hiện clear
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() ' thoát
    End Sub

End Class