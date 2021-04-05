using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace DNSBLChecker.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://github.com/hmz777", UseShellExecute = true });
        }

        private void DnsClientLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://github.com/MichaCo/DnsClient.NET", UseShellExecute = true });
        }

        private void About_Load(object sender, EventArgs e)
        {
            VersionValue.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            DateValue.Text = File.GetCreationTimeUtc(Assembly.GetExecutingAssembly().Location).ToString();
        }
    }
}
