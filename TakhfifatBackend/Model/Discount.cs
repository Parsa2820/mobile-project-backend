namespace Model;

public record Discount
{
    public string? Title { get; init; }
    public string? Description { get; init; }
    public string? ImageUrl { get; init; }
    public string? Link { get; init; }
    public string? Category { get; init; }
    public string? EndDate { get; init; }
    public string? Code { get; init; }
}