using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Something really bad happened, and this is the final try { } catch { } block to catch it: \n\n" + ex.ToString(),
                    "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
    }
}
