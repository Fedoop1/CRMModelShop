using crmBI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crmUI
{
    public partial class ProductForm : Form
    {
        public Product product;

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product) : this()
        {
            this.product = product;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(product is null)
            {
                product = new Product() { Name = nameBox.Text, Count = Convert.ToInt32(numericCount.Value), Price = numericPrice.Value };
            }
            else
            {
                product.Name = nameBox.Text;
                product.Price = numericPrice.Value;
                product.Count = Convert.ToInt32(numericCount.Value);
            }

            Close();
        }
    }
}
