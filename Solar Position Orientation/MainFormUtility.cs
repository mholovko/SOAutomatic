using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace SOAutomatic
{
    public partial class MainForm
    {
        private void DrawAzimuth(int angle)
        {
            // Validate angle.
            angle = Math.Abs(angle) > 359 ? angle % 360 : angle;
            angle = -angle + 90;
            // Draw this madness.
            Graphics gr = AzimuthDrawPanel.CreateGraphics();
            gr.Clear(Color.White);
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            // Draw XY grid.
            Pen pn = new Pen(Color.Silver, 1);
            // Draw X line.
            gr.DrawLine(pn, new Point(AzimuthDrawPanel.Width / 2, AzimuthDrawPanel.Height / 2), new Point(AzimuthDrawPanel.Width - 30, AzimuthDrawPanel.Height / 2));
            gr.DrawLine(pn, new Point(AzimuthDrawPanel.Width - 10, AzimuthDrawPanel.Height / 2), new Point(AzimuthDrawPanel.Width, AzimuthDrawPanel.Height / 2));
            gr.DrawLine(pn, new Point(0, AzimuthDrawPanel.Height / 2), new Point(0 + 8, AzimuthDrawPanel.Height / 2));
            gr.DrawLine(pn, new Point(0 + 36, AzimuthDrawPanel.Height / 2), new Point(AzimuthDrawPanel.Width / 2, AzimuthDrawPanel.Height / 2));
            // Draw Y line.
            gr.DrawLine(pn, new Point(AzimuthDrawPanel.Width / 2, 0), new Point(AzimuthDrawPanel.Height / 2, 0 + 8));
            gr.DrawLine(pn, new Point(AzimuthDrawPanel.Width / 2, 0 + 24), new Point(AzimuthDrawPanel.Height / 2, ElevationDrawPanel.Width / 2));
            gr.DrawLine(pn, new Point(AzimuthDrawPanel.Width / 2, ElevationDrawPanel.Width / 2), new Point(AzimuthDrawPanel.Height / 2, ElevationDrawPanel.Width - 25));
            gr.DrawLine(pn, new Point(AzimuthDrawPanel.Width / 2, ElevationDrawPanel.Width - 8), new Point(AzimuthDrawPanel.Height / 2, ElevationDrawPanel.Width));
            // Draw angles' text.
            Brush br = new SolidBrush(Color.Silver);
            gr.DrawString("90°", this.Font, br, new Point(222, 120));
            gr.DrawString("0°", this.Font, br, new Point(120, 10));
            gr.DrawString("270°", this.Font, br, new Point(10, 120));
            gr.DrawString("180°", this.Font, br, new Point(115, 230));
            // Draw radius at azimuth angle.
            Point O = new Point(AzimuthDrawPanel.Width / 2, AzimuthDrawPanel.Height / 2);
            double arg = -angle * Math.PI / 180;
            Point EndOfRadius = new Point(Convert.ToInt16(Math.Round(124 * Math.Cos(arg), 0)), Convert.ToInt16(Math.Round(124 * Math.Sin(arg), 0)));
            EndOfRadius.X += O.X;
            EndOfRadius.Y += O.Y;
            // Draw radius.
            pn = new Pen(Color.Black, 2);
            gr.DrawLine(pn, O, EndOfRadius);
            // Draw angle visualisation.
            pn = new Pen(Color.Orange, 2);
            gr.DrawArc(pn, new Rectangle(O.X - AzimuthDrawPanel.Width / 2, O.Y - AzimuthDrawPanel.Height / 2, AzimuthDrawPanel.Width - 2, AzimuthDrawPanel.Height - 2), -90, -(angle - 90));
            // Draw point at the end of radius.
            br = new SolidBrush(Color.Red);
            int pointRatius = 3;
            gr.FillEllipse(br, EndOfRadius.X - pointRatius, EndOfRadius.Y - pointRatius, 2 * pointRatius, 2 * pointRatius);
            br.Dispose();
            pn.Dispose();
        }

        private void DrawElevation(int angle)
        {
            // Validate angle.
            angle = Math.Abs(angle) > 359 ? angle % 360 : angle;
            // Draw this madness.
            Graphics gr = ElevationDrawPanel.CreateGraphics();
            gr.Clear(Color.White);
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            // Draw XY grid.
            Pen pn = new Pen(Color.Silver, 1);
            // Draw X line.
            gr.DrawLine(pn, new Point(10, AzimuthDrawPanel.Height - 10), new Point(AzimuthDrawPanel.Width - 24, AzimuthDrawPanel.Height - 10));
            gr.DrawLine(pn, new Point(AzimuthDrawPanel.Width - 8, AzimuthDrawPanel.Width - 10), new Point(AzimuthDrawPanel.Width, AzimuthDrawPanel.Height - 10));
            // Draw Y line.
            gr.DrawLine(pn, new Point(10, AzimuthDrawPanel.Height - 10), new Point(10, 24));
            gr.DrawLine(pn, new Point(10, 8), new Point(10, 0));
            // Draw angles' text.
            Brush br = new SolidBrush(Color.Silver);
            gr.DrawString("0°", this.Font, br, new Point(230, AzimuthDrawPanel.Height - 16));
            gr.DrawString("90°", this.Font, br, new Point(2, 10));
            // Draw radius at azimuth angle.
            Point O = new Point(10, ElevationDrawPanel.Height - 10);
            double arg = -angle * Math.PI / 180;
            Point endOfRadius = new Point(Convert.ToInt16(Math.Round((AzimuthDrawPanel.Width - 7) * Math.Cos(arg), 0)), Convert.ToInt16(Math.Round((AzimuthDrawPanel.Width - 7) * Math.Sin(arg), 0)));
            endOfRadius.X += O.X;
            endOfRadius.Y += O.Y;
            // Draw radius.
            pn = new Pen(Color.Black, 2);
            gr.DrawLine(pn, O, endOfRadius);
            // Draw angle visualisation.
            pn = new Pen(Color.Orange, 2);
            gr.DrawArc(pn, -AzimuthDrawPanel.Width, -8, 2 * AzimuthDrawPanel.Width - 2, 2 * AzimuthDrawPanel.Width - 20, 1, -(angle - 1));
            // Draw point at the end of radius.
            br = new SolidBrush(Color.Red);
            int pointRatius = 3;
            gr.FillEllipse(br, endOfRadius.X - pointRatius, endOfRadius.Y - pointRatius, 2 * pointRatius, 2 * pointRatius);
            br.Dispose();
            pn.Dispose();
        }

        private void StartProgram()
        {
            try
            {
                if (!IsProgramRunning)
                {
                    LogDateTimeStart = DateTime.Now;
                    PropertiesToolStripMenuItem.Enabled = false;
                    SPort.PortName = PortName;
                    SPort.Open();
                    _continue = true;
                    TimeLeft = 0;
                    TimeLeftTextBox.Text = ((TimerSetting - TimeLeft) / 1000) + @" сек.";
                    // Включаем таймер обновления времени и даты.
                    DateTimeUpdateTimer.Enabled = true;
                    RotateTimer.Interval = TimerSetting;
                    RotateTimer.Enabled = true;
                    ErrorEmailSendTimer.Interval = (2 * TimerSetting + 1000 * 60 * 10);
                    ErrorEmailSendTimer.Enabled = true;

                    // Считаем угол азимута и элевации.
                    CalculateCurrentAngles(false);

                    DrawAzimuth((int)Math.Round(_SPAData.Azimuth, 0));
                    DrawElevation((int)Math.Round(90 - _SPAData.Zenith, 0));

                    AzimuthTextBox.Text = Math.Round(_SPAData.Azimuth, 1) + @"°";
                    ElevationTextBox.Text = Math.Round(90 - _SPAData.Zenith, 1) + @"°";

                    ToggleProgramStatus(true);

                    Program.ConsoleForm.Show();
                    Program.ConsoleForm.Invoke(СonsoleDelegate, new Object[] { "Программа запущена (" +
                                     $"Широта: {AreaLatitude}, " +
                                     $"Долгота: {AreaLongitude}, " +
                                     $"Часовой пояс: {(TimeZone > 0 ? "+" + TimeZone : TimeZone.ToString())} (GTM), " +
                                     $"Уставка по времени: {$"{(TimerSetting) / 1000 / 60 / 60 % 24} ч. {(TimerSetting) / 1000 / 60 % 60} м. {(TimerSetting) / 1000 % 60} с."}, " +
                                     $"Порт: {PortName}, " +
                                     $"Драйвер трекера: {DriverPath.Split('\\').Last()}).",
                                                                              Color.Red });

                    CalculateCurrentAngles(true);

                    // Если солнце не зашло, то поворачиваемся.
                    if (90 - _SPAData.Zenith > 0)
                    {
                        SPortWrite((string)DriverMethod.Invoke(null, new object[] { Math.Round(_SPAData.Azimuth, 1), Math.Round(_SPAData.Zenith, 1) }));
                        Program.ConsoleForm.Invoke(СonsoleDelegate, new Object[] { $"Производится поворот на угол по азимуту: {Math.Round(_SPAData.Azimuth, 1)}°, по элевации: {Math.Round(90 - _SPAData.Zenith, 1)}° (команда: {(string)DriverMethod.Invoke(null, new object[] { Math.Round(_SPAData.Azimuth, 1), Math.Round(_SPAData.Zenith, 1) })}).", Color.Green });
                    }
                    else
                    {
                        Program.ConsoleForm.Invoke(СonsoleDelegate, new Object[] { $"Солнце зашло (расчетная элевация {Math.Round(90 - _SPAData.Zenith, 1)}°). Поворот не требуется.", Color.Green });
                    }
                }
                else
                {
                    ToggleProgramStatus(false);
                    Program.ConsoleForm.Invoke(СonsoleDelegate, new Object[] { "Программа остановлена.", Color.Red} );
                    SPort.Close();
                }
            }
            catch (Exception ex)
            {
                ToggleProgramStatus(false);
                CalculateCurrentAngles(false);
                Program.ConsoleForm.Invoke(СonsoleDelegate, new Object[] { "Программа остановлена.", Color.Red });
                SPort.Close();
                Program.ConsoleForm.Invoke(СonsoleDelegate, new Object[] { $"В ходе запуска программы возникла ошибка: {ex}. \n\nПожалуйста, проверьте настройки программы.", Color.Red });
            }
        }

        private void CalculateCurrentAngles(bool withSpan)
        {

            _SPAData.Latitude = AreaLatitude;
            _SPAData.Longitude = AreaLongitude;

            DateTime now = DateTime.Now;
            _SPAData.Year = now.Year;
            _SPAData.Month = now.Month;
            _SPAData.Day = now.Day;

            _SPAData.Timezone = TimeZone;
            TimeSpan t = TimeSpan.FromMilliseconds(withSpan ? TimerSetting / 2 : 0);
            _SPAData.Hour = now.Hour + t.Hours;
            _SPAData.Minute = now.Minute + t.Minutes;
            _SPAData.Second = now.Second + t.Seconds;

            _SPAData.Elevation = SeaLevelRise;
            _SPAData.Temperature = Temperature;
            _SPAData.Pressure = Pressure;

            _SPAData.DeltaUt1 = 0;
            _SPAData.DeltaT = 67;
            _SPAData.Slope = 0;
            _SPAData.AzmRotation = 0;
            _SPAData.AtmosRefract = 0.5667;

            _SPAData.Function = SPACalculator.CalculationMode.SPA_ZA;

            var result = SPACalculator.SPACalculate(ref _SPAData);
        }

        private void ToggleProgramStatus(bool status)
        {
            _continue = status;
            PropertiesToolStripMenuItem.Enabled = !status;
            // Выключаем таймер обновления времени и даты.
            DateTimeUpdateTimer.Enabled = status;
            RotateTimer.Enabled = status;
            ErrorEmailSendTimer.Enabled = status;
            // Меняем строку состояния в MainMenuStrip на Пуск.
            MainMenuStrip.Items["StartToolStripMenuItem"].Text = status ? "Остановить" : "Запустить";
            // Меняем цвет строки статуса.
            StatusText.Text = status ? "Программа запущена" : "Программа остановлена";
            StatusText.ForeColor = status ? Color.Green : Color.DarkRed;
            // Меняем статус программы на остановленный.
            IsProgramRunning = status;
        }

        private void SPortRead(object sender, SerialDataReceivedEventArgs e)
        {
            while (_continue)
            {
                try
                {
                    if (SPort.IsOpen)
                    {
                        byte[] buffer = new byte[SPort.ReadBufferSize];
                        int bytesRead = SPort.Read(buffer, 0, buffer.Length);
                        _tString += Encoding.ASCII.GetString(buffer, 0, bytesRead);

                        if (_tString.IndexOf((char)_char) > -1)
                        {
                            string workingString = _tString.Substring(0, _tString.IndexOf((char)_char));
                            _tString = _tString.Substring(_tString.IndexOf((char)_char));
                            Program.ConsoleForm.Invoke(СonsoleDelegate, new Object[] { workingString, Color.Blue });
                            if (workingString.StartsWith("OK"))
                            {
                                OldCurrentAzimuth = CurrentAzimuth;
                                OldCurrentElevation = CurrentElevation;
                                CurrentAzimuth =
                                    float.Parse(workingString.Replace("OK", string.Empty).Replace('.', ',').Split(' ')[0]);
                                CurrentElevation =
                                    float.Parse(workingString.Replace("OK", string.Empty).Replace('.', ',').Split(' ')[1]);
                            }
                            _tString = string.Empty;
                        }
                    }
                }
                catch (Exception) { }
            }
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void SPortWrite(string message)
        {
            message = message.Replace(',', '.') + "\r";
            SPort.Write(message.ToCharArray(), 0, message.Length);
        }

        private void SendEmail(string errorMessage)
        {
            try
            {
                SmtpClient client = new SmtpClient();

                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("soautomaticsystem@gmail.com", "soautomatic8787898");

                string message = "<div style=\"font - family: Arial, Helvetica Neue, Helvetica, sans-serif; font - size: 13px;\">" +
                            "<div style = \"color: #A30F1D; font-weight: bold; margin-bottom: 10px;\">" +
                                "SOAUTOMATIC SYSTEM REPORT" +
                            "</div>" +
                            "<div style = \"margin-bottom: 20px;\">" +
                                errorMessage +
                            "</div>" +

                            "<div style = \"font-style: italic; font-size: 10px;\">" +
                                "Время отправки сообщения: " + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") +
                            "</div>" +
                            "<div style = \"font-style: italic; font-size: 10px;\">" +
                                "Если возникли неполадки в работе программы SOAutomatic, свяжитесь с разработчиком: <a style = \"color: #A30F1D\" href = \"mailto:xeqlol@gmail.com\"> xeqlol@gmail.com </a>." +
                            "</div>" +
                          "</div>";

                MailMessage mm = new MailMessage("soautomaticsystem@gmail.com", string.Join(",", ErrorEmailAddress), "SOAutomatic system report", message);

                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.IsBodyHtml = true;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);

                ErrorEmailSendTimer.Enabled = false;
                IsErrorEmailReported = true;
                Program.ConsoleForm.Invoke(СonsoleDelegate, new Object[] { "Отправка email об ошибке прошла успешно.", Color.Red });
            }
            catch (Exception ex)
            {
                Program.ConsoleForm.Invoke(СonsoleDelegate, new Object[] { $"При отправке email возникла ошибка: {ex.ToString()} \n\nПроверьте настройки почты и сетевое соединение.", Color.Red });
            }
        }
    }
}