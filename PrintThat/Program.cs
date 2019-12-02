using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintThat
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Configs.Init(AppDomain.CurrentDomain.BaseDirectory + "Params.config");
            PrintLogger.Init();

            Form_Main form;
            if (args.Count() == 1 && args[0] == AutoStart.HideWord)
            { form = new Form_Main(true); }
            else { form = new Form_Main(); }

            Application.Run(form);
        }
    }
}
