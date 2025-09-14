namespace MALIYETLENDIRMESISTEMI
{
    partial class frmsat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsatisid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txturunfiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txturunid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btniptalet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mskalicitelefon = new System.Windows.Forms.MaskedTextBox();
            this.rchaliciadres = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaliciadsoyad = new System.Windows.Forms.TextBox();
            this.btnsatisyap = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(79)))));
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsatisid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txturunfiyat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txturunid);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(29, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN BİLGİLERİ";
            // 
            // txttutar
            // 
            this.txttutar.Enabled = false;
            this.txttutar.Location = new System.Drawing.Point(236, 238);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(188, 33);
            this.txttutar.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "ÖDENECEK TUTAR:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(174, 197);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(250, 33);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "SATIŞ ID:";
            // 
            // txtsatisid
            // 
            this.txtsatisid.Enabled = false;
            this.txtsatisid.Location = new System.Drawing.Point(174, 50);
            this.txtsatisid.Name = "txtsatisid";
            this.txtsatisid.Size = new System.Drawing.Size(250, 33);
            this.txtsatisid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "URUN ADET:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "URUN FİYAT:";
            // 
            // txturunfiyat
            // 
            this.txturunfiyat.Location = new System.Drawing.Point(174, 148);
            this.txturunfiyat.Name = "txturunfiyat";
            this.txturunfiyat.Size = new System.Drawing.Size(250, 33);
            this.txturunfiyat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "URUN ID:";
            // 
            // txturunid
            // 
            this.txturunid.Location = new System.Drawing.Point(174, 99);
            this.txturunid.Name = "txturunid";
            this.txturunid.Size = new System.Drawing.Size(250, 33);
            this.txturunid.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.groupBox2.Controls.Add(this.btniptalet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.mskalicitelefon);
            this.groupBox2.Controls.Add(this.rchaliciadres);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtaliciadsoyad);
            this.groupBox2.Controls.Add(this.btnsatisyap);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(509, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALICI BİLGİLERİ";
            // 
            // btniptalet
            // 
            this.btniptalet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btniptalet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btniptalet.Location = new System.Drawing.Point(414, 203);
            this.btniptalet.Name = "btniptalet";
            this.btniptalet.Size = new System.Drawing.Size(190, 59);
            this.btniptalet.TabIndex = 16;
            this.btniptalet.Text = "İPTAL ET";
            this.btniptalet.UseVisualStyleBackColor = false;
            this.btniptalet.Click += new System.EventHandler(this.btniptalet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "TELEFON:";
            // 
            // mskalicitelefon
            // 
            this.mskalicitelefon.Location = new System.Drawing.Point(156, 88);
            this.mskalicitelefon.Mask = "(999) 000-0000";
            this.mskalicitelefon.Name = "mskalicitelefon";
            this.mskalicitelefon.Size = new System.Drawing.Size(250, 33);
            this.mskalicitelefon.TabIndex = 14;
            // 
            // rchaliciadres
            // 
            this.rchaliciadres.Location = new System.Drawing.Point(156, 140);
            this.rchaliciadres.Name = "rchaliciadres";
            this.rchaliciadres.Size = new System.Drawing.Size(250, 122);
            this.rchaliciadres.TabIndex = 13;
            this.rchaliciadres.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "ADRES:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "AD SOYAD:";
            // 
            // txtaliciadsoyad
            // 
            this.txtaliciadsoyad.Location = new System.Drawing.Point(156, 32);
            this.txtaliciadsoyad.Name = "txtaliciadsoyad";
            this.txtaliciadsoyad.Size = new System.Drawing.Size(250, 33);
            this.txtaliciadsoyad.TabIndex = 9;
            // 
            // btnsatisyap
            // 
            this.btnsatisyap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsatisyap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsatisyap.Location = new System.Drawing.Point(414, 141);
            this.btnsatisyap.Name = "btnsatisyap";
            this.btnsatisyap.Size = new System.Drawing.Size(190, 59);
            this.btnsatisyap.TabIndex = 8;
            this.btnsatisyap.Text = "SATIŞ YAP";
            this.btnsatisyap.UseVisualStyleBackColor = false;
            this.btnsatisyap.Click += new System.EventHandler(this.btnsatisyap_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(29, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 290);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÜRÜN LİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(468, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(509, 323);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(610, 290);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SATIŞ LİSTESİ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(604, 267);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // frmsat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1131, 625);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmsat";
            this.Text = "SATIŞ FORMU";
            this.Load += new System.EventHandler(this.frmsat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txturunfiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txturunid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskalicitelefon;
        private System.Windows.Forms.RichTextBox rchaliciadres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaliciadsoyad;
        private System.Windows.Forms.Button btnsatisyap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsatisid;
        private System.Windows.Forms.Button btniptalet;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Label label8;
    }
}