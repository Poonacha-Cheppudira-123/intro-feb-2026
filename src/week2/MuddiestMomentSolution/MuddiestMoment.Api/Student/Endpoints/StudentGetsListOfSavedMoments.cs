using Marten;

namespace MuddiestMoment.Api.Student.Endpoints;

public static  class StudentGetsListOfSavedMoments
{

    // session here is this particular requests list stuff to do to the database.
    // it does NONE of that until you call "save changes" 
    // When you do that, it will ALL the things you want, or NONE of the things. That is a transaction.
    public static async Task<IResult> GetAllMomentsForStudent(IDocumentSession session)
    {
        var moments = await session.Query<StudentMomentEntity>()
            .Where(m => m.AddedBy == "fake user" && m.IsAnswered == false)
            .Select(m => new StudentMomentResponseModel
            {
                Id = m.Id,
                AddedBy = m.AddedBy,
                CreatedOn = m.CreatedOn,
                Description = m.Description,
                Title = m.Title
            })
            // this needs to be the ID of the person making this request.
            .ToListAsync();

        return TypedResults.Ok(moments);
    }
}
