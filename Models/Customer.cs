using System.ComponentModel.DataAnnotations;

namespace Designo.Website.Models;
public class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    [Required(ErrorMessage = "Can't be empty"), EmailAddress(ErrorMessage = "Can't be empty")]
    public string? Email { get; set; }

    public string? Phone { get; set; }

    [MinLength(20)]
    public string? Message { get; set; }
}
