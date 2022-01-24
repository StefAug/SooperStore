using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public virtual ICollection<UserRol> UserRols { get; set; }
    }
}
