using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HireLog.Data.Models;

public class Job{
    [Key]
    public int Id { get; set; } // Primary Key
    [ForeignKey("Offer")]
    public int Offer { get; set; } // Foreign Key
    [ForeignKey("ApplicationDetails")]
    public int ApplicationDetails { get; set; } // Foreign Key

    [Required]
    public string? Position { get; set; }
    [Required]
    public string? Company { get; set; }
    [Required]
    public JobState State { get; set; }
}

public enum JobState { Saved, Applied, TestPhase, FirstInterview, SecondInterview, ThirdInterview, Rejected, Offer, Accepted } 