using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheroTxt01
{
    internal class Invitados
    {
        public static void CrearInvitados()
        {
            int invitados = 0;
            int indice; 

            Console.WriteLine("¿Cuantos invitados asistiran?: ");
            invitados = Convert.ToInt32(Console.ReadLine());

            StreamWriter sw = null;
            sw = File.CreateText("invitados.txt");

            for (indice = 0; indice < invitados; indice++ )
            {
                
                Console.Write($"Nombre del {indice + 1} invitado: ");
                sw.WriteLine($"Nombre: {Console.ReadLine()}");
                Console.Write($"Apellidos del {indice + 1} invitado: ");
                sw.WriteLine($"Apellidos: {Console.ReadLine()}");

                
            }

            sw.Close();

        }

        internal static void MostrarInvitados()
        {
            StreamReader sr = null;
            string linea;

            sr = File.OpenText("invitados.txt");

            while ((linea = sr.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }

            sr.Close();
        }

    }
}
