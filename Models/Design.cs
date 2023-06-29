using System.ComponentModel.DataAnnotations;

namespace Designo.Website.Models;
public class Design
{
    public int Id { get; set; }

    [Required, MinLength(2)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public int DesignCategoryId { get; set; }

    [MinLength(5), DataType(DataType.Text)]
    public string Description { get; set; } = string.Empty;

    [Required]
    public string Img { get; set; } = string.Empty;

}
