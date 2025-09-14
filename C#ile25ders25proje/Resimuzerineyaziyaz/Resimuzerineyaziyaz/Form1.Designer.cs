namespace Resimuzerineyaziyaz
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
            this.btnrenksec = new System.Windows.Forms.Button();
            this.btnresimsec = new System.Windows.Forms.Button();
            this.btnyazdir = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmetin = new System.Windows.Forms.TextBox();
            this.txtboyut = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrenksec
            // 
            this.btnrenksec.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrenksec.Location = new System.Drawing.Point(38, 110);
            this.btnrenksec.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnrenksec.Name = "btnrenksec";
            this.btnrenksec.Size = new System.Drawing.Size(266, 56);
            this.btnrenksec.TabIndex = 1;
            this.btnrenksec.Text = "RENK SEÇ";
            this.btnrenksec.UseVisualStyleBackColor = true;
            this.btnrenksec.Click += new System.EventHandler(this.btnrenksec_Click);
            // 
            // btnresimsec
            // 
            this.btnresimsec.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnresimsec.Location = new System.Drawing.Point(38, 14);
            this.btnresimsec.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnresimsec.Name = "btnresimsec";
            this.btnresimsec.Size = new System.Drawing.Size(266, 56);
            this.btnresimsec.TabIndex = 0;
            this.btnresimsec.Text = "RESİM SEÇ";
            this.btnresimsec.UseVisualStyleBackColor = true;
            this.btnresimsec.Click += new System.EventHandler(this.btnresimsec_Click);
            // 
            // btnyazdir
            // 
            this.btnyazdir.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyazdir.Location = new System.Drawing.Point(38, 206);
            this.btnyazdir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnyazdir.Name = "btnyazdir";
            this.btnyazdir.Size = new System.Drawing.Size(266, 56);
            this.btnyazdir.TabIndex = 2;
            this.btnyazdir.Text = "YAZDIR";
            this.btnyazdir.UseVisualStyleBackColor = true;
            this.btnyazdir.Click += new System.EventHandler(this.btnyazdir_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(38, 302);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(266, 67);
            this.btnkaydet.TabIndex = 3;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "METİN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "BOYUT";
            // 
            // txtmetin
            // 
            this.txtmetin.Location = new System.Drawing.Point(142, 394);
            this.txtmetin.Name = "txtmetin";
            this.txtmetin.Size = new System.Drawing.Size(162, 33);
            this.txtmetin.TabIndex = 4;
            // 
            // txtboyut
            // 
            this.txtboyut.Location = new System.Drawing.Point(142, 449);
            this.txtboyut.Name = "txtboyut";
            this.txtboyut.Size = new System.Drawing.Size(162, 33);
            this.txtboyut.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(346, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 468);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnresimsec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtboyut);
            this.Controls.Add(this.txtmetin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyazdir);
            this.Controls.Add(this.btnresimsec);
            this.Controls.Add(this.btnrenksec);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrenksec;
        private System.Windows.Forms.Button btnresimsec;
        private System.Windows.Forms.Button btnyazdir;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmetin;
        private System.Windows.Forms.TextBox txtboyut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

