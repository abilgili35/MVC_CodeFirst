using MVC_CodeFirst.Repositories.Abstracts;
using MVC_CodeFirst.Repositories.Concretes;

var builder = WebApplication.CreateBuilder(args);
//MVC
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMovieRepository,MovieRepository>();


var app = builder.Build();

//staticfiles
app.UseStaticFiles();
//route
app.UseRouting();
//maproute
app.MapControllerRoute(
    name: "default", 
    pattern: "{Controller=Home}/{Action=Index}/{id?}");
    //https:localhost:7668/Home/Index/5

app.Run();
