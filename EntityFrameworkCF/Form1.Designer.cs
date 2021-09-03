namespace EntityFrameworkCF
{
    partial class Form1
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
            this.tbara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsepetlist = new System.Windows.Forms.Button();
            this.btnkategorilist = new System.Windows.Forms.Button();
            this.btnmarkalist = new System.Windows.Forms.Button();
            this.btnurunlist = new System.Windows.Forms.Button();
            this.btnmusterilist = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.tbsehir = new System.Windows.Forms.TextBox();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.tbadisoyadi = new System.Windows.Forms.TextBox();
            this.tbmusteriid = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbkategoriadi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbkategoriid = new System.Windows.Forms.TextBox();
            this.btnsepet = new System.Windows.Forms.Button();
            this.btnurun = new System.Windows.Forms.Button();
            this.tbmarkaid = new System.Windows.Forms.TextBox();
            this.tbmarkaadi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbkategoriid = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbara
            // 
            this.tbara.Location = new System.Drawing.Point(187, 11);
            this.tbara.Name = "tbara";
            this.tbara.Size = new System.Drawing.Size(190, 20);
            this.tbara.TabIndex = 35;
            this.tbara.TextChanged += new System.EventHandler(this.tbara_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(64, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Adı Soyadı Ara :";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(616, 376);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(86, 41);
            this.btnsil.TabIndex = 33;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(616, 331);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(86, 40);
            this.btnguncelle.TabIndex = 32;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(616, 284);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(86, 42);
            this.btnekle.TabIndex = 31;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsepetlist
            // 
            this.btnsepetlist.Location = new System.Drawing.Point(616, 245);
            this.btnsepetlist.Name = "btnsepetlist";
            this.btnsepetlist.Size = new System.Drawing.Size(86, 34);
            this.btnsepetlist.TabIndex = 82;
            this.btnsepetlist.Text = "Sepet Listele";
            this.btnsepetlist.UseVisualStyleBackColor = true;
            this.btnsepetlist.Click += new System.EventHandler(this.btnsepetlist_Click);
            // 
            // btnkategorilist
            // 
            this.btnkategorilist.Location = new System.Drawing.Point(616, 200);
            this.btnkategorilist.Name = "btnkategorilist";
            this.btnkategorilist.Size = new System.Drawing.Size(86, 40);
            this.btnkategorilist.TabIndex = 83;
            this.btnkategorilist.Text = "Kategori Listele";
            this.btnkategorilist.UseVisualStyleBackColor = true;
            this.btnkategorilist.Click += new System.EventHandler(this.btnkategorilist_Click);
            // 
            // btnmarkalist
            // 
            this.btnmarkalist.Location = new System.Drawing.Point(616, 167);
            this.btnmarkalist.Name = "btnmarkalist";
            this.btnmarkalist.Size = new System.Drawing.Size(86, 28);
            this.btnmarkalist.TabIndex = 84;
            this.btnmarkalist.Text = "Marka Listele";
            this.btnmarkalist.UseVisualStyleBackColor = true;
            this.btnmarkalist.Click += new System.EventHandler(this.btnmarkalist_Click);
            // 
            // btnurunlist
            // 
            this.btnurunlist.Location = new System.Drawing.Point(616, 134);
            this.btnurunlist.Name = "btnurunlist";
            this.btnurunlist.Size = new System.Drawing.Size(86, 28);
            this.btnurunlist.TabIndex = 85;
            this.btnurunlist.Text = "Ürün Listele";
            this.btnurunlist.UseVisualStyleBackColor = true;
            this.btnurunlist.Click += new System.EventHandler(this.btnurunlist_Click);
            // 
            // btnmusterilist
            // 
            this.btnmusterilist.Location = new System.Drawing.Point(616, 94);
            this.btnmusterilist.Name = "btnmusterilist";
            this.btnmusterilist.Size = new System.Drawing.Size(86, 35);
            this.btnmusterilist.TabIndex = 86;
            this.btnmusterilist.Text = "Müşteri Listele";
            this.btnmusterilist.UseVisualStyleBackColor = true;
            this.btnmusterilist.Click += new System.EventHandler(this.btnmusterilist_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbemail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTarih);
            this.groupBox1.Controls.Add(this.tbsehir);
            this.groupBox1.Controls.Add(this.tbtel);
            this.groupBox1.Controls.Add(this.tbadisoyadi);
            this.groupBox1.Controls.Add(this.tbmusteriid);
            this.groupBox1.Location = new System.Drawing.Point(43, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 188);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tarih :";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(82, 127);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(144, 20);
            this.tbemail.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Şehir :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Adı Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Müsteri Id :";
            // 
            // dateTarih
            // 
            this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTarih.Location = new System.Drawing.Point(82, 154);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(144, 20);
            this.dateTarih.TabIndex = 35;
            // 
            // tbsehir
            // 
            this.tbsehir.Location = new System.Drawing.Point(82, 100);
            this.tbsehir.Name = "tbsehir";
            this.tbsehir.Size = new System.Drawing.Size(144, 20);
            this.tbsehir.TabIndex = 34;
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(82, 73);
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(144, 20);
            this.tbtel.TabIndex = 33;
            // 
            // tbadisoyadi
            // 
            this.tbadisoyadi.Location = new System.Drawing.Point(82, 46);
            this.tbadisoyadi.Name = "tbadisoyadi";
            this.tbadisoyadi.Size = new System.Drawing.Size(144, 20);
            this.tbadisoyadi.TabIndex = 32;
            // 
            // tbmusteriid
            // 
            this.tbmusteriid.Location = new System.Drawing.Point(82, 19);
            this.tbmusteriid.Name = "tbmusteriid";
            this.tbmusteriid.Size = new System.Drawing.Size(144, 20);
            this.tbmusteriid.TabIndex = 31;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox4.Controls.Add(this.cbkategoriid);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.tbmarkaadi);
            this.groupBox4.Controls.Add(this.tbmarkaid);
            this.groupBox4.Location = new System.Drawing.Point(319, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 102);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Marka";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox5.Controls.Add(this.tbkategoriadi);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.tbkategoriid);
            this.groupBox5.Location = new System.Drawing.Point(319, 225);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 80);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kategori";
            // 
            // tbkategoriadi
            // 
            this.tbkategoriadi.Location = new System.Drawing.Point(84, 52);
            this.tbkategoriadi.Name = "tbkategoriadi";
            this.tbkategoriadi.Size = new System.Drawing.Size(144, 20);
            this.tbkategoriadi.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Kategori Adı :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Kategori Id :";
            // 
            // tbkategoriid
            // 
            this.tbkategoriid.Location = new System.Drawing.Point(84, 26);
            this.tbkategoriid.Name = "tbkategoriid";
            this.tbkategoriid.Size = new System.Drawing.Size(144, 20);
            this.tbkategoriid.TabIndex = 59;
            // 
            // btnsepet
            // 
            this.btnsepet.Location = new System.Drawing.Point(616, 54);
            this.btnsepet.Name = "btnsepet";
            this.btnsepet.Size = new System.Drawing.Size(86, 35);
            this.btnsepet.TabIndex = 93;
            this.btnsepet.Text = "Sepet İşlemleri";
            this.btnsepet.UseVisualStyleBackColor = true;
            this.btnsepet.Click += new System.EventHandler(this.btnsepet_Click);
            // 
            // btnurun
            // 
            this.btnurun.Location = new System.Drawing.Point(616, 14);
            this.btnurun.Name = "btnurun";
            this.btnurun.Size = new System.Drawing.Size(86, 35);
            this.btnurun.TabIndex = 94;
            this.btnurun.Text = "Ürün İşlemleri";
            this.btnurun.UseVisualStyleBackColor = true;
            this.btnurun.Click += new System.EventHandler(this.btnurun_Click);
            // 
            // tbmarkaid
            // 
            this.tbmarkaid.Location = new System.Drawing.Point(86, 11);
            this.tbmarkaid.Name = "tbmarkaid";
            this.tbmarkaid.Size = new System.Drawing.Size(144, 20);
            this.tbmarkaid.TabIndex = 56;
            // 
            // tbmarkaadi
            // 
            this.tbmarkaadi.Location = new System.Drawing.Point(86, 69);
            this.tbmarkaadi.Name = "tbmarkaadi";
            this.tbmarkaadi.Size = new System.Drawing.Size(144, 20);
            this.tbmarkaadi.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 59;
            this.label19.Text = "Marka Id :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 60;
            this.label18.Text = "Kategori Id :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "Marka Adı :";
            // 
            // cbkategoriid
            // 
            this.cbkategoriid.FormattingEnabled = true;
            this.cbkategoriid.Location = new System.Drawing.Point(86, 38);
            this.cbkategoriid.Name = "cbkategoriid";
            this.cbkategoriid.Size = new System.Drawing.Size(144, 21);
            this.cbkategoriid.TabIndex = 62;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 182);
            this.dataGridView1.TabIndex = 95;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(714, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnurun);
            this.Controls.Add(this.btnsepet);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnmusterilist);
            this.Controls.Add(this.btnurunlist);
            this.Controls.Add(this.btnmarkalist);
            this.Controls.Add(this.btnkategorilist);
            this.Controls.Add(this.btnsepetlist);
            this.Controls.Add(this.tbara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsepetlist;
        private System.Windows.Forms.Button btnkategorilist;
        private System.Windows.Forms.Button btnmarkalist;
        private System.Windows.Forms.Button btnurunlist;
        private System.Windows.Forms.Button btnmusterilist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private System.Windows.Forms.TextBox tbsehir;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.TextBox tbadisoyadi;
        private System.Windows.Forms.TextBox tbmusteriid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbkategoriadi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbkategoriid;
        private System.Windows.Forms.Button btnsepet;
        private System.Windows.Forms.Button btnurun;
        private System.Windows.Forms.ComboBox cbkategoriid;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbmarkaadi;
        private System.Windows.Forms.TextBox tbmarkaid;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}