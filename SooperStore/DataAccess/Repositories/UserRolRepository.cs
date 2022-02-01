using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class UserRolRepository : GenericRepository<UserRol>, IUserRolRepository
    {
        ApplicationContext _dbContext;
        public UserRolRepository(ApplicationContext context) : base(context)
        {
            _dbContext = context;
        }

        public IEnumerable<Rol> GetRolesByUserId(int id)
        {
            var items = _context.UserRols.Include(x => x.Rol).Where(x => x.IdUser == id).Select(x => x.Rol).ToList();
            return items;
        }
    }
}
