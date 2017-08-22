using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Reflection;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Collections;
using System.Text.RegularExpressions;

namespace SOAutomatic
{
    public partial class SettingsForm : Form
    {
        static readonly double[] Timezones = { -12, -11, -10, -9, -8, -7, -6, -5, -4, -3.5, -3, -2, -1, 0, 1, 2, 3, 3.5, 4, 4.5, 5, 5.5, 5.75, 6, 7, 8, 9, 9.5, 10, 11, 12 };

        static string[] Driverspath = {};

        public SettingsForm()
        {
            InitializeComponent();

            SettingsPorts.DataSource = SerialPort.GetPortNames();
            try
            {
                Driverspath = Directory.GetFiles(Assembly.GetExecutingAssembly().Location.Replace(@"\SOAutomatic.exe", "") + @"\drivers\", "*.cs");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть файл драйвера. ({ex.Message})");
            }
            foreach (var t in Driverspath)
            {
                SettingsDrivers.Items.Add(t.Split('\\').Last());
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Program.MainForm.TimeZone = Timezones[SettingsTimeZone.SelectedIndex];

                Program.MainForm.AreaLatitude = double.Parse(SettingsLatitude.Text);
                Program.MainForm.AreaLongitude = double.Parse(SettingsLongitude.Text);

                Program.MainForm.PortName = SettingsPorts.SelectedItem.ToString();

                Program.MainForm.Temperature = double.Parse(SettingsTemperature.Text);
                Program.MainForm.Pressure = double.Parse(SettingsPressure.Text);
                Program.MainForm.SeaLevelRise = double.Parse(SettingsSeaLevelRise.Text);

                Program.MainForm.TimerSetting = Decimal.ToInt32(TimeIntervalHours.Value) * 1000 * 60 * 60
                                                    + Decimal.ToInt32(TimeIntervalMinutes.Value) * 1000 * 60
                                                    + Decimal.ToInt32(TimeIntervalSeconds.Value) * 1000;
                Program.MainForm.DriverPath = Driverspath[SettingsDrivers.SelectedIndex];

                Program.MainForm.DriverMethod = CreateFunction(File.ReadAllText(Program.MainForm.DriverPath));

                Program.MainForm.DriverName = SettingsDrivers.SelectedItem.ToString();
                
                Program.MainForm.ErrorEmailAddress = SettingsAddressListBox.Items.Cast<string>().ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка. Текст ошибки: {ex}.\n\nПожалуйста, проверьте правильность настроек.", "Ошибка при настройке программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            this.Hide();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            SettingsLatitude.Text = Program.MainForm.AreaLatitude.ToString();
            SettingsLongitude.Text = Program.MainForm.AreaLongitude.ToString();

            TimeIntervalSeconds.Value = Program.MainForm.TimerSetting / 1000 % 60;
            TimeIntervalMinutes.Value = (Program.MainForm.TimerSetting / 1000 - TimeIntervalSeconds.Value) / 60 % 60;
            TimeIntervalHours.Value = (Program.MainForm.TimerSetting / 1000 - TimeIntervalSeconds.Value) / 60 / 60 % 24;

            SettingsPorts.SelectedIndex = SettingsPorts.FindString(Program.MainForm.PortName);
            SettingsDrivers.SelectedIndex = SettingsDrivers.FindString(Program.MainForm.DriverName);
            SettingsTimeZone.SelectedIndex = Array.IndexOf(Timezones, Program.MainForm.TimeZone);

            SettingsTemperature.Text = Program.MainForm.Temperature.ToString();
            SettingsPressure.Text = Program.MainForm.Pressure.ToString();
            SettingsSeaLevelRise.Text = Program.MainForm.SeaLevelRise.ToString();

            SettingsAddressListBox.Items.Clear();
            if(Program.MainForm.ErrorEmailAddress.ToArray().Length != 0)
                SettingsAddressListBox.Items.AddRange(Program.MainForm.ErrorEmailAddress.ToArray());
            SettingsAddressListBox.Refresh();

            VersionLabel.Text = @"v." + AssemblyName.GetAssemblyName(Assembly.GetExecutingAssembly().Location).Version;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void SettingsLatitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && SettingsLatitude.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        public MethodInfo CreateFunction(string function)
        {
            string code = @"
                        using System;
            
                        namespace UserFunctions
                        {                
                            public class BinaryFunction
                            {                
                                public static string Function(double AZIMUTH, double ELEVATION)
                                {
                                    return func_xy;
                                }
                            }
                        }
                    ";

            string finalCode = code.Replace("func_xy", function);

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerResults results = provider.CompileAssemblyFromSource(new CompilerParameters(), finalCode);

            Type binaryFunction = results.CompiledAssembly.GetType("UserFunctions.BinaryFunction");
            return binaryFunction.GetMethod("Function");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                TabPage p = tabControl1.TabPages[e.Node.Index];
                tabControl1.SelectedTab = p;
            }
        }

        private void DeleteAddressButton_Click(object sender, EventArgs e)
        {
            SettingsAddressListBox.BeginUpdate();
            ArrayList vSelectedItems = new ArrayList(SettingsAddressListBox.SelectedItems);
            foreach (var i in vSelectedItems)
                SettingsAddressListBox.Items.Remove(i);
            SettingsAddressListBox.EndUpdate();
        }

        private void AddAddressButton_Click(object sender, EventArgs e)
        {
            InputBoxValidation validation = delegate (string val) {
                if (val == "")
                    return "Адрес не может быть пустым.";
                if (!(new Regex(@"^[a-zA-Z0-9_\-\.]+@[a-zA-Z0-9_\-\.]+\.[a-zA-Z]{2,}$")).IsMatch(val))
                    return "Проверьте правильность введенного адреса.";
                return "";
            };

            string value = "";
            if (InputBox.Show("Введите email адрес", "email адрес:", ref value, validation) == DialogResult.OK)
            {
                SettingsAddressListBox.Items.Add(value);
            }
        }
    }

    public class InputBox
    {
        public static DialogResult Show(string title, string promptText, ref string value)
        {
            return Show(title, promptText, ref value, null);
        }

        public static DialogResult Show(string title, string promptText, ref string value,
                                        InputBoxValidation validation)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            if (validation != null)
            {
                form.FormClosing += delegate (object sender, FormClosingEventArgs e) {
                    if (form.DialogResult == DialogResult.OK)
                    {
                        string errorText = validation(textBox.Text);
                        if (e.Cancel = (errorText != ""))
                        {
                            MessageBox.Show(form, errorText, "Ошибка валидации",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox.Focus();
                        }
                    }
                };
            }
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }

    public delegate string InputBoxValidation(string errorMessage);
}
