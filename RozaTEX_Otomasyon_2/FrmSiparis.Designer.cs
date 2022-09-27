namespace RozaTEX_Otomasyon_2
{
    partial class FrmSiparis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAylar = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAySecimi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAylar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lblAySecimi);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1368, 467);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aylık Sipariş Sorgu";
            // 
            // comboBoxAylar
            // 
            this.comboBoxAylar.FormattingEnabled = true;
            this.comboBoxAylar.Location = new System.Drawing.Point(102, 49);
            this.comboBoxAylar.Name = "comboBoxAylar";
            this.comboBoxAylar.Size = new System.Drawing.Size(121, 37);
            this.comboBoxAylar.TabIndex = 3;
            this.comboBoxAylar.SelectedIndexChanged += new System.EventHandler(this.comboBoxAylar_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1355, 367);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblAySecimi
            // 
            this.lblAySecimi.AutoSize = true;
            this.lblAySecimi.Location = new System.Drawing.Point(6, 50);
            this.lblAySecimi.Name = "lblAySecimi";
            this.lblAySecimi.Size = new System.Drawing.Size(97, 29);
            this.lblAySecimi.TabIndex = 0;
            this.lblAySecimi.Text = "Ay seçiniz:";
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 487);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSiparis";
            this.Text = "Sipariş Sorgulama Ekranı";
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAySecimi;
        private System.Windows.Forms.ComboBox comboBoxAylar;
    }
}