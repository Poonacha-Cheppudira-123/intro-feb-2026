using Marten;

namespace MuddiestMoment.Api.Student.Endpoints;

public static class StudentMarksMomentAnswered
{

    // Who? Authorization..
    // Which questions (that id)
    // Policy
    // - You should only be able to do this for a question you own or created.
    public static async Task<IResult> MarkQuestionAnswered(Guid id, IDocumentSession session)
    {

        // delete that question from the database.
        // see if we can find that moment, and if we do, "flag it" as answered.
        var savedMoment = await session.Query<StudentMomentEntity>()
            .Where(m => m.Id == id)
            .SingleOrDefaultAsync();
        
        if (savedMoment is null)
        {

            return TypedResults.Ok();
        }
        // if the moment exist for this user with this id, update in the database and mark it as answered.
        savedMoment.IsAnswered = true;
        session.Store(savedMoment);
        await session.SaveChangesAsync();
        return TypedResults.Ok();
    }
}
