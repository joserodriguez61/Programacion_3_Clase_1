﻿
namespace Repaso_Conceptos.Interfaz
{
    public class Perro : ITrucos
    {
        public void EscribeSinImplementacions(string sonido)
        {
            Console.WriteLine(sonido);
        }

        public void Saltar()
        {
            Console.WriteLine("Salta");
        }
    }
}
