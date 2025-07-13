using System.ComponentModel.DataAnnotations;

namespace HireLog.Models;

public class ApplicationDetails
{
    public int ID { get; set; }
    public DateTime ApplicationDate { get; set; }
    public string? ApplicationLink { get; set; }
    public string? Letter { get; set; }
}