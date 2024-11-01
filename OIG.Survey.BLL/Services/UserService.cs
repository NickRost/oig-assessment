using Microsoft.EntityFrameworkCore;
using OIG.Survey.DLL;
using OIG.Survey.DLL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OIG.Survey.BLL.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ApplicationUser>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<ApplicationUser> GetUserById(string id)
        {
            return await _context.Users.FindAsync(id);
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
