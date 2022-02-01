using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class ProdusRepository : GenericRepository<Produs>, IProdusRepository
    {
        public ProdusRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Produs> GetPricierProducts(int count)
        {
            return _context.Produse.OrderByDescending(d => d.Stoc).Take(count).ToList();
        }

    }
}
