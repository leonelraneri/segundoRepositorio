using System;
using System.Collections.Generic;
using System.Collections;
namespace tpPila
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tarea 1: Crea un programa que pida al usuario 6 números enteros y luego los muestre en orden contrario,
                utilizando una pila. */



            /*  Stack miPila = new Stack();
              Console.WriteLine("ingrese un numero");

              int ingreso = 0;
              int numeroIngresado;
              int numero;

              while (ingreso <= 5)
              {
                  numeroIngresado = System.Convert.ToInt32(Console.ReadLine());
                  miPila.Push(numeroIngresado);
                  ingreso = ingreso + 1;

              }


              for (byte i = 0; i < 6; i++)
              {
                  numero = (int)miPila.Pop();
                  Console.WriteLine(numero);
              } */

            /* Tarea 2: Crea un programa que pida al usuario 6 números reales de doble precisión, los guarde en una cola
               y luego los muestre en pantalla.*/

            Queue miCola = new Queue();
            Console.WriteLine("Ingrese un numero de doble precision");

            int ingreso = 0;
            double numeroIngresado;
            double numero;

            while (ingreso <= 5)
            {
                numeroIngresado = System.Convert.ToDouble(Console.ReadLine());
                miCola.Enqueue(numeroIngresado);
                ingreso = ingreso + 1;
            }
            for (byte i = 0; i < 6; i++)
            {
                numero = (double)miCola.Dequeue();
                Console.WriteLine(numero);
            }



           // Tarea 3: Crea un programa que pida frases al usuario, hasta que introduzca una frase vacía.En ese momento,mostrará todas las frases que se habían introducido.



              /* List<String> frase = new List<string>();

               Console.WriteLine("ingrese una frase");

               String ingreso = null;

               while (ingreso!="")
               {
                   ingreso = Console.ReadLine();
                   frase.Add(ingreso);

               }
               Console.WriteLine("frases introducidas :");

               foreach (String elemento in frase)
               { 
                   Console.WriteLine(elemento);
               }*/


        }








    }
    }

