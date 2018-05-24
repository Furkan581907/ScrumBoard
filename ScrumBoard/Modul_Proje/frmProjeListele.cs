using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ScrumBoard.Modul_Proje
{
    public partial class frmProjeListele : DevExpress.XtraEditors.XtraForm
    {
        public frmProjeListele()
        {
            InitializeComponent();
        }

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();

        public bool secim = false;
        int SecimID = -1;
        private void frmProjeListele_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_PROJELERs
                      where s.PROJEADI.Contains(txtProjeAdi.Text) && s.PROJEONEMI.Contains(txtOnemi.Text) && s.PROJEKODU.Contains(txtProjeKodu.Text)
                      select s;
            liste.DataSource = lst;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtProjeKodu.Text = "";
            txtProjeAdi.Text = "";
            txtOnemi.Text = "";
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
                SecimID = -1;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}