using System.Globalization;

namespace Slides_ASPNET_CRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            var currentThreadCulture =
        (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            currentThreadCulture.NumberFormat =
                NumberFormatInfo.InvariantInfo;

            Thread.CurrentThread.CurrentCulture = currentThreadCulture;
            Thread.CurrentThread.CurrentUICulture = currentThreadCulture;

            //await next();


            app.Run();
        }
    }
}
