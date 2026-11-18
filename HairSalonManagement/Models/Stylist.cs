using System.ComponentModel.DataAnnotations;

namespace HairSalonManagement.Models;

public class Stylist
{
    public int StylistId { get; set; }

    [Required]
    public string FirstName { get; set; } = "";

    [Required]
    public string LastName { get; set; } = "";

    public string Email { get; set; } = "";

    public string PhoneNumber { get; set; } = "";

    public string Specialization { get; set; } = "";

    public int YearsOfExperience { get; set; }

    public bool IsAvailable { get; set; } = true;

    public string Bio { get; set; } = "";
}