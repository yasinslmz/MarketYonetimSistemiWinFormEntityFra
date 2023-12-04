namespace MarketYönetimSistemi
{
    partial class CustomerDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProductListGdv = new System.Windows.Forms.DataGridView();
            this.SepetGdv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.customerProductsBtn = new System.Windows.Forms.Button();
            this.customerProductsGdv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.shopPastBtn = new System.Windows.Forms.Button();
            this.shopPastGdv = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.favoritesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListGdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SepetGdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerProductsGdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopPastGdv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market";
            // 
            // ProductListGdv
            // 
            this.ProductListGdv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductListGdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListGdv.Location = new System.Drawing.Point(50, 55);
            this.ProductListGdv.Name = "ProductListGdv";
            this.ProductListGdv.Size = new System.Drawing.Size(344, 195);
            this.ProductListGdv.TabIndex = 1;
            this.ProductListGdv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductListGdv_CellDoubleClick);
            // 
            // SepetGdv
            // 
            this.SepetGdv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SepetGdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SepetGdv.Location = new System.Drawing.Point(649, 55);
            this.SepetGdv.Name = "SepetGdv";
            this.SepetGdv.Size = new System.Drawing.Size(344, 195);
            this.SepetGdv.TabIndex = 3;
            this.SepetGdv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SepetGdv_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sepet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(898, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sepet Toplamı:";
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Location = new System.Drawing.Point(972, 272);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(13, 13);
            this.TotalPriceLbl.TabIndex = 5;
            this.TotalPriceLbl.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sipariş Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerProductsBtn
            // 
            this.customerProductsBtn.Location = new System.Drawing.Point(59, 317);
            this.customerProductsBtn.Name = "customerProductsBtn";
            this.customerProductsBtn.Size = new System.Drawing.Size(133, 41);
            this.customerProductsBtn.TabIndex = 7;
            this.customerProductsBtn.Text = "Ürünlerim";
            this.customerProductsBtn.UseVisualStyleBackColor = true;
            this.customerProductsBtn.Click += new System.EventHandler(this.customerProductsBtn_Click);
            // 
            // customerProductsGdv
            // 
            this.customerProductsGdv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.customerProductsGdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerProductsGdv.Location = new System.Drawing.Point(59, 382);
            this.customerProductsGdv.Name = "customerProductsGdv";
            this.customerProductsGdv.Size = new System.Drawing.Size(239, 168);
            this.customerProductsGdv.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürünlerim";
            // 
            // shopPastBtn
            // 
            this.shopPastBtn.Location = new System.Drawing.Point(331, 317);
            this.shopPastBtn.Name = "shopPastBtn";
            this.shopPastBtn.Size = new System.Drawing.Size(133, 41);
            this.shopPastBtn.TabIndex = 10;
            this.shopPastBtn.Text = "Alışveriş Geçmişi";
            this.shopPastBtn.UseVisualStyleBackColor = true;
            this.shopPastBtn.Click += new System.EventHandler(this.shopPastBtn_Click);
            // 
            // shopPastGdv
            // 
            this.shopPastGdv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.shopPastGdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopPastGdv.Location = new System.Drawing.Point(331, 382);
            this.shopPastGdv.Name = "shopPastGdv";
            this.shopPastGdv.Size = new System.Drawing.Size(256, 168);
            this.shopPastGdv.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Alışveriş Geçmişim";
            // 
            // favoritesBtn
            // 
            this.favoritesBtn.Location = new System.Drawing.Point(649, 317);
            this.favoritesBtn.Name = "favoritesBtn";
            this.favoritesBtn.Size = new System.Drawing.Size(133, 41);
            this.favoritesBtn.TabIndex = 13;
            this.favoritesBtn.Text = "En Çok Satılan Ürünler";
            this.favoritesBtn.UseVisualStyleBackColor = true;
            this.favoritesBtn.Click += new System.EventHandler(this.favoritesBtn_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1031, 631);
            this.Controls.Add(this.favoritesBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.shopPastGdv);
            this.Controls.Add(this.shopPastBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerProductsGdv);
            this.Controls.Add(this.customerProductsBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalPriceLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SepetGdv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductListGdv);
            this.Controls.Add(this.label1);
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerDashboard_FormClosed);
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductListGdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SepetGdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerProductsGdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopPastGdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductListGdv;
        private System.Windows.Forms.DataGridView SepetGdv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button customerProductsBtn;
        private System.Windows.Forms.DataGridView customerProductsGdv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button shopPastBtn;
        private System.Windows.Forms.DataGridView shopPastGdv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button favoritesBtn;
    }
}