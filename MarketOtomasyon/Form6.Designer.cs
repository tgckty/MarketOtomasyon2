namespace MarketOtomasyon
{
    partial class Form6
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
            this.lstSatis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detaylarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.satışDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürüneGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSatis
            // 
            this.lstSatis.BackColor = System.Drawing.SystemColors.Info;
            this.lstSatis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader3});
            this.lstSatis.ContextMenuStrip = this.contextMenuStrip1;
            this.lstSatis.ForeColor = System.Drawing.Color.Black;
            this.lstSatis.FullRowSelect = true;
            this.lstSatis.GridLines = true;
            this.lstSatis.HoverSelection = true;
            this.lstSatis.Location = new System.Drawing.Point(0, 53);
            this.lstSatis.MultiSelect = false;
            this.lstSatis.Name = "lstSatis";
            this.lstSatis.Size = new System.Drawing.Size(452, 381);
            this.lstSatis.TabIndex = 14;
            this.lstSatis.UseCompatibleStateImageBehavior = false;
            this.lstSatis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Satış No";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Satış Tarihi";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Toplam Satış Tutarı";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ödeme Şekli";
            this.columnHeader3.Width = 101;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaylarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 26);
            // 
            // detaylarToolStripMenuItem
            // 
            this.detaylarToolStripMenuItem.Name = "detaylarToolStripMenuItem";
            this.detaylarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.detaylarToolStripMenuItem.Text = "Detaylar ";
            this.detaylarToolStripMenuItem.Click += new System.EventHandler(this.detaylarToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışDetayToolStripMenuItem,
            this.ürüneGöreToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // satışDetayToolStripMenuItem
            // 
            this.satışDetayToolStripMenuItem.Name = "satışDetayToolStripMenuItem";
            this.satışDetayToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.satışDetayToolStripMenuItem.Text = "Satış Detay";
            this.satışDetayToolStripMenuItem.Click += new System.EventHandler(this.satışDetayToolStripMenuItem_Click);
            // 
            // ürüneGöreToolStripMenuItem
            // 
            this.ürüneGöreToolStripMenuItem.Name = "ürüneGöreToolStripMenuItem";
            this.ürüneGöreToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ürüneGöreToolStripMenuItem.Text = "Ürüne Göre";
            this.ürüneGöreToolStripMenuItem.Click += new System.EventHandler(this.ürüneGöreToolStripMenuItem_Click);
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Location = new System.Drawing.Point(12, 27);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(172, 20);
            this.dtpTarih1.TabIndex = 16;
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(190, 27);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(170, 20);
            this.dtpTarih2.TabIndex = 17;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(366, 27);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 20);
            this.btnAra.TabIndex = 18;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(453, 433);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dtpTarih2);
            this.Controls.Add(this.dtpTarih1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lstSatis);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSatis;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detaylarToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem satışDetayToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ToolStripMenuItem ürüneGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
    }
}