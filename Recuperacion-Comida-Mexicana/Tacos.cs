using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_Comida_Mexicana
{
    class Tacos: OrdenBase 
    {
        public override double CalculoTotalPrecio()
        {
            Console.Write("El valor del taco es: ");
            var menu3 = 2.50;
            return menu3;
        }
    }
}
