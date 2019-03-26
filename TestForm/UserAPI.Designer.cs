namespace TestForm
{
    partial class UserAPI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBalance = new System.Windows.Forms.TabPage();
            this.bGetBalance = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgBalanceTotal = new System.Windows.Forms.DataGridView();
            this.lbBalanceTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgBalanceAvailable = new System.Windows.Forms.DataGridView();
            this.lbBalanceAvailable = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bMove = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bPlace = new System.Windows.Forms.Button();
            this.lbOrders = new System.Windows.Forms.Label();
            this.tabDeals = new System.Windows.Forms.TabPage();
            this.dgDeals = new System.Windows.Forms.DataGridView();
            this.lbDeals = new System.Windows.Forms.Label();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.lbMessages = new System.Windows.Forms.Label();
            this.dgMessages = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDemo = new System.Windows.Forms.RadioButton();
            this.rbReal = new System.Windows.Forms.RadioButton();
            this.lbMarketSelect = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bMessages = new System.Windows.Forms.Button();
            this.bDeals = new System.Windows.Forms.Button();
            this.bOpenOrders = new System.Windows.Forms.Button();
            this.bBalances = new System.Windows.Forms.Button();
            this.bAPIKeys = new System.Windows.Forms.Button();
            this.tbKeyStatus = new System.Windows.Forms.TextBox();
            this.lbKeysTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMarkets = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabBalance.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBalanceTotal)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBalanceAvailable)).BeginInit();
            this.tabOrders.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabDeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeals)).BeginInit();
            this.tabMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMessages)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBalance);
            this.tabControl1.Controls.Add(this.tabOrders);
            this.tabControl1.Controls.Add(this.tabDeals);
            this.tabControl1.Controls.Add(this.tabMessages);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 282);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBalance
            // 
            this.tabBalance.Controls.Add(this.bGetBalance);
            this.tabBalance.Controls.Add(this.panel4);
            this.tabBalance.Controls.Add(this.panel3);
            this.tabBalance.Controls.Add(this.lbBalance);
            this.tabBalance.Location = new System.Drawing.Point(4, 22);
            this.tabBalance.Name = "tabBalance";
            this.tabBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tabBalance.Size = new System.Drawing.Size(792, 256);
            this.tabBalance.TabIndex = 0;
            this.tabBalance.Text = "Balance";
            this.tabBalance.UseVisualStyleBackColor = true;
            // 
            // bGetBalance
            // 
            this.bGetBalance.Location = new System.Drawing.Point(523, 16);
            this.bGetBalance.Name = "bGetBalance";
            this.bGetBalance.Size = new System.Drawing.Size(75, 23);
            this.bGetBalance.TabIndex = 5;
            this.bGetBalance.Text = "Get Balance";
            this.bGetBalance.UseVisualStyleBackColor = true;
            this.bGetBalance.Click += new System.EventHandler(this.GetBalance_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.lbBalanceTotal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(253, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 237);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgBalanceTotal);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 224);
            this.panel6.TabIndex = 1;
            // 
            // dgBalanceTotal
            // 
            this.dgBalanceTotal.AllowUserToAddRows = false;
            this.dgBalanceTotal.AllowUserToDeleteRows = false;
            this.dgBalanceTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBalanceTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBalanceTotal.Location = new System.Drawing.Point(0, 0);
            this.dgBalanceTotal.Name = "dgBalanceTotal";
            this.dgBalanceTotal.ReadOnly = true;
            this.dgBalanceTotal.Size = new System.Drawing.Size(250, 224);
            this.dgBalanceTotal.TabIndex = 1;
            // 
            // lbBalanceTotal
            // 
            this.lbBalanceTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBalanceTotal.Location = new System.Drawing.Point(0, 0);
            this.lbBalanceTotal.Name = "lbBalanceTotal";
            this.lbBalanceTotal.Size = new System.Drawing.Size(250, 13);
            this.lbBalanceTotal.TabIndex = 0;
            this.lbBalanceTotal.Text = "Total";
            this.lbBalanceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lbBalanceAvailable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 237);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgBalanceAvailable);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 224);
            this.panel5.TabIndex = 5;
            // 
            // dgBalanceAvailable
            // 
            this.dgBalanceAvailable.AllowUserToAddRows = false;
            this.dgBalanceAvailable.AllowUserToDeleteRows = false;
            this.dgBalanceAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBalanceAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBalanceAvailable.Location = new System.Drawing.Point(0, 0);
            this.dgBalanceAvailable.Name = "dgBalanceAvailable";
            this.dgBalanceAvailable.ReadOnly = true;
            this.dgBalanceAvailable.Size = new System.Drawing.Size(250, 224);
            this.dgBalanceAvailable.TabIndex = 1;
            // 
            // lbBalanceAvailable
            // 
            this.lbBalanceAvailable.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBalanceAvailable.Location = new System.Drawing.Point(0, 0);
            this.lbBalanceAvailable.Name = "lbBalanceAvailable";
            this.lbBalanceAvailable.Size = new System.Drawing.Size(250, 13);
            this.lbBalanceAvailable.TabIndex = 0;
            this.lbBalanceAvailable.Text = "Available";
            this.lbBalanceAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBalance
            // 
            this.lbBalance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbBalance.Location = new System.Drawing.Point(3, 240);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(786, 13);
            this.lbBalance.TabIndex = 0;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.panel8);
            this.tabOrders.Controls.Add(this.panel7);
            this.tabOrders.Controls.Add(this.lbOrders);
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(792, 256);
            this.tabOrders.TabIndex = 1;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgOrders);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 39);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(786, 201);
            this.panel8.TabIndex = 4;
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
            this.dgOrders.AllowUserToDeleteRows = false;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrders.Location = new System.Drawing.Point(0, 0);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.ReadOnly = true;
            this.dgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrders.Size = new System.Drawing.Size(786, 201);
            this.dgOrders.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.bMove);
            this.panel7.Controls.Add(this.bCancel);
            this.panel7.Controls.Add(this.bPlace);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(786, 36);
            this.panel7.TabIndex = 3;
            // 
            // bMove
            // 
            this.bMove.Location = new System.Drawing.Point(173, 7);
            this.bMove.Name = "bMove";
            this.bMove.Size = new System.Drawing.Size(75, 23);
            this.bMove.TabIndex = 2;
            this.bMove.Text = "Move";
            this.bMove.UseVisualStyleBackColor = true;
            this.bMove.Click += new System.EventHandler(this.Move_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(92, 7);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // bPlace
            // 
            this.bPlace.Location = new System.Drawing.Point(11, 7);
            this.bPlace.Name = "bPlace";
            this.bPlace.Size = new System.Drawing.Size(75, 23);
            this.bPlace.TabIndex = 0;
            this.bPlace.Text = "Place";
            this.bPlace.UseVisualStyleBackColor = true;
            this.bPlace.Click += new System.EventHandler(this.Place_Click);
            // 
            // lbOrders
            // 
            this.lbOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbOrders.Location = new System.Drawing.Point(3, 240);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(786, 13);
            this.lbOrders.TabIndex = 1;
            // 
            // tabDeals
            // 
            this.tabDeals.Controls.Add(this.dgDeals);
            this.tabDeals.Controls.Add(this.lbDeals);
            this.tabDeals.Location = new System.Drawing.Point(4, 22);
            this.tabDeals.Name = "tabDeals";
            this.tabDeals.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeals.Size = new System.Drawing.Size(792, 256);
            this.tabDeals.TabIndex = 2;
            this.tabDeals.Text = "Deals";
            this.tabDeals.UseVisualStyleBackColor = true;
            // 
            // dgDeals
            // 
            this.dgDeals.AllowUserToAddRows = false;
            this.dgDeals.AllowUserToDeleteRows = false;
            this.dgDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDeals.Location = new System.Drawing.Point(3, 3);
            this.dgDeals.Name = "dgDeals";
            this.dgDeals.ReadOnly = true;
            this.dgDeals.Size = new System.Drawing.Size(786, 237);
            this.dgDeals.TabIndex = 2;
            // 
            // lbDeals
            // 
            this.lbDeals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDeals.Location = new System.Drawing.Point(3, 240);
            this.lbDeals.Name = "lbDeals";
            this.lbDeals.Size = new System.Drawing.Size(786, 13);
            this.lbDeals.TabIndex = 1;
            // 
            // tabMessages
            // 
            this.tabMessages.Controls.Add(this.lbMessages);
            this.tabMessages.Controls.Add(this.dgMessages);
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(792, 256);
            this.tabMessages.TabIndex = 3;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // lbMessages
            // 
            this.lbMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMessages.Location = new System.Drawing.Point(3, 240);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(786, 13);
            this.lbMessages.TabIndex = 4;
            // 
            // dgMessages
            // 
            this.dgMessages.AllowUserToAddRows = false;
            this.dgMessages.AllowUserToDeleteRows = false;
            this.dgMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMessages.Location = new System.Drawing.Point(3, 3);
            this.dgMessages.Name = "dgMessages";
            this.dgMessages.ReadOnly = true;
            this.dgMessages.Size = new System.Drawing.Size(786, 250);
            this.dgMessages.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bClear);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.lbMarketSelect);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 168);
            this.panel1.TabIndex = 0;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(713, 133);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 8;
            this.bClear.Text = "Clear Data";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDemo);
            this.groupBox3.Controls.Add(this.rbReal);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(62, 59);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
            // 
            // rbDemo
            // 
            this.rbDemo.AutoSize = true;
            this.rbDemo.Location = new System.Drawing.Point(6, 39);
            this.rbDemo.Name = "rbDemo";
            this.rbDemo.Size = new System.Drawing.Size(53, 17);
            this.rbDemo.TabIndex = 11;
            this.rbDemo.Text = "Demo";
            this.rbDemo.UseVisualStyleBackColor = true;
            // 
            // rbReal
            // 
            this.rbReal.AutoSize = true;
            this.rbReal.Checked = true;
            this.rbReal.Location = new System.Drawing.Point(6, 20);
            this.rbReal.Name = "rbReal";
            this.rbReal.Size = new System.Drawing.Size(47, 17);
            this.rbReal.TabIndex = 10;
            this.rbReal.TabStop = true;
            this.rbReal.Text = "Real";
            this.rbReal.UseVisualStyleBackColor = true;
            this.rbReal.CheckedChanged += new System.EventHandler(this.Real_CheckedChanged);
            // 
            // lbMarketSelect
            // 
            this.lbMarketSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMarketSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMarketSelect.Location = new System.Drawing.Point(0, 155);
            this.lbMarketSelect.Name = "lbMarketSelect";
            this.lbMarketSelect.Size = new System.Drawing.Size(800, 13);
            this.lbMarketSelect.TabIndex = 2;
            this.lbMarketSelect.Text = "no market selected";
            this.lbMarketSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bMessages);
            this.groupBox2.Controls.Add(this.bDeals);
            this.groupBox2.Controls.Add(this.bOpenOrders);
            this.groupBox2.Controls.Add(this.bBalances);
            this.groupBox2.Controls.Add(this.bAPIKeys);
            this.groupBox2.Controls.Add(this.tbKeyStatus);
            this.groupBox2.Controls.Add(this.lbKeysTime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbMarkets);
            this.groupBox2.Location = new System.Drawing.Point(80, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 140);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Params";
            // 
            // bMessages
            // 
            this.bMessages.Location = new System.Drawing.Point(47, 81);
            this.bMessages.Name = "bMessages";
            this.bMessages.Size = new System.Drawing.Size(75, 23);
            this.bMessages.TabIndex = 15;
            this.bMessages.Text = "Messages";
            this.bMessages.UseVisualStyleBackColor = true;
            this.bMessages.Click += new System.EventHandler(this.Messages_Click);
            // 
            // bDeals
            // 
            this.bDeals.Location = new System.Drawing.Point(87, 52);
            this.bDeals.Name = "bDeals";
            this.bDeals.Size = new System.Drawing.Size(75, 23);
            this.bDeals.TabIndex = 14;
            this.bDeals.Text = "Deals";
            this.bDeals.UseVisualStyleBackColor = true;
            this.bDeals.Click += new System.EventHandler(this.Deals_Click);
            // 
            // bOpenOrders
            // 
            this.bOpenOrders.Location = new System.Drawing.Point(87, 23);
            this.bOpenOrders.Name = "bOpenOrders";
            this.bOpenOrders.Size = new System.Drawing.Size(75, 23);
            this.bOpenOrders.TabIndex = 13;
            this.bOpenOrders.Text = "Open Orders";
            this.bOpenOrders.UseVisualStyleBackColor = true;
            this.bOpenOrders.Click += new System.EventHandler(this.OpenOrders_Click);
            // 
            // bBalances
            // 
            this.bBalances.Location = new System.Drawing.Point(6, 52);
            this.bBalances.Name = "bBalances";
            this.bBalances.Size = new System.Drawing.Size(75, 23);
            this.bBalances.TabIndex = 12;
            this.bBalances.Text = "Balances";
            this.bBalances.UseVisualStyleBackColor = true;
            this.bBalances.Click += new System.EventHandler(this.Balances_Click);
            // 
            // bAPIKeys
            // 
            this.bAPIKeys.Location = new System.Drawing.Point(6, 23);
            this.bAPIKeys.Name = "bAPIKeys";
            this.bAPIKeys.Size = new System.Drawing.Size(75, 23);
            this.bAPIKeys.TabIndex = 11;
            this.bAPIKeys.Text = "API Keys";
            this.bAPIKeys.UseVisualStyleBackColor = true;
            this.bAPIKeys.Click += new System.EventHandler(this.APIKeys_Click);
            // 
            // tbKeyStatus
            // 
            this.tbKeyStatus.Location = new System.Drawing.Point(449, 39);
            this.tbKeyStatus.Multiline = true;
            this.tbKeyStatus.Name = "tbKeyStatus";
            this.tbKeyStatus.ReadOnly = true;
            this.tbKeyStatus.Size = new System.Drawing.Size(123, 82);
            this.tbKeyStatus.TabIndex = 10;
            // 
            // lbKeysTime
            // 
            this.lbKeysTime.Location = new System.Drawing.Point(318, 124);
            this.lbKeysTime.Name = "lbKeysTime";
            this.lbKeysTime.Size = new System.Drawing.Size(125, 13);
            this.lbKeysTime.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Markets";
            // 
            // lbMarkets
            // 
            this.lbMarkets.FormattingEnabled = true;
            this.lbMarkets.Location = new System.Drawing.Point(318, 39);
            this.lbMarkets.Name = "lbMarkets";
            this.lbMarkets.Size = new System.Drawing.Size(125, 82);
            this.lbMarkets.Sorted = true;
            this.lbMarkets.TabIndex = 4;
            this.lbMarkets.SelectedValueChanged += new System.EventHandler(this.Markets_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 282);
            this.panel2.TabIndex = 1;
            // 
            // UserAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserAPI";
            this.Text = "Test User API";
            this.tabControl1.ResumeLayout(false);
            this.tabBalance.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBalanceTotal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBalanceAvailable)).EndInit();
            this.tabOrders.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.panel7.ResumeLayout(false);
            this.tabDeals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDeals)).EndInit();
            this.tabMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMessages)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBalance;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabDeals;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbMarkets;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbOrders;
        private System.Windows.Forms.Label lbDeals;
        private System.Windows.Forms.Label lbKeysTime;
        private System.Windows.Forms.TextBox tbKeyStatus;
        private System.Windows.Forms.Label lbMarketSelect;
        private System.Windows.Forms.DataGridView dgBalanceAvailable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbBalanceTotal;
        private System.Windows.Forms.DataGridView dgBalanceTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbBalanceAvailable;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bPlace;
        private System.Windows.Forms.DataGridView dgDeals;
        private System.Windows.Forms.Button bMove;
        private System.Windows.Forms.Button bGetBalance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDemo;
        private System.Windows.Forms.RadioButton rbReal;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.DataGridView dgMessages;
        private System.Windows.Forms.Label lbMessages;
        private System.Windows.Forms.Button bAPIKeys;
        private System.Windows.Forms.Button bBalances;
        private System.Windows.Forms.Button bOpenOrders;
        private System.Windows.Forms.Button bDeals;
        private System.Windows.Forms.Button bMessages;
    }
}