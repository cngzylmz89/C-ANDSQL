namespace Okulbonus
{
    partial class frmOgrenciler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciler));
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tBLDERSLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oKULBONUSDataSet = new Okulbonus.OKULBONUSDataSet();
            this.tBLDERSLERTableAdapter = new Okulbonus.OKULBONUSDataSetTableAdapters.TBLDERSLERTableAdapter();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnogrencisil = new System.Windows.Forms.Button();
            this.btnogrenciekle = new System.Windows.Forms.Button();
            this.btnogrenciguncelle = new System.Windows.Forms.Button();
            this.btnogrencilistele = new System.Windows.Forms.Button();
            this.txtogrenciadi = new System.Windows.Forms.TextBox();
            this.mskogrenciid = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtogrencisoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbkulup = new System.Windows.Forms.ComboBox();
            this.rdyerkek = new System.Windows.Forms.RadioButton();
            this.rdykiz = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager1 = new Okulbonus.DataSet1TableAdapters.TableAdapterManager();
            this.label9 = new System.Windows.Forms.Label();
            this.btnogrenciara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULBONUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView3.Location = new System.Drawing.Point(3, 27);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(830, 163);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // tBLDERSLERBindingSource
            // 
            this.tBLDERSLERBindingSource.DataMember = "TBLDERSLER";
            this.tBLDERSLERBindingSource.DataSource = this.oKULBONUSDataSet;
            // 
            // oKULBONUSDataSet
            // 
            this.oKULBONUSDataSet.DataSetName = "OKULBONUSDataSet";
            this.oKULBONUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLDERSLERTableAdapter
            // 
            this.tBLDERSLERTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(806, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 47;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(246, 322);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(69, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(246, 272);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 322);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // btnogrencisil
            // 
            this.btnogrencisil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnogrencisil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnogrencisil.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrencisil.Location = new System.Drawing.Point(321, 322);
            this.btnogrencisil.Name = "btnogrencisil";
            this.btnogrencisil.Size = new System.Drawing.Size(131, 44);
            this.btnogrencisil.TabIndex = 42;
            this.btnogrencisil.Text = "SİL";
            this.btnogrencisil.UseVisualStyleBackColor = true;
            this.btnogrencisil.Click += new System.EventHandler(this.btnogrencisil_Click);
            // 
            // btnogrenciekle
            // 
            this.btnogrenciekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnogrenciekle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnogrenciekle.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrenciekle.Location = new System.Drawing.Point(82, 322);
            this.btnogrenciekle.Name = "btnogrenciekle";
            this.btnogrenciekle.Size = new System.Drawing.Size(131, 44);
            this.btnogrenciekle.TabIndex = 41;
            this.btnogrenciekle.Text = "EKLE";
            this.btnogrenciekle.UseVisualStyleBackColor = true;
            this.btnogrenciekle.Click += new System.EventHandler(this.btnogrenciekle_Click);
            // 
            // btnogrenciguncelle
            // 
            this.btnogrenciguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnogrenciguncelle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnogrenciguncelle.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrenciguncelle.Location = new System.Drawing.Point(321, 272);
            this.btnogrenciguncelle.Name = "btnogrenciguncelle";
            this.btnogrenciguncelle.Size = new System.Drawing.Size(131, 44);
            this.btnogrenciguncelle.TabIndex = 40;
            this.btnogrenciguncelle.Text = "GÜNCELLE";
            this.btnogrenciguncelle.UseVisualStyleBackColor = true;
            this.btnogrenciguncelle.Click += new System.EventHandler(this.btnogrenciguncelle_Click);
            // 
            // btnogrencilistele
            // 
            this.btnogrencilistele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnogrencilistele.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnogrencilistele.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrencilistele.Location = new System.Drawing.Point(82, 272);
            this.btnogrencilistele.Name = "btnogrencilistele";
            this.btnogrencilistele.Size = new System.Drawing.Size(132, 44);
            this.btnogrencilistele.TabIndex = 39;
            this.btnogrencilistele.Text = "LİSTELE";
            this.btnogrencilistele.UseVisualStyleBackColor = true;
            // 
            // txtogrenciadi
            // 
            this.txtogrenciadi.Location = new System.Drawing.Point(198, 67);
            this.txtogrenciadi.Name = "txtogrenciadi";
            this.txtogrenciadi.Size = new System.Drawing.Size(157, 20);
            this.txtogrenciadi.TabIndex = 37;
            // 
            // mskogrenciid
            // 
            this.mskogrenciid.Enabled = false;
            this.mskogrenciid.Location = new System.Drawing.Point(198, 29);
            this.mskogrenciid.Mask = "000";
            this.mskogrenciid.Name = "mskogrenciid";
            this.mskogrenciid.Size = new System.Drawing.Size(157, 20);
            this.mskogrenciid.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "ÖĞRENCİ ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "ÖĞRENCİ İŞLEMLERİ PANELİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "ÖĞRENCİ ADI:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(7, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 193);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KULÜP LİSTESİ";
            // 
            // txtogrencisoyad
            // 
            this.txtogrencisoyad.Location = new System.Drawing.Point(198, 105);
            this.txtogrencisoyad.Name = "txtogrencisoyad";
            this.txtogrencisoyad.Size = new System.Drawing.Size(157, 20);
            this.txtogrencisoyad.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "ÖĞRENCİ SOYADI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "ÖĞRENCİ KULÜBÜ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "ÖĞRENCİ CİNSİYET:";
            // 
            // cmbkulup
            // 
            this.cmbkulup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkulup.FormattingEnabled = true;
            this.cmbkulup.Location = new System.Drawing.Point(198, 141);
            this.cmbkulup.Name = "cmbkulup";
            this.cmbkulup.Size = new System.Drawing.Size(159, 21);
            this.cmbkulup.TabIndex = 54;
            // 
            // rdyerkek
            // 
            this.rdyerkek.AutoSize = true;
            this.rdyerkek.ForeColor = System.Drawing.Color.White;
            this.rdyerkek.Location = new System.Drawing.Point(210, 183);
            this.rdyerkek.Name = "rdyerkek";
            this.rdyerkek.Size = new System.Drawing.Size(61, 17);
            this.rdyerkek.TabIndex = 55;
            this.rdyerkek.TabStop = true;
            this.rdyerkek.Text = "ERKEK";
            this.rdyerkek.UseVisualStyleBackColor = true;
            this.rdyerkek.CheckedChanged += new System.EventHandler(this.rdyerkek_CheckedChanged);
            // 
            // rdykiz
            // 
            this.rdykiz.AutoSize = true;
            this.rdykiz.ForeColor = System.Drawing.Color.White;
            this.rdykiz.Location = new System.Drawing.Point(298, 184);
            this.rdykiz.Name = "rdykiz";
            this.rdykiz.Size = new System.Drawing.Size(42, 17);
            this.rdykiz.TabIndex = 56;
            this.rdykiz.TabStop = true;
            this.rdykiz.Text = "KIZ";
            this.rdykiz.UseVisualStyleBackColor = true;
            this.rdykiz.CheckedChanged += new System.EventHandler(this.rdykiz_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rdykiz);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdyerkek);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbkulup);
            this.groupBox2.Controls.Add(this.mskogrenciid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtogrenciadi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtogrencisoyad);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(458, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 210);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÖĞRENCİ BİLGİLERİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(31, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "ÖĞRENCİ SOYADI:";
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(206, 445);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(215, 20);
            this.txtara.TabIndex = 57;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(77, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Öğrenci Ara";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(10, 400);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(69, 44);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 59;
            this.pictureBox7.TabStop = false;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.TBLDERSLERTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Okulbonus.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "ERKEK";
            // 
            // btnogrenciara
            // 
            this.btnogrenciara.Location = new System.Drawing.Point(220, 408);
            this.btnogrenciara.Name = "btnogrenciara";
            this.btnogrenciara.Size = new System.Drawing.Size(106, 23);
            this.btnogrenciara.TabIndex = 61;
            this.btnogrenciara.Text = "ÖĞRENCİ ARA";
            this.btnogrenciara.UseVisualStyleBackColor = true;
            this.btnogrenciara.Click += new System.EventHandler(this.btnogrenciara_Click);
            // 
            // frmOgrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(854, 494);
            this.Controls.Add(this.btnogrenciara);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnogrencisil);
            this.Controls.Add(this.btnogrenciekle);
            this.Controls.Add(this.btnogrenciguncelle);
            this.Controls.Add(this.btnogrencilistele);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOgrenciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOgrenciler";
            this.Load += new System.EventHandler(this.frmOgrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULBONUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource tBLDERSLERBindingSource;
        private OKULBONUSDataSet oKULBONUSDataSet;
        private OKULBONUSDataSetTableAdapters.TBLDERSLERTableAdapter tBLDERSLERTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnogrencisil;
        private System.Windows.Forms.Button btnogrenciekle;
        private System.Windows.Forms.Button btnogrenciguncelle;
        private System.Windows.Forms.Button btnogrencilistele;
        private System.Windows.Forms.TextBox txtogrenciadi;
        private System.Windows.Forms.MaskedTextBox mskogrenciid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtogrencisoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbkulup;
        private System.Windows.Forms.RadioButton rdyerkek;
        private System.Windows.Forms.RadioButton rdykiz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtara;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnogrenciara;
    }
}