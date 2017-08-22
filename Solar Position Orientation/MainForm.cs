using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;

namespace SOAutomatic
{
    public partial class MainForm : Form
    {
        // Делегаты для вывода в консоль.
        public delegate void AddDataDelegate(String myString, Color myColor);
        public AddDataDelegate СonsoleDelegate;

        // Переменная состояния программы.
        public bool IsProgramRunning { get; set; } = false;
        public bool IsFirstChecked { get; set; } = false;
        public bool IsErrorEmailReported { get; set; } = false;

        // Переменные для динамической загрузки .dll драйверов установки.
        public string DriverPath { get; set; }
        public MethodInfo DriverMethod { get; set; }
        
        // Переменная SPA Calculator.
        SPACalculator.SPAData _SPAData;

        // Данные для работы алгоритма;
        // Необходимое для чтения с последовательного порта окружение.
        private static bool _continue = true;
        private static string _tString = string.Empty;
        private const byte _char = 0x0D;

        // Текущие значения азимута и элевации.
        public float CurrentAzimuth = 0;
        public float CurrentElevation = 0;
        public float OldCurrentAzimuth = 0;
        public float OldCurrentElevation = 0;

        // Параметры до старта программы.
        public int TimerSetting { get; set; }
        public double AreaLatitude { get; set; }
        public double AreaLongitude { get; set; }
        public double TimeZone { get; set; }
        public string PortName { get; set; }
        public string DriverName { get; set; }
        public double Pressure { get; set; }
        public double Temperature { get; set; }
        public double SeaLevelRise { get; set; }

        // Поток чтения данных с порта.
        public Thread SPortReadThread { get; set; }

        // Настройки
        static INIFile Options { get; set; }

        // Данные для отправки сообщения об ошибке
        public string ErrorMessage = "В ходе работы программы возникла ошибка. Рекомендуется проверить работоспособность пульта AZV-1. В случае ошибки, рекомендуется перезагрузка пульта и перезапуск программы.";
        public List<string> ErrorEmailAddress { get; set; }

        // Данные для логгирования
        public DateTime LogDateTimeStart { get; set; }
    
        // Временной счетчик до следующего поворота.
        public int TimeLeft;

        public MainForm()
        {
            InitializeComponent();

            SPort.BaudRate = 9800;
            SPort.Parity = Parity.None;
            SPort.DataBits = 8;
            SPort.StopBits = StopBits.One;
            SPort.Handshake = Handshake.XOnXOff;
            SPort.DataReceived += SPortRead;
            SPort.ReadTimeout = 1000;
            SPort.WriteTimeout = 1000;
            SPort.DtrEnable = true;
            SPort.RtsEnable = true;

            _SPAData = new SPACalculator.SPAData();

            if (!File.Exists("settings.ini"))
                File.Create("settings.ini");
            Options = new INIFile("settings.ini");

            try 
            {
                TimerSetting = int.Parse(Options.Read("timerSettings"));
                AreaLatitude = Double.Parse(Options.Read("areaLatitude"));
                AreaLongitude = Double.Parse(Options.Read("areaLongitude"));
                Pressure = Double.Parse(Options.Read("pressure"));
                Temperature = Double.Parse(Options.Read("temperature"));
                SeaLevelRise = Double.Parse(Options.Read("seaLevelRise"));
                TimeZone = Double.Parse(Options.Read("timeZone"));
                PortName = Options.Read("portName");
                DriverName = Options.Read("driverName");
                ErrorEmailAddress = new List<string>(Options.Read("errorEmailAddress").Split(';'));
                DriverPath = Assembly.GetExecutingAssembly().Location.Replace(@"\SOAutomatic.exe", "") + @"\drivers\" + DriverName;
                DriverMethod = Program.SettingsForm.CreateFunction(File.ReadAllText(DriverPath));
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить настройки из файла settings.ini.");
            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            
            if (args.Contains("/startinstant"))
            {
                StartProgram();
            }
            else
            {
                Program.SettingsForm.Show();
            }
            this.Text = @"SOAutomatic v." + Assembly.GetExecutingAssembly().GetName().Version;
        }
        
        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProgram();
        }

