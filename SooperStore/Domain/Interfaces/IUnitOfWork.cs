using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRolRepository Rols { get; }
        IUserRepository User { get; }
        IUserRolRepository UserRol { get; }
        int Complete();
    }
}
