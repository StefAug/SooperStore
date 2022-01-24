using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class UserRolRepository : GenericRepository<UserRol>, IUserRolRepository
    {
        public UserRolRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
