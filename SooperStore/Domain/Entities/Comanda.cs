using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Comanda
    {
        public int IdProdus { get; set; }
        public Produs Produs { get; set; }

        public int IdCos { get; set; }
        public Cos Cos { get; set; }
    }
}
