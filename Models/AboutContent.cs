using System.ComponentModel.DataAnnotations;

namespace Designo.Website.Models;
public class AboutContent
{
    public int Id { get; set; }

    [Required, MinLength(2)]
    public string Title { get; set; } = string.Empty;

    public string Intro { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    [Required, MinLength(2)]
    public string Img { get; set; } = string.Empty;
}
