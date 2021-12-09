using Microsoft.EntityFrameworkCore;
using ReversoBD;
using ReversoBD.Tools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReversoForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Config.ConnectionString = ConfigurationManager.AppSettings["Connection"];
            Config.MariaDbVersion = ConfigurationManager.AppSettings["MariaDbVersion"];

            var reversoContexto = new ReversoContexto();
            if (reversoContexto.Database.GetPendingMigrations().Any())
            {
                reversoContexto.Database.Migrate();
            }

            //var retorn = reversoContexto.Usuario.Where(x => x.Email == "teste@dasdas").Select(x => new {x.PessoaFisica.Nome}).ToList();
            Application.Run(new Form1());
        }
    }
}
