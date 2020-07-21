using IMS.DataAccess;
using IMS.DataAccess.FormCategoryData;
using IMS.DataAccess.FormEmployeeData;
using IMS.DataAccess.FormOrderData;
using IMS.DataAccess.FormProductData;
using IMS.DataAccess.FormProfileData;
using IMS.DataAccess.FormSupplierData;
using IMS.FormLoginData;
using IMS.UserInterface.Category;
using IMS.UserInterface.Employees;
using IMS.UserInterface.Order;
using IMS.UserInterface.Product;
using IMS.UserInterface.Profile;
using IMS.UserInterface.SplashScreen;
using IMS.UserInterface.Supplier;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
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
            services.AddSingleton<FormSupplier>();
            services.AddSingleton<FormProduct>();
            services.AddSingleton<FormEmployees>();
            services.AddSingleton<FormProfile>();
            services.AddSingleton<FormOrder>();

            services.AddTransient<ISqlDataAccess, SqlDataAccess>();
            services.AddTransient<IFormLoginSql, FormLoginSql>();
            services.AddTransient<IFormCategorySql, FormCategorySql>();
            services.AddTransient<IFormSupplierSql, FormSupplierSql>();
            services.AddTransient<IFormProductSql, FormProductSql>();
            services.AddTransient<IFormEmployeeSql,FormEmployeeSql >();
            services.AddTransient<IFormProfileSql, FormProfileSql>();
            services.AddTransient<IFormOrderSql, FormOrderSql>();

            //Reading appsettings to get the configuration file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();


            services.AddSingleton(config);

            ServiceProvider = services.BuildServiceProvider();

            //var FormLogin = ServiceProvider.GetService<FormLogin>();
            //Application.Run(FormLogin);
            var Form = ServiceProvider.GetService<FormMainWindow>();
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
