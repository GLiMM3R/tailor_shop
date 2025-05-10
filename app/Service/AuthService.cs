using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Database;
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

        public async Task<bool> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);

            if (user == null)
            {
                return false;
            }

            return PasswordHasher.VerifyPassword(password, user.Password, user.Salt);
        }
    }
}
