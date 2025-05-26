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
    public class FilterUser : Pagination
    {
        public FilterUser(int page, int pageSize) : base(page, pageSize)
        {
            this.Page = page;
            this.PageSize = pageSize;
        }

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

        public async Task<User?> GetByID(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        public async Task<ListResult<User>> GetAll(FilterUser filter)
        {
            var skip = (filter?.Page - 1 ?? 0) * (filter?.PageSize ?? 10);
            if (skip < 0) skip = 0;

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
            var total = await query.CountAsync();
            var data = await query.Skip(skip).Take(filter?.PageSize ?? 10).ToArrayAsync();

            return new ListResult<User>
            {
                Data = data,
                Total = total,
            };
        }
        public async Task Create(User dto)
        {
            _context.Users.Add(dto);
            await _context.SaveChangesAsync();
        }

        public async Task Update(User dto)
        {
            _context.Users.Update(dto);
            await _context.SaveChangesAsync();
        }

        public int Count()
        {
            return _context.Users.Count();
        }
    }
}
