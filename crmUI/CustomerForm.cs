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
    public partial class CustomerForm : Form
    {
        public Customer customer;

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(Customer customer) : this()
        {
            this.customer = customer;
            nameBox.Text = customer.Name;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(customer is null)
            {
                customer = new Customer() { Name = nameBox.Text };
            }
            else
            {
                customer.Name = nameBox.Text;
            }

            Close();
        }
    }
}
