using System.ComponentModel.DataAnnotations;

namespace HireLog.Data.Models;

public class ApplicationDetails
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateTime ApplicationDate { get; set; }
    public string? ApplicationLink { get; set; }
    public string? Letter { get; set; }
}