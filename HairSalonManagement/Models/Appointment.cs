using HairSalonManagement.Data;

namespace HairSalonManagement.Models;

public class Appointment
{
    public int AppointmentId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string CustomerId { get; set; } = "";

    public ApplicationUser? Customer { get; set; }

    public int ServiceId { get; set; }

    public Service? Service { get; set; }

    public int StylistId { get; set; }

    public Stylist? Stylist { get; set; }

    public string Status { get; set; } = "Pending";

    public string? Notes { get; set; }
}