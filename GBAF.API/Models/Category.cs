using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBAF.API.Models;

[Table("Categories")]
public class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [Required]
    [StringLength(7)]
    public string Color { get; set; } = "#000000";

    [Required]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }

    public DateTime CreateAt { get; set; } = DateTime.Now;
    public DateTime UpdateAt { get; set; } = DateTime.Now;
}
