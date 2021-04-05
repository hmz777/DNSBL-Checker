
namespace DNSBLChecker.Forms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.IPLabel = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.Loader = new System.Windows.Forms.PictureBox();
            this.CurrentIPCheck = new System.Windows.Forms.CheckBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.AboutBtn = new System.Windows.Forms.Button();
            this.IPBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).BeginInit();
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(12, 89);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(64, 15);
            this.IPLabel.TabIndex = 1;
            this.IPLabel.Text = "IP/Domain";
            this.Tooltip.SetToolTip(this.IPLabel, "Enter a valid IP address.\r\ne.g. 94.47.64.203");
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(12, 130);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.PlaceholderText = "Result";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(404, 266);
            this.ResultBox.TabIndex = 2;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(341, 415);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.Tooltip.SetToolTip(this.StartBtn, "Start the checking operation.");
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(12, 415);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.Tooltip.SetToolTip(this.CloseBtn, "Close the app.");
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(260, 415);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Load";
            this.Tooltip.SetToolTip(this.LoadBtn, "Load the dns black list.");
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Loader
            // 
            this.Loader.Image = ((System.Drawing.Image)(resources.GetObject("Loader.Image")));
            this.Loader.Location = new System.Drawing.Point(381, 12);
            this.Loader.Name = "Loader";
            this.Loader.Size = new System.Drawing.Size(35, 35);
            this.Loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loader.TabIndex = 6;
            this.Loader.TabStop = false;
            this.Tooltip.SetToolTip(this.Loader, "An operation is in progress.");
            this.Loader.Visible = false;
            // 
            // CurrentIPCheck
            // 
            this.CurrentIPCheck.AutoSize = true;
            this.CurrentIPCheck.Location = new System.Drawing.Point(337, 88);
            this.CurrentIPCheck.Name = "CurrentIPCheck";
            this.CurrentIPCheck.Size = new System.Drawing.Size(79, 19);
            this.CurrentIPCheck.TabIndex = 8;
            this.CurrentIPCheck.Text = "Current IP";
            this.Tooltip.SetToolTip(this.CurrentIPCheck, "Capture my current IP automatically.");
            this.CurrentIPCheck.UseVisualStyleBackColor = true;
            this.CurrentIPCheck.CheckedChanged += new System.EventHandler(this.CurrentIPCheck_CheckedChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(224, 415);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(30, 23);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "C";
            this.Tooltip.SetToolTip(this.ClearBtn, "Clear the result box.");
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Tooltip
            // 
            this.Tooltip.IsBalloon = true;
            this.Tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Tooltip.ToolTipTitle = "Info";
            // 
            // AboutBtn
            // 
            this.AboutBtn.Location = new System.Drawing.Point(93, 415);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(30, 23);
            this.AboutBtn.TabIndex = 11;
            this.AboutBtn.Text = "?";
            this.Tooltip.SetToolTip(this.AboutBtn, "About the developer.");
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(82, 86);
            this.IPBox.Name = "IPBox";
            this.IPBox.PlaceholderText = "IP Address";
            this.IPBox.Size = new System.Drawing.Size(248, 23);
            this.IPBox.TabIndex = 10;
            // 
            // Main
            // 
            this.AcceptButton = this.StartBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CurrentIPCheck);
            this.Controls.Add(this.Loader);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.IPLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DNSBL Checker";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.PictureBox Loader;
        public System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.CheckBox CurrentIPCheck;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Button AboutBtn;
    }
}

