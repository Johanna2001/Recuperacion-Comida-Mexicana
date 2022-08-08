using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_Comida_Mexicana
{
   public class Burritos:OrdenBase
    {
        public override double CalculoTotalPrecio()
        {
            Console.Write("El valor del burrito es: ");
            var menu2 = 2.00;
            return menu2;
        }
    }
}
