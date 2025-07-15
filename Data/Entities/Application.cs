using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HireLog.Data.Entities;

public class Application{
    [Key]
    public Guid Id { get; set; } // Primary Key
    public DateTime ApplicationDate { get; set; }
    public string? ApplicationLink { get; set; }
    public string? Letter { get; set; }

    [Required]
    public string? Position { get; set; }
    [Required]
    public string? Company { get; set; }
    [Required]
    public JobState State { get; set; }
}