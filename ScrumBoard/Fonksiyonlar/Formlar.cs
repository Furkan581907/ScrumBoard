using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoard.Fonksiyonlar
{
    class Formlar
    {
        public int ProjeListesi(bool Secim = false)
        {
            Modul_Proje.frmProjeListele frm = new Modul_Proje.frmProjeListele();
            if (Secim)
            {
                frm.secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
        public void ProjeEkle(bool Ac = false)
        {
            Modul_Proje.frmProjeEkle frm = new Modul_Proje.frmProjeEkle();
            frm.ShowDialog();
        }

        public void KullaniciYonetimi()
        {
            Modul_KullaniciIslemleri.frmKullaniciYonetimi frm = new Modul_KullaniciIslemleri.frmKullaniciYonetimi();
            frm.ShowDialog();
        }
        public void KullaniciPanel(bool Ac = false, int ID = -1)
        {
            Modul_KullaniciIslemleri.frmKullaniciPanel frm = new Modul_KullaniciIslemleri.frmKullaniciPanel(ID,Ac);
            frm.ShowDialog();
        }
        public void ScrumBoard()
        {
            Modul_Scrum.ScrumBoard frm = new Modul_Scrum.ScrumBoard();
            frm.ShowDialog();
        }
        
    }
}
