using IMS.DataAccess;
using IMS.DataAccess.FormCategoryData;
using IMS.DataAccess.FormEmployeeData;
using IMS.DataAccess.FormInventoryData;
using IMS.DataAccess.FormMainWindowData;
using IMS.DataAccess.FormOrderData;
using IMS.DataAccess.FormProductData;
using IMS.DataAccess.FormProfileData;
using IMS.DataAccess.FormSupplierData;
using IMS.FormLoginData;
using IMS.UserInterface.Category;
using IMS.UserInterface.Employees;
using IMS.UserInterface.Inventory;
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

            //Reading appsettings to get the configuration file
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();

            //Adding classes and interfaces to DI Containners
            services.AddSingleton(config);

            services.AddSingleton<FormLogin>();
            services.AddTransient<FormSplashScreen>();
            services.AddTransient<FormMainWindow>();

            services.AddTransient<FormCategory>();
            services.AddTransient<FormSupplier>();
            services.AddTransient<FormProduct>();
            services.AddTransient<FormEmployees>();
            services.AddTransient<FormProfile>();
            services.AddTransient<FormOrder>();
            services.AddTransient<FormInventory>();


            services.AddTransient<IFormMainWindowSql, FormMainWindowSql>();
            services.AddTransient<ISqlDataAccess, SqlDataAccess>();
            services.AddTransient<IFormLoginSql, FormLoginSql>();
            services.AddTransient<IFormCategorySql, FormCategorySql>();
            services.AddTransient<IFormSupplierSql, FormSupplierSql>();
            services.AddTransient<IFormProductSql, FormProductSql>();
            services.AddTransient<IFormEmployeeSql, FormEmployeeSql>();
            services.AddTransient<IFormProfileSql, FormProfileSql>();
            services.AddTransient<IFormOrderSql, FormOrderSql>();
            services.AddTransient<IFormInventorySql, FormInventorySql>();


            ServiceProvider = services.BuildServiceProvider();

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
