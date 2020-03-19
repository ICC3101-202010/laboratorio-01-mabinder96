using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio1
{
    class Persona //Creo la clase persona
    {
        private string nombre;
        private string apellido;
        private string elegido;

        public Persona(string nombre, string apellido) //Creo el constructor de la clase persona que recibe un nombre y apellido
        {
            this.nombre = nombre;
            this.apellido = apellido;

        }

        public int Lanzar() //Creo el método lanzar, el que imprime el número y además, me retorna lo que corresponde
        {
            Random aleatorio = new Random(); //Creo instancia de Random 
            int numero = aleatorio.Next(0, 3);

            return numero;
        }
        public string Cambio(int numero)
            {
            switch (numero) //Establezco que significa cada número
                {
                case 0: elegido= "piedra" ; break;
                case 1: elegido = "papel"; break;
                case 2: elegido = "tijera"; break;
                 }
            return elegido;
            }
        
        
        public string Getnombre()
        {
            return nombre;
        }

        public string Getapellido()
        {
            return apellido;
        } 

    }
}

