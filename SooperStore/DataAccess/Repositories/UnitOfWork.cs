using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    //public class UnitOfWork : IUnitOfWork
    //{
    //    private readonly ApplicationContext _context;
    //    public UnitOfWork(ApplicationContext context)
    //    {
    //        _context = context;
    //        Rols = new RolRepository(_context);
    //        User = new UserRepository(_context);
    //        UserRol = new UserRolRepository(_context);    
    //    }
    //    IRolRepository Rols { get; }
    //    IUserRepository User { get; }
    //    IUserRolRepository UserRol { get; }
    //    public int Complete()
    //    {
    //        return _context.SaveChanges();
    //    }
    //    public void Dispose()
    //    {
    //        _context.Dispose();
    //    }
    //}
}
