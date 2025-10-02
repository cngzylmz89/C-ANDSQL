namespace PERFORMANS
{
    partial class frmpuankayitlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpuankayitlari));
            this.raporBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pERFORMANSISTEMIDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pERFORMANSISTEMIDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERFORMANSISTEMIDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // raporBindingSource1
            // 
            this.raporBindingSource1.DataMember = "rapor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 467);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "RAPOR AL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.reportViewer3);
            this.groupBox1.Controls.Add(this.reportViewer2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(5, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1031, 490);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.Location = new System.Drawing.Point(4, 19);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1023, 467);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1004, 81);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.Location = new System.Drawing.Point(4, 19);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1023, 467);
            this.reportViewer3.TabIndex = 2;
            this.reportViewer3.Visible = false;
            // 
            // frmpuankayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmpuankayitlari";
            this.Text = "PUAN KAYITLARI";
            this.Load += new System.EventHandler(this.frmpuankayitlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
       // private PERFORMANSISTEMIDataSet5 pERFORMANSISTEMIDataSet5;
        private System.Windows.Forms.BindingSource pERFORMANSISTEMIDataSet1BindingSource;
       // private PERFORMANSISTEMIDataSet1 pERFORMANSISTEMIDataSet1;
        private System.Windows.Forms.BindingSource pERFORMANSISTEMIDataSet3BindingSource;
        //private PERFORMANSISTEMIDataSet3 pERFORMANSISTEMIDataSet3;
        private System.Windows.Forms.BindingSource raporBindingSource;
       // private PERFORMANSISTEMIDataSet3TableAdapters.raporTableAdapter raporTableAdapter;
       // private PERFORMANSISTEMIDataSet6 pERFORMANSISTEMIDataSet6;
        private System.Windows.Forms.BindingSource raporBindingSource1;
       // private PERFORMANSISTEMIDataSet2 pERFORMANSISTEMIDataSet2;
        private System.Windows.Forms.BindingSource pERFORMANSISTEMIDataSet2BindingSource;
       // private System.Windows.Forms.BindingSource raporBindingSource2;
        //private PERFORMANSISTEMIDataSet2TableAdapters.raporTableAdapter raporTableAdapter;
        //private System.Windows.Forms.BindingSource raporBindingSource3;
      //  private PERFORMANSISTEMIDataSet4 pERFORMANSISTEMIDataSet4;
        //private System.Windows.Forms.BindingSource raporBindingSource4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        // private PERFORMANSISTEMIDataSet4TableAdapters.raporTableAdapter raporTableAdapter1;
        // private PERFORMANSISTEMIDataSet6TableAdapters.raporTableAdapter raporTableAdapter1;
    }
}