using Microsoft.EntityFrameworkCore;
using ReversoBD;
using ReversoBD.Tools;
using ReversoForm.Forms;
using System;
using System.Configuration;
using System.Linq;
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

            try
            {

            var reversoContexto = new ReversoContexto();
            if (reversoContexto.Database.GetPendingMigrations().Any())
            {
                reversoContexto.Database.Migrate();
            }
                Application.Run(new TelaDeLogin(reversoContexto));
            }catch(Exception err)
            {
                Console.WriteLine($"Erro ao conectar com o banco de dados. {err.Message}");
            }

            //var retorn = reversoContexto.Usuario.Where(x => x.Email == "teste@dasdas").Select(x => new {x.PessoaFisica.Nome}).ToList();
        }
    }
}
