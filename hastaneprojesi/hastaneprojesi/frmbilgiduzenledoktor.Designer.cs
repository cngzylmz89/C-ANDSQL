namespace hastaneprojesi
{
    partial class frmbilgiduzenledoktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbilgiduzenledoktor));
            this.lnklblbilgiduzelt = new System.Windows.Forms.LinkLabel();
            this.msksifredoktor = new System.Windows.Forms.MaskedTextBox();
            this.msktcdoktor = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyaddoktor = new System.Windows.Forms.TextBox();
            this.txtadoktorad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnklblbilgiduzelt
            // 
            this.lnklblbilgiduzelt.AutoSize = true;
            this.lnklblbilgiduzelt.BackColor = System.Drawing.Color.GreenYellow;
            this.lnklblbilgiduzelt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnklblbilgiduzelt.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklblbilgiduzelt.Location = new System.Drawing.Point(207, 348);
            this.lnklblbilgiduzelt.Name = "lnklblbilgiduzelt";
            this.lnklblbilgiduzelt.Padding = new System.Windows.Forms.Padding(5);
            this.lnklblbilgiduzelt.Size = new System.Drawing.Size(94, 35);
            this.lnklblbilgiduzelt.TabIndex = 39;
            this.lnklblbilgiduzelt.TabStop = true;
            this.lnklblbilgiduzelt.Text = "Güncelle";
            this.lnklblbilgiduzelt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblbilgiduzelt_LinkClicked);
            // 
            // msksifredoktor
            // 
            this.msksifredoktor.Location = new System.Drawing.Point(207, 306);
            this.msksifredoktor.Mask = "0000000000";
            this.msksifredoktor.Name = "msksifredoktor";
            this.msksifredoktor.Size = new System.Drawing.Size(138, 20);
            this.msksifredoktor.TabIndex = 38;
            this.msksifredoktor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msksifre_MaskInputRejected);
            // 
            // msktcdoktor
            // 
            this.msktcdoktor.Enabled = false;
            this.msktcdoktor.Location = new System.Drawing.Point(207, 215);
            this.msktcdoktor.Mask = "00000000000";
            this.msktcdoktor.Name = "msktcdoktor";
            this.msktcdoktor.ReadOnly = true;
            this.msktcdoktor.Size = new System.Drawing.Size(138, 20);
            this.msktcdoktor.TabIndex = 37;
            this.msktcdoktor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktc_MaskInputRejected);
            // 
            // txtsoyaddoktor
            // 
            this.txtsoyaddoktor.Location = new System.Drawing.Point(206, 162);
            this.txtsoyaddoktor.Name = "txtsoyaddoktor";
            this.txtsoyaddoktor.Size = new System.Drawing.Size(138, 20);
            this.txtsoyaddoktor.TabIndex = 36;
            // 
            // txtadoktorad
            // 
            this.txtadoktorad.Location = new System.Drawing.Point(206, 108);
            this.txtadoktorad.Name = "txtadoktorad";
            this.txtadoktorad.Size = new System.Drawing.Size(138, 20);
            this.txtadoktorad.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(128, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "ŞİFRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "T.C. KİMLİK NUMARASI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(128, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "SOYADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(158, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "ADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 48);
            this.label1.TabIndex = 30;
            this.label1.Text = "DOKTOR BİLGİ \r\nGÜNCELLEME PANELİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(206, 262);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(139, 21);
            this.cmbbrans.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(128, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "BRANŞ:";
            // 
            // frmbilgiduzenledoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(448, 436);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.lnklblbilgiduzelt);
            this.Controls.Add(this.msksifredoktor);
            this.Controls.Add(this.msktcdoktor);
            this.Controls.Add(this.txtsoyaddoktor);
            this.Controls.Add(this.txtadoktorad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbilgiduzenledoktor";
            this.Text = "frmbilgiduzenledoktor";
            this.Load += new System.EventHandler(this.frmbilgiduzenledoktor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnklblbilgiduzelt;
        private System.Windows.Forms.MaskedTextBox msksifredoktor;
        private System.Windows.Forms.MaskedTextBox msktcdoktor;
        private System.Windows.Forms.TextBox txtsoyaddoktor;
        private System.Windows.Forms.TextBox txtadoktorad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label5;
    }
}