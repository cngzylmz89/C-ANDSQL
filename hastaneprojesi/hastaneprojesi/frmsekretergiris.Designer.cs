namespace hastaneprojesi
{
    partial class frmsekretergiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsekretergiris));
            this.button1 = new System.Windows.Forms.Button();
            this.txtsekretersifre = new System.Windows.Forms.TextBox();
            this.captchasekreter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcaptca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkkayitol = new System.Windows.Forms.LinkLabel();
            this.msksekretertc = new System.Windows.Forms.MaskedTextBox();
            this.btncaptchadegistir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GİRİŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsekretersifre
            // 
            this.txtsekretersifre.Location = new System.Drawing.Point(15, 133);
            this.txtsekretersifre.Name = "txtsekretersifre";
            this.txtsekretersifre.Size = new System.Drawing.Size(173, 20);
            this.txtsekretersifre.TabIndex = 3;
            this.txtsekretersifre.UseSystemPasswordChar = true;
            // 
            // captchasekreter
            // 
            this.captchasekreter.Location = new System.Drawing.Point(15, 192);
            this.captchasekreter.Name = "captchasekreter";
            this.captchasekreter.Size = new System.Drawing.Size(84, 20);
            this.captchasekreter.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC KİMLİK NUMARASI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "ŞİFRENİZ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "METNİ GİRİNİZ:";
            // 
            // lblcaptca
            // 
            this.lblcaptca.AutoSize = true;
            this.lblcaptca.BackColor = System.Drawing.Color.LightGray;
            this.lblcaptca.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcaptca.Location = new System.Drawing.Point(132, 184);
            this.lblcaptca.Name = "lblcaptca";
            this.lblcaptca.Padding = new System.Windows.Forms.Padding(5);
            this.lblcaptca.Size = new System.Drawing.Size(66, 35);
            this.lblcaptca.TabIndex = 8;
            this.lblcaptca.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "SEKRETER GİRİŞ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.lnkkayitol);
            this.groupBox1.Controls.Add(this.msksekretertc);
            this.groupBox1.Controls.Add(this.btncaptchadegistir);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblcaptca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsekretersifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.captchasekreter);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 258);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞ VE KAYDOL";
            // 
            // lnkkayitol
            // 
            this.lnkkayitol.AutoSize = true;
            this.lnkkayitol.Location = new System.Drawing.Point(291, 125);
            this.lnkkayitol.Name = "lnkkayitol";
            this.lnkkayitol.Size = new System.Drawing.Size(55, 13);
            this.lnkkayitol.TabIndex = 12;
            this.lnkkayitol.TabStop = true;
            this.lnkkayitol.Text = "KAYIT OL";
            this.lnkkayitol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkkayitol_LinkClicked);
            // 
            // msksekretertc
            // 
            this.msksekretertc.Location = new System.Drawing.Point(19, 74);
            this.msksekretertc.Mask = "00000000000";
            this.msksekretertc.Name = "msksekretertc";
            this.msksekretertc.Size = new System.Drawing.Size(179, 20);
            this.msksekretertc.TabIndex = 11;
            // 
            // btncaptchadegistir
            // 
            this.btncaptchadegistir.Location = new System.Drawing.Point(123, 225);
            this.btncaptchadegistir.Name = "btncaptchadegistir";
            this.btncaptchadegistir.Size = new System.Drawing.Size(75, 23);
            this.btncaptchadegistir.TabIndex = 10;
            this.btncaptchadegistir.Text = "DEĞİŞTİR";
            this.btncaptchadegistir.UseVisualStyleBackColor = true;
            this.btncaptchadegistir.Click += new System.EventHandler(this.btncaptchadegistir_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "ANA FORMA GİT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmsekretergiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(535, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmsekretergiris";
            this.Text = "SEKRETER GİRİS";
            this.Load += new System.EventHandler(this.frmsekretergiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsekretersifre;
        private System.Windows.Forms.TextBox captchasekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcaptca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btncaptchadegistir;
        private System.Windows.Forms.MaskedTextBox msksekretertc;
        private System.Windows.Forms.LinkLabel lnkkayitol;
    }
}