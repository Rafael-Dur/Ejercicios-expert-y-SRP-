using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimirTablero.Print();
            Tablero.LeerTablero();
            Celula.IsLive();
        }
    }
}
