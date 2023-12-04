using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Controller;

namespace MarketYönetimSistemi
{



    public partial class CustomerDashboard : Form
    {
        ProductCrud productCrud = new ProductCrud();
        BuyProductCrud buyProductCrud = new BuyProductCrud();
        int selectedProductId = 0;
        Product product;
        List<Product> sepetUrunleri = new List<Product>();


        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            GetProductsToGdv();
            customerProductsGdv.Visible = false;
            shopPastGdv.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }
        public void GetProductsToGdv()
        {

            ProductListGdv.DataSource = productCrud.GetAll();
            ProductListGdv.Columns["Id"].Visible = false;
            ProductListGdv.Columns["Category"].Visible = false;
            ProductListGdv.Columns["CategoryId"].Visible = false;
            ProductListGdv.Columns["IsDelete"].Visible = false;
            ProductListGdv.Columns["IsStatus"].Visible = false;
            ProductListGdv.Columns["Stock"].Visible = false;
            ProductListGdv.Columns["Image"].Visible = false;
            // Sütun görüntülenme sıralarını belirle
            ProductListGdv.Columns["Name"].DisplayIndex = 0;
            ProductListGdv.Columns["Price"].DisplayIndex = 1;

            ProductListGdv.Columns["Description"].DisplayIndex = 2;
            // Diğer sütunların sırasını da belirleyebilirsiniz


        }

        public void GetProductsToSepetGdv()
        {
            SepetGdv.DataSource = null; // Mevcut veriyi temizle
            SepetGdv.DataSource = sepetUrunleri;
            SepetGdv.Columns["Id"].Visible = false;
            SepetGdv.Columns["Category"].Visible = false;
            SepetGdv.Columns["CategoryId"].Visible = false;
            SepetGdv.Columns["IsDelete"].Visible = false;
            SepetGdv.Columns["IsStatus"].Visible = false;
            SepetGdv.Columns["Stock"].Visible = false;
            SepetGdv.Columns["Image"].Visible = false;
            // Sütun görüntülenme sıralarını belirle
            SepetGdv.Columns["Name"].DisplayIndex = 0;
            SepetGdv.Columns["Price"].DisplayIndex = 1;

            SepetGdv.Columns["Description"].DisplayIndex = 2;
            // Diğer sütunların sırasını da belirleyebilirsiniz


        }
        private void ProductListGdv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProductId = Convert.ToInt32(ProductListGdv.CurrentRow.Cells["Id"].Value);



            product = productCrud.GetById(selectedProductId);

            if (product != null)
            {
                sepetUrunleri.Add(product);

                double sepetTotalPrice = sepetUrunleri.Select(x => x.Price).Sum();
                TotalPriceLbl.Text = sepetTotalPrice.ToString() + " Tl";

               
            }

            GetProductsToSepetGdv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyProduct buyProduct = new BuyProduct();
            var filteredSepet = sepetUrunleri.ToLookup(product => product.Id);
            bool durum = false;
            foreach (var item in filteredSepet)
            {


                BuyProduct newBp = new BuyProduct();
                newBp.ProductId = item.FirstOrDefault().Id;
                newBp.UserId = Form1.currentUserId;
                newBp.Quantity = item.Count();
                newBp.İsDelete = false;

                durum = buyProductCrud.Add(newBp);



            }



            if (durum == true)
            {
                OrderCrud orderCrud = new OrderCrud();
                MessageBox.Show("Siparişiniz alındı");
                Order order = new Order();
                order.OrderDateTine = DateTime.Now;
                order.UserId = Form1.currentUserId;
                order.İsDelete = false;

                bool stat = orderCrud.Add(order);
                if (stat)
                {
                    MessageBox.Show("Ürün siparişi verildi");
                    SellProductCrud sellProductCrud = new SellProductCrud();

                    bool statu = false;
                    foreach (var item in filteredSepet)
                    {


                        SellProduct sellProduct = new SellProduct();

                        sellProduct.ProductId = item.FirstOrDefault().Id;
                        sellProduct.OrderId = order.Id;
                        sellProduct.Quantity = item.Count();
                        sellProduct.IsDelete = false;
                        sellProduct.Price = item.FirstOrDefault().Price;
                        sellProduct.TotalPrice = item.FirstOrDefault().Price * item.Count();

                        Product product = new Product()
                        {
                            Stock = sellProduct.Quantity
                        };

                        bool durum1 = productCrud.Update(product, sellProduct.ProductId);
                        
                        statu = sellProductCrud.Add(sellProduct);

                    }

                    if (statu)
                    {
                        MessageBox.Show("Siparişiniz kargoya verildi");
                        TotalPriceLbl.Text = "0 Tl";
                        GetProductsToCustomerProductsGdv();
                        GetProductsToCustomerShopPastGdv();
                    }
                    else
                    {
                        MessageBox.Show("Siparişiniz maalesef iptal edildi");
                    }


                }
                else
                {
                    MessageBox.Show("Sipariş satıcıya ulaşmadı");
                }

            }
            else
            {
                MessageBox.Show("Siparişiniz oluşturulamadı");
            }



