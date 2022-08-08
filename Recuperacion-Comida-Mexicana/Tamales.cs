using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_Comida_Mexicana
{
    class Tamales:OrdenBase
    {
        public override double CalculoTotalPrecio()
        {
            Console.Write("El valor del tamal es: ");
            var menu1 = 3.10;
            return menu1;
        }
    }
}
