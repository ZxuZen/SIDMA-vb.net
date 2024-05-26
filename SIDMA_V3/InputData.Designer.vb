<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputData
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdAktif = New System.Windows.Forms.RadioButton()
        Me.rdNon = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdLanang = New System.Windows.Forms.RadioButton()
        Me.rdWedok = New System.Windows.Forms.RadioButton()
        Me.cbKelas = New System.Windows.Forms.ComboBox()
        Me.cbAngkatan = New System.Windows.Forms.ComboBox()
        Me.btnPTI = New System.Windows.Forms.Button()
        Me.btnSI = New System.Windows.Forms.Button()
        Me.btnTI = New System.Windows.Forms.Button()
        Me.btnDelData = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnView = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdAktif)
        Me.GroupBox2.Controls.Add(Me.rdNon)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(213, 379)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 35)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'rdAktif
        '
        Me.rdAktif.AutoSize = True
        Me.rdAktif.Location = New System.Drawing.Point(3, 12)
        Me.rdAktif.Name = "rdAktif"
        Me.rdAktif.Size = New System.Drawing.Size(53, 20)
        Me.rdAktif.TabIndex = 0
        Me.rdAktif.TabStop = True
        Me.rdAktif.Text = "Aktif"
        Me.rdAktif.UseVisualStyleBackColor = True
        '
        'rdNon
        '
        Me.rdNon.AutoSize = True
        Me.rdNon.Location = New System.Drawing.Point(187, 12)
        Me.rdNon.Name = "rdNon"
        Me.rdNon.Size = New System.Drawing.Size(91, 20)
        Me.rdNon.TabIndex = 0
        Me.rdNon.TabStop = True
        Me.rdNon.Text = "Tidak Aktif"
        Me.rdNon.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.rdLanang)
        Me.GroupBox1.Controls.Add(Me.rdWedok)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(213, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 40)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'rdLanang
        '
        Me.rdLanang.AutoSize = True
        Me.rdLanang.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdLanang.Location = New System.Drawing.Point(5, 13)
        Me.rdLanang.Name = "rdLanang"
        Me.rdLanang.Size = New System.Drawing.Size(82, 20)
        Me.rdLanang.TabIndex = 0
        Me.rdLanang.TabStop = True
        Me.rdLanang.Text = "Laki-Laki"
        Me.rdLanang.UseVisualStyleBackColor = False
        '
        'rdWedok
        '
        Me.rdWedok.AutoSize = True
        Me.rdWedok.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdWedok.Location = New System.Drawing.Point(179, 13)
        Me.rdWedok.Name = "rdWedok"
        Me.rdWedok.Size = New System.Drawing.Size(98, 20)
        Me.rdWedok.TabIndex = 0
        Me.rdWedok.TabStop = True
        Me.rdWedok.Text = "Perempuan"
        Me.rdWedok.UseVisualStyleBackColor = False
        '
        'cbKelas
        '
        Me.cbKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKelas.FormattingEnabled = True
        Me.cbKelas.Location = New System.Drawing.Point(213, 289)
        Me.cbKelas.Name = "cbKelas"
        Me.cbKelas.Size = New System.Drawing.Size(282, 24)
        Me.cbKelas.TabIndex = 6
        '
        'cbAngkatan
        '
        Me.cbAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAngkatan.FormattingEnabled = True
        Me.cbAngkatan.Items.AddRange(New Object() {"2024", "2023", "2022", "2021", "2020", "2019"})
        Me.cbAngkatan.Location = New System.Drawing.Point(213, 193)
        Me.cbAngkatan.Name = "cbAngkatan"
        Me.cbAngkatan.Size = New System.Drawing.Size(282, 24)
        Me.cbAngkatan.TabIndex = 2
        '
        'btnPTI
        '
        Me.btnPTI.Location = New System.Drawing.Point(322, 239)
        Me.btnPTI.Name = "btnPTI"
        Me.btnPTI.Size = New System.Drawing.Size(75, 23)
        Me.btnPTI.TabIndex = 4
        Me.btnPTI.Text = "PTI"
        Me.btnPTI.UseVisualStyleBackColor = True
        '
        'btnSI
        '
        Me.btnSI.Location = New System.Drawing.Point(420, 239)
        Me.btnSI.Name = "btnSI"
        Me.btnSI.Size = New System.Drawing.Size(75, 23)
        Me.btnSI.TabIndex = 5
        Me.btnSI.Text = "SI"
        Me.btnSI.UseVisualStyleBackColor = True
        '
        'btnTI
        '
        Me.btnTI.Location = New System.Drawing.Point(213, 239)
        Me.btnTI.Name = "btnTI"
        Me.btnTI.Size = New System.Drawing.Size(75, 23)
        Me.btnTI.TabIndex = 3
        Me.btnTI.Text = "TI"
        Me.btnTI.UseVisualStyleBackColor = True
        '
        'btnDelData
        '
        Me.btnDelData.Location = New System.Drawing.Point(420, 472)
        Me.btnDelData.Name = "btnDelData"
        Me.btnDelData.Size = New System.Drawing.Size(75, 32)
        Me.btnDelData.TabIndex = 12
        Me.btnDelData.Text = "Hapus"
        Me.btnDelData.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(152, 472)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(75, 32)
        Me.btnClearForm.TabIndex = 10
        Me.btnClearForm.Text = "Clear"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(17, 472)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 32)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Simpan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(288, 472)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 32)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(213, 140)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(282, 22)
        Me.txtNama.TabIndex = 1
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(213, 99)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(282, 22)
        Me.txtNIM.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(12, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 28)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(12, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 28)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Jenis Kelamin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(12, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 28)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Kelas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(12, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 28)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Angkatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(625, 48)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Sistem Input Data Mahasiswa"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(758, 98)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(71, 23)
        Me.btnCari.TabIndex = 106
        Me.btnCari.Text = "Search"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(571, 99)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(181, 22)
        Me.txtCari.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(571, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(807, 405)
        Me.DataGridView1.TabIndex = 107
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "NIM"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Nama"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Angkatan"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 93
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Kelas"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Jenis Kelamin"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 119
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Status"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 73
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(1252, 99)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(126, 23)
        Me.btnView.TabIndex = 108
        Me.btnView.Text = "View List"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'InputData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1390, 544)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbKelas)
        Me.Controls.Add(Me.cbAngkatan)
        Me.Controls.Add(Me.btnPTI)
        Me.Controls.Add(Me.btnSI)
        Me.Controls.Add(Me.btnTI)
        Me.Controls.Add(Me.btnDelData)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputData"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIDMA"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdAktif As RadioButton
    Friend WithEvents rdNon As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdLanang As RadioButton
    Friend WithEvents rdWedok As RadioButton
    Friend WithEvents cbKelas As ComboBox
    Friend WithEvents cbAngkatan As ComboBox
    Friend WithEvents btnPTI As Button
    Friend WithEvents btnSI As Button
    Friend WithEvents btnTI As Button
    Friend WithEvents btnDelData As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btnView As Button
End Class
