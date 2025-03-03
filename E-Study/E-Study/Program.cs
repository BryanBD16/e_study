using E_Study.Data;
using Microsoft.EntityFrameworkCore;

namespace E_Study
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<E_StudyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Apply migrations and seed the database if needed
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<E_StudyDbContext>();
                DbInitializer.Initialize(dbContext); // Call the initializer
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapAreaControllerRoute(
                 name: "Home",
                 areaName: "Home",
                 pattern: "Home/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{Area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapGet("/", async context =>
            {
                context.Response.Redirect("/Course/Courses/Index");
            });

            app.Run();
        }
    }
}
