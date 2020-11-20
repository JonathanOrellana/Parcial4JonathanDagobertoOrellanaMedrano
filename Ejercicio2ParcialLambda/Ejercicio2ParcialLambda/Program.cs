using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2ParcialLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegado dlg = new Delegado();
            string respuesta;
            double total,acum=0,totaldesc;
            Console.WriteLine("Bienvenido a Super Selectos ingrese (si) para continuar ");
            respuesta = Console.ReadLine().ToUpper();
            Console.WriteLine("----------------------------------------------------------");
            while (respuesta=="SI")
            { 

                Console.WriteLine("Ingrese el precio del producto ");
                total =Convert.ToDouble(Console.ReadLine());
                acum = acum + total;
                Console.WriteLine("Quiere ingresar mas productos?(ingrese no para salir/Cualquier si para continuar ) ");
                respuesta = Console.ReadLine().ToUpper();
            }
            total delegadodesc = dlg.desc;
            Console.WriteLine("El descuento a efectuar seria: $"+ delegadodesc(acum));
            totaldesc = acum - delegadodesc(acum);
            Console.WriteLine("El resultado con el descuento aplicado seria: $" + totaldesc);
            Console.ReadKey();
        }
    }
}
