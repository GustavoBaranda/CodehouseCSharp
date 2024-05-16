using System;

namespace PrimeraEtrega
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario
            {
                Id = 1,
                Nombre = "Gustavo",
                Apellido = "Baranda",
                NombreUsuario = "Gustavo",
                Contraseña = "contraseña123",
                Mail = "gustavo@coder.com.ar"
            };

            Producto producto = new Producto
            {
                Id = 1,
                Descripcion = "Jabon",
                Costo = 1000.00m,
                PrecioVenta = 2000.00m,
                Stock = 100,
                IdUsuario = usuario.Id
            };

            ProductoVendido productoVendido = new ProductoVendido
            {
                Id = 1,
                IdProducto = producto.Id,
                Stock = 5,
                IdVenta = 1
            };

            Venta venta = new Venta
            {
                Id = 1,
                Comentarios = "Venta online",
                IdUsuario = usuario.Id
            };
            
            Console.WriteLine("Información del usuario:");
            Console.WriteLine($"ID: {usuario.Id}, Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}");
            Console.WriteLine($"Nombre de usuario: {usuario.NombreUsuario}, Mail: {usuario.Mail}");

            Console.WriteLine("\nInformación del producto:");
            Console.WriteLine($"ID: {producto.Id}, Descripción: {producto.Descripcion}, Costo: {producto.Costo}");
            Console.WriteLine($"Precio de venta: {producto.PrecioVenta}, Stock: {producto.Stock}, ID de usuario: {producto.IdUsuario}");

            Console.WriteLine("\nInformación del producto vendido:");
            Console.WriteLine($"ID: {productoVendido.Id}, ID del producto: {productoVendido.IdProducto}, Stock: {productoVendido.Stock}");
            Console.WriteLine($"ID de la venta: {productoVendido.IdVenta}");

            Console.WriteLine("\nInformación de la venta:");
            Console.WriteLine($"ID: {venta.Id}, Comentarios: {venta.Comentarios}, ID de usuario: {venta.IdUsuario}");
            Console.ReadKey();
        }
    }

}
