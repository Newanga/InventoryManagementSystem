using IMS.DataAccess;
using IMS.DataAccess.FormCategoryData;
using IMS.UserInterface.Category;
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
            services.AddSingleton<FormCategory>();
            services.AddTransient<ISqlDataAccess, SqlDataAccess>();
            services.AddTransient<IFormLoginSql, FormLoginSql>();
            services.AddTransient<IFormCategorySql, FormCategorySql>();

            //Reading appsettings to get the configuration file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();


            services.AddSingleton(config);

            ServiceProvider = services.BuildServiceProvider();

            //var FormLogin = ServiceProvider.GetService<FormLogin>();
            //Application.Run(FormLogin);
            var Form = ServiceProvider.GetService<FormLogin>();
            Application.Run(Form);
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
