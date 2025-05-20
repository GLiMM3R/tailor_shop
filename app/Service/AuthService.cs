using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Database;
using app.Model;
using app.Utils;
using Microsoft.EntityFrameworkCore;

namespace app.Service
{
    public class AuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<User?> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);

            if (user == null)
            {
                return null;
            }

            var isMatch = PasswordHasher.VerifyPassword(password, user.Password, user.Salt);

            if (!isMatch)
            {
                return null;
            }

            return user;
        }
    }
}
