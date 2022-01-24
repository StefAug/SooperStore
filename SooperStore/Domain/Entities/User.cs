using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public virtual ICollection<UserRol> UserRols { get; set; }
        public virtual Cos Cos { get; set; }

    }
}
