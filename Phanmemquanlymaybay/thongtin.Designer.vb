<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thongtin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(thongtin))
        Me.noidungTextBox = New System.Windows.Forms.TextBox()
        Me.tieudeLabel = New System.Windows.Forms.Label()
        Me.dongButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'noidungTextBox
        '
        Me.noidungTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.noidungTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.noidungTextBox.Location = New System.Drawing.Point(2, 30)
        Me.noidungTextBox.Multiline = True
        Me.noidungTextBox.Name = "noidungTextBox"
        Me.noidungTextBox.ReadOnly = True
        Me.noidungTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.noidungTextBox.Size = New System.Drawing.Size(701, 256)
        Me.noidungTextBox.TabIndex = 0
        Me.noidungTextBox.Text = resources.GetString("noidungTextBox.Text")
        '
        'tieudeLabel
        '
        Me.tieudeLabel.AutoSize = True
        Me.tieudeLabel.BackColor = System.Drawing.Color.Transparent
        Me.tieudeLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tieudeLabel.Location = New System.Drawing.Point(219, 9)
        Me.tieudeLabel.Name = "tieudeLabel"
        Me.tieudeLabel.Size = New System.Drawing.Size(251, 17)
        Me.tieudeLabel.TabIndex = 1
        Me.tieudeLabel.Text = "PHẦN MỀM QUẢN LÝ BÁN VÉ MÁY BAY"
        '
        'dongButton
        '
        Me.dongButton.Location = New System.Drawing.Point(596, 292)
        Me.dongButton.Name = "dongButton"
        Me.dongButton.Size = New System.Drawing.Size(79, 24)
        Me.dongButton.TabIndex = 2
        Me.dongButton.Text = "Đóng"
        Me.dongButton.UseVisualStyleBackColor = True
        '
        'thongtin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(705, 323)
        Me.Controls.Add(Me.dongButton)
        Me.Controls.Add(Me.tieudeLabel)
        Me.Controls.Add(Me.noidungTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "thongtin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents noidungTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tieudeLabel As System.Windows.Forms.Label
    Friend WithEvents dongButton As System.Windows.Forms.Button
End Class
