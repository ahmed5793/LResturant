using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restuarnt.PL;

namespace Restuarnt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        internal static string salesman;
        internal static int Id_USer;
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Frm_MainNew());
             Application.Run(new frm_SerielNumber());
        }
    }
}
