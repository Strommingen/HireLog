using System.ComponentModel.DataAnnotations;

namespace HireLog.Models;

public class Job{
    public int Id { get; set; } // Primary Key
    public int Offer { get; set; } // Foreign Key
    public int ApplicationDetails { get; set; } // Foreign Key

    [Required]
    public string? Position { get; set; }
    [Required]
    public string? Company { get; set; }
    [Required]
    public JobState State { get; set; }
}

public enum JobState { Saved, Applied, TestPhase, FirstInterview, SecondInterview, ThirdInterview, Rejected, Offer, Accepted } 