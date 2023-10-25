using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1SumaConsecutiva.Servicios
{
    internal class PedirImplementacion : PedirInterfaz
    {

        public int pedirNumero() 
        {
            Console.WriteLine("Escriba un nuemro entero mayor a 0");
            int numeroPedido = Convert.ToInt32(Console.ReadLine());
            return numeroPedido; 
        }

    }
}
