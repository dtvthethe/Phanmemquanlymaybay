<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class phanmemquanlybanvemaybay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(phanmemquanlybanvemaybay))
        Me.phanmemquanlyLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.chucnang = New System.Windows.Forms.ToolStripMenuItem()
        Me.banvechuyenbaymenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.quanlychuyenbaymenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.thongkemenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.lichsumenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.managermenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TùyChọnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.banvechuyenbayButton = New System.Windows.Forms.Button()
        Me.thongtinButton = New System.Windows.Forms.Button()
        Me.thoatButton = New System.Windows.Forms.Button()
        Me.thongkeButton = New System.Windows.Forms.Button()
        Me.quanlychuyenbayButton = New System.Windows.Forms.Button()
        Me.lichsuButton = New System.Windows.Forms.Button()
        Me.managerButton = New System.Windows.Forms.Button()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'phanmemquanlyLabel
        '
        Me.phanmemquanlyLabel.BackColor = System.Drawing.SystemColors.Control
        Me.phanmemquanlyLabel.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phanmemquanlyLabel.Image = CType(resources.GetObject("phanmemquanlyLabel.Image"), System.Drawing.Image)
        Me.phanmemquanlyLabel.Location = New System.Drawing.Point(195, 30)
        Me.phanmemquanlyLabel.Name = "phanmemquanlyLabel"
        Me.phanmemquanlyLabel.Size = New System.Drawing.Size(503, 45)
        Me.phanmemquanlyLabel.TabIndex = 0
        Me.phanmemquanlyLabel.Text = "Phần mềm quản lý bán vé máy bay"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.chucnang, Me.TùyChọnToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(705, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'chucnang
        '
        Me.chucnang.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.banvechuyenbaymenu, Me.quanlychuyenbaymenu, Me.thongkemenu, Me.lichsumenu, Me.managermenu})
        Me.chucnang.Name = "chucnang"
        Me.chucnang.Size = New System.Drawing.Size(77, 20)
        Me.chucnang.Text = "Chức năng"
        '
        'banvechuyenbaymenu
        '
        Me.banvechuyenbaymenu.Name = "banvechuyenbaymenu"
        Me.banvechuyenbaymenu.Size = New System.Drawing.Size(179, 22)
        Me.banvechuyenbaymenu.Text = "Bán vé chuyến bay"
        '
        'quanlychuyenbaymenu
        '
        Me.quanlychuyenbaymenu.Name = "quanlychuyenbaymenu"
        Me.quanlychuyenbaymenu.Size = New System.Drawing.Size(179, 22)
        Me.quanlychuyenbaymenu.Text = "Quản lý chuyến bay"
        '
        'thongkemenu
        '
        Me.thongkemenu.Name = "thongkemenu"
        Me.thongkemenu.Size = New System.Drawing.Size(179, 22)
        Me.thongkemenu.Text = "Thống kê"
        '
        'lichsumenu
        '
        Me.lichsumenu.Name = "lichsumenu"
        Me.lichsumenu.Size = New System.Drawing.Size(179, 22)
        Me.lichsumenu.Text = "Lịch sử"
        '
        'managermenu
        '
        Me.managermenu.Name = "managermenu"
        Me.managermenu.Size = New System.Drawing.Size(179, 22)
        Me.managermenu.Text = "Manager"
        '
        'TùyChọnToolStripMenuItem
        '
        Me.TùyChọnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.TùyChọnToolStripMenuItem.Name = "TùyChọnToolStripMenuItem"
        Me.TùyChọnToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.TùyChọnToolStripMenuItem.Text = "Tùy chọn"
        '
        'ThôngTinToolStripMenuItem
        '
        Me.ThôngTinToolStripMenuItem.Name = "ThôngTinToolStripMenuItem"
        Me.ThôngTinToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ThôngTinToolStripMenuItem.Text = "Thông tin"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'banvechuyenbayButton
        '
        Me.banvechuyenbayButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.banvechuyenbayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.banvechuyenbayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.banvechuyenbayButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.banvechuyenbayButton.Image = Global.WindowsApplication1.My.Resources.Resources.banve
        Me.banvechuyenbayButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.banvechuyenbayButton.Location = New System.Drawing.Point(279, 136)
        Me.banvechuyenbayButton.Name = "banvechuyenbayButton"
        Me.banvechuyenbayButton.Size = New System.Drawing.Size(143, 87)
        Me.banvechuyenbayButton.TabIndex = 2
        Me.banvechuyenbayButton.Text = "Bán vé chuyến bay"
        Me.banvechuyenbayButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.banvechuyenbayButton.UseVisualStyleBackColor = False
        '
        'thongtinButton
        '
        Me.thongtinButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.thongtinButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.thongtinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.thongtinButton.Location = New System.Drawing.Point(422, 449)
        Me.thongtinButton.Name = "thongtinButton"
        Me.thongtinButton.Size = New System.Drawing.Size(75, 23)
        Me.thongtinButton.TabIndex = 6
        Me.thongtinButton.Text = "Thông tin"
        Me.thongtinButton.UseVisualStyleBackColor = False
        '
        'thoatButton
        '
        Me.thoatButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.thoatButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.thoatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.thoatButton.Location = New System.Drawing.Point(500, 449)
        Me.thoatButton.Name = "thoatButton"
        Me.thoatButton.Size = New System.Drawing.Size(75, 23)
        Me.thoatButton.TabIndex = 7
        Me.thoatButton.Text = "Thoát"
        Me.thoatButton.UseVisualStyleBackColor = False
        '
        'thongkeButton
        '
        Me.thongkeButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.thongkeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.thongkeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.thongkeButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thongkeButton.Image = Global.WindowsApplication1.My.Resources.Resources.thongke
        Me.thongkeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.thongkeButton.Location = New System.Drawing.Point(279, 226)
        Me.thongkeButton.Name = "thongkeButton"
        Me.thongkeButton.Size = New System.Drawing.Size(143, 88)
        Me.thongkeButton.TabIndex = 8
        Me.thongkeButton.Text = "Thống kê"
        Me.thongkeButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.thongkeButton.UseVisualStyleBackColor = False
        '
        'quanlychuyenbayButton
        '
        Me.quanlychuyenbayButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.quanlychuyenbayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.quanlychuyenbayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quanlychuyenbayButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quanlychuyenbayButton.Image = Global.WindowsApplication1.My.Resources.Resources.quanly
        Me.quanlychuyenbayButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.quanlychuyenbayButton.Location = New System.Drawing.Point(425, 136)
        Me.quanlychuyenbayButton.Name = "quanlychuyenbayButton"
        Me.quanlychuyenbayButton.Size = New System.Drawing.Size(150, 87)
        Me.quanlychuyenbayButton.TabIndex = 9
        Me.quanlychuyenbayButton.Text = "Quản lý chuyến bay"
        Me.quanlychuyenbayButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.quanlychuyenbayButton.UseVisualStyleBackColor = False
        '
        'lichsuButton
        '
        Me.lichsuButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lichsuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.lichsuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lichsuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lichsuButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lichsuButton.Image = Global.WindowsApplication1.My.Resources.Resources.lichsu
        Me.lichsuButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lichsuButton.Location = New System.Drawing.Point(425, 226)
        Me.lichsuButton.Name = "lichsuButton"
        Me.lichsuButton.Size = New System.Drawing.Size(150, 88)
        Me.lichsuButton.TabIndex = 10
        Me.lichsuButton.Text = "Lịch sử"
        Me.lichsuButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lichsuButton.UseVisualStyleBackColor = False
        '
        'managerButton
        '
        Me.managerButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.managerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.managerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.managerButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.managerButton.Image = Global.WindowsApplication1.My.Resources.Resources.mng
        Me.managerButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.managerButton.Location = New System.Drawing.Point(279, 317)
        Me.managerButton.Name = "managerButton"
        Me.managerButton.Size = New System.Drawing.Size(296, 119)
        Me.managerButton.TabIndex = 11
        Me.managerButton.Text = "Manager"
        Me.managerButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.managerButton.UseVisualStyleBackColor = False
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.BackColor = System.Drawing.Color.Transparent
        Me.userLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLabel.ForeColor = System.Drawing.Color.Red
        Me.userLabel.Location = New System.Drawing.Point(575, 83)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(0, 21)
        Me.userLabel.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.LightBlue
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.back3
        Me.Button1.Location = New System.Drawing.Point(649, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'phanmemquanlybanvemaybay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(705, 479)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.managerButton)
        Me.Controls.Add(Me.lichsuButton)
        Me.Controls.Add(Me.quanlychuyenbayButton)
        Me.Controls.Add(Me.thongkeButton)
        Me.Controls.Add(Me.thoatButton)
        Me.Controls.Add(Me.thongtinButton)
        Me.Controls.Add(Me.banvechuyenbayButton)
        Me.Controls.Add(Me.phanmemquanlyLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "phanmemquanlybanvemaybay"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phần mềm quản lý bán vé máy bay"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents phanmemquanlyLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents chucnang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents banvechuyenbaymenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents quanlychuyenbaymenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents banvechuyenbayButton As System.Windows.Forms.Button
    Friend WithEvents thongtinButton As System.Windows.Forms.Button
    Friend WithEvents thoatButton As System.Windows.Forms.Button
    Friend WithEvents thongkeButton As System.Windows.Forms.Button
    Friend WithEvents quanlychuyenbayButton As System.Windows.Forms.Button
    Friend WithEvents lichsuButton As System.Windows.Forms.Button
    Friend WithEvents managerButton As System.Windows.Forms.Button
    Friend WithEvents thongkemenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lichsumenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents managermenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TùyChọnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents userLabel As System.Windows.Forms.Label
    Private WithEvents Button1 As System.Windows.Forms.Button
End Class
