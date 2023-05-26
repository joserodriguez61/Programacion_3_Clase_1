using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Conceptos.Interfaz
{
    public interface ITrucos
    {
        public void EscribeSinImplementacions(string sonido);
        public void Saltar();
        public void Escribe(string figura) { 
            Console.WriteLine(figura);        
        }
    }
}
