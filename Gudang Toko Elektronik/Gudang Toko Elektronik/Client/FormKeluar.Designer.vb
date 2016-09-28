<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKeluar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKeluar))
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.kdbarang_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tgl_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nmBarang_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jumlah_txt = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.kondisi_cb = New System.Windows.Forms.ComboBox()
        Me.noSuratJalan_txt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DetailkeluarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dslengkap = New Gudang_Toko_Elektronik.Dslengkap()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gudang_cb = New System.Windows.Forms.ComboBox()
        Me.rak_cb = New System.Windows.Forms.ComboBox()
        Me.txtKodeGudang = New System.Windows.Forms.TextBox()
        Me.KdtranskeluarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KdbarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KondisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.jumlah_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailkeluarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dslengkap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'insert_btn
        '
        Me.insert_btn.BackgroundImage = CType(resources.GetObject("insert_btn.BackgroundImage"), System.Drawing.Image)
        Me.insert_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.insert_btn.Location = New System.Drawing.Point(12, 286)
        Me.insert_btn.Name = "insert_btn"
        Me.insert_btn.Size = New System.Drawing.Size(132, 36)
        Me.insert_btn.TabIndex = 0
        Me.insert_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Kode Barang"
        '
        'search_btn
        '
        Me.search_btn.BackgroundImage = CType(resources.GetObject("search_btn.BackgroundImage"), System.Drawing.Image)
        Me.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.search_btn.Location = New System.Drawing.Point(267, 151)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(35, 23)
        Me.search_btn.TabIndex = 11
        Me.search_btn.UseVisualStyleBackColor = True
        '
        'kdbarang_txt
        '
        Me.kdbarang_txt.Location = New System.Drawing.Point(128, 152)
        Me.kdbarang_txt.Name = "kdbarang_txt"
        Me.kdbarang_txt.Size = New System.Drawing.Size(134, 20)
        Me.kdbarang_txt.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "No. Surat Keluar"
        '
        'tgl_lbl
        '
        Me.tgl_lbl.AutoSize = True
        Me.tgl_lbl.BackColor = System.Drawing.Color.Transparent
        Me.tgl_lbl.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_lbl.ForeColor = System.Drawing.Color.White
        Me.tgl_lbl.Location = New System.Drawing.Point(538, 56)
        Me.tgl_lbl.Name = "tgl_lbl"
        Me.tgl_lbl.Size = New System.Drawing.Size(61, 18)
        Me.tgl_lbl.TabIndex = 14
        Me.tgl_lbl.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nama Barang"
        '
        'nmBarang_txt
        '
        Me.nmBarang_txt.Location = New System.Drawing.Point(128, 183)
        Me.nmBarang_txt.Name = "nmBarang_txt"
        Me.nmBarang_txt.Size = New System.Drawing.Size(134, 20)
        Me.nmBarang_txt.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(5, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Jumlah"
        '
        'jumlah_txt
        '
        Me.jumlah_txt.Location = New System.Drawing.Point(128, 215)
        Me.jumlah_txt.Name = "jumlah_txt"
        Me.jumlah_txt.Size = New System.Drawing.Size(134, 20)
        Me.jumlah_txt.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Kondisi"
        '
        'kondisi_cb
        '
        Me.kondisi_cb.FormattingEnabled = True
        Me.kondisi_cb.Items.AddRange(New Object() {"Jual", "Pinjam"})
        Me.kondisi_cb.Location = New System.Drawing.Point(128, 244)
        Me.kondisi_cb.Name = "kondisi_cb"
        Me.kondisi_cb.Size = New System.Drawing.Size(134, 21)
        Me.kondisi_cb.TabIndex = 20
        '
        'noSuratJalan_txt
        '
        Me.noSuratJalan_txt.Location = New System.Drawing.Point(128, 61)
        Me.noSuratJalan_txt.Name = "noSuratJalan_txt"
        Me.noSuratJalan_txt.Size = New System.Drawing.Size(134, 20)
        Me.noSuratJalan_txt.TabIndex = 21
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdtranskeluarDataGridViewTextBoxColumn, Me.KdbarangDataGridViewTextBoxColumn, Me.NamaBarang, Me.JumlahDataGridViewTextBoxColumn, Me.KondisiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DetailkeluarBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(308, 151)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(321, 171)
        Me.DataGridView1.TabIndex = 22
        '
        'DetailkeluarBindingSource
        '
        Me.DetailkeluarBindingSource.DataMember = "detail_keluar"
        Me.DetailkeluarBindingSource.DataSource = Me.Dslengkap
        '
        'Dslengkap
        '
        Me.Dslengkap.DataSetName = "Dslengkap"
        Me.Dslengkap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'save_btn
        '
        Me.save_btn.BackgroundImage = CType(resources.GetObject("save_btn.BackgroundImage"), System.Drawing.Image)
        Me.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.save_btn.Location = New System.Drawing.Point(497, 328)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(132, 36)
        Me.save_btn.TabIndex = 23
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.BackgroundImage = CType(resources.GetObject("delete_btn.BackgroundImage"), System.Drawing.Image)
        Me.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delete_btn.Location = New System.Drawing.Point(150, 286)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(132, 36)
        Me.delete_btn.TabIndex = 24
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(605, 54)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 25
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(5, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Gudang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 18)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Rak"
        '
        'gudang_cb
        '
        Me.gudang_cb.FormattingEnabled = True
        Me.gudang_cb.Location = New System.Drawing.Point(128, 88)
        Me.gudang_cb.Name = "gudang_cb"
        Me.gudang_cb.Size = New System.Drawing.Size(134, 21)
        Me.gudang_cb.TabIndex = 28
        '
        'rak_cb
        '
        Me.rak_cb.FormattingEnabled = True
        Me.rak_cb.Location = New System.Drawing.Point(128, 117)
        Me.rak_cb.Name = "rak_cb"
        Me.rak_cb.Size = New System.Drawing.Size(134, 21)
        Me.rak_cb.TabIndex = 29
        '
        'txtKodeGudang
        '
        Me.txtKodeGudang.Location = New System.Drawing.Point(268, 89)
        Me.txtKodeGudang.Name = "txtKodeGudang"
        Me.txtKodeGudang.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeGudang.TabIndex = 57
        Me.txtKodeGudang.Visible = False
        '
        'KdtranskeluarDataGridViewTextBoxColumn
        '
        Me.KdtranskeluarDataGridViewTextBoxColumn.DataPropertyName = "kdtranskeluar"
        Me.KdtranskeluarDataGridViewTextBoxColumn.HeaderText = "kdtranskeluar"
        Me.KdtranskeluarDataGridViewTextBoxColumn.Name = "KdtranskeluarDataGridViewTextBoxColumn"
        Me.KdtranskeluarDataGridViewTextBoxColumn.Visible = False
        '
        'KdbarangDataGridViewTextBoxColumn
        '
        Me.KdbarangDataGridViewTextBoxColumn.DataPropertyName = "kdbarang"
        Me.KdbarangDataGridViewTextBoxColumn.HeaderText = "kdbarang"
        Me.KdbarangDataGridViewTextBoxColumn.Name = "KdbarangDataGridViewTextBoxColumn"
        Me.KdbarangDataGridViewTextBoxColumn.Visible = False
        '
        'NamaBarang
        '
        Me.NamaBarang.HeaderText = "Nama Barang"
        Me.NamaBarang.Name = "NamaBarang"
        '
        'JumlahDataGridViewTextBoxColumn
        '
        Me.JumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah"
        Me.JumlahDataGridViewTextBoxColumn.HeaderText = "jumlah"
        Me.JumlahDataGridViewTextBoxColumn.Name = "JumlahDataGridViewTextBoxColumn"
        '
        'KondisiDataGridViewTextBoxColumn
        '
        Me.KondisiDataGridViewTextBoxColumn.DataPropertyName = "kondisi"
        Me.KondisiDataGridViewTextBoxColumn.HeaderText = "kondisi"
        Me.KondisiDataGridViewTextBoxColumn.Name = "KondisiDataGridViewTextBoxColumn"
        '
        'FormKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.form_keluar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(643, 373)
        Me.Controls.Add(Me.txtKodeGudang)
        Me.Controls.Add(Me.rak_cb)
        Me.Controls.Add(Me.gudang_cb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.noSuratJalan_txt)
        Me.Controls.Add(Me.kondisi_cb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.jumlah_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nmBarang_txt)
        Me.Controls.Add(Me.tgl_lbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.kdbarang_txt)
        Me.Controls.Add(Me.insert_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKeluar"
        CType(Me.jumlah_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailkeluarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dslengkap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents insert_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents search_btn As System.Windows.Forms.Button
    Friend WithEvents kdbarang_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tgl_lbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nmBarang_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents jumlah_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents kondisi_cb As System.Windows.Forms.ComboBox
    Friend WithEvents noSuratJalan_txt As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gudang_cb As System.Windows.Forms.ComboBox
    Friend WithEvents rak_cb As System.Windows.Forms.ComboBox
    Friend WithEvents DetailkeluarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dslengkap As Gudang_Toko_Elektronik.Dslengkap
    Friend WithEvents txtKodeGudang As System.Windows.Forms.TextBox
    Friend WithEvents KdtranskeluarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KdbarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KondisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
