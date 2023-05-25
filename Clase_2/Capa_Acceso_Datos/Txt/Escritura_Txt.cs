
namespace Capa_Acceso_Datos.Txt
{
    public class Escritura_Txt
    {
        public Escritura_Txt()
        {
            
        }

        public bool Escriba_En_TxT(string texto, string ruta_De_Documento, string nombre_Documento) {
            try
            {
                //Inicializa el objeto de escritura
                using StreamWriter outputFile = new(Path.Combine(ruta_De_Documento, nombre_Documento), true);
                outputFile.WriteLine(texto);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
        
        }

    }
}
