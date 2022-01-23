using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionFinal.Dto
{
    public class CategoriaDto
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public bool Habilitado { get; set; }
    }
}
