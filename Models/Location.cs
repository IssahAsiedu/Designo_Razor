namespace Designo.Website.Models;
public class Location
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Street { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string? Branch { get; set; }

    public string? Img { get; set; }

    public String? Map { get; set; }
}
