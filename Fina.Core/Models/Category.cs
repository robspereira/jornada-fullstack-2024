namespace Fina.Core.Models;

public class Category
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; }
    public string? Description { get; set; } = string.Empty;
    public string userId { get; set; } = string.Empty;

}