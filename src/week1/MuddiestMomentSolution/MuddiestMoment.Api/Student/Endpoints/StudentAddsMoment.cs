using Microsoft.AspNetCore.Http.HttpResults;

namespace MuddiestMoment.Api.Student.Endpoints;

    public static class StudentAddsMoment
    {
        public static async Task<Ok<StudentMomentResponseModel>> AddMoment(StudentMomentCreateModel request)
        {
            var response = new StudentMomentResponseModel
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Description = request.Description,
                CreatedOn = DateTimeOffset.UtcNow,
                AddedBy = "fake user"
            };
         

            return TypedResults.Ok(response);
        }
    }

