using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1SumaConsecutiva.Servicios
{
    internal class SumaImplementacion : SumaInterfaz
    {

        public void sumaYMuestra(int numeroPedido)
        {
            int aux = 0;
            
            for (int i = 1; i <= numeroPedido; i++)
            {              
                    aux = aux + i;

                if (i == numeroPedido)
                    Console.Write(i+" = "+ aux);
                else Console.Write(i+" + ");
            }

        }



    }
}
