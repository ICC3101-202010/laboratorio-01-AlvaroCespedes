using System;

namespace Laboratorio_1_AlvaroCespedes
{   
    public class  Mainclass
    {
        public class Persona
        {
            public string Name;
            public string Secondname;
            Random rnd = new Random();
            public int Throw()
            {
                Console.WriteLine("CA CHI PUN!");
                {
                    int var = rnd.Next(0, 3);
                    return var;
                }

            }
        }
    }
    
}
