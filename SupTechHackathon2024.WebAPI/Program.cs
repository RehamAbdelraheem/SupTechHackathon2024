using Microsoft.EntityFrameworkCore;
using SupTechHackathon2024.EFCore;
using SupTechHackathon2024.Repositories;
using SupTechHackathon2024.Repositories.Interfaces;
using SupTechHackathon2024.Services.Interfaces;
using SupTechHackathon2024.Services.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
builder.WebHost.ConfigureAppConfiguration(config =>
{
    config.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile($"appsettings.json", true, true)
    .AddJsonFile($"appsettings.{env}.json", true, true)
    .AddEnvironmentVariables();
}).UseEnvironment(env)
.ConfigureLogging((context, b) =>
{
    if (context.HostingEnvironment.IsDevelopment())
        b.SetMinimumLevel(LogLevel.Debug);

    b.AddConsole();
});
builder.Services.AddDbContext<CBEContext>((optionsBuilder) =>
{
    optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("CBE"));
}, ServiceLifetime.Scoped);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ICallRepository, CallRepository>();
builder.Services.AddTransient<ICallService, CallService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
