using System.ComponentModel.DataAnnotations;

namespace MuddiestMoment.Api.Student.Endpoints;

public record StudentMomentCreateModel
{
    [MinLength(3), MaxLength(50)]
    public required string Title { get; set; } = string.Empty;
    [MaxLength(150)]
    public string Description { get; set; } = string.Empty;
}

