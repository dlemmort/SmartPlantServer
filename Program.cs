using System.Configuration;
using System.Net;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Internal;
using SmartPlantServer.Contexts;
using SmartPlantServer.Mqtt;
using uPLibrary.Networking.M2Mqtt;

//Create mqtt client
PlantMqttClient client = new PlantMqttClient(IPAddress.Parse("192.168.1.78"));
string clientId = Guid.NewGuid().ToString();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<PlantMqttClient>(client);

builder.Services.AddDbContext<PlantContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MariaDbServerVersion(new Version()));
});

client.Connect(clientId);

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

