namespace MarketOtomasyon
{
    partial class UrunDetay
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
            this.lstDetay = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDetay1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDetay2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstDetay
            // 
            this.lstDetay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lstDetay.GridLines = true;
            this.lstDetay.Location = new System.Drawing.Point(-1, 0);
            this.lstDetay.Name = "lstDetay";
            this.lstDetay.Size = new System.Drawing.Size(287, 394);
            this.lstDetay.TabIndex = 2;
            this.lstDetay.UseCompatibleStateImageBehavior = false;
            this.lstDetay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "  Ürün Id    Ürün Adı    Fiyat";
            this.columnHeader2.Width = 277;
            // 
            // lstDetay1
            // 
            this.lstDetay1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lstDetay1.GridLines = true;
            this.lstDetay1.Location = new System.Drawing.Point(397, 0);
            this.lstDetay1.Name = "lstDetay1";
            this.lstDetay1.Size = new System.Drawing.Size(59, 394);
            this.lstDetay1.TabIndex = 3;
            this.lstDetay1.UseCompatibleStateImageBehavior = false;
            this.lstDetay1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "  ";
            this.columnHeader3.Width = 72;
            // 
            // lstDetay2
            // 
            this.lstDetay2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lstDetay2.GridLines = true;
            this.lstDetay2.Location = new System.Drawing.Point(286, 0);
            this.lstDetay2.Name = "lstDetay2";
            this.lstDetay2.Size = new System.Drawing.Size(114, 394);
            this.lstDetay2.TabIndex = 4;
            this.lstDetay2.UseCompatibleStateImageBehavior = false;
            this.lstDetay2.View = System.Windows.Forms.View.Details;
            this.lstDetay2.SelectedIndexChanged += new System.EventHandler(this.lstDetay2_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "  Toplam Satış ";
            this.columnHeader6.Width = 110;
            // 
            // UrunDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 395);
            this.Controls.Add(this.lstDetay2);
            this.Controls.Add(this.lstDetay1);
            this.Controls.Add(this.lstDetay);
            this.Name = "UrunDetay";
            this.Text = "UrunDetay";
            this.Load += new System.EventHandler(this.UrunDetay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstDetay;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lstDetay1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstDetay2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}