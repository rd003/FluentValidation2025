using System.ComponentModel.DataAnnotations;

namespace FluentValidation2025.Api.Models;

public class Person
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public int? Age { get; set; }
    public string? Password { get; set; }
}
