namespace MarketOtomasyon
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSepettenCikar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nToplam = new System.Windows.Forms.NumericUpDown();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.rbKart = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.nParaUstu = new System.Windows.Forms.NumericUpDown();
            this.nNakit = new System.Windows.Forms.NumericUpDown();
            this.lblNakit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nParaUstu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNakit)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(423, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 55);
            this.button1.TabIndex = 57;
            this.button1.Text = "Satışı Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Ara:";
            // 
            // btnSepettenCikar
            // 
            this.btnSepettenCikar.Location = new System.Drawing.Point(287, 112);
            this.btnSepettenCikar.Name = "btnSepettenCikar";
            this.btnSepettenCikar.Size = new System.Drawing.Size(120, 55);
            this.btnSepettenCikar.TabIndex = 54;
            this.btnSepettenCikar.Text = "Sepetten Çıkar";
            this.btnSepettenCikar.UseVisualStyleBackColor = true;
            this.btnSepettenCikar.Click += new System.EventHandler(this.btnSepettenCikar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Toplam:";
            // 
            // nToplam
            // 
            this.nToplam.DecimalPlaces = 3;
            this.nToplam.Enabled = false;
            this.nToplam.Location = new System.Drawing.Point(550, 259);
            this.nToplam.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nToplam.Name = "nToplam";
            this.nToplam.Size = new System.Drawing.Size(129, 20);
            this.nToplam.TabIndex = 48;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(287, 51);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(120, 55);
            this.btnSepeteEkle.TabIndex = 46;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(13, 25);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(263, 20);
            this.txtAra.TabIndex = 45;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(422, 51);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(257, 199);
            this.lstSepet.TabIndex = 44;
            this.lstSepet.SelectedIndexChanged += new System.EventHandler(this.lstSepet_SelectedIndexChanged);
            // 
            // lstUrun
            // 
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.Location = new System.Drawing.Point(13, 51);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(263, 368);
            this.lstUrun.TabIndex = 43;
            this.lstUrun.SelectedIndexChanged += new System.EventHandler(this.lstUrun_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(422, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(287, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(16, 32);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(50, 17);
            this.rbNakit.TabIndex = 61;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbKart
            // 
            this.rbKart.AutoSize = true;
            this.rbKart.Location = new System.Drawing.Point(16, 55);
            this.rbKart.Name = "rbKart";
            this.rbKart.Size = new System.Drawing.Size(73, 17);
            this.rbKart.TabIndex = 62;
            this.rbKart.TabStop = true;
            this.rbKart.Text = "Kredi Kartı";
            this.rbKart.UseVisualStyleBackColor = true;
            this.rbKart.CheckedChanged += new System.EventHandler(this.rbKart_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNakit);
            this.groupBox1.Controls.Add(this.rbKart);
            this.groupBox1.Location = new System.Drawing.Point(287, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Şekli";
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.Location = new System.Drawing.Point(487, 335);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(57, 13);
            this.lblParaUstu.TabIndex = 64;
            this.lblParaUstu.Text = "Para Üstü:";
            this.lblParaUstu.Click += new System.EventHandler(this.label2_Click);
            // 
            // nParaUstu
            // 
            this.nParaUstu.DecimalPlaces = 3;
            this.nParaUstu.Location = new System.Drawing.Point(550, 333);
            this.nParaUstu.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nParaUstu.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nParaUstu.Name = "nParaUstu";
            this.nParaUstu.Size = new System.Drawing.Size(129, 20);
            this.nParaUstu.TabIndex = 65;
            this.nParaUstu.ValueChanged += new System.EventHandler(this.nParaUstu_ValueChanged);
            // 
            // nNakit
            // 
            this.nNakit.DecimalPlaces = 3;
            this.nNakit.Location = new System.Drawing.Point(550, 296);
            this.nNakit.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nNakit.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nNakit.Name = "nNakit";
            this.nNakit.Size = new System.Drawing.Size(129, 20);
            this.nNakit.TabIndex = 66;
            this.nNakit.ValueChanged += new System.EventHandler(this.nNakit_ValueChanged);
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Location = new System.Drawing.Point(509, 298);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(35, 13);
            this.lblNakit.TabIndex = 67;
            this.lblNakit.Text = "Nakit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Barkod:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNakit);
            this.Controls.Add(this.nNakit);
            this.Controls.Add(this.nParaUstu);
            this.Controls.Add(this.lblParaUstu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSepettenCikar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nToplam);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.lstUrun);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nParaUstu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNakit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSepettenCikar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nToplam;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.RadioButton rbKart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.NumericUpDown nParaUstu;
        private System.Windows.Forms.NumericUpDown nNakit;
        private System.Windows.Forms.Label lblNakit;
        private System.Windows.Forms.Label label2;
    }
}