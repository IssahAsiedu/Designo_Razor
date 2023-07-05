using System.ComponentModel.DataAnnotations;

namespace Designo.Website.Models;
public class Customer
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Can't be empty"), EmailAddress(ErrorMessage = "Can't be empty")]
    public string? Email { get; set; }

    [Required]
    public string? Phone { get; set; }

    [Required, MinLength(3)]
    public string? Message { get; set; }
}
