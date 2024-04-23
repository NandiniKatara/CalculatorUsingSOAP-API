using CalculatorUsingSOAP.Models;
using CalculatorUsingSOAP.Services;
using SoapCore;
using static CalculatorUsingSOAP.Controllers.CalculationsController;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<InterfaceCalculator, CalculationService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSoapEndpoint<InterfaceCalculator>("/Calculator.asmx", new SoapEncoderOptions());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
