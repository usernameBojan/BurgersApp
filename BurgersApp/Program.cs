using BurgersApp.Application.Repository;
using BurgersApp.Application.Services;
using BurgersApp.Application.Services.Implementation;
using BurgersApp.Domain.Models;
using BurgersApp.Db.Repository;
using BurgersApp.Db;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// Add services to the container.
//builder.Services.AddMvc().AddNewtonsoftJson();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRepository<Burger>, BaseRepository<Burger>>();
builder.Services.AddScoped<IRepository<Location>, BaseRepository<Location>>();
//builder.Services.AddScoped<IRepository<Order>, BaseRepository<Order>>();
builder.Services.AddScoped<IRepository<Order>, OrderRepository>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IBurgerService, BurgerService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddDbContext<ApplicationDbContext>(opts =>
    opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
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
