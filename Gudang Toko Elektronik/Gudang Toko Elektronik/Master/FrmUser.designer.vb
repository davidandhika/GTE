<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUser))
        Me.cmbJabatan = New System.Windows.Forms.ComboBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblIDUser = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbJabatan
        '
        Me.cmbJabatan.FormattingEnabled = True
        Me.cmbJabatan.Items.AddRange(New Object() {"Administrator", "Gudang"})
        Me.cmbJabatan.Location = New System.Drawing.Point(198, 173)
        Me.cmbJabatan.Name = "cmbJabatan"
        Me.cmbJabatan.Size = New System.Drawing.Size(170, 21)
        Me.cmbJabatan.TabIndex = 34
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(620, 2)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 33
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(482, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.DimGray
        Me.btnBrowse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnBrowse.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnBrowse.Location = New System.Drawing.Point(426, 79)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(70, 23)
        Me.btnBrowse.TabIndex = 31
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DimGray
        Me.btnUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnUpdate.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnUpdate.Location = New System.Drawing.Point(426, 239)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(70, 23)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnSave.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnSave.Location = New System.Drawing.Point(350, 239)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 23)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtUsername.Location = New System.Drawing.Point(198, 110)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(298, 23)
        Me.txtUsername.TabIndex = 27
        '
        'lblIDUser
        '
        Me.lblIDUser.BackColor = System.Drawing.Color.Transparent
        Me.lblIDUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIDUser.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDUser.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblIDUser.Location = New System.Drawing.Point(198, 79)
        Me.lblIDUser.Name = "lblIDUser"
        Me.lblIDUser.Size = New System.Drawing.Size(170, 23)
        Me.lblIDUser.TabIndex = 26
        Me.lblIDUser.Text = "Label1"
        Me.lblIDUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtPassword.Location = New System.Drawing.Point(198, 141)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(298, 23)
        Me.txtPassword.TabIndex = 35
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'FrmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.form_master_user
        Me.ClientSize = New System.Drawing.Size(645, 395)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.cmbJabatan)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblIDUser)
        Me.Name = "FrmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblIDUser As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
End Class
