using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventaris_Barang_Kantor_Kabupaten_Bantul
{
    public partial class Form5 : Form

    {
        DataTable dt;
        DataRow dr;
        String code;

        public Form5()
        {
            InitializeComponent();
            this.barang_KeluarTableAdapter.Fill(this.invetarisBarangDataSet2.Barang_Keluar);
            // This line of code loads data into the
            // hRDataSet.empdetails table. this would appear in
            // Form1_Load event
            this.barang_KeluarTableAdapter.Fill(this.invetarisBarangDataSet2.Barang_Keluar);
            txtNoKeluar.Enabled = false;
            txtKodeBrgKlr.Enabled = false;
            txtNamaBrgKlr.Enabled = false;
            txtTanggalKlr.Enabled = false;
            txtHrgStnKlr.Enabled = false;
            txtKuantitasKlr.Enabled = false;
            txtTotalHrgKlr.Enabled = false;
            btnSaveKlr.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invetarisBarangDataSet2.Barang_Keluar' table. You can move, or remove it, as needed.
            this.barang_KeluarTableAdapter.Fill(this.invetarisBarangDataSet2.Barang_Keluar);

        }

        private void btnAddKlr_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSaveKlr_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteKlr_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelKlr_Click(object sender, EventArgs e)
        {

        }
    }
}
