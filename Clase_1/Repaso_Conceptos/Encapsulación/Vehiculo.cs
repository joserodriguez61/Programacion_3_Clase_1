
namespace Repaso_Conceptos.Encapsulación
{
    public class Vehiculo
    {
        private int llantas;
        private int puertas;
        public Vehiculo()
        {
            
        }

        public void DefinirLlantas(int _llantas) {

            llantas = _llantas;
        }

        public int ObtenerLlantas () {

            return llantas;
        }

    }
}
