using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSedona.Entities;

namespace TestSedona.Data
{
    public class DataBaseInitializer 
    {
        List<Produs> produse = new List<Produs>();
        List<Factura> facturi = new List<Factura>();

        public void Seed(SedonaContext context)
        {
            produse = new List<Produs>
            {
                new Produs
                {
                    Denumire = "Datecs DP05",
                    Pret = 599.99m
                },
                new Produs
                {
                    Denumire = "Partner 600 WiFi",
                    Pret = 910.00m
                },
                new Produs
                {
                    Denumire = "Partner 200 WiFi",
                    Pret = 920.00m
                },
                new Produs
                {
                    Denumire = "Datecs DP150",
                    Pret = 900.00m
                },
                new Produs
                {
                    Denumire = "Datecs WP50",
                    Pret = 849.99m
                }
            };
            var all_p = context.Produs.ToList();
            context.Produs.RemoveRange(all_p);
            produse.ForEach(p => context.Produs.Add(p));

            facturi = new List<Factura>
            {
                new Factura
                {
                    NrFactura = "A23F",
                    Data = Convert.ToDateTime("2022-01-01 00:00:00.000"),
                    ValoareFaraTVA = 1400.0000m,
                    Tva = 200.00m,
                    ValoareCuTva = 1600.00m
                },
                new Factura
                {
                    NrFactura = "BDS2",
                    Data = Convert.ToDateTime("2022-01-11 00:00:00.000"),
                    ValoareFaraTVA = 1350.0000m,
                    Tva = 470.00m,
                    ValoareCuTva = 1820.00m
                },
                new Factura
                {
                    NrFactura = "DGA2",
                    Data = Convert.ToDateTime("2022-01-21 00:00:00.000"),
                    ValoareFaraTVA = 8040.0000m,
                    Tva = 3000.00m,
                    ValoareCuTva = 11040.00m
                },
                new Factura
                {
                    NrFactura = "32AH",
                    Data = Convert.ToDateTime("2022-01-30 00:00:00.000"),
                    ValoareFaraTVA = 4350.0000m,
                    Tva = 1110.00m,
                    ValoareCuTva = 5460.00m
                },
                new Factura
                {
                    NrFactura = "551F",
                    Data = Convert.ToDateTime("2022-02-15 00:00:00.000"),
                    ValoareFaraTVA = 4470.0000m,
                    Tva = 1480.00m,
                    ValoareCuTva = 5950.00m
                },
            };
            var all_f = context.Factura.ToList();
            context.Factura.RemoveRange(all_f);
            facturi.ForEach(p => context.Factura.Add(p));

            context.SaveChanges();
        }


        public void Seed2(SedonaContext context)
        {
            List<DetaliiFactura> detaliiFact = new List<DetaliiFactura>
            {
                new DetaliiFactura
                {
                    IdProdus = produse[4].Id,
                    Cantitate = 3.000m,
                    Pret = 1600.00m,
                    IdFactura = facturi[4].Id
                },
                new DetaliiFactura
                {
                    IdProdus = produse[3].Id,
                    Cantitate = 3.000m,
                    Pret = 1820.00m,
                    IdFactura = facturi[3].Id
                },
                new DetaliiFactura
                {
                    IdProdus = produse[2].Id,
                    Cantitate = 12.000m,
                    Pret = 11040.00m,
                    IdFactura = facturi[2].Id
                },
                new DetaliiFactura
                {
                    IdProdus = produse[1].Id,
                    Cantitate = 6.000m,
                    Pret = 5460.00m,
                    IdFactura = facturi[1].Id
                },
                new DetaliiFactura
                {
                    IdProdus = produse[0].Id,
                    Cantitate = 7.000m,
                    Pret = 5950.00m,
                    IdFactura = facturi[0].Id
                }
            };
            var all_d = context.DetaliiFactura.ToList();
            context.DetaliiFactura.RemoveRange(all_d);
            detaliiFact.ForEach(p => context.DetaliiFactura.Add(p));

            context.SaveChanges();
        }
    }
}
