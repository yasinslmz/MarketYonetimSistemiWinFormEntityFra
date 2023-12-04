using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity.Interface;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;

namespace MarketYönetimSistemi
{
    public partial class AdminDashboard : Form
    {
        UserCrud userCrud=new UserCrud();
        ProductCrud productCrud = new ProductCrud();
        CategoryCrud categoryCrud = new CategoryCrud();
        Form form;
        Product product;
        User user;


        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            StockGdv.Visible = false;
            SellsGdv.Visible = false;
            GetProductsToGdv();
            GetUsersToGdv();
            GetCategoriesToCategoriesGdv();
        }


        public void GetProductsToGdv()
        {
           
            ProductListGdv.DataSource=productCrud.GetAll();
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


        public void GetUsersToGdv()
        {

            UserListGdv.DataSource = userCrud.GetAll();
            UserListGdv.Columns["Id"].Visible = false;
            UserListGdv.Columns["Password"].Visible = false;
            UserListGdv.Columns["RoleId"].Visible = false;
            UserListGdv.Columns["IsDelete"].Visible = false;
            UserListGdv.Columns["IsStatus"].Visible = false;
            UserListGdv.Columns["Description"].Visible = false;
            UserListGdv.Columns["Role"].Visible = false;
            UserListGdv.Columns["Image"].Visible = false;
            // Sütun görüntülenme sıralarını belirle
            UserListGdv.Columns["Name"].DisplayIndex = 0;
            UserListGdv.Columns["Surname"].DisplayIndex = 1;
            UserListGdv.Columns["Email"].DisplayIndex = 2;
            
            // Diğer sütunların sırasını da belirleyebilirsiniz


        }

        private void ProductListGdv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(ProductListGdv.CurrentRow.Cells["Id"].Value);
          

            

            product = productCrud.GetById(id);

            form= new Form();
            form.Text = "Product Details";
            form.StartPosition = FormStartPosition.CenterScreen; // Formu ekranın ortasında başlat
            form.Width = 380;

            int verticalSpacing = 10; // Dikeyde elemanlar arasındaki boşluk

            Label label1 = new Label();
            label1.Text = "Label 1";
            label1.AutoSize = true; // Otomatik boyutlandırma açık
            label1.Left = ((form.ClientSize.Width) / 2) - 18; // Formun ortasına hizala
            label1.Top = verticalSpacing;

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.ImageLocation = product.Image;
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.Left = (form.ClientSize.Width - pictureBox1.Width +30) / 2; // Formun ortasına hizala
            pictureBox1.Top = label1.Bottom + verticalSpacing; // Label'dan belirli bir boşluk bırakarak altına yerleştir
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            Label label2 = new Label();
            label2.Text = "Ürün adı: " + product.Name;
            label2.AutoSize = true; // Otomatik boyutlandırma açık
            label2.Left = ((form.ClientSize.Width) / 2) - 35; // Formun ortasına hizala
            label2.Top = pictureBox1.Bottom + verticalSpacing;

            Label label3 = new Label();
            label3.Text = "Ürün fiyat: " + product.Price;
            label3.AutoSize = true; // Otomatik boyutlandırma açık
            label3.Left = ((form.ClientSize.Width) / 2) - 35; // Formun ortasına hizala
            label3.Top = label2.Bottom + verticalSpacing;

            Label label4 = new Label();
            label4.Text = "Ürün stok: " + product.Stock;
            label4.AutoSize = true; // Otomatik boyutlandırma açık
            label4.Left = ((form.ClientSize.Width) / 2) - 35; // Formun ortasına hizala
            label4.Top = label3.Bottom + verticalSpacing;

            CategoryCrud categoryCrud = new CategoryCrud();
            var productCategory1=categoryCrud.GetById(product.CategoryId);
            

            Label label5 = new Label();
            label5.Text = "Ürün kategorisi: " + productCategory1.Name;
            label5.AutoSize = true; // Otomatik boyutlandırma açık
            label5.Left = ((form.ClientSize.Width) / 2) - 35; // Formun ortasına hizala
            label5.Top = label4.Bottom + verticalSpacing;

            Label label6 = new Label();
            label6.Text = "Ürün açıklaması: \n" + product.Description;
            label6.AutoSize = true; // Otomatik boyutlandırma açık
            label6.Left = ((form.ClientSize.Width) / 2) - 35; // Formun ortasına hizala
            label6.Top = label5.Bottom + verticalSpacing;

            Button edit = new Button();
            Button delete = new Button();

            edit.Text = "Edit";
            delete.Text = "Delete";
            edit.Left = (form.ClientSize.Width - edit.Width - delete.Width - 10) / 2; // Formun ortasına hizala
            edit.Top = label6.Bottom + verticalSpacing; // PictureBox'tan belirli bir boşluk bırakarak altına yerleştir
            delete.Left = edit.Right + 10; // Edit button'ının sağında 10 birim aralık bırak
            delete.Top = edit.Top; // Edit button'ının yüksekliği ile aynı yükseklikte yerleştir

            // Edit ve Delete butonlarına click olayları ekleyin
            edit.Click += edit_Click;
            delete.Click += delete_Click;

            // Elemanların yerleşimini güncelleyerek formun yüksekliğini ayarla
            label1.Top = verticalSpacing;
            pictureBox1.Top = label1.Bottom + verticalSpacing;
            label2.Top = pictureBox1.Bottom + verticalSpacing;
            label3.Top = label2.Bottom + verticalSpacing;
            label4.Top = label3.Bottom + verticalSpacing;
            label5.Top = label4.Bottom + verticalSpacing;
            label6.Top = label5.Bottom + verticalSpacing;
            edit.Top = label6.Bottom + verticalSpacing;
            delete.Top = edit.Top;

            // Formun yüksekliğini ayarla
            form.Height = delete.Bottom + verticalSpacing + 50;

            form.Controls.Add(label1);
            form.Controls.Add(pictureBox1);
            form.Controls.Add(label2);
            form.Controls.Add(label3);
            form.Controls.Add(label4);
            form.Controls.Add(label5);
            form.Controls.Add(label6);
            form.Controls.Add(edit);
            form.Controls.Add(delete);

            form.ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {

            
            // Yeni bir form oluştur
            Form editForm = new Form();
            editForm.Text = "Edit Product";
            editForm.StartPosition = FormStartPosition.CenterScreen;

            int verticalSpacing = 10;

            // Ürün adı
            Label nameLabel = new Label();
            nameLabel.Text = "Ürün Adı:";
            nameLabel.AutoSize = true;
            nameLabel.Left = 10;
            nameLabel.Top = verticalSpacing;

            TextBox nameTextBox = new TextBox();
            nameTextBox.Text = "";
            nameTextBox.Left = nameLabel.Right + 10;
            nameTextBox.Top = verticalSpacing;

            // Ürün fiyatı
            Label priceLabel = new Label();
            priceLabel.Text = "Ürün Fiyatı:";
            priceLabel.AutoSize = true;
            priceLabel.Left = 10;
            priceLabel.Top = nameTextBox.Bottom + verticalSpacing;

            NumericUpDown priceNumericUpDown = new NumericUpDown();
            priceNumericUpDown.Text = "";
            priceNumericUpDown.Left = priceLabel.Right + 10;
            priceNumericUpDown.Top = nameTextBox.Bottom + verticalSpacing;

            // Ürün stok
            Label stockLabel = new Label();
            stockLabel.Text = "Ürün Stok:";
            stockLabel.AutoSize = true;
            stockLabel.Left = 10;
            stockLabel.Top = priceNumericUpDown.Bottom + verticalSpacing;

            NumericUpDown stockNumericUpDown = new NumericUpDown();
            stockNumericUpDown.Text = "";
            stockNumericUpDown.Left = stockLabel.Right + 10;
            stockNumericUpDown.Top = priceNumericUpDown.Bottom + verticalSpacing;

            
            // Ürün açıklaması
            Label descriptionLabel = new Label();
            descriptionLabel.Text = "Ürün Açıklaması:";
            descriptionLabel.AutoSize = true;
            descriptionLabel.Left = 10;
            descriptionLabel.Top = stockNumericUpDown.Bottom + verticalSpacing;

            TextBox descriptionTextBox = new TextBox();
            descriptionTextBox.Text = "";
            descriptionTextBox.Left = descriptionLabel.Right + 10;
            descriptionTextBox.Top = stockNumericUpDown.Bottom + verticalSpacing;

            // Kaydet butonu
            Button saveButton = new Button();
            saveButton.Text = "Kaydet";
            saveButton.Left = 10;
            saveButton.Top = descriptionTextBox.Bottom + verticalSpacing;

            


            saveButton.Click += (s, eventArgs) =>
            {
                DialogResult result=MessageBox.Show("Emin misiniz?","Ürün Düzenleme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    // Burada güncelleme işlemlerini yapabilirsiniz
                    //product.Name = nameTextBox.Text;
                    // Diğer özellikleri de güncelleyin

                    Product updateProduct = new Product()
                    {
                        Name = nameTextBox.Text,
                        Description = descriptionTextBox.Text,
                        Price = Convert.ToDouble(priceNumericUpDown.Value),
                        Stock = Convert.ToInt32(stockNumericUpDown.Value),

                    };

                    bool durum = productCrud.Update(updateProduct, product.Id);
                    MessageBox.Show(durum == true ? "Ürün düzenlendi" : "Ürün düzenlenemedi.");
                    editForm.Close();
                    GetProductsToGdv();

                }
                else
                {

                }

            };

            editForm.Controls.Add(nameLabel);
            editForm.Controls.Add(nameTextBox);
            editForm.Controls.Add(priceLabel);
            editForm.Controls.Add(priceNumericUpDown);
            editForm.Controls.Add(stockLabel);
            editForm.Controls.Add(stockNumericUpDown);
            
            editForm.Controls.Add(descriptionLabel);
            editForm.Controls.Add(descriptionTextBox);
            editForm.Controls.Add(saveButton);

            editForm.ShowDialog();


        }

        private void delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete button clicked!");
            bool durum=productCrud.Delete(product.Id);
            if (durum == true)
            {
                MessageBox.Show("Ürün başarıyla silindi");
            }
            else
            {
                MessageBox.Show("Ürün silinemedi");
            }

            
        }

