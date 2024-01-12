
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScienceAcademy.Business.Business;
using ScienceAcademy.Business.Interfaces;
using ScienceAcademy.Data.Contexts;
using ScienceAcademy.Data.Interfaces.IRepositories;
using ScienceAcademy.Data.Repositories;
using System.Configuration;
using System.Data;
using System.Windows.Forms.Design;

namespace ScienceAcademy.UI
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureServices();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<frmMain>());
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            // Register services
            services.AddTransient<IAwardBusiness, AwardBusiness>();
            services.AddTransient<IMemberBusiness, MemberBusiness>();
            services.AddTransient<IUniversityBusiness, UniversityBusiness>();

            services.AddTransient<IAwardRepository, AwardRepository>();
            services.AddTransient<IMemberRepository, MemberRepository>();
            services.AddTransient<IUniversityRepository, UniversityRepository>();

            services.AddDbContext<ScienceAcademyDbContext>(options => options.UseSqlServer("Data Source=localhost\\SQLEXPRESS; Initial Catalog=ScienceAcademy; Trusted_Connection=True;"));
            services.AddTransient<frmMain>();

            // Build the service provider
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}