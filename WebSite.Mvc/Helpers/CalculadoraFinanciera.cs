using System;
using System.Collections.Generic;
using WebSite.Mvc.Models;

namespace WebSite.Mvc.Helpers
{
    public class CalculadoraInteres
    {
        
        public static List<AmortizacionUnitaria> ObtenerAmortizacionAnual(double prestamo, double pie, double tasa, int plazo, double mensual)
        {
            var lista = new List<AmortizacionUnitaria>();

            var endingBalance = prestamo - pie;
            var rate = tasa / 1200.0;
            var monthly = rate > 0 ? ((rate + rate / (Math.Pow(1 + rate, plazo) - 1)) * endingBalance) : endingBalance / plazo;

            var count = 1;
            while (count <= mensual)
            {
                var interestPaid = endingBalance * rate;
                var principlePaid = mensual - interestPaid;
                endingBalance -= principlePaid;

                var pago = new AmortizacionUnitaria()
                {
                    Numero = count,
                    PagoInicial = String.Format("{0:C}", interestPaid),
                    CapitalPagado = String.Format("{0:C}",
                          principlePaid),
                    Saldo = String.Format("{0:C}", endingBalance)
                };

                lista.Add(pago);
                count++;
            }
            //lista.Add(new AmortizacionUnitaria() { Numero = 1, CapitalPagado = "2000", PagoInicial = "100", Saldo = "0" });
            return lista;
        }
    }
}
