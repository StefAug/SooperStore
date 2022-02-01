using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto
{
    public class ComandaDto
    {
        public Cos Cos { get; set; }
        public List<Produs> Produse { get; set; } = new List<Produs>();
    }
}
