using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio1
{
    class Persona //Creo la clase persona
    {
        private string nombre; //Creo el atributo nombre
        private string apellido; //Creo el atributo apellido
        private string elegido; //Creo el atributo elegido

        public Persona(string nombre, string apellido) //Creo el constructor de la clase persona que recibe un nombre y apellido
        {
            this.nombre = nombre;
            this.apellido = apellido;

        }

        public int Lanzar() //Creo el método lanzar, el que retorna el número random
        {
            Random aleatorio = new Random(); //Creo instancia de Random 
            int numero = aleatorio.Next(0, 3);

            return numero;
        }
        public string Cambio(int numero)
            {
            switch (numero) //Creo método cambio, que retorna lo elegido
                {
                case 0: elegido= "piedra" ; break;
                case 1: elegido = "papel"; break;
                case 2: elegido = "tijera"; break;
                 }
            return elegido;
            }
        
        
        public string Getnombre() //Creo método Getnombre, que retorna el nombre 
        {
            return nombre;
        }

        public string Getapellido() //Creo método Getapellido, que retorna el apellido
        {
            return apellido;
        } 

    }
}

