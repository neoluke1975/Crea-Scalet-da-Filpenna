using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Crea_Scalet_da_Filpenna
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
