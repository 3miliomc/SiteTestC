using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Mvc.Helpers;
using Xunit;
namespace Utilitario.Test
{
    public class Testing
    {
        [Fact]
        public void PassingTestMonths12()
        {
            var count = CalculadoraInteres.ObtenerAmortizacionAnual(2500000, 250000, 3.2f, 12, 12).Count;
            Assert.Equal(1, count);
        }
        
    }
}
