using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSedona.Entities
{
    public class Produs
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public decimal Pret { get; set; }

        public List<DetaliiFactura> DetaliiFactura { get; set; }
    }
}
