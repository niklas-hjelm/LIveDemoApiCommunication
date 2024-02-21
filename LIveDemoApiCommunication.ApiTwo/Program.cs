using LIveDemoApiCommunication.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PeopleDbContext>(
    options =>
        options.UseSqlServer("Data Source=LAPTOP-94UMSFPO;Initial Catalog=PeopleDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")
);


var app = builder.Build();

app.MapGet("/", () => "Hello from ApiTwo!");

app.MapGet("/person", (PeopleDbContext context) =>
{
    return context.People;
});

app.Run();
