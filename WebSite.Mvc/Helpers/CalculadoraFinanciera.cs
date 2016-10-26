using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Mvc.Helpers
{
    public class CalculadoraInteres
    {
        public int Deuda { get; set; }

        public int Pagado { get; set; }

        public int Tasa { get; set; }


        public static List<AmortizacionMensual> ObtenerAmortizacionAnual(double prestamo, double pie, float tasa, int plazo, double mensual)
        {
            var lista = new List<AmortizacionMensual>();

            var endingBalance = prestamo - pie;
            var rate = tasa / 1200.0;
            var monthly = rate > 0 ? ((rate + rate / (Math.Pow(1 + rate, plazo) - 1)) * endingBalance) : endingBalance / plazo;
            
            var count = 1;
            while (count <= mensual)
            {
                var interestPaid = endingBalance * rate;
                var principlePaid = mensual - interestPaid;
                endingBalance -= principlePaid;

                var pago = new AmortizacionMensual()
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
            return lista;
        }
    }
}
