using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istanbul_devlet_tiyatrosu_847
{
    public partial class Form1 : Form
    {
        BindingList<Tiyatro> tiyatrolar = new BindingList<Tiyatro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tiyatro tiyatro1 = new Tiyatro(1, "hamlet", "AKM", new DateTime(2023, 10, 10), 80,85.5, false);
            Tiyatro tiyatro2 = new Tiyatro(2, "alis müzikali", "büyük sahne", new DateTime(2023, 11, 15), 120, 400, true);

            tiyatrolar.Add(tiyatro1);
            tiyatrolar.Add(tiyatro2);

            dataGridView1.DataSource = tiyatrolar;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string oyunAd = cmbOyun.Text;
            string sahne = cmbSahne.Text;
            DateTime tarih = dtpTarih.Value;
            int sure = Convert.ToInt32(numSure.Value);
            
        }
    }
}
