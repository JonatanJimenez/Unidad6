using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1JimenezAhumadaJonatanAlberto
{
    class Operacion2
    {
        public void BusquedaSecuencial(double [] array, double dato)// se crea un metodo de tipo void, que me pide como parametros un arreglo y un dato 
        {
            bool existe = false;// se declara una variable de tipo bolleana igualada a false 
            for (int i = 0; i < array.Length; i++)// se crea un for que va desde  0 hasta un numero menor a la longitud del arreglo 
            {
                if (array[i] == dato)// si el numero del arreglo es igual al que se busca 
                {
                   existe = true;// se iguala existe a true 
                   Console.WriteLine("el numero {0} si existe, en la posicion {1} ",dato, (i + 1));// se escribe lo que esta entre comillas                 
                }                
            }  

            if (existe == false)// si existe es igual a false 
            {
               Console.WriteLine("el numero {0} no existe",dato); // se escribe lo que esta entre comillas   
            }
        }
    }
}
