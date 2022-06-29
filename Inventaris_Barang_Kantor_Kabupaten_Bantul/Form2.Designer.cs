
namespace Inventaris_Barang_Kantor_Kabupaten_Bantul
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(277, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selamat Datang Di Kabupaten Bantul";
            // 
            // btnBarang
            // 
            this.btnBarang.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBarang.ForeColor = System.Drawing.Color.White;
            this.btnBarang.Location = new System.Drawing.Point(505, 182);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(146, 87);
            this.btnBarang.TabIndex = 3;
            this.btnBarang.Text = "Data Barang";
            this.btnBarang.UseVisualStyleBackColor = false;
            this.btnBarang.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMasuk.ForeColor = System.Drawing.Color.White;
            this.btnMasuk.Location = new System.Drawing.Point(505, 306);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(146, 87);
            this.btnMasuk.TabIndex = 3;
            this.btnMasuk.Text = "Barang Masuk";
            this.btnMasuk.UseVisualStyleBackColor = false;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKeluar.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.Location = new System.Drawing.Point(505, 441);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(146, 87);
            this.btnKeluar.TabIndex = 3;
            this.btnKeluar.Text = "Barang Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(993, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 35);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inventaris_Barang_Kantor_Kabupaten_Bantul.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(1136, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventaris_Barang_Kantor_Kabupaten_Bantul.Properties.Resources.logobantul;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1199, 604);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnMasuk);
            this.Controls.Add(this.btnBarang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Halaman Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}