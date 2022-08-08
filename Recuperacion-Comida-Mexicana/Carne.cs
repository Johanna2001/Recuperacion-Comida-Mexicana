using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_Comida_Mexicana
{
    class Carne : Decorador
    {
        public Carne(OrdenBase orden) : base(orden)
        {
        }

        public override double CalculoTotalPrecio()
        {
            var Adiccion = base.CalculoTotalPrecio() + 1.70;
            return Adiccion;
        }
    }
}
