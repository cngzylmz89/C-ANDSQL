namespace Kelimogrenaccesile
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblingilizce = new System.Windows.Forms.Label();
            this.txtturkce = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblyarismaci = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.lblyanlis = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnbasla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kelimogrenaccesile.Properties.Resources.kelimeogren;
            this.pictureBox1.Location = new System.Drawing.Point(39, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kelimogrenaccesile.Properties.Resources.kelimeogren;
            this.pictureBox2.Location = new System.Drawing.Point(26, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(594, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "İNGİLİZCE SÖZCÜK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "TÜRKÇE ANLAMI:";
            // 
            // lblingilizce
            // 
            this.lblingilizce.AutoSize = true;
            this.lblingilizce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblingilizce.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblingilizce.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblingilizce.Location = new System.Drawing.Point(250, 199);
            this.lblingilizce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblingilizce.Name = "lblingilizce";
            this.lblingilizce.Size = new System.Drawing.Size(160, 24);
            this.lblingilizce.TabIndex = 4;
            this.lblingilizce.Text = "                         ";
            // 
            // txtturkce
            // 
            this.txtturkce.Location = new System.Drawing.Point(254, 260);
            this.txtturkce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtturkce.Name = "txtturkce";
            this.txtturkce.Size = new System.Drawing.Size(138, 20);
            this.txtturkce.TabIndex = 5;
            this.txtturkce.TextChanged += new System.EventHandler(this.txtturkce_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(605, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "SÜRE";
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.Location = new System.Drawing.Point(672, 104);
            this.lblsure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(64, 24);
            this.lblsure.TabIndex = 7;
            this.lblsure.Text = "         ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(539, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "DOĞRU:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(539, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "YANLIŞ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(56, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "YARIŞMACI:";
            // 
            // lblyarismaci
            // 
            this.lblyarismaci.AutoSize = true;
            this.lblyarismaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblyarismaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyarismaci.ForeColor = System.Drawing.Color.White;
            this.lblyarismaci.Location = new System.Drawing.Point(250, 115);
            this.lblyarismaci.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblyarismaci.Name = "lblyarismaci";
            this.lblyarismaci.Size = new System.Drawing.Size(232, 24);
            this.lblyarismaci.TabIndex = 11;
            this.lblyarismaci.Text = "                                     ";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbldogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogru.ForeColor = System.Drawing.SystemColors.Window;
            this.lbldogru.Location = new System.Drawing.Point(649, 199);
            this.lbldogru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(64, 24);
            this.lbldogru.TabIndex = 12;
            this.lbldogru.Text = "         ";
            // 
            // lblyanlis
            // 
            this.lblyanlis.AutoSize = true;
            this.lblyanlis.BackColor = System.Drawing.Color.Red;
            this.lblyanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyanlis.ForeColor = System.Drawing.SystemColors.Window;
            this.lblyanlis.Location = new System.Drawing.Point(649, 240);
            this.lblyanlis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblyanlis.Name = "lblyanlis";
            this.lblyanlis.Size = new System.Drawing.Size(64, 24);
            this.lblyanlis.TabIndex = 13;
            this.lblyanlis.Text = "         ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnbasla
            // 
            this.btnbasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbasla.Location = new System.Drawing.Point(543, 313);
            this.btnbasla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(99, 31);
            this.btnbasla.TabIndex = 14;
            this.btnbasla.Text = "BAŞLA";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(778, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.lblyanlis);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.lblyarismaci);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtturkce);
            this.Controls.Add(this.lblingilizce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form2";
            this.Text = "İNGİLİZCE KELİME ÖĞREN";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblingilizce;
        private System.Windows.Forms.TextBox txtturkce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblyarismaci;
        private System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Label lblyanlis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Label label3;
    }
}