var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("apiTwo", client => client.BaseAddress = new Uri("http://localhost:5126"));

var app = builder.Build();

app.MapGet("/", () => "Hello from ApiOne!");

app.MapGet("/callApiTwo", async (IHttpClientFactory clientFactory) =>
{
    var client = clientFactory.CreateClient("apiTwo");
    var response = await client.GetAsync("/");
    return await response.Content.ReadAsStringAsync();
});

app.Run();
