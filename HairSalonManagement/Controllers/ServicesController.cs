using HairSalonManagement.Data;
using HairSalonManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HairSalonManagement.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicesController : ControllerBase
{
    private readonly ApplicationDbContext _db;

    public ServicesController(ApplicationDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult GetServices()
    {
        return Ok(_db.Services.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetService(int id)
    {
        var service = _db.Services.Find(id);

        if (service == null)
            return NotFound();

        return Ok(service);
    }

    [HttpPost]
    public IActionResult CreateService(Service service)
    {
        _db.Services.Add(service);

        _db.SaveChanges();

        return Ok(service);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateService(int id, Service service)
    {
        var existing = _db.Services.Find(id);

        if (existing == null)
            return NotFound();

        existing.Name = service.Name;
        existing.Description = service.Description;
        existing.Price = service.Price;
        existing.DurationMinutes = service.DurationMinutes;
        existing.Category = service.Category;
        existing.IsActive = service.IsActive;

        _db.SaveChanges();

        return Ok(existing);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteService(int id)
    {
        var service = _db.Services.Find(id);

        if (service == null)
            return NotFound();

        _db.Services.Remove(service);

        _db.SaveChanges();

        return Ok();
    }
}