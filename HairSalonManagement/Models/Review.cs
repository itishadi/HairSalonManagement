namespace HairSalonManagement.Models;

public class Review
{
    public int ReviewId { get; set; }

    public string CustomerId { get; set; } = "";

    public int StylistId { get; set; }

    public int Rating { get; set; }

    public string Comment { get; set; } = "";

    public DateTime CreatedDate { get; set; }
        = DateTime.Now;
}