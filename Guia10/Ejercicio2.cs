using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Guia10
{
    class Ejercicio2
    {
        public string[] pais;
        public void ejer2()
        {
            int op, n;
            do
            {
                Console.WriteLine("=============================");
                Console.WriteLine(" 1 - Agregar Paises.");
                Console.WriteLine(" 2 - Mostrar Paiseses.");
                Console.WriteLine(" 3 - Buscar Pais.");
                Console.WriteLine(" 4 - Salir.");
                Console.WriteLine("=============================");
                op = validaciones("Seleccione una opccion: ", 1, 4);
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        StreamWriter archivo = new StreamWriter(@"C:\Archivos\arregloUni.txt", true);
                        Console.WriteLine("Cuantos paises desea agregar?");
                        n = validaciones("Maximo 10",1, 10);
                        pais = new string[n];
                        for (int j = 0; j < pais.Length; j++)
                        {
                            Console.WriteLine("Pais N° {0}", j+1);
                            pais[j] = Console.ReadLine();
                        }
                        string txt = string.Join(",", pais);
                        archivo.Write(txt);
                        archivo.Close();
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        StreamReader showTxt = new StreamReader(@"C:\Archivos\arregloUni.txt");
                        string text;
                        text = showTxt.ReadToEnd();
                        //Console.WriteLine(text);
                        pais = text.Split(',');
                        showTxt.Close();
                        int i = 1;
                        Console.WriteLine("Lista de hombres almacenados: \n");
                        foreach (string item in pais)
                        {
                            Console.WriteLine("Nombre {0}: {1}",i,item);
                            i++;
                        }
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        StreamReader showTxtl = new StreamReader(@"C:\Archivos\arregloUni.txt");
                        string linea;
                        string buscar;
                        Console.WriteLine("Buscar Pais:");
                        buscar = Console.ReadLine();
                        i = 1;
                        do
                        {
                            linea = showTxtl.ReadLine();
                            if (linea != null)
                            {
                                foreach (string item in pais)
                                {
                                    if (item.Equals(buscar))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Nombre {0}: {1}", i, item);
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nombre {0}: {1}", i, item);
                                    }
                                    
                                    i++;
                                }
                            }
                        } while (linea != null);
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
            } while (op != 4);
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
