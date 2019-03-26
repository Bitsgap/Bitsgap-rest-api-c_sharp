using API.Enums;
using API.Model;
using API.REST;
using API.REST.Model.Responses;
using API.REST.Model.Responses.Data;
using API.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestForm
{
    public partial class UserAPI : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly string public_key;
        private readonly string private_key;

        private Rest rest;

        private Dictionary<MarketType, List<string>> pairs;
        private Dictionary<MarketType, DataAPIKey> keys;
        private Dictionary<MarketType, DataBalances> balances;
        private Dictionary<MarketType, List<DataOrder>> orders;
        private Dictionary<MarketType, List<DataDeal>> deals;

        public UserAPI(string public_key, string private_key)
        {
            InitializeComponent();

            this.public_key = public_key ?? throw new ArgumentNullException("public_key");
            this.private_key = private_key ?? throw new ArgumentNullException("private_key");
            rest = new Rest(this.public_key, this.private_key);

            pairs = rest.GetMarketsPairs();
        }

        private MarketType GetMarket(bool no_message = false)
        {
            if (lbMarkets.SelectedItem == null)
            {
                if (!no_message)
                    MessageBox.Show("No Markets selected", "Warning");
                return MarketType.Empty;
            }

            string market = lbMarkets.SelectedItem.ToString();
            return EnumValue.GetEnum<MarketType>(market);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            lbKeysTime.Text = string.Empty;
            lbBalance.Text = string.Empty;
            lbOrders.Text = string.Empty;
            lbDeals.Text = string.Empty;
            lbMessages.Text = string.Empty;

            lbMarkets.Items.Clear();
            tbKeyStatus.Text = string.Empty;
            lbMarketSelect.Text = "no market selected";

            dgBalanceAvailable.DataSource = null;
            dgBalanceTotal.DataSource = null;
            dgOrders.DataSource = null;
            dgDeals.DataSource = null;
            dgMessages.DataSource = null;

            keys = null;
            balances = null;
            orders = null;
            deals = null;
        }

        private void Real_CheckedChanged(object sender, EventArgs e)
        {
            Clear_Click(sender, e);
        }

        private void APIKeys_Click(object sender, EventArgs e)
        {
            if (!rbReal.Checked)
            {
                MessageBox.Show("User keys only for Real", "Warning");
                return;
            }

            keys = rest.GetAPIKeys();

            UpdateMarkets(keys?.Keys.Select(x => EnumValue.GetValue(x)).ToList());
        }

        private void UpdateMarkets(List<string> markets)
        {
            lbKeysTime.Text = DateTime.Now.ToString();

            // load markets
            lbMarkets.Items.Clear();
            lbMarkets.Items.AddRange(markets?.ToArray());
        }

        private void Markets_SelectedValueChanged(object sender, EventArgs e)
        {
            var market = GetMarket(true);
            if (market == MarketType.Empty) return;

            lbMarketSelect.Text = "market: " + lbMarkets.SelectedItem.ToString();

            if (rbReal.Checked)
            {
                tbKeyStatus.Text = keys[market].Status + "\n" + keys[market].Message;
            }

            UpdateBalances();
            UpdateOrders();
            UpdateDeals();
        }

        private void Balances_Click(object sender, EventArgs e)
        {
            // save
            balances = rest.GetBalances(rbReal.Checked ? SysType.Real : SysType.Demo);

            lbBalance.Text = "Update time: " + DateTime.Now.ToString();

            // list of markets for demo
            if (!rbReal.Checked)
            {
                UpdateMarkets(balances?.Keys.Select(x => EnumValue.GetValue(x)).ToList());
            }

            UpdateBalances();
        }

        private void UpdateBalances()
        {
            dgBalanceAvailable.DataSource = null;
            dgBalanceTotal.DataSource = null;

            if (balances == null) return;

            var market = GetMarket(true);
            if (market == MarketType.Empty) return;

            if (balances.TryGetValue(market, out DataBalances data))
            {
                dgBalanceAvailable.AutoGenerateColumns = true;
                dgBalanceAvailable.DataSource = data?.Available?.ToList();
                dgBalanceTotal.AutoGenerateColumns = true;
                dgBalanceTotal.DataSource = data?.Total?.ToList();
            }
        }

        private void GetBalance_Click(object sender, EventArgs e)
        {
            if (!rbReal.Checked)
            {
                MessageBox.Show("Get balance only for Real", "Warning");
                return;
            }

            var market = GetMarket();
            if (market == MarketType.Empty) return;

            balances = balances ?? new Dictionary<MarketType, DataBalances>();
            balances[market] = rest.GetBalance(market);

            lbBalance.Text = "Update time: " + DateTime.Now.ToString() + " for market " + EnumValue.GetValue(market);

            UpdateBalances();
        }

        private void OpenOrders_Click(object sender, EventArgs e)
        {
            var market = GetMarket();
            if (market == MarketType.Empty) return;

            orders = orders ?? new Dictionary<MarketType, List<DataOrder>>();
            orders[market] = rest.GetOrders(rbReal.Checked ? SysType.Real : SysType.Demo, market);

            lbOrders.Text = "Update time: " + DateTime.Now.ToString() + " for market " + EnumValue.GetValue(market);

            UpdateOrders();
        }

        private void UpdateOrders()
        {
            dgOrders.DataSource = null;

            if (orders == null) return;

            var market = GetMarket(true);
            if (market == MarketType.Empty) return;

            if (orders.TryGetValue(market, out List<DataOrder> data))
            {
                dgOrders.AutoGenerateColumns = true;
                dgOrders.DataSource = data?.ToList();
            }
        }

        private void Deals_Click(object sender, EventArgs e)
        {
            var market = GetMarket();
            if (market == MarketType.Empty) return;

            deals = deals ?? new Dictionary<MarketType, List<DataDeal>>();
            deals[market] = rest.GetDeals(rbReal.Checked ? SysType.Real : SysType.Demo, market);

            lbDeals.Text = "Update time: " + DateTime.Now.ToString() + " for market " + EnumValue.GetValue(market);

            UpdateDeals();
        }

        private void UpdateDeals()
        {
            dgDeals.DataSource = null;

            if (deals == null) return;

            var market = GetMarket(true);
            if (market == MarketType.Empty) return;

            if (deals.TryGetValue(market, out List<DataDeal> data))
            {
                dgDeals.AutoGenerateColumns = true;
                dgDeals.DataSource = data?.ToList();
            }
        }

        private void Messages_Click(object sender, EventArgs e)
        {
            var mess = rest.GetMessages();

            lbMessages.Text = "Update time: " + DateTime.Now.ToString();

            dgMessages.DataSource = null;

            if (mess == null) return;

            dgMessages.AutoGenerateColumns = true;
            dgMessages.DataSource = mess;
        }

        private void Place_Click(object sender, EventArgs e)
        {
            var market = GetMarket();
            if (market == MarketType.Empty) return;

            using (var form = new OrderPlace(market, pairs[market]))
            {
                form.ShowDialog();
                if (form.IsOK)
                {
                    var order = rest.OrderPlace(
                        rbReal.Checked ? SysType.Real : SysType.Demo,
                        market,
                        new Order
                        {
                            Pair = form.cbPair.Text,
                            Side = form.rbBuy.Checked ? OrderSide.Buy : OrderSide.Sell,
                            Type = form.rbLimit.Checked ? OrderType.Limit : OrderType.Market,
                            Amount = form.tbAmount.Text,
                            Price = form.rbLimit.Checked ? form.tbPrice.Text : null,
                        },
                        string.IsNullOrWhiteSpace(form.tbGUID.Text) ? null : form.tbGUID.Text
                    );

                    if (string.IsNullOrWhiteSpace(order.ErrorMessage))
                    {
                        orders = orders ?? new Dictionary<MarketType, List<DataOrder>>();
                        orders[market] = orders[market] ?? new List<DataOrder>();
                        orders[market].Add(order);
                        lbOrders.Text = "Update time: " + DateTime.Now.ToString() + " for market " + EnumValue.GetValue(market) + " and order id " + order.OrderID;

                        UpdateOrders();
                    }
                    else
                    {
                        MessageBox.Show("Order not placed: " + order.ErrorMessage, "Error");
                    }
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            var market = GetMarket();
            if (market == MarketType.Empty) return;

            if (dgOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("No order selected", "Warning");
                return;
            }

            foreach (DataGridViewRow row in dgOrders.SelectedRows)
            {
                var order_id = row.Cells["OrderID"].Value.ToString();

                var order = rest.OrderCancel(
                    rbReal.Checked ? SysType.Real : SysType.Demo,
                    market,
                    new Order
                    {
                        OrderID = order_id
                    }
                );

                if (string.IsNullOrWhiteSpace(order.ErrorMessage))
                {
                    orders = orders ?? new Dictionary<MarketType, List<DataOrder>>();
                    orders[market] = orders[market] ?? new List<DataOrder>();
                    orders[market].RemoveAll(x => x.OrderID == order_id);
                    lbOrders.Text = "Update time: " + DateTime.Now.ToString() + " for market " + EnumValue.GetValue(market) + " and order id " + order_id;

                    UpdateOrders();
                }
                else
                {
                    MessageBox.Show("Order not canceled: " + order.ErrorMessage, "Error");
                }
            }

        }

        private void Move_Click(object sender, EventArgs e)
        {
            var market = GetMarket();
            if (market == MarketType.Empty) return;

            if (dgOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("No order selected", "Warning");
                return;
            }

            foreach (DataGridViewRow row in dgOrders.SelectedRows)
            {
                var order_id = row.Cells["OrderID"].Value.ToString();

                using (var form = new OrderPlace(
                    market,
                    pairs[market],
                    new
                    {
                        pair = row.Cells["Pair"].Value?.ToString(),
                        buy = row.Cells["Side"].Value?.ToString() == "Buy",
                        limit = row.Cells["Type"].Value?.ToString() == "Limit",
                        amount = row.Cells["Amount"].Value?.ToString(),
                        price = row.Cells["Price"].Value?.ToString(),
                        guid = row.Cells["API_GUID"].Value?.ToString()
                    }))
                {
                    form.ShowDialog();
                    if (form.IsOK)
                    {
                        var order = rest.OrderMove(
                            rbReal.Checked ? SysType.Real : SysType.Demo,
                            market,
                            new Order
                            {
                                OrderID = order_id,
                                Price = form.tbPrice.Text
                            }
                        );

                        if (string.IsNullOrWhiteSpace(order.ErrorMessage))
                        {
                            orders = orders ?? new Dictionary<MarketType, List<DataOrder>>();
                            orders[market] = orders[market] ?? new List<DataOrder>();
                            orders[market].RemoveAll(x => x.OrderID == order_id);
                            orders[market].Add(order);
                            lbOrders.Text = "Update time: " + DateTime.Now.ToString() + " for market " + EnumValue.GetValue(market) + " and order id " + order.OrderID;

                            UpdateOrders();
                        }
                        else
                        {
                            MessageBox.Show("Order not moved: " + order.ErrorMessage, "Error");
                        }
                    }
                }
            }
        }
    }
}
