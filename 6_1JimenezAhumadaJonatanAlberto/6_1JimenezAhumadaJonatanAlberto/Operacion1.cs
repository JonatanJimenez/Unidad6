using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1JimenezAhumadaJonatanAlberto
{
    class Operacion1
    {               
        public bool BusquedaSecuencial(int[] array, int dato)// se crea un metodo de tipo booleano
        {
            int posicion = 0; // variable entera llamada posicion inicializada en cero
            bool encontrado = false;// variable de tipo bool llamada encontrado igualado a false 

            while (posicion < array.Length && !encontrado)// mientras que la posicion sea menor que el tamaño del arreglo y sea diferente a encontrado
            {
                if (array[posicion] == dato)// si el numero del arreglo es igual al numero buscado 
                {
                    encontrado = true;// se iguala encontrado a true 
                    Console.WriteLine("El numero {0} si se encuentra en el arreglo, y esta en la posicion {1}",dato,posicion + 1);// se imprime lo que esta entre comillas 
                }               
                else// si no
                {
                    posicion += 1;// se incrementa en 1 la posicion               
                }                
            }           
            if (encontrado == false)// si encontrado es igual a false 
            {
                Console.WriteLine("El numero {0} no se encuentra en el arreglo", dato);// se imprime lo que esta entre comillas 
            }            
            return encontrado;// se regresa encontrado             
        }

        public bool BusquedaSec(double[] array, double numBuscar)// se crea este metodo booleano para hacer una busqueda secuencial en un arreglo ordenado 
        {
            int pos = 0;// variables de tipo entero 
            bool encontrado = false, parar = false;// variables booleanas 
            
            while (pos < array.Length && !encontrado && !parar)// mientras que la posicion sea menor al tamaño del arreglo y sea diferente a enconttrado y diferente a parar 
            {
                if (array[pos] == numBuscar)// si el numero del arreglo es igual al buscado 
                {
                    encontrado = true;// se iguala a true la variable encontrado 
                    Console.WriteLine("El numero {0} si se encuentra en el arreglo, y esta en la posicion {1}", numBuscar, pos + 1);// se escrbe lo que esta entre comillas 
                }

                else// si no 
                {
                    if (array[pos] > numBuscar)// se el numero del arreglo es mayor al que se busca 
                    {
                        parar = true;// se iguala parar a true 
                        Console.WriteLine("El numero {0} no se ha encontrado y se detuvo en la posicion {1} por que el numero {2} es mayor ",numBuscar, pos + 1, array[pos]);// se escribe lo que esta entre comillas 
                    }
                    else// si no 
                    {
                        pos += 1;// se incrementa en uno la posicion                        
                    }
                }
            }            
            return encontrado;// regresa encontrado
        }
    }
}
