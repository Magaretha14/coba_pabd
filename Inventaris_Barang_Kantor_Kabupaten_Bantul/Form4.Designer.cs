
namespace Inventaris_Barang_Kantor_Kabupaten_Bantul
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtKondisiBrgMsk = new System.Windows.Forms.TextBox();
            this.txtKuantitasMsk = new System.Windows.Forms.TextBox();
            this.txtTglMsk = new System.Windows.Forms.TextBox();
            this.txtNamaBrgMsk = new System.Windows.Forms.TextBox();
            this.txtTotalHrgMsk = new System.Windows.Forms.TextBox();
            this.txtHrgStnMsk = new System.Windows.Forms.TextBox();
            this.txtKodeBrgMsk = new System.Windows.Forms.TextBox();
            this.txtNoMasuk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelMsk = new System.Windows.Forms.Button();
            this.btnSaveMsk = new System.Windows.Forms.Button();
            this.btnDeleteMsk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddMsk = new System.Windows.Forms.Button();
            this.invetarisBarangDataSet1 = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisBarangDataSet1();
            this.barangMasukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barang_MasukTableAdapter = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisBarangDataSet1TableAdapters.Barang_MasukTableAdapter();
            this.noMasukBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalMasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuantitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargatotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisBarangDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangMasukBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barang Masuk";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventaris_Barang_Kantor_Kabupaten_Bantul.Properties.Resources.logobantul;
            this.pictureBox1.Location = new System.Drawing.Point(41, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.Location = new System.Drawing.Point(920, 27);
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
            this.pictureBox2.Location = new System.Drawing.Point(1060, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtKondisiBrgMsk
            // 
            this.txtKondisiBrgMsk.Location = new System.Drawing.Point(924, 197);
            this.txtKondisiBrgMsk.Multiline = true;
            this.txtKondisiBrgMsk.Name = "txtKondisiBrgMsk";
            this.txtKondisiBrgMsk.Size = new System.Drawing.Size(155, 42);
            this.txtKondisiBrgMsk.TabIndex = 18;
            // 
            // txtKuantitasMsk
            // 
            this.txtKuantitasMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Kuantitas", true));
            this.txtKuantitasMsk.Location = new System.Drawing.Point(431, 197);
            this.txtKuantitasMsk.Multiline = true;
            this.txtKuantitasMsk.Name = "txtKuantitasMsk";
            this.txtKuantitasMsk.Size = new System.Drawing.Size(155, 42);
            this.txtKuantitasMsk.TabIndex = 19;
            this.txtKuantitasMsk.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTglMsk
            // 
            this.txtTglMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Nama_Barang", true));
            this.txtTglMsk.Location = new System.Drawing.Point(667, 118);
            this.txtTglMsk.Multiline = true;
            this.txtTglMsk.Name = "txtTglMsk";
            this.txtTglMsk.Size = new System.Drawing.Size(155, 42);
            this.txtTglMsk.TabIndex = 20;
            // 
            // txtNamaBrgMsk
            // 
            this.txtNamaBrgMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Tanggal_Masuk", true));
            this.txtNamaBrgMsk.Location = new System.Drawing.Point(920, 118);
            this.txtNamaBrgMsk.Multiline = true;
            this.txtNamaBrgMsk.Name = "txtNamaBrgMsk";
            this.txtNamaBrgMsk.Size = new System.Drawing.Size(155, 42);
            this.txtNamaBrgMsk.TabIndex = 21;
            // 
            // txtTotalHrgMsk
            // 
            this.txtTotalHrgMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Harga_total", true));
            this.txtTotalHrgMsk.Location = new System.Drawing.Point(649, 197);
            this.txtTotalHrgMsk.Multiline = true;
            this.txtTotalHrgMsk.Name = "txtTotalHrgMsk";
            this.txtTotalHrgMsk.Size = new System.Drawing.Size(155, 42);
            this.txtTotalHrgMsk.TabIndex = 22;
            // 
            // txtHrgStnMsk
            // 
            this.txtHrgStnMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Harga_Satuan", true));
            this.txtHrgStnMsk.Location = new System.Drawing.Point(205, 197);
            this.txtHrgStnMsk.Multiline = true;
            this.txtHrgStnMsk.Name = "txtHrgStnMsk";
            this.txtHrgStnMsk.Size = new System.Drawing.Size(155, 42);
            this.txtHrgStnMsk.TabIndex = 23;
            // 
            // txtKodeBrgMsk
            // 
            this.txtKodeBrgMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Kode_Barang", true));
            this.txtKodeBrgMsk.Location = new System.Drawing.Point(422, 118);
            this.txtKodeBrgMsk.Multiline = true;
            this.txtKodeBrgMsk.Name = "txtKodeBrgMsk";
            this.txtKodeBrgMsk.Size = new System.Drawing.Size(155, 42);
            this.txtKodeBrgMsk.TabIndex = 24;
            // 
            // txtNoMasuk
            // 
            this.txtNoMasuk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "No_Masuk_Barang", true));
            this.txtNoMasuk.Location = new System.Drawing.Point(205, 118);
            this.txtNoMasuk.Multiline = true;
            this.txtNoMasuk.Name = "txtNoMasuk";
            this.txtNoMasuk.Size = new System.Drawing.Size(155, 42);
            this.txtNoMasuk.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kuantitas Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kode Barang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(957, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Kondisi Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(944, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tanggal Masuk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(697, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Harga ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Harga Satuan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "No.Masuk Barang";
            // 
            // btnCancelMsk
            // 
            this.btnCancelMsk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCancelMsk.Location = new System.Drawing.Point(958, 276);
            this.btnCancelMsk.Name = "btnCancelMsk";
            this.btnCancelMsk.Size = new System.Drawing.Size(121, 43);
            this.btnCancelMsk.TabIndex = 26;
            this.btnCancelMsk.Text = "Cancel";
            this.btnCancelMsk.UseVisualStyleBackColor = false;
            this.btnCancelMsk.Click += new System.EventHandler(this.btnCancelMsk_Click);
            // 
            // btnSaveMsk
            // 
            this.btnSaveMsk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSaveMsk.Location = new System.Drawing.Point(667, 276);
            this.btnSaveMsk.Name = "btnSaveMsk";
            this.btnSaveMsk.Size = new System.Drawing.Size(121, 43);
            this.btnSaveMsk.TabIndex = 27;
            this.btnSaveMsk.Text = "Save";
            this.btnSaveMsk.UseVisualStyleBackColor = false;
            this.btnSaveMsk.Click += new System.EventHandler(this.btnSaveMsk_Click);
            // 
            // btnDeleteMsk
            // 
            this.btnDeleteMsk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeleteMsk.Location = new System.Drawing.Point(813, 276);
            this.btnDeleteMsk.Name = "btnDeleteMsk";
            this.btnDeleteMsk.Size = new System.Drawing.Size(121, 43);
            this.btnDeleteMsk.TabIndex = 28;
            this.btnDeleteMsk.Text = "Delete";
            this.btnDeleteMsk.UseVisualStyleBackColor = false;
            this.btnDeleteMsk.Click += new System.EventHandler(this.btnDeleteMsk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noMasukBarangDataGridViewTextBoxColumn,
            this.kodeBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.tanggalMasukDataGridViewTextBoxColumn,
            this.hargaSatuanDataGridViewTextBoxColumn,
            this.kuantitasDataGridViewTextBoxColumn,
            this.hargatotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barangMasukBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(138, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 126);
            this.dataGridView1.TabIndex = 29;
            // 
            // btnAddMsk
            // 
            this.btnAddMsk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddMsk.Location = new System.Drawing.Point(519, 276);
            this.btnAddMsk.Name = "btnAddMsk";
            this.btnAddMsk.Size = new System.Drawing.Size(121, 43);
            this.btnAddMsk.TabIndex = 30;
            this.btnAddMsk.Text = "Add";
            this.btnAddMsk.UseVisualStyleBackColor = false;
            this.btnAddMsk.Click += new System.EventHandler(this.btnAddMsk_Click);
            // 
            // invetarisBarangDataSet1
            // 
            this.invetarisBarangDataSet1.DataSetName = "InvetarisBarangDataSet1";
            this.invetarisBarangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangMasukBindingSource
            // 
            this.barangMasukBindingSource.DataMember = "Barang_Masuk";
            this.barangMasukBindingSource.DataSource = this.invetarisBarangDataSet1;
            // 
            // barang_MasukTableAdapter
            // 
            this.barang_MasukTableAdapter.ClearBeforeFill = true;
            // 
            // noMasukBarangDataGridViewTextBoxColumn
            // 
            this.noMasukBarangDataGridViewTextBoxColumn.DataPropertyName = "No_Masuk_Barang";
            this.noMasukBarangDataGridViewTextBoxColumn.HeaderText = "No_Masuk_Barang";
            this.noMasukBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noMasukBarangDataGridViewTextBoxColumn.Name = "noMasukBarangDataGridViewTextBoxColumn";
            this.noMasukBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodeBarangDataGridViewTextBoxColumn
            // 
            this.kodeBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode_Barang";
            this.kodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode_Barang";
            this.kodeBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeBarangDataGridViewTextBoxColumn.Name = "kodeBarangDataGridViewTextBoxColumn";
            this.kodeBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "Nama_Barang";
            this.namaBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalMasukDataGridViewTextBoxColumn
            // 
            this.tanggalMasukDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Masuk";
            this.tanggalMasukDataGridViewTextBoxColumn.HeaderText = "Tanggal_Masuk";
            this.tanggalMasukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalMasukDataGridViewTextBoxColumn.Name = "tanggalMasukDataGridViewTextBoxColumn";
            this.tanggalMasukDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaSatuanDataGridViewTextBoxColumn
            // 
            this.hargaSatuanDataGridViewTextBoxColumn.DataPropertyName = "Harga_Satuan";
            this.hargaSatuanDataGridViewTextBoxColumn.HeaderText = "Harga_Satuan";
            this.hargaSatuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaSatuanDataGridViewTextBoxColumn.Name = "hargaSatuanDataGridViewTextBoxColumn";
            this.hargaSatuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // kuantitasDataGridViewTextBoxColumn
            // 
            this.kuantitasDataGridViewTextBoxColumn.DataPropertyName = "Kuantitas";
            this.kuantitasDataGridViewTextBoxColumn.HeaderText = "Kuantitas";
            this.kuantitasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kuantitasDataGridViewTextBoxColumn.Name = "kuantitasDataGridViewTextBoxColumn";
            this.kuantitasDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargatotalDataGridViewTextBoxColumn
            // 
            this.hargatotalDataGridViewTextBoxColumn.DataPropertyName = "Harga_total";
            this.hargatotalDataGridViewTextBoxColumn.HeaderText = "Harga_total";
            this.hargatotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargatotalDataGridViewTextBoxColumn.Name = "hargatotalDataGridViewTextBoxColumn";
            this.hargatotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1168, 497);
            this.Controls.Add(this.btnAddMsk);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelMsk);
            this.Controls.Add(this.btnSaveMsk);
            this.Controls.Add(this.btnDeleteMsk);
            this.Controls.Add(this.txtKondisiBrgMsk);
            this.Controls.Add(this.txtKuantitasMsk);
            this.Controls.Add(this.txtTglMsk);
            this.Controls.Add(this.txtNamaBrgMsk);
            this.Controls.Add(this.txtTotalHrgMsk);
            this.Controls.Add(this.txtHrgStnMsk);
            this.Controls.Add(this.txtKodeBrgMsk);
            this.Controls.Add(this.txtNoMasuk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form4";
            this.Text = "Halaman Barang Masuk";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisBarangDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangMasukBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtKondisiBrgMsk;
        private System.Windows.Forms.TextBox txtKuantitasMsk;
        private System.Windows.Forms.TextBox txtTglMsk;
        private System.Windows.Forms.TextBox txtNamaBrgMsk;
        private System.Windows.Forms.TextBox txtTotalHrgMsk;
        private System.Windows.Forms.TextBox txtHrgStnMsk;
        private System.Windows.Forms.TextBox txtKodeBrgMsk;
        private System.Windows.Forms.TextBox txtNoMasuk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelMsk;
        private System.Windows.Forms.Button btnSaveMsk;
        private System.Windows.Forms.Button btnDeleteMsk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddMsk;
        private InvetarisBarangDataSet1 invetarisBarangDataSet1;
        private System.Windows.Forms.BindingSource barangMasukBindingSource;
        private InvetarisBarangDataSet1TableAdapters.Barang_MasukTableAdapter barang_MasukTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noMasukBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuantitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargatotalDataGridViewTextBoxColumn;
    }
}