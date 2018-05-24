using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ScrumBoard
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        public static Fonksiyonlar.TBL_KULLANICILAR Kullanici;
        public static int UserID = -1;
        public static int Aktarma = -1;
        public AnaForm()
        {
            InitializeComponent();
        }
        public AnaForm(Fonksiyonlar.TBL_KULLANICILAR GelenKullanici)
        {
            InitializeComponent();
            Kullanici = GelenKullanici;
            UserID = Kullanici.ID;
            txtAltKullanici.Caption = Kullanici.KULLANICIADI;
            if (Kullanici.KULLANICIKODU == "Çalışan")
                barbtnKullaniciIslemleri.Visibility = BarItemVisibility.Never;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void barbtnProjeEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.ProjeEkle();
        }

        private void barbtnProjeleriListele_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.ProjeListesi();
        }

        private void barbtnKullaniciIslemleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KullaniciYonetimi();
        }

        private void barbtnScrumEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.ScrumBoard();
        }
    }
}