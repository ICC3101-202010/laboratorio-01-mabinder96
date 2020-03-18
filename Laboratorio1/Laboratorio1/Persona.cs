using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio1
{
    class Persona //Creo la clase persona
    {

        public Persona(string nombre, string apellido)
        {
                
        }

        public void Lanzar()
        {
            Random aleatorio = new Random(); //Creo instancia de Random 
            int numero = aleatorio.Next(0, 3);
            Console.WriteLine("El numero elegido es: " + numero + ".");

            switch (numero)
            {
                case 0: Console.WriteLine("Haz elegido piedra."); break;
                case 1: Console.WriteLine("Haz elegido papel."); break;
                case 2: Console.WriteLine("Haz elegido tijera."); break;
            }

        }


    }

}

