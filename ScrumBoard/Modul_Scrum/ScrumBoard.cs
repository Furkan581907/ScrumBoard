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

namespace ScrumBoard.Modul_Scrum
{
    public partial class ScrumBoard : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int ScrumID = -1;
        int secimm = -1;
        public ScrumBoard()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBaslik.Text = "";
            txtEklenecekYer.SelectedIndex=0;
            txtGorevli.Text = "";
            txtOnemi.Text = "";
            txtProjeKodu.Text = "";
            txtZaman.Value = DateTime.Now;
            Edit = false;
            ScrumID = -1;
            
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_SCRUM1 Scrum = new Fonksiyonlar.TBL_SCRUM1();
                Scrum.KULLANICILARID = AnaForm.UserID;
                Scrum.PROJEID = Convert.ToInt32(txtProjeKodu.Text);
                Scrum.SCRUMACIKLAMA = txtAciklama.Text;
                Scrum.SCRUMBASLIK = txtBaslik.Text;
                Scrum.SCRUMGOREVLI = txtGorevli.Text;
                Scrum.SCRUMEKLENECEKYER = txtEklenecekYer.Text;
                Scrum.SCRUMONEMI = txtOnemi.Text;
                Scrum.SCRUMZAMAN = DateTime.Now;
                Scrum.SCRUMSAVEDATE = DateTime.Now;
                Scrum.SCRUMSAVEUSER = AnaForm.UserID;
                DB.TBL_SCRUM1s.InsertOnSubmit(Scrum);
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
                Fonksiyonlar.TBL_SCRUM1 Scrum = DB.TBL_SCRUM1s.First(s => s.ID == ScrumID);
                Scrum.KULLANICILARID = AnaForm.UserID;
                Scrum.PROJEID = Convert.ToInt32(txtProjeKodu.Text);
                Scrum.SCRUMACIKLAMA = txtAciklama.Text;
                Scrum.SCRUMBASLIK = txtBaslik.Text;
                Scrum.SCRUMGOREVLI = txtGorevli.Text;
                Scrum.SCRUMEKLENECEKYER = txtEklenecekYer.Text;
                Scrum.SCRUMONEMI = txtOnemi.Text;
                Scrum.SCRUMZAMAN = DateTime.Now;
                Scrum.SCRUMEDITDATE = DateTime.Now;
                Scrum.SCRUMEDITUSER = AnaForm.UserID;
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
                DB.TBL_SCRUM1s.DeleteOnSubmit(DB.TBL_SCRUM1s.First(s => s.ID == ScrumID));
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        public void ProjeAc(int ID)
        {
            Edit = true;
            ScrumID = ID;
            Fonksiyonlar.TBL_SCRUM1 Scrum = DB.TBL_SCRUM1s.First(s => s.PROJEID == ScrumID-2);
            txtProjeKodu.Text = Scrum.PROJEID.ToString();
        }

        

        void Listele()
        {
            var lst = from s in DB.TBL_SCRUM1s
                      select s;
            gridControl1.DataSource = lst;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && ScrumID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else YeniKaydet();
            tileView1.RefreshData();
        }

        private void ScrumBoard_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void tileView1_DoubleClick(object sender, EventArgs e)
        {
             secimm=int.Parse(tileView1.GetFocusedRowCellValue("ID").ToString());
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sil() == DialogResult.Yes)
            {
                DB.TBL_SCRUM1s.DeleteOnSubmit(DB.TBL_SCRUM1s.First(s => s.ID == secimm));
                DB.SubmitChanges();
            }
        }
    }
}