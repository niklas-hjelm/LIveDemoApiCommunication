using FastEndpoints;
using LIveDemoApiCommunication.Animals.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints();

builder.Services.AddSingleton<AnimalService>();

var app = builder.Build();

app.UseFastEndpoints();

app.Run();
