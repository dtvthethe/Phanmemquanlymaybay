<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanlychuyenbay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quanlychuyenbay))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timkiemTextBox = New System.Windows.Forms.TextBox()
        Me.timtheoComboBox = New System.Windows.Forms.ComboBox()
        Me.timkiemButton = New System.Windows.Forms.Button()
        Me.suaButton = New System.Windows.Forms.Button()
        Me.huybayButton = New System.Windows.Forms.Button()
        Me.thongtinButton = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.lammoiButton = New System.Windows.Forms.Button()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.time1 = New System.Windows.Forms.Label()
        Me.ngaydi = New System.Windows.Forms.Label()
        Me.den = New System.Windows.Forms.Label()
        Me.ditu = New System.Windows.Forms.Label()
        Me.quoctich = New System.Windows.Forms.Label()
        Me.sdt = New System.Windows.Forms.Label()
        Me.cmnd = New System.Windows.Forms.Label()
        Me.hovaten = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.thoatButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(180, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nhập từ khóa tìm kiếm :"
        '
        'timkiemTextBox
        '
        Me.timkiemTextBox.Location = New System.Drawing.Point(321, 66)
        Me.timkiemTextBox.Name = "timkiemTextBox"
        Me.timkiemTextBox.Size = New System.Drawing.Size(154, 23)
        Me.timkiemTextBox.TabIndex = 3
        '
        'timtheoComboBox
        '
        Me.timtheoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.timtheoComboBox.FormattingEnabled = True
        Me.timtheoComboBox.Items.AddRange(New Object() {"Số ghế", "Số hiệu bay", "Cửa bay", "Họ và tên", "CMND", "SĐT"})
        Me.timtheoComboBox.Location = New System.Drawing.Point(493, 66)
        Me.timtheoComboBox.Name = "timtheoComboBox"
        Me.timtheoComboBox.Size = New System.Drawing.Size(128, 23)
        Me.timtheoComboBox.TabIndex = 4
        '
        'timkiemButton
        '
        Me.timkiemButton.Location = New System.Drawing.Point(641, 67)
        Me.timkiemButton.Name = "timkiemButton"
        Me.timkiemButton.Size = New System.Drawing.Size(75, 23)
        Me.timkiemButton.TabIndex = 5
        Me.timkiemButton.Text = "Tìm kiếm"
        Me.timkiemButton.UseVisualStyleBackColor = True
        '
        'suaButton
        '
        Me.suaButton.Location = New System.Drawing.Point(297, 112)
        Me.suaButton.Name = "suaButton"
        Me.suaButton.Size = New System.Drawing.Size(97, 23)
        Me.suaButton.TabIndex = 7
        Me.suaButton.Text = "Sửa"
        Me.suaButton.UseVisualStyleBackColor = True
        '
        'huybayButton
        '
        Me.huybayButton.Location = New System.Drawing.Point(408, 112)
        Me.huybayButton.Name = "huybayButton"
        Me.huybayButton.Size = New System.Drawing.Size(97, 23)
        Me.huybayButton.TabIndex = 8
        Me.huybayButton.Text = "Hủy bay"
        Me.huybayButton.UseVisualStyleBackColor = True
        '
        'thongtinButton
        '
        Me.thongtinButton.Location = New System.Drawing.Point(520, 112)
        Me.thongtinButton.Name = "thongtinButton"
        Me.thongtinButton.Size = New System.Drawing.Size(97, 23)
        Me.thongtinButton.TabIndex = 9
        Me.thongtinButton.Text = "Thông tin"
        Me.thongtinButton.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView.Location = New System.Drawing.Point(0, 151)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(1025, 329)
        Me.DataGridView.TabIndex = 12
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "ho_va_ten"
        Me.Column7.HeaderText = "Họ và Tên"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 180
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "di_tu"
        Me.Column1.HeaderText = "Đi từ"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "den"
        Me.Column2.HeaderText = "Đến"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "time1"
        Me.Column3.HeaderText = "Giờ khởi hành"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "so_ghe"
        Me.Column4.HeaderText = "Số ghế"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "so_hieu_bay"
        Me.Column5.HeaderText = "Số hiệu bay"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "cua_bay"
        Me.Column6.HeaderText = "Cửa bay"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 50
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "cmnd"
        Me.Column8.HeaderText = "CMND"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 160
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "so_dien_thoai"
        Me.Column9.HeaderText = "SĐT"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 140
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "id"
        Me.Column10.HeaderText = "ID"
        Me.Column10.MinimumWidth = 2
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 2
        '
        'errorLabel
        '
        Me.errorLabel.BackColor = System.Drawing.Color.Transparent
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.Location = New System.Drawing.Point(723, 69)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(273, 19)
        Me.errorLabel.TabIndex = 13
        '
        'lammoiButton
        '
        Me.lammoiButton.Location = New System.Drawing.Point(623, 112)
        Me.lammoiButton.Name = "lammoiButton"
        Me.lammoiButton.Size = New System.Drawing.Size(97, 23)
        Me.lammoiButton.TabIndex = 14
        Me.lammoiButton.Text = "Làm mới"
        Me.lammoiButton.UseVisualStyleBackColor = True
        '
        'userLabel
        '
        Me.userLabel.BackColor = System.Drawing.Color.Transparent
        Me.userLabel.Location = New System.Drawing.Point(35, 24)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(1, 1)
        Me.userLabel.TabIndex = 19
        '
        'time1
        '
        Me.time1.BackColor = System.Drawing.Color.Transparent
        Me.time1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time1.ForeColor = System.Drawing.Color.Red
        Me.time1.Location = New System.Drawing.Point(1159, 237)
        Me.time1.Name = "time1"
        Me.time1.Size = New System.Drawing.Size(1, 1)
        Me.time1.TabIndex = 96
        Me.time1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ngaydi
        '
        Me.ngaydi.BackColor = System.Drawing.Color.Transparent
        Me.ngaydi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ngaydi.ForeColor = System.Drawing.Color.Red
        Me.ngaydi.Location = New System.Drawing.Point(1159, 168)
        Me.ngaydi.Name = "ngaydi"
        Me.ngaydi.Size = New System.Drawing.Size(1, 1)
        Me.ngaydi.TabIndex = 95
        Me.ngaydi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'den
        '
        Me.den.BackColor = System.Drawing.Color.Transparent
        Me.den.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.den.ForeColor = System.Drawing.Color.Red
        Me.den.Location = New System.Drawing.Point(1159, 95)
        Me.den.Name = "den"
        Me.den.Size = New System.Drawing.Size(1, 1)
        Me.den.TabIndex = 94
        Me.den.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ditu
        '
        Me.ditu.BackColor = System.Drawing.Color.Transparent
        Me.ditu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ditu.ForeColor = System.Drawing.Color.Red
        Me.ditu.Location = New System.Drawing.Point(1159, 127)
        Me.ditu.Name = "ditu"
        Me.ditu.Size = New System.Drawing.Size(1, 1)
        Me.ditu.TabIndex = 93
        Me.ditu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'quoctich
        '
        Me.quoctich.BackColor = System.Drawing.Color.Transparent
        Me.quoctich.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quoctich.ForeColor = System.Drawing.Color.Red
        Me.quoctich.Location = New System.Drawing.Point(1169, 148)
        Me.quoctich.Name = "quoctich"
        Me.quoctich.Size = New System.Drawing.Size(1, 1)
        Me.quoctich.TabIndex = 100
        Me.quoctich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sdt
        '
        Me.sdt.BackColor = System.Drawing.Color.Transparent
        Me.sdt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdt.ForeColor = System.Drawing.Color.Red
        Me.sdt.Location = New System.Drawing.Point(1159, 189)
        Me.sdt.Name = "sdt"
        Me.sdt.Size = New System.Drawing.Size(1, 1)
        Me.sdt.TabIndex = 99
        Me.sdt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmnd
        '
        Me.cmnd.BackColor = System.Drawing.Color.Transparent
        Me.cmnd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmnd.ForeColor = System.Drawing.Color.Red
        Me.cmnd.Location = New System.Drawing.Point(1159, 216)
        Me.cmnd.Name = "cmnd"
        Me.cmnd.Size = New System.Drawing.Size(1, 1)
        Me.cmnd.TabIndex = 98
        Me.cmnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'hovaten
        '
        Me.hovaten.BackColor = System.Drawing.Color.Transparent
        Me.hovaten.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hovaten.ForeColor = System.Drawing.Color.Red
        Me.hovaten.Location = New System.Drawing.Point(1169, 62)
        Me.hovaten.Name = "hovaten"
        Me.hovaten.Size = New System.Drawing.Size(1, 1)
        Me.hovaten.TabIndex = 97
        Me.hovaten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 40)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Quản lý chuyến bay"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(-3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1192, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'thoatButton
        '
        Me.thoatButton.Location = New System.Drawing.Point(928, 486)
        Me.thoatButton.Name = "thoatButton"
        Me.thoatButton.Size = New System.Drawing.Size(97, 23)
        Me.thoatButton.TabIndex = 10
        Me.thoatButton.Text = "Trở lại"
        Me.thoatButton.UseVisualStyleBackColor = True
        '
        'quanlychuyenbay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1037, 516)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.time1)
        Me.Controls.Add(Me.ngaydi)
        Me.Controls.Add(Me.den)
        Me.Controls.Add(Me.ditu)
        Me.Controls.Add(Me.quoctich)
        Me.Controls.Add(Me.sdt)
        Me.Controls.Add(Me.cmnd)
        Me.Controls.Add(Me.hovaten)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.lammoiButton)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.thoatButton)
        Me.Controls.Add(Me.thongtinButton)
        Me.Controls.Add(Me.huybayButton)
        Me.Controls.Add(Me.suaButton)
        Me.Controls.Add(Me.timkiemButton)
        Me.Controls.Add(Me.timtheoComboBox)
        Me.Controls.Add(Me.timkiemTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "quanlychuyenbay"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý chuyến bay"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timkiemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents timtheoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents timkiemButton As System.Windows.Forms.Button
    Friend WithEvents suaButton As System.Windows.Forms.Button
    Friend WithEvents huybayButton As System.Windows.Forms.Button
    Friend WithEvents thongtinButton As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents errorLabel As System.Windows.Forms.Label
    Friend WithEvents lammoiButton As System.Windows.Forms.Button
    Friend WithEvents userLabel As System.Windows.Forms.Label
    Friend WithEvents time1 As System.Windows.Forms.Label
    Friend WithEvents ngaydi As System.Windows.Forms.Label
    Friend WithEvents den As System.Windows.Forms.Label
    Friend WithEvents ditu As System.Windows.Forms.Label
    Friend WithEvents quoctich As System.Windows.Forms.Label
    Friend WithEvents sdt As System.Windows.Forms.Label
    Friend WithEvents cmnd As System.Windows.Forms.Label
    Friend WithEvents hovaten As System.Windows.Forms.Label
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents thoatButton As System.Windows.Forms.Button
End Class
