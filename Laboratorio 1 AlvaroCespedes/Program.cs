using System;

namespace Laboratorio_1_AlvaroCespedes
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Bob", "Kunga");
            Console.WriteLine(persona._throw());
        }
    }
}

