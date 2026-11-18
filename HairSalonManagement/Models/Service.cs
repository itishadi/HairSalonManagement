using System.ComponentModel.DataAnnotations;

namespace HairSalonManagement.Models;

public class Service
{
    public int ServiceId { get; set; }

    [Required]
    public string Name { get; set; } = "";

    public string Description { get; set; } = "";

    [Range(0.01, 10000)]
    public decimal Price { get; set; }

    public int DurationMinutes { get; set; }

    public string Category { get; set; } = "";

    public bool IsActive { get; set; } = true;
}