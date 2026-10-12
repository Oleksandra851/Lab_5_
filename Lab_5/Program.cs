using Microsoft.EntityFrameworkCore;
using Lab_5.Data;
using Lab_5.Components;

var builder = WebApplication.CreateBuilder(args);

// 1. Реєстрація сервісів 
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Реєстрація контексту бази даних
builder.Services.AddDbContext<UniversityDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UniversityDb")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// 2. Мапінг компонентів 
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();