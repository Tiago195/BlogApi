using System.ComponentModel.DataAnnotations;

namespace Blog.Model;

public class Category
{
  [Key]
  public int Id { get; set; }

  [Required(ErrorMessage = "Name is required.")]
  [MaxLength(30, ErrorMessage = "O campo Name tem que ter no maximo 30 caracteres.")]
  public string Name { get; set; }
  public ICollection<BlogPost> Posts { get; set; }
}