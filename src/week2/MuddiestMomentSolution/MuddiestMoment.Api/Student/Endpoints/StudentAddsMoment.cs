using Marten;
using Microsoft.AspNetCore.Http.HttpResults;

namespace MuddiestMoment.Api.Student.Endpoints;

public static class StudentAddsMoment
{
    public static async Task<Ok<StudentMomentResponseModel>> AddMoment(
        StudentMomentCreateModel request, IDocumentSession session)
    {
        var response = new StudentMomentResponseModel
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            Description = request.Description,
            CreatedOn = DateTimeOffset.UtcNow,
            AddedBy = "fake user" // TODO: We need the ID of the actual user that made this request.
        };

        // saving it to the database.
        var entity = new StudentMomentEntity
        {
            // mapping 
            Id = response.Id,
            Title = response.Title,
            Description = response.Description,
            AddedBy = response.AddedBy,
            CreatedOn = response.CreatedOn
        };

        // will vary depending on what libarary/database you are using.
        session.Store(entity); // this connection running this code wants to as part of this operation,
        // store this entity.
        // list of things that this "means" - Transaction -- all of this has to happen or none of it does.

        await session.SaveChangesAsync();


        return TypedResults.Ok(response);
    }
}

