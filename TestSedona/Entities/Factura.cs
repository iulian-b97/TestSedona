using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSedona.Entities
{
    public class Factura
    {
        public int Id { get; set; }
        public string NrFactura { get; set; }
        public DateTime Data { get; set; }
        public decimal ValoareFaraTVA { get; set; }
        public decimal Tva { get; set; }
        public decimal ValoareCuTva { get; set; }

        public List<DetaliiFactura> DetaliiFactura { get; set; }
    }
}
