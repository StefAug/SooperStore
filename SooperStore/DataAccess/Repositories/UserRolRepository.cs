using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
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
    }
}