            SepetGdv.DataSource = null;
            sepetUrunleri.Clear();
            selectedProductId = 0;

        }

        private void SepetGdv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(SepetGdv.CurrentRow.Cells["Id"].Value);
            var removeProduct = productCrud.GetById(Id);
            sepetUrunleri.Remove(removeProduct);

            double sepetTotalPrice = sepetUrunleri.Select(x => x.Price).Sum();
            TotalPriceLbl.Text = sepetTotalPrice.ToString() + " Tl";
            GetProductsToSepetGdv();
        }

        private void CustomerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        public void GetProductsToCustomerProductsGdv()
        {
            var grouped = buyProductCrud.GetAll().Where(x => x.UserId == Form1.currentUserId).ToLookup(x => x.ProductId).ToList();
            customerProductsGdv.DataSource = null;

            if (grouped.Count > 0)
            {
                var productSummaries1 = new List<ProductSummary>();

                foreach (var productGroup in grouped)
                {
                    int productId = productGroup.Key; // Ürün adı
                    int totalQuantity = productGroup.Sum(x => x.Quantity); // Toplam miktar

                    var productSummary = new ProductSummary
                    {
                        productId = productId,
                        TotalQuantity = totalQuantity
                    };

                    productSummaries1.Add(productSummary);
                }



                var customerProducts = from buyProduct in productSummaries1
                                       join product in productCrud.GetAll()
                                       on buyProduct.productId equals product.Id
                                       select new
                                       {
                                           Name = product.Name,
                                           TotalQuantity = buyProduct.TotalQuantity,
                                       };




                customerProductsGdv.DataSource = customerProducts.ToList();
                customerProductsGdv.Visible = true;
            }






        }
        private void customerProductsBtn_Click(object sender, EventArgs e)
        {

            GetProductsToCustomerProductsGdv();
            label4.Visible = true;
        }

        private void shopPastBtn_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            shopPastGdv.Visible = true;
            GetProductsToCustomerShopPastGdv();
           


        }

        public void GetProductsToCustomerShopPastGdv()
        {
            shopPastGdv.DataSource = null;

            OrderCrud orderCrud = new OrderCrud();
            SellProductCrud sellProductCrud = new SellProductCrud();

            var products = buyProductCrud.GetAll().Where(x => x.UserId == Form1.currentUserId).ToList();



            var customerProducts = from order in orderCrud.GetAll()
                                   join sellPr in sellProductCrud.GetAll()
                                   on order.Id equals sellPr.OrderId
                                   where (order.UserId == Form1.currentUserId)
                                   select new
                                   {
                                       Name = productCrud.GetById(sellPr.ProductId).Name,
                                       Date = order.OrderDateTine,
                                   };


           

            shopPastGdv.DataSource = customerProducts.ToList();
            customerProductsGdv.Visible = true;

        }

        private void favoritesBtn_Click(object sender, EventArgs e)
        {
            SellProductCrud sellProduct = new SellProductCrud();

            var topSellingProducts = sellProduct.GetAll()
                .Where(x => x.IsDelete == false)
                .GroupBy(x => x.ProductId)
                .Select(group => new
                {
                    ProductId = group.Key,
                    TotalQuantitySold = group.Sum(x => x.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantitySold)
                .Take(5)
                .ToList();

            Form favoritesForm = new Form();
            favoritesForm.StartPosition = FormStartPosition.CenterScreen; 

            ListBox listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;

            foreach (var product in topSellingProducts)
            {
                string productName = GetProductNameById(product.ProductId); 
                listBox.Items.Add($"{productName} - {product.TotalQuantitySold} adet satıldı");
            }

            favoritesForm.Controls.Add(listBox);

            
            favoritesForm.ShowDialog();
        }

    
        private string GetProductNameById(int productId)
        {
            ProductCrud productCrud = new ProductCrud();
            var product = productCrud.GetById(productId);
            return product != null ? product.Name : "";
        }
    }
}