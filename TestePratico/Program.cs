using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePratico
{
    static class Program
    {
        [DllImport("Kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("User32.dll")]
        public static extern bool ShowWindow(IntPtr ptr, int cmd);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IntPtr ptr = GetConsoleWindow();
            Console.Title = "Area de Calculos | Teste Pratico";
            
            if(ptr != IntPtr.Zero)
            {
                ShowWindow(ptr, 0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
