using FastEndpoints;

namespace LIveDemoApiCommunication.ApiOne.Endpoints.SayHello;

public class SayHelloHandler(IHttpClientFactory factory) : Endpoint<EmptyRequest, SayHelloResponse>
{
    public override void Configure()
    {
        Get("/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(EmptyRequest req, CancellationToken ct)
    {

        SendAsync(new SayHelloResponse { Message = "Hello from ApiOne" });
    }
}