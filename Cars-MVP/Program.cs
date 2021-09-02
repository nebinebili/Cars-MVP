using Cars_MVP.Presenter;
using Cars_MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_MVP
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
            
            var view =new MainView();
            var presenter = new MainPresenter(view);
            Application.Run(view);
        }
    }
}
