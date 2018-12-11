using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3JimenezAhumadaJonatanAlberto
{
    class Program
    {
        static void Main(string[] args)
        {          
            Operacion operacion = new Operacion();// se crea un objeto de tipo Operacion 
            operacion.Imprimir();// se manda llamar al metodo de la clase Operacion
            Console.ReadKey();// se utiliza para detener la ejecucion del programa
        }
    }
}
