using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.DAL;
using System.Data;
using System.Data.SqlClient;


namespace SiparisOtomasyonu.BLL
{
    public class UrunlerBLL
    {
        private Urunler urunlerDAL;

        public UrunlerBLL()
        {
            urunlerDAL = new Urunler();
        }
        public DataTable GetAllItems()
        {
           return urunlerDAL.GetAllItems();
        }

    }
}
