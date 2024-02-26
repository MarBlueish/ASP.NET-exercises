using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoFinal.Data;
using ProjetoFinal.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProjetoFinalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjetoFinalContext") ?? throw new InvalidOperationException("Connection string 'ProjetoFinalContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData_Casa.Initialize(services);
    SeedData_Cliente.Initialize(services);
    SeedData_Interesse.Initialize(services);
    SeedData_Visita.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
