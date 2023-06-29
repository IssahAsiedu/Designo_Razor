using System.ComponentModel.DataAnnotations;

namespace Designo.Website.Models;


public class DesignCategory
{
    public int Id { get; set; }

    [Required, MinLength(2)]
    public string Name { get; set; } = String.Empty;

    public string Img { get; set; } = string.Empty;
}

