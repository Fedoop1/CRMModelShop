using crmBI;
using crmBI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crmUI
{
    class CashDeskView
    {
        public Label cashName;
        public NumericUpDown cashSum;
        public ProgressBar queueLenght;
        public Label leaveCount;
        public CashDesk cashDesk;

        public CashDeskView(CashDesk cashDesk, int number)
        {
            this.cashDesk = cashDesk;

            cashName = new Label();
            cashName.AutoSize = true;
            cashName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cashName.Location = new System.Drawing.Point(5, number * 35 + 10);
            cashName.Name = "cashLabel" + cashDesk.number.ToString();
            cashName.Size = new System.Drawing.Size(69, 20);
            cashName.TabIndex = 3;
            cashName.Text = $"Cash Number {number}: ";

            queueLenght = new ProgressBar();
            queueLenght.Location = new System.Drawing.Point(229, number * 35 + 10);
            queueLenght.Name = "queueLenght" + cashDesk.number.ToString();
            queueLenght.Size = new System.Drawing.Size(100, 20);
            queueLenght.Minimum = 0;
            queueLenght.Maximum = cashDesk.maxLenght;
            queueLenght.TabIndex = 4;

            leaveCount = new Label();

            leaveCount.AutoSize = true;
            leaveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            leaveCount.Location = new System.Drawing.Point(344, number * 35 + 10);
            leaveCount.Name = "leaveLable" + cashDesk.number;
            leaveCount.Size = new System.Drawing.Size(56, 20);
            leaveCount.TabIndex = 5;
            leaveCount.Text = $"Queue leave: {cashDesk.exitCount}.";

            cashSum = new NumericUpDown();

            cashSum.Location = new System.Drawing.Point(95, number * 35 + 10);
            cashSum.Name = "cashSum" + cashDesk.number;
            cashSum.Size = new System.Drawing.Size(120, 20);
            cashSum.TabIndex = 2;
            cashSum.DecimalPlaces = 2;
            cashSum.Minimum = 0;
            cashSum.Maximum = 1_000_000;

            cashDesk.BillOut += CashDesk_BillOut;
        }

        private void CashDesk_BillOut(object sender, Bill e)
        {
            cashSum.Invoke((Action)delegate 
            { 
                cashSum.Value += e.Price;
                queueLenght.Value = cashDesk.Count;
                leaveCount.Text = $"Queue leave: {cashDesk.exitCount}.";
            });
        }

    }
}
