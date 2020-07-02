using IMS.DataAccess;
using IMS.UserInterface.SplashScreen;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface
{
    public static class Program
    {
        public static ServiceProvider ServiceProvider;

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<FormLogin>();
            services.AddSingleton<FormSplashScreen>();
            services.AddSingleton<FormMainWindow>();
            services.AddTransient<ISqlDataAccess, SqlDataAccess>();
            services.AddTransient<IFormLoginSql, FormLoginSql>();

            //Reading appsettings to get the configuration file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();


            services.AddSingleton(config);

            ServiceProvider = services.BuildServiceProvider();
            var FormLogin = ServiceProvider.GetService<FormLogin>();
            Application.Run(FormLogin);
        }



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            //Application.Run(new FormLogin());
        }
    }
}
