using FastEndpoints;
using LIveDemoApiCommunication.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PeopleDbContext>(
    options => 
        options.UseSqlServer("Data Source=LAPTOP-94UMSFPO;Initial Catalog=PeopleDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")
        );

builder.Services.AddHttpClient("apiTwo", client => client.BaseAddress = new Uri("http://localhost:5126"));

builder.Services.AddFastEndpoints();

var app = builder.Build();

app.UseFastEndpoints();

app.Run();
