namespace SOAutomatic
{
    partial class SettingsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Общее");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Почта");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("О программе");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SettingsTimeZone = new System.Windows.Forms.ComboBox();
            this.SettingsPorts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeIntervalHours = new System.Windows.Forms.NumericUpDown();
            this.TimeIntervalMinutes = new System.Windows.Forms.NumericUpDown();
            this.TimeIntervalSeconds = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SettingsLatitude = new System.Windows.Forms.TextBox();
            this.SettingsLongitude = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SettingsDrivers = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.SettingsSeaLevelRise = new System.Windows.Forms.TextBox();
            this.SettingsPressure = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SettingsTemperature = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteAddressButton = new System.Windows.Forms.Button();
            this.AddAddressButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SettingsAddressListBox = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeIntervalHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeIntervalMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeIntervalSeconds)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(491, 320);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Применить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(572, 320);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Широта местности:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Долгота местности:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Часовой пояс:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Временная уставка:";
            // 
            // SettingsTimeZone
            // 
            this.SettingsTimeZone.FormattingEnabled = true;
            this.SettingsTimeZone.Items.AddRange(new object[] {
            "(GMT -12:00) Эниветок, Кваджалейн",
            "(GMT -11:00) Остров Мидуэй, Самоа",
            "(GMT -10:00) Гавайи",
            "(GMT -9:00) Аляска",
            "(GMT -8:00) Тихоокеанское время (США и Канада)",
            "(GMT -7:00) Горное время (США и Канада)",
            "(GMT -6:00) Центральное время (США и Канада), Мехико",
            "(GMT -5:00) Восточное время (США и Канада), Богота, Лима",
            "(GMT -4:00) Атлантическое время (Канада), Каракас, Ла-Пас",
            "(GMT -3:30) Ньюфаундленд",
            "(GMT -3:00) Бразилия, Буэнос-Айрес, Джорджтаун",
            "(GMT -2:00) Срединно-Атлантического",
            "(GMT -1:00) Азорские острова, острова Зеленого Мыса",
            "(GMT 0:00) Время Западной Европе, Лондон, Лиссабон, Касабланка",
            "(GMT +1:00) Брюссель, Копенгаген, Мадрид, Париж",
            "(GMT +2:00) Киев, Калининград, Южная Африка",
            "(GMT +3:00) Багдад, Эр-Рияд, Москва, Санкт-Петербург",
            "(GMT +3:30) Тегеран",
            "(GMT +4:00) Абу-Даби, Мускат, Баку, Тбилиси",
            "(GMT +4:30) Кабул",
            "(GMT +5:00) Екатеринбург, Исламабад, Карачи, Ташкент",
            "(GMT +5:30) Бомбей, Калькутта, Мадрас, Нью-Дели",
            "(GMT +5:45) Катманду",
            "(GMT +6:00) Алматы, Дакке, Коломбо",
            "(GMT +7:00) Бангкок, Ханой, Джакарта",
            "(GMT +8:00) Пекин, Перт, Сингапур, Гонконг",
            "(GMT +9:00) Токио, Сеул, Осака, Саппоро, Якутск",
            "(GMT +9:30) Аделаида, Дарвин",
            "(GMT +10:00) Восточная Австралия, Гуам, Владивосток",
            "(GMT +11:00) Магадан, Соломоновы острова, Новая Каледония",
            "(GMT +12:00) Окленд, Веллингтон, Фиджи, Камчатка"});
            this.SettingsTimeZone.Location = new System.Drawing.Point(114, 89);
            this.SettingsTimeZone.Name = "SettingsTimeZone";
            this.SettingsTimeZone.Size = new System.Drawing.Size(313, 21);
            this.SettingsTimeZone.TabIndex = 11;
            // 
            // SettingsPorts
            // 
            this.SettingsPorts.FormattingEnabled = true;
            this.SettingsPorts.Location = new System.Drawing.Point(114, 142);
            this.SettingsPorts.Name = "SettingsPorts";
            this.SettingsPorts.Size = new System.Drawing.Size(313, 21);
            this.SettingsPorts.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Порт:";
            // 
            // TimeIntervalHours
            // 
            this.TimeIntervalHours.Location = new System.Drawing.Point(114, 116);
            this.TimeIntervalHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.TimeIntervalHours.Name = "TimeIntervalHours";
            this.TimeIntervalHours.Size = new System.Drawing.Size(47, 20);
            this.TimeIntervalHours.TabIndex = 14;
            // 
            // TimeIntervalMinutes
            // 
            this.TimeIntervalMinutes.Location = new System.Drawing.Point(223, 116);
            this.TimeIntervalMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.TimeIntervalMinutes.Name = "TimeIntervalMinutes";
            this.TimeIntervalMinutes.Size = new System.Drawing.Size(42, 20);
            this.TimeIntervalMinutes.TabIndex = 15;
            // 
            // TimeIntervalSeconds
            // 
            this.TimeIntervalSeconds.Location = new System.Drawing.Point(328, 116);
            this.TimeIntervalSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.TimeIntervalSeconds.Name = "TimeIntervalSeconds";
            this.TimeIntervalSeconds.Size = new System.Drawing.Size(49, 20);
            this.TimeIntervalSeconds.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "часов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "минут";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "секунд";
            // 
            // SettingsLatitude
            // 
            this.SettingsLatitude.Location = new System.Drawing.Point(114, 11);
            this.SettingsLatitude.Name = "SettingsLatitude";
            this.SettingsLatitude.Size = new System.Drawing.Size(92, 20);
            this.SettingsLatitude.TabIndex = 22;
            this.SettingsLatitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsLatitude_KeyPress);
            // 
            // SettingsLongitude
            // 
            this.SettingsLongitude.Location = new System.Drawing.Point(333, 11);
            this.SettingsLongitude.Name = "SettingsLongitude";
            this.SettingsLongitude.Size = new System.Drawing.Size(92, 20);
            this.SettingsLongitude.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Драйвер трекера:";
            // 
            // SettingsDrivers
            // 
            this.SettingsDrivers.FormattingEnabled = true;
            this.SettingsDrivers.Location = new System.Drawing.Point(114, 169);
            this.SettingsDrivers.Name = "SettingsDrivers";
            this.SettingsDrivers.Size = new System.Drawing.Size(314, 21);
            this.SettingsDrivers.TabIndex = 25;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.FullRowSelect = true;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(4, 5);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Общее";
            treeNode2.Name = "Узел1";
            treeNode2.Text = "Почта";
            treeNode3.Name = "Узел3";
            treeNode3.Text = "О программе";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(185, 308);
            this.treeView1.TabIndex = 26;
            this.treeView1.TabStop = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(195, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 310);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 27;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.SettingsSeaLevelRise);
            this.tabPage1.Controls.Add(this.SettingsPressure);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.SettingsTemperature);
            this.tabPage1.Controls.Add(this.SettingsDrivers);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SettingsLongitude);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SettingsLatitude);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.SettingsTimeZone);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.SettingsPorts);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.TimeIntervalSeconds);
            this.tabPage1.Controls.Add(this.TimeIntervalHours);
            this.tabPage1.Controls.Add(this.TimeIntervalMinutes);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(448, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 26);
            this.label18.TabIndex = 31;
            this.label18.Text = "Высота над \r\nуровнем моря:";
            // 
            // SettingsSeaLevelRise
            // 
            this.SettingsSeaLevelRise.Location = new System.Drawing.Point(114, 63);
            this.SettingsSeaLevelRise.Name = "SettingsSeaLevelRise";
            this.SettingsSeaLevelRise.Size = new System.Drawing.Size(92, 20);
            this.SettingsSeaLevelRise.TabIndex = 30;
            // 
            // SettingsPressure
            // 
            this.SettingsPressure.Location = new System.Drawing.Point(333, 37);
            this.SettingsPressure.Name = "SettingsPressure";
            this.SettingsPressure.Size = new System.Drawing.Size(92, 20);
            this.SettingsPressure.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(266, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Давление:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Температура:";
            // 
            // SettingsTemperature
            // 
            this.SettingsTemperature.Location = new System.Drawing.Point(114, 37);
            this.SettingsTemperature.Name = "SettingsTemperature";
            this.SettingsTemperature.Size = new System.Drawing.Size(92, 20);
            this.SettingsTemperature.TabIndex = 26;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.DeleteAddressButton);
            this.tabPage2.Controls.Add(this.AddAddressButton);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.SettingsAddressListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(448, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // DeleteAddressButton
            // 
            this.DeleteAddressButton.Location = new System.Drawing.Point(404, 117);
            this.DeleteAddressButton.Name = "DeleteAddressButton";
            this.DeleteAddressButton.Size = new System.Drawing.Size(23, 23);
            this.DeleteAddressButton.TabIndex = 5;
            this.DeleteAddressButton.Text = "-";
            this.DeleteAddressButton.UseVisualStyleBackColor = true;
            this.DeleteAddressButton.Click += new System.EventHandler(this.DeleteAddressButton_Click);
            // 
            // AddAddressButton
            // 
            this.AddAddressButton.Location = new System.Drawing.Point(372, 117);
            this.AddAddressButton.Name = "AddAddressButton";
            this.AddAddressButton.Size = new System.Drawing.Size(23, 23);
            this.AddAddressButton.TabIndex = 4;
            this.AddAddressButton.Text = "+";
            this.AddAddressButton.UseVisualStyleBackColor = true;
            this.AddAddressButton.Click += new System.EventHandler(this.AddAddressButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Адресаты сообщения об ошибках:";
            // 
            // SettingsAddressListBox
            // 
            this.SettingsAddressListBox.FormattingEnabled = true;
            this.SettingsAddressListBox.Location = new System.Drawing.Point(6, 29);
            this.SettingsAddressListBox.Name = "SettingsAddressListBox";
            this.SettingsAddressListBox.Size = new System.Drawing.Size(421, 82);
            this.SettingsAddressListBox.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.linkLabel1);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.VersionLabel);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(448, 301);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "фыв";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "на Солнце.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(384, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "SOAutomatic - программное обеспечение для автоматической ориентации";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Email:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(40, 277);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "xeqlol@gmail.com";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Разработчик: Немков Дмитрий Александрович";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(142, 21);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(68, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "VersionLabel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "SOAutomatic";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(653, 348);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeIntervalHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeIntervalMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeIntervalSeconds)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SettingsTimeZone;
        private System.Windows.Forms.ComboBox SettingsPorts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown TimeIntervalHours;
        private System.Windows.Forms.NumericUpDown TimeIntervalMinutes;
        private System.Windows.Forms.NumericUpDown TimeIntervalSeconds;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SettingsLatitude;
        private System.Windows.Forms.TextBox SettingsLongitude;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SettingsDrivers;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox SettingsAddressListBox;
        private System.Windows.Forms.Button DeleteAddressButton;
        private System.Windows.Forms.Button AddAddressButton;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox SettingsSeaLevelRise;
        private System.Windows.Forms.TextBox SettingsPressure;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SettingsTemperature;
    }
}