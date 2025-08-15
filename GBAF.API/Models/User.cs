using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GBAF.API.Models;

[Table("users")]
public class User : IdentityUser
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public DateTime CreateAt { get; set; } = DateTime.Now;
    public DateTime UpdateAt { get; set; } = DateTime.Now;
}
