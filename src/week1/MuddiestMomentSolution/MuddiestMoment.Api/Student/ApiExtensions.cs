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
            // 1 hypocritical 
            // 2 "slimed" - 
            var group = endpoints.MapGroup("/student/moments");
            // if any http post methods come in for /student/moments run this function
            group.MapPost("", StudentAddsMoment.AddMoment);
            group.MapGet("", StudentGetsListOfSavedMoments.GetAllMomentsForStudent);
            // DELETE /student/moments/???
            group.MapDelete("/{id:guid}", StudentMarksMomentAnswered.MarkQuestionAnswered);


            // TODO /student/answered-questions
            return group;
        }
    }
}





