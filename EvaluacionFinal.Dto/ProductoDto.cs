using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionFinal.Dto
{
    public class ProductoDto
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public bool Habilitado { get; set; }
    }
}
