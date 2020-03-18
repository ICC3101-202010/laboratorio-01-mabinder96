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
            Persona firstperson = new Persona("Bob", "Kunga");
            Console.WriteLine("Ca chi pun");
            firstperson.Lanzar();
            Console.ReadKey();
        }
    }



}
  
