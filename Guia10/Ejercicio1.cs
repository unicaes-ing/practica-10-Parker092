using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Guia10
{
    class Ejercicio1
    {
        public void ejer1()
        {
            int op;
            do
            {
                Console.WriteLine("=============================");
                Console.WriteLine(" 1 - Agregar Pais.");
                Console.WriteLine(" 2 - Mostrar Paises.");
                Console.WriteLine(" 3 - Buscar Pais.");
                Console.WriteLine(" 4 - Salir.");
                Console.WriteLine("=============================");
                op = validaciones("Seleccione una opccion: ",1, 4);
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        StreamWriter archivo = new StreamWriter(@"C:\Archivos\practica.txt", true);
                        Console.WriteLine("Introdusca el pais desea agregar: ");
                        archivo.WriteLine(Console.ReadLine());
                        archivo.Close();
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        StreamReader showTxt = new StreamReader(@"C:\Archivos\practica.txt");
                        string text;
                        text = showTxt.ReadToEnd();
                        Console.WriteLine(text);
                        showTxt.Close();
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        StreamReader showTxtl = new StreamReader(@"C:\Archivos\practica.txt");
                        string linea;
                        string buscar;
                        Console.WriteLine("Buscar Pais:");
                        buscar = Console.ReadLine();
                        do
                        {
                            linea = showTxtl.ReadLine();
                            if (linea != null)
                            {
                                if (linea.Equals(buscar))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(linea);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.WriteLine(linea);
                                }                              
                            }
                        } while (linea!=null);
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (op!=4);            
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
