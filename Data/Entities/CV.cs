using System.ComponentModel.DataAnnotations;

namespace HireLog.Data.Entities;

public class Cv
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public int Size { get; set; }
    [Required]
    public string Extension { get; set; } = string.Empty;
    [Required]
    public string Name { get; set; } = string.Empty; // change the name from the upload (security reasons)
    public string DisplayName { get; set; } = string.Empty; // for displaying on the site, should be sanitized upon upload
}