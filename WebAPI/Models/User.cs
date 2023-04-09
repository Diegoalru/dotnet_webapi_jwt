using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models;
public class User
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "This field is required")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "This field is required")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "This field is required")]
    public string? Password { get; set; }
}
