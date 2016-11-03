using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.Mvc.Models
{
    public class AmortizacionInputModel
    {
        public double Prestamo { get; set; }

        public double Pie { get; set; }

        public double Tasa { get; set; }

        public int Plazo { get; set; }

        public double Mensual { get; set; }


        public List<AmortizacionUnitaria> Amortizaciones { get; set; }

        public AmortizacionInputModel()
        {
            Amortizaciones = new List<AmortizacionUnitaria>();
        }
    }
}