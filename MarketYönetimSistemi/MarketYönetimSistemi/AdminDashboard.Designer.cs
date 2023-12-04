namespace MarketYönetimSistemi
{
    partial class AdminDashboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.UserListGdv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.StockGdv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.stockBtn = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.SellsGdv = new System.Windows.Forms.DataGridView();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.CategoriesGdv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.RaporBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListGdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserListGdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockGdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellsGdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGdv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product List";
            // 
            // ProductListGdv
            // 
            this.ProductListGdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListGdv.Location = new System.Drawing.Point(41, 59);
            this.ProductListGdv.Name = "ProductListGdv";
            this.ProductListGdv.Size = new System.Drawing.Size(358, 232);
            this.ProductListGdv.TabIndex = 1;
            this.ProductListGdv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductListGdv_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserListGdv
            // 
            this.UserListGdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListGdv.Location = new System.Drawing.Point(798, 59);
            this.UserListGdv.Name = "UserListGdv";
            this.UserListGdv.Size = new System.Drawing.Size(340, 232);
            this.UserListGdv.TabIndex = 3;
            this.UserListGdv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListGdv_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(795, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User List";
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(798, 315);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(107, 36);
            this.addCustomerBtn.TabIndex = 5;
            this.addCustomerBtn.Text = "Müşteri Ekle";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // StockGdv
            // 
            this.StockGdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockGdv.Location = new System.Drawing.Point(41, 432);
            this.StockGdv.Name = "StockGdv";
            this.StockGdv.Size = new System.Drawing.Size(246, 149);
            this.StockGdv.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // stockBtn
            // 
            this.stockBtn.Location = new System.Drawing.Point(41, 368);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(107, 36);
            this.stockBtn.TabIndex = 8;
            this.stockBtn.Text = "Stok";
            this.stockBtn.UseVisualStyleBackColor = true;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.Location = new System.Drawing.Point(310, 368);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(107, 36);
            this.sellBtn.TabIndex = 9;
            this.sellBtn.Text = "Satışlar";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // SellsGdv
            // 
            this.SellsGdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellsGdv.Location = new System.Drawing.Point(310, 432);
            this.SellsGdv.Name = "SellsGdv";
            this.SellsGdv.Size = new System.Drawing.Size(348, 149);
            this.SellsGdv.TabIndex = 10;
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Location = new System.Drawing.Point(436, 306);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(107, 36);
            this.addCategoryBtn.TabIndex = 11;
            this.addCategoryBtn.Text = "Kategori Ekle";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // CategoriesGdv
            // 
            this.CategoriesGdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesGdv.Location = new System.Drawing.Point(434, 59);
            this.CategoriesGdv.Name = "CategoriesGdv";
            this.CategoriesGdv.Size = new System.Drawing.Size(238, 232);
            this.CategoriesGdv.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Product Categories";
            // 
            // RaporBtn
            // 
            this.RaporBtn.Location = new System.Drawing.Point(798, 380);
            this.RaporBtn.Name = "RaporBtn";
            this.RaporBtn.Size = new System.Drawing.Size(107, 37);
            this.RaporBtn.TabIndex = 14;
            this.RaporBtn.Text = "Raporla";
            this.RaporBtn.UseVisualStyleBackColor = true;
            this.RaporBtn.Click += new System.EventHandler(this.RaporBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 643);
            this.Controls.Add(this.RaporBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CategoriesGdv);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.SellsGdv);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.stockBtn);
            this.Controls.Add(this.StockGdv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserListGdv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductListGdv);
            this.Controls.Add(this.label1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosed_Click);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductListGdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserListGdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockGdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellsGdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductListGdv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView UserListGdv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.DataGridView StockGdv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.DataGridView SellsGdv;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.DataGridView CategoriesGdv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RaporBtn;
    }
}