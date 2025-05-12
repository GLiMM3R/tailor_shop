using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Database;
using app.Model;
using Microsoft.EntityFrameworkCore;

namespace app.Service
{
    public class FilterUser
    {
        public int? Id { get; set; }
        public string? Username { get; set; }

        public Role? Role { get; set; }
    }

    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            this._context = context;
        }

        public User? GetByID(int id)
        {
            var user =  _context.Users.FirstOrDefault(x => x.Id == id);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        public async Task<User[]> GetAll(FilterUser filter)
        {
            IQueryable<User> query = _context.Users.AsQueryable();

            if (filter != null)
            {
                if (filter.Id.HasValue)
                {
                    query = query.Where(c => c.Id == filter.Id.Value);
                }

                if (!string.IsNullOrEmpty(filter.Username))
                {
                    query = query.Where(c => c.Username != null && c.Username.ToLower().Contains(filter.Username.ToLower()));
                }

                if (filter.Role.HasValue)
                {
                    query = query.Where(c => c.Role == filter.Role.Value);
                }
            }

            return await query.ToArrayAsync();
        }
        public void Create(User dto)
        {
            _context.Users.Add(dto);
             _context.SaveChanges();
        }

        public void Update(User dto)
        {
            _context.Users.Update(dto);
             _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Users.Count();
        }
    }
}
