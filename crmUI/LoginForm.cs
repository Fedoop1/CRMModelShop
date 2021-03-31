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
    public partial class LoginForm : Form
    {
        public Customer customer;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(nameEdit.Text) && !string.IsNullOrEmpty(nameEdit.Text))
            {
                customer = new Customer() { Name = nameEdit.Text };
                Close();
            }
            else
            {
                MessageBox.Show("Полке заполненно некорреткно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Abort;
            }
        }
    }
}
