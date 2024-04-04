using System;
using System.Windows.Forms;
//using NLog.Web;

namespace HW3
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            //try
            //{
                //logger.Debug("Инициализация программы");
            //}
            //catch (Exception ex)
            //{
                //logger.Error(ex, "Закрытие программы.");
            //}
            //finally
            //{
                //NLog.LogManager.Shutdown();
            //}
        }
        
        //public static IHostBuilder CreateHostBuilder(string[] args) =>
            //Host.CreateDefaultBuilder(args)
                //.ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
                //UseNLog();
    }
}