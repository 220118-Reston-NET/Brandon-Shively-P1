global using Serilog;
using Microsoft.Extensions.Configuration;
using StarWarsBL;
using StarWarsDL;

var builder = WebApplication.CreateBuilder(args);
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("./logs/user.txt")
    .CreateLogger();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository>(repo => new SQLRepository(builder.Configuration.GetConnectionString("Reference2DB")));
builder.Services.AddScoped<IStarWarsStoreBL, StarWarsStoreBL>();

var app = builder.Build();
var log = new LoggerConfiguration();

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
