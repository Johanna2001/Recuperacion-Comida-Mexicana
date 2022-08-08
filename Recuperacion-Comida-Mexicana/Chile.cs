using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_Comida_Mexicana
{
    class Chile : Decorador 
    {
        public Chile(OrdenBase orden) : base(orden)
        {
        }

        public override double CalculoTotalPrecio()
        {
            var Adiccion = base.CalculoTotalPrecio() + 0.90;
            return Adiccion;
        }
    }
}
