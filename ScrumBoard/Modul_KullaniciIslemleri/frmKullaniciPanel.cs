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

namespace ScrumBoard.Modul_KullaniciIslemleri
{
    public partial class frmKullaniciPanel : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        bool ac = false;
        int KullaniciID = -1;

        public frmKullaniciPanel(int ID,bool acc)
        {
            InitializeComponent();
            ac = acc;
            KullaniciID = ID;
            if (ac)
            {
                KullaniciGetir(ID);
                txtKullaniciAdi.Enabled = false;
            }
        }

        void Temizle()
        {
            txtAdSoyad.Text = "";
            txtKullaniciAdi.Text = "";
            txtKullaniciTuru.SelectedIndex = 1;
            txtSifre.Text = "";
            txtSifreT.Text = "";
            rbtnPasif.Checked = true;
            ac = false;
            KullaniciID = -1;
        }
        void KullaniciGetir(int ID)
        {
            KullaniciID=ID;
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILARs.First(S => S.ID == KullaniciID);
                txtAdSoyad.Text = Kullanici.KULLANICIADSOYAD;
                txtKullaniciAdi.Text = Kullanici.KULLANICIADI;
                if (Kullanici.KULLANICIKODU == "Çalışan") txtKullaniciTuru.SelectedIndex = 2;
                if (Kullanici.KULLANICIKODU == "Yönetici") txtKullaniciTuru.SelectedIndex = 1;
                txtSifre.Text = Kullanici.KULLANICISIFRE;
                txtSifreT.Text = Kullanici.KULLANICISIFRE;
                if (Kullanici.KULLANICIAKTIF.Value) rbtnAktif.Checked = true;
                if (!Kullanici.KULLANICIAKTIF.Value) rbtnPasif.Checked = true;
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text.Trim() == txtSifreT.Text.Trim())
            {
                if (txtAdSoyad.Text == "")
                {
                    MessageBox.Show("İsim Girişi Yapın");
                    return;
                }
                else if (txtKullaniciAdi.Text == "")
                {
                    MessageBox.Show("Kullanıcı Adı Girin");
                }
                else if (txtSifre.Text == "")
                {
                    MessageBox.Show("Şifre Girin");
                }
                DialogResult DR = MessageBox.Show(txtKullaniciAdi.Text + " Türünde bir kullanıcı açmak üzeresiniz Eminmisiniz ?", "Kullanıcı Kaydı Tamamlama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        if (!ac)
                        {
                            if (DB.TBL_KULLANICILARs.Where(s => s.KULLANICIADI == txtKullaniciAdi.Text).Count() > 0)
                            {
                                MessageBox.Show("Böyle bir kullanıcı var zaten kullanıcı adını değiş");
                                return;
                            } 
                        }
                        Fonksiyonlar.TBL_KULLANICILAR Kullanici;
                        if (!ac)
                            Kullanici = new Fonksiyonlar.TBL_KULLANICILAR();
                        else
                            Kullanici = DB.TBL_KULLANICILARs.First(s => s.ID == KullaniciID);
                        if (rbtnAktif.Checked) Kullanici.KULLANICIAKTIF = true;
                        if (rbtnPasif.Checked) Kullanici.KULLANICIAKTIF = false;
                        Kullanici.KULLANICIADSOYAD = txtAdSoyad.Text;
                        Kullanici.KULLANICIADI = txtKullaniciAdi.Text;
                        Kullanici.KULLANICIKODU = txtKullaniciTuru.Text;
                        if (ac) Kullanici.KULLANICIEDITDATE = DateTime.Now;
                        else Kullanici.KULLANICISAVEDATE = DateTime.Now;
                        Kullanici.KULLANICISIFRE = txtSifre.Text;
                        if (!ac) DB.TBL_KULLANICILARs.InsertOnSubmit(Kullanici);
                        DB.SubmitChanges();
                        if (ac) Mesajlar.Guncelle(true);
                        else
                            Mesajlar.YeniKayit(txtKullaniciAdi.Text + " Kullanıcı Kaydı Açılmıştır");
                        Temizle();

                    }
                    catch (Exception ex)
                    {

                        Mesajlar.Hata(ex);
                    }
                }
            }
            else
                MessageBox.Show("Şifreler Aynı Değildir");
        }
       

       

        
    }
}