using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Guia10
{
    class Program
    {
        //Diego Palacios Noviembre - 2019
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("========== GUIA 10 ==========");
                Console.WriteLine(" 1 - Ejercicio 1.");
                Console.WriteLine(" 2 - Ejercicio 2.");
                Console.WriteLine(" 3 - Ejercicio 3.");
                Console.WriteLine(" 4 - Ejercicio 4.");
                Console.WriteLine(" 5 - Salir.");
                Console.WriteLine("=============================");
                op = validaciones("Seleccione una opccion: ", 1, 5);
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1 a = new Ejercicio1();
                        a.ejer1();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2 b = new Ejercicio2();
                        b.ejer2();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3 c = new Ejercicio3();
                        c.ejer3();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Ejercicio4 d = new Ejercicio4();
                        d.ejer4();
                        Console.Clear();
                        break;
                }
            } while (op!=5);
            
        }
        //Validacio
        #region
        static int validaciones(string men, int lim1, int lim2)
        {
            bool esInt;
            int nOP;
            do
            {
                Console.WriteLine(men);
                esInt = int.TryParse(Console.ReadLine(), out nOP);
            } while (esInt == false || nOP < lim1 || nOP > lim2);
            return nOP;
        }
        #endregion
    }
}
