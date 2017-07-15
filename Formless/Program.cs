using System;
using System.Media;
using System.Windows.Forms;

namespace Formless
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (Icon i = new Icon())
            {
                i.Display();
                var startTimeSpan = TimeSpan.Zero;
                var periodTimeSpan = TimeSpan.FromSeconds(5);

                var timer = new System.Threading.Timer((e) =>
                {
                    ShowNotification();
                }, null, startTimeSpan, periodTimeSpan);
                Application.Run();
            }
        }
        private static void ShowNotification()
        {
            SystemSounds.Exclamation.Play();
        }

    }
}
