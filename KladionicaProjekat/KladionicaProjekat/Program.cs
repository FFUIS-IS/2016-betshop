using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;

namespace KladionicaProjekat
{
    static class Program
    {
        internal static string path;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sports());
        }

       /* static void Main(string[] args)
        {
            string baseUr1 = "https://api.sportradar.us/soccer-t3/eu/bs/schedules/2016-02-14/results.json?api_key=wer8m96968547xyrw3wjcp89";

            WebRequest requeste = 
        } 
        */
    }
}
