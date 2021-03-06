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
    public partial class SellerForm : Form
    {
        public Seller seller;

        public SellerForm()
        {
            InitializeComponent();
        }

        public SellerForm(Seller seller) : this()
        {
            this.seller = seller;
            nameBox.Text = seller.Name;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (seller is null) 
            { 
                seller = new Seller { Name = nameBox.Text }; 
            }
            else
            {
                seller.Name = nameBox.Text;
            }
            Close();
        }
    }
}
