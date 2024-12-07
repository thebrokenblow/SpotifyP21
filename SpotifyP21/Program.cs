using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpotifyP21;
using SpotifyP21.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

string connection = builder.Configuration.GetConnectionString("SpotifyConnectionString");
// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<SpotifyContext>(options =>
    options.UseNpgsql(connection));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<SpotifyContext>();
        context.Database.Migrate();
        DataSeeder.SeedData(context);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while seeding the database.");
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
