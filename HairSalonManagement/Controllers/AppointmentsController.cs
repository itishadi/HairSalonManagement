using HairSalonManagement.Data;
using HairSalonManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HairSalonManagement.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppointmentsController : ControllerBase
{
    private readonly ApplicationDbContext _db;

    public AppointmentsController(ApplicationDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult GetAppointments()
    {
        return Ok(
            _db.Appointments
                .Include(a => a.Service)
                .Include(a => a.Stylist)
                .ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetAppointment(int id)
    {
        var appointment = _db.Appointments
            .Include(a => a.Service)
            .Include(a => a.Stylist)
            .FirstOrDefault(a => a.AppointmentId == id);

        if (appointment == null)
            return NotFound();

        return Ok(appointment);
    }

    [HttpPost]
    public IActionResult CreateAppointment(Appointment appointment)
    {
        _db.Appointments.Add(appointment);

        _db.SaveChanges();

        return Ok(appointment);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAppointment(int id, Appointment appointment)
    {
        var existing = _db.Appointments.Find(id);

        if (existing == null)
            return NotFound();

        existing.AppointmentDate = appointment.AppointmentDate;
        existing.Status = appointment.Status;
        existing.ServiceId = appointment.ServiceId;
        existing.StylistId = appointment.StylistId;

        _db.SaveChanges();

        return Ok(existing);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAppointment(int id)
    {
        var appointment = _db.Appointments.Find(id);

        if (appointment == null)
            return NotFound();

        _db.Appointments.Remove(appointment);

        _db.SaveChanges();

        return Ok();
    }
}