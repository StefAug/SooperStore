using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Produs
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int Stoc { get; set; }
        public double Pret { get; set; }
        public virtual Comanda Comanda { get; set; }
    }
}
