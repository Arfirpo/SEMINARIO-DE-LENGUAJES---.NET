namespace Teoria6;

abstract class Automotor
{
  //public abstract void HacerMantenimiento();
  //public abstract DateTime FechaService { get; set; }
  //public abstract double PrecioDeVenta { get; }
  public string Marca { get; }
  private int _modelo;
  public virtual int Modelo
  {
    get => _modelo;
    protected set => _modelo = (value < 2005) ? 2005 : value;
  }
  public Automotor(string marca, int modelo)
  {
    Marca = marca;
    Modelo = modelo;
  }


  public virtual void Imprimir()
  => Console.WriteLine($"{Marca} {Modelo}");
}