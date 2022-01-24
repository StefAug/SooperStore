using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class CosRepository : GenericRepository<Cos>, ICosRepository
    {
        public CosRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
