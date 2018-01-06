using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEDUKASI
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
            Application.Run(new EduLaunch());
            //Application.Run(new EduMath());
            //Application.Run(new Edutamb());
            //Application.Run(new EduProf());
            //Application.Run(new About());
            //Application.Run(new Eduset());
        }
    }
}
