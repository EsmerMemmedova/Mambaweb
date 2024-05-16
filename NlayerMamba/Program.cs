using Mamba.Business.Services.Abstracts;
using Mamba.Business.Services.Concretes;
using Mamba.Core.RepostoryAbstracts;
using Mamba.Data.Dal;
using Mamba.Data.RepostoryConcretes;
using Microsoft.EntityFrameworkCore;

namespace NlayerMamba
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));

            });
            builder.Services.AddScoped<ITeamsService,TeamsService>();
            builder.Services.AddScoped<ITeamsRepostory,TeamsRepostory>();

            var app = builder.Build();

          
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}