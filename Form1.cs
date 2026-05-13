using Microsoft.Data.SqlClient;
using System.Data;

namespace KutuphaneOtomasyonSistemi
{
    public partial class Form1 : Form
    {
        
        string connectionString = @"Server=.\SQLEXPRESS;Database=Kutuphane;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";

        bool formYuklendi = false;

        public Form1()
        {
            InitializeComponent();
        }

        #region Form ve Genel Ayar Metotları
        private void Form1_Load(object sender, EventArgs e)
        {
            
            SetGridSettings(dataGridView);
            SetGridSettings(dgvUyeler);
            SetGridSettings(dgvEmanetKitaplar);
            SetGridSettings(dgvEmanetUyeler);
            SetGridSettings(dgvEmanetDetay);

            cmbFiltre.SelectedIndex = 0;

           
            VerileriGetir();               
            UyeListele();                 
            EmanetEkraniniYenile();       
            EmanetDetaylariniGetir();     
            KitapBilgiElemanlariniDoldur();

            formYuklendi = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) VerileriGetir();
            else if (tabControl1.SelectedIndex == 1) UyeListele();
            else if (tabControl1.SelectedIndex == 2) EmanetEkraniniYenile();
            else if (tabControl1.SelectedIndex == 3) EmanetDetaylariniGetir();
            else if (tabControl1.SelectedIndex == 4)
            {
                KitapBilgiElemanlariniDoldur(); 
                VerileriGetir();              
            }
        }

        private void SetGridSettings(DataGridView dgv)
        {
            if (dgv == null) return;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        #endregion

        #region Yardımcı Veri Metotları
        private DataTable VeriTablosuGetir(string sorgu, params SqlParameter[] parametreler)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                if (parametreler != null) da.SelectCommand.Parameters.AddRange(parametreler);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        private void KomutYurut(string sorgu, params SqlParameter[] parametreler)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                if (parametreler != null) komut.Parameters.AddRange(parametreler);
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }
        #endregion

        #region Kitap Listeleme ve Arama İşlemleri
        private void VerileriGetir(string aramaSorgusu = "")
        {
            try
            {
                string anaSorgu = @"
            SELECT k.KitapID, k.KitapAd AS 'Kitap Adı', y.Ad + ' ' + y.Soyad AS 'Yazar', 
                   kat.KategoriAd AS 'Kategori', k.Barkod,
                   CASE WHEN k.Durum = 1 THEN 'Rafta' ELSE 'Ödünçte' END AS 'Durum'
            FROM Kitaplar k
            INNER JOIN Yazarlar y ON k.YazarID = y.YazarID
            INNER JOIN Kategoriler kat ON k.KategoriID = kat.KategoriID";

                if (!string.IsNullOrEmpty(aramaSorgusu))
                    anaSorgu += " WHERE " + aramaSorgusu;

                DataTable dt = VeriTablosuGetir(anaSorgu, new SqlParameter("@p1", "%" + txtArama.Text.Trim() + "%"));

                
                dataGridView.DataSource = dt;
                if (dataGridView.Columns.Contains("KitapID")) dataGridView.Columns["KitapID"].Visible = false;

                
                if (dgvKitapYonetim != null)
                {
                    dgvKitapYonetim.DataSource = dt;
                    if (dgvKitapYonetim.Columns.Contains("KitapID")) dgvKitapYonetim.Columns["KitapID"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void txtArama_TextChanged_1(object sender, EventArgs e)
        {
            if (!formYuklendi) return;

            if (string.IsNullOrWhiteSpace(txtArama.Text))
            {
                VerileriGetir();
                return;
            }

            string filtreSorgusu = "";

            switch (cmbFiltre.SelectedIndex)
            {
                case 0: 
                    filtreSorgusu = "k.KitapAd LIKE @p1";
                    break;
                case 1: 
                    filtreSorgusu = "(y.Ad + ' ' + y.Soyad) LIKE @p1";
                    break;
                case 2: 
                    filtreSorgusu = "k.Barkod LIKE @p1";
                    break;
            }

            VerileriGetir(filtreSorgusu);
        }
        #endregion

        #region Üye Yönetimi İşlemleri
        private void UyeListele()
        {
            dgvUyeler.DataSource = VeriTablosuGetir("SELECT UyeID, Ad, Soyad, Telefon, Eposta, KayitTarihi FROM Uyeler");
        }

        private void dgvUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUyeAd.Text = dgvUyeler.CurrentRow.Cells["Ad"].Value.ToString();
                txtUyeSoyad.Text = dgvUyeler.CurrentRow.Cells["Soyad"].Value.ToString();
                txtUyeTel.Text = dgvUyeler.CurrentRow.Cells["Telefon"].Value.ToString();
                txtUyeEposta.Text = dgvUyeler.CurrentRow.Cells["Eposta"].Value.ToString();
            }
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUyeAd.Text) || string.IsNullOrWhiteSpace(txtUyeSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad alanları boş bırakılamaz!");
                return;
            }

            string sorgu = "INSERT INTO Uyeler (Ad, Soyad, Telefon, Eposta, KayitTarihi) VALUES (@ad, @soyad, @tel, @mail, GETDATE())";
            KomutYurut(sorgu,
              new SqlParameter("@ad", txtUyeAd.Text.Trim()),
              new SqlParameter("@soyad", txtUyeSoyad.Text.Trim()),
              new SqlParameter("@tel", txtUyeTel.Text),
              new SqlParameter("@mail", txtUyeEposta.Text.Trim()));

            MessageBox.Show("Üye başarıyla eklendi.");
            UyeListele();
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null) return;

            int seciliUyeID = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["UyeID"].Value);
            string sorgu = "UPDATE Uyeler SET Ad=@ad, Soyad=@soyad, Telefon=@tel, Eposta=@mail WHERE UyeID=@id";