        private void FormClosed_Click(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Product newProduct=new Product();
           
            // Yeni bir form oluştur
            Form addProductForm = new Form();
            addProductForm.Text = "Ürün Ekle";
            addProductForm.StartPosition = FormStartPosition.CenterScreen;

            int verticalSpacing = 10;

            // Ürün adı
            Label nameLabel = new Label();
            nameLabel.Text = "Ürün Adı:";
            nameLabel.AutoSize = true;
            nameLabel.Left = 10;
            nameLabel.Top = verticalSpacing;

            TextBox nameTextBox = new TextBox();
            nameTextBox.Text = "";
            nameTextBox.Left = nameLabel.Right + 10;
            nameTextBox.Top = verticalSpacing;

            // Ürün fiyatı
            Label priceLabel = new Label();
            priceLabel.Text = "Ürün Fiyatı:";
            priceLabel.AutoSize = true;
            priceLabel.Left = 10;
            priceLabel.Top = nameTextBox.Bottom + verticalSpacing;

            NumericUpDown priceNumericUpDown = new NumericUpDown();
            priceNumericUpDown.Text = "";
            priceNumericUpDown.Left = priceLabel.Right + 10;
            priceNumericUpDown.Top = nameTextBox.Bottom + verticalSpacing;

            // Ürün stok
            Label stockLabel = new Label();
            stockLabel.Text = "Ürün Stok:";
            stockLabel.AutoSize = true;
            stockLabel.Left = 10;
            stockLabel.Top = priceNumericUpDown.Bottom + verticalSpacing;

            NumericUpDown stockNumericUpDown = new NumericUpDown();
            stockNumericUpDown.Text = "";
            stockNumericUpDown.Left = stockLabel.Right + 10;
            stockNumericUpDown.Top = priceNumericUpDown.Bottom + verticalSpacing;

            // Ürün kategorisi
            Label categoryLabel = new Label();
            categoryLabel.Text = "Ürün Kategorisi:";
            categoryLabel.AutoSize = true;
            categoryLabel.Left = 10;
            categoryLabel.Top = stockNumericUpDown.Bottom + verticalSpacing;

            ComboBox categoryComboBox = new ComboBox();
            

            categoryComboBox.Left = categoryLabel.Right + 10;
            categoryComboBox.Top = stockNumericUpDown.Bottom + verticalSpacing;
            GetRoleListToCb(categoryComboBox);

            // Ürün açıklaması
            Label descriptionLabel = new Label();
            descriptionLabel.Text = "Ürün Açıklaması:";
            descriptionLabel.AutoSize = true;
            descriptionLabel.Left = 10;
            descriptionLabel.Top = categoryComboBox.Bottom + verticalSpacing;

            TextBox descriptionTextBox = new TextBox();
            descriptionTextBox.Text = "";
            descriptionTextBox.Left = descriptionLabel.Right + 10;
            descriptionTextBox.Top = categoryComboBox.Bottom + verticalSpacing;

            
            Label imageLabel = new Label();
            imageLabel.Text = "Resim: ";
            imageLabel.AutoSize = true;
            imageLabel.Left = 10;
            imageLabel.Top = descriptionTextBox.Bottom + verticalSpacing;

            Button imageButton = new Button();
            imageButton.Text = "Seç";
            imageButton.Left = imageLabel.Right +10;
            imageButton.Top = descriptionTextBox.Bottom + verticalSpacing;

            // Kaydet butonu
            Button addButton = new Button();
            addButton.Text = "Ekle";
            addButton.Left = 10;
            addButton.Top = imageButton.Bottom + verticalSpacing;



            imageButton.Click += (s, EventArgs) =>
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                     newProduct.Image=ofd.FileName;

                }
               

            };


            addButton.Click += (s, eventArgs) =>
            {
                DialogResult result = MessageBox.Show("Emin misiniz?", "Ürün Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    newProduct.Name=nameTextBox.Text;
                    newProduct.Description=descriptionTextBox.Text;
                    newProduct.Price = Convert.ToDouble(priceNumericUpDown.Value);
                    newProduct.Stock = Convert.ToInt32(stockNumericUpDown.Value);
                    newProduct.IsStatus = true;
                    newProduct.IsDelete = false;
                    newProduct.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);//

                    bool durum = productCrud.Add(newProduct);
                    MessageBox.Show(durum == true ? "Ürün eklendi" : "Ürün eklenemedi.");
                    addProductForm.Close();
                    GetProductsToGdv();

                }
                else
                {

                }

            };

            addProductForm.Controls.Add(nameLabel);
            addProductForm.Controls.Add(nameTextBox);
            addProductForm.Controls.Add(priceLabel);
            addProductForm.Controls.Add(priceNumericUpDown);
            addProductForm.Controls.Add(stockLabel);
            addProductForm.Controls.Add(stockNumericUpDown);
            addProductForm.Controls.Add(categoryLabel);
            addProductForm.Controls.Add(categoryComboBox);
            addProductForm.Controls.Add(descriptionLabel);
            addProductForm.Controls.Add(descriptionTextBox);
            addProductForm.Controls.Add(imageLabel);
            addProductForm.Controls.Add(imageButton);
            addProductForm.Controls.Add(addButton);

            addProductForm.ShowDialog();


        }


        public void UploadPictureBoxImage(PictureBox picture)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = ofd.FileName;
            }
        }
        public void GetRoleListToCb(ComboBox CategoriesCb)
        {
            CategoriesCb.DataSource = categoryCrud.GetAll();
            CategoriesCb.DisplayMember = "Name";
            CategoriesCb.ValueMember = "Id";
        }

        private void UserListGdv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(UserListGdv.CurrentRow.Cells["Id"].Value);


            user = userCrud.GetById(id);

            form = new Form();
            form.Text = "User Details";
            form.StartPosition = FormStartPosition.CenterScreen; // Formu ekranın ortasında başlat
            form.Width = 380;

            int verticalSpacing = 10; // Dikeyde elemanlar arasındaki boşluk

          

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.ImageLocation = user.Image;
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.Left = (form.ClientSize.Width / 2)-70; // Formun ortasına hizala
            pictureBox1.Top = label1.Bottom + verticalSpacing; // Label'dan belirli bir boşluk bırakarak altına yerleştir
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            Label label2 = new Label();
            label2.Text = "Müşteri adı: " + user.Name+" "+user.Surname;
            label2.AutoSize = true; // Otomatik boyutlandırma açık
            label2.Left = (form.ClientSize.Width) / 2-70; // Formun ortasına hizala
            label2.Top = pictureBox1.Bottom + verticalSpacing;

            Label label3 = new Label();
            label3.Text = "Müşteri Email: " + user.Email;
            label3.AutoSize = true; // Otomatik boyutlandırma açık
            label3.Left = (form.ClientSize.Width) / 2 - 70; // Formun ortasına hizala
            label3.Top = label2.Bottom + verticalSpacing;

            Label label4 = new Label();
            label4.Text = "User Des: " + user.Description;
            label4.AutoSize = true; // Otomatik boyutlandırma açık
            label4.Left = (form.ClientSize.Width) / 2 - 70; // Formun ortasına hizala
            label4.Top = label3.Bottom + verticalSpacing;

            Label label5 = new Label();
            label5.Text = "User Status: " + (user.IsStatus?"Aktif":"Pasif");
            label5.AutoSize = true; // Otomatik boyutlandırma açık
            label5.Left = (form.ClientSize.Width) / 2 - 70; // Formun ortasına hizala
            label5.Top = label4.Bottom + verticalSpacing;


            Button edit = new Button();
            Button delete = new Button();

            edit.Text = "Edit";
            delete.Text = "Delete";
            edit.Left = (form.ClientSize.Width - edit.Width - delete.Width - 10) / 2; // Formun ortasına hizala
            edit.Top = label5.Bottom + verticalSpacing; // PictureBox'tan belirli bir boşluk bırakarak altına yerleştir
            delete.Left = edit.Right + 10; // Edit button'ının sağında 10 birim aralık bırak
            delete.Top = edit.Top; // Edit button'ının yüksekliği ile aynı yükseklikte yerleştir

            // Edit ve Delete butonlarına click olayları ekleyin
            edit.Click += (s, EventArgs) =>
            {

               

                // Yeni bir form oluştur
                Form editForm = new Form();
                editForm.Text = "Edit User";
                editForm.StartPosition = FormStartPosition.CenterScreen;

                

                
                Label nameLabel = new Label();
                nameLabel.Text = "Müşteri Adı:";
                nameLabel.AutoSize = true;
                nameLabel.Left = 10;
                nameLabel.Top = verticalSpacing;

                TextBox nameTextBox = new TextBox();
                nameTextBox.Text = "";
                nameTextBox.Left = nameLabel.Right + 10;
                nameTextBox.Top = verticalSpacing;

                Label surnameLabel = new Label();
                surnameLabel.Text = "Müşteri Soyadı:";
                surnameLabel.AutoSize = true;
                surnameLabel.Left = 10;
                surnameLabel.Top = nameTextBox.Bottom + verticalSpacing;

                TextBox surnameTextBox = new TextBox();
                surnameTextBox.Text = "";
                surnameTextBox.Left = surnameLabel.Right + 10;
                surnameTextBox.Top = nameTextBox.Bottom + verticalSpacing;


                Label emailLabel = new Label();
                emailLabel.Text = "Müşteri Email:";
                emailLabel.AutoSize = true;
                emailLabel.Left = 10;
                emailLabel.Top = surnameTextBox.Bottom + verticalSpacing;

                TextBox emailTextBox = new TextBox();
                emailTextBox.Text = "";
                emailTextBox.Left = emailLabel.Right + 10;
                emailTextBox.Top = surnameTextBox.Bottom + verticalSpacing;

              
                Label passwordLabel = new Label();
                passwordLabel.Text = "Müşteri Şifre:";
                passwordLabel.AutoSize = true;
                passwordLabel.Left = 10;
                passwordLabel.Top = emailTextBox.Bottom + verticalSpacing;

                TextBox passwordTextBox = new TextBox();
                passwordTextBox.Text = "";
                passwordTextBox.Left = passwordLabel.Right + 10;
                passwordTextBox.Top = emailTextBox.Bottom + verticalSpacing;

                Label statusLabel = new Label();
                passwordLabel.Text = "Müşteri Durumu:";
                passwordLabel.AutoSize = true;
                passwordLabel.Left = 10;
                passwordLabel.Top = passwordTextBox.Bottom + verticalSpacing;

                ComboBox statusCb = new ComboBox();
                statusCb.Left = statusLabel.Right + 10;
                statusCb.Top = passwordTextBox.Bottom + verticalSpacing+10;
                statusCb.Items.Add(true);
                statusCb.Items.Add(false);
                statusCb.SelectedItem = true;

                // Kaydet butonu
                Button saveButton = new Button();
                saveButton.Text = "Kaydet";
                saveButton.Left = 10;
                saveButton.Top = statusCb.Bottom + verticalSpacing;




                saveButton.Click += (se, eventArgs) =>
                {
                    DialogResult result = MessageBox.Show("Emin misiniz?", "Ürün Düzenleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        User updateUser = new User()
                        {
                            Name = nameTextBox.Text,
                            Surname = surnameTextBox.Text,
                            Email = emailTextBox.Text,
                            Password = passwordTextBox.Text,


                        };
                        bool st =Convert.ToBoolean( statusCb.SelectedItem);

                        if (st==true)
                        {
                            updateUser.IsStatus = true;
                           
                        }
                        else
                        {
                            
                            updateUser.IsStatus= false;
                        }
                       

                        bool durum = userCrud.Update(updateUser, user.Id);
                        MessageBox.Show(durum == true ? "Müşteri düzenlendi" : "Müşteri düzenlenemedi.");
                        editForm.Close();
                        GetUsersToGdv();

                       

                    }
                    else
                    {

                    }

                };

                editForm.Controls.Add(nameLabel);
                editForm.Controls.Add(nameTextBox);
                editForm.Controls.Add(surnameLabel);
                editForm.Controls.Add(surnameTextBox);
                editForm.Controls.Add(emailLabel);
                editForm.Controls.Add(emailTextBox);
                editForm.Controls.Add(passwordLabel);
                editForm.Controls.Add(passwordTextBox);
                editForm.Controls.Add(statusLabel);
                editForm.Controls.Add(statusCb);
                editForm.Controls.Add(saveButton);

                editForm.ShowDialog();


            };





            delete.Click += (send, eve) =>
            {

                MessageBox.Show("Delete button clicked!");
                bool durum = userCrud.Delete(user.Id);
                if (durum == true)
                {
                    MessageBox.Show("Kullanıcı başarıyla silindi");
                }
                else
                {
                    MessageBox.Show("Kullanıcı silinemedi");
                }


            };

            // Elemanların yerleşimini güncelleyerek formun yüksekliğini ayarla
            label1.Top = verticalSpacing;
            pictureBox1.Top = label1.Bottom + verticalSpacing;
            label2.Top = pictureBox1.Bottom + verticalSpacing;
            label3.Top = label2.Bottom + verticalSpacing;
            label4.Top = label3.Bottom + verticalSpacing;
            label5.Top = label4.Bottom + verticalSpacing;
            edit.Top = label5.Bottom + verticalSpacing;
            delete.Top = edit.Top;

            // Formun yüksekliğini ayarla
            form.Height = delete.Bottom + verticalSpacing + 50;

           
            form.Controls.Add(pictureBox1);
            form.Controls.Add(label2);
            form.Controls.Add(label3);
            form.Controls.Add(label4);
            form.Controls.Add(label5);
            form.Controls.Add(edit);
            form.Controls.Add(delete);

            form.ShowDialog();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            // Yeni bir form oluştur
            Form addUserForm = new Form();
            addUserForm.Text = "Müşteri Ekle";
            addUserForm.StartPosition = FormStartPosition.CenterScreen;

            int verticalSpacing = 10;

            Label nameLabel = new Label();
            nameLabel.Text = "Müşteri Adı:";
            nameLabel.AutoSize = true;
            nameLabel.Left = 10;
            nameLabel.Top = verticalSpacing;

            TextBox nameTextBox = new TextBox();
            nameTextBox.Text = "";
            nameTextBox.Left = nameLabel.Right + 10;
            nameTextBox.Top = verticalSpacing;

            Label surnameLabel = new Label();
            surnameLabel.Text = "Müşteri Soyadı:";
            surnameLabel.AutoSize = true;
            surnameLabel.Left = 10;
            surnameLabel.Top = nameTextBox.Bottom + verticalSpacing;

            TextBox surnameTextBox = new TextBox();
            surnameTextBox.Text = "";
            surnameTextBox.Left = surnameLabel.Right + 10;
            surnameTextBox.Top = nameTextBox.Bottom + verticalSpacing;


            Label emailLabel = new Label();
            emailLabel.Text = "Müşteri Email:";
            emailLabel.AutoSize = true;
            emailLabel.Left = 10;
            emailLabel.Top = surnameTextBox.Bottom + verticalSpacing;

            TextBox emailTextBox = new TextBox();
            emailTextBox.Text = "";
            emailTextBox.Left = emailLabel.Right + 10;
            emailTextBox.Top = surnameTextBox.Bottom + verticalSpacing;


            Label passwordLabel = new Label();
            passwordLabel.Text = "Müşteri Şifre:";
            passwordLabel.AutoSize = true;
            passwordLabel.Left = 10;
            passwordLabel.Top = emailTextBox.Bottom + verticalSpacing;

            TextBox passwordTextBox = new TextBox();
            passwordTextBox.Text = "";
            passwordTextBox.Left = passwordLabel.Right + 10;
            passwordTextBox.Top = emailTextBox.Bottom + verticalSpacing;

            Label imageLabel = new Label();
            imageLabel.Text = "Resim: ";
            imageLabel.AutoSize = true;
            imageLabel.Left = 10;
            imageLabel.Top = passwordTextBox.Bottom + verticalSpacing;

            Button imageButton = new Button();
            imageButton.Text = "Seç";
            imageButton.Left = imageLabel.Right + 10;
            imageButton.Top = passwordTextBox.Bottom + verticalSpacing;

            // Kaydet butonu
            Button saveButton = new Button();
            saveButton.Text = "Kaydet";
            saveButton.Left = 10;
            saveButton.Top = imageButton.Bottom + verticalSpacing;

            imageButton.Click += (s, EventArgs) =>
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    newUser.Image = ofd.FileName;

                }


            };


            saveButton.Click += (s, eventArgs) =>
            {
                DialogResult result = MessageBox.Show("Emin misiniz?", "Müşteri Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    newUser.Name = nameTextBox.Text;
                    newUser.Surname = surnameTextBox.Text;
                    newUser.Email = emailTextBox.Text;
                    newUser.Password = passwordTextBox.Text;
                    newUser.IsStatus = true;
                    newUser.IsDelete = false;
                    newUser.RoleId = 1;
                    bool durum = userCrud.Add(newUser);
                    MessageBox.Show(durum == true ? "Müşteri eklendi" : "Müşteri eklenemedi.");
                    addUserForm.Close();
                    GetUsersToGdv();

                }
                else
                {

                }

            };


            addUserForm.Controls.Add(nameLabel);
            addUserForm.Controls.Add(nameTextBox);
            addUserForm.Controls.Add(surnameLabel);
            addUserForm.Controls.Add(surnameTextBox);
            addUserForm.Controls.Add(emailLabel);
            addUserForm.Controls.Add(emailTextBox);
            addUserForm.Controls.Add(passwordLabel);
            addUserForm.Controls.Add(passwordTextBox);
            addUserForm.Controls.Add(imageLabel);
            addUserForm.Controls.Add(imageButton);
            addUserForm.Controls.Add(saveButton);

            addUserForm.ShowDialog();


        }


        public void GetProductsToStockGdv()
        {
            StockGdv.DataSource = null;

            var productsStock = from product in productCrud.GetAll().Where(x => x.IsDelete == false).ToList()
                                   select new
                                   {
                                       Name = product.Name,
                                       Stock = product.Stock,
                                   };

            StockGdv.DataSource = productsStock.ToList();
            StockGdv.Visible = true;

        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            GetProductsToStockGdv();



        }

        public void GetSellsToSellsGdv()
        {
            SellProductCrud sellProductCrud= new SellProductCrud();

            SellsGdv.DataSource = null;

            var productsSell = from sells in sellProductCrud.GetAll().Where(x => x.IsDelete == false).ToList()
                                join product in productCrud.GetAll().Where(x => x.IsDelete == false).ToList()
                                on sells.ProductId equals product.Id
                                select new
                                {
                                    Name = product.Name,
                                    Quantity = sells.Quantity,
                                    TotalPrice= sells.TotalPrice,
                                };

            SellsGdv.DataSource = productsSell.ToList();
            SellsGdv.Visible = true;

        }

        private void sellBtn_Click(object sender, EventArgs e)
        {

            GetSellsToSellsGdv();

        }
        public void GetCategoriesToCategoriesGdv()
        {
            CategoryCrud categoryCrud = new CategoryCrud();

            CategoriesGdv.DataSource = null;

            var categories= categoryCrud.GetAll().ToList();
                               

            CategoriesGdv.DataSource = categories.ToList();
            CategoriesGdv.Visible = true;
            CategoriesGdv.Columns["Id"].Visible = false; // Eğer Id sütunu göstermek istemiyorsanız
            CategoriesGdv.Columns["Image"].Visible = false;
            CategoriesGdv.Columns["IsStatus"].Visible = false;
            CategoriesGdv.Columns["IsDelete"].Visible = false;
        }
        private void addCategoryBtn_Click(object sender, EventArgs e)
        {

            Category category = new Category();
            
            // Yeni bir form oluştur
            Form addCategoryForm = new Form();
            addCategoryForm.Text = "Kategori Ekle";
            addCategoryForm.StartPosition = FormStartPosition.CenterScreen;

            int verticalSpacing = 10;

           
            Label nameLabel = new Label();
            nameLabel.Text = "Kategori Adı:";
            nameLabel.AutoSize = true;
            nameLabel.Left = 10;
            nameLabel.Top = verticalSpacing;

            TextBox nameTextBox = new TextBox();
            nameTextBox.Text = "";
            nameTextBox.Left = nameLabel.Right + 10;
            nameTextBox.Top = verticalSpacing;

    
            Label descriptionLabel = new Label();
            descriptionLabel.Text = "Ürün Açıklaması:";
            descriptionLabel.AutoSize = true;
            descriptionLabel.Left = 10;
            descriptionLabel.Top = nameTextBox.Bottom + verticalSpacing;

            TextBox descriptionTextBox = new TextBox();
            descriptionTextBox.Text = "";
            descriptionTextBox.Left = descriptionLabel.Right + 10;
            descriptionTextBox.Top = nameTextBox.Bottom + verticalSpacing;


            Label imageLabel = new Label();
            imageLabel.Text = "Resim: ";
            imageLabel.AutoSize = true;
            imageLabel.Left = 10;
            imageLabel.Top = descriptionTextBox.Bottom + verticalSpacing;

            Button imageButton = new Button();
            imageButton.Text = "Seç";
            imageButton.Left = imageLabel.Right + 10;
            imageButton.Top = descriptionTextBox.Bottom + verticalSpacing;

            // Kaydet butonu
            Button addButton = new Button();
            addButton.Text = "Ekle";
            addButton.Left = 10;
            addButton.Top = imageButton.Bottom + verticalSpacing;



            imageButton.Click += (s, EventArgs) =>
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    category.Image = ofd.FileName;

                }


            };


            addButton.Click += (s, eventArgs) =>
            {
                DialogResult result = MessageBox.Show("Emin misiniz?", "Kategori Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    category.Name = nameTextBox.Text;
                    category.Description = descriptionTextBox.Text;
                    category.IsStatus = true;
                    category.IsDelete = false;

                    bool durum = categoryCrud.Add(category);
                    MessageBox.Show(durum == true ? "Kategori eklendi" : "Kategori eklenemedi.");
                    addCategoryForm.Close();
                    GetCategoriesToCategoriesGdv();

                }
                else
                {

                }

            };

            addCategoryForm.Controls.Add(nameLabel);
            addCategoryForm.Controls.Add(nameTextBox);
            addCategoryForm.Controls.Add(descriptionLabel);
            addCategoryForm.Controls.Add(descriptionTextBox);
            addCategoryForm.Controls.Add(imageLabel);
            addCategoryForm.Controls.Add(imageButton);
            addCategoryForm.Controls.Add(addButton);

            addCategoryForm.ShowDialog();









        }

        private void RaporBtn_Click(object sender, EventArgs e)
        {
            OrderCrud orderCrud = new OrderCrud(); 
            SellProductCrud sellProductCrud = new SellProductCrud();
            // Orders ve SellProducts tablolarını birleştirip tarih bazında satışları gruplayan sorgu
            var salesByDate = from order in orderCrud.GetAll().ToList()
                              join sellProduct in sellProductCrud.GetAll().ToList() on order.Id equals sellProduct.OrderId
                              group new { order, sellProduct } by order.OrderDateTine.Date into grouped
                              select new
                              {
                                  Date = grouped.Key,
                                  TotalSales = grouped.Sum(x => x.sellProduct.Quantity)
                              };

            // Yeni form oluştur
            Form reportForm = new Form();
            reportForm.StartPosition = FormStartPosition.CenterScreen;

            // DataGridView oluştur ve özelliklerini ayarla
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = salesByDate.ToList();

            // Form'a DataGridView'ı ekle
            reportForm.Controls.Add(dataGridView);

            // Form'u göster
            reportForm.ShowDialog();




        }
    }
}
