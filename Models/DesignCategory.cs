using System.ComponentModel.DataAnnotations;

namespace Designo.Website.Models;


public class DesignCategory
{
    public int Id { get; set; }

    [Required, MinLength(2)]
    public string? Name { get; set; }

    public string Img { get; set; } = string.Empty;

    public string? SvgBackground { get; set; }

    public string Description { get; set; } = string.Empty;
}

