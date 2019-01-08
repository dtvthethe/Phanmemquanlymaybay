Imports System.Data.OleDb

Public Class banvechuyenbay

    'khai báo tỷ lệ giá vé đối với các đối tượng và giá vé
    Dim ticked As Double
    Dim thongke As Integer
    Dim giave_thongke As Decimal
    Dim tong_gia_ve As Decimal
    Dim tinh_gia As Decimal
    Const VAT As Double = 0.1
    Const TRE_EM As Double = 0.75
    Const EM_BE As Double = 0.1
    Const THANH_TOAN As Decimal = 100000
    Const PHI_SAN_BAY As Decimal = 44000
    Dim treem, embe, nguoilon As Integer
    Dim result As Decimal
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\..\..\data\data.accdb")
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader

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

    'hiển thị thời gian từ access
    Private Sub time()
        cmd.CommandText = "select * from time2"
        cmd.Connection = cn
        cn.Open()
        rd = cmd.ExecuteReader
        While rd.Read()
            giokhoihanhComboBox.Items.Add(rd("timeAM"))
            giokhoihanh2ComboBox.Items.Add(rd("timeAM"))
        End While
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    'lưu vào access
    Private Sub save()
        khuhoi()
        motchieu()
        phothong()
        thuonggia()
        tietkiem()
        cmd.CommandText = "insert into data (khu_hoi, mot_chieu, di_tu, ngay_di, time1, den, ngay_ve,time2, so_ghe, tre_em, em_be, nguoi_lon, so_hieu_bay, cua_bay, gia_ve, ho_va_ten, cmnd, ngay_sinh, so_dien_thoai, tiet_kiem, pho_thong, thuong_gia, gioi_tinh, quoc_tich) values ('" & khuhoiRadioButton.Text & "','" & motchieuRadioButton.Text & "','" & dituComboBox.Text & "','" & ngaydiDateTimePicker.Text & "','" & giokhoihanhComboBox.Text + AMComboBox.Text & "','" & denComboBox.Text & "','" & ngayveDateTimePicker.Text & "','" & giokhoihanh2ComboBox.Text + AM2ComboBox.Text & "','" & sogheComboBox.Text + soghe2ComboBox.Text & "','" & treemComboBox.Text & "','" & embeComboBox.Text & "','" & nguoilonComboBox.Text & "','" & sohieubayComboBox.Text & "','" & thongtincuabayComboBox.Text & "','" & giaveLabel.Text & "','" & hovatenTextBoxn.Text & "','" & cmndTextBox.Text & "','" & ngaysinhDateTimePicker.Text & "','" & dienthoaiTextBox.Text & "','" & tietkiemRadioButton.Text & "','" & phothongRadioButton.Text & "','" & thuonggiaRadioButton.Text & "','" & gioitinhComboBox.Text & "','" & quoctichTextBox.Text & "')"
        cmd.Connection = cn
        cn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cn.Close()
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

    'tính giá vé thương gia đi từ Đà Nẵng
    Private Sub tinh_gia_ve_thuong_gia_DN()
        If nguoilonComboBox.Text = "" Or embeComboBox.Text = "" Or treemComboBox.Text = "" Then
            MessageBox.Show("Vui lòng chọn/kiểm tra lại số người lớn- trẻ em- en bé!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
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
                tinh_gia = gia_ve
                giaveLabel.Text = String.Format("{0:c}", gia_ve)
            ElseIf khuhoiRadioButton.Checked = True And phothongRadioButton.Checked = True Then
                gia_ve = (giaveLabel.Text) * 2
                tinh_gia = gia_ve
                giaveLabel.Text = String.Format("{0:c}", gia_ve)
            ElseIf khuhoiRadioButton.Checked = True And thuonggiaRadioButton.Checked = True Then
                gia_ve = (giaveLabel.Text) * 2
                tinh_gia = gia_ve
                giaveLabel.Text = String.Format("{0:c}", gia_ve)
            ElseIf motchieuRadioButton.Checked = True Then
                giaveLabel.Text = giaveLabel.Text
                tinh_gia = result
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

    'làm mới form
    Private Sub clear()
        giaveLabel.Text = ""
        hovatenTextBoxn.Text = ""
        cmndTextBox.Text = ""
        ngaysinhDateTimePicker.Text = "26 / 06 / 2013"
        ngaydiDateTimePicker.Text = "26 / 06 / 2013"
        ngayveDateTimePicker.Text = "26 / 06 / 2013"
        dienthoaiTextBox.Text = ""
        quoctichTextBox.Text = "Việt Nam"
        dituLabel1.Text = ""
        denLabel.Text = ""
    End Sub

    'đọc id cho việc thống kê
    Dim sendid As Integer
    Dim tong As Integer
    Dim nguoi As Integer
    Dim giave1 As Decimal
    Private Sub id()

        cmd.Connection = cn
        cn.Open()
        cmd.CommandText = "select * from thongke"
        rd = cmd.ExecuteReader
        If rd.Read Then
            sendid = rd("id")
            nguoi = rd("so_luong_nguoi_dat_ve")
            giave1 = rd("doanh_thu")
        End If
        rd.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    ' số người đặt vé
    Private Sub so_luong_nguoi_dat_ve()
        id()
        cmd.Connection = cn
        cn.Open()
        tong = nguoi + 1
        cmd.CommandText = "update thongke set so_luong_nguoi_dat_ve=" & tong & " where id =" & sendid & ""
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cn.Close()
    End Sub

    'ghi dữ liệu vào thống kê
    Private Sub thong_ke()
        Dim cong As Decimal
        id()
        cmd.Connection = cn
        cn.Open()
        cong = giave1 + tinh_gia
        cmd.CommandText = "update thongke set doanh_thu=" & cong & " where id =" & sendid & ""
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cn.Close()
    End Sub

    Private Sub dituComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dituComboBox.SelectedIndexChanged
        dituPictureBox.Image = My.Resources.vietnam
        dituLabel1.Text = dituComboBox.SelectedItem
        If dituComboBox.SelectedItem = "TP. Hồ Chí Minh" Then 'nếu dituComboBox chọn TP. Hồ Chí Minh thì sẽ hiển các điểm đến xuất phát từ TP. Hồ Chí Minh
            ho_chi_minh()
        ElseIf dituComboBox.SelectedItem = "Đà Nẵng" Then 'nếu dituComboBox chọn Đà Nẵng thì sẽ hiển các điểm đến xuất phát từ Đà Nẵng
            danang()
        ElseIf dituComboBox.SelectedItem = "Hà Nội" Then 'nếu dituComboBox chọn Hà Nội thì sẽ hiển các điểm đến xuất phát từ Hà Nội
            hanoi()
        End If
    End Sub

    Private Sub denComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles denComboBox.SelectedIndexChanged
        giaveLabel.Text = "" 'nếu  denComboBox = "" giaveLabel hiển thị ""
        denLabel.Text = denComboBox.SelectedItem 'nếu  denComboBox khác "" giaveLabel hiển thị bằng với denComboBox
        flags() 'hiển thị quốc kỳ tương đương
    End Sub

    Private Sub motchieuRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles motchieuRadioButton.CheckedChanged
        giaveLabel.Text = "" 'nếu  motchieuRadioButton = "" giaveLabel hiển thị ""
        If motchieuRadioButton.Checked = True Then ' nếu motchieuRadioButton không được chọn thì ẩn một số thành phần trên form
            ngayveLabel.Visible = False
            ngayveDateTimePicker.Visible = False
            Label19.Visible = False
            giokhoihanh2ComboBox.Visible = False
            AM2ComboBox.Visible = False
        Else ' nếu motchieuRadioButton được chọn thì hiển thị  một số thành phần trên form
            ngayveLabel.Visible = True
            ngayveDateTimePicker.Visible = True
            Label19.Visible = True
            giokhoihanh2ComboBox.Visible = True
            AM2ComboBox.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles luuButton.Click
        save() ' lưu giá thông tin vào access
        so_luong_nguoi_dat_ve() ' lưu giá trị vào thống kê
        thong_ke() ' lưu giá trị vào thống kê
        MessageBox.Show("Thông tin đã được lưu", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.None) 'hiển thị thông báo khi thông tin đã được lưu
        clear() ' làm mới form
    End Sub

    Private Sub tietkiemRadioButton_CheckedChanged(sender As Object, e As EventArgs)
        giaveLabel.Text = "" ' nếu tietkiemRadioButton thay đổi thì giaveLabel sẽ không hiển thị
    End Sub

    Private Sub phothongRadioButton_CheckedChanged(sender As Object, e As EventArgs)
        giaveLabel.Text = ""  ' nếu phothongRadioButton thay đổi thì giaveLabel sẽ không hiển thị
    End Sub

    Private Sub thuonggiaRadioButton_CheckedChanged(sender As Object, e As EventArgs)
        giaveLabel.Text = "" ' nếu thuonggiaRadioButton thay đổi thì giaveLabel sẽ không hiển thị
    End Sub

    Private Sub khuhoiRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles khuhoiRadioButton.CheckedChanged
        giaveLabel.Text = "" ' nếu thuonggiaRadioButton thay đổi thì giaveLabel sẽ không hiển thị
    End Sub

    Private Sub thoatButton_Click(sender As Object, e As EventArgs) Handles thoatButton.Click
        phanmemquanlybanvemaybay.Show() 'hiển thị form phanmemquanlybanvemaybay
        Me.Close() ' thoát khỏi form hiện tại
    End Sub

    Private Sub banvechuyenbay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time() 'khi form load thì lấy thời gian bay từ access
        quoctichTextBox.Text = "Việt Nam" ' Khi form load hiện Việt Nam
    End Sub

    Private Sub tietkiemRadioButton_CheckedChanged_1(sender As Object, e As EventArgs) Handles tietkiemRadioButton.CheckedChanged
        tinh_gia_ve() 'khi tietkiemRadioButton thay đổi thì tính giá vé
        check() 'tính giá vé trong các trường hợp
    End Sub

    Private Sub phothongRadioButton_CheckedChanged_1(sender As Object, e As EventArgs) Handles phothongRadioButton.CheckedChanged
        tinh_gia_ve() 'khi phothongRadioButton thay đổi thì tính giá vé
        check() 'tính giá vé trong các trường hợp
    End Sub

    Private Sub thuonggiaRadioButton_CheckedChanged_1(sender As Object, e As EventArgs) Handles thuonggiaRadioButton.CheckedChanged
        tinh_gia_ve() 'khi thuonggiaRadioButton thay đổi thì tính giá vé
        check() 'tính giá vé trong các trường hợp
    End Sub

End Class