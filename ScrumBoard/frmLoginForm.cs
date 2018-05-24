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

namespace ScrumBoard
{
    public partial class frmLoginForm : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public frmLoginForm()
        {
            InitializeComponent();
            txtKullaniciAdi.Focus();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILARs.First(s => s.KULLANICIADI == txtKullaniciAdi.Text.Trim() && s.KULLANICISIFRE == txtSifre.Text.Trim());
                Kullanici.KULLANICILASTLOGIN = DateTime.Now;
                DB.SubmitChanges();
                this.Hide();
                AnaForm frm = new AnaForm(Kullanici);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş Yapılamadı Kullanıcı adı yada şifre yanlış");
                return;
            }
            
        }
    }
}