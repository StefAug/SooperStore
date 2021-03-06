using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IProdusRepository : IGenericRepository<Produs>
    {
        IEnumerable<Produs> GetPricierProducts(int count);
    }
}
