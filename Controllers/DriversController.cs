using System;
using Microsoft.AspNetCore.Mvc;
using DockerApp.Data;
using DockerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerApp.Controllers;

[ApiController]
[Route("[controller]")]

public class DriversController : ControllerBase
{
  private readonly ILogger<DriversController> _logger;
  private readonly ApiDbContext _context;

  public DriversController(ILogger<DriversController> logger,
    ApiDbContext context)
  {
    _logger = logger;
    _context = context;
  }

  [HttpGet(Name = "GetAllDrivers")]
  public async Task<IActionResult> Get()
  {
    var driver = new Driver()
    {
      DriverNumber = 44,
      Name = "Sir Lewis Hamilton"
    };

    _context.Add(driver);
    await _context.SaveChangesAsync();

    var allDrivers = await _context.Drives.ToListAsync();

    return Ok(allDrivers);
  }
}

