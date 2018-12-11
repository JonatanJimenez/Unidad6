using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2JimenezAhumadaJonatanAlberto
{
    class Operacion2
    {
        public bool BusquedaBinariaRecu(int[] arreglo, int primerNum, int ultimoNum, int item)// se crea un metodo de tipo booleano
        {
            int medio = (primerNum + ultimoNum) / 2;// se crea una variable en la que se guarda el valor de la mitad del arreglo

            if (primerNum == ultimoNum && arreglo[medio] != item || arreglo[ultimoNum] < item || arreglo[primerNum] > item)// se crea este if para determinar si es que se encuentra el valor buscado en el arreglo
            {
                Console.WriteLine("El numero {0} no se encuentra en el arreglo", item);// si es que el valor no esta, se imprime que ese numero no se encuentra en el arreglo
                return false;//retorna false 
            }

            if (arreglo[medio] == item)// si el numero que se encuentra en la mitad del arreglo es igual al que buscamos 
            {
                Console.WriteLine("El numero {0} si se encuentra en el arreglo, y esta en la posicion {1}", item, medio);// se imprime que el numero se encuentra en el arreglo y en tal posicion 
                return true;// regresa true 
            }
            else// si no 
            {
                if (arreglo[medio] > item)// se crea un if que indica que si el numero de en medio es mayor al buscado              
                    return BusquedaBinariaRecu(arreglo, primerNum, medio - 1, item);// me regresa el metodo pero cambiando el parametro de ultimoNum al que se encuentra en el indice uno menos que el de enmedio 
                else // si no 
                    return BusquedaBinariaRecu(arreglo, medio + 1, ultimoNum, item);// se regresa el mismo metodo pero ahora cambia en valor de primerNum          
            }
        }
    }
}
