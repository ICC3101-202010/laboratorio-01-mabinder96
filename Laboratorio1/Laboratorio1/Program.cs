using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)

        {
            Persona firstperson = new Persona("Bob", "Kunga"); //Creo a Bob Kunga
            Console.WriteLine("Ca chi pun"); //Inicio el juego
            int numero = firstperson.Lanzar();
            string correspondencia = firstperson.Cambio(numero);
            Console.WriteLine(firstperson.Getnombre()+ " " + firstperson.Getapellido() + " lanzaste el número " + numero + " y correspone a " + correspondencia + ".") ; //Utilizo el método en Bob Kunga
            Console.ReadKey();
        }
    }
}
  
 