namespace hastaneprojesi
{
    partial class frmsekreterkayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsekreterkayit));
            this.lnklbluyeol = new System.Windows.Forms.LinkLabel();
            this.msksekretersifre = new System.Windows.Forms.MaskedTextBox();
            this.msksekretertc = new System.Windows.Forms.MaskedTextBox();
            this.txtsekretersoyad = new System.Windows.Forms.TextBox();
            this.txtsekreterad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnklbluyeol
            // 
            this.lnklbluyeol.AutoSize = true;
            this.lnklbluyeol.BackColor = System.Drawing.Color.GreenYellow;
            this.lnklbluyeol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnklbluyeol.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklbluyeol.Location = new System.Drawing.Point(204, 271);
            this.lnklbluyeol.Name = "lnklbluyeol";
            this.lnklbluyeol.Padding = new System.Windows.Forms.Padding(5);
            this.lnklbluyeol.Size = new System.Drawing.Size(88, 35);
            this.lnklbluyeol.TabIndex = 29;
            this.lnklbluyeol.TabStop = true;
            this.lnklbluyeol.Text = "Kayıt Ol";
            this.lnklbluyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbluyeol_LinkClicked);
            // 
            // msksekretersifre
            // 
            this.msksekretersifre.Location = new System.Drawing.Point(204, 218);
            this.msksekretersifre.Mask = "0000000000";
            this.msksekretersifre.Name = "msksekretersifre";
            this.msksekretersifre.Size = new System.Drawing.Size(138, 20);
            this.msksekretersifre.TabIndex = 28;
            // 
            // msksekretertc
            // 
            this.msksekretertc.Location = new System.Drawing.Point(204, 169);
            this.msksekretertc.Mask = "00000000000";
            this.msksekretertc.Name = "msksekretertc";
            this.msksekretertc.Size = new System.Drawing.Size(138, 20);
            this.msksekretertc.TabIndex = 24;
            // 
            // txtsekretersoyad
            // 
            this.txtsekretersoyad.Location = new System.Drawing.Point(203, 116);
            this.txtsekretersoyad.Name = "txtsekretersoyad";
            this.txtsekretersoyad.Size = new System.Drawing.Size(138, 20);
            this.txtsekretersoyad.TabIndex = 23;
            // 
            // txtsekreterad
            // 
            this.txtsekreterad.Location = new System.Drawing.Point(203, 62);
            this.txtsekreterad.Name = "txtsekreterad";
            this.txtsekreterad.Size = new System.Drawing.Size(138, 20);
            this.txtsekreterad.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(125, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "ŞİFRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "T.C. KİMLİK NUMARASI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(125, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "SOYADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "ADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "SEKRETER KAYIT PANELİ";
            // 
            // frmsekreterkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(397, 328);
            this.Controls.Add(this.lnklbluyeol);
            this.Controls.Add(this.msksekretersifre);
            this.Controls.Add(this.msksekretertc);
            this.Controls.Add(this.txtsekretersoyad);
            this.Controls.Add(this.txtsekreterad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmsekreterkayit";
            this.Text = "SEKRETER KAYIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnklbluyeol;
        private System.Windows.Forms.MaskedTextBox msksekretersifre;
        private System.Windows.Forms.MaskedTextBox msksekretertc;
        private System.Windows.Forms.TextBox txtsekretersoyad;
        private System.Windows.Forms.TextBox txtsekreterad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}