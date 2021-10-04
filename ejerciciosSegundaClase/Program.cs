using System;

namespace ejerciciosSegundaClase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ejercicio 1:Crea un programa que pida al usuario su identificador y su contraseña (ambos
               numéricos), y no le permita seguir hasta que introduzca como identificador "1234" y como
               contraseña "1111".*/

            /* int identificador = 1234;
               int contraseña = 1111;
               int identificadorUsuario;
               int contraseñaUsuario;

              Console.WriteLine("Ingrese su contraseña");
               identificadorUsuario = System.Convert.ToInt32(System.Console.ReadLine());
               if (identificador == identificadorUsuario)
                {
                Console.WriteLine("Ingrese su contraseña");
                contraseñaUsuario = Convert.ToInt32(Console.ReadLine());
                if (contraseña == contraseñaUsuario)
                {
                    Console.WriteLine("DATOS CORRECTOS");
                }
                }
                else
                 {
                  Console.WriteLine("Dato ingresado incorrecto");
               }*/


            //ejercicio 2:Crea un programa calcule cuantas cifras tiene un número entero positivo

            /* int numeroUsuario;
               int cifras = 0;

               Console.WriteLine("Ingrese un numero");
               numeroUsuario = System.Convert.ToInt32(System.Console.ReadLine());
               while (numeroUsuario > 0)
               {
                 numeroUsuario = numeroUsuario / 10;
                    cifras++;
               }
               Console.WriteLine("El numero ingresado tiene {0} cifras", cifras); */


            //ejercicio 3:Crea un programa que muestre la tabla de multiplicar del 9.

            /* for (int n = 9; n <91;n = n+9)
               {
                 Console.WriteLine(n);
               }*/


            /*ejercicio 4:Crea un programa que contenga un bucle sin fin que muestre los números enteros
              positivos a partir del uno.*/

            /* for (int i = 0;i>=0 ; i++ )
             {
                 Console.WriteLine(i); 
             }*/


            /*ejercicio 5: Crea un programa que contenga un bucle sin fin que escriba "Hola " en pantalla, sin
              avanzar de línea. */

            /* for (int i = 0; i <= 0;)
                {
                 Console.Write("Hola!");
                } */


            /*ejercicio 6: ¿Cuál sería el resultado de las siguientes operaciones? a = 5; b = ++a; c = a++; b = b * 5;
              a = a * 2;.*/

            /*int a = 5, b = ++a, c = a++;

              Console.WriteLine("El valor de a es:{0}, de b es :{1}, y de c:{2}", a, b, c);
              a = a * 2; b = b * 5 ;
              Console.WriteLine("ahora el valor de a es :{0}, y de b:{1}", a, b); */

            /*ejercicio 7: ¿Cuál sería el resultado de las siguientes operaciones? a = 5; b = a + 2; b -= 3; c = -3; c *= 2;
              ++c; a *= b;.*/

            /* int a = 5, b = a + 2, c = -3;
               Console.WriteLine(" El valor de A es:{0}, el valor de B es:{1}, y el valor de C es:{2}", a, b, c);
               a *= b; b -= 3; c *= 2;
               Console.WriteLine("El valor de A ahora es de:{0}, el de B es:{1}, y el de C es de :{2}", a, b, c);
               ++c;
               Console.WriteLine("El valor de C ahora es de:{0}", c);*/

            //ejercicio 8: Crea un programa que pida una letra al usuario y diga si se trata de una vocal.

            /*char letra;
              bool esVocal;
              Console.WriteLine("Ingrese una letra");
              letra = System.Convert.ToChar(Console.ReadLine());

              esVocal = (letra == 'a') || (letra == 'e') || (letra == 'i') ||
               (letra == 'o') || (letra == 'u');
              if(esVocal)
              {
              Console.WriteLine("La letra ingresada es una vocal");
              }else
              {
              Console.WriteLine("La letra ingresada no es una vocal");
              }*/

            /*ejercicio 9: Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se
              debe introducir dos veces.Si las dos contraseñas no son iguales, se avisará al usuario y se le
              volverán a pedir las dos contraseñas.*/

            /*String nombre;
              String contrasena;
              String repetirContrasena;
              bool esCorrecta;
              Console.WriteLine("Ingrese su nombre");
              nombre = Console.ReadLine();
              Console.WriteLine("Ingrese su contraseña");
              contrasena = Console.ReadLine();
              Console.WriteLine("Repita la contraseña");
              repetirContrasena = Console.ReadLine();

              esCorrecta = (contrasena == repetirContrasena);
              if (esCorrecta)
              {
                Console.WriteLine("La contraseña es correcta");
              }
              else
              {
                Console.WriteLine("Contraseña incorrecta,vuelva a introducir la contraseña");
              }*/

            /*ejercicio 10: Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama
              "Martín", o bien le diga "No te conozco" si teclea otro nombre.*/

            String nombre;
            bool nombreCorrecto;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            nombreCorrecto = (nombre == "martin");
            if (nombreCorrecto)
            {
                Console.WriteLine("Hola Martin");
            }
            else
            {
                Console.WriteLine("No te conozco ");
            }



        }
    
    }
}
