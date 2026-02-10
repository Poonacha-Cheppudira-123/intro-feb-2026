using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace MuddiestMoment.Api.Student.Endpoints;

public record StudentMomentCreateModel
{
    [MinLength(3), MaxLength(50)]
    public required string Title { get; set; } = string.Empty;
    [MaxLength(150)]
    public string Description { get; set; } = string.Empty;
}

public record StudentMomentResponseModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string AddedBy { get; set; }
    public DateTimeOffset CreatedOn { get; set; }
}

public static class StudentAddsMoment
{
    public static async Task<Ok<StudentMomentResponseModel>> AddMoment(StudentMomentCreateModel request)
    {
        // Get the data sent from the user
        // Make sure they are authenticated
        // add that to database
        // Send a receipt
        // this will return an empty 200 Ok status code to the app that called this.
        var response = new StudentMomentResponseModel
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            Description = request.Description,
            CreatedOn = DateTimeOffset.UtcNow,
            AddedBy = "fake user"
        };
           // Add it to the database and make sure it saves.
        return TypedResults.Ok(response);
    }
}
