
namespace DNSBLChecker.Forms
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AuthorValue = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.LibrariesBox = new System.Windows.Forms.GroupBox();
            this.DnsClientValue = new System.Windows.Forms.LinkLabel();
            this.DnsClientLabel = new System.Windows.Forms.Label();
            this.GitHubValue = new System.Windows.Forms.LinkLabel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionValue = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateValue = new System.Windows.Forms.Label();
            this.LibrariesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 22);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(82, 15);
            this.AuthorLabel.TabIndex = 0;
            this.AuthorLabel.Text = "Developed by:";
            // 
            // AuthorValue
            // 
            this.AuthorValue.AutoSize = true;
            this.AuthorValue.Location = new System.Drawing.Point(101, 22);
            this.AuthorValue.Name = "AuthorValue";
            this.AuthorValue.Size = new System.Drawing.Size(89, 15);
            this.AuthorValue.TabIndex = 1;
            this.AuthorValue.Text = "Hamzi Alsheikh";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Location = new System.Drawing.Point(12, 54);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(46, 15);
            this.GithubLabel.TabIndex = 2;
            this.GithubLabel.Text = "Github:";
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.Location = new System.Drawing.Point(282, 267);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // LibrariesBox
            // 
            this.LibrariesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibrariesBox.Controls.Add(this.DnsClientValue);
            this.LibrariesBox.Controls.Add(this.DnsClientLabel);
            this.LibrariesBox.Location = new System.Drawing.Point(12, 159);
            this.LibrariesBox.Name = "LibrariesBox";
            this.LibrariesBox.Size = new System.Drawing.Size(345, 91);
            this.LibrariesBox.TabIndex = 5;
            this.LibrariesBox.TabStop = false;
            this.LibrariesBox.Text = "External Libraries";
            // 
            // DnsClientValue
            // 
            this.DnsClientValue.AutoSize = true;
            this.DnsClientValue.Location = new System.Drawing.Point(94, 36);
            this.DnsClientValue.Name = "DnsClientValue";
            this.DnsClientValue.Size = new System.Drawing.Size(242, 15);
            this.DnsClientValue.TabIndex = 1;
            this.DnsClientValue.TabStop = true;
            this.DnsClientValue.Text = "https://github.com/MichaCo/DnsClient.NET";
            this.DnsClientValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DnsClientLink_LinkClicked);
            // 
            // DnsClientLabel
            // 
            this.DnsClientLabel.AutoSize = true;
            this.DnsClientLabel.Location = new System.Drawing.Point(6, 36);
            this.DnsClientLabel.Name = "DnsClientLabel";
            this.DnsClientLabel.Size = new System.Drawing.Size(85, 15);
            this.DnsClientLabel.TabIndex = 0;
            this.DnsClientLabel.Text = "DnsClient.NET:";
            // 
            // GitHubValue
            // 
            this.GitHubValue.AutoSize = true;
            this.GitHubValue.Location = new System.Drawing.Point(101, 54);
            this.GitHubValue.Name = "GitHubValue";
            this.GitHubValue.Size = new System.Drawing.Size(155, 15);
            this.GitHubValue.TabIndex = 7;
            this.GitHubValue.TabStop = true;
            this.GitHubValue.Text = "https://github.com/hmz777";
            this.GitHubValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLink_LinkClicked);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(12, 86);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(48, 15);
            this.VersionLabel.TabIndex = 8;
            this.VersionLabel.Text = "Version:";
            // 
            // VersionValue
            // 
            this.VersionValue.AutoSize = true;
            this.VersionValue.Location = new System.Drawing.Point(101, 86);
            this.VersionValue.Name = "VersionValue";
            this.VersionValue.Size = new System.Drawing.Size(13, 15);
            this.VersionValue.TabIndex = 9;
            this.VersionValue.Text = "x";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(12, 118);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(63, 15);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Build date:";
            // 
            // DateValue
            // 
            this.DateValue.AutoSize = true;
            this.DateValue.Location = new System.Drawing.Point(101, 118);
            this.DateValue.Name = "DateValue";
            this.DateValue.Size = new System.Drawing.Size(13, 15);
            this.DateValue.TabIndex = 11;
            this.DateValue.Text = "x";
            // 
            // About
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 302);
            this.Controls.Add(this.DateValue);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.VersionValue);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.GitHubValue);
            this.Controls.Add(this.LibrariesBox);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.AuthorValue);
            this.Controls.Add(this.AuthorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.LibrariesBox.ResumeLayout(false);
            this.LibrariesBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label AuthorValue;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.GroupBox LibrariesBox;
        private System.Windows.Forms.Label DnsClientLabel;
        private System.Windows.Forms.LinkLabel DnsClientValue;
        private System.Windows.Forms.LinkLabel GitHubValue;
        private System.Windows.Forms.LinkLabel G;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label VersionValue;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DateValue;
    }
}