        private void DateTimeUpdateTimer_Tick(object sender, EventArgs e)
        {
            DateTimeTextBox.Text = DateTime.Now.ToString();

            CalculateCurrentAngles(false);

            DrawAzimuth((int)Math.Round(_SPAData.Azimuth, 0));
            DrawElevation((int)Math.Round(90 - _SPAData.Zenith, 0));

            AzimuthTextBox.Text = Math.Round(_SPAData.Azimuth, 1) + @"°";
            ElevationTextBox.Text = Math.Round(90 - _SPAData.Zenith, 1) + @"°";
            CurrentAzimuthTextBox.Text = Math.Round(CurrentAzimuth, 1) + @"°";
            CurrentElevationTextBox.Text = Math.Round(CurrentElevation, 1) + @"°";

            TimeLeft += 1000;
            TimeLeftTextBox.Text = ((TimerSetting - TimeLeft)/1000) + @" сек.";
            TimeLeftTextBox.Text = $"{(TimerSetting - TimeLeft)/1000/60/60%24} ч. {(TimerSetting - TimeLeft)/1000/60%60} м. {(TimerSetting - TimeLeft)/1000%60} с.";
        }
        
        private void ConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ConsoleForm.Show();
        }

        private void RotateTimer_Tick(object sender, EventArgs e)
        {
            CalculateCurrentAngles(true);
            if (90 - _SPAData.Zenith > 0) {
                SPortWrite((string)DriverMethod.Invoke(null, new object[] { Math.Round(_SPAData.Azimuth, 1), Math.Round(_SPAData.Zenith, 1) }));
                Program.ConsoleForm.Invoke(СonsoleDelegate, new Object[] { $"Производится поворот на угол по азимуту: { Math.Round(_SPAData.Azimuth, 1)}°, по элевации: {Math.Round(90 - _SPAData.Zenith, 1)}° (команда: {(string) DriverMethod.Invoke(null, new object[] {Math.Round(_SPAData.Azimuth, 1), Math.Round(_SPAData.Zenith, 1)})}).", Color.Green });
            }
            else
            {
                Program.ConsoleForm.Invoke(СonsoleDelegate, new Object[] { $"Солнце зашло (расчетная элевация {Math.Round(90 - _SPAData.Zenith, 1)}). Поворот не требуется.", Color.Green });
            }
            TimeLeft = 0;
        }

        private void PropertiesToolStrip_Click(object sender, EventArgs e)
        {
            Program.SettingsForm.ShowDialog();
        }

        private void GCTimer_Tick(object sender, EventArgs e)
        {
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void ErrorEmailSendTimer_Tick(object sender, EventArgs e)
        {
            CalculateCurrentAngles(false);

            if (90 - _SPAData.Zenith > 0 && !IsErrorEmailReported)
            {
                if (CurrentElevation == OldCurrentElevation && CurrentAzimuth == OldCurrentAzimuth)
                {
                    SendEmail(ErrorMessage);
                }
            }

            OldCurrentAzimuth = CurrentAzimuth;
            OldCurrentElevation = CurrentElevation;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Options = new INIFile("settings.ini");
                Options.Write("timerSettings", TimerSetting.ToString());
                Options.Write("areaLatitude", AreaLatitude.ToString());
                Options.Write("areaLongitude", AreaLongitude.ToString());
                Options.Write("pressure", Pressure.ToString());
                Options.Write("temperature", Temperature.ToString());
                Options.Write("seaLevelRise", SeaLevelRise.ToString());
                Options.Write("timeZone", TimeZone.ToString());
                Options.Write("portName", PortName);
                Options.Write("driverName", DriverName);
                Options.Write("errorEmailAddress", String.Join(";", ErrorEmailAddress));

                if (!string.IsNullOrEmpty(Program.ConsoleForm.ConsoleBoxValue))
                {
                    if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\log\"))
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\log\");
                    using (
                        StreamWriter outputFile =
                            new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\log\" +
                                             $"{LogDateTimeStart.ToString("yy.MM.dd HH-mm-ss")} - {DateTime.Now.ToString("yy.MM.dd HH-mm-ss")}" +
                                             ".txt"))
                    {
                        string[] consoleboxvalue = Program.ConsoleForm.ConsoleBoxValue.Split('\n');

                        foreach (string line in consoleboxvalue)
                            outputFile.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
            Environment.Exit(0);
        }
    }
}
