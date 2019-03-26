using API.Utils;
using API.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestForm
{
    public partial class OrderPlace : Form
    {
        public bool IsOK = false;

        public OrderPlace(MarketType market, List<string> pairs, dynamic row = null)
        {
            InitializeComponent();

            tbMarket.Text = EnumValue.GetValue(market);
            cbPair.Items.AddRange(pairs.ToArray());

            // add
            if (row == null)
            {
                if (cbPair.Items.Count > 0)
                {
                    cbPair.SelectedIndex = 0;
                }

                tbGUID.Text = Guid.NewGuid().ToString("N");
            }
            // move
            else
            {
                cbPair.Text = row.pair;
                cbPair.Enabled = false;
                rbBuy.Checked = row.buy;
                rbSell.Checked = !row.buy;
                panel1.Enabled = false;
                rbLimit.Checked = row.limit;
                rbMarket.Checked = !row.limit;
                panel2.Enabled = false;
                tbAmount.Text = row.amount;
                tbAmount.Enabled = false;
                tbPrice.Text = row.price;
                tbGUID.Text = row.guid;
                tbGUID.Enabled = false;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            IsOK = true;

            this.Close();
        }
    }
}
