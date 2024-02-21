using FastEndpoints;
using LIveDemoApiCommunication.DataAccess;

namespace LIveDemoApiCommunication.ApiOne.Endpoints.AddPerson;

public class AddPersonHandler(PeopleDbContext context) : Endpoint<AddPersonRequest,EmptyResponse>
{
    public override void Configure()
    {
        Post("/person");
        AllowAnonymous();
    }

    public override async Task HandleAsync(AddPersonRequest req, CancellationToken ct)
    {
        await context.People.AddAsync(req.Person, cancellationToken: ct);
        await context.SaveChangesAsync(cancellationToken: ct);

        SendAsync(new EmptyResponse(), cancellation:ct);
    }
}