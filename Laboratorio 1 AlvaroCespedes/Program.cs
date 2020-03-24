using System;

namespace Laboratorio_1_AlvaroCespedes
{   
    public class Mainclass
    {
        public class Persona
        {
            public string Name;
            public string Secondname;
            Random rnd = new Random();
            public int Throw()
            {
                Console.WriteLine("CA CHI PUN!");
                for (int x = 0; x < 3; x++)//Creo elif ciclo, (i++ = i+=1)
                {
                    Console.WriteLine($"{rnd.Next(),15:NO}");
                }

            }
        }
    }
    
}
