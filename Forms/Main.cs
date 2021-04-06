using DNSBLChecker.Checker;
using DNSBLChecker.Helpers;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNSBLChecker.Forms
{
    public partial class Main : Form
    {
        private static CancellationTokenSource CancellationTokenSource;
        private static bool OperationStarted;

        public Main()
        {
            InitializeComponent();
        }

        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            string Path;
            using (OpenFileDialog FileDialog = new OpenFileDialog()
            {
                AddExtension = true,
                CheckFileExists = true,
                Filter = "txt files (*.txt)|*.txt",
                Multiselect = false,
                Title = "Select DNSBL urls"
            })
            {
                if (FileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                Path = FileDialog.FileName;
            }

            try
            {
                var No_Urls = await IPChecker.LoadUrlsAsync(Path);

                ResultBox.Text += $"{DateTime.Now.ToLongTimeString()} - Loaded {No_Urls} urls.{Environment.NewLine}";
            }
            catch
            {
                MessageBox.Show("Invalid file.");
            }
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            if (OperationStarted)
            {
                CancellationTokenSource.Cancel();
                return;
            }
            else
            {
                CancellationTokenSource = new CancellationTokenSource();
            }

            if (string.IsNullOrWhiteSpace(IPBox.Text) || !IPAddress.TryParse(IPBox.Text, out _) || !IPChecker.AreUrlsLoaded())
            {
                MessageBox.Show("Make sure to load the DNSBL urls and enter a valid IP.", "Invalid IP or DNSBL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationStarted = true;
            ClearBtn.Enabled = false;
            LoadBtn.Enabled = false;
            CurrentIPCheck.Enabled = false;
            StartBtn.Text = "Stop";
            Tooltip.SetToolTip(StartBtn, "Stop the ongoing check operation.");

            ToggleLoader();

            try
            {
                await StartOperationAsync(IPBox.Text, CancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                ResultBox.Text += $"{DateTime.Now.ToLongTimeString()} - Operation cancelled!{Environment.NewLine}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}");
            }

            OperationStarted = false;
            StartBtn.Text = "Start";
            Tooltip.SetToolTip(StartBtn, "Start the checking operation.");
            ClearBtn.Enabled = true;
            LoadBtn.Enabled = true;
            CurrentIPCheck.Enabled = true;

            ToggleLoader();
        }

        private async Task StartOperationAsync(string IP, CancellationToken CancellationToken = default)
        {
            int Counter = 0;

            await foreach (var Result in IPChecker.CheckIPAsync(Tools.ReverseIP(IP), CancellationToken))
            {
                if (Tools.IsIPOk(Result.Value))
                {
                    if (ResultBox.InvokeRequired)
                    {
                        ResultBox.BeginInvoke(new Action(() => { ResultBox.Text += $"{Counter} - {DateTime.Now.ToLongTimeString()} - {Result.Key} >>> OK!{Environment.NewLine}"; }));
                    }
                    else
                    {
                        ResultBox.Text += $"{Counter} - {DateTime.Now.ToLongTimeString()} - {Result.Key} >>> OK!{Environment.NewLine}";
                    }
                }
                else
                {
                    if (ResultBox.InvokeRequired)
                    {
                        ResultBox.BeginInvoke(new Action(() => { ResultBox.Text += $"{Counter} - {DateTime.Now.ToLongTimeString()} - {Result.Key} >>> BLOCKED!{Environment.NewLine}"; }));
                    }
                    else
                    {
                        ResultBox.Text += $"{Counter} - {DateTime.Now.ToLongTimeString()} - {Result.Key} >>> BLOCKED!{Environment.NewLine}";
                    }
                }

                Counter++;
            }

            ResultBox.Text += $"{DateTime.Now.ToLongTimeString()} - Finished!{Environment.NewLine}";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            IPBox.Select();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (OperationStarted)
            {
                CancellationTokenSource.Cancel();
            }

            ReleaseResources();
            Application.Exit();
        }

        private void ToggleInterface()
        {
            StartBtn.Enabled = !StartBtn.Enabled;
            LoadBtn.Enabled = !LoadBtn.Enabled;
            CurrentIPCheck.Enabled = !CurrentIPCheck.Enabled;
        }

        private void ReleaseResources()
        {
            CancellationTokenSource.Dispose();
            Tools.Dispose();
        }

        private async void CurrentIPCheck_CheckedChanged(object sender, EventArgs e)
        {
            ToggleLoader();

            if (CurrentIPCheck.Checked)
            {
                IPBox.Enabled = false;
                ToggleInterface();
                IPBox.Text = await Tools.GetCurrentIPAsync();
                ToggleInterface();
            }
            else
            {
                IPBox.Enabled = true;
                IPBox.Clear();
            }

            ToggleLoader();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Clear();
        }

        private void ToggleLoader()
        {
            Loader.Visible = !Loader.Visible;
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
