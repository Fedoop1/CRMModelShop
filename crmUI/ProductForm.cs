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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(nameBox.Text != null && numericCount.Value != decimal.Zero && numericPrice.Value != decimal.Zero)
            {
                product = new Product() { Name = nameBox.Text, Count = Convert.ToInt32(numericCount.Value), Price = numericPrice.Value };
            }

            Close();
        }
    }
}
