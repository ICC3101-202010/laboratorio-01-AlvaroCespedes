using System;

namespace Laboratorio_1_AlvaroCespedes
{
    public class Persona
    {
        //VARIABLES
        int maquina = 0;
        int Humano = 0;
        public string Name;
        public string Secondname;
        Random aleatorio = new Random();
        public void Lanzar()
        {
            Console.WriteLine("CA CHI PUN!");
            for(int x = 0; x<3;x++)//Creo elif ciclo, (i++ = i+=1)
            {
                Console.WriteLine("Ingrese 0 para piedra");
                Console.WriteLine("Ingrese 1 para papel");
                Console.WriteLine("Ingrese 2 para tijera");
                if (maquina== 0 && Humano == 2)
                {
                    Console.WriteLine("Gana Maquina");
                }
                else
                    {
    
                    }
                if (maquina == 0 && Humano == 1)
                {
                    Console.WriteLine("Gana Humano");
                }
                if (maquina == 1 && Humano = 2)
            }

        }
    }
}
