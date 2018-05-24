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
    public partial class frmKullaniciYonetimi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        int secim = -1;
        public frmKullaniciYonetimi()
        {
            InitializeComponent();
            this.Shown += frmKullaniciYonetimi_Shown;
        }

        void Listele()
        {
            var lst = from s in DB.TBL_KULLANICILARs
                      select s;
            gridControl1.DataSource = lst;
        }

        void frmKullaniciYonetimi_Shown(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnYeniKullaniciEkle_Click(object sender, EventArgs e)
        {
            Formlar.KullaniciPanel();
        }

        private void btnSeciliKullaniciyiGuncelle_Click(object sender, EventArgs e)
        {
            Formlar.KullaniciPanel(true, secim);
            Listele();
        }

        private void btnSeciliKullaniciyiSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sil() == DialogResult.Yes)
            {
                DB.TBL_KULLANICILARs.DeleteOnSubmit(DB.TBL_KULLANICILARs.First(s => s.ID == secim));
                DB.SubmitChanges();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            secim = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());

        }

        
    }
}