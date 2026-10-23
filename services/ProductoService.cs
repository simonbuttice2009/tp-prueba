using System;

namespace Company.ClassLibrary1;

public class ProductoService
{
    private readonly ProductoService _context
    {
        _context = Context;
    }
    public void Agregar (string Nombre, decimal Precio)
    {
        Nombre = Nombre,
        Precio = precio
    };
    _context.Productos.Add(producto)
    _context.SaveChanges ();
}
public list<Producto> ObtenerTodos()
{
    return _context.Productos.Tolist();
}

