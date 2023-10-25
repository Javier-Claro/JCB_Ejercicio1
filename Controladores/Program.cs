using Ejercicio1SumaConsecutiva.Servicios;

namespace Ejercicio1SumaConsecutiva.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            PedirInterfaz pi = new PedirImplementacion();
            SumaInterfaz si = new SumaImplementacion();

            int numeroPedido = pi.pedirNumero();
            si.sumaYMuestra(numeroPedido);


        }

    }

}