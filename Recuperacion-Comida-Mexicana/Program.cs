using System;

namespace Recuperacion_Comida_Mexicana
{
    class Program
        {
              public class NewBaseType
        {
            public static void Main(string[] arg)
            {

                var menu = new Tacos();
                Console.WriteLine("$" + menu.CalculoTotalPrecio());

                var pedido1 = new Pollo(menu);
                Console.WriteLine("$" + pedido1.CalculoTotalPrecio());

                var pedido2 = new Carne(pedido1);
                Console.WriteLine("$" + pedido2.CalculoTotalPrecio());

                Console.WriteLine();
            }
        }
    }
}

