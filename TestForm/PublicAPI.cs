using API.Utils;
using API.Enums;
using API.REST;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TestForm
{
    public partial class PublicAPI : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly string public_key;
        private readonly string private_key;

        private Rest rest;

        private Dictionary<MarketType, List<string>> pairs;

        public PublicAPI(string public_key, string private_key)
        {
            InitializeComponent();

            this.public_key = public_key ?? throw new ArgumentNullException("public_key");
            this.private_key = private_key ?? throw new ArgumentNullException("private_key");
            rest = new Rest(this.public_key, this.private_key);

            dtpStart.Value = DateTime.Now.AddHours(-1);
            dtpEnd.Value = DateTime.Now;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            rtResult.Clear();
        }

        private MarketType GetMarket()
        {
            if (lbMarkets.SelectedItem == null)
            {
                MessageBox.Show("No Markets selected", "Warning");
                return MarketType.Empty;
            }
            return EnumValue.GetEnum<MarketType>(lbMarkets.SelectedItem.ToString());
        }

        private string GetPair()
        {
            if (lbPairs.SelectedItem == null)
            {
                MessageBox.Show("No Pairs selected", "Warning");
                return null;
            }

            return lbPairs.SelectedItem.ToString();
        }

        private void MarketsPairs_Click(object sender, EventArgs e)
        {
            pairs = rest.GetMarketsPairs();

            // load markets
            lbMarkets.Items.Clear();
            if (pairs != null)
                lbMarkets.Items.AddRange(pairs.Keys.Select(x => EnumValue.GetValue(x)).ToArray());
        }

        private void Markets_SelectedValueChanged(object sender, EventArgs e)
        {
            // load pairs
            lbPairs.Items.Clear();
            lbPairs.Items.AddRange(pairs[GetMarket()].ToArray());
        }

        private void LastPrice_Click(object sender, EventArgs e)
        {
            var market = GetMarket();
            if (market == MarketType.Empty) return;
            var pair = GetPair();
            if (string.IsNullOrWhiteSpace(pair)) return;

            var data = rest.GetLastPrice(market, pair);

            rtResult.Text += "Last price: " + DateTime.Now.ToString() + "\n";
            rtResult.Text += JsonConvert.SerializeObject(data) + "\n";
            rtResult.Text += "\n";
        }

        private void Orderbook_Click(object sender, EventArgs e)
        {
            var market = GetMarket();
            if (market == MarketType.Empty) return;
            var pair = GetPair();
            if (string.IsNullOrWhiteSpace(pair)) return;

            var data = rest.GetOrderbook(market, pair);

            rtResult.Text += "Orderbook: " + DateTime.Now.ToString() + "\n";
            if (data?.ASKs == null)
            {
                rtResult.Text += "ASKs: NULL\n";
            }
            else
            {
                rtResult.Text += "ASKs:\n";
                foreach (var item in data.ASKs)
                {
                    rtResult.Text += "price=" + item.Key + ", amount=" + item.Value + "\n";
                }
            }
            if (data?.BIDs == null)
            {
                rtResult.Text += "BIDs: NULL\n";
            }
            else
            {
                rtResult.Text += "BIDs:\n";
                foreach (var item in data.BIDs)
                {
                    rtResult.Text += "price=" + item.Key + ", amount=" + item.Value + "\n";
                }
            }
            rtResult.Text += "\n";
        }

        private void OHLC_Click(object sender, EventArgs e)
        {
            var market = GetMarket();
            if (market == MarketType.Empty) return;
            var pair = GetPair();
            if (string.IsNullOrWhiteSpace(pair)) return;

            DateTimeOffset dtstart = dtpStart.Value.ToUniversalTime();
            DateTimeOffset dtend = dtpEnd.Value.ToUniversalTime();

            var data = rest.GetOHLC(market, pair, dtstart.ToUnixTimeSeconds(), dtend.ToUnixTimeSeconds());
            rtResult.Text += "OHLC: " + DateTime.Now.ToString() + "\n";
            if (data == null)
            {
                rtResult.Text += "NULL\n";
            }
            else
            {
                foreach (var item in data)
                {
                    rtResult.Text += JsonConvert.SerializeObject(item) + "\n";
                }
            }
            rtResult.Text += "\n";
        }

        private void RecentTrades_Click(object sender, EventArgs e)
        {
            var market = GetMarket();
            if (market == MarketType.Empty) return;
            var pair = GetPair();
            if (string.IsNullOrWhiteSpace(pair)) return;

            DateTimeOffset dtstart = dtpStart.Value.ToUniversalTime();
            DateTimeOffset dtend = dtpEnd.Value.ToUniversalTime();

            var data = rest.GetRecentTrades(market, pair);
            rtResult.Text += "Recent Trades: " + DateTime.Now.ToString() + "\n";
            if (data == null)
            {
                rtResult.Text += "NULL\n";
            }
            else
            {
                foreach (var item in data)
                {
                    rtResult.Text += JsonConvert.SerializeObject(item) + "\n";
                }
            }
            rtResult.Text += "\n";
        }
    }
}
