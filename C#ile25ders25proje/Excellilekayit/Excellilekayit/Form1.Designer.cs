namespace Excellilekayit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchadres = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtanneadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbabaadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadisoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsirano = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(945, 594);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(422, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 623);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.groupBox2.Controls.Add(this.txtsirano);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rchadres);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txttelno);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtanneadi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbabaadi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtadisoyadi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 611);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // rchadres
            // 
            this.rchadres.Location = new System.Drawing.Point(178, 304);
            this.rchadres.Name = "rchadres";
            this.rchadres.Size = new System.Drawing.Size(203, 113);
            this.rchadres.TabIndex = 16;
            this.rchadres.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnkaydet);
            this.panel1.Controls.Add(this.btnlistele);
            this.panel1.Controls.Add(this.btnguncelle);
            this.panel1.Controls.Add(this.btnsil);
            this.panel1.Location = new System.Drawing.Point(12, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 182);
            this.panel1.TabIndex = 15;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(16, 45);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(141, 47);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(184, 113);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(141, 47);
            this.btnlistele.TabIndex = 14;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(16, 113);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(141, 47);
            this.btnguncelle.TabIndex = 12;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(184, 45);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(141, 47);
            this.btnsil.TabIndex = 13;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "ADRESİ";
            // 
            // txttelno
            // 
            this.txttelno.Location = new System.Drawing.Point(178, 253);
            this.txttelno.Name = "txttelno";
            this.txttelno.Size = new System.Drawing.Size(203, 30);
            this.txttelno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "TEL NO:";
            // 
            // txtanneadi
            // 
            this.txtanneadi.Location = new System.Drawing.Point(178, 202);
            this.txtanneadi.Name = "txtanneadi";
            this.txtanneadi.Size = new System.Drawing.Size(203, 30);
            this.txtanneadi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ANNE ADI:";
            // 
            // txtbabaadi
            // 
            this.txtbabaadi.Location = new System.Drawing.Point(178, 151);
            this.txtbabaadi.Name = "txtbabaadi";
            this.txtbabaadi.Size = new System.Drawing.Size(203, 30);
            this.txtbabaadi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "BABA ADI:";
            // 
            // txtadisoyadi
            // 
            this.txtadisoyadi.Location = new System.Drawing.Point(178, 100);
            this.txtadisoyadi.Name = "txtadisoyadi";
            this.txtadisoyadi.Size = new System.Drawing.Size(203, 30);
            this.txtadisoyadi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI SOYADI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "SIRA NO:";
            // 
            // txtsirano
            // 
            this.txtsirano.Enabled = false;
            this.txtsirano.Location = new System.Drawing.Point(178, 49);
            this.txtsirano.Name = "txtsirano";
            this.txtsirano.Size = new System.Drawing.Size(203, 30);
            this.txtsirano.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1371, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ÖĞRENCİ KAYIT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttelno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtanneadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbabaadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadisoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchadres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsirano;
    }
}

