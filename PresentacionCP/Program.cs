using CapaPresentacion.Login;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Login
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login() );
        }
    }
}
