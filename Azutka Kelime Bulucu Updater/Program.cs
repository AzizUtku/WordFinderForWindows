using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azutka_Kelime_Bulucu_Updater
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
            Form1 frm1 = new Form1();
            if (args.Length > 0)
            {
                if (args[0]=="AzutkaKelimeBulucuAUK98")
                {
                    
                    frm1.fullpath = args[1].Replace("$"," ");
                    frm1.programsürümü = args[2].Replace("$", " ");
                    frm1.filename = args[3].Replace("$", " ");
                    frm1.isimarg = args[4];
                    frm1.lisanskeyarg = args[5];
                    
                    Application.Run(frm1);
                }

                else
                {
                 
                    MessageBox.Show("Bu programı Azutka Kelime Bulucu üzerinden başlatın!", "Uygulama, direkt olarak çalıştırılamaz!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
               
            }

            else
            {
                
                MessageBox.Show("Bu programı Azutka Kelime Bulucu üzerinden başlatın!", "Uygulama, direkt olarak çalıştırılamaz!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
