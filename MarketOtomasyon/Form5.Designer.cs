namespace MarketOtomasyon
{
    partial class Form5
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
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.nAdet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbFoto.Location = new System.Drawing.Point(390, 14);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(192, 156);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 80;
            this.pbFoto.TabStop = false;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 15);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(233, 20);
            this.txtAra.TabIndex = 68;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstUrun
            // 
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.Location = new System.Drawing.Point(12, 41);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(233, 368);
            this.lstUrun.TabIndex = 69;
            this.lstUrun.SelectedIndexChanged += new System.EventHandler(this.lstUrun_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(390, 352);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(192, 56);
            this.btnKaydet.TabIndex = 70;
            this.btnKaydet.Text = "Stoğa Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(390, 176);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(192, 173);
            this.lstSepet.TabIndex = 81;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(254, 58);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 56);
            this.btnEkle.TabIndex = 82;
            this.btnEkle.Text = "Sepete Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(254, 120);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(107, 56);
            this.btnCikar.TabIndex = 83;
            this.btnCikar.Text = "Sepetten Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(251, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Toplam:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(322, 319);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(16, 16);
            this.lblToplam.TabIndex = 85;
            this.lblToplam.Text = "0";
            // 
            // nAdet
            // 
            this.nAdet.Location = new System.Drawing.Point(277, 200);
            this.nAdet.Name = "nAdet";
            this.nAdet.Size = new System.Drawing.Size(84, 20);
            this.nAdet.TabIndex = 86;
            this.nAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 430);
            this.Controls.Add(this.nAdet);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.NumericUpDown nAdet;
    }
}