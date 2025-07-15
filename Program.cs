using HireLog.Data;
using DotNetEnv;
using HireLog.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();

DotNetEnv.Env.Load();
var connectionString = Environment.GetEnvironmentVariable("ConnectionStringDB"); // load connectionstring from .env file

string dbConnectionString = builder.Configuration.GetConnectionString(connectionString);
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(dbConnectionString));
builder.Services.AddScoped<ApplicationRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
