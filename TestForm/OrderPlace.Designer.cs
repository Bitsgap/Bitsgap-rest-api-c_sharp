namespace TestForm
{
    partial class OrderPlace
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPair = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbBuy = new System.Windows.Forms.RadioButton();
            this.rbSell = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbLimit = new System.Windows.Forms.RadioButton();
            this.rbMarket = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.bOk = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGUID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market";
            // 
            // tbMarket
            // 
            this.tbMarket.Enabled = false;
            this.tbMarket.Location = new System.Drawing.Point(58, 6);
            this.tbMarket.Name = "tbMarket";
            this.tbMarket.Size = new System.Drawing.Size(128, 20);
            this.tbMarket.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pair";
            // 
            // cbPair
            // 
            this.cbPair.FormattingEnabled = true;
            this.cbPair.Location = new System.Drawing.Point(58, 32);
            this.cbPair.Name = "cbPair";
            this.cbPair.Size = new System.Drawing.Size(128, 21);
            this.cbPair.Sorted = true;
            this.cbPair.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Side";
            // 
            // rbBuy
            // 
            this.rbBuy.AutoSize = true;
            this.rbBuy.Checked = true;
            this.rbBuy.Location = new System.Drawing.Point(3, 3);
            this.rbBuy.Name = "rbBuy";
            this.rbBuy.Size = new System.Drawing.Size(42, 17);
            this.rbBuy.TabIndex = 3;
            this.rbBuy.TabStop = true;
            this.rbBuy.Text = "buy";
            this.rbBuy.UseVisualStyleBackColor = true;
            // 
            // rbSell
            // 
            this.rbSell.AutoSize = true;
            this.rbSell.Location = new System.Drawing.Point(51, 3);
            this.rbSell.Name = "rbSell";
            this.rbSell.Size = new System.Drawing.Size(40, 17);
            this.rbSell.TabIndex = 4;
            this.rbSell.Text = "sell";
            this.rbSell.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbBuy);
            this.panel1.Controls.Add(this.rbSell);
            this.panel1.Location = new System.Drawing.Point(58, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 23);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbLimit);
            this.panel2.Controls.Add(this.rbMarket);
            this.panel2.Location = new System.Drawing.Point(58, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 23);
            this.panel2.TabIndex = 4;
            // 
            // rbLimit
            // 
            this.rbLimit.AutoSize = true;
            this.rbLimit.Checked = true;
            this.rbLimit.Location = new System.Drawing.Point(3, 3);
            this.rbLimit.Name = "rbLimit";
            this.rbLimit.Size = new System.Drawing.Size(42, 17);
            this.rbLimit.TabIndex = 5;
            this.rbLimit.TabStop = true;
            this.rbLimit.Text = "limit";
            this.rbLimit.UseVisualStyleBackColor = true;
            // 
            // rbMarket
            // 
            this.rbMarket.AutoSize = true;
            this.rbMarket.Location = new System.Drawing.Point(51, 3);
            this.rbMarket.Name = "rbMarket";
            this.rbMarket.Size = new System.Drawing.Size(57, 17);
            this.rbMarket.TabIndex = 6;
            this.rbMarket.Text = "market";
            this.rbMarket.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(58, 118);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(128, 20);
            this.tbAmount.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(58, 145);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(128, 20);
            this.tbPrice.TabIndex = 8;
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(74, 204);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 10;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.Ok_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "GUID";
            // 
            // tbGUID
            // 
            this.tbGUID.Location = new System.Drawing.Point(58, 171);
            this.tbGUID.Name = "tbGUID";
            this.tbGUID.Size = new System.Drawing.Size(128, 20);
            this.tbGUID.TabIndex = 9;
            // 
            // OrderPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 239);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbPair);
            this.Controls.Add(this.tbGUID);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMarket);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderPlace";
            this.Text = "Place";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMarket;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbPair;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton rbBuy;
        private System.Windows.Forms.RadioButton rbSell;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton rbLimit;
        private System.Windows.Forms.RadioButton rbMarket;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbGUID;
    }
}