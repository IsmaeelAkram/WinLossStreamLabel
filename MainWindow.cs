using System;
using System.Windows.Forms;
using System.IO;

namespace WinLossStreamLabel
{
    public partial class MainWindow : Form
    {
        public string WinFormat = "Wins: {Count}";
        public string LossFormat = "Losses: {Count}";

        public MainWindow()
        {
            InitializeComponent();
            if (!File.Exists("wincount.txt"))
            {
                File.WriteAllText("wincount.txt", "0");
            }
            if (!File.Exists("wins.txt"))
            {
                File.WriteAllText("wins.txt", WinFormat.Replace("{Count}", "0"));
            }
            if (!File.Exists("winformat.txt"))
            {
                File.WriteAllText("winformat.txt", WinFormat);
            }

            if (!File.Exists("losscount.txt"))
            {
                File.WriteAllText("losscount.txt", "0");
            }
            if (!File.Exists("losses.txt"))
            {
                File.WriteAllText("losses.txt", LossFormat.Replace("{Count}", "0"));
            }
            if (!File.Exists("lossformat.txt"))
            {
                File.WriteAllText("lossformat.txt", LossFormat);
            }
        }

        private void IncrementCount(string RawFileName, string FormattedFileName, string Format)
        {
            int IncrementedCount = int.Parse(File.ReadAllText(RawFileName)) + 1;
            File.WriteAllText(RawFileName, IncrementedCount.ToString());
            File.WriteAllText(FormattedFileName, GetFormattedString(IncrementedCount, Format));
        }

        private void DecrementCount(string RawFileName, string FormattedFileName, string Format)
        {
            int DecrementedCount = int.Parse(File.ReadAllText(RawFileName)) - 1;
            File.WriteAllText(RawFileName, DecrementedCount.ToString());
            File.WriteAllText(FormattedFileName, GetFormattedString(DecrementedCount, Format));
        }

        private int GetWinCount()
        {
            return int.Parse(File.ReadAllText("wincount.txt"));
        }

        private int GetLossCount()
        {
            return int.Parse(File.ReadAllText("losscount.txt"));
        }

        private string GetFormattedString(int Count, string Format)
        {
            return Format.Replace("{Count}", Count.ToString());
        }

        private void WinIncrement_Click(object sender, EventArgs e)
        {
            IncrementCount("wincount.txt", "wins.txt", WinFormat);
            WinPreviewText.Text = GetFormattedString(GetWinCount(), WinFormat);
            WinCurrentCount.Text = "Current Count: " + GetWinCount().ToString();
        }

        private void WinDecrement_Click(object sender, EventArgs e)
        {
            DecrementCount("wincount.txt", "wins.txt", WinFormat);
            WinPreviewText.Text = GetFormattedString(GetWinCount(), WinFormat);
            WinCurrentCount.Text = "Current Count: " + GetWinCount().ToString();
        }

        private void LossIncrement_Click(object sender, EventArgs e)
        {
            IncrementCount("losscount.txt", "losses.txt", LossFormat);
            LossPreviewText.Text = GetFormattedString(GetLossCount(), LossFormat);
            LossCurrentCount.Text = "Current Count: " + GetLossCount().ToString();
        }

        private void LossDecrement_Click(object sender, EventArgs e)
        {
            DecrementCount("losscount.txt", "losses.txt", LossFormat);
            LossPreviewText.Text = GetFormattedString(GetLossCount(), LossFormat);
            LossCurrentCount.Text = "Current Count: " + GetLossCount().ToString();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            WinFormatTextBox.Text = WinFormat;
            WinPreviewText.Text = GetFormattedString(GetWinCount(), WinFormat);
            WinCurrentCount.Text = "Current Count: " + GetWinCount().ToString();

            LossFormatTextBox.Text = LossFormat;
            LossPreviewText.Text = GetFormattedString(GetLossCount(), LossFormat);
            LossCurrentCount.Text = "Current Count: " + GetLossCount().ToString();
        }

        private void WinFormatTextBox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("winformat.txt", WinFormatTextBox.Text);
            WinFormat = WinFormatTextBox.Text;
        }

        private void LossFormatTextBox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("lossformat.txt", LossFormatTextBox.Text);
            LossFormat = LossFormatTextBox.Text;
        }
    }
}
