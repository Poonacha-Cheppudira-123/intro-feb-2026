namespace MuddiestMoment.Api.Student.Endpoints;

public record StudentMomentResponseModel
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string AddedBy { get; set; } = string.Empty;
    public DateTimeOffset CreatedOn { get; set; }
}
