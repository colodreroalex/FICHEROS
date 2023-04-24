using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheroTxt01
{
    internal class GFicheros
    {
        public static void CrearFichero()
        {
            //RECURSOS
            StreamWriter sw = null;

            //creacion fichero txt
            sw = File.CreateText("alumno.txt");

            //Agregar info
            Console.Write("Nombre: ");
            sw.WriteLine($"Nombre: {Console.ReadLine()}");
            Console.Write("Estudios: ");
            sw.WriteLine($"Estudios: {Console.ReadLine()}");
            Console.Write("Ciudad: ");
            sw.WriteLine($"Ciudad: {Console.ReadLine()}");


            //Cierre del StreamWriter
            sw.Close();
        }

        public static void MostrarFichero()
        {
            //RECURSO
            StreamReader sr = null;

            //Abrir fichero
            sr = File.OpenText("alumno.txt");

            //Lectura del fichero
            Console.WriteLine("");
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());

            //Cierre del StreamReader
            sr.Close();
        }
    }
}
