using Microsoft.EntityFrameworkCore;
using EmployeeManagementApp.Models.Entities;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<PMMContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PMMDatabase")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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


app.Run();
