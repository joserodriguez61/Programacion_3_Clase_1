using Capa_Acceso_Datos.Txt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Unitarias.Archivo
{
    [TestClass]

    public class Escritura_Txt_Test
    {

        [TestMethod]
        public void Escriba_En_TxT_ReturnTrue_Cuando_EscribeCorrectamente()
        {
            //Arrange
            Escritura_Txt escritura = new Escritura_Txt();
            string texto = "Hola";
            string ruta = "C:\\Users\\jmguk\\Documents\\LATINA\\PROFE\\2023-02\\Programación 3\\Clase 1\\Código\\Clase_2";
            string nombre = "Pruebas.txt";
            bool resultado_Esperado = true;

            //Act
            bool resultado_Obtenido = escritura.Escriba_En_TxT(texto, ruta, nombre);
           
            //Assert
            Assert.AreEqual(resultado_Esperado,resultado_Obtenido);
        }
    }
}
