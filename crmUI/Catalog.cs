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
        public Catalog(DbSet<T> set, CrmContext db)
        {
            InitializeComponent();
            this.db = db;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }
    }
}
