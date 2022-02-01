using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUserRolRepository : IGenericRepository<UserRol>
    {
        IEnumerable<Rol> GetRolesByUserId(int id);
    }
}
