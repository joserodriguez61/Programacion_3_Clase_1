using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Conceptos.Polimorfismo
{
    public class Cuadro : Figura
    {
        private int lados = 4;
        private double _lado ;

        public Cuadro(double _lados)
        {
            this._lado = _lados;
        }
        public override double CalculeArea()
        {
            return _lado * _lado;
        }
    }
}
