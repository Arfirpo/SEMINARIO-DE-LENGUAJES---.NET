

namespace Teoria7;

class Moto : Automotor, IImprimible
{
  public Moto(String marca)
  {
    this.Marca = marca;
  }
  public void imprimir()
  => Console.WriteLine($"Soy una moto {Marca}");
}