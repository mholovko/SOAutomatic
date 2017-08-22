using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SOAutomatic
{
    public partial class ConsoleForm : Form
    {
        public string ConsoleBoxValue
        {
            get { return ConsoleBox.Text; }
        }

        public ConsoleForm()
        {
            InitializeComponent();
        }

        public void WriteConsoleBox(string input, Color color)
        {
            if (this.Visible)
            {
                if (ConsoleBox.Text.Length > 50000)
                {
                    if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\log\"))
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\log\");
                    using (StreamWriter outputFile = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"log\" + $"{Program.MainForm.LogDateTimeStart.ToString("yy.MM.dd HH-mm-ss")} - {DateTime.Now.ToString("yy.MM.dd HH-mm-ss")}" + ".txt"))
                    {
                        foreach (string line in ConsoleBox.Text.Split('\n'))
                            outputFile.WriteLine(line);
                        outputFile.Dispose();
                    }
                    Program.MainForm.LogDateTimeStart = DateTime.Now;
                    ConsoleBox.Text = string.Empty;
                }
                ConsoleBox.SelectionStart = ConsoleBox.TextLength;
                ConsoleBox.SelectionLength = 0;

                ConsoleBox.SelectionColor = Color.FromArgb(133, 133, 133);
                ConsoleBox.AppendText(string.Format("[{0}] ", DateTime.Now));
                ConsoleBox.SelectionColor = ConsoleBox.ForeColor;

                ConsoleBox.SelectionColor = color;
                ConsoleBox.AppendText(input + "\r\n");
                ConsoleBox.SelectionColor = ConsoleBox.ForeColor;

                ConsoleBox.SelectionStart = ConsoleBox.TextLength;
                ConsoleBox.ScrollToCaret();

                input = string.Empty;
            }
        }

        private void ConsoleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
