
namespace Repaso_Conceptos.Polimorfismo
{
    public class Triangulo : Figura
    {
        private int _lados =3;
        private double _base;
        private double _altura;
        public Triangulo()
        {
            
        }
        public Triangulo(double _base, double _altura)
        {
            this._base = _base;
            this._altura = _altura;
        }
        public override double CalculeArea()
        {

            double area = (_base * _altura) / 2;
            return area;

            //return (_base * _altura) / 2;

        }
        public void DefineBase(double _base) { 

            this._base = _base;
        
        }

        public double ObtengaBase() {
            return this._base;
        }

        public void DefineAltura(double _altura) { 
            this._altura = _altura;
        }

        public double ObtengaAltura() {
            return this._altura;
        }
    }
}
