using FastEndpoints;

namespace LIveDemoApiCommunication.ApiOne.Endpoints.SayGoodbye;

public class SayGoodbyeHandler : Endpoint<EmptyRequest, SayGoodbyeResponse>
{
    public override void Configure()
    {
        Get("/bye");
        AllowAnonymous();
    }

    public override async Task HandleAsync(EmptyRequest req, CancellationToken ct)
    {
        SendAsync(new SayGoodbyeResponse() {Message = "Good Bye! from ApiOne!"}, cancellation: ct);
    }
}