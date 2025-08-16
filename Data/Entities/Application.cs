using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HireLog.Data.Entities;

public class Application{
    [Key]
    public Guid Id { get; set; } // Primary Key
    public DateTime ApplicationDate { get; set; }
    public string ApplicationLink { get; set; } = string.Empty;
    public Guid Letter { get; set; }

    [Required]
    public Guid Cv { get; set; }
    public string Position { get; set; } = string.Empty;
    [Required]
    public string Company { get; set; } = string.Empty;
    [Required]
    public JobState State { get; set; }
}