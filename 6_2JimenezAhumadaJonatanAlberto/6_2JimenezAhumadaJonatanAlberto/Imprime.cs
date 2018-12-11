using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2JimenezAhumadaJonatanAlberto
{
    class Imprime
    {
        public void Imprimir()// se crea este metodo llamado Imprimir 
        {
            Operacion1 operacion1 = new Operacion1(); // se crea un objeto de tipo Operacion1
            Operacion2 operacion2 = new Operacion2();// se crea un objeto de tipo Operacion2

            int[] array1 = new int[] { 2, 5, 8, 13, 26, 33, 48, 54, 67 };// se crean dos arreglos 
            int[] array2 = new int[] { 45, 54, 68, 73, 86, 93, 108, 114, 127 };

            Console.WriteLine("Ejemplo 1");  // se imprime lo que esta 
            Console.WriteLine("Busqueda Binaria");  // adentro de las 
            Console.WriteLine("\nLista de numeros en el arreglo:"); // comillas 
            foreach (var item in array1)// se crea un foreach que me imprime los numeros que estan en el arreglo numero 1 (array1)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\nQue numero desea buscar: ");  // se pregunta que numero se desea buscar 
            int resp1 = int.Parse(Console.ReadLine());// se guarda el numero en una variable 
            operacion1.BusquedaBinaria(array1, resp1);// se manda llamar al metodo BusquedaBinaria 
            Console.ReadKey();// se detiene la ejecucion del programa 

            Console.WriteLine("\nEjemplo 2");// se imprime lo que esta               
            Console.WriteLine("\nLista de numeros en el arreglo:");// entre comillas 
            foreach (var item in array2)// se crea un foreach para imprimir los numeros del arreglo numero 2 (array2)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\nQue numero desea buscar: ");// se pregunta que numero se desea buscar 
            int resp2 = int.Parse(Console.ReadLine()); ;// se guarda el numero en una variable 
            operacion1.BusquedaBinaria(array2, resp2);// se manda llamar al metodo BusquedaBinaria
            Console.ReadKey();// se detiene la ejecucion del programa 
            Console.Clear();// se limpia la consola 

            Console.WriteLine("Ejemplo 1");// se imprime lo que 
            Console.WriteLine("Busqueda Binaria con metodo recursivo");// se encuentra entre 
            Console.WriteLine("\nLista de numeros en el arreglo:");// comillas 
            foreach (var item in array1)// se imprime lo que esta en el arreglo numero 1 (array1)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\nQue numero desea buscar: ");// se pregunta que numero se desea buscar 
            int resp3 = int.Parse(Console.ReadLine());// se guarda el numero en una variable 
            operacion2.BusquedaBinariaRecu(array1,0,array1.Length -1, resp3);// se manda llamar al metodo de la clase Operacion2 donde se ultiliza una Busqueda Binaria de forma recursiva
            Console.ReadKey();// se detiene la ejecucion

            Console.WriteLine("\nEjemplo 2");// se imprime lo que esta 
            Console.WriteLine("\nLista de numeros en el arreglo:");// entre comillas 
            foreach (var item in array2)// se inprime el arreglo numero 2 
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\nQue numero desea buscar: ");// se pregunta que numero se desea buscar 
            int resp4 = int.Parse(Console.ReadLine());// se guarda el numero en una variable 
            operacion2.BusquedaBinariaRecu(array2,0,array2.Length-1, resp4);// se manda llamar al metodo de la clase Operacion2 donde se ultiliza una Busqueda Binaria de forma recursiva
            Console.ReadKey();// se detiene la ejecucion  
        }
    }
}
