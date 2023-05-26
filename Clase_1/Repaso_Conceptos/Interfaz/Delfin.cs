using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Conceptos.Interfaz
{
    public class Delfin : ITrucos
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
