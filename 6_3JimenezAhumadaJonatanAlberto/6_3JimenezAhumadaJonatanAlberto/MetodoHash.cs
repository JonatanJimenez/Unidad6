using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3JimenezAhumadaJonatanAlberto
{
    class MetodoHash
    {
        string[] arreglo;// se crea un arreglo llamado arreglo
        public string[] Arreglo { get; set; }// se crea una propiedad
        int tamaño;// se crea una variable de tipo entero llamada tamaño

        public MetodoHash(int tamaño)// se crea un constructor de la clase MetodoHash donde le mandamos de parametro la longitud del arreglo
        {
            this.tamaño = tamaño;// se guarda en la variable tamaño el parametro llamado de la misma forma
            arreglo = new string[tamaño];// se crea el arreglo de longitud indicada en el parametro
            for (int i = 0; i < arreglo.Length; i++)// se utiliza un for para llenar el arreglo 
            {
                arreglo[i] = "-1";// se guarda en cada posicion del arreglo un -1, esto es para que cada posicion del arreglo tenga ya un dato
            }
        }

        public void FuncionHash(string[] cadenaArreglo, string[] arreglop)// se crea un metodo void a cual le mandaremos como parametro el arreglo donde estaran los numeros que le ingresemos 
        {                                                                 // y como otro parametro el arreglo que se lleno con -1  
            for (int i = 0; i < cadenaArreglo.Length; i++)// se crea otro for para que se guarden los numeros del arreglo en distintos indices 
            {
                string elemento = cadenaArreglo[i];// se crea una variable llamada elemento a la cual se le da el valor de lo que contenga cadenaArreglo en la posicion i
                int IndiceArreglo = int.Parse(elemento) % 13;// se crea otra variable pero de tipo entero a la cual se le da el valor del elemento modulo 13 
                                                             // el 13 es porque es el numero primo mas cercano al tamaño del arreglo que se tiene
                Console.WriteLine("El indice es: {0} para el elemento {1}",IndiceArreglo, elemento);//se escribe el indice en el que quedo cada elemento del arreglo
                while (arreglo[IndiceArreglo] != "-1")// se crea un while que indica que mientras lo que contengo el arreglo en el indiceArreglo sea distinto a -1
                {
                    IndiceArreglo++;// se incrementa el indiceArreglo             
                    Console.WriteLine("Ocurrio una colision en el indice: {0} cambiar al indice: {1}",(IndiceArreglo - 1), IndiceArreglo);// se indica que hubo una colision y que se cambio a otro indice 
                    IndiceArreglo %= tamaño;// se guarda en IndiceArreglo lo que resulte del IndiceArreglo modulo tamaño
                }
                arreglo[IndiceArreglo] = elemento;//se guarda en el arreglo el elemento 
            }
        }

        public void Mostrar()// se crea este metodo para darle formato a la impresion de los indices y los numeros del arreglo
        {           
            for (int i = 0; i < 1; i++)// se crea un for donde se ejecutara una vez lo que esta dentro
            {             
                Console.WriteLine();// se da un salto de linea                
                for (int j = 0; j < 14; j++)// se crea un for que va desde 0 hasta 13, este for imprime los indices 
                {
                    if (j < 10)
                        Console.Write("| {0}  ", j);
                    else
                        Console.Write("| {0} ", j);
                }
                Console.WriteLine("|\n");
                for (int j = 0; j < 14; j++)// se crea otro for para imprimir los numeros del arreglo 
                {
                    if (arreglo[j] == "-1")
                        Console.Write("|  ");
                    else
                        Console.Write("| {0} ", arreglo[j]);
                }
                Console.WriteLine(" | \n");
            }
        }

        public string BuscarClave(string elemento)// se crea un metodo para buscar un numero en el arreglo 
        {
            int indiceArreglo = int.Parse(elemento) % 13;// se crea una variable a la que se le da el valor del elemento del arreglo modulo 13
            int contador = 0;// se crea un contador 
            while (arreglo[indiceArreglo] != "-1")// y mientras que el numero del arreglo sea distinto a -1 
            {
                if (arreglo[indiceArreglo] == elemento)// si el numeto del arreglo es igual al numero que se busca 
                {                    
                    Console.WriteLine("El elemento {0} fue encontrado en el indice {1}",elemento, indiceArreglo);// se imprime que el elemento que buscabas esta en tal indice
                    return arreglo[indiceArreglo];// regresa en numero del arreglo 
                }
                indiceArreglo++;// se incrementa el indice 
                indiceArreglo %= tamaño;// se guarda en indiceArreglo el indiceArreglo modulo tamaño
                contador++;// se incrementa el contador 
                if (contador > 13)//si el contador es mayor a 13, esto indica que nada mas esta dando vueltas en el arreglo buscando el numero 
                    break;// se le pone un break para que se detenga, ya que el numero que busca no se encuentra 
            }
            return null;// retorna un null
        }
    }
}
