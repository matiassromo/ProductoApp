﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoAppMovil2.Models
{
    class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
    }
}
