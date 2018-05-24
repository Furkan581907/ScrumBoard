using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ScrumBoard.Modul_Proje
{
    public partial class frmProjeEkle : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Resimleme Resimleme = new Fonksiyonlar.Resimleme();

        bool Edit = false;
        bool Resim = false;
        OpenFileDialog Dosya = new OpenFileDialog();
        int ProjeID = -1;

        public frmProjeEkle()
        {
            InitializeComponent();
        }

        private void frmProjeEkle_Load(object sender, EventArgs e)
        {
            txtProjeKodu.Text = Numaralar.ProjeNumarasi();
        }

        void Temizle()
        {
            txtTelefon.Text = "";
            txtProjeKodu.Text = Numaralar.ProjeNumarasi();
            txtProjeAdi.Text = "";
            txtOnemi.Text = "";
            txtMail.Text = "";
            dtBaslangic.Value = DateTime.Now;
            dtBitis.Value = DateTime.Now;
            txtAdiSoyadi.Text = "";
            pictureBox1.Image = null;
            Edit = false;
            Resim = false;
            ProjeID = -1;
            AnaForm.Aktarma = -1;
        }

        void ResimSec()
        { 
            Dosya.Filter="Jpg(*.jpg|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (Dosya.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = Dosya.FileName;
                Resim = true;
            }
        }

        public void Ac(int ID)
        {
            Edit = true;
            ProjeID = ID;
            Fonksiyonlar.TBL_PROJELER Proje = DB.TBL_PROJELERs.First(s => s.ID == ProjeID);
            pictureBox1.Image = Resimleme.ResimGetirme(Proje.PROJERESIM.ToArray());
            txtAdiSoyadi.Text = Proje.PROJEADISOYADI;
            txtMail.Text = Proje.PROJEMAIL;
            txtOnemi.Text = Proje.PROJEONEMI;
            txtProjeAdi.Text = Proje.PROJEADI;
            txtProjeKodu.Text = Proje.PROJEKODU;
            txtTelefon.Text = Proje.PROJETELEFON;
            dtBaslangic.Value = Proje.PROJEBASLANGICTARIHI.Value;
            dtBitis.Value = Proje.PROJEBITISTARIHI.Value;
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_PROJELER Proje = new Fonksiyonlar.TBL_PROJELER();
                Proje.PROJEADI = txtProjeAdi.Text;
                Proje.PROJEADISOYADI = txtAdiSoyadi.Text;
                Proje.PROJEBASLANGICTARIHI = dtBaslangic.Value;
                Proje.PROJEBITISTARIHI = dtBitis.Value;
                Proje.PROJEKODU = txtProjeKodu.Text;
                Proje.PROJEMAIL = txtMail.Text;
                Proje.PROJEONEMI = txtOnemi.Text;
                Proje.PROJERESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Proje.PROJETELEFON = txtTelefon.Text;
                Proje.PROJESAVEDATE = DateTime.Now;
                Proje.PROJESAVEUSER = AnaForm.UserID;
                DB.TBL_PROJELERs.InsertOnSubmit(Proje);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Proje Kaydı Başarıyla Oluşturulmuştur.");
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
            
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_PROJELER Proje = DB.TBL_PROJELERs.First(s => s.ID == ProjeID);
                Proje.PROJEADI = txtProjeAdi.Text;
                Proje.PROJEADISOYADI = txtAdiSoyadi.Text;
                Proje.PROJEBASLANGICTARIHI = dtBaslangic.Value;
                Proje.PROJEBITISTARIHI = dtBitis.Value;
                Proje.PROJEKODU = txtProjeKodu.Text;
                Proje.PROJEMAIL = txtMail.Text;
                Proje.PROJEONEMI = txtOnemi.Text;
                if(Resim) Proje.PROJERESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Proje.PROJETELEFON = txtTelefon.Text;
                Proje.PROJEEDITDATE = DateTime.Now;
                Proje.PROJEEDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void Sil()
        {
            try
            {
                DB.TBL_PROJELERs.DeleteOnSubmit(DB.TBL_PROJELERs.First(s=>s.ID==ProjeID));
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void txtProjeKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.ProjeListesi(true);
            if (ID > 0)
            {
                Ac(ID);
                AnaForm.Aktarma = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && ProjeID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && ProjeID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}