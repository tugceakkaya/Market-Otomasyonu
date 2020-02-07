using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiparisOtomasyonu.BLL;
using System.Data.SqlClient;


namespace SiparisOtomasyonu
{
    public partial class StokDurum : Form
    {
        public StokDurum()
        {
            InitializeComponent();
        }

        private void btnStokDurum_Click(object sender, EventArgs e)
        {
            UrunlerBLL urunlerBLL = new UrunlerBLL();
            dataGridViewsStokDurum.DataSource = urunlerBLL.GetAllItems();


        }
    }
}
