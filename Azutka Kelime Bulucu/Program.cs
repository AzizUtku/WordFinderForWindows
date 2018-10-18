using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azutka_Kelime_Bulucu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Intro());
            Intro intro = new Intro();
            if (args.Length > 0)
            {
                if (args[0] == "AzutkaUpdaterAUK98")
                {

                    intro.updaterlisanskey = args[1].Replace("$", " ");
                    intro.updaterisim = args[2].Replace("$", " ");
                   
                    
                }

               

            }

            Application.Run(intro);
        }
    }
}
