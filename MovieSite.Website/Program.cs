using MovieSite.DAL;
namespace MovieSite.Website;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //register the InMemoryMovieDAO as a singleton
        //so any controller class that needs an IMovieDAO will get the same instance
        //this makes it possible to keep the list of movies in memory
        builder.Services.AddSingleton<IMovieDAO, InMemoryMovieDAO>();

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

        //enable the use of static files in the wwwroot folder
        app.UseStaticFiles();

        //enable routing so the app can use controllers based on the URI
        app.UseRouting();

        app.UseAuthorization();

        //map the default route to the Home controller and the Index action
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();

    }
}