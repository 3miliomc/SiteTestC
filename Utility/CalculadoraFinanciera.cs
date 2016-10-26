using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitario
{
    public class CalculadoraInteres
    {
        public int Deuda { get; set; }

        public int Pagado { get; set; }

        public int Tasa { get; set; }


        public static List<AmortizacionMensual> ObtenerAmortizacionAnual(int prestamo, float tasa, int plazo)
        {
            var lista = new List<AmortizacionMensual>();

            double cuotas = (prestamo * tasa) / 12;

            double interes = 1 - Math.Pow(1 + tasa / 12, plazo);

            for (int p = 0; p < plazo; p++)
            {
                var pago = new AmortizacionMensual()
                {
                    Numero = p + 1,
                    Cuota = cuotas,
                    Interes = interes,
                    Capital = prestamo - interes,
                    Saldo = prestamo - cuotas
                };

                lista.Add(pago);
            }

            return lista;
        }
    }
}
