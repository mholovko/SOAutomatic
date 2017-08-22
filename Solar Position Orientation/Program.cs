using System;
using System.Reflection;
using System.Windows.Forms;

namespace SOAutomatic
{
    public static class Program
    {
        // Forms.
        public static MainForm MainForm;
        public static ConsoleForm ConsoleForm;
        public static SettingsForm SettingsForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new MainForm();
            ConsoleForm = new ConsoleForm();
            SettingsForm = new SettingsForm();

            MainForm.СonsoleDelegate = ConsoleForm.WriteConsoleBox;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("version.txt"))
            {
                file.Write(Assembly.GetExecutingAssembly().GetName().Version);
                file.Dispose();
            }
            
            Application.Run(MainForm);
        }
    }
}
