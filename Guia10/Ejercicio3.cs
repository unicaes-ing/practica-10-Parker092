using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Guia10
{
    class Ejercicio3
    {
        /* Elaborar un programa que capture por teclado una contraseña de 7 a 20 caracteres de
        longitud y que la almacene de manera cifrada en un archivo de texto. 
        (Nota: escriba su propio algoritmo para cifrar la contraseña, por ejemplo: 
        puede hacer uso de Replace para sustituir algunos
        caracteres por otros) */

        //Diego Palacios Noviembre 2019
        public void ejer3()
        {
            string clave;            
            do
            {
                Console.WriteLine("Ingrese su contraseña: ");
                clave = Console.ReadLine();
            } while (clave.Length <7 || clave.Length >20);           
            //clave encriptada
            Console.WriteLine("\nEncriptacion: "+ encript(clave));
            //clave desencriptada
            Console.WriteLine("\nClave: "+ desencript(clave));
            //almacenar en txt
            StreamWriter archivo = new StreamWriter(@"C:\Archivos\encriptacion.txt", true);
            archivo.WriteLine(encript(clave));
            archivo.Close();
            Console.WriteLine("La clave ha sido ENCRIPTADA y ALMACENADA con exito.");
            Console.WriteLine("\nPresione <ENTER> para continuar");
            Console.ReadKey();
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
        //Encriptar
        #region
        public string encript(string clave)
        {
            string encriptado = string.Empty;
            Byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(clave);
            encriptado = Convert.ToBase64String(encriptar);
            return encriptado;
        }
        #endregion
        //Desencriptar
        #region
        public string desencript(string clave)
        {
            string desencriptado = string.Empty;
            byte[] desencriptar = Convert.FromBase64String(encript(clave));
            desencriptado = System.Text.Encoding.Unicode.GetString(desencriptar);
            return desencriptado;
        }
        #endregion
    }
}
