using Repaso_Conceptos.Encapsulación;
using Repaso_Conceptos.Herencia;
using Repaso_Conceptos.Objeto;
using Repaso_Conceptos.Polimorfismo;


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

//Polimorfismo
Figura triangulo = new Triangulo(2.5,3);

double areaTriangulo = triangulo.CalculeArea();




Console.WriteLine(areaTriangulo);

Figura cuadro = new Cuadro(2);

double areaCuadro = cuadro.CalculeArea();


Console.WriteLine(areaCuadro);

Figura triangulo = new Triangulo(2.5, 3);
triangulo.Escribe("Triangulo");


