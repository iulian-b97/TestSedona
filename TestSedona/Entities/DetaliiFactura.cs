using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSedona.Entities
{
    public class DetaliiFactura
    {
        public int Id { get; set; }
        public int IdProdus { get; set; }
        public Produs Produs { get; set; }
        public decimal Cantitate { get; set; }
        public decimal Pret { get; set; }
        public int IdFactura { get; set; }
        public Factura Factura { get; set; }
    }
}
