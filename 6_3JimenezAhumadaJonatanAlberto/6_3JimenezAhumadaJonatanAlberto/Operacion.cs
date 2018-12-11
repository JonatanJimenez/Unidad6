using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3JimenezAhumadaJonatanAlberto
{
    class Operacion
    {
        public void Imprimir()
        {
            MetodoHash hash = new MetodoHash(14);// se crea un objeto de tipo MetodoHash 
            string[] elementos = { "22", "14", "70", "88", "73", "44", "33", "45", "92", "15", "34", "99", "12", "54" };// se crea este arreglo 
            hash.FuncionHash(elementos, hash.Arreglo);// se llama al metodo FuncionHash 
            hash.Mostrar();// se llama tambien al metodo Mostrar que imprime los indices y numeros del arreglo 

            Console.Write("Que numero desea buscar: ");// se crea una pregunta             
            string respuesta = Console.ReadLine();// variable que contiene la respuesta            
            string buscar = hash.BuscarClave(respuesta);// se crea una variable con en la cual guardamos lo que resulte de untilizar el metodo BuscarClave 
            if (buscar == null)// si buscar que es la variable es null               
                Console.WriteLine("El elemento {0} no se encuentra en la tabla",buscar);// se imprime en consola que el numero que buscaba no se encontro 
        }
    }
}
