namespace TestForm
{
    partial class PublicAPI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bRecentTrades = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.bOHLC = new System.Windows.Forms.Button();
            this.bOrderbook = new System.Windows.Forms.Button();
            this.bLastPrice = new System.Windows.Forms.Button();
            this.bMarketsPairs = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPairs = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMarkets = new System.Windows.Forms.ListBox();
            this.rtResult = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(710, 168);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 8;
            this.bClear.Text = "Clear Result";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bClear);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 194);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bRecentTrades);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.bOHLC);
            this.groupBox2.Controls.Add(this.bOrderbook);
            this.groupBox2.Controls.Add(this.bLastPrice);
            this.groupBox2.Controls.Add(this.bMarketsPairs);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbPairs);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbMarkets);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 167);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Params";
            // 
            // bRecentTrades
            // 
            this.bRecentTrades.Location = new System.Drawing.Point(6, 138);
            this.bRecentTrades.Name = "bRecentTrades";
            this.bRecentTrades.Size = new System.Drawing.Size(118, 23);
            this.bRecentTrades.TabIndex = 16;
            this.bRecentTrades.Text = "Recent Trades";
            this.bRecentTrades.UseVisualStyleBackColor = true;
            this.bRecentTrades.Click += new System.EventHandler(this.RecentTrades_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "End";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(391, 84);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(106, 20);
            this.dtpEnd.TabIndex = 14;
            this.dtpEnd.Value = new System.DateTime(2019, 3, 25, 10, 40, 37, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Start";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(391, 38);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(106, 20);
            this.dtpStart.TabIndex = 12;
            // 
            // bOHLC
            // 
            this.bOHLC.Location = new System.Drawing.Point(6, 109);
            this.bOHLC.Name = "bOHLC";
            this.bOHLC.Size = new System.Drawing.Size(118, 23);
            this.bOHLC.TabIndex = 11;
            this.bOHLC.Text = "Open-High-Low-Close";
            this.bOHLC.UseVisualStyleBackColor = true;
            this.bOHLC.Click += new System.EventHandler(this.OHLC_Click);
            // 
            // bOrderbook
            // 
            this.bOrderbook.Location = new System.Drawing.Point(6, 80);
            this.bOrderbook.Name = "bOrderbook";
            this.bOrderbook.Size = new System.Drawing.Size(118, 23);
            this.bOrderbook.TabIndex = 10;
            this.bOrderbook.Text = "Orderbook";
            this.bOrderbook.UseVisualStyleBackColor = true;
            this.bOrderbook.Click += new System.EventHandler(this.Orderbook_Click);
            // 
            // bLastPrice
            // 
            this.bLastPrice.Location = new System.Drawing.Point(6, 51);
            this.bLastPrice.Name = "bLastPrice";
            this.bLastPrice.Size = new System.Drawing.Size(118, 23);
            this.bLastPrice.TabIndex = 9;
            this.bLastPrice.Text = "Last price";
            this.bLastPrice.UseVisualStyleBackColor = true;
            this.bLastPrice.Click += new System.EventHandler(this.LastPrice_Click);
            // 
            // bMarketsPairs
            // 
            this.bMarketsPairs.Location = new System.Drawing.Point(6, 24);
            this.bMarketsPairs.Name = "bMarketsPairs";
            this.bMarketsPairs.Size = new System.Drawing.Size(118, 23);
            this.bMarketsPairs.TabIndex = 9;
            this.bMarketsPairs.Text = "Markets and Pairs";
            this.bMarketsPairs.UseVisualStyleBackColor = true;
            this.bMarketsPairs.Click += new System.EventHandler(this.MarketsPairs_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pairs";
            // 
            // lbPairs
            // 
            this.lbPairs.FormattingEnabled = true;
            this.lbPairs.Location = new System.Drawing.Point(263, 37);
            this.lbPairs.Name = "lbPairs";
            this.lbPairs.Size = new System.Drawing.Size(122, 121);
            this.lbPairs.Sorted = true;
            this.lbPairs.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Markets";
            // 
            // lbMarkets
            // 
            this.lbMarkets.FormattingEnabled = true;
            this.lbMarkets.Location = new System.Drawing.Point(132, 38);
            this.lbMarkets.Name = "lbMarkets";
            this.lbMarkets.Size = new System.Drawing.Size(125, 121);
            this.lbMarkets.Sorted = true;
            this.lbMarkets.TabIndex = 4;
            this.lbMarkets.SelectedValueChanged += new System.EventHandler(this.Markets_SelectedValueChanged);
            // 
            // rtResult
            // 
            this.rtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtResult.Location = new System.Drawing.Point(0, 194);
            this.rtResult.Name = "rtResult";
            this.rtResult.Size = new System.Drawing.Size(794, 256);
            this.rtResult.TabIndex = 6;
            this.rtResult.Text = "";
            // 
            // PublicAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.rtResult);
            this.Controls.Add(this.panel1);
            this.Name = "PublicAPI";
            this.Text = "Test Public API";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbMarkets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbPairs;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.RichTextBox rtResult;
        private System.Windows.Forms.Button bMarketsPairs;
        private System.Windows.Forms.Button bLastPrice;
        private System.Windows.Forms.Button bOrderbook;
        private System.Windows.Forms.Button bOHLC;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRecentTrades;
    }
}