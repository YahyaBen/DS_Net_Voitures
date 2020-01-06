using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS2017
{
    static class Program
    {
        public static List<marque> Marques = new List<marque>();
        public static List<vehicule> Vehicules = new List<vehicule>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Application());
            Marques.Add(new marque("Volvo"));
            Marques.Add(new marque("Audi"));
            Marques.Add(new marque("Dacia"));
            Marques.Add(new marque("BMW"));
            Marques.Add(new marque("Kawazaki"));

        }
    }
}
