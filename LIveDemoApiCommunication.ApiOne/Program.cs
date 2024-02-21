using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("apiTwo", client => client.BaseAddress = new Uri("http://localhost:5126"));

builder.Services.AddFastEndpoints();

var app = builder.Build();

app.UseFastEndpoints();

app.Run();
