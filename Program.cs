using Blazored.LocalStorage;
using ComputerComponentShop.Components;
using ComputerComponentShop.Models.DataBase;
using ComputerComponentShop.Models.Services;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<ComputerComponentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ComponentShop")));

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<CustomerManager>();
builder.Services.AddSingleton<AlertService>();
builder.Services.AddScoped<ShoppingCartManager>();
builder.Services.AddScoped<ComponentManager>();
builder.Services.AddScoped<ComputerComponentRepository>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ComputerComponentContext>();
    db.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
