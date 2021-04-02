using crmBI;
using crmBI.Model;
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

namespace crmUI
{
    public partial class Catalog<T> : Form
        where T : class
    {

        CrmContext db;
        DbSet set;
        public Catalog(DbSet<T> set, CrmContext db)
        {
            InitializeComponent();
            this.db = db;
            this.set = set;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                
                switch(typeof(T).Name)
                {
                    case "Product":
                        db.Products.Remove(db.Products.FirstOrDefault(p => p.ProductId == id));
                        break;
                    case "Seller":
                        db.Sellers.Remove(db.Sellers.FirstOrDefault(p => p.SellerId == id));
                        break;
                    case "Customer":
                        db.Customers.Remove(db.Customers.FirstOrDefault(p => p.CustomerId == id));
                        break;
                    case "Bill":
                        db.Bills.Remove(db.Bills.FirstOrDefault(p => p.BillId == id));
                        break;
                }

                db.SaveChanges();
                dataGridView.Update();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (typeof(T).Name)
            {
                case "Product":
                    ProductForm pForm = new ProductForm();
                    pForm.ShowDialog();
                    if(pForm.DialogResult == DialogResult.OK)
                    {
                        db.Products.Add(pForm.product);
                    }
                    break;
                case "Seller":
                    SellerForm sForm = new SellerForm();
                    sForm.ShowDialog();
                    if (sForm.DialogResult == DialogResult.OK)
                    {
                        db.Sellers.Add(sForm.seller);
                    }
                    break;
                case "Customer":
                    CustomerForm cForm = new CustomerForm();
                    cForm.ShowDialog();
                    if (cForm.DialogResult == DialogResult.OK)
                    {
                        db.Customers.Add(cForm.customer);
                    }
                    break;
            }

            db.SaveChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                switch (typeof(T).Name)
                {
                    case "Product":
                        Product product = db.Products.FirstOrDefault(p => p.ProductId == id);
                        ProductForm pForm = new ProductForm(product);
                        pForm.ShowDialog();
                        if (pForm.DialogResult == DialogResult.OK)
                        {
                            product = pForm.product;
                        }
                        break;
                    case "Seller":
                        Seller seller = db.Sellers.FirstOrDefault(p => p.SellerId == id);
                        SellerForm sForm = new SellerForm(seller);
                        sForm.ShowDialog();
                        if (sForm.DialogResult == DialogResult.OK)
                        {
                            seller = sForm.seller;
                        }
                        break;
                    case "Customer":
                        Customer customer = db.Customers.FirstOrDefault(p => p.CustomerId == id);
                        CustomerForm cForm = new CustomerForm(customer);
                        cForm.ShowDialog();
                        if (cForm.DialogResult == DialogResult.OK)
                        {
                            customer = cForm.customer;
                        }
                        break;
                }

                db.SaveChanges();
            }
        }
            
    }
}
