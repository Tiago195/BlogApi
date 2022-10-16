// using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Model;

public class BlogPost
{
  [Key]
  public int Id { get; set; }
  [Required]
  public string Title { get; set; }
  [Required]
  public string Content { get; set; }
  [Required]
  [ForeignKey("Id")]
  public int UserId { get; set; }
  public DateTime Published { get; set; } = DateTime.Now;
  public DateTime Updated { get; set; } = DateTime.Now;
  public ICollection<Category> Categories { get; set; }
}