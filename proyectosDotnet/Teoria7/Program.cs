using Teoria7;

IImprimible[] vector = [
  new Moto("Zanella"),
  new Empleado("Juan"),
  new Moto("Gilera")
];

foreach (var item in vector)
{
  item.imprimir();
}
