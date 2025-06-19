using System;
using System.Windows.Forms;

namespace Paper_Trader
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Start with login form
        }
    }
}