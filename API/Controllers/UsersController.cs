using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.EventLog;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> Get()
    {
        return _context.Users.ToList();
    }

    [HttpGet("{id:int}")]
    public ActionResult<AppUser> Get(int id)
    {
        Console.WriteLine($"id: {id}");

        return _context.Users.Find(id);;
    }
}
