using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2JimenezAhumadaJonatanAlberto
{
    class Operacion1
    {
        public bool BusquedaBinaria(int[] arreglo, int item)// se crea un metodo de tipo booleano llamado BusquedaBinaria 
        {
            int primerNum = 0;// se crea una variable llamada primerNum
            int ultimoNum = arreglo.Length - 1;// se crea otra variable llamada ultimoNum con valor de la longitud del arreglo -1 
            bool encontrado = false;// se crea una variable de tipo booleana llamado encontrado con valor de false 

            while (primerNum <= ultimoNum && !encontrado)// mientras el primerNum sea menor igual al uktimoNum y sea distinto de encontrado
            {
                int medio = (primerNum + ultimoNum) / 2;// se crea una variable de tipo entero llamado medio a la cual se le da el valor de la mitad del arreglo 
                if (arreglo[medio] == item)// se crea un if que indica que si el numero de la posicion de enmedio es igual al item 
                {
                    encontrado = true;// encontrado se cambia a true 
                    Console.WriteLine("El numero {0} si se encuentra en el arreglo, y esta en la posicion {1}", item, medio);// y se imprime en pantalla que el numero se encontro 
                }
                else
                {
                    if (item < arreglo[medio]) // si no se crea un if que indica que si el item es menor al numero de la mitad del arreglo                   
                        ultimoNum = medio - 1; // se le da el valor del medio - 1 a la variable ultimoNum
                    else                    
                        primerNum = medio + 1; // si no se le asigna el valor de medio + 1 al primerNum 
                }
            }
            if (encontrado == false) // si encontrado al ultimo resulta ser false            
                Console.WriteLine("El numero {0} no se encuentra en el arreglo", item); // se imprime que el numero que se busca no esta en el arreglo           
            return encontrado;// retorna encontrado 
        }
    }
}
