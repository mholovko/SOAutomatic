namespace SOAutomatic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AzimuthDrawPanel = new System.Windows.Forms.Panel();
            this.ElevationDrawPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AzimuthTextBox = new System.Windows.Forms.TextBox();
            this.ElevationTextBox = new System.Windows.Forms.TextBox();
            this.DateTimeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            this.DateTimeUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SPort = new System.IO.Ports.SerialPort(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.CurrentElevationTextBox = new System.Windows.Forms.TextBox();
            this.CurrentAzimuthTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RotateTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeLeftTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsoleStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GCTimer = new System.Windows.Forms.Timer(this.components);
            this.ErrorEmailSendTimer = new System.Windows.Forms.Timer(this.components);
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AzimuthDrawPanel
            // 
            this.AzimuthDrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AzimuthDrawPanel.Location = new System.Drawing.Point(8, 79);
            this.AzimuthDrawPanel.Name = "AzimuthDrawPanel";
            this.AzimuthDrawPanel.Size = new System.Drawing.Size(252, 252);
            this.AzimuthDrawPanel.TabIndex = 0;
            // 
            // ElevationDrawPanel
            // 
            this.ElevationDrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ElevationDrawPanel.Location = new System.Drawing.Point(266, 79);
            this.ElevationDrawPanel.Name = "ElevationDrawPanel";
            this.ElevationDrawPanel.Size = new System.Drawing.Size(252, 252);
            this.ElevationDrawPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(101, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Азимут";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(354, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Элевация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Азимут:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Элевация:";
            // 
            // AzimuthTextBox
            // 
            this.AzimuthTextBox.Location = new System.Drawing.Point(55, 363);
            this.AzimuthTextBox.Name = "AzimuthTextBox";
            this.AzimuthTextBox.Size = new System.Drawing.Size(57, 20);
            this.AzimuthTextBox.TabIndex = 9;
            // 
            // ElevationTextBox
            // 
            this.ElevationTextBox.Location = new System.Drawing.Point(192, 363);
            this.ElevationTextBox.Name = "ElevationTextBox";
            this.ElevationTextBox.Size = new System.Drawing.Size(57, 20);
            this.ElevationTextBox.TabIndex = 10;
            // 
            // DateTimeTextBox
            // 
            this.DateTimeTextBox.Location = new System.Drawing.Point(344, 363);
            this.DateTimeTextBox.Name = "DateTimeTextBox";
            this.DateTimeTextBox.Size = new System.Drawing.Size(170, 20);
            this.DateTimeTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата и время:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Статус:";
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.ForeColor = System.Drawing.Color.DarkRed;
            this.StatusText.Location = new System.Drawing.Point(52, 35);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(134, 13);
            this.StatusText.TabIndex = 15;
            this.StatusText.Text = "Программа остановлена";
            // 
            // DateTimeUpdateTimer
            // 
            this.DateTimeUpdateTimer.Interval = 1000;
            this.DateTimeUpdateTimer.Tick += new System.EventHandler(this.DateTimeUpdateTimer_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(8, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Алгоритмические данные:";
            // 
            // CurrentElevationTextBox
            // 
            this.CurrentElevationTextBox.Location = new System.Drawing.Point(457, 391);
            this.CurrentElevationTextBox.Name = "CurrentElevationTextBox";
            this.CurrentElevationTextBox.Size = new System.Drawing.Size(57, 20);
            this.CurrentElevationTextBox.TabIndex = 20;
            // 
            // CurrentAzimuthTextBox
            // 
            this.CurrentAzimuthTextBox.Location = new System.Drawing.Point(310, 391);
            this.CurrentAzimuthTextBox.Name = "CurrentAzimuthTextBox";
            this.CurrentAzimuthTextBox.Size = new System.Drawing.Size(57, 20);
            this.CurrentAzimuthTextBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Элевация:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Азимут:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(263, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Текущие данные:";
            // 
            // RotateTimer
            // 
            this.RotateTimer.Tick += new System.EventHandler(this.RotateTimer_Tick);
            // 
            // TimeLeftTextBox
            // 
            this.TimeLeftTextBox.Location = new System.Drawing.Point(155, 391);
            this.TimeLeftTextBox.Name = "TimeLeftTextBox";
            this.TimeLeftTextBox.Size = new System.Drawing.Size(94, 20);
            this.TimeLeftTextBox.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(8, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "До следующего поворота:";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.PropertiesToolStripMenuItem,
            this.ConsoleStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(526, 24);
            this.MainMenuStrip.TabIndex = 24;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.StartToolStripMenuItem.Text = "Пуск";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // PropertiesToolStripMenuItem
            // 
            this.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem";
            this.PropertiesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.PropertiesToolStripMenuItem.Text = "Настройки";
            this.PropertiesToolStripMenuItem.Click += new System.EventHandler(this.PropertiesToolStrip_Click);
            // 
            // ConsoleStripMenuItem
            // 
            this.ConsoleStripMenuItem.Name = "ConsoleStripMenuItem";
            this.ConsoleStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ConsoleStripMenuItem.Text = "Консоль";
            this.ConsoleStripMenuItem.Click += new System.EventHandler(this.ConsoleToolStripMenuItem_Click);
            // 
            // GCTimer
            // 
            this.GCTimer.Interval = 60000;
            this.GCTimer.Tick += new System.EventHandler(this.GCTimer_Tick);
            // 
            // ErrorEmailSendTimer
            // 
            this.ErrorEmailSendTimer.Tick += new System.EventHandler(this.ErrorEmailSendTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(526, 420);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TimeLeftTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CurrentElevationTextBox);
            this.Controls.Add(this.CurrentAzimuthTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateTimeTextBox);
            this.Controls.Add(this.ElevationTextBox);
            this.Controls.Add(this.AzimuthTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ElevationDrawPanel);
            this.Controls.Add(this.AzimuthDrawPanel);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AzimuthDrawPanel;
        private System.Windows.Forms.Panel ElevationDrawPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AzimuthTextBox;
        private System.Windows.Forms.TextBox ElevationTextBox;
        private System.Windows.Forms.TextBox DateTimeTextBox;
        private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.MenuStrip MainMenuStrip;
        //private System.Windows.Forms.ToolStripMenuItem StartToolStrip;
        //private System.Windows.Forms.ToolStripMenuItem PropertiesToolStrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Timer DateTimeUpdateTimer;
        private System.IO.Ports.SerialPort SPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CurrentElevationTextBox;
        private System.Windows.Forms.TextBox CurrentAzimuthTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        //private System.Windows.Forms.ToolStripMenuItem консольToolStripMenuItem;
        private System.Windows.Forms.Timer RotateTimer;
        private System.Windows.Forms.TextBox TimeLeftTextBox;
        private System.Windows.Forms.Label label11;
        //private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsoleStripMenuItem;
        private System.Windows.Forms.Timer GCTimer;
        private System.Windows.Forms.Timer ErrorEmailSendTimer;
    }
}

