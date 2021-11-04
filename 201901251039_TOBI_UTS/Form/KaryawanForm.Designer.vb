<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KaryawanForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KaryawanForm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboPendidikan = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.tbJmlAnak = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.tbUmur = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboGolDar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comboAgama = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tbTlp = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbKtp = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radioFemale = New System.Windows.Forms.RadioButton()
        Me.radioMale = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.tbNik = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(797, 483)
        Me.DataGridView1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(547, -158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(672, 498)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(461, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 541)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Karyawan PT. Zona Code Indonesia tahun 2021"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(814, 504)
        Me.Panel2.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.comboStatus)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.comboPendidikan)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.comboGolDar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.comboAgama)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 728)
        Me.Panel1.TabIndex = 12
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(293, 659)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 40)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Red
        Me.btnHapus.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHapus.Location = New System.Drawing.Point(168, 659)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(119, 40)
        Me.btnHapus.TabIndex = 33
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSimpan.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSimpan.Location = New System.Drawing.Point(47, 659)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(115, 40)
        Me.btnSimpan.TabIndex = 32
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(242, 565)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Status Perkawinan"
        '
        'comboStatus
        '
        Me.comboStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboStatus.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.comboStatus.ForeColor = System.Drawing.Color.White
        Me.comboStatus.FormattingEnabled = True
        Me.comboStatus.Items.AddRange(New Object() {"SINGLE", "MENIKAH", "BERCERAI"})
        Me.comboStatus.Location = New System.Drawing.Point(235, 588)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(164, 33)
        Me.comboStatus.TabIndex = 30
        Me.comboStatus.Text = "SINGLE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(51, 565)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Pendidikan Terakhir"
        '
        'comboPendidikan
        '
        Me.comboPendidikan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboPendidikan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboPendidikan.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.comboPendidikan.ForeColor = System.Drawing.Color.White
        Me.comboPendidikan.FormattingEnabled = True
        Me.comboPendidikan.Items.AddRange(New Object() {"SD", "SMP", "SMA", "S1", "S2", "S3"})
        Me.comboPendidikan.Location = New System.Drawing.Point(47, 588)
        Me.comboPendidikan.Name = "comboPendidikan"
        Me.comboPendidikan.Size = New System.Drawing.Size(151, 33)
        Me.comboPendidikan.TabIndex = 28
        Me.comboPendidikan.Text = "SMA"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.tbJmlAnak)
        Me.GroupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox8.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox8.Location = New System.Drawing.Point(235, 495)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(166, 60)
        Me.GroupBox8.TabIndex = 26
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Jumlah Anak"
        '
        'tbJmlAnak
        '
        Me.tbJmlAnak.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbJmlAnak.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbJmlAnak.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.tbJmlAnak.ForeColor = System.Drawing.Color.White
        Me.tbJmlAnak.Location = New System.Drawing.Point(11, 24)
        Me.tbJmlAnak.Name = "tbJmlAnak"
        Me.tbJmlAnak.Size = New System.Drawing.Size(134, 23)
        Me.tbJmlAnak.TabIndex = 0
        Me.tbJmlAnak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.tbUmur)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox7.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox7.Location = New System.Drawing.Point(47, 495)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(166, 60)
        Me.GroupBox7.TabIndex = 24
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Umur"
        '
        'tbUmur
        '
        Me.tbUmur.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbUmur.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUmur.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.tbUmur.ForeColor = System.Drawing.Color.White
        Me.tbUmur.Location = New System.Drawing.Point(11, 24)
        Me.tbUmur.Name = "tbUmur"
        Me.tbUmur.Size = New System.Drawing.Size(134, 23)
        Me.tbUmur.TabIndex = 0
        Me.tbUmur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.tbAlamat)
        Me.GroupBox6.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox6.Location = New System.Drawing.Point(47, 223)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(354, 60)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Alamat"
        '
        'tbAlamat
        '
        Me.tbAlamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAlamat.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.tbAlamat.ForeColor = System.Drawing.Color.White
        Me.tbAlamat.Location = New System.Drawing.Point(11, 24)
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.Size = New System.Drawing.Size(333, 23)
        Me.tbAlamat.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(242, 428)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Golongan Darah"
        '
        'comboGolDar
        '
        Me.comboGolDar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboGolDar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboGolDar.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.comboGolDar.ForeColor = System.Drawing.Color.White
        Me.comboGolDar.FormattingEnabled = True
        Me.comboGolDar.Items.AddRange(New Object() {"O", "A", "B", "AB", "A+", "B+"})
        Me.comboGolDar.Location = New System.Drawing.Point(235, 451)
        Me.comboGolDar.Name = "comboGolDar"
        Me.comboGolDar.Size = New System.Drawing.Size(72, 33)
        Me.comboGolDar.TabIndex = 25
        Me.comboGolDar.Text = "O"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(54, 428)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Agama"
        '
        'comboAgama
        '
        Me.comboAgama.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboAgama.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboAgama.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.comboAgama.ForeColor = System.Drawing.Color.White
        Me.comboAgama.FormattingEnabled = True
        Me.comboAgama.Items.AddRange(New Object() {"ISLAM", "KRISTEN", "HINDU", "BUDHA", "KONGHUCU"})
        Me.comboAgama.Location = New System.Drawing.Point(47, 451)
        Me.comboAgama.Name = "comboAgama"
        Me.comboAgama.Size = New System.Drawing.Size(151, 33)
        Me.comboAgama.TabIndex = 16
        Me.comboAgama.Text = "ISLAM"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.tbTlp)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox5.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox5.Location = New System.Drawing.Point(47, 289)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(354, 60)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "No. Telpon"
        '
        'tbTlp
        '
        Me.tbTlp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbTlp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbTlp.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.tbTlp.ForeColor = System.Drawing.Color.White
        Me.tbTlp.Location = New System.Drawing.Point(11, 24)
        Me.tbTlp.Name = "tbTlp"
        Me.tbTlp.Size = New System.Drawing.Size(333, 23)
        Me.tbTlp.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.tbKtp)
        Me.GroupBox3.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox3.Location = New System.Drawing.Point(47, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 60)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "No. KTP"
        '
        'tbKtp
        '
        Me.tbKtp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbKtp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbKtp.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.tbKtp.ForeColor = System.Drawing.Color.White
        Me.tbKtp.Location = New System.Drawing.Point(11, 24)
        Me.tbKtp.Name = "tbKtp"
        Me.tbKtp.Size = New System.Drawing.Size(333, 23)
        Me.tbKtp.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.radioFemale)
        Me.GroupBox4.Controls.Add(Me.radioMale)
        Me.GroupBox4.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox4.Location = New System.Drawing.Point(47, 355)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(354, 60)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Jenis Kelamin"
        '
        'radioFemale
        '
        Me.radioFemale.AutoSize = True
        Me.radioFemale.Font = New System.Drawing.Font("Franklin Gothic Book", 14.0!)
        Me.radioFemale.Location = New System.Drawing.Point(163, 20)
        Me.radioFemale.Name = "radioFemale"
        Me.radioFemale.Size = New System.Drawing.Size(153, 34)
        Me.radioFemale.TabIndex = 1
        Me.radioFemale.TabStop = True
        Me.radioFemale.Text = "Perempuan"
        Me.radioFemale.UseVisualStyleBackColor = True
        '
        'radioMale
        '
        Me.radioMale.AutoSize = True
        Me.radioMale.Font = New System.Drawing.Font("Franklin Gothic Book", 14.0!)
        Me.radioMale.Location = New System.Drawing.Point(39, 20)
        Me.radioMale.Name = "radioMale"
        Me.radioMale.Size = New System.Drawing.Size(120, 34)
        Me.radioMale.TabIndex = 0
        Me.radioMale.TabStop = True
        Me.radioMale.Text = "Laki-laki"
        Me.radioMale.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.tbNama)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox2.Location = New System.Drawing.Point(47, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 60)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nama"
        '
        'tbNama
        '
        Me.tbNama.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNama.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.tbNama.ForeColor = System.Drawing.Color.White
        Me.tbNama.Location = New System.Drawing.Point(11, 24)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(333, 23)
        Me.tbNama.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.tbNik)
        Me.GroupBox9.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox9.Location = New System.Drawing.Point(47, 25)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(354, 60)
        Me.GroupBox9.TabIndex = 17
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Nomor Induk Karyawan"
        '
        'tbNik
        '
        Me.tbNik.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbNik.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNik.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.tbNik.ForeColor = System.Drawing.Color.White
        Me.tbNik.Location = New System.Drawing.Point(11, 24)
        Me.tbNik.Name = "tbNik"
        Me.tbNik.Size = New System.Drawing.Size(333, 23)
        Me.tbNik.TabIndex = 0
        '
        'KaryawanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1313, 718)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "KaryawanForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Karyawan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comboPendidikan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents tbJmlAnak As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents tbUmur As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents tbAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboGolDar As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents comboAgama As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents tbTlp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbKtp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents radioFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radioMale As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents tbNik As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
