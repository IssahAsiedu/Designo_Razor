using System.ComponentModel.DataAnnotations;

namespace Designo.Website.Models;
public class CoreValue
{
   
    public int Id { get; set; }

    [Required, MinLength(2)]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Img { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty;
}
