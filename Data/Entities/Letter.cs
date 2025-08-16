using System.ComponentModel.DataAnnotations;

namespace HireLog.Data.Entities;

public class Letter
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public int Size { get; set; }
    [Required]
    public string Extension { get; set; } = string.Empty;
    [Required]
    public string Name { get; set; } = string.Empty;
}