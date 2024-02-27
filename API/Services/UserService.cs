using API.Models;
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services;

public class UserService
{
    private readonly AppDbContext _context;
    public UserService(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetUsers()
    {
        return _context.Users
            .AsNoTracking()
            .ToList();
    }

    public User? GetUser(int id)
    {
        return _context.Users
            .AsNoTracking()
            .SingleOrDefault(p => p.Id == id);
    }
}