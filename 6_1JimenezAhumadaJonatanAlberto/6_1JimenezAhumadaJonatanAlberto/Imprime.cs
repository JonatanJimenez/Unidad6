using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1JimenezAhumadaJonatanAlberto
{
    class Imprime
    {
        public void Imprimir()
        {
            Operacion1 operacion1 = new Operacion1();// se crea un objeto de tipo Operacion1 
            Operacion2 operacion2 = new Operacion2();//se crea un objeto de tipo Operacion2

            int[] array1 = new int[] { 45, 34, 98, 3, 6, 3, 8, 4, 7 };// se crea un arreglo 
            double[] array2 = new double[] { 1.2, 3, 4.5, 7.1, 8, 9, 15, 18.9, 20.6 };// se crea un arreglo 

            Console.WriteLine("Ejemplo 1");// se escribe lo que esta entre comillas   
            Console.WriteLine("Busqueda Secuencial");// se escribe lo que esta entre comillas   
            Console.WriteLine("\nLista de numeros en el arreglo:");// se escribe lo que esta entre comillas   
            foreach (var item in array1)// se crea un foreach que me sirve para imprimir los numeros 
            {
                Console.Write("{0} ", item);// se escribe lo que esta entre comillas (numeros)    
            }

            Console.WriteLine("\nQue numero desea buscar: ");// se escribe lo que esta entre comillas   
            int resp1 = int.Parse(Console.ReadLine());// guarda el numero a buscar 
            operacion1.BusquedaSecuencial(array1, resp1);// se manda llamar al metodo 
            Console.ReadKey();// se detiene la ejecucion del programa 
            Console.Clear();//se limpia la consola 

            Console.WriteLine("Busqueda Secuencial en un arreglo ordenado de forma ascendente");// se escribe lo que esta entre comillas   
            Console.WriteLine("\nLista de numeros en el arreglo: ");// se escribe lo que esta entre comillas   
            foreach (var item in array2)// se crea un foreach que me sirve para imprimir los numeros 
            {
                Console.Write("{0} ", item);// se escribe lo que esta entre comillas (numeros) 
            }

            Console.WriteLine("\nQue numero desea buscar: ");// se escribe lo que esta entre comillas   
            double resp2 = double.Parse(Console.ReadLine());// guarda el numero a buscar 
            operacion1.BusquedaSec(array2, resp2);// se manda llamar al metodo 
            Console.ReadKey();// se detiene la ejecucion del programa 
            Console.Clear();//se limpia la consola 

            Console.WriteLine("Ejemplo 2");// se escribe lo que esta entre comillas   
            Console.WriteLine("Busqueda Secuencial");// se escribe lo que esta entre comillas   
            Console.WriteLine("\nLista de numeros en el arreglo: ");// se escribe lo que esta entre comillas   
            foreach (var item in array2)// se crea un foreach que me sirve para imprimir los numeros 
            {
                Console.Write("{0} ", item);// se escribe lo que esta entre comillas   
            }

            Console.WriteLine("\nQue numero desea buscar: ");// se escribe lo que esta entre comillas   
            int resp3 = int.Parse(Console.ReadLine());// guarda el numero a buscar 
            operacion2.BusquedaSecuencial(array2, resp3);// se manda llamar al metodo 
            Console.ReadKey();// se detiene la ejecucion del programa 
        }
    }
}
