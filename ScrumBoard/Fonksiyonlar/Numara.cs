using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumBoard.Fonksiyonlar
{
    
    class Numara
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        Mesajlar Mesajlar = new Mesajlar();
        public string ProjeNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_PROJELERs
                                        orderby s.ID descending
                                        select s).First().PROJEKODU);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
    }
}
