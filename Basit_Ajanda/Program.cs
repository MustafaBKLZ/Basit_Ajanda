using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Basit_Ajanda
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Cls.SQLConnectionClass.Baglanti(); // burada f12 ye bastığımdan bandicam durmuş. geç fark ettim birazx ilerletmişsim. o kısımları göstereceğim.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Anaform());
        }
    }
}
