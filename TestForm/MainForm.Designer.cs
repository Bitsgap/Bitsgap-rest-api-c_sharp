namespace TestForm
{
    partial class MainForm
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
            this.rtLog = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bUserAPI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrivate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPublic = new System.Windows.Forms.TextBox();
            this.bPublicAPI = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtLog
            // 
            this.rtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtLog.Location = new System.Drawing.Point(0, 101);
            this.rtLog.Name = "rtLog";
            this.rtLog.Size = new System.Drawing.Size(800, 349);
            this.rtLog.TabIndex = 5;
            this.rtLog.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bUserAPI);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.bPublicAPI);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 101);
            this.panel1.TabIndex = 6;
            // 
            // bUserAPI
            // 
            this.bUserAPI.Location = new System.Drawing.Point(213, 58);
            this.bUserAPI.Name = "bUserAPI";
            this.bUserAPI.Size = new System.Drawing.Size(106, 23);
            this.bUserAPI.TabIndex = 4;
            this.bUserAPI.Text = "Test user API";
            this.bUserAPI.UseVisualStyleBackColor = true;
            this.bUserAPI.Click += new System.EventHandler(this.UserAPI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPrivate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPublic);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Private API key";
            // 
            // tbPrivate
            // 
            this.tbPrivate.Location = new System.Drawing.Point(6, 48);
            this.tbPrivate.Name = "tbPrivate";
            this.tbPrivate.Size = new System.Drawing.Size(100, 20);
            this.tbPrivate.TabIndex = 4;
            this.tbPrivate.Leave += new System.EventHandler(this.Key_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Public API key";
            // 
            // tbPublic
            // 
            this.tbPublic.Location = new System.Drawing.Point(6, 21);
            this.tbPublic.Name = "tbPublic";
            this.tbPublic.Size = new System.Drawing.Size(100, 20);
            this.tbPublic.TabIndex = 3;
            this.tbPublic.Leave += new System.EventHandler(this.Key_Leave);
            // 
            // bPublicAPI
            // 
            this.bPublicAPI.Location = new System.Drawing.Point(213, 26);
            this.bPublicAPI.Name = "bPublicAPI";
            this.bPublicAPI.Size = new System.Drawing.Size(106, 23);
            this.bPublicAPI.TabIndex = 3;
            this.bPublicAPI.Text = "Test public API";
            this.bPublicAPI.UseVisualStyleBackColor = true;
            this.bPublicAPI.Click += new System.EventHandler(this.PublicAPI_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtLog);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Bitsgap Test Rest API";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bUserAPI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrivate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPublic;
        private System.Windows.Forms.Button bPublicAPI;
    }
}

