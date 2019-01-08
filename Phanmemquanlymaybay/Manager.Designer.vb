<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manager))
        Me.dituComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.denComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tietkiemTextBox = New System.Windows.Forms.TextBox()
        Me.phothongTextBox = New System.Windows.Forms.TextBox()
        Me.thuonggiaTextBox = New System.Windows.Forms.TextBox()
        Me.tietkiemLabel = New System.Windows.Forms.Label()
        Me.phothongLabel = New System.Windows.Forms.Label()
        Me.thuonggiaLabel = New System.Windows.Forms.Label()
        Me.suaButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.luuButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.hienthiButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.xoaButton1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.showCheckBox = New System.Windows.Forms.CheckBox()
        Me.suaButton2 = New System.Windows.Forms.Button()
        Me.taikhoanLabel = New System.Windows.Forms.Label()
        Me.matkhauTextBox1 = New System.Windows.Forms.TextBox()
        Me.themButton1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.adminRadioButton = New System.Windows.Forms.RadioButton()
        Me.nhanvienRadioButton = New System.Windows.Forms.RadioButton()
        Me.matkhauTextBox = New System.Windows.Forms.TextBox()
        Me.tendangnhapTextBox = New System.Windows.Forms.TextBox()
        Me.xoaButton = New System.Windows.Forms.Button()
        Me.suaButton1 = New System.Windows.Forms.Button()
        Me.themButton = New System.Windows.Forms.Button()
        Me.taikhoanListBox = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.taikhoanComboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dituComboBox
        '
        Me.dituComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dituComboBox.FormattingEnabled = True
        Me.dituComboBox.Items.AddRange(New Object() {"Hà Nội", "Đà Nẵng", "TP. Hồ Chí Minh"})
        Me.dituComboBox.Location = New System.Drawing.Point(63, 33)
        Me.dituComboBox.Name = "dituComboBox"
        Me.dituComboBox.Size = New System.Drawing.Size(121, 23)
        Me.dituComboBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(25, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Đi từ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(25, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Đến:"
        '
        'denComboBox
        '
        Me.denComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.denComboBox.FormattingEnabled = True
        Me.denComboBox.Location = New System.Drawing.Point(63, 89)
        Me.denComboBox.Name = "denComboBox"
        Me.denComboBox.Size = New System.Drawing.Size(121, 23)
        Me.denComboBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tietkiemTextBox)
        Me.GroupBox1.Controls.Add(Me.phothongTextBox)
        Me.GroupBox1.Controls.Add(Me.thuonggiaTextBox)
        Me.GroupBox1.Controls.Add(Me.tietkiemLabel)
        Me.GroupBox1.Controls.Add(Me.phothongLabel)
        Me.GroupBox1.Controls.Add(Me.thuonggiaLabel)
        Me.GroupBox1.Controls.Add(Me.suaButton)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.luuButton)
        Me.GroupBox1.Controls.Add(Me.denComboBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dituComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 158)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thay đổi giá vé"
        '
        'tietkiemTextBox
        '
        Me.tietkiemTextBox.Location = New System.Drawing.Point(371, 94)
        Me.tietkiemTextBox.Name = "tietkiemTextBox"
        Me.tietkiemTextBox.Size = New System.Drawing.Size(174, 23)
        Me.tietkiemTextBox.TabIndex = 10
        '
        'phothongTextBox
        '
        Me.phothongTextBox.Location = New System.Drawing.Point(371, 59)
        Me.phothongTextBox.Name = "phothongTextBox"
        Me.phothongTextBox.Size = New System.Drawing.Size(174, 23)
        Me.phothongTextBox.TabIndex = 31
        '
        'thuonggiaTextBox
        '
        Me.thuonggiaTextBox.Location = New System.Drawing.Point(371, 24)
        Me.thuonggiaTextBox.Name = "thuonggiaTextBox"
        Me.thuonggiaTextBox.Size = New System.Drawing.Size(174, 23)
        Me.thuonggiaTextBox.TabIndex = 9
        '
        'tietkiemLabel
        '
        Me.tietkiemLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tietkiemLabel.Location = New System.Drawing.Point(371, 94)
        Me.tietkiemLabel.Name = "tietkiemLabel"
        Me.tietkiemLabel.Size = New System.Drawing.Size(174, 23)
        Me.tietkiemLabel.TabIndex = 30
        Me.tietkiemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'phothongLabel
        '
        Me.phothongLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.phothongLabel.Location = New System.Drawing.Point(371, 59)
        Me.phothongLabel.Name = "phothongLabel"
        Me.phothongLabel.Size = New System.Drawing.Size(174, 23)
        Me.phothongLabel.TabIndex = 29
        Me.phothongLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'thuonggiaLabel
        '
        Me.thuonggiaLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.thuonggiaLabel.Location = New System.Drawing.Point(371, 24)
        Me.thuonggiaLabel.Name = "thuonggiaLabel"
        Me.thuonggiaLabel.Size = New System.Drawing.Size(174, 23)
        Me.thuonggiaLabel.TabIndex = 28
        Me.thuonggiaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'suaButton
        '
        Me.suaButton.Location = New System.Drawing.Point(457, 120)
        Me.suaButton.Name = "suaButton"
        Me.suaButton.Size = New System.Drawing.Size(88, 24)
        Me.suaButton.TabIndex = 27
        Me.suaButton.Text = "Sửa gía vé"
        Me.suaButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(244, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Phổ thông linh hoạt:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(244, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 15)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Tiết kiệm linh hoạt:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(244, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Thương gia linh hoạt:"
        '
        'luuButton
        '
        Me.luuButton.Location = New System.Drawing.Point(457, 119)
        Me.luuButton.Name = "luuButton"
        Me.luuButton.Size = New System.Drawing.Size(88, 24)
        Me.luuButton.TabIndex = 13
        Me.luuButton.Text = "Lưu thay đổi"
        Me.luuButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.hienthiButton)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.xoaButton1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.showCheckBox)
        Me.GroupBox2.Controls.Add(Me.suaButton2)
        Me.GroupBox2.Controls.Add(Me.taikhoanLabel)
        Me.GroupBox2.Controls.Add(Me.matkhauTextBox1)
        Me.GroupBox2.Controls.Add(Me.themButton1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.adminRadioButton)
        Me.GroupBox2.Controls.Add(Me.nhanvienRadioButton)
        Me.GroupBox2.Controls.Add(Me.matkhauTextBox)
        Me.GroupBox2.Controls.Add(Me.tendangnhapTextBox)
        Me.GroupBox2.Controls.Add(Me.xoaButton)
        Me.GroupBox2.Controls.Add(Me.suaButton1)
        Me.GroupBox2.Controls.Add(Me.themButton)
        Me.GroupBox2.Controls.Add(Me.taikhoanListBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.taikhoanComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(573, 232)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quản lý tài khoản"
        '
        'hienthiButton
        '
        Me.hienthiButton.Location = New System.Drawing.Point(247, 49)
        Me.hienthiButton.Name = "hienthiButton"
        Me.hienthiButton.Size = New System.Drawing.Size(131, 25)
        Me.hienthiButton.TabIndex = 56
        Me.hienthiButton.Text = "Hiển thị thông tin"
        Me.hienthiButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(415, 98)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(130, 23)
        Me.TextBox1.TabIndex = 55
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(415, 127)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(121, 19)
        Me.CheckBox1.TabIndex = 54
        Me.CheckBox1.Text = "Hiển thị mật khẩu"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'xoaButton1
        '
        Me.xoaButton1.Location = New System.Drawing.Point(422, 194)
        Me.xoaButton1.Name = "xoaButton1"
        Me.xoaButton1.Size = New System.Drawing.Size(99, 25)
        Me.xoaButton1.TabIndex = 53
        Me.xoaButton1.Text = "Xóa tài khoản"
        Me.xoaButton1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(426, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Mật khẩu:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(412, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Tên đăng nhập:"
        '
        'showCheckBox
        '
        Me.showCheckBox.AutoSize = True
        Me.showCheckBox.Location = New System.Drawing.Point(415, 127)
        Me.showCheckBox.Name = "showCheckBox"
        Me.showCheckBox.Size = New System.Drawing.Size(121, 19)
        Me.showCheckBox.TabIndex = 48
        Me.showCheckBox.Text = "Hiển thị mật khẩu"
        Me.showCheckBox.UseVisualStyleBackColor = True
        '
        'suaButton2
        '
        Me.suaButton2.Location = New System.Drawing.Point(422, 194)
        Me.suaButton2.Name = "suaButton2"
        Me.suaButton2.Size = New System.Drawing.Size(99, 25)
        Me.suaButton2.TabIndex = 46
        Me.suaButton2.Text = "Đổi mật khẩu"
        Me.suaButton2.UseVisualStyleBackColor = True
        '
        'taikhoanLabel
        '
        Me.taikhoanLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taikhoanLabel.Location = New System.Drawing.Point(415, 50)
        Me.taikhoanLabel.Name = "taikhoanLabel"
        Me.taikhoanLabel.Size = New System.Drawing.Size(130, 22)
        Me.taikhoanLabel.TabIndex = 45
        Me.taikhoanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'matkhauTextBox1
        '
        Me.matkhauTextBox1.Location = New System.Drawing.Point(415, 98)
        Me.matkhauTextBox1.Name = "matkhauTextBox1"
        Me.matkhauTextBox1.ShortcutsEnabled = False
        Me.matkhauTextBox1.Size = New System.Drawing.Size(130, 23)
        Me.matkhauTextBox1.TabIndex = 44
        Me.matkhauTextBox1.UseSystemPasswordChar = True
        '
        'themButton1
        '
        Me.themButton1.Location = New System.Drawing.Point(422, 194)
        Me.themButton1.Name = "themButton1"
        Me.themButton1.Size = New System.Drawing.Size(99, 25)
        Me.themButton1.TabIndex = 43
        Me.themButton1.Text = "Thêm tài khoản"
        Me.themButton1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(413, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Mật khẩu:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(412, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Tên đăng nhập:"
        '
        'adminRadioButton
        '
        Me.adminRadioButton.AutoSize = True
        Me.adminRadioButton.Location = New System.Drawing.Point(415, 164)
        Me.adminRadioButton.Name = "adminRadioButton"
        Me.adminRadioButton.Size = New System.Drawing.Size(61, 19)
        Me.adminRadioButton.TabIndex = 41
        Me.adminRadioButton.TabStop = True
        Me.adminRadioButton.Text = "Admin"
        Me.adminRadioButton.UseVisualStyleBackColor = True
        '
        'nhanvienRadioButton
        '
        Me.nhanvienRadioButton.AutoSize = True
        Me.nhanvienRadioButton.Location = New System.Drawing.Point(415, 145)
        Me.nhanvienRadioButton.Name = "nhanvienRadioButton"
        Me.nhanvienRadioButton.Size = New System.Drawing.Size(79, 19)
        Me.nhanvienRadioButton.TabIndex = 40
        Me.nhanvienRadioButton.TabStop = True
        Me.nhanvienRadioButton.Text = "Nhân viên"
        Me.nhanvienRadioButton.UseVisualStyleBackColor = True
        '
        'matkhauTextBox
        '
        Me.matkhauTextBox.Location = New System.Drawing.Point(415, 98)
        Me.matkhauTextBox.Name = "matkhauTextBox"
        Me.matkhauTextBox.Size = New System.Drawing.Size(130, 23)
        Me.matkhauTextBox.TabIndex = 39
        Me.matkhauTextBox.UseSystemPasswordChar = True
        '
        'tendangnhapTextBox
        '
        Me.tendangnhapTextBox.Location = New System.Drawing.Point(415, 49)
        Me.tendangnhapTextBox.Name = "tendangnhapTextBox"
        Me.tendangnhapTextBox.Size = New System.Drawing.Size(130, 23)
        Me.tendangnhapTextBox.TabIndex = 38
        '
        'xoaButton
        '
        Me.xoaButton.Location = New System.Drawing.Point(247, 111)
        Me.xoaButton.Name = "xoaButton"
        Me.xoaButton.Size = New System.Drawing.Size(131, 25)
        Me.xoaButton.TabIndex = 37
        Me.xoaButton.Text = "Xóa tài khoản"
        Me.xoaButton.UseVisualStyleBackColor = True
        '
        'suaButton1
        '
        Me.suaButton1.Location = New System.Drawing.Point(247, 80)
        Me.suaButton1.Name = "suaButton1"
        Me.suaButton1.Size = New System.Drawing.Size(131, 25)
        Me.suaButton1.TabIndex = 36
        Me.suaButton1.Text = "Đổi mật khẩu"
        Me.suaButton1.UseVisualStyleBackColor = True
        '
        'themButton
        '
        Me.themButton.Location = New System.Drawing.Point(247, 144)
        Me.themButton.Name = "themButton"
        Me.themButton.Size = New System.Drawing.Size(131, 25)
        Me.themButton.TabIndex = 35
        Me.themButton.Text = "Thêm một tài khoản"
        Me.themButton.UseVisualStyleBackColor = True
        '
        'taikhoanListBox
        '
        Me.taikhoanListBox.FormattingEnabled = True
        Me.taikhoanListBox.ItemHeight = 15
        Me.taikhoanListBox.Location = New System.Drawing.Point(86, 49)
        Me.taikhoanListBox.Name = "taikhoanListBox"
        Me.taikhoanListBox.Size = New System.Drawing.Size(121, 139)
        Me.taikhoanListBox.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(19, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Tài khoản:"
        '
        'taikhoanComboBox
        '
        Me.taikhoanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.taikhoanComboBox.FormattingEnabled = True
        Me.taikhoanComboBox.Items.AddRange(New Object() {"Admin", "Nhân viên"})
        Me.taikhoanComboBox.Location = New System.Drawing.Point(86, 26)
        Me.taikhoanComboBox.Name = "taikhoanComboBox"
        Me.taikhoanComboBox.Size = New System.Drawing.Size(121, 23)
        Me.taikhoanComboBox.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(-8, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(812, 15)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "_________________________________________________________________________________" & _
    "________________________________________________________________________________" & _
    ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 40)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Manager"
        '
        'manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(597, 507)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "manager"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dituComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents denComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents luuButton As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents suaButton As System.Windows.Forms.Button
    Friend WithEvents thuonggiaLabel As System.Windows.Forms.Label
    Friend WithEvents tietkiemLabel As System.Windows.Forms.Label
    Friend WithEvents phothongLabel As System.Windows.Forms.Label
    Friend WithEvents tietkiemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents phothongTextBox As System.Windows.Forms.TextBox
    Friend WithEvents thuonggiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents taikhoanComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents taikhoanListBox As System.Windows.Forms.ListBox
    Friend WithEvents xoaButton As System.Windows.Forms.Button
    Friend WithEvents suaButton1 As System.Windows.Forms.Button
    Friend WithEvents themButton As System.Windows.Forms.Button
    Friend WithEvents tendangnhapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents adminRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents nhanvienRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents matkhauTextBox As System.Windows.Forms.TextBox
    Friend WithEvents themButton1 As System.Windows.Forms.Button
    Friend WithEvents suaButton2 As System.Windows.Forms.Button
    Friend WithEvents taikhoanLabel As System.Windows.Forms.Label
    Friend WithEvents matkhauTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents showCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents xoaButton1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents hienthiButton As System.Windows.Forms.Button
End Class
