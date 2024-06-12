using GestionTienda.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string? conetionString = builder.Configuration.GetConnectionString("Connection");

if (!string.IsNullOrEmpty(conetionString))
{
    // Aquí puedes usar la cadena de conexión de manera segura
    builder.Services.AddDbContext<TiendaContext>(options =>
    {
        options.UseMySql(
            conetionString,
            new MySqlServerVersion(new Version(8, 0, 19))
        );
    });
}

var app = builder.Build();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
