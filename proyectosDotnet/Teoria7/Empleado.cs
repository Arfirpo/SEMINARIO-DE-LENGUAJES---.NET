
namespace Teoria7;

class Empleado : Persona, IImprimible
{
   public Empleado(string nombre)
      => Nombre = nombre;
   public void imprimir()
      => Console.WriteLine($"Soy el empleado {Nombre}");
}