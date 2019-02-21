using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBBankOffice
{
    class Program
    {

        //The main entry point of the application
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Appliction.Run(new.MDIBackEnd());
        }
    }
}
