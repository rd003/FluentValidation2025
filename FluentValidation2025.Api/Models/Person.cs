using System.ComponentModel.DataAnnotations;

namespace FluentValidation2025.Api.Models;

public class Person
{
    [Required]
    public int? Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Name { get; set; }

    [Required]
    [MaxLength(50)]
    [EmailAddress]
    
    public string? Email { get; set; }
    [Required]
    
    public int? Age { get; set; }
}
