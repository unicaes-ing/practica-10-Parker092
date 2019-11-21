using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Guia10
{
    class Ejercicio4 : Ejercicio3
    {
        /*  Crear un programa de acceso, para que el usuario ingrese por teclado la contraseña y la
            compare con la contraseña cifrada almacenada en el archivo texto del ejercicio anterior, que
            le permita intentarlo 3 veces, de lo contrario que impida el acceso al programa. */
        public void ejer4()
        {
            int n = 0;
            string clave1;
            StreamReader archivo = new StreamReader (@"C:\Archivos\encriptacion.txt");
            string clave = archivo.ReadLine();
            string comp = desencript(clave);
            archivo.Close();
            //encript();
            //desencript(clave);
            do
            {
                Console.Write("INGRESE SU CONTRASEÑA: ");
                clave1 = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(comp);
                //Console.WriteLine(encript(clave1));
                //desencript(clave);               
                //Console.WriteLine("");
                n++;
            } while (n!=3 && clave.Equals(desencript(clave1)));

            if (clave.Equals(clave1))
            {
                Console.WriteLine("CONTRASEÑA ACEPTADA, ACCESO GARANTIZADO");
            }
            else
            {
                if (clave!=clave1)
                {
                    Console.WriteLine("CONTRASEÑA CORRECTA, INICIANDO");
                }
                else
                {
                    if (n==3)
                    {
                        Console.WriteLine("INTENTOS AGOTADOS, ACCESO NEGADO");
                    }
                }
                
            }
            Console.WriteLine("\nPresione <ENTER> para continuar.");
            Console.ReadKey();
        }
    
    }
}
