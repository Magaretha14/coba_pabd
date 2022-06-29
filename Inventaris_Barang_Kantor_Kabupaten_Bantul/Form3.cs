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
    public partial class Form3 : Form
    {
        DataTable dt;
        DataRow dr;
        String code;
        
        public Form3()
        {
            InitializeComponent();

            this.barangTableAdapter.Fill(this.invetarisBarangDataSet.Barang);
            // This line of code loads data into the
            // hRDataSet.empdetails table. this would appear in
            // Form1_Load event
            this.barangTableAdapter.Fill(this.invetarisBarangDataSet.Barang);
            txtKodeBrg.Enabled = true;
            txtNamaBrg.Enabled = true;
            txtIdPengurusBrg.Enabled = true;
            txtKeadaanBrg.Enabled = true;
            txtKeterangan.Enabled = true;
            txtHargaStn.Enabled = true;
            txtKuantitasBrg.Enabled = true;
            txtTotalHrg.Enabled = true;
            btnSaveBrg.Enabled = true;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invetarisBarangDataSet.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.invetarisBarangDataSet.Barang);
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveBrg_Click(object sender, EventArgs e)
        {

            dt = invetarisBarangDataSet.Tables["Barang"];
            dr = dt.NewRow();
            dr[0] = txtKodeBrg.Text;
            dr[1] = txtNamaBrg.Text;
            dr[2] = txtIdPengurusBrg.Text;
            dr[3] = txtKeadaanBrg.Text;
            dr[4] = txtKeterangan.Text;
            dr[5] = txtHargaStn.Text;
            dr[6] = txtKuantitasBrg.Text;
            dr[7] = txtTotalHrg.Text;
            dt.Rows.Add(dr);
            barangTableAdapter.Update(invetarisBarangDataSet);
            txtKodeBrg.Text = System.Convert.ToString(dr[0]);
            txtKodeBrg.Enabled = false;
            txtNamaBrg.Enabled = false;
            txtIdPengurusBrg.Text = System.Convert.ToString(dr[2]);
            txtKeadaanBrg.Enabled = false;
            txtKeterangan.Enabled = false;
            txtHargaStn.Enabled = false;
            txtKuantitasBrg.Enabled = false;
            txtTotalHrg.Enabled = false;
            this.barangTableAdapter.Fill(this.invetarisBarangDataSet.Barang);
            
            btnSaveBrg.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAddBrg_Click(object sender, EventArgs e)
        {
            btnSaveBrg.Enabled = true;
            txtKodeBrg.Enabled = true;
            txtNamaBrg.Enabled = true;
            txtIdPengurusBrg.Enabled = true;
            txtKeadaanBrg.Enabled = true;
            txtKeterangan.Enabled = true;
            txtHargaStn.Enabled = true;
            txtKuantitasBrg.Enabled = true;
            txtTotalHrg.Enabled = true;



            txtKodeBrg.Text = "";
            txtNamaBrg.Text = "";
            txtIdPengurusBrg.Text = "";
            txtKeadaanBrg.Text = "";
            txtKeterangan.Text = "";
            txtHargaStn.Text = "";
            txtKuantitasBrg.Text = "";
            txtTotalHrg.Text = "";
            dt = invetarisBarangDataSet.Tables["Barang"];
            dr = dt.NewRow();

            btnAddBrg.Enabled = true;
            btnDeleteBrg.Enabled = true;
        }

        private void btnDeleteBrg_Click(object sender, EventArgs e)
        {
            string code;
            code = txtKodeBrg.Text;
            dr = invetarisBarangDataSet.Tables["Barang"].Rows.Find(code);
            dr.Delete();
            barangTableAdapter.Update(invetarisBarangDataSet);
        }

        private void btnEditBrg_Click(object sender, EventArgs e)
        {
            btnCancelBrg.Enabled = true;
            txtKodeBrg.Enabled = true;
            txtNamaBrg.Enabled = true;
            txtIdPengurusBrg.Enabled = true;
            txtKeadaanBrg.Enabled = true;
            txtKeterangan.Enabled = true;
            txtHargaStn.Enabled = true;
            txtKuantitasBrg.Enabled = true;
            txtTotalHrg.Enabled = true;



            txtKodeBrg.Text = txtKodeBrg.Text;
            txtNamaBrg.Text = txtNamaBrg.Text;
            txtIdPengurusBrg.Text = txtIdPengurusBrg.Text;
            txtKeadaanBrg.Text = txtKeadaanBrg.Text;
            txtKeterangan.Text = txtKeterangan.Text;
            txtHargaStn.Text = txtHargaStn.Text;
            txtKuantitasBrg.Text = txtKuantitasBrg.Text;
            txtTotalHrg.Text = txtTotalHrg.Text;
            string code;
            code = txtKodeBrg.Text;
            dr = invetarisBarangDataSet.Tables["Barang"].Rows.Find(code);
            dr.AcceptChanges();
            barangTableAdapter.Update(invetarisBarangDataSet);

            btnEditBrg.Enabled = true;

            
        }

        private void btnCancelBrg_Click(object sender, EventArgs e)
        {
            
        }
    }
}
