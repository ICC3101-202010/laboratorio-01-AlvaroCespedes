using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_AlvaroCespedes
{
    public class Persona
    {
        public string Name;
        public string Lastname;
        Random rnd = new Random();
        public int _throw()
        {
            Console.WriteLine("CA CHI PUN!");
            {
                int numero = rnd.Next(0, 3);
                return numero;
            }

        }
        public Persona(string name, string lastname)// Constructor. Tiene que tener el mismo nombre de la persona.
        {
            this.Name = name;
            this.Lastname = lastname;

        }
        //Persona persona1 = new Persona("Bob", "Kunga"); //He construido al constructor

    }
}
