#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstConnection.Models;

public class Pet
{
    [Key]
    [Required]
    public int PetId { get; set; }
    [Required]
    public string Name { get; set; } 
    [Required]
    public int Age { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    public bool HasFur { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}