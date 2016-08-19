using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Mohamoud Mohamed 300435435
/// Final exam comp123
/// v.1
/// </summary>
namespace COMP123_S2016_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //instatiated splashform
            Application.Run(new SplashForm());
          // Application.Run(new AbilityGeneratorForm());
        }
    }
}
