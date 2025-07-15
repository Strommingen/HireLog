using System.ComponentModel.DataAnnotations;

namespace HireLog.Data.Entities;

public class Offer
{
    [Key]
    public int Id { get; set; }
    public int Pay { get; set; }
    public DateTime StartDate { get; set; }
}