using System.ComponentModel.DataAnnotations;

namespace HireLog.Models;

public class Job{
    public int Id {get;set;}
    public DateTime ApplicationDate { get; set; }
    public string? ApplicationLink { get; set; }

    [Required]
    public string? Position { get; set; }
    public string? Company { get; set; }
    public JobState State { get; set; }
}
public enum JobState { Saved, Applied, TestPhase, FirstInterview, SecondInterview, ThirdInterview, Rejected, Offer, Accepted } 