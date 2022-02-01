using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto
{
    class UserRoleDto
    {
        public User User { get; set; }
        public List<Rol> Roluri { get; set; } = new List<Rol>();
    }
}
