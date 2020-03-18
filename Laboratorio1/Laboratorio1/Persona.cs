using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio1
{
    class Persona //Creo la clase persona
    {

        public Persona(string nombre, string apellido) //Creo el constructor de la clase persona que recibe un nombre y apellido
        {
                
        }

        public string Lanzar() //Creo el método lanzar, el que imprime el número y además, me retorna lo que corresponde
        {
            Random aleatorio = new Random(); //Creo instancia de Random 
            int numero = aleatorio.Next(0, 3);
            Console.WriteLine("El numero elegido es: " + numero + "."); //Imprimo el número generado por Random 
            string elegido=""; 
            switch (numero) //Establezco que significa cada número
            {
                case 0: elegido= "piedra" ; break;
                case 1: elegido = "papel"; break;
                case 2: elegido = "tijera"; break;
            }
            return elegido;
        }
    }
}

