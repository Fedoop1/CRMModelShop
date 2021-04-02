using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crmBI;
using crmBI.Model;

namespace crmUI
{
    public partial class MainForm : Form
    {
        CrmContext database;
        Customer customer;
        Cart cart;
        CashDesk desk;
        bool isLogin = false;
        public MainForm()
        {
            InitializeComponent();
            database = new CrmContext();
            cart = new Cart(customer);
            desk = new CashDesk(database.Sellers.FirstOrDefault(), 1, database) { isModel = false };
        }

        private void ProductMenu_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(database.Products, database);
            catalogProduct.Show();
        }

        private void SellerMenu_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(database.Sellers, database);
            catalogSeller.Show();
        }

        private void CustomerMenu_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(database.Customers, database);
            catalogCustomer.Show();
        }

        private void BillMenu_Click(object sender, EventArgs e)
        {
            var catalogBill = new Catalog<Bill>(database.Bills, database);
            catalogBill.Show();
        }

        private void CustomerAddMenu_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();

            if(customerForm.ShowDialog() == DialogResult.OK)
            {
                database.Customers.Add(customerForm.customer);
                database.SaveChanges();
            }
        }

        private void SellerAddMenu_Click(object sender, EventArgs e)
        {
            var SellerForm = new SellerForm();

            if (SellerForm.ShowDialog() == DialogResult.OK)
            {
                database.Sellers.Add(SellerForm.seller);
                database.SaveChanges();
            }
        }

        private void ProductAddMenu_Click(object sender, EventArgs e)
        {
            var ProductForm = new ProductForm();

            if (ProductForm.ShowDialog() == DialogResult.OK)
            {
                database.Products.Add(ProductForm.product);
                database.SaveChanges();
            }
        }

        private void ModelMenuItem_Click(object sender, EventArgs e)
        {
            var ModelForm = new ModelForm();
            ModelForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                productBox.Invoke((Action)delegate { UpdateBoxed(); productBox.Items.AddRange(database.Products.ToArray()); });

            });
        }

        private void UpdateBoxed()
        {
            cartBox.Items.Clear();
            cartBox.Items.AddRange(cart.GetProducts().ToArray());
            sumLabel.Text = $"Sum: {cart.sum} руб.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                productBox.Invoke((Action)delegate { UpdateBoxed(); productBox.Items.Clear(); productBox.Items.AddRange(database.Products.ToArray()); });
            });

        }

        private void productBox_DoubleClick(object sender, EventArgs e)
        {
            if(productBox.SelectedItem is Product product)
            {
                cart.Add(product);
                UpdateBoxed();
            }
        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(isLogin)
            {
                isLogin = false;
                loginLabel.Text = "Clicl here, to login";
                BuyButton.Enabled = false;
            }
            else
            {
                var loginform = new LoginForm();
                loginform.ShowDialog();

                if(loginform.DialogResult == DialogResult.OK)
                {
                    Customer newcustomer = database.Customers.FirstOrDefault(c => c.Name.Equals(loginform.customer.Name));

                    if(newcustomer == null)
                    {
                        customer = new Customer() { Name = loginform.customer.Name };
                        database.Customers.Add(customer);
                        database.SaveChanges();
                    }
                    else
                    {
                        customer = newcustomer;
                    }

                    MessageBox.Show("Вы успешно авторизовались!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginLabel.Text = $"Welcome, {customer.Name}.";
                    isLogin = true;
                    BuyButton.Enabled = true;
                    cart.Customer = customer;
                }
                else
                {
                    MessageBox.Show("При авторизации произошла ошибка!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if(isLogin)
            {
                desk.Enqueue(cart);
                decimal sum = desk.Dequeue();

                cart = new Cart(customer);
                UpdateBoxed();

                MessageBox.Show($"Покупка успешно проведена. Сумма покупки: {sum} руб.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Вы не авторизованы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
