using Microsoft.AspNetCore.Identity;

namespace HairSalonManagement.Data;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = "";

    public string LastName { get; set; } = "";

    public DateTime RegistrationDate { get; set; }
        = DateTime.Now;

    public int? FavoriteStylistId { get; set; }
}