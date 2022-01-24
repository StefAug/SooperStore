using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Cos
    {
        public int Id { get; set; }
        
        public int IdUser { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Produs> Produse { get; set; }

    }
}
