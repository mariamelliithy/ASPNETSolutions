namespace ASPNET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            //MVC
            builder.Services.AddControllersWithViews(); 
            ////Razor pages
            //builder.Services.AddRazorPages();
            ////Web API
            //builder.Services.AddControllers();
            ////Mix
            //builder.Services.AddMvc();

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseRouting();
            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/index", async context => //static segment
            //{
            //    await context.Response.WriteAsync("Hello index");
            //});
            app.MapControllerRoute(name : "DefaultRoute",
                pattern : "{Controller=Movies}/{action=Index}/{id:int?}"); //variable segment
                                                                           //id is optional

            app.Run();
        }
    }
}
