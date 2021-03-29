using crmBI.Model;
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
    public partial class ModelForm : Form
    {
        ShopComputerModel computerModel;
        public ModelForm()
        {
            computerModel = new ShopComputerModel();
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StopBtn.Enabled = true;
            StartBtn.Enabled = false;
            computerModel.Start();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            computerModel.Stop();
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
        }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            List<CashDeskView> cashdeskViews = new List<CashDeskView>();

            for (int cashdeskCount = 0; cashdeskCount < computerModel.CashDesks.Count; cashdeskCount++)
            {
                var view = new CashDeskView(computerModel.CashDesks[cashdeskCount], cashdeskCount);
                cashdeskViews.Add(view);
                Controls.Add(view.cashName);
                Controls.Add(view.cashSum);
                Controls.Add(view.leaveCount);
                Controls.Add(view.queueLenght);
            }

            customerSpeedbar.Value = computerModel.customerSpeed;
            sellerSpeedbar.Value = computerModel.customerSpeed;
        }

        private void customerSpeedbar_ValueChanged(object sender, EventArgs e)
        {
            computerModel.Stop();
            computerModel.customerSpeed = customerSpeedbar.Value;
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
        }

        private void sellerSpeedbar_ValueChanged(object sender, EventArgs e)
        {
            computerModel.Stop();
            computerModel.sellerSpeed = sellerSpeedbar.Value;
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
        }
    }
}
