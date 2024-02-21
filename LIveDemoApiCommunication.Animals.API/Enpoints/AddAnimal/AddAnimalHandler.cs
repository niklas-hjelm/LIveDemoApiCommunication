using FastEndpoints;

namespace LIveDemoApiCommunication.Animals.API.Enpoints.AddAnimal;

public class AddAnimalHandler(AnimalService service) : Endpoint<AddAnimalRequest, EmptyResponse>
{
    public override void Configure()
    {
        Post("/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(AddAnimalRequest req, CancellationToken ct)
    {
        service.Animals.Add(req.Animal);
        SendAsync(new EmptyResponse(), cancellation: ct);
    }
}