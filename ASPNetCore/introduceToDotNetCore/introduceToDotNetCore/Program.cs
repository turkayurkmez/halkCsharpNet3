var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();



var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();

//pipeline: Bir kaç işin sırayla yapılması
//middleware: Sırayla yapılan her bir iş.

//app.MapGet("/", () => "Merhaba!");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
