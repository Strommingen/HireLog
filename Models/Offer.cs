using System.ComponentModel.DataAnnotations;

namespace HireLog.Models;

public class Offer
{
    public int ID { get; set; }
    public int Pay { get; set; }
    public DateTime StartDate { get; set; }
}