<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opname
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opname))
        Me.validity_btn = New System.Windows.Forms.Button()
        Me.reset_btn = New System.Windows.Forms.Button()
        Me.kdbarang_txt = New System.Windows.Forms.TextBox()
        Me.nmbarang_txt = New System.Windows.Forms.TextBox()
        Me.Selisih_txt = New System.Windows.Forms.TextBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.search2_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.actual_txt = New System.Windows.Forms.TextBox()
        Me.stokBarang_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tgl_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'validity_btn
        '
        Me.validity_btn.BackgroundImage = CType(resources.GetObject("validity_btn.BackgroundImage"), System.Drawing.Image)
        Me.validity_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.validity_btn.Location = New System.Drawing.Point(206, 260)
        Me.validity_btn.Name = "validity_btn"
        Me.validity_btn.Size = New System.Drawing.Size(132, 36)
        Me.validity_btn.TabIndex = 0
        Me.validity_btn.UseVisualStyleBackColor = True
        '
        'reset_btn
        '
        Me.reset_btn.BackgroundImage = CType(resources.GetObject("reset_btn.BackgroundImage"), System.Drawing.Image)
        Me.reset_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.reset_btn.Location = New System.Drawing.Point(411, 260)
        Me.reset_btn.Name = "reset_btn"
        Me.reset_btn.Size = New System.Drawing.Size(132, 36)
        Me.reset_btn.TabIndex = 1
        Me.reset_btn.UseVisualStyleBackColor = True
        '
        'kdbarang_txt
        '
        Me.kdbarang_txt.Enabled = False
        Me.kdbarang_txt.Location = New System.Drawing.Point(205, 75)
        Me.kdbarang_txt.Name = "kdbarang_txt"
        Me.kdbarang_txt.Size = New System.Drawing.Size(134, 20)
        Me.kdbarang_txt.TabIndex = 2
        '
        'nmbarang_txt
        '
        Me.nmbarang_txt.Enabled = False
        Me.nmbarang_txt.Location = New System.Drawing.Point(205, 104)
        Me.nmbarang_txt.Name = "nmbarang_txt"
        Me.nmbarang_txt.Size = New System.Drawing.Size(134, 20)
        Me.nmbarang_txt.TabIndex = 3
        '
        'Selisih_txt
        '
        Me.Selisih_txt.Enabled = False
        Me.Selisih_txt.Location = New System.Drawing.Point(205, 182)
        Me.Selisih_txt.Name = "Selisih_txt"
        Me.Selisih_txt.Size = New System.Drawing.Size(134, 20)
        Me.Selisih_txt.TabIndex = 6
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(595, 55)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 7
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'search2_btn
        '
        Me.search2_btn.BackgroundImage = CType(resources.GetObject("search2_btn.BackgroundImage"), System.Drawing.Image)
        Me.search2_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.search2_btn.Location = New System.Drawing.Point(344, 72)
        Me.search2_btn.Name = "search2_btn"
        Me.search2_btn.Size = New System.Drawing.Size(35, 23)
        Me.search2_btn.TabIndex = 8
        Me.search2_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(82, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(82, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(82, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Actual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(82, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Selisih"
        '
        'actual_txt
        '
        Me.actual_txt.Location = New System.Drawing.Point(205, 156)
        Me.actual_txt.Name = "actual_txt"
        Me.actual_txt.Size = New System.Drawing.Size(134, 20)
        Me.actual_txt.TabIndex = 15
        '
        'stokBarang_txt
        '
        Me.stokBarang_txt.Enabled = False
        Me.stokBarang_txt.Location = New System.Drawing.Point(205, 130)
        Me.stokBarang_txt.Name = "stokBarang_txt"
        Me.stokBarang_txt.Size = New System.Drawing.Size(134, 20)
        Me.stokBarang_txt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(82, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Stok Barang"
        '
        'tgl_lbl
        '
        Me.tgl_lbl.AutoSize = True
        Me.tgl_lbl.BackColor = System.Drawing.Color.Transparent
        Me.tgl_lbl.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_lbl.ForeColor = System.Drawing.Color.White
        Me.tgl_lbl.Location = New System.Drawing.Point(515, 57)
        Me.tgl_lbl.Name = "tgl_lbl"
        Me.tgl_lbl.Size = New System.Drawing.Size(61, 18)
        Me.tgl_lbl.TabIndex = 32
        Me.tgl_lbl.Text = "Tanggal"
        '
        'Opname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(629, 357)
        Me.Controls.Add(Me.tgl_lbl)
        Me.Controls.Add(Me.actual_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search2_btn)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.Selisih_txt)
        Me.Controls.Add(Me.stokBarang_txt)
        Me.Controls.Add(Me.nmbarang_txt)
        Me.Controls.Add(Me.kdbarang_txt)
        Me.Controls.Add(Me.reset_btn)
        Me.Controls.Add(Me.validity_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Opname"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opname"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents validity_btn As System.Windows.Forms.Button
    Friend WithEvents reset_btn As System.Windows.Forms.Button
    Friend WithEvents kdbarang_txt As System.Windows.Forms.TextBox
    Friend WithEvents nmbarang_txt As System.Windows.Forms.TextBox
    Friend WithEvents Selisih_txt As System.Windows.Forms.TextBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents search2_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents actual_txt As System.Windows.Forms.TextBox
    Friend WithEvents stokBarang_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tgl_lbl As System.Windows.Forms.Label
End Class
