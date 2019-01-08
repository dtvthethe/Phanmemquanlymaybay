<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dangnhap))
        Me.dangnhapButton = New System.Windows.Forms.Button()
        Me.thoatButton = New System.Windows.Forms.Button()
        Me.tendangnhapLabel = New System.Windows.Forms.Label()
        Me.matkhauLabel = New System.Windows.Forms.Label()
        Me.tendangnhapTextBox = New System.Windows.Forms.TextBox()
        Me.matkhauTextBox = New System.Windows.Forms.TextBox()
        Me.loiLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dangnhapButton
        '
        Me.dangnhapButton.Location = New System.Drawing.Point(130, 146)
        Me.dangnhapButton.Name = "dangnhapButton"
        Me.dangnhapButton.Size = New System.Drawing.Size(75, 23)
        Me.dangnhapButton.TabIndex = 1
        Me.dangnhapButton.Text = "Đăng nhập"
        Me.dangnhapButton.UseVisualStyleBackColor = True
        '
        'thoatButton
        '
        Me.thoatButton.Location = New System.Drawing.Point(214, 146)
        Me.thoatButton.Name = "thoatButton"
        Me.thoatButton.Size = New System.Drawing.Size(75, 23)
        Me.thoatButton.TabIndex = 2
        Me.thoatButton.Text = "Thoát"
        Me.thoatButton.UseVisualStyleBackColor = True
        '
        'tendangnhapLabel
        '
        Me.tendangnhapLabel.AutoSize = True
        Me.tendangnhapLabel.Image = CType(resources.GetObject("tendangnhapLabel.Image"), System.Drawing.Image)
        Me.tendangnhapLabel.Location = New System.Drawing.Point(34, 76)
        Me.tendangnhapLabel.Name = "tendangnhapLabel"
        Me.tendangnhapLabel.Size = New System.Drawing.Size(90, 15)
        Me.tendangnhapLabel.TabIndex = 3
        Me.tendangnhapLabel.Text = "Tên đăng nhập:"
        '
        'matkhauLabel
        '
        Me.matkhauLabel.AutoSize = True
        Me.matkhauLabel.Image = CType(resources.GetObject("matkhauLabel.Image"), System.Drawing.Image)
        Me.matkhauLabel.Location = New System.Drawing.Point(34, 106)
        Me.matkhauLabel.Name = "matkhauLabel"
        Me.matkhauLabel.Size = New System.Drawing.Size(60, 15)
        Me.matkhauLabel.TabIndex = 4
        Me.matkhauLabel.Text = "Mật khẩu:"
        '
        'tendangnhapTextBox
        '
        Me.tendangnhapTextBox.Location = New System.Drawing.Point(130, 68)
        Me.tendangnhapTextBox.Name = "tendangnhapTextBox"
        Me.tendangnhapTextBox.Size = New System.Drawing.Size(159, 23)
        Me.tendangnhapTextBox.TabIndex = 5
        '
        'matkhauTextBox
        '
        Me.matkhauTextBox.Location = New System.Drawing.Point(130, 104)
        Me.matkhauTextBox.Name = "matkhauTextBox"
        Me.matkhauTextBox.Size = New System.Drawing.Size(159, 23)
        Me.matkhauTextBox.TabIndex = 6
        Me.matkhauTextBox.UseSystemPasswordChar = True
        '
        'loiLabel
        '
        Me.loiLabel.AutoSize = True
        Me.loiLabel.ForeColor = System.Drawing.Color.Red
        Me.loiLabel.Image = CType(resources.GetObject("loiLabel.Image"), System.Drawing.Image)
        Me.loiLabel.Location = New System.Drawing.Point(132, 129)
        Me.loiLabel.Name = "loiLabel"
        Me.loiLabel.Size = New System.Drawing.Size(0, 15)
        Me.loiLabel.TabIndex = 7
        Me.loiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(-4, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(372, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "_________________________________________________________________________"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 42)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Đăng nhập"
        '
        'dangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(364, 211)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.loiLabel)
        Me.Controls.Add(Me.matkhauTextBox)
        Me.Controls.Add(Me.tendangnhapTextBox)
        Me.Controls.Add(Me.matkhauLabel)
        Me.Controls.Add(Me.tendangnhapLabel)
        Me.Controls.Add(Me.thoatButton)
        Me.Controls.Add(Me.dangnhapButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "dangnhap"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dangnhapButton As System.Windows.Forms.Button
    Friend WithEvents thoatButton As System.Windows.Forms.Button
    Friend WithEvents tendangnhapLabel As System.Windows.Forms.Label
    Friend WithEvents matkhauLabel As System.Windows.Forms.Label
    Friend WithEvents tendangnhapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents matkhauTextBox As System.Windows.Forms.TextBox
    Friend WithEvents loiLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
