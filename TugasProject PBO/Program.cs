using System;
using System.Windows.Forms;
using TugasProjectPBO.Views;

namespace TugasProjectPBO.Views
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginSIMIHAN());
        }
    }
}