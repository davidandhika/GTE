<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReport))
        Me.close_btn = New System.Windows.Forms.Button()
        Me.RptBarang = New System.Windows.Forms.Button()
        Me.RptTransKeluar = New System.Windows.Forms.Button()
        Me.RptTransMasuk = New System.Windows.Forms.Button()
        Me.opname_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(620, 1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 25
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'RptBarang
        '
        Me.RptBarang.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_barang
        Me.RptBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RptBarang.Location = New System.Drawing.Point(64, 130)
        Me.RptBarang.Name = "RptBarang"
        Me.RptBarang.Size = New System.Drawing.Size(100, 100)
        Me.RptBarang.TabIndex = 26
        Me.RptBarang.UseVisualStyleBackColor = True
        '
        'RptTransKeluar
        '
        Me.RptTransKeluar.BackgroundImage = CType(resources.GetObject("RptTransKeluar.BackgroundImage"), System.Drawing.Image)
        Me.RptTransKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RptTransKeluar.Location = New System.Drawing.Point(352, 130)
        Me.RptTransKeluar.Name = "RptTransKeluar"
        Me.RptTransKeluar.Size = New System.Drawing.Size(100, 100)
        Me.RptTransKeluar.TabIndex = 28
        Me.RptTransKeluar.UseVisualStyleBackColor = True
        '
        'RptTransMasuk
        '
        Me.RptTransMasuk.BackgroundImage = CType(resources.GetObject("RptTransMasuk.BackgroundImage"), System.Drawing.Image)
        Me.RptTransMasuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RptTransMasuk.Location = New System.Drawing.Point(211, 130)
        Me.RptTransMasuk.Name = "RptTransMasuk"
        Me.RptTransMasuk.Size = New System.Drawing.Size(100, 100)
        Me.RptTransMasuk.TabIndex = 27
        Me.RptTransMasuk.UseVisualStyleBackColor = True
        '
        'opname_btn
        '
        Me.opname_btn.BackgroundImage = CType(resources.GetObject("opname_btn.BackgroundImage"), System.Drawing.Image)
        Me.opname_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.opname_btn.Location = New System.Drawing.Point(491, 130)
        Me.opname_btn.Name = "opname_btn"
        Me.opname_btn.Size = New System.Drawing.Size(100, 100)
        Me.opname_btn.TabIndex = 29
        Me.opname_btn.UseVisualStyleBackColor = True
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.form_menu_administrator
        Me.ClientSize = New System.Drawing.Size(645, 395)
        Me.Controls.Add(Me.opname_btn)
        Me.Controls.Add(Me.RptTransKeluar)
        Me.Controls.Add(Me.RptTransMasuk)
        Me.Controls.Add(Me.RptBarang)
        Me.Controls.Add(Me.close_btn)
        Me.Name = "FrmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Report"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents RptBarang As System.Windows.Forms.Button
    Friend WithEvents RptTransKeluar As System.Windows.Forms.Button
    Friend WithEvents RptTransMasuk As System.Windows.Forms.Button
    Friend WithEvents opname_btn As System.Windows.Forms.Button
End Class