            KomutYurut(sorgu,
              new SqlParameter("@ad", txtUyeAd.Text.Trim()),
              new SqlParameter("@soyad", txtUyeSoyad.Text.Trim()),
              new SqlParameter("@tel", txtUyeTel.Text),
              new SqlParameter("@mail", txtUyeEposta.Text.Trim()),
              new SqlParameter("@id", seciliUyeID));

            MessageBox.Show("Üye bilgileri güncellendi.");
            UyeListele();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListele();
        }
        #endregion

        #region Emanet ve İade İşlemleri
        private void EmanetEkraniniYenile()
        {
            dgvEmanetKitaplar.DataSource = VeriTablosuGetir("SELECT KitapID, KitapAd, Barkod FROM Kitaplar WHERE Durum = 1");
            dgvEmanetUyeler.DataSource = VeriTablosuGetir("SELECT UyeID, Ad + ' ' + Soyad AS 'Üye Adı' FROM Uyeler");
        }

        private void EmanetDetaylariniGetir()
        {
            string sorgu = @"
        SELECT 
            e.EmanetID, 
            u.Ad + ' ' + u.Soyad AS 'Üye Ad Soyad', 
            k.KitapAd AS 'Kitap Adı',
            e.VerilisTarihi AS 'Veriliş Tarihi',
            e.TeslimTarihi AS 'İade Tarihi',
            CASE WHEN e.IslemBitti = 0 THEN 'Teslim Edilmedi' ELSE 'Teslim Edildi' END AS 'Durum'
        FROM Emanetler e
        INNER JOIN Uyeler u ON e.UyeID = u.UyeID
        INNER JOIN Kitaplar k ON e.KitapID = k.KitapID
        ORDER BY e.IslemBitti ASC, e.VerilisTarihi DESC";

            dgvEmanetDetay.DataSource = VeriTablosuGetir(sorgu);
        }

        private void btnOduncVer_Click_1(object sender, EventArgs e)
        {
            if (dgvEmanetKitaplar.CurrentRow == null || dgvEmanetUyeler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen tablolardan bir kitap ve bir üye seçin!");
                return;
            }

            int seciliKitapID = Convert.ToInt32(dgvEmanetKitaplar.CurrentRow.Cells["KitapID"].Value);
            int seciliUyeID = Convert.ToInt32(dgvEmanetUyeler.CurrentRow.Cells["UyeID"].Value);

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                SqlTransaction trx = baglanti.BeginTransaction();
                try
                {
                    string emanetSorgu = "INSERT INTO Emanetler (KitapID, UyeID, VerilisTarihi, IslemBitti) VALUES (@kId, @uId, GETDATE(), 0)";
                    SqlCommand cmdEmanet = new SqlCommand(emanetSorgu, baglanti, trx);
                    cmdEmanet.Parameters.AddWithValue("@kId", seciliKitapID);
                    cmdEmanet.Parameters.AddWithValue("@uId", seciliUyeID);
                    cmdEmanet.ExecuteNonQuery();

                    string kitapGuncelleSorgu = "UPDATE Kitaplar SET Durum = 0 WHERE KitapID = @kId";
                    SqlCommand cmdKitap = new SqlCommand(kitapGuncelleSorgu, baglanti, trx);
                    cmdKitap.Parameters.AddWithValue("@kId", seciliKitapID);
                    cmdKitap.ExecuteNonQuery();

                    trx.Commit();
                    MessageBox.Show("Ödünç verme işlemi başarıyla tamamlandı!");
                    EmanetEkraniniYenile();
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    MessageBox.Show("İşlem hatası: " + ex.Message);
                }
            }
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            if (dgvEmanetDetay.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iade edilecek işlemi listeden seçin!");
                return;
            }

            if (dgvEmanetDetay.CurrentRow.Cells["Durum"].Value.ToString() == "Teslim Edildi")
            {
                MessageBox.Show("bu kitap zaten iade edilmiş!");
                return;
            }

            int emanetID = Convert.ToInt32(dgvEmanetDetay.CurrentRow.Cells["EmanetID"].Value);

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                SqlTransaction trx = baglanti.BeginTransaction();

                try
                {
                    string idBulSorgu = "SELECT KitapID FROM Emanetler WHERE EmanetID = @eId";
                    SqlCommand cmdId = new SqlCommand(idBulSorgu, baglanti, trx);
                    cmdId.Parameters.AddWithValue("@eId", emanetID);
                    int kitapID = Convert.ToInt32(cmdId.ExecuteScalar());

                    string iadeSorgu = "UPDATE Emanetler SET IslemBitti = 1, TeslimTarihi = GETDATE() WHERE EmanetID = @eId";
                    SqlCommand cmdIade = new SqlCommand(iadeSorgu, baglanti, trx);
                    cmdIade.Parameters.AddWithValue("@eId", emanetID);
                    cmdIade.ExecuteNonQuery();

                    string kitapGuncelle = "UPDATE Kitaplar SET Durum = 1 WHERE KitapID = @kId";
                    SqlCommand cmdKitap = new SqlCommand(kitapGuncelle, baglanti, trx);
                    cmdKitap.Parameters.AddWithValue("@kId", kitapID);
                    cmdKitap.ExecuteNonQuery();

                    trx.Commit();
                    MessageBox.Show("Kitap başarıyla iade alındı. Raf durumu güncellendi.");
                    EmanetDetaylariniGetir();
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    MessageBox.Show("İade işlemi sırasında hata oluştu: " + ex.Message);
                }
            }
        }
        #endregion

        #region Kitap ve Yazar Yönetimi İşlemleri
        private void KitapBilgiElemanlariniDoldur()
        {
            cmbKategori.DataSource = VeriTablosuGetir("SELECT KategoriID, KategoriAd FROM Kategoriler");
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "KategoriID";
        }

        private void dgvKitapYonetim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvKitapYonetim.CurrentRow != null)
            {
                txtKitapAd.Text = dgvKitapYonetim.CurrentRow.Cells["Kitap Adı"].Value.ToString();
                txtBarkod.Text = dgvKitapYonetim.CurrentRow.Cells["Barkod"].Value.ToString();
                cmbKategori.Text = dgvKitapYonetim.CurrentRow.Cells["Kategori"].Value.ToString();

                string tamAd = dgvKitapYonetim.CurrentRow.Cells["Yazar"].Value.ToString().Trim();

                if (tamAd.Contains(" "))
                {
                    int sonBoslukIndex = tamAd.LastIndexOf(' ');
                    txtYazarAd.Text = tamAd.Substring(0, sonBoslukIndex);
                    txtYazarSoyad.Text = tamAd.Substring(sonBoslukIndex + 1);
                }
                else
                {
                    txtYazarAd.Text = tamAd;
                    txtYazarSoyad.Text = "";
                }
            }
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKitapAd.Text) || string.IsNullOrWhiteSpace(txtYazarAd.Text))
            {
                MessageBox.Show("Kitap adı ve Yazar adı alanları boş bırakılamaz!");
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                SqlTransaction trx = baglanti.BeginTransaction();

                try
                {
                    int yazarID;
                    string yazarSorgu = "SELECT YazarID FROM Yazarlar WHERE Ad = @yAd AND Soyad = @ySoyad";
                    SqlCommand cmdYazar = new SqlCommand(yazarSorgu, baglanti, trx);
                    cmdYazar.Parameters.AddWithValue("@yAd", txtYazarAd.Text.Trim());
                    cmdYazar.Parameters.AddWithValue("@ySoyad", txtYazarSoyad.Text.Trim());

                    object sonuc = cmdYazar.ExecuteScalar();

                    if (sonuc != null)
                    {
                        yazarID = Convert.ToInt32(sonuc);
                    }
                    else
                    {
                        string yazarEkle = "INSERT INTO Yazarlar (Ad, Soyad) OUTPUT INSERTED.YazarID VALUES (@yAd, @ySoyad)";
                        SqlCommand cmdEkle = new SqlCommand(yazarEkle, baglanti, trx);
                        cmdEkle.Parameters.AddWithValue("@yAd", txtYazarAd.Text.Trim());
                        cmdEkle.Parameters.AddWithValue("@ySoyad", txtYazarSoyad.Text.Trim());
                        yazarID = (int)cmdEkle.ExecuteScalar();
                    }

                    string kitapEkle = "INSERT INTO Kitaplar (KitapAd, YazarID, KategoriID, Barkod, Durum) VALUES (@kAd, @yId, @katId, @barkod, 1)";
                    SqlCommand cmdKitap = new SqlCommand(kitapEkle, baglanti, trx);
                    cmdKitap.Parameters.AddWithValue("@kAd", txtKitapAd.Text.Trim());
                    cmdKitap.Parameters.AddWithValue("@yId", yazarID);
                    cmdKitap.Parameters.AddWithValue("@katId", cmbKategori.SelectedValue);
                    cmdKitap.Parameters.AddWithValue("@barkod", txtBarkod.Text.Trim());
                    cmdKitap.ExecuteNonQuery();

                    trx.Commit();
                    MessageBox.Show("Kitap ve Yazar kaydı başarıyla tamamlandı.");
                    VerileriGetir();
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kitabı listeden seçin!");
                return;
            }

            int kitapID = Convert.ToInt32(dataGridView.CurrentRow.Cells["KitapID"].Value);

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                SqlTransaction trx = baglanti.BeginTransaction();

                try
                {
                    int yazarID;
                    string yazarSorgu = "SELECT YazarID FROM Yazarlar WHERE Ad = @yAd AND Soyad = @ySoyad";
                    SqlCommand cmdYazar = new SqlCommand(yazarSorgu, baglanti, trx);
                    cmdYazar.Parameters.AddWithValue("@yAd", txtYazarAd.Text.Trim());
                    cmdYazar.Parameters.AddWithValue("@ySoyad", txtYazarSoyad.Text.Trim());

                    object sonuc = cmdYazar.ExecuteScalar();

                    if (sonuc != null)
                    {
                        yazarID = Convert.ToInt32(sonuc);
                    }
                    else
                    {
                        string yazarEkle = "INSERT INTO Yazarlar (Ad, Soyad) OUTPUT INSERTED.YazarID VALUES (@yAd, @ySoyad)";
                        SqlCommand cmdEkle = new SqlCommand(yazarEkle, baglanti, trx);
                        cmdEkle.Parameters.AddWithValue("@yAd", txtYazarAd.Text.Trim());
                        cmdEkle.Parameters.AddWithValue("@ySoyad", txtYazarSoyad.Text.Trim());
                        yazarID = (int)cmdEkle.ExecuteScalar();
                    }

                    string guncelleSorgu = @"UPDATE Kitaplar SET 
                                    KitapAd = @ad, 
                                    YazarID = @yazar, 
                                    KategoriID = @kat, 
                                    Barkod = @barkod 
                                    WHERE KitapID = @id";

                    SqlCommand cmdKitap = new SqlCommand(guncelleSorgu, baglanti, trx);
                    cmdKitap.Parameters.AddWithValue("@ad", txtKitapAd.Text.Trim());
                    cmdKitap.Parameters.AddWithValue("@yazar", yazarID);
                    cmdKitap.Parameters.AddWithValue("@kat", cmbKategori.SelectedValue);
                    cmdKitap.Parameters.AddWithValue("@barkod", txtBarkod.Text.Trim());
                    cmdKitap.Parameters.AddWithValue("@id", kitapID);
                    cmdKitap.ExecuteNonQuery();

                    trx.Commit();
                    MessageBox.Show("Kitap ve yazar bilgileri başarıyla güncellendi.");
                    VerileriGetir();
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    MessageBox.Show("Güncelleme hatası: " + ex.Message);
                }
            }
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            string durum = dataGridView.CurrentRow.Cells["Durum"].Value.ToString();
            if (durum == "Ödünçte")
            {
                MessageBox.Show("Ödünçte olan bir kitabı silemezsiniz! Önce iade almalısınız.");
                return;
            }

            DialogResult onay = MessageBox.Show("Bu kitabı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                int kitapID = Convert.ToInt32(dataGridView.CurrentRow.Cells["KitapID"].Value);
                KomutYurut("DELETE FROM Kitaplar WHERE KitapID=@id", new SqlParameter("@id", kitapID));
                MessageBox.Show("Kitap kaydı silindi.");
                VerileriGetir();
            }
        }
        #endregion
    }
}