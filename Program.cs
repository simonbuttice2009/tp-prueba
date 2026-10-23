// See https://aka.ms/new-console-template for more information
using Company.ClassLibrary1;
using var context = new AppDbContext();
var servicio = new ProductoService(context);

servicio.Agregar("Mouse", 13000);
servicio.Agregar("Teclado", 20000);
servicio.Agregar("Auris", 6767);

Console.WriteLine("------------Lista de Productos------------");

foreach (var p in servicio.ObtenerTodos())
{
    Console.WriteLine($"{p.Id} - {p.Nombre} - {p.Precio}");
}