using FastEndpoints;

namespace LIveDemoApiCommunication.Animals.API.Enpoints.GetAnimalById;

public class GetAnimalByIdHandler(AnimalService service) : Endpoint<GetAnimalByIdRequest,GetAnimalByIdResponse>
{
    public override void Configure()
    {
        Get("/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetAnimalByIdRequest req, CancellationToken ct)
    {
        var animal = service.Animals[req.Id];
        SendAsync(new GetAnimalByIdResponse() {Animal = animal}, cancellation: ct);
    }
}