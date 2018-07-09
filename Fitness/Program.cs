using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness
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
            Modell.Model model = new Modell.Model();
            View.View view = new View.View();
            Presenter.Presenter presenter = new Presenter.Presenter(model, view);
            view.Run();
        }
    }
}
