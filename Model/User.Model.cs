using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace Blog.Model;

public class Login
{
  [Required(ErrorMessage = "Some required fields are missing.")]
  [MaxLength(255, ErrorMessage = "o campo Email deve conter entre 3 e 250 caracteres")]
  [MinLength(8, ErrorMessage = "o campo Email deve conter entre 3 e 250 caracteres")]
  [EmailAddress]
  public string Email { get; set; }
  [Required(ErrorMessage = "Some required fields are missing")]
  [MaxLength(255, ErrorMessage = "o campo Password deve conter entre 3 e 250 caracteres")]
  [MinLength(6, ErrorMessage = "o campo Password deve conter entre 6 e 250 caracteres")]
  public string Password { get; set; }
}

public class User
{
  [Key]
  public int Id { get; set; }

  [Required(ErrorMessage = "DisplayName is required.")]
  [MaxLength(255, ErrorMessage = "o campo DisplayName deve conter entre 3 e 250 caracteres")]
  [MinLength(3, ErrorMessage = "o campo DisplayName deve conter entre 3 e 250 caracteres")]
  public string DisplayName { get; set; }

  [Required(ErrorMessage = "Email is required.")]
  [MaxLength(255, ErrorMessage = "o campo Email deve conter entre 3 e 250 caracteres")]
  [MinLength(8, ErrorMessage = "o campo Email deve conter entre 3 e 250 caracteres")]
  [EmailAddress]
  public string Email { get; set; }

  [Required(ErrorMessage = "Password is required.")]
  [MaxLength(255, ErrorMessage = "o campo Password deve conter entre 3 e 250 caracteres")]
  [MinLength(6, ErrorMessage = "o campo Password deve conter entre 6 e 250 caracteres")]
  public string Password { get; set; }

  public string? Image { get; set; }

  public ICollection<BlogPost> Posts { get; set; }
}