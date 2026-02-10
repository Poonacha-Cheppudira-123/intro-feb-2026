using MuddiestMoment.Api.Student.Endpoints;

namespace MuddiestMoment.Api.Student;

public static class ApiExtensions
{
    extension(IEndpointRouteBuilder endpoints)
    {
        // POST /students/moments
        // GET /student/moments
        public IEndpointRouteBuilder MapStudentEndpoints()
        {
            var group = endpoints.MapGroup("/student/moments");
            group.MapPost("", StudentAddsMoment.AddMoment);
            return group;
        }
    }
}
