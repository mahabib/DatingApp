using API.Services;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    UserService _service;
    
    public UsersController(UserService service)
    {
       _service = service;
    }

    [HttpGet]
    public IEnumerable<User> GetUsers()
    {
        return _service.GetUsers();
    }

    [HttpGet("{id}")]
    public ActionResult<User> GetUser(int id)
    {
        var user = _service.GetUser(id);

        if(user is not null)
        {
            return user;
        }
        else
        {
            return NotFound();
        }
    }

}