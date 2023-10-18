using final_project;
using final_project.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DbContext,TestDbContext>(option=>{
    var connecttionstring = "Data Source=DESKTOP-NQ9064U\\SQLEXPRESS;Initial Catalog=testDB;Trusted_Connection=Yes;TrustServerCertificate=True;" ;
    // var connecttionstring = configuration.GetConnectionString("Default");
    option.UseSqlServer(connecttionstring);
});

builder.Services.AddScoped<IPersonRepository,EFPersonRepository>();

var app = builder.Build();
// app.UseCors("defaultPolicy");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
