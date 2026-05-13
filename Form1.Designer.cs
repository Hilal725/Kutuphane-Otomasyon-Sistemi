namespace KutuphaneOtomasyonSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabArama = new TabPage();
            label2 = new Label();
            label1 = new Label();
            txtArama = new TextBox();
            cmbFiltre = new ComboBox();
            dataGridView = new DataGridView();
            tabUye = new TabPage();
            btnUyeGuncelle = new Button();
            btnUyeEkle = new Button();
            label6 = new Label();
            txtUyeEposta = new TextBox();
            label5 = new Label();
            txtUyeTel = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            txtUyeSoyad = new TextBox();
            txtUyeAd = new TextBox();
            dgvUyeler = new DataGridView();
            tabEmanet = new TabPage();
            btnOduncVer = new Button();
            label8 = new Label();
            label7 = new Label();
            dgvEmanetUyeler = new DataGridView();
            dgvEmanetKitaplar = new DataGridView();
            tabEmanetListesi = new TabPage();
            panel2 = new Panel();
            dgvEmanetDetay = new DataGridView();
            label9 = new Label();
            btnIadeAl = new Button();
            tabYonetim = new TabPage();
            panel1 = new Panel();
            label15 = new Label();
            txtYazarSoyad = new TextBox();
            txtYazarAd = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtBarkod = new TextBox();
            txtKitapAd = new TextBox();
            cmbKategori = new ComboBox();
            btnKitapSil = new Button();
            dgvKitapYonetim = new DataGridView();
            btnKitapGuncelle = new Button();
            btnKitapEkle = new Button();
            tabControl1.SuspendLayout();
            tabArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabUye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            tabEmanet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetUyeler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetKitaplar).BeginInit();
            tabEmanetListesi.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetDetay).BeginInit();
            tabYonetim.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitapYonetim).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabArama);
            tabControl1.Controls.Add(tabUye);
            tabControl1.Controls.Add(tabEmanet);
            tabControl1.Controls.Add(tabEmanetListesi);
            tabControl1.Controls.Add(tabYonetim);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(996, 577);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabArama
            // 
            tabArama.BackColor = Color.FromArgb(255, 255, 128);
            tabArama.Controls.Add(label2);
            tabArama.Controls.Add(label1);
            tabArama.Controls.Add(txtArama);
            tabArama.Controls.Add(cmbFiltre);
            tabArama.Controls.Add(dataGridView);
            tabArama.Location = new Point(4, 29);
            tabArama.Margin = new Padding(3, 4, 3, 4);
            tabArama.Name = "tabArama";
            tabArama.Padding = new Padding(3, 4, 3, 4);
            tabArama.Size = new Size(988, 544);
            tabArama.TabIndex = 1;
            tabArama.Text = "Kitap Arama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(511, 46);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 14;
            label2.Text = "Filtrele :  ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 45);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 13;
            label1.Text = "Arama : ";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(254, 42);
            txtArama.Margin = new Padding(3, 4, 3, 4);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(196, 27);
            txtArama.TabIndex = 12;
            txtArama.TextChanged += txtArama_TextChanged_1;
            // 
            // cmbFiltre
            // 
            cmbFiltre.FormattingEnabled = true;
            cmbFiltre.Items.AddRange(new object[] { "Kitap Adı", "Yazar", "Barkod" });
            cmbFiltre.Location = new Point(586, 42);
            cmbFiltre.Margin = new Padding(3, 4, 3, 4);
            cmbFiltre.Name = "cmbFiltre";
            cmbFiltre.Size = new Size(138, 28);
            cmbFiltre.TabIndex = 11;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(59, 127);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(867, 344);
            dataGridView.TabIndex = 10;
            // 
            // tabUye
            // 
            tabUye.BackColor = Color.FromArgb(255, 192, 128);
            tabUye.Controls.Add(btnUyeGuncelle);
            tabUye.Controls.Add(btnUyeEkle);
            tabUye.Controls.Add(label6);
            tabUye.Controls.Add(txtUyeEposta);
            tabUye.Controls.Add(label5);
            tabUye.Controls.Add(txtUyeTel);
            tabUye.Controls.Add(label4);
            tabUye.Controls.Add(label3);
            tabUye.Controls.Add(txtUyeSoyad);
            tabUye.Controls.Add(txtUyeAd);
            tabUye.Controls.Add(dgvUyeler);
            tabUye.Location = new Point(4, 29);
            tabUye.Margin = new Padding(3, 4, 3, 4);
            tabUye.Name = "tabUye";
            tabUye.Padding = new Padding(3, 4, 3, 4);
            tabUye.Size = new Size(988, 544);
            tabUye.TabIndex = 2;
            tabUye.Text = "Üye İşlemleri";
            // 
            // btnUyeGuncelle
            // 
            btnUyeGuncelle.Location = new Point(285, 441);
            btnUyeGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnUyeGuncelle.Name = "btnUyeGuncelle";
            btnUyeGuncelle.Size = new Size(117, 31);
            btnUyeGuncelle.TabIndex = 10;
            btnUyeGuncelle.Text = "Üye Güncelle";
            btnUyeGuncelle.UseVisualStyleBackColor = true;
            btnUyeGuncelle.Click += btnUyeGuncelle_Click;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Location = new Point(106, 441);
            btnUyeEkle.Margin = new Padding(3, 4, 3, 4);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(117, 31);
            btnUyeEkle.TabIndex = 9;
            btnUyeEkle.Text = "Üye Ekle";
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 324);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 8;
            label6.Text = "E-Posta :";
            // 
            // txtUyeEposta
            // 
            txtUyeEposta.Location = new Point(229, 316);
            txtUyeEposta.Margin = new Padding(3, 4, 3, 4);
            txtUyeEposta.Name = "txtUyeEposta";
            txtUyeEposta.Size = new Size(114, 27);
            txtUyeEposta.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 255);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 6;
            label5.Text = "Telefon no : ";
            // 
            // txtUyeTel
            // 
            txtUyeTel.Location = new Point(229, 251);
            txtUyeTel.Margin = new Padding(3, 4, 3, 4);
            txtUyeTel.Mask = "(999) 000-0000";
            txtUyeTel.Name = "txtUyeTel";
            txtUyeTel.Size = new Size(114, 27);
            txtUyeTel.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 183);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 4;
            label4.Text = "Soyad : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 117);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "Ad : ";
            // 
            // txtUyeSoyad
            // 
            txtUyeSoyad.Location = new Point(229, 179);
            txtUyeSoyad.Margin = new Padding(3, 4, 3, 4);
            txtUyeSoyad.Name = "txtUyeSoyad";
            txtUyeSoyad.Size = new Size(114, 27);
            txtUyeSoyad.TabIndex = 2;
            // 
            // txtUyeAd
            // 
            txtUyeAd.Location = new Point(229, 113);
            txtUyeAd.Margin = new Padding(3, 4, 3, 4);
            txtUyeAd.Name = "txtUyeAd";
            txtUyeAd.Size = new Size(114, 27);
            txtUyeAd.TabIndex = 1;
            // 
            // dgvUyeler
            // 
            dgvUyeler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUyeler.BackgroundColor = Color.FromArgb(255, 192, 128);
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.Location = new Point(452, 117);
            dgvUyeler.Margin = new Padding(3, 4, 3, 4);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.Size = new Size(415, 212);
            dgvUyeler.TabIndex = 0;
            dgvUyeler.CellContentClick += dgvUyeler_CellContentClick;
            // 
            // tabEmanet
            // 
            tabEmanet.BackColor = Color.FromArgb(128, 255, 128);
            tabEmanet.Controls.Add(btnOduncVer);
            tabEmanet.Controls.Add(label8);
            tabEmanet.Controls.Add(label7);
            tabEmanet.Controls.Add(dgvEmanetUyeler);
            tabEmanet.Controls.Add(dgvEmanetKitaplar);
            tabEmanet.Location = new Point(4, 29);
            tabEmanet.Margin = new Padding(3, 4, 3, 4);
            tabEmanet.Name = "tabEmanet";
            tabEmanet.Size = new Size(988, 544);
            tabEmanet.TabIndex = 3;
            tabEmanet.Text = "Emanet/Ödünç Ver";
            // 
            // btnOduncVer
            // 
            btnOduncVer.ImageAlign = ContentAlignment.BottomCenter;
            btnOduncVer.Location = new Point(647, 467);
            btnOduncVer.Margin = new Padding(3, 4, 3, 4);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(152, 31);
            btnOduncVer.TabIndex = 4;
            btnOduncVer.Text = "Kitabı Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(158, 74);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 3;
            label8.Text = "Seçili Kitap : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(817, 74);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 2;
            label7.Text = "Seçili Üye : ";
            // 
            // dgvEmanetUyeler
            // 
            dgvEmanetUyeler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvEmanetUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmanetUyeler.BackgroundColor = Color.FromArgb(128, 255, 128);
            dgvEmanetUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmanetUyeler.Location = new Point(806, 119);
            dgvEmanetUyeler.Margin = new Padding(3, 4, 3, 4);
            dgvEmanetUyeler.Name = "dgvEmanetUyeler";
            dgvEmanetUyeler.RowHeadersWidth = 51;
            dgvEmanetUyeler.Size = new Size(287, 256);
            dgvEmanetUyeler.TabIndex = 1;
            dgvEmanetUyeler.CellContentClick += dgvUyeler_CellContentClick;
            // 
            // dgvEmanetKitaplar
            // 
            dgvEmanetKitaplar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvEmanetKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmanetKitaplar.BackgroundColor = Color.FromArgb(128, 255, 128);
            dgvEmanetKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmanetKitaplar.Location = new Point(158, 119);
            dgvEmanetKitaplar.Margin = new Padding(3, 4, 3, 4);
            dgvEmanetKitaplar.Name = "dgvEmanetKitaplar";
            dgvEmanetKitaplar.RowHeadersWidth = 51;
            dgvEmanetKitaplar.Size = new Size(403, 256);
            dgvEmanetKitaplar.TabIndex = 0;
            // 
            // tabEmanetListesi
            // 
            tabEmanetListesi.BackColor = Color.FromArgb(128, 255, 255);
            tabEmanetListesi.Controls.Add(panel2);
            tabEmanetListesi.Location = new Point(4, 29);
            tabEmanetListesi.Name = "tabEmanetListesi";
            tabEmanetListesi.Padding = new Padding(3);
            tabEmanetListesi.Size = new Size(988, 544);
            tabEmanetListesi.TabIndex = 4;
            tabEmanetListesi.Text = "Emanet Listesi";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvEmanetDetay);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnIadeAl);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 538);
            panel2.TabIndex = 3;
            // 
            // dgvEmanetDetay
            // 
            dgvEmanetDetay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmanetDetay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmanetDetay.BackgroundColor = Color.FromArgb(128, 255, 255);
            dgvEmanetDetay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmanetDetay.Location = new Point(168, 87);
            dgvEmanetDetay.Name = "dgvEmanetDetay";
            dgvEmanetDetay.RowHeadersWidth = 51;
            dgvEmanetDetay.Size = new Size(701, 348);
            dgvEmanetDetay.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label9.Location = new Point(404, 22);
            label9.Name = "label9";
            label9.Size = new Size(198, 38);
            label9.TabIndex = 1;
            label9.Text = "Emanet Listesi";
            // 
            // btnIadeAl
            // 
            btnIadeAl.Anchor = AnchorStyles.Bottom;
            btnIadeAl.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnIadeAl.Location = new Point(432, 467);
            btnIadeAl.Name = "btnIadeAl";
            btnIadeAl.Size = new Size(170, 44);
            btnIadeAl.TabIndex = 2;
            btnIadeAl.Text = "İade Al";
            btnIadeAl.UseVisualStyleBackColor = true;
            btnIadeAl.Click += btnIadeAl_Click;
            // 
            // tabYonetim
            // 
            tabYonetim.Controls.Add(panel1);
            tabYonetim.Location = new Point(4, 29);
            tabYonetim.Name = "tabYonetim";
            tabYonetim.Padding = new Padding(3);
            tabYonetim.Size = new Size(988, 544);
            tabYonetim.TabIndex = 5;
            tabYonetim.Text = "Kitap Yönetim Sistemi";
            tabYonetim.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtYazarSoyad);
            panel1.Controls.Add(txtYazarAd);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtBarkod);
            panel1.Controls.Add(txtKitapAd);
            panel1.Controls.Add(cmbKategori);
            panel1.Controls.Add(btnKitapSil);
            panel1.Controls.Add(dgvKitapYonetim);
            panel1.Controls.Add(btnKitapGuncelle);
            panel1.Controls.Add(btnKitapEkle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 538);
            panel1.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(337, 269);
            label15.Name = "label15";
            label15.Size = new Size(104, 20);
            label15.TabIndex = 18;
            label15.Text = "Yazar Soyadı : ";
            // 
            // txtYazarSoyad
            // 
            txtYazarSoyad.Location = new Point(447, 266);
            txtYazarSoyad.Name = "txtYazarSoyad";
            txtYazarSoyad.Size = new Size(125, 27);
            txtYazarSoyad.TabIndex = 17;
            // 
            // txtYazarAd
            // 
            txtYazarAd.Location = new Point(447, 170);
            txtYazarAd.Name = "txtYazarAd";
            txtYazarAd.Size = new Size(125, 27);
            txtYazarAd.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label14.Location = new Point(823, 40);
            label14.Name = "label14";
            label14.Size = new Size(179, 38);
            label14.TabIndex = 15;
            label14.Text = "Kitap Listesi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(363, 173);
            label13.Name = "label13";
            label13.Size = new Size(78, 20);
            label13.TabIndex = 14;
            label13.Text = "Yazar Adı: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(231, 339);
            label12.Name = "label12";
            label12.Size = new Size(77, 20);
            label12.TabIndex = 13;
            label12.Text = "Kategori : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(116, 269);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 12;
            label11.Text = "Barkod : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(101, 170);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 11;
            label10.Text = "Kitap Adı : ";
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(189, 266);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(125, 27);
            txtBarkod.TabIndex = 10;
            // 
            // txtKitapAd
            // 
            txtKitapAd.Location = new Point(189, 167);
            txtKitapAd.Name = "txtKitapAd";
            txtKitapAd.Size = new Size(125, 27);
            txtKitapAd.TabIndex = 9;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(314, 336);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(151, 28);
            cmbKategori.TabIndex = 4;
            // 
            // btnKitapSil
            // 
            btnKitapSil.Location = new Point(269, 492);
            btnKitapSil.Name = "btnKitapSil";
            btnKitapSil.Size = new Size(94, 29);
            btnKitapSil.TabIndex = 7;
            btnKitapSil.Text = "Kitap Sil";
            btnKitapSil.UseVisualStyleBackColor = true;
            btnKitapSil.Click += btnKitapSil_Click;
            // 
            // dgvKitapYonetim
            // 
            dgvKitapYonetim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKitapYonetim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKitapYonetim.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvKitapYonetim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitapYonetim.Location = new Point(701, 135);
            dgvKitapYonetim.Name = "dgvKitapYonetim";
            dgvKitapYonetim.RowHeadersWidth = 51;
            dgvKitapYonetim.Size = new Size(276, 188);
            dgvKitapYonetim.TabIndex = 0;
            dgvKitapYonetim.CellClick += dgvKitapYonetim_CellClick;
            // 
            // btnKitapGuncelle
            // 
            btnKitapGuncelle.Location = new Point(314, 442);
            btnKitapGuncelle.Name = "btnKitapGuncelle";
            btnKitapGuncelle.Size = new Size(141, 29);
            btnKitapGuncelle.TabIndex = 6;
            btnKitapGuncelle.Text = "Kitap Güncelle";
            btnKitapGuncelle.UseVisualStyleBackColor = true;
            btnKitapGuncelle.Click += btnKitapGuncelle_Click;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Location = new Point(411, 492);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(94, 29);
            btnKitapEkle.TabIndex = 5;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(996, 577);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabArama.ResumeLayout(false);
            tabArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabUye.ResumeLayout(false);
            tabUye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            tabEmanet.ResumeLayout(false);
            tabEmanet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetUyeler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetKitaplar).EndInit();
            tabEmanetListesi.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetDetay).EndInit();
            tabYonetim.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitapYonetim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;

        public Form1(TabPage tabPage1) => this.tabPage1 = tabPage1 ?? throw new ArgumentNullException(nameof(tabPage1));

        private TabPage tabArama;
        private Label label2;
        private Label label1;
        private TextBox txtArama;
        private ComboBox cmbFiltre;
        private DataGridView dataGridView;
        private TabPage tabUye;
        private TabPage tabEmanet;
        private MaskedTextBox txtUyeTel;
        private Label label4;
        private Label label3;
        private TextBox txtUyeSoyad;
        private TextBox txtUyeAd;
        private DataGridView dgvUyeler;
        private Button btnUyeGuncelle;
        private Button btnUyeEkle;
        private Label label6;
        private TextBox txtUyeEposta;
        private Label label5;
        private Button btnOduncVer;
        private Label label8;
        private Label label7;
        private DataGridView dgvEmanetUyeler;
        private DataGridView dgvEmanetKitaplar;
        private TabPage tabEmanetListesi;
        private DataGridView dgvEmanetDetay;
        private Label label9;
        private Button btnIadeAl;
        private TabPage tabYonetim;
        private DataGridView dgvKitapYonetim;
        private Panel panel1;
        private ComboBox cmbKategori;
        private Button btnKitapGuncelle;
        private Button btnKitapEkle;
        private Button btnKitapSil;
        private TextBox txtBarkod;
        private TextBox txtKitapAd;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label15;
        private TextBox txtYazarSoyad;
        private TextBox txtYazarAd;
        private Panel panel2;
    }
}
