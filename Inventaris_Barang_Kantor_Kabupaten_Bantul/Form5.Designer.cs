
namespace Inventaris_Barang_Kantor_Kabupaten_Bantul
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtTanggalKlr = new System.Windows.Forms.TextBox();
            this.txtNamaBrgKlr = new System.Windows.Forms.TextBox();
            this.txtTotalHrgKlr = new System.Windows.Forms.TextBox();
            this.txtKuantitasKlr = new System.Windows.Forms.TextBox();
            this.txtHrgStnKlr = new System.Windows.Forms.TextBox();
            this.txtKodeBrgKlr = new System.Windows.Forms.TextBox();
            this.txtNoKeluar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelKlr = new System.Windows.Forms.Button();
            this.btnSaveKlr = new System.Windows.Forms.Button();
            this.btnDeleteKlr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invetarisBarangDataSet2 = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisBarangDataSet2();
            this.barangKeluarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barang_KeluarTableAdapter = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisBarangDataSet2TableAdapters.Barang_KeluarTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddKlr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisBarangDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangKeluarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.Location = new System.Drawing.Point(986, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 38);
            this.button4.TabIndex = 8;
            this.button4.Text = "logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inventaris_Barang_Kantor_Kabupaten_Bantul.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(1131, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventaris_Barang_Kantor_Kabupaten_Bantul.Properties.Resources.logobantul;
            this.pictureBox1.Location = new System.Drawing.Point(37, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Barang Keluar";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(921, 195);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 42);
            this.textBox6.TabIndex = 34;
            // 
            // txtTanggalKlr
            // 
            this.txtTanggalKlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Tanggal_Keluar", true));
            this.txtTanggalKlr.Location = new System.Drawing.Point(921, 125);
            this.txtTanggalKlr.Multiline = true;
            this.txtTanggalKlr.Name = "txtTanggalKlr";
            this.txtTanggalKlr.Size = new System.Drawing.Size(155, 42);
            this.txtTanggalKlr.TabIndex = 35;
            // 
            // txtNamaBrgKlr
            // 
            this.txtNamaBrgKlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Nama_Barang", true));
            this.txtNamaBrgKlr.Location = new System.Drawing.Point(664, 125);
            this.txtNamaBrgKlr.Multiline = true;
            this.txtNamaBrgKlr.Name = "txtNamaBrgKlr";
            this.txtNamaBrgKlr.Size = new System.Drawing.Size(155, 42);
            this.txtNamaBrgKlr.TabIndex = 36;
            // 
            // txtTotalHrgKlr
            // 
            this.txtTotalHrgKlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Harga_total", true));
            this.txtTotalHrgKlr.Location = new System.Drawing.Point(664, 195);
            this.txtTotalHrgKlr.Multiline = true;
            this.txtTotalHrgKlr.Name = "txtTotalHrgKlr";
            this.txtTotalHrgKlr.Size = new System.Drawing.Size(155, 42);
            this.txtTotalHrgKlr.TabIndex = 37;
            // 
            // txtKuantitasKlr
            // 
            this.txtKuantitasKlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Kuantitas", true));
            this.txtKuantitasKlr.Location = new System.Drawing.Point(419, 195);
            this.txtKuantitasKlr.Multiline = true;
            this.txtKuantitasKlr.Name = "txtKuantitasKlr";
            this.txtKuantitasKlr.Size = new System.Drawing.Size(155, 42);
            this.txtKuantitasKlr.TabIndex = 38;
            // 
            // txtHrgStnKlr
            // 
            this.txtHrgStnKlr.BackColor = System.Drawing.SystemColors.Window;
            this.txtHrgStnKlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Harga_Satuan", true));
            this.txtHrgStnKlr.Location = new System.Drawing.Point(202, 195);
            this.txtHrgStnKlr.Multiline = true;
            this.txtHrgStnKlr.Name = "txtHrgStnKlr";
            this.txtHrgStnKlr.Size = new System.Drawing.Size(155, 42);
            this.txtHrgStnKlr.TabIndex = 39;
            // 
            // txtKodeBrgKlr
            // 
            this.txtKodeBrgKlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Kode_Barang", true));
            this.txtKodeBrgKlr.Location = new System.Drawing.Point(419, 125);
            this.txtKodeBrgKlr.Multiline = true;
            this.txtKodeBrgKlr.Name = "txtKodeBrgKlr";
            this.txtKodeBrgKlr.Size = new System.Drawing.Size(155, 42);
            this.txtKodeBrgKlr.TabIndex = 40;
            // 
            // txtNoKeluar
            // 
            this.txtNoKeluar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "No_Keluar_Barang", true));
            this.txtNoKeluar.Location = new System.Drawing.Point(202, 125);
            this.txtNoKeluar.Multiline = true;
            this.txtNoKeluar.Name = "txtNoKeluar";
            this.txtNoKeluar.Size = new System.Drawing.Size(155, 42);
            this.txtNoKeluar.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Kuantitas Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Kode Barang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(954, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Kondisi Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(944, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tanggal Keluar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(704, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Total Harga ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Harga Satuan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "No.Keluar Barang";
            // 
            // btnCancelKlr
            // 
            this.btnCancelKlr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCancelKlr.Location = new System.Drawing.Point(753, 265);
            this.btnCancelKlr.Name = "btnCancelKlr";
            this.btnCancelKlr.Size = new System.Drawing.Size(121, 43);
            this.btnCancelKlr.TabIndex = 42;
            this.btnCancelKlr.Text = "Cancel";
            this.btnCancelKlr.UseVisualStyleBackColor = false;
            this.btnCancelKlr.Click += new System.EventHandler(this.btnCancelKlr_Click);
            // 
            // btnSaveKlr
            // 
            this.btnSaveKlr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSaveKlr.Location = new System.Drawing.Point(390, 265);
            this.btnSaveKlr.Name = "btnSaveKlr";
            this.btnSaveKlr.Size = new System.Drawing.Size(121, 43);
            this.btnSaveKlr.TabIndex = 43;
            this.btnSaveKlr.Text = "Save";
            this.btnSaveKlr.UseVisualStyleBackColor = false;
            this.btnSaveKlr.Click += new System.EventHandler(this.btnSaveKlr_Click);
            // 
            // btnDeleteKlr
            // 
            this.btnDeleteKlr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeleteKlr.Location = new System.Drawing.Point(579, 265);
            this.btnDeleteKlr.Name = "btnDeleteKlr";
            this.btnDeleteKlr.Size = new System.Drawing.Size(121, 43);
            this.btnDeleteKlr.TabIndex = 44;
            this.btnDeleteKlr.Text = "Delete";
            this.btnDeleteKlr.UseVisualStyleBackColor = false;
            this.btnDeleteKlr.Click += new System.EventHandler(this.btnDeleteKlr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.barangKeluarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(138, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 160);
            this.dataGridView1.TabIndex = 45;
            // 
            // invetarisBarangDataSet2
            // 
            this.invetarisBarangDataSet2.DataSetName = "InvetarisBarangDataSet2";
            this.invetarisBarangDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangKeluarBindingSource
            // 
            this.barangKeluarBindingSource.DataMember = "Barang_Keluar";
            this.barangKeluarBindingSource.DataSource = this.invetarisBarangDataSet2;
            // 
            // barang_KeluarTableAdapter
            // 
            this.barang_KeluarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No_Keluar_Barang";
            this.dataGridViewTextBoxColumn1.HeaderText = "No_Keluar_Barang";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kode_Barang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kode_Barang";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nama_Barang";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nama_Barang";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tanggal_Keluar";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tanggal_Keluar";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Harga_Satuan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Harga_Satuan";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Kuantitas";
            this.dataGridViewTextBoxColumn6.HeaderText = "Kuantitas";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Harga_total";
            this.dataGridViewTextBoxColumn7.HeaderText = "Harga_total";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // btnAddKlr
            // 
            this.btnAddKlr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddKlr.Location = new System.Drawing.Point(217, 265);
            this.btnAddKlr.Name = "btnAddKlr";
            this.btnAddKlr.Size = new System.Drawing.Size(121, 43);
            this.btnAddKlr.TabIndex = 46;
            this.btnAddKlr.Text = "Add";
            this.btnAddKlr.UseVisualStyleBackColor = false;
            this.btnAddKlr.Click += new System.EventHandler(this.btnAddKlr_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1188, 560);
            this.Controls.Add(this.btnAddKlr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelKlr);
            this.Controls.Add(this.btnSaveKlr);
            this.Controls.Add(this.btnDeleteKlr);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtTanggalKlr);
            this.Controls.Add(this.txtNamaBrgKlr);
            this.Controls.Add(this.txtTotalHrgKlr);
            this.Controls.Add(this.txtKuantitasKlr);
            this.Controls.Add(this.txtHrgStnKlr);
            this.Controls.Add(this.txtKodeBrgKlr);
            this.Controls.Add(this.txtNoKeluar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Name = "Form5";
            this.Text = "Halaman Barang Keluar";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisBarangDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangKeluarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtTanggalKlr;
        private System.Windows.Forms.TextBox txtNamaBrgKlr;
        private System.Windows.Forms.TextBox txtTotalHrgKlr;
        private System.Windows.Forms.TextBox txtKuantitasKlr;
        private System.Windows.Forms.TextBox txtHrgStnKlr;
        private System.Windows.Forms.TextBox txtKodeBrgKlr;
        private System.Windows.Forms.TextBox txtNoKeluar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelKlr;
        private System.Windows.Forms.Button btnSaveKlr;
        private System.Windows.Forms.Button btnDeleteKlr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noKeluarBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalKeluarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuantitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargatotalDataGridViewTextBoxColumn;
        private InvetarisBarangDataSet2 invetarisBarangDataSet2;
        private System.Windows.Forms.BindingSource barangKeluarBindingSource;
        private InvetarisBarangDataSet2TableAdapters.Barang_KeluarTableAdapter barang_KeluarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnAddKlr;
    }
}