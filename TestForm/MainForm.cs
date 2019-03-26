using API.REST;
using Newtonsoft.Json;
using NLog.Windows.Forms;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TestForm
{
    public partial class MainForm : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly string cfg_file = "app.cfg";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RichTextBoxTarget.ReInitializeAllTextboxes(this);

            // read config
            try
            {
                var cfg = File.ReadAllText(cfg_file);
                if (!string.IsNullOrWhiteSpace(cfg))
                {
                    dynamic json = JsonConvert.DeserializeObject(cfg);
                    if (json?.pub != null)
                    {
                        tbPublic.Text = json?.pub.ToString();
                    }
                    if (json?.priv != null)
                    {
                        tbPrivate.Text = json?.priv.ToString();
                    }
                }
            }
            catch
            {
                // None
            }
        }

        ~MainForm()
        {
            NLog.LogManager.Shutdown(); // Flush and close down internal threads and timers
        }

        private void Key_Leave(object sender, EventArgs e)
        {
            tbPublic.Text = tbPublic.Text.Trim();
            tbPrivate.Text = tbPrivate.Text.Trim();

            // save config
            var cfg = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(new { pub = tbPublic.Text, priv = tbPrivate.Text }));
            using (var fs = new FileStream(cfg_file, FileMode.Create))
            {
                fs.Write(cfg, 0, cfg.Length);
                fs.Flush();
                fs.Close();
            }
        }

        private void PublicAPI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPublic.Text))
            {
                MessageBox.Show("No public API key", "Warning");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPrivate.Text))
            {
                MessageBox.Show("No private API key", "Warning");
                return;
            }

            var form = new PublicAPI(tbPublic.Text, tbPrivate.Text);
            form.Show();
        }

        private void UserAPI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPublic.Text))
            {
                MessageBox.Show("No public API key", "Warning");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPrivate.Text))
            {
                MessageBox.Show("No private API key", "Warning");
                return;
            }

            var form = new UserAPI(tbPublic.Text, tbPrivate.Text);
            form.Show();
        }
    }
}
