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
    public partial class Form4 : Form
    {
        DataTable dt;
        DataRow dr;
        String code;

        public Form4()
        {
            InitializeComponent();
            this.barang_MasukTableAdapter.Fill(this.invetarisBarangDataSet1.Barang_Masuk);
            // This line of code loads data into the
            // hRDataSet.empdetails table. this would appear in
            // Form1_Load event
            this.barang_MasukTableAdapter.Fill(this.invetarisBarangDataSet1.Barang_Masuk);
            txtNoMasuk.Enabled = false;
            txtKodeBrgMsk.Enabled = false;
            txtNamaBrgMsk.Enabled = false;
            txtTglMsk.Enabled = false;
            txtHrgStnMsk.Enabled = false;
            txtKuantitasMsk.Enabled = false;
            txtTotalHrgMsk.Enabled = false;
            txtKondisiBrgMsk.Enabled = false;
            btnSaveMsk.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invetarisBarangDataSet1.Barang_Masuk' table. You can move, or remove it, as needed.
            this.barang_MasukTableAdapter.Fill(this.invetarisBarangDataSet1.Barang_Masuk);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMsk_Click(object sender, EventArgs e)
        {
            btnSaveMsk.Enabled = true;
            txtNoMasuk.Enabled = true;
            txtKodeBrgMsk.Enabled = true;
            txtNamaBrgMsk.Enabled = true;
            txtTglMsk.Enabled = true;
            txtHrgStnMsk.Enabled = true;
            txtKuantitasMsk.Enabled = true;
            txtTotalHrgMsk.Enabled = true;
            



            txtNoMasuk.Text = "";
            txtKodeBrgMsk.Text = "";
            txtNamaBrgMsk.Text = "";
            txtTglMsk.Text = "";
            txtHrgStnMsk.Text = "";
            txtKuantitasMsk.Text = "";
            txtTotalHrgMsk.Text = "";
            dt = invetarisBarangDataSet1.Tables["Barang_Masuk"];
            dr = dt.NewRow();

            btnAddMsk.Enabled = false;
            btnDeleteMsk.Enabled = true;
        }

        private void btnSaveMsk_Click(object sender, EventArgs e)
        {
            dt = invetarisBarangDataSet1.Tables["Barang_Masuk"];
            dr = dt.NewRow();
            dr[0] = txtNoMasuk.Text;
            dr[1] = txtKodeBrgMsk.Text;
            dr[2] = txtNamaBrgMsk.Text;
            dr[3] = txtTglMsk.Text;
            dr[4] = txtHrgStnMsk.Text;
            dr[5] = txtKuantitasMsk.Text;
            dr[6] = txtTotalHrgMsk.Text;
            

            btnSaveMsk.Enabled = false;

            dt.Rows.Add(dr);
            barang_MasukTableAdapter.Update(invetarisBarangDataSet1);
            txtNoMasuk.Text = System.Convert.ToString(dr[0]);
            txtKodeBrgMsk.Enabled = false;
            txtNamaBrgMsk.Enabled = false;
            txtTglMsk.Enabled = false;
            txtHrgStnMsk.Enabled = false;
            txtKuantitasMsk.Enabled = false;
            txtTotalHrgMsk.Enabled = false;
            
            
            this.barang_MasukTableAdapter.Fill(this.invetarisBarangDataSet1.Barang_Masuk);

            btnSaveMsk.Enabled = false;

        }

        private void btnDeleteMsk_Click(object sender, EventArgs e)
        {
            string code;
            code = txtNoMasuk.Text;
            dr = invetarisBarangDataSet1.Tables["Barang_Masuk"].Rows.Find(code);
            dr.Delete();
            barang_MasukTableAdapter.Update(invetarisBarangDataSet1);
        }

        private void btnCancelMsk_Click(object sender, EventArgs e)
        {

        }
    }
}
