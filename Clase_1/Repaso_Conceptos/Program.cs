using Repaso_Conceptos.Encapsulación;
using Repaso_Conceptos.Herencia;
using Repaso_Conceptos.Objeto;

//Objeto
Silla silla = new Silla();
Console.WriteLine(silla.respaldar);

//Encapsulación
Vehiculo vehiculo = new Vehiculo();

int llantas=0;
try
{
     llantas = Int16.Parse(Console.ReadLine());
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
    llantas  = 4;
}

vehiculo.DefinirLlantas(llantas);
Console.WriteLine(vehiculo.ObtenerLlantas());


//Herencia

Elefante elefante = new Elefante();
elefante.Comer();



