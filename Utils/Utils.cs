using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductoAppMovil2.Models;

namespace ProductoAppMovil2.Utils
{
    class Utils
    {
        public static List<Producto> listaProductos = new List<Producto>()
        {
            new Producto()
            {
                IdProducto = 1,
                Nombre = "Producto 1",
                Cantidad = 1,
                Descripcion = "producto 1"
            },
            new Producto()
            {
                IdProducto = 2,
                Nombre = "Producto 2",
                Cantidad = 2,
                Descripcion = "producto 2"
            },
            new Producto()
            {
                IdProducto = 3,
                Nombre = "Producto 3",
                Cantidad = 5,
                Descripcion = "producto 3"
            }
        };
    }
}
