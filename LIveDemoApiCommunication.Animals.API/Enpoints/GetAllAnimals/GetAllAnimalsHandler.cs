using FastEndpoints;

namespace LIveDemoApiCommunication.Animals.API.Enpoints.GetAllAnimals;

public class GetAllAnimalsHandler(AnimalService service) : Endpoint<EmptyRequest, GetAllAnimalsResponse>
{
    public override void Configure()
    {
        Get("/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(EmptyRequest req, CancellationToken ct)
    {
        SendAsync(new GetAllAnimalsResponse()
        {
            Animals = service.Animals
        }, cancellation:ct);
    }
}